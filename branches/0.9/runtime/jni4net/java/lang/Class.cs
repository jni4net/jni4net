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
using System.Collections;
using System.Collections.Generic;
using net.sf.jni4net;
using net.sf.jni4net.core;
using net.sf.jni4net.jni;

namespace java.lang
{
    public sealed partial class Class : IClass
    {
        static readonly Hashtable classIdentity=new Hashtable();
        static readonly List<Class> earlyIdentity = new List<Class>();

        internal static IJvmProxy j4n_ProxyFactoryIdentity(
            JNIEnv j4n_env, IntPtr j4n_handle,
            JvmInstanceInfo j4n_instanceInfo)
        {
            j4n_instanceInfo.JVMInstance = j4n_TypeInfo.JVMApi;
            var clazz = new Class(j4n_env, new JNIHandle(j4n_handle), j4n_instanceInfo);
            if (!Registry.IsInitialized)
            {
                lock (classIdentity)
                {
                    int knownClass = earlyIdentity.IndexOf(clazz);
                    if (knownClass != -1)
                    {
                        // kill local
                        ((_IJvmProxy) clazz).SetJvmHandle(JNIHandle.Zero);
                        return earlyIdentity[knownClass];
                    }

                    //upgrade the handle
                    ((_IJvmProxy)clazz).SetJvmHandle(j4n_env.NewGlobalRef(j4n_handle));

                    earlyIdentity.Add(clazz);
                    return clazz;
                }
            }

            var canonic = (Class)classIdentity[clazz];
            if (canonic != null)
            {
                // kill local
                ((_IJvmProxy)clazz).SetJvmHandle(JNIHandle.Zero);

                //return known
                return canonic;
            }

            lock (classIdentity)
            {
                //upgrade the handle
                ((_IJvmProxy)clazz).SetJvmHandle(j4n_env.NewGlobalRef(j4n_handle));

                //register as canonic
                classIdentity[clazz] = clazz;
                return clazz;
            }
        }


        internal static void ResetIdentity()
        {
            lock (classIdentity)
            {
                earlyIdentity.Clear();
                classIdentity.Clear();
            }
        }
        
        internal static void UpgradeIdentity()
        {
            lock (classIdentity)
            {
                if (earlyIdentity!=null)
                {
                    foreach (var clazz in earlyIdentity)
                    {
                        if (clazz.j4n_instanceInfo.JVMInstance == null)
                        {
                            clazz.j4n_instanceInfo = new JvmInstanceInfo(_class, j4n_TypeInfo);
                        }
                        classIdentity.Add(clazz, clazz);
                    }
                    earlyIdentity.Clear();
                }
            }
        }


        private long hashCodeCache = long.MinValue;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as Class;
            if (other == null)
                return false;

            return JNIEnv.ThreadEnv.IsSameObjectnoCheck(this, other);
        }

        IClass IClass.getSuperclass()
        {
            return getSuperclass();
        }

        IClass[] IClass.getInterfaces()
        {
            return getInterfaces();
        }

        bool IClass.isAssignableFrom(IClass par0)
        {
            return isAssignableFrom((Class)par0);
        }

        bool IClass.isInterface()
        {
            return isInterface();
        }

        public override int GetHashCode()
        {
            if (hashCodeCache == long.MinValue)
            {
                hashCodeCache = hashCode();
            }
            return (int)hashCodeCache;
        }

        public static bool operator ==(Class x, Class y)
        {
            if ((object)x == null && (object)y == null)
                return true;
            if ((object)x == null || (object)y == null)
                return false;
            return x.Equals(y);
        }

        public static bool operator !=(Class x, Class y)
        {
            if ((object)x == null && (object)y == null)
                return false;
            if ((object)x == null || (object)y == null)
                return true;
            return !x.Equals(y);
        }

        public static bool operator ==(IClass x, Class y)
        {
            if (x == null && (object)y == null)
                return true;
            if (x == null || (object)y == null)
                return false;
            return x.Equals(y);
        }

        public static bool operator !=(IClass x, Class y)
        {
            if (x == null && (object)y == null)
                return false;
            if (x == null || (object)y == null)
                return true;
            return !x.Equals(y);
        }

        public static bool operator ==(Class x, IClass y)
        {
            if ((object)x == null && y == null)
                return true;
            if ((object)x == null || y == null)
                return false;
            return x.Equals(y);
        }

        public static bool operator !=(Class x, IClass y)
        {
            if ((object)x == null && y == null)
                return false;
            if ((object)x == null || y == null)
                return true;
            return !x.Equals(y);
        }

    }
}