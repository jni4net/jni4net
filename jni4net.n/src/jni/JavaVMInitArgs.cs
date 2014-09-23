#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Sequential), NativeCppClass]
    public unsafe struct JavaVMInitArgs
    {
        public int version;
        public int nOptions;
        public JavaVMOption* options;
        public byte ignoreUnrecognized;
    }
}