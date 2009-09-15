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
using System.Reflection;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public class RegistryRecord
    {
        public Assembly CLRAssembly;
        public IConstructionHelper CLRConstructor;
        public Type CLRInterface;
        public string CLRName;
        public Type CLRProxy;
        public MethodInfo CLRProxyInitMethod;
        public Type CLRStatic;
        public Type CLRWrapper;
        public MethodInfo CLRWrapperInitMethod;
        public bool IsCLRType;
        public bool IsInterface;
        public bool IsJVMClass;
        public bool JVMBound;
        public MethodId JVMConstructor;

        public Class JVMInterface;
        public string JVMName;
        public Class JVMProxy;
        public Class JVMStatic;

        public override string ToString()
        {
            return JVMName;
        }

        internal IntPtr CreateJVMProxy(JNIEnv env, object obj)
        {
            long handle = IntHandle.Alloc(obj);
            return env.NewObjectPtr(JVMProxy.jvmHandle, JVMConstructor, new Value(), new Value {_long = handle});
        }

        internal IJvmProxy CreateCLRProxy(JNIEnv env, IntPtr obj, Class clazz)
        {
            IJvmProxy proxy = CLRConstructor.CreateProxy(env);
            proxy.Init(env, obj, clazz);
            return proxy;
        }
    }
}