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
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using selvin.exportdllattribute;
using Exception=System.Exception;
using Object=java.lang.Object;

namespace net.sf.jni4net
{
    public static unsafe class Bridge
    {
        private static readonly Dictionary<Assembly, object> knownAssemblies = new Dictionary<Assembly, object>();
        private static bool bindNative = true;
        public static bool Verbose { get; set; }

        public static bool BindNative
        {
            get { return bindNative; }
            set { bindNative = value; }
        }

        public static void CreateJVM(params string[] options)
        {
            JavaVM jvm;
            JNIEnv env;
            JNI.CreateJavaVM(out jvm, out env, true, options);
        }

        public static void CreateJVM(out JavaVM jvm, out JNIEnv env, params string[] options)
        {
            JNI.CreateJavaVM(out jvm, out env, true, options);
        }

        public static void LoadAndRegisterAssembly(string assemblyPath)
        {
            Assembly assembly;
            if (File.Exists(assemblyPath))
            {
                assembly = Assembly.LoadFrom(assemblyPath);
            }
            else
            {
                assembly = Assembly.Load(assemblyPath);
            }
            RegisterAssembly(assembly);
        }

        public static void RegisterAssembly(Assembly assembly)
        {
            if (knownAssemblies.ContainsKey(assembly))
            {
                if (Verbose)
                {
                    Console.WriteLine("skipped " + assembly);
                }
                return;
            }
            if (Verbose)
            {
                Console.WriteLine("loading " + assembly);
            }
            knownAssemblies.Add(assembly, assembly);
            JNIEnv env = JNIEnv.GetEnv();
            JavaProxiesMap.RegisterAssembly(env, assembly);
            ClrProxiesMap.RegisterAssembly(env, assembly);
            if (Verbose)
            {
                Console.WriteLine("loaded " + assembly);
            }
        }

        public static TRes ToCLR<TRes>(IJavaProxy obj) where TRes : class
        {
            IClrProxy proxy = obj as IClrProxy;
            if (proxy==null)
            {
                return obj as TRes;
            }
            return ClrProxiesMap.ToClr<TRes>(proxy);
        }

        public static object ToCLR(Object obj)
        {
            if (obj==null)
            {
                return null;
            }
            IClrProxy proxy = obj as IClrProxy;
            if (proxy == null)
            {
                return obj;
            }
            return ClrProxiesMap.ToClr<object>(proxy);
        }

        public static Object ToJVM(object obj)
        {
            Object jp = obj as Object;
            if (jp!=null)
            {
                return jp;
            }
            return ClrProxiesMap.WrapClrObj(JNIEnv.GetEnv(), obj) as Object;
        }

        public static TRes ToJVM<TRes>(object obj) where TRes : class, IObject
        {
            Object jp = obj as Object;
            if (jp != null)
            {
                return jp as TRes;
            }
            return ClrProxiesMap.WrapClrObj(JNIEnv.GetEnv(), obj) as TRes;
        }

        public static Class TypeToKnownClass(Type real)
        {
            return ClrProxiesMap.RealToKnownIface(real);
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
            while (arr!=-1)
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
                    return array + "L" + typeName.Substring(0,low.Length).Replace('.', '/') + ";";
            }
        }

        public static string JavaSignature(Class clazz)
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

        public static void InvokeStatic(Class clazz, string method, string signature, params object[] args)
        {
            JNIEnv.GetEnv().CallStaticMethod(clazz, method, signature, args);
        }

        public static TRes InvokeStatic<TRes>(Class clazz, string method, string signature, params object[] args)
        {
            return JNIEnv.GetEnv().CallStaticMethod<TRes>(clazz, method, signature, args);
        }

        public static void disposeClrHandle(int clrHandle)
        {
            IntHandle.Free(clrHandle);
        }

        #region Initialization

        [ExportDll("Java_net_sf_jni4net_Bridge_initDotNet", CallingConvention.StdCall)]
        internal static int initDotNet(JNIEnv.JavaPtr* envi, Class.JavaPtr* clazz, bool verbose)
        {
            Verbose = verbose;
            JNIEnv env;
            try
            {
                env = (*envi).Wrap();
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Can't bind env");
                return -1;
            }
            try
            {
                Init(env);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't init bridge:" + ex.Message);
                Class exClazz = env.FindClass("net/sf/jni4net/inj/INJException");
                env.ThrowNew(exClazz, ex.Message);
                return -1;
            }
            return 0;
        }

        internal static void Init(JNIEnv env)
        {
            // rather neat. When called like Clr->Java->Clr this dll gets loaded twice.
            // which means two separate sets CLR of classes and static members
            RegisterAssembly(typeof (Bridge).Assembly);
            Class clazz = null;
            if (BindNative)
            {
                clazz = env.FindClass("net/sf/jni4net/Bridge");
                if (clazz == null)
                {
                    return;
                }
                var isRegistered = clazz.GetFieldValue<bool>("isRegistered", "Z");
                if (isRegistered)
                {
                    return;
                }
            }

            if (Verbose)
            {
                Console.WriteLine("Initialized jni4net core");
            }
            if (BindNative)
            {
                clazz.SetFieldValue("isRegistered", "Z", true);
            }
        }

        #endregion
    }
}