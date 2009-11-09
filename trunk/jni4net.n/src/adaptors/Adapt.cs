using System;
using java.io;

namespace net.sf.jni4net.adaptors
{
    public class Adapt
    {
        public static CloseableToIDisposable<TReal> Disposable<TReal>(TReal closeable)
            where TReal : Closeable
        {
            return new CloseableToIDisposable<TReal>(closeable);
        }
    }

    public class CloseableToIDisposable<TReal> : IDisposable
        where TReal : Closeable
    {
        private TReal closeable;

        public TReal Real
        {
            get { return closeable; }
        }

        public CloseableToIDisposable(TReal closeable)
        {
            this.closeable = closeable;
        }

        public void Dispose()
        {
            closeable.close();
        }
    }
}
