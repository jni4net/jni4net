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
using polyglottos;
using polyglottos.csharp;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;

namespace com.jni4net.proxygen.Services.Generators
{
    partial class BaseCSharpGenerator
    {
        public void GenerateMembers(MType model, GeneratorTarget target)
        {
            IGClass cls;
            if (!model.Targets.Classes.TryGetValue(target, out cls))
            {
                return;
            }
            var view = (MTypeView)cls.CustomData;
            if (view != null)
            {
                int membersRegistration = 0;
                foreach (MMember member in view.Members)
                {
                    if (member.IsClrSkip)
                    {
                    }
                    else if (model.IsInterface && member.IsStatic)
                    {
                        //TODO move to static class
                    }
                    else
                    {
                        CreateMember(model, target, member, cls, membersRegistration);
                    }
                    membersRegistration++;
                }
            }
        }

        private void CreateMember(MType model, GeneratorTarget target, MMember member, IGClass cls, int membersRegistration)
        {
            IGMember m;
            if (member.IsField)
            {
                m = CreateField(model, member, cls, membersRegistration);
            }
            else
            {
                IGMethod gmethod;
                if (member.IsEvent)
                {
                    gmethod = CreateEvent(model, member, cls, membersRegistration);
                } 
                else if (member.IsProperty)
                {
                    bool addParams = true;
                    if (member.Property.Get == member)
                    {
                        gmethod = CreateGetter(model, member, cls, membersRegistration, out addParams);
                    }
                    else
                    {
                        gmethod = CreateSetter(model, member, cls, membersRegistration, out addParams);
                    }

                    if (addParams)
                    {
                        foreach (UTypeUsage param in member.Params)
                        {
                            if (param.MethodParameterName != "value")
                            {
                                gmethod.AddParameter(param, NTypeName.ReplaceKeywords(param.MethodParameterName, false));
                            }
                        }
                    }
                }
                else
                {
                    if (member.IsConstructor)
                    {
                        gmethod = CreateConstructor(model, member, cls, membersRegistration);
                    }
                    else
                    {
                        gmethod = CreateMethod(model, member, cls, membersRegistration);
                    }
                    foreach (UTypeUsage param in member.Params)
                    {
                        gmethod.AddParameter(param, NTypeName.ReplaceKeywords(param.MethodParameterName, false));
                    }
                }
                gmethod.ExplicitInterface = member.ExplicitInterface;

                m = gmethod;
            }
            m.With(gmember =>
            {
                gmember.IsInterface = model.IsInterface && (target == GeneratorTarget.ClrApi || target == GeneratorTarget.ClrApiWildOut);
                gmember.IsStatic = member.IsStatic;
                gmember.IsVirtual = member.IsVirtual && !model.IsInterface;
                gmember.IsSealed = member.IsSealed;
                gmember.IsPublic = member.IsPublic && member.ExplicitInterface == null;
                gmember.HideBody = gmember.IsInterface;
                gmember.CustomData = member;

                gmember.AddXmlDoc(" <signature>#" + membersRegistration + " " + member.GetJvmSignature(true) + " " + member.GetClrSignature(true) + "</signature>");

                member.Targets[target] = gmember;
            });
        }

        private IGMethod CreateGetter(MType model, MMember member, IGClass cls, int membersRegistration, out bool addParams)
        {
            addParams = false;
            var property = member.Property.CustomData as IGProperty;
            if (property==null)
            {
                property = cls.AddProperty(member.Return, NTypeName.ReplaceKeywords(member.Property.Name, false));
                property.IsIndexer = (member.Params.Count > 0);
                member.Property.CustomData = property;
                addParams = true;
            }

            property.AddGetter(
                method => CreateMethodBody(model, member, method, membersRegistration)
                );
            return property;
        }

        private IGMethod CreateEvent(MType model, MMember member, IGClass cls, int membersRegistration)
        {
            var gEvent = member.Property.CustomData as IGEvent;
            if (gEvent == null)
            {
                gEvent = cls.AddEvent(member.Params[member.Params.Count - 1], NTypeName.ReplaceKeywords(member.Property.Name, false));
                member.Property.CustomData = gEvent;
            }
            if(member.Property.Get == member)
            {
                gEvent.AddAdder(
                    method => CreateMethodBody(model, member, method, membersRegistration)
                    );
            }
            else
            {
                gEvent.AddRemover(
                    method => CreateMethodBody(model, member, method, membersRegistration)
                    );
            }
            return gEvent;
        }

