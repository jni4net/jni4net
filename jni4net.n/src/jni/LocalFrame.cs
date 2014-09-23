#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.jni
{
    public class LocalFrame : IDisposable
    {
        private readonly JNIEnv env;

        public LocalFrame(JNIEnv env, int size)
        {
            this.env = env;
            env.PushLocalFrame(size);
        }

        public LocalFrame(JNIEnv env)
            : this(env, 10)
        {
        }

        #region IDisposable Members

        public void Dispose()
        {
            env.PopLocalFrame(JniLocalHandle.Zero);
        }

        #endregion
    }
}