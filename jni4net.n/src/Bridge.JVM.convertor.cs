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
using System.Reflection;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using Exception=System.Exception;

namespace net.sf.jni4net
{
    internal partial class __Bridge
    {
        private static long WrapJVM(IntPtr __envp, JniLocalHandle __class, JniLocalHandle obj)
        {
            JNIEnv env = JNIEnv.Wrap(__envp);
            try
            {
                Class clazz = env.GetObjectClass(obj);
                RegistryRecord record = Registry.GetJVMRecord(clazz);
                IJvmProxy clrProxy = record.CreateCLRProxy(env, obj);
                return IntHandle.Alloc(clrProxy);
            }
            catch (Exception ex)
            {
                env.ThrowExisting(ex);
            }
            return 0;
        }

        private static JniHandle UnwrapJVM(IntPtr __envp, IntPtr __class, long clrHandle)
        {
            JNIEnv env = JNIEnv.Wrap(__envp);
            try
            {
                IJvmProxy jvmProxy = (IJvmProxy)IntHandle.ToObject(clrHandle);
                return jvmProxy.JvmHandle;
            }
            catch (Exception ex)
            {
                env.ThrowExisting(ex);
            }
            return JniGlobalHandle.Zero;
        }

        private static long Convert(IntPtr __envp, JniLocalHandle __class, JniLocalHandle str)
        {
            JNIEnv env = JNIEnv.Wrap(__envp);
            try
            {
                string value = env.ConvertToString(str);
                return IntHandle.Alloc(value);
            }
            catch (Exception ex)
            {
                env.ThrowExisting(ex);
            }
            return default(long);
        }

        private static void DisposeClrHandle(IntPtr @__envp, IntPtr @__class, long clrHandle)
        {
            JNIEnv env = JNIEnv.Wrap(@__envp);
            try
            {
                IntHandle.Free(clrHandle);
            }
            catch (Exception ex)
            {
                env.ThrowExisting(ex);
            }
        }

        private static JniLocalHandle Cast(IntPtr @__envp, JniLocalHandle @__class, JniLocalHandle obj, JniLocalHandle expectedInterface)
        {
            JNIEnv env = JNIEnv.Wrap(@__envp);
            try
            {
                Class expectedInterfaceClass = Convertor.StrongJ2CpClass(env, expectedInterface);
                object real = __IClrProxy.GetObject(env, obj);
                Type type = real.GetType();
                RegistryRecord record = Registry.GetJVMRecord(expectedInterfaceClass);
                Type reqType = record.CLRInterface;
                if (!reqType.IsAssignableFrom(type))
                {
                    throw new InvalidCastException("Can't convert instance of CLR type " + type + " to " + reqType);
                }

                return record.CreateJVMProxy(env, real);
            }
            catch (Exception ex)
            {
                env.ThrowExisting(ex);
            }
            return JniLocalHandle.Zero;
        }

        private static List<JNINativeMethod> __Init2(JNIEnv @__env, Class @__class)
        {
            Type @__type = typeof (__Bridge);
            var methods = new List<JNINativeMethod>();
            methods.Add(JNINativeMethod.Create(@__type, "WrapJVM", "WrapJVM", "(Ljava/lang/Object;)J"));
            methods.Add(JNINativeMethod.Create(@__type, "Convert", "Convert", "(Ljava/lang/String;)J"));
            methods.Add(JNINativeMethod.Create(@__type, "UnwrapJVM", "UnwrapJVM", "(J)Ljava/lang/Object;"));
            methods.Add(JNINativeMethod.Create(@__type, "DisposeClrHandle", "DisposeClrHandle", "(J)V"));
            methods.Add(JNINativeMethod.Create(@__type, "Cast", "Cast", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/sf/jni4net/inj/IClrProxy;"));
            return methods;
        }

        internal static void Init(JNIEnv env)
        {
            if (Bridge.Setup.BindNative)
            {
                MethodInfo initializer = Registry.GetWrapperInitializer(typeof(__Bridge), "__Init2");
                RegistryRecord record = Registry.GetCLRRecord(typeof(Bridge));
                Registry.RegisterNative(initializer, env, record.JVMProxy, record.JVMInterface);
            }
        }
    }
}
