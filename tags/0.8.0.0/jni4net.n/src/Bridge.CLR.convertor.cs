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
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using Object = java.lang.Object;

namespace net.sf.jni4net
{
    partial class Bridge
    {
        public static bool IsCLRInstance(object obj)
        {
            var proxy = obj as IJvmProxy;
            if (proxy != null)
            {
                return proxy is IClrProxy;
            }
            return true;
        }

        public static bool IsJVMInstance(object obj)
        {
            return !IsCLRInstance(obj);
        }

        public static Object WrapCLR(object obj)
        {
            var proxy = obj as IJvmProxy;
            var clrProxy = proxy as IClrProxy;
            if (proxy != null)
            {
                if (clrProxy != null)
                {
                    return (Object)clrProxy;
                }
                throw new JNIException("Can't wrap JVM instance");
            }
            Type type = obj.GetType();
            JNIEnv env = JNIEnv.ThreadEnv;

            RegistryRecord record = Registry.GetCLRRecord(type);
            JniLocalHandle jvmProxy = record.CreateJVMProxy(env, obj);
            return (Object)__IClrProxy.CreateProxy(env, jvmProxy);
        }

        public static TRes UnwrapCLR<TRes>(Object obj)
        {
            var clrProxy = obj as IClrProxy;
            if (clrProxy == null)
            {
                throw new JNIException("Can't unwrap JVM instance");
            }
            long handle = clrProxy.getClrHandle();
            object res = IntHandle.ToObject(handle);
            Type type = res.GetType();
            Type reqType = typeof(TRes);
            if (!reqType.IsAssignableFrom(type))
            {
                throw new InvalidCastException("Can't cast CLR instance of " + type + " to " + reqType);
            }
            return (TRes) res;
        }

        public static TRes Cast<TRes>(object obj)
        {
            Type reqType = typeof(TRes);
            if (IsCLRInstance(obj))
            {
                throw new JNIException("Can't cast CLR instance of " + obj.GetType() + " to " + reqType);
            }
            IJvmProxy proxy = obj as IJvmProxy;
            if (!reqType.IsInterface && !typeof(IObject).IsAssignableFrom(reqType))
            {
                throw new JNIException("Can't cast to CLR class");
            }
            RegistryRecord record = Registry.GetCLRRecord(reqType);
            Class clazz = proxy.getClass();
            if (!record.JVMInterface.isAssignableFrom(clazz))
            {
                throw new InvalidCastException("Can't cast JVM instance of " + clazz + " to " + record.JVMInterface + "\n (" + clazz.getClassLoader() + "->" + record.JVMInterface.getClassLoader() + ")");
            }
            IJvmProxy res = record.CopyCLRProxy(JNIEnv.ThreadEnv, proxy.JvmHandle);
            return (TRes) res;
        }

        public static TRes CreateProxy<TRes>(JniGlobalHandle jvmHandle)
        {
            Type reqType = typeof(TRes);
            if (!reqType.IsInterface && !typeof(IObject).IsAssignableFrom(reqType))
            {
                throw new JNIException("Can't create proxy to CLR class");
            }
            RegistryRecord record = Registry.GetCLRRecord(reqType);
            JNIEnv env = JNIEnv.ThreadEnv;
            Class clazz = env.GetObjectClass(jvmHandle);
            if (!record.JVMInterface.isAssignableFrom(clazz))
            {
                throw new InvalidCastException("Can't cast JVM instance of " + clazz + " to " + record.JVMInterface + "\n (" + clazz.getClassLoader() + "->" + record.JVMInterface.getClassLoader() + ")");
            }
            IJvmProxy res = record.CopyCLRProxy(env, jvmHandle);
            return (TRes)res;
        }
    }

}
