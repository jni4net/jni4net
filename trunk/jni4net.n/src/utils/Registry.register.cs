using System;
using System.Collections.Generic;
using System.Reflection;
using java.lang;
using net.sf.jni4net.attributes;
using net.sf.jni4net.jni;
using Object=System.Object;
using String=System.String;

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

        public Registry()
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            RegisterType(typeof(__Type), true, env);
            RegisterType(typeof(__Object), true, env);
            RegisterType(typeof(__String), true, env);
            RegisterType(typeof(Class), true, env);
            RegisterType(typeof(Object), true, env);
            RegisterType(typeof(String), true, env);
        }

        public void RegisterAssembly(Assembly assembly, bool bindJVM)
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            foreach (Type type in assembly.GetTypes())
            {
                RegisterType(type, bindJVM, env);
            }
        }

        private static void RegisterClass(RegistryRecord record, JNIEnv env)
        {
            string package = record.CLRInterface.Namespace;
            string className = record.CLRInterface.Name;
            string interfaceName = package.ToLowerInvariant() + "." + className;
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
            }
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

            knownCLRProxies[proxyType] = record;
            knownCLRInterfaces[interfaceType] = record;
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

            knownCLRWrappers[wrapperType] = record;
            knownCLRInterfaces[interfaceType] = record;
        }
    }
}
