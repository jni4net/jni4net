using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    class JVMStaticGenerator : JVMGenerator
    {
        public JVMStaticGenerator(GType type) : base(type)
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
        }

        private void GenerateStatic(CodeNamespace nameSpace)
        {
            // static helper type
            var tgtType = new CodeTypeDeclaration(type.Name + "_");
            SetCurrentType(type.JVMNamespaceExt + "." + type.Name + "_", type.JVMNamespace + "." + type.Name,
                           type.JVMNamespaceExt + ".__" + type.Name);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;
            Utils.AddAttribute(tgtType, "net.sf.jni4net.attributes.ClrTypeInfo");

            // fields with type information
            GenerateTypeOfInit(tgtType);


            WrapMethodsMagic(tgtType, sMagicStatic, eMagicStatic);
        }
    }
}
