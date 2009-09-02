using System.CodeDom;
using System.IO;
using System.Reflection;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    /// <summary>
    /// create static helper type for interfaces
    /// </summary>
    internal class JVMInterfaceProxyGenerator : JVMStaticGenerator
    {
        public JVMInterfaceProxyGenerator(GType type) : base(type)
        {
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            base.Generate(nameSpace);
            GenerateProxy(nameSpace);
        }

    }
}
