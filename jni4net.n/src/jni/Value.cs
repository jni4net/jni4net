#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Explicit, Size = 8), NativeCppClass]
    public struct Value
    {
        public static Value Null
        {
            get { return new Value(); }
        }

        [FieldOffset(0)] public byte _bool;
        [FieldOffset(0)] public byte _byte;
        [FieldOffset(0)] public short _char;
        [FieldOffset(0)] public short _short;
        [FieldOffset(0)] public int _int;
        [FieldOffset(0)] public long _long;
        [FieldOffset(0)] public float _float;
        [FieldOffset(0)] public double _double;
        [FieldOffset(0)] public JniHandle _object;
    }
}