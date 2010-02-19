using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generators
{
    public interface IGenerator
    {
        void GenerateType(GFile file, GType type, Context context, Repository repository);
        void GenerateMember(GMember member);
    }
}
