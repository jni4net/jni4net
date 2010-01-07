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
using System.Diagnostics;
using System.Runtime.InteropServices;
using java.lang;
using java.nio;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.nio
{
    public class DirectByteBuffer : java.nio.ByteBuffer, IDisposable
    {
        private readonly byte[] sharedBuffer;
        private GCHandle pin;

        /// <summary>
        /// The buffer will be pinned and shared with java
        /// user is responsible for thread synchronization.
        /// </summary>
        /// <param name="sharedBuffer"></param>
        public DirectByteBuffer(byte[] sharedBuffer, int position, int len)
            : base(null)
        {
            this.sharedBuffer = sharedBuffer;
            pin = GCHandle.Alloc(sharedBuffer, GCHandleType.Pinned);
            JNIEnv env = JNIEnv.ThreadEnv;
            IntPtr ptr = pin.AddrOfPinnedObject();
            IntPtr offset = new IntPtr(ptr.ToInt64() + position);
            //var allocHGlobal = Marshal.AllocHGlobal(len);
            java.nio.ByteBuffer buffer = env.NewDirectByteBuffer(offset, len);
            buffer.order(ByteOrder.LITTLE_ENDIAN);
            ((IJvmProxy) this).Copy(env, buffer);
        }

        public DirectByteBuffer(byte[] sharedBuffer)
            : this(sharedBuffer, 0, sharedBuffer.Length)
        {
        }

        public byte[] GetSharedBuffer()
        {
            return sharedBuffer;
        }

        public void Dispose()
        {
            /*var dbbClazz = Class.forName("java.nio.Buffer");
            var addrField = dbbClazz.getDeclaredField("address");
            addrField.setAccessible(true);
            addrField.set(this, new Long(0));
            addrField.setAccessible(false);
            Console.WriteLine("reflection done");*/

            ((IJvmProxy)this).Dispose();
            if (pin.IsAllocated)
            {
                pin.Free();
            }
        }

        ~DirectByteBuffer()
        {
            Dispose();
        }
    }
}
