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
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using String=java.lang.String;

namespace net.sf.jni4net
{
    partial class Bridge
    {
        public static bool IsCLRInstance(object obj)
        {
            IJavaProxy proxy = obj as IJavaProxy;
            if (proxy!=null)
            {
                return proxy is IClrProxy;
            }
            return true;
        }

        public static bool IsJVMInstance(object obj)
        {
            return !IsCLRInstance(obj);
        }

        public static IClrProxy WrapCLR(object obj)
        {
            IJavaProxy proxy = obj as IJavaProxy;
            IClrProxy clrProxy = proxy as IClrProxy;
            if (proxy != null)
            {
                if (clrProxy != null)
                {
                    return clrProxy;
                }
                throw new JNIException("Can't wrap JVM instance");
            }
            Type type = obj.GetType();
            JNIEnv env = JNIEnv.ThreadEnv;

            RegistryRecord record = Registry.GetCLRRecord(type);
            IntPtr ptr = record.CreateJVMProxy(env, obj);
            return __IClrProxy.CreateProxy(env, ptr, record.JVMProxy);
        }

        public static TRes UnwrapCLR<TRes>(IJavaProxy obj)
        {
            IClrProxy clrProxy = obj as IClrProxy;
            if (clrProxy == null)
            {
                throw new JNIException("Can't unwrap JVM instance");
            }
            int handle = clrProxy.getClrHandle();
            return (TRes)IntHandle.ToObject(handle);
        }

        /*public static TRes Convert<TRes>(IJavaProxy obj)
        {
            IClrProxy clrProxy = obj as IClrProxy;
            Type reqType = typeof(TRes);
            Type inType = obj.GetType();
            if (reqType==inType)
            {
                return (TRes) obj;
            }
            if (reqType==typeof(string))
            {
                if (clrProxy!=null)
                {
                    object real = UnwrapCLR<object>(obj);
                    Type realType = real.GetType();
                    if (!reqType.IsAssignableFrom(realType))
                    {
                        throw new InvalidCastException("Can't cast " + realType + " to " + reqType);
                    }
                    return (TRes)real;
                }
                if (inType == typeof(String))
                {
                    return (TRes)(object)(string)(String) obj;
                }
            }
            if (typeof(IJavaProxy).IsAssignableFrom(reqType))
            {
                
            }
            if (reqType.IsPrimitive)
            {
                
            }
            Class clazz = obj.getClass();
        }*/

        public static object WrapJVM(IJavaProxy obj, Class interfaceClass)
        {
            IClrProxy clrProxy = obj as IClrProxy;
            if (clrProxy!=null)
            {
                return Convertor.FullJ2C<object>(JNIEnv.ThreadEnv, obj.Native);
            }
            return obj;
        }

        public static IJavaProxy UnwrapJVM(object obj, Class interfaceClass)
        {
            return null;// Convertor.C2JWrapper(JNIEnv.ThreadEnv, obj);
        }

        public static IJavaProxy UnwrapJVM(System.Exception obj, Class interfaceClass)
        {
            return null;//Convertor.C2JWrapper(JNIEnv.ThreadEnv, obj);
        }
    }
}
