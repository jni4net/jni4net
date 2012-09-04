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
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using com.jni4net.config;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.io;
using java.lang;
using java.lang.reflect;
using java.net;
using java.util.zip;
using Microsoft.Practices.Unity;
using net.sf.jni4net;
using net.sf.jni4net.jni;
using Directory = System.IO.Directory;
using Exception = System.Exception;
using File = System.IO.File;
using JType = java.lang.reflect.Type;

namespace com.jni4net.proxygen.Services.Resolvers
{
    public class JvmResolver : IJvmResolver
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ITypeRepository Repository { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        readonly List<KeyValuePair<string, ProjectRegistration>> genJarsInDirs = new List<KeyValuePair<string, ProjectRegistration>>();
        private ClassLoader classLoader;
        readonly List<URL> classPaths = new List<URL>();

        public void LoadJars()
        {
            var bridgeSetup = new BridgeSetup();
            bridgeSetup.BindClrProxies = false;
            bridgeSetup.AllowJVMJoin = true;
            if (Configurator.Debug)
            {
                bridgeSetup.LogLevel = LogLevel.Debug;
            }
            string jruntime = Path.Combine(typeof (Proxygen).Assembly.Location, @"..\runtime\jni4net.jar");
            if(File.Exists(jruntime))
            {
                bridgeSetup.AddClassPath(jruntime);
            }
            string clrCore = Path.Combine(typeof(Proxygen).Assembly.Location, @"..\runtime\mscorlib-micro-j4n.jar");
            if (File.Exists(clrCore))
            {
                bridgeSetup.AddClassPath(clrCore);
            }

            J4NBridge.CreateJVM(bridgeSetup);
            Logger.LogVerbose("JAVA_HOME " + J4NBridge.Setup.JavaHome, null);

            foreach (var projectRegistration in Configurator.Config.project)
            {
                // TODO
                /*if (projectRegistration.jarsDirectory != null)
                {
                    foreach (var directory in projectRegistration.jarsDirectory)
                    {
                        string dir = PathUtils.MakeAbsoluteBase(directory.directory, projectRegistration.BaseDirectory);
                        if (!Directory.Exists(dir))
                        {
                            throw new ProxygenException(dir + " does not exist");
                        }
                        var sp = directory.pattern;
                        if (string.IsNullOrEmpty(sp))
                        {
                            sp = "*.jar";
                        }
                        SearchOption so = directory.recurse
                                              ? SearchOption.AllDirectories
                                              : SearchOption.TopDirectoryOnly;
                        foreach (string jar in Directory.GetFiles(dir, sp, so))
                        {
                            if (directory.generate)
                            {
                                genJarsInDirs.Add(new KeyValuePair<string, ProjectRegistration>(jar,projectRegistration));
                            }
                            Logger.LogVerbose("Adding to ClassPath " + jar, null);
                            J4NBridge.AddClassPath(jar);
                        }
                    }
                }*/


                if (projectRegistration.classPath != null)
                {
                    foreach (ClassPath classPath in projectRegistration.classPath)
                    {
                        string jar = classPath.jarFile;
                        string cpDir = classPath.classPathDirectory;
                        if (!string.IsNullOrEmpty(jar))
                        {
                            jar = projectRegistration.MakeAbsolutePath(jar);
                            if (File.Exists(jar))
                            {
                                Logger.LogVerbose("Adding to ClassPath " + jar, null);
                                J4NBridge.AddClassPath(jar);
                            }
                            else
                            {
                                Logger.LogMessage("JvmResolver: can't find jarFile " + jar, null);
                            }
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(cpDir))
                            {
                                cpDir = projectRegistration.MakeAbsolutePath(cpDir);

                                if (Directory.Exists(cpDir))
                                {
                                    if (!cpDir.EndsWith("\\"))
                                    {
                                        cpDir = cpDir + "\\";
                                    }
                                    Logger.LogVerbose("Adding to ClassPath " + cpDir, null);
                                    J4NBridge.AddClassPath(cpDir);
                                }
                                else
                                {
                                    Logger.LogMessage("JvmResolver: can't find classPathDirectory " + cpDir, null);
                                }
                            }
                            else
                            {
                                throw new ProxygenException("JvmResolver: element assembly must have either classPathDirectory or jarFile specified");
                            }
                        }
                    }
                }
            }
        }

