using System;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static IntPtr FinalC2Jp<TBoth>(JNIEnv env, TBoth obj)
        {
            RegistryRecord record = Registry.Default.GetCLRRecord(typeof(TBoth));
            return record.CreateJVMProxy(env, obj);
        }

        public static IntPtr FinalC2J(JNIEnv env, string obj)
        {
            return env.NewStringPtr(obj);
        }

        public static IntPtr FinalCp2J(IJavaProxy obj)
        {
            return obj.Native;
        }

        public static IntPtr ArrayC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            Type elementType = typeof(TBoth).GetElementType();
            return ArrayC2J(env, (Array)(object)obj, elementType);
        }

        public static IntPtr SameC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            return C2J(env, obj);
        }

        public static IntPtr ConvC2J<TRes, TIn>(JNIEnv env, TIn obj)
        {
            return C2J(env, obj);
        }

    }
}