        private IGMethod CreateSetter(MType model, MMember member, IGClass cls, int membersRegistration, out bool addParams)
        {
            addParams = false;
            var property = member.Property.CustomData as IGProperty;
            if (property == null)
            {
                property = cls.AddProperty(member.Params[member.Params.Count - 1], NTypeName.ReplaceKeywords(member.Property.Name, false));
                property.IsIndexer = (member.Params.Count > 1);
                member.Property.CustomData = property;
                addParams = true;
            }

            property.AddSetter(
                method => CreateMethodBody(model, member, method, membersRegistration)
                );
            return property;
        }

        private IGMethod CreateMethod(MType model, MMember member, IGClass cls, int membersRegistration)
        {
            return cls.AddMethod(member.Return, NTypeName.ReplaceKeywords(member.Name, false),
                method => CreateMethodBody(model, member, method, membersRegistration)
                );
        }

        private void CreateMethodBody(MType model, MMember member, IGStatementContainer method, int membersRegistration)
        {
            if (member.IsJvmSkip)
            {
                method.ThrowNotImplemented();
                return;
            }
            method.Declare(GTypeJ4N.JNIEnv, "j4n_env").Static(GTypeJ4N.JNIEnv).TextExpression("ThreadEnv");
            method.AddLocalFrame(member.Params.Count*2 + 10,
                                 frame =>
                                     {
                                         bool refOut = DeclareRefOut(member, frame);
                                         IGStatementContainer refOutFrame = frame;
                                         if(refOut)
                                         {
                                             frame.AddTextLine("try");
                                             refOutFrame = frame.BlockStatement();
                                         }
                                         var callStatement = member.IsVoid
                                                                 ? (IGExpressionStartContainer) refOutFrame
                                                                 : refOutFrame.Return();

                                         AddMethodCall(callStatement, member, methodCall =>
                                            {
                                                if (member.IsStatic)
                                                {
                                                    methodCall.AddParameter().Static(
                                                        model.ClrGenerationStatic.Declaration).TextExpression(
                                                            "j4n_Class");
                                                }
                                                else
                                                {
                                                    methodCall.AddParameter().TextExpression("this");
                                                }
                                                methodCall.AddParameter().Static(
                                                    model.ClrGenerationStatic.Declaration).TextExpression(
                                                        "j4n_Members").Indexer(
                                                            indexer =>
                                                            indexer.AddParameterValue(membersRegistration));
                                                for (int i = 0; i < member.Params.Count; i++)
                                                {
                                                    UTypeUsage param = member.Params[i];
                                                    string jvmAPi = member.Pair.Params[i].Root.JvmReflectionName;
                                                    ConvertToValue(param, methodCall.AddParameter(), jvmAPi);
                                                }
                                            });

                                         if (refOut)
                                         {
                                             frame.AddTextLine("finally");
                                             refOutFrame = frame.BlockStatement();
                                             ConsumeRefOut(member, refOutFrame);
                                         }
                                     });
        }

