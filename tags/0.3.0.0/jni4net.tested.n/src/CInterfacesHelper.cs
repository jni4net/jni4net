namespace net.sf.jni4net.tested
{
    public class CInterfacesHelper
    {
        public CWithJavaInterface createCWithJavaInterface(int i)
        {
            return new CWithJavaInterface(i);
        }

        public CWithJavaInterfaceUnreg CWithJavaInterfaceUnreg(int i)
        {
            return new CWithJavaInterfaceUnreg(i);
        }
    }
}
