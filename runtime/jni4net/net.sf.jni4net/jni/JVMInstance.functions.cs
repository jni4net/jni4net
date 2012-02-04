#region Copyright (C) 2012 by Pavel Savara

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
using net.sf.jni4net.core;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.jni
{
    unsafe partial class JVMInstance
    {
        internal JVMInstance(IntPtr pjvm)
        {
            this.pjvm = pjvm;
            functions = *(*(JVMNativeInterfacePtr*) pjvm.ToPointer()).functions;
            InitMethods();
        }

        private IntPtr pjvm;
        private JVMNativeInterface functions;

        private JVMDelegates.Cdecl.AttachCurrentThread attachCurrentThread;
        private JVMDelegates.Cdecl.AttachCurrentThreadAsDaemon attachCurrentThreadAsDaemon;
        private JVMDelegates.Cdecl.DestroyJavaVM destroyJavaVM;
        private JVMDelegates.Cdecl.DetachCurrentThread detachCurrentThread;
        private JVMDelegates.Cdecl.GetEnv getEnv;

        private void InitMethods()
        {
            bool IsStdCall = OsUtils.IsRunningWindows;
            Delegates.GetDelegateForFunctionPointer<JVMDelegates.Cdecl.AttachCurrentThread, JVMDelegates.StdCall.AttachCurrentThread>(functions.AttachCurrentThread, ref attachCurrentThread, IsStdCall);
            Delegates.GetDelegateForFunctionPointer<JVMDelegates.Cdecl.AttachCurrentThreadAsDaemon, JVMDelegates.StdCall.AttachCurrentThreadAsDaemon>(functions.AttachCurrentThreadAsDaemon, ref attachCurrentThreadAsDaemon, IsStdCall);
            Delegates.GetDelegateForFunctionPointer<JVMDelegates.Cdecl.DestroyJavaVM, JVMDelegates.StdCall.DestroyJavaVM>(functions.DestroyJavaVM, ref destroyJavaVM, IsStdCall);
            Delegates.GetDelegateForFunctionPointer<JVMDelegates.Cdecl.DetachCurrentThread, JVMDelegates.StdCall.DetachCurrentThread>(functions.DetachCurrentThread, ref detachCurrentThread, IsStdCall);
            Delegates.GetDelegateForFunctionPointer<JVMDelegates.Cdecl.GetEnv, JVMDelegates.StdCall.GetEnv>(functions.GetEnv, ref getEnv, IsStdCall);
        }
    }
}
