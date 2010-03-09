using System;
using System.CodeDom;
using System.Reflection;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public abstract class BaseGenerator : IGenerator
    {
        protected int m;
        protected CodeTypeDeclaration tgtType;
        protected CodeMemberMethod tgtMember;
        protected GFile file;
        protected GType type;
        protected GMember member;
        protected Context context;
        protected Repository repository;

        public virtual void GenerateType1Pass()
        {
        }

        public virtual void GenerateType2Pass()
        {
        }

        public virtual void GenerateMember()
        {
        }

        public void GenerateType1Pass(GFile file, GType type, Context context, Repository repository)
        {
            this.file = file;
            this.type = type;
            this.context = context;
            this.repository = repository;
            if (type.DType == null)
            {
                tgtType = new CodeTypeDeclaration(type.Name);

                type.DType = tgtType;
                if (type.Enclosing == null)
                {
                    if (context.Has(Context.Proxy) && type.Model.IsInterface)
                    {
                        tgtType.TypeAttributes = TypeAttributes.NotPublic;
                    }
                    else
                    {
                        tgtType.TypeAttributes = TypeAttributes.Public;
                    }
                    if (context.Has(Context.Static) && type.Model.IsInterface)
                    {
                        tgtType.TypeAttributes |= TypeAttributes.Sealed;
                    }
                    type.File.DNamespace.Types.Add(tgtType);
                }
                else
                {
                    type.Enclosing.DType.Members.Add(tgtType);
                    tgtType.TypeAttributes = TypeAttributes.NestedPublic;
                }
            }
            else
            {
                tgtType = type.DType;
            }

            GenerateType1Pass();
        }

        public void GenerateMember(GMember member)
        {
            this.member = member;
            GenerateMember();
        }

        public void GenerateType2Pass(GFile file, GType type, Context context, Repository repository)
        {
            this.file = file;
            this.type = type;
            this.context = context;
            this.repository = repository;
            GenerateType2Pass();
        }

        protected void CreateEnvConstructor(CodeTypeDeclaration tgtType, CodeTypeReference envType)
        {
            if (type.Model.IsRootType)
            {
                return;
            }
            var cc = new CodeConstructor();
            if (type.Model.IsInterface)
            {
                cc.Attributes = MemberAttributes.Private;
            }
            else
            {
                cc.Attributes = MemberAttributes.Family;
            }
            cc.BaseConstructorArgs.Add(Known.envVariable);
            if (context.IsJvmSide())
            {
                cc.Parameters.Add(new CodeParameterDeclarationExpression(Known.INJEnv, Known.envVariableName));
                cc.Parameters.Add(new CodeParameterDeclarationExpression(Known.Long, Known.handleVariableName));
                cc.BaseConstructorArgs.Add(new CodeVariableReferenceExpression(Known.handleVariableName));
            }
            else
            {
                cc.Parameters.Add(new CodeParameterDeclarationExpression(Known.JNIEnv, Known.envVariableName));
            }
            tgtType.Members.Add(cc);
        }

        protected void AddAttribute(CodeTypeDeclaration declaration, string attr)
        {
            declaration.CustomAttributes.Add(
                new CodeAttributeDeclaration(new CodeTypeReference(attr, CodeTypeReferenceOptions.GlobalReference)));
        }

        protected void AddAttribute(CodeTypeMember tgtMethodCLR, string attr, object value)
        {
            CodeAttributeDeclaration declaration = AddAttribute(tgtMethodCLR, attr);
            declaration.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(value)));
        }

        protected void AddAttribute(CodeTypeMember tgtMethodCLR, string attr, CodeTypeReference refer, CodeTypeReference refer2)
        {
            CodeAttributeDeclaration declaration = AddAttribute(tgtMethodCLR, attr);
            declaration.Arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(refer)));
            declaration.Arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(refer2)));
        }

        protected CodeAttributeDeclaration AddAttribute(CodeTypeMember tgtMethodCLR, string attr)
        {
            var declaration =
                new CodeAttributeDeclaration(new CodeTypeReference(attr, CodeTypeReferenceOptions.GlobalReference));
            tgtMethodCLR.CustomAttributes.Add(declaration);
            return declaration;
        }


    }
}
