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

namespace com.jni4net.proxygen.Model
{
    public class MTypeView
    {
        GeneratorTarget Target { get; set; }
        public MType Owner { get; set; }
        public UTypeUsage Declaration { get; set; }
        public UTypeUsage Base { get; set; }
        public IList<UTypeUsage> Interfaces { get; private set; }
        public IDictionary<string,object> Data { get; private set; }

        public UTypeUsage ConfigBase { get; set; }
        public IList<UTypeUsage> ConfigInterfaces { get; private set; }

        public IList<MType> NestedTypes { get; private set; }
        public MType EnclosingType { get; set; }
        public IList<MMember> Members { get; set; }
        public bool IsClr { get; set; }
        public bool IsJvm { get { return !IsClr; } set { IsClr = !value; } }

        public MTypeView(MType owner, bool isClr, GeneratorTarget target)
        {
            Target = target;
            IsClr = isClr;
            Owner = owner;
            Interfaces = new List<UTypeUsage>();
            ConfigInterfaces = new List<UTypeUsage>();
            NestedTypes = new List<MType>();
            Members = new List<MMember>();
            Data=new Dictionary<string, object>();
        }

        public MTypeView DeepClone(bool pair, GeneratorTarget target)
        {
            return DeepClone(pair, true, target);
        }

        public MTypeView ShalowClone(GeneratorTarget target)
        {
            var clone = new MTypeView(Owner, IsClr, target);
            if (Declaration != null)
            {
                clone.Declaration = Declaration;
            }
            clone.Base = Base;
            clone.ConfigBase = ConfigBase;
            clone.EnclosingType = EnclosingType;
            foreach (UTypeUsage ifc in Interfaces)
            {
                if (IsClr ? !ifc.IsJvmSkip : !ifc.IsClrSkip)
                {
                    clone.Interfaces.Add(ifc);
                }
                else
                {
                    clone.ConfigInterfaces.Add(ifc);
                }
            }
            foreach (var ifc in ConfigInterfaces)
            {
                if (IsClr ? !ifc.IsJvmSkip : !ifc.IsClrSkip)
                {
                    clone.Interfaces.Add(ifc);
                }
                else
                {
                    clone.ConfigInterfaces.Add(ifc);
                }
            }
            foreach (MType nestedType in NestedTypes)
            {
                clone.NestedTypes.Add(nestedType);
            }
            foreach (MMember member in Members)
            {
                clone.Members.Add(member);
            }

            return clone;
        }

        public MTypeView DeepClone(bool pair, bool members, GeneratorTarget target)
        {
            if (Owner.IsClr != IsClr && pair)
            {
                throw new InvalidProgramException();
            }

            bool isClr = pair ? !IsClr : IsClr;
            var clone = new MTypeView(Owner, isClr, target);
            if (Declaration != null)
            {
                clone.Declaration = Declaration.DeepClone(pair, Owner);
            }
            if (Base!=null)
            {
                clone.Base = Base.DeepClone(pair, Owner);
            }
            if(ConfigBase!=null)
            {
                clone.ConfigBase = clone.Base;
                clone.Base = ConfigBase.DeepClone(pair, Owner);
            }
            clone.EnclosingType = EnclosingType;
            foreach (UTypeUsage ifc in Interfaces)
            {
                if (IsClr ? !ifc.IsJvmSkip : !ifc.IsClrSkip)
                {
                    clone.Interfaces.Add(ifc.DeepClone(pair, Owner));
                }
                else
                {
                    clone.ConfigInterfaces.Add(ifc.DeepClone(pair, Owner));
                }
            }
            foreach (var ifc in ConfigInterfaces)
            {
                if (IsClr ? !ifc.IsJvmSkip : !ifc.IsClrSkip)
                {
                    clone.Interfaces.Add(ifc.DeepClone(pair, Owner));
                }
                else
                {
                    clone.ConfigInterfaces.Add(ifc.DeepClone(pair, Owner));
                }
            }
            foreach (MType nestedType in NestedTypes)
            {
                clone.NestedTypes.Add(nestedType);
            }
            if(members)
            {
                foreach (MMember member in Members)
                {
                    clone.Members.Add(member.DeepClone(pair));
                }                
            }

            return clone;
        }

        public IList<UTypeUsage> AllInterfaces
        {
            get
            {
                var allInterfaces = new Dictionary<UTypeUsage, UTypeUsage>();
                AddInterfaces(allInterfaces);
                return allInterfaces.Values.ToList();
            }
        }

        private void AddInterfaces(Dictionary<UTypeUsage, UTypeUsage> allInterfaces)
        {
            foreach (var ifc in Interfaces)
            {
                if (!allInterfaces.ContainsKey(ifc))
                {
                    allInterfaces.Add(ifc, ifc);
                }
                ifc.Root.TargetGeneration.AddInterfaces(allInterfaces);
            }
            if(Base!=null)
            {
                Base.Root.TargetGeneration.AddInterfaces(allInterfaces);
            }
        }

        public void SortMembers()
        {
            Members = Members.OrderBy(x => !x.IsConstructor).ThenBy(x => !x.IsStatic).ThenBy(x => x.Name).ThenBy(x => x.GetJvmSignature(true)).ToList();
        }


        public override string ToString()
        {
            return Target.ToString()+": "+ Owner;
        }
    }
}
