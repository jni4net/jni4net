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
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static TRes StrongJp2C<TRes>(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return default(TRes);
            }
            object res = __IClrProxy.GetObject(env, obj);
            if (res == null && typeof(Delegate).IsAssignableFrom(typeof(TRes)))
            {
                //that's delegate implemented in Java
                RegistryRecord delRecord = Registry.GetCLRRecord(typeof(TRes));
                IJvmProxy jvmProxy = delRecord.CreateCLRProxy(env, obj);
                return (TRes)(object)Delegate.CreateDelegate(typeof(TRes), jvmProxy, delRecord.JVMDelegateInvoke);
            }
            return (TRes)res;
        }


        public static TRes StrongJ2Cp<TRes>(JNIEnv env, JniLocalHandle obj)
            where TRes : IJvmProxy
        {
            if (JniHandle.IsNull(obj))
            {
                return default(TRes);
            }
            Class clazz = env.GetObjectClass(obj);
            RegistryRecord record = Registry.GetJVMRecord(clazz);
            return (TRes) record.CreateCLRProxy(env, obj);
        }

        #region Well known

        public static string StrongJ2CString(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            string res = env.ConvertToString(obj);
            return res;
        }

        public static string StrongJp2CString(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            object res = __IClrProxy.GetObject(env, obj);
            return (string) res;
        }

        public static String StrongJ2CpString(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            return String.CreateProxy(env, obj);
        }

        public static Class StrongJ2CpClass(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            return Class.CreateProxy(env, obj);
        }

        public static Object StrongJ2CpObject(JNIEnv env, JniLocalHandle obj)
        {
            var res = new Object(env);
            ((IJvmProxy) res).Init(env, obj);
            return res;
        }

        #endregion
    }
}