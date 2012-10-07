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
        public MType(IMType parent)
        {
            Interfaces=new List<IMType>();
            Views=new Dictionary<ViewKind, IMTypeView>();
            Members=new List<IMMember>();
            Registration = new TypeRegistration
                {IsSyntetic = true, Parent = parent == null ? null : parent.Registration.Parent};
        }

        public Stage Stage { get; set; }

        public bool IsGenerate { get; set; }
        public bool IsExplore { get; set; }
        public bool IsQueueing { get; set; }
        public bool IsVerbose { get; set; }
        public Class JvmReflection { get; set; }
        public Type ClrReflection { get; set; }
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
            sb.Append(IsClr? ClrReflection.FullName : JvmReflection.getName());
            sb.Append('{');
            if (IsClr)
            {
                sb.Append('C');
                sb.Append(JvmReflection != null ? 'j' : ' ');
            }
            else
            {
                sb.Append(ClrReflection != null ? 'c' : ' ');
                sb.Append('J');
            }
            sb.Append('}');
            return sb.ToString();
        }
    }
}
