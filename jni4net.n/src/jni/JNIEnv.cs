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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using java.lang;
using java.lang.reflect;
using java.nio;
using java_.lang;
using net.sf.jni4net.utils;
using Exception=System.Exception;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.jni
{
    [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution | SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SkipVerification)]
    public unsafe partial class JNIEnv
    {
        #region JNI methods

        public int GetVersion()
        {
            int version = getVersion(envPtr);
            ExceptionTest();
            return version;
        }

        public JavaVM GetJavaVM()
        {
            if (javaVM == null)
            {
                IntPtr jvm;
                getJavaVM.Invoke(envPtr, out jvm);
                ExceptionTest();
                javaVM = new JavaVM(jvm);
            }
            return javaVM;
        }

        #endregion

        #region reflection

        public IntPtr FindClassPtr(string name)
        {
            IntPtr clazz = findClass.Invoke(envPtr, name);
            ExceptionTest();
            return clazz;
        }

        public Class FindClass(string name)
        {
            IntPtr clazz = findClass.Invoke(envPtr, name);
            ExceptionTest();
            return Convertor.StrongJ2CpClass(this, clazz);
        }

        public IntPtr FindClassPtrNoThrow(string name)
        {
            IntPtr clazz = findClass.Invoke(envPtr, name);
            if (ExceptionRead())
            {
                return IntPtr.Zero;
            }
            return clazz;
        }

        public Class FindClassNoThrow(string name)
        {
            IntPtr clazz = findClass.Invoke(envPtr, name);
            if (ExceptionRead())
            {
                return null;
            }
            return Convertor.StrongJ2CpClass(this, clazz);
        }

        public Class GetObjectClass(IJvmProxy obj)
        {
            return GetObjectClass(obj.JvmHandle);
        }

        internal Class GetObjectClass(IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            IntPtr res = getObjectClass.Invoke(envPtr, obj);
            ExceptionTest();
            return Convertor.StrongJ2CpClass(this, res);
        }

        public MethodId GetStaticMethodID(Class clazz, string name, string sig)
        {
            IntPtr res = getStaticMethodID.Invoke(envPtr, clazz.jvmHandle, name, sig);
            ExceptionTest();
            return new MethodId(res);
        }

        public MethodId GetStaticMethodIDNoThrow(Class clazz, string name, string sig)
        {
            IntPtr res = getStaticMethodID.Invoke(envPtr, clazz.jvmHandle, name, sig);
            if (ExceptionRead())
            {
                return null;
            }
            return new MethodId(res);
        }

        public MethodId GetMethodID(Class clazz, string name, string sig)
        {
            IntPtr res = getMethodID.Invoke(envPtr, clazz.jvmHandle, name, sig);
            ExceptionTest();
            return new MethodId(res);
        }

        public MethodId GetMethodIDNoThrow(Class clazz, string name, string sig)
        {
            IntPtr res = getMethodID.Invoke(envPtr, clazz.jvmHandle, name, sig);
            if (ExceptionRead())
            {
                return null;
            }
            return new MethodId(res);
        }

        public FieldId GetFieldID(Class clazz, string name, string sig)
        {
            IntPtr res = getFieldID.Invoke(envPtr, clazz.jvmHandle, name, sig);
            ExceptionTest();
            return new FieldId(res);
        }

#if !JNI4NET_MINI

        public Field ToReflectedField(Class cls, FieldId fieldID, bool isStatic)
        {
            IntPtr res = toReflectedField.Invoke(envPtr, cls.jvmHandle, fieldID.native,
                                                 isStatic ? (byte) 1 : (byte) 0);
            ExceptionTest();
            return Convertor.StrongJ2Cp<Field>(this, res);
        }

        public Method ToReflectedMethod(Class cls, MethodId methodId, bool isStatic)
        {
            IntPtr res = toReflectedMethod.Invoke(envPtr, cls.jvmHandle, methodId.native,
                                                  isStatic ? (byte) 1 : (byte) 0);
            ExceptionTest();
            return Convertor.StrongJ2Cp<Method>(this, res);
        }

        public MethodId FromReflectedMethod(Method methodId)
        {
            IntPtr res = fromReflectedMethod.Invoke(envPtr, methodId.jvmHandle);
            ExceptionTest();
            return new MethodId(res);
        }

        public FieldId FromReflectedField(Field FieldId)
        {
            IntPtr res = fromReflectedField.Invoke(envPtr, FieldId.jvmHandle);
            ExceptionTest();
            return new FieldId(res);
        }

#endif

        public IntPtr GetStaticFieldIDPtr(IntPtr clazz, string name, string sig)
        {
            IntPtr res = getStaticFieldID.Invoke(envPtr, clazz, name, sig);
            ExceptionTest();
            return res;
        }

        public FieldId GetStaticFieldID(Class clazz, string name, string sig)
        {
            IntPtr res = GetStaticFieldIDPtr(clazz.jvmHandle, name, sig);
            return new FieldId(res);
        }

        public JNIResult RegisterNatives(Class clazz, JNINativeMethod* methods, int nMethods)
        {
            JNIResult natives = registerNatives.Invoke(envPtr, clazz.jvmHandle, methods, nMethods);
            ExceptionTest();
            return natives;
        }

        #endregion

        #region call static

        public void CallStaticVoidMethod(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            //TODO result could be tested in Java 1.6
            callStaticVoidMethod(envPtr, clazz.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
        }

        public TRes CallStaticObjectMethod<TRes>(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            IntPtr res = CallStaticObjectMethodPtr(clazz, methodIdNative, args);
            return Convertor.FullJ2C<TRes>(this, res);
        }

        public int CallStaticIntMethod(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            int res = callStaticIntMethod(envPtr, clazz.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallStaticLongMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callStaticLongMethod(envPtr, obj.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallStaticDoubleMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callStaticDoubleMethod(envPtr, obj.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallStaticFloatMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callStaticFloatMethod(envPtr, obj.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallStaticShortMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callStaticShortMethod(envPtr, obj.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallStaticCharMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callStaticCharMethod(envPtr, obj.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public bool CallStaticBooleanMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callStaticBooleanMethod(envPtr, obj.jvmHandle, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public byte CallStaticByteMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callStaticByteMethod(envPtr, obj.jvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        internal void CallStaticVoidMethod(Class clazz, string method, string sig, params Value[] args)
        {
            MethodId idNative = GetStaticMethodID(clazz, method, sig);
            if (idNative != null)
            {
                CallStaticVoidMethod(clazz, idNative, args);
                return;
            }
            throw new ArgumentException();
        }

        private TRes CallStaticMethod<TRes>(Class clazz, string method, string sig, params Value[] args)
        {
            MethodId idNative = GetStaticMethodID(clazz, method, sig);
            if (idNative != null)
            {
                if (typeof (IObject).IsAssignableFrom(typeof (TRes)))
                {
                    return CallStaticObjectMethod<TRes>(clazz, idNative, args);
                }
                if (typeof (string).IsAssignableFrom(typeof (TRes)))
                {
                    return CallStaticObjectMethod<TRes>(clazz, idNative, args);
                }
                if (typeof (int).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticIntMethod(clazz, idNative, args);
                }
                if (typeof (bool).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticBooleanMethod(clazz, idNative, args);
                }
                if (typeof (long).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticLongMethod(clazz, idNative, args);
                }
                if (typeof (double).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticDoubleMethod(clazz, idNative, args);
                }
                if (typeof (byte).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticByteMethod(clazz, idNative, args);
                }
                if (typeof (short).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticShortMethod(clazz, idNative, args);
                }
                if (typeof (float).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticFloatMethod(clazz, idNative, args);
                }
                if (typeof (char).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticCharMethod(clazz, idNative, args);
                }
                if (typeof (byte).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallStaticByteMethod(clazz, idNative, args);
                }
            }
            throw new ArgumentException();
        }

        #endregion

        #region call instance

        public void CallVoidMethod(IntPtr obj, MethodId methodId, params Value[] args)
        {
            callVoidMethod(envPtr, obj, methodId.native, args);
            //TODO result could be tested in Java 1.6
            ExceptionTest();
        }

        public void CallVoidMethod(IJvmProxy obj, MethodId methodId, params Value[] args)
        {
            CallVoidMethod(obj.JvmHandle, methodId, args);
        }

        public TRes CallObjectMethod<TRes>(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            IntPtr res = CallObjectMethodPtr(obj, methodIdNative, args);
            return Convertor.FullJ2C<TRes>(this, res);
        }

        public bool CallBooleanMethod(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callBooleanMethod(envPtr, obj.JvmHandle, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public bool CallBooleanMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callBooleanMethod(envPtr, obj, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public int CallIntMethod(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            int res = callIntMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public int CallIntMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            int res = callIntMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallShortMethod(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callShortMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallShortMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callShortMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallLongMethod(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callLongMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallLongMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callLongMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public byte CallByteMethod(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callByteMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public byte CallByteMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callByteMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallDoubleMethod(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callDoubleMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallDoubleMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callDoubleMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallFloatMethod(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callFloatMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallFloatMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callFloatMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallCharMethod(IJvmProxy obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callCharMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallCharMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callCharMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        private void CallVoidMethod(IJvmProxy obj, string method, string sig, params Value[] args)
        {
            Class objectClass = GetObjectClass(obj);
            if (objectClass != null)
            {
                MethodId methodId = GetMethodID(objectClass, method, sig);
                if (methodId != null)
                {
                    CallVoidMethod(obj, methodId, args);
                    return;
                }
            }
            throw new ArgumentException();
        }

        public bool CallBooleanMethod(IJvmProxy obj, string method, string sig, params Value[] args)
        {
            Class objectClass = GetObjectClass(obj);
            if (objectClass != null)
            {
                MethodId methodId = GetMethodID(objectClass, method, sig);
                if (methodId != null)
                {
                    return CallBooleanMethod(obj, methodId, args);
                }
            }
            throw new ArgumentException();
        }

        private int CallIntMethod(IJvmProxy obj, string method, string sig, params Value[] args)
        {
            Class objectClass = GetObjectClass(obj);
            if (objectClass != null)
            {
                MethodId methodId = GetMethodID(objectClass, method, sig);
                if (methodId != null)
                {
                    return CallIntMethod(obj, methodId, args);
                }
            }
            throw new ArgumentException();
        }

        private TRes CallMethod<TRes>(IJvmProxy obj, string method, string sig, params Value[] args)
        {
            MethodId idNative = GetMethodID(GetObjectClass(obj), method, sig);
            if (idNative != null)
            {
                if (typeof (IObject).IsAssignableFrom(typeof (TRes)))
                {
                    return CallObjectMethod<TRes>(obj, idNative, args);
                }
                if (typeof (string).IsAssignableFrom(typeof (TRes)))
                {
                    return CallObjectMethod<TRes>(obj, idNative, args);
                }
                if (typeof (int).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallIntMethod(obj, idNative, args);
                }
                if (typeof (bool).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallBooleanMethod(obj, idNative, args);
                }
                if (typeof (long).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallLongMethod(obj, idNative, args);
                }
                if (typeof (double).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallDoubleMethod(obj, idNative, args);
                }
                if (typeof (byte).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallByteMethod(obj, idNative, args);
                }
                if (typeof (short).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallShortMethod(obj, idNative, args);
                }
                if (typeof (float).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallFloatMethod(obj, idNative, args);
                }
                if (typeof (char).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallCharMethod(obj, idNative, args);
                }
                if (typeof (byte).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) CallByteMethod(obj, idNative, args);
                }
            }
            throw new ArgumentException();
        }

        #endregion

        #region getters instance

        public TRes GetObjectField<TRes>(IJvmProxy obj, FieldId fieldID)
        {
            IntPtr res = GetObjectFieldPtr(obj, fieldID);
            return Convertor.FullJ2C<TRes>(this, res);
        }

        public bool GetBooleanField(IJvmProxy obj, FieldId fieldID)
        {
            bool res = getBooleanField(envPtr, obj.JvmHandle, fieldID.native) != 0;
            ExceptionTest();
            return res;
        }

        public byte GetByteField(IJvmProxy obj, FieldId fieldID)
        {
            byte res = getByteField(envPtr, obj.JvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public short GetShortField(IJvmProxy obj, FieldId fieldID)
        {
            short res = getShortField(envPtr, obj.JvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public long GetLongField(IJvmProxy obj, FieldId fieldID)
        {
            long res = getLongField(envPtr, obj.JvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public int GetIntField(IJvmProxy obj, FieldId fieldID)
        {
            return GetIntField(obj.JvmHandle, fieldID);
        }

        public int GetIntField(IntPtr obj, FieldId fieldID)
        {
            int res = getIntField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public double GetDoubleField(IJvmProxy obj, FieldId fieldID)
        {
            double res = getDoubleField(envPtr, obj.JvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public float GetFloatField(IJvmProxy obj, FieldId fieldID)
        {
            float res = getFloatField(envPtr, obj.JvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public char GetCharField(IJvmProxy obj, FieldId fieldID)
        {
            var res = (char) getCharField(envPtr, obj.JvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public TRes GetField<TRes>(IJvmProxy obj, string fieldName, string sig)
        {
            FieldId id = GetFieldID(obj.GetClass(), fieldName, sig);
            if (id != null)
            {
                if (typeof (IObject).IsAssignableFrom(typeof (TRes)))
                {
                    return GetObjectField<TRes>(obj, id);
                }
                if (typeof (string).IsAssignableFrom(typeof (TRes)))
                {
                    return GetObjectField<TRes>(obj, id);
                }
                if (typeof (int).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetIntField(obj, id);
                }
                if (typeof (bool).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetBooleanField(obj, id);
                }
                if (typeof (long).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetLongField(obj, id);
                }
                if (typeof (double).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetDoubleField(obj, id);
                }
                if (typeof (byte).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetByteField(obj, id);
                }
                if (typeof (short).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetShortField(obj, id);
                }
                if (typeof (float).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetFloatField(obj, id);
                }
                if (typeof (char).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetCharField(obj, id);
                }
                if (typeof (byte).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetByteField(obj, id);
                }
                throw new NotImplementedException();
            }
            throw new ArgumentException();
        }

        #endregion

        #region setters instance

        internal void SetObjectField(IJvmProxy obj, FieldId fieldID, IJvmProxy value)
        {
            setObjectField(envPtr, obj.JvmHandle, fieldID.native, value.JvmHandle);
            ExceptionTest();
        }

        internal void SetIntField(IJvmProxy obj, FieldId fieldID, int value)
        {
            setIntField(envPtr, obj.JvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetBooleanField(IJvmProxy obj, FieldId fieldID, bool value)
        {
            setBooleanField(envPtr, obj.JvmHandle, fieldID.native, value ? (byte) 1 : (byte) 0);
            ExceptionTest();
        }

        internal void SetByteField(IJvmProxy obj, FieldId fieldID, byte value)
        {
            setByteField(envPtr, obj.JvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetCharField(IJvmProxy obj, FieldId fieldID, char value)
        {
            setCharField(envPtr, obj.JvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetShortField(IJvmProxy obj, FieldId fieldID, short value)
        {
            setShortField(envPtr, obj.JvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetLongField(IJvmProxy obj, FieldId fieldID, long value)
        {
            setLongField(envPtr, obj.JvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetFloatField(IJvmProxy obj, FieldId fieldID, float value)
        {
            setFloatField(envPtr, obj.JvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetDoubleField(IJvmProxy obj, FieldId fieldID, double value)
        {
            setDoubleField(envPtr, obj.JvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        public void SetField<T>(IJvmProxy obj, string fieldName, string sig, T value)
        {
            FieldId id = GetFieldID(obj.GetClass(), fieldName, sig);
            if (id != null)
            {
                if (typeof (IObject).IsAssignableFrom(typeof (T)))
                {
                    SetObjectField(obj, id, (Object) (object) value);
                }
                else if (typeof (string).IsAssignableFrom(typeof (T)))
                {
                    SetObjectField(obj, id, (String) (string) (object) value);
                }
                else if (typeof (int).IsAssignableFrom(typeof (T)))
                {
                    SetIntField(obj, id, (int) (object) value);
                }
                else if (typeof (bool).IsAssignableFrom(typeof (T)))
                {
                    SetBooleanField(obj, id, (bool) (object) value);
                }
                else if (typeof (long).IsAssignableFrom(typeof (T)))
                {
                    SetLongField(obj, id, (long) (object) value);
                }
                else if (typeof (double).IsAssignableFrom(typeof (T)))
                {
                    SetDoubleField(obj, id, (double) (object) value);
                }
                else if (typeof (byte).IsAssignableFrom(typeof (T)))
                {
                    SetByteField(obj, id, (byte) (object) value);
                }
                else if (typeof (short).IsAssignableFrom(typeof (T)))
                {
                    SetShortField(obj, id, (short) (object) value);
                }
                else if (typeof (float).IsAssignableFrom(typeof (T)))
                {
                    SetFloatField(obj, id, (float) (object) id);
                }
                else if (typeof (char).IsAssignableFrom(typeof (T)))
                {
                    SetCharField(obj, id, (char) (object) id);
                }
                else if (typeof (byte).IsAssignableFrom(typeof (T)))
                {
                    SetByteField(obj, id, (byte) (object) id);
                }
                else
                {
                    throw new NotImplementedException();
                }
                return;
            }
            throw new ArgumentException();
        }

        #endregion

        #region setters static

        internal void SetStaticObjectField(Class clazz, FieldId fieldID, IJvmProxy value)
        {
            setStaticObjectField(envPtr, clazz.jvmHandle, fieldID.native, value.JvmHandle);
            ExceptionTest();
        }

        internal void SetStaticIntField(Class clazz, FieldId fieldID, int value)
        {
            setStaticIntField(envPtr, clazz.jvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool value)
        {
            setStaticBooleanField(envPtr, clazz, fieldID, value ? (byte)1 : (byte)0);
            ExceptionTest();
        }

        internal void SetStaticBooleanField(Class clazz, FieldId fieldID, bool value)
        {
            SetStaticBooleanField(clazz.jvmHandle, fieldID.native, value);
        }

        internal void SetStaticByteField(Class clazz, FieldId fieldID, byte value)
        {
            setStaticByteField(envPtr, clazz.jvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticCharField(Class clazz, FieldId fieldID, char value)
        {
            setStaticCharField(envPtr, clazz.jvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticShortField(Class clazz, FieldId fieldID, short value)
        {
            setStaticShortField(envPtr, clazz.jvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticLongField(Class clazz, FieldId fieldID, long value)
        {
            setStaticLongField(envPtr, clazz.jvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticFloatField(Class clazz, FieldId fieldID, float value)
        {
            setStaticFloatField(envPtr, clazz.jvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticDoubleField(Class clazz, FieldId fieldID, double value)
        {
            setStaticDoubleField(envPtr, clazz.jvmHandle, fieldID.native, value);
            ExceptionTest();
        }

        public void SetStaticField<T>(Class clazz, string fieldName, string sig, T value)
        {
            FieldId id = GetStaticFieldID(clazz, fieldName, sig);
            if (id != null)
            {
                if (typeof (IObject).IsAssignableFrom(typeof (T)))
                {
                    SetStaticObjectField(clazz, id, (Object) (object) value);
                }
                else if (typeof (string).IsAssignableFrom(typeof (T)))
                {
                    SetStaticObjectField(clazz, id, (String) (string) (object) value);
                }
                else if (typeof (int).IsAssignableFrom(typeof (T)))
                {
                    SetStaticIntField(clazz, id, (int) (object) value);
                }
                else if (typeof (bool).IsAssignableFrom(typeof (T)))
                {
                    SetStaticBooleanField(clazz, id, (bool) (object) value);
                }
                else if (typeof (long).IsAssignableFrom(typeof (T)))
                {
                    SetStaticLongField(clazz, id, (long) (object) value);
                }
                else if (typeof (double).IsAssignableFrom(typeof (T)))
                {
                    SetStaticDoubleField(clazz, id, (double) (object) value);
                }
                else if (typeof (byte).IsAssignableFrom(typeof (T)))
                {
                    SetStaticByteField(clazz, id, (byte) (object) value);
                }
                else if (typeof (short).IsAssignableFrom(typeof (T)))
                {
                    SetStaticShortField(clazz, id, (short) (object) value);
                }
                else if (typeof (float).IsAssignableFrom(typeof (T)))
                {
                    SetStaticFloatField(clazz, id, (float) (object) value);
                }
                else if (typeof (char).IsAssignableFrom(typeof (T)))
                {
                    SetStaticCharField(clazz, id, (char) (object) value);
                }
                else if (typeof (byte).IsAssignableFrom(typeof (T)))
                {
                    SetStaticByteField(clazz, id, (byte) (object) value);
                }
                else
                {
                    throw new NotImplementedException();
                }
                return;
            }
            throw new ArgumentException();
        }

        #endregion

        #region getters static

        public TRes GetStaticObjectField<TRes>(Class clazz, FieldId fieldID)
        {
            IntPtr res = GetStaticObjectFieldPtr(clazz, fieldID);
            return Convertor.FullJ2C<TRes>(this, res);
        }


        public bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
        {
            bool res = getStaticBooleanField(envPtr, clazz, fieldID) != 0;
            ExceptionTest();
            return res;
        }

        public bool GetStaticBooleanField(Class clazz, FieldId fieldID)
        {
            return GetStaticBooleanField(clazz.jvmHandle, fieldID.native);
        }

        public byte GetStaticByteField(Class clazz, FieldId fieldID)
        {
            byte res = getStaticByteField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public short GetStaticShortField(Class clazz, FieldId fieldID)
        {
            short res = getStaticShortField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public long GetStaticLongField(Class clazz, FieldId fieldID)
        {
            long res = getStaticLongField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public int GetStaticIntField(Class clazz, FieldId fieldID)
        {
            int res = getStaticIntField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public double GetStaticDoubleField(Class clazz, FieldId fieldID)
        {
            double res = getStaticDoubleField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public float GetStaticFloatField(Class clazz, FieldId fieldID)
        {
            float res = getStaticFloatField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }

        public char GetStaticCharField(Class clazz, FieldId fieldID)
        {
            var res = (char) getStaticCharField(envPtr, clazz.jvmHandle, fieldID.native);
            ExceptionTest();
            return res;
        }


        public TRes GetStaticField<TRes>(string type, string fieldName, string sig)
        {
            Class objectClass = FindClass(type);
            if (objectClass != null)
            {
                return GetStaticField<TRes>(objectClass, fieldName, sig);
            }
            throw new ArgumentException();
        }

        public TRes GetStaticField<TRes>(Class objectClass, string fieldName, string sig)
        {
            FieldId id = GetStaticFieldID(objectClass, fieldName, sig);
            if (id != null)
            {
                if (typeof (IObject).IsAssignableFrom(typeof (TRes)))
                {
                    return GetStaticObjectField<TRes>(objectClass, id);
                }
                if (typeof (string).IsAssignableFrom(typeof (TRes)))
                {
                    return GetStaticObjectField<TRes>(objectClass, id);
                }
                if (typeof (int).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticIntField(objectClass, id);
                }
                if (typeof (bool).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticBooleanField(objectClass, id);
                }
                if (typeof (long).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticLongField(objectClass, id);
                }
                if (typeof (double).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticDoubleField(objectClass, id);
                }
                if (typeof (byte).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticByteField(objectClass, id);
                }
                if (typeof (short).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticShortField(objectClass, id);
                }
                if (typeof (float).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticFloatField(objectClass, id);
                }
                if (typeof (char).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticCharField(objectClass, id);
                }
                if (typeof (byte).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) GetStaticByteField(objectClass, id);
                }
                throw new NotImplementedException();
            }
            throw new ArgumentException();
        }

        #endregion

        #region buffer

        public ByteBuffer NewDirectByteBuffer(IntPtr address, long capacity)
        {
            IntPtr res = newDirectByteBuffer.Invoke(envPtr, address, capacity);
            ExceptionTest();
            return Convertor.StrongJ2Cp<ByteBuffer>(this, res);
        }

        public void* GetDirectBufferAddress(Object buf)
        {
            void* res = getDirectBufferAddress.Invoke(envPtr, buf.jvmHandle);
            ExceptionTest();
            return res;
        }

        public long GetDirectBufferCapacity(Object buf)
        {
            long res = getDirectBufferCapacity.Invoke(envPtr, buf.jvmHandle);
            ExceptionTest();
            return res;
        }

        #endregion

        #region string

        public String NewString(string unicode)
        {
            IntPtr res = NewStringPtr(unicode);
            return Convertor.StrongJ2CpString(this, res);
        }

        internal string ConvertToString(IntPtr javaString)
        {
            byte b = 0;
            IntPtr chars = GetStringChars(javaString, &b);
            string result = Marshal.PtrToStringUni(chars);
            ReleaseStringChars(javaString, chars);
            return result;
        }

        #endregion

        #region references

        internal IntPtr NewGlobalRef(IntPtr lobj)
        {
            if (lobj == IntPtr.Zero)
            {
                throw new ArgumentNullException("lobj");
            }
            IntPtr res = newGlobalRef(envPtr, lobj);
            //optimized away ExceptionTest();
            return res;
        }

        internal IntPtr PopLocalFrame(IntPtr result)
        {
            IntPtr res = popLocalFrame(envPtr, result);
            ExceptionTest();
            return res;
        }

        internal void PushLocalFrame(int capacity)
        {
            int res = pushLocalFrame(envPtr, capacity);
            ExceptionTest();
            if (res != 0)
            {
                throw new JNIException("Can't allocate local frame" + res);
            }
        }

        internal void EnsureLocalCapacity(int capacity)
        {
            int res = ensureLocalCapacity(envPtr, capacity);
            ExceptionTest();
            if (res != 0)
            {
                throw new JNIException("Can't allocate local frame" + res);
            }
        }

        internal void DeleteGlobalRef(IJvmProxy gref)
        {
            if (gref == null || gref.JvmHandle == IntPtr.Zero)
            {
                throw new ArgumentNullException("gref");
            }
            deleteGlobalRef(envPtr, gref.JvmHandle);
            //optimized away ExceptionTest();
            gref.JvmHandle = IntPtr.Zero;
        }

        internal void DeleteLocalRef(IntPtr lref)
        {
            if (lref == IntPtr.Zero)
            {
                throw new ArgumentNullException("lref");
            }
            deleteLocalRef(envPtr, lref);
            //optimized away ExceptionTest();
        }

        public bool IsSameObject(IJvmProxy o1, IJvmProxy o2)
        {
            bool res = isSameObject(envPtr, o1.JvmHandle, o2.JvmHandle) != 0;
            ExceptionTest();
            return res;
        }

        #endregion

        #region allocation

        internal IObject AllocObject(Class clazz)
        {
            IntPtr res = allocObject(envPtr, clazz.jvmHandle);
            ExceptionTest();
            return Convertor.FullJ2C<IJvmProxy>(this, res);
        }

        public void NewObject(Class clazz, MethodId methodID, IJvmProxy obj, params Value[] args)
        {
            IntPtr res = newObject(envPtr, clazz.jvmHandle, methodID.native, args);
            ExceptionTest();
            obj.Init(this, res, clazz);
        }

        public IntPtr NewObjectPtr(IntPtr clazz, MethodId methodID, params Value[] args)
        {
            IntPtr res = newObject(envPtr, clazz, methodID.native, args);
            ExceptionTest();
            return res;
        }

        public IObject NewObject(Class clazz, MethodId methodID, params Value[] args)
        {
            IntPtr res = newObject(envPtr, clazz.jvmHandle, methodID.native, args);
            ExceptionTest();
            return Convertor.FullJ2C<IJvmProxy>(this, res);
        }

        #endregion

        #region exceptions

        public void Throw(Throwable ex)
        {
            IntPtr ptr = ex.jvmHandle;
            Throw(ptr);
        }

        internal void Throw(IntPtr ptr)
        {
            if (@throw(envPtr, ptr) != JNIResult.JNI_OK)
            {
                throw new JNIException("Can't throw");
            }
        }

        public void ThrowNew(Class clazz, string message)
        {
            IntPtr uni = Marshal.StringToHGlobalUni(message);
            if (throwNew(envPtr, clazz.jvmHandle, uni) != JNIResult.JNI_OK)
            {
                throw new JNIException("Can't throw");
            }
            Marshal.FreeHGlobal(uni);
        }

        public IntPtr ExceptionOccurred()
        {
            return exceptionOccurred(envPtr);
        }

        public void FatalError(string message)
        {
            fatalError(envPtr, Marshal.StringToHGlobalUni(message));
        }

        public void ExceptionClear()
        {
            exceptionClear(envPtr);
        }

        public void ExceptionDescribe()
        {
            exceptionDescribe(envPtr);
        }

        public void ExceptionTest()
        {
            IntPtr occurred = ExceptionOccurred();
            if (IntPtr.Zero != occurred)
            {
                //ExceptionDescribe();
                ExceptionClear();
                Exception exception = Convertor.FullJ2C<Exception>(this, occurred);
                throw exception;
            }
        }

        public bool ExceptionRead()
        {
            IntPtr occurred = ExceptionOccurred();
            if (IntPtr.Zero != occurred)
            {
                /*if (Bridge.Setup.Verbose && Bridge.Setup.Debug)
                {
                    ExceptionDescribe();
                }*/
                ExceptionClear();
                return true;
            }
            return false;
        }


        public void ThrowExisting(Exception ex)
        {
            var ext = ex as Throwable;
            if (ext == null)
            {
                Throw(Convertor.StrongC2Jp(this, ex));
            }
            else
            {
#if !JNI4NET_MINI
                ext.SetStackTrace(new StackTrace(ex));
#else
                //TODO
#endif
                Throw(ext);
            }
        }

        public bool ExceptionCheck()
        {
            return exceptionCheck(envPtr) != 0;
        }

        #endregion
    }
}