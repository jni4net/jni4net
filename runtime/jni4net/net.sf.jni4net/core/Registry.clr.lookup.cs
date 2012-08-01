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
using System.Collections.Generic;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    partial class Registry
    {
        public static ProxyInfo LookupSealedToJvm(JNIEnv env, Type typeOfSealed)
        {
            ProxyInfo res;
            if (!CLRApiToInfo.TryGetValue(typeOfSealed, out res))
            {
                lock (syncroot)
                {
                    res = ClrCoreHooks.BindSealedToJvm(env, typeOfSealed);
                }
            }
            else if (res.IsStub || res.IsBackBound)
            {
                InitClrProxy(ref res, env);
            }
            return res;
        }

        public static ProxyInfo LookupAbstractToJvm(JNIEnv env, Type typeOfInstance, string classOfApi)
        {
            ProxyInfo res;
            var clrConversion = new CLRConversion(typeOfInstance, classOfApi);
            if (!CLRConversionToInfo.TryGetValue(clrConversion, out res))
            {
                lock (syncroot)
                {
                    res = ClrCoreHooks.BindAbstractToJvm(env, clrConversion);
                }
            }
            return res;
        }
        
        internal static ProxyInfo BindCLRConversion(JNIEnv env, CLRConversion conversion)
        {
            ProxyInfo proxyInfo;

            // CLR or JVM instance ?
            if (typeof(IJvmProxy).IsAssignableFrom(conversion.Instance))
            {
                // this is to unwrap real JVM instance
                proxyInfo = unwrapJvmProxy;
                RegisterCLRConversions(proxyInfo, new[] { conversion });
                return proxyInfo;
            }
            // create new wrapper for real CLR instance
            
            IClass conversion_Api;
            ProxyInfo apiProxyInfo = LoadProxyByName(conversion.Api, true);
            if (apiProxyInfo != null && (apiProxyInfo.IsInterface || apiProxyInfo.IsCLR))
            {
                InitClrProxy(ref apiProxyInfo, env);

                if (conversion.Instance.IsAssignableFrom(apiProxyInfo.CLRApi))
                {
                    return apiProxyInfo;
                }
                conversion_Api = apiProxyInfo.JVMApi;
            }
            else
            {
                conversion_Api = FindClass(env, conversion.Api, null);
            }

            if (CLRConversionToInfo.TryGetValue(conversion, out proxyInfo))
            {
                return proxyInfo;
            }
            var toregister = new List<CLRConversion>();

            if (conversion.Api == "java.lang.Object")
            {
                toregister.Add(conversion);
                conversion = new CLRConversion(conversion.Instance, "system.Object");
            }

            var current = conversion;
            do
            {
                if (CLRConversionToInfo.TryGetValue(current, out proxyInfo))
                {
                    break;
                }

                proxyInfo = LoadProxyByType(current.Instance);
                if (proxyInfo != null && (proxyInfo.IsInterface || proxyInfo.IsCLR))
                {
                    InitClrProxy(ref proxyInfo, env);
                    if(conversion_Api.isAssignableFrom(proxyInfo.JVMApi))
                    {
                        toregister.Add(current);
                        break;
                    }
                    proxyInfo = null;
                    break;
                }

                toregister.Add(current);
                current = new CLRConversion(current.Instance.BaseType, conversion.Api);
            } while (current.Instance != null);
            if(proxyInfo==null)
            {
                // at this point base classes can't satisfy the API, we search for interface
                proxyInfo = BindCLRConversionIfc(env, conversion, conversion_Api, apiProxyInfo, toregister);
            }

            RegisterCLRConversions(proxyInfo, toregister);

            return proxyInfo;
        }

        private static ProxyInfo BindCLRConversionIfc(JNIEnv env, CLRConversion conversion, IClass conversion_Api, ProxyInfo apiProxyInfo, List<CLRConversion> toregister)
        {
            ProxyInfo proxyInfo;
            if (apiProxyInfo == null)
            {
                throw new J4NException("Can't find proxy for " + conversion.Instance);
            }

            toregister.Clear();
            toregister.Add(conversion);

            // so we search best match for the interface
            var allIfcs = new List<Type>(conversion.Instance.GetInterfaces());
            var relevantIfcs = new List<ProxyInfo>();
            foreach (var ifc in allIfcs)
            {
                if (apiProxyInfo.CLRApi.IsAssignableFrom(ifc) || apiProxyInfo == javaLangObject)
                {
                    proxyInfo = LoadProxyByType(ifc);
                    if (proxyInfo != null && (proxyInfo.IsInterface || proxyInfo.IsCLR))
                    {
                        InitClrProxy(ref proxyInfo, env);
                        relevantIfcs.Add(proxyInfo);
                    }
                    else
                    {
                        relevantIfcs.Add(apiProxyInfo);
                    }
                }
            }
            while (relevantIfcs.Count > 1)
            {
                var isAssignableFrom = relevantIfcs[0].JVMApi.isAssignableFrom(relevantIfcs[1].JVMApi);
                relevantIfcs.RemoveAt(isAssignableFrom ? 0 : 1);
            }
            proxyInfo = relevantIfcs[0];
            if (!conversion_Api.isAssignableFrom(proxyInfo.JVMApi) && conversion.Api != systemObject.JVMApiName)
            {
                //different generic parameter in base class
                return apiProxyInfo;
            }
            return proxyInfo;
        }

        static object unwrap_ClrProxyFactory(JNIEnv env, IntPtr proxyHandle, JvmInstanceInfo j4n_instanceInfo)
        {
            if (proxyHandle == IntPtr.Zero)
            {
                return null;
            }
            long j4n_clrHande = env.CallLongMethod(proxyHandle, clrProxyGetClrHandleMethodId);
            return LongClrHandle.ToObject(j4n_clrHande);
        }

        internal static object unwrap_ClrProxyFactory(JNIEnv env, IntPtr proxyHandle)
        {
            long j4n_clrHande = env.CallLongMethod(proxyHandle, clrProxyGetClrHandleMethodId);
            return LongClrHandle.ToObject(j4n_clrHande);
        }

        internal static IntPtr CreateClrProxy(JNIEnv env, object value, Type instanceType, IJvmProxy clrProxyFactoryImpl)
        {
            long clrHandle = LongClrHandle.Alloc(value);
            return env.CallObjectMethod(clrProxyFactoryImpl, clrProxyFactoryMethodId, new JNIValue { _long = clrHandle });
        }


    }
}
