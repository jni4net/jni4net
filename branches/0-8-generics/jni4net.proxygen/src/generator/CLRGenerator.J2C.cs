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
using System.Collections.Generic;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.proxygen.generator {

    internal partial class CLRGenerator {

        protected CodeMemberMethod initMethod;

        protected void GenerateWrapperMethodsJ2C(CodeTypeDeclaration tgtType) {
            Utils.AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrWrapperAttribute", RealType, StaticType);
            tgtType.Members.Add(initMethod);

            int m = 0;
            foreach (GMethod method in type.MethodsWithInterfaces) {
                string uName = (method.CLRName + m);

                if (!method.IsStatic || !type.IsInterface) {
                    GenerateMethodJ2C(method, tgtType, uName);
                    GenerateMethodRegistrationJ2C(method, uName);
                }
                m++;
            }
            m = 0;
            foreach (GMethod method in type.Constructors) {
                string uName = "__ctor" + type.Name + m;

                GenerateMethodJ2C(method, tgtType, uName);
                GenerateMethodRegistrationJ2C(method, uName);
                m++;
            }

            initMethod.Statements.Add(
                new CodeMethodReturnStatement(new CodeVariableReferenceExpression("methods")));
        }

        private void GenerateMethodJ2C(GMethod method, CodeTypeDeclaration tgtType, string uName) {
            var tgtMethod = new CodeMemberMethod();
            tgtMethod.Statements.Add(new CodeCommentStatement(method.JVMSignature));
            tgtMethod.Statements.Add(new CodeCommentStatement(method.CLRSignature));
            tgtMethod.Name = uName;
            tgtMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private;

            GenerateMethodParamsJ2C(tgtMethod, method);
            GenerateGetEnvJ2C(tgtMethod);
            GenerateMethodCallPrologJ2C(tgtMethod, method);

            GenerateCallJ2C(tgtMethod, method);

            GenerateMethodCallEpilogJ2C(tgtMethod, method);
            tgtType.Members.Add(tgtMethod);
        }

        private void GenerateCallJ2C(CodeMemberMethod tgtMethod, GMethod method) {
            List<CodeExpression> callParams = GenerateCallParamsJ2C(method);

            if (method.IsConstructor) {
                tgtMethod.ReturnType = new CodeTypeReference(typeof(void));

                var call = new CodeObjectCreateExpression(RealType, callParams.ToArray());

                tgtMethod.Statements.Add(
                    new CodeVariableDeclarationStatement(RealType, realVariableName, call));

                tgtMethod.Statements.Add(
                    new CodeMethodInvokeExpression(
                        new CodeMethodReferenceExpression(TypeReferenceEx(typeof(Convertor)),
                                                          "InitProxy"), envVariable, objVariable, realVariable));
            } else {
                CodeExpression targetObject;
                if (method.IsStatic) {
                    targetObject = RealTypeEx;
                } else {
                    CodeExpression expression = CreateConversionExpressionJ2C(type, objVariable);
                    tgtMethod.Statements.Add(
                        new CodeVariableDeclarationStatement(RealType, realVariableName, expression));

                    if (method.DeclaringType != type) {
                        targetObject = new CodeCastExpression(method.DeclaringType.CLRReference, realVariable);
                    } else {
                        targetObject = realVariable;
                    }
                }
                CodeExpression call;
                CodeExpression value = null;
                if (method.IsProperty) {
                    if (method.IsVoid) {
                        int last = callParams.Count - 1;
                        value = callParams[last];
                        callParams.RemoveAt(last);
                    }
                    if (method.CLRProperty.GetIndexParameters().Length > 0) {
                        call = new CodeIndexerExpression(targetObject, callParams.ToArray());
                    } else {
                        call = new CodePropertyReferenceExpression(targetObject, method.CLRProperty.Name);
                        ///@@@ Mihai
                        call = FixGenericConversion(method, call);
                    }
                } else if (method.IsEvent) {
                    int last = callParams.Count - 1;
                    value = callParams[last];
                    if (method.IsCLRPropertyAdd) {
                        call = new CodeEventReferenceExpression(targetObject, method.CLREvent.Name + "__event_add__");
                    } else {
                        call = new CodeEventReferenceExpression(targetObject, method.CLREvent.Name + "__event_remove__");
                    }
                } else {
                    call = new CodeMethodInvokeExpression(targetObject, method.CLRName, callParams.ToArray());
                    ///@@@ Mihai
                    call = FixGenericConversion(method, call);
                }
                CodeStatement callst;
                if (method.IsVoid) {
                    if (method.IsProperty || method.IsEvent) {
                        callst = new CodeAssignStatement(call, value);
                    } else {
                        callst = new CodeExpressionStatement(call);
                    }
                } else {
                    if (method.ReturnType.IsPrimitive) {
                        if (method.ReturnType.JVMSubst != null) {
                            call = new CodeCastExpression(method.ReturnType.CLRReference, call);
                        }
                        callst = new CodeAssignStatement(new CodeVariableReferenceExpression("__return"), call);
                        tgtMethod.ReturnType = method.ReturnType.CLRReference;
                    } else {
                        CodeMethodInvokeExpression conversionExpression =
                            CreateConversionExpressionC2J(method.ReturnType, call);
                        callst = new CodeAssignStatement(new CodeVariableReferenceExpression("__return"), conversionExpression);
                        tgtMethod.ReturnType = TypeReference(typeof(JniHandle));
                    }
                }
                tgtMethod.Statements.Add(callst);
            }
        }

        ///@@@ Mihai
        private CodeExpression FixGenericConversion(GMethod method, CodeExpression call) {
            if (CheckGenericMethod(method)) {
                string convertMethodName = "To" + method.ReturnType.Name.Split(new char[] { '`' }, 2)[0];
                switch (convertMethodName) {
                    case "ToICollection":
                    case "ToIDictionary":
                    case "ToIEnumerable":
                    case "ToIList":
                    case "ToISet":
                        call = new CodeMethodInvokeExpression(
                            new CodeTypeReferenceExpression("Mitza.Jni4Net.Convertor"),
                            convertMethodName,
                            call
                        );
                        break;
                }
            }
            return call;
        }

        private void GenerateMethodRegistrationJ2C(GMethod method, string uName) {
            string callbackName = method.IsConstructor ? uName : method.JVMName;
            string callBackSignature = method.IsConstructor
                                           ? method.JVMSignature.Replace("(", "(Lnet/sf/jni4net/inj/IClrProxy;")
                                           : method.JVMSignature;
            callBackSignature = FixGenericReturnTypeJVMSignature(method, callBackSignature);
            var registation = new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("methods"),
                                                             "Add",
                                                             new CodeMethodInvokeExpression(
                                                                 new CodeMethodReferenceExpression(
                                                                     TypeReferenceEx(typeof(JNINativeMethod)), "Create"),
                                                                 new CodeVariableReferenceExpression(typeVariableName),
                                                                 new CodePrimitiveExpression(callbackName),
                                                                 new CodePrimitiveExpression(uName),
                                                                 new CodePrimitiveExpression(callBackSignature)));
            initMethod.Statements.Add(registation);
        }

        private void GenerateMethodCallPrologJ2C(CodeMemberMethod tgtMethod, GMethod method) {
            if (!method.IsConstructor && !method.IsVoid) {
                if (method.ReturnType.IsPrimitive) {
                    tgtMethod.Statements.Add(new CodeVariableDeclarationStatement(method.ReturnType.CLRReference, "__return", new CodeDefaultValueExpression(method.ReturnType.CLRReference)));
                } else {
                    CodeTypeReference jnihandle = TypeReference(typeof(JniHandle));
                    tgtMethod.Statements.Add(new CodeVariableDeclarationStatement(jnihandle, "__return", new CodeDefaultValueExpression(jnihandle)));
                }
            }
            tgtMethod.Statements.Add(
                new CodeSnippetStatement(
                //using (new global::net.sf.jni4net.jni.LocalFrame(env)) { 
                    "            try {"));
            for (int p = 0; p < method.Parameters.Count; p++) {
                GType parameter = method.Parameters[p];
                string name = method.ParameterNames[p];
                if (parameter.IsOut) {
                    tgtMethod.Statements.Add(new CodeVariableDeclarationStatement(parameter.CLRReference, "__out_" + name));
                }
                if (parameter.IsRef) {
                    var parExpression = new CodeVariableReferenceExpression(name);
                    CodeMethodInvokeExpression conversionExpression = new CodeMethodInvokeExpression(
                        new CodeMethodReferenceExpression(
                            new CodeTypeReferenceExpression(typeof(Ref)), "GetValue",
                            new[] { parameter.CLRReference }), envVariable, parExpression);
                    CodeVariableDeclarationStatement varExpression = new CodeVariableDeclarationStatement(parameter.CLRReference, "__ref_" + name, conversionExpression);
                    tgtMethod.Statements.Add(varExpression);
                }
            }
        }

        private void GenerateMethodCallEpilogJ2C(CodeMemberMethod tgtMethod, GMethod method) {
            for (int p = 0; p < method.Parameters.Count; p++) {
                GType parameter = method.Parameters[p];
                string name = method.ParameterNames[p];
                if (parameter.IsOut) {
                    var parExpression = new CodeVariableReferenceExpression(name);
                    var outExpression = new CodeVariableReferenceExpression("__out_" + name);
                    CodeMethodInvokeExpression invokeExpression = new CodeMethodInvokeExpression(
                        new CodeMethodReferenceExpression(
                        new CodeTypeReferenceExpression(typeof(Out)), "SetValue",
                        new[] { parameter.CLRReference }),
                        envVariable, parExpression, outExpression);
                    tgtMethod.Statements.Add(invokeExpression);
                } else if (parameter.IsRef) {
                    var parExpression = new CodeVariableReferenceExpression(name);
                    var outExpression = new CodeVariableReferenceExpression("__ref_" + name);
                    CodeMethodInvokeExpression invokeExpression = new CodeMethodInvokeExpression(
                        new CodeMethodReferenceExpression(
                        new CodeTypeReferenceExpression(typeof(Ref)), "SetValue",
                        new[] { parameter.CLRReference }),
                        envVariable, parExpression, outExpression);
                    tgtMethod.Statements.Add(invokeExpression);
                }
            }
            tgtMethod.Statements.Add(
                new CodeSnippetStatement(
                    "            }catch (global::System.Exception __ex){@" + envVariableName + ".ThrowExisting(__ex);}"
                //}
                    ));

            if (!method.IsConstructor && !method.IsVoid) {
                tgtMethod.Statements.Add(new CodeMethodReturnStatement(new CodeVariableReferenceExpression("__return")));
            }
        }

        private void GenerateGetEnvJ2C(CodeMemberMethod tgtMethod) {
            var env = new CodeVariableDeclarationStatement(
                new CodeTypeReference(typeof(JNIEnv), CodeTypeReferenceOptions.GlobalReference), envVariableName,
                new CodeSnippetExpression("global::net.sf.jni4net.jni.JNIEnv.Wrap(@" + envpVariableName + ")"));
            tgtMethod.Statements.Add(env);
        }

        private List<CodeExpression> GenerateCallParamsJ2C(GMethod method) {
            var callParams = new List<CodeExpression>();
            for (int p = 0; p < method.Parameters.Count; p++) {
                GType paramType = method.Parameters[p];
                var invokeExpression = new CodeVariableReferenceExpression(method.ParameterNames[p]);
                if (paramType.IsOut) {
                    var outExpression = new CodeSnippetExpression("out __out_" + method.ParameterNames[p]);
                    callParams.Add(outExpression);
                } else if (paramType.IsRef) {
                    var outExpression = new CodeSnippetExpression("ref __ref_" + method.ParameterNames[p]);
                    callParams.Add(outExpression);
                } else if (paramType.IsPrimitive) {
                    callParams.Add(invokeExpression);
                } else {
                    CodeMethodInvokeExpression conversionExpression = CreateConversionExpressionJ2CParam(paramType, invokeExpression);
                    callParams.Add(conversionExpression);
                }
            }
            return callParams;
        }

        private void GenerateMethodParamsJ2C(CodeMemberMethod tgtMethod, GMethod method) {
            var enviParam = new CodeParameterDeclarationExpression(
                TypeReference(typeof(IntPtr)), envpVariableName);
            tgtMethod.Parameters.Add(enviParam);

            if (method.IsStatic || method.IsConstructor) {
                var classParam = new CodeParameterDeclarationExpression(
                    TypeReference(typeof(JniLocalHandle)), classVariableName);
                tgtMethod.Parameters.Add(classParam);
            }
            if (!method.IsStatic || method.IsConstructor) {
                var classParam = new CodeParameterDeclarationExpression(
                    TypeReference(typeof(JniLocalHandle)), objVariableName);
                tgtMethod.Parameters.Add(classParam);
            }


            for (int p = 0; p < method.Parameters.Count; p++) {
                GType paramType = method.Parameters[p];
                CodeTypeReference parameter;
                if (!paramType.IsPrimitive || paramType.IsOut || paramType.IsRef) {
                    parameter = TypeReference(typeof(JniLocalHandle));
                } else {
                    parameter = paramType.CLRReference;
                }

                string name = method.ParameterNames[p];
                tgtMethod.Parameters.Add(new CodeParameterDeclarationExpression(parameter, name));
            }
        }

        public void GenerateWrapperInitJ2C() {
            CodeTypeReference returnType =
                TypeReference("System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>");
            initMethod = new CodeMemberMethod();
            initMethod.Name = "__Init";
            initMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private;
            initMethod.Parameters.Add(
                new CodeParameterDeclarationExpression(
                    new CodeTypeReference(typeof(JNIEnv), CodeTypeReferenceOptions.GlobalReference), envVariableName));
            initMethod.Parameters.Add(
                new CodeParameterDeclarationExpression(
                    new CodeTypeReference(typeof(Class), CodeTypeReferenceOptions.GlobalReference), classVariableName));
            string wrapper = "__" + type.Name;
            initMethod.Statements.Add(
                new CodeVariableDeclarationStatement(
                    new CodeTypeReference(typeof(Type), CodeTypeReferenceOptions.GlobalReference), typeVariableName,
                    new CodeSnippetExpression("typeof(" + wrapper + ")")));

            initMethod.Statements.Add(
                new CodeVariableDeclarationStatement(
                    returnType, "methods", new CodeObjectCreateExpression(returnType)));

            initMethod.ReturnType = returnType;
        }
    }
}