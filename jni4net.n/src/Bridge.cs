#region Copyright (C) 2009 by Pavel Savara

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
using System.Security;
using System.Security.Permissions;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using Exception=System.Exception;

namespace net.sf.jni4net
{
    public static partial class Bridge
    {
        private static readonly Dictionary<Assembly, object> knownAssemblies = new Dictionary<Assembly, object>();
        private static bool jvmLoaded;
        internal static bool clrLoaded;
        private static BridgeSetup setup;
        private static readonly string homeDir;
        private static readonly string homeDll;

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        static Bridge()
        {
            homeDll = typeof(Bridge).Assembly.Location;
            homeDir = Path.GetDirectoryName(homeDll);
        }

        public static BridgeSetup Setup
        {
            get
            {
                return setup;
            }
        }

        public static IList<Assembly> KnownAssemblies
        {
            get
            {
                Assembly[] res=new Assembly[knownAssemblies.Count];
                knownAssemblies.Keys.CopyTo(res, 0);
                return res;
            }
        }

        public static JNIEnv CreateJVM(BridgeSetup setup)
        {
            if (jvmLoaded && setup.Verbose)
            {
                Console.Error.WriteLine("Already initilized");
                return JNIEnv.ThreadEnv;
            }
            Bridge.setup = setup;
            return CreateJVM();
        }

