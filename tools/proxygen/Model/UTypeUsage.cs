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
using com.jni4net.proxygen.Services;
using polyglottos.snippets;
using com.jni4net.config;
using polyglottos;
using JType = java.lang.reflect.Type;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Model
{
    public abstract class UTypeUsageBase : GSnippetBase, IGType
    {
        private static int globalID;
        public readonly int ID;
        private readonly GTypeUsageGenerator generator;

        protected UTypeUsageBase(MType root, MType father)
        {
            Root = root;
            Father = father;
            ID = ++globalID;
            ArrayRank = new int[10];
            genericParams = new List<UTypeUsage>();
            generator = root.Repository.Container.Resolve<GTypeUsageGenerator>("GTypeUsageGenerator");
        }

        private bool isLocalName;
        public bool IsLocalName
        {
            get { return isLocalName || Root.IsLocalName; }
            set { isLocalName = value; }
        }

        public MType Root { get; set; }
        public MType Father { get; set; }
        public UTypeUsageBase Pair { get; set; }
        public virtual bool IsGeneric { get; set; }
        public virtual bool IsWildcard { get; set; }
        public bool IsArray
        {
            get
            {
                return ArrayRank[0] > 0;
            }
        }

        public bool IsOut { get; set; }
        public bool IsRef { get; set; }
        public bool IsPointer { get; set; }
        public int[] ArrayRank { get; set; }

        private readonly IList<UTypeUsage> genericParams;
        public IList<UTypeUsage> GenericParams
        {
            get { return genericParams; }
        }

        public bool MakeProxyName { get; set; }
        public bool MakeStaticName { get; set; }
        public bool MakeWildOut { get; set; }
        public bool MakeWildIn { get; set; }

        public virtual void Merge(UTypeUsageBase src, bool pair)
        {
            Array.Copy(src.ArrayRank, ArrayRank, src.ArrayRank.Length);
            IsRef = src.IsRef;
            IsOut = src.IsOut;
            IsPointer = src.IsPointer;
            MakeProxyName = src.MakeProxyName;
            MakeStaticName = src.MakeStaticName;
            MakeWildOut = src.MakeWildOut;
            MakeWildIn = src.MakeWildIn;
            IsWildcard = src.IsWildcard;
            IsGeneric = src.IsGeneric;
            isLocalName = src.isLocalName;
            foreach (var param in src.GenericParams)
            {
                GenericParams.Add(param.DeepClone(pair, Father));
            }
        }

        public virtual string JvmFullName
        {
            get
            {
                return generator.CreateParametrizedName(this, TypeArgs.NameNamespaceArguments, true);
            }
        }

        public virtual string ClrFullName
        {
            get
            {
                return generator.CreateParametrizedName(this, TypeArgs.NameNamespaceArguments, false);
            }
        }

        public virtual string JvmReflectionName
        {
            get
            {
                return generator.CreateParametrizedName(this, TypeArgs.Reflection | TypeArgs.NameNamespace, true);
            }
        }

        public virtual string ClrReflectionName
        {
            get
            {
                return generator.CreateParametrizedName(this, TypeArgs.Reflection | TypeArgs.NameNamespaceArguments, false);
            }
        }

        public virtual string ClrSignature
        {
            get
            {
                return generator.CreateParametrizedName(this, TypeArgs.Signature | TypeArgs.NameNamespace, false);
            }
        }

        public virtual string JvmSignature
        {
            get
            {
                return generator.CreateParametrizedName(this, TypeArgs.Signature|TypeArgs.NameNamespace, true);
            }
        }

        public override string ToString()
        {
            return Root.IsClr
                       ? ClrFullName
                       : JvmFullName;
        }
        
        public override bool Equals(object obj)
        {
            var other = obj as UTypeUsageBase;
            if (other == null)
                return false;
            if (other.Root != Root) return false;
            if (other.IsOut != IsOut) return false;
            if (other.IsRef != IsRef) return false;
            if (other.IsPointer != IsPointer) return false;
            if (other.IsGeneric != IsGeneric) return false;
            if (other.IsWildcard != IsWildcard) return false;

            if (other.MakeProxyName != MakeProxyName) return false;
            if (other.MakeStaticName != MakeStaticName) return false;
            if (other.MakeWildOut != MakeWildOut) return false;
            if (other.MakeWildIn != MakeWildIn) return false;
            
            if (!other.ArrayRank.SequenceEqual(ArrayRank)) return false;

            if (other.GenericParams.Count != GenericParams.Count) return false;
            if (genericParams.Where((t, i) => !t.Equals(other.genericParams[i])).Any())
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return Root.GetHashCode()
                ^ ArrayRank[0].GetHashCode()
                ^ ArrayRank[1].GetHashCode()
                ^ ArrayRank[2].GetHashCode()
                ^ ArrayRank[3].GetHashCode()
                ^ ArrayRank[4].GetHashCode()
                ^ ArrayRank[5].GetHashCode()
                ^ ArrayRank[6].GetHashCode()
                ^ ArrayRank[7].GetHashCode()
                ^ ArrayRank[8].GetHashCode()
                ^ ArrayRank[9].GetHashCode()
                ^ (IsWildcard.GetHashCode() >> 1)
                ^ (IsOut.GetHashCode() >> 2)
                ^ (IsGeneric.GetHashCode() >> 3)
                ^ (IsPointer.GetHashCode() >> 4)
                ^ (IsRef.GetHashCode() >> 5)
                ^ (MakeProxyName.GetHashCode() >> 6)
                ^ (MakeStaticName.GetHashCode() >> 7)
                ^ (MakeWildOut.GetHashCode() >> 8)
                ^ (MakeWildIn.GetHashCode() >> 9)
                ;
        }
    }

    public class UTypeUsage : UTypeUsageBase
    {
        public UTypeUsage(MType root, MType father)
            : base(root, father)
        {
        }

        //method parameter
        public ParameterRegistration ParameterRegistration { get; set; }
        public string MethodParameterName { get; set; }

        //interface declaration
        public bool IsClrSkip { get; set; }
        public bool IsJvmSkip { get; set; }
        public ExtendsRegistration Registration { get; set; }

        public bool IsParameter { get; set; }
        public bool IsReturn { get; set; }

        public override void Merge(UTypeUsageBase src, bool pair)
        {
            base.Merge(src, pair);

            var s = src as UTypeUsage;
            if (s != null)
            {
                MethodParameterName = s.MethodParameterName;
                ParameterRegistration = s.ParameterRegistration;
                IsClrSkip = s.IsClrSkip;
                IsJvmSkip = s.IsJvmSkip;
                Registration = s.Registration;
                IsReturn = s.IsReturn;
                IsParameter = s.IsParameter;
            }
        }

        public virtual UTypeUsage DeepClone(bool pair, MType father)
        {
            var clone = new UTypeUsage(Root, father);

            clone.Merge(this, pair);

            if (pair)
            {
                clone.Pair = this;
                Pair = clone;
            }

            return clone;
        }

        public virtual bool IsAssignableFrom(UTypeUsage other)
        {
            if (other == this || other.Equals(this))
            {
                return true;
            }
            if(!Root.IsAssignableFrom(other.Root))
            {
                return false;
            }
            if (other.IsOut != IsOut) return false;
            if (other.IsRef != IsRef) return false;
            if (other.IsPointer != IsPointer) return false;
            if (other.IsGeneric != IsGeneric) return false;
            if (other.IsWildcard != IsWildcard) return false;
            if (!other.ArrayRank.SequenceEqual(ArrayRank)) return false;

            //TODO generic params

            return true;
        }

        public virtual void MarkGenerate(Func<MType, bool> predicate, ProjectRegistration projectRegistration)
        {
            Root.MarkGenerate(predicate, projectRegistration);
        }
    }
}
