using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using java.lang;

namespace net.sf.jni4net.jni
{
    unsafe partial class JNIEnv
    {
        internal IntPtr NewIntArrayPtr(int len)
        {
            IntPtr res = newIntArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr GetObjectArrayElementPtr(IntPtr array, int index)
        {
            IntPtr res = getObjectArrayElement(native, array, index);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewStringPtr(string unicode)
        {
            IntPtr uni = Marshal.StringToHGlobalUni(unicode);
            IntPtr res = newString(native, uni, unicode.Length);
            ExceptionTest();
            Marshal.FreeHGlobal(uni);
            return res;
        }

        internal IntPtr GetStringChars(IntPtr str, byte* isCopy)
        {
            IntPtr res = getStringChars(native, str, isCopy);
            ExceptionTest();
            return res;
        }

        internal void ReleaseStringChars(IntPtr str, IntPtr chars)
        {
            releaseStringChars(native, str, chars);
            ExceptionTest();
        }

        internal IntPtr NewObjectArrayPtr(int len, IntPtr clazz, IJavaProxy init)
        {
            IntPtr res = newObjectArray(native, len, clazz, init == null ? IntPtr.Zero : init.Native);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewCharArrayPtr(int len)
        {
            IntPtr res = newCharArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewShortArrayPtr(int len)
        {
            IntPtr res = newShortArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewByteArrayPtr(int len)
        {
            IntPtr res = newByteArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewBooleanArrayPtr(int len)
        {
            IntPtr res = newBooleanArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewLongArrayPtr(int len)
        {
            IntPtr res = newLongArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewFloatArrayPtr(int len)
        {
            IntPtr res = newFloatArray(native, len);
            ExceptionTest();
            return res;
        }

        internal IntPtr NewDoubleArrayPtr(int len)
        {
            IntPtr res = newDoubleArray(native, len);
            ExceptionTest();
            return res;
        }

        public IntPtr CallObjectMethodPtr(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            IntPtr res = callObjectMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public IntPtr GetObjectFieldPtr(IJavaProxy obj, FieldId fieldID)
        {
            IntPtr res = getObjectField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public IntPtr GetStaticObjectFieldPtr(Class clazz, FieldId fieldID)
        {
            IntPtr res = getStaticObjectField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public IntPtr CallStaticObjectMethodPtr(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            IntPtr res = callStaticObjectMethod(native, clazz.native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

    }
}
