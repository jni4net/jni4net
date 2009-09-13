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
using java.lang;
using net.sf.jni4net.utils;
using Object=java.lang.Object;

namespace net.sf.jni4net.jni
{
    unsafe partial class JNIEnv
    {
        #region NewArray

        public Object NewObjectArray(int len, Class clazz, IJavaProxy init)
        {
            IntPtr res = NewObjectArrayPtr(len, clazz.native, init);
            return Convertor.StrongJ2CpObject(this, res);
        }

        internal Object NewBooleanArray(int len)
        {
            IntPtr res = NewBooleanArrayPtr(len);
            return Convertor.StrongJ2CpObject(this, res);
        }

        internal Object NewByteArray(int len)
        {
            IntPtr res = NewByteArrayPtr(len);
            return Convertor.StrongJ2CpObject(this, res);
        }

        internal Object NewShortArray(int len)
        {
            IntPtr res = NewShortArrayPtr(len);
            return Convertor.StrongJ2CpObject(this, res);
        }

        internal Object NewCharArray(int len)
        {
            IntPtr res = NewCharArrayPtr(len);
            return Convertor.StrongJ2CpObject(this, res);
        }

        internal Object NewIntArray(int len)
        {
            IntPtr res = NewIntArrayPtr(len);
            return Convertor.StrongJ2CpObject(this, res);
        }

        internal Object NewLongArray(int len)
        {
            IntPtr res = NewLongArrayPtr(len);
            return Convertor.StrongJ2CpObject(this, res);
        }

        internal Object NewFloatArray(int len)
        {
            IntPtr res = NewFloatArrayPtr(len);
            return Convertor.StrongJ2CpObject(this, res);
        }

        internal Object NewDoubleArray(int len)
        {
            IntPtr res = NewDoubleArrayPtr(len);
            return Convertor.StrongJ2CpObject(this, res);
        }

        #endregion

        #region SetRegion

        internal void SetIntArrayRegion(IntPtr array, int start, int len, int[] buf)
        {
            fixed (int* ptr = &buf[0])
            {
                setIntArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetBooleanArrayRegion(IntPtr array, int start, int len, bool[] buf)
        {
            fixed (bool* ptr = &buf[0])
            {
                setBooleanArrayRegion(native, array, start, len, (byte*) ptr);
            }
            ExceptionTest();
        }

        internal void SetByteArrayRegion(IntPtr array, int start, int len, byte[] buf)
        {
            fixed (byte* ptr = &buf[0])
            {
                setByteArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetCharArrayRegion(IntPtr array, int start, int len, char[] buf)
        {
            fixed (char* ptr = &buf[0])
            {
                setCharArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetShortArrayRegion(IntPtr array, int start, int len, short[] buf)
        {
            fixed (short* ptr = &buf[0])
            {
                setShortArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetLongArrayRegion(IntPtr array, int start, int len, long[] buf)
        {
            fixed (long* ptr = &buf[0])
            {
                setLongArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetFloatArrayRegion(IntPtr array, int start, int len, float[] buf)
        {
            fixed (float* ptr = &buf[0])
            {
                setFloatArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetDoubleArrayRegion(IntPtr array, int start, int len, double[] buf)
        {
            fixed (double* ptr = &buf[0])
            {
                setDoubleArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        #endregion

        #region GetRegion

        internal void GetIntArrayRegion(IntPtr array, int start, int len, int[] buf)
        {
            fixed (int* ptr = &buf[0])
            {
                getIntArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetCharArrayRegion(IntPtr array, int start, int len, char[] buf)
        {
            fixed (char* ptr = &buf[0])
            {
                getCharArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetByteArrayRegion(IntPtr array, int start, int len, byte[] buf)
        {
            fixed (byte* ptr = &buf[0])
            {
                getByteArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetShortArrayRegion(IntPtr array, int start, int len, short[] buf)
        {
            fixed (short* ptr = &buf[0])
            {
                getShortArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetLongArrayRegion(IntPtr array, int start, int len, long[] buf)
        {
            fixed (long* ptr = &buf[0])
            {
                getLongArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetFloatArrayRegion(IntPtr array, int start, int len, float[] buf)
        {
            fixed (float* ptr = &buf[0])
            {
                getFloatArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetDoubleArrayRegion(IntPtr array, int start, int len, double[] buf)
        {
            fixed (double* ptr = &buf[0])
            {
                getDoubleArrayRegion(native, array, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetBooleanArrayRegion(IntPtr array, int start, int len, bool[] buf)
        {
            fixed (bool* ptr = &buf[0])
            {
                getBooleanArrayRegion(native, array, start, len, (byte*) ptr);
            }
            ExceptionTest();
        }

        #endregion

        internal int GetArrayLength(Object array)
        {
            return GetArrayLength(array.native);
        }

        internal int GetArrayLength(IntPtr array)
        {
            int res = getArrayLength(native, array);
            ExceptionTest();
            return res;
        }

        public void SetObjectArrayElement(Object array, int index, IJavaProxy val)
        {
            SetObjectArrayElement(array, index, val == null ? IntPtr.Zero : val.Native);
        }

        public void SetObjectArrayElement(Object array, int index, IntPtr val)
        {
            SetObjectArrayElement(array.native, index, val);
        }

        public void SetObjectArrayElement(IntPtr array, int index, IntPtr val)
        {
            setObjectArrayElement(native, array, index, val);
            ExceptionTest();
        }
    }
}