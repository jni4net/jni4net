using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using String=System.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static T J2C<T>(JNIEnv env, IntPtr obj)
        {
            var clrType = typeof (T);
            //TODO all sealed ?
            if (clrType == typeof(Class))
            {
                var nclazz = new Class(env);
                ((IJavaProxy)nclazz).Init(env, obj, Class._class);
                return (T)(object)nclazz;
            }
            if (clrType == typeof(String))
            {
                var nstring = new java.lang.String(env);
                ((IJavaProxy)nstring).Init(env, obj, java.lang.String._class);
                return (T)(object)nstring;
            }
            if (typeof(IJavaProxy).IsAssignableFrom(clrType))
            {
                return (T)OptiJ2CP(env, obj);
            }
            if (clrType.IsArray)
            {
                return (T)(object) J2CArray(env, obj, typeof (T).GetElementType());
            }
            return (T)J2C(env, obj);
        }

        public static T OptiJ2CP<T>(JNIEnv env, IntPtr obj)
            where T : class, IJavaProxy
        {
            var clrType = typeof(T);
            //TODO all sealed ?
            if (clrType == typeof(Class))
            {
                var nclazz = new Class(env);
                ((IJavaProxy)nclazz).Init(env, obj, Class._class);
                return (T)(object)nclazz;
            }
            if (clrType == typeof(String))
            {
                var nstring = new java.lang.String(env);
                ((IJavaProxy)nstring).Init(env, obj, java.lang.String._class);
                return (T)(object)nstring;
            }
            return OptiJ2CP(env, obj) as T;
        }

        public static T OptiJP2C<T>(JNIEnv env, IntPtr obj)
        {
            return (T) OptiJP2C(env, obj);
        }
    }
}
