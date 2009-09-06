using System;
using java.lang;
using net.sf.jni4net.jni;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static T J2C<T>(JNIEnv env, IntPtr obj)
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
            if (clrType == typeof (string))
            {
                return (T)(object)env.ConvertToString(obj);
            }
            if (typeof (IJavaProxy).IsAssignableFrom(clrType))
            {
                return (T) OptiJ2CP(env, obj);
            }
            if (clrType.IsArray)
            {
                return (T) (object) J2CArray(env, obj, typeof (T).GetElementType());
            }
            return (T) J2C(env, obj);
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

        public static IntPtr C2J<TRes>(JNIEnv env, object obj)
        {
            return C2J(env, obj);
        }
    }
}
