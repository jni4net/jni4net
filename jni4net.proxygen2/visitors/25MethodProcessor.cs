using System.CodeDom;
using net.sf.jni4net.inj;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.visitors
{
    public class MethodProcessor : BaseModelVisitor
    {
        private MMember currentMember;
        private GMember gMember;
        private GMember gcMember;
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
                gMember.Attributes = MemberAttributes.Public;
                if (member.IsStatic)
                {
                    gMember.Attributes |= MemberAttributes.Static;
                }
                gMember.IsVoid = member.IsVoid;
                gMember.IsConstructor = member.IsConstructor;
                gMember.Signature = member.SignatureClr;
                if (member.IsConstructor)
                {
                    gcMember = new GMember(currentMember);
                    gFaceJvm.Methods.Add(gcMember);
                    gcMember.Attributes = MemberAttributes.Static | MemberAttributes.Private;
                    gcMember.Name = "__ctor" + member.Name;
                    gcMember.Signature = "(Lnet/sf/jni4net/inj/IClrProxy;" + member.SignatureClr.Substring(1);
                    gMember.IsVoid = true;
                    MType iclrProxy = repository.AddOrResolve(typeof(IClrProxy));
                    gcMember.Parameters.Add(new CodeParameterDeclarationExpression(iclrProxy.GFaceJvm.DTypeReference, "thiz"));
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
                    CodeTypeReference refer;
                    if (mParameter.IsOut)
                    {
                        refer = mParameter.Type.GFaceJvm.DTypeReferenceOut;
                    }
                    else if (mParameter.IsRef)
                    {
                        refer = mParameter.Type.GFaceJvm.DTypeReferenceRef;
                    }
                    else
                    {
                        refer = mParameter.Type.GFaceJvm.DTypeReference;
                    }
                    p = new CodeParameterDeclarationExpression(refer, mParameter.Name);
                    gMember.Parameters.Add(p);
                    if (currentMember.IsConstructor)
                    {
                        gcMember.Parameters.Add(p);
                    }
                }
            }
        }
    }
}
