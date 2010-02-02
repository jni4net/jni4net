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

namespace net.sf.jni4net.proxygen.generator
{
    public static class Utils
    {
        public static void AddAttribute(CodeTypeDeclaration declaration, string attr)
        {
            declaration.CustomAttributes.Add(
                new CodeAttributeDeclaration(new CodeTypeReference(attr, CodeTypeReferenceOptions.GlobalReference)));
        }

        public static void AddAttribute(CodeTypeMember tgtMethodCLR, string attr, object value)
        {
            CodeAttributeDeclaration declaration = AddAttribute(tgtMethodCLR, attr);
            declaration.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(value)));
        }

        /*public static void AddAttribute(CodeTypeMember tgtMethodCLR, string attr, CodeTypeReference refer)
        {
            CodeAttributeDeclaration declaration = AddAttribute(tgtMethodCLR, attr);
            declaration.Arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(refer)));
        }*/

        public static void AddAttribute(CodeTypeMember tgtMethodCLR, string attr, CodeTypeReference refer, CodeTypeReference refer2)
        {
            CodeAttributeDeclaration declaration = AddAttribute(tgtMethodCLR, attr);
            declaration.Arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(refer)));
            declaration.Arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(refer2)));
        }

        public static CodeAttributeDeclaration AddAttribute(CodeTypeMember tgtMethodCLR, string attr)
        {
            var declaration =
                new CodeAttributeDeclaration(new CodeTypeReference(attr, CodeTypeReferenceOptions.GlobalReference));
            tgtMethodCLR.CustomAttributes.Add(declaration);
            return declaration;
        }
    }
}