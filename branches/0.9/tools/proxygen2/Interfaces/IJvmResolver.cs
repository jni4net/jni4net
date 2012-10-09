using System.Collections.Generic;
using com.jni4net.proxygen.Model;
using java.lang;
using JType=java.lang.reflect.Type;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IJvmResolver
    {
        void AddDir(string cp);
        void AddJar(string cp);
        void Init();
        List<IMType> GenerateCp(string cp, IMType father, string regex = null);
        IMType ResolveModel(Class clazz, IMType father);
        IMType ResolveModel(string plainName, IMType father);
        void UpdateModel(IMType model);
        Class FindPlainType(Class clazz);

        UTypeUsage CreateUsage(Class type, IMTypeView father);
        UTypeUsage CreateUsage(Class type, string paramName, IMTypeView father);
    }
}
