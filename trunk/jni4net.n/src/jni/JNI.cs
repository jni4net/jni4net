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
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using JType=java.lang.reflect.Type;
using Microsoft.Win32;

namespace net.sf.jni4net.jni
{
    internal static unsafe class JNI
    {
        public const int JNI_VERSION_1_1 = 0x00010001;
        public const int JNI_VERSION_1_2 = 0x00010002;
        public const int JNI_VERSION_1_4 = 0x00010004;
        public const int JNI_VERSION_1_6 = 0x00010006;

        private const string JRE_REGISTRY_KEY = @"HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Runtime Environment";
        private const string JDK_REGISTRY_KEY = @"HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Development Kit";
        private const string JAVA_HOME_ENV = "JAVA_HOME";
        

        private static bool init;

        static JNI()
        {
            Init();
        }

        [EnvironmentPermission(SecurityAction.Assert, Read = JAVA_HOME_ENV)]
        [RegistryPermission(SecurityAction.Assert, Read = JRE_REGISTRY_KEY)]
        [RegistryPermission(SecurityAction.Assert, Read = JDK_REGISTRY_KEY)]
        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution|SecurityPermissionFlag.UnmanagedCode|SecurityPermissionFlag.SkipVerification)]
        private static void Init()
        {
            if (!init)
            {
                string jvmDir = FindJvmDir();

                string oldDirectory = Directory.GetCurrentDirectory();
                try
                {
                    Directory.SetCurrentDirectory(jvmDir);
                    var args = new JavaVMInitArgs();

                    //just load DLL
                    Dll.JNI_GetDefaultJavaVMInitArgs(&args);
                    init = true;
                }
                catch(TypeInitializationException)
                {
                }
                finally
                {
                    Directory.SetCurrentDirectory(oldDirectory);
                }
            }
        }

        private static string FindJvmDir()
        {
            string jvmDir = null;
            if (Bridge.Setup.JavaHome == null)
            {
                Bridge.Setup.JavaHome = Environment.GetEnvironmentVariable(JAVA_HOME_ENV);
            }

            if (!IsRunningOnUnix())
            {
                if (Bridge.Setup.JavaHome == null)
                {
                    string jreVersion = (string)Registry.GetValue(JRE_REGISTRY_KEY, "CurrentVersion", null);
                    if (jreVersion != null)
                    {
                        string keyName = Path.Combine(JRE_REGISTRY_KEY, jreVersion);
                        jvmDir = (string)Registry.GetValue(keyName, "RuntimeLib", null);
                        Bridge.Setup.JavaHome = (string)Registry.GetValue(keyName, "JavaHome", null);
                    }
                }

                if (Bridge.Setup.JavaHome == null)
                {
                    string jdkVersion = (string)Registry.GetValue(JDK_REGISTRY_KEY, "CurrentVersion", null);
                    if (jdkVersion != null)
                    {
                        string keyName = Path.Combine(JDK_REGISTRY_KEY, jdkVersion);
                        jvmDir = (string)Registry.GetValue(keyName, "RuntimeLib", null);
                        Bridge.Setup.JavaHome = (string)Registry.GetValue(keyName, "JavaHome", null);
                    }
                }

                string prfi = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if (Bridge.Setup.JavaHome == null && Directory.Exists(prfi))
                {
                    string prfijava = Path.Combine(prfi, "Java");
                    if (Directory.Exists(prfijava))
                    {
                        string[] directories = Directory.GetDirectories(prfijava,"jre*");
                        if (directories.Length>0)
                        {
                            Array.Sort(directories);
                            Bridge.Setup.JavaHome = directories[directories.Length - 1];
                            if (Bridge.Setup.Verbose)
                            {
                                Console.WriteLine("Guessed JAVA_HOME to " + Bridge.Setup.JavaHome);
                            }
                        }
                        else
                        {
                            directories = Directory.GetDirectories(prfijava, "jdk*");
                            if (directories.Length > 0)
                            {
                                Array.Sort(directories);
                                Bridge.Setup.JavaHome = directories[directories.Length - 1];
                                if (Bridge.Setup.Verbose)
                                {
                                    Console.WriteLine("Guessed JAVA_HOME to " + Bridge.Setup.JavaHome);
                                }
                            }
                        }
                    }
                }
            }

            if (Bridge.Setup.JavaHome == null)
            {
                throw new JNIException("JAVA_HOME environment variable is not set");
            }

            if ((jvmDir == null) || !Directory.Exists(jvmDir))
            {
                jvmDir = Path.Combine(Bridge.Setup.JavaHome, @"bin\client\");
                if (!Directory.Exists(jvmDir))
                {
                    jvmDir = Path.Combine(Bridge.Setup.JavaHome, @"bin\server\");
                    if (!Directory.Exists(jvmDir))
                    {
                        jvmDir = Path.Combine(Bridge.Setup.JavaHome, @"jre\bin\client\");
                        if (!Directory.Exists(jvmDir))
                        {
                            jvmDir = Path.Combine(Bridge.Setup.JavaHome, @"jre\bin\server\");
                            if (!Directory.Exists(jvmDir))
                            {
                                throw new JNIException("JAVA_HOME environment variable points to an invalid location: " + Bridge.Setup.JavaHome);
                            }
                        }
                    }
                }
            }
            return jvmDir;
        }

        private static bool IsRunningOnUnix()
        {
            int p = (int) Environment.OSVersion.Platform;
            return ((p == 4) || (p == 6) || (p == 128));
        }

        public static void CreateJavaVM(out JavaVM jvm, out JNIEnv env, params string[] options)
        {
            CreateJavaVM(out jvm, out env, false, options);
        }

        public static void CreateJavaVM(out JavaVM jvm, out JNIEnv env, bool attachIfExists, params string[] options)
        {
            Init();
            IntPtr njvm;
            IntPtr nenv;
            var args = new JavaVMInitArgs();
            args.version = JNI_VERSION_1_4;

            if (options.Length > 0)
            {
                args.nOptions = options.Length;
                var opt = new JavaVMOption[options.Length];
                for (int i = 0; i < options.Length; i++)
                {
                    opt[i].optionString = Marshal.StringToHGlobalAnsi(options[i]);
                }
                fixed (JavaVMOption* a = &opt[0])
                {
                    args.options = a;
                }
            }
            JNIResult result;
            if (attachIfExists)
            {
                IntPtr njvma;
                int count;
                result = Dll.JNI_GetCreatedJavaVMs(out njvma, 1, out count);
                if (result != JNIResult.JNI_OK)
                {
                    throw new JNIException("Can't enumerate current JVMs " + result);
                }
                if (count > 0)
                {
                    njvm = njvma;
                    jvm = new JavaVM(njvm);
                    result = jvm.AttachCurrentThread(out env, args);
                    if (result != JNIResult.JNI_OK)
                    {
                        throw new JNIException("Can't join current JVM " + result);
                    }
                    return;
                }
            }
            result = Dll.JNI_CreateJavaVM(out njvm, out nenv, &args);
            if (result != JNIResult.JNI_OK)
            {
                Console.Error.WriteLine("Can't load JVM (already have one ?)");
                throw new JNIException("Can't load JVM (already have one ?) " + result);
            }
            jvm = new JavaVM(njvm);
            env = new JNIEnv(nenv);
        }

        #region Nested type: Dll

        private static class Dll
        {
            [DllImport("jvm.dll", CallingConvention = CallingConvention.StdCall)]
            internal static extern JNIResult JNI_CreateJavaVM(out IntPtr pvm, out IntPtr penv,
                                                              JavaVMInitArgs* args);

            [DllImport("jvm.dll", CallingConvention = CallingConvention.StdCall)]
            internal static extern JNIResult JNI_GetCreatedJavaVMs(out IntPtr pvm, int size,
                                                                   [Out] out int size2);

            [DllImport("jvm.dll", CallingConvention = CallingConvention.StdCall)]
            internal static extern JNIResult JNI_GetDefaultJavaVMInitArgs(JavaVMInitArgs* args);
        }

        #endregion
    }
}