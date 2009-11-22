using System;
using System.Collections;
using java.util;

namespace net.sf.jni4net.adaptors
{
    public partial class Adapt
    {
        public static Enumerator<T> Enumeration<T>(T closeable)
            where T : Enumeration
        {
            return new Enumerator<T>(closeable);
        }
    }

    public class Enumerator<T> : Adaptor<T>, IEnumerator, IEnumerable
        where T : Enumeration
    {
        public Enumerator(T enumeration)
            : base(enumeration)
        {
            current = null;
        }

        private object current;

        public bool MoveNext()
        {
            if (Real.hasMoreElements())
            {
                current = Real.nextElement();
                return true;
            }
            return false;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public object Current
        {
            get { return current; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
