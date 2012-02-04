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
using com.jni4net.proxygen.Utils;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class ClrImplementsExplorer : ImplementsExplorerCommon
    {
        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P0300_BasesExplored; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 50; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsClr;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            waitingFor = new[] {model};
            return model.Exploration != null;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            var clr = model.ClrReflection;
            if (clr != KnownTypes.SystemObject.ClrReflection)
            {
                ReflectInterfaces(model, clr, handleModel);
            }

            LoadRegistrations(model);

            model.Pass = ProxyGenPass.P0400_InterfacesExplored;
            return false;
        }

        private void ReflectInterfaces(MType model, Type clr, Func<MType, bool> handleModel)
        {
            Type[] clrInterfaces = clr.GetInterfaces();
            foreach (var clri in clrInterfaces)
            {
                if (HasHigher(clrInterfaces, clri))
                {
                    continue;
                }

                Type clrIface = FindIface(clri, clr);
                if (clrIface != null)
                {
                    var ifcModel = ClrResolver.Register(ClrResolver.FindPlainType(clrIface), null, model);

                    Repository.ExploreType(ifcModel);

                    // make sure we load jvm side
                    if (ifcModel.Pass < ProxyGenPass.P0300_BasesExplored)
                    {
                        handleModel(ifcModel);
                    }
                    var interfaceUsage = ClrResolver.CreateUsage(clrIface, model);
                    if (!ifcModel.IsExcluded)
                    {
                        if (model.IsGenerate)
                        {
                            interfaceUsage.MarkGenerate(AutogenerateInterface, model.ProjectRegistration);
                        }
                        model.Exploration.Interfaces.Add(interfaceUsage);
                    }
                }
            }
        }

        protected virtual bool HasHigher(IEnumerable<Type> clrInterfaces, Type ifc)
        {
            return clrInterfaces.Any(other => other != ifc && other.Implements(ifc) && !other.IsGenericType);
        }

        protected virtual bool AutogenerateInterface(MType model)
        {
            return ((model.ProjectRegistration.autoGenerateInterfaces && !model.IsKnown) || model.ProjectRegistration.forceGenerateInterfaces);
        }

        protected virtual Type FindIface(Type clri, Type clr)
        {
            if (!ClrResolver.CheckSupportedType(clri))
            {
                return null;
            }

            if (clr.BaseType != null && clr.BaseType.Implements(clri))
            {
                return null;
            }
            return clri;
        }
    }
}
