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
using net.sf.jni4net.inj;
using net.sf.jni4net.utils;
using Exception=System.Exception;
using Object=java.lang.Object;
using String=java.lang.String;
using Type=System.Type;

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
                JavaVM.JavaPtr* jvm;
                getJavaVM.Invoke(native, out jvm);
                ExceptionTest();
                javaVM = new JavaVM(jvm);
            }
            return javaVM;
        }

        public Value[] ConverArgs(params object[] args)
        {
            if (args.Length == 0)
            {
                return null;
            }
            var jargs = new Value[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                jargs[i] = new Value(args[i], this);
            }
            return jargs;
        }

        #endregion

        #region reflection

        public Class FindClass(string name)
        {
            Class.JavaPtr* invoke = findClass.Invoke(native, name);
            ExceptionTest();
            return Wrap<Class>((Object.JavaPtr*) invoke);
        }

        public Class FindClassNoThrow(string name)
        {
            Class.JavaPtr* invoke = findClass.Invoke(native, name);
            if (ExceptionRead())
            {
                return null;
            }
            return Wrap<Class>((Object.JavaPtr*) invoke);
        }


        public Class GetObjectClass(IJavaProxy obj)
        {
            return GetObjectClass(obj.Native);
        }

        internal Class GetObjectClass(Object.JavaPtr* obj)
        {
            var res = (Object.JavaPtr*) getObjectClass.Invoke(native, obj);
            ExceptionTest();
            return Wrap<Class>(res);
        }

        public MethodId GetStaticMethodID(Class clazz, string name, string sig)
        {
            MethodId.JavaPtr* res = getStaticMethodID.Invoke(native, clazz.native, name, sig);
            ExceptionTest();
            return (*res).Wrap();
        }

        public MethodId GetMethodID(Class clazz, string name, string sig)
        {
            MethodId.JavaPtr* res = getMethodID.Invoke(native, clazz.native, name, sig);
            ExceptionTest();
            return (*res).Wrap();
        }

        public MethodId GetMethodIDNoThrow(Class clazz, string name, string sig)
        {
            MethodId.JavaPtr* res = getMethodID.Invoke(native, clazz.native, name, sig);
            if (ExceptionRead())
            {
                return null;
            }
            return (*res).Wrap();
        }

        public FieldId GetFieldID(Class clazz, string name, string sig)
        {
            FieldId.JavaPtr* res = getFieldID.Invoke(native, clazz.native, name, sig);
            ExceptionTest();
            return (*res).Wrap();
        }

        #if !JNI4NET_MINI

        public Field ToReflectedField(Class cls, FieldId fieldID, bool isStatic)
        {
            Object.JavaPtr* res = toReflectedField.Invoke(native, cls.native, fieldID.native,
                                                          isStatic ? (byte) 1 : (byte) 0);
            ExceptionTest();
            return Wrap<Field>(res);
        }

        public Method ToReflectedMethod(Class cls, MethodId methodId, bool isStatic)
        {
            Object.JavaPtr* res = toReflectedMethod.Invoke(native, cls.native, methodId.native,
                                                           isStatic ? (byte) 1 : (byte) 0);
            ExceptionTest();
            return Wrap<Method>(res);
        }

        public MethodId FromReflectedMethod(Method methodId)
        {
            MethodId.JavaPtr* res = fromReflectedMethod.Invoke(native, methodId.native);
            ExceptionTest();
            return (*res).Wrap();
        }

        public FieldId FromReflectedField(Field FieldId)
        {
            FieldId.JavaPtr* res = fromReflectedField.Invoke(native, FieldId.native);
            ExceptionTest();
            return (*res).Wrap();
        }

