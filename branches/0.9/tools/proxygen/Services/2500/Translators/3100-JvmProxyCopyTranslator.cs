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

namespace com.jni4net.proxygen.Services.Translators
{
    public class JvmProxyCopyTranslator : BaseProxyCopyTranslator
    {
         public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P2800_MembersPrimitivised; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 300; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate 
                && model.IsJvm;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            //JVM->JVM static
            model.JvmGenerationStatic = model.JvmGeneration.ShalowClone(GeneratorTarget.JvmStatic);
            model.JvmGenerationStatic.Declaration = new UTypeUsage(model.JvmGeneration.Declaration.Root, model);
            model.JvmGenerationStatic.Declaration.IsLocalName = true;
            model.JvmGenerationStatic.Declaration.MakeStaticName = true;
            model.JvmGenerationStatic.Base = null;
            model.JvmGenerationStatic.Interfaces.Clear();
            model.JvmGenerationStatic.Members.Clear();

            //JVM->CLR static backing
            model.ClrGenerationStatic = model.ClrGeneration.DeepClone(false, GeneratorTarget.ClrStatic | GeneratorTarget.JvmBacking);
            model.ClrGenerationStatic.Declaration = new UTypeUsage(model.ClrGeneration.Declaration.Root, model);
            model.ClrGenerationStatic.Declaration.IsLocalName = true;

            if (model.IsInterface)
            {
                // JVM->CLR proxy
                model.ClrGenerationProxy = model.ClrGeneration.DeepClone(false, GeneratorTarget.ClrProxy);
                model.ClrGenerationProxy.Interfaces.Clear();
                model.ClrGenerationProxy.Interfaces.Add(model.JvmGeneration.Declaration.DeepClone(false, model));
                FlattenClrGenerationMembers(model, model.ClrGenerationProxy, false);

                //JVM->CLR static backing
                FlattenClrGenerationMembers(model, model.ClrGenerationStatic, false);

                //JVM->JVM proxy
                model.JvmGenerationProxy = model.Exploration.DeepClone(false, GeneratorTarget.JvmProxy);
                model.JvmGenerationProxy.Interfaces.Clear();
                model.JvmGenerationProxy.Interfaces.Add(model.JvmGeneration.Declaration.DeepClone(false, model));
                FlattenJvmGenerationMembers(model, model.JvmGenerationProxy, true);

                //names
                model.ClrGenerationStatic.Declaration.MakeStaticName = true;
                model.ClrGenerationProxy.Declaration.MakeProxyName = true;
                model.JvmGenerationProxy.Declaration.MakeProxyName = true;
            }
            else
            {
                // JVM->CLR proxy
                model.ClrGenerationProxy = model.ClrGeneration;

                // JVM->JVM proxy backing
                model.JvmGenerationProxy = model.Exploration.ShalowClone(GeneratorTarget.JvmProxy);
                model.JvmGenerationProxy.Base = null;
                model.JvmGenerationProxy.Interfaces.Clear();
                model.JvmGenerationProxy.Members.Clear();
            }

            model.Pass = ProxyGenPass.P3100_InterfacesProxyFilled;
            return false;
        }

        protected override bool IsSkip(UTypeUsage ifc)
        {
            return ifc.IsClrSkip;
        }
    }
}
