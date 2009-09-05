using System;
using System.Collections.Generic;
using System.Reflection;
using net.sf.jni4net.attributes;
using net.sf.jni4net.jni;
using Class = java.lang.Class;

namespace net.sf.jni4net.utils
{
    partial class Registry
    {
        #region Singleton

        private static readonly Registry defaultRegistry = new Registry();

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

        public Registry()
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            RegisterType(typeof(__Type), true, env);
            RegisterType(typeof(__Object), true, env);
            RegisterType(typeof(__String), true, env);
            RegisterType(typeof(Class), true, env);
            RegisterType(typeof(java.lang.Object), true, env);
            RegisterType(typeof(java.lang.String), true, env);

            RegisterType(typeof(java.lang.Boolean), true, env);
            RegisterType(typeof(java.lang.Byte), true, env);
            RegisterType(typeof(java.lang.Character), true, env);
            RegisterType(typeof(java.lang.Short), true, env);
            RegisterType(typeof(java.lang.Integer), true, env);
            RegisterType(typeof(java.lang.Long), true, env);
            RegisterType(typeof(java.lang.Float), true, env);
            RegisterType(typeof(java.lang.Double), true, env);

            RegisterPrimitiveType("boolean", typeof(bool));
            RegisterPrimitiveType("byte", typeof(byte));
            RegisterPrimitiveType("char", typeof(char));
            RegisterPrimitiveType("short", typeof(short));
            RegisterPrimitiveType("int", typeof(int));
            RegisterPrimitiveType("long", typeof(long));
            RegisterPrimitiveType("float", typeof(float));
            RegisterPrimitiveType("double", typeof(double));
            RegisterPrimitiveType("void", typeof(void));
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

        private void RegisterPrimitiveType(string clazzName, Type type)
        {
            RegistryRecord record = new RegistryRecord();
            Class clazz = Class.getPrimitiveClass(clazzName);
            record.JVMInterface = clazz;
            record.IsJVMClass = true;
            record.CLRInterface = type;
            record.IsCLRType = true;
            record.JVMName = clazzName;
            record.CLRName = type.Name;

            knownJVMInterfaces[record.JVMInterface] = record;
            knownJVM[record.JVMInterface] = record;
            knownCLRInterfaces[record.CLRInterface] = record;
            knownCLR[record.CLRInterface] = record;
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
                    RegisterClass(record, env);
                    if (record.CLRProxy != null)
                    {
                        RegisterStaticAndMethods(record, env);
                    }
                    if (record.CLRWrapper != null)
                    {
                        RegisterNative(record.CLRWrapperInitMethod, env, record.JVMProxy, record.JVMInterface);
                    }
                    record.JVMBound = true;
                }
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
            record.CLRStatic = record.CLRAssembly.GetType(GetStaticName(record.CLRInterface.Namespace, record.CLRInterface.Name, false), false);
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
            record.JVMName = interfaceType.Namespace.ToLowerInvariant()+"."+interfaceType.Name;

            knownCLRWrappers[wrapperType] = record;
            knownCLRInterfaces[interfaceType] = record;
            knownCLR[interfaceType] = record;
            knownCLR[wrapperType] = record;
        }
    }
}
