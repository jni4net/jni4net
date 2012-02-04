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
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services.Translators
{
    public class ClrProxyCopyTranslator : BaseProxyCopyTranslator
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
                && model.IsClr;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            //CLR->JVM static
            model.JvmGenerationStatic = model.JvmGeneration.ShalowClone(GeneratorTarget.JvmStatic);
            model.JvmGenerationStatic.Declaration = new UTypeUsage(model.JvmGeneration.Declaration.Root, model);
            model.JvmGenerationStatic.Declaration.IsLocalName = true;
            model.JvmGenerationStatic.Base = null;
            model.JvmGenerationStatic.Interfaces.Clear();
            model.JvmGenerationStatic.Members.Clear();

            //CLR->CLR static backing
            model.ClrGenerationStatic = model.ClrGeneration.DeepClone(false,GeneratorTarget.ClrStatic | GeneratorTarget.JvmBacking);
            model.ClrGenerationStatic.Declaration = new UTypeUsage(model.ClrGeneration.Declaration.Root, model);
            model.ClrGenerationStatic.Declaration.IsLocalName = true;
            model.ClrGenerationStatic.Declaration.MakeStaticName = true;

            if (model.IsInterface)
            {
                // CLR->JVM proxy
                model.JvmGenerationProxy = model.JvmGeneration.DeepClone(false, GeneratorTarget.JvmProxy);
                model.JvmGenerationProxy.Interfaces.Clear();
                model.JvmGenerationProxy.Interfaces.Add(model.ClrGeneration.Declaration.DeepClone(false, model));
                FlattenJvmGenerationMembers(model, model.JvmGenerationProxy, false);

                //CLR->CLR static backing
                FlattenClrGenerationMembers(model, model.ClrGenerationStatic, true);

                //CLR->CLR proxy backing
                model.ClrGenerationProxy = model.Exploration.DeepClone(false, GeneratorTarget.ClrProxy | GeneratorTarget.JvmBacking);
                model.ClrGenerationProxy.Interfaces.Clear();
                model.ClrGenerationProxy.Interfaces.Add(model.ClrGeneration.Declaration.DeepClone(false, model));
                FlattenClrGenerationMembers(model, model.ClrGenerationProxy, true);

                //names
                model.JvmGenerationStatic.Declaration.MakeStaticName = true;
                model.JvmGenerationProxy.Declaration.MakeProxyName = true;
                model.ClrGenerationProxy.Declaration.MakeProxyName = true;
            }
            else
            {
                // CLR->JVM proxy
                model.JvmGenerationProxy = model.JvmGeneration;

                // CLR->CLR proxy backing
                model.ClrGenerationProxy = model.Exploration.ShalowClone(GeneratorTarget.ClrProxy | GeneratorTarget.JvmBacking);
                model.ClrGenerationProxy.Base = null;
                model.ClrGenerationProxy.Interfaces.Clear();
                model.ClrGenerationProxy.Members.Clear();

                if(model.TypeRegistration.addBaseMethods)
                {
                    //System.Exception

                    //CLR->CLR static backing
                    MType bse = model.Exploration.Base.Root;
                    foreach (var bseMember in bse.ClrGeneration.Members)
                    {
                        if(!bseMember.IsConstructor && bseMember.IsPublic)
                        {
                            model.ClrGenerationStatic.Members.Add(bseMember.DeepClone(false));
                        }
                    }

                    //MakeConflictsExplicit(model, model.ClrGenerationStatic, false);

                    model.ClrGenerationStatic.SortMembers();
                }
            }

            model.Pass = ProxyGenPass.P3100_InterfacesProxyFilled;
            return false;
        }

        protected override bool IsSkip(UTypeUsage ifc)
        {
            return ifc.IsJvmSkip;
        }
    }
}
