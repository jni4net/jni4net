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
using java.lang;
using Microsoft.Practices.Unity;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services
{
    class TypeRepository : ITypeRepository
    {
        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IContainer Container { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public void Init()
        {
        }

        public void DumpExploredModels(bool dep)
        {
            foreach (var model in GetModelsToExplore())
            {
                Logger.LogMessage(model.DescriptiveName(), model);
                MTypeView view = model.Exploration ?? model.ClrGeneration ?? model.JvmGeneration;
                if (dep && view.Declaration!=null)
                {
                    var sb = new System.Text.StringBuilder();
                    sb.Append("        " + view.Declaration);
                    if (view.Base != null)
                    {
                        sb.Append(" extends " + view.Base);
                    }
                    if (view.Interfaces.Count>0)
                    {
                        sb.Append(" implements ");
                    }
                    for (int i = 0; i < view.Interfaces.Count; i++)
                    {
                        var ifc = view.Interfaces[i];
                        if(i>0)
                        {
                            sb.Append(", ");
                        }
                        sb.Append(ifc);
                    }
                    Logger.LogMessage(sb.ToString(), model);
                    sb.Length = 0;
                    sb.Append("       ");
                    if (view.EnclosingType != null)
                    {
                        sb.Append(" inside of " + view.EnclosingType);
                    }
                    if (view.NestedTypes.Count>0)
                    {
                        sb.Append(" contains " );
                        for (int i = 0; i < view.NestedTypes.Count; i++)
                        {
                            var enclosedType = view.NestedTypes[i];
                            if (i > 0)
                            {
                                sb.Append(", ");
                            }
                            sb.Append(enclosedType);
                        }
                    }
                    if(sb.Length>8)
                    {
                        Logger.LogMessage(sb.ToString(),model);
                    }
                    sb.Length = 0;
                    foreach (var member in view.Members)
                    {
                        Logger.LogMessage(">>       "+member,model);
                    }
                }
            }
        }

        private readonly Dictionary<Type, MType> types = new Dictionary<Type, MType>();
        private readonly Dictionary<Class, MType> classes = new Dictionary<Class, MType>();
        private readonly Dictionary<MType, int> explore = new Dictionary<MType, int>();
        private IList<MType> exploreList = new List<MType>();

        public void ResetModelsToExplore(IList<MType> models)
        {
            exploreList = models;
        }

        public IEnumerable<MType> GetModelsToExplore()
        {
            return exploreList;
        }

        public T GetModel<T>(Type handle) where T : MType
        {
            if (handle==null)
            {
                return null;
            }
            MType res;
            types.TryGetValue(handle, out res);
            return (T)res;
        }

        public T GetModel<T>(Class handle) where T : MType
        {
            if (handle == null)
            {
                return null;
            }
            MType res;
            classes.TryGetValue(handle, out res);
            return (T)res;
        }

        public void RegisterType(MType model)
        {
            var clr = model.ClrReflection;
            var jvm = model.JvmReflection;
            if (clr!=null)
            {
                if ((clr.IsGenericType && !clr.IsGenericTypeDefinition) || clr.IsGenericParameter)
                {
                    throw new InvalidProgramException();
                }
                if (!clr.IsPublic && !clr.IsNestedPublic)
                {
                    throw new InvalidProgramException();
                }
                types[clr] = model;
            }
            if (jvm != null)
            {
                /* damn AbstractStringBuilder
                if (!jvm.IsPublic())
                {
                    throw new InvalidProgramException();
                }*/
                classes[jvm] = model;
            }
        }

        public void ExploreType(MType model)
        {
            if (model.Exploration == null)
            {
                model.Exploration = new MTypeView(model, model.IsClr, model.IsClr ? GeneratorTarget.ClrApi : GeneratorTarget.JvmApi);
            }
            if (model.ClrReflection != null &&
                ((model.ClrReflection.IsGenericType && !model.ClrReflection.IsGenericTypeDefinition) ||
                (model.ClrReflection.IsGenericParameter))
                )
            {
                throw new InvalidProgramException();
            }
            if(!explore.ContainsKey(model))
            {
                explore[model] = 0;
                exploreList.Add(model);
            }
        }

        public void ProcessType(MType model)
        {
            if (!model.IsProcess && model.Pass > ProxyGenPass.P0100_ProxyLoaded)
            {
                // restart exploration, just in case we missed the IsProcess propagation
                model.Pass = ProxyGenPass.P0100_ProxyLoaded;
                model.Exploration = new MTypeView(model, model.IsClr, model.IsClr ? GeneratorTarget.ClrApi : GeneratorTarget.JvmApi);
                model.Handlers = null;
            }
            ExploreType(model);
            model.IsProcess = true;
        }

        public void GenerateType(MType model)
        {
            if (model.TypeRegistration == null || model.ProjectRegistration==Explorer.unknownProject)
            {
                throw new InvalidProgramException();
            }
            if (model.IsExcluded)
            {
                throw new ProxygenException("Model " + model.JvmFullName + " was excluded");
            }
            if (!model.IsGenerate && model.Pass > ProxyGenPass.P0100_ProxyLoaded)
            {
                // restart exploration, just in case we missed the IsGenerate propagation
                model.Pass = ProxyGenPass.P0100_ProxyLoaded;
                model.Exploration = new MTypeView(model, model.IsClr, model.IsClr ? GeneratorTarget.ClrApi : GeneratorTarget.JvmApi);
                model.Handlers = null;
            }
            ExploreType(model);
            model.IsGenerate = true;
            model.IsProcess = true;
        }

    }
}
