#region Copyright (C) 2012 by Pavel Savara

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

namespace net.sf.jni4net.core
{
    public struct JvmInstanceInfo
    {
        public JvmInstanceInfo(IClass jvmInstance, ProxyInfo proxyInfo)
        {
            JVMInstance = jvmInstance;
            ProxyInfo = proxyInfo;
        }

        public IClass JVMInstance;
        public ProxyInfo ProxyInfo;
    }

    public class ProxyInfo
    {
        public void Merge(ProxyInfo src)
        {
            ClassLoader = ClassLoader ?? src.ClassLoader;
            JVMApi = JVMApi ?? src.JVMApi;
            JVMApiArray = JVMApiArray ?? src.JVMApiArray;
            JVMProxy = JVMProxy ?? src.JVMProxy;
            JVMStaticApi = JVMStaticApi ?? src.JVMStaticApi;
            JVMApiName = JVMApiName ?? src.JVMApiName;
            JVMProxyName = JVMProxyName ?? src.JVMProxyName;
            JVMStaticApiName = JVMStaticApiName ?? src.JVMStaticApiName;
            CLRProxy = CLRProxy ?? src.CLRProxy;
            CLRApi = CLRApi ?? src.CLRApi;
            CLRStaticApi = CLRStaticApi ?? src.CLRStaticApi;
            JVMProxyFactory = JVMProxyFactory ?? src.JVMProxyFactory;
            CLRGProxy = CLRGProxy ?? src.CLRGProxy;
            CLRGApi = CLRGApi ?? src.CLRGApi;
            CLRGApiIn = CLRGApiIn ?? src.CLRGApiIn;
            CLRGStaticApi = CLRGStaticApi ?? src.CLRGStaticApi;
            JVMGProxyFactory = JVMGProxyFactory ?? src.JVMGProxyFactory;
            CLRProxyFactory = CLRProxyFactory ?? src.CLRProxyFactory;
            CLRProxyFactoryImpl = CLRProxyFactoryImpl ?? src.CLRProxyFactoryImpl;
            MemberIds = MemberIds ?? src.MemberIds;
            Members = Members ?? src.Members;
            IsBound = IsBound | src.IsBound;
            IsBackBound = IsBackBound | src.IsBackBound;
            IsInterface = IsInterface | src.IsInterface;
            IsCLR = IsCLR | src.IsCLR;
        }

        public bool IsStub;
        public bool IsBound;
        public bool IsBackBound;

        public bool IsInterface;
        public bool IsCLR;
        public bool IsJVM
        {
            get { return !IsCLR; }
        }

        public IClassLoader ClassLoader;
        public IClass JVMApi;
        public IClass JVMApiArray;
        public IClass JVMProxy;
        public IClass JVMStaticApi;
        public string JVMApiName;
        public string JVMProxyName;
        public string JVMStaticApiName;

        public Type CLRProxy;
        public Type CLRApi;
        public Type CLRStaticApi;
        public CreateJvmProxy JVMProxyFactory;

        public Type CLRGProxy;
        public Type CLRGApi;
        public Type CLRGApiIn;
        public Type CLRGStaticApi;
        public CreateJvmProxy JVMGProxyFactory;

        public CreateClrProxy CLRProxyFactory;
        public IJvmProxy CLRProxyFactoryImpl;

        public MemberId[] MemberIds;
        public IntPtr[] Members;

        public override string ToString()
        {
            return JVMApiName;
        }

        public void Unload()
        {
            IsStub = false;
            IsBound = false;
            IsBackBound = false;

            ClassLoader = null;
            JVMApi = null;
            JVMApiArray = null;
            JVMProxy = null;
            JVMStaticApi = null;

            //JVMGProxyFactory = null;
            //JVMProxyFactory = null;

            CLRProxyFactory = null;
            CLRProxyFactoryImpl = null;

            Members = null;
        }
    }
}