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
using System.Threading;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    partial class Registry
    {
        internal static void Unload1()
        {
            var env = JNIEnv.ThreadEnv;
            using (new LocalFrame(env, 100))
            {
                PendingJvmProxyInits.Clear();
                PendingClrProxyInits.Clear();
                PendingModuleInits.Clear();

                foreach (var proxyInfo in CLRApiToInfo.Values)
                {
                    if (proxyInfo.IsBackBound)
                    {
                        /*IntPtr j4nTypeInfo = env.GetStaticFieldID(proxyInfo.JVMStaticApi, "j4n_TypeInfo", "Lnet/sf/jni4net/core/ProxyInfo;");
                        env.SetStaticObjectField(proxyInfo.JVMStaticApi, j4nTypeInfo, IntPtr.Zero);

                        IntPtr j4nType = env.GetStaticFieldID(proxyInfo.JVMStaticApi, "j4n_Type", "Lsystem/IType;");
                        env.SetStaticObjectField(proxyInfo.JVMStaticApi, j4nType, IntPtr.Zero);
                         */
                        
                        env.UnregisterNatives(proxyInfo.JVMProxy.JvmHandle, proxyInfo.JVMProxy.getName());
                    }
                }

                foreach (var proxyInfo in CLRApiToInfo.Values)
                {
                    if (proxyInfo.JVMApiName.Contains("Foobararable"))
                    {
                        int xxx = 0;
                    }
                    if (proxyInfo.IsBound || proxyInfo.IsBackBound)
                    {
                        var j4nMembers = proxyInfo.CLRStaticApi.GetField("j4n_Members", BindingFlags.Static | BindingFlags.NonPublic);
                        if (j4nMembers == null)
                        {
                            throw new J4NException("Can't find " + proxyInfo.CLRStaticApi.FullName + ".j4n_Members");
                        }
                        j4nMembers.SetValue(null, null);

                        var j4nClass = proxyInfo.CLRStaticApi.GetField("j4n_Class", BindingFlags.Static | BindingFlags.NonPublic);
                        if (j4nClass == null)
                        {
                            throw new J4NException("Can't find " + proxyInfo.CLRStaticApi.FullName + ".j4n_Class");
                        }
                        j4nClass.SetValue(null, null);

                    }
                    if (proxyInfo.IsJVM || proxyInfo.IsInterface)
                    {
                        if (!PendingJvmProxyInits.ContainsKey(proxyInfo.CLRApi))
                        {
                            PendingJvmProxyInits.Add(proxyInfo.CLRApi, proxyInfo);
                        }
                    }
                    if (proxyInfo.IsCLR || proxyInfo.IsInterface)
                    {
                        if (!PendingClrProxyInits.ContainsKey(proxyInfo.CLRApi))
                        {
                            PendingClrProxyInits.Add(proxyInfo.CLRApi, proxyInfo);
                        }
                    }
                    proxyInfo.Unload();
                }
                foreach (var proxyInfo in JVMApiNameToInfo.Values)
                {
                    if (proxyInfo.IsBound || proxyInfo.IsBackBound)
                    {
                        var j4nMembers = proxyInfo.CLRStaticApi.GetField("j4n_Members", BindingFlags.Static | BindingFlags.NonPublic);
                        if (j4nMembers == null)
                        {
                            throw new J4NException("Can't find " + proxyInfo.CLRStaticApi.FullName + ".j4n_Members");
                        }
                        j4nMembers.SetValue(null, null);

                        var j4nClass = proxyInfo.CLRStaticApi.GetField("j4n_Class", BindingFlags.Static | BindingFlags.NonPublic);
                        if (j4nClass == null)
                        {
                            throw new J4NException("Can't find " + proxyInfo.CLRStaticApi.FullName + ".j4n_Class");
                        }
                        j4nClass.SetValue(null, null);

                    }
                    if (proxyInfo.IsJVM || proxyInfo.IsInterface)
                    {
                        if (!PendingJvmProxyInits.ContainsKey(proxyInfo.CLRApi))
                        {
                            PendingJvmProxyInits.Add(proxyInfo.CLRApi, proxyInfo);
                        }
                    }
                    if (proxyInfo.IsCLR || proxyInfo.IsInterface)
                    {
                        if (!PendingClrProxyInits.ContainsKey(proxyInfo.CLRApi))
                        {
                            PendingClrProxyInits.Add(proxyInfo.CLRApi, proxyInfo);
                        }
                    }
                    proxyInfo.Unload();
                }
           
                javaLangObject.JVMProxyFactory = null;
                javaLangClass.JVMProxyFactory = null;

                javaLangClass = null;
                javaLangObject = null;
                javaLangString = null;
                javaLangThrowable = null;

                javaLangBoolean = null;
                javaLangByte = null;
                javaLangCharacter = null;
                javaLangShort = null;
                javaLangInteger = null;
                javaLangLong = null;
                javaLangFloat = null;
                javaLangDouble = null;

                systemObject = null;
                systemException = null;
                currentBridgeSetup = null;
                outWrapper = null;
                refWrapper = null;

                unwrapClrProxy = null;
                unwrapJvmProxy = null;

                IClrProxy = null;
                if (JvmCoreHooks != null)
                {
                    JvmCoreHooks.UnloadJ4N();
                    JvmCoreHooks = null;
                }
                if (ClrCoreHooks != null)
                {
                    ClrCoreHooks.UnloadJ4N(env);
                    ClrCoreHooks = null;
                }
                clrProxyFactoryMethodId = IntPtr.Zero;
                clrProxyGetClrHandleMethodId = IntPtr.Zero;


                JVMConversionToInfo.Clear();
                CLRConversionToInfo.Clear();
            }
        }

        internal static void Unload2()
        {
            var env = JNIEnv.ThreadEnv;
            using (new LocalFrame(env, 100))
            {
                if (isBackInitialized)
                {
                    /*IntPtr bslh = env.FindClass("net.sf.jni4net.J4NBridge");
                    IntPtr cbs = env.GetStaticFieldID(bslh, "currentSetup", "Lnet/sf/jni4net/CurrentBridgeSetup;");
                    env.SetStaticObjectField(bslh, cbs, IntPtr.Zero);*/

                    var registry = env.FindClass(netSfJni4netCoreRegistry);
                    env.UnregisterNatives(registry, netSfJni4netCoreRegistry);
                }

                IntPtr system = env.FindClass("java.lang.System");
                IntPtr gc = env.GetStaticMethodID(system, "gc", "()V");

                for (int i = 0; i < 10; i++)
                {
                    env.CallStaticVoidMethod(system, gc);
                    GC.Collect();
                    GC.WaitForFullGCComplete();
                    GC.WaitForPendingFinalizers();
                    Thread.Sleep(1);
                }
            }


            isInitialized = false;
            isBackInitialized = false;
        }

    }
}
