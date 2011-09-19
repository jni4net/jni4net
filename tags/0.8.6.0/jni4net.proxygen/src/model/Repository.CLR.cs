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
using net.sf.jni4net.proxygen.config;
using String = java.lang.String;

namespace net.sf.jni4net.proxygen.model
{
    internal partial class Repository
    {
        #region Delegates

        public delegate string RegSkip(GMethod skip);

        #endregion

        public static List<GType> CLRGenTypes()
        {
            var res = new List<GType>();
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
            Type original = type;
            if (knownTypes.ContainsKey(type))
            {
                GType known = knownTypes[type];
                if (registration != null)
                {
                    known.Registration = registration;
                }
                return known;
            }
            var res = new GType();
            if(typeof(Delegate).IsAssignableFrom(type))
            {
                int i = 0;
            }
            if (type.IsPointer)
            {
                //it's out really
                res.IsOut = true;
                type = type.GetElementType();
            }
            if (type.IsByRef)
            {
                //it's ref really
                res.IsRef = true;
                type = type.GetElementType();
            }
            if (type.IsArray)
            {
                res.ArrayElement = RegisterType(type.GetElementType());
                res.IsArray = true;
            }

            res.LowerName = original.FullName.ToLowerInvariant();
            if (res.IsOut)
            {
                res.LowerName += "!";
            }
            if (knownNames.ContainsKey(res.LowerName))
            {
                res = knownNames[res.LowerName];
            }
            
            if (type.IsAbstract)
            {
                res.IsAbstract = true;
            }
            if (type.IsSealed)
            {
                res.IsFinal = true;
            }
            if (typeof(Delegate).IsAssignableFrom(type) && typeof(Delegate) != type && typeof(MulticastDelegate) != type)
            {
                res.IsDelegate = true;
            }

            if (res.Registration == null && registration != null)
            {
                res.Registration = registration;
            }
            res.IsPrimitive = type.IsPrimitive;
            res.IsException = typeof(Exception).IsAssignableFrom(type);
            res.CLRType = original;
            if (res.IsArray)
            {
                res.CLRFullName = type.GetElementType().FullName + "[]";
            }
            else
            {
                res.CLRFullName = type.FullName;
            }
            res.Attributes = type.Attributes;
            res.IsCLRType = true;
            res.IsInterface = type.IsInterface;
            res.IsJVMProxy = jvmProxyType.IsAssignableFrom(type);
            if (!res.IsJVMProxy)
            {
                res.IsCLRRealType = true;
            }
            if (type.BaseType != null && res.Base == null
                && type != typeof (object)
                && type != typeof (Exception)
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
                    if (!TestCLRTypeStrong(ifc))
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
            }
            Register(res);

            if (type.IsGenericType)
            {
                Type sub;
                Type supGeneric = type.GetGenericTypeDefinition();
                if (typeof (IComparable<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof (IComparable);
                    res.LowerName =
                        ("System.IComparable<" + type.GetGenericArguments()[0].Name + ">").ToLowerInvariant();
                }
                else if (typeof (IEnumerable<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof (IEnumerable);
                    res.LowerName =
                        ("System.Collections.Generic.IEnumerable<" + type.GetGenericArguments()[0].Name + ">").
                            ToLowerInvariant();
                }
                else if (typeof (IEnumerator<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof (IEnumerator);
                    res.LowerName =
                        ("System.Collections.Generic.IEnumerator<" + type.GetGenericArguments()[0].Name + ">").
                            ToLowerInvariant();
                }
                else if (typeof (IEquatable<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof (object);
                    res.LowerName =
                        ("System.Collections.Generic.IEquatable<" + type.GetGenericArguments()[0].Name + ">").
                            ToLowerInvariant();
                }
                else if (typeof (ICollection<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof (ICollection);
                    res.LowerName =
                        ("System.Collections.Generic.ICollection<" + type.GetGenericArguments()[0].Name + ">").
                            ToLowerInvariant();
                }
                else if (typeof (IList<>).IsAssignableFrom(supGeneric))
                {
                    sub = typeof (IList);
                    res.LowerName =
                        ("System.Collections.Generic.IList<" + type.GetGenericArguments()[0].Name + ">").
                            ToLowerInvariant();
                }
                else
                {
                    sub = type.BaseType;
                    if (sub == null)
                    {
                        sub = typeof (object);
                    }
                }
                res.JVMSubst = RegisterType(sub);
            }
            if (res.IsOut)
            {
                Type sub;
                if (type.IsArray)
                {
                    sub = typeof(Out<>).MakeGenericType(typeof(object));
                }
                else
                {
                    sub = typeof(Out<>).MakeGenericType(type);
                }
                res.JVMSubst = RegisterType(sub);
                res.CLRSubst = res;
            }
            if (res.IsRef)
            {
                Type sub;
                if (type.IsArray)
                {
                    sub = typeof(Ref<>).MakeGenericType(typeof(object));
                }
                else
                {
                    sub = typeof(Ref<>).MakeGenericType(type);
                }
                res.JVMSubst = RegisterType(sub);
                res.CLRSubst = res;
            }

            return res;
        }

        private static void RegisterCLRConstructors(GType type, bool register)
        {
            if (type.IsAbstract)
            {
                return;
            }
            Type clrType = type.CLRType;
            if (typeof(Delegate).IsAssignableFrom(clrType))
            {
                if (config.Verbose)
                {
                    Console.WriteLine("Skip " + type + " constructors");
                }
                return;                
            }
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
                    || type.CLRType == typeof (Exception))
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
                    Console.WriteLine("Skip " + type + "." + method);
                }
                return;
            }
            if (method.IsSpecialName)
            {
                string name = method.Name;
                if (name.StartsWith("op_"))
                {
                    if (config.Verbose)
                    {
                        Console.WriteLine("Skip " + type + "." + method);
                    }
                    return;
                }
            }

            GMethod res = RegisterCLRCall(type, method);
            if (res == null || TestCLRType(method.ReturnType))
            {
                // skip
                if (config.Verbose)
                {
                    Console.WriteLine("Skip " + type + "." + method);
                }
                return;
            }
            if (method.IsSpecialName)
            {
                res.CLRProperty = GetProperty(type, method);
                if (res.CLRProperty == null)
                {
                    res.CLREvent = GetEvent(type, method);
                    res.IsEvent = true;
                    if (method.Name.StartsWith("add_"))
                    {
                        res.IsCLRPropertyAdd = true;
                        res.CLRPropertyAdd = res;
                        foreach (GMethod m in type.Methods)
                        {
                            if (m.CLRProperty == res.CLRProperty)
                            {
                                m.CLRPropertyAdd = res;
                            }
                        }
                    }
                    if (method.Name.StartsWith("remove_"))
                    {
                        res.IsCLRPropertyRemove = true;
                        res.CLRPropertyRemove = res;
                        foreach (GMethod m in type.Methods)
                        {
                            if (m.CLRProperty == res.CLRProperty)
                            {
                                m.CLRPropertyRemove = res;
                            }
                        }
                    }
                    res.CLRName = res.CLREvent.Name;
                    res.JVMName = method.Name.Replace("_", "");
                }
                else
                {
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
                    res.CLRName = res.CLRProperty.Name;
                    res.JVMName = method.Name.Replace("_", "");
                    if (res.CLRProperty.PropertyType == typeof(bool) && res.JVMName.StartsWith("getIs"))
                    {
                        res.JVMName = "is" + res.JVMName.Substring(5);
                    }
                }
                res.Name = method.Name;
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
                    if (config.Verbose)
                    {
                        Console.WriteLine("Skip " + type + "." + method);
                    }
                    return;
                }
                FinishRegistration(method.Name, type, res, force, res.Name + res.GetJVMSignatureNoRet(), skipJVM);
            }
        }

        private static string skipJVM(GMethod skip)
        {
            return skip.Name + skip.GetJVMSignatureNoRet();
        }

        private static void RegisterCLRConstructor(GType type, ConstructorInfo method, bool register)
        {
            GMethod res = RegisterCLRCall(type, method);
            if (res == null)
            {
                if (config.Verbose)
                {
                    Console.WriteLine("Skip " + type + "." + method);
                }
                // skip
                return;
            }
            res.IsConstructor = true;
            if (register)
            {
                string sig = type.Name + res.GetJVMSignatureNoRet();
                if (type.AllMethods.ContainsKey(sig))
                {
                    if (config.Verbose)
                    {
                        Console.WriteLine("Skip " + type + "." + method);
                    }
                    return;
                }
                type.AllMethods.Add(sig, res);
                type.Constructors.Add(res);
            }
        }

        private static GMethod RegisterCLRCall(GType type, MethodBase method)
        {
            var res = new GMethod();
            res.Type = type;
            res.Name = method.Name;
            res.CLRName = method.Name;
            res.JVMName = method.Name;
            res.IsCLRMethod = true;
            foreach (ParameterInfo info in method.GetParameters())
            {
                Type parameterType = info.ParameterType;
                if (TestCLRType(parameterType))
                {
                    return null;
                }
                // we ignore IsOut when IsIn is set as well, because they are probably just attributes
                // see System.IO.TextReader.Read([In, Out] char[] buffer, int index, int count)
                if (info.IsOut && !info.IsIn)
                {
                    //this is trick how to store out as type
                    parameterType = parameterType.GetElementType().MakePointerType();
                }
                res.ParameterNames.Add(info.Name);
                res.Parameters.Add(RegisterType(parameterType));
            }
            res.ReturnType = RegisterType(typeof (void));

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
                //TODO res.Attributes |= MemberAttributes.Final;
            }
        }