        private IGConstructor CreateConstructor(MType model, MMember member, IGClass cls, int membersRegistration)
        {
            return cls.AddConstructor(
                method =>
                {
                    if (!model.IsRoot)
                    {
                        method.CallConstructorBase
                            (
                                baseCall =>
                                {
                                    baseCall.AddParameter().Cast(GTypeJ4N.JNIEnv).AddParameterNull();
                                    baseCall.AddParameter().Static(GTypeJ4N.JNIHandle).TextExpression("Zero");
                                    baseCall.AddParameter().New(GTypeJ4N.JvmInstanceInfo,ii=>
                                        {
                                            ii.AddParameterVariable("j4n_TypeInfo.JVMApi");
                                            ii.AddParameterVariable("j4n_TypeInfo");
                                        });
                                });
                    }
                    if (member.IsJvmSkip)
                    {
                        method.ThrowNotImplemented();
                        return;
                    }
                    method.Declare(GTypeJ4N.JNIEnv, "j4n_env").Static(GTypeJ4N.JNIEnv).TextExpression("ThreadEnv");
                    method.AddLocalFrame(member.Params.Count * 2 + 10,
                        frame => frame.Assign("j4n_handle").Call("j4n_env.NewObjectG",
                            newObject =>
                            {
                                newObject.AddParameter().Static(model.ClrGenerationStatic.Declaration).TextExpression("j4n_Class");
                                newObject.AddParameter().Static(model.ClrGenerationStatic.Declaration).TextExpression("j4n_Members").Indexer(
                                    indexer =>
                                    indexer.AddParameterValue(membersRegistration));
                                for (int i = 0; i < member.Params.Count; i++)
                                {
                                    UTypeUsage param = member.Params[i];
                                    string jvmAPi = member.Pair.Params[i].Root.JvmReflectionName;
                                    ConvertToValue(param, newObject.AddParameter(), jvmAPi);
                                }
                            }));
                });
        }

        private IGProperty CreateField(MType model, MMember member, IGClass cls, int membersRegistration)
        {
            return cls.AddProperty(member.Return, NTypeName.ReplaceKeywords(member.Name, false),
                property =>
                {
                    property.IsStatic = member.IsStatic;
                    property.AddGetter(
                        getter =>
                        {
                            if (member.IsJvmSkip)
                            {
                                getter.ThrowNotImplemented();
                                return;
                            }
                            getter.Declare(GTypeJ4N.JNIEnv, "j4n_env").Static(GTypeJ4N.JNIEnv).TextExpression("ThreadEnv");
                            getter.AddLocalFrame(member.Params.Count * 2 + 10,
                                frame => AddFieldGet(frame.Return(), member,
                                    fieldCall =>
                                    {
                                        if (member.IsStatic)
                                        {
                                            fieldCall.AddParameter().Static(model.ClrGenerationStatic.Declaration).TextExpression("j4n_Class");
                                        }
                                        else
                                        {
                                            fieldCall.AddParameter().TextExpression("this");
                                        }
                                        fieldCall.AddParameter().Static(model.ClrGenerationStatic.Declaration).TextExpression("j4n_Members").Indexer(
                                            indexer =>
                                            indexer.AddParameterValue(membersRegistration));
                                    }));
                        });

                    if (!member.IsFinal)
                    {
                        property.AddSetter(setter =>
                        {
                            setter.ThrowNotImplemented();
                        });
                    }
                });
        }

        private void ConvertToValue(UTypeUsage param, IGCallParameter callParam, string jvmAPi)
        {
            if (param.IsOut)
            {
                callParam.AddTextSnippet(Configurator.PrivateVarPrefix + "out_" + param.MethodParameterName);
                return;
            }
            if (param.IsRef)
            {
                callParam.AddTextSnippet(Configurator.PrivateVarPrefix + "ref_" + param.MethodParameterName);
                return;
            }

            bool isPrimitive;
            var type = GetConversionType(param, out isPrimitive);
            IGCallMethod convert = callParam.CallStatic(type, "ToValue");

            if (!isPrimitive)
            {
                convert.AddParameterVariable("j4n_env");
            }
            convert.AddParameterVariable(NTypeName.ReplaceKeywords(param.MethodParameterName,false));
            if (!param.Root.IsSealed || !param.Root.IsMapped)
            {
                convert.AddParameterValue(jvmAPi);
            }
        }

