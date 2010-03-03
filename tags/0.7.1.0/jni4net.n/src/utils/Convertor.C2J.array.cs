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
using java.lang;
using net.sf.jni4net.jni;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static JniLocalHandle ArrayFullC2J<TBoth, TElem>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            if (obj == null)
            {
                return JniLocalHandle.Zero;
            }
#if  DEBUG
            if (!typeof (TBoth).IsArray)
            {
                throw new ArgumentException("Must be array type");
            }
            if (typeof (TBoth).GetElementType() != typeof (TElem))
            {
                throw new ArgumentException("Must be array of type" + typeof (TElem));
            }
#endif
            var array = (Array) (object) obj;
            int length = array.Length;
            Type elementType = typeof (TBoth).GetElementType();
            Class elemClazz = Registry.GetCLRRecord(elementType).JVMInterface;

            JniLocalHandle res = env.NewObjectArrayPtr(length, elemClazz.jvmHandle, null);
            for (int i = 0; i < length; i++)
            {
                JniHandle item = FullC2J(env, (TElem)array.GetValue(i));
                env.SetObjectArrayElement(res, i, item);
            }
            return res;
        }

        public static JniLocalHandle ArrayStrongC2Jp<TBoth, TElem>(JNIEnv env, TBoth obj)
            where TBoth : class
            //should be where TBoth : Array
        {
            if (obj == null)
            {
                return JniLocalHandle.Zero;
            }
#if  DEBUG
            if (!typeof (TBoth).IsArray)
            {
                throw new ArgumentException("Must be array type");
            }
            if (typeof (TBoth).GetElementType() != typeof (TElem))
            {
                throw new ArgumentException("Must be array of type" + typeof (TElem));
            }
#endif
            var array = (Array) (object) obj;
            int length = array.Length;
            Type elementType = typeof (TBoth).GetElementType();
            Class elemClazz = Registry.GetCLRRecord(elementType).JVMInterface;

            JniLocalHandle res = env.NewObjectArrayPtr(length, elemClazz.jvmHandle, null);
            for (int i = 0; i < length; i++)
            {
                JniHandle item = StrongC2Jp(env, (TElem)array.GetValue(i));
                env.SetObjectArrayElement(res, i, item);
            }
            return res;
        }

        public static JniLocalHandle ArrayStrongCp2J<TBoth>(JNIEnv env, TBoth obj)
            where TBoth : class
            //should be where TBoth : IJvmProxy[]
        {
            if (obj == null)
            {
                return JniLocalHandle.Zero;
            }
#if  DEBUG
            if (!typeof (TBoth).IsArray)
            {
                throw new ArgumentException("Must be array type");
            }
#endif
            var array = (Array) (object) obj;
            int length = array.Length;
            Type elementType = typeof (TBoth).GetElementType();
            Class elemClazz = Registry.GetCLRRecord(elementType).JVMInterface;
            JniLocalHandle res = env.NewObjectArrayPtr(length, elemClazz.jvmHandle, null);
            for (int i = 0; i < length; i++)
            {
                JniHandle item = StrongCp2J((IJvmProxy)array.GetValue(i));
                env.SetObjectArrayElement(res, i, item);
            }
            return res;
        }

        #region Primitive Array

        public static JniLocalHandle ArrayStrongC2JString(JNIEnv env, string[] array)
        {
            if (array == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = array.Length;
            JniLocalHandle res = env.NewObjectArrayPtr(length, String._class.jvmHandle, null);
            for (int i = 0; i < length; i++)
            {
                JniLocalHandle item = env.NewStringPtr(array[i]);
                env.SetObjectArrayElement(res, i, item);
            }
            return res;
        }

        public static JniLocalHandle ArrayPrimC2J(JNIEnv env, int[] value)
        {
            if (value == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewIntArrayPtr(length);
            env.SetIntArrayRegion(res, 0, length, value);
            return res;
        }

        public static JniLocalHandle ArrayPrimC2J(JNIEnv env, long[] value)
        {
            if (value == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewLongArrayPtr(length);
            env.SetLongArrayRegion(res, 0, length, value);
            return res;
        }

        public static JniLocalHandle ArrayPrimC2J(JNIEnv env, short[] value)
        {
            if (value == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewShortArrayPtr(length);
            env.SetShortArrayRegion(res, 0, length, value);
            return res;
        }

        public static JniLocalHandle ArrayPrimC2J(JNIEnv env, byte[] value)
        {
            if (value == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewByteArrayPtr(length);
            env.SetByteArrayRegion(res, 0, length, value);
            return res;
        }

        public static JniLocalHandle ArrayPrimC2J(JNIEnv env, char[] value)
        {
            if (value == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewCharArrayPtr(length);
            env.SetCharArrayRegion(res, 0, length, value);
            return res;
        }

        public static JniLocalHandle ArrayPrimC2J(JNIEnv env, double[] value)
        {
            if (value == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewDoubleArrayPtr(length);
            env.SetDoubleArrayRegion(res, 0, length, value);
            return res;
        }

        public static JniLocalHandle ArrayPrimC2J(JNIEnv env, float[] value)
        {
            if (value == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewFloatArrayPtr(length);
            env.SetFloatArrayRegion(res, 0, length, value);
            return res;
        }

        public static JniLocalHandle ArrayPrimC2J(JNIEnv env, bool[] value)
        {
            if (value == null)
            {
                return JniLocalHandle.Zero;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewBooleanArrayPtr(length);
            env.SetBooleanArrayRegion(res, 0, length, value);
            return res;
        }

        #endregion
    }
}