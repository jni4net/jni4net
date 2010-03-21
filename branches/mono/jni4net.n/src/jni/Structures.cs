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

namespace net.sf.jni4net.jni
{
    public enum JNIResult
    {
        JNI_OK = 0, /* success */
        JNI_ERR = (-1), /* unknown error */
        JNI_EDETACHED = (-2), /* thread detached from the VM */
        JNI_EVERSION = (-3), /* JNI version error */
        JNI_ENOMEM = (-4), /* not enough memory */
        JNI_EEXIST = (-5), /* VM already created */
        JNI_EINVAL = (-6), /* invalid arguments */
    }

    [StructLayout(LayoutKind.Sequential), NativeCppClass]
    public struct JavaVMOption
    {
        public IntPtr optionString; //char*
        public IntPtr extraInfo; //void*
    }
}