        public static void CreateJVM(params string[] options)
        {
            if (jvmLoaded)
            {
                throw new JNIException("Already initilized");
            }
            setup = new BridgeSetup(options);
            CreateJVM();
        }

        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution | SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SkipVerification)]
        [ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
        private static JNIEnv CreateJVM()
        {
            JavaVM jvm;
            JNIEnv env;
            try
            {
                JNI.CreateJavaVM(out jvm, out env, true, setup.JVMOptions);
            }

            catch (TypeInitializationException ex)
            {
                if (ex.InnerException is SecurityException)
                {
                    throw;
                }
                throw new JNIException("Can't initialize jni4net. (32bit vs 64bit JVM vs CLR ?)", ex);
            }
            catch (SecurityException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new JNIException("Can't initialize jni4net. (32bit vs 64bit JVM vs CLR ?)", ex);
            }
            BindCore(env, setup);
            jvmLoaded = true;
            return env;
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static string FindJar()
        {
            string jar = homeDll.Replace(".dll", ".jar").Replace("jni4net.n", "jni4net.j");
            if (File.Exists(jar))
            {
                return jar;
            }
            if (homeDll.Contains("jni4net.proxygen\\target"))
            {
                string dir = Path.GetDirectoryName(homeDll).Replace("jni4net.proxygen", "jni4net.j") + "\\classes";
                if (Directory.Exists(dir))
                {
                    return dir;
                }
            }
            if (homeDll.Contains("jni4net.n\\target"))
            {
                string dir = Path.GetDirectoryName(homeDll).Replace("jni4net.n", "jni4net.j") + "\\classes";
                if (Directory.Exists(dir))
                {
                    return dir;
                }
            }
            if (homeDll.Contains("jni4net.test.n\\target"))
            {
                string dir = Path.GetDirectoryName(homeDll).Replace("jni4net.test.n", "jni4net.j").Replace("jni4net.n", "jni4net.j") + "\\classes";
                if (Directory.Exists(dir))
                {
                    return dir;
                }
            }
            throw new JNIException("Can't find " + jar);
        }

        public static string GetVersion()
        {
            return typeof (Bridge).Assembly.GetName().Version.ToString();
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void LoadAndRegisterAssemblyFrom(java.io.File assemblyFile)
        {
            string assemblyPath = new Uri(assemblyFile.getCanonicalFile().toURI().toString()).LocalPath;

            Assembly assembly;
            if (File.Exists(assemblyPath))
            {
                assembly = Assembly.LoadFrom(assemblyPath);
            }
            else
            {
                string current = Path.Combine(homeDir, assemblyPath);
                if (File.Exists(current))
                {
                    assembly = Assembly.LoadFrom(current);
                }
                else
                {
                    throw new FileNotFoundException(assemblyPath);
                }
            }
            RegisterAssembly(assembly);
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void LoadAndRegisterAssemblyByName(string strongName)
        {
            Assembly assembly = Assembly.Load(strongName);
            RegisterAssembly(assembly);
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void RegisterAssembly(Assembly assembly)
        {
            if (knownAssemblies.ContainsKey(assembly))
            {
                if (Setup.Verbose)
                {
                    Console.WriteLine("skipped " + assembly + " from " + assembly.Location);
                }
                return;
            }
            if (Setup.Verbose)
            {
                Console.WriteLine("loading " + assembly + " from " + assembly.Location);
            }
            knownAssemblies.Add(assembly, assembly);
            Registry.RegisterAssembly(assembly, true);

            if (Setup.Verbose)
            {
                Console.WriteLine("loaded " + assembly + " from " + assembly.Location);
            }
        }

        public static void SetSystemClassLoader(ClassLoader classLoader)
        {
            Registry.systemClassLoader = classLoader;
        }

        #region Initialization

        internal static int initDotNetImpl(IntPtr envi, IntPtr clazz)
        {
            JNIEnv env;
            try
            {
                env = JNIEnv.Wrap(envi);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't bind env:\n"+ex);
                return -1;
            }
            JniLocalHandle br = env.FindClassPtrNoThrow("net/sf/jni4net/Bridge");
            if (JniLocalHandle.IsNull(br))
            {
                return -2;
            }
            IntPtr vb = env.GetStaticFieldIDPtr(br, "verbose", "Z");
            IntPtr db = env.GetStaticFieldIDPtr(br, "debug", "Z");
            BridgeSetup newSetup=new BridgeSetup(false)
                                     {
                                         Verbose = env.GetStaticBooleanField(br, vb),
                                         Debug = env.GetStaticBooleanField(br, db),
                                         BindStatic = true,
                                         BindNative = true
                                     };

            try
            {
                BindCore(env,newSetup);
                if (Setup.JavaHome == null)
                {
                    Setup.JavaHome = java.lang.System.getProperty("java.home");
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't init bridge:" + ex.Message);
                Console.Error.WriteLine("Can't init bridge:" + ex);
                Class exClazz = env.FindClass("net/sf/jni4net/inj/INJException");
                env.ThrowNew(exClazz, ex.Message);
                return -1;
            }
            return 0;
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        internal static void BindCore(JNIEnv env, BridgeSetup newSetup)
        {
            if (CheckAlreadyLoaded(newSetup, env))
            {
                return;
            }

            if (newSetup.Verbose)
            {
                Console.WriteLine("loading core from " + homeDll);
            }
            setup = newSetup;
            if (!setup.BindCoreOnly)
            {
                RegisterAssembly(typeof (Bridge).Assembly);
            }
            __Bridge.Init(env);

            if (Setup.Verbose)
            {
                Console.WriteLine("Initialized jni4net core");
            }
            if (Setup.BindNative)
            {
                JniLocalHandle br = env.FindClassPtr("net/sf/jni4net/Bridge");
                IntPtr ir = env.GetStaticFieldIDPtr(br, "isRegistered", "Z");
                env.SetStaticBooleanField(br, ir, true);
                if (!env.GetStaticBooleanField(br, ir))
                {
                    Console.Error.WriteLine("Can't mark bridge");
                }
                Ref.Init();
                Out.Init();
            }
            if (Setup.Verbose)
            {
                Console.WriteLine("core loaded from " + homeDll);
            }

            AppDomain.CurrentDomain.DomainUnload += CurrentDomain_DomainUnload;

            clrLoaded = true;
        }

        static void CurrentDomain_DomainUnload(object sender, EventArgs e)
        {
            if (Setup.BindNative)
            {
                JNIEnv env = JNIEnv.ThreadEnv;
                Registry.UnregisterNative();
                JniLocalHandle br = env.FindClassPtrNoThrow("net/sf/jni4net/Bridge");
                IntPtr ir = env.GetStaticFieldIDPtr(br, "isRegistered", "Z");
                env.SetStaticBooleanField(br, ir, false);
            }
        }

        private static bool CheckAlreadyLoaded(BridgeSetup newSetup, JNIEnv env)
        {
            if (clrLoaded)
            {
                return true;
            }
            if (newSetup.BindNative)
            {
                JniLocalHandle br = env.FindClassPtrNoThrow("net/sf/jni4net/Bridge");
                if (JniLocalHandle.IsNull(br))
                {
                    throw new JNIException("Can't find class net.sf.jni4net.Bridge on classpath");
                }
                IntPtr ir = env.GetStaticFieldIDPtr(br, "isRegistered", "Z");
                var isRegistered = env.GetStaticBooleanField(br, ir);
                if (isRegistered)
                {
                    // rather neat. When called like Clr->Java->Clr this dll gets loaded twice.
                    // which means two separate sets CLR of classes and static members
                    if (newSetup.Verbose)
                    {
                        Console.WriteLine("Already initialized jni4net core before");
                    }
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}