using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public class RegistryRecord
    {
        public bool IsInterface;
        public bool IsCLRType;
        public bool IsJVMClass;
        public string JVMName;
        public string CLRName;

        public Type CLRInterface;
        public Type CLRWrapper;
        public Type CLRProxy;
        public Type CLRStatic;
        public MethodInfo CLRProxyInitMethod;
        public MethodInfo CLRWrapperInitMethod;
        public IConstructionHelper CLRConstructor;
        public Assembly CLRAssembly;

        public Class JVMInterface;
        public Class JVMProxy;
        public Class JVMStatic;
        public MethodId JVMConstructor;
        public bool JVMBound;

        public override string ToString()
        {
            return JVMName;
        }

        internal IntPtr CreateJVMProxy(JNIEnv env, object obj)
        {
            int handle = IntHandle.Alloc(obj);
            return env.NewObjectPtr(JVMProxy.native, JVMConstructor, new Value(), new Value {_int = handle});
        }

        internal IJavaProxy CreateCLRProxy(JNIEnv env, IntPtr obj, Class clazz)
        {
            IJavaProxy proxy = CLRConstructor.CreateProxy(env);
            proxy.Init(env, obj, clazz);
            return proxy;
        }
    }
}
