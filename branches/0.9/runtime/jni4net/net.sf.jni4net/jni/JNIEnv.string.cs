﻿#region Copyright (C) 2012 by Pavel Savara

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

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        public string GetString(IJvmProxy str)
        {
            return GetString(str.JvmHandle);
        }

        public JNIGlobalHandle NewStringG(string value)
        {
            return NewGlobalRef(NewString(value));
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

        public unsafe IntPtr GetStringChars(IntPtr strObject)
        {
            byte copy = 0;
            IntPtr res = Functions.getStringChars(envPtr, strObject, &copy);
            ExceptionTest();
            return res;
        }

        public void ReleaseStringChars(IntPtr strObject, IntPtr strNative)
        {
            Functions.releaseStringChars(envPtr, strObject, strNative);
            ExceptionTest();
        }

        public IntPtr NewString(string value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr res = Functions.newString(envPtr, value, value.Length);
            ExceptionTest();
            return res;
        }
    }
}
