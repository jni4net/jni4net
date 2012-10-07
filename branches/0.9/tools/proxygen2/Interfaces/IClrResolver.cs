using System.Collections.Generic;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IClrResolver
    {
        void AddName(string fullName);
        void AddPath(string filename);
        void Init();
        List<IMType> GenerateAs(string asm, IMType parent, string regex = null);
        IMType ResolveModel(Type clazz, IMType parent);
        IMType ResolveModel(string fullname, IMType parent);
        void UpdateModel(IMType model);
        Type FindPlainType(Type clazz);
    }
}
