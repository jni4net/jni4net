using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net
{
    partial class Bridge
    {
        public static TRes UnrapCLR<TRes>(IJavaProxy obj)
        {
            return Convertor.OptiJP2C<TRes>(JNIEnv.ThreadEnv, obj.Native);
        }

        public static TRes WrapCLR<TRes>(object obj)
            where TRes : class, IJavaProxy
        {
            return Convertor.C2JObject(JNIEnv.ThreadEnv, obj) as TRes;
        }

        public static object WrapJVM(IJavaProxy obj)
        {
            IClrProxy clrProxy = obj as IClrProxy;
            if (clrProxy!=null)
            {
                return Convertor.OptiJP2C(JNIEnv.ThreadEnv, obj.Native);
            }
            return obj;
        }

        public static IJavaProxy UnwrapJVM(object obj)
        {
            return Convertor.C2JObject(JNIEnv.ThreadEnv, obj);
        }

    }
}
