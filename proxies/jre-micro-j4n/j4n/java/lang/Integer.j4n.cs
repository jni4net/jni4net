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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Integer))]
    public sealed partial class Integer : global::java.lang.Number, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Integer(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Integer(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Integer()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Number));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Integer));
        }
        
        /// <signature>#0 (I)V (I)V</signature>
        public Integer(int par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[0], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public Integer(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 (I)I (I)I</signature>
        static public int bitCount(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[2], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;)Ljava/lang/Integer; (Lsystem/String;)Ljava/lang/Integer;</signature>
        static public global::java.lang.Integer decode(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Integer>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#4 (Ljava/lang/String;)Ljava/lang/Integer; (Lsystem/String;)Ljava/lang/Integer;</signature>
        static public global::java.lang.Integer getInteger(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Integer>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[4], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;I)Ljava/lang/Integer; (Lsystem/String;I)Ljava/lang/Integer;</signature>
        static public global::java.lang.Integer getInteger(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Integer>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#7 (I)I (I)I</signature>
        static public int highestOneBit(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[7], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#8 (I)I (I)I</signature>
        static public int lowestOneBit(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[8], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        static public int MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[9]);
                }
            }
        }
        
        static public int MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[10]);
                }
            }
        }
        
        /// <signature>#11 (I)I (I)I</signature>
        static public int numberOfLeadingZeros(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[11], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#12 (I)I (I)I</signature>
        static public int numberOfTrailingZeros(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[12], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#13 (Ljava/lang/String;)I (Lsystem/String;)I</signature>
        static public int parseInt(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[13], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#14 (Ljava/lang/String;I)I (Lsystem/String;I)I</signature>
        static public int parseInt(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[14], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#15 (I)I (I)I</signature>
        static public int reverse(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[15], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#16 (I)I (I)I</signature>
        static public int reverseBytes(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[16], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#17 (II)I (II)I</signature>
        static public int rotateLeft(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[17], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#18 (II)I (II)I</signature>
        static public int rotateRight(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[18], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#19 (I)I (I)I</signature>
        static public int signum(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[19], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        static public int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[20]);
                }
            }
        }
        
        /// <signature>#21 (I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static public string toBinaryString(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[21], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#22 (I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static public string toHexString(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[22], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#23 (I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static public string toOctalString(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[23], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#24 (I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static public string toString(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[24], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#25 (II)Ljava/lang/String; (II)Lsystem/String;</signature>
        static public string toString(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[25], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        static public global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[26]));
                }
            }
        }
        
        /// <signature>#27 (I)Ljava/lang/Integer; (I)Ljava/lang/Integer;</signature>
        static public global::java.lang.Integer valueOf(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Integer>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[27], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#28 (Ljava/lang/String;)Ljava/lang/Integer; (Lsystem/String;)Ljava/lang/Integer;</signature>
        static public global::java.lang.Integer valueOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Integer>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[28], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#29 (Ljava/lang/String;I)Ljava/lang/Integer; (Lsystem/String;I)Ljava/lang/Integer;</signature>
        static public global::java.lang.Integer valueOf(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Integer>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Integer.j4n_Class, java.lang.Integer.j4n_Members[29], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#30 (Ljava/lang/Integer;)I (Ljava/lang/Integer;)I</signature>
        public int compareTo(global::java.lang.Integer par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Integer.j4n_Members[30], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#31 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Integer.j4n_Members[31], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Integer))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Integer";
                    proxyInfo.JVMStaticApiName = "java_.lang.Integer_";
                    proxyInfo.CLRApi = typeof(java.lang.Integer);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Integer);
                    proxyInfo.CLRProxy = typeof(java.lang.Integer);
                    proxyInfo.JVMProxyFactory = java.lang.Integer.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(I)V", false, false), // #0 (I)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("bitCount","(I)I", false, true), // #2 (I)I
                        new global::net.sf.jni4net.core.MemberId("decode","(Ljava/lang/String;)Ljava/lang/Integer;", false, true), // #3 (Lsystem/String;)Ljava/lang/Integer;
                        new global::net.sf.jni4net.core.MemberId("getInteger","(Ljava/lang/String;)Ljava/lang/Integer;", false, true), // #4 (Lsystem/String;)Ljava/lang/Integer;
                        new global::net.sf.jni4net.core.MemberId("getInteger","(Ljava/lang/String;I)Ljava/lang/Integer;", false, true), // #5 (Lsystem/String;I)Ljava/lang/Integer;
                        new global::net.sf.jni4net.core.MemberId("getInteger","(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;", false, true), // #6 (Lsystem/String;Ljava/lang/Integer;)Ljava/lang/Integer;
                        new global::net.sf.jni4net.core.MemberId("highestOneBit","(I)I", false, true), // #7 (I)I
                        new global::net.sf.jni4net.core.MemberId("lowestOneBit","(I)I", false, true), // #8 (I)I
                        new global::net.sf.jni4net.core.MemberId("MAX_VALUE","I", true, true), // #9 ()I
                        new global::net.sf.jni4net.core.MemberId("MIN_VALUE","I", true, true), // #10 ()I
                        new global::net.sf.jni4net.core.MemberId("numberOfLeadingZeros","(I)I", false, true), // #11 (I)I
                        new global::net.sf.jni4net.core.MemberId("numberOfTrailingZeros","(I)I", false, true), // #12 (I)I
                        new global::net.sf.jni4net.core.MemberId("parseInt","(Ljava/lang/String;)I", false, true), // #13 (Lsystem/String;)I
                        new global::net.sf.jni4net.core.MemberId("parseInt","(Ljava/lang/String;I)I", false, true), // #14 (Lsystem/String;I)I
                        new global::net.sf.jni4net.core.MemberId("reverse","(I)I", false, true), // #15 (I)I
                        new global::net.sf.jni4net.core.MemberId("reverseBytes","(I)I", false, true), // #16 (I)I
                        new global::net.sf.jni4net.core.MemberId("rotateLeft","(II)I", false, true), // #17 (II)I
                        new global::net.sf.jni4net.core.MemberId("rotateRight","(II)I", false, true), // #18 (II)I
                        new global::net.sf.jni4net.core.MemberId("signum","(I)I", false, true), // #19 (I)I
                        new global::net.sf.jni4net.core.MemberId("SIZE","I", true, true), // #20 ()I
                        new global::net.sf.jni4net.core.MemberId("toBinaryString","(I)Ljava/lang/String;", false, true), // #21 (I)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toHexString","(I)Ljava/lang/String;", false, true), // #22 (I)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toOctalString","(I)Ljava/lang/String;", false, true), // #23 (I)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","(I)Ljava/lang/String;", false, true), // #24 (I)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","(II)Ljava/lang/String;", false, true), // #25 (II)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("TYPE","Ljava/lang/Class;", true, true), // #26 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(I)Ljava/lang/Integer;", false, true), // #27 (I)Ljava/lang/Integer;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;)Ljava/lang/Integer;", false, true), // #28 (Lsystem/String;)Ljava/lang/Integer;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;I)Ljava/lang/Integer;", false, true), // #29 (Lsystem/String;I)Ljava/lang/Integer;
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Integer;)I", false, false), // #30 (Ljava/lang/Integer;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #31 (Lsystem/Object;)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
