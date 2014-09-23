#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using java.lang;
using java_.lang;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        public IObject NewObject(Class clazz, string method, string sig, params object[] args)
        {
            MethodId idNative = GetMethodID(clazz, method, sig);
            if (idNative != null)
            {
                return NewObject(clazz, idNative, Convertor.ConverArgs(this, args));
            }
            throw new ArgumentException();
        }

        public TRes CallStaticMethod<TRes>(Class clazz, string method, string sig, params object[] args)
        {
            return CallStaticMethod<TRes>(clazz, method, sig, Convertor.ConverArgs(this, args));
        }

        public void CallVoidMethod(IJvmProxy obj, string method, string signature, params object[] args)
        {
            CallVoidMethod(obj, method, signature, Convertor.ConverArgs(this, args));
        }

        public bool CallBooleanMethod(IJvmProxy obj, string method, string sig, params object[] args)
        {
            return CallBooleanMethod(obj, method, sig, Convertor.ConverArgs(this, args));
        }

        public int CallIntMethod(IJvmProxy obj, string method, string signature, params object[] args)
        {
            return CallIntMethod(obj, method, signature, Convertor.ConverArgs(this, args));
        }

        public TRes CallMethod<TRes>(IJvmProxy obj, string method, string sig, params object[] args)
        {
            return CallMethod<TRes>(obj, method, sig, Convertor.ConverArgs(this, args));
        }
    }
}