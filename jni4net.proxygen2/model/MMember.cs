using System;
using System.Collections.Generic;
using System.Reflection;
using java.lang.reflect;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    public class MMember : IModel
    {
        public MType Parent { get; set; }

        public string Name { get; set; }

        //original, with return type, dots
        public string Signature { get; set; }

        public string SignatureJvm { get; set; }
        public string SignatureClr { get; set; }
        public string SignatureJvmNoRet { get; set; }
        public string SignatureClrNoRet { get; set; }

        public MMethodClr Clr { get; set; }
        public MMethodJvm Jvm { get; set; }

        public bool IsLoaded { get; set; }

        public bool IsStatic { get; set; }
        public bool IsVoid { get; set; }
        public bool IsProperty { get; set; }
        public bool IsEvent { get; set; }

        public bool IsConstructor { get; set; }
        public bool IsField { get; set; }
        public bool IsFinal { get; set; }

        public List<MParameter> Parameters=new List<MParameter>();
        public MParameter Return;

        public MMember Pair { get; set; }

        public MMember(MType parent ,MethodInfo methodInfo)
        {
            Parent = parent;
            Clr=new MMethodClr();
            Clr.MethodInfo = methodInfo;
            Clr.MemberInfo = methodInfo;
            Name = methodInfo.Name;
            Signature = "(";
            foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
            {
                Signature += parameterInfo.ParameterType + ";";
            }
            Signature += methodInfo.ReturnType == null
                             ? ")"
                             : ")" + methodInfo.ReturnType;
        }

        public MMember(MType parent, ConstructorInfo constructorInfo)
        {
            Parent = parent;
            Clr = new MMethodClr();
            Clr.ConstructorInfo = constructorInfo;
            Clr.MemberInfo = constructorInfo;
            Name = parent.Name;
            IsVoid = true;
            IsConstructor = true;
            Signature = "(";
            foreach (ParameterInfo parameterInfo in constructorInfo.GetParameters())
            {
                Signature += parameterInfo.ParameterType + ";";
            }
            Signature += ")";
        }

        public MMember(MType parent, EventInfo eventInfo)
        {
            Parent = parent;
            Clr = new MMethodClr();
            Clr.EventInfo = eventInfo;
            Clr.MemberInfo = eventInfo;
            Name = eventInfo.Name;
            Signature = "()" + eventInfo.EventHandlerType;
        }

        public MMember(MType parent, PropertyInfo propInfo)
        {
            Parent = parent;
            Clr = new MMethodClr();
            Clr.PropertyInfo = propInfo;
            Clr.MemberInfo = propInfo;
            Name = propInfo.Name;
            Signature = "()" + propInfo.PropertyType;
        }

        public class MMethodClr
        {
            public MemberInfo MemberInfo { get; set; }
            public PropertyInfo PropertyInfo { get; set; }
            public EventInfo EventInfo { get; set; }
            public ConstructorInfo ConstructorInfo { get; set; }
            public FieldInfo FieldInfo { get; set; }
            public MethodInfo MethodInfo { get; set; }
        }

        public class MMethodJvm
        {
            public Method Method { get; set; }
            public Constructor Constructor { get; set; }
            public Field Field { get; set; }
        }

        public void Accept(IModelVisitor visitor, Repository repository)
        {
            visitor.VisitMember(this, repository);
            foreach (MParameter parameter in Parameters)
            {
                parameter.Accept(visitor, repository);
            }
            if (Return!=null)
            {
                Return.Accept(visitor, repository);
            }
        }

        public string Key
        {
            get { return Name + Signature; }
        }

        public override string ToString()
        {
            return Name + Signature;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Signature.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            MMember o = obj as MMember;
            if (o == null)
                return false;
            return Name.Equals(o.Name)
                && Signature.Equals(o.Signature);
        }
    }
}
