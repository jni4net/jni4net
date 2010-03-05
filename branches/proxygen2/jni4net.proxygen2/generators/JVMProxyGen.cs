using System.CodeDom;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public class JVMProxyGen : JVMBaseGenerator
    {
        public override void GenerateType()
        {
            base.GenerateType();
            CreateEnvConstructor(tgtType, Known.INJEnv);
            AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrProxy");
        }


        public override void GenerateMember()
        {
            base.GenerateMember();

            // I abuse MemberAttributes.New to set it to native
            tgtMember.Attributes |= MemberAttributes.New;
        }

    }
}
