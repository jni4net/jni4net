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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.IllegalArgumentException))]
    public partial class IllegalArgumentException : global::java.lang.RuntimeException
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected IllegalArgumentException(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.IllegalArgumentException(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static IllegalArgumentException()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.RuntimeException));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.IllegalArgumentException));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public IllegalArgumentException()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.IllegalArgumentException.j4n_Class, java.lang.IllegalArgumentException.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public IllegalArgumentException(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.IllegalArgumentException.j4n_Class, java.lang.IllegalArgumentException.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;Ljava/lang/Throwable;)V (Lsystem/String;LSystem/Exception;)V</signature>
        public IllegalArgumentException(string par0, global::System.Exception par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.IllegalArgumentException.j4n_Class, java.lang.IllegalArgumentException.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Throwable"));
            }
        }
        
        /// <signature>#3 (Ljava/lang/Throwable;)V (LSystem/Exception;)V</signature>
        public IllegalArgumentException(global::System.Exception par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.IllegalArgumentException.j4n_Class, java.lang.IllegalArgumentException.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Throwable"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.IllegalArgumentException))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.IllegalArgumentException";
                    proxyInfo.JVMStaticApiName = "java_.lang.IllegalArgumentException_";
                    proxyInfo.CLRApi = typeof(java.lang.IllegalArgumentException);
                    proxyInfo.CLRStaticApi = typeof(java.lang.IllegalArgumentException);
                    proxyInfo.CLRProxy = typeof(java.lang.IllegalArgumentException);
                    proxyInfo.JVMProxyFactory = java.lang.IllegalArgumentException.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V", false, false), // #2 (Lsystem/String;LSystem/Exception;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/Throwable;)V", false, false), // #3 (LSystem/Exception;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
