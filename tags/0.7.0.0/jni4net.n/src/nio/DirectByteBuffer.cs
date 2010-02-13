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
using java.lang;
using java.nio;
using net.sf.jni4net.jni;
using Exception = java.lang.Exception;
using Object = java.lang.Object;

namespace net.sf.jni4net.nio
{
    public class DirectByteBuffer : ByteBuffer
    {
        private static Class dbClazz;
        private static MethodId ctor;
        private static bool initDone;
        private static void Init()
        {
            if (initDone)
            {
                return;
            }
            try
            {
                initDone = true;
                // sun JVM specific
                JNIEnv env = JNIEnv.ThreadEnv;
                dbClazz = env.FindClass("java/nio/DirectByteBuffer");
                ctor = env.GetMethodID(dbClazz, "<init>", "(IJLjava/lang/Runnable;)V");
            }
            catch (Exception)
            {
            }
        }

        private DirectBufferCleaner cleaner;

        /// <summary>
        ///   The buffer will be pinned and shared with java
        ///   user is responsible for thread synchronization.
        /// </summary>
        public DirectByteBuffer(byte[] sharedBuffer, int position, int len)
            : base(null)
        {
            Init();
            cleaner = new DirectBufferCleaner(sharedBuffer);
            JNIEnv env = JNIEnv.ThreadEnv;
            long offset = cleaner.Address.ToInt64() + position;
            ByteBuffer buffer;
            if (Bridge.Setup.BindNative && ctor!=null)
            {
                // sun JVM specific
                Object wrap = Bridge.WrapCLR(cleaner);
                buffer = (ByteBuffer)env.NewObject(dbClazz, ctor,
                                                    new Value { _int = len },
                                                    new Value { _long = offset },
                                                    new Value { _object = wrap.jvmHandle });
                ((IJvmProxy)wrap).JvmHandle.HoldThisHandle();
            }
            else
            {
                // TODO ?
                // the buffer could disapear when collected by CLR gc
                buffer = env.NewDirectByteBuffer(new IntPtr(cleaner.Address.ToInt64() + position), len);
            }

            buffer.order(ByteOrder.LITTLE_ENDIAN);
            ((IJvmProxy)this).Copy(env, buffer.jvmHandle);
        }

        /// <summary>
        ///   The buffer will be pinned and shared with java
        ///   user is responsible for thread synchronization.
        /// </summary>
        public DirectByteBuffer(byte[] sharedBuffer)
            : this(sharedBuffer, 0, sharedBuffer.Length)
        {
        }

        public byte[] GetSharedBuffer()
        {
            return cleaner.sharedBuffer;
        }
    }
}