#endif
        public FieldId GetStaticFieldID(Class clazz, string name, string sig)
        {
            FieldId.JavaPtr* res = getStaticFieldID.Invoke(native, clazz.native, name, sig);
            ExceptionTest();
            return (*res).Wrap();
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
            if (callStaticVoidMethod(native, clazz.native, methodIdNative.native, args) != JNIResult.JNI_OK)
            {
                throw new ApplicationException();
            }
            ExceptionTest();
        }

        public IJavaProxy CallStaticObjectMethod(Class clazz, MethodId methodIdNative, params Value[] args)
        {
            Object.JavaPtr* res = callStaticObjectMethod(native, clazz.native, methodIdNative.native, args);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
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

        public void CallStaticMethod(Class clazz, string method, string sig, params object[] args)
        {
            CallStaticVoidMethod(clazz, method, sig, ConverArgs(args));
        }

        private void CallStaticVoidMethod(Class clazz, string method, string sig, params Value[] args)
        {
            MethodId idNative = GetStaticMethodID(clazz, method, sig);
            if (idNative != null)
            {
                CallStaticVoidMethod(clazz, idNative, args);
                return;
            }
            throw new ArgumentException();
        }

        public TRes CallStaticMethod<TRes>(Class clazz, string method, string sig, params object[] args)
        {
            return CallStaticMethod<TRes>(clazz, method, sig, ConverArgs(args));
        }

        private TRes CallStaticMethod<TRes>(Class clazz, string method, string sig, params Value[] args)
        {
            MethodId idNative = GetStaticMethodID(clazz, method, sig);
            if (idNative != null)
            {
                if (typeof(IObject).IsAssignableFrom(typeof(TRes)))
                {
                    return (TRes) (object) CallStaticObjectMethod(clazz, idNative, args);
                }
                if (typeof (string).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) (string) (String) CallStaticObjectMethod(clazz, idNative, args);
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

        public void CallVoidMethod(IJavaProxy obj, MethodId methodId, params Value[] args)
        {
            if (callVoidMethod(native, obj.Native, methodId.native, args) != JNIResult.JNI_OK)
            {
                throw new JNIException("Can't call method");
            }
            ExceptionTest();
        }

        public IJavaProxy CallObjectMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            Object.JavaPtr* res = callObjectMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
        }


        public bool CallBooleanMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callBooleanMethod(native, obj.Native, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public int CallIntMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            int res = callIntMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallShortMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callShortMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallLongMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callLongMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public byte CallByteMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callByteMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallDoubleMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callDoubleMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallFloatMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callFloatMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallCharMethod(IJavaProxy obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callCharMethod(native, obj.Native, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public void CallVoidMethod(IJavaProxy obj, string method, string signature, params object[] args)
        {
            CallVoidMethod(obj, method, signature, ConverArgs(args));
        }

        public IObject CallObjectMethod(IJavaProxy obj, string method, string signature, params object[] args)
        {
            return CallObjectMethod(obj, method, signature, ConverArgs(args));
        }

        public bool CallBooleanMethod(IJavaProxy obj, string method, string sig, params object[] args)
        {
            return CallBooleanMethod(obj, method, sig, ConverArgs(args));
        }

        public int CallIntMethod(IJavaProxy obj, string method, string signature, params object[] args)
        {
            return CallIntMethod(obj, method, signature, ConverArgs(args));
        }

        public string CallStringMethod(IJavaProxy obj, string method, string signature, params object[] args)
        {
            var str = (Object) CallObjectMethod(obj, method, signature, ConverArgs(args));
            byte b = 0;
            IntPtr chars = GetStringChars(str.native, &b);
            string result = Marshal.PtrToStringUni(chars);
            ReleaseStringChars(str.native, chars);
            return result;
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

        private IObject CallObjectMethod(IJavaProxy obj, string method, string sig, params Value[] args)
        {
            Class objectClass = GetObjectClass(obj);
            if (objectClass != null)
            {
                MethodId methodId = GetMethodID(objectClass, method, sig);
                if (methodId != null)
                {
                    return CallObjectMethod(obj, methodId, args);
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

        public TRes CallMethod<TRes>(IJavaProxy obj, string method, string sig, params object[] args)
        {
            return CallMethod<TRes>(obj, method, sig, ConverArgs(args));
        }

        private TRes CallMethod<TRes>(IJavaProxy obj, string method, string sig, params Value[] args)
        {
            MethodId idNative = GetMethodID(GetObjectClass(obj), method, sig);
            if (idNative != null)
            {
                if (typeof(IObject).IsAssignableFrom(typeof(TRes)))
                {
                    return (TRes) CallObjectMethod(obj, idNative, args);
                }
                if (typeof (string).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) (string) (String) CallObjectMethod(obj, idNative, args);
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

        public IJavaProxy GetObjectField(IJavaProxy obj, FieldId fieldID)
        {
            Object.JavaPtr* res = getObjectField(native, obj.Native, fieldID.native);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
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

        public int GetIntField(Object.JavaPtr* obj, FieldId fieldID)
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

        public IObject GetObjectField(IJavaProxy obj, string fieldName, string sig)
        {
            Class objectClass = obj.GetClass();
            if (objectClass != null)
            {
                FieldId id = GetStaticFieldID(objectClass, fieldName, sig);
                if (id != null)
                {
                    return GetObjectField(obj, id);
                }
            }
            throw new ArgumentException();
        }

        public TRes GetField<TRes>(IJavaProxy obj, string fieldName, string sig)
        {
            FieldId id = GetFieldID(obj.GetClass(), fieldName, sig);
            if (id != null)
            {
                if (typeof(IObject).IsAssignableFrom(typeof(TRes)))
                {
                    return (TRes) (object) GetObjectField(obj, id);
                }
                if (typeof (string).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) (string) (String) GetObjectField(obj, id);
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
                if (typeof(IObject).IsAssignableFrom(typeof(T)))
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
                if (typeof(IObject).IsAssignableFrom(typeof(T)))
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

        public IJavaProxy GetStaticObjectField(Class clazz, FieldId fieldID)
        {
            Object.JavaPtr* res = getStaticObjectField(native, clazz.native, fieldID.native);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
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
                if (typeof(IObject).IsAssignableFrom(typeof(TRes)))
                {
                    return (TRes) (object) GetStaticObjectField(objectClass, id);
                }
                if (typeof (string).IsAssignableFrom(typeof (TRes)))
                {
                    return (TRes) (object) (string) (String) GetStaticObjectField(objectClass, id);
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
            Object.JavaPtr* res = newDirectByteBuffer.Invoke(native, address, capacity);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
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
            IntPtr uni = Marshal.StringToHGlobalUni(unicode);
            Object.JavaPtr* res = newString(native, uni, unicode.Length);
            ExceptionTest();
            Marshal.FreeHGlobal(uni);
            return Wrap<String>(res);
        }

        internal IntPtr GetStringChars(Object.JavaPtr* str, byte* isCopy)
        {
            IntPtr res = getStringChars(native, str, isCopy);
            ExceptionTest();
            return res;
        }

        internal void ReleaseStringChars(Object.JavaPtr* str, IntPtr chars)
        {
            releaseStringChars(native, str, chars);
            ExceptionTest();
        }

        #endregion

        #region array

        internal int GetArrayLength(Object array)
        {
            return GetArrayLength(array.native);
        }

        internal int GetArrayLength(Object.JavaPtr* array)
        {
            int res = getArrayLength(native, array);
            ExceptionTest();
            return res;
        }

        internal IJavaProxy GetObjectArrayElement(Object array, int index)
        {
            return GetObjectArrayElement(array.native, index);
        }

        internal IJavaProxy GetObjectArrayElement(Object.JavaPtr* array, int index)
        {
            Object.JavaPtr* res = getObjectArrayElement(native, array, index);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
        }

        public Object NewObjectArray(int len, Class clazz, IJavaProxy init)
        {
            Object.JavaPtr* res = newObjectArray(native, len, clazz.native, init == null ? null : init.Native);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        public void SetObjectArrayElement(Object array, int index, IJavaProxy val)
        {
            SetObjectArrayElement(array, index, val == null ? null : val.Native);
        }

        public void SetObjectArrayElement(Object array, int index, Object.JavaPtr* val)
        {
            setObjectArrayElement(native, array.native, index, val);
            ExceptionTest();
        }

        internal Object NewBooleanArray(int len)
        {
            Object.JavaPtr* res = newBooleanArray(native, len);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        internal Object NewByteArray(int len)
        {
            Object.JavaPtr* res = newByteArray(native, len);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        internal Object NewShortArray(int len)
        {
            Object.JavaPtr* res = newShortArray(native, len);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        internal Object NewCharArray(int len)
        {
            Object.JavaPtr* res = newCharArray(native, len);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        internal Object NewIntArray(int len)
        {
            Object.JavaPtr* res = newIntArray(native, len);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        internal Object NewLongArray(int len)
        {
            Object.JavaPtr* res = newLongArray(native, len);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        internal Object NewFloatArray(int len)
        {
            Object.JavaPtr* res = newFloatArray(native, len);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        internal Object NewDoubleArray(int len)
        {
            Object.JavaPtr* res = newDoubleArray(native, len);
            ExceptionTest();
            return Wrap<Object>(res);
        }

        internal void GetIntArrayRegion(IJavaProxy array, int start, int len, int[] buf)
        {
            fixed (int* ptr = &buf[0])
            {
                getIntArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetCharArrayRegion(IJavaProxy array, int start, int len, char[] buf)
        {
            fixed (char* ptr = &buf[0])
            {
                getCharArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetByteArrayRegion(IJavaProxy array, int start, int len, byte[] buf)
        {
            fixed (byte* ptr = &buf[0])
            {
                getByteArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetShortArrayRegion(IJavaProxy array, int start, int len, short[] buf)
        {
            fixed (short* ptr = &buf[0])
            {
                getShortArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetLongArrayRegion(IJavaProxy array, int start, int len, long[] buf)
        {
            fixed (long* ptr = &buf[0])
            {
                getLongArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetFloatArrayRegion(IJavaProxy array, int start, int len, float[] buf)
        {
            fixed (float* ptr = &buf[0])
            {
                getFloatArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetDoubleArrayRegion(IJavaProxy array, int start, int len, double[] buf)
        {
            fixed (double* ptr = &buf[0])
            {
                getDoubleArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void GetBooleanArrayRegion(IJavaProxy array, int start, int len, bool[] buf)
        {
            fixed (bool* ptr = &buf[0])
            {
                getBooleanArrayRegion(native, array.Native, start, len, (byte*) ptr);
            }
            ExceptionTest();
        }

        public T[] ConvertArrayToNet<T>(IJavaProxy array)
        {
            return (T[]) ConvertArrayToNet(array, typeof (T));
        }

        public Array ConvertArrayToNet(IJavaProxy array, Type elementType)
        {
            int length = GetArrayLength((Object) array);
            Array res = Array.CreateInstance(elementType, length);
            if (!elementType.IsPrimitive)
            {
                for (int i = 0; i < length; i++)
                {
                    object element = Bridge.ToCLR(GetObjectArrayElement((Object)array, i));
                    res.SetValue(element, i);
                }
            }
            else if (elementType == typeof (int))
            {
                GetIntArrayRegion(array, 0, length, (int[]) res);
            }
            else if (elementType == typeof (char))
            {
                GetCharArrayRegion(array, 0, length, (char[]) res);
            }
            else if (elementType == typeof (byte))
            {
                GetByteArrayRegion(array, 0, length, (byte[]) res);
            }
            else if (elementType == typeof (long))
            {
                GetLongArrayRegion(array, 0, length, (long[]) res);
            }
            else if (elementType == typeof (short))
            {
                GetShortArrayRegion(array, 0, length, (short[]) res);
            }
            else if (elementType == typeof (double))
            {
                GetDoubleArrayRegion(array, 0, length, (double[]) res);
            }
            else if (elementType == typeof (float))
            {
                GetFloatArrayRegion(array, 0, length, (float[]) res);
            }
            else if (elementType == typeof (bool))
            {
                GetBooleanArrayRegion(array, 0, length, (bool[]) res);
            }
            else
            {
                throw new NotImplementedException();
            }
            return res;
        }

        internal void SetIntArrayRegion(IJavaProxy array, int start, int len, int[] buf)
        {
            fixed (int* ptr = &buf[0])
            {
                setIntArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetBooleanArrayRegion(IJavaProxy array, int start, int len, bool[] buf)
        {
            fixed (bool* ptr = &buf[0])
            {
                setBooleanArrayRegion(native, array.Native, start, len, (byte*) ptr);
            }
            ExceptionTest();
        }

        internal void SetByteArrayRegion(IJavaProxy array, int start, int len, byte[] buf)
        {
            fixed (byte* ptr = &buf[0])
            {
                setByteArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetCharArrayRegion(IJavaProxy array, int start, int len, char[] buf)
        {
            fixed (char* ptr = &buf[0])
            {
                setCharArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetShortArrayRegion(IJavaProxy array, int start, int len, short[] buf)
        {
            fixed (short* ptr = &buf[0])
            {
                setShortArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetLongArrayRegion(IJavaProxy array, int start, int len, long[] buf)
        {
            fixed (long* ptr = &buf[0])
            {
                setLongArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetFloatArrayRegion(IJavaProxy array, int start, int len, float[] buf)
        {
            fixed (float* ptr = &buf[0])
            {
                setFloatArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        internal void SetDoubleArrayRegion(IJavaProxy array, int start, int len, double[] buf)
        {
            fixed (double* ptr = &buf[0])
            {
                setDoubleArrayRegion(native, array.Native, start, len, ptr);
            }
            ExceptionTest();
        }

        public Object ConvertArrayToJava<T>(T[] array)
        {
            return ConvertArrayToJava(array, typeof (T));
        }

        public Object ConvertArrayToJava(Array array, Type type)
        {
            Object res;
            int length = array.Length;
            if (typeof(IObject).IsAssignableFrom(type))
            {
                res = NewObjectArray(length, JavaProxiesMap.TypeToKnownClass(type), null);
                for (int i = 0; i < array.Length; i++)
                {
                    SetObjectArrayElement(res, i, (IJavaProxy)array.GetValue(i));
                }
            }
            else if (typeof (string).IsAssignableFrom(type))
            {
                res = NewObjectArray(length, String._class, null);
                for (int i = 0; i < array.Length; i++)
                {
                    SetObjectArrayElement(res, i, (String) (string) array.GetValue(i));
                }
            }
            else if (typeof (int).IsAssignableFrom(type))
            {
                res = NewIntArray(length);
                SetIntArrayRegion(res, 0, length, (int[]) array);
            }
            else if (typeof (bool).IsAssignableFrom(type))
            {
                res = NewBooleanArray(length);
                SetBooleanArrayRegion(res, 0, length, (bool[]) array);
            }
            else if (typeof (long).IsAssignableFrom(type))
            {
                res = NewLongArray(length);
                SetLongArrayRegion(res, 0, length, (long[]) array);
            }
            else if (typeof (double).IsAssignableFrom(type))
            {
                res = NewDoubleArray(length);
                SetDoubleArrayRegion(res, 0, length, (double[]) array);
            }
            else if (typeof (byte).IsAssignableFrom(type))
            {
                res = NewByteArray(length);
                SetByteArrayRegion(res, 0, length, (byte[]) array);
            }
            else if (typeof (short).IsAssignableFrom(type))
            {
                res = NewShortArray(length);
                SetShortArrayRegion(res, 0, length, (short[]) array);
            }
            else if (typeof (float).IsAssignableFrom(type))
            {
                res = NewFloatArray(length);
                SetFloatArrayRegion(res, 0, length, (float[]) array);
            }
            else if (typeof (char).IsAssignableFrom(type))
            {
                res = NewCharArray(length);
                SetCharArrayRegion(res, 0, length, (char[]) array);
            }
            else
            {
                throw new NotImplementedException();
            }
            return res;
        }

        #endregion

        #region references

        internal Object.JavaPtr* NewGlobalRef(Object.JavaPtr* lobj)
        {
            if (lobj == null)
            {
                throw new ArgumentNullException("lobj");
            }
            Object.JavaPtr* res = newGlobalRef(native, lobj);
            //optimized away ExceptionTest();
            return res;
        }

        internal Object.JavaPtr* PopLocalFrame(Object.JavaPtr* result)
        {
            Object.JavaPtr* res = popLocalFrame(native, result);
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
            if (gref == null || gref.Native == null)
            {
                throw new ArgumentNullException("gref");
            }
            deleteGlobalRef(native, gref.Native);
            //optimized away ExceptionTest();
            gref.Native = null;
        }

        internal void DeleteLocalRef(Object.JavaPtr* lref)
        {
            if (lref == null)
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
            Object.JavaPtr* res = allocObject(native, clazz.native);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
        }

        public void NewObject(Class clazz, MethodId methodID, IJavaProxy obj, params Value[] args)
        {
            Object.JavaPtr* res = newObject(native, clazz.native, methodID.native, args);
            ExceptionTest();
            obj.Init(this, res, clazz);
        }

        public Object.JavaPtr* NewObjectPtr(Class clazz, MethodId methodID, params Value[] args)
        {
            Object.JavaPtr* res = newObject(native, clazz.native, methodID.native, args);
            ExceptionTest();
            return res;
        }

        public IJavaProxy NewObjectEx(Class clazz, MethodId methodID, params Value[] args)
        {
            Object.JavaPtr* res = newObject(native, clazz.native, methodID.native, args);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
        }

        public IObject NewObject(Class clazz, MethodId methodID, params Value[] args)
        {
            Object.JavaPtr* res = newObject(native, clazz.native, methodID.native, args);
            ExceptionTest();
            return Wrap<IJavaProxy>(res);
        }

        public IObject NewObject(Class clazz, string method, string sig, params object[] args)
        {
            MethodId idNative = GetMethodID(clazz, method, sig);
            if (idNative != null)
            {
                return NewObject(clazz, idNative, ConverArgs(args));
            }
            throw new ArgumentException();
        }

        #endregion

        #region exceptions

        public void Throw(Throwable ex)
        {
            Object.JavaPtr* ptr = ex.native;
            Throw(ptr);
        }

        internal void Throw(Object.JavaPtr* ptr)
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

        public Object.JavaPtr* ExceptionOccurred()
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
            Object.JavaPtr* occurred = ExceptionOccurred();
            if (null != occurred)
            {
                //ExceptionDescribe();
                ExceptionClear();
                IJavaProxy javaProxy;
                try
                {
                    javaProxy = Wrap<IJavaProxy>(occurred);
                }
                catch(Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                    Console.Error.WriteLine(ex);
                    throw;
                }
                var throwable = javaProxy as Throwable;
                if (throwable != null)
                {
                    throw throwable;
                }
                var clrProxy = javaProxy as IClrProxy;
                if (clrProxy == null)
                {
                    throw new JNIException("Can't convert exception:" + javaProxy.toString());
                }
                var exception = ClrProxiesMap.ToClr<Exception>(clrProxy);
                throw exception;
            }
        }

        public bool ExceptionRead()
        {
            Object.JavaPtr* occurred = ExceptionOccurred();
            if (null != occurred)
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
                IJavaProxy proxy = ClrProxiesMap.WrapClrObj(this, ex);
                Throw(proxy.Native);
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