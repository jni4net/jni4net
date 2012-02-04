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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Hashtable))]
    public partial class Hashtable : global::java.util.Dictionary, global::java.util.Map, global::java.lang.Cloneable, global::java.io.Serializable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected Hashtable(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util.Hashtable(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Hashtable()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.util.Dictionary));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.util.Map_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.util.Map_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Cloneable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Cloneable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Hashtable));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Hashtable()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.Hashtable.j4n_Class, java.util.Hashtable.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 (I)V (I)V</signature>
        public Hashtable(int par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.Hashtable.j4n_Class, java.util.Hashtable.j4n_Members[1], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#2 (IF)V (IF)V</signature>
        public Hashtable(int par0, float par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.Hashtable.j4n_Class, java.util.Hashtable.j4n_Members[2], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertFloat.ToValue(par1));
            }
        }
        
        /// <signature>#3 (Ljava/util/Map;)V (Ljava/util/Map;)V</signature>
        public Hashtable(global::java.util.Map par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.Hashtable.j4n_Class, java.util.Hashtable.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Map"));
            }
        }
        
        /// <signature>#4 ()V ()V</signature>
        public virtual void clear()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.util.Hashtable.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public virtual object clone()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Hashtable.j4n_Members[5]));
            }
        }
        
        /// <signature>#6 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public virtual bool contains(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Hashtable.j4n_Members[6], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#7 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public virtual bool containsKey(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Hashtable.j4n_Members[7], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#8 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public virtual bool containsValue(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Hashtable.j4n_Members[8], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#9 ()Ljava/util/Set; ()Ljava/util/Set;</signature>
        public virtual global::java.util.Set entrySet()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Set>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Hashtable.j4n_Members[9]));
            }
        }
        
        /// <signature>#10 ()Ljava/util/Set; ()Ljava/util/Set;</signature>
        public virtual global::java.util.Set keySet()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Set>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Hashtable.j4n_Members[10]));
            }
        }
        
        /// <signature>#11 (Ljava/util/Map;)V (Ljava/util/Map;)V</signature>
        public virtual void putAll(global::java.util.Map par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.Hashtable.j4n_Members[11], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Map"));
            }
        }
        
        /// <signature>#12 ()Ljava/util/Collection; ()Ljava/util/Collection;</signature>
        public virtual global::java.util.Collection values()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Collection>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Hashtable.j4n_Members[12]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.util.Hashtable))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.util.Hashtable";
                    proxyInfo.JVMStaticApiName = "java_.util.Hashtable_";
                    proxyInfo.CLRApi = typeof(java.util.Hashtable);
                    proxyInfo.CLRStaticApi = typeof(java.util.Hashtable);
                    proxyInfo.CLRProxy = typeof(java.util.Hashtable);
                    proxyInfo.JVMProxyFactory = java.util.Hashtable.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","(I)V", false, false), // #1 (I)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IF)V", false, false), // #2 (IF)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/util/Map;)V", false, false), // #3 (Ljava/util/Map;)V
                        new global::net.sf.jni4net.core.MemberId("clear","()V", false, false), // #4 ()V
                        new global::net.sf.jni4net.core.MemberId("clone","()Ljava/lang/Object;", false, false), // #5 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("contains","(Ljava/lang/Object;)Z", false, false), // #6 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("containsKey","(Ljava/lang/Object;)Z", false, false), // #7 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("containsValue","(Ljava/lang/Object;)Z", false, false), // #8 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("entrySet","()Ljava/util/Set;", false, false), // #9 ()Ljava/util/Set;
                        new global::net.sf.jni4net.core.MemberId("keySet","()Ljava/util/Set;", false, false), // #10 ()Ljava/util/Set;
                        new global::net.sf.jni4net.core.MemberId("putAll","(Ljava/util/Map;)V", false, false), // #11 (Ljava/util/Map;)V
                        new global::net.sf.jni4net.core.MemberId("values","()Ljava/util/Collection;", false, false), // #12 ()Ljava/util/Collection;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
