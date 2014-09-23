#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
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

        public static unsafe void Unregister(Class jvmProxy, JNIEnv env)
        {
            JNIResult res = env.UnregisterNatives(jvmProxy);
            if (res != JNIResult.JNI_OK)
            {
                throw new JNIException("Can't unbind native methods to class " + jvmProxy);
            }
        }

        public IntPtr name; //char* 
        public IntPtr signature; //char* 
        public IntPtr fnPtr; //void* 
    }
}