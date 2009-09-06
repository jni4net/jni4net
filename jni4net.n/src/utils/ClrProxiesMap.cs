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
using System.Collections.Generic;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    public partial class ClrProxiesMap
    {
        public static IntPtr WrapClr(JNIEnv env, object real)
        {
            return Convertor.C2J(env, real);
        }

        public static IntPtr ConvertString(JNIEnv env, object real)
        {
            return env.NewString(real as string).native;
        }

        public static void InitProxy(JNIEnv env, IntPtr obj, object real)
        {
            Convertor.InitProxy(env, obj, real);
        }

        public static TRes ToClr<TRes>(IClrProxy clrProxy)
        {
            int handle = clrProxy.getClrHandle();
            if (handle == 0)
            {
                throw new NullReferenceException();
            }
            return (TRes) IntHandle.ToObject(handle);
        }

        public static TRes ToClr<TRes>(JNIEnv env, IntPtr obj)
        {
            return Convertor.J2C<TRes>(env, obj);
        }

        /*
        public static bool IsKnownReal(Type real)
        {
            return knownReal.ContainsKey(real);
        }

        private static ClrProxyRecord ResolveRealType(Type typeReal)
        {
            ClrProxyRecord result;
            if (knownReal.TryGetValue(typeReal, out result))
            {
                return result;
            }

            var unknown = new List<Type>();
            ClrProxyRecord known = null;
            unknown.Add(typeReal);

            Type super = typeReal.BaseType;
            while (super != typeof (object))
            {
                if (knownReal.TryGetValue(super, out result))
                {
                    known = result;
                    break;
                }
                unknown.Add(super);
                super = super.BaseType;
            }

            if (known != null)
            {
                foreach (Type newType in unknown)
                {
                    ExpandRealRecord(newType, known);
                }
                return known;
            }

            unknown = new List<Type>();
            super = typeReal;
            while (known == null && super != typeof (object))
            {
                foreach (Type ifc in super.GetInterfaces())
                {
                    if (!ifc.IsAssignableFrom(super.BaseType))
                    {
                        if (knownReal.TryGetValue(ifc, out result))
                        {
                            known = result;
                            break;
                        }
                        foreach (Type ifcs in ifc.GetInterfaces())
                        {
                            if (knownReal.TryGetValue(ifcs, out result))
                            {
                                known = result;
                                break;
                            }
                        }
                        if (known != null)
                        {
                            break;
                        }
                    }
                }
                unknown.Add(super);
                super = super.BaseType;
            }

            if (known == null)
            {
                known = knownReal[typeof (object)];
            }

            foreach (Type newType in unknown)
            {
                ExpandRealRecord(newType, known);
            }
            return known;
        }
         */
    }
}