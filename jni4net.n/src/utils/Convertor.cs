#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
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

        public static void InitProxy(JNIEnv env, JniLocalHandle obj, object real)
        {
            long handle = IntHandle.Alloc(real);
            env.CallVoidMethod(obj, __IClrProxy._initProxy1, new Value {_long = handle});
        }
    }
}