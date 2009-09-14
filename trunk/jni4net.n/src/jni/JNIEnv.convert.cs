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