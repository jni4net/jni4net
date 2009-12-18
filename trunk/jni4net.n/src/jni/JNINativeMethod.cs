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
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using java.lang;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Sequential, Size = 12), NativeCppClass]
    public struct JNINativeMethod
    {
        public static JNINativeMethod Create(MethodInfo methodInfo, string javaName, string javaSignature)
        {
            JNINativeMethod meth;
            meth.fnPtr = MethodWrapper.CreateMethodPtr(methodInfo);
            meth.name = Marshal.StringToHGlobalAnsi(javaName);
            meth.signature = Marshal.StringToHGlobalAnsi(javaSignature);
            return meth;
        }

        public static JNINativeMethod Create(Type type, string javaName, string clrName, string javaSignature)
        {
            MethodInfo methodInfo = type.GetMethod(clrName, BindingFlags.NonPublic | BindingFlags.Static);
            if (methodInfo == null)
            {
                throw new JNIException("Can'type find" + type.Name + "." + clrName);
            }
            return Create(methodInfo, javaName, javaSignature);
        }

        public static unsafe void Register(List<JNINativeMethod> registrations, Class jvmProxy, JNIEnv env)
        {
            JNINativeMethod[] methods = registrations.ToArray();
            fixed (JNINativeMethod* m = &(methods[0]))
            {
                JNIResult res = env.RegisterNatives(jvmProxy, m, methods.Length);
                if (res!=JNIResult.JNI_OK)
                {
                    throw new JNIException("Can't bind native methods to class " + jvmProxy +" is it in system classloader ?");
                }
            }
        }

        public IntPtr name; //char* 
        public IntPtr signature; //char* 
        public IntPtr fnPtr; //void* 
    }
}