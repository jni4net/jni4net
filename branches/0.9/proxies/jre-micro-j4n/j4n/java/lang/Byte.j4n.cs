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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Byte))]
    public sealed partial class Byte : global::java.lang.Number, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Byte(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Byte(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Byte()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Number));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Byte));
        }
        
        /// <signature>#0 (B)V (B)V</signature>
        public Byte(byte par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[0], global::net.sf.jni4net.core.ConvertByte.ToValue(par0));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public Byte(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;)Ljava/lang/Byte; (Lsystem/String;)Ljava/lang/Byte;</signature>
        static public global::java.lang.Byte decode(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Byte>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        static public byte MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[3]);
                }
            }
        }
        
        static public byte MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[4]);
                }
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;)B (Lsystem/String;)B</signature>
        static public byte parseByte(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticByteMethod(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#6 (Ljava/lang/String;I)B (Lsystem/String;I)B</signature>
        static public byte parseByte(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticByteMethod(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        static public int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[7]);
                }
            }
        }
        
        /// <signature>#8 (B)Ljava/lang/String; (B)Lsystem/String;</signature>
        static public string toString(byte par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[8], global::net.sf.jni4net.core.ConvertByte.ToValue(par0));
            }
        }
        
        static public global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[9]));
                }
            }
        }
        
        /// <signature>#10 (B)Ljava/lang/Byte; (B)Ljava/lang/Byte;</signature>
        static public global::java.lang.Byte valueOf(byte par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Byte>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[10], global::net.sf.jni4net.core.ConvertByte.ToValue(par0)));
            }
        }
        
        /// <signature>#11 (Ljava/lang/String;)Ljava/lang/Byte; (Lsystem/String;)Ljava/lang/Byte;</signature>
        static public global::java.lang.Byte valueOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Byte>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[11], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#12 (Ljava/lang/String;I)Ljava/lang/Byte; (Lsystem/String;I)Ljava/lang/Byte;</signature>
        static public global::java.lang.Byte valueOf(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Byte>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Byte.j4n_Class, java.lang.Byte.j4n_Members[12], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#13 (Ljava/lang/Byte;)I (Ljava/lang/Byte;)I</signature>
        public int compareTo(global::java.lang.Byte par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Byte.j4n_Members[13], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#14 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Byte.j4n_Members[14], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Byte))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Byte";
                    proxyInfo.JVMStaticApiName = "java_.lang.Byte_";
                    proxyInfo.CLRApi = typeof(java.lang.Byte);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Byte);
                    proxyInfo.CLRProxy = typeof(java.lang.Byte);
                    proxyInfo.JVMProxyFactory = java.lang.Byte.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(B)V", false, false), // #0 (B)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("decode","(Ljava/lang/String;)Ljava/lang/Byte;", false, true), // #2 (Lsystem/String;)Ljava/lang/Byte;
                        new global::net.sf.jni4net.core.MemberId("MAX_VALUE","B", true, true), // #3 ()B
                        new global::net.sf.jni4net.core.MemberId("MIN_VALUE","B", true, true), // #4 ()B
                        new global::net.sf.jni4net.core.MemberId("parseByte","(Ljava/lang/String;)B", false, true), // #5 (Lsystem/String;)B
                        new global::net.sf.jni4net.core.MemberId("parseByte","(Ljava/lang/String;I)B", false, true), // #6 (Lsystem/String;I)B
                        new global::net.sf.jni4net.core.MemberId("SIZE","I", true, true), // #7 ()I
                        new global::net.sf.jni4net.core.MemberId("toString","(B)Ljava/lang/String;", false, true), // #8 (B)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("TYPE","Ljava/lang/Class;", true, true), // #9 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(B)Ljava/lang/Byte;", false, true), // #10 (B)Ljava/lang/Byte;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;)Ljava/lang/Byte;", false, true), // #11 (Lsystem/String;)Ljava/lang/Byte;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;I)Ljava/lang/Byte;", false, true), // #12 (Lsystem/String;I)Ljava/lang/Byte;
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Byte;)I", false, false), // #13 (Ljava/lang/Byte;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #14 (Lsystem/Object;)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
