#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace net.sf.jni4net.jni
{
    unsafe partial class JavaVM
    {
        #region Nested type: Delegates

        public struct Delegates
        {
            #region Nested type: AttachCurrentThread

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult AttachCurrentThread(
                IntPtr thiz, out IntPtr penv, JavaVMInitArgs* args);

            #endregion

            #region Nested type: AttachCurrentThreadAsDaemon

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult AttachCurrentThreadAsDaemon(
                IntPtr thiz, out IntPtr penv, JavaVMInitArgs* args);

            #endregion

            #region Nested type: DestroyJavaVM

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult DestroyJavaVM(IntPtr thiz);

            #endregion

            #region Nested type: DetachCurrentThread

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult DetachCurrentThread(IntPtr thiz);

            #endregion

            #region Nested type: GetEnv

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult GetEnv(IntPtr thiz, out IntPtr penv, int version);

            #endregion
        }

        #endregion

        #region Nested type: JavaPtr

        [StructLayout(LayoutKind.Sequential, Size = 4), NativeCppClass]
        private struct JavaPtr
        {
            public JNIInvokeInterface* functions;
        }

        #endregion

        #region function pointers

        private Delegates.AttachCurrentThread attachCurrentThread;
        private Delegates.AttachCurrentThreadAsDaemon attachCurrentThreadAsDaemon;
        private Delegates.DestroyJavaVM destroyJavaVM;
        private Delegates.DetachCurrentThread detachCurrentThread;
        private Delegates.GetEnv getEnv;

        #endregion
    }
}