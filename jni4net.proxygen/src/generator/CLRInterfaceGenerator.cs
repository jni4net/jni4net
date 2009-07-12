using System.CodeDom;
using System.Reflection;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    /// <summary>
    /// Generator for CLR interface
    /// </summary>
    internal class CLRInterfaceGenerator : CLRGenerator
    {
        public CLRInterfaceGenerator(GType type) : base(type)
        {
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            if (!type.IsSkipCLRInterface)
            {
                GenerateInterface(nameSpace);
            }
            if (!config.SkipInterfaceTypeInfo)
            {
                GenerateStatic(nameSpace);
            }
            GenerateProxy(nameSpace);
        }

        private void GenerateInterface(CodeNamespace nameSpace)
        {
            var tgtType = new CodeTypeDeclaration(type.Name);
            SetCurrentType(type.JVMNamespace + "." + type.Name);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.Public;
            tgtType.IsInterface = true;
            tgtType.IsPartial = true;
            Utils.AddAttribute(tgtType, "net.sf.jni4net.attributes.JavaInterfaceAttribute");

            foreach (GType ifc in type.Interfaces)
            {
                if (ifc.IsCLRGenerate || ifc.IsCLRType)
                {
                    tgtType.BaseTypes.Add(ifc.CLRReference);
                }
            }

            if (type.Registration == null || !type.Registration.NoMethods)
            {
                // dump java side methods
                // CLR methods should be in partial file
                foreach (GMethod method in type.Methods)
                {
                    if (method.IsJVMMethod && !method.IsField)
                    {
                        CreateMethodSignature(tgtType, method, false);
                    }
                }
            }
            tgtType.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, cdc));
            tgtType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, cdc));
        }
    }
}
