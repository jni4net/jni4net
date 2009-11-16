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
        private static bool clrLoaded;
        private static BridgeSetup setup;

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
            JavaVM jvm;
            JNIEnv env;
            JNI.CreateJavaVM(out jvm, out env, true, Bridge.setup.JVMOptions);
            BindCore(env, Bridge.setup);
            jvmLoaded = true;
            return env;
        }

        public static void CreateJVM(params string[] options)
        {
            if (jvmLoaded)
            {
                throw new JNIException("Already initilized");
            }
            setup = new BridgeSetup(options);
            JavaVM jvm;
            JNIEnv env;
            JNI.CreateJavaVM(out jvm, out env, true, setup.JVMOptions);
            BindCore(env, Bridge.setup);
            jvmLoaded = true;
        }

        public static void CreateJVM(out JavaVM jvm, out JNIEnv env, params string[] options)
        {
            if (jvmLoaded)
            {
                throw new JNIException("Already initilized");
            }
            setup = new BridgeSetup(options);
            JNI.CreateJavaVM(out jvm, out env, true, setup.JVMOptions);
            BindCore(env, Bridge.setup);
            jvmLoaded = true;
        }

        public static string FindJar()
        {
            string dll = typeof(Bridge).Assembly.Location;
            string jar = dll.Replace(".dll", ".jar").Replace("jni4net.n", "jni4net.j");
            if (File.Exists(jar))
            {
                return jar;
            }
            if (dll.Contains("jni4net.proxygen\\target"))
            {
                string dir = Path.GetDirectoryName(dll).Replace("jni4net.proxygen", "jni4net.j") + "\\classes";
                if (Directory.Exists(dir))
                {
                    return dir;
                }
            }
            if (dll.Contains("jni4net.n\\target"))
            {
                string dir = Path.GetDirectoryName(dll).Replace("jni4net.n", "jni4net.j") + "\\classes";
                if (Directory.Exists(dir))
                {
                    return dir;
                }
            }
            if (dll.Contains("jni4net.test.n\\target"))
            {
                string dir = Path.GetDirectoryName(dll).Replace("jni4net.test.n", "jni4net.j").Replace("jni4net.n", "jni4net.j") + "\\classes";
                if (Directory.Exists(dir))
                {
                    return dir;
                }
            }
            TextWriter writer = Console.Out;
            throw new JNIException("Can't find " + jar);
        }

        public static string GetVersion()
        {
            return typeof (Bridge).Assembly.GetName().Version.ToString();
        }

        public static void LoadAndRegisterAssembly(string assemblyPath)
        {
            Assembly assembly;
            if (File.Exists(assemblyPath))
            {
                assembly = Assembly.LoadFrom(assemblyPath);
            }
            else
            {
                assembly = Assembly.Load(assemblyPath);
            }
            RegisterAssembly(assembly);
        }

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
            JNIEnv env = JNIEnv.ThreadEnv;
            //JavaProxiesMap.RegisterAssembly(env, assembly);
            //ClrProxiesMap.RegisterAssembly(env, assembly);
            Registry.RegisterAssembly(assembly, true);

            if (Setup.Verbose)
            {
                Console.WriteLine("loaded " + assembly + " from " + assembly.Location);
            }
        }

        #region Initialization

        internal static int initDotNetImpl(IntPtr envi, IntPtr clazz)
        {
            JNIEnv env;
            try
            {
                env = JNIEnv.Wrap(envi);
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Can't bind env");
                return -1;
            }
            IntPtr br = env.FindClassPtrNoThrow("net/sf/jni4net/Bridge");
            if (br==IntPtr.Zero)
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

        internal static void BindCore(JNIEnv env, BridgeSetup newSetup)
        {
            if (CheckAlreadyLoaded(newSetup, env))
            {
                return;
            }

            setup = newSetup;

            RegisterAssembly(typeof(Bridge).Assembly);
            __Bridge.Init(env);

            if (Setup.Verbose)
            {
                Console.WriteLine("Initialized jni4net core");
            }
            if (Setup.BindNative)
            {
                IntPtr br = env.FindClassPtr("net/sf/jni4net/Bridge");
                IntPtr ir = env.GetStaticFieldIDPtr(br, "isRegistered", "Z");
                env.SetStaticBooleanField(br, ir, true);
                if (!env.GetStaticBooleanField(br, ir))
                {
                    Console.Error.WriteLine("Can't mark bridge");
                }
            }
            if (Setup.Verbose)
            {
                Console.WriteLine("core loaded from " + typeof(Bridge).Assembly.Location);
            }
            clrLoaded = true;
        }

        private static bool CheckAlreadyLoaded(BridgeSetup newSetup, JNIEnv env)
        {
            if (clrLoaded)
            {
                return true;
            }
            if (newSetup.Verbose)
            {
                Console.WriteLine("loading core from " + typeof(Bridge).Assembly.Location);
            }
            if (newSetup.BindNative)
            {
                IntPtr br = env.FindClassPtrNoThrow("net/sf/jni4net/Bridge");
                if (br==IntPtr.Zero)
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