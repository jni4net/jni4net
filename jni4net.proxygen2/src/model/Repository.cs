#region Copyright (C) 2009 by Pavel Savara
/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.proxygen.generator;
using Type=System.Type;

namespace net.sf.jni4net.proxygen.model
{
    internal partial class Repository
    {
        public static ToolConfig config;
        private static readonly Dictionary<Type, GType> knownTypes = new Dictionary<Type, GType>();
        private static readonly Dictionary<Class, GType> knownClasses = new Dictionary<Class, GType>();
        private static readonly Dictionary<string, GType> knownNames = new Dictionary<string, GType>();
        private static List<Assembly> knownAssemblies = new List<Assembly>();
        private static List<GType> all = new List<GType>();

        public static void Analyze()
        {
            foreach (GType type in new List<GType>(all))
            {
                PreLoadMethods(type, false,false);
            }
            foreach (GType type in new List<GType>(all))
            {
                type.Resolve();
            }
            foreach (GType type in new List<GType>(all))
            {
                type.UpdateNames();
            }
            foreach (GType type in new List<GType>(all))
            {
                LoadMethods(type);
            }
            foreach (GType type in new List<GType>(all))
            {
                type.UpdateMethods();
            }
            if (config.Verbose)
            {
                foreach (GType type in all)
                {
                    if (!type.IsJVMGenerate && !type.IsCLRGenerate)
                    {
                        if (type.CLRSubst != null)
                        {
                            Console.WriteLine(type + " ->ToCLR-> " + type.CLRResolved);
                        }
                        else if (type.JVMSubst != null)
                        {
                            Console.WriteLine(type + " ->ToJVM-> " + type.JVMResolved);
                        }
                        else
                        {
                            Console.WriteLine(type);
                        }
                    }
                }
                Console.WriteLine();
            }
            foreach (GType type in all)
            {
                if (type.IsJVMGenerate)
                {
                    Console.WriteLine("will generate JVM " + type);
                }
                else if (type.IsCLRGenerate)
                {
                    Console.WriteLine("will generate CLR " + type);
                }
            }
        }

        public static List<GType> GetGenInterfaces()
        {
            List<GType> res = new List<GType>();
            foreach (GType type in all)
            {
                if ((type.IsJVMGenerate || type.IsCLRGenerate) && type.IsInterface)
                {
                    res.Add(type);
                }
            }
            return res;
        }

        private static void Register(GType type)
        {
            bool known = false;
            if (type.CLRType != null)
            {
                if (!knownTypes.ContainsKey(type.CLRType))
                {
                    knownTypes.Add(type.CLRType, type);
                }
                else
                {
                    known = true;
                }
            }
            if (type.JVMType != null)
            {
                if (!knownClasses.ContainsKey(type.JVMType))
                {
                    knownClasses.Add(type.JVMType, type);
                }
                else
                {
                    known = true;
                }
            }
            if (!knownNames.ContainsKey(type.LowerName))
            {
                knownNames.Add(type.LowerName, type);
            }
            if (!known)
            {
                all.Add(type);
            }
        }

        public static void Register()
        {
            LoadAssemblies();
            LoadClasspath();
            RegisterAssemblies();

            if (config.JavaClass != null)
            {
                RegisterClasses();
            }
            if (config.ClrType != null)
            {
                RegisterTypes();
            }
        }

        private static void RegisterAssemblies()
        {
            BindKnownTypesPre();
            foreach (Assembly assembly in knownAssemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    object javaInterfaceA = HasAttribute(type, javaInterfaceAttr);
                    object clrWrapperA = HasAttribute(type, clrWrapperAttr);
                    object javaClassA = HasAttribute(type, javaClassAttr);
                    if ((javaProxyType.IsAssignableFrom(type) && javaClassA != null) ||
                        (type.IsInterface && javaInterfaceA != null))
                    {
                        Class clazz = JNIEnv.GetEnv().FindClassNoThrow(type.FullName.Replace('.', '/'));
                        if (clazz != null)
                        {
                            RegisterClass(clazz);
                        }
                        RegisterType(type);
                    }
                    else if (clrWrapperA != null && type.IsSealed && type.Name.StartsWith("__"))
                    {
                        Type realType = clrWrapperA.GetType().GetProperty("RealType").GetValue(clrWrapperA, null) as Type;
                        if (realType != null)
                        {
                            string clazzName = type.FullName.Replace(".__", "/").Replace('.', '/');
                            Class clazz = JNIEnv.GetEnv().FindClassNoThrow(clazzName);
                            if (clazz != null)
                            {
                                RegisterClass(clazz);
                            }
                            RegisterType(realType);
                        }
                    }
                }
            }
            BindKnownTypesPost();
        }

        private static void RegisterClasses()
        {
            JNIEnv env = JNIEnv.GetEnv();
            foreach (TypeRegistration registration in config.JavaClass)
            {
                string name = registration.TypeName.Replace(".", "/");
                Class clazz = env.FindClassNoThrow(name);
                if (clazz != null)
                {
                    GType reg = RegisterClass(clazz, registration);
                    reg.IsCLRGenerate = true;
                    reg.IsSkipJVMInterface = !registration.SyncInterface;
                    reg.MergeJavaSource = registration.MergeJavaSource;
                }
                else
                {
                    Console.Error.WriteLine("Can't load class " + registration);
                }
            }
        }

        private static void RegisterTypes()
        {
            foreach (var registration in config.ClrType)
            {
                Type type = null;
                foreach (Assembly a in knownAssemblies)
                {
                    type = a.GetType(registration.TypeName);
                    if (type != null)
                    {
                        break;
                    }
                }

                if (type == null)
                {
                    Console.Error.WriteLine("Can't load type" + registration);
                    throw new JNIException("Can't load type" + registration);
                }
                GType reg = RegisterType(type, registration);
                reg.IsJVMGenerate = true;
                reg.IsSkipCLRInterface = !registration.SyncInterface;
                reg.MergeJavaSource = registration.MergeJavaSource;
            }
        }
    
    }
}
