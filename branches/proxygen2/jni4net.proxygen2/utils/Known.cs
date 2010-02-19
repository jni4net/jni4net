using System;
using System.CodeDom;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace net.sf.jni4net.proxygen.utils
{
    public class Known
    {
        public const string eMagicIface = "//</generated-interface>";
        public const string eMagicProxy = "//</generated-proxy>";
        public const string eMagicStatic = "//</generated-static>";
        public const string sMagicIface = "//<generated-interface>";
        public const string sMagicProxy = "//<generated-proxy>";
        public const string sMagicStatic = "//<generated-static>";

        public const string cdcComment = "magic comment";
        public const string cdc = "Component Designer generated code";

        public const string JavaMethodAttribute = "net.sf.jni4net.attributes.JavaMethodAttribute";
        public const string classVariableName = "__class";
        public const string envpVariableName = "__envp";
        public const string envVariableName = "__env";
        public const string handleVariableName = "__handle";
        public const string objVariableName = "__obj";
        public const string realVariableName = "__real";
        public const string typeVariableName = "__type";
        public static readonly CodeVariableReferenceExpression envVariable = new CodeVariableReferenceExpression(envVariableName);
        public static readonly CodeVariableReferenceExpression objVariable = new CodeVariableReferenceExpression(objVariableName);
        public static readonly CodeVariableReferenceExpression realVariable = new CodeVariableReferenceExpression(realVariableName);

        public static readonly CodeTypeReference javaLangClass = new CodeTypeReference(typeof(java.lang.Class), CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference javaLangObject = new CodeTypeReference(typeof(java.lang.Object), CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference javaLangString = new CodeTypeReference(typeof(java.lang.String), CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference IConstructionHelper = new CodeTypeReference(typeof(IConstructionHelper), CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference IJvmProxy = new CodeTypeReference(typeof(IJvmProxy), CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference JNIEnv = new CodeTypeReference(typeof(JNIEnv), CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference INJEnv = new CodeTypeReference("net.sf.jni4net.inj.INJEnv", CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference Long = new CodeTypeReference("long", CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference systemtTypeJ = new CodeTypeReference("systemt.Type", CodeTypeReferenceOptions.GlobalReference);
        public static readonly CodeTypeReference systemtTypeC = new CodeTypeReference(typeof(Type), CodeTypeReferenceOptions.GlobalReference);
        
        
    }
}
