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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Boolean))]
    public sealed partial class Boolean : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Boolean(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Boolean(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Boolean()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Boolean));
        }
        
        /// <signature>#0 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public Boolean(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[0], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#1 (Z)V (Z)V</signature>
        public Boolean(bool par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[1], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        static public global::java.lang.Boolean FALSE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Boolean>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[2]));
                }
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static public bool getBoolean(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#4 (Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static public bool parseBoolean(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[4], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#5 (Z)Ljava/lang/String; (Z)Lsystem/String;</signature>
        static public string toString(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[5], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        static public global::java.lang.Boolean TRUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Boolean>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[6]));
                }
            }
        }
        
        static public global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[7]));
                }
            }
        }
        
        /// <signature>#8 (Ljava/lang/String;)Ljava/lang/Boolean; (Lsystem/String;)Ljava/lang/Boolean;</signature>
        static public global::java.lang.Boolean valueOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Boolean>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[8], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#9 (Z)Ljava/lang/Boolean; (Z)Ljava/lang/Boolean;</signature>
        static public global::java.lang.Boolean valueOf(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Boolean>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Boolean.j4n_Class, java.lang.Boolean.j4n_Members[9], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0)));
            }
        }
        
        /// <signature>#10 ()Z ()Z</signature>
        public bool booleanValue()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Boolean.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 (Ljava/lang/Boolean;)I (Ljava/lang/Boolean;)I</signature>
        public int compareTo(global::java.lang.Boolean par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Boolean.j4n_Members[11], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#12 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Boolean.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Boolean))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Boolean";
                    proxyInfo.JVMStaticApiName = "java_.lang.Boolean_";
                    proxyInfo.CLRApi = typeof(java.lang.Boolean);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Boolean);
                    proxyInfo.CLRProxy = typeof(java.lang.Boolean);
                    proxyInfo.JVMProxyFactory = java.lang.Boolean.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #0 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Z)V", false, false), // #1 (Z)V
                        new global::net.sf.jni4net.core.MemberId("FALSE","Ljava/lang/Boolean;", true, true), // #2 ()Ljava/lang/Boolean;
                        new global::net.sf.jni4net.core.MemberId("getBoolean","(Ljava/lang/String;)Z", false, true), // #3 (Lsystem/String;)Z
                        new global::net.sf.jni4net.core.MemberId("parseBoolean","(Ljava/lang/String;)Z", false, true), // #4 (Lsystem/String;)Z
                        new global::net.sf.jni4net.core.MemberId("toString","(Z)Ljava/lang/String;", false, true), // #5 (Z)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("TRUE","Ljava/lang/Boolean;", true, true), // #6 ()Ljava/lang/Boolean;
                        new global::net.sf.jni4net.core.MemberId("TYPE","Ljava/lang/Class;", true, true), // #7 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;)Ljava/lang/Boolean;", false, true), // #8 (Lsystem/String;)Ljava/lang/Boolean;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Z)Ljava/lang/Boolean;", false, true), // #9 (Z)Ljava/lang/Boolean;
                        new global::net.sf.jni4net.core.MemberId("booleanValue","()Z", false, false), // #10 ()Z
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Boolean;)I", false, false), // #11 (Ljava/lang/Boolean;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #12 (Lsystem/Object;)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
