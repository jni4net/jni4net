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

namespace java.util
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Dictionary))]
    public partial class Dictionary : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected Dictionary(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util.Dictionary(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Dictionary()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Dictionary));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Dictionary()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.Dictionary.j4n_Class, java.util.Dictionary.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()Ljava/util/Enumeration; ()Ljava/util/Enumeration;</signature>
        public virtual global::java.util.Enumeration elements()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Enumeration>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Dictionary.j4n_Members[1]));
            }
        }
        
        /// <signature>#2 (Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        public virtual object get(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Dictionary.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#3 ()Z ()Z</signature>
        public virtual bool isEmpty()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Dictionary.j4n_Members[3]);
            }
        }
        
        /// <signature>#4 ()Ljava/util/Enumeration; ()Ljava/util/Enumeration;</signature>
        public virtual global::java.util.Enumeration keys()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Enumeration>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Dictionary.j4n_Members[4]));
            }
        }
        
        /// <signature>#5 (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;Lsystem/Object;)Lsystem/Object;</signature>
        public virtual object put(object par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Dictionary.j4n_Members[5], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
            }
        }
        
        /// <signature>#6 (Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        public virtual object remove(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Dictionary.j4n_Members[6], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#7 ()I ()I</signature>
        public virtual int size()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.util.Dictionary.j4n_Members[7]);
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.util.Dictionary))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.util.Dictionary";
                    proxyInfo.JVMStaticApiName = "java_.util.Dictionary_";
                    proxyInfo.CLRApi = typeof(java.util.Dictionary);
                    proxyInfo.CLRStaticApi = typeof(java.util.Dictionary);
                    proxyInfo.CLRProxy = typeof(java.util.Dictionary);
                    proxyInfo.JVMProxyFactory = java.util.Dictionary.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("elements","()Ljava/util/Enumeration;", false, false), // #1 ()Ljava/util/Enumeration;
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #2 (Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("isEmpty","()Z", false, false), // #3 ()Z
                        new global::net.sf.jni4net.core.MemberId("keys","()Ljava/util/Enumeration;", false, false), // #4 ()Ljava/util/Enumeration;
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #5 (Lsystem/Object;Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("remove","(Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #6 (Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("size","()I", false, false), // #7 ()I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
