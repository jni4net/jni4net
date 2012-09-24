using System.Collections.Generic;
using System.Text;
using com.jni4net.config;
using com.jni4net.proxygen.Interfaces;
using java.lang;
using StringBuilder = System.Text.StringBuilder;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Model
{
    public class MType : IMType
    {
        public MType()
        {
            Interfaces=new List<IMType>();
            Views=new Dictionary<ViewKind, IMTypeView>();
            Members=new List<IMMember>();
            Registration = new TypeRegistration {IsSyntetic = true};
        }

        public Stage Stage { get; set; }

        public bool IsGenerate { get; set; }
        public bool IsExplore { get; set; }
        public bool IsQueueing { get; set; }
        public bool IsVerbose { get; set; }
        public Class JvmType { get; set; }
        public Type ClrType { get; set; }
        public bool IsClr { get; set; }
        public bool IsJvm { get { return !IsClr; } set { IsClr = !value; } }

        public IMType Parent { get; set; }
        public IMType Base { get; set; }
        public List<IMType> Interfaces { get; set; }
        public Dictionary<ViewKind,IMTypeView> Views { get; set; }
        public List<IMMember> Members { get; set; }
        public ITypeRegistration Registration { get; set; }

        public override string ToString()
        {
            var sb=new StringBuilder();
            sb.Append(IsClr? ClrType.FullName : JvmType.getName());
            sb.Append('{');
            if (IsClr)
            {
                sb.Append('C');
                sb.Append(JvmType != null ? 'j' : ' ');
            }
            else
            {
                sb.Append(ClrType != null ? 'c' : ' ');
                sb.Append('J');
            }
            sb.Append('}');
            return sb.ToString();
        }
    }
}
