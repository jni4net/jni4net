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
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Services.Compilation;
using polyglottos;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using polyglottos.snippets;

namespace com.jni4net.proxygen.Services.Generators
{
    public partial class BaseJavaGenerator : BaseGenerator
    {
        [Dependency("GProjectJava")]
        public IGProject GProjectJava { get; set; }

        [Dependency("GTypeUsageGenerator")]
        public GTypeUsageGenerator GTypeUsageGenerator { get; set; }

        [Dependency]
        public ProjectsGenerator ProjectsGenerator { get; set; }
        
        public IGClassContainer GenerateJvmContainer(MType model, MTypeView view, Action<IGClassContainer> with = null)
        {
            IGClassContainer container = null;
            if (!model.IsNested)
            {
                string jvmNamespace = GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model, model) , TypeArgs.Namespace|TypeArgs.Filename, true);
                string jvmName = GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model, model), TypeArgs.Name | TypeArgs.Filename, true);
                string fileName = model.ProjectRegistration.GetJvmFileName(model.TypeRegistration, jvmNamespace, jvmName);
                model.ProjectRegistration.JavaFiles.Add(fileName);

                GProjectJava.AddFile(fileName,
                    file =>
                        {
                            file.AddComment("This code was generated using jni4net. See http://jni4net.sourceforge.net/");
                            if (jvmNamespace != null)
                            {
                                container = file.AddNamespace(jvmNamespace);
                            }
                            else
                            {
                                container = file;
                            }

                            model.Targets.AddFile(file, GeneratorTarget.JvmApi);
                            model.Targets.AddFile(file, GeneratorTarget.JvmProxy);
                        });
            }
            else
            {
                MType enclosingModel = view.EnclosingType;
                container = enclosingModel.Targets.Classes[GeneratorTarget.JvmApi];
            }
            if (with != null) with(container);
            return container;
        }

        public IGClassContainer GenerateJvmStaticContainer(MType model, MTypeView view, Action<IGClassContainer> with = null)
        {
            IGClassContainer container = null;
            if (!model.IsNested)
            {
                string jvmNamespace = GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model, model) { MakeStaticName = true }, TypeArgs.Namespace | TypeArgs.Filename, true);
                string jvmName = GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model, model) { MakeStaticName = true }, TypeArgs.Name | TypeArgs.Filename, true);
                string staticFileName = model.ProjectRegistration.GetJvmFileName(model.TypeRegistration, jvmNamespace, jvmName);
                model.ProjectRegistration.JavaFiles.Add(staticFileName);
                
                GProjectJava.AddFile(staticFileName,
                    sfile =>
                    {
                        if (jvmNamespace != null)
                        {
                            container = sfile.AddNamespace(jvmNamespace);
                        }
                        else
                        {
                            container = sfile;
                        }

                        model.Targets.AddFile(sfile, GeneratorTarget.JvmStatic);
                    });
            }
            else
            {
                MType enclosingModel = view.EnclosingType;
                container = enclosingModel.Targets.Classes[GeneratorTarget.JvmStatic];
            }
            if (with != null) with(container);
            return container;
        }

        public IGClass GenerateJvmClass(MType model, MTypeView view, IGClassContainer container, Action<IGClass> with=null)
        {
            return container.AddClass(model.JvmLocalName, view.Declaration,
                cls =>
                {
                    cls.AddAttribute(GTypeJ4N.J4NProxyAttribute).AddParameter().TypeOf(model.JvmGenerationStatic.Declaration);
                    SupressGeneratedCodeWarnings(cls);
                    cls.IsStatic = model.IsNested;
                    cls.CustomData = view;
                    cls.IsInterface = model.IsInterface;
                    cls.IsSealed = model.IsSealed && !model.IsAbstract;
                    cls.IsPartial = true;
                    cls.Extends = view.Base;
                    foreach (var ifc in view.Interfaces)
                    {
                        if (!ifc.IsJvmSkip)
                        {
                            cls.Implements.Add(ifc);
                        }
                    }
                    if (with != null) with(cls);
                });
        }

        public static void SupressGeneratedCodeWarnings(IGClass cls)
        {
            cls.AddAttribute("SuppressWarnings").AddParameter().TextExpression(
                "{\"UnusedDeclaration\", \"NullableProblems\", \"RedundantCast\", \"deprecation\", \"unchecked\"}");
        }

        public void CreateStaticConstructor(MType model, IGClass cls)
        {
            cls.AddConstructor(
                staticConstructor =>
                {
                    staticConstructor.IsStatic = true;
                    staticConstructor.IsPublic = false;
                    staticConstructor.Static(model.JvmGenerationStatic.Declaration).Call(Configurator.PrivateMethodPrefix + "ProxyInit",
                        parameters => parameters.AddParameterValue(null));
                });
        }

        public void CreateStaticInfo(MType model, IGClass cls)
        {
            cls.AddField(GTypeJ4N.ProxyInfo, Configurator.PrivateFieldPrefix + "TypeInfo",
                ti =>
                {
                    ti.IsStatic = true;
                    //ti.IsPrivate = !isinternal;
                });

            cls.AddField(GTypeJ4N.SystemIType, Configurator.PrivateFieldPrefix + "Type",
                cl =>
                {
                    cl.IsStatic = true;
                    //cl.IsPrivate = !isinternal;
                });

            if (model.IsClr)
            {
                cls.AddMethod(GTypeJ4N.SystemIType, "typeOf",
                    typeOf =>
                    {
                        typeOf.IsStatic = true;
                        typeOf.Return()
                            .TextExpression("j4n_Type");
                    });
            }
            else
            {
                cls.AddMethod(GTypeJ4N.SystemIType, "typeOf",
                    _class =>
                    {
                        _class.IsStatic = true;
                        _class.Return()
                            .TextExpression("j4n_Type");
                    });
            }
        }

        public void CreateEnvConstructor(MType model, IGClass cls)
        {
            cls.AddConstructor(
                envConstructor =>
                {
                    envConstructor.AddParameter(GTypeJvm.Long, Configurator.PrivateParamPrefix + "handle");
                    envConstructor.AddParameter(GTypeJ4N.ClrInstanceInfo, Configurator.PrivateParamPrefix + "instanceInfo");
                    envConstructor.IsPublic = false;
                    envConstructor.IsProtected = !model.IsSealed && !model.IsInterface;
                    envConstructor.IsPrivate = model.IsSealed;
                    envConstructor.CallConstructorBase(
                        baseCall =>
                        {
                            baseCall.AddParameterVariable(Configurator.PrivateParamPrefix + "handle");
                            baseCall.AddParameterVariable(Configurator.PrivateParamPrefix + "instanceInfo");
                        });
                });
        }

        public IGMethod CreateProxyFactory(MType model, IGClass cls, MTypeView view, Action<IGMethod> with = null)
        {
            IGMethod res=null;

            cls.AddClass(Configurator.PrivateMethodPrefix + "ProxyFactory",
                pf =>
                    {
                        pf.Implements.Add(GTypeJ4N.IClrProxyFactory);
                        pf.IsPrivate = true;
                        pf.IsStatic = true;
                        pf.AddMethod(GTypeJ4N.IClrProxy, "CreateInstance",
                            method =>
                                {
                                    method.AddParameter(GTypeJvm.Long, Configurator.PrivateParamPrefix + "handle");
                                    //method.AddParameter(GTypeJ4N.SystemIType, Configurator.PrivateParamPrefix + "instanceType");
                                    var proxy = JvmProxyDeclaration(model, view);
                                    method.Return().New(proxy, 
                                        parameters =>
                                            {
                                                parameters.AddParameterVariable(Configurator.PrivateParamPrefix + "handle");
                                                parameters.AddParameter().Cast(GTypeJ4N.ClrInstanceInfo).AddParameterNull();
                                                /*parameters.AddParameter().New(GTypeJ4N.ClrInstanceInfo, ii =>
                                                {
                                                    if(model.IsSealed)
                                                    {
                                                        ii.AddParameterVariable("j4n_TypeInfo.CLRApi");
                                                    }
                                                    else
                                                    {
                                                        ii.AddParameterVariable(Configurator.PrivateParamPrefix + "instanceType");
                                                    }
                                                    ii.AddParameterVariable("j4n_TypeInfo");
                                                });*/
                                            });
                                    if (with != null) with(method);
                                    res = method;
                                });
                    });

            return res;
        }

        protected virtual UTypeUsage JvmProxyDeclaration(MType model, MTypeView view)
        {
            UTypeUsage proxy = view.Declaration.DeepClone(false, model);
            return proxy;
        }

        public void CreateProxyInit(MType model, GeneratorTarget target)
        {
            IGClass cls;
            if (!model.Targets.Classes.TryGetValue(target, out cls))
            {
                return;
            }

            var staticUsage = new UTypeUsage(model, model) {MakeStaticName = true};
            string staticClrName = GTypeUsageGenerator.CreateParametrizedName(staticUsage, TypeArgs.NameNamespace|TypeArgs.Reflection, false);

            cls.AddMethod(GTypeClr.Void, Configurator.PrivateMethodPrefix + "ProxyInit",
                          method =>
                              {
                                  method.AddParameter(GTypeJ4N.INJEnv, "env");
                                  method.IsStatic = true;
                                  method.IsSynchronized = true;
                                  method.ReturnType = GTypeJ4N.ProxyInfo;
                                  method.IsPublic = false;
                                  method.IsProtected = true;
                                  method.IsInternal = true;

                                  method.AddTextLine("if (j4n_TypeInfo==null)");
                                  method.BlockStatement(
                                      cnd => cnd.Assign("j4n_TypeInfo").CallStatic(GTypeJ4N.Registry, "registerProxy",
                                          registerProxy =>
                                          {
                                              registerProxy.AddParameterVariable("env");

                                              registerProxy.AddParameter()
                                                  .Value(staticClrName + ", ")
                                                  .Operator("+")
                                                  .TextExpression(model.ProjectRegistration.ModuleNamespace + "." +
                                                         model.ProjectRegistration.ModuleName + ".assemblyName")
                                                  ;
                                              RegisterProxyParams(model, registerProxy);
                                          }));
                                  method.Return().TextExpression("j4n_TypeInfo");
                              });
        }

        protected virtual void RegisterProxyParams(MType model, IGCallMethodExpression registerProxy)
        {
            registerProxy.AddParameter().TypeOf(model.JvmGeneration.Declaration);
            registerProxy.AddParameter().TypeOf(model.JvmGenerationStatic.Declaration);
            registerProxy.AddParameter().TypeOf(model.JvmGenerationProxy.Declaration);

            var staticUsage = new UTypeUsage(model, model) {MakeStaticName = true};
            string staticJvmName = GTypeUsageGenerator.CreateParametrizedName(staticUsage, TypeArgs.NameNamespace, true);

            var factory = staticJvmName + "." + Configurator.PrivateMethodPrefix + "ProxyFactory";
            registerProxy.AddParameter().New(new GTextType(factory));
        }

    }
}
