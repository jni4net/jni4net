using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.finishers
{
    public interface IFinisher
    {
        void Finish(GFile file, Repository repository);
    }
}
