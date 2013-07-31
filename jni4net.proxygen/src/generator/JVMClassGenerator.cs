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
using System.Reflection;
using net.sf.jni4net.inj;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator {

    internal class JVMClassGenerator : JVMGenerator {

        public JVMClassGenerator(GType type)
            : base(type) {
        }

        protected override void Generate(CodeNamespace nameSpace) {
            var tgtType = new CodeTypeDeclaration(type.Name);
            SetCurrentType(type.JVMNamespace + "." + type.Name);
            AddTypeJVM(CurrentType.BaseType);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = type.Attributes & TypeAttributes.VisibilityMask;
            /*if (type.IsAbstract)
            {
                tgtType.TypeAttributes |= TypeAttributes.Abstract;
            }*/
            Utils.AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrType");
            if (type.Base != null) {
                tgtType.BaseTypes.Add(type.Base.JVMReference);
            }
            foreach (GType ifc in type.Interfaces) {
                if (ifc.IsJVMGenerate || ifc.IsJVMType) {
                    tgtType.BaseTypes.Add(ifc.JVMReference);
                }
            }

            // fields with type information
            CreateEnvConstructor(tgtType, "net.sf.jni4net.inj.INJEnv", false, true, false);
            GenerateConstructors(tgtType);
            GenerateMethods(tgtType);
            GenerateTypeOfInit(tgtType);

            WrapMethodsMagic(tgtType, sMagicProxy, eMagicProxy);

            if (type.IsDelegate) {
                tgtType.TypeAttributes |= TypeAttributes.Abstract;
                GenerateProxy(nameSpace);
            }
        }

        private void GenerateMethods(CodeTypeDeclaration tgtType) {
            foreach (GMethod method in type.MethodsWithInterfaces) {
                CodeMemberMethod tgtMethod = null;
                ///@@@ Mihai
                if (CheckGenericMethod(method)) {
                    tgtMethod = CreateGenericMethod(tgtType, method);
                } else {
                    tgtMethod = CreateMethodSignature(method, false);
                }
                tgtType.Members.Add(tgtMethod);
                if (!type.IsDelegate) {
                    ChangeNativeAttributes(tgtMethod);
                } else {
                    if (method.Name == "Invoke") {
                        tgtMethod.Attributes |= MemberAttributes.Abstract;
                    } else {
                        tgtMethod.Statements.Add(
                            new CodeThrowExceptionStatement(
                                new CodeObjectCreateExpression(TypeReference("system.NotImplementedException"))));
                    }
                }
            }
        }

        ///@@@ Mihai
        private CodeMemberMethod CreateGenericMethod(CodeTypeDeclaration tgtType, GMethod method) {
            Console.WriteLine(string.Format("Create generic method {0}.{1}", tgtType.Name, method));

            try {
                string wrapperClassName = GetWrapperClassNameFull(method.ReturnType.Name);
                CodeTypeReference wrapperType = CreateWrapperType(wrapperClassName);
                CodeMemberMethod tgtMethod = CreateGenericMethodSignature(method, wrapperClassName, wrapperType);
                CreateGenericMethodBody(tgtMethod, method, wrapperType);
                tgtType.Members.Add(tgtMethod);
            } catch (ArgumentException ae) {
                Console.WriteLine("ArgumentException intercepted: " + ae.Message);
            }

            //generate native delegate
            return CreateMethodSignature(method, false);
        }

        ///@@@ Mihai
        private void CreateGenericMethodBody(CodeMemberMethod tgtMethod, GMethod method, CodeTypeReference wrapperType) {
            CodeVariableReferenceExpression[] parameters = new CodeVariableReferenceExpression[tgtMethod.Parameters.Count];
            int i = 0;
            foreach (CodeParameterDeclarationExpression parameter in tgtMethod.Parameters) {
                parameters[i++] = new CodeVariableReferenceExpression(parameter.Name);
            }
            CodeMethodReferenceExpression methodReference = new CodeMethodReferenceExpression();
            methodReference.MethodName = method.JVMName;
            CodeObjectCreateExpression returnExpresion = new CodeObjectCreateExpression(
                wrapperType,
                new CodeExpression[] {
                    new CodeMethodInvokeExpression(
                        methodReference,
                        parameters
                    )
                }
            );
            tgtMethod.Statements.Add(new CodeMethodReturnStatement(returnExpresion));
            //TODO: add dynamic type checking
            //foreach (Type genericType in method.ReturnType.CLRType.GetGenericArguments()) {
            //    GType genericGType = Repository.RegisterType(genericType);
            //    returnExpresion.Parameters.Add(new CodeTypeOfExpression(genericGType.JVMFullName));
            //}
        }

        ///@@@ Mihai
        private CodeTypeReference CreateWrapperType(string wrapperClassName) {
            return new CodeTypeReference("mitza.jni4net.wrapper." + wrapperClassName);
        }

        ///@@@ Mihai
        private CodeMemberMethod CreateGenericMethodSignature(GMethod method, string wrapperClassName, CodeTypeReference wrapperType) {
            CodeMemberMethod tgtMethod = new CodeMemberMethod();
            tgtMethod.Name = method.JVMName + wrapperClassName;
            ConstructTypeArguments(wrapperType, method.ReturnType.CLRType.GetGenericArguments());
            tgtMethod.ReturnType = GetJavaInterface(wrapperType);
            tgtMethod.Attributes = method.Attributes;
            GenerateParameters(method, tgtMethod);

            return tgtMethod;
        }

        ///@@@ Mihai
        private CodeTypeReference GetJavaInterface(CodeTypeReference wrapperType) {
            CodeTypeReference result = new CodeTypeReference();
            result.TypeArguments.AddRange(wrapperType.TypeArguments);

            switch (wrapperType.BaseType) {
                case "mitza.jni4net.wrapper.Collection`1":
                    result.BaseType = "java.util.Collection";
                    break;
                case "mitza.jni4net.wrapper.Iterable`1":
                    result.BaseType = "java.lang.Iterable";
                    break;
                case "mitza.jni4net.wrapper.List`1":
                    result.BaseType = "java.util.List";
                    break;
                case "mitza.jni4net.wrapper.Map`2":
                    result.BaseType = "java.util.Map";
                    break;
                case "mitza.jni4net.wrapper.Set`1":
                    result.BaseType = "java.util.Set";
                    break;
            }

            return result;
        }

        ///@@@ Mihai
        private void ConstructTypeArguments(CodeTypeReference wrapperType, Type[] types) {
            foreach (Type argumentType in types) {
                if (argumentType.IsGenericType) {
                    CodeTypeReference innerType = new CodeTypeReference(argumentType);
                    if (innerType.BaseType == "System.Collections.Generic.KeyValuePair`2") {
                        innerType.BaseType = "mitza.jni4net.wrapper.j2c.KeyValuePair";
                    }
                    innerType.TypeArguments.Clear();
                    ConstructTypeArguments(innerType, argumentType.GetGenericArguments());
                    wrapperType.TypeArguments.Add(innerType);
                } else if (argumentType.IsPrimitive) {
                    FancyLog(string.Format("Primitives are not supported for generic methods {0}", argumentType),
                        "Skipping generic method...");
                    throw new ArgumentException("Primitive argument type not supported");
                    //FixArgumentType(wrapperType, argumentType);
                } else {
                    GType gType = Repository.RegisterType(argumentType);
                    if (!IsChildOfSystemObject(gType)) {
                        FancyLog(string.Format("Type argument {0} is not a SystemObject.", argumentType),
                            "Not supported. Skipping generic method...");
                        throw new ArgumentException("Type argument not supported");
                    }
                    string jvmFullName = gType.JVMFullName;
                    if (string.IsNullOrEmpty(jvmFullName)) {
                        string message1 = "Can't find Java mapping for " + argumentType + ". Are you generating proxy for it!?";
                        string message2 = argumentType.Assembly.FullName;
                        FancyLog(message1, message2);
                    }
                    wrapperType.TypeArguments.Add(jvmFullName);
                }
            }
        }

        private bool IsChildOfSystemObject(GType gType) {
            if (gType == null) {
                return false;
            }

            if (gType.CLRFullName == "System.Object") {
                return true;
            } else {
                return IsChildOfSystemObject(gType.Base);
            }
        }

        private void FancyLog(params string[] messages) {
            int maxLength = 0;
            foreach (string message in messages) {
                maxLength = Math.Max(maxLength, message.Length + 6);
            }

            string padding = new String('#', maxLength);
            Console.WriteLine(padding);

            foreach (string message in messages) {
                Console.WriteLine(new String('#', (maxLength - message.Length) / 2 - 1) + " " + message + " " +
                    new String('#', maxLength - (maxLength - message.Length) / 2 - 1 - message.Length));
            }

            Console.WriteLine(padding);
        }

        ///@@@ Mihai
        private static void FixArgumentType(CodeTypeReference wrapperType, Type argumentType) {
            Console.WriteLine("ArgumentType " + argumentType + " is primitive");
            string argumentJavaType = string.Empty;
            switch (argumentType.FullName) {
                case "System.Byte":
                    argumentJavaType = "java.lang.Short";
                    break;
                case "System.SByte":
                    argumentJavaType = "java.lang.Byte";
                    break;
                case "System.Int32":
                    argumentJavaType = "java.lang.Integer";
                    break;
                case "System.Int16":
                    argumentJavaType = "java.lang.Short";
                    break;
                case "System.Int64":
                    argumentJavaType = "java.lang.Long";
                    break;
                case "System.Float":
                    argumentJavaType = "java.lang.Float";
                    break;
                case "System.Double":
                    argumentJavaType = "java.lang.Double";
                    break;
                case "System.Char":
                    argumentJavaType = "java.lang.Character";
                    break;
                case "System.Boolean":
                    argumentJavaType = "java.lang.Boolean";
                    break;
                case "System.String":
                    argumentJavaType = "java.lang.String";
                    break;
                default:
                    argumentJavaType = "Object";
                    break;
            }
            wrapperType.TypeArguments.Add(argumentJavaType);
        }

        private void GenerateConstructors(CodeTypeDeclaration tgtType) {
            int m = 0;

            // constructors
            foreach (GMethod constructor in type.Constructors) {
                string uName = ("__ctor" + type.Name + m);

                //create constructor
                var tgtConstructor = CreateMethodSignature(constructor, false) as CodeConstructor;
                CreateConstructorBody(constructor, tgtConstructor, uName);
                tgtType.Members.Add(tgtConstructor);

                //create helper for it
                CodeMemberMethod tgtHelper = CreateConstructorHelper(constructor, uName);
                tgtType.Members.Add(tgtHelper);

                m++;
            }

            if (type.Constructors.Count == 0
                && type.JVMFullName != "system.Object"
                && type.JVMFullName != "system.Exception") {
                var cc = new CodeConstructor();
                cc.Attributes = MemberAttributes.Family;
                cc.BaseConstructorArgs.Add(
                    new CodeCastExpression(
                        new CodeTypeReference("net.sf.jni4net.inj.INJEnv"),
                        new CodePrimitiveExpression(null)));
                cc.BaseConstructorArgs.Add(new CodePrimitiveExpression(0));
                tgtType.Members.Add(cc);
            }
        }

        private CodeMemberMethod CreateConstructorHelper(GMethod constructor, string uName) {
            var tgtMethod = new CodeMemberMethod();
            tgtMethod.Name = uName;
            tgtMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private | MemberAttributes.New;
            Utils.AddAttribute(tgtMethod, "net.sf.jni4net.attributes.ClrMethod", constructor.JVMSignature);

            // inject thiz parameter
            var tgtParameter = new CodeParameterDeclarationExpression();
            tgtParameter.Name = "thiz";
            tgtParameter.Type = TypeReference(typeof(IClrProxy));
            tgtMethod.Parameters.Add(tgtParameter);

            GenerateParameters(constructor, tgtMethod);

            return tgtMethod;
        }

        private void CreateConstructorBody(GMethod constructor, CodeConstructor con, string uName) {
            if (!type.IsRootType) {
                con.BaseConstructorArgs.Add(
                    new CodeCastExpression(TypeReference("net.sf.jni4net.inj.INJEnv"), new CodePrimitiveExpression(null)));
                con.BaseConstructorArgs.Add(new CodePrimitiveExpression(0));
            }

            var parameters = new CodeExpression[constructor.Parameters.Count + 1];
            for (int p = 0; p < constructor.Parameters.Count; p++) {
                parameters[p + 1] = new CodeVariableReferenceExpression(constructor.ParameterNames[p]);
            }
            parameters[0] = new CodeThisReferenceExpression();
            con.Statements.Add(
                new CodeMethodInvokeExpression(CurrentTypeEx, uName, parameters));
        }
    }
}