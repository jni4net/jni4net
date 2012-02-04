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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Long))]
    public sealed partial class Long : global::java.lang.Number, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Long(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Long(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Long()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Number));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Long));
        }
        
        /// <signature>#0 (J)V (J)V</signature>
        public Long(long par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[0], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public Long(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 (J)I (J)I</signature>
        static public int bitCount(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[2], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;)Ljava/lang/Long; (Lsystem/String;)Ljava/lang/Long;</signature>
        static public global::java.lang.Long decode(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Long>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#4 (Ljava/lang/String;)Ljava/lang/Long; (Lsystem/String;)Ljava/lang/Long;</signature>
        static public global::java.lang.Long getLong(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Long>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[4], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;J)Ljava/lang/Long; (Lsystem/String;J)Ljava/lang/Long;</signature>
        static public global::java.lang.Long getLong(string par0, long par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Long>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertLong.ToValue(par1)));
            }
        }
        
        /// <signature>#7 (J)J (J)J</signature>
        static public long highestOneBit(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[7], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#8 (J)J (J)J</signature>
        static public long lowestOneBit(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[8], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        static public long MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticLongField(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[9]);
                }
            }
        }
        
        static public long MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticLongField(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[10]);
                }
            }
        }
        
        /// <signature>#11 (J)I (J)I</signature>
        static public int numberOfLeadingZeros(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[11], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#12 (J)I (J)I</signature>
        static public int numberOfTrailingZeros(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[12], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#13 (Ljava/lang/String;)J (Lsystem/String;)J</signature>
        static public long parseLong(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[13], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#14 (Ljava/lang/String;I)J (Lsystem/String;I)J</signature>
        static public long parseLong(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[14], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#15 (J)J (J)J</signature>
        static public long reverse(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[15], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#16 (J)J (J)J</signature>
        static public long reverseBytes(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[16], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#17 (JI)J (JI)J</signature>
        static public long rotateLeft(long par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[17], global::net.sf.jni4net.core.ConvertLong.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#18 (JI)J (JI)J</signature>
        static public long rotateRight(long par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[18], global::net.sf.jni4net.core.ConvertLong.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#19 (J)I (J)I</signature>
        static public int signum(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[19], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        static public int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[20]);
                }
            }
        }
        
        /// <signature>#21 (J)Ljava/lang/String; (J)Lsystem/String;</signature>
        static public string toBinaryString(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[21], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#22 (J)Ljava/lang/String; (J)Lsystem/String;</signature>
        static public string toHexString(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[22], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#23 (J)Ljava/lang/String; (J)Lsystem/String;</signature>
        static public string toOctalString(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[23], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#24 (J)Ljava/lang/String; (J)Lsystem/String;</signature>
        static public string toString(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[24], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#25 (JI)Ljava/lang/String; (JI)Lsystem/String;</signature>
        static public string toString(long par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[25], global::net.sf.jni4net.core.ConvertLong.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        static public global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[26]));
                }
            }
        }
        
        /// <signature>#27 (J)Ljava/lang/Long; (J)Ljava/lang/Long;</signature>
        static public global::java.lang.Long valueOf(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Long>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[27], global::net.sf.jni4net.core.ConvertLong.ToValue(par0)));
            }
        }
        
        /// <signature>#28 (Ljava/lang/String;)Ljava/lang/Long; (Lsystem/String;)Ljava/lang/Long;</signature>
        static public global::java.lang.Long valueOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Long>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[28], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#29 (Ljava/lang/String;I)Ljava/lang/Long; (Lsystem/String;I)Ljava/lang/Long;</signature>
        static public global::java.lang.Long valueOf(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Long>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Long.j4n_Class, java.lang.Long.j4n_Members[29], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#30 (Ljava/lang/Long;)I (Ljava/lang/Long;)I</signature>
        public int compareTo(global::java.lang.Long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Long.j4n_Members[30], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#31 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Long.j4n_Members[31], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Long))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Long";
                    proxyInfo.JVMStaticApiName = "java_.lang.Long_";
                    proxyInfo.CLRApi = typeof(java.lang.Long);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Long);
                    proxyInfo.CLRProxy = typeof(java.lang.Long);
                    proxyInfo.JVMProxyFactory = java.lang.Long.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(J)V", false, false), // #0 (J)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("bitCount","(J)I", false, true), // #2 (J)I
                        new global::net.sf.jni4net.core.MemberId("decode","(Ljava/lang/String;)Ljava/lang/Long;", false, true), // #3 (Lsystem/String;)Ljava/lang/Long;
                        new global::net.sf.jni4net.core.MemberId("getLong","(Ljava/lang/String;)Ljava/lang/Long;", false, true), // #4 (Lsystem/String;)Ljava/lang/Long;
                        new global::net.sf.jni4net.core.MemberId("getLong","(Ljava/lang/String;J)Ljava/lang/Long;", false, true), // #5 (Lsystem/String;J)Ljava/lang/Long;
                        new global::net.sf.jni4net.core.MemberId("getLong","(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;", false, true), // #6 (Lsystem/String;Ljava/lang/Long;)Ljava/lang/Long;
                        new global::net.sf.jni4net.core.MemberId("highestOneBit","(J)J", false, true), // #7 (J)J
                        new global::net.sf.jni4net.core.MemberId("lowestOneBit","(J)J", false, true), // #8 (J)J
                        new global::net.sf.jni4net.core.MemberId("MAX_VALUE","J", true, true), // #9 ()J
                        new global::net.sf.jni4net.core.MemberId("MIN_VALUE","J", true, true), // #10 ()J
                        new global::net.sf.jni4net.core.MemberId("numberOfLeadingZeros","(J)I", false, true), // #11 (J)I
                        new global::net.sf.jni4net.core.MemberId("numberOfTrailingZeros","(J)I", false, true), // #12 (J)I
                        new global::net.sf.jni4net.core.MemberId("parseLong","(Ljava/lang/String;)J", false, true), // #13 (Lsystem/String;)J
                        new global::net.sf.jni4net.core.MemberId("parseLong","(Ljava/lang/String;I)J", false, true), // #14 (Lsystem/String;I)J
                        new global::net.sf.jni4net.core.MemberId("reverse","(J)J", false, true), // #15 (J)J
                        new global::net.sf.jni4net.core.MemberId("reverseBytes","(J)J", false, true), // #16 (J)J
                        new global::net.sf.jni4net.core.MemberId("rotateLeft","(JI)J", false, true), // #17 (JI)J
                        new global::net.sf.jni4net.core.MemberId("rotateRight","(JI)J", false, true), // #18 (JI)J
                        new global::net.sf.jni4net.core.MemberId("signum","(J)I", false, true), // #19 (J)I
                        new global::net.sf.jni4net.core.MemberId("SIZE","I", true, true), // #20 ()I
                        new global::net.sf.jni4net.core.MemberId("toBinaryString","(J)Ljava/lang/String;", false, true), // #21 (J)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toHexString","(J)Ljava/lang/String;", false, true), // #22 (J)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toOctalString","(J)Ljava/lang/String;", false, true), // #23 (J)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","(J)Ljava/lang/String;", false, true), // #24 (J)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","(JI)Ljava/lang/String;", false, true), // #25 (JI)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("TYPE","Ljava/lang/Class;", true, true), // #26 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(J)Ljava/lang/Long;", false, true), // #27 (J)Ljava/lang/Long;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;)Ljava/lang/Long;", false, true), // #28 (Lsystem/String;)Ljava/lang/Long;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;I)Ljava/lang/Long;", false, true), // #29 (Lsystem/String;I)Ljava/lang/Long;
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Long;)I", false, false), // #30 (Ljava/lang/Long;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #31 (Lsystem/Object;)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
