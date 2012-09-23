using System.Collections.Generic;

namespace com.jni4net.proxygen.Interfaces
{
    public interface ITypeRegistration
    {
        List<IMemberRegistration> Members { get; }
    }

    public interface IMemberRegistration
    {
        List<IParameterRegistration> Parameters { get; }
        IParameterRegistration Return { get; }
    }

    public interface IParameterRegistration
    {
    }
}
