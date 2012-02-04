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
using polyglottos;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Model;

namespace com.jni4net.proxygen.Services.Generators
{
    public class DumpFilesGenerator : BaseHandler
    {
        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public ILogger Logger { get; set; }

        [Dependency("GProjectCSharp")]
        public IGProject CSharpGenerator { get; set; }

        [Dependency("GProjectJava")]
        public IGProject JavaGenerator { get; set; }

        public override ProxyGenPass ExpectedPass
        {
            get { return ProxyGenPass.P5200_MembersGenerated; }
        }

        public override bool CheckOtherPrerequisites(MType model, out IEnumerable<MType> waitingFor)
        {
            waitingFor = model.TargetGeneration.NestedTypes.Where(x => x.IsGenerate && x.Pass < ProxyGenPass.P9999_FilesDumped);
            return !waitingFor.Any();
        }

        public override int PassPriority
        {
            get { return 9050; }
        }

        public override bool IsHandlerForModel(MType model)
        {
            return model.IsGenerate;
        }

        public override bool HandleModel(MType model, Func<MType, bool> handleModel)
        {
            foreach (var file in model.Targets.Files)
            {
                if(file.Key == GeneratorTarget.ClrApi || file.Key == GeneratorTarget.ClrProxy || file.Key == GeneratorTarget.JvmBacking)
                {
                    CSharpGenerator.GenerateFile(file.Value);
                }
                else if (file.Key == GeneratorTarget.JvmApi || file.Key == GeneratorTarget.JvmProxy || file.Key == GeneratorTarget.JvmStatic)
                {
                    JavaGenerator.GenerateFile(file.Value);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

            model.Pass = ProxyGenPass.P9999_FilesDumped;
            return false;
        }
    }
}
