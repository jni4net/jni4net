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
using java.lang;
using net.sf.jni4net.utils;
using Object=java.lang.Object;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Explicit, Size = 8), NativeCppClass]
    public struct Value
    {
        public static Value Null
        {
            get { return new Value(); }
        }

        public Value(IntPtr o)
        {
            _bool = 0;
            _byte = 0;
            _char = 0;
            _short = 0;
            _int = 0;
            _long = 0;
            _float = 0;
            _double = 0;
            _object = o;
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
            _object = IntPtr.Zero;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = Convertor.C2J(env, i);
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
            _object = IntPtr.Zero;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = Convertor.C2J(env, z);
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
            _object = IntPtr.Zero;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = Convertor.C2J(env, b);
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
            _object = IntPtr.Zero;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = Convertor.C2J(env, c);
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
            _object = IntPtr.Zero;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = Convertor.C2J(env, s);
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
            _object = IntPtr.Zero;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = Convertor.C2J(env, f);
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
            _object = IntPtr.Zero;

            JNIEnv env = JNIEnv.ThreadEnv;
            _object = Convertor.C2J(env, d);
        }

        public static Value CreateArray<T>(T[] o)
        {
            var v = new Value();
            JNIEnv env = JNIEnv.ThreadEnv;
            v._object = Convertor.C2J(env, o);
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
        [FieldOffset(0)] public IntPtr _object;
    }
}