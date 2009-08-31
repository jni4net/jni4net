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

#if !JNI4NET_MINI
using System;

namespace java.lang.reflect
{
    [Flags]
    public enum ModifierFlags
    {
        None = 0x00000000,
        Public = 0x00000001,
        Private = 0x00000002,
        Protected = 0x00000004,
        Static = 0x00000008,
        Final = 0x00000010,
        Synchronized = 0x00000020,
        Volatile = 0x00000040,
        Transient = 0x00000080,
        Native = 0x00000100,
        Interface = 0x00000200,
        Abstract = 0x00000400,
        Strict = 0x00000800,
        Bridge = 0x00000040,
        Varargs = 0x00000080,
        Synthetic = 0x00001000,
        Annotation = 0x00002000,
        Enum = 0x00004000,
    }
}

#endif