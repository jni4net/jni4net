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
using net.sf.jni4net.utils;
using Object=java.lang.Object;

namespace net.sf.jni4net.jni
{
    unsafe partial class JNIEnv
    {
        private static JavaVM defaultVM;
        [ThreadStatic] private static JNIEnv threadJNIEnv;

        private readonly IntPtr native;
        private JNINativeInterface functions;
        private JavaVM javaVM;

        internal JNIEnv(IntPtr native)
        {
            this.native = native;
            functions = *(*(JavaPtr*)native.ToPointer()).functions;
            InitMethods();
            if (defaultVM == null)
            {
                defaultVM = GetJavaVM();
            }
        }

        public static JNIEnv ThreadEnv
        {
            get
            {
                if (threadJNIEnv == null)
                {
                    if (defaultVM == null)
                    {
                        throw new JNIException(
                            "AttachCurrentThreadAsDaemon failed: Java VM is not attached, call JNI.CreateJavaVM() first");
                    }
                    JNIResult result = defaultVM.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                    if (result != JNIResult.JNI_OK)
                    {
                        throw new JNIException("AttachCurrentThreadAsDaemon failed: " + result);
                    }
                }
                return threadJNIEnv;
            }
        }

        public static JNIEnv GetEnvForVm(JavaVM vm)
        {
            if (threadJNIEnv == null)
            {
                JNIResult result = vm.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                if (result != JNIResult.JNI_OK)
                {
                    throw new JNIException("AttachCurrentThreadAsDaemon failed: " + result);
                }
            }
            return threadJNIEnv;
        }

        public static JNIEnv GetEnvNoThrow(JavaVM vm)
        {
            if (threadJNIEnv == null)
            {
                JNIResult result = vm.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                if (result != JNIResult.JNI_OK)
                {
                    return null;
                }
            }
            return threadJNIEnv;
        }

        public T Wrap<T>(Object.JavaPtr* obj) where T : IJavaProxy
        {
            return JavaProxiesMap.Wrap<T>(this, obj);
        }

        public static JNIEnv Wrap(IntPtr envi)
        {
            if (envi == IntPtr.Zero)
            {
                return null;
            }
            if (threadJNIEnv != null && envi == threadJNIEnv.native)
            {
                return threadJNIEnv;
            }
            return new JNIEnv(envi);
        }

        #region Nested type: JavaPtr

        [StructLayout(LayoutKind.Sequential, Size = 4), NativeCppClass]
        private struct JavaPtr
        {
            public JNINativeInterface* functions;
        }

        #endregion
    }
}