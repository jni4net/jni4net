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

// ReSharper disable CheckNamespace
using System;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    internal partial class JvmCoreHooks : IJvmCoreHooks
    {
        #region init
        
        // ReSharper disable UnusedParameter.Local
        private void PreInitJ4N(JNIEnv env)
        {
        }

        private void PostInitJ4N(JNIEnv env)
        {
        }
        // ReSharper restore UnusedParameter.Local

        #endregion

        public ProxyInfo BindSealedToClr(JNIEnv env, Type typeOfApi)
        {
            ProxyInfo proxyInfo = Registry.InitJvmProxy(typeOfApi, env);
            if (proxyInfo == null)
            {
                throw new NotImplementedException("Unmapped sealed class");
            }
            return proxyInfo;
        }

        public ProxyInfo BindAbstractToClr(JNIEnv env, Registry.JVMConversion conversion)
        {
            return Registry.BindJVMConversion(env, conversion);
        }
    }
}
