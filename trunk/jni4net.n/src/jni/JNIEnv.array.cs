using System;
using java.lang;
using net.sf.jni4net.utils;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.jni
{
    unsafe partial class JNIEnv
    {
        #region NewArray

        public Object NewObjectArray(int len, Class clazz, IJavaProxy init)
        {
            IntPtr res = NewObjectArrayPtr(len, clazz.native, init);
            return Convertor.OptiJ2CP<Object>(this, res);
        }

        internal Object NewBooleanArray(int len)
        {
            IntPtr res = NewBooleanArrayPtr(len);
            return Convertor.OptiJ2CP<Object>(this, res);
        }

        internal Object NewByteArray(int len)
        {
            IntPtr res = NewByteArrayPtr(len);
            return Convertor.OptiJ2CP<Object>(this, res);
        }

        internal Object NewShortArray(int len)
        {
            IntPtr res = NewShortArrayPtr(len);
            return Convertor.OptiJ2CP<Object>(this, res);
        }

        internal Object NewCharArray(int len)
        {
            IntPtr res = NewCharArrayPtr(len);
            return Convertor.OptiJ2CP<Object>(this, res);
        }

        internal Object NewIntArray(int len)
        {
            IntPtr res = NewIntArrayPtr(len);
            return Convertor.OptiJ2CP<Object>(this, res);
        }

        internal Object NewLongArray(int len)
        {
            IntPtr res = NewLongArrayPtr(len);
            return Convertor.OptiJ2CP<Object>(this, res);
        }

        internal Object NewFloatArray(int len)
        {
            IntPtr res = NewFloatArrayPtr(len);
            return Convertor.OptiJ2CP<Object>(this, res);
        }

        internal Object NewDoubleArray(int len)
        {
            IntPtr res = NewDoubleArrayPtr(len);
            return Convertor.OptiJ2CP<Object>(this, res);
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

        internal object GetObjectArrayElement(Object array, int index)
        {
            return GetObjectArrayElement(array.native, index);
        }

        internal object GetObjectArrayElement(IntPtr array, int index)
        {
            IntPtr res = GetObjectArrayElementPtr(array, index);
            return Convertor.J2C(this, res);
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