        private IGType GetConversionType(UTypeUsage param, out bool isPrimitive)
        {
            isPrimitive = true;
            IGType type;
            MType root = param.Root;
            if (root == KnownTypes.ClrBool)
            {
                type = GTypeJ4N.ConvertBoolean;
            }
            else if (root == KnownTypes.ClrByte)
            {
                type = GTypeJ4N.ConvertByte;
            }
            else if (root == KnownTypes.ClrChar)
            {
                type = GTypeJ4N.ConvertChar;
            }
            else if (root == KnownTypes.ClrShort)
            {
                type = GTypeJ4N.ConvertShort;
            }
            else if (root == KnownTypes.ClrInt)
            {
                type = GTypeJ4N.ConvertInt;
            }
            else if (root == KnownTypes.ClrLong)
            {
                type = GTypeJ4N.ConvertLong;
            }
            else if (root == KnownTypes.ClrDouble)
            {
                type = GTypeJ4N.ConvertDouble;
            }
            else if (root == KnownTypes.ClrFloat)
            {
                type = GTypeJ4N.ConvertFloat;
            }
            else if (root == KnownTypes.SystemString)
            {
                type = GTypeJ4N.ConvertString;
                isPrimitive = false;
            }
            else if (root.IsSealed && root.IsMapped)
            {
                type = GTypeJ4N.ConvertSealed;
                isPrimitive = false;
            }
            else
            {
                type = GTypeJ4N.ConvertAbstract;
                isPrimitive = false;
            }
            if (param.IsArray)
            {
                isPrimitive = false;
            }
            return type;
        }

        private IGCallMethodExpression AddFieldGet(IGExpressionStartContainer self, MMember member, Action<IGCallMethodExpression> result = null)
        {
            return AddMemberCall(self, member, "Get", "Field", result);
        }

        private IGCallMethodExpression AddMethodCall(IGExpressionStartContainer self, MMember member, Action<IGCallMethodExpression> result = null)
        {
            return AddMemberCall(self, member, "Call", "Method", result);
        }

        private IGCallMethodExpression AddMemberCall(IGExpressionStartContainer self, MMember member, string prefix, string postfix, Action<IGCallMethodExpression> result = null)
        {
            UTypeUsage ga;
            string callName;
            bool isPrimitive1 = true;
            string convertName = "";
            if (member.Return.Root == KnownTypes.ClrBool)
            {
                callName = "Boolean";
            }
            else if (member.Return.Root == KnownTypes.ClrByte)
            {
                callName = "Byte";
            }
            else if (member.Return.Root == KnownTypes.ClrChar)
            {
                callName = "Char";
            }
            else if (member.Return.Root == KnownTypes.ClrShort)
            {
                callName = "Short";
            }
            else if (member.Return.Root == KnownTypes.ClrInt)
            {
                callName = "Int";
            }
            else if (member.Return.Root == KnownTypes.ClrLong)
            {
                callName = "Long";
            }
            else if (member.Return.Root == KnownTypes.ClrDouble)
            {
                callName = "Double";
            }
            else if (member.Return.Root == KnownTypes.ClrFloat)
            {
                callName = "Float";
            }
            else if (member.Return.Root == KnownTypes.ClrVoid)
            {
                callName = "Void";
            }
            else if (member.Return.Root == KnownTypes.SystemString)
            {
                callName = "String";
            }
            else if (member.Return.Root == KnownTypes.JavaLangClass)
            {
                callName = "Sealed";
                convertName = "Class";
                isPrimitive1 = false;
            }
            else if (member.Return.Root.IsSealed && member.Return.Root.IsMapped)
            {
                callName = "Sealed";
                convertName = "Sealed";
                isPrimitive1 = false;
            }
            else
            {
                callName = "Abstract";
                convertName = "Abstract";
                isPrimitive1 = false;
            }
            bool isGeneric = !isPrimitive1;
            ga = member.Return;
            if (member.Return.IsArray)
            {
                ga = member.Return.DeepClone(false, member.Owner);
                convertName = callName + ".ToCLRArray";
                //TODO more complex array rank vs jagged
                // flatten for now
                for (int i = 0; i < ga.ArrayRank.Length; i++)
                {
                    if (ga.ArrayRank[i] > 0)
                    {
                        convertName += ga.ArrayRank[i];
                        ga.ArrayRank[i] = 0;
                    }
                    else
                    {
                        break;
                    }
                }

                isPrimitive1 = false;
                callName = "Object";
            }
            else
            {
                convertName += ".ToCLR";
            }

            if (!isPrimitive1)
            {
                callName = "Object";
            }
            if (member.IsStatic)
            {
                callName = prefix + "Static" + callName + postfix;
            }
            else
            {
                callName = prefix + callName + postfix;
            }
            var isPrimitive = isPrimitive1;

            if (isPrimitive)
            {
                return self.Call("j4n_env." + callName, result);
            }

            return self.Call("global::net.sf.jni4net.core.Convert" + convertName, convert =>
            {
                if (isGeneric)
                {
                    convert.GenericArguments.Add(ga);
                }
                convert.AddParameterVariable("j4n_env");
                convert.AddParameter().Call("j4n_env." + callName, result);
            });
        }

