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

using Type = IKVM.Reflection.Type;
using System;
using System.Collections.Generic;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class ClrExtendsExplorer : BaseHandler
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
            get { return ProxyGenPass.P0200_EnclosingExplored; }
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
            var clr = model.ClrReflection;
            model.Exploration.Declaration = ClrResolver.CreateUsage(clr, model);
            model.Exploration.Declaration.IsLocalName = true;

            if (clr == KnownTypes.SystemObject.ClrReflection || clr.IsInterface)
            {
                model.Pass = ProxyGenPass.P0300_BasesExplored;
                return false;
            }

            Type clrBase = FindBase(clr);
            if (clrBase != null)
            {
                var baseModel = ClrResolver.Register(ClrResolver.FindPlainType(clrBase), null, model);

                Repository.ExploreType(baseModel);

                // make sure we load clr side
                if (baseModel.Pass < ProxyGenPass.P0300_BasesExplored)
                {
                    handleModel(baseModel);
                }

                model.Exploration.Base = ClrResolver.CreateUsage(clrBase, model);

                if (model.IsGenerate && !model.Exploration.Base.Root.IsExcluded)
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

        protected virtual Type FindBase(Type type)
        {
            Type clrBase = type.BaseType;
            while (clrBase!=null && clrBase.IsGenericType)
            {
                Logger.LogMessage("Skipped generic base" +
                                  (clrBase.IsGenericTypeDefinition
                                       ? clrBase.FullName
                                       : clrBase.GetGenericTypeDefinition().FullName), null);
                clrBase = clrBase.BaseType;
            }
            return clrBase;
        }
    }
}