		private static PropertyInfo GetProperty( GType type, MethodInfo method )
		{
			BindingFlags f = GetPropFlags( method );
			string pname = method.Name.Substring( method.Name.IndexOf( '_' ) + 1 );

			bool isIndexerProperty = method.IsSpecialName && pname == "Item";
			if (isIndexerProperty)
			{
                var pts=new List<Type>();
			    int length = method.GetParameters().Length;
                if (method.Name.StartsWith("set_"))
                {
                    // setter value
                    length--;
                }
			    for (int index = 0; index < length; index++)
			    {
			        var parameter = method.GetParameters()[index];
			        pts.Add(parameter.ParameterType);
			    }
			    return FindIndexerProperty(f, type.CLRType, method.ReturnType, pts.ToArray());
            }

			return FindProperty( f, type.CLRType, pname );
		}

        private static EventInfo GetEvent(GType type, MethodInfo method)
        {
            BindingFlags f = GetPropFlags(method);
            string pname = method.Name.Substring(method.Name.IndexOf('_') + 1);
            return FindEvent(f, type.CLRType, pname);
        }

        private static BindingFlags GetPropFlags(MethodInfo method)
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
            return f;
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
            if (!clazz.IsInterface && clazz.BaseType == typeof (object))
            {
                property = FindProperty(f, clazz.BaseType, pname);
                if (property != null)
                {
                    return property;
                }
            }
            return null;
        }

