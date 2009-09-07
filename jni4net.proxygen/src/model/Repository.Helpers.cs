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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.config;
using system;
using Exception=System.Exception;
using Object=java.lang.Object;
using String=java.lang.String;
using StringBuilder=System.Text.StringBuilder;

namespace net.sf.jni4net.proxygen.model
{
    internal partial class Repository
    {
        private static Type javaProxyType;
        private static Type javaClassAttr;
        private static Type javaInterfaceAttr;
        private static Type javaMethodAttribute;
        private static Type clrWrapperAttr;
        private static Type javalangIObjectType;
        private static Class clrProxyClass;
        internal static GType javaLangObject;
        internal static GType javaLangIObject;
        internal static GType javaLangClass;
        internal static GType javaLangString;
        internal static GType systemObject;
        internal static GType systemIObject;
        internal static GType systemType;
        internal static GType systemString;
        internal static GType systemException;
        internal static GType javaLangThrowable;
        internal static GType voidType;

        private static void BindKnownTypesPre()
        {
            foreach (Assembly assembly in knownAssemblies)
            {
                if (javaProxyType == null)
                {
                    javaProxyType = assembly.GetType("net.sf.jni4net.jni.IJavaProxy");
                }
                if (javaClassAttr == null)
                {
                    javaClassAttr = assembly.GetType("net.sf.jni4net.attributes.JavaClassAttribute");
                }
                if (javaInterfaceAttr == null)
                {
                    javaInterfaceAttr = assembly.GetType("net.sf.jni4net.attributes.JavaInterfaceAttribute");
                }
                if (clrWrapperAttr == null)
                {
                    clrWrapperAttr = assembly.GetType("net.sf.jni4net.attributes.ClrWrapperAttribute");
                }
                if (javaMethodAttribute == null)
                {
                    javaMethodAttribute = assembly.GetType("net.sf.jni4net.attributes.JavaMethodAttribute");
                }
                if (javalangIObjectType == null)
                {
                    javalangIObjectType = assembly.GetType("java_.lang.IObject");
                }
            }
            if (javaMethodAttribute == null)
            {
                Console.Error.WriteLine("Wrong DLLs ?");
            }
            clrProxyClass = JNIEnv.ThreadEnv.FindClassNoThrow("net/sf/jni4net/inj/IClrProxy");
            knownNames.Add("int", RegisterType(typeof (int)));
            knownNames.Add("long", RegisterType(typeof (long)));
            knownNames.Add("short", RegisterType(typeof (short)));
            knownNames.Add("char", RegisterType(typeof (char)));
            knownNames.Add("double", RegisterType(typeof (double)));
            knownNames.Add("float", RegisterType(typeof (float)));
            knownNames.Add("byte", RegisterType(typeof (byte)));
            knownNames.Add("bool", RegisterType(typeof (bool)));
            knownNames.Add("boolean", RegisterType(typeof (bool)));
            knownNames.Add("void", RegisterType(typeof (void)));
            GType glong = RegisterClass(Class.getPrimitiveClass("long"));
            GType gint = RegisterClass(Class.getPrimitiveClass("int"));
            GType gshort = RegisterClass(Class.getPrimitiveClass("short"));
            GType gbyte = RegisterClass(Class.getPrimitiveClass("byte"));
            GType gchar = RegisterClass(Class.getPrimitiveClass("char"));
            GType gdouble = RegisterClass(Class.getPrimitiveClass("double"));
            GType gfloat = RegisterClass(Class.getPrimitiveClass("float"));
            GType gbool = RegisterClass(Class.getPrimitiveClass("boolean"));
            RegisterType(typeof(ulong)).JVMSubst = glong;
            RegisterType(typeof(uint)).JVMSubst = gint;
            RegisterType(typeof(ushort)).JVMSubst = gshort;
            RegisterType(typeof(sbyte)).JVMSubst = gbyte;
            RegisterType(typeof(long)).JVMSubst = glong;
            RegisterType(typeof(int)).JVMSubst = gint;
            RegisterType(typeof(short)).JVMSubst = gshort;
            RegisterType(typeof(byte)).JVMSubst = gbyte;
            RegisterType(typeof(char)).JVMSubst = gchar;
            RegisterType(typeof(double)).JVMSubst = gdouble;
            RegisterType(typeof(float)).JVMSubst = gfloat;
            RegisterType(typeof(bool)).JVMSubst = gbool;
        
        }

