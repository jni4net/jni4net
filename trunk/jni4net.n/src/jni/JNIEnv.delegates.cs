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
            internal delegate Object.JavaPtr* AllocObject(JavaPtr* thiz, Class.JavaPtr* clazz);

            #endregion

            #region Nested type: CallBooleanMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallBooleanMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallByteMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallByteMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallCharMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort CallCharMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallDoubleMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double CallDoubleMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallFloatMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float CallFloatMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallIntMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int CallIntMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallLongMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long CallLongMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualBooleanMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallNonvirtualBooleanMethod(
                Object.JavaPtr* obj, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualByteMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallNonvirtualByteMethod(JavaPtr* thiz,
                                                            Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                            MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualCharMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort CallNonvirtualCharMethod(JavaPtr* thiz,
                                                              Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                              MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualDoubleMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double CallNonvirtualDoubleMethod(JavaPtr* thiz,
                                                                Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                                MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualFloatMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float CallNonvirtualFloatMethod(JavaPtr* thiz,
                                                              Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                              MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualIntMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int CallNonvirtualIntMethod(JavaPtr* thiz,
                                                          Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                          MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualLongMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long CallNonvirtualLongMethod(JavaPtr* thiz,
                                                            Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                            MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualObjectMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* CallNonvirtualObjectMethod(JavaPtr* thiz,
                                                                         Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                                         MethodId.JavaPtr* methodID, params Value[] args
                );

            #endregion

            #region Nested type: CallNonvirtualShortMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short CallNonvirtualShortMethod(JavaPtr* thiz,
                                                              Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                              MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallNonvirtualVoidMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void CallNonvirtualVoidMethod(JavaPtr* thiz,
                                                            Object.JavaPtr* obj, Class.JavaPtr* clazz,
                                                            MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallObjectMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* CallObjectMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallShortMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short CallShortMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticBooleanMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallStaticBooleanMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticByteMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte CallStaticByteMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticCharMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort CallStaticCharMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticDoubleMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double CallStaticDoubleMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticFloatMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float CallStaticFloatMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticIntMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int CallStaticIntMethod(
                JavaPtr* thiz, Class.JavaPtr* obj, MethodId.JavaPtr* methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallStaticLongMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long CallStaticLongMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticObjectMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* CallStaticObjectMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticShortMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short CallStaticShortMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: CallStaticVoidMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult CallStaticVoidMethod(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: CallVoidMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult CallVoidMethod(
                JavaPtr* thiz, Object.JavaPtr* obj, MethodId.JavaPtr* methodIdJavaPtr, params Value[] args);

            #endregion

            #region Nested type: DefineClass

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Class.JavaPtr* DefineClass(JavaPtr* thiz,
                                                         IntPtr name /*const char* */, Object.JavaPtr* loader,
                                                         IntPtr buf /*const byte **/, int len);

            #endregion

            #region Nested type: DeleteGlobalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void DeleteGlobalRef(JavaPtr* thiz, Object.JavaPtr* gref);

            #endregion

            #region Nested type: DeleteLocalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void DeleteLocalRef(JavaPtr* thiz, Object.JavaPtr* lref);

            #endregion

            #region Nested type: DeleteWeakGlobalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void DeleteWeakGlobalRef(JavaPtr* thiz, IntPtr wref);

            #endregion

            #region Nested type: EnsureLocalCapacity

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int EnsureLocalCapacity(JavaPtr* thiz, int capacity);

            #endregion

            #region Nested type: ExceptionCheck

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte ExceptionCheck(JavaPtr* thiz);

            #endregion

            #region Nested type: ExceptionClear

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ExceptionClear(JavaPtr* thiz);

            #endregion

            #region Nested type: ExceptionDescribe

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ExceptionDescribe(JavaPtr* thiz);

            #endregion

            #region Nested type: ExceptionOccurred

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* ExceptionOccurred(JavaPtr* thiz);

            #endregion

            #region Nested type: FatalError

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void FatalError(JavaPtr* thiz, IntPtr msg);

            #endregion

            #region Nested type: FindClass

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Class.JavaPtr* FindClass(JavaPtr* thiz, [MarshalAs(UnmanagedType.LPStr)] string name);

            #endregion

            #region Nested type: FromReflectedField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate FieldId.JavaPtr* FromReflectedField(JavaPtr* thiz, Object.JavaPtr* field);

            #endregion

            #region Nested type: FromReflectedMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate MethodId.JavaPtr* FromReflectedMethod(JavaPtr* thiz, Object.JavaPtr* method);

            #endregion

            #region Nested type: GetArrayLength

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetArrayLength(
                JavaPtr* thiz, Object.JavaPtr* array);

            #endregion

            #region Nested type: GetBooleanArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte* GetBooleanArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetBooleanArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetBooleanArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, byte* buf);

            #endregion

            #region Nested type: GetBooleanField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte GetBooleanField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetByteArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte* GetByteArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetByteArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetByteArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, byte* buf);

            #endregion

            #region Nested type: GetByteField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte GetByteField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetCharArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort* GetCharArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetCharArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetCharArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, char* buf);

            #endregion

            #region Nested type: GetCharField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort GetCharField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetDirectBufferAddress

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void* GetDirectBufferAddress(JavaPtr* thiz, Object.JavaPtr* buf);

            #endregion

            #region Nested type: GetDirectBufferCapacity

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long GetDirectBufferCapacity(JavaPtr* thiz, Object.JavaPtr* buf);

            #endregion

            #region Nested type: GetDoubleArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double* GetDoubleArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetDoubleArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetDoubleArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, double* buf
                /* double* */);

            #endregion

            #region Nested type: GetDoubleField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double GetDoubleField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetFieldID

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate FieldId.JavaPtr* GetFieldID(
                JavaPtr* thiz, Class.JavaPtr* clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetFloatArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float* GetFloatArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetFloatArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetFloatArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, float* buf);

            #endregion

            #region Nested type: GetFloatField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float GetFloatField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetIntArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int* GetIntArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetIntArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetIntArrayRegion(JavaPtr* thiz, Object.JavaPtr* array, int start, int len, int* buf);

            #endregion

            #region Nested type: GetIntField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetIntField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetJavaVM

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult GetJavaVM(JavaPtr* thiz, out JavaVM.JavaPtr* vm);

            #endregion

            #region Nested type: GetLongArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long* GetLongArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetLongArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetLongArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, long* buf);

            #endregion

            #region Nested type: GetLongField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long GetLongField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetMethodID

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate MethodId.JavaPtr* GetMethodID(
                JavaPtr* thiz, Class.JavaPtr* clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetObjectArrayElement

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* GetObjectArrayElement(
                JavaPtr* thiz, Object.JavaPtr* array, int index);

            #endregion

            #region Nested type: GetObjectClass

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Class.JavaPtr* GetObjectClass(JavaPtr* thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: GetObjectField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* GetObjectField(
                JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetPrimitiveArrayCritical

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void* GetPrimitiveArrayCritical(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetShortArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short* GetShortArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* isCopy);

            #endregion

            #region Nested type: GetShortArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetShortArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, short* buf);

            #endregion

            #region Nested type: GetShortField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short GetShortField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStaticBooleanField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte GetStaticBooleanField(JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStaticByteField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte GetStaticByteField(JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStaticCharField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate ushort GetStaticCharField(JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStaticDoubleField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate double GetStaticDoubleField(JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStaticFieldID

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate FieldId.JavaPtr* GetStaticFieldID(
                JavaPtr* thiz, Class.JavaPtr* clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetStaticFloatField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate float GetStaticFloatField(JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStaticIntField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetStaticIntField(JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStaticLongField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate long GetStaticLongField(JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStaticMethodID

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate MethodId.JavaPtr* GetStaticMethodID(
                JavaPtr* thiz, Class.JavaPtr* clazz, [MarshalAs(UnmanagedType.LPStr)] string name,
                [MarshalAs(UnmanagedType.LPStr)] string sig);

            #endregion

            #region Nested type: GetStaticObjectField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* GetStaticObjectField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID
                );

            #endregion

            #region Nested type: GetStaticShortField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate short GetStaticShortField(JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID);

            #endregion

            #region Nested type: GetStringChars

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetStringChars(JavaPtr* thiz, Object.JavaPtr* str, byte* isCopy);

            #endregion

            #region Nested type: GetStringCritical

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetStringCritical(JavaPtr* thiz, Object.JavaPtr* str, byte* isCopy);

            #endregion

            #region Nested type: GetStringLength

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetStringLength(JavaPtr* thiz, Object.JavaPtr* str);

            #endregion

            #region Nested type: GetStringRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetStringRegion(JavaPtr* thiz, Object.JavaPtr* str, int start, int len, char* buf);

            #endregion

            #region Nested type: GetStringUTFChars

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr GetStringUTFChars(JavaPtr* thiz, Object.JavaPtr* str, IntPtr isCopy /*byte * */);

            #endregion

            #region Nested type: GetStringUTFLength

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetStringUTFLength(JavaPtr* thiz, Object.JavaPtr* str);

            #endregion

            #region Nested type: GetStringUTFRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void GetStringUTFRegion(JavaPtr* thiz, Object.JavaPtr* str, int start, int len, char* buf);

            #endregion

            #region Nested type: GetVersion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int GetVersion(JavaPtr* thiz);

            #endregion

            #region Nested type: IsSameObject

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate byte IsSameObject(
                JavaPtr* thiz, Object.JavaPtr* o1, Object.JavaPtr* o2);

            #endregion

            #region Nested type: MonitorEnter

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int MonitorEnter(JavaPtr* thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: MonitorExit

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int MonitorExit(JavaPtr* thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: NewBooleanArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewBooleanArray(JavaPtr* thiz, int len);

            #endregion

            #region Nested type: NewByteArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewByteArray(JavaPtr* thiz, int len);

            #endregion

            #region Nested type: NewCharArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewCharArray(JavaPtr* thiz, int len);

            #endregion

            #region Nested type: NewDirectByteBuffer

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewDirectByteBuffer(JavaPtr* thiz, void* address, long capacity);

            #endregion

            #region Nested type: NewDoubleArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewDoubleArray(JavaPtr* thiz, int len);

            #endregion

            #region Nested type: NewFloatArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewFloatArray(JavaPtr* thiz, int len);

            #endregion

            #region Nested type: NewGlobalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewGlobalRef(JavaPtr* thiz, Object.JavaPtr* lobj);

            #endregion

            #region Nested type: NewIntArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewIntArray(JavaPtr* thiz, int len);

            #endregion

            #region Nested type: NewLocalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewLocalRef(JavaPtr* thiz, Object.JavaPtr* reference);

            #endregion

            #region Nested type: NewLongArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewLongArray(JavaPtr* thiz, int len);

            #endregion

            #region Nested type: NewObject

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewObject(
                JavaPtr* thiz, Class.JavaPtr* clazz, MethodId.JavaPtr* methodID, params Value[] args);

            #endregion

            #region Nested type: NewObjectArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewObjectArray(
                JavaPtr* thiz, int len, Class.JavaPtr* clazz, Object.JavaPtr* init);

            #endregion

            #region Nested type: NewShortArray

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewShortArray(JavaPtr* thiz, int len);

            #endregion

            #region Nested type: NewString

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewString(JavaPtr* thiz, IntPtr unicode, int len);

            #endregion

            #region Nested type: NewStringUTF

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* NewStringUTF(JavaPtr* thiz, IntPtr utf /* const char * */);

            #endregion

            #region Nested type: NewWeakGlobalRef

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate IntPtr NewWeakGlobalRef(JavaPtr* thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: PopLocalFrame

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* PopLocalFrame(JavaPtr* thiz, Object.JavaPtr* result);

            #endregion

            #region Nested type: PushLocalFrame

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate int PushLocalFrame(JavaPtr* thiz, int capacity);

            #endregion

            #region Nested type: RegisterNatives

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult RegisterNatives(
                JavaPtr* thiz, Class.JavaPtr* clazz, JNINativeMethod* methods, int nMethods);

            #endregion

            #region Nested type: ReleaseBooleanArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseBooleanArrayElements(
                JavaPtr* thiz, Object.JavaPtr* array, byte* elems, int mode);

            #endregion

            #region Nested type: ReleaseByteArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseByteArrayElements(JavaPtr* thiz, Object.JavaPtr* array, byte* elems, int mode);

            #endregion

            #region Nested type: ReleaseCharArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseCharArrayElements(
                JavaPtr* thiz, Object.JavaPtr* array, ushort* elems, int mode);

            #endregion

            #region Nested type: ReleaseDoubleArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseDoubleArrayElements(
                JavaPtr* thiz, Object.JavaPtr* array, double* elems, int mode);

            #endregion

            #region Nested type: ReleaseFloatArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseFloatArrayElements(
                JavaPtr* thiz, Object.JavaPtr* array, float* elems, int mode);

            #endregion

            #region Nested type: ReleaseIntArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseIntArrayElements(JavaPtr* thiz, Object.JavaPtr* array, int* elems, int mode);

            #endregion

            #region Nested type: ReleaseLongArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseLongArrayElements(JavaPtr* thiz, Object.JavaPtr* array, long* elems, int mode);

            #endregion

            #region Nested type: ReleasePrimitiveArrayCritical

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleasePrimitiveArrayCritical(
                JavaPtr* thiz, Object.JavaPtr* array, void* carray, int mode);

            #endregion

            #region Nested type: ReleaseShortArrayElements

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseShortArrayElements(
                JavaPtr* thiz, Object.JavaPtr* array, short* elems, int mode);

            #endregion

            #region Nested type: ReleaseStringChars

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseStringChars(JavaPtr* thiz, Object.JavaPtr* str, IntPtr chars);

            #endregion

            #region Nested type: ReleaseStringCritical

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseStringCritical(JavaPtr* thiz, Object.JavaPtr* str, IntPtr cstring
                /*const char * */);

            #endregion

            #region Nested type: ReleaseStringUTFChars

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void ReleaseStringUTFChars(JavaPtr* thiz, Object.JavaPtr* str, IntPtr chars
                /* const char* */);

            #endregion

            #region Nested type: SetBooleanArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetBooleanArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, byte* buf
                /*  const byte * */);

            #endregion

            #region Nested type: SetBooleanField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetBooleanField(
                JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, byte val);

            #endregion

            #region Nested type: SetByteArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetByteArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, byte* buf
                /* const byte * */);

            #endregion

            #region Nested type: SetByteField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetByteField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, byte val);

            #endregion

            #region Nested type: SetCharArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetCharArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, char* buf
                /* const ushort *  */);

            #endregion

            #region Nested type: SetCharField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetCharField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, ushort val
                );

            #endregion

            #region Nested type: SetDoubleArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetDoubleArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, double* buf
                /* const double * */);

            #endregion

            #region Nested type: SetDoubleField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetDoubleField(
                JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, double val);

            #endregion

            #region Nested type: SetFloatArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetFloatArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, float* buf
                /* const float *  */);

            #endregion

            #region Nested type: SetFloatField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetFloatField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, float val
                );

            #endregion

            #region Nested type: SetIntArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetIntArrayRegion(JavaPtr* thiz, Object.JavaPtr* array, int start, int len, int* buf
                /* const int * */);

            #endregion

            #region Nested type: SetIntField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetIntField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, int val);

            #endregion

            #region Nested type: SetLongArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetLongArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, long* buf
                /*  const long * */);

            #endregion

            #region Nested type: SetLongField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetLongField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, long val);

            #endregion

            #region Nested type: SetObjectArrayElement

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetObjectArrayElement(
                JavaPtr* thiz, Object.JavaPtr* array, int index, Object.JavaPtr* val);

            #endregion

            #region Nested type: SetObjectField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetObjectField(
                JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, Object.JavaPtr* val);

            #endregion

            #region Nested type: SetShortArrayRegion

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetShortArrayRegion(
                JavaPtr* thiz, Object.JavaPtr* array, int start, int len, short* buf
                /* const short *  */);

            #endregion

            #region Nested type: SetShortField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetShortField(JavaPtr* thiz, Object.JavaPtr* obj, FieldId.JavaPtr* fieldID, short val
                );

            #endregion

            #region Nested type: SetStaticBooleanField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticBooleanField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, byte value);

            #endregion

            #region Nested type: SetStaticByteField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticByteField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, byte value);

            #endregion

            #region Nested type: SetStaticCharField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticCharField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, ushort value);

            #endregion

            #region Nested type: SetStaticDoubleField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticDoubleField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, double value);

            #endregion

            #region Nested type: SetStaticFloatField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticFloatField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, float value);

            #endregion

            #region Nested type: SetStaticIntField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticIntField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, int value);

            #endregion

            #region Nested type: SetStaticLongField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticLongField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, long value);

            #endregion

            #region Nested type: SetStaticObjectField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticObjectField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, Object.JavaPtr* value);

            #endregion

            #region Nested type: SetStaticShortField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate void SetStaticShortField(
                JavaPtr* thiz, Class.JavaPtr* clazz, FieldId.JavaPtr* fieldID, short value);

            #endregion

            #region Nested type: Throw

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult Throw(JavaPtr* thiz, Object.JavaPtr* obj);

            #endregion

            #region Nested type: ThrowNew

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult ThrowNew(JavaPtr* thiz, Class.JavaPtr* clazz, IntPtr msg);

            #endregion

            #region Nested type: ToReflectedField

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* ToReflectedField(
                JavaPtr* thiz, Class.JavaPtr* cls, FieldId.JavaPtr* fieldID, byte isStatic);

            #endregion

            #region Nested type: ToReflectedMethod

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate Object.JavaPtr* ToReflectedMethod(
                JavaPtr* thiz, Class.JavaPtr* cls, MethodId.JavaPtr* methodID, byte isStatic);

            #endregion

            #region Nested type: UnregisterJavaPtrs

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            internal delegate JNIResult UnregisterJavaPtrs(JavaPtr* thiz, Class.JavaPtr* clazz);

            #endregion
        }

        #endregion
    }
}