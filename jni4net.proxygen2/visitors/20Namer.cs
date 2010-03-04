using System.Text;
using net.sf.jni4net.proxygen.model;
using String = java.lang.String;

namespace net.sf.jni4net.proxygen.visitors
{
    public class Namer : BaseModelVisitor
    {
        public override void VisitType(MType type, Repository repository)
        {
            if (type.Clr!=null)
            {
                string enclosing = Reflection.GetEnclosing(type.Clr.FullName, '+');
                type.GFaceClr = new CGType(type, type.Clr.Namespace, enclosing, type.Name, type.Enclosing == null ? null : type.Enclosing.GFaceClr);
                if (type.Jvm == null)
                {
                    type.GFaceJvm = new JGType(type, type.Clr.Namespace.ToLowerInvariant(), enclosing, type.Name, type.Enclosing == null ? null : type.Enclosing.GFaceJvm);
                }
            }
            if (type.Jvm!=null)
            {
                string reflectionName = type.Jvm.getName();
                string namespce = Reflection.GetNamespce(reflectionName);
                String simpleName = type.Jvm.getSimpleName();
                string enclosing = Reflection.GetEnclosing(reflectionName, '$');
                type.GFaceJvm = new JGType(type, namespce.ToLowerInvariant(), enclosing, simpleName, type.Enclosing == null ? null : type.Enclosing.GFaceJvm);
                if (type.Clr == null)
                {
                    type.GFaceClr = new CGType(type, namespce, enclosing, simpleName, type.Enclosing == null ? null : type.Enclosing.GFaceClr);
                }
            }

            if (!type.IsKnown)
            {
                return;
            }

            if (type.IsGenJvm)
            {
                if (type.Enclosing != null)
                {
                    if (type.IsInterface)
                    {
                        // clr interface is known

                        // jvm interface is new
                        GFile gJVM = type.Enclosing.GFaceJvm.File;
                        gJVM.Add(type.GFaceJvm, Context.Interface | Context.ProxySide | Context.JvmSide);

                        // clr static
                        GFile gCLR = type.Enclosing.GFaceClr.File;//face name is fine
                        gCLR.Add(type.GFaceClr, Context.None);
                        type.GStaticClr = new CGType(type, type.GFaceClr.Namespace, null, type.GFaceClr.Name + "_", type.Enclosing.GStaticClr);
                        gCLR.Add(type.GStaticClr, Context.Static | Context.HomeSide | Context.ClrSide);

                        // jvm static
                        type.GStaticJvm = new JGType(type, type.GFaceJvm.Namespace, null, type.GFaceJvm.Name + "_", type.Enclosing.GStaticJvm);
                        gJVM.Add(type.GStaticJvm, Context.Static | Context.ProxySide | Context.JvmSide);

                        //clr proxy
                        type.GProxyClr = new CGType(type, type.GFaceClr.Namespace, null, "__" + type.GFaceClr.Name, type.Enclosing.GImplementation);
                        gCLR.Add(type.GProxyClr, Context.Proxy | Context.HomeSide | Context.ClrSide);

                        //jvm proxy
                        type.GProxyJvm = new JGType(type, type.GFaceClr.Namespace, null, "__" + type.GFaceJvm.Name, type.Enclosing.GStaticJvm);
                        gJVM.Add(type.GProxyJvm, Context.Proxy | Context.ProxySide | Context.JvmSide);
                        gCLR.Add(type.GProxyClr, Context.Implementation | Context.HomeSide | Context.ClrSide);
                    }
                    else
                    {
                        // clr face is known

                        // jvm face is new, proxy is the face
                        GFile gJVM = type.Enclosing.GFaceJvm.File;
                        gJVM.Add(type.GFaceJvm, Context.None);

                        // clr static
                        GFile gCLR = type.Enclosing.GFaceClr.File;//face name is fine
                        gCLR.Add(type.GFaceClr, Context.None);
                        type.GStaticClr = new CGType(type, type.GFaceClr.Namespace, null, type.GFaceClr.Name + "_", type.Enclosing.GStaticClr);
                        gCLR.Add(type.GStaticClr, Context.Static | Context.HomeSide | Context.ClrSide);

                        // jvm static
                        type.GStaticJvm = type.GFaceJvm;
                        gJVM.Add(type.GStaticJvm, Context.Static | Context.ProxySide | Context.JvmSide);

                        //clr proxy not needed

                        //jvm proxy
                        type.GProxyJvm = type.GFaceJvm;
                        gJVM.Add(type.GProxyJvm, Context.Proxy | Context.ProxySide | Context.JvmSide);
                        type.GImplementation = new CGType(type, type.GFaceClr.Namespace, null, "__" + type.GFaceClr.Name, type.Enclosing.GImplementation);
                        gCLR.Add(type.GImplementation, Context.Implementation | Context.HomeSide | Context.ClrSide);
                    }
                }
                else
                {
                    if (type.IsInterface)
                    {
                        // clr interface is known
                        GFile gCLR = new CGFile(type.GFaceClr);//face name is fine
                        gCLR.Add(type.GFaceClr, Context.None);

                        // jvm interface is new
                        GFile gJVM = new JGFile(type.GFaceJvm);
                        gJVM.Add(type.GFaceJvm, Context.Interface | Context.ProxySide | Context.JvmSide);

                        // clr static
                        type.GStaticClr = new CGType(type, type.GFaceClr.Namespace, null, type.GFaceClr.Name + "_", null);
                        gCLR.Add(type.GStaticClr, Context.Static | Context.HomeSide | Context.ClrSide);

                        // jvm static
                        type.GStaticJvm = new JGType(type, type.GFaceJvm.Namespace, null, type.GFaceJvm.Name + "_", null);
                        GFile gJVM_ = new JGFile(type.GStaticJvm);
                        gJVM_.Add(type.GStaticJvm, Context.Static | Context.ProxySide | Context.JvmSide);

                        //clr proxy
                        type.GProxyClr = new CGType(type, type.GFaceClr.Namespace, null, "__" + type.GFaceClr.Name, null);
                        gCLR.Add(type.GProxyClr, Context.Proxy | Context.HomeSide | Context.ClrSide);

                        //jvm proxy
                        type.GProxyJvm = new JGType(type, type.GFaceClr.Namespace, null, "__" + type.GFaceJvm.Name, null);
                        gJVM_.Add(type.GProxyJvm, Context.Proxy | Context.ProxySide | Context.JvmSide);
                        gCLR.Add(type.GProxyClr, Context.Implementation | Context.HomeSide | Context.ClrSide);
                    }
                    else
                    {
                        // clr face is known
                        GFile gCLR = new CGFile(type.GFaceClr);//face name is fine
                        gCLR.Add(type.GFaceClr, Context.None);

                        // jvm face is new, proxy is the face
                        GFile gJVM = new JGFile(type.GFaceJvm);
                        gJVM.Add(type.GFaceJvm, Context.None);

                        // clr static
                        type.GStaticClr = new CGType(type, type.GFaceClr.Namespace, null, type.GFaceClr.Name + "_", null);
                        gCLR.Add(type.GStaticClr, Context.Static | Context.HomeSide | Context.ClrSide);

                        // jvm static
                        type.GStaticJvm = type.GFaceJvm;
                        gJVM.Add(type.GStaticJvm, Context.Static | Context.ProxySide | Context.JvmSide);

                        //clr proxy not needed

                        //jvm proxy
                        type.GProxyJvm = type.GFaceJvm;
                        gJVM.Add(type.GProxyJvm, Context.Proxy | Context.ProxySide | Context.JvmSide);
                        type.GImplementation = new CGType(type, type.GFaceClr.Namespace, null, "__" + type.GFaceClr.Name, null);
                        gCLR.Add(type.GImplementation, Context.Implementation | Context.HomeSide | Context.ClrSide);
                    }
                }
            }
        }

        public override void VisitMember(MMember member, Repository repository)
        {
            if (!member.Parent.IsGenClr && !member.Parent.IsGenJvm)
            {
                return;
            }

            StringBuilder sbc=new StringBuilder();
            sbc.Append("(");
            foreach (MParameter parameter in member.Parameters)
            {
                sbc.Append(parameter.Type.SignatureClr);
            }
            sbc.Append(")");
            if (member.IsVoid)
            {
                sbc.Append("V");
            }
            else
            {
                sbc.Append(member.Return.Type.SignatureClr);
            }
            member.SignatureClr = sbc.ToString();

            StringBuilder sbj = new StringBuilder();
            sbj.Append("(");
            foreach (MParameter parameter in member.Parameters)
            {
                sbj.Append(parameter.Type.SignatureJvm);
            }
            sbj.Append(")");
            if (member.IsVoid)
            {
                sbj.Append("V");
            }
            else
            {
                sbj.Append(member.Return.Type.SignatureJvm);
            }
            member.SignatureJvm = sbj.ToString();           
        
        }
    }
}
