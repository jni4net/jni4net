#region Copyright (c) 2001, 2010 Mathew A. Nelson and Robocode contributors

// Copyright (c) 2001, 2008 Mathew A. Nelson and Robocode contributors
// All rights reserved. This program and the accompanying materials
// are made available under the terms of the Common Public License v1.0
// which accompanies this distribution, and is available at
// http://robocode.sourceforge.net/license/cpl-v10.html

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
                ((IJvmProxy)wrap).HoldThisHandle();
            }
            else
            {
                // TODO ?
                // the buffer could disapear when collected by CLR gc
                buffer = env.NewDirectByteBuffer(new IntPtr(cleaner.Address.ToInt64() + position), len);
            }

            buffer.order(ByteOrder.LITTLE_ENDIAN);
            ((IJvmProxy)this).Copy(env, buffer);
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