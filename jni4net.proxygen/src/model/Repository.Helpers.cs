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
using System.IO;
using System.Reflection;
using java.lang;
using java.lang.reflect;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.config;
using Exception=System.Exception;
using Object=java.lang.Object;
using String=java.lang.String;
using StringBuilder=System.Text.StringBuilder;
using Type=System.Type;

namespace net.sf.jni4net.proxygen.model
{
    internal partial class Repository
    {
        internal static GType clrProxy;
        private static Class clrProxyClass;
        private static Type clrWrapperAttr;
        private static Type javaClassAttr;
        private static Type javaInterfaceAttr;
        internal static GType javaLangClass;
        internal static GType javaLangIObject;
        private static Type javalangIObjectType;
        internal static GType javaLangObject;
        internal static GType javaLangString;
        internal static GType javaLangThrowable;
        private static Type javaMethodAttribute;
        internal static GType jvmProxy;
        private static Type jvmProxyType;
        internal static GType systemException;
        internal static GType systemObject;
        internal static GType systemIObject;
        internal static GType systemString;
        internal static GType systemType;
        internal static GType voidType;

        internal static Dictionary<Type, Class> jvmPrimitives = new Dictionary<Type, Class>();

        private static void BindKnownTypesPre()
        {
            foreach (Assembly assembly in knownAssemblies)
            {
                if (jvmProxyType == null)
                {
                    jvmProxyType = assembly.GetType("net.sf.jni4net.jni.IJvmProxy");
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
            clrProxy = RegisterClass(clrProxyClass);
            systemIObject = RegisterClass(JNIEnv.ThreadEnv.FindClassNoThrow("system/IObject"));
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
            RegisterType(typeof(IntPtr)).JVMSubst = glong;
            jvmPrimitives.Add(typeof(long), Class.forName("java.lang.Long"));
            jvmPrimitives.Add(typeof(int), Class.forName("java.lang.Integer"));
            jvmPrimitives.Add(typeof(short), Class.forName("java.lang.Short"));
            jvmPrimitives.Add(typeof(byte), Class.forName("java.lang.Byte"));
            jvmPrimitives.Add(typeof(char), Class.forName("java.lang.Character"));
            jvmPrimitives.Add(typeof(double), Class.forName("java.lang.Double"));
            jvmPrimitives.Add(typeof(float), Class.forName("java.lang.Float"));
            jvmPrimitives.Add(typeof(bool), Class.forName("java.lang.Boolean"));
            jvmPrimitives.Add(typeof(ulong), Class.forName("java.lang.Long"));
            jvmPrimitives.Add(typeof(uint), Class.forName("java.lang.Integer"));
            jvmPrimitives.Add(typeof(ushort), Class.forName("java.lang.Short"));
            jvmPrimitives.Add(typeof(sbyte), Class.forName("java.lang.Byte"));
        }

        private static void BindKnownTypesPost()
        {
            voidType = RegisterClass(Class.getPrimitiveClass("void"));
            systemObject = RegisterType(typeof (object));
            systemString = RegisterType(typeof (string));
            systemType = RegisterType(typeof (Type));
            systemException = RegisterType(typeof (Exception));
            javaLangObject = RegisterClass(Object._class);
            javaLangString = RegisterClass(String._class);
            javaLangClass = RegisterClass(Class._class);
            javaLangThrowable = RegisterClass(Throwable._class);
            systemString.JVMSubst = javaLangString;
            javaLangIObject = RegisterType(javalangIObjectType);
            javaLangIObject.JVMSubst = javaLangObject;
            jvmProxy = RegisterType(jvmProxyType);
            jvmProxy.JVMSubst = javaLangObject;
            clrProxy.CLRSubst = systemObject;
        }

        private static Assembly LoadFile(string file)
        {
            string path = Path.GetFullPath(file);
            try
            {
                Assembly assembly = Assembly.LoadFrom(path);
                knownAssemblies.Add(assembly);
                if (config.Verbose)
                {
                    Console.WriteLine("Loaded " + path);
                }
                return assembly;
            }
            catch (java.lang.Exception)
            {
                Console.Error.WriteLine("Can't load " + path);
                //ignore
                return null;
            }
        }

        private static void LoadAssemblies()
        {
            bool foundJni4net = false;
            knownAssemblies = new List<Assembly>();
            knownAssemblies.Add(typeof (object).Assembly);
            if (config.AssemblyReference != null && config.AssemblyReference.Length>0)
            {
                foreach (var reference in config.AssemblyReference)
                {
                    Assembly assembly=null;
                    string pathOrName = reference.Assembly;
                    if (Directory.Exists(pathOrName))
                    {
                        foreach (string file in Directory.GetFiles(pathOrName, "*.dll"))
                        {
                            assembly = LoadFile(file);
                            foundJni4net |= TestJni4net(assembly);
                        }
                        foreach (string file in Directory.GetFiles(pathOrName, "*.exe"))
                        {
                            assembly = LoadFile(file);
                            foundJni4net |= TestJni4net(assembly);
                        }
                    }
                    else if (File.Exists(pathOrName) || pathOrName.Contains("..") || pathOrName.Contains("\\") ||
                             pathOrName.Contains("//"))
                    {
                        assembly = LoadFile(pathOrName);
                        foundJni4net |= TestJni4net(assembly);
                    }
                    else
                    {
                        assembly = Assembly.Load(pathOrName);
                        foundJni4net |= TestJni4net(assembly);
                        knownAssemblies.Add(assembly);
                        if (config.Verbose)
                        {
                            Console.WriteLine("Loaded " + reference);
                        }
                    }
                    if (reference.Generate)
                    {
                        generateAssemblies.Add(assembly);
                    }
                }
            }
            if (!foundJni4net)
            {
                knownAssemblies.Add(typeof (IJvmProxy).Assembly);
            }
        }

        private static bool TestJni4net(Assembly assembly)
        {
            if (assembly.GetType(typeof (IJvmProxy).FullName, false)!=null)
            {
                return true;
            }
            return false;
        }

        private static void LoadClasspath()
        {
            BridgeSetup setup=new BridgeSetup(false);
            setup.BindNative = false;
            setup.BindStatic = true;

            if (config.ClassPath != null && config.ClassPath.Length > 0)
            {
                foreach (var classPath in config.ClassPath)
                {
                    setup.AddClassPath(Path.GetFullPath(classPath.Path));
                    if (classPath.Generate)
                    {
                        generateCp.Add(classPath.Path);
                    }
                }
            }
            setup.AddBridgeClassPath();
            Bridge.CreateJVM(setup);
            systemClassLoader = ClassLoader.getSystemClassLoader();
        }

        /// <summary>
        /// Propagate method loading
        /// </summary>
        private static void FlagLoadMethods(GType type, bool forceCLR, bool forceJVM)
        {
            forceJVM |= type.IsCLRGenerate;
            forceJVM &= type.IsJVMType;
            forceCLR |= type.IsJVMGenerate;
            forceCLR &= type.IsCLRType;

            if ((forceCLR || forceJVM))
            {
                foreach (GType ifc in type.Interfaces)
                {
                    FlagLoadMethods(ifc, forceCLR, forceJVM);
                }
                if (type.Base != null)
                {
                    FlagLoadMethods(type.Base, forceCLR, forceJVM);
                }
                if (forceJVM)
                {
                    type.IsLoadJVMMethods = true;
                }
                if (forceCLR)
                {
                    type.IsLoadCLRMethods = true;
                }
            }
        }


        /// <summary>
        /// Prefetch types of parameters
        /// </summary>
        private static void PreLoadMethods(GType type)
        {
            if (type.IsMethodsPreLoaded)
            {
                return;
            }
            type.IsMethodsPreLoaded = true;

            if (type.Registration != null && type.Registration.IgnoreInterface != null)
            {
                foreach (TypeReference ifcName in type.Registration.IgnoreInterface)
                {
                    foreach (GType ifc in type.Interfaces)
                    {
                        if (ifc.LowerName == ifcName.TypeName.ToLowerInvariant())
                        {
                            type.Interfaces.Remove(ifc);
                            break;
                        }
                    }
                }
            }

            if (type.IsLoadCLRMethods || type.IsLoadJVMMethods)
            {
                foreach (GType ifc in type.Interfaces)
                {
                    PreLoadMethods(ifc);
                }
                if (type.Base != null)
                {
                    PreLoadMethods(type.Base);
                }
                if (type.IsLoadJVMMethods)
                {
                    //dry registration
                    RegisterJVMConstructors(type, false);
                    RegisterJVMMethods(type, false);
                    RegisterJVMFields(type, false);
                }
                if (type.IsLoadCLRMethods)
                {
                    //dry registration
                    RegisterCLRMethods(type, false);
                    RegisterCLRConstructors(type, false);
                }
            }
        }

        /// <summary>
        /// Load and register methods
        /// </summary>
        private static void LoadMethods(GType type)
        {
            if (type.IsMethodsLoaded)
            {
                return;
            }
            type.IsMethodsLoaded = true;
            if (type.Base != null)
            {
                LoadMethods(type.Base);
                if (!type.IsRootType && !type.IsInterface)
                {
                    foreach (var pair in type.Base.AllMethods)
                    {
                        if (!type.AllMethods.ContainsKey(pair.Key))
                        {
                            type.AllMethods.Add(pair.Key, pair.Value);
                        }
                    }
                }
            }

            if (!type.IsInterface)
            {
                foreach (GType ifc in type.Interfaces)
                {
                    LoadMethods(ifc);
                    foreach (var pair in ifc.AllMethods)
                    {
                        if (!type.AllMethods.ContainsKey(pair.Key) || pair.Value.UseExplicitInterface ||
                            type.AllMethods[pair.Key].UseExplicitInterface)
                        {
                            type.AllMethods.Add(pair.Key, pair.Value);
                            type.MethodsWithInterfaces.Add(pair.Value);
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

        private static bool TestCLRTypeStrong(Type type)
        {
            bool nested = false;
            if (type.IsNested)
            {
                nested = TestCLRType(type.DeclaringType);
            }
            return nested || (!type.IsPublic) || TestCLRType(type);
        }

        private static bool TestCLRType(Type type)
        {
            return type.IsPointer
                //|| type.IsByRef 
                //|| typeof (Delegate).IsAssignableFrom(type)
                ;
        }

        private static bool UseMethodModifier(GType type, GMethod res, string name, string signature, ref bool force)
        {
            bool fskip = false;
            if (type.Registration != null)
            {
                MethodModifier modifier;
                if (type.Registration.GetModifier(name, signature, out modifier))
                {
                    if (modifier.Return != null)
                    {
                        res.ReturnType = knownNames[modifier.Return.ToLowerInvariant()];
                    }
                    if (modifier.Interface != null)
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
                    if (modifier.Hide)
                    {
                        res.Attributes = (res.Attributes & (MemberAttributes.VTableMask|MemberAttributes.ScopeMask)) | MemberAttributes.Private;
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

        private static void FinishRegistration(string method, GType type, GMethod res, bool force, string sig, RegSkip skipSignatureBuilder)
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
                    string skipSig = skipSignatureBuilder(skip);
                    if (skipSig == sig)
                    {
                        type.Methods.Add(skip);
                        type.MethodsWithInterfaces.Add(skip);
                        type.AllMethods.Add(sig, skip);
                        type.SkippedMethods.Remove(skip);
                        break;
                    }
                }
                type.AllMethods.Add(res.DeclaringType.Name + "." + sig, res);
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

        private static void RegisterClass(string clazzName)
        {
            Class clazz = loadClass(clazzName, false);
            if (clazz != null && ((ModifierFlags)clazz.getModifiers() & ModifierFlags.Public) != 0)
            {
                TypeRegistration registration = new TypeRegistration();
                registration.TypeName = clazzName;
                GType reg = RegisterClass(clazz, registration);
                reg.IsCLRGenerate = true;
                reg.IsSkipJVMInterface = !registration.SyncInterface;
                reg.MergeJavaSource = registration.MergeJavaSource;
            }
        }
    }
}