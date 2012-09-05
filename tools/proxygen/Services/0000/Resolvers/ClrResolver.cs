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
using System.IO;
using System.Linq;
using IKVM.Reflection;
using com.jni4net.config;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Utils;
using Assembly = IKVM.Reflection.Assembly;
using Directory = System.IO.Directory;
using ResolveEventArgs = IKVM.Reflection.ResolveEventArgs;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services.Resolvers
{
    public class ClrResolver : IClrResolver
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ITypeRepository Repository { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        protected readonly Universe Universe=new Universe();
        protected readonly Dictionary<string, Assembly> LoadedAssemblies = new Dictionary<string, Assembly>();
        protected readonly Dictionary<string, string> AssemblyCanddiates = new Dictionary<string, string>();
        protected readonly Dictionary<string, string> KnownDirectories = new Dictionary<string, string>();
        protected readonly Dictionary<string, Type> KnownClrTypes = new Dictionary<string, Type>();

        public void LoadAssemblies()
        {
            Universe.AssemblyResolve += UniverseAssemblyResolve;

            //TODO load CLR 2.0 by config
            LoadAssemblyFile(typeof(string).Assembly.Location);
            /*
            LoadAssemblyFile(typeof(IJvmProxy).Assembly.Location);
            LoadAssemblyFile(typeof(todo::java_.lang.IClass).Assembly.Location);
            LoadAssemblyFile(typeof(ClrResolver).Assembly.Location);
            foreach (var la in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (!la.FullName.ToLowerInvariant().Contains("dynammic") && !la.FullName.ToLowerInvariant().Contains("dynamic"))
                {
                    RegisterCandidate(la.GetName(),la.Location);
                }
            }
             */

            //TODO load CLR 2.0 by config
            RegisterDirectory(typeof(string).Assembly);
            //TODO ? RegisterDirectory(typeof(IJvmProxy).Assembly);
            //TODO ? RegisterDirectory(typeof(ClrResolver).Assembly);

            foreach (string dir in KnownDirectories.Keys)
            {
                foreach (string dll in Directory.GetFiles(dir, "*.dll"))
                {
                    AssemblyName fan;
                    try
                    {
                        fan = AssemblyName.GetAssemblyName(dll);
                        RegisterCandidate(fan, dll);
                    }
                    catch (Exception)
                    {
                        //Logger.LogVerbose("ClrResolver: can't load " + dll + "\n" + ex.Message);
                    }
                }
            }

            foreach (var projectRegistration in Configurator.Config.project)
            {
                /*if (projectRegistration.assembliesDirectory != null)
                {
                    foreach (var directory in projectRegistration.assembliesDirectory)
                    {
                        string dir = projectRegistration.MakeAbsolutePath(directory.directory);

                        Logger.LogVerbose("ClrResolver: loading " + dir, null);
                        if (!Directory.Exists(dir))
                        {
                            throw new ProxygenException(dir + " does not exist");
                        }
                        RegisterDirectory(dir);
                        var sp = directory.pattern;
                        if (string.IsNullOrEmpty(sp))
                        {
                            sp = "*.dll";
                        }
                        SearchOption so = directory.recurse
                                              ? SearchOption.AllDirectories
                                              : SearchOption.TopDirectoryOnly;
                        foreach (string dll in Directory.GetFiles(dir, sp, so))
                        {
                            try
                            {
                                AssemblyName an = AssemblyName.GetAssemblyName(dll);
                                RegisterCandidate(an, dll);
                            }
                            catch (Exception ex)
                            {
                                Logger.LogVerbose("ClrResolver: Can't load " + dll + "\n" + ex.Message, null);
                            }
                        }
                    }
                }*/
                if (projectRegistration.assembly != null)
                {
                    foreach (config.Assembly assembly in projectRegistration.assembly)
                    {
                        string assemblyFile = assembly.file;
                        if (!string.IsNullOrEmpty(assemblyFile))
                        {
                            assemblyFile = projectRegistration.MakeAbsolutePath(assemblyFile);

                            Logger.LogVerbose("ClrResolver: loading " + assemblyFile, null);
                            try
                            {
                                AssemblyName an = AssemblyName.GetAssemblyName(assemblyFile);
                                RegisterCandidate(an, assemblyFile);
                                RegisterDirectory(Path.GetDirectoryName(assemblyFile));
                                assembly.assemblyName = an.FullName;
                            }
                            catch (Exception ex)
                            {
                                Logger.LogVerbose("ClrResolver: Can't load " + assemblyFile + "\n" + ex.Message, null);
                            }
                        }
                        else if (!string.IsNullOrEmpty(assembly.assemblyName))
                        {
                            Logger.LogVerbose("ClrResolver: loading " + assembly.assemblyName, null);
                            RegisterCandidate(new AssemblyName(assembly.assemblyName), null);
                        }
                        else
                        {
                            throw new ProxygenException(
                                "element assembly must have either assemblyName or file specified");
                        }
                    }
                }
            }
        }

        private void RegisterCandidate(System.Reflection.AssemblyName an, string file)
        {
            string f;
            if (!AssemblyCanddiates.TryGetValue(an.FullName, out f) || (f == null && file != null))
            {
                AssemblyCanddiates[an.FullName] = file;
            }
            if (!AssemblyCanddiates.TryGetValue(an.Name, out f) || (f == null && file != null))
            {
                AssemblyCanddiates[an.Name] = file;
            }
        }

        private void RegisterCandidate(AssemblyName an, string file)
        {
            string f;
            if (!AssemblyCanddiates.TryGetValue(an.FullName, out f) || (f == null && file != null))
            {
                AssemblyCanddiates[an.FullName] = file;
            }
            if (!AssemblyCanddiates.TryGetValue(an.Name, out f) || (f == null && file != null))
            {
                AssemblyCanddiates[an.Name] = file;
            }
        }

        private void RegisterDirectory(System.Reflection.Assembly assembly)
        {
            RegisterDirectory(Path.GetDirectoryName(assembly.Location));
        }

        private void RegisterDirectory(string directory)
        {
            directory = Path.GetFullPath(directory);
            if (Directory.Exists(directory))
            {
                if (!KnownDirectories.ContainsKey(directory))
                {
                    KnownDirectories.Add(directory, null);
                }
            }
        }

        Assembly UniverseAssemblyResolve(object sender, ResolveEventArgs args)
        {
            return AssemblyResolveImpl(args.Name);
        }

        private Assembly LoadAssemblyFile(string fileName)
        {
            fileName = Path.GetFullPath(fileName);
            AssemblyName name = AssemblyName.GetAssemblyName(fileName);

            Assembly assembly;
            if (!LoadedAssemblies.TryGetValue(name.FullName, out assembly))
            {
                assembly = Universe.LoadFile(fileName);
                Logger.LogVerbose("ClrResolver: loaded " + assembly.FullName + " from " + Path.GetFullPath(assembly.Location), null);
                LoadedAssemblies.Add(assembly.FullName, assembly);

                foreach (var type in assembly.GetTypes())
                {
                    Type conflict;
                    string lowerName = type.FullName.ToLowerInvariant();
                    if (!KnownClrTypes.TryGetValue(lowerName, out conflict))
                    {
                        KnownClrTypes.Add(lowerName, type);
                    }
                    else
                    {
                        Logger.LogMessage("ClrResolver: conflicting name for "
                                          + type.AssemblyQualifiedName + " and " + conflict.AssemblyQualifiedName, null);
                    }
                }
            }
            return assembly;
        }

        protected Type GetType(string fullName)
        {
            Type res;
            KnownClrTypes.TryGetValue(fullName.ToLowerInvariant(), out res);
            return res;
        }

        Assembly AssemblyResolveImpl(string refname)
        {
            var name = new AssemblyName(refname);
            string file;
            if (AssemblyCanddiates.TryGetValue(name.FullName, out file) && file!=null)
            {
                try
                {
                    return LoadAssemblyFile(file);
                }
                catch(Exception ex)
                {
                    throw new ProxygenException("ClrResolver can't load assembly " + Path.GetFullPath(file), ex);
                }
            }
            if (AssemblyCanddiates.TryGetValue(name.Name, out file) && file != null)
            {
                try
                {
                    return LoadAssemblyFile(file);
                }
                catch (Exception ex)
                {
                    throw new ProxygenException("ClrResolver can't load assembly " + Path.GetFullPath(file), ex);
                }
            }

            return null;
        }

        public void LoadTypes()
        {
            foreach (var projectRegistration in Configurator.Config.project)
            {
                if (projectRegistration.assembly != null)
                {
                    foreach (config.Assembly ar in projectRegistration.assembly)
                    {
                        Assembly assembly = null;
                        if (ar.clrType != null)
                        {
                            foreach (TypeRegistration tr in ar.clrType)
                            {
                                tr.Parent = projectRegistration;
                                Logger.LogVerbose("ClrResolver: loading " + tr.name, null);
                                if (assembly == null)
                                {
                                    assembly = LoadAssembly(ar, projectRegistration.BaseDirectory);
                                }
                                LoadRegistration(assembly, tr);
                            }
                        }
                        if (ar.generate)
                        {
                            if (assembly == null)
                            {
                                assembly = LoadAssembly(ar, projectRegistration.BaseDirectory);
                            }

                            var types = EnumerateAssemblyTypes(assembly);
                            foreach (var type in types)
                            {
                                if (type.IsPublic)
                                {
                                    Logger.LogVerbose("ClrResolver: loading " + type.FullName, null);
                                    Register(type, new TypeRegistration(type.FullName, projectRegistration, true), null);
                                }
                            }
                        }
                    }
                }
                if (projectRegistration.clrClass != null)
                {
                    foreach (var tr in projectRegistration.clrClass)
                    {
                        LoadRegistration(null, tr);
                    }
                }
            }
        }

        protected virtual IEnumerable<Type> EnumerateAssemblyTypes(Assembly assembly)
        {
            return assembly.GetTypes().Where(CheckSupportedType);
        }

        private Assembly LoadAssembly(config.Assembly ar, string baseDirectory)
        {
            Assembly assembly;
            string assemblyName = ar.assemblyName;
            if (!string.IsNullOrEmpty(assemblyName))
            {
                if (!LoadedAssemblies.TryGetValue(assemblyName, out assembly))
                {
                    assembly = UniverseAssemblyResolve(null, new ResolveEventArgs(assemblyName));
                }
            }
            else
            {
                assembly = LoadAssemblyFile(PathUtils.MakeAbsolutePath(baseDirectory, ar.file));
            }
            return assembly;
        }

        private void LoadRegistration(Assembly assembly, TypeRegistration tr)
        {
            var name = tr.name;
            if (tr.name.Contains("<"))
            {
                throw new ProxygenException("ClrResolver can't generate from parametrized generic types " + name);
            }
            Type type=null;
            if (assembly != null)
            {
                type = assembly.GetType(name, false);
            }
            if (type==null)
            {
                type = LoadType(name, true);
            }
            if (type == null)
            {
                throw new ProxygenException("ClrResolver can't load " + name);
            }

            Register(type, tr, null);
        }

        public virtual MType Register(Type clr, TypeRegistration tr, MType father)
        {
            if (clr.IsGenericType)
            {
                throw new ProxygenException("ClrResolver generic types are not supported in this version. " + clr.FullName);
            }
            var model = MType.Create(Repository, clr, null, tr, father);
            if (!model.IsSideLocked)
            {
                model.IsClr = true;
                model.IsInterface = clr.IsInterface;
                model.IsAbstract = clr.IsAbstract;
                model.IsSealed = clr.IsSealed;
            }
            if (!model.IsGenerate && !model.IsExcluded && tr != null && tr.generate && !tr.exclude)
            {
                Repository.GenerateType(model);
            }
            return model;
        }

        public MType Register(System.Type clr, TypeRegistration tr, MType father)
        {
            return Register(Universe.GetType(clr.AssemblyQualifiedName), tr, father);
        }

        public virtual Type LoadType(string fullName, bool reportError)
        {
            //TODO case insensitive search!
            Type res = GetType(fullName);
            if (res != null)
            {
                return res;
            }

            if (reportError)
            {
                Logger.LogMessage("ClrResolver: can't load " + fullName, null);  
            }
            return null;
        }

        public virtual UTypeUsage CreateUsage(ParameterInfo clr, MType father)
        {
            var typeUsage = CreateUsage(clr.ParameterType, father);
            typeUsage.MethodParameterName = clr.Name;
            if (clr.ParameterType.IsByRef)
            {
                if (clr.IsOut)
                {
                    typeUsage.IsRef = false;
                    typeUsage.IsOut = true;
                }
            }
            return typeUsage;
        }

        public virtual UTypeUsage CreateUsage(Type clr, MType father)
        {
            MType model = Register(FindPlainType(clr), null, father);

            var typeUsage = new UTypeUsage(model, father);

            if (clr.IsByRef)
            {
                typeUsage.IsRef = true;
                clr = clr.GetElementType();
            }
            if (clr.IsPointer)
            {
                typeUsage.IsPointer = true;
                clr = clr.GetElementType();
            }
            int a = 0;
            while (clr.IsArray)
            {
                typeUsage.ArrayRank[a] = clr.GetArrayRank();
                clr = clr.GetElementType();
                a++;
            }
            return typeUsage;
        }

        public virtual Type FindPlainType(Type clr)
        {
            while (clr.IsArray || clr.IsPointer || clr.IsByRef)
            {
                clr = clr.GetElementType();
            }
            if (clr.IsGenericParameter)
            {
                clr = KnownTypes.SystemObject.ClrReflection;
            }
            while (clr.IsGenericType)
            {
                clr = clr.BaseType;
                if (clr == null)
                {
                    // from generic interface
                    clr = KnownTypes.SystemObject.ClrReflection;
                }
            }
            return clr;
        }

        public virtual bool CheckSupportedType(Type clr)
        {
            if (!clr.IsPublic && !clr.IsNestedPublic)
            {
                return false;
            }
            if (clr.IsInterface && clr.Name.StartsWith("_"))
            {
                return false;
            }
            if (clr.IsGenericType)
            {
                Logger.LogVerbose("Skipped generic interface " +
                                  (clr.IsGenericTypeDefinition
                                       ? clr.FullName
                                       : clr.GetGenericTypeDefinition().FullName), null);
                return false;
            }
            return true;
        }
    }
}
