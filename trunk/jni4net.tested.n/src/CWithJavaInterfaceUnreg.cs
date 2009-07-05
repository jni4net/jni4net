using java.lang;

namespace net.sf.jni4net.tested
{
    public class CWithJavaInterfaceUnreg : Comparable, Runnable
    {
        public int Value { get; set; }

        public CWithJavaInterfaceUnreg(int value)
        {
            Value = value;
        }

        public int compareTo(Object objectPar0)
        {
            var other = Bridge.ToCLR<CWithJavaInterfaceUnreg>(objectPar0);
            if (other == null)
            {
                return -1;
            }
            return other.Value.CompareTo(Value);
        }

        public void run()
        {
            Value++;
        }
    }
}
