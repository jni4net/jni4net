using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net
{
    partial class Bridge
    {
        public static TRes UnwrapCLR<TRes>(IJavaProxy obj)
        {
            return Convertor.J2C<TRes>(JNIEnv.ThreadEnv, obj.Native);
        }

        public static TRes WrapCLR<TRes>(object obj)
            where TRes : class, IJavaProxy
        {
            return (TRes)Convertor.C2JWrapper(JNIEnv.ThreadEnv, obj);
        }

        public static object WrapJVM(IJavaProxy obj, Class interfaceClass)
        {
            IClrProxy clrProxy = obj as IClrProxy;
            if (clrProxy!=null)
            {
                return Convertor.J2C<object>(JNIEnv.ThreadEnv, obj.Native);
            }
            return obj;
        }

        public static IJavaProxy UnwrapJVM(object obj, Class interfaceClass)
        {
            return Convertor.C2JWrapper(JNIEnv.ThreadEnv, obj);
        }

        public static IJavaProxy UnwrapJVM(System.Exception obj, Class interfaceClass)
        {
            return Convertor.C2JWrapper(JNIEnv.ThreadEnv, obj);
        }
    }
}
