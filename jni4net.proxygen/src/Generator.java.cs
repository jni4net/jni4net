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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using java.lang;
using Microsoft.CSharp;
using net.sf.jni4net.attributes;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.utils;
using Exception=System.Exception;
using String=java.lang.String;
using StringBuilder=System.Text.StringBuilder;

namespace net.sf.jni4net.proxygen
{
    internal partial class Generator
    {
        #region Nested type: Net2Java

        private class Net2Java
        {
            private Generator generator;
            private IList<SkipMethod> skipMethods;

            public Net2Java(IList<SkipMethod> skipMethods, Generator generator)
            {
                this.skipMethods = skipMethods;
                this.generator = generator;
            }

            public void Generate(Type type, string directoryJava, string directoryNative)
            {
                string package = type.Namespace.Replace('.', '/').ToLower();
                string dirJava = Path.Combine(directoryJava, package);
                if (!Directory.Exists(dirJava))
                {
                    Directory.CreateDirectory(dirJava);
                }
                string dirNative = Path.Combine(directoryNative, package);
                if (!Directory.Exists(dirNative))
                {
                    Directory.CreateDirectory(dirNative);
                }
                string oldJavaManualTweaks = null;


                string javaFile = Path.Combine(directoryJava, package + "/" + type.Name + ".java");
                string nativeFile = Path.Combine(directoryNative, package + "/__" + type.Name + ".cs");

                if (File.Exists(javaFile))
                {
                    using (var srJavaFile = new StreamReader(javaFile))
                    {
                        string all = srJavaFile.ReadToEnd();
                        const string sMagic = "//<manual-tweaks>";
                        const string eMagic = "//</manual-tweaks>";
                        int start = all.IndexOf(sMagic);
                        int end = all.IndexOf(eMagic);
                        if (start != -1 && end != -1)
                        {
                            oldJavaManualTweaks = all.Substring(start, end - start + eMagic.Length);
                        }
                    }
                }

                using (var swJava = new StreamWriter(javaFile))
                {
                    using (var swNative = new StreamWriter(nativeFile))
                    {
                        var sbNative = new StringBuilder();
                        var sbJava = new StringBuilder();
                        var swNativeBuffer = new StringWriter(sbNative);
                        var swJavaBuffer = new StringWriter(sbJava);

                        ICodeGenerator cscgJava = new JavaCodeGenerator();
                        var cscProvider = new CSharpCodeProvider();
                        var cop = new CodeGeneratorOptions();

                        var unitJava = new CodeCompileUnit();
                        var nmspJava = new CodeNamespace(type.Namespace.ToLower());
                        unitJava.Namespaces.Add(nmspJava);

                        var unitNative = new CodeCompileUnit();
                        var nmspNative = new CodeNamespace(type.Namespace.ToLower());
                        unitNative.Namespaces.Add(nmspNative);

                        Generate(type, nmspJava, nmspNative);

                        cscgJava.GenerateCodeFromCompileUnit(unitJava, swJavaBuffer, cop);
                        cscProvider.GenerateCodeFromCompileUnit(unitNative, swNativeBuffer, cop);
                        swNativeBuffer.Close();
                        swJavaBuffer.Close();

                        sbNative.Replace("internal sealed class", "internal sealed unsafe class");
                        if (oldJavaManualTweaks != null)
                        {
                            sbJava.Replace("    private static system.Type staticType;",
                                           "	" + oldJavaManualTweaks + "\n\n    private static system.Type staticType;");
                        }
                        sbNative.Replace("This code was generated by a tool.",
                                         "This code was generated by jni4net. See http://jni4net.sourceforge.net/ ");
                        sbJava.Replace("This code was generated by a tool.",
                                         "This code was generated by jni4net. See http://jni4net.sourceforge.net/ ");

                        swNative.Write(sbNative);
                        swJava.Write(sbJava);
                    }
                }
            }

            private void Generate(Type type, CodeNamespace nmspJava, CodeNamespace nmspNative)
            {
                MethodInfo[] methods = type.GetMethods();
                bool isProxy = type.IsInterface;
                if (isProxy)
                {
                    nmspJava.Types.Add(CreateInterface(type, null, methods));
                }
                Type superclass = type.BaseType;
                if (isProxy)
                {
                    superclass = typeof (object);
                }
                if (typeof(Exception) == type)
                {
                    superclass = null;
                }
                CodeTypeReference baseClass = superclass == null
                                                  ? new CodeTypeReference("net.sf.jni4net.inj.IClrProxy")
                                                  : generator.ResolveTypeReference(superclass);
                CreateClass(type, baseClass, methods, isProxy, nmspJava, nmspNative);
            }

