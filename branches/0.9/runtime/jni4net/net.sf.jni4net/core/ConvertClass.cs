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
using java.lang;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.core
{
    public static class ConvertClass
    {
        #region To JVM

        #endregion

        #region To CLR

        public static T ToCLR<T>(JNIEnv env, IntPtr localHandle)
        {
            if (localHandle==IntPtr.Zero)
            {
                return default(T);
            }
            return (T)Registry.javaLangClass.JVMProxyFactory(env, localHandle, new JvmInstanceInfo(Registry.javaLangClass.JVMApi, Registry.javaLangClass));
        }

        internal static IClass CreateClassProxy(JNIEnv env, IntPtr classHandle)
        {
            return (IClass)Registry.javaLangClass.JVMProxyFactory(env, classHandle, new JvmInstanceInfo(Registry.javaLangClass.JVMApi, Registry.javaLangClass));
        }

        internal static IClass MakeArray(JNIEnv env, IClass elementClass)
        {
            //cache ?
            return CreateClassProxy(env, env.GetObjectClass(env.NewObjectArray(elementClass, 0)));
        }

        #endregion
    }
}
