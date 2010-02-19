using System.CodeDom;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public class JVMStaticGen : JVMBaseGenerator
    {
        public override void GenerateType()
        {
            GenerateTypeOfInit();
        }

        public override void GenerateMember()
        {
        }

        private void GenerateTypeOfInit()
        {
            //field
            var staticfield = new CodeMemberField(Known.systemtTypeJ, "staticType");
            staticfield.Attributes = MemberAttributes.Static | MemberAttributes.Private;
            tgtType.Members.Insert(0, staticfield);

            // property to access it
            var claprop = new CodeMemberMethod();
            claprop.ReturnType = Known.systemtTypeJ;
            claprop.Name = "typeof";
            claprop.Statements.Add(
                new CodeMethodReturnStatement(new CodeFieldReferenceExpression(type.DTypeReferenceEx, "staticType")));
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
                    new CodeFieldReferenceExpression(type.DTypeReferenceEx, "staticType"),
                    new CodeVariableReferenceExpression("staticType")));

            tgtType.Members.Add(init);
        }

    }
}
