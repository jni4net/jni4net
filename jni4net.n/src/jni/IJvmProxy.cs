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
    public interface IJvmProxy : IObject
    {
        JniGlobalHandle JvmHandle { get; }

        void Init(JNIEnv env, JniLocalHandle obj);

        void Copy(JNIEnv env, JniGlobalHandle obj);
    }
}