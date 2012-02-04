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
using java.lang;
using JType = java.lang.reflect.Type;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class JvmImplementsExplorer : ImplementsExplorerCommon
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
            return model.IsJvm;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            waitingFor = new[] {model};
            return model.Exploration != null;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            var jvm = model.JvmReflection;
            if (!java.lang.Object._class.equals(jvm))
            {
                ReflectInterfaces(model, jvm, handleModel);
            }

            LoadRegistrations(model);

            model.Pass = ProxyGenPass.P0400_InterfacesExplored;
            return false;
        }

        private void ReflectInterfaces(MType model, Class jvm, Func<MType, bool> handleModel)
        {
            var d = new Dictionary<JType, UTypeUsage>();
            Class superclass = jvm.getSuperclass();
            JType[] jvmInterfaces = FindIfaces(jvm);
            foreach (var jvmIface in jvmInterfaces)
            {
                var jvmi= jvmIface as Class;
                if (superclass != null && jvmi != null && jvmi.isAssignableFrom(superclass))
                {
                    continue;
                }
                if (HasHigher(jvmInterfaces, jvmi))
                {
                    continue;
                }
                if (jvmIface != null && !d.ContainsKey(jvmIface))
                {
                    var ifcModel = JvmResolver.Register(JvmResolver.FindPlainType(jvmIface), null, model);

                    Repository.ExploreType(ifcModel);

                    // make sure we load clr side
                    if (ifcModel.Pass < ProxyGenPass.P0300_BasesExplored)
                    {
                        handleModel(ifcModel);
                    }

                    var interfaceUsage = JvmResolver.CreateUsage(jvmIface, model);
                    if (!ifcModel.IsExcluded && !ifcModel.IsProtected)
                    {
                        if(model.IsGenerate)
                        {
                            interfaceUsage.MarkGenerate(AutogenerateInterface, model.ProjectRegistration);
                        }
                        d.Add(jvmIface, interfaceUsage);
                        model.Exploration.Interfaces.Add(interfaceUsage);
                    }
                }
            }
        }

        protected virtual bool HasHigher(IEnumerable<JType> clrInterfaces, JType ifc)
        {
            return clrInterfaces.Any(other => other != ifc && JvmResolver.IsAssignableFrom(ifc, other));
        }

        protected virtual bool AutogenerateInterface(MType model)
        {
            return ((model.ProjectRegistration.autoGenerateInterfaces && !model.IsKnown) || model.ProjectRegistration.forceGenerateInterfaces);
        }

        protected virtual JType[] FindIfaces(Class type)
        {
            return type.getInterfaces();
        }
    }
}
