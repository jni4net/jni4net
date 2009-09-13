#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

#if !JNI4NET_MINI
using java.lang.annotation;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.lang.reflect
{
    public partial class Method
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