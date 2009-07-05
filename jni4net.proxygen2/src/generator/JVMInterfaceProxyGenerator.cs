using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    /// <summary>
    /// create static helper type for interfaces
    /// </summary>
    class JVMInterfaceProxyGenerator : JVMGenerator
    {
        public JVMInterfaceProxyGenerator(GType type) : base(type)
        {
        }

        protected override string GetFileName(string dirJava)
        {
            return Path.Combine(dirJava, type.Name + "_.java");
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            if (!config.SkipInterfaceTypeInfo)
            {
                GenerateStatic(nameSpace);
            }
            GenerateProxy(nameSpace);
        }

        private void GenerateStatic(CodeNamespace nameSpace)
        {
            // static helper type
            var tgtType = new CodeTypeDeclaration(type.Name + "_");
            SetCurrentType(type.JVMNamespace + "." + type.Name + "_", type.JVMNamespace + "." + type.Name, type.JVMNamespace + ".__" + type.Name);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;
            tgtType.AddAttribute("net.sf.jni4net.attributes.ClrTypeInfo");

            // fields with type information
            GenerateTypeOfInit(tgtType);



            WrapMethodsMagic(tgtType, sMagicStatic, eMagicStatic);
        }

    }

}
