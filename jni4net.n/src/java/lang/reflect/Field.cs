#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

#if !JNI4NET_MINI
using java_.lang.reflect;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.lang.reflect
{
    partial class Field : _Member
    {
        public string GetSignature()
        {
            return Registry.JavaSignature(getType());
        }

        public FieldId GetMethodId()
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            return env.FromReflectedField(this);
        }
    }
}

#endif