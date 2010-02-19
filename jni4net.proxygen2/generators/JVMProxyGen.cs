using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public class JVMProxyGen:JVMBaseGenerator
    {
        public override void GenerateType()
        {
            CreateEnvConstructor(tgtType, Known.INJEnv);
        }

        public override void GenerateMember()
        {
        }

    }
}
