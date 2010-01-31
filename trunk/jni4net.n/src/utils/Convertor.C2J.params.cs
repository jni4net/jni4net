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
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static Value ParStrongCp2J(IJvmProxy obj)
        {
            var res = new Value {_object = StrongCp2J(obj).DangerousGetHandle()};
            return res;
        }

        public static Value ParStrongC2Jp<TBoth>(JNIEnv env, TBoth obj)
        {
            var res = new Value { _object = StrongC2Jp(env, obj) };
            return res;
        }

        public static Value ParArrayFullC2J<TBoth, TElem>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            var res = new Value { _object = ArrayFullC2J<TBoth, TElem>(env, obj).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayStrongC2Jp<TBoth, TElem>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            var res = new Value { _object = ArrayStrongC2Jp<TBoth, TElem>(env, obj).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayStrongCp2J<TBoth>(JNIEnv env, TBoth obj)
            where TBoth : class
        {
            var res = new Value { _object = ArrayStrongCp2J(env, obj).DangerousGetHandle() };
            return res;
        }

        public static Value ParFullC2J<TBoth>(JNIEnv env, TBoth obj)
        {
            var res = new Value { _object = FullC2J(env, obj) };
            return res;
        }

        #region Primitive

        public static Value ParStrongC2JString(JNIEnv env, string obj)
        {
            var res = new Value { _object = StrongC2JString(env, obj).DangerousGetHandle() };
            return res;
        }

        public static Value ParPrimC2J(int value)
        {
            var res = new Value {_int = value};
            return res;
        }

        public static Value ParPrimC2J(bool value)
        {
            var res = new Value {_bool = value ? (byte) 1 : (byte) 0};
            return res;
        }

        public static Value ParPrimC2J(byte value)
        {
            var res = new Value {_byte = value};
            return res;
        }

        public static Value ParPrimC2J(char value)
        {
            var res = new Value {_char = (short) value};
            return res;
        }

        public static Value ParPrimC2J(short value)
        {
            var res = new Value {_short = value};
            return res;
        }

        public static Value ParPrimC2J(JniLocalHandle value)
        {
            var res = new Value { _long = value.ToInt64() };
            return res;
        }

        public static Value ParPrimC2J(long value)
        {
            var res = new Value {_long = value};
            return res;
        }

        public static Value ParPrimC2J(float value)
        {
            var res = new Value {_float = value};
            return res;
        }

        public static Value ParPrimC2J(double value)
        {
            var res = new Value {_double = value};
            return res;
        }

        public static Value ParArrayStrongC2JString(JNIEnv env, string[] obj)
        {
            var res = new Value { _object = ArrayStrongC2JString(env, obj).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, int[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, bool[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, byte[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, char[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, short[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, long[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, float[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value).DangerousGetHandle() };
            return res;
        }

        public static Value ParArrayPrimC2J(JNIEnv env, double[] value)
        {
            var res = new Value { _object = ArrayPrimC2J(env, value).DangerousGetHandle() };
            return res;
        }

        #endregion
    }
}