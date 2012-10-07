using System.Collections.Generic;
using com.jni4net.proxygen.Model;
using com.jni4net.proxygen.Services;
using java.lang;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IMType
    {
        Stage Stage { get; set; }

        IMType Parent { get; set; }
        IMType Base { get; set; }
        List<IMType> Interfaces { get; }
        List<IMMember> Members { get; }
        Dictionary<ViewKind, IMTypeView> Views { get; }
        ITypeRegistration Registration { get; set; }

        IMTypeView HomeView { get; }
        IMTypeView ForeignView { get; }

        IMType Enclosing { get; set; }
        List<IMType> Nested { get; }


        Class JvmReflection { get; set; }
        Type ClrReflection { get; set; }

        bool IsClr { get; set; }
        bool IsJvm { get; set; }
        bool IsSideLocked { get; set; }

        bool IsQueueing { get; set; }
        bool IsVerbose { get; set; }
        bool IsGenerate { get; set; }
        bool IsGenerateIfMissing { get; set; }
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
        INTypeName Name { get; set; }

        new IUTypeUsage Base { get; set; }
        new List<IUTypeUsage> Interfaces { get; }
        new List<IMMemberView> Members { get; }
    
    }
}
