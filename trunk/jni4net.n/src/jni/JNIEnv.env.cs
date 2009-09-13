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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace net.sf.jni4net.jni
{
    unsafe partial class JNIEnv
    {
        private static JavaVM defaultVM;
        [ThreadStatic] private static JNIEnv threadJNIEnv;

        private readonly IntPtr native;
        private JNINativeInterface functions;
        private JavaVM javaVM;

        internal JNIEnv(IntPtr native)
        {
            this.native = native;
            functions = *(*(JavaPtr*) native.ToPointer()).functions;
            InitMethods();
            if (defaultVM == null)
            {
                defaultVM = GetJavaVM();
            }
        }

        public static JNIEnv ThreadEnv
        {
            get
            {
                if (threadJNIEnv == null)
                {
                    if (defaultVM == null)
                    {
                        throw new JNIException(
                            "AttachCurrentThreadAsDaemon failed: Java VM is not attached, call JNI.CreateJavaVM() first");
                    }
                    JNIResult result = defaultVM.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                    if (result != JNIResult.JNI_OK)
                    {
                        throw new JNIException("AttachCurrentThreadAsDaemon failed: " + result);
                    }
                }
                return threadJNIEnv;
            }
        }

        public static JNIEnv GetEnvForVm(JavaVM vm)
        {
            if (threadJNIEnv == null)
            {
                JNIResult result = vm.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                if (result != JNIResult.JNI_OK)
                {
                    throw new JNIException("AttachCurrentThreadAsDaemon failed: " + result);
                }
            }
            return threadJNIEnv;
        }

        public static JNIEnv GetEnvNoThrow(JavaVM vm)
        {
            if (threadJNIEnv == null)
            {
                JNIResult result = vm.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                if (result != JNIResult.JNI_OK)
                {
                    return null;
                }
            }
            return threadJNIEnv;
        }

        public static JNIEnv Wrap(IntPtr envi)
        {
            if (envi == IntPtr.Zero)
            {
                return null;
            }
            if (threadJNIEnv != null && envi == threadJNIEnv.native)
            {
                return threadJNIEnv;
            }
            return new JNIEnv(envi);
        }

        #region Nested type: JavaPtr

        [StructLayout(LayoutKind.Sequential, Size = 4), NativeCppClass]
        private struct JavaPtr
        {
            public JNINativeInterface* functions;
        }

        #endregion

        #region Nested type: JNINativeInterface

        [StructLayout(LayoutKind.Sequential), NativeCppClass]
        public struct JNINativeInterface
        {
            public IntPtr reserved0;
            public IntPtr reserved1;
            public IntPtr reserved2;
            public IntPtr reserved3;
            public IntPtr GetVersion;
            public IntPtr DefineClass;
            public IntPtr FindClass;
            public IntPtr FromReflectedMethod;
            public IntPtr FromReflectedField;
            public IntPtr ToReflectedMethod;
            public IntPtr GetSuperclass;
            public IntPtr IsAssignableFrom;
            public IntPtr ToReflectedField;
            public IntPtr Throw;
            public IntPtr ThrowNew;
            public IntPtr ExceptionOccurred;
            public IntPtr ExceptionDescribe;
            public IntPtr ExceptionClear;
            public IntPtr FatalError;
            public IntPtr PushLocalFrame;
            public IntPtr PopLocalFrame;
            public IntPtr NewGlobalRef;
            public IntPtr DeleteGlobalRef;
            public IntPtr DeleteLocalRef;
            public IntPtr IsSameObject;
            public IntPtr NewLocalRef;
            public IntPtr EnsureLocalCapacity;
            public IntPtr AllocObject;
            public IntPtr __NewObject;
            public IntPtr __NewObjectV;
            public IntPtr NewObject;
            public IntPtr GetObjectClass;
            public IntPtr IsInstanceOf;
            public IntPtr GetMethodID;
            public IntPtr __CallObjectMethod;
            public IntPtr __CallObjectMethodV;
            public IntPtr CallObjectMethod;
            public IntPtr __CallBooleanMethod;
            public IntPtr __CallBooleanMethodV;
            public IntPtr CallBooleanMethod;
            public IntPtr __CallByteMethod;
            public IntPtr __CallByteMethodV;
            public IntPtr CallByteMethod;
            public IntPtr __CallCharMethod;
            public IntPtr __CallCharMethodV;
            public IntPtr CallCharMethod;
            public IntPtr __CallShortMethod;
            public IntPtr __CallShortMethodV;
            public IntPtr CallShortMethod;
            public IntPtr __CallIntMethod;
            public IntPtr __CallIntMethodV;
            public IntPtr CallIntMethod;
            public IntPtr __CallLongMethod;
            public IntPtr __CallLongMethodV;
            public IntPtr CallLongMethod;
            public IntPtr __CallFloatMethod;
            public IntPtr __CallFloatMethodV;
            public IntPtr CallFloatMethod;
            public IntPtr __CallDoubleMethod;
            public IntPtr __CallDoubleMethodV;
            public IntPtr CallDoubleMethod;
            public IntPtr __CallVoidMethod;
            public IntPtr __CallVoidMethodV;
            public IntPtr CallVoidMethod;
            public IntPtr __CallNonvirtualObjectMethod;
            public IntPtr __CallNonvirtualObjectMethodV;
            public IntPtr CallNonvirtualObjectMethod;
            public IntPtr __CallNonvirtualBooleanMethod;
            public IntPtr __CallNonvirtualBooleanMethodV;
            public IntPtr CallNonvirtualBooleanMethod;
            public IntPtr __CallNonvirtualByteMethod;
            public IntPtr __CallNonvirtualByteMethodV;
            public IntPtr CallNonvirtualByteMethod;
            public IntPtr __CallNonvirtualCharMethod;
            public IntPtr __CallNonvirtualCharMethodV;
            public IntPtr CallNonvirtualCharMethod;
            public IntPtr __CallNonvirtualShortMethod;
            public IntPtr __CallNonvirtualShortMethodV;
            public IntPtr CallNonvirtualShortMethod;
            public IntPtr __CallNonvirtualIntMethod;
            public IntPtr __CallNonvirtualIntMethodV;
            public IntPtr CallNonvirtualIntMethod;
            public IntPtr __CallNonvirtualLongMethod;
            public IntPtr __CallNonvirtualLongMethodV;
            public IntPtr CallNonvirtualLongMethod;
            public IntPtr __CallNonvirtualFloatMethod;
            public IntPtr __CallNonvirtualFloatMethodV;
            public IntPtr CallNonvirtualFloatMethod;
            public IntPtr __CallNonvirtualDoubleMethod;
            public IntPtr __CallNonvirtualDoubleMethodV;
            public IntPtr CallNonvirtualDoubleMethod;
            public IntPtr __CallNonvirtualVoidMethod;
            public IntPtr __CallNonvirtualVoidMethodV;
            public IntPtr CallNonvirtualVoidMethod;
            public IntPtr GetFieldID;
            public IntPtr GetObjectField;
            public IntPtr GetBooleanField;
            public IntPtr GetByteField;
            public IntPtr GetCharField;
            public IntPtr GetShortField;
            public IntPtr GetIntField;
            public IntPtr GetLongField;
            public IntPtr GetFloatField;
            public IntPtr GetDoubleField;
            public IntPtr SetObjectField;
            public IntPtr SetBooleanField;
            public IntPtr SetByteField;
            public IntPtr SetCharField;
            public IntPtr SetShortField;
            public IntPtr SetIntField;
            public IntPtr SetLongField;
            public IntPtr SetFloatField;
            public IntPtr SetDoubleField;
            public IntPtr GetStaticMethodID;
            public IntPtr __CallStaticObjectMethod;
            public IntPtr __CallStaticObjectMethodV;
            public IntPtr CallStaticObjectMethod;
            public IntPtr __CallStaticBooleanMethod;
            public IntPtr __CallStaticBooleanMethodV;
            public IntPtr CallStaticBooleanMethod;
            public IntPtr __CallStaticByteMethod;
            public IntPtr __CallStaticByteMethodV;
            public IntPtr CallStaticByteMethod;
            public IntPtr __CallStaticCharMethod;
            public IntPtr __CallStaticCharMethodV;
            public IntPtr CallStaticCharMethod;
            public IntPtr __CallStaticShortMethod;
            public IntPtr __CallStaticShortMethodV;
            public IntPtr CallStaticShortMethod;
            public IntPtr __CallStaticIntMethod;
            public IntPtr __CallStaticIntMethodV;
            public IntPtr CallStaticIntMethod;
            public IntPtr __CallStaticLongMethod;
            public IntPtr __CallStaticLongMethodV;
            public IntPtr CallStaticLongMethod;
            public IntPtr __CallStaticFloatMethod;
            public IntPtr __CallStaticFloatMethodV;
            public IntPtr CallStaticFloatMethod;
            public IntPtr __CallStaticDoubleMethod;
            public IntPtr __CallStaticDoubleMethodV;
            public IntPtr CallStaticDoubleMethod;
            public IntPtr __CallStaticVoidMethod;
            public IntPtr __CallStaticVoidMethodV;
            public IntPtr CallStaticVoidMethod;
            public IntPtr GetStaticFieldID;
            public IntPtr GetStaticObjectField;
            public IntPtr GetStaticBooleanField;
            public IntPtr GetStaticByteField;
            public IntPtr GetStaticCharField;
            public IntPtr GetStaticShortField;
            public IntPtr GetStaticIntField;
            public IntPtr GetStaticLongField;
            public IntPtr GetStaticFloatField;
            public IntPtr GetStaticDoubleField;
            public IntPtr SetStaticObjectField;
            public IntPtr SetStaticBooleanField;
            public IntPtr SetStaticByteField;
            public IntPtr SetStaticCharField;
            public IntPtr SetStaticShortField;
            public IntPtr SetStaticIntField;
            public IntPtr SetStaticLongField;
            public IntPtr SetStaticFloatField;
            public IntPtr SetStaticDoubleField;
            public IntPtr NewString;
            public IntPtr GetStringLength;
            public IntPtr GetStringChars;
            public IntPtr ReleaseStringChars;
            public IntPtr NewStringUTF;
            public IntPtr GetStringUTFLength;
            public IntPtr GetStringUTFChars;
            public IntPtr ReleaseStringUTFChars;
            public IntPtr GetArrayLength;
            public IntPtr NewObjectArray;
            public IntPtr GetObjectArrayElement;
            public IntPtr SetObjectArrayElement;
            public IntPtr NewBooleanArray;
            public IntPtr NewByteArray;
            public IntPtr NewCharArray;
            public IntPtr NewShortArray;
            public IntPtr NewIntArray;
            public IntPtr NewLongArray;
            public IntPtr NewFloatArray;
            public IntPtr NewDoubleArray;
            public IntPtr GetBooleanArrayElements;
            public IntPtr GetByteArrayElements;
            public IntPtr GetCharArrayElements;
            public IntPtr GetShortArrayElements;
            public IntPtr GetIntArrayElements;
            public IntPtr GetLongArrayElements;
            public IntPtr GetFloatArrayElements;
            public IntPtr GetDoubleArrayElements;
            public IntPtr ReleaseBooleanArrayElements;
            public IntPtr ReleaseByteArrayElements;
            public IntPtr ReleaseCharArrayElements;
            public IntPtr ReleaseShortArrayElements;
            public IntPtr ReleaseIntArrayElements;
            public IntPtr ReleaseLongArrayElements;
            public IntPtr ReleaseFloatArrayElements;
            public IntPtr ReleaseDoubleArrayElements;
            public IntPtr GetBooleanArrayRegion;
            public IntPtr GetByteArrayRegion;
            public IntPtr GetCharArrayRegion;
            public IntPtr GetShortArrayRegion;
            public IntPtr GetIntArrayRegion;
            public IntPtr GetLongArrayRegion;
            public IntPtr GetFloatArrayRegion;
            public IntPtr GetDoubleArrayRegion;
            public IntPtr SetBooleanArrayRegion;
            public IntPtr SetByteArrayRegion;
            public IntPtr SetCharArrayRegion;
            public IntPtr SetShortArrayRegion;
            public IntPtr SetIntArrayRegion;
            public IntPtr SetLongArrayRegion;
            public IntPtr SetFloatArrayRegion;
            public IntPtr SetDoubleArrayRegion;
            public IntPtr RegisterNatives;
            public IntPtr UnregisterNatives;
            public IntPtr MonitorEnter;
            public IntPtr MonitorExit;
            public IntPtr GetJavaVM;
            public IntPtr GetStringRegion;
            public IntPtr GetStringUTFRegion;
            public IntPtr GetPrimitiveArrayCritical;
            public IntPtr ReleasePrimitiveArrayCritical;
            public IntPtr GetStringCritical;
            public IntPtr ReleaseStringCritical;
            public IntPtr NewWeakGlobalRef;
            public IntPtr DeleteWeakGlobalRef;
            public IntPtr ExceptionCheck;
            public IntPtr NewDirectByteBuffer;
            public IntPtr GetDirectBufferAddress;
            public IntPtr GetDirectBufferCapacity;
        }

        #endregion
    }
}