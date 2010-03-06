
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

        protected void WrapMethodsMagic(CodeTypeDeclaration tgtType, string start, string end)
        {
            // if there is at leat one, put magic block around
            if (tgtType.Members.Count > 0)
            {
                int last = tgtType.Members.Count - 1;
                tgtType.Members[0].StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, start));
                tgtType.Members[last].EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, end));
            }
        }

    }
}
