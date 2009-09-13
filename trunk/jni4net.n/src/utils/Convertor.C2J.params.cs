using System;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static Value ParStrongCp2J(IJavaProxy obj)
        {
            var res = new Value { _object = StrongCp2J(obj) };
            return res;
        }

        public static Value ParStrongC2Jp<TBoth>(JNIEnv env, TBoth obj)
        {
            var res = new Value { _object = StrongC2Jp<TBoth>(env, obj) };
            return res;
        }

        public static Value ParArrayFullC2J<TBoth>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            var res = new Value { _object = ArrayFullC2J<TBoth>(env, obj) };
            return res;
        }

        public static Value ParArrayStrongC2Jp<TBoth>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            var res = new Value { _object = ArrayStrongC2Jp<TBoth>(env, obj) };
            return res;
        }

        public static Value ParArrayStrongCp2J<TBoth>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            var res = new Value { _object = ArrayStrongCp2J<TBoth>(env, obj) };
            return res;
        }

        public static Value ParFullC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            var res = new Value { _object = FullC2J<TBoth>(env, obj) };
            return res;
        }

        public static Value ParStrongC2J(JNIEnv env, string obj)
        {
            var res = new Value { _object = StrongC2J(env, obj) };
            return res;
        }

        #region Primitive

        public static Value ParPrimC2J(int value)
        {
            var res = new Value { _int = value };
            return res;
        }

        public static Value ParPrimC2J(bool value)
        {
            var res = new Value { _bool = value ? (byte)1 : (byte)0 };
            return res;
        }

        public static Value ParPrimC2J(byte value)
        {
            var res = new Value { _byte = value };
            return res;
        }

        public static Value ParPrimC2J(char value)
        {
            var res = new Value { _char = (short)value };
            return res;
        }

        public static Value ParPrimC2J(short value)
        {
            var res = new Value { _short = value };
            return res;
        }

        public static Value ParPrimC2J(long value)
        {
            var res = new Value { _long = value };
            return res;
        }

        public static Value ParPrimC2J(float value)
        {
            var res = new Value { _float = value };
            return res;
        }

        public static Value ParPrimC2J(double value)
        {
            var res = new Value { _double = value };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, int[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value) };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, bool[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value) };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, byte[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value) };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, char[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value) };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, short[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value) };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, long[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value) };
            return res;
        }

        public static Value ParPrimC2J(JNIEnv env, float[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value) };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, double[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value) };
            return res;
        }

        #endregion

    }
}
