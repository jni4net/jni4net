using System;
using System.Collections.Generic;
using System.Reflection;
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
        #region Singleton

        private static Registry defaultRegistry = new Registry();

        public static Registry Default
        {
            get { return defaultRegistry; }
        }

        #endregion

        private readonly Dictionary<Type, RegistryRecord> knownCLRWrappers = new Dictionary<Type, RegistryRecord>();
        private readonly Dictionary<Type, RegistryRecord> knownCLRProxies = new Dictionary<Type, RegistryRecord>();
        private readonly Dictionary<Type, RegistryRecord> knownCLRInterfaces = new Dictionary<Type, RegistryRecord>();
        private readonly Dictionary<Type, RegistryRecord> knownCLR = new Dictionary<Type, RegistryRecord>();
        private readonly Dictionary<Class, RegistryRecord> knownJVMInterfaces = new Dictionary<Class, RegistryRecord>();
        private readonly Dictionary<Class, RegistryRecord> knownJVMProxies = new Dictionary<Class, RegistryRecord>();
        private readonly Dictionary<Class, RegistryRecord> knownJVM = new Dictionary<Class, RegistryRecord>();
        private readonly bool initialized;

        public Registry()
        {
            if (Default == null)
            {
                defaultRegistry = this;
            }

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
        }

        public void RegisterAssembly(Assembly assembly, bool bindJVM)
        {
            lock (this)
            {
                JNIEnv env = JNIEnv.ThreadEnv;
                foreach (Type type in assembly.GetTypes())
                {
                    RegisterType(type, bindJVM, env);
                }
            }
        }

        private void RegisterPrimitiveType(string clazzName, Type type, Type jvmBoxed)
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

        private void RegisterType(Type type, bool bindJVM, JNIEnv env)
        {
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

        private void BindJvm(RegistryRecord record, JNIEnv env)
        {
            RegisterClass(record, env);
            if (record.CLRProxy != null)
            {
                RegisterStaticAndMethods(record, env);
                if (initialized)
                {
                    RegisterTypeOf(record, env);
                }
            }
            if (initialized)
            {
                if (record.CLRWrapper != null)
                {
                    RegisterNative(record.CLRWrapperInitMethod, env, record.JVMProxy, record.JVMInterface);
                }
                RegisterClassToMap(record);
                record.JVMBound = true;
            }
        }

        private void RegisterClass(RegistryRecord record, JNIEnv env)
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
            else
            {
                proxyName = interfaceName;
                staticName = interfaceName;
            }
            record.JVMInterface = env.FindClassNoThrow(interfaceName.Replace('.', '/'));
            record.JVMStatic = env.FindClassNoThrow(staticName.Replace('.', '/'));
            if (proxyName != null)
            {
                record.JVMProxy = env.FindClassNoThrow(proxyName.Replace('.', '/'));
                record.JVMConstructor = GetJVMConstructor(env, record.IsInterface, record.JVMProxy);
                knownJVMProxies[record.JVMProxy] = record;
                knownJVM[record.JVMProxy] = record;
            }
        }

        private void RegisterClassToMap(RegistryRecord record)
        {
            knownJVMInterfaces[record.JVMInterface] = record;
            knownJVM[record.JVMInterface] = record;
            knownJVM[record.JVMStatic] = record;
        }

        private void RegisterInterfaceProxy(Type proxyType, ref RegistryRecord record)
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
            record.CLRStatic =
                record.CLRAssembly.GetType(
                    GetStaticName(record.CLRInterface.Namespace, record.CLRInterface.Name, false), false);
            knownCLR[record.CLRStatic] = record;
        }

        private void RegisterClassProxy(Type proxyType, ref RegistryRecord record)
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

        private void RegisterProxy(Type proxyType, Type interfaceType, ref RegistryRecord record)
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

        private void RegisterWrapper(Type wrapperType, ref RegistryRecord record)
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
                                         IsCLRType = !interfaceType.IsInterface
                                     };
                    }
                }
            }
            record.CLRInterface = interfaceType;
            record.CLRWrapper = wrapperType;
            record.CLRWrapperInitMethod = GetWrapperInitializer(wrapperType);
            record.CLRName = interfaceType.FullName;
            record.JVMName = interfaceType.Namespace.ToLowerInvariant() + "." + interfaceType.Name;

            knownCLRWrappers[wrapperType] = record;
            knownCLRInterfaces[interfaceType] = record;
            knownCLR[interfaceType] = record;
            knownCLR[wrapperType] = record;
        }
    }
}
