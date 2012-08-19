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

        public static ProxyInfo LookupSealedToClr(JNIEnv env, Type typeOfSealed)
        {
            ProxyInfo res;
            if (!CLRApiToInfo.TryGetValue(typeOfSealed, out res))
            {
                lock (syncroot)
                {
                    return JvmCoreHooks.BindSealedToClr(env, typeOfSealed);
                }
            }
            else if (res.IsStub || res.IsBound)
            {
                InitJvmProxy(ref res, env);
            }
            return res;
        }

        public static ProxyInfo LookupAbstractToClr(JNIEnv env, IClass instanceClazz, Type typeOfApi)
        {
            ProxyInfo res;
            var jvmConversion = new JVMConversion(instanceClazz, typeOfApi);
            if (!JVMConversionToInfo.TryGetValue(jvmConversion, out res))
            {
                lock (syncroot)
                {
                    return JvmCoreHooks.BindAbstractToClr(env, jvmConversion);
                }
            }
            return res;
        }

        internal static ProxyInfo BindJVMConversion(JNIEnv env, JVMConversion conversion)
        {
            ProxyInfo proxyInfo;

            // CLR or JVM instance ?
            if (IClrProxy != null && IClrProxy.isAssignableFrom(conversion.Instance))
            {
                // this is to unwrap real CLR instance
                proxyInfo = unwrapClrProxy;
                RegisterJVMConversions(proxyInfo, new[] { conversion });
                return proxyInfo;
            }

            if(conversion.Instance==javaLangString.JVMApi && conversion.Api==typeof(string))
            {
                return unboxStringPI;
            }

            // create new wrapper for real JVM instance

            ProxyInfo apiProxyInfo = LoadProxyByType(conversion.Api);
            if (apiProxyInfo != null && (apiProxyInfo.IsInterface || apiProxyInfo.IsJVM))
            {
                InitJvmProxy(ref apiProxyInfo, env);

                if (conversion.Instance.isAssignableFrom(apiProxyInfo.JVMApi))
                {
                    return apiProxyInfo;
                }
            }

            if (JVMConversionToInfo.TryGetValue(conversion, out proxyInfo))
            {
                return proxyInfo;
            }
            var toregister = new List<JVMConversion>();

            if (conversion.Api == typeof (object))
            {
                toregister.Add(conversion);
                conversion = new JVMConversion(conversion.Instance, javaLangObject.CLRApi);
            }

            JVMConversion current = conversion;
            do
            {
                if (JVMConversionToInfo.TryGetValue(current, out proxyInfo))
                {
                    break;
                }

                proxyInfo = LoadProxyByName(current.Instance.getName(), true);
                if (proxyInfo != null && (proxyInfo.IsInterface || proxyInfo.IsJVM))
                {
                    InitJvmProxy(ref proxyInfo, env);
                    if (conversion.Api.IsAssignableFrom(proxyInfo.CLRApi))
                    {
                        toregister.Add(current);
                        break;
                    }
                    proxyInfo = null;
                    break;
                }

                toregister.Add(current);
                current = new JVMConversion(current.Instance.getSuperclass(), conversion.Api);
            } while (current.Instance != null);
            if (proxyInfo == javaLangObject && apiProxyInfo !=null && apiProxyInfo.JVMApi != null)
            {
                // we satisfied the API with javaLangObject. Could we improve it with interface ?
                var proxyInfoIfc = BindJVMConversionIfc(env, conversion, apiProxyInfo, toregister);
                if (proxyInfoIfc != null)
                {
                    proxyInfo = proxyInfoIfc;
                }
            }
            if (proxyInfo == null)
            {
                // at this point base classes can't satisfy the API, we search for interface
                proxyInfo = BindJVMConversionIfc(env, conversion, apiProxyInfo, toregister);
            }

            RegisterJVMConversions(proxyInfo, toregister);

            return proxyInfo;
        }

        private static ProxyInfo BindJVMConversionIfc(JNIEnv env, JVMConversion conversion, ProxyInfo apiProxyInfo, List<JVMConversion> toregister)
        {
            ProxyInfo proxyInfo;
            if (apiProxyInfo == null)
            {
                throw new J4NException("Can't find proxy for " + conversion.Instance.toString());
            }
            toregister.Clear();
            toregister.Add(conversion);

            // so we search best match for the interface
            var allIfcs = new List<IClass>(conversion.Instance.getInterfaces());
            var relevantIfcs = new List<ProxyInfo>();
            foreach (IClass ifc in allIfcs)
            {
                if (apiProxyInfo.JVMApi.isAssignableFrom(ifc) || apiProxyInfo==systemObject)
                {
                    var staticApi = JvmCoreHooks.LoadAnnotatedProxy(ifc);
                    if (staticApi != null)
                    {
                        var sc = env.GetStaticMethodIDNoThrow(staticApi.JvmHandle, "j4n_ProxyInit", "(Lnet/sf/jni4net/inj/INJEnv;)Lnet/sf/jni4net/core/ProxyInfo;");
                        if (sc != IntPtr.Zero)
                        {
                            env.CallStaticObjectMethod(staticApi, sc, new JNIValue());
                        }
                    }
                    proxyInfo = LoadProxyByName(ifc.getName(), true);
                    if (proxyInfo != null && (proxyInfo.IsInterface || proxyInfo.IsJVM))
                    {
                        InitJvmProxy(ref proxyInfo, env);
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
                bool isAssignableFrom = relevantIfcs[0].CLRApi.IsAssignableFrom(relevantIfcs[1].CLRApi);
                relevantIfcs.RemoveAt(isAssignableFrom ? 0 : 1);
            }
            proxyInfo = relevantIfcs[0];
            if (!conversion.Api.IsAssignableFrom(proxyInfo.CLRApi) && conversion.Api != javaLangObject.CLRApi)
            {
                //different generic parameter in base class
                return apiProxyInfo;
            }
            return proxyInfo;
        }
    }
}
