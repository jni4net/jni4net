#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Runtime.Serialization;

namespace net.sf.jni4net.jni
{
    [Serializable]
    public class JNIException : Exception
    {
        protected JNIException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public JNIException()
        {
        }

        public JNIException(string message)
            : base(message)
        {
        }

        public JNIException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}