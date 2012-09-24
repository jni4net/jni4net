using System.Collections.Generic;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IMMember
    {
        IMType DeclaringType { get; set; }
        IMemberRegistration Registration { get; set; }
        string Name { get; set; }
    }

    public interface IMMemberView : IMMember
    {
        List<IUTypeUsage> Ret { get; }
        List<IUTypeUsage> Parameters { get; }
    }
}
