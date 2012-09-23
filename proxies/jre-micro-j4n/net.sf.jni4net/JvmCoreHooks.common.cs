#region Copyright (C) 2012 by Pavel Savara

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

// ReSharper disable CheckNamespace
using System;
using System.Collections.Generic;
using java.io;
using java.lang;
using java.lang.annotation;
using java.net;
using net.sf.jni4net.jni;
using Array = java.lang.reflect.Array;
using Exception = System.Exception;
using Object = java.lang.Object;

namespace net.sf.jni4net.core
{
    partial class JvmCoreHooks
    {
        public void InitJ4N(JNIEnv env, BridgeSetup setup, CallBack initPending)
        {
            using (new LocalFrame(env, 1000))
            {
                PreInitJ4N(env);
                Registry.javaLangObject = Registry.InitJvmProxy(typeof(Object), env);
                Registry.javaLangObject.JVMProxyFactory = java.lang.Object.j4n_ProxyFactory;
                Registry.javaLangClass = Registry.InitJvmProxy(typeof(Class), env);
                Registry.javaLangClass.JVMProxyFactory = Class.j4n_ProxyFactoryIdentity;
                var classClass = (IClass) Class.j4n_ProxyFactoryIdentity(env, env.FindClass("java.lang.Class"), new JvmInstanceInfo(null, Registry.javaLangClass));
                Registry.javaLangClass.JVMApi = classClass;
                Registry.javaLangThrowable = Registry.InitJvmProxy(typeof(Throwable), env);
                Registry.javaLangString = Registry.InitJvmProxy(typeof(java.lang.String), env);
                if (Registry.javaLangObject.MemberIds[1].Name != "equals" ||
                    Registry.javaLangObject.MemberIds[3].Name != "hashCode" ||
                    Registry.javaLangObject.MemberIds[6].Name != "toString")
                {
                    throw new InvalidProgramException();
                }

                initPending(setup);
                Class.UpgradeIdentity();
                /*foreach (var classPath in setup.ClassPathList)
                {
                    Logger.LogInfo("Adding to classPath " + classPath);
                    AddURL(J4NBridge.currentSetup.DefaultClassLoader, classPath);
                }*/

                Registry.javaLangBoolean = Registry.InitJvmProxy(typeof(java.lang.Boolean), env);
                Registry.javaLangByte = Registry.InitJvmProxy(typeof(java.lang.Byte), env);
                Registry.javaLangCharacter = Registry.InitJvmProxy(typeof(Character), env);
                Registry.javaLangShort = Registry.InitJvmProxy(typeof(Short), env);
                Registry.javaLangInteger = Registry.InitJvmProxy(typeof(Integer), env);
                Registry.javaLangLong = Registry.InitJvmProxy(typeof(Long), env);
                Registry.javaLangFloat = Registry.InitJvmProxy(typeof(Float), env);
                Registry.javaLangDouble = Registry.InitJvmProxy(typeof(java.lang.Double), env);


                J4NBridge.currentSetup.DefaultClassLoader = ClassLoader.getSystemClassLoader();

                Registry.javaLangBoolean.JVMApiArray = Class.forName("[Z");
                Registry.javaLangByte.JVMApiArray = Class.forName("[B");
                Registry.javaLangCharacter.JVMApiArray = Class.forName("[C");
                Registry.javaLangShort.JVMApiArray = Class.forName("[S");
                Registry.javaLangInteger.JVMApiArray = Class.forName("[I");
                Registry.javaLangLong.JVMApiArray = Class.forName("[J");
                Registry.javaLangFloat.JVMApiArray = Class.forName("[F");
                Registry.javaLangDouble.JVMApiArray = Class.forName("[D");
                Registry.javaLangString.JVMApiArray = ((IJvmProxy)Array.newInstance((Class)Registry.javaLangString.JVMApi, 0)).getClass();

                Registry.javaLangComparable = Registry.InitJvmProxy(typeof(Comparable), env);

                PostInitJ4N(env);
            }
        }

        public void UnloadJ4N()
        {
            URLClassLoader.UnloadJ4N();
            Class.ResetIdentity();
        }

        public void AddURL(IClassLoader urlClassLoader, string url)
        {
            URLClassLoader.InitJ4N();
            if(urlClassLoader==null)
            {
                urlClassLoader = ClassLoader.getSystemClassLoader();
            }
            var cl = (URLClassLoader)urlClassLoader;

            /*string us = "file:/" + url.Replace("\\", "/");
            if (!us.ToLowerInvariant().EndsWith(".jar") && !us.EndsWith("/"))
            {
                us += "/";
            }
            var ui = new URI(us);
            URL ur = ui.toURL();
            */


            var file = new File(url);
            file = file.getCanonicalFile();
            if(!file.exists())
            {
                Logger.LogDebug("Can't find " + file);
            }
            URL ur = file.toURL();
            foreach (var urL in cl.getURLs())
            {
                if(ur.Equals(urL))
                {
                    return;
                }
            }
            cl.AddUrl(ur);
        }

        public IList<string> GetURLs(IClassLoader urlClassLoader)
        {
            URLClassLoader.InitJ4N();
            if (urlClassLoader == null)
            {
                urlClassLoader = ClassLoader.getSystemClassLoader();
            }
            var cl = (URLClassLoader)urlClassLoader;
            var res = new List<string>();
            foreach (var urL in cl.getURLs())
            {
                res.Add(urL.toString());
            }
            return res;
        }

        public string GetLocation(IClass clazz)
        {
            var klass = (Class) clazz;
            var location = klass.getResource('/' + klass.getName().Replace('.', '/') + ".class");
            return location.toString();
        }

        public string systemGetProperty(string name)
        {
            return java.lang.System.getProperty(name);
        }

        [ThreadStatic]
        private bool inprogress;

        public IClass LoadAnnotatedProxy(IClass type)
        {
            if (inprogress) return null;
            try
            {
                inprogress = true;
                Annotation[] annotations = ((Class) type).getAnnotations();
                foreach (Annotation annotation in annotations)
                {
                    var annotationType = annotation.annotationType();
                    string name = annotationType.getName();
                    if (name == "net.sf.jni4net.attributes.J4NProxy")
                    {
                        var valueMethod = annotationType.getMethod("value", new Class[] {});
                        var cls = (Class) valueMethod.invoke(annotation, new object[] {});
                        // enforce class load
                        var methods = cls.getMethods();
                        return cls;
                    }
                }
            }
            finally
            {
                inprogress = false;
            }

            return null;
        }

        public IClass ClassForName(string name)
        {
            return Class.forName(name);
        }
    }
}
