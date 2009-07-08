using System.CodeDom;
using System.Reflection;
using net.sf.jni4net.inj;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    internal class JVMClassGenerator : JVMGenerator
    {
        public JVMClassGenerator(GType type) : base(type)
        {
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            CodeTypeDeclaration tgtType = new CodeTypeDeclaration(type.Name);
            SetCurrentType(type.JVMNamespace + "." + type.Name);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = type.Attributes & TypeAttributes.VisibilityMask;
            /*if (type.IsAbstract)
            {
                tgtType.TypeAttributes |= TypeAttributes.Abstract;
            }*/
            tgtType.AddAttribute("net.sf.jni4net.attributes.ClrType");
            if (type.Base != null)
            {
                tgtType.BaseTypes.Add(type.Base.JVMReference);
            }
            foreach (GType ifc in type.Interfaces)
            {
                if (ifc.IsJVMGenerate || ifc.IsJVMType)
                {
                    tgtType.BaseTypes.Add(ifc.JVMReference);
                }
            }

            // fields with type information
            CreateEnvConstructor(tgtType, "net.sf.jni4net.inj.INJEnv", false, true);
            GenerateConstructors(tgtType);
            GenerateMethods(tgtType);
            GenerateTypeOfInit(tgtType);

            WrapMethodsMagic(tgtType, sMagicProxy, eMagicProxy);
        }

        private void GenerateMethods(CodeTypeDeclaration tgtType)
        {
            foreach (GMethod method in type.MethodsWithInterfaces)
            {
                CodeMemberMethod tgtMethod = CreateMethodSignature(method, false);
                tgtType.Members.Add(tgtMethod);

                ChangeNativeAttributes(tgtMethod);
            }
        }

        private void GenerateConstructors(CodeTypeDeclaration tgtType)
        {
            int m = 0;

            // constructors
            foreach (GMethod constructor in type.Constructors)
            {
                string uName = ("__ctor" + type.Name + m);

                //create constructor
                var tgtConstructor = CreateMethodSignature(constructor, false) as CodeConstructor;
                CreateConstructorBody(constructor, tgtConstructor, uName);
                tgtType.Members.Add(tgtConstructor);
                
                //create helper for it
                var tgtHelper = CreateConstructorHelper(constructor, uName);
                tgtType.Members.Add(tgtHelper);

                m++;
            }

            if (type.Constructors.Count == 0 
                && type.JVMFullName!="system.Object"
                && type.JVMFullName != "system.Exception")
            {
                var cc = new CodeConstructor();
                cc.Attributes = MemberAttributes.Family;
                cc.BaseConstructorArgs.Add(
                    new CodeCastExpression(
                        new CodeTypeReference("net.sf.jni4net.inj.INJEnv"),
                        new CodePrimitiveExpression(null)));
                cc.BaseConstructorArgs.Add(new CodePrimitiveExpression(0));
                tgtType.Members.Add(cc);
            }
        }

        private CodeMemberMethod CreateConstructorHelper(GMethod constructor, string uName)
        {
            CodeMemberMethod tgtMethod = new CodeMemberMethod();
            tgtMethod.Name = uName;
            tgtMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private | MemberAttributes.New;
            tgtMethod.AddAttribute("net.sf.jni4net.attributes.ClrMethod", constructor.JVMSignature);

            // inject thiz parameter
            var tgtParameter = new CodeParameterDeclarationExpression();
            tgtParameter.Name = "thiz";
            tgtParameter.Type = TypeReference(typeof(IClrProxy));
            tgtMethod.Parameters.Add(tgtParameter);
            
            GenerateParameters(constructor, tgtMethod);

            return tgtMethod;
        }

        private void CreateConstructorBody(GMethod constructor, CodeConstructor con, string uName)
        {
            if (!type.IsRootType)
            {
                con.BaseConstructorArgs.Add(
                    new CodeCastExpression(TypeReference("net.sf.jni4net.inj.INJEnv"), new CodePrimitiveExpression(null)));
                con.BaseConstructorArgs.Add(new CodePrimitiveExpression(0));
            }

            var parameters = new CodeExpression[constructor.Parameters.Count + 1];
            for (int p = 0; p < constructor.Parameters.Count; p++)
            {
                parameters[p + 1] = new CodeVariableReferenceExpression(constructor.ParameterNames[p]);
            }
            parameters[0] = new CodeThisReferenceExpression();
            con.Statements.Add(
                new CodeMethodInvokeExpression(CurrentTypeEx, uName, parameters));
        }
    }
}
