using System.Collections.Generic;
using IKVM.Reflection;
using com.jni4net.proxygen.Services;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Interfaces
{
    public interface ICommonResolver
    {
        Dictionary<string, ResolverRecord> ByLowName { get; }
        Dictionary<string, ResolverRecord> ByName  { get; }
    }

    public interface IClrResolver
    {
        void AddName(string fullName);
        void AddPath(string filename);
        void Init();
        List<IMType> GenerateAs(string asm, IMType father, string regex = null);
        IMType ResolveModel(Type clazz, IMType father);
        IMType ResolveModel(string fullname, IMType father);
        void UpdateModel(IMType model);
        Type FindPlainType(Type type);
        Type LoadType(string fullname);

        IUTypeUsage CreateUsage(ParameterInfo clr, IMTypeView father);
        IUTypeUsage CreateUsage(Type clr, IMTypeView father);
    }
}
