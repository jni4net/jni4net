#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using Exception = System.Exception;
using File = java.io.File;

namespace net.sf.jni4net
{
    public static partial class Bridge
    {
        private static readonly Dictionary<Assembly, object> knownAssemblies = new Dictionary<Assembly, object>();
        private static bool jvmLoaded;
        private static bool clrLoaded;
        private static BridgeSetup setup;
        private static readonly string homeDir;

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        static Bridge()
        {
            homeDir = AppDomain.CurrentDomain.BaseDirectory.ToLowerInvariant();
        }

        public static BridgeSetup Setup
        {
            get { return setup; }
        }

        public static IList<Assembly> KnownAssemblies
        {
            get
            {
                var res = new Assembly[knownAssemblies.Count];
                knownAssemblies.Keys.CopyTo(res, 0);
                return res;
            }
        }

        public static JNIEnv CreateJVM(BridgeSetup setup)
        {
            if (jvmLoaded)
            {
                if (setup.Verbose)
                {
                    Console.Error.WriteLine("Already initilized");
                }
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

        [SecurityPermission(SecurityAction.Assert,
            Flags =
                SecurityPermissionFlag.Execution | SecurityPermissionFlag.UnmanagedCode |
                SecurityPermissionFlag.SkipVerification)]
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
                if (ex.InnerException is BadImageFormatException)
                {
                    // it didn't help, throw original exception
                    throw new JNIException("Can't initialize jni4net. (32bit vs 64bit JVM vs CLR ?)"
                                           + "\nCLR architecture: " + ((IntPtr.Size == 8) ? "64bit" : "32bit")
                                           + "\nJAVA_HOME: " + (setup==null || setup.JavaHome == null
                                                                    ? "null"
                                                                    : Path.GetFullPath(setup.JavaHome))
                                           , ex);
                }
                throw;
            }
            BindCore(env, setup);
            jvmLoaded = true;
            DumpRuntimeVersions();
            return env;
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static string FindJar()
        {
            string dir = homeDir;
            var jarName = "jni4net.j-" + typeof(Bridge).Assembly.GetName().Version + ".jar";
            var jar1 = Path.GetFullPath(Path.Combine(dir, jarName));
            if (System.IO.File.Exists(jar1))
            {
                return jar1;
            }
            var jar2 = Path.GetFullPath(Path.Combine(Path.Combine(dir, @".\bin"), jarName));
            if (System.IO.File.Exists(jar2))
            {
                return jar2;
            }
            var jar3 = Path.GetFullPath(Path.Combine(Path.Combine(dir, @".\lib"), jarName));
            if (System.IO.File.Exists(jar3))
            {
                return jar3;
            }
            var jar4 = Path.GetFullPath(Path.Combine(Path.Combine(dir, @".\..\lib"), jarName));
            if (System.IO.File.Exists(jar4))
            {
                return jar4;
            }

            dir = Path.GetDirectoryName(new Uri(typeof(Bridge).Assembly.GetName().CodeBase).AbsolutePath);
            var jar5 = Path.GetFullPath(Path.Combine(dir, jarName));
            if (System.IO.File.Exists(jar5))
            {
                return jar5;
            }
            var jar6 = Path.GetFullPath(Path.Combine(Path.Combine(dir, @".\bin"), jarName));
            if (System.IO.File.Exists(jar6))
            {
                return jar6;
            }
            var jar7 = Path.GetFullPath(Path.Combine(Path.Combine(dir, @".\lib"), jarName));
            if (System.IO.File.Exists(jar7))
            {
                return jar7;
            }
            var jar8 = Path.GetFullPath(Path.Combine(Path.Combine(dir, @".\..\lib"), jarName));
            if (System.IO.File.Exists(jar8))
            {
                return jar8;
            }

            throw new JNIException("Can't find " + jarName
                + "\nat " + jar1
                + "\nor " + jar2
                + "\nor " + jar3
                + "\nor " + jar4
                + "\nor " + jar5
                + "\nor " + jar6
                + "\nor " + jar7
                + "\nor " + jar8
                );
        }

        public static string GetVersion()
        {
            return typeof (Bridge).Assembly.GetName().Version.ToString();
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

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void LoadAndRegisterAssemblyFrom(File assemblyFile)
        {
            string assemblyPath = new Uri(assemblyFile.getCanonicalFile().toURI().toString()).LocalPath;

            Assembly assembly;
            if (System.IO.File.Exists(assemblyPath))
            {
                assembly = Assembly.LoadFrom(assemblyPath);
            }
            else
            {
                string current = Path.Combine(homeDir, assemblyPath);
                if (System.IO.File.Exists(current))
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
        public static void LoadAndRegisterAssemblyFrom(File assemblyFile, ClassLoader classLoader)
        {
            string assemblyPath = new Uri(assemblyFile.getCanonicalFile().toURI().toString()).LocalPath;

            Assembly assembly;
            if (System.IO.File.Exists(assemblyPath))
            {
                assembly = Assembly.LoadFrom(assemblyPath);
            }
            else
            {
                string current = Path.Combine(homeDir, assemblyPath);
                if (System.IO.File.Exists(current))
                {
                    assembly = Assembly.LoadFrom(current);
                }
                else
                {
                    throw new FileNotFoundException(assemblyPath);
                }
            }
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
            Registry.RegisterAssembly(assembly, true, classLoader);

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
            JNIEnv env = null;
            try
            {
                try
                {
                    env = JNIEnv.Wrap(envi);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Can't bind env:\n" + ex.Message);
                    Console.Error.WriteLine("Can't bind env:\n" + ex);
                    return -3;
                }
                JniLocalHandle br = env.FindClassPtrNoThrow("net/sf/jni4net/Bridge");
                if (JniLocalHandle.IsNull(br))
                {
                    Console.Error.WriteLine("Can't find net/sf/jni4net/Bridge class");
                    return -2;
                }
                IntPtr vb = env.GetStaticFieldIDPtr(br, "verbose", "Z");
                IntPtr db = env.GetStaticFieldIDPtr(br, "debug", "Z");
                if (IntPtr.Zero == vb || IntPtr.Zero == db)
                {
                    Console.Error.WriteLine("Can't find verbose or debug fields");
                    return -6;
                }
                var newSetup = new BridgeSetup(false)
                                   {
                                       Verbose = env.GetStaticBooleanField(br, vb),
                                       Debug = env.GetStaticBooleanField(br, db),
                                       BindStatic = true,
                                       BindNative = true
                                   };
                BindCore(env, newSetup);
                if (Setup.JavaHome == null)
                {
                    Setup.JavaHome = java.lang.System.getProperty("java.home");
                }
                DumpRuntimeVersions();
            }
            catch (Exception ex)
            {
                try
                {
                    Console.Error.WriteLine("Can't bind bridge:" + ex.Message);
                    Console.Error.WriteLine("Can't bind bridge:" + ex);
                    Class exClazz = env.FindClass("net/sf/jni4net/inj/INJException");
                    env.ThrowNew(exClazz, ex.Message);
                    return -4;
                }
                catch (Exception)
                {
                    return -5;
                }
            }
            return 0;
        }

        [EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        private static void DumpRuntimeVersions()
        {
            if (Setup.Verbose)
            {
                Console.WriteLine("clr.version         :" + RuntimeEnvironment.GetSystemVersion());
                Console.WriteLine("clr.arch            :" + ((IntPtr.Size == 8) ? "64bit" : "32bit"));
                Console.WriteLine("java.home           :" + Setup.JavaHome);
                Console.WriteLine("java.version        :" + java.lang.System.getProperty("java.version"));
                Console.WriteLine("sun.arch.data.model :" + java.lang.System.getProperty("sun.arch.data.model"));
                if (setup.Debug)
                {
                    Console.WriteLine("current.dir         :" + Directory.GetCurrentDirectory());
                    Console.WriteLine();
                    Console.WriteLine("java.class.path     :" + java.lang.System.getProperty("java.class.path"));
                    Console.WriteLine();
                    Console.WriteLine("env.PATH            :" + Environment.GetEnvironmentVariable("PATH"));
                    Console.WriteLine();
                }
            }
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
                var homeDll = new Uri(typeof(Bridge).Assembly.GetName().CodeBase).AbsolutePath;
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
                var homeDll = new Uri(typeof(Bridge).Assembly.GetName().CodeBase).AbsolutePath;
                Console.WriteLine("core loaded from " + homeDll);
            }

            AppDomain.CurrentDomain.DomainUnload += CurrentDomain_DomainUnload;

            clrLoaded = true;
        }

        private static void CurrentDomain_DomainUnload(object sender, EventArgs e)
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
                bool isRegistered = env.GetStaticBooleanField(br, ir);
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