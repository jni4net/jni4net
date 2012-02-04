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
using IKVM.Reflection;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services.Tweakers
{
    public class ClrMembersTweaker : BaseHandler
    {
        [Dependency]
        public IClrResolver ClrResolver { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P1000_TweakerStarted; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 110; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate
                && model.IsClr;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            if(model.IsInterface)
            {
                foreach (var member in model.Exploration.Members)
                {
                    member.ImplementsInterfaces.Add(model.Exploration.Declaration);
                    member.ImplementsMember.Add(member);
                }
                return false;
            }

            FindImplementedInterfaces(model);

            //TODO what about overrides of abstract methods ? (on generic base class, which would change signature )

            var membersCopy = model.Exploration.Members.ToList();
            foreach (var member in membersCopy)
            {
                if (!member.IsPublic || member.IsObsolete)
                {
                    if (member.ImplementsInterfaces.Count == 0)
                    {
                        model.Exploration.Members.Remove(member);
                    }
                    else
                    {
                        member.Name = member.ImplementsMember[0].Name;
                    }
                }
            }


            return false;
        }

        private void FindImplementedInterfaces(MType model)
        {
            Type clr = model.ClrReflection;
            var clrInterfaces = GetInterfaces(clr);

            var memberMap = CreateMemberMap(model);

            foreach (var clrIfc in clrInterfaces)
            {
                UTypeUsage ifcModel = ClrResolver.CreateUsage(clrIfc, model);
                var ifcMembersMap = CreateMemberMap(ifcModel, clrIfc);

                var clrIfcMap = clr.GetInterfaceMap(clrIfc);
                for (int i = 0; i < clrIfcMap.InterfaceMethods.Length; i++)
                {
                    var srcClrMember = clrIfcMap.InterfaceMethods[i];
                    var tgtClrMember = clrIfcMap.TargetMethods[i];
                    var srcMember = ifcMembersMap[srcClrMember];
                    if (!srcMember.Owner.IsExcluded)
                    {
                        MMember tgtMember;
                        if (memberMap.TryGetValue(tgtClrMember, out tgtMember))
                        {
                            tgtMember.ImplementsInterfaces.Add(ifcModel);
                            tgtMember.ImplementsMember.Add(srcMember);
                        }
                    }
                }
            }
        }

        protected virtual List<Type> GetInterfaces(Type clr)
        {
            return clr.GetInterfaces().Where(x => ClrResolver.CheckSupportedType(x)).ToList();
        }

        protected virtual Dictionary<MemberInfo, MMember> CreateMemberMap(MType model)
        {
            var memberMap = new Dictionary<MemberInfo, MMember>();
            foreach (var member in model.Exploration.Members)
            {
                if (!member.IsField || member.Property.Set!=member)
                {
                    memberMap.Add(member.ClrReflection, member);
                }
            }
            return memberMap;
        }

        protected virtual Dictionary<MemberInfo, MMember> CreateMemberMap(UTypeUsage ifcUsage, Type clrType)
        {
            var memberMap = new Dictionary<MemberInfo, MMember>();
            foreach (var member in ifcUsage.Root.Exploration.Members)
            {
                if (!member.IsField || member.Property.Set != member)
                {
                    memberMap.Add(member.ClrReflection, member);
                }
            }
            return memberMap;
        }
    
    }
}
