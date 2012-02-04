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

namespace net.sf.jni4net
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(net.sf.jni4net.Out))]
    public partial class Out : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected Out(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new net.sf.jni4net.Out(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Out()
        {
            global::net.sf.jni4net.modules.jni4net.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(net.sf.jni4net.Out));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Out()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(net.sf.jni4net.Out.j4n_Class, net.sf.jni4net.Out.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public virtual object getValue()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, net.sf.jni4net.Out.j4n_Members[1]));
            }
        }
        
        /// <signature>#2 (Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        public virtual void setValue(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, net.sf.jni4net.Out.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::net.sf.jni4net.Out))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "net.sf.jni4net.Out";
                    proxyInfo.JVMStaticApiName = "net.sf.jni4net.Out_";
                    proxyInfo.CLRApi = typeof(net.sf.jni4net.Out);
                    proxyInfo.CLRStaticApi = typeof(net.sf.jni4net.Out);
                    proxyInfo.CLRProxy = typeof(net.sf.jni4net.Out);
                    proxyInfo.JVMProxyFactory = net.sf.jni4net.Out.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("getValue","()Ljava/lang/Object;", false, false), // #1 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("setValue","(Ljava/lang/Object;)V", false, false), // #2 (Lsystem/Object;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
