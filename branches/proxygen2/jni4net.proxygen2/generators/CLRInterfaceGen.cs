using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.sf.jni4net.proxygen.generators
{
    public class CLRInterfaceGen : CLRBaseGenerator
    {
        public override void GenerateType()
        {
            tgtType.IsInterface = true;
            base.GenerateType();
        }
    }
}
