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

namespace com.jni4net.proxygen.Services.Translators
{
    public class ClrSubstitutePrimitiveTypeUsageTranslator : BaseHandler
    {
        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P2700_MembersMapped; }
        }

        public override bool IsBlockingAll
        {
            get { return true; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 10; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate 
                && model.IsClr;
        }

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
            return x!=null && !x.IsJvmSkip && !x.IsClrSkip && x.Root.IsGenerate && x.Root.Pass < ProxyGenPass.P2800_MembersPrimitivised;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            foreach (var member in model.JvmGeneration.Members)
            {
                MType subst = SubstitutePrimitiveParameter(member.Return);
                if (TestPrimitiveLike(member, x => x.Return, subst) && TestInterfaces(model, member, x => x.Return, subst))
                {
                    Subst(member.Return, true, subst);
                }
                for (int i = 0; i < member.Params.Count; i++)
                {
                    int index = i;
                    subst = SubstitutePrimitiveParameter(member.Params[index]);
                    if (TestPrimitiveLike(member, x => x.Params[index], subst) && TestInterfaces(model, member, x => x.Params[index], subst))
                    {
                        Subst(member.Params[index], true, subst);
                    }
                }
            }

            model.Pass = ProxyGenPass.P2800_MembersPrimitivised;

            return false;
        }

        protected virtual bool TestPrimitiveLike(MMember member, Func<MMember, UTypeUsage> getparam, MType subst)
        {
            UTypeUsage usage = getparam(member);
            if (usage==null || subst==null)
            {
                return false;
            }
            return usage.Root.IsPrimitiveLike;
        }


        protected virtual bool TestInterfaces(MType model, MMember member, Func<MMember, UTypeUsage> getparam, MType subst)
        {
            if (model.IsInterface)
                return true;

            foreach (var impl in member.ImplementsMember)
            {
                UTypeUsage parImpl = getparam(impl);
                if (parImpl != null)
                {
                    if(parImpl.Root!=subst)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        protected virtual void Subst(UTypeUsage usage, bool viewIsClr, MType subst)
        {
            if (subst!=null)
            {
                usage.Root = subst;
            }
        }

        protected MType SubstitutePrimitiveParameter(UTypeUsage usage)
        {
            if(usage==null)
            {
                return null;
            }
            if (usage.Root == KnownTypes.JavaLangBoolean || usage.Root == KnownTypes.ClrBool)
            {
                return KnownTypes.JvmBool;
            }
            if (usage.Root == KnownTypes.JavaLangByte || usage.Root == KnownTypes.ClrBool || usage.Root == KnownTypes.ClrSByte)
            {
                return KnownTypes.JvmByte;
            }
            if (usage.Root == KnownTypes.JavaLangCharacter || usage.Root == KnownTypes.ClrChar)
            {
                return KnownTypes.JvmChar;
            }
            if (usage.Root == KnownTypes.JavaLangShort || usage.Root == KnownTypes.ClrShort|| usage.Root == KnownTypes.ClrUShort)
            {
                return KnownTypes.JvmShort;
            }
            if (usage.Root == KnownTypes.JavaLangInteger || usage.Root == KnownTypes.ClrInt || usage.Root == KnownTypes.ClrUInt)
            {
                return KnownTypes.JvmInt;
            }
            if (usage.Root == KnownTypes.JavaLangLong || usage.Root == KnownTypes.ClrLong || usage.Root == KnownTypes.ClrULong)
            {
                return KnownTypes.JvmLong;
            }
            if (usage.Root == KnownTypes.JavaLangFloat || usage.Root == KnownTypes.ClrFloat)
            {
                return KnownTypes.JvmFloat;
            }
            if (usage.Root == KnownTypes.JavaLangDouble || usage.Root == KnownTypes.ClrDouble)
            {
                return KnownTypes.JvmDouble;
            }
            return null;
        }

        private bool TestPrimitive(MMember member, Func<MMember, UTypeUsage> getparam)
        {
            UTypeUsage usage = getparam(member);
            if (usage.Root == KnownTypes.JavaLangBoolean || usage.Root == KnownTypes.ClrBool)
            {
                return true;
            }
            if (usage.Root == KnownTypes.JavaLangByte || usage.Root == KnownTypes.ClrBool || usage.Root == KnownTypes.ClrSByte)
            {
                return true;
            }
            if (usage.Root == KnownTypes.JavaLangCharacter || usage.Root == KnownTypes.ClrChar)
            {
                return true;
            }
            if (usage.Root == KnownTypes.JavaLangShort || usage.Root == KnownTypes.ClrShort || usage.Root == KnownTypes.ClrUShort)
            {
                return true;
            }
            if (usage.Root == KnownTypes.JavaLangInteger || usage.Root == KnownTypes.ClrInt || usage.Root == KnownTypes.ClrUInt)
            {
                return true;
            }
            if (usage.Root == KnownTypes.JavaLangLong || usage.Root == KnownTypes.ClrLong || usage.Root == KnownTypes.ClrULong)
            {
                return true;
            }
            if (usage.Root == KnownTypes.JavaLangFloat || usage.Root == KnownTypes.ClrFloat)
            {
                return true;
            }
            if (usage.Root == KnownTypes.JavaLangDouble || usage.Root == KnownTypes.ClrDouble)
            {
                return true;
            }
            return false;
        }
    }
}
