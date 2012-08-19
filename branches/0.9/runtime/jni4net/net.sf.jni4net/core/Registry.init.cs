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
using System.IO;
using System.Reflection;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    partial class Registry
    {
        public static IntPtr[] dummyMethods=new IntPtr[1000];

        internal static readonly object syncroot = J4NBridge.syncRoot;

        const string netSfJni4netCoreRegistry = "net.sf.jni4net.core.Registry";
        const string netSfJni4netCoreIClrProxyFactory = "net.sf.jni4net.core.IClrProxyFactory";
        const string jlsystemItypeLnetSfJni4netIclrproxy = "(J)Lnet/sf/jni4net/IClrProxy;";
        private static bool isInitialized;
        private static bool isBackInitialized;
        public static bool IsInitialized { get { return isInitialized; } }
        public static bool IsBackInitialized { get { return isBackInitialized; } }
        private static readonly Dictionary<Type, ProxyInfo> PendingJvmProxyInits = new Dictionary<Type, ProxyInfo>(); 
        private static readonly Dictionary<Type, ProxyInfo> PendingClrProxyInits = new Dictionary<Type, ProxyInfo>();
        private static readonly List<ModuleInfo> PendingModuleInits = new List<ModuleInfo>();

        internal static ProxyInfo javaLangClass;
        internal static ProxyInfo javaLangObject;
        internal static ProxyInfo javaLangString;
        internal static ProxyInfo javaLangThrowable;
        internal static ProxyInfo javaLangBoolean;
        internal static ProxyInfo javaLangByte;
        internal static ProxyInfo javaLangCharacter;
        internal static ProxyInfo javaLangShort;
        internal static ProxyInfo javaLangInteger;
        internal static ProxyInfo javaLangLong;
        internal static ProxyInfo javaLangFloat;
        internal static ProxyInfo javaLangDouble;

        internal static ProxyInfo systemType;
        internal static ProxyInfo systemObject;
        internal static ProxyInfo systemString;
        internal static ProxyInfo systemException;
        internal static ProxyInfo systemBool;
        internal static ProxyInfo systemByte;
        internal static ProxyInfo systemChar;
        internal static ProxyInfo systemShort;
        internal static ProxyInfo systemInt;
        internal static ProxyInfo systemLong;
        internal static ProxyInfo systemFloat;
        internal static ProxyInfo systemDouble;

        internal static ProxyInfo currentBridgeSetup;
        internal static ProxyInfo outWrapper;
        internal static ProxyInfo refWrapper;
        internal static IntPtr outWrapperConstructor;
        internal static IntPtr refWrapperConstructor;
        internal static IntPtr outWrapperField;
        internal static IntPtr refWrapperField;

        internal static ProxyInfo unwrapClrProxy;
        internal static ProxyInfo unwrapJvmProxy;

        internal static ProxyInfo unboxStringPI;


        internal static IClass IClrProxy;
        internal static IJvmCoreHooks JvmCoreHooks;
        internal static IClrCoreHooks ClrCoreHooks;
        internal static IntPtr clrProxyFactoryMethodId;
        internal static IntPtr clrProxyGetClrHandleMethodId;

        internal static readonly DictionarySWMR<Type, ProxyInfo> CLRApiToInfo = new DictionarySWMR<Type, ProxyInfo>(syncroot);
        internal static readonly DictionarySWMR<string, ProxyInfo> JVMApiNameToInfo = new DictionarySWMR<string, ProxyInfo>(syncroot);
        internal static readonly DictionarySWMR<JVMConversion, ProxyInfo> JVMConversionToInfo = new DictionarySWMR<JVMConversion, ProxyInfo>(syncroot);
        internal static readonly DictionarySWMR<CLRConversion, ProxyInfo> CLRConversionToInfo = new DictionarySWMR<CLRConversion, ProxyInfo>(syncroot);

        internal static readonly FieldInfo _innerException = typeof(Exception).GetField("_innerException", BindingFlags.Instance | BindingFlags.NonPublic);

        public struct CLRConversion
        {
            public CLRConversion(Type instance, string api)
            {
                Api = api;
                Instance = instance;
            }

            public readonly string Api;
            public readonly Type Instance;

            public override string ToString()
            {
                return Instance.FullName + " -> " + Api;
            }
        }

        public struct JVMConversion
        {
            public JVMConversion(IClass instance, Type api)
            {
                Api = api;
                Instance = instance;
            }

            public readonly Type Api;
            public readonly IClass Instance;

            public override string ToString()
            {
                return Instance.getName() + " -> " + Api.FullName;
            }
        }

        private struct ModuleInfo
        {
            public ModuleInfo(Type module, string className, string projectName, string moduleJar)
            {
                Module = module;
                ClassName = className;
                ProjectName = projectName;
                ModuleJar = moduleJar;
            }

            public readonly Type Module;
            public readonly string ClassName;
            public readonly string ProjectName;
            public readonly string ModuleJar;
        }


        internal static void Init(JNIEnv env, BridgeSetup setup)
        {
            lock (syncroot) using (new LocalFrame(env, 1000))
            {
                Logger.LogDebug("Registry.Init() ");

                Assembly coreJvm = Assembly.Load(J4NBridge.currentSetup.JVMCoreLib);
                Type hooksType = coreJvm.GetType("net.sf.jni4net.core.JvmCoreHooks");
                if (hooksType == null)
                {
                    throw new J4NException("Can't find net.sf.jni4net.core.JvmCoreHooks in " + coreJvm.Location);
                }
                unwrapJvmProxy = new ProxyInfo
                                     {
                                         JVMApiName = "Unwrap real Jvm object",
                                         CLRProxyFactory = (e, v, t) => ((IJvmProxy) v).JvmHandle
                                     };

                JvmCoreHooks = (IJvmCoreHooks)Activator.CreateInstance(hooksType);
                JvmCoreHooks.InitJ4N(env, setup, s =>
                {
                    foreach (var init in PendingJvmProxyInits)
                    {
                        BindJvmProxy(env, init.Value);
                    }
                    PendingJvmProxyInits.Clear();

                    unboxStringPI = new ProxyInfo()
                        {
                            JVMApiName = "Unbox real Jvm String",
                            JVMProxyFactory = (e, lh, iif) => e.GetString(lh),
                        };



                    isInitialized = true;
                });
                Logger.LogDebug("Registry.Init() Done");
            }
        }

        internal static void InitNative(JNIEnv env)
        {
            lock (syncroot) using (new LocalFrame(env,1000))
            {
                Logger.LogDebug("Registry.InitNative()");
                var disposeClrHandle = typeof(Registry).GetMethod("disposeClrHandle", BindingFlags.Static | BindingFlags.NonPublic);
                var registerNative = typeof(Registry).GetMethod("registerNative", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedBool = typeof(Registry).GetMethod("createBoxedBool", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedByte = typeof(Registry).GetMethod("createBoxedByte", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedChar = typeof(Registry).GetMethod("createBoxedChar", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedShort = typeof(Registry).GetMethod("createBoxedShort", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedInteger = typeof(Registry).GetMethod("createBoxedInteger", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedLong = typeof(Registry).GetMethod("createBoxedLong", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedFloat = typeof(Registry).GetMethod("createBoxedFloat", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedDouble = typeof(Registry).GetMethod("createBoxedDouble", BindingFlags.Static | BindingFlags.NonPublic);
                var createBoxedString = typeof(Registry).GetMethod("createBoxedString", BindingFlags.Static | BindingFlags.NonPublic);

                var unboxBool = typeof(Registry).GetMethod("unboxBool", BindingFlags.Static | BindingFlags.NonPublic);
                var unboxByte = typeof(Registry).GetMethod("unboxByte", BindingFlags.Static | BindingFlags.NonPublic);
                var unboxChar = typeof(Registry).GetMethod("unboxChar", BindingFlags.Static | BindingFlags.NonPublic);
                var unboxShort = typeof(Registry).GetMethod("unboxShort", BindingFlags.Static | BindingFlags.NonPublic);
                var unboxInteger = typeof(Registry).GetMethod("unboxInteger", BindingFlags.Static | BindingFlags.NonPublic);
                var unboxLong = typeof(Registry).GetMethod("unboxLong", BindingFlags.Static | BindingFlags.NonPublic);
                var unboxFloat = typeof(Registry).GetMethod("unboxFloat", BindingFlags.Static | BindingFlags.NonPublic);
                var unboxDouble = typeof(Registry).GetMethod("unboxDouble", BindingFlags.Static | BindingFlags.NonPublic);
                var unboxString = typeof(Registry).GetMethod("unboxString", BindingFlags.Static | BindingFlags.NonPublic);

                var list = new List<JNINativeMethod>
                               {
                                   new JNINativeMethod(registerNative, "RegisterProxy","(Ljava/lang/String;)I"),
                                   new JNINativeMethod(disposeClrHandle, "DisposeClrHandle","(J)V"),
                                   new JNINativeMethod(createBoxedBool, "CreateBoxedBool","(Z)J"),
                                   new JNINativeMethod(createBoxedByte, "CreateBoxedByte","(B)J"),
                                   new JNINativeMethod(createBoxedChar, "CreateBoxedChar","(C)J"),
                                   new JNINativeMethod(createBoxedShort, "CreateBoxedShort","(S)J"),
                                   new JNINativeMethod(createBoxedInteger, "CreateBoxedInteger","(I)J"),
                                   new JNINativeMethod(createBoxedLong, "CreateBoxedLong","(J)J"),
                                   new JNINativeMethod(createBoxedFloat, "CreateBoxedFloat","(F)J"),
                                   new JNINativeMethod(createBoxedDouble, "CreateBoxedDouble","(D)J"),
                                   new JNINativeMethod(createBoxedString, "CreateBoxedString","(Ljava/lang/String;)J"),

                                   new JNINativeMethod(unboxBool, "UnboxBool","(J)Z"),
                                   new JNINativeMethod(unboxByte, "UnboxByte","(J)B"),
                                   new JNINativeMethod(unboxChar, "UnboxChar","(J)C"),
                                   new JNINativeMethod(unboxShort, "UnboxShort","(J)S"),
                                   new JNINativeMethod(unboxInteger, "UnboxInteger","(J)I"),
                                   new JNINativeMethod(unboxLong, "UnboxLong","(J)J"),
                                   new JNINativeMethod(unboxFloat, "UnboxFloat","(J)F"),
                                   new JNINativeMethod(unboxDouble, "UnboxDouble","(J)D"),
                                   new JNINativeMethod(unboxString, "UnboxString","(J)Ljava/lang/String;"),
                               };
                var clazz = env.FindClassNoThrow(netSfJni4netCoreRegistry);
                if (clazz == IntPtr.Zero)
                {
                    AutoAddJavaRuntime();
                    clazz = J4NBridge.currentSetup.DefaultClassLoader.loadClass(netSfJni4netCoreRegistry).JvmHandle;
                }

                env.RegisterNatives(list, clazz, netSfJni4netCoreRegistry);

                clazz = env.FindClassNoThrow(netSfJni4netCoreIClrProxyFactory);
                clrProxyFactoryMethodId = env.GetMethodID(clazz, "CreateInstance", jlsystemItypeLnetSfJni4netIclrproxy);

                Assembly coreClr = Assembly.Load(J4NBridge.currentSetup.CLRCoreLib);
                Type hooksType = coreClr.GetType("net.sf.jni4net.core.ClrCoreHooks");
                if (hooksType == null)
                {
                    throw new J4NException("Can't find net.sf.jni4net.core.ClrCoreHooks in " + coreClr.Location);
                }

                IClrProxy = FindClass(env, "net.sf.jni4net.IClrProxy", null);
                clrProxyGetClrHandleMethodId = env.GetMethodID(IClrProxy, "_getClrHandle", "()J");

                unwrapClrProxy = new ProxyInfo
                                     {
                                         JVMApiName = "Unwrap real Clr object",
                                         JVMProxyFactory = unwrap_ClrProxyFactory
                                     };

                ClrCoreHooks = (IClrCoreHooks)Activator.CreateInstance(hooksType);
                ClrCoreHooks.InitJ4N(env, s =>
                    {
                        foreach (var moduleInfo in PendingModuleInits)
                        {
                            CheckModuleImpl(moduleInfo, JNIEnv.ThreadEnv);
                        }
                        PendingModuleInits.Clear();
                        foreach (var init in PendingClrProxyInits)
                        {
                            BindClrProxy(env, init.Value);
                        }
                        PendingClrProxyInits.Clear();
                        isBackInitialized = true;
                    }, JvmCoreHooks);

                Logger.LogDebug("Registry.InitNative() done");
            }
        }

        private static void RegisterJVMConversions(ProxyInfo proxyInfo, IEnumerable<JVMConversion> toregister)
        {
            foreach (JVMConversion reg in toregister)
            {
                JVMConversionToInfo.TryAdd(reg, ref proxyInfo);
                Logger.LogDebug("CoreHooks.RegisterJVMConversions() " + reg + " as " + proxyInfo);
            }
        }

        private static void RegisterCLRConversions(ProxyInfo proxyInfo, IEnumerable<CLRConversion> toregister)
        {
            foreach (CLRConversion reg in toregister)
            {
                CLRConversionToInfo.TryAdd(reg, ref proxyInfo);
                Logger.LogDebug("CoreHooks.RegisterCLRConversions() " + reg + " as " + proxyInfo);
            }
        }

        public static void RegisterModule(Type module, string className, string projectName)
        {
            string fullPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(module.Assembly.Location), projectName + ".jar"));
            RegisterModule(new ModuleInfo(module, className, projectName, fullPath));
        }

        private static void RegisterModule(ModuleInfo moduleInfo)
        {
            lock (syncroot)
            {
                if(isInitialized && J4NBridge.currentSetup.BindClrProxies)
                {
                    CheckModuleImpl(moduleInfo, JNIEnv.ThreadEnv);
                }
                else
                {
                    PendingModuleInits.Add(moduleInfo);
                }
            }
        }

        private static void CheckModuleImpl(ModuleInfo moduleInfo, JNIEnv env)
        {
            if (env.FindClassNoThrow(moduleInfo.ClassName) == IntPtr.Zero)
            {
                Logger.LogInfo("Adding to classPath " + moduleInfo.ModuleJar);
                JvmCoreHooks.AddURL(J4NBridge.currentSetup.DefaultClassLoader, moduleInfo.ModuleJar);
                if (env.FindClassNoThrow(moduleInfo.ClassName) == IntPtr.Zero)
                {
                    Logger.LogWarn("Can't find module " + moduleInfo.ProjectName);
                }
            }
        }

        private static void AutoAddJavaRuntime()
        {
            string fullPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(typeof(Registry).Assembly.Location),"jni4net.jar"));
            Logger.LogInfo("Adding to classPath " + fullPath);
            JvmCoreHooks.AddURL(J4NBridge.currentSetup.DefaultClassLoader, fullPath);
        }
    }
}
