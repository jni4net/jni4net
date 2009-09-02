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
using System.Reflection;
using System.Runtime.InteropServices;
using java.lang;
using net.sf.jni4net.attributes;
using net.sf.jni4net.jni;
using Exception=System.Exception;
using StringBuilder=System.Text.StringBuilder;

namespace net.sf.jni4net.utils
{
    partial class ClrProxiesMap
    {
        private static readonly Dictionary<Class, ClrProxyRecord> knownClasses = new Dictionary<Class, ClrProxyRecord>();
        private static readonly Dictionary<Type, ClrProxyRecord> knownReal = new Dictionary<Type, ClrProxyRecord>();
        private static readonly Dictionary<Type, ClrProxyRecord> knownWrappers = new Dictionary<Type, ClrProxyRecord>();
        private static bool initialized;

        public static void InitCore(JNIEnv env)
        {
            if (initialized)
            {
                return;
            }
            initialized = true;
            RegisterType(env, typeof (__Type), true);
            RegisterType(env, typeof (__Object), true);
            RegisterType(env, typeof (__String), true);
            WritePrimitiveRecord("int", typeof (int));
            WritePrimitiveRecord("long", typeof (long));
            WritePrimitiveRecord("short", typeof (short));
            WritePrimitiveRecord("char", typeof (char));
            WritePrimitiveRecord("byte", typeof (byte));
            WritePrimitiveRecord("double", typeof (double));
            WritePrimitiveRecord("float", typeof (float));
            WritePrimitiveRecord("void", typeof (void));
            WritePrimitiveRecord("boolean", typeof (bool));
        }

        public static void RegisterAssembly(JNIEnv env, Assembly assembly)
        {
            InitCore(env);
            foreach (Type type in assembly.GetTypes())
            {
                RegisterType(env, type, true);
            }
        }

        public static ClrProxyRecord RegisterType(JNIEnv env, Type wrapper, bool write)
        {
            ClrProxyRecord res;
            InitCore(env);
            if (write && knownWrappers.ContainsKey(wrapper))
            {
                return knownWrappers[wrapper];
            }
            ClrWrapperAttribute wrapperAttribute = GetClrProxyAttribute(wrapper);
            if (wrapperAttribute != null)
            {
                if (!Bridge.BindNative)
                {
                    res = CreateRecord(null, null, wrapper, wrapperAttribute.InterfaceType, null);
                    if (write)
                    {
                        WriteRecord(res);
                    }
                    return res;
                }
                return RegisterWrapper(env, wrapper, null, wrapperAttribute.InterfaceType, write);
            }

            return null;
        }

        private static unsafe ClrProxyRecord RegisterWrapper(JNIEnv env, Type wrapper, string name, Type real,
                                                             bool write)
        {
            string className = GetInterfaceName(name, wrapper);
            string proxyName = GetProxyName(name, wrapper);
            string staticName = GetStaticName(name, wrapper);
            Type type = real;
            if (type == null)
            {
                type = Type.GetType(className, true, true);
            }
            if (type == null)
            {
                throw new JNIException("Can't find real CLR type  for " + wrapper);
            }

            Class iface = env.FindClassNoThrow(className.Replace(".", "/"));
            if (iface == null)
            {
                Console.WriteLine("Can't find class     " + className);
                throw new JNIException("Can't find java class: " + className);
            }

            Class proxy = iface;
            Class stati = iface;
            if (type.IsInterface)
            {
                proxy = env.FindClassNoThrow(proxyName.Replace(".", "/"));
                stati = env.FindClassNoThrow(staticName.Replace(".", "/"));
            }
            if (proxy == null)
            {
                Console.WriteLine("Can't find proxy     " + proxyName);
                throw new JNIException("Can't find java proxy class: " + proxyName);
            }
            if (stati == null)
            {
                Console.WriteLine("Can't find proxy     " + staticName);
                throw new JNIException("Can't find java proxy class: " + staticName);
            }


            MethodInfo initMethod = wrapper.GetMethod("__Init", BindingFlags.Static | BindingFlags.NonPublic, null,
                                                      new[] {typeof (JNIEnv), typeof (Class)}, null);

            if (initMethod == null)
            {
                throw new JNIException("Can't find CLR type init method for " + wrapper);
            }
            MethodId constructor;
            if (type.IsInterface)
            {
                constructor = env.GetMethodID(proxy, "<init>", "()V");
            }
            else
            {
                constructor = env.GetMethodID(proxy, "<init>", "(Lnet/sf/jni4net/inj/INJEnv;I)V");
            }
            if (constructor == null)
            {
                throw new JNIException("Can't find java proxy constructor for " + proxyName);
            }


            var registrations = (List<JNINativeMethod>) initMethod.Invoke(null, new object[] {env, proxy});
            if (registrations.Count > 0)
            {
                if (Bridge.Debug)
                {
                    foreach (JNINativeMethod registration in registrations)
                    {
                        string n = Marshal.PtrToStringAnsi(registration.name);
                        string s = Marshal.PtrToStringAnsi(registration.signature);
                        if (env.GetMethodIDNoThrow(iface, n, s) == null)
                        {
                            try
                            {
                                env.GetStaticMethodID(iface, n, s);
                            }
                            catch (Exception ex2)
                            {
                                Console.Error.WriteLine(ex2);
                            }
                        }
                    }
                }
                JNINativeMethod[] methods = registrations.ToArray();
                fixed (JNINativeMethod* m = &(methods[0]))
                {
                    env.RegisterNatives(proxy, m, methods.Length);
                }
            }

            ClrProxyRecord res = CreateRecord(iface, proxy, wrapper, type, constructor);
            if (write)
            {
                WriteRecord(res);
            }
            stati.Invoke("InitJNI", "(Lnet/sf/jni4net/inj/INJEnv;Lsystem/Type;)V", null, real);
            return res;
        }

