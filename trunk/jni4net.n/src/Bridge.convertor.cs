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
using System.Collections.Generic;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using Exception=System.Exception;

namespace net.sf.jni4net
{
    partial class Bridge
    {
        public static bool IsCLRInstance(object obj)
        {
            var proxy = obj as ICJvmProxy;
            if (proxy != null)
            {
                return proxy is ICClrProxy;
            }
            return true;
        }

        public static bool IsJVMInstance(object obj)
        {
            return !IsCLRInstance(obj);
        }

        public static ICClrProxy WrapCLR(object obj)
        {
            var proxy = obj as ICJvmProxy;
            var clrProxy = proxy as ICClrProxy;
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
            return __ICClrProxy.CreateProxy(env, ptr, record.JVMProxy);
        }

        public static TRes UnwrapCLR<TRes>(ICJvmProxy obj)
        {
            var clrProxy = obj as ICClrProxy;
            if (clrProxy == null)
            {
                throw new JNIException("Can't unwrap JVM instance");
            }
            int handle = clrProxy.getClrHandle();
            return (TRes) IntHandle.ToObject(handle);
        }
    }

    internal partial class __Bridge
    {
        private static IntPtr WrapJVM(IntPtr __envp, IntPtr __class, IntPtr obj, IntPtr interfaceClass)
        {
            // (Ljava/lang/Object;Ljava/lang/Class;)Lsystem/Object;
            // (Lnet/sf/jni4net/jni/ICJvmProxy;Ljava/lang/Class;)LSystem/Object;
            JNIEnv env = JNIEnv.Wrap(__envp);
            try
            {
                Class clazz = Convertor.StrongJ2CpClass(env, interfaceClass);
                RegistryRecord record = Registry.GetJVMRecord(clazz);
                return record.CreateCLRProxy(env, obj, clazz).Native;
            }
            catch (Exception ex)
            {
                env.ThrowExisting(ex);
            }
            return default(IntPtr);
        }

        private static IntPtr UnwrapJVM(IntPtr __envp, IntPtr __class, IntPtr obj, IntPtr interfaceClass)
        {
            // (Lsystem/Object;Ljava/lang/Class;)Ljava/lang/Object;
            // (LSystem/Object;Ljava/lang/Class;)Lnet/sf/jni4net/jni/ICJvmProxy;
            JNIEnv env = JNIEnv.Wrap(__envp);
            try
            {
                ICJvmProxy real = (ICJvmProxy)__ICClrProxy.GetObject(env, obj);
                return real.Native;
            }
            catch (Exception ex)
            {
                env.ThrowExisting(ex);
            }
            return default(IntPtr);
        }

        private static List<JNINativeMethod> __Init2(JNIEnv @__env, Class @__class)
        {
            Type @__type = typeof (__Bridge);
            var methods = new List<JNINativeMethod>();
            methods.Add(JNINativeMethod.Create(@__type, "WrapJVM", "WrapJVM", "(Ljava/lang/Object;Ljava/lang/Class;)Lsystem/Object;"));
            methods.Add(JNINativeMethod.Create(@__type, "UnwrapJVM", "UnwrapJVM", "(Lsystem/Object;Ljava/lang/Class;)Ljava/lang/Object;"));
            return methods;
        }
    }
}
