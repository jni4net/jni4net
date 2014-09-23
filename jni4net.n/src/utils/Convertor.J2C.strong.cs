#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

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
        public static TRes StrongJp2C<TRes>(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return default(TRes);
            }
            object res = __IClrProxy.GetObject(env, obj);
            return (TRes)res;
        }


        public static TRes StrongJ2CpDelegate<TRes>(JNIEnv env, JniLocalHandle obj)
            where TRes : class //Delegate
        {
#if DEBUG
            if (!typeof(Delegate).IsAssignableFrom(typeof(TRes)))
            {
                throw new ArgumentException("expected delegate");
            }
#endif
            if (JniHandle.IsNull(obj))
            {
                return default(TRes);
            }
            object res = __IClrProxy.GetObject(env, obj);
            if (res == null)
            {
                //that's delegate implemented in Java
                RegistryRecord delRecord = Registry.GetCLRRecord(typeof(TRes));
                IJvmProxy jvmProxy = delRecord.CreateCLRProxy(env, obj);
                return (TRes)(object)Delegate.CreateDelegate(typeof(TRes), jvmProxy, delRecord.JVMDelegateInvoke);
            }
            return (TRes) res;
        }

        public static TRes StrongJ2Cp<TRes>(JNIEnv env, JniLocalHandle obj)
            where TRes : IJvmProxy
        {
            if (JniHandle.IsNull(obj))
            {
                return default(TRes);
            }
            Class clazz = env.GetObjectClass(obj);
            RegistryRecord record = Registry.GetJVMRecord(clazz);
            return (TRes) record.CreateCLRProxy(env, obj);
        }

        #region Well known

        public static string StrongJ2CString(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            string res = env.ConvertToString(obj);
            return res;
        }

        public static string StrongJp2CString(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            object res = __IClrProxy.GetObject(env, obj);
            return (string) res;
        }

        public static String StrongJ2CpString(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            return String.CreateProxy(env, obj);
        }

        public static Class StrongJ2CpClass(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            return Class.CreateProxy(env, obj);
        }

        public static Object StrongJ2CpObject(JNIEnv env, JniLocalHandle obj)
        {
            var res = new Object(env);
            ((IJvmProxy) res).Init(env, obj);
            return res;
        }

        #endregion
    }
}