            private void CreateClass(Type type, CodeTypeReference baseClass, MethodInfo[] methods, bool isProxy,
                                     CodeNamespace nmspJava, CodeNamespace nmspNative)
            {
                var javaType = new CodeTypeDeclaration();
                var nativeType = new CodeTypeDeclaration();
                bool isSealedClass = false;
                if (typeof(Exception) == type)
                {
                    javaType.BaseTypes.Add(new CodeTypeReference("java.lang.RuntimeException"));
                    javaType.BaseTypes.Add(new CodeTypeReference("net.sf.jni4net.inj.IClrProxy"));
                }
                else if (baseClass != null)
                {
                    javaType.BaseTypes.Add(baseClass);
                }
                nativeType.Name = "__" + type.Name;
                nativeType.TypeAttributes = TypeAttributes.Sealed | TypeAttributes.NotPublic;
                nativeType.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, cdc));
                nativeType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, cdc));

                nativeType.CustomAttributes.Add(
                    new CodeAttributeDeclaration(
                        new CodeTypeReference(typeof (ClrWrapperAttribute), CodeTypeReferenceOptions.GlobalReference),
                        new CodeAttributeArgument(
                            new CodeTypeOfExpression(new CodeTypeReference(type,
                                                                           CodeTypeReferenceOptions.GlobalReference)))));

                var initMethod = new CodeMemberMethod();
                initMethod.Name = "__Init";
                initMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private;
                initMethod.Parameters.Add(
                    new CodeParameterDeclarationExpression(
                        new CodeTypeReference(typeof (JNIEnv), CodeTypeReferenceOptions.GlobalReference), "env"));
                initMethod.Parameters.Add(
                    new CodeParameterDeclarationExpression(
                        new CodeTypeReference(typeof (Class), CodeTypeReferenceOptions.GlobalReference), "clazz"));
                initMethod.Statements.Add(
                    new CodeVariableDeclarationStatement(
                        new CodeTypeReference(typeof (Type), CodeTypeReferenceOptions.GlobalReference), "type",
                        new CodeSnippetExpression("typeof(__" + type.Name + ")")));

                initMethod.Statements.Add(
                    new CodeVariableDeclarationStatement(
                        new CodeTypeReference(typeof (List<>).MakeGenericType(typeof (JNINativeMethod)),
                                              CodeTypeReferenceOptions.GlobalReference), "methods",
                        new CodeObjectCreateExpression(
                            new CodeTypeReference(typeof (List<>).MakeGenericType(typeof (JNINativeMethod)),
                                                  CodeTypeReferenceOptions.GlobalReference))));

                initMethod.ReturnType = new CodeTypeReference(
                    typeof (List<>).MakeGenericType(typeof (JNINativeMethod)), CodeTypeReferenceOptions.GlobalReference);


                if (isProxy)
                {
                    javaType.Name = "__" + type.Name;
                    javaType.CustomAttributes.Add(
                        new CodeAttributeDeclaration(new CodeTypeReference("net.sf.jni4net.attributes.ClrProxy",
                                                                           CodeTypeReferenceOptions.GlobalReference)));
                    javaType.BaseTypes.Add(CreateTypeReference(type, false));
                    javaType.TypeAttributes = TypeAttributes.NotPublic;
                }
                else
                {
                    javaType.Name = type.Name;
                    javaType.CustomAttributes.Add(
                        new CodeAttributeDeclaration(new CodeTypeReference("net.sf.jni4net.attributes.ClrType",
                                                                           CodeTypeReferenceOptions.GlobalReference)));
                    javaType.TypeAttributes = TypeAttributes.Public;
                    var classModifiers = (MemberAttributes) type.Attributes;
                    if ((classModifiers & (MemberAttributes.Final)) == MemberAttributes.Final)
                    {
                        javaType.TypeAttributes |= TypeAttributes.Sealed;
                        isSealedClass = true;
                    }
                }
                javaType.IsClass = true;

                #region Base classes

                foreach (Type ifc in type.GetInterfaces())
                {
                    if (!ifc.IsGenericParameter && !ifc.IsGenericType && !ifc.IsGenericTypeDefinition &&
                        !ifc.Name.StartsWith("_"))
                    {
                        CodeTypeReference reference = generator.ResolveTypeReference(ifc);
                        if (reference.BaseType != "system.Object")
                        {
                            javaType.BaseTypes.Add(reference);
                        }
                    }
                }

                #endregion

                #region class static

                /*var statConst = new CodeTypeConstructor();
                statConst.Attributes = MemberAttributes.Static;
                var parameters = new CodeFieldReferenceExpression(
                    new CodeTypeReferenceExpression(CreateTypeReference(type, false)),
                    "class");
                var expression =
                    new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("net.sf.jni4net.inj.INJEnv"),
                                                   "initClrProxy");

                expression.Parameters.Add(parameters);
                if (isProxy)
                {
                    parameters = new CodeFieldReferenceExpression(
                        new CodeTypeReferenceExpression(CreateTypeReference(type, true)),
                        "class");
                    expression.Parameters.Add(parameters);
                }
                statConst.Statements.Add(new CodeExpressionStatement(expression));
                typeDeclarationJava.Members.Add(statConst);*/


                var staticfield =
                    new CodeMemberField(
                        new CodeTypeReference("system.Type"), "staticType");
                staticfield.Attributes = MemberAttributes.Static | MemberAttributes.Private;
                javaType.Members.Add(staticfield);

                var claprop = new CodeMemberMethod();
                claprop.ReturnType = new CodeTypeReference("system.Type");
                claprop.Name = "typeof";
                claprop.Statements.Add(
                    new CodeMethodReturnStatement(
                        new CodeFieldReferenceExpression(
                            new CodeTypeReferenceExpression(CreateTypeReference(type, isProxy)), "staticType")));
                javaType.Members.Add(claprop);
                claprop.Attributes = MemberAttributes.Static | MemberAttributes.Public;

                var init = new CodeMemberMethod();
                init.Name = "InitJNI";
                init.Attributes |= MemberAttributes.Static;
                var jniEnv = new CodeTypeReference("net.sf.jni4net.inj.INJEnv", CodeTypeReferenceOptions.GlobalReference);
                var statClass = new CodeTypeReference("system.Type");
                init.Parameters.Add(new CodeParameterDeclarationExpression(jniEnv, "env"));
                init.Parameters.Add(new CodeParameterDeclarationExpression(statClass, "staticType"));
                init.Statements.Add(
                    new CodeAssignStatement(
                        new CodeFieldReferenceExpression(
                            new CodeTypeReferenceExpression(CreateTypeReference(type, isProxy)), "staticType"),
                        new CodeVariableReferenceExpression("staticType")));

                javaType.Members.Add(init);

                #endregion

                var knownMethods = new List<SkipMethod>();

                int c = 0;
                for (int m = 0; m < methods.Length; m++)
                {
                    MethodInfo method = methods[m];
                    //TODO if (method.IsAnnotationPresent("net.sf.jni4net.attributes.ClrMethod"))
                    {
                        if (method.DeclaringType == type)
                        {
                            CreateMethod(type, javaType, nativeType, c++, method, init.Statements,
                                         isProxy, false, null,
                                         isSealedClass, knownMethods, initMethod);
                        }
                    }
                }
                foreach (Type ifc in type.GetInterfaces())
                {
                    if (!ifc.IsGenericType && !ifc.IsGenericParameter)
                    {
                        MethodInfo[] methods2 = ifc.GetMethods();
                        for (int m = 0; m < methods2.Length; m++)
                        {
                            MethodInfo method2 = methods2[m];
                            if (method2.DeclaringType == ifc)
                            {
                                CreateMethod(type, javaType, nativeType, c++, methods2[m],
                                             init.Statements, isProxy, false,
                                             generator.ResolveTypeReference(ifc), isSealedClass, knownMethods,
                                             initMethod);
                            }
                        }
                    }
                }
                bool isJavaClass = false; //TODO type.IsAnnotationPresent("net.sf.jni4net.attributes.ClrClass");
                if (!isProxy)
                {
                    bool noparam = false;
                    ConstructorInfo[] constructors = type.GetConstructors();
                    foreach (ConstructorInfo constructor in constructors)
                    {
                        if (constructor.GetParameters().Length == 0)
                        {
                            noparam = true;
                        }
                        CreateConstructor(type, javaType, nativeType, c++, constructor,
                                          init.Statements, isSealedClass,
                                          knownMethods, initMethod);
                    }
                    if (constructors.Length == 0)
                    {
                        var cc = new CodeConstructor();
                        cc.Attributes = MemberAttributes.Family;
                        cc.BaseConstructorArgs.Add(
                            new CodeCastExpression(
                                new CodeTypeReference("net.sf.jni4net.inj.INJEnv"),
                                new CodePrimitiveExpression(null)));
                        cc.BaseConstructorArgs.Add(new CodePrimitiveExpression(0));
                        javaType.Members.Add(cc);
                    }
                }
                if (type != typeof(Exception) && type != typeof(object))
                {
                    CreateEnvConstructor(javaType,
                                         type.FullName == "system.String" || type.FullName == "system.Type",
                                         type != typeof (object) && type != typeof (Exception));
                }

                initMethod.Statements.Add(
                    new CodeMethodReturnStatement(new CodeVariableReferenceExpression("methods")));
                nativeType.Members.Add(initMethod);

                nmspJava.Types.Add(javaType);
                nmspNative.Types.Add(nativeType);
            }

            private CodeTypeDeclaration CreateInterface(Type type, CodeTypeReference baseClass, MethodInfo[] methods)
            {
                CodeTypeDeclaration iface;
                iface = new CodeTypeDeclaration(type.Name);
                iface.CustomAttributes.Add(
                    new CodeAttributeDeclaration(new CodeTypeReference("net.sf.jni4net.attributes.ClrInterface")));
                if (baseClass != null)
                {
                    iface.BaseTypes.Add(baseClass);
                }
                if (typeof(Exception).IsAssignableFrom(type))
                {
                    iface.BaseTypes.Add(new CodeTypeReference("java.lang.RuntimeException"));
                }
                //iface.BaseTypes.Add(new CodeTypeReference("net.sf.jni4net.inj.IClrProxy"));
                iface.TypeAttributes = TypeAttributes.Public;
                iface.IsInterface = true;
                var knownMethods = new List<SkipMethod>();
                for (int m = 0; m < methods.Length; m++)
                {
                    MethodInfo method = methods[m];
                    if (method.DeclaringType == type)
                    {
                        CreateMethod(type, iface, null, m, method, null, true, true, null, false, knownMethods, null);
                    }
                }
                return iface;
            }

            private void CreateEnvConstructor(CodeTypeDeclaration type, bool pub, bool callBase)
            {
                var cc = new CodeConstructor();
                cc.Attributes = pub ? MemberAttributes.FamilyOrAssembly : MemberAttributes.Family;
                cc.Parameters.Add(
                    new CodeParameterDeclarationExpression(
                        new CodeTypeReference("net.sf.jni4net.inj.INJEnv"), "env"));
                cc.Parameters.Add(
                    new CodeParameterDeclarationExpression(
                        new CodeTypeReference("int"), "handle"));
                if (callBase)
                {
                    cc.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("env"));
                    cc.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("handle"));
                }
                type.Members.Add(cc);
            }

            private void CreateConstructor(Type clazz, CodeTypeDeclaration type, CodeTypeDeclaration typeNative, int m,
                                           ConstructorInfo constructor,
                                           CodeStatementCollection init, bool isSealedClass,
                                           List<SkipMethod> knownMethods, CodeMemberMethod initMethod)
            {
                MethodAttributes modifiers = constructor.Attributes;
                if ((modifiers & (MethodAttributes.Private)) != 0)
                {
                    return;
                }
                if (constructor.IsGenericMethod)
                {
                    return;
                }

                ParameterInfo[] parameterTypes = constructor.GetParameters();
                if (!testParams(parameterTypes))
                {
                    return;
                }

                string name = clazz.Name;
                string uName = ("__ctor" + name + m).Replace('$', '_');

                string signature = MethodInfoExt.GetSignature(constructor);
                var ignored = new SkipMethod(clazz.FullName, name, signature);
                if (skipMethods.Contains(ignored))
                {
                    return;
                }
                if (knownMethods.Contains(ignored))
                {
                    return;
                }

                CodeMemberMethod rawCon = CreateMethodSignature(clazz, uName, signature, typeof (void), parameterTypes,
                                                                MethodAttributes.Private | MethodAttributes.Static,
                                                                false, false, false, false, true);
                string sigJava = MethodInfoExt.GetClrSignature(rawCon);


                CodeConstructor con = CreateConstructorSignature(clazz, name, signature, parameterTypes, modifiers,
                                                                 isSealedClass);
                var parameters = new CodeExpression[parameterTypes.Length + 1];
                for (int p = 0; p < parameterTypes.Length; p++)
                {
                    parameters[p + 1] = new CodeVariableReferenceExpression(GetParamName(parameterTypes[p], p));
                }
                parameters[0] = new CodeThisReferenceExpression();
                con.Statements.Add(
                    new CodeMethodInvokeExpression(new CodeTypeReferenceExpression(CreateTypeReference(clazz, false)),
                                                   uName, parameters));

                if (clazz != typeof (object) && clazz != typeof (Exception))
                {
                    con.BaseConstructorArgs.Add(
                        new CodeCastExpression(
                            new CodeTypeReference("net.sf.jni4net.inj.INJEnv"),
                            new CodePrimitiveExpression(null)));
                    con.BaseConstructorArgs.Add(new CodePrimitiveExpression(0));
                }

                signature = MethodInfoExt.GetClrSignature(con);
                var ignored2 = new SkipMethod(clazz.FullName, name, signature);
                if (knownMethods.Contains(ignored2))
                {
                    return;
                }
                knownMethods.Add(ignored);
                knownMethods.Add(ignored2);

                type.Members.Add(rawCon);
                type.Members.Add(con);

                CreateNative(constructor, modifiers, parameterTypes, clazz, name, typeof (void), typeNative, m,
                             initMethod, true, sigJava, null);
            }

            private bool testParams(ParameterInfo[] parameterTypes)
            {
                foreach (ParameterInfo info in parameterTypes)
                {
                    if (info.IsRetval || info.IsOut || info.ParameterType.IsByRef || info.ParameterType.IsPointer)
                    {
                        return false;
                    }
                }
                return true;
            }

            private void CreateMethod(Type clazz, CodeTypeDeclaration type, CodeTypeDeclaration typeNative, int m,
                                      MethodInfo method,
                                      CodeStatementCollection init,
                                      bool isProxy, bool isInterface, CodeTypeReference isInterfaceMethod,
                                      bool isSealedClass, List<SkipMethod> knownMethods, CodeMemberMethod initMethod)
            {
                MethodAttributes modifiers = method.Attributes;
                string name = method.Name;
                if ((modifiers & (MethodAttributes.Private)) != 0)
                {
                    return;
                }
                if (method.IsGenericMethod)
                {
                    return;
                }
                PropertyInfo property = null;
                ParameterInfo[] parameterTypes = method.GetParameters();
                if (method.IsSpecialName)
                {
                    if (name.StartsWith("op_") || name.StartsWith("add_") || name.StartsWith("remove_"))
                    {
                        return;
                    }
                    BindingFlags f = 0;
                    if (method.IsStatic)
                    {
                        f |= BindingFlags.Static;
                    }
                    else
                    {
                        f |= BindingFlags.Instance;
                    }
                    if (method.IsPublic)
                    {
                        f |= BindingFlags.Public;
                    }
                    else
                    {
                        f |= BindingFlags.NonPublic;
                    }
                    if (method.IsAbstract)
                    {
                        f |= BindingFlags.DeclaredOnly;
                    }
                    string pname = method.Name.Substring(method.Name.IndexOf('_') + 1);
                    property = FindProperty(f, clazz, pname);
                    name = name.Replace("_", "");
                }
                if (!testParams(parameterTypes))
                {
                    return;
                }
                if (name == "getStackTrace" && typeof(Exception).IsAssignableFrom(clazz))
                {
                    name = "getStackTraceNet";
                }

                //TODO if (method.IsAnnotationPresent("net.sf.jni4net.attributes.ClrMethod"))
                {
                    //TODO return;
                }
                string signature = MethodInfoExt.GetSignature(method);
                var ignored = new SkipMethod(clazz.FullName, name, signature);

                if (skipMethods.Contains(ignored))
                {
                    return;
                }
                if (knownMethods.Contains(ignored))
                {
                    return;
                }

                Type returnType = method.ReturnType;
                CodeMemberMethod meth = CreateMethodSignature(clazz, name, signature, returnType, parameterTypes,
                                                              modifiers,
                                                              isProxy, isInterface, isInterfaceMethod != null,
                                                              isSealedClass, false);

                string sigJava = MethodInfoExt.GetClrSignature(meth);

                var ignored2 = new SkipMethod("", name, MethodInfoExt.GetSignatureNoRet(meth)); // todo just base
                if (knownMethods.Contains(ignored2))
                {
                    return;
                }
                knownMethods.Add(ignored);
                knownMethods.Add(ignored2);

                type.Members.Add(meth);

                // native
                if (typeNative != null)
                {
                    CreateNative(method, modifiers, parameterTypes, clazz, name, returnType, typeNative, m, initMethod,
                                 false, sigJava, property);
                }
            }

            private PropertyInfo FindProperty(BindingFlags f, Type clazz, string pname)
            {
                PropertyInfo property = clazz.GetProperty(pname, f);
                if (property != null)
                {
                    return property;
                }
                foreach (Type ifc in clazz.GetInterfaces())
                {
                    property = FindProperty(f, ifc, pname);
                    if (property != null)
                    {
                        return property;
                    }
                }
                if (!clazz.IsInterface && clazz.BaseType == typeof (object))
                {
                    property = FindProperty(f, clazz.BaseType, pname);
                    if (property != null)
                    {
                        return property;
                    }
                }

                return null;
            }

            private CodeConstructor CreateConstructorSignature(Type clazz, string name, string signature,
                                                               ParameterInfo[] parameterTypes,
                                                               MethodAttributes modifiers,
                                                               bool isSealedClass)
            {
                var con = new CodeConstructor();
                con.Name = name.Replace('$', '_');
                con.Attributes = 0;
                CreateModifiers(con, name, null, modifiers, clazz, signature, false, false, false, isSealedClass);
                CreateSignatureParams(con, parameterTypes);

                if (!generator.config.SkipSignatures)
                {
                    var declaration =
                        new CodeAttributeDeclaration(new CodeTypeReference("net.sf.jni4net.attributes.ClrConstructor"));
                    con.CustomAttributes.Add(declaration);
                }

                return con;
            }

            private CodeMemberMethod CreateMethodSignature(Type type, string name, string signature, Type returnType,
                                                           ParameterInfo[] parameterTypes, MethodAttributes modifiers,
                                                           bool isProxy, bool isInterface,
                                                           bool isInterfaceMethod, bool isSealedClass,
                                                           bool isConstructor)
            {
                var meth = new CodeMemberMethod();
                meth.Name = name.Replace('$', '_');
                meth.ReturnType = generator.ResolveTypeReference(returnType);
                meth.Attributes = 0;
                CreateModifiers(meth, name, returnType, modifiers, type, signature, isProxy, isInterface,
                                isInterfaceMethod, isSealedClass);
                CreateSignatureParams(meth, parameterTypes);
                if (isConstructor)
                {
                    meth.Parameters.Insert(0, new CodeParameterDeclarationExpression("java.lang.Object", "target"));
                }

                if (!generator.config.SkipSignatures)
                {
                    var declaration =
                        new CodeAttributeDeclaration(new CodeTypeReference("net.sf.jni4net.attributes.ClrMethod"));
                    declaration.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(signature)));
                    meth.CustomAttributes.Add(declaration);
                }
                return meth;
            }

            private void CreateNative(MemberInfo method, MethodAttributes modifiers, ParameterInfo[] parameterTypes,
                                      Type clazz, string name, Type returnType, CodeTypeDeclaration typeNative, int m,
                                      CodeMemberMethod initMethod, bool isCtor, string signature, PropertyInfo property)
            {
                bool isVoid = typeof (void) == returnType;
                bool isStatic = (modifiers & MethodAttributes.Static) != 0;

                var memberMethod = new CodeMemberMethod();
                Type tp;

                memberMethod.Statements.Add(new CodeCommentStatement(signature));

                tp = typeof (JNIEnv.JavaPtr).MakePointerType();
                memberMethod.Parameters.Add(
                    new CodeParameterDeclarationExpression(
                        new CodeTypeReference(tp, CodeTypeReferenceOptions.GlobalReference),
                        "envi"));

                string jName = name;
                if (isCtor)
                {
                    jName = "__ctor" + name + m;
                    memberMethod.Name = jName;
                }
                else
                {
                    memberMethod.Name = name + m;
                }

                if (isStatic || isCtor)
                {
                    tp = typeof (Class.JavaPtr).MakePointerType();
                    memberMethod.Parameters.Add(
                        new CodeParameterDeclarationExpression(
                            new CodeTypeReference(tp, CodeTypeReferenceOptions.GlobalReference),
                            "clazz"));
                }
                if (!isStatic || isCtor)
                {
                    tp = typeof (java.lang.Object.JavaPtr).MakePointerType();
                    memberMethod.Parameters.Add(
                        new CodeParameterDeclarationExpression(
                            new CodeTypeReference(tp, CodeTypeReferenceOptions.GlobalReference),
                            "obj"));
                }

                var callParams = new List<CodeExpression>();
                for (int p = 0; p < parameterTypes.Length; p++)
                {
                    ParameterInfo paramType = parameterTypes[p];
                    tp = paramType.ParameterType.IsPrimitive
                             ? paramType.ParameterType
                             : typeof (java.lang.Object.JavaPtr).MakePointerType();

                    memberMethod.Parameters.Add(
                        new CodeParameterDeclarationExpression(
                            new CodeTypeReference(tp, CodeTypeReferenceOptions.GlobalReference),
                            "par" + p));


                    if (paramType.ParameterType.IsPrimitive)
                    {
                        callParams.Add(new CodeVariableReferenceExpression("par" + p));
                    }
                    else if (!generator.jp.IsAssignableFrom(paramType.ParameterType))
                    {
                        callParams.Add(
                            new CodeSnippetExpression("global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::" +
                                                      paramType.ParameterType.FullName + ">(env, par" +
                                                      p + ")"));
                    }
                    else
                    {
                        callParams.Add(
                            new CodeSnippetExpression(
                                "global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<" + paramType.ParameterType.FullName +
                                ">(env, par" + p +
                                ")"));
                    }
                }

                memberMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private;

                var env = new CodeVariableDeclarationStatement(
                    new CodeTypeReference(typeof (JNIEnv), CodeTypeReferenceOptions.GlobalReference), "env",
                    new CodeSnippetExpression("(*envi).Wrap()"));
                memberMethod.Statements.Add(env);
                memberMethod.Statements.Add(
                    new CodeSnippetStatement(
                        //using (new global::net.sf.jni4net.jni.LocalFrame(env)) { 
                        "            try {"));

                if (isCtor)
                {
                    memberMethod.ReturnType = new CodeTypeReference(typeof (void));

                    var call = new CodeObjectCreateExpression(
                        new CodeTypeReference(clazz, CodeTypeReferenceOptions.GlobalReference), callParams.ToArray());

                    memberMethod.Statements.Add(
                        new CodeVariableDeclarationStatement(
                            new CodeTypeReference(clazz, CodeTypeReferenceOptions.GlobalReference), "real", call));
                    memberMethod.Statements.Add(
                        new CodeSnippetStatement(
                            "            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(env, obj, real);"));
                }
                else
                {
                    CodeExpression targetObject;
                    if (isStatic)
                    {
                        targetObject =
                            new CodeTypeReferenceExpression(new CodeTypeReference(clazz,
                                                                                  CodeTypeReferenceOptions.
                                                                                      GlobalReference));
                    }
                    else
                    {
                        memberMethod.Statements.Add(
                            new CodeVariableDeclarationStatement(
                                new CodeTypeReference(clazz, CodeTypeReferenceOptions.GlobalReference), "real",
                                new CodeSnippetExpression(
                                    "global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::" + clazz.FullName +
                                    ">(env, obj)")));

                        if (method.DeclaringType != clazz)
                        {
                            targetObject = new CodeCastExpression(
                                new CodeTypeReference(method.DeclaringType, CodeTypeReferenceOptions.GlobalReference),
                                new CodeVariableReferenceExpression("real"));
                        }
                        else
                        {
                            targetObject = new CodeVariableReferenceExpression("real");
                        }
                    }
                    if (isVoid)
                    {
                        CodeStatement call;
                        if (property != null)
                        {
                            int last = callParams.Count - 1;
                            CodeExpression value = callParams[last];
                            callParams.RemoveAt(last);
                            if (property.GetIndexParameters().Length > 0)
                            {
                                call =
                                    new CodeAssignStatement(
                                        new CodeIndexerExpression(targetObject, callParams.ToArray()), value);
                            }
                            else
                            {
                                call =
                                    new CodeAssignStatement(
                                        new CodePropertyReferenceExpression(targetObject, property.Name), value);
                            }
                        }
                        else
                        {
                            call =
                                new CodeExpressionStatement(new CodeMethodInvokeExpression(targetObject, method.Name,
                                                                                           callParams.ToArray()));
                        }
                        memberMethod.Statements.Add(call);
                        memberMethod.ReturnType = new CodeTypeReference(typeof (void));
                    }
                    else
                    {
                        CodeExpression call;
                        if (property != null)
                        {
                            if (property.GetIndexParameters().Length > 0)
                            {
                                call = new CodeIndexerExpression(targetObject, callParams.ToArray());
                            }
                            else
                            {
                                call = new CodePropertyReferenceExpression(targetObject, property.Name);
                            }
                        }
                        else
                        {
                            call = new CodeMethodInvokeExpression(targetObject, method.Name, callParams.ToArray());
                        }


                        if (returnType.IsPrimitive)
                        {
                            memberMethod.Statements.Add(new CodeMethodReturnStatement(call));
                            memberMethod.ReturnType = new CodeTypeReference(returnType,
                                                                            CodeTypeReferenceOptions.GlobalReference);
                        }
                        else
                        {
                            //TODO
                            string wrapperName = "WrapClr";
                            if (returnType == typeof (string))
                            {
                                wrapperName = "ConvertString";
                            }
                            var wrapcall =
                                new CodeMethodInvokeExpression(
                                    new CodeTypeReferenceExpression(new CodeTypeReference(typeof (ClrProxiesMap),
                                                                                          CodeTypeReferenceOptions.
                                                                                              GlobalReference)),
                                    wrapperName, new CodeVariableReferenceExpression("env"),
                                    call);
                            memberMethod.Statements.Add(new CodeMethodReturnStatement(wrapcall));
                            memberMethod.ReturnType =
                                new CodeTypeReference(typeof (java.lang.Object.JavaPtr).MakePointerType(),
                                                      CodeTypeReferenceOptions.GlobalReference);
                        }
                    }
                }
                memberMethod.Statements.Add(
                    new CodeSnippetStatement(
                        "            }catch (global::System.Exception ex){env.ThrowExisting(ex);}"
                        //}
                        ));

                if (!isCtor && returnType != typeof (void))
                {
                    memberMethod.Statements.Add(
                        new CodeMethodReturnStatement(new CodeDefaultValueExpression(memberMethod.ReturnType)));
                }

                typeNative.Members.Add(memberMethod);

                var registation = new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("methods"),
                                                                 "Add",
                                                                 new CodeMethodInvokeExpression(
                                                                     new CodeMethodReferenceExpression(
                                                                         new CodeTypeReferenceExpression(
                                                                             new CodeTypeReference(
                                                                                 typeof (JNINativeMethod),
                                                                                 CodeTypeReferenceOptions.
                                                                                     GlobalReference)),
                                                                         "Create"),
                                                                     new CodeVariableReferenceExpression("type"),
                                                                     new CodePrimitiveExpression(jName),
                                                                     new CodePrimitiveExpression(memberMethod.Name),
                                                                     new CodePrimitiveExpression(signature)));
                initMethod.Statements.Add(registation);
            }


            private void CreateModifiers(CodeMemberMethod meth, string name, Type returnType, MethodAttributes modifiers,
                                         Type clazz, string signature, bool isProxy, bool isInterface,
                                         bool isInterfaceMethod, bool isSealedClass)
            {
                bool over = false;
                if ((modifiers & MethodAttributes.Static) != 0)
                {
                    meth.Attributes |= MemberAttributes.Static;
                }

                if ((modifiers & MethodAttributes.Public) != 0)
                {
                    meth.Attributes |= MemberAttributes.Public;
                }
                else if ((modifiers & MethodAttributes.Family) != 0)
                {
                    meth.Attributes |= MemberAttributes.Family;
                }

                if (isProxy)
                {
                    meth.Attributes |= MemberAttributes.Public;
                    meth.Attributes |= MemberAttributes.Final;
                }
                if (!isInterface)
                {
                    meth.Attributes |= MemberAttributes.New;
                }
            }


            private void CreateSignatureParams(CodeMemberMethod method, ParameterInfo[] parameterTypes)
            {
                for (int p = 0; p < parameterTypes.Length; p++)
                {
                    ParameterInfo paramType = parameterTypes[p];

                    var parameter = new CodeParameterDeclarationExpression();
                    parameter.Name = GetParamName(paramType, p);
                    parameter.Type = generator.ResolveTypeReference(paramType.ParameterType);
                    method.Parameters.Add(parameter);
                }
            }

            private CodeTypeReference CreateTypeReference(Type type, bool isProxy)
            {
                var reference =
                    new CodeTypeReference((isProxy ? "__" + type.Name : type.Name), CodeTypeReferenceOptions.GlobalReference);
                return reference;
            }

            private string GetParamName(ParameterInfo type, int index)
            {
                string name;
                if (type.Name != null)
                {
                    name = type.Name;
                }
                else
                {
                    name = type.ParameterType.Name;
                }

                int b = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] >= 'A' && name[i] <= 'Z')
                    {
                        b = i;
                    }
                    if (name[i] == '.')
                    {
                        b = i + 1;
                    }
                }
                var sb = new StringBuilder(name.Substring(b));
                sb.Replace("[", "");
                sb.Replace(";", "");
                sb.Replace("]", "");
                sb.Replace("<", "");
                sb.Replace(">", "");
                sb.Replace("?", "");
                sb.Replace("@", "");
                sb.Replace(".", "");

                sb.Append("Par");
                sb.Append(index);
                sb[0] = Char.ToLower(sb[0]);

                return sb.ToString();
            }
        }

        #endregion
    }
}