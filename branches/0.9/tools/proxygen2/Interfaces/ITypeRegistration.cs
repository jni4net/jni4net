using System.Collections.Generic;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IProjectRegistration
    {
        bool GenerateNestedClasses { get; }
    }

    public interface ITypeRegistration
    {
        List<IMemberRegistration> Members { get; }
        string Rename { get; }
        string Name { get; }
        string Move { get; }
        bool AddBaseMethods { get; }
        IProjectRegistration Parent { get; set; }
    }

    public interface IImplementsRegistration
    {
        bool Include { get; }
        bool Exclude { get; }
    }

    public interface IMemberRegistration
    {
        List<IParameterRegistration> Parameters { get; }
        IParameterRegistration Return { get; }
        string Signature { get; }
        string Rename { get; }
        bool Exclude { get; }
        bool ExplicitInterface { get; }
    }

    public interface IParameterRegistration
    {
        string Rename { get; }
        string ChangeType { get; }
    }
}
