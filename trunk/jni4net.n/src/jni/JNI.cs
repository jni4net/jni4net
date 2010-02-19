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

        private const string JAVA_REGISTRY_KEY = @"HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Runtime Environment";

        private static bool init;

        static JNI()
        {
            Init();
        }

        [EnvironmentPermission(SecurityAction.Assert, Read = "JAVA_HOME")]
        [RegistryPermission(SecurityAction.Assert, Read = JAVA_REGISTRY_KEY)]
        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution|SecurityPermissionFlag.UnmanagedCode|SecurityPermissionFlag.SkipVerification)]
        private static void Init()
        {
            if (!init)
            {
                string javaHome = Environment.GetEnvironmentVariable("JAVA_HOME");
                string jvmDir = null;

                if (javaHome == null)
                {
                    string jdkVersion = (string)Registry.GetValue(JAVA_REGISTRY_KEY, "CurrentVersion", null);
                    if (jdkVersion != null)
                    {
                        jvmDir = (string)Registry.GetValue(Path.Combine(JAVA_REGISTRY_KEY, jdkVersion), "RuntimeLib", null);
                        javaHome = (string)Registry.GetValue(Path.Combine(JAVA_REGISTRY_KEY, jdkVersion), "JavaHome", null);
                    }
                }

                if ((jvmDir == null) || !Directory.Exists(jvmDir))
                {
                    if (javaHome == null)
                    {
                        throw new JNIException("JAVA_HOME environment variable is not set");
                    }
                    jvmDir = Path.Combine(javaHome, @"bin\client\");
                    if (!Directory.Exists(jvmDir))
                    {
                        jvmDir = Path.Combine(javaHome, @"bin\server\");
                        if (!Directory.Exists(jvmDir))
                        {
                            jvmDir = Path.Combine(javaHome, @"jre\bin\client\");
                            if (!Directory.Exists(jvmDir))
                            {
                                jvmDir = Path.Combine(javaHome, @"jre\bin\server\");
                                if (!Directory.Exists(jvmDir))
                                {
                                    throw new JNIException("JAVA_HOME environment variable points to an invalid location: " + javaHome);
                                }
                            }
                        }
                    }
                }

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