        private static void BindKnownTypesPost()
        {
            voidType = RegisterClass(Class.getPrimitiveClass("void"));
            systemObject = RegisterType(typeof(object));
            systemString = RegisterType(typeof(string));
            systemType = RegisterType(typeof(Type));
            systemException = RegisterType(typeof(Exception));
            javaLangObject = RegisterClass(Object._class);
            javaLangString = RegisterClass(String._class);
            javaLangClass = RegisterClass(Class._class);
            javaLangThrowable = RegisterClass(Throwable._class);
            systemString.JVMSubst = javaLangString;
            systemIObject = RegisterType(typeof (IObject));
            systemIObject.CLRSubst = systemObject;
            javaLangIObject = RegisterType(javalangIObjectType);
            javaLangIObject.JVMSubst = javaLangObject;
        }

        private static void LoadFile(string file)
        {
            string path = Path.GetFullPath(file);
            try
            {
                knownAssemblies.Add(Assembly.LoadFrom(path));
                if (config.Verbose)
                {
                    Console.WriteLine("Loaded " + path);
                }
            }
            catch (java.lang.Exception)
            {
                Console.Error.WriteLine("Can't load " + path);
                //ignore
            }
        }

        private static void LoadAssemblies()
        {
            knownAssemblies = new List<Assembly>();
            knownAssemblies.Add(typeof (object).Assembly);
            if (config.AssemblyReference != null)
            {
                foreach (string reference in config.AssemblyReference)
                {
                    if (Directory.Exists(reference))
                    {
                        foreach (string file in Directory.GetFiles(reference, "*.dll"))
                        {
                            LoadFile(file);
                        }
                        foreach (string file in Directory.GetFiles(reference, "*.exe"))
                        {
                            LoadFile(file);
                        }
                    }
                    else if (File.Exists(reference) || reference.Contains("..") || reference.Contains("\\") ||
                             reference.Contains("//"))
                    {
                        LoadFile(reference);
                    }
                    else
                    {
                        knownAssemblies.Add(Assembly.Load(reference));
                        if (config.Verbose)
                        {
                            Console.WriteLine("Loaded " + reference);
                        }
                    }
                }
            }
            if (config.AssemblyReference == null || config.AssemblyReference.Length == 0)
            {
                knownAssemblies.Add(typeof (IJavaProxy).Assembly);
            }
        }

        private static void LoadClasspath()
        {
            JNIEnv env;
            JavaVM vm;
            var cp = new StringBuilder();
            if (config.ClassPath != null)
            {
                cp.Append("-Djava.class.path=");
                foreach (string classPath in config.ClassPath)
                {
                    if (!Directory.Exists(classPath) && !File.Exists(classPath))
                    {
                        Console.Error.WriteLine("Can't find " + Path.GetFullPath(classPath));
                    }
                    else if (config.Verbose)
                    {
                        Console.WriteLine("Adding " + Path.GetFullPath(classPath));
                    }
                    cp.Append(classPath);
                    cp.Append(';');
                }
                cp.Length--;
                Bridge.CreateJVM(out vm, out env, cp.ToString());
            }
            else
            {
                Bridge.CreateJVM(out vm, out env);
            }
        }

