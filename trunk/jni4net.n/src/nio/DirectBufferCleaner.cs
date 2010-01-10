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