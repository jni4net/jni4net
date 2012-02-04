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
using System.Collections.Generic;
using java.lang;

namespace net.sf.jni4net.jni
{
    partial class JNIEnv
    {
        public IntPtr GetStaticMethodID(IClass clazz, string name, string sig)
        {
            IntPtr res = Functions.getStaticMethodID.Invoke(envPtr, clazz.JvmHandle, name, sig);
            ExceptionTest();
            return res;
        }

        public IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
        {
            IntPtr res = Functions.getStaticMethodID.Invoke(envPtr, clazz, name, sig);
            ExceptionTest();
            return res;
        }

        public IntPtr GetMethodID(IClass clazz, string name, string sig)
        {
            IntPtr res = Functions.getMethodID.Invoke(envPtr, clazz.JvmHandle, name, sig);
            ExceptionTest();
            return res;
        }

        public IntPtr GetMethodID(IntPtr clazz, string name, string sig)
        {
            IntPtr res = Functions.getMethodID.Invoke(envPtr, clazz, name, sig);
            ExceptionTest();
            return res;
        }

        public IntPtr GetMethodIDNoThrow(IntPtr clazz, string name, string sig)
        {
            IntPtr res = Functions.getMethodID.Invoke(envPtr, clazz, name, sig);
            ExceptionRead();
            return res;
        }

        public IntPtr GetStaticMethodIDNoThrow(IntPtr clazz, string name, string sig)
        {
            IntPtr res = Functions.getStaticMethodID.Invoke(envPtr, clazz, name, sig);
            ExceptionRead();
            return res;
        }

        public IntPtr CallObjectMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallObjectMethod(obj.JvmHandle, methodID, args);
        }

        public IntPtr CallStaticObjectMethod(IClass clazz, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticObjectMethod(clazz.JvmHandle, methodID, args);
        }

        public void CallVoidMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            CallVoidMethod(obj.JvmHandle, methodID, args);
        }

        public void CallStaticVoidMethod(IClass clazz, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            CallStaticVoidMethod(clazz.JvmHandle, methodID, args);
        }

        public string CallStringMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            IntPtr lh = CallObjectMethod(obj, methodID, args);
            return GetString(lh);
        }

        public string CallStringMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            IntPtr lh = CallObjectMethod(obj.JvmHandle, methodID, args);
            return GetString(lh);
        }

        public string CallStaticStringMethod(IClass clazz, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            IntPtr lh = CallStaticObjectMethod(clazz.JvmHandle, methodID, args);
            return GetString(lh);
        }

        public bool CallBooleanMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallBooleanMethod(obj.JvmHandle, methodID, args);
        }

        public byte CallByteMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallByteMethod(obj.JvmHandle, methodID, args);
        }

        public char CallCharMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallCharMethod(obj.JvmHandle, methodID, args);
        }

        public short CallShortMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallShortMethod(obj.JvmHandle, methodID, args);
        }

        public int CallIntMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallIntMethod(obj.JvmHandle, methodID, args);
        }

        public long CallLongMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallLongMethod(obj.JvmHandle, methodID, args);
        }

        public float CallFloatMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallFloatMethod(obj.JvmHandle, methodID, args);
        }

        public double CallDoubleMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallDoubleMethod(obj.JvmHandle, methodID, args);
        }

        public bool CallStaticBooleanMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticBooleanMethod(obj.JvmHandle, methodID, args);
        }

        public byte CallStaticByteMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticByteMethod(obj.JvmHandle, methodID, args);
        }

        public char CallStaticCharMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticCharMethod(obj.JvmHandle, methodID, args);
        }

        public short CallStaticShortMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticShortMethod(obj.JvmHandle, methodID, args);
        }

        public int CallStaticIntMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticIntMethod(obj.JvmHandle, methodID, args);
        }

        public long CallStaticLongMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticLongMethod(obj.JvmHandle, methodID, args);
        }

        public float CallStaticFloatMethod(IJvmProxy obj, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticFloatMethod(obj.JvmHandle, methodID, args);
        }

        public double CallStaticDoubleMethod(IClass clazz, IntPtr methodID, params JNIValue[] args)
        {
            if (methodID == IntPtr.Zero)
            {
                throw J4NException.InitBridgeFirst();
            }
            return CallStaticDoubleMethod(clazz.JvmHandle, methodID, args);
        }

        public void CallVoidMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            Functions.callVoidMethod(envPtr, obj, methodID, args);
            ExceptionTest();
        }

        public IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            IntPtr res = Functions.callObjectMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return res;
        }

        public bool CallBooleanMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callBooleanMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return res != 0;
        }

        public byte CallByteMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callByteMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return res;
        }

        public char CallCharMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callCharMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return (char)res;
        }

        public short CallShortMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callShortMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return res;
        }

        public int CallIntMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callIntMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return res;
        }


        public long CallLongMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callLongMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return res;
        }

        public float CallFloatMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callFloatMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return res;
        }

        public double CallDoubleMethod(IntPtr obj, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callDoubleMethod(envPtr, obj, methodID, args);
            ExceptionTest();
            return res;
        }

        public IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            IntPtr res = Functions.callStaticObjectMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res;
        }

        public void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            Functions.callStaticVoidMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
        }

        public bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callStaticBooleanMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res != 0;
        }

        public byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callStaticByteMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res;
        }

        public char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callStaticCharMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return (char)res;
        }

        public short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callStaticShortMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res;
        }

        public int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callStaticIntMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res;
        }


        public long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callStaticLongMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res;
        }

        public float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callStaticFloatMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res;
        }

        public double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, params JNIValue[] args)
        {
            var res = Functions.callStaticDoubleMethod(envPtr, clazz, methodID, args);
            ExceptionTest();
            return res;
        }

        public unsafe void RegisterNatives(List<JNINativeMethod> registrations, IntPtr clazz, string className)
        {
            if (registrations.Count == 0)
            {
                return;
            }

            JNINativeMethod[] methods = registrations.ToArray();
            fixed (JNINativeMethod* m = &(methods[0]))
            {
                JNIResult res = Functions.registerNatives(envPtr, clazz, m, methods.Length);
                if (res != JNIResult.JNI_OK)
                {
#if DEBUG
                    if(registrations.Count>1)
                    {
                        for (int i = 0; i < registrations.Count; i++)
                        {
                            var jniNativeMethod = registrations[i];
                            RegisterNatives(new List<JNINativeMethod> {jniNativeMethod}, clazz, className + " #"+i);
                        }
                    }
#endif
                    throw J4NException.CantBindNative(className);
                }
            }
        }

        public void UnregisterNatives(IntPtr clazz, string className)
        {
            JNIResult res = Functions.unregisterNatives(envPtr, clazz);
            if (res != JNIResult.JNI_OK)
            {
                throw J4NException.CantUnbindNative(className);
            }
        }

    }
}
