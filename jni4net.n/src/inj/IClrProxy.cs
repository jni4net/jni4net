using net.sf.jni4net.jni;

namespace net.sf.jni4net.inj
{
    public partial interface IClrProxy : IJavaProxy
    {
        int getClrHandle();

        void initProxy(int par0);
    }
}
