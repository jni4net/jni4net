using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.utils;
using Object=java.lang.Object;

namespace net.sf.jni4net.proxygen.generator
{
    internal partial class CLRGenerator
    {
        protected CodeMemberMethod initMethod;

        protected void GenerateWrapperMethods(CodeTypeDeclaration tgtType)
        {
            tgtType.AddAttribute("net.sf.jni4net.attributes.ClrWrapperAttribute", type.CLRReference);
            tgtType.Members.Add(initMethod);

            int m = 0;
            foreach (GMethod method in type.MethodsWithInterfaces)
            {
                string uName = method.IsConstructor
                                   ? "__ctor" + type.Name + m
                                   : (method.CLRName + m);

                if (!method.IsStatic || !type.IsInterface)
                {
                    GenerateMethodJ2C(method, tgtType, uName);
                    GenerateMethodRegistrationJ2C(method, uName);
                }
                m++;
            }

            initMethod.Statements.Add(
                new CodeMethodReturnStatement(new CodeVariableReferenceExpression("methods")));
        }

        private void GenerateMethodJ2C(GMethod method, CodeTypeDeclaration tgtType, string uName)
        {
            var tgtMethod = new CodeMemberMethod();
            tgtMethod.Statements.Add(new CodeCommentStatement(method.JVMSignature));
            tgtMethod.Statements.Add(new CodeCommentStatement(method.CLRSignature));
            tgtMethod.Name = uName;
            tgtMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private;

            GenerateMethodParamsJ2C(tgtMethod, method);
            GenerateGetEnvJ2C(tgtMethod);
            GenerateMethodCallPrologJ2C(tgtMethod);
            
            GenerateCallJ2C(tgtMethod, method);

            GenerateMethodCallEpilogJ2C(tgtMethod, method);
            tgtType.Members.Add(tgtMethod);
        }

        private void GenerateCallJ2C(CodeMemberMethod tgtMethod, GMethod method)
        {
            List<CodeExpression> callParams = GenerateCallParamsJ2C(method);

            if (method.IsConstructor)
            {
                tgtMethod.ReturnType = new CodeTypeReference(typeof (void));

                var call = new CodeObjectCreateExpression(CurrentType, callParams.ToArray());

                tgtMethod.Statements.Add(
                    new CodeVariableDeclarationStatement(RealType, "real", call));
                tgtMethod.Statements.Add(
                    new CodeSnippetStatement(
                        "            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, obj, real);"));
            }
            else
            {
                CodeExpression targetObject;
                if (method.IsStatic)
                {
                    targetObject = RealTypeEx;
                }
                else
                {
                    tgtMethod.Statements.Add(
                        new CodeVariableDeclarationStatement(RealType, "real",
                                                             new CodeSnippetExpression(
                                                                 "global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::" +
                                                                 type.CLRResolved +
                                                                 ">(__env, @__obj)")));

                    if (method.DeclaringType != type)
                    {
                        targetObject = new CodeCastExpression(method.DeclaringType.CLRReference,
                                                              new CodeVariableReferenceExpression("real"));
                    }
                    else
                    {
                        targetObject = new CodeVariableReferenceExpression("real");
                    }
                }
                CodeExpression call;
                CodeExpression value = null;
                if (method.IsProperty)
                {
                    if (method.IsVoid)
                    {
                        int last = callParams.Count - 1;
                        value = callParams[last];
                        callParams.RemoveAt(last);
                    }
                    if (method.CLRProperty.GetIndexParameters().Length > 0)
                    {
                        call = new CodeIndexerExpression(targetObject, callParams.ToArray());
                    }
                    else
                    {
                        call = new CodePropertyReferenceExpression(targetObject, method.CLRProperty.Name);
                    }
                }
                else
                {
                    call = new CodeMethodInvokeExpression(targetObject, method.CLRName, callParams.ToArray());
                }
                CodeStatement callst;
                if (method.IsVoid)
                {
                    if (method.IsProperty)
                    {
                        callst = new CodeAssignStatement(call, value);
                    }
                    else
                    {
                        callst = new CodeExpressionStatement(call);
                    }
                }
                else
                {
                    if (method.ReturnType.IsPrimitive)
                    {
                        if (method.ReturnType.JVMSubst != null)
                        {
                            call = new CodeCastExpression(method.ReturnType.CLRReference, call);
                        }
                        callst = new CodeMethodReturnStatement(call);
                        tgtMethod.ReturnType = method.ReturnType.CLRReference;
                    }
                    else
                    {
                        string wrapperName = "WrapClr";
                        if (method.ReturnType == Repository.systemString)
                        {
                            wrapperName = "ConvertString";
                        }
                        callst = new CodeMethodReturnStatement(new CodeMethodInvokeExpression(
                                                                   TypeReferenceEx(typeof (ClrProxiesMap)),
                                                                   wrapperName,
                                                                   new CodeVariableReferenceExpression("__env"),
                                                                   call));
                        tgtMethod.ReturnType = TypeReference(typeof (Object.JavaPtr).MakePointerType());
                    }
                }
                tgtMethod.Statements.Add(callst);
            }
        }

