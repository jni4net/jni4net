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
    public unsafe partial class JavaProxiesMap
    {
        public static T Wrap<T>(JNIEnv env, Object.JavaPtr* obj) where T : IJavaProxy
        {
            if (obj == null)
            {
                return default(T);
            }
            Type clrType = typeof (T);
            if (clrType == typeof (Class))
            {
                var nclazz = new Class(env);
                ((IJavaProxy) nclazz).Init(env, obj, Class._class);
                return (T) (object) nclazz;
            }
            if (clrType == typeof (String))
            {
                var nstring = new String(env);
                ((IJavaProxy) nstring).Init(env, obj, String._class);
                return (T) (object) nstring;
            }

            Class clazzExact;
            JavaProxyRecord record;
            //using (new LocalFrame(env, 10))
            {
                clazzExact = env.GetObjectClass(obj);
                record = ResolveClass(clazzExact);
            }

            IJavaProxy bestKnown = record.constructor.CreateProxy(env);
            if (bestKnown != null)
            {
                bestKnown.Init(env, obj, clazzExact);
                return (T) bestKnown;
            }
            return default(T);
        }

        public static T Wrap<T>(JNIEnv env, Object.JavaPtr* obj, Class clazzExact)
        {
            if (obj == null)
            {
                return default(T);
            }
            Type clrType = typeof (T);
            if (clrType == typeof (Class))
            {
                var nclazz = new Class(env);
                ((IJavaProxy) nclazz).Init(env, obj, Class._class);
                return (T) (object) nclazz;
            }
            if (clrType == typeof (String))
            {
                var nstring = new String(env);
                ((IJavaProxy) nstring).Init(env, obj, String._class);
                return (T) (object) nstring;
            }

            JavaProxyRecord record;
            //using (new LocalFrame(env, 10))
            {
                record = ResolveClass(clazzExact);
            }


            IJavaProxy bestKnown = record.constructor.CreateProxy(env);
            if (bestKnown != null)
            {
                bestKnown.Init(env, obj, clazzExact);
                return (T) bestKnown;
            }
            return default(T);
        }

        public static Class TypeToKnownClass(Type knownType)
        {
            return ResolveType(knownType).clazz;
        }

        private static JavaProxyRecord ResolveClass(Class clazzExact)
        {
            JavaProxyRecord result;
            if (knownClasses.TryGetValue(clazzExact, out result))
            {
                return result;
            }
            if (clazzExact.isArray())
            {
                JavaProxyRecord newClazz = knownClasses[Object._class];
                ExpandRecord(clazzExact, newClazz);
                return newClazz;
            }
            if (__IClrProxy._class != null && __IClrProxy._class.isAssignableFrom(clazzExact))
            {
                JavaProxyRecord newClazz = knownClasses[__IClrProxy._class];
                ExpandRecord(clazzExact, newClazz);
                return newClazz;
            }

            var unknown = new List<Class>();
            JavaProxyRecord known = null;
            unknown.Add(clazzExact);

            Class super = clazzExact.getSuperclass();
            while (super != Object._class)
            {
                if (knownClasses.TryGetValue(super, out result))
                {
                    known = result;
                    break;
                }
                unknown.Add(super);
                super = super.getSuperclass();
            }

            if (known != null)
            {
                foreach (Class newClazz in unknown)
                {
                    ExpandRecord(newClazz, known);
                }
                return known;
            }

            unknown = new List<Class>();
            super = clazzExact;
            while (known == null && super != Object._class)
            {
                foreach (Class ifc in super.getInterfaces())
                {
                    if (knownClasses.TryGetValue(ifc, out result))
                    {
                        known = result;
                        break;
                    }
                    foreach (Class ifcs in ifc.getInterfaces())
                    {
                        if (knownClasses.TryGetValue(ifcs, out result))
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
                unknown.Add(super);
                super = super.getSuperclass();
            }

            if (known == null)
            {
                known = knownClasses[Object._class];
            }

            foreach (Class newClazz in unknown)
            {
                ExpandRecord(newClazz, known);
            }
            return known;
        }

        private static JavaProxyRecord ResolveType(Type typeExact)
        {
            JavaProxyRecord result;
            if (knownTypes.TryGetValue(typeExact, out result))
            {
                return result;
            }

            var unknown = new List<Type>();
            JavaProxyRecord known = null;
            unknown.Add(typeExact);

            Type super = typeExact.BaseType;
            while (super != typeof (Object))
            {
                if (knownTypes.TryGetValue(super, out result))
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
                    ExpandRecord(newType, known);
                }
                return known;
            }

            unknown = new List<Type>();
            super = typeExact;
            while (known == null && super != typeof (Object))
            {
                foreach (Type ifc in super.GetInterfaces())
                {
                    if (knownTypes.TryGetValue(ifc, out result))
                    {
                        known = result;
                        break;
                    }
                    foreach (Type ifcs in ifc.GetInterfaces())
                    {
                        if (knownTypes.TryGetValue(ifcs, out result))
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
                unknown.Add(super);
                super = super.BaseType;
            }

            if (known == null)
            {
                known = knownTypes[typeof (Object)];
            }

            foreach (Type newType in unknown)
            {
                ExpandRecord(newType, known);
            }
            return known;
        }
    }
}