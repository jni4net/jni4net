using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public partial class Registry
    {
        public RegistryRecord GetRecord(JNIEnv env, IntPtr obj, Class iface)
        {
            lock (this)
            {
                RegistryRecord res;
                if (knownJVM.TryGetValue(iface, out res))
                {
                    return res;
                }
                Type clr = IsCLR(iface, obj, env);
                if (clr != null)
                {
                    return ResolveNew(clr);
                }
                return ResolveNew(iface);
            }
        }
        
        public RegistryRecord GetRecord(object obj)
        {
            Type iface = obj.GetType();
            lock (this)
            {
                RegistryRecord res;
                if (knownCLR.TryGetValue(iface, out res))
                {
                    return res;
                }
                Class jvm = IsJVM(obj);
                if (jvm!=null)
                {
                    return ResolveNew(jvm);
                }
                return ResolveNew(iface);
            }
        }

        public RegistryRecord GetCLRRecord(Type iface)
        {
            lock (this)
            {
                RegistryRecord res;
                if (knownCLR.TryGetValue(iface, out res))
                {
                    return res;
                }
                return ResolveNew(iface);
            }
        }

        public RegistryRecord GetJVMRecord(Class iface)
        {
            lock (this)
            {
                RegistryRecord res;
                if (knownJVM.TryGetValue(iface, out res))
                {
                    return res;
                }
                return ResolveNew(iface);
            }
        }

        private static Type IsCLR(Class iface, IntPtr obj, JNIEnv env)
        {
            if (IClrProxy_._class.isAssignableFrom(iface))
            {
                object real = __IClrProxy.GetObject(env, obj);
                return real.GetType();
            }
            return null;
        }

        private static Class IsJVM(object obj)
        {
            IJavaProxy proxy = obj as IJavaProxy;
            if (proxy!=null)
            {
                return proxy.GetClass();
            }
            return null;
        }
    }
}
