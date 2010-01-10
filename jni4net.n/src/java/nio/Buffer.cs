using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.nio
{
    public partial class Buffer
    {
        public void Limit(int par0)
        {
            JNIEnv @__env = Env;
            @__env.DeleteLocalRef(@__env.CallObjectMethodPtr(this, _limit1, Convertor.ParPrimC2J(par0)));
        }

        public void Position(int par0)
        {
            JNIEnv @__env = Env;
            @__env.DeleteLocalRef(@__env.CallObjectMethodPtr(this, _position3, Convertor.ParPrimC2J(par0)));
        }

    }
}
