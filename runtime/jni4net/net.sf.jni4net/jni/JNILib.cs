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

namespace net.sf.jni4net.jni
{
    internal unsafe partial class JNILib
    {
        public JNILib(string jvmPath, bool forceLoad)
        {
            InitMethods(jvmPath, forceLoad);
        }

        public JNIResult CreateJavaVM(out IntPtr pjvm, out IntPtr penv, JVMInitArgs args)
        {
            return createJavaVM(out pjvm, out penv, &args);
        }

        public JNIResult GetCreatedJavaVMs(out IntPtr[] pjvm)
        {
            int s;
            var w = new IntPtr[100];
            JNIResult res;
            fixed (IntPtr* a=&(w[0]))
            {
                res = getCreatedJavaVMs(a, 100, out s);
            }
            
            if (res == JNIResult.JNI_OK && s>0)
            {
                pjvm = new IntPtr[1];
                pjvm[0] = w[0];
            }
            else
            {
                pjvm = new IntPtr[0];
            }
            return res;
        }

        public JNIResult GetDefaultJavaVMInitArgs(out JVMInitArgs args)
        {
            args=new JVMInitArgs
                {
                    version = JVMInitArgs.JNI_VERSION_1_4
                };
            fixed (JVMInitArgs* a = &args)
            {
                return getDefaultJavaVMInitArgs(a);
            }
        }
    }
}
