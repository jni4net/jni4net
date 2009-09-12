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
using System.Reflection;
using System.CodeDom;
using System.Collections.Generic;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.config;

namespace net.sf.jni4net.proxygen.model
{
    internal class GType
    {
        private readonly Dictionary<string, GMethod> _allMethods = new Dictionary<string, GMethod>();
        private readonly List<GMethod> _skippedMethods = new List<GMethod>();
        private readonly List<GMethod> _methods = new List<GMethod>();
        private readonly List<GMethod> _methodsWithInterfaces = new List<GMethod>();
        private readonly List<GMethod> _constructors = new List<GMethod>();
        private readonly List<GType> _interfaces = new List<GType>();
        private readonly List<GType> _allInterfaces = new List<GType>();

        public bool MergeJavaSource { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsArray { get; set; }
        public bool IsFinal { get; set; }
        public bool IsPrimitive { get; set; }
        public bool IsCLRProxy { get; set; }
        public bool IsJVMProxy { get; set; }
        public bool IsCLRGenerate { get; set; }
        public bool IsJVMGenerate { get; set; }
        public bool IsSkipCLRInterface { get; set; }
        public bool IsSkipJVMInterface { get; set; }
        public bool IsInterface { get; set; }
        public bool IsJVMType { get; set; }
        public bool IsCLRType { get; set; }
        public bool IsJVMRealType { get; set; }
        public bool IsCLRRealType { get; set; }
        public string LowerName { get; set; }
        public string Name { get; set; }
        public string CLRFullName { get; set; }
        public string JVMFullName { get; set; }
        public string CLRNamespace { get; set; }
        public string JVMNamespace { get; set; }
        public string JVMNamespaceExt { get; set; }
        public Type CLRType { get; set; }
        public Class JVMType { get; set; }
        public GType Base { get; set; }
        public GType ArrayElement { get; set; }
        public GType JVMSubst { get; set; }
        public GType CLRSubst { get; set; }
        public bool IsMethodsLoaded { get; set; }
        public bool IsMethodsPreLoaded { get; set; }
        public bool IsLoadJVMMethods { get; set; }
        public bool IsLoadCLRMethods { get; set; }
        public TypeRegistration Registration { get; set; }
        public TypeAttributes Attributes { get; set; }

        public string CLRResolved
        {
            get { return CLRSubst == null ? CLRFullName : CLRSubst.CLRFullName; }
        }

        public string JVMResolved
        {
            get { return JVMSubst == null ? JVMFullName : JVMSubst.JVMFullName; }
        }

        public CodeTypeReference JVMReference
        {
            get { return new CodeTypeReference(JVMResolved); }
        }

        public CodeTypeReference CLRReference
        {
            get { return new CodeTypeReference(CLRResolved, CodeTypeReferenceOptions.GlobalReference); }
        }

        public Dictionary<string, GMethod> AllMethods
        {
            get
            {
                return _allMethods;
            }
        }

        public List<GMethod> SkippedMethods
        {
            get
            {
                return _skippedMethods;
            }
        }

        public List<GMethod> Methods
        {
            get
            {
                return _methods;
            }
        }

        public List<GMethod> MethodsWithInterfaces
        {
            get
            {
                return _methodsWithInterfaces;
            }
        }

        public List<GMethod> Constructors
        {
            get
            {
                return _constructors;
            }
        }

        public List<GType> Interfaces
        {
            get
            {
                return _interfaces;
            }
        }

        public List<GType> AllInterfaces
        {
            get
            {
                return _allInterfaces;
            }
        }

        public override string ToString()
        {
            return LowerName;
        }

        public GType Resolve()
        {
            if (IsJVMGenerate || IsCLRGenerate)
                return this;
            if (IsCLRType && IsJVMType)
                return this;
            if (IsCLRType && JVMSubst!=null)
            {
                return JVMSubst;
            }
            if (IsJVMType && CLRSubst != null)
            {
                return CLRSubst;
            }
            if (IsArray)
            {
                GType subst = ArrayElement.Resolve().MakeArray();
                if (IsCLRType)
                {
                    JVMSubst = subst;
                }
                else
                {
                    CLRSubst = subst;
                }
                return subst;
            }
            if (IsRootType)
            {
                return this;
            }
            if (Base != null)
            {
                GType subst = Base.Resolve();
                if (!subst.IsRootType)
                {
                    if(IsCLRType)
                    {
                        JVMSubst = subst;
                    }
                    else
                    {
                        CLRSubst = subst;
                    }
                    return subst;
                }
            }
            /*
            foreach (GType ifc in Interfaces)
            {
                GType subst = ifc.Resolve();
                if (IsCLRType && ifc.IsJVMType)
                {
                    JVMSubst = subst;
                    return subst;
                }
                if (IsJVMType && ifc.IsCLRType)
                {
                    CLRSubst = subst;
                    return subst;
                }
            }*/
            if (IsCLRType)
            {
                JVMSubst = Repository.systemObject;
                return Repository.systemObject;
            }
            else
            {
                CLRSubst = Repository.javaLangObject;
                return Repository.javaLangObject;
            }
        }

        public bool IsRootType
        {
            get
            {
                return this == Repository.systemObject
                       || this == Repository.systemException
                       || this == Repository.javaLangThrowable
                       || this == Repository.javaLangObject;
            }
        }

        public void UpdateNames()
        {
            foreach (GType ifc in Interfaces)
            {
                foreach (GType inIfc in ifc.AllInterfaces)
                {
                    if (!AllInterfaces.Contains(inIfc))
                    {
                        AllInterfaces.Add(inIfc);
                    }
                }
            }
            if (IsCLRType)
            {
                CLRNamespace = CLRType.Namespace;
                Name = CLRType.Name;
                if (!IsJVMType)
                {
                    JVMNamespace = CLRNamespace.ToLowerInvariant();
                    JVMFullName = JVMNamespace + "." + CLRType.Name;
                }
            }
            if (IsJVMType)
            {
                JVMNamespace = JVMType.PackageName;
                Name = JVMType.ShortName;
                if (!IsCLRType)
                {
                    CLRNamespace = JVMNamespace;
                    CLRFullName = JVMType.FullName;
                }
            }
            JVMNamespaceExt = JVMNamespace;
            if (JVMNamespace.StartsWith("java."))
            {
                JVMNamespaceExt = "java_."+ JVMNamespace.Substring(5);
            }
            /* TODO
            if (IsJVMGenerate)
            {
                if (Base!=null && !Base.IsJVMType && !Base.IsJVMGenerate)
                {
                    Console.WriteLine("you should add " + Base.Name);
                }
                foreach (GType ifc in Interfaces)
                {
                    if (!ifc.IsJVMType && !ifc.IsJVMGenerate)
                    {
                        Console.WriteLine("you should add " + ifc.Name);
                    }
                }
            }

            if (IsCLRGenerate && CLRType!=typeof(IClrProxy))
            {
                if (Base != null && !Base.IsCLRType && !Base.IsCLRGenerate)
                {
                    Console.WriteLine("you should add " + Base.Name);
                }
                foreach (GType ifc in Interfaces)
                {
                    if (!ifc.IsCLRType && !ifc.IsCLRGenerate)
                    {
                        Console.WriteLine("you should add " + ifc.Name);
                    }
                }
            }*/
        }

        public void UpdateMethods()
        {
            foreach (GMethod method in Methods)
            {
                method.UpdateNames();
            }
            foreach (GMethod method in Constructors)
            {
                method.UpdateNames();
            }
        }

        public GType MakeArray()
        {
            if (IsCLRType)
            {
                return Repository.RegisterType(CLRType.MakeArrayType());
            }
            else
            {
                Class arrClass = JNIEnv.ThreadEnv.NewObjectArray(0, JVMType, null).getClass();
                return Repository.RegisterClass(arrClass);
            }
        }
    }
}
