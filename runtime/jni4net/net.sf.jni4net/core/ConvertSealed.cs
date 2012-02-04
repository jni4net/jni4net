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
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    public class ConvertSealed
    {
        #region To JVM

        public static JNIValueRef ToRefParam<T>(JNIEnv env, T value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValueRef ToRefParam<T>(JNIEnv env, T[] value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValueRef ToRefParam<T>(JNIEnv env, T[][] value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValue ToValue<T>(JNIEnv env, T value)
        {
            return new JNIValue { _object = ToPtr<T>(env, value) };
        }

        public static JNIValue ToValue<T>(JNIEnv env, T[] value)
        {
            return new JNIValue { _object = ToPtr<T>(env, value) };
        }

        public static JNIValue ToValue<T>(JNIEnv env, T[][] value)
        {
            return new JNIValue { _object = ToPtr<T>(env, value) };
        }

        public static IntPtr ToPtr<T>(JNIEnv env, T value)
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
                return ConvertString.ToPtr(env, (string)(object)value);
            }
            Type type = typeof(T);
            #region Primitive and array
            //could it happen ? Primitive and array ? 
            if (type.IsPrimitive)
            {
                if (value is int)
                {
                    return ConvertInt.ToBoxedPtr(env, (int)(object)value);
                }
                if (value is bool)
                {
                    return ConvertBoolean.ToBoxedPtr(env, (bool)(object)value);
                }
                if (value is long)
                {
                    return ConvertLong.ToBoxedPtr(env, (long)(object)value);
                }
                if (value is byte)
                {
                    return ConvertByte.ToBoxedPtr(env, (byte)(object)value);
                }
                if (value is float)
                {
                    return ConvertFloat.ToBoxedPtr(env, (float)(object)value);
                }
                if (value is double)
                {
                    return ConvertDouble.ToBoxedPtr(env, (double)(object)value);
                }
                if (value is char)
                {
                    return ConvertChar.ToBoxedPtr(env, (char)(object)value);
                }
                if (value is short)
                {
                    return ConvertShort.ToBoxedPtr(env, (short)(object)value);
                }
            }
            else if (type.IsArray)
            {
                if (value is int[])
                {
                    return ConvertInt.ToPtr(env, (int[])(object)value);
                }
                if (value is bool[])
                {
                    return ConvertBoolean.ToPtr(env, (bool[])(object)value);
                }
                if (value is long[])
                {
                    return ConvertLong.ToPtr(env, (long[])(object)value);
                }
                if (value is byte[])
                {
                    return ConvertByte.ToPtr(env, (byte[])(object)value);
                }
                if (value is float[])
                {
                    return ConvertFloat.ToPtr(env, (float[])(object)value);
                }
                if (value is double[])
                {
                    return ConvertDouble.ToPtr(env, (double[])(object)value);
                }
                if (value is char[])
                {
                    return ConvertChar.ToPtr(env, (char[])(object)value);
                }
                if (value is short[])
                {
                    return ConvertShort.ToPtr(env, (short[])(object)value);
                }
                if (value is string[])
                {
                    return ConvertString.ToPtr(env, (string[])(object)value);
                }

                if (value is int[][])
                {
                    return ConvertInt.ToPtr(env, (int[][])(object)value);
                }
                if (value is bool[][])
                {
                    return ConvertBoolean.ToPtr(env, (bool[][])(object)value);
                }
                if (value is long[][])
                {
                    return ConvertLong.ToPtr(env, (long[][])(object)value);
                }
                if (value is byte[][])
                {
                    return ConvertByte.ToPtr(env, (byte[][])(object)value);
                }
                if (value is float[][])
                {
                    return ConvertFloat.ToPtr(env, (float[][])(object)value);
                }
                if (value is double[][])
                {
                    return ConvertDouble.ToPtr(env, (double[][])(object)value);
                }
                if (value is char[][])
                {
                    return ConvertChar.ToPtr(env, (char[][])(object)value);
                }
                if (value is short[][])
                {
                    return ConvertShort.ToPtr(env, (short[][])(object)value);
                }
                if (value is string[][])
                {
                    return ConvertString.ToPtr(env, (string[][])(object)value);
                }
                if (value is T[][])
                {
                    return ToPtr<T>(env, (T[][])(object)value);
                }
                if (value is T[])
                {
                    return ToPtr<T>(env, (T[])(object)value);
                }
            }
            #endregion

            ProxyInfo proxyInfo = Registry.LookupSealedToJvm(env, type);
            return proxyInfo.CLRProxyFactory(env, value, null);
        }

        public static IntPtr ToPtr<T>(JNIEnv env, T[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }

            var arrApi = Registry.LoadProxyByType(typeof (T));
            IntPtr arr = env.NewObjectArray(arrApi.JVMApi, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    T value2 = value[i];
                    if (value2 != null)
                    {
                        var itemPtr = ToPtr(env, value2);
                        if (itemPtr != IntPtr.Zero)
                        {
                            env.SetObjectArrayElement(arr, i, itemPtr);
                        }
                    }
                }
                return arr;
            }
        }

        public static IntPtr ToPtr<T>(JNIEnv env, T[][] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            // optimize unnecesary array creation in make array ?
            var arrApi = Registry.LoadProxyByType(typeof(T));
            var firstarr = ConvertClass.MakeArray(env, arrApi.JVMApi);
            IntPtr arr = env.NewObjectArray(firstarr, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    T[] arr2 = value[i];
                    if (arr2 != null)
                    {
                        env.SetObjectArrayElement(arr, i, ToPtr(env, arr2));
                    }
                }
                return arr;
            }
        }


        #endregion

        #region To CLR

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

        public static void FromRefParam<T>(JNIEnv env, JNIValueRef param, ref T value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
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

        public static void FromRefParam<T>(JNIEnv env, JNIValueRef param, ref T[] value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
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

        public static void FromRefParam<T>(JNIEnv env, JNIValueRef param, ref T[][] value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
            if (val == IntPtr.Zero)
            {
                value = null;
                return;
            }
            value = ToCLRArray11<T>(env, val);
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
                if (obj is T)
                {
                    return (T)obj;
                }
                throw new InvalidCastException("Can't cast " + obj.GetType().FullName + " to " + typeof(T).FullName);
            }
            JNIEnv env = JNIEnv.ThreadEnv;
            var proxyInfo = Registry.LookupSealedToClr(env, typeof(T));
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
            var proxyInfo = Registry.LookupSealedToClr(env, typeof(T));
            return (T)proxyInfo.JVMProxyFactory(env, localHandle, new JvmInstanceInfo(proxyInfo.JVMApi, proxyInfo));
        }

        public static T[] ToCLRArray1<T>(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            var proxyInfo = Registry.LookupSealedToClr(env, typeof(T));
            int length = env.GetArrayLength(array);
            var res = new T[length];
            for (int i = 0; i < length; i++)
            {
                IntPtr element = env.GetObjectArrayElement(array, i);
                if (element != IntPtr.Zero)
                {
                    res[i] = (T)proxyInfo.JVMProxyFactory(env, element, new JvmInstanceInfo(proxyInfo.JVMApi, proxyInfo));
                }
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
