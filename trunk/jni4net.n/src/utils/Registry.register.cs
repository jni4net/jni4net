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
using System.Collections.Generic;
using System.Reflection;
using java.io;
using java.lang;
using net.sf.jni4net.attributes;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using Boolean=java.lang.Boolean;
using Byte=java.lang.Byte;
using Double=java.lang.Double;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Registry
    {
        private static readonly bool initialized;
        private static readonly Dictionary<Type, RegistryRecord> knownCLR = new Dictionary<Type, RegistryRecord>();

        private static readonly Dictionary<Type, RegistryRecord> knownCLRInterfaces =
            new Dictionary<Type, RegistryRecord>();

        private static readonly Dictionary<Type, RegistryRecord> knownCLRProxies =
            new Dictionary<Type, RegistryRecord>();

        private static readonly Dictionary<Type, RegistryRecord> knownCLRWrappers =
            new Dictionary<Type, RegistryRecord>();

        private static readonly Dictionary<Class, RegistryRecord> knownJVM = new Dictionary<Class, RegistryRecord>();

        private static readonly Dictionary<Class, RegistryRecord> knownJVMInterfaces =
            new Dictionary<Class, RegistryRecord>();

        private static readonly Dictionary<Class, RegistryRecord> knownJVMProxies =
            new Dictionary<Class, RegistryRecord>();

        internal static ClassLoader systemClassLoader;

        static Registry()
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            RegisterType(typeof (Class), true, env);
            RegisterType(typeof (Object), true, env);
            RegisterType(typeof (String), true, env);
            RegisterType(typeof (__Type), true, env);
            RegisterType(typeof (__Object), true, env);
            RegisterType(typeof (__String), true, env);
            RegisterType(typeof (__IClrProxy), true, env);
            initialized = true;

            BindJvm(knownCLR[typeof (Class)], env);
            BindJvm(knownCLR[typeof (Object)], env);
            BindJvm(knownCLR[typeof (String)], env);
            BindJvm(knownCLR[typeof (__Type)], env);
            BindJvm(knownCLR[typeof (__Object)], env);
            BindJvm(knownCLR[typeof (__String)], env);
            BindJvm(knownCLR[typeof (__IClrProxy)], env);

            RegisterType(typeof (Boolean), true, env);
            RegisterType(typeof (Byte), true, env);
            RegisterType(typeof (Character), true, env);
            RegisterType(typeof (Short), true, env);
            RegisterType(typeof (Integer), true, env);
            RegisterType(typeof (Long), true, env);
            RegisterType(typeof (Float), true, env);
            RegisterType(typeof (Double), true, env);

            RegisterPrimitiveType("boolean", typeof (bool), typeof (Boolean));
            RegisterPrimitiveType("byte", typeof (byte), typeof (Byte));
            RegisterPrimitiveType("char", typeof (char), typeof (Character));
            RegisterPrimitiveType("short", typeof (short), typeof (Short));
            RegisterPrimitiveType("int", typeof (int), typeof (Integer));
            RegisterPrimitiveType("long", typeof (long), typeof (Long));
            RegisterPrimitiveType("float", typeof (float), typeof (Float));
            RegisterPrimitiveType("double", typeof (double), typeof (Double));
            RegisterPrimitiveType("void", typeof (void), null);

            Convertor.boolObject = env.GetStaticMethodID(Boolean.staticClass, "valueOf", "(Z)Ljava/lang/Boolean;");
            Convertor.byteObject = env.GetStaticMethodID(Byte.staticClass, "valueOf", "(B)Ljava/lang/Byte;");
            Convertor.charObject = env.GetStaticMethodID(Character.staticClass, "valueOf", "(C)Ljava/lang/Character;");
            Convertor.shortObject = env.GetStaticMethodID(Short.staticClass, "valueOf", "(S)Ljava/lang/Short;");
            Convertor.intObject = env.GetStaticMethodID(Integer.staticClass, "valueOf", "(I)Ljava/lang/Integer;");
            Convertor.longObject = env.GetStaticMethodID(Long.staticClass, "valueOf", "(J)Ljava/lang/Long;");
            Convertor.doubleObject = env.GetStaticMethodID(Double.staticClass, "valueOf", "(D)Ljava/lang/Double;");
            Convertor.floatObject = env.GetStaticMethodID(Float.staticClass, "valueOf", "(F)Ljava/lang/Float;");

            Convertor.boolValue = env.GetMethodID(Boolean.staticClass, "booleanValue", "()Z");
            Convertor.byteValue = env.GetMethodID(Byte.staticClass, "byteValue", "()B");
            Convertor.charValue = env.GetMethodID(Character.staticClass, "charValue", "()C");
            Convertor.shortValue = env.GetMethodID(Short.staticClass, "shortValue", "()S");
            Convertor.intValue = env.GetMethodID(Integer.staticClass, "intValue", "()I");
            Convertor.longValue = env.GetMethodID(Long.staticClass, "longValue", "()J");
            Convertor.doubleValue = env.GetMethodID(Double.staticClass, "doubleValue", "()D");
            Convertor.floatValue = env.GetMethodID(Float.staticClass, "floatValue", "()F");

            RegisterType(typeof(__Bridge), true, env);
            RegisterType(typeof(__Exception), true, env);
            RegisterType(typeof(Throwable), true, env);
            RegisterType(typeof(__IJvmProxy), true, env);
            RegisterType(typeof(ClassLoader), true, env);

            systemClassLoader = ClassLoader.getSystemClassLoader();
        }

        public static void RegisterAssembly(Assembly assembly, bool bindJVM)
        {
            lock (typeof (Registry))
            {
                JNIEnv env = JNIEnv.ThreadEnv;
                foreach (Type type in assembly.GetTypes())
                {
                    RegisterType(type, bindJVM, env);
                }
            }
        }

        private static void RegisterPrimitiveType(string clazzName, Type type, Type jvmBoxed)
        {
            var record = new RegistryRecord();
            Class clazz = Class.getPrimitiveClass(clazzName);
            record.JVMInterface = clazz;
            record.IsJVMClass = true;
            record.CLRInterface = type;
            record.IsCLRType = true;
            record.JVMName = clazzName;
            record.CLRName = type.Name;
            if (jvmBoxed != null)
            {
                RegistryRecord jvmBoxedRec = knownCLR[jvmBoxed];
                record.JVMConstructor = jvmBoxedRec.JVMConstructor;
                record.JVMProxy = jvmBoxedRec.JVMProxy;
                record.JVMStatic = jvmBoxedRec.JVMStatic;
                record.JVMBound = jvmBoxedRec.JVMBound;
            }

            knownJVMInterfaces[clazz] = record;
            knownJVM[clazz] = record;
            //knownCLRInterfaces[record.CLRInterface] = record;
            //knownCLR[record.CLRInterface] = record;
        }

        public static void RegisterType(Type type, bool bindJVM, JNIEnv env)
        {
            if (Bridge.Setup.VeryVerbose)
            {
                Console.WriteLine("Registration : " + type.FullName);
            }
            if (type.Name.EndsWith("__TestDelegate"))
            {
                int i=0;
            }
            RegistryRecord record = null;
            RegisterWrapper(type, ref record);
            RegisterInterfaceProxy(type, ref record);
            RegisterClassProxy(type, ref record);
            if (record != null)
            {
                if (bindJVM && !record.JVMBound)
                {
                    BindJvm(record, env);
                }
            }
        }

        private static void BindJvm(RegistryRecord record, JNIEnv env)
        {
            RegisterClass(record, env);
            if (record.CLRProxy != null)
            {
                if (record.IsJVMClass || Bridge.Setup.BindCLRTypes)
                {
                    RegisterStaticAndMethods(record, env);
                    if (record.IsDelegate)
                    {
                        MethodInfo methodInfo = record.CLRInterface.GetMethod("Invoke");
                        ParameterInfo[] parameterInfo = methodInfo.GetParameters();
                        Type[] param=new Type[parameterInfo.Length];
                        for (int i = 0; i < param.Length; i++)
                        {
                            param[i] = parameterInfo[i].ParameterType;
                        }
                        record.JVMDelegateInvoke = record.CLRProxy.GetMethod("Invoke", param);
                    }
                }
                if (initialized && Bridge.Setup.BindStatic)
                {
                    RegisterTypeOf(record, env);
                }
            }
            if (initialized)
            {
                if (Bridge.Setup.BindNative && record.CLRWrapper != null)
                {
                    RegisterNative(record.CLRWrapperInitMethod, env, record.JVMProxy, record.JVMInterface);
                }
                RegisterClassToMap(record);
                record.JVMBound = true;
            }
        }

        private static void RegisterClass(RegistryRecord record, JNIEnv env)
        {
            string package = record.CLRInterface.Namespace;
            string className = record.CLRInterface.Name;
            string interfaceName = record.JVMName;
            string proxyName;
            string staticName;
            if (record.IsJVMClass)
            {
                staticName = GetStaticName(package, className, true);
                proxyName = null;
            }
            else if (record.IsInterface)
            {
                proxyName = GetProxyName(package, className, true);
                staticName = GetStaticName(package, className, true);
            }
            else if (record.IsDelegate)
            {
                proxyName = GetProxyName(package, className, true);
                staticName = interfaceName;
            }
            else
            {
                proxyName = interfaceName;
                staticName = interfaceName;
            }
            if (Bridge.Setup.BindCLRTypes || record.IsJVMClass)
            {
                record.JVMInterface = LoadClass(interfaceName, env);
            }
            record.JVMStatic = LoadClass(staticName, env);
            if (record.JVMStatic == null && Bridge.Setup.BindStatic)
            {
                throw new JNIException("Can't find java class for " + staticName);
            }
            if (proxyName != null && Bridge.Setup.BindStatic)
            {
                record.JVMProxy = LoadClass(proxyName, env);
                record.JVMConstructor = GetJVMConstructor(env, record.JVMProxy);
                if (record.JVMConstructor == null)
                {
                    throw new JNIException("Can't find java constructor for " + record.JVMProxy);
                }
                knownJVMProxies[record.JVMProxy] = record;
                knownJVM[record.JVMProxy] = record;
            }
        }

        private static Class LoadClass(string name, JNIEnv env)
        {
            Class res;
            string rn = name.Replace('.', '/');
            res = env.FindClassNoThrow(rn);
            if (res == null)
            {
                try
                {
                    res = systemClassLoader.loadClass(name);
                }
                catch(Throwable th)
                {
                    throw new JNIException("Can't find java class for " + name, th);
                }
            }
            if (res == null)
            {
                throw new JNIException("Can't find java class for " + name);
            }
            return res;
        }

        private static void RegisterClassToMap(RegistryRecord record)
        {
            if (record.JVMInterface != null)
            {
                knownJVMInterfaces[record.JVMInterface] = record;
                knownJVM[record.JVMInterface] = record;
            }
            if (record.JVMStatic != null)
            {
                knownJVM[record.JVMStatic] = record;
            }
        }

        private static void RegisterInterfaceProxy(Type proxyType, ref RegistryRecord record)
        {
            JavaProxyAttribute javaProxyAttribute = GetJavaProxyAttribute(proxyType);
            if (javaProxyAttribute == null)
            {
                return;
            }

            Type interfaceType = javaProxyAttribute.InterfaceType;
            if (interfaceType == null)
            {
                throw new JNIException("Can't initialize " + proxyType);
            }

            RegisterProxy(proxyType, interfaceType, ref record);
            record.CLRStatic = javaProxyAttribute.StaticType;
            knownCLR[record.CLRStatic] = record;
        }

        private static void RegisterClassProxy(Type proxyType, ref RegistryRecord record)
        {
            JavaClassAttribute javaClassAttribute = GetJavaClassAttribute(proxyType);
            if (javaClassAttribute == null)
            {
                return;
            }

            RegisterProxy(proxyType, proxyType, ref record);
            record.IsJVMClass = true;
            record.CLRStatic = proxyType;
        }

        private static void RegisterProxy(Type proxyType, Type interfaceType, ref RegistryRecord record)
        {
            if (record == null)
            {
                if (!knownCLRProxies.TryGetValue(proxyType, out record))
                {
                    if (!knownCLRInterfaces.TryGetValue(interfaceType, out record))
                    {
                        record = new RegistryRecord
                                     {
                                         CLRAssembly = proxyType.Assembly,
                                         IsInterface = interfaceType.IsInterface
                                     };
                    }
                }
            }
            record.CLRInterface = interfaceType;
            record.CLRProxy = proxyType;
            record.CLRConstructor = GetConstructor(proxyType);
            record.CLRProxyInitMethod = GetProxyInitializer(proxyType);
            record.CLRName = interfaceType.FullName;
            record.JVMName = interfaceType.Namespace.ToLowerInvariant() + "." + interfaceType.Name;

            knownCLRProxies[proxyType] = record;
            knownCLRInterfaces[interfaceType] = record;
            knownCLR[interfaceType] = record;
            knownCLR[proxyType] = record;
        }

        private static void RegisterWrapper(Type wrapperType, ref RegistryRecord record)
        {
            ClrWrapperAttribute wrapperAttribute = GetClrWrapperAttribute(wrapperType);
            if (wrapperAttribute == null)
            {
                return;
            }

            Type interfaceType = wrapperAttribute.InterfaceType;
            if (record == null)
            {
                if (!knownCLRWrappers.TryGetValue(wrapperType, out record))
                {
                    if (!knownCLRInterfaces.TryGetValue(interfaceType, out record))
                    {
                        record = new RegistryRecord
                                     {
                                         CLRAssembly = wrapperType.Assembly,
                                         IsInterface = interfaceType.IsInterface,
                                         IsCLRType = !interfaceType.IsInterface,
                                         IsDelegate =
                                             typeof (Delegate).IsAssignableFrom(interfaceType) &&
                                             typeof (Delegate) != interfaceType &&
                                             typeof (MulticastDelegate) != interfaceType,
                                     };
                    }
                }
            }
            record.CLRInterface = interfaceType;
            record.CLRWrapper = wrapperType;
            record.CLRWrapperInitMethod = GetWrapperInitializer(wrapperType, "__Init");
            record.CLRName = interfaceType.FullName;
            record.JVMName = interfaceType.Namespace.ToLowerInvariant() + "." + interfaceType.Name;
            record.CLRStatic = wrapperAttribute.StaticType;

            knownCLRWrappers[wrapperType] = record;
            knownCLRInterfaces[interfaceType] = record;
            knownCLR[interfaceType] = record;
            knownCLR[wrapperType] = record;
        }
    }
}