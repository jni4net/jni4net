using System;
using java.lang;
using net.sf.jni4net.jni;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static IntPtr StrongC2Jp<TBoth>(JNIEnv env, TBoth obj)
        {
            // ReSharper disable CompareNonConstrainedGenericWithNull
            if (obj == null)
            // ReSharper restore CompareNonConstrainedGenericWithNull
            {
                return IntPtr.Zero;
            }
            RegistryRecord record = Registry.Default.GetCLRRecord(typeof(TBoth));
            return record.CreateJVMProxy(env, obj);
        }

        public static IntPtr StrongC2J(JNIEnv env, string obj)
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            return env.NewStringPtr(obj);
        }

        public static IntPtr ArrayStrongC2J(JNIEnv env, string[] array)
        {
            if (array == null)
            {
                return IntPtr.Zero;
            }
            int length = array.Length;
            IntPtr res = env.NewObjectArrayPtr(length, String._class.native, null);
            for (int i = 0; i < length; i++)
            {
                IntPtr item = env.NewStringPtr(array[i]);
                env.SetObjectArrayElement(res, i, item);
            }
            return res;
        }

        public static IntPtr StrongCp2J(IJavaProxy obj)
        {
            if (obj==null)
            {
                return IntPtr.Zero;
            }
            return obj.Native;
        }

        public static IntPtr ArrayStrongC2Jp<TBoth>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            Type elementType = typeof(TBoth).GetElementType();
            return ArrayC2J(env, (Array)(object)obj, elementType);
        }

        public static IntPtr ArrayStrongCp2J<TBoth>(JNIEnv env, TBoth obj)
                    where TBoth : class
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            Array array = (Array)(object)obj;
            int length = array.Length;
            Type elementType = typeof(TBoth).GetElementType();
            Class elemClazz = Registry.Default.GetCLRRecord(elementType).JVMInterface;
            IntPtr res = env.NewObjectArrayPtr(length, elemClazz.native, null);
            for (int i = 0; i < length; i++)
            {
                IntPtr item = StrongCp2J((IJavaProxy)array.GetValue(i));
                env.SetObjectArrayElement(res, i, item);
            }
            return res;
        }

        #region Primitive Array

        public static IntPtr ArrayPrimC2J(JNIEnv env, int[] value)
        {
            int length = value.Length;
            IntPtr res = env.NewIntArrayPtr(length);
            env.SetIntArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, long[] value)
        {
            int length = value.Length;
            IntPtr res = env.NewLongArrayPtr(length);
            env.SetLongArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, short[] value)
        {
            int length = value.Length;
            IntPtr res = env.NewShortArrayPtr(length);
            env.SetShortArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, byte[] value)
        {
            int length = value.Length;
            IntPtr res = env.NewByteArrayPtr(length);
            env.SetByteArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, char[] value)
        {
            int length = value.Length;
            IntPtr res = env.NewCharArrayPtr(length);
            env.SetCharArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, double[] value)
        {
            int length = value.Length;
            IntPtr res = env.NewDoubleArrayPtr(length);
            env.SetDoubleArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, float[] value)
        {
            int length = value.Length;
            IntPtr res = env.NewFloatArrayPtr(length);
            env.SetFloatArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, bool[] value)
        {
            int length = value.Length;
            IntPtr res = env.NewBooleanArrayPtr(length);
            env.SetBooleanArrayRegion(res, 0, length, value);
            return res;
        }

        #endregion
    }
}
