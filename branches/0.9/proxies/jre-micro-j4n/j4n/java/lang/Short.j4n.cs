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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Short))]
    public sealed partial class Short : global::java.lang.Number, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Short(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Short(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Short()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Number));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Short));
        }
        
        /// <signature>#0 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public Short(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[0], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#1 (S)V (S)V</signature>
        public Short(short par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[1], global::net.sf.jni4net.core.ConvertShort.ToValue(par0));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;)Ljava/lang/Short; (Lsystem/String;)Ljava/lang/Short;</signature>
        static public global::java.lang.Short decode(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Short>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        static public short MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticShortField(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[3]);
                }
            }
        }
        
        static public short MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticShortField(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[4]);
                }
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;)S (Lsystem/String;)S</signature>
        static public short parseShort(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticShortMethod(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#6 (Ljava/lang/String;I)S (Lsystem/String;I)S</signature>
        static public short parseShort(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticShortMethod(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#7 (S)S (S)S</signature>
        static public short reverseBytes(short par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticShortMethod(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[7], global::net.sf.jni4net.core.ConvertShort.ToValue(par0));
            }
        }
        
        static public int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[8]);
                }
            }
        }
        
        /// <signature>#9 (S)Ljava/lang/String; (S)Lsystem/String;</signature>
        static public string toString(short par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[9], global::net.sf.jni4net.core.ConvertShort.ToValue(par0));
            }
        }
        
        static public global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[10]));
                }
            }
        }
        
        /// <signature>#11 (Ljava/lang/String;)Ljava/lang/Short; (Lsystem/String;)Ljava/lang/Short;</signature>
        static public global::java.lang.Short valueOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Short>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[11], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#12 (Ljava/lang/String;I)Ljava/lang/Short; (Lsystem/String;I)Ljava/lang/Short;</signature>
        static public global::java.lang.Short valueOf(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Short>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[12], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#13 (S)Ljava/lang/Short; (S)Ljava/lang/Short;</signature>
        static public global::java.lang.Short valueOf(short par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Short>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Short.j4n_Class, java.lang.Short.j4n_Members[13], global::net.sf.jni4net.core.ConvertShort.ToValue(par0)));
            }
        }
        
        /// <signature>#14 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Short.j4n_Members[14], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#15 (Ljava/lang/Short;)I (Ljava/lang/Short;)I</signature>
        public int compareTo(global::java.lang.Short par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Short.j4n_Members[15], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Short))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Short";
                    proxyInfo.JVMStaticApiName = "java_.lang.Short_";
                    proxyInfo.CLRApi = typeof(java.lang.Short);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Short);
                    proxyInfo.CLRProxy = typeof(java.lang.Short);
                    proxyInfo.JVMProxyFactory = java.lang.Short.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #0 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(S)V", false, false), // #1 (S)V
                        new global::net.sf.jni4net.core.MemberId("decode","(Ljava/lang/String;)Ljava/lang/Short;", false, true), // #2 (Lsystem/String;)Ljava/lang/Short;
                        new global::net.sf.jni4net.core.MemberId("MAX_VALUE","S", true, true), // #3 ()S
                        new global::net.sf.jni4net.core.MemberId("MIN_VALUE","S", true, true), // #4 ()S
                        new global::net.sf.jni4net.core.MemberId("parseShort","(Ljava/lang/String;)S", false, true), // #5 (Lsystem/String;)S
                        new global::net.sf.jni4net.core.MemberId("parseShort","(Ljava/lang/String;I)S", false, true), // #6 (Lsystem/String;I)S
                        new global::net.sf.jni4net.core.MemberId("reverseBytes","(S)S", false, true), // #7 (S)S
                        new global::net.sf.jni4net.core.MemberId("SIZE","I", true, true), // #8 ()I
                        new global::net.sf.jni4net.core.MemberId("toString","(S)Ljava/lang/String;", false, true), // #9 (S)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("TYPE","Ljava/lang/Class;", true, true), // #10 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;)Ljava/lang/Short;", false, true), // #11 (Lsystem/String;)Ljava/lang/Short;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;I)Ljava/lang/Short;", false, true), // #12 (Lsystem/String;I)Ljava/lang/Short;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(S)Ljava/lang/Short;", false, true), // #13 (S)Ljava/lang/Short;
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #14 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Short;)I", false, false), // #15 (Ljava/lang/Short;)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