        private static ClrProxyRecord CreateRecord(Class iface, Class proxy, Type wrapper, Type real,
                                                   MethodId constructor)
        {
            return new ClrProxyRecord
                       {
                           iface = iface,
                           proxy = proxy,
                           wrapper = wrapper,
                           real = real,
                           constructor = constructor,
                       };
        }

        private static void WriteRecord(ClrProxyRecord record)
        {
            if (knownWrappers.ContainsKey(record.wrapper))
            {
                Console.Error.WriteLine("Duplicate wrap" + record.wrapper);
            }
            else
            {
                knownWrappers.Add(record.wrapper, record);
            }
            if (knownReal.ContainsKey(record.real))
            {
                if (!record.real.IsPrimitive)
                {
                    Console.Error.WriteLine("Duplicate real" + record.real);
                }
            }
            else
            {
                knownReal.Add(record.real, record);
            }
            if (record.iface != null)
            {
                if (knownClasses.ContainsKey(record.iface))
                {
                    Console.Error.WriteLine("Duplicate iface" + record.iface);
                }
                else
                {
                    knownClasses.Add(record.iface, record);
                }
            }
            if (record.proxy != record.iface)
            {
                if (knownClasses.ContainsKey(record.proxy))
                {
                    Console.Error.WriteLine("Duplicate proxy" + record.proxy);
                }
                else
                {
                    knownClasses.Add(record.proxy, record);
                }
            }
            if (Bridge.Verbose)
            {
                Console.WriteLine("Registered type " + record.iface);
            }
        }

        private static void ExpandRecord(Class clazz, ClrProxyRecord record)
        {
            knownClasses.Add(clazz, record);
        }

        private static void ExpandRealRecord(Type realType, ClrProxyRecord record)
        {
            knownReal.Add(realType, record);
        }

        private static void WritePrimitiveRecord(string name, Type type)
        {
            Class clazz = Class.getPrimitiveClass(name);
            WriteRecord(CreateRecord(clazz, clazz, type, type, null));
        }

        private static ClrWrapperAttribute GetClrProxyAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (ClrWrapperAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as ClrWrapperAttribute;
            }
            return null;
        }

        public static string GetTypeName(string className)
        {
            var name = new StringBuilder(className);
            for (int i = 0; i < className.LastIndexOf('.'); i++)
            {
                if (name[i] == '.')
                {
                    name[i + 1] = Char.ToUpperInvariant(name[i + 1]);
                }
            }
            name[0] = Char.ToUpperInvariant(name[0]);

            return name.ToString();
        }

        public static string GetInterfaceName(string attr, Type type)
        {
            string className = attr;
            if (className == null)
            {
                className = type.Namespace.ToLowerInvariant() + "." + type.Name.Replace("__", "");
                if (className == "java.lang.IObject")
                {
                    className = "java_.lang.IObject";
                }
            }
            return className;
        }

        private static string GetProxyName(string attr, Type type)
        {
            string className = attr;
            if (className == null)
            {
                className = type.Namespace.ToLowerInvariant() + "." + type.Name;
                if (className.StartsWith("java."))
                {
                    className = "java_." + className.Substring(5);
                }
            }
            return className;
        }

        private static string GetStaticName(string attr, Type type)
        {
            string className = attr;
            if (className == null)
            {
                className = type.Namespace.ToLowerInvariant() + "." + type.Name.Replace("__", "") + "_";
                if (className.StartsWith("java."))
                {
                    className = "java_." + className.Substring(5);
                }
            }
            return className;
        }

        #region Nested type: ClrProxyRecord

        public class ClrProxyRecord
        {
            public MethodId constructor;
            public Class iface;
            public Class proxy;
            public Type real;
            public Type wrapper;
        }

        #endregion
    }
}