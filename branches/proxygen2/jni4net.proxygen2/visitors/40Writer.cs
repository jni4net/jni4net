using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.proxygen.writers;

namespace net.sf.jni4net.proxygen.visitors
{
    public class Writer : BaseModelVisitor
    {
        public override void VisitFile(GFile file, Repository repository)
        {
            IWriter w;
            if (file is JGFile)
            {
                w = new JVMWriter();
            }
            else
            {
                w = new CLRWriter();
            }
            w.Write(file, repository);
        }
    }
}
