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
using java.lang;
using net.sf.jni4net.attributes;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using Exception=System.Exception;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class JavaProxiesMap
    {
        private static readonly Dictionary<Class, JavaProxyRecord> knownClasses =
            new Dictionary<Class, JavaProxyRecord>();

        private static readonly Dictionary<Type, JavaProxyRecord> knownTypes = new Dictionary<Type, JavaProxyRecord>();

        private static bool initialized;

        public static void InitCore(JNIEnv env)
        {
            if (initialized)
            {
                return;
            }
            initialized = true;

            RegisterType(env, typeof (Object), true);
            RegisterType(env, typeof(String), true);
            RegisterType(env, typeof(Class), true);
            RegisterType(env, typeof(IClrProxy), true);

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
                if (typeof(IJavaProxy).IsAssignableFrom(type) || type.IsInterface)
                {
                    RegisterType(env, type, true);
                }
            }
        }

        public static JavaProxyRecord RegisterType(JNIEnv env, Type type, bool write)
        {
            InitCore(env);
            if (write && knownTypes.ContainsKey(type))
            {
                return knownTypes[type];
            }
            if (!Bridge.BindNative && (type == typeof (IClrProxy) || type == typeof (Bridge)))
            {
                if (env.FindClassNoThrow(type.FullName.Replace('.', '/')) == null)
                {
                    return null;
                }
            }
            if (type.BaseType != typeof (Object) && type.BaseType != typeof (object) &&
                type.BaseType != typeof (Exception) && type.BaseType != null)
            {
                RegisterType(env, type.BaseType, write);
            }
            JavaClassAttribute classAttribute = GetJavaClassAttribute(type);
            if (classAttribute != null)
            {
                var res = RegisterProxy(env, type, type, classAttribute.ClassName);
                if (write)
                {
                    WriteRecord(res);
                }
                return res;
            }
            JavaInterfaceAttribute interfaceAttribute = GetJavaInterfaceAttribute(type);
            if (interfaceAttribute != null)
            {
                string proxyName = type.FullName.Replace(type.Name, "__" + type.Name);
                Type proxy = type.Assembly.GetType(proxyName);
                var res = RegisterProxy(env, type, proxy, interfaceAttribute.ClassName);
                if (write)
                {
                    WriteRecord(res);
                }
                return res;
            }
            return null;
        }

        private static JavaProxyRecord RegisterProxy(JNIEnv env, Type iface, Type proxy, string name)
        {
            string className = GetClassName(name, iface);
            string replace = className.Replace(".", "/");
            Class clazz = env.FindClassNoThrow(replace);
            if (clazz == null)
            {
                Console.WriteLine("Can't find class     " + className);
                throw new JNIException("Can't find java class: " + className);
            }

            IConstructionHelper constructorhelper;
            Type[] types = proxy.GetNestedTypes();
            Type cnt = proxy.GetNestedType("ContructionHelper", BindingFlags.NonPublic | BindingFlags.Public);
            if (cnt == null)
            {
                Console.WriteLine("Can't find .NET ContructioHelper: " + proxy);
                throw new JNIException("Can't find .NET ContructioHelper: " + proxy);
            }

            ConstructorInfo constructor =
                cnt.GetConstructor(BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.Public, null,
                                   new Type[] {}, null);
            if (constructor == null)
            {
                Console.WriteLine("Can't find .NET ContructioHelper constructor: " + proxy);
                throw new JNIException("Can't find .NET ContructioHelper constructor: " + proxy);
            }
            constructorhelper = (IConstructionHelper) constructor.Invoke(null);

            MethodInfo initMethod = proxy.GetMethod("InitJNI", BindingFlags.NonPublic | BindingFlags.Static, null,
                                                    new[] {typeof (JNIEnv), typeof (Class)}, null);
            if (initMethod == null)
            {
                Console.WriteLine("Can't find .NET InitJNI: method" + proxy);
                throw new JNIException("Can't find .NET InitJNI method: " + proxy);
            }
            initMethod.Invoke(null, new object[] {env, clazz});

            return CreateRecord(className, clazz, iface, proxy, constructorhelper);
        }

        private static JavaProxyRecord CreateRecord(string clazzName,Class clazz, Type iface, Type proxy, IConstructionHelper constructor)
        {
            return new JavaProxyRecord
                       {
                           clazzName = clazzName,
                clazz = clazz,
                constructor = constructor,
                iface = iface,
                proxy = proxy
            };
        }

        private static void WriteRecord(JavaProxyRecord record)
        {
            knownTypes.Add(record.iface, record);
            if (record.iface != record.proxy)
            {
                knownTypes.Add(record.proxy, record);
            }
            knownClasses.Add(record.clazz, record);
            if (Bridge.Verbose)
            {
                Console.WriteLine("Registered " + record.iface);
            }
        }

        private static void ExpandRecord(Class clazz, JavaProxyRecord record)
        {
            knownClasses.Add(clazz, record);
        }

        private static void ExpandRecord(Type type, JavaProxyRecord record)
        {
            knownTypes.Add(type, record);
        }

        private static void WritePrimitiveRecord(string name, Type type)
        {
            Class clazz = Class.getPrimitiveClass(name);
            WriteRecord(CreateRecord(clazz.getName(), clazz, type, type, null));
        }

        private static JavaClassAttribute GetJavaClassAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (JavaClassAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as JavaClassAttribute;
            }
            return null;
        }

        private static JavaInterfaceAttribute GetJavaInterfaceAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (JavaInterfaceAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as JavaInterfaceAttribute;
            }
            return null;
        }

        private static JavaProxyAttribute GetJavaProxyAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (JavaProxyAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as JavaProxyAttribute;
            }
            return null;
        }

        private static string GetClassName(string attr, Type type)
        {
            string className = attr;
            if (className == null)
            {
                if (type.IsGenericType)
                {
                    int index = type.FullName.LastIndexOf('`');
                    className = type.FullName.Substring(0, index);
                }
                else
                {
                    className = type.FullName;
                }
                if (className.StartsWith("jni4net."))
                {
                    className = className.Substring("jni4net.".Length);
                }
            }
            return className;
        }

        #region Nested type: JavaProxyRecord

        public class JavaProxyRecord
        {
            public Class clazz;
            public string clazzName;
            public IConstructionHelper constructor;
            public Type iface;
            public Type proxy;
        }

        #endregion
    }
}