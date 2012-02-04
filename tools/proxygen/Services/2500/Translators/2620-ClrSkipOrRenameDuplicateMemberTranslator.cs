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
using Microsoft.Practices.Unity;
using JType = java.lang.reflect.Type;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services.Translators
{
    public class ClrSkipOrRenameDuplicateMembersTranslator : BaseHandler
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
            return model.IsGenerate && model.IsClr;
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
            //todo solve generic erasure conflict on params, not just return type

            HandleSignatures(model, false, true);

            model.Pass = ProxyGenPass.P2700_MembersMapped;
            return false;
        }

        protected virtual Dictionary<string, MMember> HandleSignatures(MType model, bool load, bool exploreBase)
        {
            var signatures = new Dictionary<string, MMember>();
            Dictionary<string, MMember> basesignatures;

            if (model.Exploration.Base != null && exploreBase)
            {
                //load base class methods
                basesignatures = HandleSignatures(model.Exploration.Base.Root, true, true);
                foreach (var basesignature in basesignatures)
                {
                    signatures.Add(basesignature.Key, basesignature.Value);
                }
            }
            else
            {
                basesignatures=new Dictionary<string, MMember>();
            }

            HandleMembers(model, load, false, basesignatures, model.JvmGeneration.Members, signatures);
            return signatures;
        }

        public int HandleMembers(MType model, bool load, bool intefaceProxy, Dictionary<string, MMember> basesignatures, IList<MMember> members, Dictionary<string, MMember> signatures)
        {
            int count = 0;
            foreach (var current in members)
            {
                string signature = current.GetJvmSignature(false) + " " + current.Name;
                MMember conflict;
                if (load && (current.IsConstructor || current.IsJvmSkip || current.IsLooser))
                {
                    continue;
                }

                if (!signatures.TryGetValue(signature, out conflict))
                {
                    signatures[signature] = current;
                }
                else
                {
                    count++;
                    bool killCurrent = false;
                    bool skip = intefaceProxy || current.IsConstructor;

                    //to solve add base class methods
                    if (current.Owner != model && !intefaceProxy)
                    {
                        continue;
                    }
                    if (load)
                    {
                        throw new InvalidProgramException();
                    }

                    if (basesignatures.ContainsKey(signature))
                    {
                        killCurrent = true;
                    }
                    else if (current.ImplementsInterfaces.Count > 0 && current.ImplementsInterfaces.All(x => x.IsJvmSkip))
                    {
                        killCurrent = true;
                    }
                    else if (conflict.ImplementsInterfaces.Count > 0 && conflict.ImplementsInterfaces.All(x => x.IsJvmSkip))
                    {
                        killCurrent = false;
                    }
                    else if (IsMethodEqual(conflict, current, false))
                    {
                        killCurrent = true;
                        skip = true;
                    }
                    else if (IsMethodAssignable(current, conflict, false))
                    {
                        killCurrent = true;
                    }
                    else if (!IsMethodAssignable(conflict, current, false))
                    {
                        killCurrent = true;
                    }
                    SkipOrRename(model, killCurrent ? conflict : current, killCurrent ? current : conflict, signatures, skip);
                }
            }
            return count;
        }

        protected void SkipOrRename(MType model, MMember winner, MMember looser, Dictionary<string, MMember> signatures, bool skip)
        {
            if (skip)
            {
                Logger.LogMessage("Skipping member " + looser + " on " + model + " because of conflict with " + winner,model);
                signatures[winner.GetJvmSignature(false) + " " + winner.Name] = winner;
                looser.IsJvmSkip = true;
            }
            else
            {
                Logger.LogMessage("Renaming member " + looser + " on " + model + " because of conflict with " + winner, model);
                Rename(looser, signatures.Count);
                signatures[winner.GetJvmSignature(false) + " " + winner.Name] = winner;
                signatures[looser.GetJvmSignature(false) + " " + looser.Name] = looser;
            }
            looser.IsLooser = true;
            for (int i = 0; i < looser.ImplementsMember.Count; i++)
            {
                var impl = looser.ImplementsMember[i];
                var impli = looser.ImplementsInterfaces[i];
                if (IsMethodAssignable(looser,winner, false))
                {
                    winner.ImplementsMember.Add(impl);
                    winner.ImplementsInterfaces.Add(impli);
                }
            }
        }

        private static void Rename(MMember member, int id)
        {
            if (member.ImplementsInterfaces.Count>0)
            {
                member.Name = member.Name + "_" + member.ImplementsInterfaces[0].Root.JvmLocalName + (id + 1);
            }
            else
            {
                member.Name = member.Name + "_" + (id + 1);
            }
        }

        protected static bool IsMethodEqual(MMember a, MMember b, bool ignoreRet)
        {
            if (a.Params.Count != b.Params.Count
                || (a.Return == null && b.Return != null)
                || (a.Return != null && b.Return == null)
                )
            {
                throw new InvalidProgramException();
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

        protected bool IsMethodAssignable(MMember a, MMember b, bool ignoreRet)
        {
            if (a.Params.Count != b.Params.Count)
            {
                throw new InvalidProgramException();
            }

            if (!ignoreRet && !IsAssignableFrom(a.Return, b.Return))
            {
                return false;
            }
            for (int i = 0; i < a.Params.Count; i++)
            {
                var ap = a.Params[i];
                var bp = b.Params[i];
                if (!IsAssignableFrom(bp, ap))
                {
                    return false;
                }
            }
            return true;
        }

        protected bool IsAssignableFrom(UTypeUsage ap, UTypeUsage bp)
        {
            if (ap == null && bp == null)
                return true;
            if (ap == null)
                return false;
            if (bp == null)
                return false;

            return ap.IsAssignableFrom(bp);
        }

        protected virtual bool IsAssignableFrom(Type ar, Type br)
        {
            if (ar == null)
                return false;
            if (br == null)
                return false;
            if (ar == KnownTypes.JavaLangObject.ClrReflection)
            {
                ar = KnownTypes.SystemObject.ClrReflection;
            }
            if (br == KnownTypes.JavaLangObject.ClrReflection)
            {
                br = KnownTypes.SystemObject.ClrReflection;
            }
            return ar.IsAssignableFrom(br);
        }

    }
}
