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

namespace com.jni4net.proxygen.Services.Generators
{
    partial class BaseJavaGenerator
    {
        public void GenerateMembers(MType model, GeneratorTarget target)
        {
            IGClass clsApi;
            if (!model.Targets.Classes.TryGetValue(target, out clsApi))
            {
                return;
            }
            var view = (MTypeView)clsApi.CustomData;
            int membersRegistration = 0;
            foreach (var m in view.Members)
            {
                MMember member = m;
                if (member.IsJvmSkip)
                {
                }
                else if (model.IsInterface && member.IsStatic)
                {
                    //TODO move to static class
                }
                else
                {
                    GenerateMember(model, target, member, clsApi, membersRegistration);
                }
                membersRegistration++;
            }
        }

        private static void GenerateMember(MType model, GeneratorTarget target, MMember member, IGClass clsApi, int membersRegistration)
        {
            string name = member.Name;
            IGMethod gmethod;
            if (member.IsConstructor)
            {
                IGConstructor constructor = clsApi.AddConstructor();
                if (!model.IsRoot)
                {
                    constructor.CallConstructorBase(
                        super =>
                            {
                                super.AddParameter().Value(0);
                                super.AddParameter().Cast(GTypeJ4N.ClrInstanceInfo).AddParameterNull();
                                /*super.AddParameter().New(GTypeJ4N.ClrInstanceInfo, ii =>
                                {
                                    ii.AddParameterVariable("j4n_TypeInfo.CLRApi");
                                    ii.AddParameterVariable("j4n_TypeInfo");
                                });*/
                            });
                }

                constructor.CustomData = member;
                var call = constructor.Assign("j4n_clrHandle").Call("j4n_constructor");
                foreach (UTypeUsage param in member.Params)
                {
                    constructor.AddParameter(param, NTypeName.ReplaceKeywords(param.MethodParameterName, true));
                    call.AddParameterVariable(NTypeName.ReplaceKeywords(param.MethodParameterName, true));
                }

                gmethod = clsApi.AddMethod(GTypeJvm.Long, "j4n_constructor");
                gmethod.IsPrivate = true;
            }
            else
            {
                gmethod = clsApi.AddMethod(member.Return, name);
            }
            member.Targets[target] = gmethod;
            gmethod.With(method =>
                              {
                                  method.CustomData = member;
                                  method.IsNative = !clsApi.IsInterface;
                                  method.HideBody = clsApi.IsInterface || method.IsNative;
                                  method.IsInterface = model.IsInterface && (target == GeneratorTarget.JvmApi);
                                  method.IsStatic = member.IsStatic;
                                  method.IsSealed = !member.IsStatic && !member.IsConstructor &&
                                                    (member.IsSealed || !member.IsVirtual || member.IsField);
                                  foreach (UTypeUsage param in member.Params)
                                  {
                                      method.AddParameter(param, NTypeName.ReplaceKeywords(param.MethodParameterName, true));
                                  }
                                  method.AddXmlDoc(" <signature>#" + membersRegistration + " " + member.GetJvmSignature(true) + " " + member.GetClrSignature(true) + "</signature>");
                              });
        }
    }
}
