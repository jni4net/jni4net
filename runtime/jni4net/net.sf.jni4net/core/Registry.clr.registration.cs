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
using System.Reflection;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    // ReSharper disable StringLastIndexOfIsCultureSpecific.1
    partial class Registry
    {
        public static void RegisterClrProxy(Type staticApi, Type clrApi, string jvmApiFullName)
        {
            if(!J4NBridge.currentSetup.BindClrProxies)
            {
                return;
            }

            var temporaryPI = new ProxyInfo
            {
                JVMApiName = jvmApiFullName,
                CLRApi = clrApi,
                CLRStaticApi = staticApi,
                IsStub = true
            };
            lock (syncroot)
            {
                CLRApiToInfo.TryAdd(temporaryPI.CLRApi, ref temporaryPI);
                JVMApiNameToInfo.TryAdd(temporaryPI.JVMApiName.ToLowerInvariant(), ref temporaryPI);
                if(J4NBridge.currentSetup.EnforceImmediateBinding)
                {
                    InitClrProxy(ref temporaryPI, null);
                }
            }
        }

        public static ProxyInfo InitClrProxy(Type potentialProxy, JNIEnv env = null)
        {
            var proxyInfo = LoadProxyByType(potentialProxy);
            if(proxyInfo!=null)
            {
                InitClrProxy(ref proxyInfo, env);
            }
            return proxyInfo;
        }

        private static void InitClrProxy(ref ProxyInfo proxyInfo, JNIEnv env)
        {
            if (!J4NBridge.currentSetup.BindClrProxies)
            {
                //throw new J4NException("Binding CLR proxies is disabled, use BridgeSetup.BindClrProxies");
                return;
            }
            if (proxyInfo.IsStub)
            {
                proxyInfo = InitClrProxy(proxyInfo.CLRStaticApi, env);
                return;
            }
            if (proxyInfo != null && !proxyInfo.IsBackBound)
            {
                if (env == null)
                {
                    env = JNIEnv.ThreadEnv;
                }
                lock (syncroot) using (new LocalFrame(env, 100))
                {
                    CLRApiToInfo.TryAdd(proxyInfo.CLRApi, ref proxyInfo);
                    JVMApiNameToInfo.TryAdd(proxyInfo.JVMApiName.ToLowerInvariant(), ref proxyInfo);

                    if (isBackInitialized)
                    {
                        BindClrProxy(env, proxyInfo);
                    }
                    else
                    {
                        if (!PendingClrProxyInits.ContainsKey(proxyInfo.CLRApi))
                        {
                            Logger.LogDebug("Registry.InitClrProxy() pending " + proxyInfo.JVMApiName);
                            PendingClrProxyInits.Add(proxyInfo.CLRApi, proxyInfo);
                        }
                    }
                }
            }
        }

        private static void BindClrProxy(JNIEnv env, ProxyInfo proxyInfo)
        {
            Logger.LogDebug("Registry.BindClrProxy() " + proxyInfo.JVMApiName);
            if (proxyInfo.JVMApi == null)
            {
                proxyInfo.JVMApi = FindClass(env, proxyInfo.JVMApiName, proxyInfo.ClassLoader);
            }
            proxyInfo.JVMStaticApi = FindClass(env, proxyInfo.JVMStaticApiName, proxyInfo.ClassLoader);
            if (proxyInfo.IsInterface || proxyInfo.IsCLR)
            {
                proxyInfo.JVMProxy = FindClass(env, proxyInfo.JVMProxyName, proxyInfo.ClassLoader);
                var fc = FindClass(env, proxyInfo.JVMStaticApiName+"$j4n_ProxyFactory", proxyInfo.ClassLoader);
                IntPtr constructor = env.GetMethodID(fc, "<init>", "()V");
                IntPtr factoryInstance = env.NewObject(fc, constructor);
                proxyInfo.CLRProxyFactoryImpl = (IJvmProxy)javaLangObject.JVMProxyFactory(env, factoryInstance, new JvmInstanceInfo(javaLangObject.JVMApi, javaLangObject));
                proxyInfo.CLRProxyFactory=(e,v,t)=> CreateClrProxy(e, v, t, proxyInfo.CLRProxyFactoryImpl);
            }

            var list = new List<JNINativeMethod>();
            var jvmProxy = proxyInfo.JVMProxy;
            for (int i = 0; i < proxyInfo.MemberIds.Length; i++)
            {
                var memberId = proxyInfo.MemberIds[i];
                if (memberId==null)
                {
                    continue;
                }
                var method = proxyInfo.CLRStaticApi.GetMethod("j4n_" + i, BindingFlags.Static | BindingFlags.NonPublic);
                if(method==null)
                {
                    throw new J4NException("Can't find method j4n_" + i + " on " + proxyInfo.CLRStaticApi.FullName);
                }
                var name = memberId.Name;
                var signature = memberId.Signature;
                if(memberId.Name=="<init>")
                {
                    int lb = memberId.Signature.LastIndexOf(")");
                    signature = memberId.Signature.Substring(0, lb+1)+"J";
                    name = "j4n_constructor";
                }
                if(i==0)
                {
                    // workaround for Java 1.6 bug
                    // force method definition
                    // http://bugs.sun.com/bugdatabase/view_bug.do?bug_id=6493522
                    LoadJvmMember(env, memberId, jvmProxy, name, signature);
                }
                list.Add(new JNINativeMethod(method, name, signature));
            }
            env.RegisterNatives(list, jvmProxy.JvmHandle, jvmProxy.getName());
            proxyInfo.IsBackBound = true;
        }

        private static void LoadJvmMember(JNIEnv env, MemberId memberId, IClass jvmProxy, string name, string signature)
        {
            try
            {
                if (memberId.IsStatic)
                {
                    env.GetStaticMethodID(jvmProxy, name, signature);
                }
                else
                {
                    env.GetMethodID(jvmProxy, name, signature);
                }
            }
            catch(Exception ex)
            {
                Logger.LogWarn(jvmProxy.getName() + " " + name + " " + ex.Message);
            }
        }
    }
}
