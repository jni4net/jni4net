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

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        private Delegates.AllocObject allocObject;
        private Delegates.CallBooleanMethod callBooleanMethod;
        private Delegates.CallByteMethod callByteMethod;
        private Delegates.CallCharMethod callCharMethod;
        private Delegates.CallDoubleMethod callDoubleMethod;
        private Delegates.CallFloatMethod callFloatMethod;
        private Delegates.CallIntMethod callIntMethod;
        private Delegates.CallLongMethod callLongMethod;
        private Delegates.CallNonvirtualBooleanMethod callNonvirtualBooleanMethod;
        private Delegates.CallNonvirtualByteMethod callNonvirtualByteMethod;
        private Delegates.CallNonvirtualCharMethod callNonvirtualCharMethod;
        private Delegates.CallNonvirtualDoubleMethod callNonvirtualDoubleMethod;
        private Delegates.CallNonvirtualFloatMethod callNonvirtualFloatMethod;
        private Delegates.CallNonvirtualIntMethod callNonvirtualIntMethod;
        private Delegates.CallNonvirtualLongMethod callNonvirtualLongMethod;
        private Delegates.CallNonvirtualObjectMethod callNonvirtualObjectMethod;
        private Delegates.CallNonvirtualShortMethod callNonvirtualShortMethod;
        private Delegates.CallNonvirtualVoidMethod callNonvirtualVoidMethod;
        private Delegates.CallObjectMethod callObjectMethod;
        private Delegates.CallShortMethod callShortMethod;
        private Delegates.CallStaticBooleanMethod callStaticBooleanMethod;
        private Delegates.CallStaticByteMethod callStaticByteMethod;
        private Delegates.CallStaticCharMethod callStaticCharMethod;
        private Delegates.CallStaticDoubleMethod callStaticDoubleMethod;
        private Delegates.CallStaticFloatMethod callStaticFloatMethod;
        private Delegates.CallStaticIntMethod callStaticIntMethod;
        private Delegates.CallStaticLongMethod callStaticLongMethod;
        private Delegates.CallStaticObjectMethod callStaticObjectMethod;
        private Delegates.CallStaticShortMethod callStaticShortMethod;
        private Delegates.CallStaticVoidMethod callStaticVoidMethod;
        private Delegates.CallVoidMethod callVoidMethod;
        private Delegates.DefineClass defineClass;
        private Delegates.DeleteGlobalRef deleteGlobalRef;
        private Delegates.DeleteLocalRef deleteLocalRef;
        private Delegates.DeleteWeakGlobalRef deleteWeakGlobalRef;
        private Delegates.EnsureLocalCapacity ensureLocalCapacity;
        private Delegates.ExceptionCheck exceptionCheck;
        private Delegates.ExceptionClear exceptionClear;
        private Delegates.ExceptionDescribe exceptionDescribe;
        private Delegates.ExceptionOccurred exceptionOccurred;
        private Delegates.FatalError fatalError;
        private Delegates.FindClass findClass;
        private Delegates.FromReflectedField fromReflectedField;
        private Delegates.FromReflectedMethod fromReflectedMethod;
        private Delegates.GetArrayLength getArrayLength;
        private Delegates.GetBooleanArrayElements getBooleanArrayElements;
        private Delegates.GetBooleanArrayRegion getBooleanArrayRegion;
        private Delegates.GetBooleanField getBooleanField;
        private Delegates.GetByteArrayElements getByteArrayElements;
        private Delegates.GetByteArrayRegion getByteArrayRegion;
        private Delegates.GetByteField getByteField;
        private Delegates.GetCharArrayElements getCharArrayElements;
        private Delegates.GetCharArrayRegion getCharArrayRegion;
        private Delegates.GetCharField getCharField;
        private Delegates.GetDirectBufferAddress getDirectBufferAddress;
        private Delegates.GetDirectBufferCapacity getDirectBufferCapacity;
        private Delegates.GetDoubleArrayElements getDoubleArrayElements;
        private Delegates.GetDoubleArrayRegion getDoubleArrayRegion;
        private Delegates.GetDoubleField getDoubleField;
        private Delegates.GetFieldID getFieldID;
        private Delegates.GetFloatArrayElements getFloatArrayElements;
        private Delegates.GetFloatArrayRegion getFloatArrayRegion;
        private Delegates.GetFloatField getFloatField;
        private Delegates.GetIntArrayElements getIntArrayElements;
        private Delegates.GetIntArrayRegion getIntArrayRegion;
        private Delegates.GetIntField getIntField;
        private Delegates.GetJavaVM getJavaVM;
        private Delegates.GetLongArrayElements getLongArrayElements;
        private Delegates.GetLongArrayRegion getLongArrayRegion;
        private Delegates.GetLongField getLongField;
        private Delegates.GetMethodID getMethodID;
        private Delegates.GetObjectArrayElement getObjectArrayElement;
        private Delegates.GetObjectClass getObjectClass;
        private Delegates.GetObjectField getObjectField;
        private Delegates.GetPrimitiveArrayCritical getPrimitiveArrayCritical;
        private Delegates.GetShortArrayElements getShortArrayElements;
        private Delegates.GetShortArrayRegion getShortArrayRegion;
        private Delegates.GetShortField getShortField;
        private Delegates.GetStaticBooleanField getStaticBooleanField;
        private Delegates.GetStaticByteField getStaticByteField;
        private Delegates.GetStaticCharField getStaticCharField;
        private Delegates.GetStaticDoubleField getStaticDoubleField;
        private Delegates.GetStaticFieldID getStaticFieldID;
        private Delegates.GetStaticFloatField getStaticFloatField;
        private Delegates.GetStaticIntField getStaticIntField;
        private Delegates.GetStaticLongField getStaticLongField;
        private Delegates.GetStaticMethodID getStaticMethodID;
        private Delegates.GetStaticObjectField getStaticObjectField;
        private Delegates.GetStaticShortField getStaticShortField;
        private Delegates.GetStringChars getStringChars;
        private Delegates.GetStringCritical getStringCritical;
        private Delegates.GetStringLength getStringLength;
        private Delegates.GetStringRegion getStringRegion;
        private Delegates.GetStringUTFChars getStringUTFChars;
        private Delegates.GetStringUTFLength getStringUTFLength;
        private Delegates.GetStringUTFRegion getStringUTFRegion;
        private Delegates.GetVersion getVersion;
        private Delegates.IsSameObject isSameObject;
        private Delegates.MonitorEnter monitorEnter;
        private Delegates.MonitorExit monitorExit;
        private Delegates.NewBooleanArray newBooleanArray;
        private Delegates.NewByteArray newByteArray;
        private Delegates.NewCharArray newCharArray;
        private Delegates.NewDirectByteBuffer newDirectByteBuffer;
        private Delegates.NewDoubleArray newDoubleArray;
        private Delegates.NewFloatArray newFloatArray;
        private Delegates.NewGlobalRef newGlobalRef;
        private Delegates.NewIntArray newIntArray;
        private Delegates.NewLocalRef newLocalRef;
        private Delegates.NewLongArray newLongArray;
        private Delegates.NewObject newObject;
        private Delegates.NewObjectArray newObjectArray;
        private Delegates.NewShortArray newShortArray;
        private Delegates.NewString newString;
        private Delegates.NewStringUTF newStringUTF;
        private Delegates.NewWeakGlobalRef newWeakGlobalRef;
        private Delegates.PopLocalFrame popLocalFrame;
        private Delegates.PushLocalFrame pushLocalFrame;
        private Delegates.RegisterNatives registerNatives;
        private Delegates.UnregisterNatives unregisterNatives;
        private Delegates.ReleaseBooleanArrayElements releaseBooleanArrayElements;
        private Delegates.ReleaseByteArrayElements releaseByteArrayElements;
        private Delegates.ReleaseCharArrayElements releaseCharArrayElements;
        private Delegates.ReleaseDoubleArrayElements releaseDoubleArrayElements;
        private Delegates.ReleaseFloatArrayElements releaseFloatArrayElements;
        private Delegates.ReleaseIntArrayElements releaseIntArrayElements;
        private Delegates.ReleaseLongArrayElements releaseLongArrayElements;
        private Delegates.ReleasePrimitiveArrayCritical releasePrimitiveArrayCritical;
        private Delegates.ReleaseShortArrayElements releaseShortArrayElements;
        private Delegates.ReleaseStringChars releaseStringChars;
        private Delegates.ReleaseStringCritical releaseStringCritical;
        private Delegates.ReleaseStringUTFChars releaseStringUTFChars;
        private Delegates.SetBooleanArrayRegion setBooleanArrayRegion;
        private Delegates.SetBooleanField setBooleanField;
        private Delegates.SetByteArrayRegion setByteArrayRegion;
        private Delegates.SetByteField setByteField;
        private Delegates.SetCharArrayRegion setCharArrayRegion;
        private Delegates.SetCharField setCharField;
        private Delegates.SetDoubleArrayRegion setDoubleArrayRegion;
        private Delegates.SetDoubleField setDoubleField;
        private Delegates.SetFloatArrayRegion setFloatArrayRegion;
        private Delegates.SetFloatField setFloatField;
        private Delegates.SetIntArrayRegion setIntArrayRegion;
        private Delegates.SetIntField setIntField;
        private Delegates.SetLongArrayRegion setLongArrayRegion;
        private Delegates.SetLongField setLongField;
        private Delegates.SetObjectArrayElement setObjectArrayElement;
        private Delegates.SetObjectField setObjectField;
        private Delegates.SetShortArrayRegion setShortArrayRegion;
        private Delegates.SetShortField setShortField;
        private Delegates.SetStaticBooleanField setStaticBooleanField;
        private Delegates.SetStaticByteField setStaticByteField;
        private Delegates.SetStaticCharField setStaticCharField;
        private Delegates.SetStaticDoubleField setStaticDoubleField;
        private Delegates.SetStaticFloatField setStaticFloatField;
        private Delegates.SetStaticIntField setStaticIntField;
        private Delegates.SetStaticLongField setStaticLongField;
        private Delegates.SetStaticObjectField setStaticObjectField;
        private Delegates.SetStaticShortField setStaticShortField;
        private Delegates.Throw @throw;
        private Delegates.ThrowNew throwNew;
        private Delegates.ToReflectedField toReflectedField;
        private Delegates.ToReflectedMethod toReflectedMethod;

        internal unsafe void InitMethods()
        {
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallBooleanMethod, ref callBooleanMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallByteMethod, ref callByteMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallCharMethod, ref callCharMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallDoubleMethod, ref callDoubleMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallFloatMethod, ref callFloatMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallIntMethod, ref callIntMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallLongMethod, ref callLongMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallObjectMethod, ref callObjectMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallShortMethod, ref callShortMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallVoidMethod, ref callVoidMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticBooleanMethod, ref callStaticBooleanMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticByteMethod, ref callStaticByteMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticCharMethod, ref callStaticCharMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticDoubleMethod, ref callStaticDoubleMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticFloatMethod, ref callStaticFloatMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticIntMethod, ref callStaticIntMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticLongMethod, ref callStaticLongMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticObjectMethod, ref callStaticObjectMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticShortMethod, ref callStaticShortMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallStaticVoidMethod, ref callStaticVoidMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticObjectField, ref getStaticObjectField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticBooleanField, ref getStaticBooleanField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticByteField, ref getStaticByteField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticCharField, ref getStaticCharField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticShortField, ref getStaticShortField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticIntField, ref getStaticIntField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticLongField, ref getStaticLongField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticFloatField, ref getStaticFloatField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticDoubleField, ref getStaticDoubleField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticObjectField, ref setStaticObjectField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticBooleanField, ref setStaticBooleanField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticByteField, ref setStaticByteField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticCharField, ref setStaticCharField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticShortField, ref setStaticShortField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticIntField, ref setStaticIntField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticLongField, ref setStaticLongField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticFloatField, ref setStaticFloatField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetStaticDoubleField, ref setStaticDoubleField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetObjectField, ref getObjectField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetBooleanField, ref getBooleanField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetByteField, ref getByteField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetCharField, ref getCharField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetShortField, ref getShortField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetIntField, ref getIntField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetLongField, ref getLongField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetFloatField, ref getFloatField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetDoubleField, ref getDoubleField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetObjectField, ref setObjectField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetBooleanField, ref setBooleanField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetByteField, ref setByteField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetCharField, ref setCharField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetShortField, ref setShortField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetIntField, ref setIntField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetLongField, ref setLongField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetFloatField, ref setFloatField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetDoubleField, ref setDoubleField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.DeleteGlobalRef, ref deleteGlobalRef);
            MethodWrapper.GetDelegateForFunctionPointer(functions.DeleteLocalRef, ref deleteLocalRef);
            MethodWrapper.GetDelegateForFunctionPointer(functions.EnsureLocalCapacity, ref ensureLocalCapacity);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ExceptionCheck, ref exceptionCheck);
            MethodWrapper.GetDelegateForFunctionPointer(functions.FindClass, ref findClass);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetDirectBufferAddress, ref getDirectBufferAddress);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetDirectBufferCapacity, ref getDirectBufferCapacity);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetFieldID, ref getFieldID);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetJavaVM, ref getJavaVM);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetMethodID, ref getMethodID);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetObjectClass, ref getObjectClass);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticFieldID, ref getStaticFieldID);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStaticMethodID, ref getStaticMethodID);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStringChars, ref getStringChars);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetVersion, ref getVersion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.IsSameObject, ref isSameObject);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewDirectByteBuffer, ref newDirectByteBuffer);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewGlobalRef, ref newGlobalRef);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewLocalRef, ref newLocalRef);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewString, ref newString);
            MethodWrapper.GetDelegateForFunctionPointer(functions.PopLocalFrame, ref popLocalFrame);
            MethodWrapper.GetDelegateForFunctionPointer(functions.PushLocalFrame, ref pushLocalFrame);
            MethodWrapper.GetDelegateForFunctionPointer(functions.RegisterNatives, ref registerNatives);
            MethodWrapper.GetDelegateForFunctionPointer(functions.UnregisterNatives, ref unregisterNatives);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseStringChars, ref releaseStringChars);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ToReflectedField, ref toReflectedField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ToReflectedMethod, ref toReflectedMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.FromReflectedMethod, ref fromReflectedMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.FromReflectedField, ref fromReflectedField);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetArrayLength, ref getArrayLength);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetObjectArrayElement, ref getObjectArrayElement);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewBooleanArray, ref newBooleanArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewByteArray, ref newByteArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewCharArray, ref newCharArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewDoubleArray, ref newDoubleArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewFloatArray, ref newFloatArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewIntArray, ref newIntArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewLongArray, ref newLongArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewObjectArray, ref newObjectArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewShortArray, ref newShortArray);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetObjectArrayElement, ref setObjectArrayElement);
            MethodWrapper.GetDelegateForFunctionPointer(functions.AllocObject, ref allocObject);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewObject, ref newObject);
            MethodWrapper.GetDelegateForFunctionPointer(functions.Throw, ref @throw);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ThrowNew, ref throwNew);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ExceptionOccurred, ref exceptionOccurred);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ExceptionDescribe, ref exceptionDescribe);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ExceptionClear, ref exceptionClear);
            MethodWrapper.GetDelegateForFunctionPointer(functions.FatalError, ref fatalError);
            MethodWrapper.GetDelegateForFunctionPointer(functions.DefineClass, ref defineClass);
            MethodWrapper.GetDelegateForFunctionPointer(functions.MonitorEnter, ref monitorEnter);
            MethodWrapper.GetDelegateForFunctionPointer(functions.MonitorExit, ref monitorExit);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStringRegion, ref getStringRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStringUTFRegion, ref getStringUTFRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetPrimitiveArrayCritical,
                                                        ref getPrimitiveArrayCritical);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleasePrimitiveArrayCritical,
                                                        ref releasePrimitiveArrayCritical);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStringCritical, ref getStringCritical);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseStringCritical, ref releaseStringCritical);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewWeakGlobalRef, ref newWeakGlobalRef);
            MethodWrapper.GetDelegateForFunctionPointer(functions.DeleteWeakGlobalRef, ref deleteWeakGlobalRef);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualObjectMethod,
                                                        ref callNonvirtualObjectMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualBooleanMethod,
                                                        ref callNonvirtualBooleanMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualByteMethod, ref callNonvirtualByteMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualCharMethod, ref callNonvirtualCharMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualShortMethod,
                                                        ref callNonvirtualShortMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualIntMethod, ref callNonvirtualIntMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualLongMethod, ref callNonvirtualLongMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualFloatMethod,
                                                        ref callNonvirtualFloatMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualDoubleMethod,
                                                        ref callNonvirtualDoubleMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.CallNonvirtualVoidMethod, ref callNonvirtualVoidMethod);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStringLength, ref getStringLength);
            MethodWrapper.GetDelegateForFunctionPointer(functions.NewStringUTF, ref newStringUTF);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStringUTFLength, ref getStringUTFLength);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetStringUTFChars, ref getStringUTFChars);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseStringUTFChars, ref releaseStringUTFChars);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetBooleanArrayElements, ref getBooleanArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetByteArrayElements, ref getByteArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetCharArrayElements, ref getCharArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetShortArrayElements, ref getShortArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetIntArrayElements, ref getIntArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetLongArrayElements, ref getLongArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetFloatArrayElements, ref getFloatArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetDoubleArrayElements, ref getDoubleArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseBooleanArrayElements,
                                                        ref releaseBooleanArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseByteArrayElements, ref releaseByteArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseCharArrayElements, ref releaseCharArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseShortArrayElements,
                                                        ref releaseShortArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseIntArrayElements, ref releaseIntArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseLongArrayElements, ref releaseLongArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseFloatArrayElements,
                                                        ref releaseFloatArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.ReleaseDoubleArrayElements,
                                                        ref releaseDoubleArrayElements);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetBooleanArrayRegion, ref getBooleanArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetByteArrayRegion, ref getByteArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetCharArrayRegion, ref getCharArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetShortArrayRegion, ref getShortArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetIntArrayRegion, ref getIntArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetLongArrayRegion, ref getLongArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetFloatArrayRegion, ref getFloatArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.GetDoubleArrayRegion, ref getDoubleArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetBooleanArrayRegion, ref setBooleanArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetByteArrayRegion, ref setByteArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetCharArrayRegion, ref setCharArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetShortArrayRegion, ref setShortArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetIntArrayRegion, ref setIntArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetLongArrayRegion, ref setLongArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetFloatArrayRegion, ref setFloatArrayRegion);
            MethodWrapper.GetDelegateForFunctionPointer(functions.SetDoubleArrayRegion, ref setDoubleArrayRegion);
        }
    }
}