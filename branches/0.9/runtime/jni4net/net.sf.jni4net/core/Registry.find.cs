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
using System.Reflection;
using java.lang;
using net.sf.jni4net.attributes;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    partial class Registry
    {
        public static ProxyInfo LoadProxyByName(string instanceTypeName, bool isInterface)
        {
            ProxyInfo proxyInfo;
            // try known proxies, just in case
            if (JVMApiNameToInfo.TryGetValue(instanceTypeName.ToLowerInvariant(), out proxyInfo))
            {
                if (proxyInfo.IsStub)
                {
                    return LoadProxyByType(proxyInfo.CLRStaticApi, false);
                }
                return proxyInfo;
            }

            if (isInterface)
            {
                proxyInfo = _SearchAssemblies(instanceTypeName + "_");
                if (proxyInfo != null) return proxyInfo;
                proxyInfo = _SearchAssemblies(instanceTypeName);
                if (proxyInfo != null) return proxyInfo;
            }
            else
            {
                proxyInfo = _SearchAssemblies(instanceTypeName);
                if (proxyInfo != null) return proxyInfo;
                proxyInfo = _SearchAssemblies(instanceTypeName + "_");
                if (proxyInfo != null) return proxyInfo;
            }
            return null;
        }

        private static ProxyInfo _SearchAssemblies(string instanceTypeName)
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type staticApi = assembly.GetType(instanceTypeName, false, true);
                if (staticApi != null)
                {
                    ProxyInfo proxyInfo = LoadProxyByType(staticApi, false);
                    if (proxyInfo != null)
                    {
                        return proxyInfo;
                    }
                }
            }
            return null;
        }

        public static ProxyInfo LoadProxyByType(Type potentialProxy, bool allowNameFallback=true)
        {
            ProxyInfo proxyInfo;
            // try known proxies, just in case
            if (CLRApiToInfo.TryGetValue(potentialProxy, out proxyInfo))
            {
                if(proxyInfo.IsStub)
                {
                    potentialProxy = proxyInfo.CLRStaticApi;
                }
                else
                {
                    return proxyInfo;
                }
            }

            if (potentialProxy == null
                || potentialProxy == typeof(IClass)
                || potentialProxy == typeof(IThrowable)
                || potentialProxy == typeof(IClassLoader)
                || potentialProxy == typeof(_IJvmProxy)
                || potentialProxy == typeof(IObject)
                || potentialProxy == typeof(IJvmProxy))
            {
                return null;
            }

            if (potentialProxy == typeof(Exception)
                || potentialProxy == typeof(object))
            {
                // ReSharper disable PossibleNullReferenceException
                return LoadProxyByName(potentialProxy.FullName.Replace("+", "$")+"_", potentialProxy.IsInterface);
                // ReSharper restore PossibleNullReferenceException
            }

            //try it by attribute
            foreach (var customAttribute in potentialProxy.GetCustomAttributes(false))
            {
                var pio = customAttribute as IProxyInfoOwner;
                if (pio != null)
                {
                    potentialProxy = pio.GetStaticApi();
                    break;
                }
            }

            var methodInfo = potentialProxy.GetMethod("j4n_ProxyInit", BindingFlags.Static | BindingFlags.NonPublic);
            if (methodInfo == null)
            {
                if (allowNameFallback && !string.IsNullOrEmpty(potentialProxy.FullName))
                {
                    return LoadProxyByName(potentialProxy.FullName.Replace("+", "$"), potentialProxy.IsInterface);
                }
                return null;
            }
            return (ProxyInfo)methodInfo.Invoke(null, new object[] { new ProxyInfo() });
        }

        public static IClass FindClass(JNIEnv env, string className, IClassLoader classLoader, bool throwOnError=true)
        {
            try{
                IClass cls = null;
                ProxyInfo proxyInfo;
                if (JVMApiNameToInfo.TryGetValue(className.ToLowerInvariant(), out proxyInfo) && proxyInfo.JVMApi!=null)
                {
                    return proxyInfo.JVMApi;
                }

                if (isInitialized && classLoader != null)
                {
                    try
                    {
                        cls = classLoader.loadClass(className);
                    }
                    catch(Exception ex)
                    {
                        Logger.LogDebug(ex.Message);
                    }
                }
            
                if (cls==null && isInitialized && J4NBridge.currentSetup.DefaultClassLoader != null)
                {
                    try
                    {
                        cls = J4NBridge.currentSetup.DefaultClassLoader.loadClass(className);
                    }
                    catch (Exception ex)
                    {
                        Logger.LogDebug(ex.Message);
                    }
                }

                if (cls == null && javaLangClass != null)
                {
                    IntPtr lhJvmApi;
                    if(throwOnError)
                    {
                        lhJvmApi = env.FindClass(className);
                    }
                    else
                    {
                        lhJvmApi = env.FindClassNoThrow(className);
                        if(lhJvmApi==IntPtr.Zero)
                        {
                            return null;
                        }
                    }
                    var classProxy = javaLangClass.JVMProxyFactory(env, lhJvmApi, new JvmInstanceInfo(javaLangClass.JVMApi, javaLangClass));
                    cls = (IClass)classProxy;
                }
                return cls;
            }
            catch(Exception ex)
            {
                if (throwOnError)
                {
                    throw new J4NException("Can't load class " + className, ex);
                }
                return null;
            }
        }
    }
}
