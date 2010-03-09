using System.CodeDom;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public class JVMClassGen : JVMBaseGenerator
    {
        public override void GenerateType1Pass()
        {
            base.GenerateType1Pass();
            AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrType");
        }

        public override void GenerateMember()
        {
            //no methods
        }

    }
}
