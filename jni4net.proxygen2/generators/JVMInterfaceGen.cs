using System;
using System.CodeDom;

namespace net.sf.jni4net.proxygen.generators
{
    public class JVMInterfaceGen : JVMBaseGenerator
    {
        public override void GenerateType()
        {
            base.GenerateType();
            tgtType.IsInterface = true;
            AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrInterface");
        }
    }
}
