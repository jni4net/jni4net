using System;
using System.Runtime.InteropServices;
using java.lang;

namespace net.sf.jni4net.nio
{
    public class DirectBufferCleaner : IDisposable
    {
        public DirectBufferCleaner(byte[] sharedBuffer)
        {
            this.sharedBuffer = sharedBuffer;
            pin = GCHandle.Alloc(sharedBuffer, GCHandleType.Pinned);
        }

        internal readonly byte[] sharedBuffer;
        internal GCHandle pin;

        public IntPtr Address
        {
            get { return pin.AddrOfPinnedObject(); }
        }

        ~DirectBufferCleaner()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (pin.IsAllocated)
            {
                pin.Free();
            }
        }
    }
}