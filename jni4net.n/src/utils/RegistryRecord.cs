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
    }
}
