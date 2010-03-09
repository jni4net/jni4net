using System.Collections.Generic;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.visitors
{
    public class MethodSkipper : BaseModelVisitor
    {
        public override void VisitMember(MMember member, Repository repository)
        {
            MType type = member.Parent;
            Dictionary<string, MMember> signatures = type.Signatures;
            if (type.IsGenJvm)
            {
                string signatureJvm = member.Name + member.SignatureJvm;

                if (ContainsSignatureRecursive(type, signatureJvm))
                {
                    type.SkippedMethods.Add(member);
                    type.Methods.Remove(member);
                }
                else
                {
                    signatures.Add(signatureJvm, member);
                }
            }
            if (type.IsGenClr)
            {
                string signatureJvm = member.Name + member.SignatureClrNoRet;

                if (signatures.ContainsKey(signatureJvm))
                {
                    type.SkippedMethods.Add(member);
                    type.Methods.Remove(member);
                }
                else
                {
                    signatures.Add(signatureJvm, member);
                }
            }
        }

        private static bool ContainsSignature(MType type, string signatureJvm)
        {
            return type.Signatures.ContainsKey(signatureJvm);
        }

        private static bool ContainsSignatureRecursive(MType type, string signatureJvm)
        {
            if (type.Signatures.ContainsKey(signatureJvm))
            {
                return true;
            }
            if (type.Base!=null)
            {
                return ContainsSignatureRecursive(type.Base, signatureJvm);
            }
            return false;
        }
    
    }
}
