﻿using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using java.lang;
using net.sf.jni4net.proxygen.config;
using Exception=System.Exception;
using Object=java.lang.Object;

namespace net.sf.jni4net.proxygen.model
{
    partial class Repository
    {
        public static List<GType> CLRGenTypes()
        {
            List<GType> res = new List<GType>();
            foreach (GType type in all)
            {
                if (type.IsCLRGenerate && !type.IsInterface)
                {
                    res.Add(type);
                }
            }
            return res;
        }

        internal static GType RegisterType(Type type)
        {
            return RegisterType(type, null);
        }
        internal static GType RegisterType(Type type, TypeRegistration registration)
        {
            if (knownTypes.ContainsKey(type))
            {
                GType known = knownTypes[type];
                if (registration != null)
                {
                    known.Registration = registration;
                }
                return known;
            }
            GType res = new GType();
            if (type.IsArray)
            {
                res.ArrayElement = RegisterType(type.GetElementType());
                res.IsArray = true;
            }

            if (type.IsAbstract)
            {
                res.IsAbstract = true;
            }
            if (type.IsSealed)
            {
                res.IsFinal = true;
            }

            res.LowerName = type.FullName.ToLowerInvariant();
            if (knownNames.ContainsKey(res.LowerName))
            {
                res = knownNames[res.LowerName];
            }
            if (res.Registration == null && registration != null)
            {
                res.Registration = registration;
            }
            res.IsPrimitive = type.IsPrimitive;
            res.CLRType = type;
            if (res.IsArray)
            {
                res.CLRFullName = type.GetElementType().FullName+ "[]";
            }
            else
            {
                res.CLRFullName = type.FullName;
            }
            res.Attributes = type.Attributes;
            res.IsCLRType = true;
            res.IsInterface = type.IsInterface;
            res.IsJVMProxy = javaProxyType.IsAssignableFrom(type);
            if (res.IsJVMProxy)
            {
                res.IsCLRRealType = true;
            }
            if (type.BaseType != null && res.Base == null 
                && type != typeof(object) 
                && type != typeof(Exception)
                && type.FullName != "java.lang.Throwable"
                && type.FullName != "java.lang.Object"
                )
            {
                res.Base = RegisterType(type.BaseType);
            }
            foreach (Type ifc in type.GetInterfaces())
            {
                if (!ifc.IsAssignableFrom(type.BaseType))
                {
                    GType gifc = RegisterType(ifc);
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
            }
            Register(res);

            if (type.IsGenericType)
            {
                Type sub;
                Type supGeneric = type.GetGenericTypeDefinition();
                if (typeof(IComparable<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof(IComparable);
                    res.LowerName = ("System.IComparable<" + type.GetGenericArguments()[0].Name + ">").ToLowerInvariant();
                }
                else if (typeof(IEnumerable<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof(IEnumerable);
                    res.LowerName = ("System.Collections.Generic.IEnumerable<" + type.GetGenericArguments()[0].Name + ">").ToLowerInvariant();
                }
                else if (typeof(IEnumerator<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof(IEnumerator);
                    res.LowerName = ("System.Collections.Generic.IEnumerator<" + type.GetGenericArguments()[0].Name + ">").ToLowerInvariant();
                }
                else if (typeof(IEquatable<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof(object);
                    res.LowerName = ("System.Collections.Generic.IEquatable<" + type.GetGenericArguments()[0].Name + ">").ToLowerInvariant();
                }
                else if (typeof(ICollection<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof(ICollection);
                    res.LowerName = ("System.Collections.Generic.ICollection<" + type.GetGenericArguments()[0].Name + ">").ToLowerInvariant();
                }
                else if (typeof(IList<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof(IList);
                    res.LowerName = ("System.Collections.Generic.IList<" + type.GetGenericArguments()[0].Name + ">").ToLowerInvariant();
                }
                else
                {
                    sub = type.BaseType;
                    if (sub == null)
                    {
                        sub = typeof(object);
                    }
                }
                res.JVMSubst = RegisterType(sub);
            }

            return res;
        }

        private static void RegisterCLRConstructors(GType type, bool register)
        {
            Type clrType = type.CLRType;
            foreach (ConstructorInfo constructor in clrType.GetConstructors())
            {
                MethodAttributes modifiers = constructor.Attributes;
                if ((modifiers & (MethodAttributes.Private)) != 0)
                {
                    continue;
                }
                RegisterCLRConstructor(type, constructor, register);
            }            
        }

        private static void RegisterCLRMethods(GType type, bool register)
        {
            Type clrType = type.CLRType;
            foreach (MethodInfo method in clrType.GetMethods())
            {
                if (method.DeclaringType == type.CLRType 
                    || type.CLRType == typeof(Exception))
                {
                    RegisterCLRMethod(type, method, register);
                }
            }
            foreach (GType ifc in type.Interfaces)
            {
                if (ifc.IsCLRType)
                {
                    foreach (MethodInfo method in ifc.CLRType.GetMethods())
                    {
                        RegisterCLRMethod(type, method, register);
                    }
                }
            }
        }

        private static void RegisterCLRMethod(GType type, MethodInfo method, bool register)
        {
            object attr = HasAttribute(method, javaMethodAttribute);
            
            if (method.IsGenericMethod || !method.IsPublic || attr != null)
            {
                if (attr == null && config.Verbose)
                {
                    //Console.WriteLine("Skip " + type + "." + method);
                }
                return;
            }
            if (method.IsSpecialName)
            {
                string name = method.Name;
                if (name.StartsWith("op_") || name.StartsWith("add_") || name.StartsWith("remove_"))
                {
                    if (config.Verbose)
                    {
                        //Console.WriteLine("Skip " + type + "." + method);
                    }
                    return;
                }
            }
            
            GMethod res = RegisterCLRCall(type, method);
            if (res == null || TestCLRType(method.ReturnType))
            {
                // skip
                return;
            }
            if (method.IsSpecialName)
            {
                res.CLRProperty = GetProperty(type, method);
                res.IsProperty = true;
                if (res.CLRProperty.CanRead && method.Name.StartsWith("get_"))
                {
                    res.IsCLRPropertyGetter = true;
                    res.CLRPropertyGetter = res;
                    foreach (GMethod m in type.Methods)
                    {
                        if (m.CLRProperty == res.CLRProperty)
                        {
                            m.CLRPropertyGetter = res;
                        }
                    }
                }
                if (res.CLRProperty.CanWrite && method.Name.StartsWith("set_"))
                {
                    res.IsCLRPropertySetter = true;
                    res.CLRPropertySetter = res;
                    foreach (GMethod m in type.Methods)
                    {
                        if (m.CLRProperty == res.CLRProperty)
                        {
                            m.CLRPropertySetter = res;
                        }
                    }
                }
                res.Name = method.Name;
                res.JVMName = method.Name.Replace("_", "");
                res.CLRName = res.CLRProperty.Name;
                if (res.CLRProperty.PropertyType == typeof(bool) && res.JVMName.StartsWith("getIs"))
                {
                    res.JVMName = "is" + res.JVMName.Substring(5);
                }
            }

            if (method.DeclaringType != type.CLRType)
            {
                res.DeclaringType = RegisterType(method.DeclaringType);
            }
            res.ReturnType = RegisterType(method.ReturnType);
            if (register)
            {
                bool force = false;
                if (UseMethodModifier(type, res, res.Name, res.GetCLRSignature(), ref force))
                {
                    return;
                }
                FinishRegistration(method.Name, type, res, force, res.Name + res.GetJVMSignatureNoRet(), skipJVM);
            }
        }

        public delegate string RegSkip(GMethod skip);

        private static string skipJVM(GMethod skip)
        {
            return skip.Name + skip.GetJVMSignatureNoRet();
        }

        private static void RegisterCLRConstructor(GType type, ConstructorInfo method, bool register)
        {
            GMethod res = RegisterCLRCall(type, method);
            if (res==null)
            {
                // skip
                return;
            }
            res.IsConstructor = true;
            if (register)
            {
                string sig = type.Name + res.GetJVMSignatureNoRet();
                if (type.AllMethods.ContainsKey(sig))
                {
                    //Console.WriteLine("Skip " + type + "." + method);
                    return;
                }
                type.AllMethods.Add(sig, res);
                type.Constructors.Add(res);
            }
        }

        private static GMethod RegisterCLRCall(GType type, MethodBase method)
        {
            GMethod res = new GMethod();
            res.Type = type;
            res.Name = method.Name;
            res.CLRName = method.Name;
            res.JVMName = method.Name;
            res.IsCLRMethod = true;
            foreach (ParameterInfo info in method.GetParameters())
            {
                if (TestCLRType(info.ParameterType))
                {
                    return null;
                }
                res.ParameterNames.Add(info.Name);
                res.Parameters.Add(RegisterType(info.ParameterType));
            }
            res.ReturnType = RegisterType(typeof(void));

            ConvertCLRAttributes(type, res, method);
            res.LowerName = (res.JVMName + res.GetSignatureLowerNoRet());

            return res;
        }
        
        private static object HasAttribute(MethodInfo method, Type attribute)
        {
            object[] objects = method.GetCustomAttributes(false);
            foreach (object attr in objects)
            {
                if (attr.GetType().FullName == attribute.FullName)
                {
                    return attr;
                }
            }
            return null;
        }

        private static object HasAttribute(Type tested, Type attribute)
        {
            object[] objects = tested.GetCustomAttributes(false);
            foreach (object attr in objects)
            {
                if (attr.GetType().FullName == attribute.FullName)
                {
                    return attr;
                }
            }
            return null;
        }

        private static void ConvertCLRAttributes(GType type, GMethod res, MethodBase method)
        {
            res.Attributes = 0;
            if (method.IsPublic || type.IsInterface)
            {
                res.Attributes |= MemberAttributes.Public;
            }
            else if (method.IsFamily && !type.IsInterface)
            {
                res.Attributes |= MemberAttributes.Family;
            }
            else if (method.IsFamilyOrAssembly && !type.IsInterface)
            {
                res.Attributes |= MemberAttributes.FamilyOrAssembly;
            }
            else if (method.IsFamilyAndAssembly && !type.IsInterface)
            {
                res.Attributes |= MemberAttributes.FamilyAndAssembly;
            }

            if (method.IsAbstract && !type.IsInterface)
            {
                res.Attributes |= MemberAttributes.Abstract;
            }
            else if (method.IsStatic && !type.IsInterface)
            {
                res.IsStatic = method.IsStatic;
                res.Attributes |= MemberAttributes.Static;
            }
            else if (!method.IsVirtual && !method.IsAbstract && !type.IsInterface)
            {
                res.Attributes |= MemberAttributes.Final;
            }
        }

        private static PropertyInfo GetProperty(GType type, MethodInfo method)
        {
            BindingFlags f = 0;
            if (method.IsStatic)
            {
                f |= BindingFlags.Static;
            }
            else
            {
                f |= BindingFlags.Instance;
            }
            if (method.IsPublic)
            {
                f |= BindingFlags.Public;
            }
            else
            {
                f |= BindingFlags.NonPublic;
            }
            if (method.IsAbstract)
            {
                f |= BindingFlags.DeclaredOnly;
            }
            string pname = method.Name.Substring(method.Name.IndexOf('_') + 1);
            return FindProperty(f, type.CLRType, pname);
        }

        private static PropertyInfo FindProperty(BindingFlags f, Type clazz, string pname)
        {
            PropertyInfo property = clazz.GetProperty(pname, f);
            if (property != null)
            {
                return property;
            }
            foreach (Type ifc in clazz.GetInterfaces())
            {
                property = FindProperty(f, ifc, pname);
                if (property != null)
                {
                    return property;
                }
            }
            if (!clazz.IsInterface && clazz.BaseType == typeof(object))
            {
                property = FindProperty(f, clazz.BaseType, pname);
                if (property != null)
                {
                    return property;
                }
            }

            return null;
        }

    }
}
