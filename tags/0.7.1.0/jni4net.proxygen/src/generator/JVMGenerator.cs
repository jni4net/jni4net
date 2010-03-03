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
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Text;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    /// <summary>
    /// Base class for java generator
    /// </summary>
    internal abstract class JVMGenerator : Generator
    {
        protected const string eMagicIface = "//</generated-interface>";
        protected const string eMagicProxy = "//</generated-proxy>";
        protected const string eMagicStatic = "//</generated-static>";
        protected const string sMagicIface = "//<generated-interface>";
        protected const string sMagicProxy = "//<generated-proxy>";
        protected const string sMagicStatic = "//<generated-static>";

        protected JVMGenerator(GType type) : base(type)
        {
        }

        protected override void Generate()
        {
            Write(GenerateNamespace());
        }

        /// <summary>
        /// create or merge files
        /// </summary>
        public void Write(string newFile)
        {
            string package = type.JVMNamespaceExt.Replace('.', '/').ToLower();
            string dirJava = Path.Combine(config.TargetDirJvm, package);
            if (!Directory.Exists(dirJava))
            {
                Directory.CreateDirectory(dirJava);
            }

            string javaFile = GetFileName(dirJava);

            //load if exists
            string oldFile = null;
            if (File.Exists(javaFile))
            {
                using (var srJavaFile = new StreamReader(javaFile))
                {
                    oldFile = srJavaFile.ReadToEnd();
                }
            }
            if (oldFile != null)
            {
                // merge
                var sb = new StringBuilder(oldFile);
                bool replace = !type.MergeJavaSource;

                if (!replace)
                {
                    int ostart = oldFile.IndexOf(sMagicIface);
                    int oend = oldFile.IndexOf(eMagicIface);
                    int nstart = newFile.IndexOf(sMagicIface);
                    int nend = newFile.IndexOf(eMagicIface);
                    if (nstart != -1 && nend != -1)
                    {
                        if (ostart != -1 && oend != -1)
                        {
                            sb.Remove(ostart, oend - ostart);
                            sb.Insert(ostart, newFile.Substring(nstart, nend - nstart));
                            oldFile = sb.ToString();
                        }
                        else
                        {
                            replace = true;
                        }
                    }
                }

                if (!replace)
                {
                    int sostart = oldFile.IndexOf(sMagicStatic);
                    int soend = oldFile.IndexOf(eMagicStatic);
                    int snstart = newFile.IndexOf(sMagicStatic);
                    int snend = newFile.IndexOf(eMagicStatic);

                    if (snstart != -1 && snend != -1)
                    {
                        if (sostart != -1 && soend != -1)
                        {
                            sb.Remove(sostart, soend - sostart);
                            sb.Insert(sostart, newFile.Substring(snstart, snend - snstart));
                        }
                        else
                        {
                            replace = true;
                        }
                    }
                }

                if (!replace)
                {
                    int postart = oldFile.IndexOf(sMagicProxy);
                    int poend = oldFile.IndexOf(eMagicProxy);
                    int pnstart = newFile.IndexOf(sMagicProxy);
                    int pnend = newFile.IndexOf(eMagicProxy);

                    if (pnstart != -1 && pnend != -1)
                    {
                        if (postart != -1 && poend != -1)
                        {
                            sb.Remove(postart, poend - postart);
                            sb.Insert(postart, newFile.Substring(pnstart, pnend - pnstart));
                        }
                        else
                        {
                            replace = true;
                        }
                    }
                }
                if (!replace)
                {
                    newFile = sb.ToString();
                }
            }

            // replace with merged or new text
            using (var sw = new StreamWriter(javaFile))
            {
                sw.Write(newFile);
            }
            filesJVM.Add(javaFile);
        }

        protected virtual string GetFileName(string dirJava)
        {
            return Path.Combine(dirJava, type.Name + ".java");
        }

        /// <summary>
        /// Compile unit
        /// </summary>
        private string GenerateNamespace()
        {
            var sb = new StringBuilder();
            var swJavaBuffer = new StringWriter(sb);

            ICodeGenerator codeGenerator = new JavaCodeGenerator();
            var cop = new CodeGeneratorOptions();
            var unit = new CodeCompileUnit();
            var nameSpace = new CodeNamespace(type.JVMNamespaceExt);
            unit.Namespaces.Add(nameSpace);

            Generate(nameSpace);

            codeGenerator.GenerateCodeFromCompileUnit(unit, swJavaBuffer, cop);
            swJavaBuffer.Close();

            sb.Replace("This code was generated by a tool.",
                       "This code was generated by jni4net. See http://jni4net.sourceforge.net/ ");

            return sb.ToString();
        }

        protected void GenerateTypeOfInit(CodeTypeDeclaration tgtType)
        {
            var staticfield = new CodeMemberField(Repository.systemType.JVMReference, "staticType");
            staticfield.Attributes = MemberAttributes.Static | MemberAttributes.Private;
            tgtType.Members.Insert(0, staticfield);

            // property to access it
            var claprop = new CodeMemberMethod();
            claprop.ReturnType = Repository.systemType.JVMReference;
            claprop.Name = "typeof";
            claprop.Statements.Add(
                new CodeMethodReturnStatement(new CodeFieldReferenceExpression(CurrentTypeEx, "staticType")));
            tgtType.Members.Add(claprop);
            claprop.Attributes = MemberAttributes.Static | MemberAttributes.Public;

            // initializer
            var init = new CodeMemberMethod();
            init.Name = "InitJNI";
            init.Attributes |= MemberAttributes.Static;
            var jniEnv = new CodeTypeReference("net.sf.jni4net.inj.INJEnv", CodeTypeReferenceOptions.GlobalReference);
            var statClass = new CodeTypeReference("system.Type");
            init.Parameters.Add(new CodeParameterDeclarationExpression(jniEnv, "env"));
            init.Parameters.Add(new CodeParameterDeclarationExpression(statClass, "staticType"));
            init.Statements.Add(
                new CodeAssignStatement(
                    new CodeFieldReferenceExpression(CurrentTypeEx, "staticType"),
                    new CodeVariableReferenceExpression("staticType")));

            tgtType.Members.Add(init);
        }

        protected void WrapMethodsMagic(CodeTypeDeclaration tgtType, string start, string end)
        {
            // if there is at leat one, put magic block around
            if (tgtType.Members.Count > 0)
            {
                int last = tgtType.Members.Count - 1;
                tgtType.Members[0].StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, start));
                tgtType.Members[last].EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, end));
            }
        }

        protected CodeMemberMethod CreateMethodSignature(GMethod method, bool skipSignature)
        {
            CodeMemberMethod tgtMethod;
            if (method.IsConstructor)
            {
                tgtMethod = new CodeConstructor();
            }
            else
            {
                tgtMethod = new CodeMemberMethod();
                tgtMethod.Name = method.JVMName;
                tgtMethod.ReturnType = method.ReturnType.JVMReference;
            }
            if (!config.SkipSignatures && !skipSignature)
            {
                if (method.IsConstructor)
                {
                    Utils.AddAttribute(tgtMethod, "net.sf.jni4net.attributes.ClrConstructor", method.CLRSignature);
                }
                else
                {
                    Utils.AddAttribute(tgtMethod, "net.sf.jni4net.attributes.ClrMethod", method.CLRSignature);
                }
            }
            tgtMethod.Attributes = method.Attributes;
            GenerateParameters(method, tgtMethod);
            return tgtMethod;
        }

        protected void GenerateParameters(GMethod method, CodeMemberMethod tgtMethod)
        {
            for (int i = 0; i < method.Parameters.Count; i++)
            {
                var tgtParameter = new CodeParameterDeclarationExpression();
                tgtParameter.Name = method.ParameterNames[i];
                tgtParameter.Type = method.Parameters[i].JVMReference;
                tgtMethod.Parameters.Add(tgtParameter);
            }
        }

        /// <summary>
        /// Create proxy for interface
        /// </summary>
        protected void GenerateProxy(CodeNamespace nameSpace)
        {
            var tgtType = new CodeTypeDeclaration("__" + type.Name);
            SetCurrentType(type.JVMNamespaceExt + ".__" + type.Name, type.JVMNamespace + "." + type.Name,
                           type.JVMNamespaceExt + ".__" + type.Name, type.CLRNamespaceExt + "." + type.Name + "_");
            AddTypeJVM(CurrentType.BaseType);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.NotPublic;
            Utils.AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrProxy");
            if (!type.IsDelegate)
            {
                tgtType.BaseTypes.Add(Repository.systemObject.JVMReference);
            }
            tgtType.BaseTypes.Add(type.JVMReference);

            CreateEnvConstructor(tgtType, "net.sf.jni4net.inj.INJEnv", false, true, false);

            if (type.Registration == null || !type.Registration.NoMethods)
            {
                foreach (GMethod method in type.MethodsWithInterfaces)
                {
                    if (!method.IsStatic || !type.IsInterface)
                    {
                        CodeMemberMethod tgtMethod = CreateMethodSignature(method, false);
                        ChangeNativeAttributes(tgtMethod);
                        tgtType.Members.Add(tgtMethod);
                    }
                }
            }
            tgtType.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, sMagicProxy));
            tgtType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, eMagicProxy));
        }

        protected void ChangeNativeAttributes(CodeMemberMethod tgtMethod)
        {
            if ((tgtMethod.Attributes & MemberAttributes.ScopeMask) == MemberAttributes.Abstract)
            {
                tgtMethod.Attributes -= MemberAttributes.Abstract;
            }
            // I abuse MemberAttributes.New to set it to native
            tgtMethod.Attributes |= MemberAttributes.New;
        }
    }
}