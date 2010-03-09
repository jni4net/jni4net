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
            if (!member.Parent.IsGenJvm)
            {
                currentMember = null;
                return;
            }
            currentMember = member;
            gMember = new GMember(currentMember);
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
            if (member.IsFinal || member.Parent.IsFinal)
            {
                gMember.Attributes |= MemberAttributes.Final;
            }
            gMember.IsVoid = member.IsVoid;
            gMember.IsConstructor = member.IsConstructor;
            gMember.Signature = member.SignatureClr;

            if (member.IsConstructor)
            {
                gcMember = new GMember(currentMember);
                gcMember.Attributes = MemberAttributes.Static | MemberAttributes.Private;
                gcMember.Name = "__ctor" + member.Name;
                gcMember.Signature = "(Lnet/sf/jni4net/inj/IClrProxy;" + member.SignatureClr.Substring(1);
                gMember.IsVoid = true;
                MType iclrProxy = repository.AddOrResolve(typeof(IClrProxy));
                gcMember.Parameters.Add(new CodeParameterDeclarationExpression(iclrProxy.GFaceJvm.DTypeReference, "thiz"));
            }

            JGType gFaceJvm = currentMember.Parent.GFaceJvm;
            JGType gProxyJvm = currentMember.Parent.GProxyJvm;
            if (gProxyJvm.IsGen)
            {
                gProxyJvm.Methods.Add(gMember);
                if (member.IsConstructor)
                {
                    gProxyJvm.Methods.Add(gcMember);
                }
            }
            if (gFaceJvm.IsGen && gFaceJvm != gProxyJvm)
            {
                gFaceJvm.Methods.Add(gMember);
            }
        }

        public override void VisitParameter(MParameter mParameter, Repository repository)
        {
            if (currentMember ==null || !currentMember.Parent.IsGenJvm)
            {
                return;
            }

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
