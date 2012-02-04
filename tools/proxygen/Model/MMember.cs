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
using IKVM.Reflection;
using com.jni4net.proxygen.Utils;
using polyglottos;
using com.jni4net.config;
using java.lang.reflect;
using StringBuilder = System.Text.StringBuilder;

namespace com.jni4net.proxygen.Model
{
    public class MMember
    {
        private IDictionary<GeneratorTarget, IGMember> targets;
        public MMember(MType owner, string name)
        {
            Owner = owner;
            Name = name;
            Params = new List<UTypeUsage>();
            ImplementsInterfaces = new List<UTypeUsage>();
            ImplementsMember = new List<MMember>();
            IsPublic = true;
            IsOriginal = true;
        }

        public bool IsOriginal { get; set; }
        public bool IsPair
        {
            get { return !IsOriginal; }
            set { IsOriginal = !value; }
        }

        private bool isClrSkip;
        public bool IsClrSkip
        {
            get
            {
                if (IsOriginal && Owner.IsClr && Pair != null)
                {
                    return Pair.IsClrSkip;
                }
                return isClrSkip;
            }
            set
            {
                if (IsOriginal && Owner.IsClr && Pair != null)
                {
                    Pair.IsClrSkip=value;
                }
                isClrSkip = value;
            }
        }

        private bool isJvmSkip;
        public bool IsJvmSkip
        {
            get
            {
                if (IsOriginal && Owner.IsJvm && Pair!=null)
                {
                    return Pair.IsJvmSkip;
                }
                return isJvmSkip;
            }
            set
            {
                if (IsOriginal && Owner.IsJvm && Pair != null)
                {
                    Pair.IsJvmSkip = value;
                }
                isJvmSkip = value;
            }
        }

