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