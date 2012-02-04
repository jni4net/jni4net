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

namespace net.sf.jni4net.jni
{
    /* TODO
                static public JNIDelegates.Cdecl.GetJavaVM getJavaVM;
                static public JNIDelegates.Cdecl.GetVersion getVersion;

                static public JNIDelegates.Cdecl.MonitorEnter monitorEnter;
                static public JNIDelegates.Cdecl.MonitorExit monitorExit;

                static public JNIDelegates.Cdecl.DefineClass defineClass;
                static public JNIDelegates.Cdecl.DeleteWeakGlobalRef deleteWeakGlobalRef;
                static public JNIDelegates.Cdecl.NewWeakGlobalRef newWeakGlobalRef;
                static public JNIDelegates.Cdecl.EnsureLocalCapacity ensureLocalCapacity;

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

                static public JNIDelegates.Cdecl.GetPrimitiveArrayCritical getPrimitiveArrayCritical;
                static public JNIDelegates.Cdecl.ReleasePrimitiveArrayCritical releasePrimitiveArrayCritical;

                static public JNIDelegates.Cdecl.GetDirectBufferAddress getDirectBufferAddress;
                static public JNIDelegates.Cdecl.GetDirectBufferCapacity getDirectBufferCapacity;
                static public JNIDelegates.Cdecl.NewDirectByteBuffer newDirectByteBuffer;

                static public JNIDelegates.Cdecl.FromReflectedField fromReflectedField;
                static public JNIDelegates.Cdecl.FromReflectedMethod fromReflectedMethod;
                static public JNIDelegates.Cdecl.ToReflectedField toReflectedField;
                static public JNIDelegates.Cdecl.ToReflectedMethod toReflectedMethod;

                static public JNIDelegates.Cdecl.GetStringCritical getStringCritical;
                static public JNIDelegates.Cdecl.GetStringLength getStringLength;
                static public JNIDelegates.Cdecl.GetStringRegion getStringRegion;
                static public JNIDelegates.Cdecl.GetStringUTFChars getStringUTFChars;
                static public JNIDelegates.Cdecl.GetStringUTFLength getStringUTFLength;
                static public JNIDelegates.Cdecl.GetStringUTFRegion getStringUTFRegion;
                static public JNIDelegates.Cdecl.ReleaseStringCritical releaseStringCritical;
                static public JNIDelegates.Cdecl.ReleaseStringUTFChars releaseStringUTFChars;
                static public JNIDelegates.Cdecl.NewStringUTF newStringUTF;

                static public JNIDelegates.Cdecl.ReleaseBooleanArrayElements releaseBooleanArrayElements;
                static public JNIDelegates.Cdecl.ReleaseByteArrayElements releaseByteArrayElements;
                static public JNIDelegates.Cdecl.ReleaseCharArrayElements releaseCharArrayElements;
                static public JNIDelegates.Cdecl.ReleaseDoubleArrayElements releaseDoubleArrayElements;
                static public JNIDelegates.Cdecl.ReleaseFloatArrayElements releaseFloatArrayElements;
                static public JNIDelegates.Cdecl.ReleaseIntArrayElements releaseIntArrayElements;
                static public JNIDelegates.Cdecl.ReleaseLongArrayElements releaseLongArrayElements;
                static public JNIDelegates.Cdecl.ReleaseShortArrayElements releaseShortArrayElements;
                static public JNIDelegates.Cdecl.GetShortArrayElements getShortArrayElements;
                static public JNIDelegates.Cdecl.GetLongArrayElements getLongArrayElements;
                static public JNIDelegates.Cdecl.GetFloatArrayElements getFloatArrayElements;
                static public JNIDelegates.Cdecl.GetIntArrayElements getIntArrayElements;
                static public JNIDelegates.Cdecl.GetBooleanArrayElements getBooleanArrayElements;
                static public JNIDelegates.Cdecl.GetByteArrayElements getByteArrayElements;
                static public JNIDelegates.Cdecl.GetCharArrayElements getCharArrayElements;
                static public JNIDelegates.Cdecl.GetDoubleArrayElements getDoubleArrayElements;

    */

    [SuppressUnmanagedCodeSecurity]
    public partial class JNIEnv
    {
        public IntPtr envPtr;

        [ThreadStatic] internal static JNIEnv threadJNIEnv;
        internal static JNIEnv gcthreadJNIEnv;

        internal static JNIEnv ThreadEnvGC
        {
            [SuppressUnmanagedCodeSecurity]
            get
            {
                if (gcthreadJNIEnv == null && J4NBridge.CurrentJVM!=null)
                {
                    gcthreadJNIEnv=Attach();
                }
                return gcthreadJNIEnv;
            }
        }

        public static JNIEnv ThreadEnv
        {
            [SuppressUnmanagedCodeSecurity]
            get
            {
                if (threadJNIEnv == null)
                {
                    if(J4NBridge.currentSetup.EnforceThreadDetach)
                    {
                        if (J4NBridge.isInitialized)
                        {
                            throw new J4NException("Thread is not attached to JVM.\nPlease wrap any calls to JVM, preferably with:\n\nusing(new AttachedThread()){\n your code ...\n}\n\nOr with J4NBridge.AttachCurrentThreadAsDaemon() and J4NBridge.DetachCurrentThread() in pair.\n");
                        }
                        throw J4NException.InitBridgeFirst();
                    }
                    threadJNIEnv=Attach();
                }
                return threadJNIEnv;
            }
        }

        private static JNIEnv Attach()
        {
            JNIEnv res;
            if (J4NBridge.CurrentJVM == null)
            {
                throw J4NException.InitBridgeFirst();
            }
            JNIResult result = J4NBridge.CurrentJVM.JVMInstance.AttachCurrentThreadAsDaemon(out res);
            if (result != JNIResult.JNI_OK)
            {
                throw new J4NException("AttachCurrentThreadAsDaemon failed: " + result);
            }
            return res;
        }

    }
}
