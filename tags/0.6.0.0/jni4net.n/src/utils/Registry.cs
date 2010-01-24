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
using System.Security.Permissions;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;

namespace net.sf.jni4net.utils
{
    [ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
    public partial class Registry
    {
        public static RegistryRecord GetRecord(JNIEnv env, JniHandle obj, Class iface)
        {
            lock (typeof (Registry))
            {
                RegistryRecord res;
                if (knownJVM.TryGetValue(iface, out res))
                {
                    return res;
                }
                Type clr = IsCLR(iface, obj, env);
                if (clr != null)
                {
                    return ResolveNew(clr);
                }
                return ResolveNew(iface);
            }
        }

        public static RegistryRecord GetRecord(object obj)
        {
            Type iface = obj.GetType();
            lock (typeof (Registry))
            {
                RegistryRecord res;
                if (knownCLR.TryGetValue(iface, out res))
                {
                    return res;
                }
                var proxy = obj as IJvmProxy;
                if (proxy != null)
                {
                    return ResolveNew(proxy.getClass());
                }
                return ResolveNew(iface);
            }
        }

        internal static RegistryRecord GetCLRRecord(Type iface)
        {
            lock (typeof (Registry))
            {
                RegistryRecord res;
                if (knownCLR.TryGetValue(iface, out res))
                {
                    return res;
                }
                return ResolveNew(iface);
            }
        }

        internal static RegistryRecord GetJVMRecord(Class iface)
        {
            lock (typeof (Registry))
            {
                RegistryRecord res;
                if (knownJVM.TryGetValue(iface, out res))
                {
                    return res;
                }
                return ResolveNew(iface);
            }
        }

        private static Type IsCLR(Class iface, JniHandle obj, JNIEnv env)
        {
            if (IClrProxy_._class.isAssignableFrom(iface))
            {
                object real = __IClrProxy.GetObject(env, obj);
                return real.GetType();
            }
            return null;
        }
    }
}