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
using System.Runtime.InteropServices;
using System.Security;

namespace net.sf.jni4net.jniexport
{
    [SuppressUnmanagedCodeSecurity]
    public class JNIEnvMini
    {
        private readonly IntPtr envPtr;

        public unsafe JNIEnvMini(IntPtr envPtr)
        {
            this.envPtr = envPtr;
            Functions.functions = *(*(JNINativeInterfacePtr*)envPtr.ToPointer()).functions;
            Functions.InitMethods();
        }

        public string GetString(IntPtr strObject)
        {
            if (strObject == IntPtr.Zero)
            {
                return null;
            }
            IntPtr strNative = IntPtr.Zero;
            try
            {
                strNative = GetStringChars(strObject);
                return Marshal.PtrToStringUni(strNative);
            }
            finally
            {
                if (strNative != IntPtr.Zero)
                {
                    ReleaseStringChars(strObject, strNative);
                }
            }
        }

        private unsafe IntPtr GetStringChars(IntPtr strObject)
        {
            byte copy = 0;
            IntPtr res = Functions.getStringChars(envPtr, strObject, &copy);
            return res;
        }

        private void ReleaseStringChars(IntPtr strObject, IntPtr strNative)
        {
            Functions.releaseStringChars(envPtr, strObject, strNative);
        }

        [SuppressUnmanagedCodeSecurity]
        static class Functions
        {
            public static void InitMethods()
            {
                lock (typeof(JNIEnvMini))
                {
                    getStringChars = (JNIDelegates.StdCall.GetStringChars)Marshal.GetDelegateForFunctionPointer(functions.GetStringChars, typeof(JNIDelegates.StdCall.GetStringChars));
                    releaseStringChars = (JNIDelegates.StdCall.ReleaseStringChars)Marshal.GetDelegateForFunctionPointer(functions.ReleaseStringChars, typeof(JNIDelegates.StdCall.ReleaseStringChars));
                }
            }

            public static JNINativeInterface functions;
            public static JNIDelegates.StdCall.GetStringChars getStringChars;
            public static JNIDelegates.StdCall.ReleaseStringChars releaseStringChars;
        }

        static class JNIDelegates
        {
            [SuppressUnmanagedCodeSecurity]
            public unsafe static class StdCall
            {
                [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
                public delegate IntPtr GetStringChars(IntPtr thiz, IntPtr str, byte* isCopy);

                [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
                public delegate void ReleaseStringChars(IntPtr thiz, IntPtr str, IntPtr chars);
            }
        }
    }
}
