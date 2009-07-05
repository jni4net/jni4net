using java.lang;

namespace net.sf.jni4net.tested
{
    public class CWithJavaInterface : Comparable, Runnable
    {
        public int Value { get; set; }

        public CWithJavaInterface(int value)
        {
            Value = value;
        }

        public int compareTo(Object objectPar0)
        {
            var other = Bridge.ToCLR<CWithJavaInterface>(objectPar0);
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
