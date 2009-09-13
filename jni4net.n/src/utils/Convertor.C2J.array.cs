using System;
using java.lang;
using net.sf.jni4net.jni;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static IntPtr ArrayStrongC2Jp<TBoth, TElem>(JNIEnv env, TBoth obj)
            where TBoth : class
            //should be where TBoth : Array
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
#if  DEBUG
            if (!typeof (TBoth).IsArray)
            {
                throw new ArgumentException("Must be array type");
            }
            if (typeof (TBoth).GetElementType() != typeof (TElem))
            {
                throw new ArgumentException("Must be array of type" + typeof (TElem));
            }
#endif
            var array = (Array) (object) obj;
            int length = array.Length;
            Type elementType = typeof (TBoth).GetElementType();
            Class elemClazz = Registry.Default.GetCLRRecord(elementType).JVMInterface;

            IntPtr res = env.NewObjectArrayPtr(length, elemClazz.native, null);
            for (int i = 0; i < length; i++)
            {
                IntPtr item = StrongC2Jp(env, (TElem) array.GetValue(i));
                env.SetObjectArrayElement(res, i, item);
            }
            return res;
        }

        public static IntPtr ArrayStrongCp2J<TBoth>(JNIEnv env, TBoth obj)
            where TBoth : class
            //should be where TBoth : IJavaProxy[]
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
#if  DEBUG
            if (!typeof (TBoth).IsArray)
            {
                throw new ArgumentException("Must be array type");
            }
#endif
            var array = (Array) (object) obj;
            int length = array.Length;
            Type elementType = typeof (TBoth).GetElementType();
            Class elemClazz = Registry.Default.GetCLRRecord(elementType).JVMInterface;
            IntPtr res = env.NewObjectArrayPtr(length, elemClazz.native, null);
            for (int i = 0; i < length; i++)
            {
                IntPtr item = StrongCp2J((IJavaProxy) array.GetValue(i));
                env.SetObjectArrayElement(res, i, item);
            }
            return res;
        }

        #region Primitive Array

        public static IntPtr ArrayStrongC2JString(JNIEnv env, string[] array)
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

        public static IntPtr ArrayPrimC2J(JNIEnv env, int[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            int length = value.Length;
            IntPtr res = env.NewIntArrayPtr(length);
            env.SetIntArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, long[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            int length = value.Length;
            IntPtr res = env.NewLongArrayPtr(length);
            env.SetLongArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, short[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            int length = value.Length;
            IntPtr res = env.NewShortArrayPtr(length);
            env.SetShortArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, byte[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            int length = value.Length;
            IntPtr res = env.NewByteArrayPtr(length);
            env.SetByteArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, char[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            int length = value.Length;
            IntPtr res = env.NewCharArrayPtr(length);
            env.SetCharArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, double[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            int length = value.Length;
            IntPtr res = env.NewDoubleArrayPtr(length);
            env.SetDoubleArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, float[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            int length = value.Length;
            IntPtr res = env.NewFloatArrayPtr(length);
            env.SetFloatArrayRegion(res, 0, length, value);
            return res;
        }

        public static IntPtr ArrayPrimC2J(JNIEnv env, bool[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            int length = value.Length;
            IntPtr res = env.NewBooleanArrayPtr(length);
            env.SetBooleanArrayRegion(res, 0, length, value);
            return res;
        }

        #endregion
    }
}
