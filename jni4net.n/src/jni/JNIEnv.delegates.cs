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
using System.Runtime.InteropServices;
using java.lang;
using Object=java.lang.Object;

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        #region Nested type: Delegates

        internal unsafe struct Delegates
        {
            #region Nested type: AllocObject

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* AllocObject(IntPtr thiz, Class.JavaPtr* clazz);

            #endregion

            #region Nested type: CallBooleanMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallBooleanMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallByteMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallByteMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallCharMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort CallCharMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallDoubleMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double CallDoubleMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallFloatMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float CallFloatMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallIntMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int CallIntMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallLongMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long CallLongMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualBooleanMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallNonvirtualBooleanMethod(
                Object.JavaPtr* obj, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualByteMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallNonvirtualByteMethod(IntPtr thiz,
                                                            Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                            IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualCharMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort CallNonvirtualCharMethod(IntPtr thiz,
                                                              Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                              IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualDoubleMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double CallNonvirtualDoubleMethod(IntPtr thiz,
                                                                Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                                IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualFloatMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float CallNonvirtualFloatMethod(IntPtr thiz,
                                                              Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                              IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualIntMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int CallNonvirtualIntMethod(IntPtr thiz,
                                                          Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                          IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualLongMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long CallNonvirtualLongMethod(IntPtr thiz,
                                                            Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                            IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualObjectMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* CallNonvirtualObjectMethod(IntPtr thiz,
                                                                         Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                                         IntPtr methodID, params Value[] args
                );

            #endregion

            #region Nested type: CallNonvirtualShortMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short CallNonvirtualShortMethod(IntPtr thiz,
                                                              Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                              IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualVoidMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void CallNonvirtualVoidMethod(IntPtr thiz,
                                                            Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                            IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallObjectMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* CallObjectMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallShortMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short CallShortMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticBooleanMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallStaticBooleanMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticByteMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallStaticByteMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticCharMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort CallStaticCharMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticDoubleMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double CallStaticDoubleMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticFloatMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float CallStaticFloatMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticIntMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int CallStaticIntMethod(
                IntPtr thiz, Class.JavaPtr* obj, IntPtr methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallStaticLongMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long CallStaticLongMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticObjectMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* CallStaticObjectMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticShortMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short CallStaticShortMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticVoidMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult CallStaticVoidMethod(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallVoidMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult CallVoidMethod(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: DefineClass

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Class.JavaPtr* DefineClass(IntPtr thiz,
                                                         IntPtr name /*const char* */, Object.JavaPtr* loader,
                                                         IntPtr buf /*const byte **/, int len);

            #endregion

            #region Nested type: DeleteGlobalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void DeleteGlobalRef(IntPtr thiz, Object.JavaPtr* gref);

            #endregion

            #region Nested type: DeleteLocalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void DeleteLocalRef(IntPtr thiz, Object.JavaPtr* lref);

            #endregion

            #region Nested type: DeleteWeakGlobalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void DeleteWeakGlobalRef(IntPtr thiz, IntPtr wref);

            #endregion

            #region Nested type: EnsureLocalCapacity

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int EnsureLocalCapacity(IntPtr thiz, int capacity);

            #endregion

            #region Nested type: ExceptionCheck

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte ExceptionCheck(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionClear

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ExceptionClear(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionDescribe

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ExceptionDescribe(IntPtr thiz);

            #endregion

            #region Nested type: ExceptionOccurred

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* ExceptionOccurred(IntPtr thiz);

            #endregion

            #region Nested type: FatalError

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void FatalError(IntPtr thiz, IntPtr msg);

            #endregion

            #region Nested type: FindClass

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Class.JavaPtr* FindClass(IntPtr thiz, [MarshalAs(UnmanagedType.LPStr)] string name);

            #endregion

            #region Nested type: FromReflectedField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr FromReflectedField(IntPtr thiz, Object.JavaPtr* field);

            #endregion

            #region Nested type: FromReflectedMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr FromReflectedMethod(IntPtr thiz, Object.JavaPtr* method);

            #endregion

            #region Nested type: GetArrayLength

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetArrayLength(
                IntPtr thiz, Object.JavaPtr* array);

            #endregion

            #region Nested type: GetBooleanArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte* GetBooleanArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetBooleanArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetBooleanArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, byte* buf);

            #endregion

            #region Nested type: GetBooleanField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte GetBooleanField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetByteArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte* GetByteArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetByteArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetByteArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, byte* buf);

            #endregion

            #region Nested type: GetByteField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte GetByteField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetCharArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort* GetCharArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetCharArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetCharArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, char* buf);

            #endregion

            #region Nested type: GetCharField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort GetCharField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetDirectBufferAddress

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void* GetDirectBufferAddress(IntPtr thiz, Object.JavaPtr* buf);

            #endregion

            #region Nested type: GetDirectBufferCapacity

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long GetDirectBufferCapacity(IntPtr thiz, Object.JavaPtr* buf);

            #endregion

            #region Nested type: GetDoubleArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double* GetDoubleArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetDoubleArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetDoubleArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, double* buf
                /* double* */);

            #endregion

            #region Nested type: GetDoubleField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double GetDoubleField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetFieldID

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetFieldID(
                IntPtr thiz, Class.JavaPtr* clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetFloatArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float* GetFloatArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetFloatArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetFloatArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, float* buf);

            #endregion

            #region Nested type: GetFloatField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float GetFloatField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetIntArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int* GetIntArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetIntArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetIntArrayRegion(IntPtr thiz, Object.JavaPtr* array, int start, int len, int* buf);

            #endregion

            #region Nested type: GetIntField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetIntField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetJavaVM

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult GetJavaVM(IntPtr thiz, out IntPtr vm);

            #endregion

            #region Nested type: GetLongArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long* GetLongArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetLongArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetLongArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, long* buf);

            #endregion

            #region Nested type: GetLongField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long GetLongField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetMethodID

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetMethodID(
                IntPtr thiz, Class.JavaPtr* clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetObjectArrayElement

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* GetObjectArrayElement(
                IntPtr thiz, Object.JavaPtr* array, int index);

            #endregion

            #region Nested type: GetObjectClass

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Class.JavaPtr* GetObjectClass(IntPtr thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: GetObjectField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* GetObjectField(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetPrimitiveArrayCritical

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void* GetPrimitiveArrayCritical(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetShortArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short* GetShortArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetShortArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetShortArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, short* buf);

            #endregion

            #region Nested type: GetShortField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short GetShortField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticBooleanField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte GetStaticBooleanField(IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticByteField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte GetStaticByteField(IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticCharField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort GetStaticCharField(IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticDoubleField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double GetStaticDoubleField(IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticFieldID

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetStaticFieldID(
                IntPtr thiz, Class.JavaPtr* clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetStaticFloatField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float GetStaticFloatField(IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticIntField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetStaticIntField(IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticLongField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long GetStaticLongField(IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStaticMethodID

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetStaticMethodID(
                IntPtr thiz, Class.JavaPtr* clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetStaticObjectField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* GetStaticObjectField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID
                );

            #endregion

            #region Nested type: GetStaticShortField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short GetStaticShortField(IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID);

            #endregion

            #region Nested type: GetStringChars

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetStringChars(IntPtr thiz, Object.JavaPtr* str, byte* isCopy);

            #endregion

            #region Nested type: GetStringCritical

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetStringCritical(IntPtr thiz, Object.JavaPtr* str, byte* isCopy);

            #endregion

            #region Nested type: GetStringLength

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetStringLength(IntPtr thiz, Object.JavaPtr* str);

            #endregion

            #region Nested type: GetStringRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetStringRegion(IntPtr thiz, Object.JavaPtr* str, int start, int len, char* buf);

            #endregion

            #region Nested type: GetStringUTFChars

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetStringUTFChars(IntPtr thiz, Object.JavaPtr* str, IntPtr isCopy /*byte * */);

            #endregion

            #region Nested type: GetStringUTFLength

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetStringUTFLength(IntPtr thiz, Object.JavaPtr* str);

            #endregion

            #region Nested type: GetStringUTFRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetStringUTFRegion(IntPtr thiz, Object.JavaPtr* str, int start, int len, char* buf);

            #endregion

            #region Nested type: GetVersion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetVersion(IntPtr thiz);

            #endregion

            #region Nested type: IsSameObject

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte IsSameObject(
                IntPtr thiz, Object.JavaPtr* o1, Object.JavaPtr* o2);

            #endregion

            #region Nested type: MonitorEnter

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int MonitorEnter(IntPtr thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: MonitorExit

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int MonitorExit(IntPtr thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: NewBooleanArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewBooleanArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewByteArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewByteArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewCharArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewCharArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewDirectByteBuffer

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewDirectByteBuffer(IntPtr thiz, void* address, long capacity);

            #endregion

            #region Nested type: NewDoubleArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewDoubleArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewFloatArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewFloatArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewGlobalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewGlobalRef(IntPtr thiz, Object.JavaPtr* lobj);

            #endregion

            #region Nested type: NewIntArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewIntArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewLocalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewLocalRef(IntPtr thiz, Object.JavaPtr* reference);

            #endregion

            #region Nested type: NewLongArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewLongArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewObject

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewObject(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr methodID, params Value[] args);

            #endregion

            #region Nested type: NewObjectArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewObjectArray(
                IntPtr thiz, int len, Class.JavaPtr* clazz, Object.JavaPtr* init);

            #endregion

            #region Nested type: NewShortArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewShortArray(IntPtr thiz, int len);

            #endregion

            #region Nested type: NewString

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewString(IntPtr thiz, IntPtr unicode, int len);

            #endregion

            #region Nested type: NewStringUTF

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewStringUTF(IntPtr thiz, IntPtr utf /* const char * */);

            #endregion

            #region Nested type: NewWeakGlobalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr NewWeakGlobalRef(IntPtr thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: PopLocalFrame

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* PopLocalFrame(IntPtr thiz, Object.JavaPtr* result);

            #endregion

            #region Nested type: PushLocalFrame

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int PushLocalFrame(IntPtr thiz, int capacity);

            #endregion

            #region Nested type: RegisterNatives

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult RegisterNatives(
                IntPtr thiz, Class.JavaPtr* clazz, JNINativeMethod* methods, int nMethods);

            #endregion

            #region Nested type: ReleaseBooleanArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseBooleanArrayElements(
                IntPtr thiz, Object.JavaPtr* array, byte* elems, int mode);

            #endregion

            #region Nested type: ReleaseByteArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseByteArrayElements(IntPtr thiz, Object.JavaPtr* array, byte* elems, int mode);

            #endregion

            #region Nested type: ReleaseCharArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseCharArrayElements(
                IntPtr thiz, Object.JavaPtr* array, ushort* elems, int mode);

            #endregion

            #region Nested type: ReleaseDoubleArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseDoubleArrayElements(
                IntPtr thiz, Object.JavaPtr* array, double* elems, int mode);

            #endregion

            #region Nested type: ReleaseFloatArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseFloatArrayElements(
                IntPtr thiz, Object.JavaPtr* array, float* elems, int mode);

            #endregion

            #region Nested type: ReleaseIntArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseIntArrayElements(IntPtr thiz, Object.JavaPtr* array, int* elems, int mode);

            #endregion

            #region Nested type: ReleaseLongArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseLongArrayElements(IntPtr thiz, Object.JavaPtr* array, long* elems, int mode);

            #endregion

            #region Nested type: ReleasePrimitiveArrayCritical

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleasePrimitiveArrayCritical(
                IntPtr thiz, Object.JavaPtr* array, void* carray, int mode);

            #endregion

            #region Nested type: ReleaseShortArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseShortArrayElements(
                IntPtr thiz, Object.JavaPtr* array, short* elems, int mode);

            #endregion

            #region Nested type: ReleaseStringChars

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseStringChars(IntPtr thiz, Object.JavaPtr* str, IntPtr chars);

            #endregion

            #region Nested type: ReleaseStringCritical

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseStringCritical(IntPtr thiz, Object.JavaPtr* str, IntPtr cstring
                /*const char * */);

            #endregion

            #region Nested type: ReleaseStringUTFChars

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseStringUTFChars(IntPtr thiz, Object.JavaPtr* str, IntPtr chars
                /* const char* */);

            #endregion

            #region Nested type: SetBooleanArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetBooleanArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, byte* buf
                /*  const byte * */);

            #endregion

            #region Nested type: SetBooleanField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetBooleanField(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, byte val);

            #endregion

            #region Nested type: SetByteArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetByteArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, byte* buf
                /* const byte * */);

            #endregion

            #region Nested type: SetByteField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetByteField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, byte val);

            #endregion

            #region Nested type: SetCharArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetCharArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, char* buf
                /* const ushort *  */);

            #endregion

            #region Nested type: SetCharField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetCharField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, ushort val
                );

            #endregion

            #region Nested type: SetDoubleArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetDoubleArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, double* buf
                /* const double * */);

            #endregion

            #region Nested type: SetDoubleField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetDoubleField(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, double val);

            #endregion

            #region Nested type: SetFloatArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetFloatArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, float* buf
                /* const float *  */);

            #endregion

            #region Nested type: SetFloatField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetFloatField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, float val
                );

            #endregion

            #region Nested type: SetIntArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetIntArrayRegion(IntPtr thiz, Object.JavaPtr* array, int start, int len, int* buf
                /* const int * */);

            #endregion

            #region Nested type: SetIntField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetIntField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, int val);

            #endregion

            #region Nested type: SetLongArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetLongArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, long* buf
                /*  const long * */);

            #endregion

            #region Nested type: SetLongField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetLongField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, long val);

            #endregion

            #region Nested type: SetObjectArrayElement

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetObjectArrayElement(
                IntPtr thiz, Object.JavaPtr* array, int index, Object.JavaPtr* val);

            #endregion

            #region Nested type: SetObjectField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetObjectField(
                IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, Object.JavaPtr* val);

            #endregion

            #region Nested type: SetShortArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetShortArrayRegion(
                IntPtr thiz, Object.JavaPtr* array, int start, int len, short* buf
                /* const short *  */);

            #endregion

            #region Nested type: SetShortField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetShortField(IntPtr thiz, Object.JavaPtr* obj, IntPtr fieldID, short val
                );

            #endregion

            #region Nested type: SetStaticBooleanField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticBooleanField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, byte value);

            #endregion

            #region Nested type: SetStaticByteField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticByteField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, byte value);

            #endregion

            #region Nested type: SetStaticCharField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticCharField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, ushort value);

            #endregion

            #region Nested type: SetStaticDoubleField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticDoubleField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, double value);

            #endregion

            #region Nested type: SetStaticFloatField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticFloatField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, float value);

            #endregion

            #region Nested type: SetStaticIntField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticIntField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, int value);

            #endregion

            #region Nested type: SetStaticLongField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticLongField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, long value);

            #endregion

            #region Nested type: SetStaticObjectField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticObjectField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, Object.JavaPtr* value);

            #endregion

            #region Nested type: SetStaticShortField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticShortField(
                IntPtr thiz, Class.JavaPtr* clazz, IntPtr fieldID, short value);

            #endregion

            #region Nested type: Throw

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult Throw(IntPtr thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: ThrowNew

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult ThrowNew(IntPtr thiz, Class.JavaPtr* clazz, IntPtr msg);

            #endregion

            #region Nested type: ToReflectedField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* ToReflectedField(
                IntPtr thiz, Class.JavaPtr* cls, IntPtr fieldID, byte isStatic);

            #endregion

            #region Nested type: ToReflectedMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* ToReflectedMethod(
                IntPtr thiz, Class.JavaPtr* cls, IntPtr methodID, byte isStatic);

            #endregion

            #region Nested type: UnregisterJavaPtrs

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult UnregisterJavaPtrs(IntPtr thiz, Class.JavaPtr* clazz);

            #endregion
        }

        #endregion
    }
}