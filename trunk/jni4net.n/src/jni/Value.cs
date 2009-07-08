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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using net.sf.jni4net.utils;
using Object=java.lang.Object;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Explicit, Size = 8), NativeCppClass]
    public unsafe struct Value
    {
        public Value(object o)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            init(o, JNIEnv.GetEnvForVm(null));
        }

        public Value(object o, JNIEnv env)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            init(o, env);
        }

        private void init(object o, JNIEnv env)
        {
            if (o == null)
            {
                _object = null;
            }
            else if (o is int)
            {
                _int = (int) o;
            }
            else if (o is bool)
            {
                _bool = ((bool) o) ? (byte) 1 : (byte) 0;
            }
            else if (o is byte)
            {
                _bool = ((byte) o);
            }
            else if (o is char)
            {
                _char = (short) ((char) o);
            }
            else if (o is short)
            {
                _short = ((short) o);
            }
            else if (o is long)
            {
                _long = ((long) o);
            }
            else if (o is float)
            {
                _float = ((float) o);
            }
            else if (o is double)
            {
                _double = ((double) o);
            }
            else if (o is Value)
            {
                _double = ((Value) o)._double;
            }
            else if (o is Object)
            {
                _object = ((Object) o).native;
            }
            else if (o is string)
            {
                _object = env.NewString(((string) o)).native;
            }
            else if (o is Array)
            {
                var a = o as Array;
                Type elementType = o.GetType().GetElementType();
                if (typeof (Object).IsAssignableFrom(elementType))
                {
                    Object array = env.NewObjectArray(a.Length, JavaProxiesMap.TypeToKnownClass(elementType), null);
                    _object = array.native;
                    for (int i = 0; i < a.Length; i++)
                    {
                        env.SetObjectArrayElement(array, i, (Object) a.GetValue(i));
                    }
                }
            }
            else
            {
                _object = ClrProxiesMap.WrapClr(env, o);
            }
        }

        public Value(int i)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _int = i;
        }

        public Value(bool z)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _bool = z ? (byte) 1 : (byte) 0;
        }

        public Value(byte b)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _byte = b;
        }

        public Value(char c)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _char = (short) c; //test
        }

        public Value(short s)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _char = s;
        }

        public Value(float f)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _float = f;
        }

        public Value(double d)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _double = d;
        }

        public Value(Object o)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _object = o.native;
        }

        public Value(IJavaProxy o)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _object = o.Native;
        }


        public Value(Value o)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            _double = o._double;
        }

        public Value(int[] i)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = env.ConvertArrayToJava(i).native;
        }

        public Value(bool[] z)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = env.ConvertArrayToJava(z).native;
        }

        public Value(byte[] b)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = env.ConvertArrayToJava(b).native;
        }

        public Value(char[] c)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = env.ConvertArrayToJava(c).native;
        }

        public Value(short[] s)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = env.ConvertArrayToJava(s).native;
        }

        public Value(float[] f)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = env.ConvertArrayToJava(f).native;
        }

        public Value(double[] d)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = null;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = env.ConvertArrayToJava(d).native;
        }

        public static Value CreateArray<T>(T[] o)
        {
            var v = new Value();
            JNIEnv env = JNIEnv.ThreadEnv;
            v._object = env.ConvertArrayToJava(o).native;
            return v;
        }

        [FieldOffset(0)] public byte _bool;
        [FieldOffset(0)] public byte _byte;
        [FieldOffset(0)] public short _char;
        [FieldOffset(0)] public short _short;
        [FieldOffset(0)] public int _int;
        [FieldOffset(0)] public long _long;
        [FieldOffset(0)] public float _float;
        [FieldOffset(0)] public double _double;
        [FieldOffset(0)] public void* _object;
    }
}