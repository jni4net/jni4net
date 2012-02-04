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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Double))]
    public sealed partial class Double : global::java.lang.Number, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Double(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Double(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Double()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Number));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Double));
        }
        
        /// <signature>#0 (D)V (D)V</signature>
        public Double(double par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[0], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public Double(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 (DD)I (DD)I</signature>
        static public int compare(double par0, double par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[2], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0), global::net.sf.jni4net.core.ConvertDouble.ToValue(par1));
            }
        }
        
        /// <signature>#3 (D)J (D)J</signature>
        static public long doubleToLongBits(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[3], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#4 (D)J (D)J</signature>
        static public long doubleToRawLongBits(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticLongMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[4], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#5 (D)Z (D)Z</signature>
        static public bool isInfinite(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[5], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#6 (D)Z (D)Z</signature>
        static public bool isNaN(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[6], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#7 (J)D (J)D</signature>
        static public double longBitsToDouble(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticDoubleMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[7], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        static public double MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticDoubleField(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[8]);
                }
            }
        }
        
        static public double MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticDoubleField(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[9]);
                }
            }
        }
        
        static public double NaN {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticDoubleField(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[10]);
                }
            }
        }
        
        static public double NEGATIVE_INFINITY {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticDoubleField(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[11]);
                }
            }
        }
        
        /// <signature>#12 (Ljava/lang/String;)D (Lsystem/String;)D</signature>
        static public double parseDouble(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticDoubleMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[12], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        static public double POSITIVE_INFINITY {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticDoubleField(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[13]);
                }
            }
        }
        
        static public int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[14]);
                }
            }
        }
        
        /// <signature>#15 (D)Ljava/lang/String; (D)Lsystem/String;</signature>
        static public string toHexString(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[15], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#16 (D)Ljava/lang/String; (D)Lsystem/String;</signature>
        static public string toString(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[16], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        static public global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[17]));
                }
            }
        }
        
        /// <signature>#18 (D)Ljava/lang/Double; (D)Ljava/lang/Double;</signature>
        static public global::java.lang.Double valueOf(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Double>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[18], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0)));
            }
        }
        
        /// <signature>#19 (Ljava/lang/String;)Ljava/lang/Double; (Lsystem/String;)Ljava/lang/Double;</signature>
        static public global::java.lang.Double valueOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Double>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Double.j4n_Class, java.lang.Double.j4n_Members[19], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#20 (Ljava/lang/Double;)I (Ljava/lang/Double;)I</signature>
        public int compareTo(global::java.lang.Double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Double.j4n_Members[20], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#21 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Double.j4n_Members[21], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#22 ()Z ()Z</signature>
        public bool isInfinite()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Double.j4n_Members[22]);
            }
        }
        
        /// <signature>#23 ()Z ()Z</signature>
        public bool isNaN()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Double.j4n_Members[23]);
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Double))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Double";
                    proxyInfo.JVMStaticApiName = "java_.lang.Double_";
                    proxyInfo.CLRApi = typeof(java.lang.Double);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Double);
                    proxyInfo.CLRProxy = typeof(java.lang.Double);
                    proxyInfo.JVMProxyFactory = java.lang.Double.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(D)V", false, false), // #0 (D)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("compare","(DD)I", false, true), // #2 (DD)I
                        new global::net.sf.jni4net.core.MemberId("doubleToLongBits","(D)J", false, true), // #3 (D)J
                        new global::net.sf.jni4net.core.MemberId("doubleToRawLongBits","(D)J", false, true), // #4 (D)J
                        new global::net.sf.jni4net.core.MemberId("isInfinite","(D)Z", false, true), // #5 (D)Z
                        new global::net.sf.jni4net.core.MemberId("isNaN","(D)Z", false, true), // #6 (D)Z
                        new global::net.sf.jni4net.core.MemberId("longBitsToDouble","(J)D", false, true), // #7 (J)D
                        new global::net.sf.jni4net.core.MemberId("MAX_VALUE","D", true, true), // #8 ()D
                        new global::net.sf.jni4net.core.MemberId("MIN_VALUE","D", true, true), // #9 ()D
                        new global::net.sf.jni4net.core.MemberId("NaN","D", true, true), // #10 ()D
                        new global::net.sf.jni4net.core.MemberId("NEGATIVE_INFINITY","D", true, true), // #11 ()D
                        new global::net.sf.jni4net.core.MemberId("parseDouble","(Ljava/lang/String;)D", false, true), // #12 (Lsystem/String;)D
                        new global::net.sf.jni4net.core.MemberId("POSITIVE_INFINITY","D", true, true), // #13 ()D
                        new global::net.sf.jni4net.core.MemberId("SIZE","I", true, true), // #14 ()I
                        new global::net.sf.jni4net.core.MemberId("toHexString","(D)Ljava/lang/String;", false, true), // #15 (D)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","(D)Ljava/lang/String;", false, true), // #16 (D)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("TYPE","Ljava/lang/Class;", true, true), // #17 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(D)Ljava/lang/Double;", false, true), // #18 (D)Ljava/lang/Double;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;)Ljava/lang/Double;", false, true), // #19 (Lsystem/String;)Ljava/lang/Double;
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Double;)I", false, false), // #20 (Ljava/lang/Double;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #21 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("isInfinite","()Z", false, false), // #22 ()Z
                        new global::net.sf.jni4net.core.MemberId("isNaN","()Z", false, false), // #23 ()Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
