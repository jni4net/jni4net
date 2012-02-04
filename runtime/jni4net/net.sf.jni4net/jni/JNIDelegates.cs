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
using System.Runtime.InteropServices;
using System.Security;

namespace net.sf.jni4net.jni
{

    [SuppressUnmanagedCodeSecurity]
    internal unsafe class LibDelegates
    {
        [SuppressUnmanagedCodeSecurity]
        public static class StdCall
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult CreateJavaVM(out IntPtr pvm, out IntPtr penv, JVMInitArgs* args);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult GetCreatedJavaVMs(out IntPtr pvm, int size, [Out] out int size2);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult GetDefaultJavaVMInitArgs(JVMInitArgs* args);
        }

        [SuppressUnmanagedCodeSecurity]
        public static class Cdecl
        {
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult CreateJavaVM(out IntPtr pvm, out IntPtr penv, JVMInitArgs* args);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult GetCreatedJavaVMs(IntPtr* pvm, int size, [Out] out int size2);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult GetDefaultJavaVMInitArgs(out JVMInitArgs args);
        }
    }

    [SuppressUnmanagedCodeSecurity]
    unsafe class JVMDelegates
    {
        [SuppressUnmanagedCodeSecurity]
        public static class StdCall
        {
            #region Nested type: AttachCurrentThread

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult AttachCurrentThread(
                IntPtr thiz, out IntPtr penv, JVMInitArgs* args);

            #endregion

            #region Nested type: AttachCurrentThreadAsDaemon

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult AttachCurrentThreadAsDaemon(
                IntPtr thiz, out IntPtr penv, JVMInitArgs* args);

            #endregion

            #region Nested type: DestroyJavaVM

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult DestroyJavaVM(IntPtr thiz);

            #endregion

            #region Nested type: DetachCurrentThread

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult DetachCurrentThread(IntPtr thiz);

            #endregion

            #region Nested type: GetEnv

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult GetEnv(IntPtr thiz, out IntPtr penv, int version);

            #endregion
             
        }

        [SuppressUnmanagedCodeSecurity]
        public static class Cdecl
        {
            #region Nested type: AttachCurrentThread

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult AttachCurrentThread(
                IntPtr thiz, out IntPtr penv, JVMInitArgs* args);

            #endregion

            #region Nested type: AttachCurrentThreadAsDaemon

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult AttachCurrentThreadAsDaemon(
                IntPtr thiz, out IntPtr penv, JVMInitArgs* args);

            #endregion

            #region Nested type: DestroyJavaVM

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult DestroyJavaVM(IntPtr thiz);

            #endregion

            #region Nested type: DetachCurrentThread

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult DetachCurrentThread(IntPtr thiz);

            #endregion

            #region Nested type: GetEnv

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JNIResult GetEnv(IntPtr thiz, out IntPtr penv, int version);

            #endregion

        }
    }

    [SuppressUnmanagedCodeSecurity]
    unsafe class JNIDelegates
    {
        [SuppressUnmanagedCodeSecurity]
        public static class StdCall
        {
            #region Nested type: AllocObject

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr AllocObject(IntPtr thiz, IntPtr clazz);

            #endregion

            #region Nested type: CallBooleanMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte CallBooleanMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallByteMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte CallByteMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallCharMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate ushort CallCharMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallDoubleMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate double CallDoubleMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallFloatMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate float CallFloatMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallIntMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int CallIntMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallLongMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate long CallLongMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualBooleanMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte CallNonvirtualBooleanMethod(
                IntPtr obj, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualByteMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte CallNonvirtualByteMethod(IntPtr thiz,
                                                            IntPtr obj, IntPtr clazz,
                                                            IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualCharMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate ushort CallNonvirtualCharMethod(IntPtr thiz,
                                                              IntPtr obj, IntPtr clazz,
                                                              IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualDoubleMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate double CallNonvirtualDoubleMethod(IntPtr thiz,
                                                                IntPtr obj, IntPtr clazz,
                                                                IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualFloatMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate float CallNonvirtualFloatMethod(IntPtr thiz,
                                                              IntPtr obj, IntPtr clazz,
                                                              IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualIntMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int CallNonvirtualIntMethod(IntPtr thiz,
                                                          IntPtr obj, IntPtr clazz,
                                                          IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualLongMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate long CallNonvirtualLongMethod(IntPtr thiz,
                                                            IntPtr obj, IntPtr clazz,
                                                            IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualObjectMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr CallNonvirtualObjectMethod(IntPtr thiz,
                                                                IntPtr obj, IntPtr clazz,
                                                                IntPtr methodID, params JNIValue[] args
                );

            #endregion

            #region Nested type: CallNonvirtualShortMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate short CallNonvirtualShortMethod(IntPtr thiz,
                                                              IntPtr obj, IntPtr clazz,
                                                              IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualVoidMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void CallNonvirtualVoidMethod(IntPtr thiz,
                                                            IntPtr obj, IntPtr clazz,
                                                            IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallObjectMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr CallObjectMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallShortMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate short CallShortMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticBooleanMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte CallStaticBooleanMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticByteMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte CallStaticByteMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticCharMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate ushort CallStaticCharMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticDoubleMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate double CallStaticDoubleMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticFloatMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate float CallStaticFloatMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticIntMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int CallStaticIntMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticLongMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate long CallStaticLongMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticObjectMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr CallStaticObjectMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticShortMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate short CallStaticShortMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticVoidMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult CallStaticVoidMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallVoidMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult CallVoidMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: DefineClass

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr DefineClass(IntPtr thiz,
                                                 IntPtr name /*const char* */, IntPtr loader,
                                                 IntPtr buf /*const byte **/, int len);

            #endregion

            #region Nested type: DeleteGlobalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void DeleteGlobalRef(IntPtr thiz, IntPtr gref);

            #endregion

            #region Nested type: DeleteLocalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void DeleteLocalRef(IntPtr thiz, IntPtr lref);

            #endregion

            #region Nested type: DeleteWeakGlobalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void DeleteWeakGlobalRef(IntPtr thiz, IntPtr wref);

            #endregion

            #region Nested type: EnsureLocalCapacity

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int EnsureLocalCapacity(IntPtr thiz, int capacity);

            #endregion

            #region Nested type: ExceptionCheck

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte ExceptionCheck(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionClear

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ExceptionClear(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionDescribe

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ExceptionDescribe(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionOccurred

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr ExceptionOccurred(IntPtr thiz);

            #endregion

            #region Nested type: FatalError

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void FatalError(IntPtr thiz, IntPtr msg);

            #endregion

            #region Nested type: FindClass

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr FindClass(IntPtr thiz, [MarshalAs(UnmanagedType.LPStr)] string name);

            #endregion

            #region Nested type: FromReflectedField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr FromReflectedField(IntPtr thiz, IntPtr field);

            #endregion

            #region Nested type: FromReflectedMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr FromReflectedMethod(IntPtr thiz, IntPtr method);

            #endregion

            #region Nested type: GetArrayLength

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int GetArrayLength(
                IntPtr thiz, IntPtr array);

            #endregion

            #region Nested type: GetBooleanArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte* GetBooleanArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetBooleanArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetBooleanArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, byte* buf);

            #endregion

            #region Nested type: GetBooleanField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte GetBooleanField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetByteArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte* GetByteArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetByteArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetByteArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, byte* buf);

            #endregion

            #region Nested type: GetByteField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte GetByteField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetCharArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate ushort* GetCharArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetCharArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetCharArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, char* buf);

            #endregion

            #region Nested type: GetCharField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate ushort GetCharField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetDirectBufferAddress

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetDirectBufferAddress(IntPtr thiz, IntPtr buf);

            #endregion

            #region Nested type: GetDirectBufferCapacity

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate long GetDirectBufferCapacity(IntPtr thiz, IntPtr buf);

            #endregion

            #region Nested type: GetDoubleArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate double* GetDoubleArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetDoubleArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetDoubleArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, double* buf
                /* double* */);

            #endregion

            #region Nested type: GetDoubleField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate double GetDoubleField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetFieldID

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetFieldID(
                IntPtr thiz, IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetFloatArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate float* GetFloatArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetFloatArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetFloatArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, float* buf);

            #endregion

            #region Nested type: GetFloatField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate float GetFloatField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetIntArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int* GetIntArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetIntArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetIntArrayRegion(IntPtr thiz, IntPtr array, int start, int len, int* buf);

            #endregion

            #region Nested type: GetIntField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int GetIntField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetJavaVM

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult GetJavaVM(IntPtr thiz, out IntPtr vm);

            #endregion

            #region Nested type: GetLongArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate long* GetLongArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetLongArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetLongArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, long* buf);

            #endregion

            #region Nested type: GetLongField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate long GetLongField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetMethodID

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetMethodID(
                IntPtr thiz, IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetObjectArrayElement

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetObjectArrayElement(
                IntPtr thiz, IntPtr array, int index);

            #endregion

            #region Nested type: GetObjectClass

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetObjectClass(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: GetObjectField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetObjectField(
                IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetPrimitiveArrayCritical

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void* GetPrimitiveArrayCritical(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetShortArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate short* GetShortArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetShortArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetShortArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, short* buf);

            #endregion

            #region Nested type: GetShortField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate short GetShortField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticBooleanField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte GetStaticBooleanField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticByteField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte GetStaticByteField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticCharField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate ushort GetStaticCharField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticDoubleField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate double GetStaticDoubleField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticFieldID

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetStaticFieldID(
                IntPtr thiz, IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetStaticFloatField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate float GetStaticFloatField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticIntField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int GetStaticIntField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticLongField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate long GetStaticLongField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticMethodID

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetStaticMethodID(
                IntPtr thiz, IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetStaticObjectField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetStaticObjectField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID
                );

            #endregion

            #region Nested type: GetStaticShortField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate short GetStaticShortField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStringChars

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetStringChars(IntPtr thiz, IntPtr str, byte* isCopy);

            #endregion

            #region Nested type: GetStringCritical

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetStringCritical(IntPtr thiz, IntPtr str, byte* isCopy);

            #endregion

            #region Nested type: GetStringLength

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int GetStringLength(IntPtr thiz, IntPtr str);

            #endregion

            #region Nested type: GetStringRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetStringRegion(IntPtr thiz, IntPtr str, int start, int len, char* buf);

            #endregion

            #region Nested type: GetStringUTFChars

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr GetStringUTFChars(IntPtr thiz, IntPtr str, byte* isCopy);

            #endregion

            #region Nested type: GetStringUTFLength

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int GetStringUTFLength(IntPtr thiz, IntPtr str);

            #endregion

            #region Nested type: GetStringUTFRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void GetStringUTFRegion(IntPtr thiz, IntPtr str, int start, int len, char* buf);

            #endregion

            #region Nested type: GetVersion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int GetVersion(IntPtr thiz);

            #endregion

            #region Nested type: IsSameObject

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate byte IsSameObject(
                IntPtr thiz, IntPtr o1, IntPtr o2);

            #endregion

            #region Nested type: MonitorEnter

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int MonitorEnter(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: MonitorExit

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int MonitorExit(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: NewBooleanArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewBooleanArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewByteArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewByteArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewCharArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewCharArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewDirectByteBuffer

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewDirectByteBuffer(IntPtr thiz, IntPtr address, long capacity);

            #endregion

            #region Nested type: NewDoubleArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewDoubleArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewFloatArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewFloatArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewGlobalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr NewGlobalRef(IntPtr thiz, IntPtr lobj);

            #endregion

            #region Nested type: NewIntArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewIntArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewLocalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewLocalRef(IntPtr thiz, IntPtr reference);

            #endregion

            #region Nested type: NewLongArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewLongArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewObject

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewObject(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: NewObjectArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewObjectArray(
                IntPtr thiz, int len, IntPtr clazz, IntPtr init);

            #endregion

            #region Nested type: NewShortArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewShortArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewString

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewString(IntPtr thiz, [MarshalAs(UnmanagedType.LPWStr)] string unicode, int len);

            #endregion

            #region Nested type: NewStringUTF

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewStringUTF(IntPtr thiz, [MarshalAs(UnmanagedType.LPStr)] string utf);

            #endregion

            #region Nested type: NewWeakGlobalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr NewWeakGlobalRef(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: PopLocalFrame

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr PopLocalFrame(IntPtr thiz, IntPtr result);

            #endregion

            #region Nested type: PushLocalFrame

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate int PushLocalFrame(IntPtr thiz, int capacity);

            #endregion

            #region Nested type: RegisterNatives

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult RegisterNatives(
                IntPtr thiz, IntPtr clazz, JNINativeMethod* methods, int nMethods);

            #endregion

            #region Nested type: UnregisterNatives

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult UnregisterNatives(IntPtr thiz, IntPtr clazz);

            #endregion

            #region Nested type: ReleaseBooleanArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseBooleanArrayElements(
                IntPtr thiz, IntPtr array, byte* elems, int mode);

            #endregion

            #region Nested type: ReleaseByteArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseByteArrayElements(IntPtr thiz, IntPtr array, byte* elems, int mode);

            #endregion

            #region Nested type: ReleaseCharArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseCharArrayElements(
                IntPtr thiz, IntPtr array, ushort* elems, int mode);

            #endregion

            #region Nested type: ReleaseDoubleArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseDoubleArrayElements(
                IntPtr thiz, IntPtr array, double* elems, int mode);

            #endregion

            #region Nested type: ReleaseFloatArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseFloatArrayElements(
                IntPtr thiz, IntPtr array, float* elems, int mode);

            #endregion

            #region Nested type: ReleaseIntArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseIntArrayElements(IntPtr thiz, IntPtr array, int* elems, int mode);

            #endregion

            #region Nested type: ReleaseLongArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseLongArrayElements(IntPtr thiz, IntPtr array, long* elems, int mode);

            #endregion

            #region Nested type: ReleasePrimitiveArrayCritical

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleasePrimitiveArrayCritical(
                IntPtr thiz, IntPtr array, void* carray, int mode);

            #endregion

            #region Nested type: ReleaseShortArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseShortArrayElements(
                IntPtr thiz, IntPtr array, short* elems, int mode);

            #endregion

            #region Nested type: ReleaseStringChars

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseStringChars(IntPtr thiz, IntPtr str, IntPtr chars);

            #endregion

            #region Nested type: ReleaseStringCritical

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseStringCritical(IntPtr thiz, IntPtr str, IntPtr cstring
                /*const char * */);

            #endregion

            #region Nested type: ReleaseStringUTFChars

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void ReleaseStringUTFChars(IntPtr thiz, IntPtr str, IntPtr chars
                /* const char* */);

            #endregion

            #region Nested type: SetBooleanArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetBooleanArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, byte* buf
                /*  const byte * */);

            #endregion

            #region Nested type: SetBooleanField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetBooleanField(
                IntPtr thiz, IntPtr obj, IntPtr fieldID, byte val);

            #endregion

            #region Nested type: SetByteArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetByteArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, byte* buf
                /* const byte * */);

            #endregion

            #region Nested type: SetByteField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetByteField(IntPtr thiz, IntPtr obj, IntPtr fieldID, byte val);

            #endregion

            #region Nested type: SetCharArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetCharArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, char* buf
                /* const ushort *  */);

            #endregion

            #region Nested type: SetCharField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetCharField(IntPtr thiz, IntPtr obj, IntPtr fieldID, ushort val
                );

            #endregion

            #region Nested type: SetDoubleArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetDoubleArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, double* buf
                /* const double * */);

            #endregion

            #region Nested type: SetDoubleField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetDoubleField(
                IntPtr thiz, IntPtr obj, IntPtr fieldID, double val);

            #endregion

            #region Nested type: SetFloatArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetFloatArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, float* buf
                /* const float *  */);

            #endregion

            #region Nested type: SetFloatField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetFloatField(IntPtr thiz, IntPtr obj, IntPtr fieldID, float val
                );

            #endregion

            #region Nested type: SetIntArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetIntArrayRegion(IntPtr thiz, IntPtr array, int start, int len, int* buf
                /* const int * */);

            #endregion

            #region Nested type: SetIntField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetIntField(IntPtr thiz, IntPtr obj, IntPtr fieldID, int val);

            #endregion

            #region Nested type: SetLongArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetLongArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, long* buf
                /*  const long * */);

            #endregion

            #region Nested type: SetLongField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetLongField(IntPtr thiz, IntPtr obj, IntPtr fieldID, long val);

            #endregion

            #region Nested type: SetObjectArrayElement

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetObjectArrayElement(
                IntPtr thiz, IntPtr array, int index, IntPtr val);

            #endregion

            #region Nested type: SetObjectField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetObjectField(
                IntPtr thiz, IntPtr obj, IntPtr fieldID, IntPtr val);

            #endregion

            #region Nested type: SetShortArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetShortArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, short* buf
                /* const short *  */);

            #endregion

            #region Nested type: SetShortField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetShortField(IntPtr thiz, IntPtr obj, IntPtr fieldID, short val
                );

            #endregion

            #region Nested type: SetStaticBooleanField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticBooleanField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, byte value);

            #endregion

            #region Nested type: SetStaticByteField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticByteField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, byte value);

            #endregion

            #region Nested type: SetStaticCharField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticCharField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, ushort value);

            #endregion

            #region Nested type: SetStaticDoubleField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticDoubleField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, double value);

            #endregion

            #region Nested type: SetStaticFloatField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticFloatField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, float value);

            #endregion

            #region Nested type: SetStaticIntField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticIntField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, int value);

            #endregion

            #region Nested type: SetStaticLongField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticLongField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, long value);

            #endregion

            #region Nested type: SetStaticObjectField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticObjectField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, IntPtr value);

            #endregion

            #region Nested type: SetStaticShortField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SetStaticShortField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, short value);

            #endregion

            #region Nested type: Throw

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult Throw(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: ThrowNew

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult ThrowNew(IntPtr thiz, IntPtr clazz, IntPtr msg);

            #endregion

            #region Nested type: ToReflectedField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr ToReflectedField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, byte isStatic);

            #endregion

            #region Nested type: ToReflectedMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate IntPtr ToReflectedMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, byte isStatic);

            #endregion

            #region Nested type: UnregisterJavaPtrs

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate JNIResult UnregisterJavaPtrs(IntPtr thiz, IntPtr clazz);

            #endregion
        }

        [SuppressUnmanagedCodeSecurity]
        public static class Cdecl
        {
            #region Nested type: AllocObject

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr AllocObject(IntPtr thiz, IntPtr clazz);

            #endregion

            #region Nested type: CallBooleanMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte CallBooleanMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallByteMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte CallByteMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallCharMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate ushort CallCharMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallDoubleMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate double CallDoubleMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallFloatMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate float CallFloatMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallIntMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int CallIntMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallLongMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate long CallLongMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualBooleanMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte CallNonvirtualBooleanMethod(
                IntPtr obj, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualByteMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte CallNonvirtualByteMethod(IntPtr thiz,
                                                            IntPtr obj, IntPtr clazz,
                                                            IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualCharMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate ushort CallNonvirtualCharMethod(IntPtr thiz,
                                                              IntPtr obj, IntPtr clazz,
                                                              IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualDoubleMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate double CallNonvirtualDoubleMethod(IntPtr thiz,
                                                                IntPtr obj, IntPtr clazz,
                                                                IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualFloatMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate float CallNonvirtualFloatMethod(IntPtr thiz,
                                                              IntPtr obj, IntPtr clazz,
                                                              IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualIntMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int CallNonvirtualIntMethod(IntPtr thiz,
                                                          IntPtr obj, IntPtr clazz,
                                                          IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualLongMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate long CallNonvirtualLongMethod(IntPtr thiz,
                                                            IntPtr obj, IntPtr clazz,
                                                            IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualObjectMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr CallNonvirtualObjectMethod(IntPtr thiz,
                                                                IntPtr obj, IntPtr clazz,
                                                                IntPtr methodID, params JNIValue[] args
                );

            #endregion

            #region Nested type: CallNonvirtualShortMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate short CallNonvirtualShortMethod(IntPtr thiz,
                                                              IntPtr obj, IntPtr clazz,
                                                              IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallNonvirtualVoidMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void CallNonvirtualVoidMethod(IntPtr thiz,
                                                            IntPtr obj, IntPtr clazz,
                                                            IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallObjectMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr CallObjectMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallShortMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate short CallShortMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticBooleanMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte CallStaticBooleanMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticByteMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte CallStaticByteMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticCharMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate ushort CallStaticCharMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticDoubleMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate double CallStaticDoubleMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticFloatMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate float CallStaticFloatMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticIntMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int CallStaticIntMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticLongMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate long CallStaticLongMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticObjectMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr CallStaticObjectMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticShortMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate short CallStaticShortMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: CallStaticVoidMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate JNIResult CallStaticVoidMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: CallVoidMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate JNIResult CallVoidMethod(
                IntPtr thiz, IntPtr obj, IntPtr methodIdJavaPtr, params JNIValue[] args);

            #endregion

            #region Nested type: DefineClass

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr DefineClass(IntPtr thiz,
                                                 IntPtr name /*const char* */, IntPtr loader,
                                                 IntPtr buf /*const byte **/, int len);

            #endregion

            #region Nested type: DeleteGlobalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void DeleteGlobalRef(IntPtr thiz, IntPtr gref);

            #endregion

            #region Nested type: DeleteLocalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void DeleteLocalRef(IntPtr thiz, IntPtr lref);

            #endregion

            #region Nested type: DeleteWeakGlobalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void DeleteWeakGlobalRef(IntPtr thiz, IntPtr wref);

            #endregion

            #region Nested type: EnsureLocalCapacity

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int EnsureLocalCapacity(IntPtr thiz, int capacity);

            #endregion

            #region Nested type: ExceptionCheck

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte ExceptionCheck(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionClear

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ExceptionClear(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionDescribe

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ExceptionDescribe(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionOccurred

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr ExceptionOccurred(IntPtr thiz);

            #endregion

            #region Nested type: FatalError

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void FatalError(IntPtr thiz, IntPtr msg);

            #endregion

            #region Nested type: FindClass

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr FindClass(IntPtr thiz, [MarshalAs(UnmanagedType.LPStr)] string name);

            #endregion

            #region Nested type: FromReflectedField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr FromReflectedField(IntPtr thiz, IntPtr field);

            #endregion

            #region Nested type: FromReflectedMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr FromReflectedMethod(IntPtr thiz, IntPtr method);

            #endregion

            #region Nested type: GetArrayLength

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int GetArrayLength(
                IntPtr thiz, IntPtr array);

            #endregion

            #region Nested type: GetBooleanArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte* GetBooleanArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetBooleanArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetBooleanArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, byte* buf);

            #endregion

            #region Nested type: GetBooleanField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte GetBooleanField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetByteArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte* GetByteArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetByteArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetByteArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, byte* buf);

            #endregion

            #region Nested type: GetByteField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte GetByteField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetCharArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate ushort* GetCharArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetCharArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetCharArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, char* buf);

            #endregion

            #region Nested type: GetCharField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate ushort GetCharField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetDirectBufferAddress

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetDirectBufferAddress(IntPtr thiz, IntPtr buf);

            #endregion

            #region Nested type: GetDirectBufferCapacity

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate long GetDirectBufferCapacity(IntPtr thiz, IntPtr buf);

            #endregion

            #region Nested type: GetDoubleArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate double* GetDoubleArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetDoubleArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetDoubleArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, double* buf
                /* double* */);

            #endregion

            #region Nested type: GetDoubleField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate double GetDoubleField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetFieldID

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetFieldID(
                IntPtr thiz, IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetFloatArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate float* GetFloatArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetFloatArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetFloatArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, float* buf);

            #endregion

            #region Nested type: GetFloatField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate float GetFloatField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetIntArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int* GetIntArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetIntArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetIntArrayRegion(IntPtr thiz, IntPtr array, int start, int len, int* buf);

            #endregion

            #region Nested type: GetIntField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int GetIntField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetJavaVM

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate JNIResult GetJavaVM(IntPtr thiz, out IntPtr vm);

            #endregion

            #region Nested type: GetLongArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate long* GetLongArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetLongArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetLongArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, long* buf);

            #endregion

            #region Nested type: GetLongField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate long GetLongField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetMethodID

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetMethodID(
                IntPtr thiz, IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetObjectArrayElement

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetObjectArrayElement(
                IntPtr thiz, IntPtr array, int index);

            #endregion

            #region Nested type: GetObjectClass

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetObjectClass(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: GetObjectField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetObjectField(
                IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetPrimitiveArrayCritical

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void* GetPrimitiveArrayCritical(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetShortArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate short* GetShortArrayElements(IntPtr thiz, IntPtr array, byte* isCopy);

            #endregion

            #region Nested type: GetShortArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetShortArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, short* buf);

            #endregion

            #region Nested type: GetShortField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate short GetShortField(IntPtr thiz, IntPtr obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticBooleanField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte GetStaticBooleanField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticByteField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte GetStaticByteField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticCharField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate ushort GetStaticCharField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticDoubleField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate double GetStaticDoubleField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticFieldID

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetStaticFieldID(
                IntPtr thiz, IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetStaticFloatField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate float GetStaticFloatField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticIntField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int GetStaticIntField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticLongField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate long GetStaticLongField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticMethodID

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetStaticMethodID(
                IntPtr thiz, IntPtr clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetStaticObjectField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetStaticObjectField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID
                );

            #endregion

            #region Nested type: GetStaticShortField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate short GetStaticShortField(IntPtr thiz, IntPtr clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStringChars

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetStringChars(IntPtr thiz, IntPtr str, byte* isCopy);

            #endregion

            #region Nested type: GetStringCritical

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetStringCritical(IntPtr thiz, IntPtr str, byte* isCopy);

            #endregion

            #region Nested type: GetStringLength

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int GetStringLength(IntPtr thiz, IntPtr str);

            #endregion

            #region Nested type: GetStringRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetStringRegion(IntPtr thiz, IntPtr str, int start, int len, char* buf);

            #endregion

            #region Nested type: GetStringUTFChars

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr GetStringUTFChars(IntPtr thiz, IntPtr str, byte* isCopy);

            #endregion

            #region Nested type: GetStringUTFLength

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int GetStringUTFLength(IntPtr thiz, IntPtr str);

            #endregion

            #region Nested type: GetStringUTFRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void GetStringUTFRegion(IntPtr thiz, IntPtr str, int start, int len, char* buf);

            #endregion

            #region Nested type: GetVersion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int GetVersion(IntPtr thiz);

            #endregion

            #region Nested type: IsSameObject

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate byte IsSameObject(
                IntPtr thiz, IntPtr o1, IntPtr o2);

            #endregion

            #region Nested type: MonitorEnter

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int MonitorEnter(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: MonitorExit

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int MonitorExit(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: NewBooleanArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewBooleanArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewByteArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewByteArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewCharArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewCharArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewDirectByteBuffer

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewDirectByteBuffer(IntPtr thiz, IntPtr address, long capacity);

            #endregion

            #region Nested type: NewDoubleArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewDoubleArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewFloatArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewFloatArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewGlobalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr NewGlobalRef(IntPtr thiz, IntPtr lobj);

            #endregion

            #region Nested type: NewIntArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewIntArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewLocalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewLocalRef(IntPtr thiz, IntPtr reference);

            #endregion

            #region Nested type: NewLongArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewLongArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewObject

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewObject(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, params JNIValue[] args);

            #endregion

            #region Nested type: NewObjectArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewObjectArray(
                IntPtr thiz, int len, IntPtr clazz, IntPtr init);

            #endregion

            #region Nested type: NewShortArray

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewShortArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewString

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewString(IntPtr thiz, [MarshalAs(UnmanagedType.LPWStr)] string unicode, int len);

            #endregion

            #region Nested type: NewStringUTF

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewStringUTF(IntPtr thiz, [MarshalAs(UnmanagedType.LPStr)] string utf);

            #endregion

            #region Nested type: NewWeakGlobalRef

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr NewWeakGlobalRef(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: PopLocalFrame

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr PopLocalFrame(IntPtr thiz, IntPtr result);

            #endregion

            #region Nested type: PushLocalFrame

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int PushLocalFrame(IntPtr thiz, int capacity);

            #endregion

            #region Nested type: RegisterNatives

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate JNIResult RegisterNatives(
                IntPtr thiz, IntPtr clazz, JNINativeMethod* methods, int nMethods);

            #endregion

            #region Nested type: UnregisterNatives

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate JNIResult UnregisterNatives(IntPtr thiz, IntPtr clazz);

            #endregion

            #region Nested type: ReleaseBooleanArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseBooleanArrayElements(
                IntPtr thiz, IntPtr array, byte* elems, int mode);

            #endregion

            #region Nested type: ReleaseByteArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseByteArrayElements(IntPtr thiz, IntPtr array, byte* elems, int mode);

            #endregion

            #region Nested type: ReleaseCharArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseCharArrayElements(
                IntPtr thiz, IntPtr array, ushort* elems, int mode);

            #endregion

            #region Nested type: ReleaseDoubleArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseDoubleArrayElements(
                IntPtr thiz, IntPtr array, double* elems, int mode);

            #endregion

            #region Nested type: ReleaseFloatArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseFloatArrayElements(
                IntPtr thiz, IntPtr array, float* elems, int mode);

            #endregion

            #region Nested type: ReleaseIntArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseIntArrayElements(IntPtr thiz, IntPtr array, int* elems, int mode);

            #endregion

            #region Nested type: ReleaseLongArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseLongArrayElements(IntPtr thiz, IntPtr array, long* elems, int mode);

            #endregion

            #region Nested type: ReleasePrimitiveArrayCritical

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleasePrimitiveArrayCritical(
                IntPtr thiz, IntPtr array, void* carray, int mode);

            #endregion

            #region Nested type: ReleaseShortArrayElements

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseShortArrayElements(
                IntPtr thiz, IntPtr array, short* elems, int mode);

            #endregion

            #region Nested type: ReleaseStringChars

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseStringChars(IntPtr thiz, IntPtr str, IntPtr chars);

            #endregion

            #region Nested type: ReleaseStringCritical

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseStringCritical(IntPtr thiz, IntPtr str, IntPtr cstring
                /*const char * */);

            #endregion

            #region Nested type: ReleaseStringUTFChars

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void ReleaseStringUTFChars(IntPtr thiz, IntPtr str, IntPtr chars
                /* const char* */);

            #endregion

            #region Nested type: SetBooleanArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetBooleanArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, byte* buf
                /*  const byte * */);

            #endregion

            #region Nested type: SetBooleanField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetBooleanField(
                IntPtr thiz, IntPtr obj, IntPtr fieldID, byte val);

            #endregion

            #region Nested type: SetByteArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetByteArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, byte* buf
                /* const byte * */);

            #endregion

            #region Nested type: SetByteField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetByteField(IntPtr thiz, IntPtr obj, IntPtr fieldID, byte val);

            #endregion

            #region Nested type: SetCharArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetCharArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, char* buf
                /* const ushort *  */);

            #endregion

            #region Nested type: SetCharField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetCharField(IntPtr thiz, IntPtr obj, IntPtr fieldID, ushort val
                );

            #endregion

            #region Nested type: SetDoubleArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetDoubleArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, double* buf
                /* const double * */);

            #endregion

            #region Nested type: SetDoubleField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetDoubleField(
                IntPtr thiz, IntPtr obj, IntPtr fieldID, double val);

            #endregion

            #region Nested type: SetFloatArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetFloatArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, float* buf
                /* const float *  */);

            #endregion

            #region Nested type: SetFloatField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetFloatField(IntPtr thiz, IntPtr obj, IntPtr fieldID, float val
                );

            #endregion

            #region Nested type: SetIntArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetIntArrayRegion(IntPtr thiz, IntPtr array, int start, int len, int* buf
                /* const int * */);

            #endregion

            #region Nested type: SetIntField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetIntField(IntPtr thiz, IntPtr obj, IntPtr fieldID, int val);

            #endregion

            #region Nested type: SetLongArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetLongArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, long* buf
                /*  const long * */);

            #endregion

            #region Nested type: SetLongField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetLongField(IntPtr thiz, IntPtr obj, IntPtr fieldID, long val);

            #endregion

            #region Nested type: SetObjectArrayElement

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetObjectArrayElement(
                IntPtr thiz, IntPtr array, int index, IntPtr val);

            #endregion

            #region Nested type: SetObjectField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetObjectField(
                IntPtr thiz, IntPtr obj, IntPtr fieldID, IntPtr val);

            #endregion

            #region Nested type: SetShortArrayRegion

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetShortArrayRegion(
                IntPtr thiz, IntPtr array, int start, int len, short* buf
                /* const short *  */);

            #endregion

            #region Nested type: SetShortField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetShortField(IntPtr thiz, IntPtr obj, IntPtr fieldID, short val
                );

            #endregion

            #region Nested type: SetStaticBooleanField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticBooleanField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, byte value);

            #endregion

            #region Nested type: SetStaticByteField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticByteField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, byte value);

            #endregion

            #region Nested type: SetStaticCharField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticCharField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, ushort value);

            #endregion

            #region Nested type: SetStaticDoubleField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticDoubleField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, double value);

            #endregion

            #region Nested type: SetStaticFloatField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticFloatField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, float value);

            #endregion

            #region Nested type: SetStaticIntField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticIntField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, int value);

            #endregion

            #region Nested type: SetStaticLongField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticLongField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, long value);

            #endregion

            #region Nested type: SetStaticObjectField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticObjectField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, IntPtr value);

            #endregion

            #region Nested type: SetStaticShortField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SetStaticShortField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, short value);

            #endregion

            #region Nested type: Throw

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate JNIResult Throw(IntPtr thiz, IntPtr obj);

            #endregion

            #region Nested type: ThrowNew

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate JNIResult ThrowNew(IntPtr thiz, IntPtr clazz, IntPtr msg);

            #endregion

            #region Nested type: ToReflectedField

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr ToReflectedField(
                IntPtr thiz, IntPtr clazz, IntPtr fieldID, byte isStatic);

            #endregion

            #region Nested type: ToReflectedMethod

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate IntPtr ToReflectedMethod(
                IntPtr thiz, IntPtr clazz, IntPtr methodID, byte isStatic);

            #endregion

            #region Nested type: UnregisterJavaPtrs

            [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate JNIResult UnregisterJavaPtrs(IntPtr thiz, IntPtr clazz);

            #endregion
        }
    }
}
