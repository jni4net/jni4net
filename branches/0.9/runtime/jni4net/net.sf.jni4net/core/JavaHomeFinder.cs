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
using System.IO;
using System.Security.Permissions;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.core
{
    [EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
    [RegistryPermission(SecurityAction.Assert, Read = JRE_REGISTRY_KEY)]
    [RegistryPermission(SecurityAction.Assert, Read = JDK_REGISTRY_KEY)]
    [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
    [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution | SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SkipVerification)]
    static class JavaHomeFinder
    {
        private const string JAVA_HOME_ENV = "JAVA_HOME";
        private const string JRE_REGISTRY_KEY = @"HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Runtime Environment";
        private const string JDK_REGISTRY_KEY = @"HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Development Kit";

        public static bool FindJavaHome(BridgeSetup setup, ref string javaHome, ref JNILib jvmDll)
        {
            string jvmDir = null;
            if (!string.IsNullOrEmpty(javaHome) && ConfirmJavaHome(ref javaHome, ref jvmDir, ref jvmDll, setup.JavaVersion))
            {
                return true;
            }
            if (setup.DisableJavaHomeDetection)
            {
                return false;
            }
            
            // environment
            javaHome = Environment.GetEnvironmentVariable(JAVA_HOME_ENV);
            jvmDir = null;
            if (!string.IsNullOrEmpty(javaHome) && ConfirmJavaHome(ref javaHome, ref jvmDir, ref jvmDll, setup.JavaVersion))
            {
                return true;
            }

            if (OsUtils.IsRunningWindows)
            {
                //registry JRE
                string jreVersion;
                if (setup.JavaVersion == null)
                {
                    jreVersion = (string)Microsoft.Win32.Registry.GetValue(JRE_REGISTRY_KEY, "CurrentVersion", null);
                }
                else
                {
                    jreVersion = setup.JavaVersion;
                }
                if (jreVersion != null)
                {
                    string keyName = Path.Combine(JRE_REGISTRY_KEY, jreVersion);
                    jvmDir = (string) Microsoft.Win32.Registry.GetValue(keyName, "RuntimeLib", null);
                    if (!string.IsNullOrEmpty(jvmDir))
                    {
                        jvmDir = Path.GetDirectoryName(jvmDir);
                    }
                    javaHome = (string)Microsoft.Win32.Registry.GetValue(keyName, "JavaHome", null);
                    if (!string.IsNullOrEmpty(javaHome) && ConfirmJavaHome(ref javaHome, ref jvmDir, ref jvmDll, setup.JavaVersion))
                    {
                        return true;
                    }
                }

                //registry JDK
                string jdkVersion;
                if (setup.JavaVersion == null)
                {
                    jdkVersion = (string)Microsoft.Win32.Registry.GetValue(JDK_REGISTRY_KEY, "CurrentVersion", null);
                }
                else
                {
                    jdkVersion = setup.JavaVersion;
                }
                if (jdkVersion != null)
                {
                    string keyName = Path.Combine(JDK_REGISTRY_KEY, jdkVersion);
                    jvmDir = (string)Microsoft.Win32.Registry.GetValue(keyName, "RuntimeLib", null);
                    if (!string.IsNullOrEmpty(jvmDir))
                    {
                        jvmDir = Path.GetDirectoryName(jvmDir);
                    }
                    javaHome = (string)Microsoft.Win32.Registry.GetValue(keyName, "JavaHome", null);
                    if (!string.IsNullOrEmpty(javaHome) && ConfirmJavaHome(ref javaHome, ref jvmDir, ref jvmDll, setup.JavaVersion))
                    {
                        return true;
                    }
                }

                // path to program files
                string prfi = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if (OsUtils.Is64BitSystem && !OsUtils.Is64BitProcess)
                {
                    prfi = prfi + " (x86)";
                    if (Directory.Exists(prfi))
                    {
                        string prfijava = Path.Combine(prfi, "Java");
                        if (Directory.Exists(prfijava))
                        {
                            string[] directories = Directory.GetDirectories(prfijava, "jre*");
                            Array.Sort(directories);
                            for (int i = directories.Length - 1; i <= 0; i--)
                            {
                                jvmDir = null;
                                javaHome = directories[i];
                                if (ConfirmJavaHome(ref javaHome, ref jvmDir, ref jvmDll, setup.JavaVersion))
                                {
                                    return true;
                                }
                            }

                            directories = Directory.GetDirectories(prfijava, "jdk*");
                            Array.Sort(directories);
                            for (int i = directories.Length - 1; i <= 0; i--)
                            {
                                jvmDir = null;
                                javaHome = directories[i];
                                if (ConfirmJavaHome(ref javaHome, ref jvmDir, ref jvmDll, setup.JavaVersion))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

                prfi = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if (Directory.Exists(prfi))
                {
                    string prfijava = Path.Combine(prfi, "Java");
                    if (Directory.Exists(prfijava))
                    {
                        string[] directories = Directory.GetDirectories(prfijava, "jre*");
                        Array.Sort(directories);
                        for (int i = directories.Length - 1; i >= 0; i--)
                        {
                            jvmDir = null;
                            javaHome = directories[i];
                            if (ConfirmJavaHome(ref javaHome, ref jvmDir, ref jvmDll, setup.JavaVersion))
                            {
                                return true;
                            }
                        }

                        directories = Directory.GetDirectories(prfijava, "jdk*");
                        Array.Sort(directories);
                        for (int i = directories.Length - 1; i >= 0; i--)
                        {
                            jvmDir = null;
                            javaHome = directories[i];
                            if (ConfirmJavaHome(ref javaHome, ref jvmDir, ref jvmDll, setup.JavaVersion))
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private static bool ConfirmJavaHome(ref string javaHome, ref string jvmDir, ref JNILib jvmDll, string javaVersion)
        {
            try
            {
                if (!Directory.Exists(javaHome))
                {
                    return false;
                }
                javaHome = Path.GetFullPath(javaHome);
                if (string.IsNullOrEmpty(jvmDir) || !Directory.Exists(jvmDir))
                {
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
                                    jvmDir = Path.Combine(javaHome, @"jre\bin\classic\");
                                    if (!Directory.Exists(jvmDir))
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
                if (javaVersion != null && !javaHome.ToLowerInvariant().Contains(javaVersion.ToLowerInvariant()))
                {
                    return false;
                }
                jvmDll = new JNILib(jvmDir, false);

                return true;

            }
            catch(Exception ex)
            {
                Logger.LogDebug(ex.Message);
                return false;
            }
        }
    }
}
