using System;
using net.sf.jni4net.proxygen.generators;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.visitors
{
    public class Generator : BaseModelVisitor
    {
        IGenerator currentGenerator;

        public override void VisitGType(GFile file, GType type, Context context, Repository repository)
        {
            if (file is CGFile)
            {
                switch (context.Core())
                {
                    case Context.None:
                        return;
                    case Context.Static:
                        currentGenerator = new CLRStaticGen();
                        break;
                    case Context.Implementation:
                        currentGenerator = new CLRImplementationGen();
                        break;
                    case Context.Proxy:
                        currentGenerator = new CLRProxyGen();
                        break;
                    case Context.Interface:
                        currentGenerator = new CLRInterfaceGen();
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
            else
            {
                switch (context.Core())
                {
                    case Context.None:
                        return;
                    case Context.Static:
                        currentGenerator = new JVMStaticGen();
                        break;
                    case Context.Proxy:
                        currentGenerator = new JVMProxyGen();
                        break;
                    case Context.Interface:
                        currentGenerator = new JVMInterfaceGen();
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
            currentGenerator.GenerateType(file, type, context, repository);
        }

        public override void VisitGMember(GMember member)
        {
            currentGenerator.GenerateMember(member);
        }
    }
}
