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

using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Config;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Services.Compilation;

namespace com.jni4net.proxygen.Services.Generators
{
    public abstract class BaseGeneratorHandler : BaseHandler
    {
        [Dependency]
        public ProjectsGenerator ProjectsGenerator { get; set; }

        [Dependency]
        public ITypeRepository Repository { get; set; }

        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }

        [Dependency]
        public BaseJavaGenerator JavaGenerator { get; set; }

        [Dependency]
        public BaseCSharpGenerator CSharpGenerator { get; set; }
    }

    public abstract class BaseGenerator
    {
        [Dependency]
        public Configurator Configurator { get; set; }

        [Dependency]
        public IKnownTypes KnownTypes { get; set; }


        #region trivial helpers


        #endregion
    }
}
