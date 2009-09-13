using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net
{
    partial class Bridge
    {
        public static bool IsCLRInstance(object obj)
        {
            IJavaProxy proxy = obj as IJavaProxy;
            if (proxy!=null)
            {
                IClrProxy clrProxy = proxy as IClrProxy;
                if (clrProxy != null)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        public static bool IsJVMInstance(object obj)
        {
            return !IsCLRInstance(obj);
        }

        public static IClrProxy WrapCLR(object obj)
        {
            IJavaProxy proxy = obj as IJavaProxy;
            IClrProxy clrProxy = proxy as IClrProxy;
            if (proxy != null)
            {
                if (clrProxy != null)
                {
                    return clrProxy;
                }
                throw new JNIException("Can't wrap JVM instance");
            }
            Type type = obj.GetType();
            JNIEnv env = JNIEnv.ThreadEnv;

            RegistryRecord record = Registry.Default.GetCLRRecord(type);
            IntPtr ptr = record.CreateJVMProxy(env, obj);
            return __IClrProxy.CreateProxy(env, ptr, record.JVMProxy);
        }

        public static TRes UnwrapCLR<TRes>(IJavaProxy obj)
        {
            return Convertor.J2C<TRes>(JNIEnv.ThreadEnv, obj.Native);
        }

        public static object WrapJVM(IJavaProxy obj, Class interfaceClass)
        {
            IClrProxy clrProxy = obj as IClrProxy;
            if (clrProxy!=null)
            {
                return Convertor.J2C<object>(JNIEnv.ThreadEnv, obj.Native);
            }
            return obj;
        }

        public static IJavaProxy UnwrapJVM(object obj, Class interfaceClass)
        {
            return Convertor.C2JWrapper(JNIEnv.ThreadEnv, obj);
        }

        public static IJavaProxy UnwrapJVM(System.Exception obj, Class interfaceClass)
        {
            return Convertor.C2JWrapper(JNIEnv.ThreadEnv, obj);
        }
    }
}
