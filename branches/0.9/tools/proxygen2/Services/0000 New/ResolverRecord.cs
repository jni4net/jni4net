using System;
using System.Collections.Generic;
using System.Text;
using com.jni4net.proxygen.Interfaces;
using java.lang;
using StringBuilder = System.Text.StringBuilder;
using Type = IKVM.Reflection.Type;

namespace com.jni4net.proxygen.Services
{
    public class ResolverRecord
    {
        public bool JvmCantLoad;
        public string JvmPlainName;
        public string JvmReflectionName;
        public Class Clazz;

        public bool ClrCantLoad;
        public string ClrPlainName;
        public string ClrReflectionName;
        
        public Type Type;
        public IMType Model;

        public override string ToString()
        {
            var sb=new StringBuilder();

            if(Type!=null && Clazz!=null)
            {
                sb.Append("CJ ");
                sb.Append(ClrReflectionName);
            }
            else if (Type != null)
            {
                sb.Append("C  ");
                sb.Append(ClrReflectionName);
            }
            else if (Clazz != null)
            {
                sb.Append(" J ");
                sb.Append(JvmReflectionName);
            }
            else
            {
                sb.Append("INVALID");
            }

            return sb.ToString();
        }
    }

    public class CommonResolver : ICommonResolver
    {
        readonly Dictionary<string, ResolverRecord> byLowName = new Dictionary<string, ResolverRecord>();
        readonly Dictionary<string, ResolverRecord> byName = new Dictionary<string, ResolverRecord>();
        
        public Dictionary<string, ResolverRecord> ByLowName { get { return byLowName; }}
        public Dictionary<string, ResolverRecord> ByName { get { return byName; } }
    }
}