#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

#if !JNI4NET_MINI
using java.lang.annotation;
using java_.lang.reflect;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.lang.reflect
{
    public partial class Method : _Member
    {
        public string GetSignature()
        {
            var sb = new global::System.Text.StringBuilder();
            sb.Append('(');
            foreach (Class par in getParameterTypes())
            {
                sb.Append(Registry.JavaSignature(par));
            }
            sb.Append(')');
            sb.Append(Registry.JavaSignature(getReturnType()));
            return sb.ToString();
        }

        public MethodId GetMethodId()
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            return env.FromReflectedMethod(this);
        }

        public bool IsAnnotationPresent(string search)
        {
            foreach (Annotation annotation in getAnnotations())
            {
                String name = annotation.annotationType().getName();
                if (name == search)
                {
                    return true;
                }
            }
            return false;
        }

        public Annotation GetAnnotation(string search)
        {
            foreach (Annotation annotation in getAnnotations())
            {
                String name = annotation.annotationType().getName();
                if (name == search)
                {
                    return annotation;
                }
            }
            return null;
        }
    }
}

#endif