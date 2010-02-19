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
        protected GFile file;
        protected GType type;
        protected GMember member;
        protected Context context;
        protected Repository repository;

        public abstract void GenerateType();
        public abstract void GenerateMember();

        public virtual void GenerateType(GFile file, GType type, Context context, Repository repository)
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
                    tgtType.TypeAttributes = TypeAttributes.Public;
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

            GenerateType();
        }

        public virtual void GenerateMember(GMember member)
        {
            GenerateMember();
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
            cc.Parameters.Add(new CodeParameterDeclarationExpression(Known.JNIEnv, Known.envVariableName));
            cc.BaseConstructorArgs.Add(Known.envVariable);
            if (context.IsJvmSide())
            {
                cc.Parameters.Add(new CodeParameterDeclarationExpression(Known.Long, Known.handleVariableName));
                cc.BaseConstructorArgs.Add(new CodeVariableReferenceExpression(Known.handleVariableName));
            }
            tgtType.Members.Add(cc);
        }

    }
}
