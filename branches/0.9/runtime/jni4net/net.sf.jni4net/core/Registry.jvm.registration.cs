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
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    public static partial class Registry
    {
        public static void RegisterJvmProxy(Type staticApi, Type clrApi, string jvmApiFullName)
        {
            var temporaryPI = new ProxyInfo()
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
                if (J4NBridge.currentSetup.EnforceImmediateBinding)
                {
                    InitJvmProxy(ref temporaryPI, null);
                }
            }
        }

        public static ProxyInfo InitJvmProxy(Type potentialProxy, JNIEnv env = null)
        {
            var proxyInfo = LoadProxyByType(potentialProxy);
            if (proxyInfo!=null)
            {
                InitJvmProxy(ref proxyInfo, env);
            }
            return proxyInfo;
        }

        private static void InitJvmProxy(ref ProxyInfo proxyInfo, JNIEnv env)
        {
            if (proxyInfo.IsStub)
            {
                proxyInfo = InitJvmProxy(proxyInfo.CLRStaticApi, env);
                return;
            }
            if (proxyInfo != null && !proxyInfo.IsBound)
            {
                if (env == null)
                {
                    env = JNIEnv.ThreadEnv;
                }
                lock (syncroot)
                {
                    CLRApiToInfo.TryAdd(proxyInfo.CLRApi, ref proxyInfo);
                    JVMApiNameToInfo.TryAdd(proxyInfo.JVMApiName.ToLowerInvariant(), ref proxyInfo);

                    if (isInitialized)
                    {
                        BindJvmProxy(env, proxyInfo);
                    }
                    else
                    {
                        if (!PendingJvmProxyInits.ContainsKey(proxyInfo.CLRApi))
                        {
                            Logger.LogDebug("Registry.InitJvmProxy() pending " + proxyInfo.CLRApi.FullName);
                            PendingJvmProxyInits.Add(proxyInfo.CLRApi, proxyInfo);
                        }
                    }
                }
            }
        }

        private static void BindJvmProxy(JNIEnv env, ProxyInfo proxyInfo)
        {
            Logger.LogDebug("Registry.BindJvmProxy() " + proxyInfo.JVMApiName);

            proxyInfo.Members = new IntPtr[proxyInfo.MemberIds.Length];
            using (new LocalFrame(env, 10 + proxyInfo.MemberIds.Length * 2))
            {
                proxyInfo.JVMApi = FindClass(env, proxyInfo.JVMApiName, proxyInfo.ClassLoader);
                for (int m = 0; m < proxyInfo.MemberIds.Length; m++)
                {
                    var method = proxyInfo.MemberIds[m];
                    if(method==null)
                    {
                        continue;
                    }
                    try
                    {
                        IntPtr res = method.IsField
                                         ? method.IsStatic
                                               ? env.GetStaticFieldIDNoThrow(proxyInfo.JVMApi.JvmHandle, method.Name, method.Signature)
                                               : env.GetFieldIDNoThrow(proxyInfo.JVMApi.JvmHandle, method.Name, method.Signature)
                                         : method.IsStatic
                                               ? env.GetStaticMethodIDNoThrow(proxyInfo.JVMApi.JvmHandle, method.Name, method.Signature)
                                               : env.GetMethodIDNoThrow(proxyInfo.JVMApi.JvmHandle, method.Name, method.Signature);
                        if (res == IntPtr.Zero)
                        {
                            throw new J4NException("Can't bind " + proxyInfo.JVMApiName + "." + method.Name + method.Signature);
                        }
                        proxyInfo.Members[m] = res;
                    }
                    catch (Exception ex)
                    {
                        var message = "Exception while binding member #" + m + ": " + proxyInfo.JVMApi + "." + method.Name;
                        Logger.LogError(message, ex);
                        throw new J4NException(message, ex);
                    }
                }

                var j4nMembers = proxyInfo.CLRStaticApi.GetField("j4n_Members", BindingFlags.Static | BindingFlags.NonPublic);
                if (j4nMembers == null)
                {
                    throw new J4NException("Can't find " + proxyInfo.CLRStaticApi.FullName + ".j4n_Members");
                }
                j4nMembers.SetValue(null, proxyInfo.Members);

                var j4nClass = proxyInfo.CLRStaticApi.GetField("j4n_Class", BindingFlags.Static | BindingFlags.NonPublic);
                if (j4nClass == null)
                {
                    throw new J4NException("Can't find " + proxyInfo.CLRStaticApi.FullName + ".j4n_Class");
                }
                j4nClass.SetValue(null, proxyInfo.JVMApi);

                JVMConversionToInfo.TryAdd(new JVMConversion(proxyInfo.JVMApi, proxyInfo.CLRApi), ref proxyInfo);

                proxyInfo.IsBound = true;
            }
        }

    }
}
