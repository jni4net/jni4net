#region Copyright (C) 2012 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as
published by the Free Software Foundation, either version 3
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using net.sf.jni4net.core;
using net.sf.jni4net.jni;

namespace net.sf.jni4net
{
    partial class J4NBridge
    {
        private const string netSfJni4netCoreJvmcorehooks = "net.sf.jni4net.core.JvmCoreHooks";
        private const string netSfJni4netCoreClrcorehooks = "net.sf.jni4net.core.ClrCoreHooks";

        public static AttachedJVM CreateJVM()
        {
            Assembly callingAssembly = Assembly.GetCallingAssembly();
            var setup = new BridgeSetup
            {
                JVMCoreLib = FindJVMCoreAssembly(callingAssembly),
                CLRCoreLib = FindCLRCoreAssembly(callingAssembly),
            };
            return CreateJVM(setup);
        }

        public static AttachedJVM CreateJVM(BridgeSetup setup)
        {
            return CreateBridge(setup, true, Assembly.GetCallingAssembly());
        }

        private static AttachedJVM CreateBridge(BridgeSetup setup, bool clrStart, Assembly caller)
        {
            if (isInitialized)
            {
                if (currentJVM.AttachedThread.JNIEnv==null)
                {
                    AttachCurrentThreadAsDaemon();
                    currentJVM.AttachedThread.JNIEnv = JNIEnv.threadJNIEnv;
                }
                return currentJVM;
            }

            lock (syncRoot)
            {
                LoadCoreLibs(setup, caller);

                string newJavaHome = setup.JavaHome;
                JNILib jvmDll=null;
                if (!JavaHomeFinder.FindJavaHome(setup, ref newJavaHome, ref jvmDll))
                {
                    throw J4NException.CantFindJavaHome();
                }
                if (newJavaHome != setup.JavaHome)
                {
                    setup.JavaHome = newJavaHome;
                    Logger.LogInfo("JavaHome set to " + setup.JavaHome);
                }
                if (setup.AutoLoadBaseDirecoryJars)
                {
                    setup.AddAllJarsClassPath(AppDomain.CurrentDomain.BaseDirectory);
                }

                var env = JoinOrCreateJvm(jvmDll, setup);

                currentSetup = new CurrentBridgeSetup(setup);

                DumpRuntimeInfoCLR();

                Registry.Init(env, setup);
                if (currentSetup.BindClrProxies)
                {
                    Registry.InitNative(env);
                }

                if (currentJVM.IsAttached)
                {
                    string jh = Registry.JvmCoreHooks.systemGetProperty("java.home");
                    if (jh != currentSetup.JavaHome)
                    {
                        currentSetup.JavaHome = jh;
                        Logger.LogWarn("Updated JAVA_HOME to " + jh);
                    }
                }
                isInitialized = true;
                if (clrStart)
                {
                    DumpRuntimeInfoJVM();
                }
                AppDomain.CurrentDomain.DomainUnload += CurrentDomain_DomainUnload;
            }
            return currentJVM;
        }

        private static void CurrentDomain_DomainUnload(object sender, EventArgs e)
        {
            Logger.LogInfo("Unloading AppDomain" + AppDomain.CurrentDomain.FriendlyName);
            if (currentJVM!=null)
            {
                currentJVM.Dispose();
            }
        }
        
