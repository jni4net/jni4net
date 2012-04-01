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
using System.Text;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Generators
{
    public class StartTweaker : BaseHandler
    {
        [Dependency]
        public ITypeRepository Repository { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.Any; }
        }

        public override int PassPriority
        {
            get { return 1000; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return true;
        }

        public override bool IsBlockingAll
        {
            get
            {
                return true;
            }
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            if (!IsDone(model.Exploration.Base))
            {
                waitingFor = new[] { model.Exploration.Base.Root };
                return false;
            }
            if (!IsDone(model.Exploration.EnclosingType))
            {
                waitingFor = new[] { model.Exploration.EnclosingType };
                return false;
            }
            foreach (var ifc in model.Exploration.Interfaces)
            {
                if (!(model.IsClr ? ifc.IsClrSkip : ifc.IsJvmSkip) && !IsDone(ifc))
                {
                    waitingFor = new[] { ifc.Root };
                    return false;
                }
            }
            waitingFor = null;
            return true;
        }

        private static bool IsDone(UTypeUsage usage)
        {
            return usage == null || IsDone(usage.Root);
        }

        private static bool IsDone(MType model)
        {
            return model == null || model.Pass >= ProxyGenPass.P1000_TweakerStarted;
        }

        public override void RoundStarted(IList<MType> models)
        {
            this.models = new List<MType>();
            var l=0;
            var sb = new StringBuilder("Explorer round : ");
            foreach (var model in models)
            {
                if(model.IsGenerate)
                {
                    string name = model.ToShortString();
                    l += name.Length+1;
                    if (l > 120)
                    {
                        l = 0;
                        sb.AppendLine();
                        sb.Append("                 ");
                    }
                    sb.Append(name);
                    sb.Append(' ');
                }
            }
            Logger.LogMessage(sb.ToString(), null);
        }

        public override void RoundFinished(IList<MType> models)
        {
            Repository.ResetModelsToExplore(this.models);
        }

        private List<MType> models;

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            if (model.Exploration != null)
            {
                models.Add(model);
                model.Pass = ProxyGenPass.P1000_TweakerStarted;
            }
            else
            {
                model.Pass = ProxyGenPass.Quit;
            }

            return false;
        }
    }
}
