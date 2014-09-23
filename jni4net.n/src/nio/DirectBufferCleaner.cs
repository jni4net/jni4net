#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Runtime.InteropServices;

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