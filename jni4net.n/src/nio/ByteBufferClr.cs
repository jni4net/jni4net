#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Runtime.InteropServices;
using java.nio;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.nio
{
    public class ByteBufferClr : java.nio.ByteBuffer, IDisposable
    {
        private readonly byte[] sharedBuffer;
        private GCHandle pin;

        /// <summary>
        /// The buffer will be pinned and shared with java
        /// user is responsible for synchronization
        /// </summary>
        /// <param name="sharedBuffer"></param>
        public ByteBufferClr(byte[] sharedBuffer)
            : base(null)
        {
            this.sharedBuffer = sharedBuffer;
            pin = GCHandle.Alloc(sharedBuffer, GCHandleType.Pinned);
            JNIEnv env = JNIEnv.ThreadEnv;
            IntPtr ptr = pin.AddrOfPinnedObject();
            java.nio.ByteBuffer buffer = env.NewDirectByteBuffer(ptr, sharedBuffer.Length);
            buffer.order(ByteOrder.LITTLE_ENDIAN);
            ((IJvmProxy) this).Copy(env, buffer);
        }

        public byte[] GetSharedBuffer()
        {
            return sharedBuffer;
        }

        public void Dispose()
        {
            if (pin.IsAllocated)
            {
                pin.Free();
            }
            GC.SuppressFinalize(this);
        }

        ~ByteBufferClr()
        {
            Dispose();
        }
    }
}
