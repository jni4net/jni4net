using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public partial class Registry
    {
        public static RegistryRecord GetRecord(JNIEnv env, IntPtr obj, Class iface)
        {
            lock (typeof(Registry))
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
        
        public static RegistryRecord GetRecord(object obj)
        {
            Type iface = obj.GetType();
            lock (typeof(Registry))
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

        public static RegistryRecord GetCLRRecord(Type iface)
        {
            lock (typeof(Registry))
            {
                RegistryRecord res;
                if (knownCLR.TryGetValue(iface, out res))
                {
                    return res;
                }
                return ResolveNew(iface);
            }
        }

        public static RegistryRecord GetJVMRecord(Class iface)
        {
            lock (typeof(Registry))
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
