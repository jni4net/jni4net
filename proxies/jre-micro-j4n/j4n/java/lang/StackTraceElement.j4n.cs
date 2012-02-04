// This code was generated using jni4net. See http://jni4net.sourceforge.net/

#region Component Designer generated code
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantCast
// ReSharper disable RedundantCommaInArrayInitializer
// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable UnassignedField.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable SuggestUseVarKeywordEvident
// ReSharper disable PossibleMultipleEnumeration
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedMember.Global
#pragma warning disable 109
#pragma warning disable 649
#pragma warning disable 618

namespace java.lang
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.StackTraceElement))]
    public sealed partial class StackTraceElement : global::java.lang.Object, global::java.io.Serializable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private StackTraceElement(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.StackTraceElement(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static StackTraceElement()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.StackTraceElement));
        }
        
        /// <signature>#0 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V (Lsystem/String;Lsystem/String;Lsystem/String;I)V</signature>
        public StackTraceElement(string par0, string par1, string par2, int par3)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.StackTraceElement.j4n_Class, java.lang.StackTraceElement.j4n_Members[0], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3));
            }
        }
        
        /// <signature>#1 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getClassName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.StackTraceElement.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getFileName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.StackTraceElement.j4n_Members[2]);
            }
        }
        
        /// <signature>#3 ()I ()I</signature>
        public int getLineNumber()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.StackTraceElement.j4n_Members[3]);
            }
        }
        
        /// <signature>#4 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getMethodName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.StackTraceElement.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 ()Z ()Z</signature>
        public bool isNativeMethod()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.StackTraceElement.j4n_Members[5]);
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.StackTraceElement))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.StackTraceElement";
                    proxyInfo.JVMStaticApiName = "java_.lang.StackTraceElement_";
                    proxyInfo.CLRApi = typeof(java.lang.StackTraceElement);
                    proxyInfo.CLRStaticApi = typeof(java.lang.StackTraceElement);
                    proxyInfo.CLRProxy = typeof(java.lang.StackTraceElement);
                    proxyInfo.JVMProxyFactory = java.lang.StackTraceElement.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", false, false), // #0 (Lsystem/String;Lsystem/String;Lsystem/String;I)V
                        new global::net.sf.jni4net.core.MemberId("getClassName","()Ljava/lang/String;", false, false), // #1 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getFileName","()Ljava/lang/String;", false, false), // #2 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getLineNumber","()I", false, false), // #3 ()I
                        new global::net.sf.jni4net.core.MemberId("getMethodName","()Ljava/lang/String;", false, false), // #4 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("isNativeMethod","()Z", false, false), // #5 ()Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
