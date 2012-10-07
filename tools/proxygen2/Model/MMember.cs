using System.Collections.Generic;
using IKVM.Reflection;
using com.jni4net.proxygen.Interfaces;
using java.lang.reflect;

namespace com.jni4net.proxygen.Model
{
    public class MMember : IMMember
    {
        public MMember(IMType declaringType, string name)
        {
            DeclaringType = declaringType;
            Name = name;
            HomeView = new MMemberView(this, ViewKind.Home);
        }

        public MemberInfo ClrReflection { get; set; }
        public Member JvmReflection { get; set; }
        public IMMemberView HomeView { get; set; }
        public IMProperty Property { get; set; }
        public bool IsStatic { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsPublic { get; set; }
        public bool IsGeneric { get; set; }
        public bool IsFinal { get; set; }
        public bool IsVoid { get; set; }
        public bool IsConstructor { get; set; }
        public bool IsProperty { get; set; }
        public bool IsField { get; set; }
        public bool IsMethod { get; set; }
        public bool IsEvent { get; set; }
        public bool IsObsolete { get; set; }
        public IMType DeclaringType { get; set; }
        public IMemberRegistration Registration { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return DeclaringType.IsClr
                       ? ClrReflection.ToString()
                       : JvmReflection.ToString();
        }
    }

    public class MProperty : IMProperty
    {
        public MProperty(IMType declaringType, string name)
        {
            DeclaringType = declaringType;
            Name = name;
        }

        public IMType DeclaringType { get; set; }
        public MemberInfo ClrReflection { get; set; }
        public IMMember Get { get; set; }
        public IMMember Set { get; set; }
        public string Name { get; set; }
        public bool IsExplicitInterface { get; set; }
    }
}
