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

// ReSharper disable EmptyGeneralCatchClause
using System;
using System.Runtime.ConstrainedExecution;
using System.Security;
using net.sf.jni4net.core;

namespace net.sf.jni4net.jni
{
    public unsafe partial class JVMInstance
    {
        [SuppressUnmanagedCodeSecurity]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        internal JNIResult AttachCurrentThreadAsDaemon(out JNIEnv penv)
        {
            IntPtr env;
            JNIResult result = attachCurrentThreadAsDaemon(pjvm, out env, null);
            if (result == JNIResult.JNI_OK)
            {
                penv = new JNIEnv(env);
                JNIEnv.threadJNIEnv = penv;
            }
            else
            {
                penv = null;
            }
            return result;
        }


        [SuppressUnmanagedCodeSecurity]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        internal JNIResult AttachCurrentThread(out JNIEnv penv)
        {
            IntPtr env;
            JNIResult result = attachCurrentThread(pjvm, out env, null);
            if (result == JNIResult.JNI_OK)
            {
                penv = new JNIEnv(env);
                JNIEnv.threadJNIEnv = penv;
            }
            else
            {
                penv = null;
            }
            return result;
        }


        [SuppressUnmanagedCodeSecurity]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public JNIResult DetachCurrentThread()
        {
            JNIResult result = detachCurrentThread(pjvm);
            JNIEnv.threadJNIEnv = null;
            if (result != JNIResult.JNI_OK)
            {
                Logger.LogError("Can't properly detach thread " + result, null);
            }
            return result;
        }

        [SuppressUnmanagedCodeSecurity]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public void DestroyJavaVM()
        {
            JNIResult result = destroyJavaVM(pjvm);
            if (result != JNIResult.JNI_OK)
            {
                throw J4NException.CantDestroyJvm(result);
            }
        }
    }
}
