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
using System.Collections.Generic;
using System.Reflection;
using com.thoughtworks.paranamer;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using net.sf.jni4net.proxygen.config;
using Exception = System.Exception;
using Object = java.lang.Object;
using String = System.String;

namespace net.sf.jni4net.proxygen.model
{
    internal partial class Repository
    {
        public static List<GType> JVMGenTypes()
        {
            var res = new List<GType>();
            foreach (GType type in all)
            {
                if (type.IsJVMGenerate && !type.IsInterface)
                {
                    res.Add(type);
                }
            }
            return res;
        }

        internal static GType RegisterClass(Class clazz)
        {
            return RegisterClass(clazz, null);
        }

        internal static GType RegisterClass(Class clazz, TypeRegistration registration)
        {
            if (knownClasses.ContainsKey(clazz))
            {
                GType known = knownClasses[clazz];
                if (registration != null)
                {
                    known.Registration = registration;
                }
                return known;
            }
            var res = new GType();
            if (clazz.isArray())
            {
                res.ArrayElement = RegisterClass(clazz.getComponentType(), null);
                res.IsArray = true;
                string array = "[]";
                Class comp = clazz.getComponentType();
                while (comp.isArray())
                {
                    array += "[]";
                    comp = comp.getComponentType();
                }
                res.LowerName = ((string) comp.getName()).ToLowerInvariant() + array;
            }
            else
            {
                res.LowerName = ((string) clazz.getName()).ToLowerInvariant();
            }

            res.Attributes = 0;
            var classModifiers = (ModifierFlags) clazz.getModifiers();
            if ((classModifiers & ModifierFlags.Abstract) != 0)
            {
                res.IsAbstract = true;
                res.Attributes |= TypeAttributes.Abstract;
            }
            if ((classModifiers & ModifierFlags.Final) != 0)
            {
                res.IsFinal = true;
            }
            if ((classModifiers & ModifierFlags.Public) != 0)
            {
                res.Attributes |= TypeAttributes.Public;
            }
            else if ((classModifiers & ModifierFlags.Private) != 0)
            {
                res.Attributes |= TypeAttributes.NotPublic;
            }
            //TODO internal ?
            if (knownNames.ContainsKey(res.LowerName))
            {
                res = knownNames[res.LowerName];
            }
            if (res.Registration == null && registration != null)
            {
                res.Registration = registration;
            }
            res.JVMType = clazz;
            res.JVMFullName = clazz.getName();
            if (res.IsArray)
            {
                string array = "[]";
                Class comp = clazz.getComponentType();
                while (comp.isArray())
                {
                    array += "[]";
                    comp = comp.getComponentType();
                }
                res.JVMFullName = comp.getName() + array;
            }
            else
            {
                res.JVMFullName = clazz.getName();
            }
            res.IsJVMType = true;
            res.IsPrimitive = clazz.isPrimitive();
            res.IsException = Throwable._class.isAssignableFrom(clazz);
            res.IsInterface = clazz.isInterface();
            res.IsCLRProxy = clrProxyClass != null && clrProxyClass.isAssignableFrom(clazz);
            if (!res.IsCLRProxy)
            {
                res.IsJVMRealType = true;
            }
            Class superclass = clazz.getSuperclass();
            var isBaseClassPublic = superclass == null || ((ModifierFlags)superclass.getModifiers() & ModifierFlags.Public) != 0;
            if (superclass != null && res.Base == null
                && clazz != Object._class
                && clazz != Throwable._class
                && res.JVMFullName != "system.Object"
                && res.JVMFullName != "system.Exception"
                && isBaseClassPublic)
            {
                res.Base = RegisterClass(superclass);
            }
            List<Class> interfaces = new List<Class>(clazz.getInterfaces());
            if (!isBaseClassPublic)
            {
                interfaces.AddRange(superclass.getInterfaces());
                res.Base = RegisterClass(superclass.getSuperclass());
            }
            foreach (Class ifc in interfaces)
            {
                GType gifc = RegisterClass(ifc);
                if (!res.Interfaces.Contains(gifc))
                {
                    if (res.IsInterface && res.Base == null)
                    {
                        res.Base = gifc;
                    }
                    res.Interfaces.Add(gifc);
                    res.AllInterfaces.Add(gifc);
                }
            }
            Register(res);
            return res;
        }

        private static void RegisterJVMConstructors(GType type, bool register)
        {
            if (type.IsAbstract)
            {
                return;
            }
            Class clazz = type.JVMType;
            foreach (Constructor ctor in clazz.getConstructors())
            {
                RegisterJVMConstructor(type, ctor, register);
            }
        }

