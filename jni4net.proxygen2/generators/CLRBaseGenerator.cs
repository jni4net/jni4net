using System.CodeDom;
using System.Reflection;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public abstract class CLRBaseGenerator : BaseGenerator
    {
        public override void GenerateType1Pass()
        {
            base.GenerateType1Pass();
            tgtType.IsPartial = true;
            tgtType.StartDirectives.Insert(0, new CodeRegionDirective(CodeRegionMode.Start, Known.cdcComment + type.Name));
            tgtType.StartDirectives.Insert(0, new CodeRegionDirective(CodeRegionMode.Start, Known.cdc));
            tgtType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, Known.cdc));
        }

        protected void GenerateConstructionHelper()
        {
            var constructionHelper = new CodeTypeDeclaration("ContructionHelper");
            constructionHelper.BaseTypes.Add(Known.IConstructionHelper);
            var createMethod = new CodeMemberMethod();
            createMethod.ReturnType = Known.IJvmProxy;
            createMethod.Parameters.Add(new CodeParameterDeclarationExpression(Known.JNIEnv, Known.envVariableName));
            createMethod.Statements.Add(new CodeMethodReturnStatement(new CodeObjectCreateExpression(type.DTypeReference, Known.envVariable)));
            createMethod.Name = "CreateProxy";
            createMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final | MemberAttributes.New;
            constructionHelper.Members.Add(createMethod);
            constructionHelper.TypeAttributes = TypeAttributes.NotPublic | TypeAttributes.Sealed;
            tgtType.Members.Add(constructionHelper);
        }
    }
}
