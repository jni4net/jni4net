using System;
using net.sf.jni4net.jni;

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
            RegistryRecord record = Registry.Default.GetCLRRecord(typeof (TBoth));
            return record.CreateJVMProxy(env, obj);
        }


        public static IntPtr StrongC2JString(JNIEnv env, string obj)
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            return env.NewStringPtr(obj);
        }


        public static IntPtr StrongCp2J(IJavaProxy obj)
        {
            if (obj == null)
            {
                return IntPtr.Zero;
            }
            return obj.Native;
        }
    }
}
