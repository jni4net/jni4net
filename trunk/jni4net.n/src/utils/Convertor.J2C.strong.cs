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
        public static TRes StrongJp2C<TRes>(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return default(TRes);
            }
            object res = __ICClrProxy.GetObject(env, obj);
            return (TRes) res;
        }


        public static TRes StrongJ2Cp<TRes>(JNIEnv env, IntPtr obj)
            where TRes : ICJvmProxy
        {
            if (obj == IntPtr.Zero)
            {
                return default(TRes);
            }
            Class clazz = env.GetObjectClass(obj);
            RegistryRecord record = Registry.GetJVMRecord(clazz);
            return (TRes) record.CreateCLRProxy(env, obj, clazz);
        }

        #region Well known

        public static string StrongJ2CString(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            string res = env.ConvertToString(obj);
            return res;
        }

        public static string StrongJp2CString(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            object res = __ICClrProxy.GetObject(env, obj);
            return (string) res;
        }

        public static String StrongJ2CpString(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            return String.CreateProxy(env, obj);
        }

        public static Class StrongJ2CpClass(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            return Class.CreateProxy(env, obj);
        }

        public static Object StrongJ2CpObject(JNIEnv env, IntPtr obj)
        {
            var res = new Object(env);
            ((ICJvmProxy) res).Init(env, obj, Object._class);
            return res;
        }

        #endregion
    }
}