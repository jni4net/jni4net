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
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using java.lang;
using java.lang.reflect;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.utils;
using Exception=System.Exception;
using Object=java.lang.Object;
using String=java.lang.String;
using Type=System.Type;

namespace net.sf.jni4net.proxygen
{
    internal class Analyzer
    {
        protected ToolConfig config;
        protected Type jp = null;
        protected Type jca = null;
        protected Type jia = null;
        protected Type cwa = null;
        protected Class icp = null;
        protected Dictionary<Class, Class> ignoredClasses = new Dictionary<Class, Class>();
        protected Dictionary<Type, Type> ignoredTypes = new Dictionary<Type, Type>();
        protected Dictionary<Class, string> knownClasses = new Dictionary<Class, string>();
        protected Dictionary<Type, string> knownTypes = new Dictionary<Type, string>();
        protected List<Assembly> knownAssemblies=new List<Assembly>();

        protected Dictionary<Class, Type> sharedClasses = new Dictionary<Class, Type>();
        protected Dictionary<Type, Class> sharedTypes = new Dictionary<Type, Class>();

        public Analyzer(ToolConfig config)
        {
            this.config = config;
            RegisterShared(Class.getPrimitiveClass("void"), typeof (void));
            RegisterShared(Class.getPrimitiveClass("int"), typeof (int));
            RegisterShared(Class.getPrimitiveClass("long"), typeof (long));
            RegisterShared(Class.getPrimitiveClass("short"), typeof (short));
            RegisterShared(Class.getPrimitiveClass("char"), typeof (char));
            RegisterShared(Class.getPrimitiveClass("byte"), typeof (byte));
            RegisterShared(Class.getPrimitiveClass("double"), typeof (double));
            RegisterShared(Class.getPrimitiveClass("float"), typeof (float));
            RegisterShared(Class.getPrimitiveClass("boolean"), typeof (bool));
        }
        public void RegisterKnownCore(List<Assembly> assemblies)
        {
            knownAssemblies = assemblies;
            jp = typeof(IJavaProxy);
        }

