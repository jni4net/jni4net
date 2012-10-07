using System.Text;
using com.jni4net.proxygen.Interfaces;
using com.jni4net.proxygen.Utils;
using polyglottos;

namespace com.jni4net.proxygen.Model
{
    

    public class UTypeUsage : /*IGSnippet,*/ IUTypeUsage
    {
        public UTypeUsage(IMTypeView usedType, IMTypeView declaringType)
        {
            UsedType = usedType;
            DeclaringType = declaringType;
            ArrayRank=new int[10];
        }

        public bool IsReturn { get; set; }
        public bool IsParameter { get; set; }
        public IMTypeView DeclaringType { get; set; }
        public IMTypeView UsedType { get; set; }

        public IParameterRegistration ParameterRegistration { get; set; }
        public string MethodParameterName { get; set; }


        public bool IsOut { get; set; }
        public bool IsRef { get; set; }
        public bool IsReference { get; set; }
        public bool IsPointer { get; set; }
        public int[] ArrayRank { get; set; }
        public bool IsArray
        {
            get
            {
                return ArrayRank[0] > 0;
            }
        }
        
        public string TypeToString(TypeArgs nameArgs)
        {
            var sb=new StringBuilder();
            var name = UsedType.Name;
            if (EnumUtils.IsSet(nameArgs, TypeArgs.NameNamespace))
            {
                if (EnumUtils.IsSet(nameArgs, TypeArgs.GlobalPrefix))
                {
                    sb.Append("global::");
                }
                for (int i = 0; i < name.Namespaces.Count; i++)
                {
                    var ns = name.Namespaces[i];
                    if (i > 0)
                    {
                        sb.Append('.');
                    }
                    sb.Append(ns);
                }
                for (int i = 0; i < name.Enclosing.Count; i++)
                {
                    var ns = name.Enclosing[i];
                    if (i > 0 || name.Namespaces.Count>0)
                    {
                        if (i>0 && EnumUtils.IsSet(nameArgs, TypeArgs.Reflection))
                        {
                            sb.Append(DeclaringType.IsClr ? '+' : '$');
                        }
                        else
                        {
                            sb.Append('.');
                        }
                    }
                    sb.Append(ns);
                }
            }
            if (name.Namespaces.Count > 0 || name.Enclosing.Count>0)
            {
                if (name.Enclosing.Count>0 && EnumUtils.IsSet(nameArgs, TypeArgs.Reflection))
                {
                    sb.Append(DeclaringType.IsClr ? '+' : '$');
                }
                else
                {
                    sb.Append('.');
                }
            }
            sb.Append(name.Name);
            if (EnumUtils.IsSet(nameArgs, TypeArgs.Arguments))
            {
                if (IsArray)
                {
                    for (int i = 0; i < ArrayRank.Length; i++)
                    {
                        if (ArrayRank[i] > 0)
                        {
                            sb.Append('[');
                            sb.Append(',', ArrayRank[i] - 1);
                            sb.Append(']');
                        }
                    }
                }
                if (IsReference)
                {
                    sb.Append("&");
                }
                if (IsPointer)
                {
                    sb.Append("*");
                }
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            if(IsParameter)
            {
                return MethodParameterName + " " + TypeToString(TypeArgs.NameNamespaceArgumentsPrefix);
            }
            return TypeToString(TypeArgs.NameNamespaceArguments);
        }
    }
}
