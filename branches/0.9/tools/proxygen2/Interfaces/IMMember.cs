using System.Collections.Generic;
using IKVM.Reflection;
using com.jni4net.proxygen.Model;
using java.lang.reflect;

namespace com.jni4net.proxygen.Interfaces
{
    public interface IMMember
    {
        IMType DeclaringType { get; set; }
        IMemberRegistration Registration { get; set; }
        string Name { get; set; }
        MemberInfo ClrReflection { get; set; }
        Member JvmReflection { get; set; }

        IMMemberView HomeView { get; }

        IMProperty Property { get; set; }
    
        bool IsStatic { get; set; }
        bool IsVirtual { get; set; }
        bool IsPublic { get; set; }
        bool IsGeneric { get; set; }
        bool IsFinal { get; set; }
        bool IsVoid { get; set; }

        bool IsConstructor { get; set; }
        bool IsProperty { get; set; }
        bool IsField { get; set; }
        bool IsMethod { get; set; }
        bool IsEvent { get; set; }
        
        bool IsObsolete { get; set; }
    }

    public interface IMProperty
    {
        IMType DeclaringType { get; set; }
        MemberInfo ClrReflection { get; set; }
        IMMember Get { get; set; }
        IMMember Set { get; set; }
        string Name { get; set; }
        bool IsExplicitInterface { get; set; }
    }

    public interface IMMemberView : IMMember
    {
        IUTypeUsage Ret { get; set; }
        List<IUTypeUsage> Parameters { get; set; }
    }
}
