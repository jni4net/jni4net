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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Float))]
    public sealed partial class Float : global::java.lang.Number, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Float(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Float(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Float()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Number));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Float));
        }
        
        /// <signature>#0 (D)V (D)V</signature>
        public Float(double par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[0], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#1 (F)V (F)V</signature>
        public Float(float par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[1], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public Float(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#3 (FF)I (FF)I</signature>
        static public int compare(float par0, float par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[3], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0), global::net.sf.jni4net.core.ConvertFloat.ToValue(par1));
            }
        }
        
        /// <signature>#4 (F)I (F)I</signature>
        static public int floatToIntBits(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[4], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#5 (F)I (F)I</signature>
        static public int floatToRawIntBits(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[5], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#6 (I)F (I)F</signature>
        static public float intBitsToFloat(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticFloatMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[6], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#7 (F)Z (F)Z</signature>
        static public bool isInfinite(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[7], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#8 (F)Z (F)Z</signature>
        static public bool isNaN(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[8], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        static public float MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticFloatField(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[9]);
                }
            }
        }
        
        static public float MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticFloatField(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[10]);
                }
            }
        }
        
        static public float NaN {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticFloatField(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[11]);
                }
            }
        }
        
        static public float NEGATIVE_INFINITY {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticFloatField(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[12]);
                }
            }
        }
        
        /// <signature>#13 (Ljava/lang/String;)F (Lsystem/String;)F</signature>
        static public float parseFloat(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticFloatMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[13], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        static public float POSITIVE_INFINITY {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticFloatField(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[14]);
                }
            }
        }
        
        static public int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[15]);
                }
            }
        }
        
        /// <signature>#16 (F)Ljava/lang/String; (F)Lsystem/String;</signature>
        static public string toHexString(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[16], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#17 (F)Ljava/lang/String; (F)Lsystem/String;</signature>
        static public string toString(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[17], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        static public global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[18]));
                }
            }
        }
        
        /// <signature>#19 (F)Ljava/lang/Float; (F)Ljava/lang/Float;</signature>
        static public global::java.lang.Float valueOf(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Float>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[19], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0)));
            }
        }
        
        /// <signature>#20 (Ljava/lang/String;)Ljava/lang/Float; (Lsystem/String;)Ljava/lang/Float;</signature>
        static public global::java.lang.Float valueOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Float>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Float.j4n_Class, java.lang.Float.j4n_Members[20], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#21 (Ljava/lang/Float;)I (Ljava/lang/Float;)I</signature>
        public int compareTo(global::java.lang.Float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Float.j4n_Members[21], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#22 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Float.j4n_Members[22], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#23 ()Z ()Z</signature>
        public bool isInfinite()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Float.j4n_Members[23]);
            }
        }
        
        /// <signature>#24 ()Z ()Z</signature>
        public bool isNaN()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Float.j4n_Members[24]);
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Float))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Float";
                    proxyInfo.JVMStaticApiName = "java_.lang.Float_";
                    proxyInfo.CLRApi = typeof(java.lang.Float);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Float);
                    proxyInfo.CLRProxy = typeof(java.lang.Float);
                    proxyInfo.JVMProxyFactory = java.lang.Float.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(D)V", false, false), // #0 (D)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(F)V", false, false), // #1 (F)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #2 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("compare","(FF)I", false, true), // #3 (FF)I
                        new global::net.sf.jni4net.core.MemberId("floatToIntBits","(F)I", false, true), // #4 (F)I
                        new global::net.sf.jni4net.core.MemberId("floatToRawIntBits","(F)I", false, true), // #5 (F)I
                        new global::net.sf.jni4net.core.MemberId("intBitsToFloat","(I)F", false, true), // #6 (I)F
                        new global::net.sf.jni4net.core.MemberId("isInfinite","(F)Z", false, true), // #7 (F)Z
                        new global::net.sf.jni4net.core.MemberId("isNaN","(F)Z", false, true), // #8 (F)Z
                        new global::net.sf.jni4net.core.MemberId("MAX_VALUE","F", true, true), // #9 ()F
                        new global::net.sf.jni4net.core.MemberId("MIN_VALUE","F", true, true), // #10 ()F
                        new global::net.sf.jni4net.core.MemberId("NaN","F", true, true), // #11 ()F
                        new global::net.sf.jni4net.core.MemberId("NEGATIVE_INFINITY","F", true, true), // #12 ()F
                        new global::net.sf.jni4net.core.MemberId("parseFloat","(Ljava/lang/String;)F", false, true), // #13 (Lsystem/String;)F
                        new global::net.sf.jni4net.core.MemberId("POSITIVE_INFINITY","F", true, true), // #14 ()F
                        new global::net.sf.jni4net.core.MemberId("SIZE","I", true, true), // #15 ()I
                        new global::net.sf.jni4net.core.MemberId("toHexString","(F)Ljava/lang/String;", false, true), // #16 (F)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","(F)Ljava/lang/String;", false, true), // #17 (F)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("TYPE","Ljava/lang/Class;", true, true), // #18 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(F)Ljava/lang/Float;", false, true), // #19 (F)Ljava/lang/Float;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/String;)Ljava/lang/Float;", false, true), // #20 (Lsystem/String;)Ljava/lang/Float;
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Float;)I", false, false), // #21 (Ljava/lang/Float;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #22 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("isInfinite","()Z", false, false), // #23 ()Z
                        new global::net.sf.jni4net.core.MemberId("isNaN","()Z", false, false), // #24 ()Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