		private static PropertyInfo FindIndexerProperty( BindingFlags f, Type clazz, Type returnType, Type[] parameterTypes )
		{
            PropertyInfo property = clazz.GetProperty("Item", f, Type.DefaultBinder, returnType, parameterTypes, default(ParameterModifier[]));
			if (property != null)
			{
				return property;
			}
			foreach (Type ifc in clazz.GetInterfaces())
			{
				property = FindIndexerProperty( f, ifc, returnType, parameterTypes );
				if (property != null)
				{
					return property;
				}
			}
			if (!clazz.IsInterface && clazz.BaseType == typeof( object ))
			{
				property = FindIndexerProperty( f, clazz.BaseType, returnType, parameterTypes );
				if (property != null)
				{
					return property;
				}
			}

			return null;
		}

        private static EventInfo FindEvent(BindingFlags f, Type clazz, string pname)
        {
            EventInfo property = clazz.GetEvent(pname, f);
            if (property != null)
            {
                return property;
            }
            foreach (Type ifc in clazz.GetInterfaces())
            {
                property = FindEvent(f, ifc, pname);
                if (property != null)
                {
                    return property;
                }
            }
            if (!clazz.IsInterface && clazz.BaseType == typeof(object))
            {
                property = FindEvent(f, clazz.BaseType, pname);
                if (property != null)
                {
                    return property;
                }
            }

            return null;
        }

    }
}