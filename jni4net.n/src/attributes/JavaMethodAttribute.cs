#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;

namespace net.sf.jni4net.attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Property)]
    public sealed class JavaMethodAttribute : Attribute
    {
        public JavaMethodAttribute()
        {
        }

        public JavaMethodAttribute(string signature)
        {
            Signature = signature;
        }

        public string Signature { get; private set; }
    }
}