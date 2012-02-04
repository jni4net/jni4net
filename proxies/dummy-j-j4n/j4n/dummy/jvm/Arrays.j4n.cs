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

namespace dummy.jvm
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Arrays))]
    public partial class Arrays : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected Arrays(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new dummy.jvm.Arrays(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Arrays()
        {
            global::net.sf.jni4net.modules.dummyjj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Arrays));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Arrays()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()[[Z ()[[Z</signature>
        static public bool[][] boolean11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertBoolean.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[1]));
            }
        }
        
        /// <signature>#2 ()[[Z ()[[Z</signature>
        static public bool[][] boolean11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertBoolean.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[2]));
            }
        }
        
        /// <signature>#3 ()[[Z ()[[Z</signature>
        static public bool[][] boolean11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertBoolean.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[3]));
            }
        }
        
        /// <signature>#4 ()[[B ()[[B</signature>
        static public byte[][] byte11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertByte.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[4]));
            }
        }
        
        /// <signature>#5 ()[[B ()[[B</signature>
        static public byte[][] byte11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertByte.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[5]));
            }
        }
        
        /// <signature>#6 ()[[B ()[[B</signature>
        static public byte[][] byte11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertByte.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[6]));
            }
        }
        
        /// <signature>#7 ()[[C ()[[C</signature>
        static public char[][] char11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertChar.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[7]));
            }
        }
        
        /// <signature>#8 ()[[C ()[[C</signature>
        static public char[][] char11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertChar.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 ()[[C ()[[C</signature>
        static public char[][] char11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertChar.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[9]));
            }
        }
        
        /// <signature>#10 ()[[Ljava/lang/Class; ()[[Ljava/lang/Object;</signature>
        static public global::java.lang.Object[][] class11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray11<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[10]));
            }
        }
        
        /// <signature>#11 ()[[Ljava/lang/Class; ()[[Ljava/lang/Object;</signature>
        static public global::java.lang.Object[][] class11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray11<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[11]));
            }
        }
        
        /// <signature>#12 ()[[Ljava/lang/Class; ()[[Ljava/lang/Object;</signature>
        static public global::java.lang.Object[][] class11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray11<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[12]));
            }
        }
        
        /// <signature>#13 ()[[D ()[[D</signature>
        static public double[][] double11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertDouble.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[13]));
            }
        }
        
        /// <signature>#14 ()[[D ()[[D</signature>
        static public double[][] double11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertDouble.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[14]));
            }
        }
        
        /// <signature>#15 ()[[D ()[[D</signature>
        static public double[][] double11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertDouble.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[15]));
            }
        }
        
        /// <signature>#16 (Ljava/lang/Object;Ljava/lang/Object;)Z (Lsystem/Object;Lsystem/Object;)Z</signature>
        static public bool equals(object par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[16], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"));
            }
        }
        
        /// <signature>#17 ()[[F ()[[F</signature>
        static public float[][] float11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertFloat.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[17]));
            }
        }
        
        /// <signature>#18 ()[[F ()[[F</signature>
        static public float[][] float11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertFloat.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[18]));
            }
        }
        
        /// <signature>#19 ()[[F ()[[F</signature>
        static public float[][] float11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertFloat.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[19]));
            }
        }
        
        /// <signature>#20 ()[[I ()[[I</signature>
        static public int[][] int11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertInt.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[20]));
            }
        }
        
        /// <signature>#21 ()[[I ()[[I</signature>
        static public int[][] int11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertInt.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[21]));
            }
        }
        
        /// <signature>#22 ()[[I ()[[I</signature>
        static public int[][] int11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertInt.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[22]));
            }
        }
        
        /// <signature>#23 ()[Ljava/util/Comparator; ()[Ljava/lang/Object;</signature>
        static public global::java.lang.Object[] interface1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[23]));
            }
        }
        
        /// <signature>#24 ()[[Ljava/util/Comparator; ()[[Ljava/lang/Object;</signature>
        static public global::java.lang.Object[][] interface11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray11<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[24]));
            }
        }
        
        /// <signature>#25 ()[[Ljava/util/Comparator; ()[[Ljava/lang/Object;</signature>
        static public global::java.lang.Object[][] interface11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray11<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[25]));
            }
        }
        
        /// <signature>#26 ()[[Ljava/util/Comparator; ()[[Ljava/lang/Object;</signature>
        static public global::java.lang.Object[][] interface11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray11<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[26]));
            }
        }
        
        /// <signature>#27 ()[[J ()[[J</signature>
        static public long[][] long11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertLong.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[27]));
            }
        }
        
        /// <signature>#28 ()[[J ()[[J</signature>
        static public long[][] long11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertLong.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[28]));
            }
        }
        
        /// <signature>#29 ()[[J ()[[J</signature>
        static public long[][] long11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertLong.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[29]));
            }
        }
        
        /// <signature>#30 ()[[S ()[[S</signature>
        static public short[][] short11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertShort.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[30]));
            }
        }
        
        /// <signature>#31 ()[[S ()[[S</signature>
        static public short[][] short11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertShort.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[31]));
            }
        }
        
        /// <signature>#32 ()[[S ()[[S</signature>
        static public short[][] short11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertShort.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[32]));
            }
        }
        
        /// <signature>#33 ()[[Ljava/lang/String; ()[[Lsystem/String;</signature>
        static public string[][] string11_l1()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertString.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[33]));
            }
        }
        
        /// <signature>#34 ()[[Ljava/lang/String; ()[[Lsystem/String;</signature>
        static public string[][] string11_l2()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertString.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[34]));
            }
        }
        
        /// <signature>#35 ()[[Ljava/lang/String; ()[[Lsystem/String;</signature>
        static public string[][] string11_lj()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertString.ToCLRArray11(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Arrays.j4n_Class, dummy.jvm.Arrays.j4n_Members[35]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::dummy.jvm.Arrays))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "dummy.jvm.Arrays";
                    proxyInfo.JVMStaticApiName = "dummy.jvm.Arrays_";
                    proxyInfo.CLRApi = typeof(dummy.jvm.Arrays);
                    proxyInfo.CLRStaticApi = typeof(dummy.jvm.Arrays);
                    proxyInfo.CLRProxy = typeof(dummy.jvm.Arrays);
                    proxyInfo.JVMProxyFactory = dummy.jvm.Arrays.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("boolean11_l1","()[[Z", false, true), // #1 ()[[Z
                        new global::net.sf.jni4net.core.MemberId("boolean11_l2","()[[Z", false, true), // #2 ()[[Z
                        new global::net.sf.jni4net.core.MemberId("boolean11_lj","()[[Z", false, true), // #3 ()[[Z
                        new global::net.sf.jni4net.core.MemberId("byte11_l1","()[[B", false, true), // #4 ()[[B
                        new global::net.sf.jni4net.core.MemberId("byte11_l2","()[[B", false, true), // #5 ()[[B
                        new global::net.sf.jni4net.core.MemberId("byte11_lj","()[[B", false, true), // #6 ()[[B
                        new global::net.sf.jni4net.core.MemberId("char11_l1","()[[C", false, true), // #7 ()[[C
                        new global::net.sf.jni4net.core.MemberId("char11_l2","()[[C", false, true), // #8 ()[[C
                        new global::net.sf.jni4net.core.MemberId("char11_lj","()[[C", false, true), // #9 ()[[C
                        new global::net.sf.jni4net.core.MemberId("class11_l1","()[[Ljava/lang/Class;", false, true), // #10 ()[[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("class11_l2","()[[Ljava/lang/Class;", false, true), // #11 ()[[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("class11_lj","()[[Ljava/lang/Class;", false, true), // #12 ()[[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("double11_l1","()[[D", false, true), // #13 ()[[D
                        new global::net.sf.jni4net.core.MemberId("double11_l2","()[[D", false, true), // #14 ()[[D
                        new global::net.sf.jni4net.core.MemberId("double11_lj","()[[D", false, true), // #15 ()[[D
                        new global::net.sf.jni4net.core.MemberId("equals","(Ljava/lang/Object;Ljava/lang/Object;)Z", false, true), // #16 (Lsystem/Object;Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("float11_l1","()[[F", false, true), // #17 ()[[F
                        new global::net.sf.jni4net.core.MemberId("float11_l2","()[[F", false, true), // #18 ()[[F
                        new global::net.sf.jni4net.core.MemberId("float11_lj","()[[F", false, true), // #19 ()[[F
                        new global::net.sf.jni4net.core.MemberId("int11_l1","()[[I", false, true), // #20 ()[[I
                        new global::net.sf.jni4net.core.MemberId("int11_l2","()[[I", false, true), // #21 ()[[I
                        new global::net.sf.jni4net.core.MemberId("int11_lj","()[[I", false, true), // #22 ()[[I
                        new global::net.sf.jni4net.core.MemberId("interface1","()[Ljava/util/Comparator;", false, true), // #23 ()[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("interface11_l1","()[[Ljava/util/Comparator;", false, true), // #24 ()[[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("interface11_l2","()[[Ljava/util/Comparator;", false, true), // #25 ()[[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("interface11_lj","()[[Ljava/util/Comparator;", false, true), // #26 ()[[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("long11_l1","()[[J", false, true), // #27 ()[[J
                        new global::net.sf.jni4net.core.MemberId("long11_l2","()[[J", false, true), // #28 ()[[J
                        new global::net.sf.jni4net.core.MemberId("long11_lj","()[[J", false, true), // #29 ()[[J
                        new global::net.sf.jni4net.core.MemberId("short11_l1","()[[S", false, true), // #30 ()[[S
                        new global::net.sf.jni4net.core.MemberId("short11_l2","()[[S", false, true), // #31 ()[[S
                        new global::net.sf.jni4net.core.MemberId("short11_lj","()[[S", false, true), // #32 ()[[S
                        new global::net.sf.jni4net.core.MemberId("string11_l1","()[[Ljava/lang/String;", false, true), // #33 ()[[Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("string11_l2","()[[Ljava/lang/String;", false, true), // #34 ()[[Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("string11_lj","()[[Ljava/lang/String;", false, true), // #35 ()[[Lsystem/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
