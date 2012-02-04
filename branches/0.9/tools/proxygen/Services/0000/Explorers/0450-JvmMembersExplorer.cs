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
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;
using java.lang.reflect;
using Microsoft.Practices.Unity;
using JType = java.lang.reflect.Type;
using String = java.lang.String;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class JvmMembersExplorer : BaseHandler
    {
        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

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
            return model.IsJvm;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            waitingFor = new[] { model };
            return model.Exploration != null;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            Class jvm = model.JvmReflection;

            var jvmConstructors = jvm.getConstructors().OrderBy(x => x.ToString());
            foreach (var jvmConstructor in jvmConstructors)
            {
                var modifiers = (ModifierFlags)jvmConstructor.getModifiers();
                if (!EnumUtils.IsSet(modifiers, ModifierFlags.Public))
                {
                    continue;
                }
                if(EnumUtils.IsSet(modifiers, ModifierFlags.Static))
                {
                    continue;
                }
                var memberModel = new MMember(model, model.ClrLocalName);
                memberModel.JvmReflection = jvmConstructor;
                memberModel.IsConstructor = true;
                memberModel.JvmSignature = ReflectionUtils.GetJvmSignature(jvmConstructor);

                AddConstructorParams(memberModel, jvmConstructor);

                GenerateUsedTypes(model, memberModel);

                model.Exploration.Members.Add(memberModel);
            }

            var jvmMethods = jvm.getMethods().OrderBy(x => !x.IsStatic()).ThenBy(x => x.getName().ToString());
            foreach (Method jvmMethod in jvmMethods)
            {

                var modifiers = (ModifierFlags)jvmMethod.getModifiers();
                if (!EnumUtils.IsSet(modifiers, ModifierFlags.Public))
                {
                    continue;
                }
                Class declaringClass = jvmMethod.getDeclaringClass();
                if (!jvm.equals(declaringClass))
                {
                    continue;
                }

                var name = jvmMethod.getName();
                var memberModel = new MMember(model, name);
                memberModel.JvmReflection = jvmMethod;
                memberModel.IsMethod = true;
                memberModel.IsStatic = EnumUtils.IsSet(modifiers, ModifierFlags.Static);
                memberModel.IsSealed = EnumUtils.IsSet(modifiers, ModifierFlags.Final);
                memberModel.IsVirtual = !EnumUtils.IsSet(modifiers, ModifierFlags.Final) && !memberModel.IsStatic && !model.IsSealed;
                memberModel.JvmSignature = ReflectionUtils.GetJvmSignature(jvmMethod);

                Class[] pars = jvmMethod.getParameterTypes();
                if (model.IsInterface && ReflectionUtils.IsMethodDefinedOnInterface(jvm, name, pars))
                {
                    continue;
                }

                if(!model.IsInterface && !memberModel.IsStatic && ReflectionUtils.IsMethodDefinedOnBaseClass(jvm, name, pars))
                {
                    continue;
                }

                AddMethodParams(memberModel, jvmMethod);

                GenerateUsedTypes(model, memberModel);

                model.Exploration.Members.Add(memberModel);
            }

            var jvmFields = jvm.getFields().OrderBy(x => !x.IsStatic()).ThenBy(x => x.getName().ToString());
            foreach (Field jvmField in jvmFields)
            {
                var modifiers = (ModifierFlags)jvmField.getModifiers();
                if (!EnumUtils.IsSet(modifiers, ModifierFlags.Public))
                {
                    continue;
                }
                if (jvm != jvmField.getDeclaringClass())
                {
                    continue;
                }
                var memberModel = new MMember(model, jvmField.getName());
                memberModel.JvmReflection = jvmField;
                memberModel.IsStatic = EnumUtils.IsSet(modifiers, ModifierFlags.Static);
                memberModel.IsField = true;
                memberModel.IsFinal = EnumUtils.IsSet(modifiers, ModifierFlags.Final);
                memberModel.JvmSignature = ReflectionUtils.GetJvmSignature(jvmField);
                AddFieldParams(memberModel, jvmField);
                GenerateUsedTypes(model, memberModel);
                model.Exploration.Members.Add(memberModel);
            }

            model.Exploration.SortMembers();

            model.Pass = ProxyGenPass.P0500_MembersExplored;

            return false;
        }

        protected virtual void AddFieldParams(MMember memberModel, Field jvmField)
        {
            AddParams(memberModel, jvmField.getType(), new JType[] { });
        }

        protected virtual void AddConstructorParams(MMember memberModel, Constructor jvmConstructor)
        {
            AddParams(memberModel, null, jvmConstructor.getParameterTypes());
        }

        protected virtual void AddMethodParams(MMember memberModel, Method jvmMethod)
        {
            AddParams(memberModel, jvmMethod.getReturnType(), jvmMethod.getParameterTypes());
        }

        protected void AddParams(MMember memberModel, JType ret, JType[] pars)
        {
            if (ret!=null)
            {
                memberModel.Return = JvmResolver.CreateUsage(ret, memberModel.Owner);
                memberModel.Return.IsReturn = true;
            }
            for (int i = 0; i < pars.Length; i++)
            {
                JType param = pars[i];
                var prm = JvmResolver.CreateUsage(param, "par" + i, memberModel.Owner);
                prm.IsParameter = true;
                memberModel.Params.Add(prm);
            }
        }

        protected virtual void GenerateUsedTypes(MType model, MMember memberModel)
        {
            if (model.IsGenerate)
            {
                foreach (UTypeUsage param in memberModel.ReturnAndParams)
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
