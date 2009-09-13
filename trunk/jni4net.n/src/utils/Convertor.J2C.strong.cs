using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static TRes StrongJp2C<TRes>(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return default(TRes);
            }
            object res = __IClrProxy.GetObject(env, obj);
            return (TRes)res;
        }


        public static TRes StrongJ2Cp<TRes>(JNIEnv env, IntPtr obj)
            where TRes : IJavaProxy
        {
            if (obj == IntPtr.Zero)
            {
                return default(TRes);
            }
            Class clazz = env.GetObjectClass(obj);
            RegistryRecord record = Registry.Default.GetJVMRecord(clazz);
            return (TRes) record.CreateCLRProxy(env, obj, clazz);
        }

        #region Well known

        public static string StrongJp2CString(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            object res = __IClrProxy.GetObject(env, obj);
            return (string)res;
        }

        public static String StrongJ2CpString(JNIEnv env, IntPtr obj)
        {
            if (obj==IntPtr.Zero)
            {
                return null;
            }
            return String.CreateProxy(env, obj);
        }

        public static Class StrongJ2CpClass(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            return Class.CreateProxy(env, obj);
        }

        public static Object StrongJ2CpObject(JNIEnv env, IntPtr obj)
        {
            Object res = new Object(env);
            ((IJavaProxy)res).Init(env, obj, Object._class);
            return res;
        }

        #endregion
    }
}
