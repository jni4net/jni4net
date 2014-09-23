#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Runtime.InteropServices;
using java.lang;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.jni
{
    unsafe partial class JNIEnv
    {
        internal JniLocalHandle NewIntArrayPtr(int len)
        {
            JniLocalHandle res = newIntArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle GetObjectArrayElementPtr(JniHandle array, int index)
        {
            JniLocalHandle res = getObjectArrayElement(envPtr, array, index);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewStringPtr(string unicode)
        {
            IntPtr uni = Marshal.StringToHGlobalUni(unicode);
            JniLocalHandle res = newString(envPtr, uni, unicode.Length);
            ExceptionTest();
            Marshal.FreeHGlobal(uni);
            return res;
        }

        internal IntPtr GetStringChars(JniHandle str, byte* isCopy)
        {
            IntPtr res = getStringChars(envPtr, str, isCopy);
            ExceptionTest();
            return res;
        }

        internal void ReleaseStringChars(JniHandle str, IntPtr chars)
        {
            releaseStringChars(envPtr, str, chars);
            ExceptionTest();
        }

        internal JniLocalHandle NewObjectArrayPtr(int len, JniGlobalHandle clazz, IJvmProxy init)
        {
            JniLocalHandle res = newObjectArray(envPtr, len, clazz, init == null ? JniGlobalHandle.Zero : init.JvmHandle);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewCharArrayPtr(int len)
        {
            JniLocalHandle res = newCharArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewShortArrayPtr(int len)
        {
            JniLocalHandle res = newShortArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewByteArrayPtr(int len)
        {
            JniLocalHandle res = newByteArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewBooleanArrayPtr(int len)
        {
            JniLocalHandle res = newBooleanArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewLongArrayPtr(int len)
        {
            JniLocalHandle res = newLongArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewFloatArrayPtr(int len)
        {
            JniLocalHandle res = newFloatArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewDoubleArrayPtr(int len)
        {
            JniLocalHandle res = newDoubleArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle CallObjectMethodPtr(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
#if DEBUG
            if (Bridge.Setup.VeryVerbose)
            {
                Console.WriteLine("CallObjectMethodPtr : " + obj.GetType().FullName);
            }
#endif
            JniLocalHandle res = callObjectMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle GetObjectFieldPtr(IJvmProxy obj, FieldId fieldID)
        {
            JniLocalHandle res = getObjectField(envPtr, obj.JvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle GetObjectFieldPtr(JniHandle obj, FieldId fieldID)
        {
            JniLocalHandle res = getObjectField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle GetStaticObjectFieldPtr(Class clazz, FieldId fieldID)
        {
            JniLocalHandle res = getStaticObjectField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle CallStaticObjectMethodPtr(Class clazz, MethodId methodIdNative, params Value[] args)
        {
#if DEBUG
            if (Bridge.Setup.VeryVerbose)
            {
                Console.WriteLine("CallStaticObjectMethodPtr : " + clazz.FullName);
            }
#endif
            JniLocalHandle res = callStaticObjectMethod(envPtr, clazz.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
    }
}