        public void RegisterKnownAssemblies(List<Assembly> assemblies)
        {
            knownAssemblies = assemblies;
            foreach (Assembly assembly in knownAssemblies)
            {
                if (jp == null){
                    jp = assembly.GetType("net.sf.jni4net.jni.IJavaProxy");
                }
                if(jca==null)
                {
                    jca = assembly.GetType("net.sf.jni4net.attributes.JavaClassAttribute");
                }
                if (jia == null)
                {
                    jia = assembly.GetType("net.sf.jni4net.attributes.JavaInterfaceAttribute");
                }
                if (cwa == null)
                {
                    cwa = assembly.GetType("net.sf.jni4net.attributes.ClrWrapperAttribute");
                }
                
            }
            if (jp==null)
            {
                jp = typeof (IJavaProxy);
                knownAssemblies.Add(jp.Assembly);
            }
            Class oc = JNIEnv.GetEnv().FindClassNoThrow("system/IObject");
            if (oc!=null && !ignoredClasses.ContainsKey(oc))
            {
                ignoredClasses.Add(oc, Object._class);
            }
            Type ot = typeof(IObject);
            if (!ignoredTypes.ContainsKey(ot))
            {
                ignoredTypes.Add(ot, typeof(object));
            }

            icp = JNIEnv.GetEnv().FindClassNoThrow("net.sf.jni4net.inj.IClrProxy");


            foreach (Assembly assembly in knownAssemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (jp.IsAssignableFrom(type) || (type.IsInterface && HasAttribute(type, jia)!=null))
                    {
                        Class clazz = JNIEnv.GetEnv().FindClassNoThrow(type.FullName.Replace('.', '/'));
                        if (clazz!=null)
                        {
                            if (!sharedTypes.ContainsKey(type))
                            {
                                sharedTypes.Add(type, clazz);
                            }
                            if (!sharedClasses.ContainsKey(clazz))
                            {
                                sharedClasses.Add(clazz, type);
                            }
                            if (config.Verbose)
                            {
                                Console.WriteLine("shared type " + type);
                            }
                        }
                    }
                    else if (type.IsSealed && type.Name.StartsWith("__"))
                    {
                        object attribute = HasAttribute(type, cwa);
                        if (attribute != null)
                        {
                            Type realType = attribute.GetType().GetProperty("RealType").GetValue(attribute, null) as Type;
                            if (realType != null)
                            {
                                string clazzName = type.FullName.Replace(".__", "/").Replace('.','/');
                                Class clazz = JNIEnv.GetEnv().FindClassNoThrow(clazzName);
                                if (clazz != null)
                                {
                                    if (!sharedTypes.ContainsKey(realType))
                                    {
                                        sharedTypes.Add(realType, clazz);
                                    }
                                    if (!sharedClasses.ContainsKey(clazz))
                                    {
                                        sharedClasses.Add(clazz, realType);
                                    }
                                    if (config.Verbose)
                                    {
                                        Console.WriteLine("shared class " + clazzName);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private object HasAttribute(Type tested, Type attribute)
        {
            object[] objects = tested.GetCustomAttributes(attribute, false);
            if (objects.Length == 1)
            {
                return objects[0];
            }
            return null;
        }

        public void RegisterClass(Class clazz)
        {
            if (knownClasses.ContainsKey(clazz))
            {
                return;
            }
            if (sharedClasses.ContainsKey(clazz))
            {
                return;
            }
            if (clazz.isArray())
            {
                RegisterClass(clazz.getComponentType());
                return;
            }
            knownClasses.Add(clazz, clazz.FullName);
            if (config.Verbose)
            {
                Console.WriteLine("known class " + clazz);
            }
            Class superclass = clazz.getSuperclass();
            if (superclass != null)
            {
                RegisterClass(superclass);
            }
            foreach (Class ifc in clazz.getInterfaces())
            {
                RegisterClass(ifc);
            }
        }

        public void RegisterType(Type type)
        {
            if (sharedTypes.ContainsKey(type)) //&& !type.IsPrimitive
            {
                sharedTypes.Remove(type);
            }
            RegisterTypeImpl(type);
        }

        private void RegisterTypeImpl(Type type)
        {
            if (type == typeof (ICloneable))
            {
                return;
            }
            if (type == typeof (ISerializable))
            {
                return;
            }
            if (type.IsGenericType || type.IsGenericParameter)
            {
                return;
            }
            if (knownTypes.ContainsKey(type))
            {
                return;
            }
            if (sharedTypes.ContainsKey(type))
            {
                return;
            }
            if (type.IsArray)
            {
                RegisterTypeImpl(type.GetElementType());
                return;
            }
            knownTypes.Add(type, type.Namespace.ToLowerInvariant() + "." + type.Name);
            if (config.Verbose)
            {
                Console.WriteLine("known type " + type);
            }
            Type superclass = type.BaseType;
            if (superclass != null)
            {
                RegisterTypeImpl(superclass);
            }
            foreach (Type ifc in type.GetInterfaces())
            {
                if (!ifc.Name.StartsWith("_"))
                {
                    RegisterTypeImpl(ifc);
                }
            }
        }


        public void Analyze()
        {
            foreach (Class clazz in knownClasses.Keys)
            {
                AnalyzeMethods(clazz);
            }
            foreach (Type type in knownTypes.Keys)
            {
                AnalyzeMethods(type);
            }
        }

        private void AnalyzeMethods(Type type)
        {
            IList<MethodInfo> methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                MethodAttributes modifiers = method.Attributes;
                if ((modifiers & (MethodAttributes.Private)) != 0)
                {
                    continue;
                }
                Type returnType = method.ReturnType;
                RegisterIgnoredType(returnType);

                foreach (ParameterInfo parameterType in method.GetParameters())
                {
                    RegisterIgnoredType(parameterType.ParameterType);
                }
            }

            IList<ConstructorInfo> constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                MethodAttributes modifiers = constructor.Attributes;
                if ((modifiers & (MethodAttributes.Private)) != 0)
                {
                    continue;
                }
                foreach (ParameterInfo parameterType in constructor.GetParameters())
                {
                    RegisterIgnoredType(parameterType.ParameterType);
                }
            }
        }

        private void AnalyzeMethods(Class clazz)
        {
            IList<Method> methods = clazz.getDeclaredMethods();
            foreach (Method method in methods)
            {
                var modifiers = (ModifierFlags) method.getModifiers();
                if ((modifiers & (ModifierFlags.Private | ModifierFlags.Synthetic)) != ModifierFlags.None)
                {
                    continue;
                }
                Class returnType = method.getReturnType();
                RegisterIgnoredClass(returnType);

                foreach (Class parameterType in method.getParameterTypes())
                {
                    RegisterIgnoredClass(parameterType);
                }

                foreach (Class exceptionType in method.getExceptionTypes())
                {
                    RegisterIgnoredClass(exceptionType);
                }
            }

            IList<Constructor> constructors = clazz.getConstructors();
            foreach (Constructor constructor in constructors)
            {
                var modifiers = (ModifierFlags) constructor.getModifiers();
                if ((modifiers & (ModifierFlags.Private | ModifierFlags.Synthetic)) != ModifierFlags.None)
                {
                    continue;
                }
                foreach (Class parameterType in constructor.getParameterTypes())
                {
                    RegisterIgnoredClass(parameterType);
                }

                foreach (Class exceptionType in constructor.getExceptionTypes())
                {
                    RegisterIgnoredClass(exceptionType);
                }
            }
        }

        private void RegisterIgnoredClass(Class ignoredClazz)
        {
            if (ignoredClazz.isArray())
            {
                RegisterIgnoredClass(ignoredClazz.getComponentType());
                return;
            }
            if (icp != null && icp.isAssignableFrom(ignoredClazz))
            {
                Type type=null;
                foreach (Assembly assembly in knownAssemblies)
                {
                    type = assembly.GetType(ignoredClazz.getName(), false, true);
                    if (type!=null)
                    {
                        break;
                    }
                }
                if (type!=null)
                {
                    if (!sharedTypes.ContainsKey(type))
                    {
                        sharedTypes.Add(type, ignoredClazz);
                    }
                    if (!sharedClasses.ContainsKey(ignoredClazz))
                    {
                        sharedClasses.Add(ignoredClazz, type);
                    }
                    return;
                }
                Console.Error.WriteLine("can't find " + ignoredClazz.getName() + " Clr type ");
            }
            if (!knownClasses.ContainsKey(ignoredClazz) && !ignoredClasses.ContainsKey(ignoredClazz) &&
                !sharedClasses.ContainsKey(ignoredClazz))
            {
                Class reg = null;
                Class superclass = ignoredClazz;
                while (superclass != null)
                {
                    if (sharedClasses.ContainsKey(superclass))
                    {
                        reg = superclass;
                        break;
                    }
                    if (knownClasses.ContainsKey(superclass))
                    {
                        reg = superclass;
                        break;
                    }
                    Class csuperclass = superclass;
                    if (csuperclass != null)
                    {
                        superclass = csuperclass.getSuperclass();
                    }
                    else
                    {
                        break;
                    }
                }

                if (reg == null)
                {
                    reg = Object._class;
                }

                ignoredClasses.Add(ignoredClazz, reg);
                if (config.Verbose)
                {
                    Console.WriteLine("ignored " + ignoredClazz + " conversion to " + reg);
                }
            }
        }

        private void RegisterIgnoredType(Type ignoredType)
        {
            if (ignoredType.IsGenericType || ignoredType.IsGenericParameter)
            {
                return;
            }
            if (ignoredType.IsArray)
            {
                RegisterIgnoredType(ignoredType.GetElementType());
                return;
            }
            if (!knownTypes.ContainsKey(ignoredType) && !ignoredTypes.ContainsKey(ignoredType) &&
                !sharedTypes.ContainsKey(ignoredType))
            {
                Type reg = null;
                Type baseType = ignoredType;
                while (baseType != null)
                {
                    if (sharedTypes.ContainsKey(baseType))
                    {
                        reg = baseType;
                        break;
                    }
                    if (knownTypes.ContainsKey(baseType))
                    {
                        reg = baseType;
                        break;
                    }
                    baseType = baseType.BaseType;
                }
                //convert to non generic type
                if ((reg == null || reg == typeof (object)) && typeof (IEnumerator).IsAssignableFrom(ignoredType))
                {
                    reg = typeof (IEnumerator);
                }
                else if ((reg == null || reg == typeof(object)) && typeof(ICollection).IsAssignableFrom(ignoredType))
                {
                    reg = typeof(ICollection);
                }
                /*if (reg == null || reg == typeof (object))
                {
                    reg = null;
                    baseType = ignoredType;
                    while (baseType != null)
                    {
                        foreach (Type ifc in baseType.GetInterfaces())
                        {
                            if (sharedTypes.ContainsKey(ifc))
                            {
                                reg = ifc;
                                break;
                            }
                            if (knownTypes.ContainsKey(ifc))
                            {
                                reg = ifc;
                                break;
                            }
                        }
                        if (reg != null)
                        {
                            break;
                        }
                        baseType = baseType.BaseType;
                    }
                }*/

                if (reg == null)
                {
                    reg = typeof (object);
                }

                ignoredTypes.Add(ignoredType, reg);
                if (config.Verbose)
                {
                    Console.WriteLine("ignored type " + ignoredType + " conversion to " + reg);
                }
            }
        }

        private void RegisterShared(Class sharedClass, Type sharedType)
        {
            if (!sharedClasses.ContainsKey(sharedClass))
            {
                sharedClasses.Add(sharedClass, sharedType);
                sharedTypes.Add(sharedType, sharedClass);
                if (config.Verbose)
                {
                    Console.WriteLine("shared type " + sharedClass);
                }
            }
        }

        public CodeTypeReference ResolveTypeReference(Type type)
        {
            return new CodeTypeReference(ResolveTypeRef(type));
        }


        public CodeTypeReference ResolveClassReference(Class type)
        {
            return new CodeTypeReference(ResolveClassRef(type) , CodeTypeReferenceOptions.GlobalReference);
        }

        private string ResolveClassRef(Class type)
        {
            if (type.isArray())
            {
                Class comp = type.getComponentType();
                if (comp.isArray())
                {
                    comp = comp.getComponentType();
                    return ResolveClassRef(ResolveClass(comp)) + "[][]";
                }
                return ResolveClassRef(ResolveClass(comp)) + "[]";
            }
            return ResolveClassName(ResolveClass(type));
        }

        private string ResolveTypeRef(Type type)
        {
            if (type.IsArray)
            {
                Type comp = type.GetElementType();
                if (comp.IsArray)
                {
                    comp = comp.GetElementType();
                    return ResolveTypeRef(ResolveType(comp)) + "[][]";
                }
                return ResolveTypeRef(ResolveType(comp)) + "[]";
            }
            Type jp = type.Assembly.GetType("net.sf.jni4net.jni.IJavaProxy");
            if (jp != null && jp.IsAssignableFrom(type))
            {
                return type.FullName;
            }
            return ResolveTypeName(ResolveType(type));
        }


        private string ResolveClassName(Class clazz)
        {
            if (sharedClasses.ContainsKey(clazz))
            {
                return sharedClasses[clazz].FullName;
            }
            if (knownClasses.ContainsKey(clazz))
            {
                return knownClasses[clazz];
            }
            Class ignoredType = ignoredClasses[clazz];
            Class ignoredClass = ignoredType;
            if (ignoredClass != null)
            {
                return ignoredClass.FullName;
            }
            return ignoredType.ToString();
        }

        private string ResolveTypeName(Type type)
        {
            if (typeof (string) == type)
            {
                return "java.lang.String";
            }
            if (sharedTypes.ContainsKey(type))
            {
                Class clazz = sharedTypes[type];
                if (clazz == null)
                {
                    return type.Namespace.ToLowerInvariant() + "." + type.Name;
                }
                return clazz.FullName;
            }
            if (knownTypes.ContainsKey(type))
            {
                return knownTypes[type];
            }
            Type ignoredType = ignoredTypes[type];
            Type ignoredClass = ignoredType;
            if (ignoredClass != null)
            {
                return ignoredClass.FullName;
            }
            return ignoredType.ToString();
        }

        private Type ResolveType(Type type)
        {
            if (sharedTypes.ContainsKey(type) || knownTypes.ContainsKey(type))
            {
                return type;
            }
            if (ignoredTypes.ContainsKey(type))
            {
                return ignoredTypes[type];
            }
            return typeof (object);
        }

        private Class ResolveClass(Class clazz)
        {
            if (sharedClasses.ContainsKey(clazz) || knownClasses.ContainsKey(clazz))
            {
                return clazz;
            }
            if (ignoredClasses.ContainsKey(clazz))
            {
                return ignoredClasses[clazz];
            }
            return Object._class;
        }
    }
}