        public bool IsStatic { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsSealed { get; set; }
        public bool IsPublic { get; set; }
        public bool IsConstructor { get; set; }
        public bool IsProperty { get; set; }
        public bool IsGeneric { get; set; }
        public bool IsField { get; set; }
        public bool IsFinal { get; set; }
        public bool IsMethod { get; set; }
        public bool IsEvent { get; set; }
        public bool IsLooser { get; set; }
        public bool IsObsolete { get; set; }
        public bool IsVoid
        {
            get { return Return == null || Return.Root.IsVoid; }
        }
        public string Name { get; set; }

        public string JvmName
        {
            get
            {
                if (Owner.IsJvm && !IsOriginal && Pair != null)
                {
                    return Pair.Name;
                }
                return Name;
            }
        }

        public string ClrName
        {
            get
            {
                if (Owner.IsClr && !IsOriginal && Pair != null)
                {
                    return Pair.Name;
                }
                return Name;
            }
        }
        
        public MType Owner { get; set; }
        public MProperty Property { get; set; }
        public MemberInfo ClrReflection { get; set; }
        public Member JvmReflection { get; set; }
        public UTypeUsage Return { get; set; }
        public IList<UTypeUsage> Params { get; private set; }
        public IEnumerable<UTypeUsage> ReturnAndParams
        {
            get
            {
                return Return == null
                           ? Params
                           : new List<UTypeUsage>(Params) { Return };
            }
        }
        public IList<UTypeUsage> ImplementsInterfaces { get; private set; }
        public IList<MMember> ImplementsMember { get; private set; }
        public MMember Pair { get; set; }
        public MemberRegistration MemberRegistration { get; set; }
        public UTypeUsage ExplicitInterface { get; set; }

        public string JvmSignature { get; set; }

        public IDictionary<GeneratorTarget, IGMember> Targets
        {
            get
            {
                if(targets==null)
                {
                    targets = new Dictionary<GeneratorTarget, IGMember>();
                }
                return targets;
            }
        }

        public virtual MMember DeepClone(bool pair)
        {
            var clone = new MMember(Owner, Name);
            if (pair)
            {
                clone.Pair = this;
                Pair = clone;
            }
            else
            {
                clone.Pair = Pair;
            }
            clone.IsPair = pair ? !IsPair : IsPair;
            clone.IsStatic = IsStatic;
            clone.IsClrSkip = IsClrSkip;
            clone.IsJvmSkip = IsJvmSkip;
            clone.IsConstructor = IsConstructor;
            clone.IsPublic = IsPublic;
            clone.IsVirtual = IsVirtual;
            clone.IsProperty = IsProperty;
            clone.IsField = IsField;
            clone.IsFinal = IsFinal;
            clone.IsMethod = IsMethod;
            clone.IsEvent = IsEvent;
            clone.IsGeneric = IsGeneric;
            clone.IsLooser = IsLooser;
            if(!pair)
            {
                clone.JvmSignature = JvmSignature;
            }
            clone.JvmReflection = JvmReflection;
            clone.ClrReflection = ClrReflection;
            clone.MemberRegistration = MemberRegistration;
            foreach (var param in Params)
            {
                clone.Params.Add(param.DeepClone(pair, Owner));
            }
            if (Return != null)
            {
                clone.Return = Return.DeepClone(pair, Owner);
            }
            foreach (var ifc in ImplementsInterfaces)
            {
                clone.ImplementsInterfaces.Add(ifc.DeepClone(pair, Owner));
            }
            foreach (var ifcm in ImplementsMember)
            {
                if (ifcm.Pair == null)
                {
                    throw new InvalidProgramException();
                }
                clone.ImplementsMember.Add(ifcm.Pair);
            }
            if(Property!=null)
            {
                if (Property.Get!=null && Property.Set!=null)
                {
                    clone.Property = Property.CustomData as MProperty;
                    if(clone.Property==null)
                    {
                        clone.Property = new MProperty
                                             {
                                                 Name = Property.Name
                                             };

                        Property.CustomData = clone.Property;
                    }
                    else
                    {
                        Property.CustomData = null;
                    }
                }
                else
                {
                    clone.Property = new MProperty
                                         {
                                             Name = Property.Name
                                         };
                }

                if(Property.Get==this)
                {
                    clone.Property.Get = clone;
                }
                else if(Property.Set==this)
                {
                    clone.Property.Set = clone;
                }
            }

            if (ExplicitInterface!=null)
            {
                clone.ExplicitInterface = ExplicitInterface.DeepClone(pair, Owner);
            }

            return clone;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if(IsStatic)
            {
                sb.Append("static ");
            }
            if (Return != null)
            {
                sb.Append(Owner.IsClr ? Return.ClrFullName : Return.JvmFullName);
                sb.Append(' ');
            }
            else
            {
                sb.Append("void ");
            }
            sb.Append(Name);
            if (!IsField)
            {
                sb.Append('(');
                for (int i = 0; i < Params.Count; i++)
                {
                    var param = Params[i];
                    if (i > 0)
                    {
                        sb.Append(", ");
                    }
                    sb.Append(Owner.IsClr ? param.ClrFullName : param.JvmFullName);
                }
                sb.Append(')');
            }
            return sb.ToString();
        }

        public virtual string GetClrSignature(bool useReturn)
        {
            var sb = new StringBuilder();

            sb.Append('(');
            for (int i = 0; i < Params.Count; i++)
            {
                var param = Params[i];
                sb.Append(param.ClrSignature);
            }
            sb.Append(')');
            if (useReturn)
            {
                if (Return != null)
                {
                    sb.Append(Return.ClrSignature);
                }
                else
                {
                    sb.Append('V');
                }
            }

            return sb.ToString();
        }
        
        public virtual string GetJvmSignature(bool useReturn)
        {
            var sb=new StringBuilder();
            if (JvmSignature != null && useReturn)
            {
                return JvmSignature;
            }
            if (JvmReflection != null && useReturn)
            {
                JvmSignature = ReflectionUtils.GetJvmSignature(JvmReflection);
                return JvmSignature;
            }
            if(!Owner.IsJvm && IsOriginal && Pair!=null)
            {
                return Pair.GetJvmSignature(useReturn);
            }


            sb.Append('(');
            for (int i = 0; i < Params.Count; i++)
            {
                var param = Params[i];
                sb.Append(param.JvmSignature);
            }
            sb.Append(')');
            if (useReturn)
            {
                if (Return != null)
                {
                    sb.Append(Return.JvmSignature);
                }
                else
                {
                    sb.Append('V');
                }
            }

            return sb.ToString();
        }
    }

    public class MProperty
    {
        public MemberInfo ClrReflection { get; set; }
        public MMember Get { get; set; }
        public MMember Set { get; set; }
        public object CustomData { get; set; }
        public string Name { get; set; }
        public bool IsExplicitInterface { get; set; }
    }
}
