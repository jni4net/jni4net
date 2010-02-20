using System.CodeDom;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.visitors
{
    public class MethodProcessor : BaseModelVisitor
    {
        private MMember currentMember;
        private GMember gMember;
        public override void VisitMember(MMember member, Repository repository)
        {
            currentMember = member;
            JGType gFaceJvm = currentMember.Parent.GFaceJvm;
            if (gFaceJvm.IsGen)
            {
                gMember = new GMember(currentMember);
                gFaceJvm.Methods.Add(gMember);
                if (member.IsProperty)
                {
                    gMember.Name = gMember.Name.Replace("get_", "get");
                    gMember.Name = gMember.Name.Replace("set_", "set");
                }
                if (member.IsEvent)
                {
                    gMember.Name = gMember.Name.Replace("add_", "add");
                    gMember.Name = gMember.Name.Replace("remove_", "remove");
                }
            }
        }

        public override void VisitParameter(MParameter mParameter, Repository repository)
        {
            JGType gFaceJvm = currentMember.Parent.GFaceJvm;
            if (gFaceJvm.IsGen)
            {
                CodeParameterDeclarationExpression p;
                if (mParameter.IsReturn)
                {
                    gMember.ReturnType = mParameter.Type.GFaceJvm.DTypeReference;
                }
                else
                {
                    if (mParameter.IsOut)
                    {
                        p = new CodeParameterDeclarationExpression(mParameter.Type.GFaceJvm.DTypeReferenceOut,
                                                                   "__out_" + mParameter.Name);
                    }
                    else if (mParameter.IsRef)
                    {
                        p = new CodeParameterDeclarationExpression(mParameter.Type.GFaceJvm.DTypeReferenceRef,
                                                                   "__ref_" + mParameter.Name);
                    }
                    else
                    {
                        p = new CodeParameterDeclarationExpression(mParameter.Type.GFaceJvm.DTypeReference,
                                                                   mParameter.Name);
                    }
                    gMember.Parameters.Add(p);
                }
            }
        }
    }
}
