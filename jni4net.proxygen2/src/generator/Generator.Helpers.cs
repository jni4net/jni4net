using System;
using System.CodeDom;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    internal partial class Generator
    {
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
                new CodeParameterDeclarationExpression(TypeReference(envType), "env"));
            if (handle)
            {
                cc.Parameters.Add(
                    new CodeParameterDeclarationExpression(TypeReference("int"), "handle"));
            }
            cc.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("env"));
            if (handle)
            {
                cc.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("handle"));
            }
            tgtType.Members.Add(cc);
        }
    
    }
}
