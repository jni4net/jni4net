using System.Collections.Generic;
using java.lang;
using JType=java.lang.reflect.Type;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IJvmResolver
    {
        void AddDir(string cp);
        void AddJar(string cp);
        void Init();
        List<IMType> GenerateCp(string cp, string regex=null);
        IMType ResolveModel(Class clazz);
        IMType ResolveModel(string fullname);
        void UpdateModel(IMType model);
    }
}