        public void LoadClasses()
        {
            List<string> classes;
            foreach (var jar in genJarsInDirs)
            {
                classes = EnumerateClassesInJar(jar.Key);
                foreach (var cls in classes)
                {
                    LoadRegistration(cls, new TypeRegistration(cls,jar.Value,true), false);
                }
            }

            foreach (var projectRegistration in Configurator.Config.project)
            {
                if (projectRegistration.classPath != null)
                {
                    foreach (ClassPath ar in projectRegistration.classPath)
                    {
                        if (ar.javaClass != null || ar.generate)
                        {
                            string jarFile = ar.jarFile;
                            string cpDir = ar.classPathDirectory;
                            if (!string.IsNullOrEmpty(jarFile))
                            {
                                jarFile = projectRegistration.MakeAbsolutePath(jarFile);
                                if (File.Exists(jarFile))
                                {
                                    classes = EnumerateClassesInJar(jarFile);
                                }
                                else
                                {
                                    Logger.LogMessage("Can't find jar " + jarFile, null);
                                    continue;
                                }
                            }
                            else
                            {
                                cpDir = projectRegistration.MakeAbsolutePath(cpDir);
                                if (Directory.Exists(cpDir))
                                {
                                    classes = EnumerateClassesInDir(cpDir);
                                }
                                else
                                {
                                    Logger.LogMessage("Can't find directory " + cpDir, null);
                                    continue;
                                }
                            }
                            if (ar.generate)
                            {
                                foreach (var cls in classes)
                                {
                                    LoadRegistration(cls, new TypeRegistration(cls,projectRegistration,true), false);
                                }
                            }
                            if (ar.javaClass != null)
                            {
                                foreach (TypeRegistration tr in ar.javaClass)
                                {
                                    tr.Parent = projectRegistration;
                                    if (!tr.name.Contains("*"))
                                    {
                                        LoadRegistration(tr.name, tr, true);
                                    }
                                }

                                foreach (TypeRegistration tr in ar.javaClass)
                                {
                                    tr.Parent = projectRegistration;
                                    if (tr.name.Contains("*"))
                                    {
                                        string exp = tr.name.Replace(".", "\\.");
                                        var r = new Regex(exp.StartsWith("*") ? exp : "^" + exp);
                                        foreach (var cls in classes)
                                        {
                                            if (r.IsMatch(cls))
                                            {
                                                LoadRegistration(cls, tr, false);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (projectRegistration.jvmClass != null)
                {
                    foreach (TypeRegistration tr in projectRegistration.jvmClass)
                    {
                        tr.Parent = projectRegistration;
                        if (tr.name.Contains("*"))
                        {
                            Logger.LogMessage("JvmResolver: wildcard not supported without classPath: " + tr.name, null);
                        }
                        else
                        {
                            LoadRegistration(tr.name, tr, true);
                        }
                    }
                }
            }
        }

        private List<string> EnumerateClassesInJar(string jar)
        {
            var classes = new List<string>();
            if (!File.Exists(jar))
            {
                Logger.LogMessage("JvmResolver: file doesn't exist: " + Path.GetFullPath(jar),null);
                return null;
            }

            try
            {
                var zis = new ZipInputStream(new FileInputStream(jar));
                ZipEntry entry = zis.getNextEntry();
                while (entry != null)
                {
                    string ename = entry.getName();
                    int dcl = ename.LastIndexOf(".class");
                    if (dcl != -1)
                    {
                        string urlName = ename.Substring(0, dcl).Replace('/', '.');
                        classes.Add(urlName);
                    }
                    entry = zis.getNextEntry();
                }
            }
            catch (Exception ex)
            {
                Logger.LogMessage("JvmResolver: Can't open " + jar + "\n" + ex,null);
            }
            return classes;
        }

        private List<string> EnumerateClassesInDir(string dir)
        {
            var classes=new List<string>();
            string[] files = Directory.GetFiles(dir, "*.class", SearchOption.AllDirectories);
            int prefix = dir.Length;
            foreach (var ename in files)
            {
                int dcl = ename.LastIndexOf(".class");
                if (dcl != -1)
                {
                    string urlName = ename.Substring(prefix+1, dcl-prefix-1).Replace('\\', '.');
                    classes.Add(urlName);
                }
            }
            return classes;
        }

        private void LoadRegistration(string name, TypeRegistration tr, bool thrw)
        {
            /* TODO if (?? name.Contains("<"))
            {
                throw new ProxygenException("JvmResolver: Can't generate from parametrized generic types" + name);
            }*/

            var clazz = LoadClass(name, true);
            if (clazz == null)
            {
                if (thrw)
                {
                    throw new ProxygenException("JvmResolver: can't load " + name);
                }
                Logger.LogMessage("JvmResolver: can't load " + name,null);
                return;
            }
            if (!clazz.IsPublic() && thrw)
            {
                Logger.LogVerbose("JvmResolver: skip private class " + name,null);
                return;
            }

            Register(clazz, tr, null);
        }

        public virtual Class LoadClass(string codeFullName, bool reportError)
        {
            if (classLoader==null)
            {
                classLoader = (ClassLoader)J4NBridge.Setup.DefaultClassLoader;
            }

            Class clazz = null;
            try
            {
                clazz = classLoader.loadClass(codeFullName);
            }
            catch (Exception ex)
            {
                string name = codeFullName.Replace('.', '/');
                if (!name.Contains("."))
                {
                    try
                    {
                        clazz = ReflectionUtils.getPrimitiveClass(name);
                    }
                    catch (Exception)
                    {
                        clazz = null;
                    }
                }
                if (clazz == null && reportError)
                {
                    Logger.LogVerbose("JvmResolver: can't load " + codeFullName + ": " + ex.GetType() + " " + ex.Message, null);
                }
            }

            return clazz;
        }

        public virtual MType Register(JType jvm, TypeRegistration tr, MType father)
        {
            var cls = jvm as Class;
            var model = MType.Create(Repository, null, cls, tr,father);
            if (!model.IsSideLocked)
            {
                model.IsJvm = true;
                model.IsAbstract = cls.IsAbstract();
                model.IsSealed = cls.IsFinal();
                model.IsInterface = cls.isInterface();
                model.IsProtected = !cls.IsPublic();
            }
            if (!model.IsGenerate && !model.IsExcluded && tr != null && tr.generate && !tr.exclude && cls.IsPublic())
            {
                Repository.GenerateType(model);
            }

            return model;
        }

        public virtual UTypeUsage CreateDeclaration(JType jvm, MType father)
        {
            return CreateUsage(jvm, father);
        }
        
        public virtual UTypeUsage CreateUsage(JType jvm, MType father)
        {
            var cls = (Class) jvm;
            if (cls.isArray())
            {
                var res = CreateUsage(cls.getComponentType(), father);
                for (int i = 0; i < res.ArrayRank.Length; i++)
                {
                    if(res.ArrayRank[i]==0)
                    {
                        res.ArrayRank[i]=1;
                        break;
                    }
                }
                return res;
            }
            MType model = Register(cls, null, father);
            var typeUsage = new UTypeUsage(model, father);
            return typeUsage;
        }

        public UTypeUsage CreateUsage(JType jvm, string paramName, MType father)
        {
            UTypeUsage res = CreateUsage(jvm, father);
            res.MethodParameterName = paramName;
            return res;
        }

        public virtual Class FindPlainType(JType jvm)
        {
            return (Class)jvm;
        }

        public virtual bool IsAssignableFrom(JType a, JType b)
        {
            if (a == null)
                return false;
            if (b == null)
                return false;
            return ((Class)a).isAssignableFrom((Class)b);
        }

        public virtual bool IsOverridden(Method higher, Method lower)
        {
            if (!higher.getName().Equals(lower.getName()))
            {
                return false;
            }
            if (!IsAssignableFrom(higher.getReturnType(), lower.getReturnType()))
            {
                return false;
            }
            JType[] f = higher.getParameterTypes();
            JType[] s = lower.getParameterTypes();
            if (s.Length != f.Length)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!f[i].Equals(s[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
