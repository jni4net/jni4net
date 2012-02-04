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
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace net.sf.jni4net.utils
{
    internal static class OsUtils
    {
        public static bool IsRunningMono
        {
            get
            {
                Type t = Type.GetType("Mono.Runtime", false);
                return (t != null);
            }
        }

        public static bool IsRunningWindows
        {
            get
            {
                var platformId = Environment.OSVersion.Platform;
                return platformId == PlatformID.Win32Windows || platformId == PlatformID.Win32NT || platformId==PlatformID.Xbox;
            }
        }

        
        public static bool IsRunningUnix
        {
            get
            {
                var p = (int)Environment.OSVersion.Platform;
                return ((p == 4) || (p == 6) || (p == 128));
            }
        }

        public static bool Is64BitProcess
        {
            get { return IntPtr.Size == 8; }
        }

        public static bool Is64BitSystem
        {
            get
            {
                if (IntPtr.Size == 8 || (IntPtr.Size == 4 && !IsRunningUnix && OsUtils.WindowsIs32BitProcessOn64BitProcessor()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        #region Windows

        static class NativeWindowsMethods
        {
            [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
            public static extern IntPtr LoadLibrary(string lpFileName);

            [DllImport("kernel32", CharSet = CharSet.Auto)]
            public static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
            internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

            //[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
            //internal static extern bool SetDllDirectory(string lpPathName);

            public delegate bool IsWow64ProcessDelegate([In] IntPtr handle, [Out] out bool isWow64Process);
        }

        public static IntPtr WindowsLoadDll(string jvmPath, bool forceLoad, string jvmDllName)
        {
            IntPtr hModule;
            string dllName = Path.Combine(jvmPath, jvmDllName);
            if (forceLoad)
            {
                hModule = NativeWindowsMethods.LoadLibrary(dllName + ".dll");
            }
            else
            {
                hModule = NativeWindowsMethods.GetModuleHandle(jvmDllName + ".dll");
                if (hModule == IntPtr.Zero)
                {
                    hModule = NativeWindowsMethods.LoadLibrary(dllName + ".dll");
                }
            }
            if (hModule == IntPtr.Zero)
            {
                throw new J4NException("Can't load " + dllName);
            }
            return hModule;
        }

        public static IntPtr WindowsGetProcAddress(IntPtr hModule, string procName)
        {
            return NativeWindowsMethods.GetProcAddress(hModule, procName);
        }

        private static NativeWindowsMethods.IsWow64ProcessDelegate GetIsWow64ProcessDelegate()
        {
            IntPtr handle = NativeWindowsMethods.LoadLibrary("kernel32");

            if (handle != IntPtr.Zero)
            {
                IntPtr fnPtr = NativeWindowsMethods.GetProcAddress(handle, "IsWow64Process");

                if (fnPtr != IntPtr.Zero)
                {
                    return (NativeWindowsMethods.IsWow64ProcessDelegate)Marshal.GetDelegateForFunctionPointer((IntPtr)fnPtr, typeof(NativeWindowsMethods.IsWow64ProcessDelegate));
                }
            }

            return null;
        }

        public static bool WindowsIs32BitProcessOn64BitProcessor()
        {
            NativeWindowsMethods.IsWow64ProcessDelegate fnDelegate = GetIsWow64ProcessDelegate();

            if (fnDelegate == null)
            {
                return false;
            }

            bool isWow64;
            bool retVal = fnDelegate.Invoke(Process.GetCurrentProcess().Handle, out isWow64);

            if (retVal == false)
            {
                return false;
            }

            return isWow64;
        }

        #endregion
    }
}
