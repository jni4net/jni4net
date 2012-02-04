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
    public class JvmSubstitutePrimitiveTypeUsageTranslator : BaseHandler
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
                && model.IsJvm;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            var goa = IsNotDependencyDone(model.Exploration.Base);
            if (goa)
            {
                waitingFor = new[] {model.Exploration.Base.Root};
                return false;
            }
            waitingFor = model.Exploration.Interfaces.Where(IsNotDependencyDone).Select(x => x.Root);
            return waitingFor.Count()==0;
        }

        private static bool IsNotDependencyDone(UTypeUsage x)
        {
            return x!=null && !x.IsJvmSkip && !x.IsClrSkip && x.Root.IsGenerate && x.Root.Pass < ProxyGenPass.P2800_MembersPrimitivised;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            model.Pass = ProxyGenPass.P2800_MembersPrimitivised;

            if (model == KnownTypes.JavaLangThrowable)
            {
                model.ClrGeneration.Base = null;
            }

            return false;
        }


    }
}
