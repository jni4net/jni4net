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
using System.Runtime.InteropServices;
using java.lang;

namespace net.sf.jni4net.jni
{
    unsafe partial class JNIEnv
    {
        internal IntPtr NewIntArrayPtr(int len)
        {
            IntPtr res = newIntArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr GetObjectArrayElementPtr(IntPtr array, int index)
        {
            IntPtr res = getObjectArrayElement(envPtr, array, index);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewStringPtr(string unicode)
        {
            IntPtr uni = Marshal.StringToHGlobalUni(unicode);
            IntPtr res = newString(envPtr, uni, unicode.Length);
            ExceptionTest();
            Marshal.FreeHGlobal(uni);
            return res;
        }

        internal IntPtr GetStringChars(IntPtr str, byte* isCopy)
        {
            IntPtr res = getStringChars(envPtr, str, isCopy);
            ExceptionTest();
            return res;
        }

        internal void ReleaseStringChars(IntPtr str, IntPtr chars)
        {
            releaseStringChars(envPtr, str, chars);
            ExceptionTest();
        }

        internal IntPtr NewObjectArrayPtr(int len, IntPtr clazz, IJvmProxy init)
        {
            IntPtr res = newObjectArray(envPtr, len, clazz, init == null ? IntPtr.Zero : init.JvmHandle);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewCharArrayPtr(int len)
        {
            IntPtr res = newCharArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewShortArrayPtr(int len)
        {
            IntPtr res = newShortArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewByteArrayPtr(int len)
        {
            IntPtr res = newByteArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewBooleanArrayPtr(int len)
        {
            IntPtr res = newBooleanArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewLongArrayPtr(int len)
        {
            IntPtr res = newLongArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewFloatArrayPtr(int len)
        {
            IntPtr res = newFloatArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewDoubleArrayPtr(int len)
        {
            IntPtr res = newDoubleArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public IntPtr CallObjectMethodPtr(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
#if DEBUG
            if (Bridge.Setup.VeryVerbose)
            {
                Console.WriteLine("CallObjectMethodPtr : " + obj.GetType().FullName);
            }
#endif
            IntPtr res = callObjectMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public IntPtr GetObjectFieldPtr(IJvmProxy obj, FieldId fieldID)
        {
            IntPtr res = getObjectField(envPtr, obj.JvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public IntPtr GetStaticObjectFieldPtr(Class clazz, FieldId fieldID)
        {
            IntPtr res = getStaticObjectField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public IntPtr CallStaticObjectMethodPtr(Class clazz, MethodId methodIdNative, params Value[] args)
        {
#if DEBUG
            if (Bridge.Setup.VeryVerbose)
            {
                Console.WriteLine("CallStaticObjectMethodPtr : " + clazz.FullName);
            }
#endif
            IntPtr res = callStaticObjectMethod(envPtr, clazz.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
    }
}