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
using com.jni4net.config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Services;
using com.jni4net.proxygen.Utils;
using java.lang;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Model
{
    public class MType
    {
        private static int globalID=10000;
        public readonly int ID;

        internal bool InProgress;
        private bool isClr;
        public bool IsSideLocked { get; set; }
        private MType substitution;
        protected internal ITypeRepository Repository;
        public NTypeName JvmName { get; set; }
        public NTypeName ClrName { get; set; }

        public ProxyGenPass Pass { get; set; }
        public bool IsGenerate { get; set; }
        public bool IsProcess { get; set; }
        public bool IsExcluded
        {
            get { return TypeRegistration.exclude; }
        }

        public TypeRegistration TypeRegistration { get; set; }
        public ProjectRegistration ProjectRegistration { get { return TypeRegistration.Parent; }}

        public bool IsInterface { get; set; }
        public bool IsVerbose { get; set; }
        public bool IsPrimitive { get; set; }
        public bool IsVoid { get; set; }
        public bool IsPrimitiveLike { get; set; }
        public bool IsLocalName { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsSealed { get; set; }
        public bool IsRoot { get; set; }
        public bool IsNested { get; set; }

        //java.lang.AbstractStringBuilder
        public bool IsProtected { get; set; }

        public virtual bool IsGeneric { get { return false; } }
        public int WildcardCounter { get; set; }
        public MType Father { get; set; }

        public Queue<IModelHandler> Handlers { get; set; }

        public bool IsClr
        {
            get { return isClr; }
            set
            {
                if (!IsSideLocked)
                {
                    isClr = value;
                }
            }
        }

        public bool IsJvm
        {
            get { return !IsClr; }
            set { IsClr = !value; }
        }

        public virtual bool IsKnown
        {
            get
            {
                return
                    (ClrReflection != null && JvmReflection != null)
                    || Substitution != null
                    || IsRoot
                    || IsGenerate
                    ;
            }
        }

        public virtual bool IsMapped
        {
            get
            {
                return
                    (ClrReflection != null && JvmReflection != null)
                    || IsRoot
                    || IsGenerate
                    || IsPrimitive
                    || IsPrimitiveLike
                    ;
            }
        }

        public Type ClrReflection { get; set; }
        public Class JvmReflection { get; set; }

        public string JvmFullName
        {
            get
            {
                var plain = new UTypeUsage(this, this) { IsGeneric = IsGeneric };
                return plain.JvmFullName;
            }
        }

        public string ClrFullName
        {
            get
            {
                var plain = new UTypeUsage(this, this) { IsGeneric = IsGeneric };
                return plain.ClrFullName;
            }
        }

        public string ClrLocalName
        {
            get { return ClrName.LocalName; }
        }

        public string JvmLocalName
        {
            get { return JvmName.LocalName; }
        }

        public string JvmNamespace
        {
            get { return JvmName.Namespace; }
        }

        public string ClrNamespace
        {
            get { return ClrName.Namespace; }
        }
        
        public string JvmReflectionName
        {
            get
            {
                var plain = new UTypeUsage(this, this);
                return plain.JvmReflectionName;
            }
        }

        public string ClrReflectionName
        {
            get
            {
                var plain = new UTypeUsage(this, this);
                return plain.ClrReflectionName;
            }
        }


        public MType Substitution
        {
            get { return substitution; }
            set
            {
                LockSide();
                if (value != null && value.Substitution != null && value.IsClr==IsClr && !value.IsKnown)
                {
                    throw new InvalidOperationException();
                }
                substitution = value;
            }
        }

        public MTypeView Exploration { get; set; }
        public MTypeView ClrGeneration { get; set; }
        public MTypeView JvmGeneration { get; set; }
        public MTypeView ClrGenerationProxy { get; set; }
        public MTypeView JvmGenerationProxy { get; set; }
        public MTypeView ClrGenerationStatic { get; set; }
        public MTypeView JvmGenerationStatic { get; set; }

        public MTypeView TargetGeneration
        {
            get
            {
                return IsClr
                           ? JvmGeneration
                           : ClrGeneration;
            }
        }
        public MTypeView TargetGenerationProxy
        {
            get
            {
                return IsClr
                           ? JvmGenerationProxy
                           : ClrGenerationProxy;
            }
        }
        public MTypeTargets Targets { get; set; }

        protected MType(ITypeRepository repository, MType father)
        {
            Repository = repository;
            Father = father;
            ID = ++globalID;
        }
        
        public static MType Create(ITypeRepository repository, Type clr, Class jvm, TypeRegistration typeRegistration, MType father)
        {
            var res = (repository.GetModel<MType>(clr) 
                ?? repository.GetModel<MType>(jvm))
                ?? new MType(repository, father) { ClrReflection = clr, JvmReflection = jvm, IsJvm = jvm != null, IsClr = clr != null };
            res.Merge(clr, jvm, typeRegistration);
            if (clr != null && res.JvmReflection == null)
            {
                res.IsClr = true;
            }
            if (jvm != null && res.ClrReflection==null)
            {
                res.IsJvm = true;
            }
            res.Register();
            return res;
        }

        public virtual void Merge(MType src)
        {
            Merge(src.ClrReflection, src.JvmReflection, src.TypeRegistration);
            if (!IsSideLocked)
            {
                IsClr = src.IsClr;
                IsInterface |= src.IsInterface;
                IsAbstract |= src.IsAbstract;
                IsNested |= src.IsNested;
                IsPrimitive |= src.IsPrimitive;
                IsLocalName |= src.IsLocalName;
            }
            IsGenerate |= src.IsGenerate;
        }

        protected virtual void Merge(Type clr, Class jvm, TypeRegistration typeRegistration)
        {
            if (ClrReflection == null && clr!=null)
            {
                ClrReflection = clr;
                if (!IsSideLocked)
                {
                    IsInterface = ClrReflection.IsInterface;
                    IsAbstract = ClrReflection.IsAbstract;
                    IsNested = ClrReflection.IsNested;
                    IsPrimitive = ClrReflection.IsPrimitive;
                }
            }
            if (JvmReflection == null && jvm!=null)
            {
                JvmReflection = jvm;
                if (!IsSideLocked)
                {
                    IsPrimitive = JvmReflection.isPrimitive();
                    IsInterface = JvmReflection.isInterface();
                    IsAbstract = JvmReflection.IsAbstract();
                    IsNested = JvmReflection.IsNested();
                    //IsLocalName = IsPrimitive;
                }
            }
            if (TypeRegistration != null && !TypeRegistration.IsSyntetic && typeRegistration != null && !typeRegistration.IsSyntetic)
            {
                Repository.Logger.LogMessage("Duplicate configuration for " + typeRegistration.name, this);
            }
            if (typeRegistration != null && (TypeRegistration == null || TypeRegistration.IsSyntetic || TypeRegistration.Parent == Explorer.unknownProject || TypeRegistration.Parent == Explorer.knownProject))
            {
                TypeRegistration = typeRegistration;
            }
            BuildNames();
            if (TypeRegistration == null)
            {
                TypeRegistration = new TypeRegistration (ClrFullName, Explorer.unknownProject, false);
            }
        }

        protected virtual void BuildNames()
        {
            if (IsClr && ClrName == null && ClrReflection != null)
            {
                ClrName = BuildClrName(this, ClrReflection);
            }
            if (IsJvm && JvmName == null && JvmReflection != null)
            {
                JvmName = BuildJvmName(this, JvmReflection);
            }
            if (ClrName == null && JvmName != null)
            {
                ClrName = new NTypeName(JvmName);
                NTypeName.HackUpperCase(ClrName);
            }
            if (JvmName == null && ClrName != null)
            {
                JvmName = new NTypeName(ClrName);
                var n = JvmName.Namespace.ToLowerInvariant();
                if (n.StartsWith("java."))
                {
                    n = n.Replace("java.", "java_.");
                }
                JvmName.Namespace = n;
            }
        }

        protected virtual NTypeName BuildJvmName(MType root, Class src)
        {
            var res = new NTypeName(root);
            if (src.IsNested())
            {
                NTypeName enclosing;
                if(root!=null && root.Exploration != null && root.Exploration.EnclosingType != null)
                {
                    enclosing = root.Exploration.EnclosingType.JvmName;
                }
                else
                {
                    //TODO disconnected fake
                    enclosing = BuildJvmName(null, src.getDeclaringClass());
                }

                //topmost first
                foreach (var et in enclosing.EnclosingTypes)
                {
                    res.EnclosingTypes.Add(et);
                }
                res.EnclosingTypes.Add(enclosing);

                var ename = src.GetShortName();
                int es = ename.LastIndexOf('$');
                res.LocalName = ename.Substring(es + 1, ename.Length - es - 1);
            }
            else
            {
                res.Namespace = src.GetPackageName();
                res.LocalName = src.GetShortName();
            }
            return res;
        }


        protected virtual NTypeName BuildClrName(MType root, Type src)
        {
            var res = new NTypeName(root);
            res.LocalName = src.Name;
            if (src.IsNested)
            {
                NTypeName enclosing;
                if (root != null && root.Exploration != null && root.Exploration.EnclosingType != null)
                {
                    enclosing = root.Exploration.EnclosingType.ClrName;
                }
                else
                {
                    //TODO disconnected fake
                    enclosing = BuildClrName(null, src.DeclaringType);
                }

                //topmost first
                foreach (var et in enclosing.EnclosingTypes)
                {
                    res.EnclosingTypes.Add(et);
                }
                res.EnclosingTypes.Add(enclosing);
            }
            else
            {
                res.Namespace = src.Namespace;
            }
            return res;
        }
        
        public void LockSide()
        {
            if (!IsSideLocked)
            {
                if (IsClr && ClrReflection!=null)
                {
                    IsInterface = ClrReflection.IsInterface;
                    IsAbstract = ClrReflection.IsAbstract;
                    IsNested = ClrReflection.IsNested;
                    IsPrimitive = ClrReflection.IsPrimitive;
                    //IsLocalName = IsPrimitive;
                }
                if (IsJvm && JvmReflection != null)
                {
                    IsPrimitive = JvmReflection.isPrimitive();
                    IsInterface = JvmReflection.isInterface();
                    IsAbstract = JvmReflection.IsAbstract();
                    IsNested = JvmReflection.IsNested();
                    //IsLocalName = IsPrimitive;
                }
                IsSideLocked = true;
            }
        }

        public virtual void Register()
        {
            Repository.RegisterType(this);
        }

        public override string ToString()
        {
            string arrow =
                (IsInterface ? "I" : "C") +
                (IsClr ? "Clr" : "Jvm") +
                ToArrow();
            return IsClr
                ? arrow + ClrFullName
                : arrow + JvmFullName;
        }

        public string ToShortString()
        {
            return IsClr
                ? ClrFullName
                : JvmFullName;
        }

        public bool IsNestedIn(MType model)
        {
            //searching foir parent of myself
            MType current = this;
            while (current != null)
            {
                if (model == current)
                {
                    return true;
                }
                if (!current.IsNested)
                {
                    return false;
                }
                current = current.Exploration.EnclosingType;
            }
            return false;
        }


        public string DescriptiveName()
        {
            throw new NotImplementedException();
        }

        private string ToArrow()
        {
            return Substitution != null
                       ? Substitution.IsGenerate
                       ? (IsGenerate ? " ==> " : " -=> ")
                       : (IsGenerate ? " =-> " : " --> ")
                       : IsGenerate
                             ? " => "
                             :" -> ";
        }

        public override bool Equals(object obj)
        {
            var oth = obj as MType;
            if (oth==null)
                return false;

            return IsClr 
                ? Equals(ClrReflection, oth.ClrReflection) 
                : Equals(JvmReflection, oth.JvmReflection);
        }

        public override int GetHashCode()
        {
            return IsClr
                       ? ClrReflection.GetHashCode()
                       : JvmReflection.GetHashCode();
        }


        public virtual bool IsAssignableFrom(MType other)
        {
            if (other == this)
            {
                return true;
            }
            if (!IsInterface && other.IsInterface)
            {
                return false;
            }
            if(other.IsRoot && !IsRoot)
            {
                return false;
            }
            if (this == Repository.KnownTypes.SystemObject)
            {
                return true;
            }
            if (this == Repository.KnownTypes.JavaLangObject)
            {
                return true;
            }
            if (IsClr != other.IsClr && Substitution!=null)
            {
                return Substitution.IsAssignableFrom(other);
            }

            if (other.Exploration.Base != null)
            {
                // TODO type parameters
                if(IsAssignableFrom(other.Exploration.Base.Root))
                {
                    return true;
                }
            }
            return other.Exploration.AllInterfaces.Any(ifc => this.IsAssignableFrom(ifc.Root));
        }

        public virtual void MarkGenerate(Func<MType, bool> predicate, ProjectRegistration projectRegistration)
        {
            if (predicate(this))
            {
                if (TypeRegistration == null || ProjectRegistration == Explorer.unknownProject)
                {
                    TypeRegistration = new TypeRegistration(ClrFullName, projectRegistration,false);
                }
                Repository.GenerateType(this);
            }
            else if (!IsKnown)
            {
                Repository.ExploreType(this);
            }
            
        }
    }
}
