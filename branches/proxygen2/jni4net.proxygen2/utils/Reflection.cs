using System;
using System.Reflection;

namespace net.sf.jni4net.proxygen
{
    public static class Reflection
    {
        public static bool IsOKType(this Type type)
        {
            return (type.IsPublic || type.IsNestedPublic) 
                && !type.IsPointer 
                && !type.IsGenericTypeDefinition
                && type.HasAttribute("net.sf.jni4net.attributes.JavaProxyAttribute")==null
                && type.HasAttribute("net.sf.jni4net.attributes.ClrWrapperAttribute") == null
                //TODO && type.HasAttribute("net.sf.jni4net.attributes.StaticAttribute") == null
                ;
        }

        public static string GetNamespce(string reflectionName)
        {
            int p = reflectionName.IndexOf('.');
            string namespce = null;
            if (p != -1)
            {
                namespce = reflectionName.Substring(0, p);
            }
            return namespce;
        }

        public static string GetEnclosing(string reflectionName, char encl)
        {
            int p = reflectionName.LastIndexOf('.');
            int e = reflectionName.LastIndexOf(encl);
            string enclosing = null;
            if (p != -1 && e!=-1)
            {
                enclosing = reflectionName.Substring(p + 1, e == p
                                                                ? reflectionName.Length - p - 1
                                                                : e - p - 1).Replace(encl, '.');
            }
            return enclosing;
        }

        public static object HasAttribute(this Type type, string attribute)
        {
            object[] objects = type.GetCustomAttributes(false);
            foreach (object attr in objects)
            {
                if (attr.GetType().FullName == attribute)
                {
                    return attr;
                }
            }
            return null;
        }

        public static object HasAttribute(this MethodBase method, string attribute)
        {
            object[] objects = method.GetCustomAttributes(false);
            foreach (object attr in objects)
            {
                if (attr.GetType().FullName == attribute)
                {
                    return attr;
                }
            }
            return null;
        }
    }
}
