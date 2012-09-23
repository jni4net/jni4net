#region Copyright (C) 2012 by Pavel Savara

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
using System.Linq;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using net.sf.jni4net;
using net.sf.jni4net.core;
using net.sf.jni4net.jni;
using Boolean = java.lang.Boolean;
using Byte = java.lang.Byte;
using Double = java.lang.Double;
using JType = java.lang.reflect.Type;
using Object = java.lang.Object;
using String = java.lang.String;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Utils
{
    public static class ReflectionUtils
    {
        private static readonly IntPtr getMethod0;
        private static readonly Dictionary<Class, Class> makeArray = new Dictionary<Class, Class>();

        static ReflectionUtils()
        {
            getMethod0 = JNIEnv.ThreadEnv.GetMethodID(Class._class, "getMethod0", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
            makeArray.Add(Character.TYPE, Class.forName("[C"));
            makeArray.Add(Long.TYPE, Class.forName("[J"));
            makeArray.Add(Integer.TYPE, Class.forName("[I"));
            makeArray.Add(Boolean.TYPE, Class.forName("[Z"));
            makeArray.Add(Byte.TYPE, Class.forName("[B"));
            makeArray.Add(Double.TYPE, Class.forName("[D"));
            makeArray.Add(Float.TYPE, Class.forName("[F"));
            makeArray.Add(Short.TYPE, Class.forName("[S"));
        }

        public static bool IsMethodDefinedOnInterface(Class jvm, String name, Class[] pars)
        {
            if (IsMethodDefined((Class)Object._class,name,pars))
            {
                return true;
            }
            return jvm.getInterfaces().Any(ifc => IsMethodDefined(ifc, name, pars));
        }

        public static bool IsMethodDefinedOnBaseClass(Class jvm, String name, Class[] pars)
        {
            Class superClass = jvm.getSuperclass();
            return superClass != null && IsMethodDefined(superClass, name, pars);
        }

        public static bool IsMethodDefined(Class superClass, String name, Class[] pars)
        {
            return GetMethodNoThrow(superClass, name, pars) != null;
        }
        
        public static Method GetMethodNoThrow(Class clazz, string name, Class[] pars)
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            using (new LocalFrame(env))
            {
                IntPtr array = env.NewObjectArray(Class._class, pars.Length);
                for (int i = 0; i < pars.Length; i++)
                {
                    env.SetObjectArrayElement(array, i, ((IClass)pars[i]).JvmHandle);
                }

                IntPtr lh = env.CallObjectMethod(clazz, getMethod0, ConvertString.ToValue(env, name), ConvertSealed.ToValue(env, pars));

                return ConvertAbstract.ToCLR<Method>(env, lh);
            }
        }

        public static Class getPrimitiveClass(string name)
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            var id = env.GetStaticMethodID(Class._class, "getPrimitiveClass", "(Ljava/lang/String;)Ljava/lang/Class;");
            return ConvertClass.ToCLR<Class>(env, env.CallStaticObjectMethod(Class._class, id, ConvertString.ToValue(env, name)));
        }
        
        public static string GetJvmSignature(Member member)
        {
            var sb = new System.Text.StringBuilder();

            var method = member as Method;
            var field = member as Field;
            var constructor = member as Constructor;
            if (method != null)
            {
                sb.Append('(');
                foreach (Class par in method.getParameterTypes())
                {
                    sb.Append(JavaSignature(par));
                }
                sb.Append(')');
                sb.Append(JavaSignature(method.getReturnType()));
            }
            else if(field!=null)
            {
                sb.Append(JavaSignature(field.getType()));
            }
            else if (constructor != null)
            {
                sb.Append('(');
                foreach (Class par in constructor.getParameterTypes())
                {
                    sb.Append(JavaSignature(par));
                }
                sb.Append(')');
                sb.Append('V');
            }
            else
            {
                throw new ProxygenException("Unexpected");
            }

            return sb.ToString();
        }

        public static string JavaSignature(Class clazz)
        {
            string name = clazz.getName();
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


        /*public static Class MakeArray(this Class self)
        {
            Class res;
            if (!makeArray.TryGetValue(self, out res))
            {
                res = JNIEnv.ThreadEnv.NewObjectArray(0, self, null).getClass();
                makeArray.Add(self, res);
            }
            return res;
        }*/

        public static bool Implements(this Type self, Type ifc)
        {
            return ifc.IsAssignableFrom(self);
        }

        public static bool IsGenericClass(this Class jvmEnclosing)
        {
            return jvmEnclosing.getTypeParameters().Length > 0;
        }

        public static bool IsAbstract(this Class jvm)
        {
            return EnumUtils.IsSet((ModifierFlags) jvm.getModifiers(), ModifierFlags.Abstract);
        }

        public static bool IsFinal(this Class jvm)
        {
            return EnumUtils.IsSet((ModifierFlags) jvm.getModifiers(), ModifierFlags.Final);
        }

        public static bool IsStatic(this Member jvm)
        {
            return EnumUtils.IsSet((ModifierFlags) jvm.getModifiers(), ModifierFlags.Static);
        }

        public static bool IsNested(this Class jvm)
        {
            return jvm.getDeclaringClass() != null;
        }

        public static bool DetectIsClr(Class jvm, Type clr)
        {
            bool isClr;
            if (clr.IsInterface
                    ? IsProxyAnnotatedInterface(clr)
                    : IsProxyAnnotatedType(clr))
            {
                isClr = false;
            }
            else if (jvm.isInterface()
                         ? IsProxyAnnotatedInterface(jvm)
                         : IsProxyAnnotatedType(jvm))
            {
                isClr = true;
            }
            else if (clr.FindInterfaces((type, o) => type.FullName == typeof (IJvmProxy).FullName, null).Length > 0)
            {
                isClr = true;
            }
            /*TODO else if (IClrProxy_._class.isAssignableFrom(jvm))
            {
                isClr = false;
            }*/
            else
            {
                isClr = true;
            }
            return isClr;
        }

        public static bool IsProxyAnnotatedInterface(Type type)
        {
            if (!type.IsInterface) return false;
            foreach (var customAttributeData in type.__GetCustomAttributes(null, false))
            {
                if (customAttributeData.Constructor.DeclaringType.FullName == "net.sf.jni4net.attributes.J4NProxyAttribute")
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsProxyAnnotatedType(Type type)
        {
            if (type.IsInterface) return false;
            foreach (var customAttributeData in type.__GetCustomAttributes(null, false))
            {
                if (customAttributeData.Constructor.DeclaringType.FullName == "net.sf.jni4net.attributes.J4NProxyAttribute")
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsProxyAnnotatedInterface(Class type)
        {
            if (type == null || !type.isInterface()) return false;
            Annotation[] annotations = type.getAnnotations();
            foreach (Annotation annotation in annotations)
            {
                string name = annotation.annotationType().getName();
                if (name == "net.sf.jni4net.attributes.J4NProxy")
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsProxyAnnotatedType(Class type)
        {
            if (type == null || type.isInterface()) return false;
            Annotation[] annotations = type.getAnnotations();
            foreach (Annotation annotation in annotations)
            {
                string name = annotation.annotationType().getName();
                if (name == "net.sf.jni4net.attributes.J4NProxy")
                {
                    return true;
                }
            }
            return false;
        }

        public static ParameterizedType makeParameterizedType(Class rawType,
                                                              JType[] actualTypeArguments,
                                                              JType ownerType)
        {
            throw new NotImplementedException();
        }


        public static bool IsPublic(this Class clazz)
        {
            var modifiers = (ModifierFlags) clazz.getModifiers();
            return EnumUtils.IsSet(modifiers, ModifierFlags.Public);
        }
    }

    public static class ClassExtension
    {

        public static string GetShortName(this Class self)
        {
            string name = self.getName();
            int i = name.LastIndexOf('.');
            if (i == -1)
            {
                return name;
            }
            return name.Substring(i + 1);
        }

        public static string GetPackageName(this Class self)
        {
            string name = self.getName();
            int i = name.LastIndexOf('.');
            if (i == -1)
            {
                return "";
            }
            return name.Substring(0, i);
        }
    }

    [Flags]
    public enum ModifierFlags
    {
        None = 0x00000000,
        Public = 0x00000001,
        Private = 0x00000002,
        Protected = 0x00000004,
        Static = 0x00000008,
        Final = 0x00000010,
        Synchronized = 0x00000020,
        Volatile = 0x00000040,
        Transient = 0x00000080,
        Native = 0x00000100,
        Interface = 0x00000200,
        Abstract = 0x00000400,
        Strict = 0x00000800,
        Bridge = 0x00000040,
        Varargs = 0x00000080,
        Synthetic = 0x00001000,
        Annotation = 0x00002000,
        Enum = 0x00004000,
    }
}


