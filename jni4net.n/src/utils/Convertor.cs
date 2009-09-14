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
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    public static partial class Convertor
    {
        internal static MethodId boolObject;
        internal static MethodId boolValue;
        internal static MethodId byteObject;
        internal static MethodId byteValue;
        internal static MethodId charObject;
        internal static MethodId charValue;
        internal static MethodId doubleObject;
        internal static MethodId doubleValue;
        internal static MethodId floatObject;
        internal static MethodId floatValue;
        internal static MethodId intObject;

        internal static MethodId intValue;
        internal static MethodId longObject;
        internal static MethodId longValue;
        internal static MethodId shortObject;
        internal static MethodId shortValue;

        public static void InitProxy(JNIEnv env, IntPtr obj, object real)
        {
            int handle = IntHandle.Alloc(real);
            env.CallVoidMethod(obj, __ICClrProxy._initProxy1, new Value {_int = handle});
        }
    }
}