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
using java.lang;
using java.lang.reflect;
using java_.lang;
using net.sf.jni4net.utils;
using Exception=System.Exception;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.jni
{
    public unsafe partial class JNIEnv
    {
        #region JNI methods

        public int GetVersion()
        {
            int version = getVersion(native);
            ExceptionTest();
            return version;
        }

        public JavaVM GetJavaVM()
        {
            if (javaVM == null)
            {
                IntPtr jvm;
                getJavaVM.Invoke(native, out jvm);
                ExceptionTest();
                javaVM = new JavaVM(jvm);
            }
            return javaVM;
        }

        #endregion

        #region reflection

        public Class FindClass(string name)
        {
            IntPtr clazz = findClass.Invoke(native, name);
            ExceptionTest();
            return Convertor.StrongJ2CpClass(this, clazz);
        }

        public Class FindClassNoThrow(string name)
        {
            IntPtr clazz = findClass.Invoke(native, name);
            if (ExceptionRead())
            {
                return null;
            }
            return Convertor.StrongJ2CpClass(this, clazz);
        }

        public Class GetObjectClass(IJavaProxy obj)
        {
            return GetObjectClass(obj.Native);
        }

        internal Class GetObjectClass(IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            IntPtr res = getObjectClass.Invoke(native, obj);
            ExceptionTest();
            return Convertor.StrongJ2CpClass(this, res);
        }

        public MethodId GetStaticMethodID(Class clazz, string name, string sig)
        {
            IntPtr res = getStaticMethodID.Invoke(native, clazz.native, name, sig);
            ExceptionTest();
            return new MethodId(res);
        }

        public MethodId GetStaticMethodIDNoThrow(Class clazz, string name, string sig)
        {
            IntPtr res = getStaticMethodID.Invoke(native, clazz.native, name, sig);
            if (ExceptionRead())
            {
                return null;
            }
            return new MethodId(res);
        }

        public MethodId GetMethodID(Class clazz, string name, string sig)
        {
            IntPtr res = getMethodID.Invoke(native, clazz.native, name, sig);
            ExceptionTest();
            return new MethodId(res);
        }

        public MethodId GetMethodIDNoThrow(Class clazz, string name, string sig)
        {
            IntPtr res = getMethodID.Invoke(native, clazz.native, name, sig);
            if (ExceptionRead())
            {
                return null;
            }
            return new MethodId(res);
        }

        public FieldId GetFieldID(Class clazz, string name, string sig)
        {
            IntPtr res = getFieldID.Invoke(native, clazz.native, name, sig);
            ExceptionTest();
            return new FieldId(res);
        }

#if !JNI4NET_MINI

        public Field ToReflectedField(Class cls, FieldId fieldID, bool isStatic)
        {
            IntPtr res = toReflectedField.Invoke(native, cls.native, fieldID.native,
                                                 isStatic ? (byte) 1 : (byte) 0);
            ExceptionTest();
            return Convertor.StrongJ2Cp<Field>(this, res);
        }

        public Method ToReflectedMethod(Class cls, MethodId methodId, bool isStatic)
        {
            IntPtr res = toReflectedMethod.Invoke(native, cls.native, methodId.native,
                                                  isStatic ? (byte) 1 : (byte) 0);
            ExceptionTest();
            return Convertor.StrongJ2Cp<Method>(this, res);
        }

        public MethodId FromReflectedMethod(Method methodId)
        {
            IntPtr res = fromReflectedMethod.Invoke(native, methodId.native);
            ExceptionTest();
            return new MethodId(res);
        }

        public FieldId FromReflectedField(Field FieldId)
        {
            IntPtr res = fromReflectedField.Invoke(native, FieldId.native);
            ExceptionTest();
            return new FieldId(res);
        }

#endif

        public FieldId GetStaticFieldID(Class clazz, string name, string sig)
        {
            IntPtr res = getStaticFieldID.Invoke(native, clazz.native, name, sig);
            ExceptionTest();
            return new FieldId(res);
        }

        public JNIResult RegisterNatives(Class clazz, JNINativeMethod* methods, int nMethods)
        {
            JNIResult natives = registerNatives.Invoke(native, clazz.native, methods, nMethods);
            ExceptionTest();
            return natives;
        }

        #endregion

        #region call static

        public void CallStaticVoidMethod(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            //TODO result could be tested in Java 1.6
            callStaticVoidMethod(native, clazz.native, methodIdNative.native, args);
            ExceptionTest();
        }

        public TRes CallStaticObjectMethod<TRes>(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            IntPtr res = CallStaticObjectMethodPtr(clazz, methodIdNative, args);
            return Convertor.FullJ2C<TRes>(this, res);
        }

        public int CallStaticIntMethod(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            int res = callStaticIntMethod(native, clazz.native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallStaticLongMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callStaticLongMethod(native, obj.native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallStaticDoubleMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callStaticDoubleMethod(native, obj.native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallStaticFloatMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callStaticFloatMethod(native, obj.native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallStaticShortMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callStaticShortMethod(native, obj.native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallStaticCharMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callStaticCharMethod(native, obj.native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public bool CallStaticBooleanMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callStaticBooleanMethod(native, obj.native, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public byte CallStaticByteMethod(Class obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callStaticByteMethod(native, obj.native, methodIdNative.native, args);
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
            callVoidMethod(native, obj, methodId.native, args);
            //TODO result could be tested in Java 1.6
            ExceptionTest();
        }

        public void CallVoidMethod(IJavaProxy obj, MethodId methodId, params Value[] args)
        {
            CallVoidMethod(obj.Native, methodId, args);
        }

        public TRes CallObjectMethod<TRes>(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            IntPtr res = CallObjectMethodPtr(obj, methodIdNative, args);
            return Convertor.FullJ2C<TRes>(this, res);
        }

        public bool CallBooleanMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callBooleanMethod(native, obj.Native, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public bool CallBooleanMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callBooleanMethod(native, obj, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public int CallIntMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            int res = callIntMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public int CallIntMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            int res = callIntMethod(native, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallShortMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callShortMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallShortMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callShortMethod(native, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallLongMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callLongMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallLongMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callLongMethod(native, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public byte CallByteMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callByteMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public byte CallByteMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callByteMethod(native, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallDoubleMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callDoubleMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallDoubleMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callDoubleMethod(native, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallFloatMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callFloatMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallFloatMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callFloatMethod(native, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallCharMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callCharMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallCharMethod(IntPtr obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callCharMethod(native, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        private void CallVoidMethod(IJavaProxy obj, string method, string sig, params Value[] args)
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

        private bool CallBooleanMethod(IJavaProxy obj, string method, string sig, params Value[] args)
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

        private int CallIntMethod(IJavaProxy obj, string method, string sig, params Value[] args)
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

        private TRes CallMethod<TRes>(IJavaProxy obj, string method, string sig, params Value[] args)
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

        public TRes GetObjectField<TRes>(IJavaProxy obj, FieldId fieldID)
        {
            IntPtr res = GetObjectFieldPtr(obj, fieldID);
            return Convertor.FullJ2C<TRes>(this, res);
        }

        public bool GetBooleanField(IJavaProxy obj, FieldId fieldID)
        {
            bool res = getBooleanField(native, obj.Native, fieldID.native) != 0;
            ExceptionTest();
            return res;
        }

        public byte GetByteField(IJavaProxy obj, FieldId fieldID)
        {
            byte res = getByteField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public short GetShortField(IJavaProxy obj, FieldId fieldID)
        {
            short res = getShortField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public long GetLongField(IJavaProxy obj, FieldId fieldID)
        {
            long res = getLongField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public int GetIntField(IJavaProxy obj, FieldId fieldID)
        {
            return GetIntField(obj.Native, fieldID);
        }

        public int GetIntField(IntPtr obj, FieldId fieldID)
        {
            int res = getIntField(native, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public double GetDoubleField(IJavaProxy obj, FieldId fieldID)
        {
            double res = getDoubleField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public float GetFloatField(IJavaProxy obj, FieldId fieldID)
        {
            float res = getFloatField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public char GetCharField(IJavaProxy obj, FieldId fieldID)
        {
            var res = (char) getCharField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public TRes GetField<TRes>(IJavaProxy obj, string fieldName, string sig)
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

        internal void SetObjectField(IJavaProxy obj, FieldId fieldID, IJavaProxy value)
        {
            setObjectField(native, obj.Native, fieldID.native, value.Native);
            ExceptionTest();
        }

        internal void SetIntField(IJavaProxy obj, FieldId fieldID, int value)
        {
            setIntField(native, obj.Native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetBooleanField(IJavaProxy obj, FieldId fieldID, bool value)
        {
            setBooleanField(native, obj.Native, fieldID.native, value ? (byte) 1 : (byte) 0);
            ExceptionTest();
        }

        internal void SetByteField(IJavaProxy obj, FieldId fieldID, byte value)
        {
            setByteField(native, obj.Native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetCharField(IJavaProxy obj, FieldId fieldID, char value)
        {
            setCharField(native, obj.Native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetShortField(IJavaProxy obj, FieldId fieldID, short value)
        {
            setShortField(native, obj.Native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetLongField(IJavaProxy obj, FieldId fieldID, long value)
        {
            setLongField(native, obj.Native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetFloatField(IJavaProxy obj, FieldId fieldID, float value)
        {
            setFloatField(native, obj.Native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetDoubleField(IJavaProxy obj, FieldId fieldID, double value)
        {
            setDoubleField(native, obj.Native, fieldID.native, value);
            ExceptionTest();
        }

        public void SetField<T>(IJavaProxy obj, string fieldName, string sig, T value)
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

        internal void SetStaticObjectField(Class clazz, FieldId fieldID, IJavaProxy value)
        {
            setStaticObjectField(native, clazz.native, fieldID.native, value.Native);
            ExceptionTest();
        }

        internal void SetStaticIntField(Class clazz, FieldId fieldID, int value)
        {
            setStaticIntField(native, clazz.native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticBooleanField(Class clazz, FieldId fieldID, bool value)
        {
            setStaticBooleanField(native, clazz.native, fieldID.native, value ? (byte) 1 : (byte) 0);
            ExceptionTest();
        }

        internal void SetStaticByteField(Class clazz, FieldId fieldID, byte value)
        {
            setStaticByteField(native, clazz.native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticCharField(Class clazz, FieldId fieldID, char value)
        {
            setStaticCharField(native, clazz.native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticShortField(Class clazz, FieldId fieldID, short value)
        {
            setStaticShortField(native, clazz.native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticLongField(Class clazz, FieldId fieldID, long value)
        {
            setStaticLongField(native, clazz.native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticFloatField(Class clazz, FieldId fieldID, float value)
        {
            setStaticFloatField(native, clazz.native, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticDoubleField(Class clazz, FieldId fieldID, double value)
        {
            setStaticDoubleField(native, clazz.native, fieldID.native, value);
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


        public bool GetStaticBooleanField(Class clazz, FieldId fieldID)
        {
            bool res = getStaticBooleanField(native, clazz.native, fieldID.native) != 0;
            ExceptionTest();
            return res;
        }

        public byte GetStaticByteField(Class clazz, FieldId fieldID)
        {
            byte res = getStaticByteField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public short GetStaticShortField(Class clazz, FieldId fieldID)
        {
            short res = getStaticShortField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public long GetStaticLongField(Class clazz, FieldId fieldID)
        {
            long res = getStaticLongField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public int GetStaticIntField(Class clazz, FieldId fieldID)
        {
            int res = getStaticIntField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public double GetStaticDoubleField(Class clazz, FieldId fieldID)
        {
            double res = getStaticDoubleField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public float GetStaticFloatField(Class clazz, FieldId fieldID)
        {
            float res = getStaticFloatField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return res;
        }

        public char GetStaticCharField(Class clazz, FieldId fieldID)
        {
            var res = (char) getStaticCharField(native, clazz.native, fieldID.native);
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

        public IObject NewDirectByteBuffer(void* address, long capacity)
        {
            IntPtr res = newDirectByteBuffer.Invoke(native, address, capacity);
            ExceptionTest();
            return Convertor.FullJ2C<IJavaProxy>(this, res);
        }

        public void* GetDirectBufferAddress(Object buf)
        {
            void* res = getDirectBufferAddress.Invoke(native, buf.native);
            ExceptionTest();
            return res;
        }

        public long GetDirectBufferCapacity(Object buf)
        {
            long res = getDirectBufferCapacity.Invoke(native, buf.native);
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
            IntPtr res = newGlobalRef(native, lobj);
            //optimized away ExceptionTest();
            return res;
        }

        internal IntPtr PopLocalFrame(IntPtr result)
        {
            IntPtr res = popLocalFrame(native, result);
            ExceptionTest();
            return res;
        }

        internal void PushLocalFrame(int capacity)
        {
            int res = pushLocalFrame(native, capacity);
            ExceptionTest();
            if (res != 0)
            {
                throw new JNIException("Can't allocate local frame" + res);
            }
        }

        internal void EnsureLocalCapacity(int capacity)
        {
            int res = ensureLocalCapacity(native, capacity);
            ExceptionTest();
            if (res != 0)
            {
                throw new JNIException("Can't allocate local frame" + res);
            }
        }

        internal void DeleteGlobalRef(IJavaProxy gref)
        {
            if (gref == null || gref.Native == IntPtr.Zero)
            {
                throw new ArgumentNullException("gref");
            }
            deleteGlobalRef(native, gref.Native);
            //optimized away ExceptionTest();
            gref.Native = IntPtr.Zero;
        }

        internal void DeleteLocalRef(IntPtr lref)
        {
            if (lref == IntPtr.Zero)
            {
                throw new ArgumentNullException("lref");
            }
            deleteLocalRef(native, lref);
            //optimized away ExceptionTest();
        }

        public bool IsSameObject(IJavaProxy o1, IJavaProxy o2)
        {
            bool res = isSameObject(native, o1.Native, o2.Native) != 0;
            ExceptionTest();
            return res;
        }

        #endregion

        #region allocation

        internal IObject AllocObject(Class clazz)
        {
            IntPtr res = allocObject(native, clazz.native);
            ExceptionTest();
            return Convertor.FullJ2C<IJavaProxy>(this, res);
        }

        public void NewObject(Class clazz, MethodId methodID, IJavaProxy obj, params Value[] args)
        {
            IntPtr res = newObject(native, clazz.native, methodID.native, args);
            ExceptionTest();
            obj.Init(this, res, clazz);
        }

        public IntPtr NewObjectPtr(IntPtr clazz, MethodId methodID, params Value[] args)
        {
            IntPtr res = newObject(native, clazz, methodID.native, args);
            ExceptionTest();
            return res;
        }

        public IObject NewObject(Class clazz, MethodId methodID, params Value[] args)
        {
            IntPtr res = newObject(native, clazz.native, methodID.native, args);
            ExceptionTest();
            return Convertor.FullJ2C<IJavaProxy>(this, res);
        }

        #endregion

        #region exceptions

        public void Throw(Throwable ex)
        {
            IntPtr ptr = ex.native;
            Throw(ptr);
        }

        internal void Throw(IntPtr ptr)
        {
            if (@throw(native, ptr) != JNIResult.JNI_OK)
            {
                throw new JNIException("Can't throw");
            }
        }

        public void ThrowNew(Class clazz, string message)
        {
            IntPtr uni = Marshal.StringToHGlobalUni(message);
            if (throwNew(native, clazz.native, uni) != JNIResult.JNI_OK)
            {
                throw new JNIException("Can't throw");
            }
            Marshal.FreeHGlobal(uni);
        }

        public IntPtr ExceptionOccurred()
        {
            return exceptionOccurred(native);
        }

        public void FatalError(string message)
        {
            fatalError(native, Marshal.StringToHGlobalUni(message));
        }

        public void ExceptionClear()
        {
            exceptionClear(native);
        }

        public void ExceptionDescribe()
        {
            exceptionDescribe(native);
        }

        public void ExceptionTest()
        {
            IntPtr occurred = ExceptionOccurred();
            if (IntPtr.Zero != occurred)
            {
                //ExceptionDescribe();
                ExceptionClear();
                throw Convertor.FullJ2C<Exception>(this, occurred);
            }
        }

        public bool ExceptionRead()
        {
            IntPtr occurred = ExceptionOccurred();
            if (IntPtr.Zero != occurred)
            {
                if (Bridge.Verbose)
                {
                    ExceptionDescribe();
                }
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
                Throw(Convertor.StrongCp2J(ext));
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
            return exceptionCheck(native) != 0;
        }

        #endregion
    }
}