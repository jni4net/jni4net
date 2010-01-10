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
        public IConstructionHelper CLRConstructor { get; internal set; }
        public Type CLRInterface { get; internal set; }
        public string CLRName { get; internal set; }
        public Type CLRProxy { get; internal set; }
        public MethodInfo CLRProxyInitMethod { get; internal set; }
        public Type CLRStatic { get; internal set; }
        public Type CLRWrapper { get; internal set; }
        public MethodInfo CLRWrapperInitMethod { get; internal set; }
        public bool IsCLRType { get; internal set; }
        public bool IsInterface { get; internal set; }
        public bool IsJVMClass { get; internal set; }
        public bool JVMBound { get; internal set; }
        public MethodId JVMConstructor { get; internal set; }

        public Class JVMInterface { get; internal set; }
        public string JVMName { get; internal set; }
        public Class JVMProxy { get; internal set; }
        public Class JVMStatic { get; internal set; }

        public Assembly CLRAssembly { get; internal set; }

        public override string ToString()
        {
            return JVMName;
        }

        internal JniLocalHandle CreateJVMProxy(JNIEnv env, object obj)
        {
            if (!Bridge.Setup.BindNative)
            {
                throw new JNIException("you have to bind native method in order to create proxies to CLR types");
            }
            long handle = IntHandle.Alloc(obj);
            return env.NewObjectPtr(JVMProxy.jvmHandle, JVMConstructor, new Value(), new Value {_long = handle});
        }

        internal IJvmProxy CreateCLRProxy(JNIEnv env, JniLocalHandle obj)
        {
            IJvmProxy proxy = CLRConstructor.CreateProxy(env);
            proxy.Init(env, obj);
            return proxy;
        }

        internal IJvmProxy CopyCLRProxy(JNIEnv env, JniGlobalHandle obj)
        {
            IJvmProxy proxy = CLRConstructor.CreateProxy(env);
            proxy.Copy(env, obj);
            return proxy;
        }
    }
}