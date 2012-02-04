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
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class ClrMembersExplorer : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IClrResolver ClrResolver { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ITypeRepository Repository { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P0400_InterfacesExplored; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 50; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsClr;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            waitingFor = new[] { model};
            return model.Exploration != null;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            Type clr = model.ClrReflection;
            var clrMembers = EnumerateMembers(clr).OrderBy(x=>x.MemberType).ThenBy(x=>x.ToString());
            foreach (MemberInfo clrMember in clrMembers)
            {
                if (clrMember.MemberType == MemberTypes.NestedType)
                {
                    continue;
                }
                HandleMember(model, clrMember, false);
            }

            model.Exploration.SortMembers();
            model.Pass = ProxyGenPass.P0500_MembersExplored;

            return false;
        }

        protected virtual MMember HandleMember(MType model, MemberInfo clrMember, bool special)
        {
            var memberModel = new MMember(model, clrMember.Name);
            memberModel.ClrReflection = clrMember;
            memberModel.IsObsolete = IsObsolete(clrMember);

            var clrField = clrMember as FieldInfo;
            var clrMethod = clrMember as MethodInfo;
            var clrProperty = clrMember as PropertyInfo;
            var clrEvent = clrMember as EventInfo;
            var clrConstructor = clrMember as ConstructorInfo;
            if (clrMethod != null)
            {
                if (clrMethod.IsSpecialName)
                {
                    if (!special)
                    {
                        return null;
                    }
                }
                else
                {
                    memberModel.IsMethod = true;
                }
                if (clrMethod.GetBaseDefinition() != clrMethod)
                {
                    return null;
                }
                if (!HandleReturn(memberModel, clrMethod.ReturnType))
                {
                    return null;
                }
                if (!HandleParams(memberModel, clrMethod.GetParameters()))
                {
                    return null;
                }
                var li = memberModel.Name.LastIndexOf('.');
                if (li > 0)
                {
                    memberModel.Name = memberModel.Name.Substring(li + 1, memberModel.Name.Length - li - 1);
                    //memberModel.ExplicitInterface = TODO;
                }
                memberModel.IsStatic = clrMethod.IsStatic;
                memberModel.IsVirtual = clrMethod.IsVirtual;
                memberModel.IsSealed = clrMethod.IsFinal;
                memberModel.IsPublic = clrMethod.IsPublic;
            }
            else if (clrConstructor != null)
            {
                if (!clrConstructor.IsPublic)
                {
                    return null;
                }
                if (clrConstructor.IsStatic)
                {
                    return null;
                }
                memberModel.IsConstructor = true;
                if (!HandleParams(memberModel, clrConstructor.GetParameters()))
                {
                    return null;
                }
            }
            else if (clrField != null)
            {
                if (!clrField.IsPublic)
                {
                    return null;
                }
                if (clrField.IsSpecialName)
                {
                    return null;
                }
                if (!HandleReturn(memberModel, clrField.FieldType))
                {
                    return null;
                }

                var property = new MProperty
                {
                    Name = clrField.Name
                };

                memberModel.IsStatic = clrField.IsStatic;
                memberModel.IsField = true;
                property.Get = memberModel;
                property.Get.Property = property;

                if (!clrField.IsInitOnly && !clrField.IsLiteral)
                {
                    property.Set = new MMember(model, clrMember.Name);
                    property.Set.ClrReflection = clrMember;
                    property.Set.IsObsolete = IsObsolete(clrMember);
                    property.Set.IsStatic = clrField.IsStatic;
                    property.Set.Property = property;
                    property.Set.IsField = true;
                    property.Set.Return = new UTypeUsage(KnownTypes.ClrVoid, model);
                    UTypeUsage par = ClrResolver.CreateUsage(clrField.FieldType, memberModel.Owner);
                    par.MethodParameterName = "value";
                    property.Set.Params.Add(par);
                    model.Exploration.Members.Add(property.Set);
                }
            }
            else if (clrProperty != null)
            {
                var property = new MProperty
                {
                    Name = clrProperty.Name
                };
                var li = property.Name.LastIndexOf('.');
                if(li>0)
                {
                    property.Name = property.Name.Substring(li+1, property.Name.Length - li - 1);
                    property.IsExplicitInterface = true;
                }
                var g = clrProperty.GetGetMethod(true);
                if (g != null)
                {
                    property.Get = HandleMember(model, g, true);
                    if (property.Get != null)
                    {
                        property.Get.IsProperty = true;
                        property.Get.Property = property;
                    }
                }
                var s = clrProperty.GetSetMethod(true);
                if (s != null)
                {
                    property.Set = HandleMember(model, s, true);
                    if (property.Set != null)
                    {
                        property.Set.IsProperty = true;
                        property.Set.Property = property;
                    }
                }
                return null;
            }
            else if (clrEvent != null)
            {
                var property = new MProperty
                                   {
                                       Name = clrEvent.Name
                                   };
                var li = property.Name.LastIndexOf('.');
                if (li > 0)
                {
                    property.Name = property.Name.Substring(li + 1, property.Name.Length - li - 1);
                    property.IsExplicitInterface = true;
                }
                var g = clrEvent.GetAddMethod(true);
                if (g != null)
                {
                    property.Get = HandleMember(model, g, true);
                    if (property.Get != null)
                    {
                        property.Get.IsEvent = true;
                        property.Get.Property = property;
                    }
                }
                var s = clrEvent.GetRemoveMethod(true);
                if (s != null)
                {
                    property.Set = HandleMember(model, s, true);
                    if (property.Set != null)
                    {
                        property.Set.IsEvent = true;
                        property.Set.Property = property;
                    }
                }
                return null;
            }
            else
            {
                throw new NotImplementedException(clrMember.MemberType.ToString());
            }
            
            GenerateUsedTypes(model, memberModel);
            model.Exploration.Members.Add(memberModel);

            return memberModel;
        }

        private bool HandleReturn(MMember memberModel, Type type)
        {
            if (!IsPublic(type))
            {
                return false;
            }
            memberModel.Return = ClrResolver.CreateUsage(type, memberModel.Owner);
            memberModel.Return.IsReturn = true;
            return true;
        }

        private bool HandleParams(MMember memberModel, IEnumerable<ParameterInfo> parameterInfos)
        {
            if (parameterInfos.Any(x => !IsPublic(x.ParameterType)))
            {
                return false;
            }
            foreach (ParameterInfo parameter in parameterInfos)
            {
                var prm = ClrResolver.CreateUsage(parameter, memberModel.Owner);
                prm.IsParameter = true;
                memberModel.Params.Add(prm);
            }
            return true;
        }

        protected virtual bool IsPublic(Type type)
        {
            if(type.IsGenericType || type.IsPointer)
            {
                return false;
            }
            var parameterType = ClrResolver.FindPlainType(type);
            return (parameterType.IsPublic || parameterType.IsNestedPublic);
        }

        protected virtual MemberInfo[] EnumerateMembers(Type clr)
        {
            return clr.GetMembers(BindingFlags.Instance | BindingFlags.Static | 
                                  BindingFlags.Public | BindingFlags.NonPublic
                                  | BindingFlags.DeclaredOnly)
                                  .Where(m
                                                                     =>
                                                                         {
                                                                             var mb = m as MethodBase;
                                                                             if (mb == null)
                                                                             {
                                                                                 return true;
                                                                             }
                                                                             return !mb.IsGenericMethod;
                                                                             
                                                                         }).ToArray();
        }

        private Type obsolete;
        public bool IsObsolete(MemberInfo member)
        {
            if (obsolete == null)
            {
                obsolete = ClrResolver.LoadType("System.ObsoleteAttribute", true);
            }
            return member.IsDefined(obsolete, true);
        }

        protected virtual void GenerateUsedTypes(MType model, MMember memberModel)
        {
            if (model.IsGenerate)
            {
                foreach (var param in memberModel.ReturnAndParams)
                {
                    if (!param.Root.IsExcluded)
                    {
                        param.MarkGenerate(AutoGenerateMethodParams, model.ProjectRegistration);
                    }
                }
            }
        }

        protected virtual bool AutoGenerateMethodParams(MType model)
        {
            return !model.IsKnown && model.ProjectRegistration.autoGenerateMethodParams;
        }
    }
}
