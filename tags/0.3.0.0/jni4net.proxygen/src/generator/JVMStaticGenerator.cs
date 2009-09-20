#region Copyright (C) 2009 by Pavel Savara

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

using System.CodeDom;
using System.IO;
using System.Reflection;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    internal class JVMStaticGenerator : JVMGenerator
    {
        public JVMStaticGenerator(GType type) : base(type)
        {
        }

        protected override string GetFileName(string dirJava)
        {
            return Path.Combine(dirJava, type.Name + "_.java");
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            if (!config.SkipInterfaceTypeInfo)
            {
                GenerateStatic(nameSpace);
            }
        }

        private void GenerateStatic(CodeNamespace nameSpace)
        {
            // static helper type
            var tgtType = new CodeTypeDeclaration(type.Name + "_");
            SetCurrentType(type.JVMNamespaceExt + "." + type.Name + "_", type.JVMNamespace + "." + type.Name,
                           type.JVMNamespaceExt + ".__" + type.Name);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;
            Utils.AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrTypeInfo");

            // fields with type information
            GenerateTypeOfInit(tgtType);


            WrapMethodsMagic(tgtType, sMagicStatic, eMagicStatic);
        }
    }
}