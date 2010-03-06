using System.CodeDom;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.utils;

namespace net.sf.jni4net.proxygen.generators
{
    public class JVMProxyGen : JVMBaseGenerator
    {
        public override void GenerateType1Pass()
        {
            base.GenerateType1Pass();
            CreateEnvConstructor(tgtType, Known.INJEnv);
            AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrProxy");

            if (type.Model.IsInterface)
            {
                tgtType.BaseTypes.Add(Known.systemtObjectJ);
                tgtType.BaseTypes.Add(type.Model.GFaceJvm.DTypeReference);
            } 
            else 
            {
                if (type.Model.Base != null)
                {
                    tgtType.BaseTypes.Add(type.Model.Base.GFaceJvm.DTypeReference);
                }
            }
            
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
            if (type.Model.IsInterface)
            {
                tgtType.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, Known.sMagicProxy));
                tgtType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, Known.eMagicProxy));
            }
            else
            {
                WrapMethodsMagic(tgtType, Known.sMagicProxy, Known.eMagicProxy);
            }
        }


        public override void GenerateMember()
        {
            base.GenerateMember();

            // I abuse MemberAttributes.New to set it to native
            tgtMember.Attributes |= MemberAttributes.New;
        }

    }
}
