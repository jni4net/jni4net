using System;
using System.Collections.Generic;
using java.lang;
using net.sf.jni4net.proxygen.config;
using net.sf.jni4net.proxygen.visitors;

namespace net.sf.jni4net.proxygen.model
{
    public class MType : IModel
    {
        public CType Config { get; set; }

        public Type Clr { get; set; }
        public Class Jvm { get; set; }

        //short class name
        public string Name { get; set; }

        // low, uniform, dots, incl enclosing types
        public string NameSpace { get; set; }

        public bool IsPrimitive { get; set; }
        public bool IsException { get; set; }
        public bool IsDelegate { get; set; }
        public bool IsOut { get; set; }
        public bool IsRef { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsArray { get; set; }
        public bool IsFinal { get; set; }
        public bool IsNested { get; set; }
        public bool IsInterface { get; set; }

        public bool IsRootType { get; set; }
        public bool IsKnown { get; set; }
        public bool IsGenClr { get; set; }
        public bool IsGenJvm { get; set; }
        public bool IsLoaded { get; set; }
        public MType Subst { get; set; }

        public MType Enclosing { get; set; }
        public MType Base;
        public MType Element;
        public List<MType> NextedTypes = new List<MType>();

        // just immediate interfaces, not inherited from base
        public List<MType> Interfaces = new List<MType>();

        // just immediate methods, not inherited from base
        public List<MMember> Methods = new List<MMember>();
        public List<MMember> Constructors = new List<MMember>();

        public List<MMember> SkippedMethods = new List<MMember>();
        public Dictionary<string, MMember> Signatures=new Dictionary<string, MMember>();

        // static information
        public CGType GStaticClr { get; set; }
        public JGType GStaticJvm { get; set; }

        // interface or public type
        public CGType GFaceClr { get; set; }
        public JGType GFaceJvm { get; set; }

        // instance
        public CGType GProxyClr { get; set; }
        public JGType GProxyJvm { get; set; }

        // both implemented on CLR side
        public CGType GImplementation { get; set; }

        public List<GFile> GFiles = new List<GFile>();

        public MType(Type type)
        {
            Config = new CType();
            Clr = type;
            Name = type.Name;

            string fullName = type.FullName.Replace('+', '.');
            int ld = fullName.LastIndexOf('.');
            NameSpace = ld == -1
                            ? ""
                            : fullName.Substring(0, ld);
        }

        public MType(Class clazz)
        {
            Jvm = clazz;
            Name = clazz.getSimpleName();
            string fullName = ((string)clazz.getName()).Replace('$', '.');
            int ld = fullName.LastIndexOf('.');
            NameSpace = ld == -1
                            ? ""
                            : fullName.Substring(0, ld);
        }

        public void Accept(IModelVisitor visitor, Repository repository)
        {
            visitor.VisitType(this, repository);
            //the collection is changing
            List<MMember> copyMembers = new List<MMember>(Methods);
            foreach (MMember member in copyMembers)
            {
                member.Accept(visitor, repository);
            }
            foreach (GFile file in GFiles)
            {
                file.Accept(visitor, repository);
            }
        }

        public string Key
        {
            get { return (NameSpace + "." + Name).ToLowerInvariant(); }
        }

        public override string ToString()
        {
            return NameSpace + "." + Name;
        }

        public override int GetHashCode()
        {
            return NameSpace.GetHashCode() ^ Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            MType o = obj as MType;
            if (o == null)
                return false;
            return NameSpace.Equals(o.NameSpace)
                && Name.Equals(o.Name);
        }

        public string SignatureClr
        {
            get
            {
                string fullName = NameSpace + "." + Name;
                string low = fullName.ToLowerInvariant();
                int arr = low.LastIndexOf("[");
                string array = "";
                while (arr != -1)
                {
                    array += "[";
                    low = low.Substring(0, arr);
                    arr = low.LastIndexOf("[");
                }
                switch (low)
                {
                    case "bool":
                    case "boolean":
                    case "system.boolean":
                        return array + "Z";
                    case "int":
                    case "int32":
                    case "system.int32":
                        return array + "I";
                    case "double":
                    case "system.double":
                        return array + "D";
                    case "float":
                    case "single":
                    case "system.single":
                        return array + "F";
                    case "short":
                    case "int16":
                    case "system.int16":
                        return array + "S";
                    case "long":
                    case "int64":
                    case "system.int64":
                        return array + "J";
                    case "char":
                    case "system.char":
                        return array + "C";
                    case "byte":
                    case "system.byte":
                        return array + "B";
                    case "void":
                    case "system.void":
                        return array + "V";
                    default:
                        return array + "L" + fullName.Substring(0, low.Length).Replace('.', '/') + ";";
                }
            }
        }

        public string SignatureJvm
        {
            get
            {
                string fullName = NameSpace.ToLowerInvariant() + "." + Name;
                string low = fullName.ToLowerInvariant();
                int arr = low.LastIndexOf("[");
                string array = "";
                while (arr != -1)
                {
                    array += "[";
                    low = low.Substring(0, arr);
                    arr = low.LastIndexOf("[");
                }
                switch (low)
                {
                    case "bool":
                    case "boolean":
                    case "system.boolean":
                        return array + "Z";
                    case "int":
                    case "int32":
                    case "system.int32":
                        return array + "I";
                    case "double":
                    case "system.double":
                        return array + "D";
                    case "float":
                    case "single":
                    case "system.single":
                        return array + "F";
                    case "short":
                    case "int16":
                    case "system.int16":
                        return array + "S";
                    case "long":
                    case "int64":
                    case "system.int64":
                        return array + "J";
                    case "char":
                    case "system.char":
                        return array + "C";
                    case "byte":
                    case "system.byte":
                        return array + "B";
                    case "void":
                    case "system.void":
                        return array + "V";
                    default:
                        return array + "L" + fullName.Substring(0, low.Length).Replace('.', '/') + ";";
                }
            }
        }

    }
}
