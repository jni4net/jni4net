
using System.CodeDom;

namespace net.sf.jni4net.proxygen.generators
{
    public abstract class JVMBaseGenerator : BaseGenerator
    {
        public override void GenerateMember()
        {
            base.GenerateMember();

            if (member.IsConstructor)
            {
                tgtMember = new CodeConstructor();
                AddAttribute(tgtMember, "net.sf.jni4net.attributes.ClrConstructor", member.Signature);
            }
            else
            {
                tgtMember = new CodeMemberMethod();
                tgtMember.Name = member.Name;
                if (!member.IsVoid)
                {
                    tgtMember.ReturnType = member.ReturnType;
                }

                AddAttribute(tgtMember, "net.sf.jni4net.attributes.ClrMethod", member.Signature);
            }
            foreach (var parameter in member.Parameters)
            {
                tgtMember.Parameters.Add(parameter);
            }

            tgtMember.Attributes = member.Attributes;
            tgtType.Members.Add(tgtMember);
        }
    }
}
