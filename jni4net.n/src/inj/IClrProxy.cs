using System;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.inj
{
    public partial interface IClrProxy : IJavaProxy
    {
        int getClrHandle();

        void initProxy(int par0);
    }

    partial class __IClrProxy
    {
        internal static int getClrHandle(JNIEnv env, IntPtr obj)
        {
            return env.CallIntMethod(obj, _getClrHandle0);
        }

        internal static IClrProxy CreateProxy(JNIEnv env, IntPtr obj, Class clazz)
        {
            IClrProxy proxy = new __IClrProxy(env);
            proxy.Init(env, obj, clazz);
            return proxy;
        }
    }
}