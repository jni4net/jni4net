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
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;
using Microsoft.Practices.Unity;
using Object = java.lang.Object;
using JType = java.lang.reflect.Type;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class JvmExtendsExplorer : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ITypeRepository Repository { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P0200_EnclosingExplored; }
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
            var jvm = model.JvmReflection;
            model.Exploration.Declaration = JvmResolver.CreateDeclaration((JType)jvm, (MType)model);
            model.Exploration.Declaration.IsLocalName = true;

            if (jvm.isInterface() || Object._class.Equals(jvm))
            {
                model.Pass = ProxyGenPass.P0300_BasesExplored;
                return false;
            }

            var jvmBase = FindBase(jvm);
            if (jvmBase != null)
            {
                var bse = (Class)JvmResolver.FindPlainType(jvmBase);
                MType baseModel = JvmResolver.Register(bse, null, model);

                Repository.ExploreType(baseModel);

                // make sure we load jvm side
                if (baseModel.Pass < ProxyGenPass.P0300_BasesExplored)
                {
                    handleModel(baseModel);
                }

                model.Exploration.Base = JvmResolver.CreateUsage(jvmBase, model);
                if (model.IsGenerate && !model.Exploration.Base.Root.IsExcluded && bse.IsPublic())
                {
                    model.Exploration.Base.MarkGenerate(AutogenerateBase, model.ProjectRegistration);
                }
            }
            model.Pass = ProxyGenPass.P0300_BasesExplored;
            return false;
        }

        protected virtual bool AutogenerateBase(MType model)
        {
            return ((model.ProjectRegistration.autoGenerateBaseClass && !model.IsKnown) || model.ProjectRegistration.forceGenerateBaseClass);
        }

        protected virtual JType FindBase(Class type)
        {
            return type.getSuperclass();
        }
    }
}
