using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public static partial class Convertor
    {
        internal static MethodId boolValue;
        internal static MethodId byteValue;
        internal static MethodId charValue;
        internal static MethodId shortValue;
        internal static MethodId intValue;
        internal static MethodId longValue;
        internal static MethodId doubleValue;
        internal static MethodId floatValue;

        public static void InitProxy(JNIEnv env, IntPtr obj, object real)
        {
            int handle = IntHandle.Alloc(real);
            env.CallVoidMethod(obj, __IClrProxy._initProxy1, new Value { _int = handle });
        }
    }
}
