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
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Tweakers
{
    public class SubstituteTypeTweaker : BaseHandler
    {
        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P1000_TweakerStarted; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 80; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return !model.IsKnown && model.Exploration != null;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            if (model.IsInterface)
            {
                FindSuperInterface(model, model);
            }
            else
            {
                FindSuperClass(model);
            }

            // try to find better interface instead of root Object
            if (!model.IsInterface && (model.Substitution == null ||  model.Substitution.IsRoot))
            {
                model.Substitution = null;
                FindSuperInterface(model, model);
            }

            // fallback
            if (model.Substitution == null)
            {
                SubstObject(model);
            }
            return false;
        }

        private static void FindSuperClass(MType model)
        {
            MType current = model;
            while (current != null)
            {
                if (AcceptSubstitution(model, current))
                {
                    break;
                }

                if (current.Exploration.Base!=null)
                {
                    current = current.Exploration.Base.Root;
                }
                else
                {
                    break;
                }
            }
        }

        private static void FindSuperInterface(MType model, MType current)
        {
            foreach (UTypeUsage ifc in current.Exploration.Interfaces)
            {
                if (AcceptSubstitution(model, ifc.Root))
                {
                    break;
                }
            }
            if(model.Substitution==null)
            {
                foreach (UTypeUsage ifc in current.Exploration.Interfaces)
                {
                    if (!ifc.IsGeneric)
                    {
                        FindSuperInterface(model, ifc.Root);
                    }
                }
            }
        }

        private static bool AcceptSubstitution(MType model, MType current)
        {
            if (current.IsRoot || (current.ClrReflection != null && current.JvmReflection != null) || current.IsGenerate)
            {
                model.Substitution = current;
                return true;
            }
            if (current.Substitution != null)
            {
                if (current.Substitution.IsClr == current.IsClr)
                {
                    model.Substitution = current.Substitution;
                }
                else
                {
                    throw new NotImplementedException();
                }
                return true;
            }
            return false;
        }

        private void SubstObject(MType model)
        {
            model.Substitution = model.IsClr ? KnownTypes.SystemObject : KnownTypes.JavaLangObject;
        }


    }
}
