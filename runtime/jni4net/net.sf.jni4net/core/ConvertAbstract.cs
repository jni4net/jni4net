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

// ReSharper disable CanBeReplacedWithTryCastAndCheckForNull
// ReSharper disable RedundantAssignment

using System;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    public class ConvertAbstract
    {
        #region To JVM

        public static JNIValueRef ToRefParam<T>(JNIEnv env, T value, string classOfApi)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value, classOfApi));
            return new JNIValueRef(_outObject);
        }

        public static JNIValueRef ToRefParam<T>(JNIEnv env, T[] value, string classOfApi)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value, classOfApi));
            return new JNIValueRef(_outObject);
        }

        public static JNIValueRef ToRefParam<T>(JNIEnv env, T[][] value, string classOfApi)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value, classOfApi));
            return new JNIValueRef(_outObject);
        }


        public static JNIValue ToValue(JNIEnv env, object value, string classOfApi)
        {
            return new JNIValue { _object = ToPtr(env, value, classOfApi) };
        }

        public static JNIValue ToValue<T>(JNIEnv env, T[] value, string classOfApi)
        {
            return new JNIValue { _object = ToPtr(env, value, classOfApi) };
        }

        public static JNIValue ToValue<T>(JNIEnv env, T[][] value, string classOfApi)
        {
            return new JNIValue { _object = ToPtr(env, value, classOfApi) };
        }

        public static IntPtr ToWrappedPtr(JNIEnv env, object value, string classOfApi)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            var jvm = value as IJvmProxy;
            if (jvm != null)
            {
                return jvm.JvmHandle;
            }
            if (value is string)
            {
                if(classOfApi=="system.String")
                {
                    return ConvertString.ToWrappedPtr(env, (string)value);
                }
                return ConvertString.ToPtr(env, (string)value);
            }
            Type type = value.GetType();
            #region Primitive and array

            if (type.IsPrimitive)
            {
                if (value is int)
                {
                    return ConvertInt.ToWrappedPtr(env, (int)value);
                }
                if (value is bool)
                {
                    return ConvertBoolean.ToWrappedPtr(env, (bool)value);
                }
                if (value is long)
                {
                    return ConvertLong.ToWrappedPtr(env, (long)value);
                }
                if (value is byte)
                {
                    return ConvertByte.ToWrappedPtr(env, (byte)value);
                }
                if (value is float)
                {
                    return ConvertFloat.ToWrappedPtr(env, (float)value);
                }
                if (value is double)
                {
                    return ConvertDouble.ToWrappedPtr(env, (double)value);
                }
                if (value is char)
                {
                    return ConvertChar.ToWrappedPtr(env, (char)value);
                }
                if (value is short)
                {
                    return ConvertShort.ToWrappedPtr(env, (short)value);
                }
            }
            else if (type.IsArray)
            {
                if (value is int[])
                {
                    return ConvertInt.ToWrappedPtr(env, (int[])value);
                }
                if (value is bool[])
                {
                    return ConvertBoolean.ToWrappedPtr(env, (bool[])value);
                }
                if (value is long[])
                {
                    return ConvertLong.ToWrappedPtr(env, (long[])value);
                }
                if (value is byte[])
                {
                    return ConvertByte.ToWrappedPtr(env, (byte[])value);
                }
                if (value is float[])
                {
                    return ConvertFloat.ToWrappedPtr(env, (float[])value);
                }
                if (value is double[])
                {
                    return ConvertDouble.ToWrappedPtr(env, (double[])value);
                }
                if (value is char[])
                {
                    return ConvertChar.ToWrappedPtr(env, (char[])value);
                }
                if (value is short[])
                {
                    return ConvertShort.ToWrappedPtr(env, (short[])value);
                }
                if (value is string[])
                {
                    return ConvertString.ToWrappedPtr(env, (string[])value);
                }

                if (value is int[][])
                {
                    return ConvertInt.ToWrappedPtr(env, (int[][])value);
                }
                if (value is bool[][])
                {
                    return ConvertBoolean.ToWrappedPtr(env, (bool[][])value);
                }
                if (value is long[][])
                {
                    return ConvertLong.ToWrappedPtr(env, (long[][])value);
                }
                if (value is byte[][])
                {
                    return ConvertByte.ToWrappedPtr(env, (byte[][])value);
                }
                if (value is float[][])
                {
                    return ConvertFloat.ToWrappedPtr(env, (float[][])value);
                }
                if (value is double[][])
                {
                    return ConvertDouble.ToWrappedPtr(env, (double[][])value);
                }
                if (value is char[][])
                {
                    return ConvertChar.ToWrappedPtr(env, (char[][])value);
                }
                if (value is short[][])
                {
                    return ConvertShort.ToWrappedPtr(env, (short[][])value);
                }
                if (value is string[][])
                {
                    return ConvertString.ToPtr(env, (string[][])value);
                }
                if (value is object[][])
                {
                    return ToPtr(env, (object[][])value, classOfApi);
                }
                if (value is object[])
                {
                    return ToPtr(env, (object[])value, classOfApi);
                }
            }
            #endregion
            ProxyInfo proxyInfo = Registry.LookupAbstractToJvm(env, type, classOfApi);
            return proxyInfo.CLRProxyFactory(env, value, type);
        }

        public static IntPtr ToPtr(JNIEnv env, object value, string classOfApi)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            var jvm = value as IJvmProxy;
            if (jvm != null)
            {
                return jvm.JvmHandle;
            }
            if (value is string)
            {
                if (classOfApi == "system.String")
                {
                    return ConvertString.ToWrappedPtr(env, (string)value);
                }
                return ConvertString.ToPtr(env, (string)value);
            }
            Type type = value.GetType();
            #region Primitive and array

            if (type.IsPrimitive)
            {
                if (value is int)
                {
                    return ConvertInt.ToBoxedPtr(env, (int)value);
                }
                if (value is bool)
                {
                    return ConvertBoolean.ToBoxedPtr(env, (bool)value);
                }
                if (value is long)
                {
                    return ConvertLong.ToBoxedPtr(env, (long)value);
                }
                if (value is byte)
                {
                    return ConvertByte.ToBoxedPtr(env, (byte)value);
                }
                if (value is float)
                {
                    return ConvertFloat.ToBoxedPtr(env, (float)value);
                }
                if (value is double)
                {
                    return ConvertDouble.ToBoxedPtr(env, (double)value);
                }
                if (value is char)
                {
                    return ConvertChar.ToBoxedPtr(env, (char)value);
                }
                if (value is short)
                {
                    return ConvertShort.ToBoxedPtr(env, (short)value);
                }
            }
            else if (type.IsArray)
            {
                if (value is int[])
                {
                    return ConvertInt.ToPtr(env, (int[])value);
                }
                if (value is bool[])
                {
                    return ConvertBoolean.ToPtr(env, (bool[])value);
                }
                if (value is long[])
                {
                    return ConvertLong.ToPtr(env, (long[])value);
                }
                if (value is byte[])
                {
                    return ConvertByte.ToPtr(env, (byte[])value);
                }
                if (value is float[])
                {
                    return ConvertFloat.ToPtr(env, (float[])value);
                }
                if (value is double[])
                {
                    return ConvertDouble.ToPtr(env, (double[])value);
                }
                if (value is char[])
                {
                    return ConvertChar.ToPtr(env, (char[])value);
                }
                if (value is short[])
                {
                    return ConvertShort.ToPtr(env, (short[])value);
                }
                if (value is string[])
                {
                    return ConvertString.ToPtr(env, (string[])value);
                }

                if (value is int[][])
                {
                    return ConvertInt.ToPtr(env, (int[][])value);
                }
                if (value is bool[][])
                {
                    return ConvertBoolean.ToPtr(env, (bool[][])value);
                }
                if (value is long[][])
                {
                    return ConvertLong.ToPtr(env, (long[][])value);
                }
                if (value is byte[][])
                {
                    return ConvertByte.ToPtr(env, (byte[][])value);
                }
                if (value is float[][])
                {
                    return ConvertFloat.ToPtr(env, (float[][])value);
                }
                if (value is double[][])
                {
                    return ConvertDouble.ToPtr(env, (double[][])value);
                }
                if (value is char[][])
                {
                    return ConvertChar.ToPtr(env, (char[][])value);
                }
                if (value is short[][])
                {
                    return ConvertShort.ToPtr(env, (short[][])value);
                }
                if (value is string[][])
                {
                    return ConvertString.ToPtr(env, (string[][])value);
                }
                if (value is object[][])
                {
                    return ToPtr(env, (object[][])value, classOfApi);
                }
                if (value is object[])
                {
                    return ToPtr(env, (object[])value, classOfApi);
                }
            }
            #endregion
            ProxyInfo proxyInfo = Registry.LookupAbstractToJvm(env, type, classOfApi);
            return proxyInfo.CLRProxyFactory(env, value, type);
        }

        public static IntPtr ToWrappedPtr<T>(JNIEnv env, T[] value, string classOfApi)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }

            var arrApi = Registry.FindClass(env, classOfApi, null);
            IntPtr arr = env.NewObjectArray(arrApi, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    object value2 = value[i];
                    if (value2 != null)
                    {
                        var itemPtr = ToWrappedPtr(env, value2, classOfApi);
                        if (itemPtr != IntPtr.Zero)
                        {
                            env.SetObjectArrayElement(arr, i, itemPtr);
                        }
                    }
                }
                return arr;
            }
        }

        public static IntPtr ToPtr<T>(JNIEnv env, T[] value, string classOfApi)
        {
            if(value==null)
            {
                return IntPtr.Zero;
            }

            var arrApi = Registry.FindClass(env, classOfApi, null);
            IntPtr arr = env.NewObjectArray(arrApi, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    object value2 = value[i];
                    if (value2 != null)
                    {
                        var itemPtr = ToPtr(env, value2, classOfApi);
                        if(itemPtr!=IntPtr.Zero)
                        {
                            env.SetObjectArrayElement(arr, i, itemPtr);
                        }
                    }
                }
                return arr;
            }
        }

        public static IntPtr ToPtr<T>(JNIEnv env, T[][] value, string classOfApi)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            // optimize unnecesary array creation in make array ?
            var firstarr = ConvertClass.MakeArray(env, Registry.FindClass(env, classOfApi, null));
            IntPtr arr = env.NewObjectArray(firstarr, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    T[] arr2 = value[i];
                    if (arr2 != null)
                    {
                        env.SetObjectArrayElement(arr, i, ToPtr(env, arr2, classOfApi));
                    }
                }
                return arr;
            }
        }
        public static IntPtr ToWrappedPtr<T>(JNIEnv env, T[][] value, string classOfApi)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            // optimize unnecesary array creation in make array ?
            var firstarr = ConvertClass.MakeArray(env, Registry.FindClass(env, classOfApi, null));
            IntPtr arr = env.NewObjectArray(firstarr, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    T[] arr2 = value[i];
                    if (arr2 != null)
                    {
                        env.SetObjectArrayElement(arr, i, ToWrappedPtr(env, arr2, classOfApi));
                    }
                }
                return arr;
            }
        }

        public static long ToClrHandle(object value)
        {
            return LongClrHandle.Alloc(value);
        }

        #endregion
        
        #region To CLR

        public static void ToRefObject<T>(JNIEnv env, IntPtr refObject, T value, string classOfApi)
        {
            env.SetObjectField(refObject, Registry.refWrapperField, ToWrappedPtr(env, value, classOfApi));
        }

        public static void ToOutObject<T>(JNIEnv env, IntPtr outObject, T value, string classOfApi)
        {
            env.SetObjectField(outObject, Registry.outWrapperField, ToWrappedPtr(env, value, classOfApi));
        }

        public static void ToRefObject<T>(JNIEnv env, IntPtr refObject, T[] value, string classOfApi)
        {
            env.SetObjectField(refObject, Registry.refWrapperField, ToWrappedPtr(env, value, classOfApi));
        }

        public static void ToOutObject<T>(JNIEnv env, IntPtr outObject, T[] value, string classOfApi)
        {
            env.SetObjectField(outObject, Registry.outWrapperField, ToWrappedPtr(env, value, classOfApi));
        }

        public static void ToRefObject<T>(JNIEnv env, IntPtr refObject, T[][] value, string classOfApi)
        {
            env.SetObjectField(refObject, Registry.refWrapperField, ToWrappedPtr(env, value, classOfApi));
        }

        public static void ToOutObject<T>(JNIEnv env, IntPtr outObject, T[][] value, string classOfApi)
        {
            env.SetObjectField(outObject, Registry.outWrapperField, ToWrappedPtr(env, value, classOfApi));
        }

        public static void FromOutParam<T>(JNIEnv env, JNIValueOut param, out T value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            if (val == IntPtr.Zero)
            {
                value = default(T);
                return;
            }
            value = ToCLR<T>(env, val);
        }

        public static void FromOutParam<T>(JNIEnv env, JNIValueOut param, out T[] value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            if (val == IntPtr.Zero)
            {
                value = null;
                return;
            }
            value = ToCLRArray1<T>(env, val);
        }

        public static void FromOutParam<T>(JNIEnv env, JNIValueOut param, out T[][] value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            if (val == IntPtr.Zero)
            {
                value = null;
                return;
            }
            value = ToCLRArray11<T>(env, val);
        }

        public static void FromRefParam<T>(JNIEnv env, JNIValueRef param, ref T value)
        {
            value = FromRefObject<T>(env, param._refObject);
        }

        public static void FromRefParam<T>(JNIEnv env, JNIValueRef param, ref T[] value)
        {
            value = FromRefObjectArray1<T>(env, param._refObject);
        }

        public static void FromRefParam<T>(JNIEnv env, JNIValueRef param, ref T[][] value)
        {
            value = FromRefObjectArray11<T>(env, param._refObject);
        }

        public static T FromRefObject<T>(JNIEnv env, IntPtr refObject)
        {
            var val = env.GetObjectField(refObject, Registry.refWrapperField);
            if (val == IntPtr.Zero)
            {
                return default(T);
            }
            return ToCLR<T>(env, val);
        }

        public static T[] FromRefObjectArray1<T>(JNIEnv env, IntPtr refObject)
        {
            var val = env.GetObjectField(refObject, Registry.refWrapperField);
            if (val == IntPtr.Zero)
            {
                return null;
            }
            return ToCLRArray1<T>(env, val);
        }

        public static T[][] FromRefObjectArray11<T>(JNIEnv env, IntPtr refObject)
        {
            var val = env.GetObjectField(refObject, Registry.refWrapperField);
            if (val == IntPtr.Zero)
            {
                return null;
            }
            return ToCLRArray11<T>(env, val);
        }


        public static T CastToCLR<T>(object obj)
        {
            //we do this to check the cast is valid and to keep original instanceInfo
            if (obj == null)
            {
                return default(T);
            }
            var proxy = obj as IJvmProxy;
            if (proxy == null)
            {
                if(obj is T)
                {
                    return (T) obj;
                }
                throw new InvalidCastException("Can't cast " + obj.GetType().FullName + " to " + typeof (T).FullName);
            }
            JNIEnv env = JNIEnv.ThreadEnv;
            var proxyInfo = Registry.LookupAbstractToClr(env, proxy.InstanceInfo.JVMInstance, typeof(T));
            return (T)proxyInfo.JVMProxyFactory(env, proxy.JvmHandle, proxy.InstanceInfo);
        }

        public static T ToCLR<T>(JNIEnv env, IntPtr localHandle)
        {
#if DEBUG
            if (typeof(T).IsArray)
            {
                throw new ArgumentException("Use ToCLRArray1 instead");
            }
#endif
            if (localHandle == IntPtr.Zero)
            {
                return default(T);
            }
            var clsLocal = env.GetObjectClassNoCheck(localHandle);
            IClass clazz = ConvertClass.CreateClassProxy(env, clsLocal);
            var proxyInfo = Registry.LookupAbstractToClr(env, clazz, typeof(T));
            return (T)proxyInfo.JVMProxyFactory(env, localHandle, new JvmInstanceInfo(clazz, proxyInfo));
        }

        public static T[] ToCLRArray1<T>(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }

            int length = env.GetArrayLength(array);
            var res = new T[length];
            for (int i = 0; i < length; i++)
            {
                IntPtr element = env.GetObjectArrayElement(array, i);
                res[i] = ToCLR<T>(env, element);
            }
            return res;
        }

        public static T[][] ToCLRArray11<T>(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new T[length][];
            for (int i = 0; i < length; i++)
            {
                res[i] = ToCLRArray1<T>(env, env.GetObjectArrayElement(array, i));
            }
            return res;
        }

        #endregion
    }
}
