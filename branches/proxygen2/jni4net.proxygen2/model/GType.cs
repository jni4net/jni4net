using System;
using System.CodeDom;
using System.Collections.Generic;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    [Flags]
    public enum Context
    {
        None = 0,

        Interface = 1,
        Static =2,
        Proxy=4,
        Implementation=8,
        CoreMask = 15,


        HomeSide=16,
        ProxySide=32,
        JvmSide = 64,
        ClrSide = 128,
    }

    public static class ContextRock
    {
        public static Context Core(this Context context)
        {
            return (context & Context.CoreMask);
        }

        public static bool Has(this Context context, Context flag)
        {
            return (context & flag) != 0;
        }

        public static bool IsHome(this Context context)
        {
            return (context & Context.HomeSide) != 0;
        }

        public static bool IsProxySide(this Context context)
        {
            return (context & Context.ProxySide) != 0;
        }

        public static bool IsJvmSide(this Context context)
        {
            return (context & Context.JvmSide) != 0;
        }

        public static bool IsClrSide(this Context context)
        {
            return (context & Context.ClrSide) != 0;
        }
    }

    public abstract class GType : IModel
    {
        public MType Model { get; set; }
        public GType Enclosing { get; set; }

        //short class name
        public string Name { get; set; }
        
        // full, dots, incl enclosing types
        public string FullName { get; set; }
        public string ReflectionName { get; set; }

        public string Namespace { get; set; }
        public string EnclosingNames { get; set; }
        public GFile File { get; set; }
        public bool IsGen
        {
            get
            {
                return File != null;
            }
        }

        public List<GMember> Methods = new List<GMember>();

        public CodeTypeDeclaration DType { get; set; }

        public CodeTypeReference DTypeReference
        {
            get
            {
                return new CodeTypeReference(FullName, CodeTypeReferenceOptions.GlobalReference);
            }
        }

        public CodeTypeReferenceExpression DTypeReferenceEx
        {
            get
            {
                return new CodeTypeReferenceExpression(new CodeTypeReference(FullName, CodeTypeReferenceOptions.GlobalReference));
            }
        }

        public CodeTypeReference DTypeReferenceOut
        {
            get
            {
                return new CodeTypeReference("net.sf.jni4net.Out<" + FullName + ">", CodeTypeReferenceOptions.GlobalReference);
            }
        }

        public CodeTypeReference DTypeReferenceRef
        {
            get
            {
                return new CodeTypeReference("net.sf.jni4net.Ref<" + FullName + ">", CodeTypeReferenceOptions.GlobalReference);
            }
        }

        protected GType(MType parent, string namespce, string enclosing, string clazz, GType enclosingType)
        {
            Name = clazz;
            EnclosingNames = enclosing;
            Namespace = namespce;

            Model = parent;
            Enclosing = enclosingType;
        }

        public string Key
        {
            get { return Model.Key + Name; }
        }

        public void Accept(IModelVisitor visitor, Repository repository)
        {
            Accept(visitor, Context.None, repository);
        }

        public void Accept(IModelVisitor visitor, Context context, Repository repository)
        {
            visitor.VisitGType(this, context, repository);
            foreach (GMember method in Methods)
            {
                visitor.VisitGMember(method, context, repository);
            }
        }
    
    }

    public class JGType : GType
    {
        public JGType(MType parent, string namespce, string enclosing, string clazz, JGType enclosingType)
            : base(parent, namespce, enclosing, clazz, enclosingType)
        {
            ReflectionName = (namespce == null ? "" : namespce.ToLowerInvariant() + ".") +
                             (enclosing == null ? "" : enclosing.Replace('.', '$') + "$") + clazz;
            if (parent.IsPrimitive)
            {
                switch (clazz)
                {
                    case "Byte":
                    case "SByte":
                        FullName = "byte";
                        break;
                    case "Int16":
                    case "UInt16":
                        FullName = "short";
                        break;
                    case "Char":
                        FullName = "char";
                        break;
                    case "Boolean":
                        FullName = "boolean";
                        break;
                    case "Int32":
                    case "UInt32":
                        FullName = "int";
                        break;
                    case "Int64":
                    case "UInt64":
                    case "IntPtr":
                    case "UIntPtr":
                        FullName = "long";
                        break;
                    case "Double":
                        FullName = "double";
                        break;
                    case "Single":
                        FullName = "float";
                        break;
                    default:
                        throw new NotImplementedException(clazz);
                }
            }
            else
            {
                FullName = (namespce == null ? "" : namespce.ToLowerInvariant() + ".") +
                           (enclosing == null ? "" : enclosing + ".") + clazz;
                if (EnclosingNames == null && enclosingType != null)
                {
                    EnclosingNames = Reflection.GetEnclosing(enclosingType.ReflectionName + "$" + Name, '$');
                }
            }
            //Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "J:" + Model.Key + "->" + FullName;
        }
    }

    public class CGType : GType
    {
        public CGType(MType parent, string namespce, string enclosing, string clazz, CGType enclosingType)
            : base(parent, namespce, enclosing, clazz, enclosingType)
        {
            ReflectionName = (namespce == null ? "" : namespce + ".") + (enclosing == null ? "" : enclosing.Replace('.', '+') + "+") + clazz;
            FullName = (namespce == null ? "" : namespce + ".") + (enclosing == null ? "" : enclosing + ".") + clazz;
            if (EnclosingNames == null && enclosingType != null)
            {
                EnclosingNames = Reflection.GetEnclosing(enclosingType.ReflectionName+"+"+Name, '+');
            }
            //Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "C:" + Model.Key + "->" + FullName;
        }
    }
}