        private static void PreLoadMethods(GType type, bool forceCLR, bool forceJVM)
        {
            if (type.IsMethodsPreLoaded)
            {
                return;
            }
            type.IsMethodsPreLoaded = true;
            
            forceJVM |= (type.IsCLRGenerate && type.IsJVMType);
            forceCLR |= (type.IsJVMGenerate && type.IsCLRType);

            if (type.Registration != null && type.Registration.IgnoreInterface!=null)
            {
                foreach (TypeReference ifcName in type.Registration.IgnoreInterface)
                {
                    foreach (GType ifc in type.Interfaces)
                    {
                        if (ifc.LowerName==ifcName.TypeName.ToLowerInvariant())
                        {
                            type.Interfaces.Remove(ifc);
                            break;
                        }
                    }
                }
            }


            if ((forceCLR || forceJVM) && type.Base!=null)
            {
                PreLoadMethods(type.Base, forceCLR,forceJVM);
            }
            if (forceJVM)
            {
                type.IsLoadJVMMethods = true;
                RegisterJVMConstructors(type, false);
                RegisterJVMMethods(type, false);
                RegisterJVMFields(type, false);
            }
            if (forceCLR)
            {
                RegisterCLRMethods(type, false);
                RegisterCLRConstructors(type, false);
                type.IsLoadCLRMethods = true;
            }
        }
        private static void LoadMethods(GType type)
        {
            if (type.IsMethodsLoaded)
            {
                return;
            }
            type.IsMethodsLoaded = true;
            foreach (GType ifc in type.Interfaces)
            {
                LoadMethods(ifc);
                foreach (KeyValuePair<string, GMethod> pair in ifc.AllMethods)
                {
                    if (!type.AllMethods.ContainsKey(pair.Key))
                    {
                        type.AllMethods.Add(pair.Key, pair.Value);
                        type.MethodsWithInterfaces.Add(pair.Value);
                    }
                }
            }

            if (type.Base != null)
            {
                LoadMethods(type.Base);
                if (!type.IsRootType)
                {
                    foreach (KeyValuePair<string, GMethod> pair in type.Base.AllMethods)
                    {
                        if (!type.AllMethods.ContainsKey(pair.Key))
                        {
                            type.AllMethods.Add(pair.Key, pair.Value);
                        }
                    }
                }
            }

            bool loadCLR = (type.IsCLRGenerate || type.IsLoadJVMMethods) && type.IsJVMType;
            bool loadJVM = (type.IsJVMGenerate || type.IsLoadCLRMethods) && type.IsCLRType;
            if ((loadCLR || (loadJVM && type.IsInterface)) && type.IsJVMType)
            {
                RegisterJVMConstructors(type, true);
                RegisterJVMMethods(type, true);
                RegisterJVMFields(type, true);
            }
            if ((loadJVM || (loadCLR && type.IsInterface)) && type.IsCLRType)
            {
                RegisterCLRMethods(type, true);
                RegisterCLRConstructors(type, true);
            }

        
        }

        private static bool TestCLRType(Type type)
        {
            return type.IsByRef || type.IsPointer || typeof(Delegate).IsAssignableFrom(type);
        }

        private static bool UseMethodModifier(GType type, GMethod res, string name, string signature, ref bool force)
        {
            var fskip = false;
            if (type.Registration != null)
            {
                MethodModifier modifier;
                if (type.Registration.GetModifier(name, signature, out modifier))
                {
                    if (modifier.Return!=null)
                    {
                        res.ReturnType = knownNames[modifier.Return.ToLowerInvariant()];
                    }
                    if (modifier.Interface!=null)
                    {
                        res.UseExplicitInterface = true;
                        res.DeclaringType = knownNames[modifier.Interface.ToLowerInvariant()];
                    }
                    if (modifier.RenameJVM != null)
                    {
                        res.JVMName = modifier.RenameJVM;
                    }
                    if (modifier.RenameCLR != null)
                    {
                        res.JVMName = modifier.RenameCLR;
                    }
                    if (modifier.Skip)
                    {
                        type.SkippedMethods.Add(res);
                        fskip = true;
                    }
                    force = type.Registration.TestForceMethod(name, signature);
                }
            }
            return fskip;
        }

        private static void FinishRegistration(string method, GType type, GMethod res, bool force, string sig, RegSkip x)
        {
            if (!res.UseExplicitInterface && !force)
            {
                if (type.AllMethods.ContainsKey(sig))
                {
                    type.SkippedMethods.Add(res);
                    if (config.Verbose)
                    {
                        Console.WriteLine("Skip " + type + "." + method + "<-" + type.AllMethods[sig].Type);
                    }
                    return;
                }
                type.AllMethods.Add(sig, res);
            }
            if (res.UseExplicitInterface)
            {
                if (type.AllMethods.ContainsKey(sig))
                {
                    GMethod rem = type.AllMethods[sig];
                    type.AllMethods.Remove(sig);
                    type.MethodsWithInterfaces.Remove(rem);
                }
                foreach (GMethod skip in type.SkippedMethods)
                {
                    var s = x(skip);
                    if (s==sig)
                    {
                        type.Methods.Add(skip);
                        type.MethodsWithInterfaces.Add(skip);
                        type.AllMethods.Add(sig, skip);
                        type.SkippedMethods.Remove(skip);
                        break;
                    }
                }
                type.AllMethods.Add(res.DeclaringType.Name+"."+sig, res);
            }
            type.MethodsWithInterfaces.Add(res);
            type.Methods.Add(res);
        }

        private static string GetInterfaceName(Type type)
        {
            string clazzName = type.Namespace.ToLowerInvariant() + "." + type.Name.Replace("__", "");
            if (clazzName == "java.lang.IObject")
            {
                clazzName = "java_.lang.IObject";
            }
            clazzName = clazzName.Replace('.', '/');
            return clazzName;
        }
    }
}
