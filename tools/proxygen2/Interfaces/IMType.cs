using System.Collections.Generic;
using java.lang;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IMType
    {
        IMType Parent { get; set; }
        IMType Base { get; set; }

        List<IMType> Interfaces { get; }
        List<IMMember> Members { get; }
        Dictionary<ViewKind, IMTypeView> Views { get; }
        ITypeRegistration Registration { get; set; }

        Class JvmType { get; set; }
        Type ClrType { get; set; }

        bool IsClr { get; set; }
        bool IsJvm { get; set; }

        bool IsVerbose { get; set; }
        bool IsGenerate { get; set; }
        bool IsExplore { get; set; }
        string ToString();
    }

    public enum ViewKind
    {
        Home,
        Foreign,//Api
        HomeProxy,
        ForeignProxy,
    }

    public interface IMTypeView : IMType
    {
        ViewKind ViewKind { get; set; }
        IMType Owner { get; set; }
    }
}
