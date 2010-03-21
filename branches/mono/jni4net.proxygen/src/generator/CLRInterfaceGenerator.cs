﻿#region Copyright (C) 2009 by Pavel Savara

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
using System.Reflection;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    /// <summary>
    /// Generator for CLR interface
    /// </summary>
    internal class CLRInterfaceGenerator : CLRGenerator
    {
        public CLRInterfaceGenerator(GType type) : base(type)
        {
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            if (!type.IsSkipCLRInterface)
            {
                GenerateInterface(nameSpace);
            }
            if (!config.SkipInterfaceTypeInfo)
            {
                GenerateStatic(nameSpace);
            }
            GenerateProxy(nameSpace);
        }

        private void GenerateInterface(CodeNamespace nameSpace)
        {
            var tgtType = new CodeTypeDeclaration(type.Name);
            SetCurrentType(type.JVMNamespace + "." + type.Name);
            AddTypeCLR(CurrentType.BaseType);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.Public;
            tgtType.IsInterface = true;
            tgtType.IsPartial = true;
            Utils.AddAttribute(tgtType, "net.sf.jni4net.attributes.JavaInterfaceAttribute");

            foreach (GType ifc in type.Interfaces)
            {
                if (ifc.IsCLRGenerate || ifc.IsCLRType)
                {
                    tgtType.BaseTypes.Add(ifc.CLRReference);
                }
            }

            if (type.Registration == null || !type.Registration.NoMethods)
            {
                // dump java side methods
                // CLR methods should be in partial file
                foreach (GMethod method in type.Methods)
                {
                    if (method.IsJVMMethod && !method.IsField)
                    {
                        CreateMethodSignature(tgtType, method, false);
                    }
                }
            }
            tgtType.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, cdc));
            tgtType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, cdc));
        }
    }
}