        private void ConsumeRefOut(MMember member, IGStatementContainer frame)
        {
            foreach (UTypeUsage param in member.Params)
            {
                if (param.IsOut)
                {
                    ConsumeOutParam(member, param, frame);
                }
                if (param.IsRef)
                {
                    ConsumeRefParam(member, param, frame);
                }
            }
        }

        private bool DeclareRefOut(MMember member, IGUsingStatement frame)
        {
            bool ro = false;
            for (int i = 0; i < member.Params.Count; i++)
            {
                UTypeUsage param = member.Params[i];
                if (param.IsOut)
                {
                    DeclareOutParam(member, param, frame);
                    ro = true;
                }
                if (param.IsRef)
                {
                    string jvmAPi = member.Pair.Params[i].Root.JvmReflectionName;
                    DeclareRefParam(member, param, frame, jvmAPi);
                    ro = true;
                }
            }
            return ro;
        }

        private void DeclareOutParam(MMember member, UTypeUsage param, IGStatementContainer frame)
        {
            frame.Declare(GTypeJ4N.JNIValueOut, Configurator.PrivateVarPrefix + "out_" + param.MethodParameterName,
            outPar => outPar.New(GTypeJ4N.JNIValueOut).AddParameterVariable(Configurator.PrivateVarPrefix + "env"));
        }

        private void ConsumeOutParam(MMember member, UTypeUsage param, IGStatementContainer frame)
        {
            UTypeUsage strip = param.DeepClone(false, member.Owner);
            strip.IsOut = false;

            bool isPrimitive;
            IGType ct = GetConversionType(strip, out isPrimitive);

            frame.CallStatic(ct, "FromOutParam",
                convert =>
                {
                    convert.AddParameterVariable(Configurator.PrivateVarPrefix + "env");
                    convert.AddParameterVariable(Configurator.PrivateVarPrefix + "out_" + param.MethodParameterName);
                    convert.AddParameter().AddTextSnippet("out " + param.MethodParameterName);

                    //convert.GenericArguments.Add(strip);
                });
        }

        private void DeclareRefParam(MMember member, UTypeUsage param, IGUsingStatement frame, string jvmAPi)
        {
            UTypeUsage strip = param.DeepClone(false, member.Owner);
            strip.IsOut = false;

            bool isPrimitive;
            IGType ct = GetConversionType(strip, out isPrimitive);

            frame.Declare(GTypeJ4N.JNIValueRef, Configurator.PrivateVarPrefix + "ref_" + param.MethodParameterName,
            outPar => outPar.CallStatic(ct, "ToRefParam",
                call =>
                {
                    call.AddParameterVariable(Configurator.PrivateVarPrefix + "env");
                    call.AddParameterVariable(NTypeName.ReplaceKeywords(param.MethodParameterName,false));
                    if ((!param.Root.IsSealed || !param.Root.IsMapped) && !param.Root.IsPrimitive)
                    {
                        call.AddParameterValue(jvmAPi);
                    }
                }));
        }

        private void ConsumeRefParam(MMember member, UTypeUsage param, IGStatementContainer frame)
        {
            UTypeUsage strip = param.DeepClone(false, member.Owner);
            strip.IsOut = false;

            bool isPrimitive;
            IGType ct = GetConversionType(strip, out isPrimitive);

            frame.CallStatic(ct, "FromRefParam",
                convert =>
                {
                    convert.AddParameterVariable(Configurator.PrivateVarPrefix + "env");
                    convert.AddParameterVariable(Configurator.PrivateVarPrefix + "ref_" + param.MethodParameterName);
                    convert.AddParameter().AddTextSnippet("ref " + param.MethodParameterName);

                    //convert.GenericArguments.Add(strip);
                });
        }

    }
}
