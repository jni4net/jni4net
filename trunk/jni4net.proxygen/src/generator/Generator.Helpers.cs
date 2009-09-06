using System;
using System.CodeDom;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    internal partial class Generator
    {
        protected static string realVariableName = "__real";
        protected static string envVariableName = "__env";
        protected static string envpVariableName = "__envp";
        protected static string objVariableName = "__obj";
        protected static string handleVariableName = "__handle";
        protected static string classVariableName = "__class";
        protected static string typeVariableName = "__type";
        protected CodeVariableReferenceExpression envVariable = new CodeVariableReferenceExpression(envVariableName);
        protected CodeVariableReferenceExpression objVariable = new CodeVariableReferenceExpression(objVariableName);
        protected CodeVariableReferenceExpression realVariable = new CodeVariableReferenceExpression(realVariableName);

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

        protected CodeTypeReferenceExpression CurrentTypeEx { get; set; }

        protected CodeTypeReference CurrentType { get; set; }

        protected CodeTypeReferenceExpression RealTypeEx { get; set; }

        protected CodeTypeReference RealType { get; set; }

        protected CodeTypeReferenceExpression ProxyTypeEx { get; set; }

        protected CodeTypeReference ProxyType { get; set; }

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
