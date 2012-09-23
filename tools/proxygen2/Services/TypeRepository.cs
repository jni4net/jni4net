using Microsoft.Practices.Unity;
using com.jni4net.proxygen.Interfaces;

namespace com.jni4net.proxygen.Services
{
    public class TypeRepository : ITypeRepository
    {
        [Dependency]
        public ILogger Logger { get; set; }


        public void Register(IMType type)
        {
            Logger.LogMessage(type.ToString());
        }

        public IMType SystemObject { get; set; }
        public IMType SystemType { get; set; }
        public IMType SystemException { get; set; }
        public IMType JavaLangObject { get; set; }
        public IMType JavaLangClass { get; set; }
        public IMType JavaLangThrowable { get; set; }
    }
}
