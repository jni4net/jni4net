﻿#region Copyright (C) 2012 by Pavel Savara

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
using polyglottos;
using polyglottos.csharp;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;

namespace com.jni4net.proxygen.Services.Generators
{
    public class JvmInterfaceGenerator : BaseGeneratorHandler
    {
        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P5000_GeneratorStarted; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 50; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate
                && model.IsInterface
                && model.IsJvm;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            var go = (!model.IsNested || model.ClrGeneration.EnclosingType.Pass >= ProxyGenPass.P5100_FilesGenerateCreated);
            waitingFor = new[] {model.ClrGeneration.EnclosingType};
            return go;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            JavaGenerator.GenerateJvmStaticContainer(model, model.JvmGeneration,
                container =>
                {
                    container.AddClass(model.JvmLocalName + "_",
                        staticApi =>
                        {
                            staticApi.IsPartial = true;
                            staticApi.IsStatic = model.IsNested;
                            staticApi.AddAttribute(GTypeJ4N.J4NProxyAttribute).AddParameter().TypeOf(model.JvmGenerationStatic.Declaration);
                            BaseJavaGenerator.SupressGeneratedCodeWarnings(staticApi);

                            JavaGenerator.CreateStaticInfo(model, staticApi);
                            JavaGenerator.CreateProxyFactory(model, staticApi, model.JvmGenerationProxy);
                            JavaGenerator.CreateStaticConstructor(model, staticApi);

                            model.Targets.AddClass(staticApi, GeneratorTarget.JvmStatic);
                        });

                    JavaGenerator.GenerateJvmClass(model, model.JvmGenerationProxy, container,
                        proxy =>
                        {
                            proxy.IsInterface = false;
                            proxy.IsPublic = false;
                            proxy.Extends = GTypeJ4N.SystemObject;

                            JavaGenerator.CreateEnvConstructor(model, proxy);
                            JavaGenerator.CreateStaticConstructor(model, proxy);

                            model.Targets.AddClass(proxy, GeneratorTarget.JvmProxy);
                        });

                    model.Targets.AddContainer(container, GeneratorTarget.JvmStatic);
                    model.Targets.AddContainer(container, GeneratorTarget.JvmProxy);
                });

            CSharpGenerator.GenerateClrContainer(model, model.ClrGeneration,
                container=>
                    {
                        CSharpGenerator.GenerateClrClass(model, model.ClrGeneration, container,
                            api => model.Targets.AddClass(api, GeneratorTarget.ClrApi));

                        container.AddClass(model.ClrLocalName + "_",
                            staticApi =>
                            {
                                staticApi.IsPartial = true;
                                staticApi.IsStatic = true;
                                staticApi.AddAttribute(GTypeJ4N.J4NProxyAttribute).AddParameter().TypeOf(model.ClrGenerationStatic.Declaration);
                                staticApi.CustomData = model.ClrGenerationStatic;

                                CSharpGenerator.CreateStaticInfo(model, staticApi);
                                CSharpGenerator.CreateStaticConstructor(model, staticApi);

                                model.Targets.AddClass(staticApi, GeneratorTarget.ClrStatic);
                                model.Targets.AddClass(staticApi, GeneratorTarget.JvmBacking);
                            });

                        CSharpGenerator.GenerateClrClass(model, model.ClrGenerationProxy, container,
                            proxy =>
                            {
                                proxy.Extends = GTypeJ4N.JavaLangObject;
                                proxy.IsInterface = false;
                                proxy.IsInternal = true;

                                CSharpGenerator.CreateStaticConstructor(model, proxy);
                                CSharpGenerator.CreateEnvConstructor(model, proxy, model.ClrGenerationProxy);
                                CSharpGenerator.CreateProxyFactory(model, proxy, model.ClrGenerationProxy);

                                model.Targets.AddClass(proxy, GeneratorTarget.ClrProxy);
                            });

                        model.Targets.AddContainer(container, GeneratorTarget.ClrApi);
                        model.Targets.AddContainer(container, GeneratorTarget.ClrProxy);
                        model.Targets.AddContainer(container, GeneratorTarget.ClrStatic);
                        model.Targets.AddContainer(container, GeneratorTarget.JvmBacking);
                    });

            model.Pass = ProxyGenPass.P5100_FilesGenerateCreated;
            return false;
        }


    }
}
