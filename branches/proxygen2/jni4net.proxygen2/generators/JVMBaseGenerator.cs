
using System.CodeDom;

namespace net.sf.jni4net.proxygen.generators
{
    public abstract class JVMBaseGenerator : BaseGenerator
    {
        public override void GenerateMember()
        {
            base.GenerateMember();

            if (member.Model.IsConstructor)
            {
                tgtMember = new CodeConstructor();
            }
            else
            {
                tgtMember = new CodeMemberMethod();
                tgtMember.Name = member.Name;
                if (!member.Model.IsVoid)
                {
                    tgtMember.ReturnType = member.ReturnType;
                }
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
