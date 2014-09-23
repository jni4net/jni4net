#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

#if !JNI4NET_MINI
using System;
using java.lang.annotation;
using java.lang.reflect;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

#endif

namespace java.lang
{
    //todo sealed
    public partial class Class
    {
        private long hashCodeCache = long.MinValue;

        public string FullName
        {
            get { return getName(); }
        }

        public string ShortName
        {
            get
            {
                string name = FullName;
                int i = name.LastIndexOf('.');
                if (i == -1)
                {
                    return name;
                }
                return name.Substring(i + 1);
            }
        }

        public string PackageName
        {
            get
            {
                string name = FullName;
                int i = name.LastIndexOf('.');
                if (i == -1)
                {
                    return "";
                }
                return name.Substring(0, i);
            }
        }

        public Class SuperClass
        {
            get { return getSuperclass(); }
        }

#if !JNI4NET_MINI
        public bool IsAnnotationPresent(string search)
        {
            foreach (Annotation annotation in getAnnotations())
            {
                String name = annotation.annotationType().getName();
                if (name == search)
                {
                    return true;
                }
            }
            return false;
        }

        public Method GetMethod(string name, string signature, bool isStatic)
        {
            MethodId methodId = Env.GetMethodID(this, name, signature);
            if (methodId == null)
            {
                return null;
            }
            return Env.ToReflectedMethod(this, methodId, isStatic);
        }

        public Method GetMethodNoThrow(string name, string signature, bool isStatic)
        {
            MethodId methodId = Env.GetMethodIDNoThrow(this, name, signature);
            if (methodId == null)
            {
                return null;
            }
            return Env.ToReflectedMethod(this, methodId, isStatic);
        }
#endif

        public new void Invoke(string method, string signature, params object[] args)
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(this, method, signature, Convertor.ConverArgs(env, args));
        }

        public new TRes Invoke<TRes>(string method, string signature, params object[] args)
        {
            return Env.CallStaticMethod<TRes>(this, method, signature, args);
        }

        public new TRes GetFieldValue<TRes>(string fieldName, string signature)
        {
            return Env.GetStaticField<TRes>(this, fieldName, signature);
        }

        public new void SetFieldValue<T>(string fieldName, string signature, T value)
        {
            Env.SetStaticField(this, fieldName, signature, value);
        }

        public static Class getPrimitiveClass(string name)
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            MethodId id = env.GetStaticMethodID(staticClass, "getPrimitiveClass",
                                                "(Ljava/lang/String;)Ljava/lang/Class;");
            return Convertor.StrongJ2CpClass(env,
                                             env.CallStaticObjectMethodPtr(staticClass, id,
                                                                           Convertor.ParStrongC2JString(env, name)));
        }

        public override bool Equals(object obj)
        {
            var other = obj as Class;
            if (other == null)
                return false;

            if (hashCodeCache != long.MinValue && other.hashCodeCache != long.MinValue &&
                hashCodeCache != other.hashCodeCache)
            {
                return false;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            if (hashCodeCache == long.MinValue)
            {
                hashCodeCache = hashCode();
            }
            return (int) hashCodeCache;
        }

        public static bool operator ==(Class x, Class y)
        {
            if ((object) x == null && (object) y == null)
                return true;
            if ((object) x == null || (object) y == null)
                return false;
            return x.equals(y);
        }

        public static bool operator !=(Class x, Class y)
        {
            if ((object) x == null && (object) y == null)
                return false;
            if ((object) x == null || (object) y == null)
                return true;
            return !x.equals(y);
        }

        internal static Class CreateProxy(JNIEnv env, JniLocalHandle obj)
        {
            var proxy = new Class(env);
            ((IJvmProxy) proxy).Init(env, obj);
            return proxy;
        }
    }
}