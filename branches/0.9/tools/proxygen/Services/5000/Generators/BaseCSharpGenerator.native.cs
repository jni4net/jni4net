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

using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using polyglottos;
using polyglottos.csharp;

namespace com.jni4net.proxygen.Services.Generators
{
    partial class BaseCSharpGenerator
    {
        public void GenerateBackingMembers(MType model, GeneratorTarget target)
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
                    if (member.IsJvmSkip)
                    {
                    }
                    else if (model.IsInterface && member.IsStatic)
                    {
                        //TODO move to static class
                    }
                    else
                    {
                        var method = CreateBackingMember(model, member, membersRegistration, cls);
                        CreateBackingMemberBody(model, member, method);
                    }
                    membersRegistration++;
                }
            }
        }

        private IGMethod CreateBackingMember(MType model, MMember member, int membersRegistration, IGClass cls)
        {
            IGType returnType = member.IsConstructor
                                    ? GTypeClr.Long
                                    : (member.Return != null && IntPtrTest(member.Return))
                                          ? GTypeClr.IntPtr
                                          : member.Return;

            IGMethod gmethod = cls.AddMethod(returnType, Configurator.PrivateMethodPrefix + membersRegistration,
                method =>
                    {
                        method.IsStatic = true;
                        method.IsPublic = false;
                        method.CustomData = member;
                        method.AddXmlDoc(" <signature>#" + membersRegistration + " " + member.Name + member.GetJvmSignature(true) + " " + member.GetClrSignature(true) + "</signature>");

                        method.AddParameter(GTypeClr.IntPtr, "j4n_penv");
                        if (member.IsStatic)
                        {
                            method.AddParameter(GTypeClr.IntPtr, "j4n_clazz");
                        }
                        else
                        {
                            method.AddParameter(GTypeClr.IntPtr, "j4n_self");
                        }
                        foreach (UTypeUsage param in member.Params)
                        {
                            var paramType = IntPtrTest(param) ? GTypeClr.IntPtr : param;
                            method.AddParameter(paramType, NTypeName.ReplaceKeywords(param.MethodParameterName, false));
                        }
                    });
            return gmethod;
        }

        private static bool IntPtrTest(UTypeUsage param)
        {
            return !param.Root.IsPrimitive || param.IsRef || param.IsOut || param.IsArray;
        }

        private void CreateBackingMemberBody(MType model, MMember member, IGMethod method)
        {
            method.Declare(GTypeJ4N.JNIEnv, "j4n_env").New(GTypeJ4N.JNIEnv).AddParameterVariable("j4n_penv");
            method.Declare(GTypeJ4N.LocalFrame, "j4n_frame")
                .New(GTypeJ4N.LocalFrame, lf=>
                                              {
                                                  lf.AddParameterVariable("j4n_env");
                                                  lf.AddParameterValue(member.Params.Count*2 + 10);
                                              });
            method.TryCatchFinally(tryb =>
                {

                    foreach (var param in member.Params)
                    {
                        if(param.IsRef)
                        {
                            var noref = param.DeepClone(false,model);
                            noref.IsRef = false;
                            var norefarr = noref.DeepClone(false, model);
                            string convertName = "FromRefObject";
                            if(noref.IsArray)
                            {
                                convertName += "Array";
                                for (int i = 0; i < norefarr.ArrayRank.Length; i++)
                                {
                                    if (norefarr.ArrayRank[i] > 0)
                                    {
                                        convertName += norefarr.ArrayRank[i];
                                        norefarr.ArrayRank[i] = 0;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            tryb.Declare(noref, "j4n_ref_" + param.MethodParameterName).CallStatic(GTypeJ4N.ConvertAbstract, convertName,
                                refcall =>
                                    {
                                        refcall.GenericArguments.Add(norefarr);
                                        refcall.AddParameterVariable("j4n_env");
                                        refcall.AddParameterVariable(NTypeName.ReplaceKeywords(param.MethodParameterName, false));
                                    });
                        }
                        else if (param.IsOut)
                        {
                            var noout = param.DeepClone(false, model);
                            noout.IsOut = false;
                            tryb.Declare(noout, "j4n_out_" + param.MethodParameterName);
                        }
                    }


                    IGCallParametersContainer call;
                    var instanceType = new UTypeUsage(model, model);
                    if(member.ImplementsInterfaces.Count>0)
                    {
                        instanceType = member.ImplementsInterfaces[0];
                    }

                    if (member.IsConstructor)
                    {
                        call = tryb.Return().CallStatic(GTypeJ4N.ConvertAbstract, "ToClrHandle")
                            .AddParameter().New(instanceType);
                    }
                    else
                    {
                        IGExpressionStartContainer site;
                        if (!member.IsStatic)
                        {
                            tryb.Declare(instanceType, "j4n_real").CallStatic(GTypeJ4N.ConvertAbstract, "ToCLR",
                                conv =>
                                    {
                                        conv.GenericArguments.Add(instanceType);
                                        conv.AddParameterVariable("j4n_env");
                                        conv.AddParameterVariable("j4n_self");
                                    });
                        }
                        if(member.IsVoid)
                        {
                            site = tryb;
                        }
                        else
                        {
                            site = null;
                            IGStatement ret;
                            if (IntPtrTest(member.Return))
                            {
                                ret = tryb.Assign("j4n_frame.Result");
                            }
                            else
                            {
                                ret = tryb.Declare(member.Return, "j4n_result");
                            }
                            if (!member.Return.Root.IsPrimitive || member.Return.IsArray)
                            {
                                ret.CallStatic(GTypeJ4N.ConvertAbstract, "ToPtr", conv =>
                                {
                                    conv.AddParameterVariable("j4n_env");
                                    site = conv.AddParameter();
                                    conv.AddParameterValue(member.Pair.Return.Root.JvmReflectionName);
                                });
                            }
                            else
                            {
                                site = ret;
                            }
                        }
                        IGExpression site2;
                        if(member.IsStatic)
                        {
                            site2 = site.Static(instanceType);
                        }
                        else
                        {
                            site2 = site.TextExpression("j4n_real");
                        }
                        if(member.IsProperty || member.IsEvent || member.IsField)
                        {
                            if ((member.IsProperty || member.IsField) && member.Property.Get == member)
                            {
                                if(member.Params.Count==0)
                                {
                                    site2.CallField(member.Property.Name);
                                    call = null;
                                }
                                else
                                {
                                    call = site2.Indexer();
                                }
                            }
                            else
                            {
                                IGOperatorExpression assign;
                                if(member.IsStatic)
                                {
                                    if (member.Params.Count > 1)
                                    {
                                        var idxr = site2.Indexer();
                                        call = idxr;
                                        assign = idxr.Operator("=");
                                    }
                                    else
                                    {
                                        call = null;
                                        assign = site2.TextExpression(member.Property.Name).Operator("=");
                                    }
                                }
                                else
                                {
                                    if (member.Params.Count > 1)
                                    {
                                        var idxr = site2.Indexer();
                                        call = idxr;
                                        assign = idxr.Operator("=");
                                    }
                                    else
                                    {
                                        assign = site2.TextExpression(member.Property.Name).Operator("=");
                                        call = null;
                                    }
                                }
                                if(member.IsEvent)
                                {
                                    if(member.Property.Get==member)
                                    {
                                        assign.Name = "+=";
                                    }
                                    else
                                    {
                                        assign.Name = "-=";
                                    }
                                }

                                UTypeUsage parameter = member.Params[member.Params.Count - 1];
                                var methodParameterName = NTypeName.ReplaceKeywords(parameter.MethodParameterName,false);
                                if (!parameter.Root.IsPrimitive || parameter.IsArray)
                                {
                                    assign.CallStatic(GTypeJ4N.ConvertAbstract, "ToCLR", conv =>
                                                                                            {
                                                                                                conv.GenericArguments.Add(parameter);
                                                                                                conv.AddParameterVariable("j4n_env");
                                                                                                conv.AddParameterVariable(methodParameterName);
                                                                                            });
                                }
                                else
                                {
                                    assign.TextExpression(methodParameterName);
                                }
                            }
                        }
                        else
                        {
                            call = site2.Call(member.Name);
                        }
                    }

                    for (int i = 0; i < member.Params.Count; i++)
                    {
                        if(i==member.Params.Count-1 && (((member.IsProperty ||member.IsField) && member.Property.Set==member) || member.IsEvent))
                        {
                            continue;
                        }
                        UTypeUsage parameter = member.Params[i];
                        var methodParameterName = parameter.MethodParameterName;
                        if (parameter.IsRef)
                        {
                            methodParameterName = "j4n_ref_" + methodParameterName;
                            call.AddParameterVariable(methodParameterName, gp => { gp.IsRef = true; });
                        }
                        else if (parameter.IsOut)
                        {
                            methodParameterName = "j4n_out_" + methodParameterName;
                            call.AddParameterVariable(methodParameterName, gp => { gp.IsOut = true; });
                        }
                        else if (!parameter.Root.IsPrimitive || parameter.IsArray)
                        {
                            call.AddParameter().CallStatic(GTypeJ4N.ConvertAbstract, "ToCLR",
                                conv =>
                                    {
                                        conv.GenericArguments.Add(parameter);
                                        conv.AddParameterVariable("j4n_env");
                                        conv.AddParameterVariable(NTypeName.ReplaceKeywords(methodParameterName,false));
                                    });
                        }
                        else
                        {
                            call.AddParameterVariable(NTypeName.ReplaceKeywords(methodParameterName,false));
                        }
                    }

                    for (int i = 0; i < member.Params.Count; i++)
                    {
                        var param = member.Params[i];
                        if (param.IsRef)
                        {
                            string jvmAPi = member.Pair.Params[i].Root.JvmReflectionName;
                            tryb.CallStatic(GTypeJ4N.ConvertAbstract, "ToRefObject",
                                refcall =>
                                    {
                                        refcall.AddParameterVariable("j4n_env");
                                        refcall.AddParameterVariable(NTypeName.ReplaceKeywords(
                                            param.MethodParameterName, false));
                                        refcall.AddParameterVariable("j4n_ref_" + param.MethodParameterName);
                                        refcall.AddParameterValue(jvmAPi);
                                    });
                        }
                        else if (param.IsOut)
                        {
                            string jvmAPi = member.Pair.Params[i].Root.JvmReflectionName;
                            tryb.CallStatic(GTypeJ4N.ConvertAbstract, "ToOutObject",
                                outcall =>
                                    {
                                        outcall.AddParameterVariable("j4n_env");
                                        outcall.AddParameterVariable(NTypeName.ReplaceKeywords(
                                            param.MethodParameterName, false));
                                        outcall.AddParameterVariable("j4n_out_" + param.MethodParameterName);
                                        outcall.AddParameterValue(jvmAPi);
                                    });
                        }
                    }

                    if (!member.IsConstructor && !member.IsVoid && member.Return.Root.IsPrimitive && !member.Return.IsArray)
                    {
                        tryb.Return().TextExpression("j4n_result");
                    }
                })
                .Catch(GTypeClr.SystemException, "j4n_ex", catchb =>
                {
                    catchb.TextExpression("j4n_env").Call("ThrowExisting").AddParameterVariable("j4n_ex");
                    if(member.IsConstructor || !member.IsVoid)
                    {
                        catchb.Return().Default(method.ReturnType);
                    }
                })
                .Finally(finallyb => finallyb.TextExpression("j4n_frame").Call("Dispose"));
            if (!member.IsVoid && !member.IsConstructor && IntPtrTest(member.Return))
            {
                method.Return().TextExpression("j4n_frame.Result");
            }
        }
    }
}
