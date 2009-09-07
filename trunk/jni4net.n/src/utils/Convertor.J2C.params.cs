using System;
using java.lang;
using net.sf.jni4net.jni;
using Boolean=java.lang.Boolean;
using Byte=java.lang.Byte;
using Double=java.lang.Double;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static IntPtr C2JString(JNIEnv env, string obj)
        {
            return env.NewStringPtr(obj);
        }
    }
}