        private void GenerateMethodRegistrationJ2C(GMethod method, string uName)
        {
            var registation = new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("methods"),
                                                             "Add",
                                                             new CodeMethodInvokeExpression(
                                                                 new CodeMethodReferenceExpression(TypeReferenceEx(typeof (JNINativeMethod)),"Create"),
                                                                 new CodeVariableReferenceExpression("type"),
                                                                 new CodePrimitiveExpression(method.JVMName),
                                                                 new CodePrimitiveExpression(uName),
                                                                 new CodePrimitiveExpression(method.CLRSignature)));
            initMethod.Statements.Add(registation);
        }

        private void GenerateMethodCallPrologJ2C(CodeMemberMethod tgtMethod)
        {
            tgtMethod.Statements.Add(
                new CodeSnippetStatement(
                    //using (new global::net.sf.jni4net.jni.LocalFrame(env)) { 
                    "            try {"));
        }

        private void GenerateMethodCallEpilogJ2C(CodeMemberMethod tgtMethod, GMethod method)
        {
            tgtMethod.Statements.Add(
                new CodeSnippetStatement(
                    "            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}"
                    //}
                    ));

            if (!method.IsConstructor && !method.IsVoid)
            {
                tgtMethod.Statements.Add(
                    new CodeMethodReturnStatement(new CodeDefaultValueExpression(tgtMethod.ReturnType)));
            }
        }

        private void GenerateGetEnvJ2C(CodeMemberMethod tgtMethod)
        {
            var env = new CodeVariableDeclarationStatement(
                new CodeTypeReference(typeof(JNIEnv), CodeTypeReferenceOptions.GlobalReference), "__env",
                new CodeSnippetExpression("(*@__envi).Wrap()"));
            tgtMethod.Statements.Add(env);
        }

        private List<CodeExpression> GenerateCallParamsJ2C(GMethod method)
        {
            var callParams = new List<CodeExpression>();
            for (int p = 0; p < method.Parameters.Count; p++)
            {
                GType paramType = method.Parameters[p];
                if (paramType.IsPrimitive)
                {
                    callParams.Add(new CodeVariableReferenceExpression(method.ParameterNames[p]));
                }
                else if (!paramType.IsJVMProxy)
                {
                    callParams.Add(new CodeSnippetExpression(
                                       "global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::" +
                                       paramType.CLRResolved + ">(__env, " + method.ParameterNames[p] + ")"));
                }
                else
                {
                    callParams.Add(new CodeSnippetExpression(
                                       "global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<" + paramType.CLRResolved +
                                       ">(__env, " + method.ParameterNames[p] + ")"));
                }
            }
            return callParams;
        }

        private void GenerateMethodParamsJ2C(CodeMemberMethod tgtMethod, GMethod method)
        {
            var enviParam = new CodeParameterDeclarationExpression(
                TypeReference(typeof (JNIEnv.JavaPtr).MakePointerType()), "__envi");
            tgtMethod.Parameters.Add(enviParam);

            if (method.IsStatic || method.IsConstructor)
            {
                var classParam = new CodeParameterDeclarationExpression(
                    TypeReference(typeof (Class.JavaPtr).MakePointerType()), "__clazz");
                tgtMethod.Parameters.Add(classParam);
            }
            if (!method.IsStatic || method.IsConstructor)
            {
                var classParam = new CodeParameterDeclarationExpression(
                    TypeReference(typeof (Object.JavaPtr).MakePointerType()), "__obj");
                tgtMethod.Parameters.Add(classParam);
            }


            for (int p = 0; p < method.Parameters.Count; p++)
            {
                GType paramType = method.Parameters[p];
                CodeTypeReference parameter = paramType.IsPrimitive
                                                  ? paramType.CLRReference
                                                  : TypeReference(typeof (Object.JavaPtr).MakePointerType());

                string name = method.ParameterNames[p];
                tgtMethod.Parameters.Add(new CodeParameterDeclarationExpression(parameter, name));
            }
        }

        public void GenerateWrapperInitJ2C()
        {
            CodeTypeReference returnType = TypeReference("System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>");
            initMethod = new CodeMemberMethod();
            initMethod.Name = "__Init";
            initMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private;
            initMethod.Parameters.Add(
                new CodeParameterDeclarationExpression(
                    new CodeTypeReference(typeof (JNIEnv), CodeTypeReferenceOptions.GlobalReference), "env"));
            initMethod.Parameters.Add(
                new CodeParameterDeclarationExpression(
                    new CodeTypeReference(typeof (Class), CodeTypeReferenceOptions.GlobalReference), "clazz"));
            string wrapper = type.IsCLRProxy ? "__" + type.Name : type.Name;
            initMethod.Statements.Add(
                new CodeVariableDeclarationStatement(
                    new CodeTypeReference(typeof (Type), CodeTypeReferenceOptions.GlobalReference), "type",
                    new CodeSnippetExpression("typeof(" + wrapper + ")")));

            initMethod.Statements.Add(
                new CodeVariableDeclarationStatement(
                    returnType, "methods", new CodeObjectCreateExpression(returnType)));

            initMethod.ReturnType = returnType;
        }
    }
}
