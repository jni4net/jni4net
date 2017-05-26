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
using System.CodeDom.Compiler;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace net.sf.jni4net.proxygen.generator
{
    internal class JavaCodeGenerator : CodeGenerator
    {
        private static readonly string[] keywords = new[]
                                                        {
                                                            "abstract", "assert", "break", "case", "catch",
                                                            //"class",
                                                            "const",
                                                            "continue", "default", "do", "else", "enum", "extends",
                                                            "final",
                                                            "finally", "for", "goto", "if", "implements", "import",
                                                            "instanceof",
                                                            "interface", "native", "new", "package", "private",
                                                            "protected", "public",
                                                            "return", "static", "strictfp", "super", "switch",
                                                            "synchronized", "this",
                                                            "throw", "throws", "transient", "try", "volatile", "while",
                                                            "boolean",
                                                            "byte", "char", "double", "float", "int", "long", "short",
                                                            "void",
                                                        };

        private static Hashtable keywordsTable;

        private bool dont_write_semicolon;

        protected override string NullToken
        {
            get { return "null"; }
        }

        protected override void GenerateArrayCreateExpression(CodeArrayCreateExpression expression)
        {
            TextWriter output = Output;

            output.Write("new ");

            CodeExpressionCollection initializers = expression.Initializers;
            CodeTypeReference createType = expression.CreateType;

            if (initializers.Count > 0)
            {
                OutputType(createType);

                if (expression.CreateType.ArrayRank == 0)
                {
                    output.Write("[]");
                }

                OutputStartBrace();
                ++Indent;
                OutputExpressionList(initializers, true);
                --Indent;
                output.Write("}");
            }
            else
            {
                CodeTypeReference arrayType = createType.ArrayElementType;
                while (arrayType != null)
                {
                    createType = arrayType;
                    arrayType = arrayType.ArrayElementType;
                }

                OutputType(createType);

                output.Write('[');

                CodeExpression size = expression.SizeExpression;
                if (size != null)
                    GenerateExpression(size);
                else
                    output.Write(expression.Size);

                output.Write(']');
            }
        }

        protected override void GenerateBaseReferenceExpression(CodeBaseReferenceExpression expression)
        {
            Output.Write("super");
        }

        protected override void GenerateCastExpression(CodeCastExpression expression)
        {
            TextWriter output = Output;
            output.Write("((");
            OutputType(expression.TargetType);
            output.Write(")(");
            GenerateExpression(expression.Expression);
            output.Write("))");
        }


        protected override void GenerateCompileUnitStart(CodeCompileUnit compileUnit)
        {
            GenerateComment(
                new CodeComment("------------------------------------------------------------------------------"));
            GenerateComment(new CodeComment(" <autogenerated>"));
            GenerateComment(new CodeComment("     This code was generated by a tool."));
            GenerateComment(new CodeComment(""));
            GenerateComment(
                new CodeComment("     Changes to this file may cause incorrect behavior and will be lost if "));
            GenerateComment(new CodeComment("     the code is regenerated."));
            GenerateComment(new CodeComment(" </autogenerated>"));
            GenerateComment(
                new CodeComment("------------------------------------------------------------------------------"));
            Output.WriteLine();
            base.GenerateCompileUnitStart(compileUnit);
        }

        protected override void GenerateCompileUnit(CodeCompileUnit compileUnit)
        {
            GenerateCompileUnitStart(compileUnit);

            foreach (CodeNamespace ns in compileUnit.Namespaces)
                GenerateNamespace(ns);

            GenerateCompileUnitEnd(compileUnit);
        }

        protected override void GenerateDelegateCreateExpression(CodeDelegateCreateExpression expression)
        {
            throw new NotSupportedException();
        }

        protected override void GenerateFieldReferenceExpression(CodeFieldReferenceExpression expression)
        {
            CodeExpression targetObject = expression.TargetObject;
            if (targetObject != null)
            {
                GenerateExpression(targetObject);
                Output.Write('.');
            }
            Output.Write(GetSafeName(expression.FieldName));
        }

        protected override void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression expression)
        {
            Output.Write(GetSafeName(expression.ParameterName));
        }

        protected override void GenerateVariableReferenceExpression(CodeVariableReferenceExpression expression)
        {
            Output.Write(GetSafeName(expression.VariableName));
        }

        protected override void GenerateIndexerExpression(CodeIndexerExpression expression)
        {
            TextWriter output = Output;

            GenerateExpression(expression.TargetObject);
            output.Write('[');
            OutputExpressionList(expression.Indices);
            output.Write(']');
        }

        protected override void GenerateArrayIndexerExpression(CodeArrayIndexerExpression expression)
        {
            TextWriter output = Output;

            GenerateExpression(expression.TargetObject);
            output.Write('[');
            OutputExpressionList(expression.Indices);
            output.Write(']');
        }

        protected override void GenerateSnippetExpression(CodeSnippetExpression expression)
        {
            Output.Write(expression.Value);
        }

        protected override void GenerateMethodInvokeExpression(CodeMethodInvokeExpression expression)
        {
            TextWriter output = Output;

            GenerateMethodReferenceExpression(expression.Method);

            output.Write('(');
            OutputExpressionList(expression.Parameters);
            output.Write(')');
        }

        protected override void GenerateMethodReferenceExpression(CodeMethodReferenceExpression expression)
        {
            if (expression.TargetObject != null)
            {
                GenerateExpression(expression.TargetObject);
                Output.Write('.');
            }
            Output.Write(GetSafeName(expression.MethodName));
        }

        protected override void GenerateEventReferenceExpression(CodeEventReferenceExpression expression)
        {
            if (expression.TargetObject != null)
            {
                GenerateExpression(expression.TargetObject);
                Output.Write('.');
            }
            Output.Write(GetSafeName(expression.EventName));
        }

        protected override void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression expression)
        {
            throw new NotSupportedException();
        }

        protected override void GenerateObjectCreateExpression(CodeObjectCreateExpression expression)
        {
            Output.Write("new ");
            OutputType(expression.CreateType);
            Output.Write('(');
            OutputExpressionList(expression.Parameters);
            Output.Write(')');
        }

        protected override void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression expression)
        {
            CodeExpression targetObject = expression.TargetObject;
            if (targetObject != null)
            {
                GenerateExpression(targetObject);
                Output.Write('.');
            }
            Output.Write(GetSafeName(expression.PropertyName));
        }

        protected override void GeneratePropertySetValueReferenceExpression(
            CodePropertySetValueReferenceExpression expression)
        {
            Output.Write("value");
        }

        protected override void GenerateThisReferenceExpression(CodeThisReferenceExpression expression)
        {
            Output.Write("this");
        }

        protected override void GenerateExpressionStatement(CodeExpressionStatement statement)
        {
            GenerateExpression(statement.Expression);
            if (dont_write_semicolon)
                return;
            Output.WriteLine(';');
        }

        protected override void GenerateIterationStatement(CodeIterationStatement statement)
        {
            TextWriter output = Output;

            dont_write_semicolon = true;
            output.Write("for (");
            GenerateStatement(statement.InitStatement);
            output.Write("; ");
            GenerateExpression(statement.TestExpression);
            output.Write("; ");
            GenerateStatement(statement.IncrementStatement);
            output.Write(")");
            dont_write_semicolon = false;
            OutputStartBrace();
            ++Indent;
            GenerateStatements(statement.Statements);
            --Indent;
            output.WriteLine('}');
        }

        protected override void GenerateThrowExceptionStatement(CodeThrowExceptionStatement statement)
        {
            Output.Write("throw");
            if (statement.ToThrow != null)
            {
                Output.Write(' ');
                GenerateExpression(statement.ToThrow);
            }
            Output.WriteLine(";");
        }

        protected override void GenerateComment(CodeComment comment)
        {
            TextWriter output = Output;

            string commentChars = null;

            if (comment.DocComment)
            {
                commentChars = "///";
            }
            else
            {
                commentChars = "//";
            }

            output.Write(commentChars);
            output.Write(' ');
            string text = comment.Text;

            for (int i = 0; i < text.Length; i++)
            {
                output.Write(text[i]);
                if (text[i] == '\r')
                {
                    if (i < (text.Length - 1) && text[i + 1] == '\n')
                    {
                        continue;
                    }
                    output.Write(commentChars);
                }
                else if (text[i] == '\n')
                {
                    output.Write(commentChars);
                }
            }

            output.WriteLine();
        }

        protected override void GenerateMethodReturnStatement(CodeMethodReturnStatement statement)
        {
            TextWriter output = Output;

            if (statement.Expression != null)
            {
                output.Write("return ");
                GenerateExpression(statement.Expression);
                output.WriteLine(";");
            }
            else
            {
                output.WriteLine("return;");
            }
        }

        protected override void GenerateConditionStatement(CodeConditionStatement statement)
        {
            TextWriter output = Output;
            output.Write("if (");
            GenerateExpression(statement.Condition);
            output.Write(")");
            OutputStartBrace();

            ++Indent;
            GenerateStatements(statement.TrueStatements);
            --Indent;

            CodeStatementCollection falses = statement.FalseStatements;
            if (falses.Count > 0)
            {
                output.Write('}');
                if (Options.ElseOnClosing)
                    output.Write(' ');
                else
                    output.WriteLine();
                output.Write("else");
                OutputStartBrace();
                ++Indent;
                GenerateStatements(falses);
                --Indent;
            }
            output.WriteLine('}');
        }

        protected override void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement statement)
        {
            TextWriter output = Output;
            CodeGeneratorOptions options = Options;

            output.Write("try");
            OutputStartBrace();
            ++Indent;
            GenerateStatements(statement.TryStatements);
            --Indent;

            foreach (CodeCatchClause clause in statement.CatchClauses)
            {
                output.Write('}');
                if (options.ElseOnClosing)
                    output.Write(' ');
                else
                    output.WriteLine();
                output.Write("catch (");
                OutputTypeNamePair(clause.CatchExceptionType, GetSafeName(clause.LocalName));
                output.Write(")");
                OutputStartBrace();
                ++Indent;
                GenerateStatements(clause.Statements);
                --Indent;
            }

            CodeStatementCollection finallies = statement.FinallyStatements;
            if (finallies.Count > 0)
            {
                output.Write('}');
                if (options.ElseOnClosing)
                    output.Write(' ');
                else
                    output.WriteLine();
                output.Write("finally");
                OutputStartBrace();
                ++Indent;
                GenerateStatements(finallies);
                --Indent;
            }

            output.WriteLine('}');
        }

        protected override void GenerateAssignStatement(CodeAssignStatement statement)
        {
            TextWriter output = Output;
            GenerateExpression(statement.Left);
            output.Write(" = ");
            GenerateExpression(statement.Right);
            if (dont_write_semicolon)
                return;
            output.WriteLine(';');
        }

        protected override void GenerateAttachEventStatement(CodeAttachEventStatement statement)
        {
            TextWriter output = Output;

            GenerateEventReferenceExpression(statement.Event);
            output.Write(" += ");
            GenerateExpression(statement.Listener);
            output.WriteLine(';');
        }

        protected override void GenerateRemoveEventStatement(CodeRemoveEventStatement statement)
        {
            TextWriter output = Output;
            GenerateEventReferenceExpression(statement.Event);
            output.Write(" -= ");
            GenerateExpression(statement.Listener);
            output.WriteLine(';');
        }

        protected override void GenerateGotoStatement(CodeGotoStatement statement)
        {
            throw new NotSupportedException();
        }

        protected override void GenerateLabeledStatement(CodeLabeledStatement statement)
        {
            throw new NotSupportedException();
        }

        protected override void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement statement)
        {
            TextWriter output = Output;

            OutputTypeNamePair(statement.Type, GetSafeName(statement.Name));

            CodeExpression initExpression = statement.InitExpression;
            if (initExpression != null)
            {
                output.Write(" = ");
                GenerateExpression(initExpression);
            }

            if (!dont_write_semicolon)
            {
                output.WriteLine(';');
            }
        }

        protected override void GenerateLinePragmaStart(CodeLinePragma linePragma)
        {
            throw new NotSupportedException();
        }

        protected override void GenerateLinePragmaEnd(CodeLinePragma linePragma)
        {
            throw new NotSupportedException();
        }

        protected override void GenerateEvent(CodeMemberEvent eventRef, CodeTypeDeclaration declaration)
        {
            throw new NotSupportedException();
        }

        protected override void GenerateField(CodeMemberField field)
        {
            if (IsCurrentDelegate || IsCurrentInterface)
            {
                return;
            }

            TextWriter output = Output;

            OutputAttributes(field.CustomAttributes, null, false);

            if (IsCurrentEnum)
            {
                Output.Write(GetSafeName(field.Name));
            }
            else
            {
                MemberAttributes attributes = field.Attributes;
                OutputMemberAccessModifier(attributes);
                OutputVTableModifier(attributes);
                OutputFieldScopeModifier(attributes);

                OutputTypeNamePair(field.Type, GetSafeName(field.Name));
            }

            CodeExpression initExpression = field.InitExpression;
            if (initExpression != null)
            {
                output.Write(" = ");
                GenerateExpression(initExpression);
            }

            if (IsCurrentEnum)
                output.WriteLine(',');
            else
                output.WriteLine(';');
        }

        protected override void GenerateSnippetMember(CodeSnippetTypeMember member)
        {
            Output.Write(member.Text);
        }

        protected override void GenerateEntryPointMethod(CodeEntryPointMethod method,
                                                         CodeTypeDeclaration declaration)
        {
            OutputAttributes(method.CustomAttributes, null, false);
            Output.Write("public static ");
            OutputType(method.ReturnType);
            Output.Write(" Main()");
            OutputStartBrace();
            Indent++;
            GenerateStatements(method.Statements);
            Indent--;
            Output.WriteLine("}");
        }

        protected override void GenerateMethod(CodeMemberMethod method,
                                               CodeTypeDeclaration declaration)
        {
            if (IsCurrentDelegate || IsCurrentEnum)
            {
                return;
            }

            TextWriter output = Output;

            OutputAttributes(method.CustomAttributes, null, false);

            if (method.ReturnTypeCustomAttributes != null && method.ReturnTypeCustomAttributes.Count > 0)
            {
                throw new NotSupportedException("method.ReturnTypeCustomAttributes");
            }

            MemberAttributes attributes = method.Attributes;

            if (!IsCurrentInterface)
            {
                if (method.PrivateImplementationType == null)
                {
                    OutputMemberAccessModifier(attributes);
                    OutputVTableModifier(attributes);
                    OutputMemberScopeModifier(attributes);
                }
            }
            else
            {
                OutputVTableModifier(attributes);
            }

            OutputType(method.ReturnType);
            output.Write(' ');

            CodeTypeReference privateType = method.PrivateImplementationType;
            if (privateType != null)
            {
                output.Write(privateType.BaseType);
                output.Write('.');
            }
            output.Write(GetSafeName(method.Name));
            output.Write('(');
            OutputParameters(method.Parameters);
            output.Write(')');

            if ((attributes & MemberAttributes.ScopeMask) == MemberAttributes.Abstract || declaration.IsInterface
                || (attributes & MemberAttributes.VTableMask) == MemberAttributes.New)
                output.WriteLine(';');
            else
            {
                OutputStartBrace();
                ++Indent;
                GenerateStatements(method.Statements);
                --Indent;
                output.WriteLine('}');
            }
        }


        //TODO ZAMO
        protected override void GenerateProperty(CodeMemberProperty property,
                                                 CodeTypeDeclaration declaration)
        {
            if (IsCurrentDelegate || IsCurrentEnum)
            {
                return;
            }

            TextWriter output = Output;

            OutputAttributes(property.CustomAttributes, null, false);

            MemberAttributes attributes = property.Attributes;

            if (!IsCurrentInterface)
            {
                if (property.PrivateImplementationType == null)
                {
                    OutputMemberAccessModifier(attributes);
                    OutputVTableModifier(attributes);
                    OutputMemberScopeModifier(attributes);
                }
            }
            else
            {
                OutputVTableModifier(attributes);
            }

            OutputType(property.Type);
            output.Write(' ');

            if (!IsCurrentInterface && property.PrivateImplementationType != null)
            {
                output.Write(property.PrivateImplementationType.BaseType);
                output.Write('.');
            }

            // only consider property indexer if name is Item (case-insensitive 
            // comparison) AND property has parameters
            if (string.Compare(property.Name, "Item", true, CultureInfo.InvariantCulture) == 0 &&
                property.Parameters.Count > 0)
            {
                output.Write("this[");
                OutputParameters(property.Parameters);
                output.Write(']');
            }
            else
            {
                output.Write(GetSafeName(property.Name));
            }
            OutputStartBrace();
            ++Indent;

            if (declaration.IsInterface)
            {
                if (property.HasGet) output.WriteLine("get;");
                if (property.HasSet) output.WriteLine("set;");
            }
            else
            {
                if (property.HasGet)
                {
                    output.Write("get");
                    OutputStartBrace();
                    ++Indent;

                    GenerateStatements(property.GetStatements);

                    --Indent;
                    output.WriteLine('}');
                }

                if (property.HasSet)
                {
                    output.Write("set");
                    OutputStartBrace();
                    ++Indent;

                    GenerateStatements(property.SetStatements);

                    --Indent;
                    output.WriteLine('}');
                }
            }

            --Indent;
            output.WriteLine('}');
        }

        protected override void GenerateConstructor(CodeConstructor constructor, CodeTypeDeclaration declaration)
        {
            if (IsCurrentDelegate || IsCurrentEnum || IsCurrentInterface)
            {
                return;
            }

            OutputAttributes(constructor.CustomAttributes, null, false);

            OutputMemberAccessModifier(constructor.Attributes);
            Output.Write(GetSafeName(CurrentTypeName) + "(");
            OutputParameters(constructor.Parameters);
            Output.Write(")");
            OutputStartBrace();
            Indent++;

            if (constructor.BaseConstructorArgs.Count > 0)
            {
                Indent += 1;
                Output.Write("super(");
                OutputExpressionList(constructor.BaseConstructorArgs);
                Output.WriteLine(");");
                Indent -= 1;
            }
            if (constructor.ChainedConstructorArgs.Count > 0)
            {
                Indent += 1;
                Output.Write("this(");
                OutputExpressionList(constructor.ChainedConstructorArgs);
                Output.WriteLine(");");
                Indent -= 1;
            }

            GenerateStatements(constructor.Statements);
            Indent--;
            Output.WriteLine('}');
        }

        protected override void GenerateTypeConstructor(CodeTypeConstructor constructor)
        {
            if (IsCurrentDelegate || IsCurrentEnum || IsCurrentInterface)
            {
                return;
            }

            OutputAttributes(constructor.CustomAttributes, null, false);
            Output.Write("static ");
            OutputStartBrace();
            Indent++;
            GenerateStatements(constructor.Statements);
            Indent--;
            Output.WriteLine('}');
        }

        //TODO ZAMO
        protected override void GenerateTypeStart(CodeTypeDeclaration declaration)
        {
            TextWriter output = Output;

            OutputAttributes(declaration.CustomAttributes, null, false);

            if (!IsCurrentDelegate)
            {
                OutputTypeAttributes(declaration);

                output.Write(GetSafeName(declaration.Name));

                IEnumerator enumerator = declaration.BaseTypes.GetEnumerator();
                if (enumerator.MoveNext())
                {
                    var type = (CodeTypeReference) enumerator.Current;
                    if (type.BaseType == "net.sf.jni4net.inj.IClrProxy" && !CurrentClass.IsInterface)
                    {
                        output.Write(" implements ");
                    }
                    else
                    {
                        output.Write(" extends ");
                    }
                    OutputType(type);
                    bool clazz = !CurrentClass.IsInterface;

                    while (enumerator.MoveNext())
                    {
                        type = (CodeTypeReference) enumerator.Current;

                        if (clazz)
                        {
                            output.Write(" implements ");
                            clazz = false;
                        }
                        else
                        {
                            output.Write(", ");
                        }
                        OutputType(type);
                    }
                }

                OutputStartBrace();
                ++Indent;
            }
            else
            {
                if ((declaration.TypeAttributes & TypeAttributes.VisibilityMask) == TypeAttributes.Public)
                {
                    output.Write("public ");
                }

                var delegateDecl = (CodeTypeDelegate) declaration;
                output.Write("delegate ");
                OutputType(delegateDecl.ReturnType);
                output.Write(" ");
                output.Write(GetSafeName(declaration.Name));
                output.Write("(");
                OutputParameters(delegateDecl.Parameters);
                output.WriteLine(");");
            }
        }

        protected override void GenerateTypeEnd(CodeTypeDeclaration declaration)
        {
            if (!IsCurrentDelegate)
            {
                --Indent;
                Output.WriteLine("}");
            }
        }

        protected override void GenerateNamespaceStart(CodeNamespace ns)
        {
            TextWriter output = Output;

            string name = ns.Name;
            if (name != null && name.Length != 0)
            {
                output.Write("package ");
                output.Write(GetSafeName(name));
                output.Write(";");
            }
        }

        protected override void GenerateNamespaceEnd(CodeNamespace ns)
        {
        }

        protected override void GenerateNamespaceImport(CodeNamespaceImport import)
        {
            TextWriter output = Output;

            output.Write("import ");
            output.Write(GetSafeName(import.Namespace));
            output.WriteLine(';');
        }

        protected override void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes)
        {
        }

        protected override void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection attributes)
        {
        }

        private void OutputStartBrace()
        {
            if (Options.BracingStyle == "C")
            {
                Output.WriteLine("");
                Output.WriteLine("{");
            }
            else
            {
                Output.WriteLine(" {");
            }
        }

        private void OutputAttributes(CodeAttributeDeclarationCollection attributes, string prefix, bool inline)
        {
            foreach (CodeAttributeDeclaration att in attributes)
            {
                GenerateAttributeDeclarationsStart(attributes);
                Output.Write('@');
                if (prefix != null)
                {
                    Output.Write(prefix);
                }
                OutputAttributeDeclaration(att);
                GenerateAttributeDeclarationsEnd(attributes);
                if (inline)
                {
                    Output.Write(" ");
                }
                else
                {
                    Output.WriteLine();
                }
            }
        }

        private void OutputAttributeDeclaration(CodeAttributeDeclaration attribute)
        {
            Output.Write(attribute.Name.Replace('+', '.'));
            IEnumerator enumerator = attribute.Arguments.GetEnumerator();
            if (enumerator.MoveNext())
            {
                Output.Write('(');
                var argument = (CodeAttributeArgument) enumerator.Current;
                OutputAttributeArgument(argument);

                while (enumerator.MoveNext())
                {
                    Output.Write(", ");
                    argument = (CodeAttributeArgument) enumerator.Current;
                    OutputAttributeArgument(argument);
                }
                Output.Write(')');
            }
        }

        private void OutputVTableModifier(MemberAttributes attributes)
        {
            if ((attributes & MemberAttributes.VTableMask) == MemberAttributes.New)
            {
                Output.Write("native ");
            }
        }

        protected override void OutputFieldScopeModifier(MemberAttributes attributes)
        {
            switch (attributes & MemberAttributes.ScopeMask)
            {
                case MemberAttributes.Static:
                    Output.Write("static ");
                    break;
                case MemberAttributes.Const:
                    Output.Write("const ");
                    break;
            }
        }

        protected override void OutputMemberAccessModifier(MemberAttributes attributes)
        {
            switch (attributes & MemberAttributes.AccessMask)
            {
                case MemberAttributes.Assembly:
                case MemberAttributes.FamilyAndAssembly:
                    //Output.Write("internal ");
                    break;
                case MemberAttributes.Family:
                    Output.Write("protected ");
                    break;
                case MemberAttributes.FamilyOrAssembly:
                    //Output.Write("protected internal ");
                    break;
                case MemberAttributes.Private:
                    Output.Write("private ");
                    break;
                case MemberAttributes.Public:
                    Output.Write("public ");
                    break;
            }
        }

        protected override void OutputMemberScopeModifier(MemberAttributes attributes)
        {
            switch (attributes & MemberAttributes.ScopeMask)
            {
                case MemberAttributes.Abstract:
                    Output.Write("abstract ");
                    break;
                case MemberAttributes.Final:
                    // do nothing
                    Output.Write("final ");
                    break;
                case MemberAttributes.Static:
                    Output.Write("static ");
                    break;
                case MemberAttributes.Override:
                    //TODO annotation Output.Write("override ");
                    break;
                default:
                    MemberAttributes access = attributes & MemberAttributes.AccessMask;
                    if (access == MemberAttributes.Assembly || access == MemberAttributes.Family ||
                        access == MemberAttributes.Public)
                    {
                        //Output.Write("virtual ");
                    }
                    break;
            }
        }

        private void OutputTypeAttributes(CodeTypeDeclaration declaration)
        {
            TextWriter output = Output;
            TypeAttributes attributes = declaration.TypeAttributes;

            switch (attributes & TypeAttributes.VisibilityMask)
            {
                case TypeAttributes.Public:
                case TypeAttributes.NestedPublic:
                    output.Write("public ");
                    break;
                case TypeAttributes.NestedPrivate:
                    output.Write("private ");
                    break;
                case TypeAttributes.NotPublic:
                case TypeAttributes.NestedFamANDAssem:
                case TypeAttributes.NestedAssembly:
                    //output.Write("internal ");
                    break;
                case TypeAttributes.NestedFamily:
                    output.Write("protected ");
                    break;
                case TypeAttributes.NestedFamORAssem:
                    //output.Write("protected internal ");
                    break;
            }

            if (declaration.IsStruct)
            {
                output.Write("struct ");
            }
            else if (declaration.IsEnum)
            {
                output.Write("enum ");
            }
            else
            {
                if ((attributes & TypeAttributes.Interface) != 0)
                {
                    output.Write("interface ");
                }
                else
                {
                    if (((attributes & (TypeAttributes.Sealed | TypeAttributes.Abstract)) ==
                         (TypeAttributes.Sealed | TypeAttributes.Abstract)))
                    {
                        output.Write("static ");
                    }
                    else
                    {
                        if ((attributes & TypeAttributes.Sealed) != 0)
                            output.Write("final ");
                        if ((attributes & TypeAttributes.Abstract) != 0)
                            output.Write("abstract ");
                    }
                    output.Write("class ");
                }
            }
        }

        protected override string QuoteSnippetString(string value)
        {
            // FIXME: this is weird, but works.
            string output = value.Replace("\\", "\\\\");
            output = output.Replace("\"", "\\\"");
            output = output.Replace("\t", "\\t");
            output = output.Replace("\r", "\\r");
            output = output.Replace("\n", "\\n");

            return "\"" + output + "\"";
        }

        protected override void GeneratePrimitiveExpression(CodePrimitiveExpression e)
        {
            if (e.Value is char)
            {
                GenerateCharValue((char) e.Value);
            }
            else if (e.Value is ushort)
            {
                var uc = (ushort) e.Value;
                Output.Write(uc.ToString(CultureInfo.InvariantCulture));
            }
            else if (e.Value is uint)
            {
                var ui = (uint) e.Value;
                Output.Write(ui.ToString(CultureInfo.InvariantCulture));
                Output.Write("u");
            }
            else if (e.Value is ulong)
            {
                var ul = (ulong) e.Value;
                Output.Write(ul.ToString(CultureInfo.InvariantCulture));
                Output.Write("ul");
            }
            else if (e.Value is sbyte)
            {
                var sb = (sbyte) e.Value;
                Output.Write(sb.ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                base.GeneratePrimitiveExpression(e);
            }
        }

        private void GenerateCharValue(char c)
        {
            Output.Write('\'');

            switch (c)
            {
                case '\0':
                    Output.Write("\\0");
                    break;
                case '\t':
                    Output.Write("\\t");
                    break;
                case '\n':
                    Output.Write("\\n");
                    break;
                case '\r':
                    Output.Write("\\r");
                    break;
                case '"':
                    Output.Write("\\\"");
                    break;
                case '\'':
                    Output.Write("\\'");
                    break;
                case '\\':
                    Output.Write("\\\\");
                    break;
                case '\u2028':
                    Output.Write("\\u");
                    Output.Write(((int) c).ToString("X4", CultureInfo.InvariantCulture));
                    break;
                case '\u2029':
                    Output.Write("\\u");
                    Output.Write(((int) c).ToString("X4", CultureInfo.InvariantCulture));
                    break;
                default:
                    Output.Write(c);
                    break;
            }

            Output.Write('\'');
        }

        protected override void GenerateSingleFloatValue(float f)
        {
            base.GenerateSingleFloatValue(f);
            base.Output.Write('F');
        }

        protected override void GenerateDecimalValue(decimal d)
        {
            base.GenerateDecimalValue(d);
            base.Output.Write('m');
        }

        protected override void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e)
        {
            OutputAttributes(e.CustomAttributes, null, true);
            OutputDirection(e.Direction);
            OutputType(e.Type);
            Output.Write(' ');
            Output.Write(GetSafeName(e.Name));
        }

        protected override void GenerateTypeOfExpression(CodeTypeOfExpression e)
        {
            Output.Write("typeof(");
            OutputType(e.Type);
            Output.Write(")");
        }

        protected override string CreateEscapedIdentifier(string value)
        {
            if (value == null)
                throw new NullReferenceException("Argument identifier is null.");
            return GetSafeName(value);
        }

        protected override string CreateValidIdentifier(string value)
        {
            if (value == null)
                throw new NullReferenceException();

            if (keywordsTable == null)
                FillKeywordTable();

            if (keywordsTable.Contains(value))
                return "_" + value;
            else
                return value;
        }

        private static bool is_identifier_start_character(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_' || c == '@' || Char.IsLetter(c);
        }

        private static bool is_identifier_part_character(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_' || (c >= '0' && c <= '9') ||
                   Char.IsLetter(c)
                ;
        }

        protected override bool IsValidIdentifier(string identifier)
        {
            if (string.IsNullOrEmpty(identifier))
                return false;

            if (keywordsTable == null)
                FillKeywordTable();

            if (keywordsTable.Contains(identifier))
                return false;

            if (!is_identifier_start_character(identifier[0]))
                return false;

            for (int i = 1; i < identifier.Length; i++)
                if (!is_identifier_part_character(identifier[i]))
                    return false;

            return true;
        }


        protected override void OutputType(CodeTypeReference typeRef)
        {
            var type = GetTypeOutput(typeRef);
            var patchedType = type.Replace("$", ".");//fix for enums https://github.com/jni4net/jni4net/issues/39
            Output.Write(patchedType);
        }


        protected override string GetTypeOutput(CodeTypeReference value)
        {
            string typeOutput = null;

            if (value.ArrayElementType != null)
            {
                typeOutput = GetTypeOutput(value.ArrayElementType);
            }
            else
            {
                typeOutput = DetermineTypeOutput(value);
            }

            int rank = value.ArrayRank;
            if (rank > 0)
            {
                typeOutput += '[';
                for (--rank; rank > 0; --rank)
                {
                    typeOutput += ',';
                }
                typeOutput += ']';
            }

            return typeOutput;
        }

        private string DetermineTypeOutput(CodeTypeReference type)
        {
            string typeOutput = null;
            string baseType = type.BaseType;

            if (type.Options == CodeTypeReferenceOptions.GlobalReference)
            {
                //typeOutput = GetSafeName(baseType);
                typeOutput = baseType;
                typeOutput = typeOutput.Replace('+', '.');
                return typeOutput;
            }

            switch (baseType.ToLower(CultureInfo.InvariantCulture))
            {
                case "system.int32":
                case "int":
                    typeOutput = "int";
                    break;
                case "system.int64":
                case "long":
                    typeOutput = "long";
                    break;
                case "system.int16":
                case "short":
                    typeOutput = "short";
                    break;
                case "system.boolean":
                case "bool":
                case "boolean":
                    typeOutput = "boolean";
                    break;
                case "system.char":
                case "char":
                    typeOutput = "char";
                    break;
                case "system.string":
                case "string":
                    typeOutput = "system.String";
                    break;
                case "system.object":
                case "object":
                    typeOutput = "system.Object";
                    break;
                case "system.void":
                case "void":
                    typeOutput = "void";
                    break;
                case "system.byte":
                case "byte":
                    typeOutput = "byte";
                    break;
                case "system.sbyte":
                    typeOutput = "byte";
                    break;
                case "system.decimal":
                case "decimal":
                    typeOutput = "system.Decimal";
                    break;
                case "system.double":
                case "double":
                    typeOutput = "double";
                    break;
                case "system.single":
                case "float":
                    typeOutput = "float";
                    break;
                case "system.uint16":
                    typeOutput = "short";
                    break;
                case "system.uint32":
                    typeOutput = "int";
                    break;
                case "system.uint64":
                    typeOutput = "long";
                    break;
                default:

                    typeOutput = GetSafeName(baseType);
                    typeOutput = typeOutput.Replace('+', '.');
                    break;
            }
            return typeOutput;
        }


        protected override bool Supports(GeneratorSupport support)
        {
            switch (support)
            {
                case GeneratorSupport.PublicStaticMembers:
                case GeneratorSupport.NestedTypes:
                case GeneratorSupport.StaticConstructors:
                case GeneratorSupport.DeclareInterfaces:
                case GeneratorSupport.DeclareEnums:
                case GeneratorSupport.ArraysOfArrays:
                case GeneratorSupport.TryCatchStatements:
                    return true;
                default:
                    return false;
            }
        }


        private string GetSafeName(string id)
        {
            if (keywordsTable == null)
            {
                FillKeywordTable();
            }
            if (keywordsTable.Contains(id))
            {
                return "_" + id;
            }
            return id;
        }

        private static void FillKeywordTable()
        {
            keywordsTable = new Hashtable();
            foreach (string keyword in keywords)
            {
                keywordsTable.Add(keyword, keyword);
            }
        }

        protected override void GenerateDirectives(CodeDirectiveCollection directives)
        {
            foreach (CodeDirective directive in directives)
            {
                var cdr = directive as CodeRegionDirective;
                if (cdr != null)
                {
                    Output.WriteLine(cdr.RegionText);
                }
            }
        }
    }
}