        private static void RegisterJVMMethods(GType type, bool register)
        {
            Class clazz = type.JVMType;
            Method[] methods;
            try
            {
                methods = clazz.getMethods();
            }
            catch(Throwable th)
            {
                if (config.Verbose)
                {
                    Console.WriteLine("Skip methods" + type + " error: " + th.Message);
                }
                type.IsCLRGenerate = false;
                type.IsJVMGenerate = false;
                return;
            }
            var superclass = clazz.getSuperclass();
            var isBaseClassPublic = superclass==null || ((ModifierFlags)superclass.getModifiers() & ModifierFlags.Public) != 0;
            foreach (Method method in methods)
            {
                var declaringClass = method.getDeclaringClass();
                bool create = declaringClass == clazz;
                create = testVirtual(type, clazz, method, create, isBaseClassPublic);
                if (create || type == javaLangThrowable)
                {
                    try
                    {
                        RegisterJVMMethod(type, method, register);
                    }
                    catch(Throwable th)
                    {
                        if (config.Verbose)
                        {
                            Console.WriteLine("Skip " + type + "." + method + " error: " + th.Message);
                        }
                    }
                }
                else if (config.Verbose)
                {
                    Console.WriteLine("Skip " + type + "." + method);
                }
            }
            foreach (GType ifc in type.Interfaces)
            {
                if (ifc.IsJVMType)
                {
                    foreach (Method method in ifc.JVMType.getMethods())
                    {
                        bool create = testVirtual(type, clazz, method, true, isBaseClassPublic);
                        if (create)
                        {
                            try
                            {
                                RegisterJVMMethod(type, method, register);
                            }
                            catch (Throwable th)
                            {
                                if (config.Verbose)
                                {
                                    Console.WriteLine("Skip " + type + "." + method + " error: " + th.Message);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static bool testVirtual(GType type, Class clazz, Method method, bool create, bool isBaseClassPublic)
        {
            var modifiers = (ModifierFlags) method.getModifiers();
            bool isStatic = (modifiers & ModifierFlags.Static) != ModifierFlags.None;
            bool isVirtual = (modifiers & ModifierFlags.Final) == ModifierFlags.None;
            if (!clazz.isInterface())
            {
                if (create && !isStatic && isVirtual && !type.IsRootType)
                {
                    Method smethod = clazz.getSuperclass().GetMethodNoThrow(method.getName(), method.GetSignature(), false);
                    if (smethod != null && isBaseClassPublic)
                    {
                        create = false;
                    }
                }
            }
            return create;
        }

        private static void RegisterJVMFields(GType type, bool register)
        {
            Class clazz = type.JVMType;
            foreach (Field field in clazz.getFields())
            {
                RegisterJVMField(type, field, register);
            }
        }


        private static void RegisterJVMField(GType type, Field field, bool register)
        {
            var modifiers = (ModifierFlags) field.getModifiers();
            if ((modifiers & (ModifierFlags.Private | ModifierFlags.Synthetic)) != ModifierFlags.None)
            {
                if (config.Verbose)
                {
                    Console.WriteLine("Skip " + type + "." + field);
                }
                return;
            }
            var res = new GMethod();
            res.Type = type;
            res.IsField = true;
            res.Name = field.getName();
            res.JVMName = field.getName();
            res.CLRName = res.JVMName;
            res.IsJVMMethod = true;
            ConvertJVMAttributes(type, res, field);
            res.ReturnType = RegisterClass(field.getType());
            res.LowerName = (field.getName());
            if (register)
            {
                type.Methods.Add(res);
                type.MethodsWithInterfaces.Add(res);
            }
        }

        private static void RegisterJVMMethod(GType type, Method method, bool register)
        {
            var modifiers = (ModifierFlags)method.getModifiers();
            Annotation annotation = HasAnnotation(method, "net.sf.jni4net.attributes.ClrMethod");
            if (annotation != null ||
                (modifiers & (ModifierFlags.Private | ModifierFlags.Synthetic)) != ModifierFlags.None)
            {
                if (annotation == null)
                {
                    if (config.Verbose)
                    {
                        Console.WriteLine("Skip " + type + "." + method);
                    }
                }
                return;
            }

            var res = new GMethod();
            res.Type = type;
            res.Name = method.getName();
            res.JVMName = res.Name;
            res.CLRName = res.JVMName;
            res.IsJVMMethod = true;
            var parameterTypes = method.getParameterTypes();
            var parameterNames = GetParameterNames(method, parameterTypes.Length);
            for (int i = 0; i < parameterTypes.Length; i++)
            {
                var paramType = parameterTypes[i];
                var paramName = parameterNames[i];
                res.ParameterNames.Add(paramName); //+ paramType.ShortName
                res.Parameters.Add(RegisterClass(paramType));
            }
            ConvertJVMAttributes(type, res, method);
            res.LowerName = res.Name + res.GetSignatureLowerNoRet();
            res.ReturnType = RegisterClass(method.getReturnType());
            if (register)
            {
                bool force = false;
                if (UseMethodModifier(type, res, res.Name, res.GetJVMSignature(), ref force))
                {
                    if (config.Verbose)
                    {
                        Console.WriteLine("Skip " + type + "." + method);
                    }
                    return;
                }

                FinishRegistration(method.getName(), type, res, force, res.Name + res.GetCLRSignatureNoRet(), skipCLR);
            }
        }

        private static string skipCLR(GMethod skip)
        {
            return skip.Name + skip.GetCLRSignatureNoRet();
        }

        private static void RegisterJVMConstructor(GType type, Constructor ctor, bool register)
        {
            var modifiers = (ModifierFlags) ctor.getModifiers();
            if ((modifiers & (ModifierFlags.Private | ModifierFlags.Synthetic)) != ModifierFlags.None)
            {
                return;
            }

            var res = new GMethod();
            res.Type = type;
            res.Name = "<init>";
            res.JVMName = res.Name;
            res.CLRName = "_ctor" + type.JVMType.getSimpleName();
            res.ReturnType = voidType;
            res.IsJVMMethod = true;
            res.IsConstructor = true;
            var parameterTypes = ctor.getParameterTypes();
            var parameterNames = GetParameterNames(ctor, parameterTypes.Length);

            for (int i = 0; i < parameterTypes.Length; i++)
            {
                var paramType = parameterTypes[i];
                var paramName = parameterNames[i];
                res.ParameterNames.Add(paramName); //+ paramType.ShortName
                res.Parameters.Add(RegisterClass(paramType));
            }
            ConvertJVMAttributes(type, res, ctor);
            res.LowerName = (res.Name + res.GetSignatureLowerNoRet());
            if (register)
            {
                bool force = false;
                if (UseMethodModifier(type, res, res.Name, res.GetJVMSignature(), ref force))
                {
                    return;
                }
                type.Constructors.Add(res);
            }
        }

        private static java.lang.String[] GetParameterNames(AccessibleObject member, int parametersCount)
        {
            var paranamer = new BytecodeReadingParanamer();
            var names = paranamer.lookupParameterNames(member, false);
            if (names.Length >= parametersCount)
            {
                return names;
            }

            names = new java.lang.String[parametersCount];
            for (var i = 0; i < names.Length; i++)
            {
                names[i] = "par" + i;
            }

            return names;
        }

        private static Annotation HasAnnotation(Method tested, string name)
        {
            Annotation[] annotations = tested.getAnnotations();
            foreach (Annotation annotation in annotations)
            {
                if (annotation.annotationType().getName() == name)
                {
                    return annotation;
                }
            }
            return null;
        }

        private static void ConvertJVMAttributes(GType type, GMethod res, Member member)
        {
            var modifiers = (ModifierFlags) member.getModifiers();
            res.Attributes = 0;
            if ((modifiers & (ModifierFlags.Public)) != ModifierFlags.None || type.IsInterface)
            {
                res.Attributes |= MemberAttributes.Public;
            }
            if ((modifiers & (ModifierFlags.Static)) != ModifierFlags.None)
            {
                res.Attributes |= MemberAttributes.Static;
                res.IsStatic = true;
            }
            /*if ((modifiers & (ModifierFlags.Abstract)) != ModifierFlags.None && !type.IsInterface)
            {
                res.Attributes |= MemberAttributes.Abstract;
            }*/
            if ((modifiers & (ModifierFlags.Final)) != ModifierFlags.None && !type.IsInterface)
            {
                res.Attributes |= MemberAttributes.Final;
            }
            if ((modifiers & (ModifierFlags.Varargs)) != ModifierFlags.None)
            {
                var indexOfLastParameter = res.Parameters.Count - 1;
                res.Parameters[indexOfLastParameter].IsOptional = true;
            }
        }
    }
}