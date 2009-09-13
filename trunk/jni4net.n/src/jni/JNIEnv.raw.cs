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
            IntPtr res = newIntArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr GetObjectArrayElementPtr(IntPtr array, int index)
        {
            IntPtr res = getObjectArrayElement(native, array, index);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewStringPtr(string unicode)
        {
            IntPtr uni = Marshal.StringToHGlobalUni(unicode);
            IntPtr res = newString(native, uni, unicode.Length);
            ExceptionTest();
            Marshal.FreeHGlobal(uni);
            return res;
        }

        internal IntPtr GetStringChars(IntPtr str, byte* isCopy)
        {
            IntPtr res = getStringChars(native, str, isCopy);
            ExceptionTest();
            return res;
        }

        internal void ReleaseStringChars(IntPtr str, IntPtr chars)
        {
            releaseStringChars(native, str, chars);
            ExceptionTest();
        }

        internal IntPtr NewObjectArrayPtr(int len, IntPtr clazz, IJavaProxy init)
        {
            IntPtr res = newObjectArray(native, len, clazz, init == null ? IntPtr.Zero : init.Native);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewCharArrayPtr(int len)
        {
            IntPtr res = newCharArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewShortArrayPtr(int len)
        {
            IntPtr res = newShortArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewByteArrayPtr(int len)
        {
            IntPtr res = newByteArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewBooleanArrayPtr(int len)
        {
            IntPtr res = newBooleanArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewLongArrayPtr(int len)
        {
            IntPtr res = newLongArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewFloatArrayPtr(int len)
        {
            IntPtr res = newFloatArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewDoubleArrayPtr(int len)
        {
            IntPtr res = newDoubleArray(native, len);
            ExceptionTest();
            return res;
        }

        public IntPtr CallObjectMethodPtr(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            IntPtr res = callObjectMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public IntPtr GetObjectFieldPtr(IJavaProxy obj, FieldId fieldID)
        {
            IntPtr res = getObjectField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public IntPtr GetStaticObjectFieldPtr(Class clazz, FieldId fieldID)
        {
            IntPtr res = getStaticObjectField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public IntPtr CallStaticObjectMethodPtr(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            IntPtr res = callStaticObjectMethod(native, clazz.native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
    }
}