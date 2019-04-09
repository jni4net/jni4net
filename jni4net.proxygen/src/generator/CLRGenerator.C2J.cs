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
using System.Text;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    internal partial class CLRGenerator
    {
        protected void CreateMethodC2J(GMethod method, CodeTypeDeclaration tgtType, string uName, bool isProxy)
        {
            if (method.IsCLRMethod && !type.IsInterface && !type.IsDelegate)
            {
                return;
            }
            if (isProxy || !type.IsInterface)
            {
                GenerateMethodIdFieldC2J(method, tgtType, uName);
                GenerateMethodRegC2J(method, uName);
            }
            if (method.IsStatic && type.IsInterface && isProxy)
            {
                return;
            }

            CreateMethodC2J(method, tgtType, uName, isProxy, false);

            if (method.IsField && !method.IsFinal)
            {
                CreateMethodC2J(method, tgtType, uName, isProxy, true);
            }
        }

        private void CreateMethodC2J(GMethod method, CodeTypeDeclaration tgtType, string uName, bool isProxy, bool fieldSetter)
        {
            CodeStatementCollection tgtStatements = CreateMethodSignature(tgtType, method, isProxy, fieldSetter);
            GenerateGetEnvC2J(method, tgtStatements);
            CodeMethodInvokeExpression invokeExpression = GenerateInvokeExpressionC2J(method, uName, fieldSetter);
            CodeStatement call = GenerateCallStatementC2J(method, invokeExpression, fieldSetter);

            tgtStatements.Add(call);
            GenerateEndFrameC2J(tgtStatements);
        }

        private void GenerateMethodIdFieldC2J(GMethod method, CodeTypeDeclaration tgtType, string uName)
        {
            CodeMemberField fieldId;
            if (method.IsField)
            {
                fieldId = new CodeMemberField(TypeReference(typeof(FieldId)), uName);
            }
            else
            {
                fieldId = new CodeMemberField(TypeReference(typeof(MethodId)), uName);
            }
            fieldId.Attributes = MemberAttributes.Static | MemberAttributes.FamilyAndAssembly;
            tgtType.Members.Add(fieldId);
        }

        private CodeStatement GenerateCallStatementC2J(GMethod method, CodeExpression invokeExpression, bool fieldSetter)
        {
            CodeStatement call;
            if (method.IsConstructor || method.IsVoid || fieldSetter)
            {
                call = new CodeExpressionStatement(invokeExpression);
            }
            else
            {
                if (method.ReturnType.IsPrimitive)
                {
                    if (method.ReturnType.JVMSubst != null)
                    {
                        invokeExpression = new CodeCastExpression(method.ReturnType.CLRReference, invokeExpression);
                    }
                    call = new CodeMethodReturnStatement(invokeExpression);
                }
                else
                {
                    CodeMethodInvokeExpression conversionExpression = CreateConversionExpressionJ2CParam(method.ReturnType,
                                                                                                    invokeExpression);
                    call = new CodeMethodReturnStatement(conversionExpression);
                }
            }
            return call;
        }

        private CodeMethodInvokeExpression GenerateInvokeExpressionC2J(GMethod method, string uName, bool fieldSetter)
        {
            CodeExpression[] expressions = GetExpressionsC2J(method, uName, fieldSetter);
            string callName = GetCallNameC2J(method, fieldSetter);
            return new CodeMethodInvokeExpression(envVariable, callName, expressions);
        }

        private CodeExpression[] GetExpressionsC2J(GMethod method, string uName, bool fieldSetter)
        {
            int offset = method.IsConstructor || fieldSetter ? 3 : 2;
            var expressions = new CodeExpression[method.Parameters.Count + offset];

            if (method.IsStatic || method.IsConstructor)
            {
                expressions[0] = new CodeFieldReferenceExpression(ProxyTypeEx, "staticClass");
            }
            else
            {
                expressions[0] = new CodeThisReferenceExpression();
            }
            expressions[1] = new CodeFieldReferenceExpression(ProxyTypeEx, uName);
            if (method.IsConstructor)
            {
                expressions[2] = new CodeThisReferenceExpression();
            }
            for (int i = 0; i < method.Parameters.Count; i++)
            {
                GType parameter = method.Parameters[i];
                string paramName = method.ParameterNames[i];
                CodeExpression invokeExpression = new CodeVariableReferenceExpression(paramName);
                CodeMethodInvokeExpression conversionExpression = CreateConversionExpressionC2JParam(parameter, invokeExpression);
                expressions[i + offset] = conversionExpression;
            }

            if (fieldSetter)
            {
                CodeExpression invokeExpression = new CodeVariableReferenceExpression("value");
                if (method.ReturnType.IsPrimitive)
                {
                    expressions[offset - 1] = invokeExpression;
                }
                else
                {
                    CodeMethodInvokeExpression conversionExpression = CreateConversionExpressionC2J(method.ReturnType, invokeExpression);
                    expressions[offset - 1] = conversionExpression;
                }
            }

            return expressions;
        }

        private void GenerateMethodRegC2J(GMethod method, string uName)
        {
            var claxs = new CodeFieldReferenceExpression(CurrentTypeEx, "staticClass");
            string getmethodidthrow = method.IsField
                                          ? method.IsStatic ? "GetStaticFieldID" : "GetFieldID"
                                          : method.IsStatic ? "GetStaticMethodID" : "GetMethodID";
            var initBody =
                new CodeAssignStatement(
                    new CodeFieldReferenceExpression(CurrentTypeEx, uName),
                    new CodeMethodInvokeExpression(
                        envVariable, getmethodidthrow,
                        claxs,
                        new CodePrimitiveExpression(method.JVMName),
                        new CodePrimitiveExpression(method.JVMSignature)));
            InitStatements.Add(initBody);
        }

        private string GetCallNameC2J(GMethod method, bool fieldSetter)
        {
            var callName = new StringBuilder();
            if (method.IsConstructor)
            {
                callName.Append("NewObject");
            }
            else
            {
                if (method.ReturnType != null && method.ReturnType.IsPrimitive)
                {
                    callName.Append(method.ReturnType.JVMResolved);
                    callName[0] = Char.ToUpper(callName[0]);
                }
                else
                {
                    callName.Append("Object");
                }
                if (method.IsStatic)
                {
                    callName.Insert(0, "Static");
                }
                callName.Insert(0, method.IsField ? (fieldSetter ? "Set" : "Get") : "Call");
                callName.Append(method.IsField ? "Field" : "Method");
                if (method.ReturnType != null && !method.ReturnType.IsPrimitive)
                {
                    callName.Append("Ptr");
                }
            }
            return callName.ToString();
        }

        private void GenerateGetEnvC2J(GMethod method, CodeStatementCollection tgtStatements)
        {
            if (method.IsStatic || method.IsConstructor)
            {
                CodeStatement statement =
                    new CodeVariableDeclarationStatement(
                        new CodeTypeReference(typeof (JNIEnv), CodeTypeReferenceOptions.GlobalReference),
                        envVariableName,
                        new CodePropertyReferenceExpression(TypeReferenceEx(typeof (JNIEnv)), "ThreadEnv"));
                tgtStatements.Add(statement);
            }
            else
            {
                CodeStatement statement =
                    new CodeVariableDeclarationStatement(
                        new CodeTypeReference(typeof (JNIEnv), CodeTypeReferenceOptions.GlobalReference),
                        envVariableName,
                        new CodePropertyReferenceExpression
                            (new CodeThisReferenceExpression
                                 (), "Env"));
                tgtStatements.Add(statement);
            }
            int framesize = (10+method.Parameters.Count*2);
            tgtStatements.Add(new CodeSnippetStatement("            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, "+framesize+")){"));
        }

        private void GenerateEndFrameC2J(CodeStatementCollection tgtStatements)
        {
            tgtStatements.Add(new CodeSnippetStatement("            }"));
        }
    }
}