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

// ReSharper disable RedundantAssignment

using System;
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    public class ConvertString
    {
        #region To JVM

        public static JNIValueRef ToRefParam(JNIEnv env, string value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValueRef ToRefParam(JNIEnv env, string[] value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValueRef ToRefParam(JNIEnv env, string[][] value)
        {
            var _outObject = env.NewObject(Registry.refWrapper.JVMApi, Registry.refWrapperConstructor, ToValue(env, value));
            return new JNIValueRef(_outObject);
        }

        public static JNIValue ToValue(JNIEnv env, string value)
        {
            return new JNIValue { _object = ToPtr(env, value) };
        }

        public static IntPtr ToPtr(JNIEnv env, string value)
        {
            return env.NewString(value);
        }

        public static JNIValue ToValue(JNIEnv env, string[] value)
        {
            return new JNIValue { _object = ToPtr(env, value) };
        }

        public static JNIValue ToValue(JNIEnv env, string[][] value)
        {
            return new JNIValue { _object = ToPtr(env, value) };
        }

        public static IntPtr ToWrappedPtr(JNIEnv env, string value)
        {
            return Registry.systemString.CLRProxyFactory(env, value, typeof(string));
        }

        public static IntPtr ToWrappedPtr(JNIEnv env, string[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr arr = env.NewObjectArray(Registry.systemString.JVMApi, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    string str = value[i];
                    if (str != null)
                    {
                        env.SetObjectArrayElement(arr, i, ToWrappedPtr(env, str));
                    }
                }
            }
            return arr;
        }

        public static IntPtr ToWrappedPtr(JNIEnv env, string[][] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr arr = env.NewObjectArray(Registry.systemString.JVMApiArray, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    string[] value2 = value[i];
                    if (value2 != null)
                    {
                        IntPtr arr2 = env.NewObjectArray(Registry.systemString.JVMApi, value.Length);
                        env.SetObjectArrayElement(arr, i, arr2);
                        using (new LocalFrame(env, value2.Length))
                        {
                            for (int j = 0; j < value2.Length; j++)
                            {
                                string str = value2[i];
                                if (str != null)
                                {
                                    env.SetObjectArrayElement(arr2, i, ToWrappedPtr(env, str));
                                }

                            }
                        }
                    }
                }
                return arr;
            }
        }

        public static IntPtr ToPtr(JNIEnv env, string[] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr arr = env.NewObjectArray(Registry.javaLangString.JVMApi, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    string str = value[i];
                    if (str != null)
                    {
                        env.SetObjectArrayElement(arr, i, env.NewString(str));
                    }
                }
            }
            return arr;
        }

        public static IntPtr ToPtr(JNIEnv env, string[][] value)
        {
            if (value == null)
            {
                return IntPtr.Zero;
            }
            IntPtr arr = env.NewObjectArray(Registry.javaLangString.JVMApiArray, value.Length);
            using (new LocalFrame(env, value.Length))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    string[] value2 = value[i];
                    if (value2 != null)
                    {
                        IntPtr arr2 = env.NewObjectArray(Registry.javaLangString.JVMApi, value.Length);
                        env.SetObjectArrayElement(arr, i, arr2);
                        using (new LocalFrame(env, value2.Length))
                        {
                            for (int j = 0; j < value2.Length; j++)
                            {
                                string str = value2[i];
                                if (str != null)
                                {
                                    env.SetObjectArrayElement(arr2, i, env.NewString(str));
                                }
                                
                            }
                        }
                    }
                }
                return arr;
            }
        }
        
        #endregion

        #region To CLR

        public static void FromOutParam(JNIEnv env, JNIValueOut param, out string value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            if (val == IntPtr.Zero)
            {
                value=null;
                return;
            }
            var clsLocal = env.GetObjectClassNoCheck(val);
            IClass clazz = ConvertClass.CreateClassProxy(env, clsLocal);
            if(clazz==Registry.javaLangString.JVMApi)
            {
                value=env.GetString(val);
                return;
            }
            value = (string)Registry.unwrap_ClrProxyFactory(env, val);
        }

        public static void FromOutParam(JNIEnv env, JNIValueOut param, out string[] value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            if (val == IntPtr.Zero)
            {
                value = null;
                return;
            }
            value = ToCLRArray1(env, val);
        }

        public static void FromOutParam(JNIEnv env, JNIValueOut param, out string[][] value)
        {
            var val = env.GetObjectField(param._outObject, Registry.outWrapperField);
            if (val == IntPtr.Zero)
            {
                value = null;
                return;
            }
            value = ToCLRArray11(env, val);
        }

        public static void FromRefParam(JNIEnv env, JNIValueRef param, ref string value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
            if (val == IntPtr.Zero)
            {
                value = null;
                return;
            }
            var clsLocal = env.GetObjectClassNoCheck(val);
            IClass clazz = ConvertClass.CreateClassProxy(env, clsLocal);
            if (clazz == Registry.javaLangString.JVMApi)
            {
                value = env.GetString(val);
                return;
            }
            value = (string)Registry.unwrap_ClrProxyFactory(env, val);
        }

        public static void FromRefParam(JNIEnv env, JNIValueRef param, ref string[] value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
            if (val == IntPtr.Zero)
            {
                value = null;
                return;
            }
            value = ToCLRArray1(env, val);
        }

        public static void FromRefParam(JNIEnv env, JNIValueRef param, ref string[][] value)
        {
            var val = env.GetObjectField(param._refObject, Registry.refWrapperField);
            if (val == IntPtr.Zero)
            {
                value = null;
                return;
            }
            value = ToCLRArray11(env, val);
        }

        public static string ToCLR(JNIEnv env, IntPtr localHandle)
        {
            if (localHandle == IntPtr.Zero)
            {
                return null;
            }
            var clsLocal = env.GetObjectClassNoCheck(localHandle);
            IClass clazz = ConvertClass.CreateClassProxy(env, clsLocal);
            if (clazz == Registry.javaLangString.JVMApiArray)
            {
                return env.GetString(localHandle);
            }
            return (string)Registry.unwrap_ClrProxyFactory(env, localHandle);
        }

        public static string[] ToCLRArray1(JNIEnv env, IntPtr array)
        {
            if (array==IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new string[length];

            var clsLocal = env.GetObjectClassNoCheck(array);
            IClass clazz = ConvertClass.CreateClassProxy(env, clsLocal);

            
            if (clazz == Registry.javaLangString.JVMApiArray)
            {
                using (new LocalFrame(env, length))
                {
                    for (int i = 0; i < length; i++)
                    {
                        res[i] = env.GetStringArrayElement(array, i);
                    }
                }
                return res;
            }
           
            using (new LocalFrame(env, length))
            {
                for (int i = 0; i < length; i++)
                {
                    var val = env.GetObjectArrayElement(array, i);
                    res[i] = (string)Registry.unwrap_ClrProxyFactory(env, val);
                }
            }
            return res;
        }

        public static string[][] ToCLRArray11(JNIEnv env, IntPtr array)
        {
            if (array == IntPtr.Zero)
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new string[length][];
            for (int i = 0; i < length; i++)
            {
                res[i] = ToCLRArray1(env, env.GetObjectArrayElement(array, i));
            }
            return res;
        }
        
        #endregion
    }
}