        private unsafe static JNIEnv JoinOrCreateJvm(JNILib jvmDll, BridgeSetup setup)
        {
            var jvms = new IntPtr[0];
            JNIResult res = jvmDll.GetCreatedJavaVMs(out jvms);
            if (res != JNIResult.JNI_OK)
            {
                throw J4NException.CantCreateJvm(res);
            }

            if (jvms.Length > 0)
            {
                if (!setup.AllowJVMJoin)
                {
                    throw J4NException.ExistingJvm();
                }
                currentJVM = new AttachedJVM(new JVMInstance(jvms[0]), true);
            }
            else
            {
                var args = new JVMInitArgs
                {
                    version = JVMInitArgs.JNI_VERSION_1_4,
                };

                if (setup.ClassPathList.Length > 0)
                {
                    var sb = new StringBuilder("-Djava.class.path=");
                    foreach (string path in setup.ClassPathList)
                    {
                        sb.Append(path);
                        sb.Append(Path.PathSeparator);
                    }
                    sb.Length--;
                    setup.jvmOptions.Add(sb.ToString());
                }

                args.nOptions = setup.jvmOptions.Count;
                var opt = new JVMOption[args.nOptions];
                for (int i = 0; i < args.nOptions; i++)
                {
                    opt[i].optionString = Marshal.StringToHGlobalAnsi(setup.jvmOptions[i]);
                }
                if (args.nOptions>0)
                {
                    fixed (JVMOption* a = &opt[0])
                    {
                        args.options = a;
                        IntPtr pjvm;
                        IntPtr penv;
                        res = jvmDll.CreateJavaVM(out pjvm, out penv, args);
                        if (res != JNIResult.JNI_OK)
                        {
                            throw J4NException.CantCreateJvm(res);
                        }
                        currentJVM = new AttachedJVM(new JVMInstance(pjvm), false, new JNIEnv(penv));
                    }
                }
                else
                {
                    IntPtr pjvm;
                    IntPtr penv;
                    res = jvmDll.CreateJavaVM(out pjvm, out penv, args);
                    if (res != JNIResult.JNI_OK)
                    {
                        throw J4NException.CantCreateJvm(res);
                    }
                    currentJVM = new AttachedJVM(new JVMInstance(pjvm), false, new JNIEnv(penv));
                }
                for (int i = 0; i < args.nOptions; i++)
                {
                    Marshal.FreeHGlobal(opt[i].optionString);
                }
            }
            return currentJVM.AttachedThread.JNIEnv;
        }

        private static void LoadCoreLibs(BridgeSetup setup, Assembly caller)
        {
            if (setup.JVMCoreLib == null)
            {
                setup.JVMCoreLib = FindJVMCoreAssembly(caller);
            }
            else
            {
                var jvmCoreLib = setup.JVMCoreLib;
                if (!TryLoadAssembly(ref jvmCoreLib, netSfJni4netCoreJvmcorehooks))
                {
                    throw J4NException.CantFindJVMCoreAssembly();
                }
                setup.JVMCoreLib = jvmCoreLib;
            }

            if (setup.BindClrProxies)
            {
                if (setup.CLRCoreLib == null)
                {
                    setup.CLRCoreLib = FindCLRCoreAssembly(caller);
                }
                else
                {
                    var clrCoreLib = setup.CLRCoreLib;
                    if (!TryLoadAssembly(ref clrCoreLib, netSfJni4netCoreClrcorehooks))
                    {
                        throw J4NException.CantFindCLRCoreAssembly();
                    }
                    setup.CLRCoreLib = clrCoreLib;
                }
            }
        }

        private static string FindJVMCoreAssembly(Assembly caller)
        {
            return FindCoreAssembly(caller, netSfJni4netCoreJvmcorehooks, new[]
            {
                "jre-micro-j4n",
                "jre-mipro-j4n",
                "jre15-core-j4n",
                "jre16-core-j4n",
                "jre17-core-j4n",
            });
        }

        private static string FindCLRCoreAssembly(Assembly caller)
        {
            return FindCoreAssembly(caller, netSfJni4netCoreClrcorehooks, new[]
            {
                "mscorlib-micro-j4n",
                "mscorlib-mipro-j4n",
                "mscorlib-20-j4n",
                "mscorlib-40-j4n",
            });
        }

        private static string FindCoreAssembly(Assembly caller, string coreHooks, string[] libnames)
        {
            try
            {
                if (caller != null)
                {
                    foreach (var an in caller.GetReferencedAssemblies())
                    {
                        foreach (var libname in libnames)
                        {
                            if (an.FullName.StartsWith(libname))
                            {
                                var ln = an.FullName;
                                if (TryLoadAssembly(ref ln, coreHooks))
                                {
                                    Logger.LogInfo("Guessed CoreLib by loaded assemblies to " + ln);
                                    return ln;
                                }
                            }
                        }
                    }
                }

                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    var type = assembly.GetType(coreHooks, false);
                    if (type != null)
                    {
                        Logger.LogInfo("Guessed CoreLib by loaded assemblies to " + assembly.FullName);
                        return assembly.FullName;
                    }
                }

                foreach (var libname in libnames)
                {
                    var m = libname;
                    if (TryLoadAssembly(ref m, coreHooks))
                    {
                        return m;
                    }
                }
            }
            catch (Exception ex)
            {
                throw J4NException.CantFindCLRCoreAssembly(ex);
            }
            throw J4NException.CantFindCLRCoreAssembly();
        }

        private static bool TryLoadAssembly(ref string name, string coreHooks)
        {
            try
            {
                var mscj4n = AppDomain.CurrentDomain.Load(name);
                name = mscj4n.FullName;
                var type = mscj4n.GetType(coreHooks, false);
                return type != null;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
