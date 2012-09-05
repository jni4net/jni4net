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
using System.Text;
using Microsoft.Practices.Unity;
using com.jni4net.config;
using com.jni4net.proxygen.Services.Compilation;
using polyglottos;
using polyglottos.csharp;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using polyglottos.snippets;

namespace com.jni4net.proxygen.Services.Generators
{
    public partial class BaseCSharpGenerator : BaseGenerator
    {
        [Dependency("GProjectCSharp")]
        public IGProject GProjectCSharp { get; set; }

        [Dependency("GTypeUsageGenerator")]
        public GTypeUsageGenerator GTypeUsageGenerator { get; set; }

        [Dependency]
        public ProjectsGenerator ProjectsGenerator { get; set; }

        public IGClassContainer GenerateClrContainer(MType model, MTypeView view, Action<IGClassContainer> with = null)
        {
            IGClassContainer container=null;
            if (!model.IsNested || (model.IsNested && model.IsJvm && model.Exploration.EnclosingType.IsInterface))
            {
                string clrNamespace = GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model,model),TypeArgs.Namespace | TypeArgs.Filename, false );
                string clrName = GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model, model), TypeArgs.Name | TypeArgs.Filename, false);
                var fileName = model.ProjectRegistration.GetClrFileName(model.TypeRegistration, clrNamespace, clrName);
                model.ProjectRegistration.CsharpFiles.Add(fileName);

                GProjectCSharp.AddFile(fileName,
                    file =>
                        {
                            var reg = CreateGeneratedRegion(file);
                            if (clrNamespace != null)
                            {
                                container = reg.AddNamespace(NTypeName.ReplaceKeywords(clrNamespace, false));
                            }
                            else
                            {
                                container = reg;
                            }
                            if (model.IsClr && model.IsInterface)
                            {
                                model.Targets.AddFile(file, GeneratorTarget.JvmBacking);
                            }
                            else
                            {
                                model.Targets.AddFile(file, GeneratorTarget.ClrApi);
                            }
                            model.Targets.AddFile(file, GeneratorTarget.ClrProxy);
                        });
            }
            else
            {
                MType enclosingModel = view.EnclosingType;
                var target = model.IsClr ? GeneratorTarget.ClrStatic : GeneratorTarget.ClrApi;
                container = enclosingModel.Targets.Classes[target];
            }
            if (with != null) with(container);
            return container;
        }

        public static IGFileRegion CreateGeneratedRegion(IGFile file)
        {
            file.AddComment("This code was generated using jni4net. See http://jni4net.sourceforge.net/");
            IGFileRegion gFileRegion = file.AddRegion("Component Designer generated code",
                region =>
                    {
                        region.AddComment("ReSharper disable InconsistentNaming");
                        region.AddComment("ReSharper disable CheckNamespace");
                        region.AddComment("ReSharper disable RedundantNameQualifier");
                        region.AddComment("ReSharper disable RedundantCast");
                        region.AddComment("ReSharper disable RedundantCommaInArrayInitializer");
                        region.AddComment("ReSharper disable RedundantExplicitArrayCreation");
                        region.AddComment("ReSharper disable UnassignedField.Local");
                        region.AddComment("ReSharper disable UnusedMember.Local");
                        region.AddComment("ReSharper disable PartialTypeWithSinglePart");
                        region.AddComment("ReSharper disable RedundantExtendsListEntry");
                        region.AddComment("ReSharper disable SuggestUseVarKeywordEvident");
                        region.AddComment("ReSharper disable PossibleMultipleEnumeration");
                        region.AddComment("ReSharper disable MemberHidesStaticFromOuterClass");
                        region.AddComment("ReSharper disable UnusedParameter.Local");
                        region.AddComment("ReSharper disable UnusedMember.Global");
                        region.AddTextLine("#pragma warning disable 109");
                        region.AddTextLine("#pragma warning disable 649");
                        region.AddTextLine("#pragma warning disable 618");
                    });
            return gFileRegion;
        }

        public IGClass GenerateClrClass(MType model, MTypeView view, IGClassContainer container, Action<IGClass> with = null)
        {
            return container.AddClass(model.ClrLocalName, view.Declaration,
                cls =>
                {
                    cls.AddAttribute(GTypeJ4N.J4NProxyAttribute).AddParameter().TypeOf(model.ClrGenerationStatic.Declaration);
                    cls.CustomData = view;
                    cls.IsPartial = true;
                    cls.IsInterface = model.IsInterface;
                    cls.IsSealed = model.IsSealed && !model.IsInterface;
                    cls.Extends = view.Base;
                    foreach (var ifc in view.Interfaces)
                    {
                        if (!ifc.IsClrSkip)
                        {
                            cls.Implements.Add(ifc);
                        }
                    }
                    if (with != null) with(cls);
                });
        }

        public void CreateStaticInfo(MType model, IGClass cls)
        {
            bool isinternal = model.IsInterface || model.IsGeneric;
            bool isnew = isinternal && (!model.IsInterface || (model.Exploration.Base != null && model.Exploration.Base.Root.IsGeneric));
            cls.AddField(GTypeJ4N.ProxyInfo, Configurator.PrivateFieldPrefix + "TypeInfo",
                ti =>
                {
                    ti.IsStatic = true;
                    ti.IsPrivate = !isinternal;
                    ti.IsInternal = isinternal;
                    ti.IsNew = isnew;
                });

            cls.AddField(GTypeJ4N.JavaLangIClass, Configurator.PrivateFieldPrefix + "Class",
                cl =>
                {
                    cl.IsStatic = true;
                    cl.IsPrivate = !isinternal;
                    cl.IsInternal = isinternal;
                    cl.IsNew = isnew;
                });

            cls.AddField(GTypeClr.IntPtrArray, Configurator.PrivateFieldPrefix + "Members",
                mi =>
                {
                    mi.IsStatic = true;
                    mi.IsPrivate = !isinternal;
                    mi.IsInternal = isinternal;
                    mi.IsNew = isnew;
                    mi.Static(GTypeJ4N.Registry).CallField("dummyMethods");
                });

            if (model.IsJvm)
            {
                cls.AddProperty(GTypeJ4N.JavaLangIClass, "_class",
                    _class =>
                    {
                        _class.IsStatic = true;
                        _class.IsNew = !model.IsRoot && !model.IsInterface;
                        _class.AddGetter()
                            .Return()
                            .TextExpression("j4n_Class");
                    });
            }
            else
            {
                cls.AddProperty(GTypeJ4N.JavaLangIClass, "_class",
                    _class =>
                    {
                        _class.IsStatic = true;
                        _class.IsNew = !model.IsRoot && !model.IsInterface;
                        _class.AddGetter()
                            .Return()
                            .TextExpression("j4n_Class");
                    });
            }
        }

        public IGConstructor CreateEnvConstructor(MType model, IGClass cls, MTypeView view, Action<IGConstructor> with = null)
        {
            return cls.AddConstructor(
                envConstructor =>
                {
                    envConstructor.AddParameter(GTypeJ4N.JNIEnv, Configurator.PrivateParamPrefix + "env");
                    envConstructor.AddParameter(GTypeJ4N.JNIHandle, Configurator.PrivateParamPrefix + "handle");
                    envConstructor.AddParameter(GTypeJ4N.JvmInstanceInfo, Configurator.PrivateParamPrefix + "instanceInfo");
                    envConstructor.IsProtected = !model.IsSealed;
                    envConstructor.IsInternal = model.IsGeneric;
                    envConstructor.IsPrivate = model.IsSealed;
                    envConstructor.CallConstructorBase(
                        parameters =>
                        {
                            parameters.AddParameterVariable(Configurator.PrivateParamPrefix + "env");
                            parameters.AddParameterVariable(Configurator.PrivateParamPrefix + "handle");
                            parameters.AddParameterVariable(Configurator.PrivateParamPrefix + "instanceInfo");
                        });
                    if (with != null) with(envConstructor);
                });
        }

        public IGMethod CreateProxyFactory(MType model, IGClass cls, MTypeView view, Action<IGMethod> with=null)
        {
            return cls.AddMethod(GTypeJ4N.IJvmProxy, Configurator.PrivateMethodPrefix + "ProxyFactory",
                method =>
                {
                    method.IsStatic = true;
                    method.IsInternal = true;
                    method.IsNew = !model.IsRoot;
                    method.AddParameter(GTypeJ4N.JNIEnv, Configurator.PrivateParamPrefix + "env");
                    method.AddParameter(GTypeClr.IntPtr, Configurator.PrivateParamPrefix + "handle");
                    method.AddParameter(GTypeJ4N.JvmInstanceInfo, Configurator.PrivateParamPrefix + "instanceInfo");
                    method.Return().New(view.Declaration,
                        parameters =>
                        {
                            parameters.AddParameterVariable(Configurator.PrivateParamPrefix + "env");
                            parameters.AddParameterVariable(Configurator.PrivateParamPrefix + "env")
                                .Call("NewGlobalRef")
                                .AddParameterVariable(Configurator.PrivateParamPrefix + "handle");
                            parameters.AddParameterVariable(Configurator.PrivateParamPrefix + "instanceInfo");
                        });
                    if (with != null) with(method);
                });

        }

        public void CreateStaticConstructor(MType model, IGClass cls)
        {
            cls.AddConstructor(
                staticConstructor =>
                {
                    staticConstructor.IsStatic = true;
                    staticConstructor.IsPublic = false;
                    if(model!=KnownTypes.JavaLangObject
                        && model != KnownTypes.JavaLangClass
                        && model != KnownTypes.JavaLangThrowable
                        && model != KnownTypes.JavaLangString)
                    {
                        staticConstructor.CallStatic(
                            new GTextType(model.ProjectRegistration.ModuleNamespace + "." +
                                          model.ProjectRegistration.ModuleName + "j4n") { IsLocalName = false }, "InitModule");
                    }
                    UTypeUsage bse = model.Exploration.Base;
                    if (bse!=null && bse.Root.IsProtected)
                    {
                        //java.lang.AbstractStringBuilder
                        bse = bse.Root.TargetGeneration.Base;
                    }
                    const string initClrProxy = "InitClrProxy";
                    const string initJvmProxy = "InitJvmProxy";

                    if (bse != null)
                    {
                        if (bse.Root.IsInterface || bse.Root.IsJvm)
                        {
                            staticConstructor.CallStatic(GTypeJ4N.Registry, initJvmProxy,
                                call => call.AddParameter().TypeOf(new UTypeUsage(bse.Root,model) { MakeStaticName = true}));
                        }
                        if (bse.Root.IsInterface || bse.Root.IsClr)
                        {
                            staticConstructor.CallStatic(GTypeJ4N.Registry, initClrProxy,
                                call => call.AddParameter().TypeOf(new UTypeUsage(bse.Root, model) { MakeStaticName = true }));
                        }
                    }
                    if (!model.IsInterface)
                    {
                        foreach (var itfc in model.Exploration.Interfaces)
                        {
                            UTypeUsage ifc = itfc;
                            if (!ifc.IsClrSkip && (ifc.Root.IsInterface || ifc.Root.IsJvm))
                            {
                                staticConstructor.CallStatic(GTypeJ4N.Registry, initJvmProxy,
                                    call => call.AddParameter().TypeOf(new UTypeUsage(ifc.Root, model) { MakeStaticName = true }));
                            }
                            if (!ifc.IsJvmSkip && (ifc.Root.IsInterface || ifc.Root.IsClr))
                            {
                                staticConstructor.CallStatic(GTypeJ4N.Registry, initClrProxy,
                                    call => call.AddParameter().TypeOf(new UTypeUsage(ifc.Root, model) { MakeStaticName = true }));
                            }
                        }
                    }

                    if (model.IsInterface || model.IsJvm)
                    {
                        staticConstructor.CallStatic(GTypeJ4N.Registry, initJvmProxy,
                            call => call.AddParameter().TypeOf(model.ClrGenerationStatic.Declaration));
                    }
                    if (model.IsInterface || model.IsClr)
                    {
                        staticConstructor.CallStatic(GTypeJ4N.Registry, initClrProxy,
                            call => call.AddParameter().TypeOf(model.ClrGenerationStatic.Declaration));
                    }
                });
        }

        public void CreateProxyInit(MType model, GeneratorTarget target)
        {
            IGClass cls;
            if (!model.Targets.Classes.TryGetValue(target, out cls))
            {
                return;
            }

            var staticUsage = new UTypeUsage(model, model) { MakeStaticName = true };
            string staticClrName = GTypeUsageGenerator.CreateParametrizedName(staticUsage, TypeArgs.NameNamespace, false);
            var apiUsage = new UTypeUsage(model, model);
            string clrName = GTypeUsageGenerator.CreateParametrizedName(apiUsage, TypeArgs.NameNamespace, false);
            string jvmName = GTypeUsageGenerator.CreateParametrizedName(apiUsage, TypeArgs.NameNamespace | TypeArgs.Reflection, true);
            if(model.IsInterface || model.IsClr)
            {
                model.ProjectRegistration.ClrProxies.Add(new ModuleRegistration { CLRStaticApi = staticClrName, CLRApi = clrName, JVMApi = jvmName });
            }
            if (model.IsInterface || model.IsJvm)
            {
                model.ProjectRegistration.JvmProxies.Add(new ModuleRegistration { CLRStaticApi = staticClrName, CLRApi = clrName, JVMApi = jvmName });
            }

            var sb = new StringBuilder("new global::net.sf.jni4net.core.MemberId[]{\r\n");

            int membersRegistration = 0;
            foreach (var member in model.TargetGenerationProxy.Members)
            {
                string reg;
                if (member.IsJvmSkip)
                {
                    reg = "                        null, // #" + membersRegistration + " IsJvmSkip: " + member.Name + "\r\n";
                }
                else if (model.IsInterface && member.IsStatic)
                {
                    //TODO move to static class
                    reg = "                        null, // #"+membersRegistration+" interface static: " + member.Name + "\r\n";
                }
                else
                {
                    reg = "                        new global::net.sf.jni4net.core.MemberId(\""
                                 + (member.IsConstructor ? "<init>" : member.JvmName)
                                 + "\",\""
                                 + member.GetJvmSignature(true)
                                 + (member.IsField ? "\", true" : "\", false")
                                 + (member.IsStatic ? ", true" : ", false")
                                 + "), // #" + membersRegistration + " " + member.GetClrSignature(true) + "\r\n";
                }
                    sb.Append(reg);
                membersRegistration++;
            }

            sb.Append("                        }");

            cls.AddMethod(GTypeJ4N.ProxyInfo, Configurator.PrivateMethodPrefix + "ProxyInit",
                method =>
                {
                    method.AddParameter(GTypeJ4N.ProxyInfo, "proxyInfo");
                    method.IsStatic = true;
                    method.IsInternal = true;
                    method.IsNew = !model.IsRoot && !model.IsInterface;
                    string name = model == KnownTypes.ClrVoid ? "void" : GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model, model) { IsGeneric = model.IsGeneric }, TypeArgs.NameNamespaceArgumentsPrefix, false);

                    method.AddTextLine("lock (typeof(" + name + "))");
                    method.BlockStatement(
                        lck =>
                        {
                            lck.AddTextLine("if (j4n_TypeInfo==null)");
                            lck.BlockStatement(
                                cnd =>
                                {
                                    cnd.Assign("j4n_TypeInfo").TextExpression("proxyInfo");
                                    cnd.Assign("proxyInfo.IsCLR").Value(model.IsClr);
                                    cnd.Assign("proxyInfo.IsInterface").Value(model.IsInterface);
                                    cnd.Assign("proxyInfo.JVMApiName").Value(model.JvmReflectionName);
                                    if (model.IsClr || model.IsInterface)
                                    {
                                        cnd.Assign("proxyInfo.JVMProxyName").Value(GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model, model) {MakeProxyName = true},TypeArgs.NameNamespace | TypeArgs.Reflection, true));
                                    }
                                    cnd.Assign("proxyInfo.JVMStaticApiName").Value(GTypeUsageGenerator.CreateParametrizedName(new UTypeUsage(model, model) { MakeStaticName = true }, TypeArgs.NameNamespace | TypeArgs.Reflection, true));
                                    RegisterProxyParams(model, cnd);
                                    cnd.Assign("proxyInfo.MemberIds").TextExpression(sb.ToString());
                                });
                            lck.Return().TextExpression("j4n_TypeInfo");
                        });
                });

        }

        protected virtual void RegisterProxyParams(MType model, IGBlockStatement registerProxy)
        {
            registerProxy.Assign("proxyInfo.CLRApi").TypeOf(model.ClrGeneration.Declaration);
            registerProxy.Assign("proxyInfo.CLRStaticApi").TypeOf(model.ClrGenerationStatic.Declaration);
            if(model.IsJvm || model.IsInterface)
            {
                registerProxy.Assign("proxyInfo.CLRProxy").TypeOf(model.ClrGenerationProxy.Declaration);
                registerProxy.Assign("proxyInfo.JVMProxyFactory").Static(model.ClrGenerationProxy.Declaration).
                    AddTextSnippet(Configurator.PrivateMethodPrefix + "ProxyFactory");
            }
        }

    }

    public static class GeneratorRocks
    {
        public static IGUsingStatement AddLocalFrame(this IGStatementContainer self, int frameSize, Action<IGUsingStatement> with = null)
        {
            return self.UsingNew(GTypeJ4N.LocalFrame,
                frame =>
                    {
                        frame.AddParameterVariable("j4n_env");
                        frame.AddParameterValue(frameSize);
                    }, with);
        }
    }

}
