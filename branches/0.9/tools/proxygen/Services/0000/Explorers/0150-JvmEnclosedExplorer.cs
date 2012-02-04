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
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class JvmEnclosedExplorer : BaseHandler
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
            get { return ProxyGenPass.P0100_ProxyLoaded; }
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
            waitingFor=new []{model};
            return model.Exploration != null;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            var jvm = model.JvmReflection;
            Class jvmEnclosing = jvm.getEnclosingClass();
            if (jvmEnclosing != null)
            {
                var enclosingModel = JvmResolver.Register(JvmResolver.FindPlainType(jvmEnclosing), null, model);

                Repository.ExploreType(enclosingModel);

                // make sure we load clr side
                if (enclosingModel.Pass < ProxyGenPass.P0300_BasesExplored)
                {
                    handleModel(enclosingModel);
                }

                if (model.IsProcess)
                {
                    Repository.ProcessType(enclosingModel);
                }
                if (model.IsGenerate && !model.IsExcluded && model.ProjectRegistration.ShouldGenerateNested(false))
                {
                    enclosingModel.MarkGenerate((m) => true, model.ProjectRegistration);
                }

                model.Exploration.EnclosingType = enclosingModel;
                enclosingModel.Exploration.NestedTypes.Add(model);
            }
            if (model.IsGenerate && !model.IsExcluded && model.ProjectRegistration.ShouldGenerateNested(false))
            {
                var nestedTypes = FindNestedTypes(jvm);
                foreach (var nestedType in nestedTypes)
                {
                    var enclosedModel = JvmResolver.Register(JvmResolver.FindPlainType(nestedType), null, model);
                    enclosedModel.MarkGenerate((m) => true, model.ProjectRegistration);
                }
            }

            ClrEnclosedExplorer.UpdateNameRoots(model);
            
            model.Pass = ProxyGenPass.P0200_EnclosingExplored;
            return false;
        }

        protected virtual IList<Class> FindNestedTypes(Class jvm)
        {
            return jvm.getDeclaredClasses().Where(x => x.IsPublic()).ToList();
        }
    }
}
