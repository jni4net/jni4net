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
using net.sf.jni4net;
using net.sf.jni4net.core;
using net.sf.jni4net.jni;
using net.sf.jni4net.jni.utils;

namespace java.lang
{
    public partial class Object : IJvmProxy, _IJvmProxy
    {
        // ReSharper disable InconsistentNaming
        internal protected JNIHandle j4n_handle;
        internal protected JvmInstanceInfo j4n_instanceInfo;

        protected Object(JNIEnv env, JNIHandle handle, JvmInstanceInfo instanceInfo)
        {
            j4n_handle = handle;
            j4n_instanceInfo = instanceInfo;
        }

        static internal IJvmProxy j4n_ProxyFactory(JNIEnv j4n_env, IntPtr j4n_handle, JvmInstanceInfo instanceInfo)
        {
            return new Object(j4n_env, j4n_env.NewGlobalRef(j4n_handle), instanceInfo);
        }

        #region Reference handling

        #region IJvmProxy Members

        void _IJvmProxy.SetJvmHandle(JNIHandle handle)
        {
            var disposable = j4n_handle as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
            j4n_handle = handle;
        }

        IntPtr IJvmProxy.JvmHandle
        {
            get { return j4n_handle.Handle; }
        }

        JvmInstanceInfo IJvmProxy.InstanceInfo
        {
            get { return j4n_instanceInfo; }
        }

        #endregion

        #endregion

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(this, obj))
            {
                return true;
            }
            var other = obj as Object;
            if (other == null)
            {
                return false;
            }
            JNIEnv env = JNIEnv.ThreadEnv;
            if (env.IsSameObjectnoCheck(this, other))
            {
                return true;
            }
            return equals(other);
        }

        public override int GetHashCode()
        {
            return hashCode();
        }

        public IClass getClass()
        {
            return j4n_instanceInfo.JVMInstance;
        }

        public static bool operator ==(Object a, Object b)
        {
            return JNIEnv.ThreadEnv.IsSameObjectnoCheck(a, b);
        }

        public static bool operator !=(Object a, Object b)
        {
            return !JNIEnv.ThreadEnv.IsSameObjectnoCheck(a, b);
        }

        public override string ToString()
        {
            return toString();
        }
    }
}