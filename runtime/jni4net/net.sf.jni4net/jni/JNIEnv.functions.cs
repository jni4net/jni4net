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
using System.Security;
using net.sf.jni4net.core;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.jni
{
    [SuppressUnmanagedCodeSecurity]
    unsafe partial class JNIEnv
    {
        public JNIEnv(IntPtr envPtr)
        {
            this.envPtr = envPtr;
            Functions.functions = *(*(JNINativeInterfacePtr*)envPtr.ToPointer()).functions;
            Functions.InitMethods();
        }

        [SuppressUnmanagedCodeSecurity]
        internal static class Functions
        {
            public static JNINativeInterface functions;

            private static bool initialized;
            static public JNIDelegates.Cdecl.AllocObject allocObject;
            static public JNIDelegates.Cdecl.CallBooleanMethod callBooleanMethod;
            static public JNIDelegates.Cdecl.CallByteMethod callByteMethod;
            static public JNIDelegates.Cdecl.CallCharMethod callCharMethod;
            static public JNIDelegates.Cdecl.CallDoubleMethod callDoubleMethod;
            static public JNIDelegates.Cdecl.CallFloatMethod callFloatMethod;
            static public JNIDelegates.Cdecl.CallIntMethod callIntMethod;
            static public JNIDelegates.Cdecl.CallLongMethod callLongMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualBooleanMethod callNonvirtualBooleanMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualByteMethod callNonvirtualByteMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualCharMethod callNonvirtualCharMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualDoubleMethod callNonvirtualDoubleMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualFloatMethod callNonvirtualFloatMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualIntMethod callNonvirtualIntMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualLongMethod callNonvirtualLongMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualObjectMethod callNonvirtualObjectMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualShortMethod callNonvirtualShortMethod;
            static public JNIDelegates.Cdecl.CallNonvirtualVoidMethod callNonvirtualVoidMethod;
            static public JNIDelegates.Cdecl.CallObjectMethod callObjectMethod;
            static public JNIDelegates.Cdecl.CallShortMethod callShortMethod;
            static public JNIDelegates.Cdecl.CallStaticBooleanMethod callStaticBooleanMethod;
            static public JNIDelegates.Cdecl.CallStaticByteMethod callStaticByteMethod;
            static public JNIDelegates.Cdecl.CallStaticCharMethod callStaticCharMethod;
            static public JNIDelegates.Cdecl.CallStaticDoubleMethod callStaticDoubleMethod;
            static public JNIDelegates.Cdecl.CallStaticFloatMethod callStaticFloatMethod;
            static public JNIDelegates.Cdecl.CallStaticIntMethod callStaticIntMethod;
            static public JNIDelegates.Cdecl.CallStaticLongMethod callStaticLongMethod;
            static public JNIDelegates.Cdecl.CallStaticObjectMethod callStaticObjectMethod;
            static public JNIDelegates.Cdecl.CallStaticShortMethod callStaticShortMethod;
            static public JNIDelegates.Cdecl.CallStaticVoidMethod callStaticVoidMethod;
            static public JNIDelegates.Cdecl.CallVoidMethod callVoidMethod;
            static public JNIDelegates.Cdecl.DefineClass defineClass;
            static public JNIDelegates.Cdecl.DeleteGlobalRef deleteGlobalRef;
            static public JNIDelegates.Cdecl.DeleteLocalRef deleteLocalRef;
            static public JNIDelegates.Cdecl.DeleteWeakGlobalRef deleteWeakGlobalRef;
            static public JNIDelegates.Cdecl.EnsureLocalCapacity ensureLocalCapacity;
            static public JNIDelegates.Cdecl.ExceptionCheck exceptionCheck;
            static public JNIDelegates.Cdecl.ExceptionClear exceptionClear;
            static public JNIDelegates.Cdecl.ExceptionDescribe exceptionDescribe;
            static public JNIDelegates.Cdecl.ExceptionOccurred exceptionOccurred;
            static public JNIDelegates.Cdecl.FatalError fatalError;
            static public JNIDelegates.Cdecl.FindClass findClass;
            static public JNIDelegates.Cdecl.FromReflectedField fromReflectedField;
            static public JNIDelegates.Cdecl.FromReflectedMethod fromReflectedMethod;
            static public JNIDelegates.Cdecl.GetArrayLength getArrayLength;
            static public JNIDelegates.Cdecl.GetBooleanArrayElements getBooleanArrayElements;
            static public JNIDelegates.Cdecl.GetBooleanArrayRegion getBooleanArrayRegion;
            static public JNIDelegates.Cdecl.GetBooleanField getBooleanField;
            static public JNIDelegates.Cdecl.GetByteArrayElements getByteArrayElements;
            static public JNIDelegates.Cdecl.GetByteArrayRegion getByteArrayRegion;
            static public JNIDelegates.Cdecl.GetByteField getByteField;
            static public JNIDelegates.Cdecl.GetCharArrayElements getCharArrayElements;
            static public JNIDelegates.Cdecl.GetCharArrayRegion getCharArrayRegion;
            static public JNIDelegates.Cdecl.GetCharField getCharField;
            static public JNIDelegates.Cdecl.GetDirectBufferAddress getDirectBufferAddress;
            static public JNIDelegates.Cdecl.GetDirectBufferCapacity getDirectBufferCapacity;
            static public JNIDelegates.Cdecl.GetDoubleArrayElements getDoubleArrayElements;
            static public JNIDelegates.Cdecl.GetDoubleArrayRegion getDoubleArrayRegion;
            static public JNIDelegates.Cdecl.GetDoubleField getDoubleField;
            static public JNIDelegates.Cdecl.GetFieldID getFieldID;
            static public JNIDelegates.Cdecl.GetFloatArrayElements getFloatArrayElements;
            static public JNIDelegates.Cdecl.GetFloatArrayRegion getFloatArrayRegion;
            static public JNIDelegates.Cdecl.GetFloatField getFloatField;
            static public JNIDelegates.Cdecl.GetIntArrayElements getIntArrayElements;
            static public JNIDelegates.Cdecl.GetIntArrayRegion getIntArrayRegion;
            static public JNIDelegates.Cdecl.GetIntField getIntField;
            static public JNIDelegates.Cdecl.GetJavaVM getJavaVM;
            static public JNIDelegates.Cdecl.GetLongArrayElements getLongArrayElements;
            static public JNIDelegates.Cdecl.GetLongArrayRegion getLongArrayRegion;
            static public JNIDelegates.Cdecl.GetLongField getLongField;
            static public JNIDelegates.Cdecl.GetMethodID getMethodID;
            static public JNIDelegates.Cdecl.GetObjectArrayElement getObjectArrayElement;
            static public JNIDelegates.Cdecl.GetObjectClass getObjectClass;
            static public JNIDelegates.Cdecl.GetObjectField getObjectField;
            static public JNIDelegates.Cdecl.GetPrimitiveArrayCritical getPrimitiveArrayCritical;
            static public JNIDelegates.Cdecl.GetShortArrayElements getShortArrayElements;
            static public JNIDelegates.Cdecl.GetShortArrayRegion getShortArrayRegion;
            static public JNIDelegates.Cdecl.GetShortField getShortField;
            static public JNIDelegates.Cdecl.GetStaticBooleanField getStaticBooleanField;
            static public JNIDelegates.Cdecl.GetStaticByteField getStaticByteField;
            static public JNIDelegates.Cdecl.GetStaticCharField getStaticCharField;
            static public JNIDelegates.Cdecl.GetStaticDoubleField getStaticDoubleField;
            static public JNIDelegates.Cdecl.GetStaticFieldID getStaticFieldID;
            static public JNIDelegates.Cdecl.GetStaticFloatField getStaticFloatField;
            static public JNIDelegates.Cdecl.GetStaticIntField getStaticIntField;
            static public JNIDelegates.Cdecl.GetStaticLongField getStaticLongField;
            static public JNIDelegates.Cdecl.GetStaticMethodID getStaticMethodID;
            static public JNIDelegates.Cdecl.GetStaticObjectField getStaticObjectField;
            static public JNIDelegates.Cdecl.GetStaticShortField getStaticShortField;
            static public JNIDelegates.Cdecl.GetStringChars getStringChars;
            static public JNIDelegates.Cdecl.GetStringCritical getStringCritical;
            static public JNIDelegates.Cdecl.GetStringLength getStringLength;
            static public JNIDelegates.Cdecl.GetStringRegion getStringRegion;
            static public JNIDelegates.Cdecl.GetStringUTFChars getStringUTFChars;
            static public JNIDelegates.Cdecl.GetStringUTFLength getStringUTFLength;
            static public JNIDelegates.Cdecl.GetStringUTFRegion getStringUTFRegion;
            static public JNIDelegates.Cdecl.GetVersion getVersion;
            static public JNIDelegates.Cdecl.IsSameObject isSameObject;
            static public JNIDelegates.Cdecl.MonitorEnter monitorEnter;
            static public JNIDelegates.Cdecl.MonitorExit monitorExit;
            static public JNIDelegates.Cdecl.NewBooleanArray newBooleanArray;
            static public JNIDelegates.Cdecl.NewByteArray newByteArray;
            static public JNIDelegates.Cdecl.NewCharArray newCharArray;
            static public JNIDelegates.Cdecl.NewDirectByteBuffer newDirectByteBuffer;
            static public JNIDelegates.Cdecl.NewDoubleArray newDoubleArray;
            static public JNIDelegates.Cdecl.NewFloatArray newFloatArray;
            static public JNIDelegates.Cdecl.NewGlobalRef newGlobalRef;
            static public JNIDelegates.Cdecl.NewIntArray newIntArray;
            static public JNIDelegates.Cdecl.NewLocalRef newLocalRef;
            static public JNIDelegates.Cdecl.NewLongArray newLongArray;
            static public JNIDelegates.Cdecl.NewObject newObject;
            static public JNIDelegates.Cdecl.NewObjectArray newObjectArray;
            static public JNIDelegates.Cdecl.NewShortArray newShortArray;
            static public JNIDelegates.Cdecl.NewString newString;
            static public JNIDelegates.Cdecl.NewStringUTF newStringUTF;
            static public JNIDelegates.Cdecl.NewWeakGlobalRef newWeakGlobalRef;
            static public JNIDelegates.Cdecl.PopLocalFrame popLocalFrame;
            static public JNIDelegates.Cdecl.PushLocalFrame pushLocalFrame;
            static public JNIDelegates.Cdecl.RegisterNatives registerNatives;
            static public JNIDelegates.Cdecl.UnregisterNatives unregisterNatives;
            static public JNIDelegates.Cdecl.ReleaseBooleanArrayElements releaseBooleanArrayElements;
            static public JNIDelegates.Cdecl.ReleaseByteArrayElements releaseByteArrayElements;
            static public JNIDelegates.Cdecl.ReleaseCharArrayElements releaseCharArrayElements;
            static public JNIDelegates.Cdecl.ReleaseDoubleArrayElements releaseDoubleArrayElements;
            static public JNIDelegates.Cdecl.ReleaseFloatArrayElements releaseFloatArrayElements;
            static public JNIDelegates.Cdecl.ReleaseIntArrayElements releaseIntArrayElements;
            static public JNIDelegates.Cdecl.ReleaseLongArrayElements releaseLongArrayElements;
            static public JNIDelegates.Cdecl.ReleasePrimitiveArrayCritical releasePrimitiveArrayCritical;
            static public JNIDelegates.Cdecl.ReleaseShortArrayElements releaseShortArrayElements;
            static public JNIDelegates.Cdecl.ReleaseStringChars releaseStringChars;
            static public JNIDelegates.Cdecl.ReleaseStringCritical releaseStringCritical;
            static public JNIDelegates.Cdecl.ReleaseStringUTFChars releaseStringUTFChars;
            static public JNIDelegates.Cdecl.SetBooleanArrayRegion setBooleanArrayRegion;
            static public JNIDelegates.Cdecl.SetBooleanField setBooleanField;
            static public JNIDelegates.Cdecl.SetByteArrayRegion setByteArrayRegion;
            static public JNIDelegates.Cdecl.SetByteField setByteField;
            static public JNIDelegates.Cdecl.SetCharArrayRegion setCharArrayRegion;
            static public JNIDelegates.Cdecl.SetCharField setCharField;
            static public JNIDelegates.Cdecl.SetDoubleArrayRegion setDoubleArrayRegion;
            static public JNIDelegates.Cdecl.SetDoubleField setDoubleField;
            static public JNIDelegates.Cdecl.SetFloatArrayRegion setFloatArrayRegion;
            static public JNIDelegates.Cdecl.SetFloatField setFloatField;
            static public JNIDelegates.Cdecl.SetIntArrayRegion setIntArrayRegion;
            static public JNIDelegates.Cdecl.SetIntField setIntField;
            static public JNIDelegates.Cdecl.SetLongArrayRegion setLongArrayRegion;
            static public JNIDelegates.Cdecl.SetLongField setLongField;
            static public JNIDelegates.Cdecl.SetObjectArrayElement setObjectArrayElement;
            static public JNIDelegates.Cdecl.SetObjectField setObjectField;
            static public JNIDelegates.Cdecl.SetShortArrayRegion setShortArrayRegion;
            static public JNIDelegates.Cdecl.SetShortField setShortField;
            static public JNIDelegates.Cdecl.SetStaticBooleanField setStaticBooleanField;
            static public JNIDelegates.Cdecl.SetStaticByteField setStaticByteField;
            static public JNIDelegates.Cdecl.SetStaticCharField setStaticCharField;
            static public JNIDelegates.Cdecl.SetStaticDoubleField setStaticDoubleField;
            static public JNIDelegates.Cdecl.SetStaticFloatField setStaticFloatField;
            static public JNIDelegates.Cdecl.SetStaticIntField setStaticIntField;
            static public JNIDelegates.Cdecl.SetStaticLongField setStaticLongField;
            static public JNIDelegates.Cdecl.SetStaticObjectField setStaticObjectField;
            static public JNIDelegates.Cdecl.SetStaticShortField setStaticShortField;
            static public JNIDelegates.Cdecl.Throw @throw;
            static public JNIDelegates.Cdecl.ThrowNew throwNew;
            static public JNIDelegates.Cdecl.ToReflectedField toReflectedField;
            static public JNIDelegates.Cdecl.ToReflectedMethod toReflectedMethod;

            public static void InitMethods()
            {
                lock (typeof(JNIEnv))
                {
                    if (initialized)
                    {
                        return;
                    }

                    bool IsStdCall = OsUtils.IsRunningWindows;
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallBooleanMethod, JNIDelegates.StdCall.CallBooleanMethod>(functions.CallBooleanMethod, ref callBooleanMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallByteMethod, JNIDelegates.StdCall.CallByteMethod>(functions.CallByteMethod, ref callByteMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallCharMethod, JNIDelegates.StdCall.CallCharMethod>(functions.CallCharMethod, ref callCharMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallDoubleMethod, JNIDelegates.StdCall.CallDoubleMethod>(functions.CallDoubleMethod, ref callDoubleMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallFloatMethod, JNIDelegates.StdCall.CallFloatMethod>(functions.CallFloatMethod, ref callFloatMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallIntMethod, JNIDelegates.StdCall.CallIntMethod>(functions.CallIntMethod, ref callIntMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallLongMethod, JNIDelegates.StdCall.CallLongMethod>(functions.CallLongMethod, ref callLongMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallObjectMethod, JNIDelegates.StdCall.CallObjectMethod>(functions.CallObjectMethod, ref callObjectMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallShortMethod, JNIDelegates.StdCall.CallShortMethod>(functions.CallShortMethod, ref callShortMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallVoidMethod, JNIDelegates.StdCall.CallVoidMethod>(functions.CallVoidMethod, ref callVoidMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticBooleanMethod, JNIDelegates.StdCall.CallStaticBooleanMethod>(functions.CallStaticBooleanMethod, ref callStaticBooleanMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticByteMethod, JNIDelegates.StdCall.CallStaticByteMethod>(functions.CallStaticByteMethod, ref callStaticByteMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticCharMethod, JNIDelegates.StdCall.CallStaticCharMethod>(functions.CallStaticCharMethod, ref callStaticCharMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticDoubleMethod, JNIDelegates.StdCall.CallStaticDoubleMethod>(functions.CallStaticDoubleMethod, ref callStaticDoubleMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticFloatMethod, JNIDelegates.StdCall.CallStaticFloatMethod>(functions.CallStaticFloatMethod, ref callStaticFloatMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticIntMethod, JNIDelegates.StdCall.CallStaticIntMethod>(functions.CallStaticIntMethod, ref callStaticIntMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticLongMethod, JNIDelegates.StdCall.CallStaticLongMethod>(functions.CallStaticLongMethod, ref callStaticLongMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticObjectMethod, JNIDelegates.StdCall.CallStaticObjectMethod>(functions.CallStaticObjectMethod, ref callStaticObjectMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticShortMethod, JNIDelegates.StdCall.CallStaticShortMethod>(functions.CallStaticShortMethod, ref callStaticShortMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallStaticVoidMethod, JNIDelegates.StdCall.CallStaticVoidMethod>(functions.CallStaticVoidMethod, ref callStaticVoidMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticObjectField, JNIDelegates.StdCall.GetStaticObjectField>(functions.GetStaticObjectField, ref getStaticObjectField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticBooleanField, JNIDelegates.StdCall.GetStaticBooleanField>(functions.GetStaticBooleanField, ref getStaticBooleanField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticByteField, JNIDelegates.StdCall.GetStaticByteField>(functions.GetStaticByteField, ref getStaticByteField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticCharField, JNIDelegates.StdCall.GetStaticCharField>(functions.GetStaticCharField, ref getStaticCharField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticShortField, JNIDelegates.StdCall.GetStaticShortField>(functions.GetStaticShortField, ref getStaticShortField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticIntField, JNIDelegates.StdCall.GetStaticIntField>(functions.GetStaticIntField, ref getStaticIntField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticLongField, JNIDelegates.StdCall.GetStaticLongField>(functions.GetStaticLongField, ref getStaticLongField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticFloatField, JNIDelegates.StdCall.GetStaticFloatField>(functions.GetStaticFloatField, ref getStaticFloatField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticDoubleField, JNIDelegates.StdCall.GetStaticDoubleField>(functions.GetStaticDoubleField, ref getStaticDoubleField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticObjectField, JNIDelegates.StdCall.SetStaticObjectField>(functions.SetStaticObjectField, ref setStaticObjectField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticBooleanField, JNIDelegates.StdCall.SetStaticBooleanField>(functions.SetStaticBooleanField, ref setStaticBooleanField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticByteField, JNIDelegates.StdCall.SetStaticByteField>(functions.SetStaticByteField, ref setStaticByteField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticCharField, JNIDelegates.StdCall.SetStaticCharField>(functions.SetStaticCharField, ref setStaticCharField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticShortField, JNIDelegates.StdCall.SetStaticShortField>(functions.SetStaticShortField, ref setStaticShortField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticIntField, JNIDelegates.StdCall.SetStaticIntField>(functions.SetStaticIntField, ref setStaticIntField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticLongField, JNIDelegates.StdCall.SetStaticLongField>(functions.SetStaticLongField, ref setStaticLongField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticFloatField, JNIDelegates.StdCall.SetStaticFloatField>(functions.SetStaticFloatField, ref setStaticFloatField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetStaticDoubleField, JNIDelegates.StdCall.SetStaticDoubleField>(functions.SetStaticDoubleField, ref setStaticDoubleField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetObjectField, JNIDelegates.StdCall.GetObjectField>(functions.GetObjectField, ref getObjectField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetBooleanField, JNIDelegates.StdCall.GetBooleanField>(functions.GetBooleanField, ref getBooleanField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetByteField, JNIDelegates.StdCall.GetByteField>(functions.GetByteField, ref getByteField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetCharField, JNIDelegates.StdCall.GetCharField>(functions.GetCharField, ref getCharField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetShortField, JNIDelegates.StdCall.GetShortField>(functions.GetShortField, ref getShortField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetIntField, JNIDelegates.StdCall.GetIntField>(functions.GetIntField, ref getIntField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetLongField, JNIDelegates.StdCall.GetLongField>(functions.GetLongField, ref getLongField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetFloatField, JNIDelegates.StdCall.GetFloatField>(functions.GetFloatField, ref getFloatField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetDoubleField, JNIDelegates.StdCall.GetDoubleField>(functions.GetDoubleField, ref getDoubleField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetObjectField, JNIDelegates.StdCall.SetObjectField>(functions.SetObjectField, ref setObjectField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetBooleanField, JNIDelegates.StdCall.SetBooleanField>(functions.SetBooleanField, ref setBooleanField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetByteField, JNIDelegates.StdCall.SetByteField>(functions.SetByteField, ref setByteField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetCharField, JNIDelegates.StdCall.SetCharField>(functions.SetCharField, ref setCharField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetShortField, JNIDelegates.StdCall.SetShortField>(functions.SetShortField, ref setShortField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetIntField, JNIDelegates.StdCall.SetIntField>(functions.SetIntField, ref setIntField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetLongField, JNIDelegates.StdCall.SetLongField>(functions.SetLongField, ref setLongField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetFloatField, JNIDelegates.StdCall.SetFloatField>(functions.SetFloatField, ref setFloatField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetDoubleField, JNIDelegates.StdCall.SetDoubleField>(functions.SetDoubleField, ref setDoubleField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.DeleteGlobalRef, JNIDelegates.StdCall.DeleteGlobalRef>(functions.DeleteGlobalRef, ref deleteGlobalRef, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.DeleteLocalRef, JNIDelegates.StdCall.DeleteLocalRef>(functions.DeleteLocalRef, ref deleteLocalRef, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.EnsureLocalCapacity, JNIDelegates.StdCall.EnsureLocalCapacity>(functions.EnsureLocalCapacity, ref ensureLocalCapacity, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ExceptionCheck, JNIDelegates.StdCall.ExceptionCheck>(functions.ExceptionCheck, ref exceptionCheck, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.FindClass, JNIDelegates.StdCall.FindClass>(functions.FindClass, ref findClass, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetDirectBufferAddress, JNIDelegates.StdCall.GetDirectBufferAddress>(functions.GetDirectBufferAddress, ref getDirectBufferAddress, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetDirectBufferCapacity, JNIDelegates.StdCall.GetDirectBufferCapacity>(functions.GetDirectBufferCapacity, ref getDirectBufferCapacity, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetFieldID, JNIDelegates.StdCall.GetFieldID>(functions.GetFieldID, ref getFieldID, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetJavaVM, JNIDelegates.StdCall.GetJavaVM>(functions.GetJavaVM, ref getJavaVM, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetMethodID, JNIDelegates.StdCall.GetMethodID>(functions.GetMethodID, ref getMethodID, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetObjectClass, JNIDelegates.StdCall.GetObjectClass>(functions.GetObjectClass, ref getObjectClass, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticFieldID, JNIDelegates.StdCall.GetStaticFieldID>(functions.GetStaticFieldID, ref getStaticFieldID, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStaticMethodID, JNIDelegates.StdCall.GetStaticMethodID>(functions.GetStaticMethodID, ref getStaticMethodID, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStringChars, JNIDelegates.StdCall.GetStringChars>(functions.GetStringChars, ref getStringChars, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetVersion, JNIDelegates.StdCall.GetVersion>(functions.GetVersion, ref getVersion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.IsSameObject, JNIDelegates.StdCall.IsSameObject>(functions.IsSameObject, ref isSameObject, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewDirectByteBuffer, JNIDelegates.StdCall.NewDirectByteBuffer>(functions.NewDirectByteBuffer, ref newDirectByteBuffer, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewGlobalRef, JNIDelegates.StdCall.NewGlobalRef>(functions.NewGlobalRef, ref newGlobalRef, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewLocalRef, JNIDelegates.StdCall.NewLocalRef>(functions.NewLocalRef, ref newLocalRef, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewString, JNIDelegates.StdCall.NewString>(functions.NewString, ref newString, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.PopLocalFrame, JNIDelegates.StdCall.PopLocalFrame>(functions.PopLocalFrame, ref popLocalFrame, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.PushLocalFrame, JNIDelegates.StdCall.PushLocalFrame>(functions.PushLocalFrame, ref pushLocalFrame, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.RegisterNatives, JNIDelegates.StdCall.RegisterNatives>(functions.RegisterNatives, ref registerNatives, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.UnregisterNatives, JNIDelegates.StdCall.UnregisterNatives>(functions.UnregisterNatives, ref unregisterNatives, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseStringChars, JNIDelegates.StdCall.ReleaseStringChars>(functions.ReleaseStringChars, ref releaseStringChars, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ToReflectedField, JNIDelegates.StdCall.ToReflectedField>(functions.ToReflectedField, ref toReflectedField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ToReflectedMethod, JNIDelegates.StdCall.ToReflectedMethod>(functions.ToReflectedMethod, ref toReflectedMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.FromReflectedMethod, JNIDelegates.StdCall.FromReflectedMethod>(functions.FromReflectedMethod, ref fromReflectedMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.FromReflectedField, JNIDelegates.StdCall.FromReflectedField>(functions.FromReflectedField, ref fromReflectedField, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetArrayLength, JNIDelegates.StdCall.GetArrayLength>(functions.GetArrayLength, ref getArrayLength, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetObjectArrayElement, JNIDelegates.StdCall.GetObjectArrayElement>(functions.GetObjectArrayElement, ref getObjectArrayElement, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewBooleanArray, JNIDelegates.StdCall.NewBooleanArray>(functions.NewBooleanArray, ref newBooleanArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewByteArray, JNIDelegates.StdCall.NewByteArray>(functions.NewByteArray, ref newByteArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewCharArray, JNIDelegates.StdCall.NewCharArray>(functions.NewCharArray, ref newCharArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewDoubleArray, JNIDelegates.StdCall.NewDoubleArray>(functions.NewDoubleArray, ref newDoubleArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewFloatArray, JNIDelegates.StdCall.NewFloatArray>(functions.NewFloatArray, ref newFloatArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewIntArray, JNIDelegates.StdCall.NewIntArray>(functions.NewIntArray, ref newIntArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewLongArray, JNIDelegates.StdCall.NewLongArray>(functions.NewLongArray, ref newLongArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewObjectArray, JNIDelegates.StdCall.NewObjectArray>(functions.NewObjectArray, ref newObjectArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewShortArray, JNIDelegates.StdCall.NewShortArray>(functions.NewShortArray, ref newShortArray, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetObjectArrayElement, JNIDelegates.StdCall.SetObjectArrayElement>(functions.SetObjectArrayElement, ref setObjectArrayElement, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.AllocObject, JNIDelegates.StdCall.AllocObject>(functions.AllocObject, ref allocObject, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewObject, JNIDelegates.StdCall.NewObject>(functions.NewObject, ref newObject, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.Throw, JNIDelegates.StdCall.Throw>(functions.Throw, ref @throw, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ThrowNew, JNIDelegates.StdCall.ThrowNew>(functions.ThrowNew, ref throwNew, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ExceptionOccurred, JNIDelegates.StdCall.ExceptionOccurred>(functions.ExceptionOccurred, ref exceptionOccurred, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ExceptionDescribe, JNIDelegates.StdCall.ExceptionDescribe>(functions.ExceptionDescribe, ref exceptionDescribe, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ExceptionClear, JNIDelegates.StdCall.ExceptionClear>(functions.ExceptionClear, ref exceptionClear, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.FatalError, JNIDelegates.StdCall.FatalError>(functions.FatalError, ref fatalError, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.DefineClass, JNIDelegates.StdCall.DefineClass>(functions.DefineClass, ref defineClass, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.MonitorEnter, JNIDelegates.StdCall.MonitorEnter>(functions.MonitorEnter, ref monitorEnter, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.MonitorExit, JNIDelegates.StdCall.MonitorExit>(functions.MonitorExit, ref monitorExit, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStringRegion, JNIDelegates.StdCall.GetStringRegion>(functions.GetStringRegion, ref getStringRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStringUTFRegion, JNIDelegates.StdCall.GetStringUTFRegion>(functions.GetStringUTFRegion, ref getStringUTFRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetPrimitiveArrayCritical, JNIDelegates.StdCall.GetPrimitiveArrayCritical>(functions.GetPrimitiveArrayCritical, ref getPrimitiveArrayCritical, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleasePrimitiveArrayCritical, JNIDelegates.StdCall.ReleasePrimitiveArrayCritical>(functions.ReleasePrimitiveArrayCritical, ref releasePrimitiveArrayCritical, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStringCritical, JNIDelegates.StdCall.GetStringCritical>(functions.GetStringCritical, ref getStringCritical, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseStringCritical, JNIDelegates.StdCall.ReleaseStringCritical>(functions.ReleaseStringCritical, ref releaseStringCritical, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewWeakGlobalRef, JNIDelegates.StdCall.NewWeakGlobalRef>(functions.NewWeakGlobalRef, ref newWeakGlobalRef, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.DeleteWeakGlobalRef, JNIDelegates.StdCall.DeleteWeakGlobalRef>(functions.DeleteWeakGlobalRef, ref deleteWeakGlobalRef, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualObjectMethod, JNIDelegates.StdCall.CallNonvirtualObjectMethod>(functions.CallNonvirtualObjectMethod, ref callNonvirtualObjectMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualBooleanMethod, JNIDelegates.StdCall.CallNonvirtualBooleanMethod>(functions.CallNonvirtualBooleanMethod, ref callNonvirtualBooleanMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualByteMethod, JNIDelegates.StdCall.CallNonvirtualByteMethod>(functions.CallNonvirtualByteMethod, ref callNonvirtualByteMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualCharMethod, JNIDelegates.StdCall.CallNonvirtualCharMethod>(functions.CallNonvirtualCharMethod, ref callNonvirtualCharMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualShortMethod, JNIDelegates.StdCall.CallNonvirtualShortMethod>(functions.CallNonvirtualShortMethod, ref callNonvirtualShortMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualIntMethod, JNIDelegates.StdCall.CallNonvirtualIntMethod>(functions.CallNonvirtualIntMethod, ref callNonvirtualIntMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualLongMethod, JNIDelegates.StdCall.CallNonvirtualLongMethod>(functions.CallNonvirtualLongMethod, ref callNonvirtualLongMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualFloatMethod, JNIDelegates.StdCall.CallNonvirtualFloatMethod>(functions.CallNonvirtualFloatMethod, ref callNonvirtualFloatMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualDoubleMethod, JNIDelegates.StdCall.CallNonvirtualDoubleMethod>(functions.CallNonvirtualDoubleMethod, ref callNonvirtualDoubleMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.CallNonvirtualVoidMethod, JNIDelegates.StdCall.CallNonvirtualVoidMethod>(functions.CallNonvirtualVoidMethod, ref callNonvirtualVoidMethod, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStringLength, JNIDelegates.StdCall.GetStringLength>(functions.GetStringLength, ref getStringLength, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.NewStringUTF, JNIDelegates.StdCall.NewStringUTF>(functions.NewStringUTF, ref newStringUTF, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStringUTFLength, JNIDelegates.StdCall.GetStringUTFLength>(functions.GetStringUTFLength, ref getStringUTFLength, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetStringUTFChars, JNIDelegates.StdCall.GetStringUTFChars>(functions.GetStringUTFChars, ref getStringUTFChars, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseStringUTFChars, JNIDelegates.StdCall.ReleaseStringUTFChars>(functions.ReleaseStringUTFChars, ref releaseStringUTFChars, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetBooleanArrayElements, JNIDelegates.StdCall.GetBooleanArrayElements>(functions.GetBooleanArrayElements, ref getBooleanArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetByteArrayElements, JNIDelegates.StdCall.GetByteArrayElements>(functions.GetByteArrayElements, ref getByteArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetCharArrayElements, JNIDelegates.StdCall.GetCharArrayElements>(functions.GetCharArrayElements, ref getCharArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetShortArrayElements, JNIDelegates.StdCall.GetShortArrayElements>(functions.GetShortArrayElements, ref getShortArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetIntArrayElements, JNIDelegates.StdCall.GetIntArrayElements>(functions.GetIntArrayElements, ref getIntArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetLongArrayElements, JNIDelegates.StdCall.GetLongArrayElements>(functions.GetLongArrayElements, ref getLongArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetFloatArrayElements, JNIDelegates.StdCall.GetFloatArrayElements>(functions.GetFloatArrayElements, ref getFloatArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetDoubleArrayElements, JNIDelegates.StdCall.GetDoubleArrayElements>(functions.GetDoubleArrayElements, ref getDoubleArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseBooleanArrayElements, JNIDelegates.StdCall.ReleaseBooleanArrayElements>(functions.ReleaseBooleanArrayElements, ref releaseBooleanArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseByteArrayElements, JNIDelegates.StdCall.ReleaseByteArrayElements>(functions.ReleaseByteArrayElements, ref releaseByteArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseCharArrayElements, JNIDelegates.StdCall.ReleaseCharArrayElements>(functions.ReleaseCharArrayElements, ref releaseCharArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseShortArrayElements, JNIDelegates.StdCall.ReleaseShortArrayElements>(functions.ReleaseShortArrayElements, ref releaseShortArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseIntArrayElements, JNIDelegates.StdCall.ReleaseIntArrayElements>(functions.ReleaseIntArrayElements, ref releaseIntArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseLongArrayElements, JNIDelegates.StdCall.ReleaseLongArrayElements>(functions.ReleaseLongArrayElements, ref releaseLongArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseFloatArrayElements, JNIDelegates.StdCall.ReleaseFloatArrayElements>(functions.ReleaseFloatArrayElements, ref releaseFloatArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.ReleaseDoubleArrayElements, JNIDelegates.StdCall.ReleaseDoubleArrayElements>(functions.ReleaseDoubleArrayElements, ref releaseDoubleArrayElements, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetBooleanArrayRegion, JNIDelegates.StdCall.GetBooleanArrayRegion>(functions.GetBooleanArrayRegion, ref getBooleanArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetByteArrayRegion, JNIDelegates.StdCall.GetByteArrayRegion>(functions.GetByteArrayRegion, ref getByteArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetCharArrayRegion, JNIDelegates.StdCall.GetCharArrayRegion>(functions.GetCharArrayRegion, ref getCharArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetShortArrayRegion, JNIDelegates.StdCall.GetShortArrayRegion>(functions.GetShortArrayRegion, ref getShortArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetIntArrayRegion, JNIDelegates.StdCall.GetIntArrayRegion>(functions.GetIntArrayRegion, ref getIntArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetLongArrayRegion, JNIDelegates.StdCall.GetLongArrayRegion>(functions.GetLongArrayRegion, ref getLongArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetFloatArrayRegion, JNIDelegates.StdCall.GetFloatArrayRegion>(functions.GetFloatArrayRegion, ref getFloatArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.GetDoubleArrayRegion, JNIDelegates.StdCall.GetDoubleArrayRegion>(functions.GetDoubleArrayRegion, ref getDoubleArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetBooleanArrayRegion, JNIDelegates.StdCall.SetBooleanArrayRegion>(functions.SetBooleanArrayRegion, ref setBooleanArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetByteArrayRegion, JNIDelegates.StdCall.SetByteArrayRegion>(functions.SetByteArrayRegion, ref setByteArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetCharArrayRegion, JNIDelegates.StdCall.SetCharArrayRegion>(functions.SetCharArrayRegion, ref setCharArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetShortArrayRegion, JNIDelegates.StdCall.SetShortArrayRegion>(functions.SetShortArrayRegion, ref setShortArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetIntArrayRegion, JNIDelegates.StdCall.SetIntArrayRegion>(functions.SetIntArrayRegion, ref setIntArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetLongArrayRegion, JNIDelegates.StdCall.SetLongArrayRegion>(functions.SetLongArrayRegion, ref setLongArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetFloatArrayRegion, JNIDelegates.StdCall.SetFloatArrayRegion>(functions.SetFloatArrayRegion, ref setFloatArrayRegion, IsStdCall);
                    Delegates.GetDelegateForFunctionPointer<JNIDelegates.Cdecl.SetDoubleArrayRegion, JNIDelegates.StdCall.SetDoubleArrayRegion>(functions.SetDoubleArrayRegion, ref setDoubleArrayRegion, IsStdCall);

                    initialized = true;
                }
            }
        }
    }
}
