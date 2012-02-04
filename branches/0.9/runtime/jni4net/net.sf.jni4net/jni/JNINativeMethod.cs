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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using net.sf.jni4net.core;

namespace net.sf.jni4net.jni
{
    [StructLayout(LayoutKind.Sequential, Size = 12), NativeCppClass]
    public struct JNINativeMethod
    {
        public IntPtr name; //char* 
        public IntPtr signature; //char* 
        public IntPtr fnPtr; //void*


        public JNINativeMethod(MethodInfo methodInfo, string javaName, string javaSignature)
        {
            fnPtr = MethodWrapper.CreateMethodPtr(methodInfo);
            name = Marshal.StringToHGlobalAnsi(javaName);
            signature = Marshal.StringToHGlobalAnsi(javaSignature);
        }

    }
}
