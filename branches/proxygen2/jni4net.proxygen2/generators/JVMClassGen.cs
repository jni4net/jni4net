namespace net.sf.jni4net.proxygen.generators
{
    public class JVMClassGen : JVMBaseGenerator
    {
        public override void GenerateType()
        {
            base.GenerateType();
            AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrType");
        }
    }
}
