using System.Collections.Generic;
using IKVM.Reflection;
using com.jni4net.proxygen.Interfaces;
using java.lang;

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
    }

    public class CommonResolver : ICommonResolver
    {
        readonly Dictionary<string, ResolverRecord> byLowName = new Dictionary<string, ResolverRecord>();
        readonly Dictionary<string, ResolverRecord> byName = new Dictionary<string, ResolverRecord>();
        
        public Dictionary<string, ResolverRecord> ByLowName { get { return byLowName; }}
        public Dictionary<string, ResolverRecord> ByName { get { return byName; } }
    }
}