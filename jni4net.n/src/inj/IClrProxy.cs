#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.inj
{
    public partial interface IClrProxy : IJvmProxy
    {
        long getClrHandle();

        void initProxy(long par0);
    }

    internal partial class __IClrProxy
    {
        private static long getClrHandle(JNIEnv env, JniHandle obj)
        {
            return env.CallLongMethod(obj, _getClrHandle0);
        }

        internal static object GetObject(JNIEnv env, JniHandle obj)
        {
            long handle = getClrHandle(env, obj);
            if (handle==0)
            {
                return null;
            }
            object real = IntHandle.ToObject(handle);
            return real;
        }

        internal static IClrProxy CreateProxy(JNIEnv env, JniLocalHandle obj)
        {
            IClrProxy proxy = new __IClrProxy(env);
            proxy.Init(env, obj);
            return proxy;
        }
    }
}