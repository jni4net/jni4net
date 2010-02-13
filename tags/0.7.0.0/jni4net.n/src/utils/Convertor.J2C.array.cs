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
        public static TRes ArrayFullJ2C<TRes, TElem>(JNIEnv env, JniLocalHandle array)
            where TRes : class //should be TRes : Array
        {
            if (JniHandle.IsNull(array))
            {
                return default(TRes);
            }
            int length = env.GetArrayLength(array);
            var res = new TElem[length];
            for (int i = 0; i < length; i++)
            {
                JniLocalHandle elementPtr = env.GetObjectArrayElementPtr(array, i);
                var element = FullJ2C<TElem>(env, elementPtr);
                res.SetValue(element, i);
            }
            return (TRes) (object) res;
        }

        public static TRes ArrayStrongJp2C<TRes, TElem>(JNIEnv env, JniLocalHandle array)
            where TRes : class //should be TRes : Array
        {
            if (JniHandle.IsNull(array))
            {
                return default(TRes);
            }
            int length = env.GetArrayLength(array);
            var res = new TElem[length];
            for (int i = 0; i < length; i++)
            {
                JniLocalHandle elementPtr = env.GetObjectArrayElementPtr(array, i);
                var element = StrongJp2C<TElem>(env, elementPtr);
                res.SetValue(element, i);
            }
            return (TRes) (object) res;
        }

        public static TRes ArrayStrongJ2Cp<TRes, TElem>(JNIEnv env, JniLocalHandle array)
            where TElem : IJvmProxy
            where TRes : class //should be TRes : Array
        {
            if (JniHandle.IsNull(array))
            {
                return default(TRes);
            }
            int length = env.GetArrayLength(array);
            var res = new TElem[length];
            for (int i = 0; i < length; i++)
            {
                JniLocalHandle elementPtr = env.GetObjectArrayElementPtr(array, i);
                var element = StrongJ2Cp<TElem>(env, elementPtr);
                res.SetValue(element, i);
            }
            return (TRes) (object) res;
        }

        #region Well known

        public static String[] ArrayStrongJ2CpString(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new String[length];
            for (int i = 0; i < length; i++)
            {
                JniLocalHandle elementPtr = env.GetObjectArrayElementPtr(array, i);
                String element = StrongJ2CpString(env, elementPtr);
                res.SetValue(element, i);
            }
            return res;
        }

        public static string[] ArrayStrongJp2CString(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new string[length];
            for (int i = 0; i < length; i++)
            {
                JniLocalHandle elementPtr = env.GetObjectArrayElementPtr(array, i);
                String element = StrongJp2CString(env, elementPtr);
                res.SetValue(element, i);
            }
            return res;
        }

        public static string[] ArrayStrongJ2CString(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new string[length];
            for (int i = 0; i < length; i++)
            {
                JniLocalHandle elementPtr = env.GetObjectArrayElementPtr(array, i);
                string element = StrongJ2CString(env, elementPtr);
                res.SetValue(element, i);
            }
            return res;
        }

        public static Class[] ArrayStrongJ2CpClass(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new Class[length];
            for (int i = 0; i < length; i++)
            {
                JniLocalHandle elementPtr = env.GetObjectArrayElementPtr(array, i);
                Class element = StrongJ2CpClass(env, elementPtr);
                res.SetValue(element, i);
            }
            return res;
        }

        #endregion

        #region Primitive

        public static byte[] ArrayPrimJ2Cbyte(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new byte[length];
            env.GetByteArrayRegion(array, 0, length, res);
            return res;
        }

        public static bool[] ArrayPrimJ2Cboolean(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new bool[length];
            env.GetBooleanArrayRegion(array, 0, length, res);
            return res;
        }

        public static char[] ArrayPrimJ2Cchar(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new char[length];
            env.GetCharArrayRegion(array, 0, length, res);
            return res;
        }

        public static short[] ArrayPrimJ2Cshort(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new short[length];
            env.GetShortArrayRegion(array, 0, length, res);
            return res;
        }

        public static int[] ArrayPrimJ2Cint(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new int[length];
            env.GetIntArrayRegion(array, 0, length, res);
            return res;
        }

        public static long[] ArrayPrimJ2Clong(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new long[length];
            env.GetLongArrayRegion(array, 0, length, res);
            return res;
        }

        public static double[] ArrayPrimJ2Cdouble(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new double[length];
            env.GetDoubleArrayRegion(array, 0, length, res);
            return res;
        }

        public static float[] ArrayPrimJ2Cfloat(JNIEnv env, JniLocalHandle array)
        {
            if (JniLocalHandle.IsNull(array))
            {
                return null;
            }
            int length = env.GetArrayLength(array);
            var res = new float[length];
            env.GetFloatArrayRegion(array, 0, length, res);
            return res;
        }

        #endregion
    }
}