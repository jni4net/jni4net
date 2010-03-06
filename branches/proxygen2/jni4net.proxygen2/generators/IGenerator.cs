using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generators
{
    public interface IGenerator
    {
        void GenerateType1Pass(GFile file, GType type, Context context, Repository repository);
        void GenerateMember(GMember member);
        void GenerateType2Pass(GFile file, GType type, Context context, Repository repository);
    }
}
