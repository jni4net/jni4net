using System;
using System.Threading;

namespace net.sf.jni4net.utils
{
    internal class MutexLocker : IDisposable
    {
        private Mutex mutex;

        public MutexLocker(Mutex mutex)
        {
            this.mutex = mutex;
            mutex.WaitOne();
        }

        public void Dispose()
        {
            mutex.ReleaseMutex();
            GC.SuppressFinalize(this);
        }
    }
}
