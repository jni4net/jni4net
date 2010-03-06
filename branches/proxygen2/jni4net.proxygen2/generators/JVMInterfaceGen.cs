using System;
using System.CodeDom;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public class JVMInterfaceGen : JVMBaseGenerator
    {
        public override void GenerateType1Pass()
        {
            base.GenerateType1Pass();
            tgtType.IsInterface = true;
            AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrInterface");

            foreach (MType ifc in type.Model.Interfaces)
            {
                if (ifc.IsKnown)
                {
                    tgtType.BaseTypes.Add(ifc.GFaceJvm.DTypeReference);
                }
            }
        }

        public override void GenerateType2Pass()
        {
            base.GenerateType2Pass();
            WrapMethodsMagic(tgtType, Known.sMagicIface, Known.eMagicIface);
        }
    }
}
