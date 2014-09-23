#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static JniHandle StrongC2Jp<TBoth>(JNIEnv env, TBoth obj)
        {
            // ReSharper disable CompareNonConstrainedGenericWithNull
            if (obj == null)
            {
                return JniLocalHandle.Zero;
            }
            // ReSharper restore CompareNonConstrainedGenericWithNull
            RegistryRecord record = Registry.GetCLRRecord(obj.GetType());
            return record.CreateJVMProxy(env, obj);
        }

        public static JniGlobalHandle StrongCp2J(IJvmProxy obj)
        {
            if (obj == null)
            {
                return JniGlobalHandle.Zero;
            }
            return obj.JvmHandle;
        }

        public static JniHandle StrongC2JDelegate(JNIEnv env, Delegate obj)
        {
            if (obj == null)
            {
                return JniLocalHandle.Zero;
            }
            IJvmProxy proxy = obj.Target as IJvmProxy;
            if (proxy != null)
            {
                return proxy.JvmHandle;
            }
            RegistryRecord record = Registry.GetCLRRecord(obj.GetType());
            return record.CreateJVMProxy(env, obj);
        }

        public static JniLocalHandle StrongC2JString(JNIEnv env, string obj)
        {
            if (obj == null)
            {
                return JniLocalHandle.Zero;
            }
            return env.NewStringPtr(obj);
        }
    }
}