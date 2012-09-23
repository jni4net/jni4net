namespace com.jni4net.proxygen.Interfaces
{
    public interface ITypeRepository : IKnownTypes
    {
        void Register(IMType type);
    }
}
