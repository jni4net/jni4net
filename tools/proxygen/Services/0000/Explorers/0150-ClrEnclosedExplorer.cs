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

using com.jni4net.config;
using Type = IKVM.Reflection.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class ClrEnclosedExplorer : BaseHandler
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
            get { return ProxyGenPass.P0100_ProxyLoaded; }
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
            waitingFor = new[] { model };
            return model.Exploration != null;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            var clr = model.ClrReflection;
            Type clrEnclosing = clr.DeclaringType;
            CheckType(clrEnclosing);
            if (clrEnclosing != null)
            {
                var enclosingModel = ClrResolver.Register(ClrResolver.FindPlainType(clrEnclosing), null, model);

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
                model.ClrName.UnnestInterfaces();

                enclosingModel.Exploration.NestedTypes.Add(model);
            }
            if (model.IsGenerate && !model.IsExcluded && model.ProjectRegistration.ShouldGenerateNested(false))
            {
                var nestedTypes = FindNestedTypes(clr);
                foreach (var nestedType in nestedTypes)
                {
                    var enclosedModel = ClrResolver.Register(ClrResolver.FindPlainType(nestedType), null, model);
                    enclosedModel.MarkGenerate((m) => true, model.ProjectRegistration);
                }
            }
            UpdateNameRoots(model);

            model.Pass = ProxyGenPass.P0200_EnclosingExplored;
            return false;
        }

        public static void UpdateNameRoots(MType model)
        {
            MType current = model;
            foreach (var enclosingType in model.JvmName.EnclosingTypes)
            {
                current = current.Exploration.EnclosingType;
                if (enclosingType.Root != null)
                {
                    if (enclosingType.Root != current)
                    {
                        throw new InvalidProgramException();
                    }
                }
                else
                {
                    enclosingType.Root = current;
                }
            }

            current = model;
            foreach (var enclosingType in model.ClrName.EnclosingTypes)
            {
                current = current.Exploration.EnclosingType;
                if (enclosingType.Root != null)
                {
                    if (enclosingType.Root != current)
                    {
                        throw new InvalidProgramException();
                    }
                }
                else
                {
                    enclosingType.Root = current;
                }
            }
            
            //update name roots
            foreach (var nestedType in model.Exploration.NestedTypes)
            {
                current = nestedType;
                foreach (var enclosingType in nestedType.JvmName.EnclosingTypes)
                {
                    current = current.Exploration.EnclosingType;
                    if (enclosingType.Root != null)
                    {
                        if (enclosingType.Root != current)
                        {
                            throw new InvalidProgramException();
                        }
                    }
                    else
                    {
                        enclosingType.Root = current;
                    }
                }

                current = nestedType;
                foreach (var enclosingType in nestedType.ClrName.EnclosingTypes)
                {
                    current = current.Exploration.EnclosingType;
                    if (enclosingType.Root != null)
                    {
                        if (enclosingType.Root != current)
                        {
                            throw new InvalidProgramException();
                        }
                    }
                    else
                    {
                        enclosingType.Root = current;
                    }
                }
            }
        }

        protected virtual void CheckType(Type clrEnclosing)
        {
            if (clrEnclosing!=null && clrEnclosing.IsGenericType)
            {
                throw new ProxygenException("ClrEnclosedExplorer generic types are not supported in this version. " + clrEnclosing.FullName);
            }
        }

        protected virtual IList<Type> FindNestedTypes(Type clr)
        {
            return clr.GetNestedTypes().Where(x=>!x.IsGenericType && x.IsNestedPublic).ToList();
        }
    }
}
