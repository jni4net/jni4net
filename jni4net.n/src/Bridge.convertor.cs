using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using String=java.lang.String;

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
            IClrProxy clrProxy = obj as IClrProxy;
            if (clrProxy == null)
            {
                throw new JNIException("Can't unwrap JVM instance");
            }
            int handle = clrProxy.getClrHandle();
            return (TRes)IntHandle.ToObject(handle);
        }

        /*public static TRes Convert<TRes>(IJavaProxy obj)
        {
            IClrProxy clrProxy = obj as IClrProxy;
            Type reqType = typeof(TRes);
            Type inType = obj.GetType();
            if (reqType==inType)
            {
                return (TRes) obj;
            }
            if (reqType==typeof(string))
            {
                if (clrProxy!=null)
                {
                    object real = UnwrapCLR<object>(obj);
                    Type realType = real.GetType();
                    if (!reqType.IsAssignableFrom(realType))
                    {
                        throw new InvalidCastException("Can't cast " + realType + " to " + reqType);
                    }
                    return (TRes)real;
                }
                if (inType == typeof(String))
                {
                    return (TRes)(object)(string)(String) obj;
                }
            }
            if (typeof(IJavaProxy).IsAssignableFrom(reqType))
            {
                
            }
            if (reqType.IsPrimitive)
            {
                
            }
            Class clazz = obj.getClass();
        }*/

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
