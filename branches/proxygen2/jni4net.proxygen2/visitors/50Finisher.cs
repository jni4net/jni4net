using net.sf.jni4net.proxygen.finishers;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.visitors
{
    public class Finisher : BaseModelVisitor
    {
        public override void VisitFile(GFile file, Repository repository)
        {
            IFinisher fin;
            if (file is JGFile)
            {
                fin = new JVMFinisher();
            }
            else
            {
                fin = new CLRFinisher();
            }
            fin.Finish(file,repository);
        }
    }
}
