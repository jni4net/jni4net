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

using System;
using System.CodeDom;

namespace net.sf.jni4net.proxygen.generator
{
    internal partial class Generator
    {
        protected static string classVariableName = "__class";
        protected static string envpVariableName = "__envp";
        protected static string envVariableName = "__env";
        protected static string handleVariableName = "__handle";
        protected static string objVariableName = "__obj";
        protected static string realVariableName = "__real";
        protected static string typeVariableName = "__type";
        protected CodeVariableReferenceExpression envVariable = new CodeVariableReferenceExpression(envVariableName);
        protected CodeVariableReferenceExpression objVariable = new CodeVariableReferenceExpression(objVariableName);
        protected CodeVariableReferenceExpression realVariable = new CodeVariableReferenceExpression(realVariableName);

        protected CodeTypeReferenceExpression CurrentTypeEx { get; set; }

        protected CodeTypeReference CurrentType { get; set; }

        protected CodeTypeReferenceExpression RealTypeEx { get; set; }

        protected CodeTypeReference RealType { get; set; }

        protected CodeTypeReferenceExpression ProxyTypeEx { get; set; }

        protected CodeTypeReference ProxyType { get; set; }

        public static CodeTypeReference TypeReference(string src)
        {
            return new CodeTypeReference(src, CodeTypeReferenceOptions.GlobalReference);
        }

        public static CodeTypeReference TypeReference(Type src)
        {
            return new CodeTypeReference(src, CodeTypeReferenceOptions.GlobalReference);
        }

        public static CodeTypeReferenceExpression TypeReferenceEx(Type src)
        {
            return new CodeTypeReferenceExpression(new CodeTypeReference(src, CodeTypeReferenceOptions.GlobalReference));
        }

        public static CodeTypeReferenceExpression TypeReferenceEx(string src)
        {
            return new CodeTypeReferenceExpression(new CodeTypeReference(src, CodeTypeReferenceOptions.GlobalReference));
        }

        protected void CreateEnvConstructor(CodeTypeDeclaration tgtType, string envType, bool pub, bool handle)
        {
            if (type.IsRootType)
            {
                return;
            }
            var cc = new CodeConstructor();
            cc.Attributes = pub ? MemberAttributes.FamilyOrAssembly : MemberAttributes.Family;
            cc.Parameters.Add(
                new CodeParameterDeclarationExpression(TypeReference(envType), envVariableName));
            if (handle)
            {
                cc.Parameters.Add(
                    new CodeParameterDeclarationExpression(TypeReference("int"), handleVariableName));
            }
            cc.BaseConstructorArgs.Add(envVariable);
            if (handle)
            {
                cc.BaseConstructorArgs.Add(new CodeVariableReferenceExpression(handleVariableName));
            }
            tgtType.Members.Add(cc);
        }
    }
}