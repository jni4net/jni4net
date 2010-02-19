using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.writers
{
    public interface IWriter
    {
        void Write(GFile file, Repository repository);
    }
}
