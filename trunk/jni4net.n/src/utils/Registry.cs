using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public partial class Registry
    {
        public RegistryRecord GetRecord(IntPtr obj, JNIEnv env)
        {
            Class iface = env.GetObjectClass(obj);
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

        private static Type IsCLR(Class iface, IntPtr obj, JNIEnv env)
        {
            //TODO return CLR instance
            if (IClrProxy_._class.isAssignableFrom(iface))
            {
                int handle = __IClrProxy.getClrHandle(env, obj);
                object o = IntHandle.ToObject(handle);
                return o.GetType();
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
