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
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Translators
{
    public class SubstituteTypeUsageTranslator : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P2600_MembersConfigured; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 10; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            Subst(model, model.ClrGeneration);
            Subst(model, model.JvmGeneration);
            return false;
        }

        protected virtual void Subst(MType model, MTypeView view)
        {
            bool viewIsClr = view.IsClr;
            MType subst;
            foreach (MMember member in view.Members)
            {
                subst = Subst(model, member, m => m.Return, viewIsClr);
                UpdateUsage(member, member.Return, subst, viewIsClr);
                for (int i = 0; i < member.Params.Count; i++)
                {
                    int index = i;
                    subst = Subst(model, member, m => m.Params[index], viewIsClr);
                    UpdateUsage(member, member.Params[i], subst, viewIsClr);
                }
            }
            if (view.Base != null && !view.Base.Root.IsRoot)
            {
                subst = Subst(model, null, m => view.Base, viewIsClr);
                UpdateUsage(null, view.Base, subst, viewIsClr);
            }
            foreach (UTypeUsage ifc in view.Interfaces)
            {
                UTypeUsage infc = ifc;
                subst = Subst(model, null, m => infc, viewIsClr);
                UpdateUsage(null, ifc, subst, viewIsClr);
            }
        }

        protected virtual MType Subst(MType model, MMember member, Func<MMember, UTypeUsage> getUsage, bool viewIsClr)
        {
            var usage = getUsage(member);
            if(usage == null )
            {
                return null;
            }

            if(usage.ParameterRegistration!=null && usage.ParameterRegistration.changeType!=null)
            {
                Logger.LogVerbose("SubstituteTypeUsageTranslator: skipped parameter substitution on" + member, model);
                return null;
            }

            MType paramModel = usage.Root;
            if (paramModel.Substitution == null || usage.Root.IsClr == viewIsClr)
            {
                return null;
            }

            if (paramModel.IsPrimitive && (usage.IsRef || usage.IsOut))
            {
                return null;
            }

            if (model.IsJvm && model == usage.Root && !model.IsRoot)
            {
                return null;
            }

            return paramModel.Substitution;
        }

        protected virtual void UpdateUsage(MMember member, UTypeUsage usage, MType substitution, bool viewIsClr)
        {
            if (usage != null && substitution!=null)
            {
                usage.Root = substitution;
            }
        }
    }
}