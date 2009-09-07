using System;
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
    }
}