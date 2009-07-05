using System.CodeDom;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    internal class CLRWrapperGenerator : CLRGenerator
    {
        public CLRWrapperGenerator(GType type) : base(type)
        {
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            GenerateStatic(nameSpace);
            GenerateProxy(nameSpace);
        }
    }
}
