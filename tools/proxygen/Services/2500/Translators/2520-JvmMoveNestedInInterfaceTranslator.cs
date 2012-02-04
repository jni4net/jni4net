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
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;
using Microsoft.Practices.Unity;

namespace com.jni4net.proxygen.Services.Translators
{
    public class JvmMoveNestedInInterfaceTranslator : BaseHandler
    {
        [Dependency]
        public ILogger Logger { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P2500_TranslatorStarted; }
        }

        public override int PassPriority
        {
            get { return MyPassPriority + 20; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate 
                && model.IsNested 
                && model.TargetGeneration.EnclosingType!=null 
                && model.TargetGeneration.EnclosingType.IsInterface;
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            bool canContinue = model.TargetGeneration.EnclosingType!=null
                                           && (model.TargetGeneration.EnclosingType.ClrName.EnclosingTypes.Count==0
                                           || !model.TargetGeneration.EnclosingType.ClrName.EnclosingTypes[0].Root.IsInterface)
                                           ;
            waitingFor = new[] {model.TargetGeneration.EnclosingType};
            return canContinue;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            model.ClrName.UnnestInterfaces();
            return false;
        }
    }
}
