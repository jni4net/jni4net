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
using System.Linq;
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using java.lang;

namespace com.jni4net.proxygen.Services.Tweakers
{
    public class BaseMethodsTranslator : BaseHandler
    {
        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P2500_TranslatorStarted; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 05; }
        }

        public override bool IsBlockingAll
        {
            get
            {
                return true;
            }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate
                && !model.IsInterface
                && model.Exploration.Base != null
                && 
                (model.IsJvm && model.Exploration.Base.Root.IsProtected)
                ||
                (model.TypeRegistration.addBaseMethods)
                ||
                model == KnownTypes.JavaLangThrowable
                ;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            MType bse = model.Exploration.Base.Root;
            foreach (var member in bse.TargetGeneration.Members)
            {
                if(model==KnownTypes.JavaLangThrowable && member.Name=="getClass")
                {
                    continue;
                }
                if (model == KnownTypes.SystemException&& member.Name == "GetType")
                {
                    continue;
                }
                if (!member.IsConstructor && member.IsPublic)
                {
                    MMember clone = member.DeepClone(false);
                    if (model.IsSealed)
                    {
                        clone.IsVirtual = false;
                    }
                    if (!model.TypeRegistration.addBaseMethods)
                    {
                        clone.Owner = model;
                    }
                    model.TargetGeneration.Members.Add(clone);
                }
            }

            if (model.Exploration.Base.Root.IsProtected)
            {
                //java.lang.AbstractStringBuilder
                model.TargetGeneration.Base = bse.TargetGeneration.Base;
                foreach (var ifc in bse.TargetGeneration.Interfaces)
                {
                    if (!model.TargetGeneration.Interfaces.Any(x => ifc.Root.IsAssignableFrom(x.Root)))
                    {
                        var clone = ifc.DeepClone(false, model);
                        model.TargetGeneration.Interfaces.Add(clone);
                    }
                }
            }
            return false;
        }
    }
}
