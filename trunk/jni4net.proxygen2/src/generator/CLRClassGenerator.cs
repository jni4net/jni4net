using System.CodeDom;
using System.Reflection;
using net.sf.jni4net.proxygen.model;

namespace net.sf.jni4net.proxygen.generator
{
    internal class CLRClassGenerator : CLRGenerator
    {
        public CLRClassGenerator(GType type) : base(type)
        {
        }

        protected override void Generate(CodeNamespace nameSpace)
        {
            GenerateClass(nameSpace);
        }

        private void GenerateClass(CodeNamespace nameSpace)
        {
            var tgtType = new CodeTypeDeclaration(type.Name);
            SetCurrentType(type.CLRNamespace + "." + type.Name);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.Public;
            tgtType.IsPartial = true;
            tgtType.AddAttribute("net.sf.jni4net.attributes.JavaClassAttribute");
            tgtType.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, cdc));
            tgtType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, cdc));
            if (type.Base != null)
            {
                tgtType.BaseTypes.Add(type.Base.CLRReference);
            }
            foreach (GType ifc in type.Interfaces)
            {
                if (ifc.IsCLRGenerate || ifc.IsCLRType)
                {
                    tgtType.BaseTypes.Add(ifc.CLRReference);
                }
            }

            // fields with type information
            GenerateStaticFields(tgtType);
            GenerateTypeOfInit(tgtType);
            GenerateMethodsC2J(tgtType);
            GenerateConstructionHelper(tgtType);
            CreateEnvConstructor(tgtType, "net.sf.jni4net.jni.JNIEnv", type == Repository.javaLangClass || type == Repository.javaLangString, false);
        }

        private void GenerateMethodsC2J(CodeTypeDeclaration tgtType)
        {
            int m = 0;
            foreach (GMethod method in type.MethodsWithInterfaces)
            {
                string uName = ("_" + method.CLRName + m);
                CreateMethodC2J(method, tgtType, uName, false);
                m++;
            }
            foreach (GMethod method in type.Constructors)
            {
                string uName = ("_" + method.CLRName + m);
                CreateMethodC2J(method, tgtType, uName, false);
                m++;
            }
        }


        /*private void GenerateMethods(CodeTypeDeclaration tgtType)
        {
            foreach (GMethod method in type.Methods)
            {
                CreateMethodSignature(tgtType, method, false);
            }
        }*/

        private CodeMemberMethod CreateConstructorHelper(GMethod constructor, string uName)
        {
            var tgtMethod = new CodeMemberMethod();
            tgtMethod.Name = uName;
            tgtMethod.Attributes = MemberAttributes.Static | MemberAttributes.Private | MemberAttributes.New;
            tgtMethod.AddAttribute("net.sf.jni4net.attributes.ClrMethod", constructor.CLRSignature);

            // inject thiz parameter
            var tgtParameter = new CodeParameterDeclarationExpression();
            tgtParameter.Name = "thiz";
            tgtParameter.Type = constructor.Type.CLRReference;
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
