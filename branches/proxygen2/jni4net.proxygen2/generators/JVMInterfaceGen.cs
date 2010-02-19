using System;

namespace net.sf.jni4net.proxygen.generators
{
    public class JVMInterfaceGen : JVMBaseGenerator
    {
        public override void GenerateType()
        {
            tgtType.IsInterface = true;
        }

        public override void GenerateMember()
        {
            throw new NotImplementedException();
        }
    }
}
