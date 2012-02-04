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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using net.sf.jni4net.core;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Explicit), NativeCppClass]
    public struct JNIValue
    {
        public static JNIValue Null
        {
            get { return new JNIValue(); }
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

    public struct JNIValueOut
    {
        public JNIValueOut(JNIEnv env)
        {
            _outObject = env.NewObject(Registry.outWrapper.JVMApi, Registry.outWrapperConstructor);
        }

        internal readonly IntPtr _outObject;

        public static implicit operator JNIValue(JNIValueOut self)
        {
            return new JNIValue() { _object = self._outObject };
        }
    }

    public struct JNIValueRef
    {
        public JNIValueRef(IntPtr refHolder)
        {
            _refObject = refHolder;
        }

        internal readonly IntPtr _refObject;

        public static implicit operator JNIValue(JNIValueRef self)
        {
            return new JNIValue() { _object = self._refObject };
        }
    }
}
