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
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Utils;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Explorers
{
    public class ClrPairExplorer : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency]
        public IClrResolver ClrResolver { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ITypeRepository Repository { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        [Dependency]
        public IClassRenamer[] ClassRenamers { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P0000_TypeLoaded; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 50; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsJvm;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            bool change = false;
            var jvm = model.JvmReflection;
            var clr = model.ClrReflection;
            foreach (var classRenamer in ClassRenamers)
            {
                classRenamer.Rename(model);
            }
            if (clr == null)
            {
                clr = ClrResolver.LoadType(model.ClrReflectionName, false);
            }
            if (jvm!=null && !jvm.IsPublic())
            {
                clr = null;
            }
            if (clr != null)
            {
                model.ClrReflection = clr;
                if (ReflectionUtils.DetectIsClr(jvm, clr, KnownTypes))
                {
                    model.IsClr=true;
                    change = true;
                }
                else
                {
                    model.IsJvm = true;
                }
            }
            else
            {
                model.IsJvm = true;
            }
            model.LockSide();
            model.Pass = ProxyGenPass.P0100_ProxyLoaded;
            return change;
        }
    }
}
