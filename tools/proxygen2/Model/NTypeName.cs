using System.Collections.Generic;
using System.Text;
using com.jni4net.proxygen.Interfaces;

namespace com.jni4net.proxygen.Model
{
    public class NTypeName : INTypeName
    {
        public NTypeName()
        {
            Namespaces=new List<string>();
            Enclosing=new List<string>();
        }

        public NTypeName(INTypeName src)
        {
            Namespaces = new List<string>(src.Namespaces);
            Enclosing = new List<string>(src.Enclosing);
            Name = src.Name;
        }

        public List<string> Namespaces { get; set; }
        public List<string> Enclosing { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            var sb=new StringBuilder();
            for (int i = 0; i < Namespaces.Count; i++)
            {
                if(i!=0)
                {
                    sb.Append(".");
                }
                sb.Append(Namespaces[i]);
            }
            for (int i = 0; i < Enclosing.Count; i++)
            {
                if (i != 0 || Namespaces.Count>0)
                {
                    sb.Append(".");
                }
                sb.Append(Enclosing[i]);
            }
            if(Namespaces.Count>0||Enclosing.Count>0)
            {
                sb.Append(".");
            }
            sb.Append(Name);
            return sb.ToString();
        }
    }
}
