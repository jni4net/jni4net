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
using System.Linq;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using java.lang.reflect;
using Microsoft.Practices.Unity;
using JType = java.lang.reflect.Type;

namespace com.jni4net.proxygen.Services.Translators
{
    public class JvmSkipOrRenameDuplicateMembersTranslator : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IJvmResolver JvmResolver { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P2600_MembersConfigured; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 20; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate && model.IsJvm;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            if (model.Exploration.Base != null && model.Exploration.Base.Root.Pass < ProxyGenPass.P2700_MembersMapped)
            {
                waitingFor = new[] { model.Exploration.Base.Root };
                return false;
            }
            waitingFor = null;
            return true;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            if (model != KnownTypes.JavaLangThrowable)
            {
                HandleModel(model, false, new Dictionary<string, List<MMember>>());
            }
            model.Pass = ProxyGenPass.P2700_MembersMapped;
            return false;
            
        }

        protected virtual void HandleModel(MType model, bool load, Dictionary<string, List<MMember>> byNames)
        {
            if (model.IsInterface)
            {
                foreach (var ifc in model.Exploration.Interfaces)
                {
                    HandleModel(ifc.Root, true, byNames);
                }
            }
            else
            {
                if (model.Exploration.Base != null && !model.TypeRegistration.addBaseMethods)
                {
                    //load base class methods
                    HandleModel(model.Exploration.Base.Root, true, byNames);
                }                
            }


            foreach (var member in model.ClrGeneration.Members)
            {
                /*if (model.JvmFullName == "java.lang.StringBuilder" && member.Name == "append")
                {
                    string jvmSignature = member.GetJvmSignature(true);
                    if(jvmSignature == "(C)Ljava/lang/AbstractStringBuilder;"
                        || jvmSignature=="(C)Ljava/lang/Appendable;")
                    {
                        int xxx = 0;
                    }
                }*/

                if (!member.IsLooser && member.IsMethod)
                {
                    List<MMember> competitors;
                    var name = member.Name + "(" + member.Params.Count + ")";
                    if (!byNames.TryGetValue(name, out competitors))
                    {
                        competitors = new List<MMember>();
                        byNames.Add(name, competitors);
                    }
                    competitors.Add(member);
                }
            }

            if(load)
            {
                return;
            }

            foreach (var competitors in byNames.Values)
            {
                if (competitors.Count > 1)
                {
                    var keep = new List<MMember>();
                    foreach (var current in competitors)
                    {
                        bool add = true;
                        foreach (var k in keep.ToList())
                        {
                            var currentMethod = current.JvmReflection as Method;
                            var kMethod = k.JvmReflection as Method;
                            if (JvmResolver.IsOverridden(kMethod, currentMethod))
                            {
                                SkipOrRename(model, current, k, keep.Count);
                                keep.Remove(k);
                            }
                            else if (JvmResolver.IsOverridden(currentMethod, kMethod))
                            {
                                SkipOrRename(model, k, current, keep.Count);
                                add = false;
                                break;
                            }
                            else if (IsMethodEqual(k, current, true))
                            {
                                SkipOrRename(model, k, current, keep.Count);
                                add = false;
                                break;
                            }
                        }
                        if (add)
                        {
                            keep.Add(current);
                        }
                    }
                }
            }

        }

        protected void SkipOrRename(MType model, MMember winner, MMember looser, int count)
        {
            if (looser.ImplementsInterfaces.Count==0)
            {
                Logger.LogMessage("Renaming member " + looser + " on " + model + " because of conflict with " + winner, model);
                looser.Name = looser.Name + "_" + (count + 1);
            }
            else
            {
                Logger.LogMessage("Explicit member " + looser + " on " + model + " because of conflict with " + winner, model);
                looser.ExplicitInterface = looser.ImplementsInterfaces[0];
                looser.IsVirtual = false;
                looser.IsPublic = false;
            }
            looser.IsLooser = true;
        }

        protected bool IsMethodEqual(MMember a, MMember b, bool ignoreRet)
        {
            if (a.Params.Count != b.Params.Count
                || (a.Return == null && b.Return != null)
                || (a.Return != null && b.Return == null)
                )
            {
                return false;
            }
            if (!ignoreRet && a.Return != null && b.Return != null)
            {
                if (!Equals(a.Return, b.Return))
                {
                    return false;
                }
            }
            for (int i = 0; i < a.Params.Count; i++)
            {
                var ap = a.Params[i];
                var bp = b.Params[i];
                if (!Equals(ap, bp))
                {
                    return false;
                }
            }
            return true;
        }


    }
}

