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
            return WrapClrObj(env, real).Native;
        }

        public static IJavaProxy WrapClrObj(JNIEnv env, object real)
        {
            if (real == null)
            {
                return null;
            }
            var res = real as IJavaProxy;
            if (res != null)
            {
                return res;
            }
            var array = real as Array;
            if (array != null)
            {
                Class elemClazz = RealToKnownProxy(real.GetType().GetElementType());
                res = env.NewObjectArray(array.Length, elemClazz, null);
                for (int i = 0; i < array.Length; i++)
                {
                    IntPtr item = WrapClr(env, array.GetValue(i));
                    env.SetObjectArrayElement((Object) res, i, item);
                }
            }
            else
            {
                int clrHandle = IntHandle.Alloc(real);
                ClrProxyRecord record = ResolveRealType(real.GetType());
                res = env.NewObjectEx(record.proxy, record.constructor, new Value(), new Value(clrHandle));
            }
            return res;
        }

        public static IntPtr ConvertString(JNIEnv env, object real)
        {
            return env.NewString(real as string).native;
        }

        public static void InitProxy(JNIEnv env, IntPtr obj, object real)
        {
            JavaProxiesMap.Wrap<IClrProxy>(env, obj).initProxy(IntHandle.Alloc(real));
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
            var javaProxy = JavaProxiesMap.Wrap<IJavaProxy>(env, obj);
            var clrProxy = javaProxy as IClrProxy;
            if (clrProxy != null)
            {
                return ToClr<TRes>(clrProxy);
            }
            if (typeof (TRes) == typeof (string))
            {
                return (TRes) (object) (string) (String) javaProxy;
            }
            if (typeof (TRes).IsArray)
            {
                return (TRes) (object) env.ConvertArrayToNet(javaProxy, typeof (TRes).GetElementType());
            }
            return (TRes) javaProxy;
        }

        public static Class RealToKnownProxy(Type real)
        {
            return ResolveRealType(real).proxy;
        }

        public static Class RealToKnownIface(Type real)
        {
            return ResolveRealType(real).iface;
        }

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
    }
}