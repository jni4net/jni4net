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
using System.Collections.Generic;
using com.jni4net.config;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using java.lang;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Explorers
{
    public abstract class ImplementsExplorerCommon : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        [Dependency]
        public IClrResolver ClrResolver { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ITypeRepository Repository { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        
        protected void LoadRegistrations(MType model)
        {
            if (model.TypeRegistration.implements.Count!=0)
            {
                MapInterfaces(model);
            }

            if (model.TypeRegistration.extends != null && model.TypeRegistration.extends.declaration!=null)
            {
                MapBase(model);
            }
        }

        private void MapBase(MType model)
        {
            var reg = model.TypeRegistration.extends;
            var declaration = LoadDeclaration(model, reg);
            if (declaration == null)
            {
                Logger.LogMessage("Can't load base " + reg.declaration + " for " + model, model);
            }
            else
            {
                model.Exploration.ConfigBase = declaration;
            }
        }

        private void MapInterfaces(MType model)
        {
            var regMap = new Dictionary<string, ImplementsRegistration>();
            foreach (var implementsRegistration in model.TypeRegistration.implements)
            {
                regMap.Add(implementsRegistration.declaration, implementsRegistration);
            }


            foreach (var ifcDeclaration in model.Exploration.Interfaces)
            {
                ImplementsRegistration reg;
                string name = model.IsClr
                                  ? ifcDeclaration.ClrReflectionName
                                  : ifcDeclaration.JvmReflectionName;
                if (regMap.TryGetValue(name, out reg))
                {
                    regMap.Remove(reg.declaration);
                    ifcDeclaration.Registration = reg;
                    if (reg.exclude)
                    {
                        if (model.IsClr)
                        {
                            ifcDeclaration.IsJvmSkip = true;
                        }
                        else
                        {
                            ifcDeclaration.IsClrSkip = true;
                        }
                    }
                }
            }

            foreach (var reg in regMap.Values)
            {
                if (reg.include)
                {
                    var declaration = LoadDeclaration(model, reg);
                    if (declaration == null)
                    {
                        Logger.LogMessage("Can't load interface " + reg.declaration + " on " + model, model);
                    }
                    else
                    {
                        model.Exploration.ConfigInterfaces.Add(declaration);
                    }
                }
                else
                {
                    Logger.LogMessage("Can't find interface " + reg.declaration + " on " + model, model);
                }
            }
        }

        private UTypeUsage LoadDeclaration(MType model, ExtendsRegistration reg)
        {
            UTypeUsage declaration = null;
            if (model.IsClr)
            {
                Class jvm = JvmResolver.LoadClass(reg.declaration, false);
                if (jvm != null)
                {
                    declaration = JvmResolver.CreateUsage(jvm, model);
                }
                else
                {

                    Type clr = ClrResolver.LoadType(reg.declaration, true);
                    if (clr != null)
                    {
                        declaration = ClrResolver.CreateUsage(clr, model);
                    }
                }
            }
            else
            {
                Type clr = ClrResolver.LoadType(reg.declaration, false);
                if (clr != null)
                {
                    declaration = ClrResolver.CreateUsage(clr, model);
                }
                else
                {
                    Class jvm = JvmResolver.LoadClass(reg.declaration, true);
                    if (jvm != null)
                    {
                        declaration = JvmResolver.CreateUsage(jvm, model);
                    }
                }
            }
            if(declaration!=null)
            {
                Repository.ExploreType(declaration.Root);
                if (model.IsClr)
                {
                    declaration.IsClrSkip = true;
                }
                else
                {
                    declaration.IsJvmSkip = true;
                }
                declaration.Registration = reg;
            }
            return declaration;
        }

    }
}
