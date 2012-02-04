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
using java.lang;

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        public unsafe IntPtr NewBooleanArray(bool[] array)
        {
            IntPtr res = Functions.newBooleanArray(envPtr, array.Length);
            fixed (bool* p = array)
            {
                Functions.setBooleanArrayRegion(envPtr, res, 0, array.Length, (byte*) p);
            }
            ExceptionTest();
            return res;
        }

        public unsafe IntPtr NewByteArray(byte[] array)
        {
            IntPtr res = Functions.newByteArray(envPtr, array.Length);
            fixed (byte* p = array)
            {
                Functions.setByteArrayRegion(envPtr, res, 0, array.Length, p);
            }
            ExceptionTest();
            return res;
        }

        public unsafe IntPtr NewCharArray(char[] array)
        {
            IntPtr res = Functions.newCharArray(envPtr, array.Length);
            fixed (char* p = array)
            {
                Functions.setCharArrayRegion(envPtr, res, 0, array.Length, p);
            }
            ExceptionTest();
            return res;
        }

        public unsafe IntPtr NewShortArray(short[] array)
        {
            IntPtr res = Functions.newShortArray(envPtr, array.Length);
            fixed (short* p = array)
            {
                Functions.setShortArrayRegion(envPtr, res, 0, array.Length, p);
            }
            ExceptionTest();
            return res;
        }

        public unsafe IntPtr NewIntArray(int[] array)
        {
            IntPtr res = Functions.newIntArray(envPtr, array.Length);
            fixed (int* p = array)
            {
                Functions.setIntArrayRegion(envPtr, res, 0, array.Length, p);
            }
            ExceptionTest();
            return res;
        }

        public unsafe IntPtr NewLongArray(long[] array)
        {
            IntPtr res = Functions.newLongArray(envPtr, array.Length);
            fixed (long* p = array)
            {
                Functions.setLongArrayRegion(envPtr, res, 0, array.Length, p);
            }
            ExceptionTest();
            return res;
        }

        public unsafe IntPtr NewFloatArray(float[] array)
        {
            IntPtr res = Functions.newFloatArray(envPtr, array.Length);
            fixed (float* p = array)
            {
                Functions.setFloatArrayRegion(envPtr, res, 0, array.Length, p);
            }
            ExceptionTest();
            return res;
        }

        public unsafe IntPtr NewDoubleArray(double[] array)
        {
            IntPtr res = Functions.newDoubleArray(envPtr, array.Length);
            fixed (double* p = array)
            {
                Functions.setDoubleArrayRegion(envPtr, res, 0, array.Length, p);
            }
            ExceptionTest();
            return res;
        }

        public IntPtr NewObjectArray(IClass clazz, int length)
        {
            IntPtr res = Functions.newObjectArray(envPtr, length, clazz.JvmHandle, IntPtr.Zero);
            ExceptionTest();
            return res;
        }

        public int GetArrayLength(IntPtr array)
        {
            int res = Functions.getArrayLength(envPtr, array);
            ExceptionTest();
            return res;
        }

        public IntPtr GetObjectArrayElement(IntPtr array, int index)
        {
            IntPtr res = Functions.getObjectArrayElement(envPtr, array, index);
            ExceptionTest();
            return res;
        }

        public void SetObjectArrayElement(IntPtr array, int index, IntPtr obj)
        {
            Functions.setObjectArrayElement(envPtr, array, index, obj);
            ExceptionTest();
        }

        public string GetStringArrayElement(IntPtr array, int index)
        {
            IntPtr ptr = Functions.getObjectArrayElement(envPtr, array, index);
            if(ptr==IntPtr.Zero)
            {
                return null;
            }
            var res = GetString(ptr);
            ExceptionTest();
            return res;
        }

        public unsafe bool[] GetBooleanArray(IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = Functions.getArrayLength(envPtr, array);
            var value1 = new bool[length];
            fixed (bool* p = value1)
            {
                Functions.getBooleanArrayRegion(envPtr, array, 0, length, (byte*)p);
            }
            bool[] value = value1;
            ExceptionTest();
            return value;
        }

        public unsafe byte[] GetByteArray(IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = Functions.getArrayLength(envPtr, array);
            var value1 = new byte[length];
            fixed (byte* p = value1)
            {
                Functions.getByteArrayRegion(envPtr, array, 0, value1.Length, p);
            }
            byte[] value = value1;
            ExceptionTest();
            return value;
        }

        public unsafe char[] GetCharArray(IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = Functions.getArrayLength(envPtr, array);
            var value1 = new char[length];
            fixed (char* p = value1)
            {
                Functions.getCharArrayRegion(envPtr, array, 0, value1.Length, p);
            }
            char[] value = value1;
            ExceptionTest();
            return value;
        }

        public unsafe short[] GetShortArray(IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = Functions.getArrayLength(envPtr, array);
            var value1 = new short[length];
            fixed (short* p = value1)
            {
                Functions.getShortArrayRegion(envPtr, array, 0, value1.Length, p);
            }
            short[] value = value1;
            ExceptionTest();
            return value;
        }

        public unsafe int[] GetIntArray(IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = Functions.getArrayLength(envPtr, array);
            var value1 = new int[length];
            fixed (int* p = value1)
            {
                Functions.getIntArrayRegion(envPtr, array, 0, value1.Length, p);
            }
            int[] value = value1;
            ExceptionTest();
            return value;
        }

        public unsafe long[] GetLongArray(IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = Functions.getArrayLength(envPtr, array);
            var value1 = new long[length];
            fixed (long* p = value1)
            {
                Functions.getLongArrayRegion(envPtr, array, 0, value1.Length, p);
            }
            long[] value = value1;
            ExceptionTest();
            return value;
        }

        public unsafe float[] GetFloatArray(IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = Functions.getArrayLength(envPtr, array);
            var value1 = new float[length];
            fixed (float* p = value1)
            {
                Functions.getFloatArrayRegion(envPtr, array, 0, value1.Length, p);
            }
            float[] value = value1;
            ExceptionTest();
            return value;
        }

        public unsafe double[] GetDoubleArray(IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = Functions.getArrayLength(envPtr, array);
            var value1 = new double[length];
            fixed (double* p = value1)
            {
                Functions.getDoubleArrayRegion(envPtr, array, 0, value1.Length, p);
            }
            double[] value = value1;
            ExceptionTest();
            return value;
        }
    }
}
