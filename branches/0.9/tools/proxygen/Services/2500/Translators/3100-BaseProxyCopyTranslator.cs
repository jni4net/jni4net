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
using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services.Translators
{
    public abstract class BaseProxyCopyTranslator : BaseHandler
    {
        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        [Dependency]
        public ClrSkipOrRenameDuplicateMembersTranslator ClrSkipOrRenameDuplicateMembersTranslator { get; set; }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            var goa = IsNotDependencyDone(model.Exploration.Base);
            if (goa)
            {
                waitingFor = new[] { model.Exploration.Base.Root };
                return false;
            }
            waitingFor = model.Exploration.Interfaces.Where(IsNotDependencyDone).Select(x => x.Root);
            return !waitingFor.Any();
        }

        private static bool IsNotDependencyDone(UTypeUsage x)
        {
            return x != null && !x.IsJvmSkip && !x.IsClrSkip && x.Root.IsGenerate && x.Root.Pass < ProxyGenPass.P3100_InterfacesProxyFilled;
        }

        protected virtual void AddBaseMembers(MType model, IList<MMember> members, IDictionary<MType, MType> alreadyAdded, bool target)
        {
            var srcView = target
                ? model.TargetGeneration
                : model.Exploration;

            foreach (UTypeUsage ifc in srcView.Interfaces)
            {
                if (IsSkip(ifc) || alreadyAdded.ContainsKey(ifc.Root))
                {
                    continue;
                }
                //TODO should be rather parametrized type usage
                alreadyAdded.Add(ifc.Root, ifc.Root);
                var ifcMembers = new List<MMember>();
                AddBaseMembers(ifc.Root, ifcMembers, alreadyAdded, target);
                foreach (MMember member in ifcMembers)
                {
                    Visit(member, ifc);
                    members.Add(member);
                }
            }

            foreach (var member in srcView.Members)
            {
                var clone = member.DeepClone(false);
                members.Add(clone);
            }
        }

        protected abstract bool IsSkip(UTypeUsage ifc);

        protected virtual void Visit(MMember member, UTypeUsage ifc)
        {
        }

        protected virtual void FlattenJvmGenerationMembers(MType model, MTypeView view, bool pair)
        {
            view.Members.Clear();
            AddBaseMembers(model, view.Members, new Dictionary<MType, MType>(), !pair);

            // have same signature in Java
            // System.Resources.IResourceReader
            // global::System.Collections.IEnumerator GetEnumerator()
            // global::System.Collections.IDictionaryEnumerator GetEnumerator()
            var signatures = new Dictionary<string, MMember>();
            var basesignatures = new Dictionary<string, MMember>();
            ClrSkipOrRenameDuplicateMembersTranslator.HandleMembers(model, false, true, basesignatures, view.Members, signatures);

            view.SortMembers();
        }

        protected virtual void FlattenClrGenerationMembers(MType model, MTypeView view, bool pair)
        {
            view.Members.Clear();
            AddBaseMembers(model, view.Members, new Dictionary<MType, MType>(), !pair);

            MakeConflictsExplicit(model, view, pair);

            view.SortMembers();
        }

        private void MakeConflictsExplicit(MType model, MTypeView view, bool pair)
        {
            var conflicts=new Dictionary<string, Dictionary<string, MMember>>();

            foreach (var member in view.Members)
            {
                Dictionary<string, MMember> sameName;
                if (!conflicts.TryGetValue(member.Name, out sameName))
                {
                    sameName = new Dictionary<string, MMember>();
                    conflicts.Add(member.Name, sameName);
                }
                string signature = member.GetClrSignature(false);
                MMember other;
                if (sameName.TryGetValue(signature, out other))
                {
                    if(member.Owner.IsAssignableFrom(other.Owner))
                    {
                        member.ExplicitInterface = member.ImplementsInterfaces[0];
                    }
                    else
                    {
                        other.ExplicitInterface = other.ImplementsInterfaces[0];
                    }
                }
                else
                {
                    sameName.Add(signature, member);
                }
            }
        }
    }
}
