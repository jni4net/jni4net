using System;
using java.lang;
using net.sf.jni4net.jni;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static TRes ArrayFullJ2C<TRes, TElem>(JNIEnv env, IntPtr array)
            where TRes : class //should be TRes : Array
        {
            if (array == IntPtr.Zero)
            {
                return default(TRes);
            }
            int length = env.GetArrayLength(array);
            var res = new TElem[length];
            for (int i = 0; i < length; i++)
            {
                IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                var element = FullJ2C<TElem>(env, elementPtr);
                res.SetValue(element, i);
            }
            return (TRes) (object) res;
        }

        public static TRes ArrayStrongJp2C<TRes, TElem>(JNIEnv env, IntPtr array)
            where TRes : class //should be TRes : Array
        {
            if (array == IntPtr.Zero)
            {
                return default(TRes);
            }
            int length = env.GetArrayLength(array);
            var res = new TElem[length];
            for (int i = 0; i < length; i++)
            {
                IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                var element = StrongJp2C<TElem>(env, elementPtr);
                res.SetValue(element, i);
            }
            return (TRes) (object) res;
        }

        public static TRes ArrayStrongJ2Cp<TRes, TElem>(JNIEnv env, IntPtr array)
            where TElem : IJavaProxy
            where TRes : class //should be TRes : Array
        {
            if (array == IntPtr.Zero)
            {
                return default(TRes);
            }
            int length = env.GetArrayLength(array);
            var res = new TElem[length];
            for (int i = 0; i < length; i++)
            {
                IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                var element = StrongJ2Cp<TElem>(env, elementPtr);
                res.SetValue(element, i);
            }
            return (TRes) (object) res;
        }

        #region Well known

        public static String[] ArrayStrongJ2CpString(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new String[length];
            for (int i = 0; i < length; i++)
            {
                IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                String element = StrongJ2CpString(env, elementPtr);
                res.SetValue(element, i);
            }
            return res;
        }

        public static string[] ArrayStrongJp2CString(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new string[length];
            for (int i = 0; i < length; i++)
            {
                IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                String element = StrongJp2CString(env, elementPtr);
                res.SetValue(element, i);
            }
            return res;
        }

        public static Class[] ArrayStrongJ2CpClass(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new Class[length];
            for (int i = 0; i < length; i++)
            {
                IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                Class element = StrongJ2CpClass(env, elementPtr);
                res.SetValue(element, i);
            }
            return res;
        }

        #endregion

        #region Primitive

        public static byte[] ArrayPrimJ2Cbyte(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new byte[length];
            env.GetByteArrayRegion(array, 0, length, res);
            return res;
        }

        public static bool[] ArrayPrimJ2Cboolean(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new bool[length];
            env.GetBooleanArrayRegion(array, 0, length, res);
            return res;
        }

        public static char[] ArrayPrimJ2Cchar(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new char[length];
            env.GetCharArrayRegion(array, 0, length, res);
            return res;
        }

        public static short[] ArrayPrimJ2Cshort(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new short[length];
            env.GetShortArrayRegion(array, 0, length, res);
            return res;
        }

        public static int[] ArrayPrimJ2Cint(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new int[length];
            env.GetIntArrayRegion(array, 0, length, res);
            return res;
        }

        public static long[] ArrayPrimJ2Clong(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new long[length];
            env.GetLongArrayRegion(array, 0, length, res);
            return res;
        }

        public static double[] ArrayPrimJ2Cdouble(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new double[length];
            env.GetDoubleArrayRegion(array, 0, length, res);
            return res;
        }

        public static float[] ArrayPrimJ2Cfloat(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new float[length];
            env.GetFloatArrayRegion(array, 0, length, res);
            return res;
        }

        #endregion
    }
}
