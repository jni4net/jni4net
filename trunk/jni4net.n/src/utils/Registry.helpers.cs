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

namespace net.sf.jni4net.utils
{
    partial class Registry
    {
        private static ClrWrapperAttribute GetClrWrapperAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (ClrWrapperAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as ClrWrapperAttribute;
            }
            return null;
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

        private static JavaProxyAttribute GetJavaProxyAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (JavaProxyAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as JavaProxyAttribute;
            }
            return null;
        }

        private static string GetStaticName(string package, string name, bool jvm)
        {
            package = GetPackageName(package, jvm);
            return package + "." + name + "_";
        }

        private static string GetProxyName(string package, string name, bool jvm)
        {
            package = GetPackageName(package, jvm);
            return package + ".__" + name;
        }

        private static string GetPackageName(string package, bool jvm)
        {
            if (jvm)
            {
                package = package.ToLowerInvariant();
                if (package.StartsWith("java."))
                {
                    package = "java_." + package.Substring(5);
                }
            }
            return package;
        }


        private static IConstructionHelper GetConstructor(Type proxy)
        {
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
            return (IConstructionHelper) constructor.Invoke(null);
        }


        private static MethodId GetJVMConstructor(JNIEnv env, Class proxy)
        {
            return env.GetMethodIDNoThrow(proxy, "<init>", "(Lnet/sf/jni4net/inj/INJEnv;J)V");
        }

        internal static MethodInfo GetWrapperInitializer(Type wrapperType, string name)
        {
            MethodInfo initializer = wrapperType.GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic, null,
                                                           new[] {typeof (JNIEnv), typeof (Class)}, null);
            if (initializer == null)
            {
                throw new JNIException("Can't find CLR type init method for " + wrapperType);
            }
            return initializer;
        }

        private static MethodInfo GetProxyInitializer(Type proxyType)
        {
            MethodInfo initMethod = proxyType.GetMethod("InitJNI", BindingFlags.NonPublic | BindingFlags.Static, null,
                                                        new[] {typeof (JNIEnv), typeof (Class)}, null);
            if (initMethod == null)
            {
                Console.WriteLine("Can't find .NET InitJNI: method" + proxyType);
                throw new JNIException("Can't find .NET InitJNI method: " + proxyType);
            }
            return initMethod;
        }

        internal static void RegisterNative(MethodInfo initializer, JNIEnv env, Class jvmProxy, Class jvmInterface)
        {
            var registrations = (List<JNINativeMethod>) initializer.Invoke(null, new object[] {env, jvmProxy});
            if (registrations.Count > 0)
            {
                if (Bridge.Setup.Debug)
                {
                    foreach (JNINativeMethod registration in registrations)
                    {
                        string n = Marshal.PtrToStringAnsi(registration.name);
                        string s = Marshal.PtrToStringAnsi(registration.signature);
                        if (env.GetMethodIDNoThrow(jvmInterface, n, s) == null)
                        {
                            if (env.GetStaticMethodIDNoThrow(jvmInterface, n, s) == null)
                            {
                                throw new JNIException("Can't find native method" + registration.name + "()" +
                                                       registration.signature + " in class " + jvmInterface);
                            }
                        }
                    }
                }
                try
                {
                    JNINativeMethod.Register(registrations, jvmProxy, env);
                }
                catch (Exception ex)
                {
                    throw new JNIException("Failed binding native methods for " + jvmInterface, ex);
                }
            }
        }

        private static void RegisterStaticAndMethods(RegistryRecord record, JNIEnv env)
        {
            try
            {
                record.CLRProxyInitMethod.Invoke(null, new object[] {env, record.JVMInterface});
            }
            catch (Exception ex)
            {
                throw new JNIException("Can't initialize proxy " + record.CLRName, ex);
            }
        }

        private static void RegisterTypeOf(RegistryRecord record, JNIEnv env)
        {
            MethodId constructor = knownCLR[typeof (Type)].JVMConstructor;
            var h = new Value {_long = IntHandle.Alloc(record.CLRInterface)};
            IntPtr clazz = Type_._class.jvmHandle;
            var typeInfo = new Value {_object = env.NewObjectPtr(clazz, constructor, Value.Null, h)};
            env.CallStaticVoidMethod(record.JVMStatic, "InitJNI", "(Lnet/sf/jni4net/inj/INJEnv;Lsystem/Type;)V",
                                     new[] {Value.Null, typeInfo});
            //record.JVMStatic.Invoke("InitJNI", "(Lnet/sf/jni4net/inj/INJEnv;Lsystem/Type;)V", null, record.CLRInterface);
        }

        public static string ClrSignature(Type type)
        {
            return GetSignature(type.FullName);
        }

        public static string GetSignature(string typeName)
        {
            string low = typeName.ToLowerInvariant();
            int arr = low.LastIndexOf("[");
            string array = "";
            while (arr != -1)
            {
                array += "[";
                low = low.Substring(0, arr);
                arr = low.LastIndexOf("[");
            }
            switch (low)
            {
                case "bool":
                case "boolean":
                case "system.boolean":
                    return array + "Z";
                case "int":
                case "int32":
                case "system.int32":
                    return array + "I";
                case "double":
                case "system.double":
                    return array + "D";
                case "float":
                case "single":
                case "system.single":
                    return array + "F";
                case "short":
                case "int16":
                case "system.int16":
                    return array + "S";
                case "long":
                case "int64":
                case "system.int64":
                    return array + "J";
                case "char":
                case "system.char":
                    return array + "C";
                case "byte":
                case "system.byte":
                    return array + "B";
                case "void":
                case "system.void":
                    return array + "V";
                default:
                    return array + "L" + typeName.Substring(0, low.Length).Replace('.', '/') + ";";
            }
        }

        internal static string JavaSignature(Class clazz)
        {
            string name = clazz.FullName;
            if (clazz.isPrimitive())
            {
                switch (name)
                {
                    case "boolean":
                        return "Z";
                    case "int":
                        return "I";
                    case "double":
                        return "D";
                    case "float":
                        return "F";
                    case "short":
                        return "S";
                    case "long":
                        return "J";
                    case "char":
                        return "C";
                    case "byte":
                        return "B";
                    case "void":
                        return "V";
                    default:
                        throw new NotImplementedException();
                }
            }
            if (clazz.isArray())
            {
                return name.Replace('.', '/');
            }
            return "L" + name.Replace('.', '/') + ";";
        }
    }
}