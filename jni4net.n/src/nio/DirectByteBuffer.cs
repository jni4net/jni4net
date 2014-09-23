#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using java.lang;
using java.nio;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using Exception = java.lang.Exception;
using Object = java.lang.Object;

namespace net.sf.jni4net.nio
{
    public class DirectByteBuffer : ByteBuffer
    {
        private static Class dbClazz;
        private static MethodId ctor;
        private static bool jdk6;
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

                // java 7 and above
                ctor = env.GetMethodIDNoThrow(dbClazz, "<init>", "(IJLjava/io/FileDescriptor;Ljava/lang/Runnable;)V");
                if (ctor == null)
                {
                    // java 6 and below
                    ctor = env.GetMethodIDNoThrow(dbClazz, "<init>", "(IJLjava/lang/Runnable;)V");
                    jdk6 = true;
                }
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
                if (jdk6)
                {
                    buffer = (ByteBuffer)env.NewObject(dbClazz, ctor,
                                                        new Value { _int = len },
                                                        new Value { _long = offset },
                                                        new Value { _object = wrap.jvmHandle });
                }
                else
                {
                    buffer = (ByteBuffer)env.NewObject(dbClazz, ctor,
                                                        new Value { _int = len },
                                                        new Value { _long = offset },
                                                        new Value { _object = JniHandle.Zero }, //FileDescriptor
                                                        new Value { _object = wrap.jvmHandle }
                                                        );
                }
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