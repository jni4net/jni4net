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
using System.Reflection;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    /// <summary>
    /// Generator for Java interface
    /// </summary>
    internal class JVMInterfaceGenerator : JVMGenerator
    {
        public JVMInterfaceGenerator(GType type) : base(type)
        {
        }

        protected override void Generate()
        {
            if (!type.IsSkipJVMInterface)
            {
                base.Generate();
            }
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            GenerateInterface(nameSpace);
        }

        private void GenerateInterface(CodeNamespace nameSpace)
        {
            var tgtType = new CodeTypeDeclaration(type.Name);
            SetCurrentType(type.JVMNamespace + "." + type.Name);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.Public;
            tgtType.IsInterface = true;
            tgtType.AddAttribute("net.sf.jni4net.attributes.ClrInterface");

            foreach (GType ifc in type.Interfaces)
            {
                if (ifc.IsJVMGenerate || ifc.IsJVMType)
                {
                    tgtType.BaseTypes.Add(ifc.JVMReference);
                }
            }

            CodeMemberMethod first = null;
            CodeMemberMethod last = null;
            if (type.Registration == null || !type.Registration.NoMethods)
            {
                // dump java side methods first, they will be replaced by oldFile eventually
                foreach (GMethod method in type.Methods)
                {
                    if (method.IsJVMMethod)
                    {
                        last = CreateMethodSignature(method, true);
                        tgtType.Members.Add(last);
                    }
                }

                // now dump methods which are found on CLR side
                foreach (GMethod method in type.Methods)
                {
                    if (method.IsCLRMethod)
                    {
                        last = CreateMethodSignature(method, false);
                        tgtType.Members.Add(last);
                        if (first == null)
                        {
                            first = last;
                        }
                    }
                }
            }

            // if there is at leat one, put magic block around
            if (first != null)
            {
                first.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, sMagicIface));
                last.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, eMagicIface));
            }
            else if (last!=null)
            {
                last.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, sMagicIface));
                last.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, eMagicIface));
            }
        }

    }
}
