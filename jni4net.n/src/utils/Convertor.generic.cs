using System;
using java.lang;
using net.sf.jni4net.jni;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static TRes J2C<TInput, TRes>(JNIEnv env, IntPtr obj)
        {
            return J2C<TRes>(env, obj);
        }

        public static TBoth J2C<TBoth>(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return default(TBoth);
            }
            Type clrType = typeof (TBoth);
            //TODO all sealed ?
            if (clrType == typeof (Class))
            {
                var nclazz = new Class(env);
                ((IJavaProxy) nclazz).Init(env, obj, Class._class);
                return (TBoth) (object) nclazz;
            }
            if (clrType == typeof (String))
            {
                var nstring = new String(env);
                ((IJavaProxy) nstring).Init(env, obj, String._class);
                return (TBoth) (object) nstring;
            }
            if (clrType == typeof (string))
            {
                return (TBoth)(object)env.ConvertToString(obj);
            }
            if (typeof (IJavaProxy).IsAssignableFrom(clrType))
            {
                return (TBoth) OptiJ2CP(env, obj);
            }
            if (clrType.IsArray)
            {
                return (TBoth) (object) J2CArray(env, obj, typeof (TBoth).GetElementType());
            }
            return (TBoth) J2C(env, obj);
        }

        public static T OptiJ2CP<T>(JNIEnv env, IntPtr obj)
            where T : class, IJavaProxy
        {
            if (obj == IntPtr.Zero)
            {
                return default(T);
            }
            Type clrType = typeof (T);
            //TODO all sealed ?
            if (clrType == typeof (Class))
            {
                var nclazz = new Class(env);
                ((IJavaProxy) nclazz).Init(env, obj, Class._class);
                return (T) (object) nclazz;
            }
            if (clrType == typeof (String))
            {
                var nstring = new String(env);
                ((IJavaProxy) nstring).Init(env, obj, String._class);
                return (T) (object) nstring;
            }
            return OptiJ2CP(env, obj) as T;
        }

        public static T OptiJP2C<T>(JNIEnv env, IntPtr obj)
        {
            return (T) OptiJP2C(env, obj);
        }

        public static IntPtr C2J<TBoth>(JNIEnv env, TBoth obj)
        {
            return C2J(env, obj);
        }

        public static IntPtr C2J<TRes, TInput>(JNIEnv env, TInput obj)
        {
            return C2J(env, obj);
        }
    }
}
