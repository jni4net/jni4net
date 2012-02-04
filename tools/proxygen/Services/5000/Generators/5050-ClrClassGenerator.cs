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
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using polyglottos;

namespace com.jni4net.proxygen.Services.Generators
{
    public class ClrClassGenerator : BaseGeneratorHandler
    {
        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P5000_GeneratorStarted; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority+50; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate 
                && !model.IsInterface 
                && model.IsClr;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            waitingFor = new[] { model.JvmGeneration.EnclosingType };
            return (!model.IsNested || model.JvmGeneration.EnclosingType.Pass >= ProxyGenPass.P5100_FilesGenerateCreated);
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            JavaGenerator.GenerateJvmContainer(model, model.JvmGeneration,
                container =>
                    {
                        JavaGenerator.GenerateJvmClass(model, model.JvmGeneration, container,
                            proxy =>
                            {
                                if (!model.IsRoot)
                                {
                                    JavaGenerator.CreateEnvConstructor(model, proxy);
                                }

                                JavaGenerator.CreateProxyFactory(model, proxy, model.JvmGeneration);
                                JavaGenerator.CreateStaticInfo(model, proxy);
                                JavaGenerator.CreateStaticConstructor(model, proxy);

                                model.Targets.AddClass(proxy, GeneratorTarget.JvmApi);
                                model.Targets.AddClass(proxy, GeneratorTarget.JvmProxy);
                                model.Targets.AddClass(proxy, GeneratorTarget.JvmStatic);
                            });

                        model.Targets.AddContainer(container, GeneratorTarget.JvmApi);
                        model.Targets.AddContainer(container, GeneratorTarget.JvmProxy);
                        model.Targets.AddContainer(container, GeneratorTarget.JvmStatic);
                    }
                );

            CSharpGenerator.GenerateClrContainer(model, model.ClrGeneration,
                container =>
                {
                    container.AddClass(model.ClrLocalName + "_",
                        staticApi =>
                        {
                            staticApi.IsPartial = true;
                            staticApi.IsStatic = true;
                            //staticApi.IsPublic = false;
                            //staticApi.IsInternal = true;
                            staticApi.CustomData = model.ClrGenerationStatic;
                            staticApi.AddAttribute(GTypeJ4N.J4NProxyAttribute).AddParameter().TypeOf(model.ClrGenerationStatic.Declaration);

                            CSharpGenerator.CreateStaticConstructor(model, staticApi);
                            CSharpGenerator.CreateStaticInfo(model, staticApi);

                            model.Targets.AddClass(staticApi, GeneratorTarget.ClrStatic);
                            model.Targets.AddClass(staticApi, GeneratorTarget.JvmBacking);
                        });

                    model.Targets.AddContainer(container, GeneratorTarget.JvmBacking);
                    model.Targets.AddContainer(container, GeneratorTarget.ClrStatic);
                });

            model.Pass = ProxyGenPass.P5100_FilesGenerateCreated;
            return false;
        }
    }
}
