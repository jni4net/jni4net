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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Arrays))]
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
            return new java.util.Arrays(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Arrays()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Arrays));
        }
        
        /// <signature>#0 ([Ljava/lang/Object;)Ljava/util/List; ([Lsystem/Object;)Ljava/util/List;</signature>
        static public global::java.util.List asList(object[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.List>(j4n_env, j4n_env.CallStaticObjectMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#1 ([BB)I ([BB)I</signature>
        static public int binarySearch(byte[] par0, byte par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[1], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertByte.ToValue(par1));
            }
        }
        
        /// <signature>#2 ([CC)I ([CC)I</signature>
        static public int binarySearch(char[] par0, char par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[2], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1));
            }
        }
        
        /// <signature>#3 ([DD)I ([DD)I</signature>
        static public int binarySearch(double[] par0, double par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[3], global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertDouble.ToValue(par1));
            }
        }
        
        /// <signature>#4 ([FF)I ([FF)I</signature>
        static public int binarySearch(float[] par0, float par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[4], global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertFloat.ToValue(par1));
            }
        }
        
        /// <signature>#5 ([II)I ([II)I</signature>
        static public int binarySearch(int[] par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[5], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#6 ([JJ)I ([JJ)I</signature>
        static public int binarySearch(long[] par0, long par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[6], global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertLong.ToValue(par1));
            }
        }
        
        /// <signature>#7 ([Ljava/lang/Object;Ljava/lang/Object;)I ([Lsystem/Object;Lsystem/Object;)I</signature>
        static public int binarySearch(object[] par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[7], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"));
            }
        }
        
        /// <signature>#8 ([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I ([Lsystem/Object;Lsystem/Object;Ljava/util/Comparator;)I</signature>
        static public int binarySearch(object[] par0, object par1, global::java.util.Comparator par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[8], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.util.Comparator"));
            }
        }
        
        /// <signature>#9 ([SS)I ([SS)I</signature>
        static public int binarySearch(short[] par0, short par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[9], global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertShort.ToValue(par1));
            }
        }
        
        /// <signature>#10 ([Ljava/lang/Object;[Ljava/lang/Object;)Z ([Lsystem/Object;[Lsystem/Object;)Z</signature>
        static public bool deepEquals(object[] par0, object[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[10], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"));
            }
        }
        
        /// <signature>#11 ([Ljava/lang/Object;)I ([Lsystem/Object;)I</signature>
        static public int deepHashCode(object[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[11], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#12 ([Ljava/lang/Object;)Ljava/lang/String; ([Lsystem/Object;)Lsystem/String;</signature>
        static public string deepToString(object[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#13 ([B[B)Z ([B[B)Z</signature>
        static public bool equals(byte[] par0, byte[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[13], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#14 ([C[C)Z ([C[C)Z</signature>
        static public bool equals(char[] par0, char[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[14], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#15 ([D[D)Z ([D[D)Z</signature>
        static public bool equals(double[] par0, double[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[15], global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#16 ([F[F)Z ([F[F)Z</signature>
        static public bool equals(float[] par0, float[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[16], global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#17 ([I[I)Z ([I[I)Z</signature>
        static public bool equals(int[] par0, int[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[17], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#18 ([J[J)Z ([J[J)Z</signature>
        static public bool equals(long[] par0, long[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[18], global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#19 ([Ljava/lang/Object;[Ljava/lang/Object;)Z ([Lsystem/Object;[Lsystem/Object;)Z</signature>
        static public bool equals(object[] par0, object[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[19], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"));
            }
        }
        
        /// <signature>#20 ([S[S)Z ([S[S)Z</signature>
        static public bool equals(short[] par0, short[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[20], global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#21 ([Z[Z)Z ([Z[Z)Z</signature>
        static public bool equals(bool[] par0, bool[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[21], global::net.sf.jni4net.core.ConvertBoolean.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertBoolean.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#22 ([BB)V ([BB)V</signature>
        static public void fill(byte[] par0, byte par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[22], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertByte.ToValue(par1));
            }
        }
        
        /// <signature>#23 ([BIIB)V ([BIIB)V</signature>
        static public void fill(byte[] par0, int par1, int par2, byte par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[23], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertByte.ToValue(par3));
            }
        }
        
        /// <signature>#24 ([CC)V ([CC)V</signature>
        static public void fill(char[] par0, char par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[24], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1));
            }
        }
        
        /// <signature>#25 ([CIIC)V ([CIIC)V</signature>
        static public void fill(char[] par0, int par1, int par2, char par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[25], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertChar.ToValue(par3));
            }
        }
        
        /// <signature>#26 ([DD)V ([DD)V</signature>
        static public void fill(double[] par0, double par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[26], global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertDouble.ToValue(par1));
            }
        }
        
        /// <signature>#27 ([DIID)V ([DIID)V</signature>
        static public void fill(double[] par0, int par1, int par2, double par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[27], global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertDouble.ToValue(par3));
            }
        }
        
        /// <signature>#28 ([FF)V ([FF)V</signature>
        static public void fill(float[] par0, float par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[28], global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertFloat.ToValue(par1));
            }
        }
        
        /// <signature>#29 ([FIIF)V ([FIIF)V</signature>
        static public void fill(float[] par0, int par1, int par2, float par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[29], global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertFloat.ToValue(par3));
            }
        }
        
        /// <signature>#30 ([II)V ([II)V</signature>
        static public void fill(int[] par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[30], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#31 ([IIII)V ([IIII)V</signature>
        static public void fill(int[] par0, int par1, int par2, int par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[31], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3));
            }
        }
        
        /// <signature>#32 ([JIIJ)V ([JIIJ)V</signature>
        static public void fill(long[] par0, int par1, int par2, long par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[32], global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertLong.ToValue(par3));
            }
        }
        
        /// <signature>#33 ([JJ)V ([JJ)V</signature>
        static public void fill(long[] par0, long par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[33], global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertLong.ToValue(par1));
            }
        }
        
        /// <signature>#34 ([Ljava/lang/Object;IILjava/lang/Object;)V ([Lsystem/Object;IILsystem/Object;)V</signature>
        static public void fill(object[] par0, int par1, int par2, object par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[34], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par3, "java.lang.Object"));
            }
        }
        
        /// <signature>#35 ([Ljava/lang/Object;Ljava/lang/Object;)V ([Lsystem/Object;Lsystem/Object;)V</signature>
        static public void fill(object[] par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[35], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"));
            }
        }
        
        /// <signature>#36 ([SIIS)V ([SIIS)V</signature>
        static public void fill(short[] par0, int par1, int par2, short par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[36], global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertShort.ToValue(par3));
            }
        }
        
        /// <signature>#37 ([SS)V ([SS)V</signature>
        static public void fill(short[] par0, short par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[37], global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertShort.ToValue(par1));
            }
        }
        
        /// <signature>#38 ([ZIIZ)V ([ZIIZ)V</signature>
        static public void fill(bool[] par0, int par1, int par2, bool par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[38], global::net.sf.jni4net.core.ConvertBoolean.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par3));
            }
        }
        
        /// <signature>#39 ([ZZ)V ([ZZ)V</signature>
        static public void fill(bool[] par0, bool par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[39], global::net.sf.jni4net.core.ConvertBoolean.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1));
            }
        }
        
        /// <signature>#40 ([B)I ([B)I</signature>
        static public int hashCode(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[40], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#41 ([C)I ([C)I</signature>
        static public int hashCode(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[41], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#42 ([D)I ([D)I</signature>
        static public int hashCode(double[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[42], global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#43 ([F)I ([F)I</signature>
        static public int hashCode(float[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[43], global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#44 ([I)I ([I)I</signature>
        static public int hashCode(int[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[44], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#45 ([J)I ([J)I</signature>
        static public int hashCode(long[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[45], global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#46 ([Ljava/lang/Object;)I ([Lsystem/Object;)I</signature>
        static public int hashCode(object[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[46], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#47 ([S)I ([S)I</signature>
        static public int hashCode(short[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[47], global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#48 ([Z)I ([Z)I</signature>
        static public int hashCode(bool[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[48], global::net.sf.jni4net.core.ConvertBoolean.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#49 ([B)V ([B)V</signature>
        static public void sort(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[49], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#50 ([BII)V ([BII)V</signature>
        static public void sort(byte[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[50], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#51 ([C)V ([C)V</signature>
        static public void sort(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[51], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#52 ([CII)V ([CII)V</signature>
        static public void sort(char[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[52], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#53 ([D)V ([D)V</signature>
        static public void sort(double[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[53], global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#54 ([DII)V ([DII)V</signature>
        static public void sort(double[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[54], global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#55 ([F)V ([F)V</signature>
        static public void sort(float[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[55], global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#56 ([FII)V ([FII)V</signature>
        static public void sort(float[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[56], global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#57 ([I)V ([I)V</signature>
        static public void sort(int[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[57], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#58 ([III)V ([III)V</signature>
        static public void sort(int[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[58], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#59 ([J)V ([J)V</signature>
        static public void sort(long[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[59], global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#60 ([JII)V ([JII)V</signature>
        static public void sort(long[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[60], global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#61 ([Ljava/lang/Object;)V ([Lsystem/Object;)V</signature>
        static public void sort(object[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[61], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#62 ([Ljava/lang/Object;II)V ([Lsystem/Object;II)V</signature>
        static public void sort(object[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[62], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#63 ([Ljava/lang/Object;IILjava/util/Comparator;)V ([Lsystem/Object;IILjava/util/Comparator;)V</signature>
        static public void sort(object[] par0, int par1, int par2, global::java.util.Comparator par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[63], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par3, "java.util.Comparator"));
            }
        }
        
        /// <signature>#64 ([Ljava/lang/Object;Ljava/util/Comparator;)V ([Lsystem/Object;Ljava/util/Comparator;)V</signature>
        static public void sort(object[] par0, global::java.util.Comparator par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[64], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.util.Comparator"));
            }
        }
        
        /// <signature>#65 ([S)V ([S)V</signature>
        static public void sort(short[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[65], global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#66 ([SII)V ([SII)V</signature>
        static public void sort(short[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[66], global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#67 ([B)Ljava/lang/String; ([B)Lsystem/String;</signature>
        static public string toString(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[67], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#68 ([C)Ljava/lang/String; ([C)Lsystem/String;</signature>
        static public string toString(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[68], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#69 ([D)Ljava/lang/String; ([D)Lsystem/String;</signature>
        static public string toString(double[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[69], global::net.sf.jni4net.core.ConvertDouble.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#70 ([F)Ljava/lang/String; ([F)Lsystem/String;</signature>
        static public string toString(float[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[70], global::net.sf.jni4net.core.ConvertFloat.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#71 ([I)Ljava/lang/String; ([I)Lsystem/String;</signature>
        static public string toString(int[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[71], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#72 ([J)Ljava/lang/String; ([J)Lsystem/String;</signature>
        static public string toString(long[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[72], global::net.sf.jni4net.core.ConvertLong.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#73 ([Ljava/lang/Object;)Ljava/lang/String; ([Lsystem/Object;)Lsystem/String;</signature>
        static public string toString(object[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[73], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#74 ([S)Ljava/lang/String; ([S)Lsystem/String;</signature>
        static public string toString(short[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[74], global::net.sf.jni4net.core.ConvertShort.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#75 ([Z)Ljava/lang/String; ([Z)Lsystem/String;</signature>
        static public string toString(bool[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.util.Arrays.j4n_Class, java.util.Arrays.j4n_Members[75], global::net.sf.jni4net.core.ConvertBoolean.ToValue(j4n_env, par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.util.Arrays))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.util.Arrays";
                    proxyInfo.JVMStaticApiName = "java_.util.Arrays_";
                    proxyInfo.CLRApi = typeof(java.util.Arrays);
                    proxyInfo.CLRStaticApi = typeof(java.util.Arrays);
                    proxyInfo.CLRProxy = typeof(java.util.Arrays);
                    proxyInfo.JVMProxyFactory = java.util.Arrays.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("asList","([Ljava/lang/Object;)Ljava/util/List;", false, true), // #0 ([Lsystem/Object;)Ljava/util/List;
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([BB)I", false, true), // #1 ([BB)I
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([CC)I", false, true), // #2 ([CC)I
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([DD)I", false, true), // #3 ([DD)I
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([FF)I", false, true), // #4 ([FF)I
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([II)I", false, true), // #5 ([II)I
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([JJ)I", false, true), // #6 ([JJ)I
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([Ljava/lang/Object;Ljava/lang/Object;)I", false, true), // #7 ([Lsystem/Object;Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I", false, true), // #8 ([Lsystem/Object;Lsystem/Object;Ljava/util/Comparator;)I
                        new global::net.sf.jni4net.core.MemberId("binarySearch","([SS)I", false, true), // #9 ([SS)I
                        new global::net.sf.jni4net.core.MemberId("deepEquals","([Ljava/lang/Object;[Ljava/lang/Object;)Z", false, true), // #10 ([Lsystem/Object;[Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("deepHashCode","([Ljava/lang/Object;)I", false, true), // #11 ([Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("deepToString","([Ljava/lang/Object;)Ljava/lang/String;", false, true), // #12 ([Lsystem/Object;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("equals","([B[B)Z", false, true), // #13 ([B[B)Z
                        new global::net.sf.jni4net.core.MemberId("equals","([C[C)Z", false, true), // #14 ([C[C)Z
                        new global::net.sf.jni4net.core.MemberId("equals","([D[D)Z", false, true), // #15 ([D[D)Z
                        new global::net.sf.jni4net.core.MemberId("equals","([F[F)Z", false, true), // #16 ([F[F)Z
                        new global::net.sf.jni4net.core.MemberId("equals","([I[I)Z", false, true), // #17 ([I[I)Z
                        new global::net.sf.jni4net.core.MemberId("equals","([J[J)Z", false, true), // #18 ([J[J)Z
                        new global::net.sf.jni4net.core.MemberId("equals","([Ljava/lang/Object;[Ljava/lang/Object;)Z", false, true), // #19 ([Lsystem/Object;[Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("equals","([S[S)Z", false, true), // #20 ([S[S)Z
                        new global::net.sf.jni4net.core.MemberId("equals","([Z[Z)Z", false, true), // #21 ([Z[Z)Z
                        new global::net.sf.jni4net.core.MemberId("fill","([BB)V", false, true), // #22 ([BB)V
                        new global::net.sf.jni4net.core.MemberId("fill","([BIIB)V", false, true), // #23 ([BIIB)V
                        new global::net.sf.jni4net.core.MemberId("fill","([CC)V", false, true), // #24 ([CC)V
                        new global::net.sf.jni4net.core.MemberId("fill","([CIIC)V", false, true), // #25 ([CIIC)V
                        new global::net.sf.jni4net.core.MemberId("fill","([DD)V", false, true), // #26 ([DD)V
                        new global::net.sf.jni4net.core.MemberId("fill","([DIID)V", false, true), // #27 ([DIID)V
                        new global::net.sf.jni4net.core.MemberId("fill","([FF)V", false, true), // #28 ([FF)V
                        new global::net.sf.jni4net.core.MemberId("fill","([FIIF)V", false, true), // #29 ([FIIF)V
                        new global::net.sf.jni4net.core.MemberId("fill","([II)V", false, true), // #30 ([II)V
                        new global::net.sf.jni4net.core.MemberId("fill","([IIII)V", false, true), // #31 ([IIII)V
                        new global::net.sf.jni4net.core.MemberId("fill","([JIIJ)V", false, true), // #32 ([JIIJ)V
                        new global::net.sf.jni4net.core.MemberId("fill","([JJ)V", false, true), // #33 ([JJ)V
                        new global::net.sf.jni4net.core.MemberId("fill","([Ljava/lang/Object;IILjava/lang/Object;)V", false, true), // #34 ([Lsystem/Object;IILsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("fill","([Ljava/lang/Object;Ljava/lang/Object;)V", false, true), // #35 ([Lsystem/Object;Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("fill","([SIIS)V", false, true), // #36 ([SIIS)V
                        new global::net.sf.jni4net.core.MemberId("fill","([SS)V", false, true), // #37 ([SS)V
                        new global::net.sf.jni4net.core.MemberId("fill","([ZIIZ)V", false, true), // #38 ([ZIIZ)V
                        new global::net.sf.jni4net.core.MemberId("fill","([ZZ)V", false, true), // #39 ([ZZ)V
                        new global::net.sf.jni4net.core.MemberId("hashCode","([B)I", false, true), // #40 ([B)I
                        new global::net.sf.jni4net.core.MemberId("hashCode","([C)I", false, true), // #41 ([C)I
                        new global::net.sf.jni4net.core.MemberId("hashCode","([D)I", false, true), // #42 ([D)I
                        new global::net.sf.jni4net.core.MemberId("hashCode","([F)I", false, true), // #43 ([F)I
                        new global::net.sf.jni4net.core.MemberId("hashCode","([I)I", false, true), // #44 ([I)I
                        new global::net.sf.jni4net.core.MemberId("hashCode","([J)I", false, true), // #45 ([J)I
                        new global::net.sf.jni4net.core.MemberId("hashCode","([Ljava/lang/Object;)I", false, true), // #46 ([Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("hashCode","([S)I", false, true), // #47 ([S)I
                        new global::net.sf.jni4net.core.MemberId("hashCode","([Z)I", false, true), // #48 ([Z)I
                        new global::net.sf.jni4net.core.MemberId("sort","([B)V", false, true), // #49 ([B)V
                        new global::net.sf.jni4net.core.MemberId("sort","([BII)V", false, true), // #50 ([BII)V
                        new global::net.sf.jni4net.core.MemberId("sort","([C)V", false, true), // #51 ([C)V
                        new global::net.sf.jni4net.core.MemberId("sort","([CII)V", false, true), // #52 ([CII)V
                        new global::net.sf.jni4net.core.MemberId("sort","([D)V", false, true), // #53 ([D)V
                        new global::net.sf.jni4net.core.MemberId("sort","([DII)V", false, true), // #54 ([DII)V
                        new global::net.sf.jni4net.core.MemberId("sort","([F)V", false, true), // #55 ([F)V
                        new global::net.sf.jni4net.core.MemberId("sort","([FII)V", false, true), // #56 ([FII)V
                        new global::net.sf.jni4net.core.MemberId("sort","([I)V", false, true), // #57 ([I)V
                        new global::net.sf.jni4net.core.MemberId("sort","([III)V", false, true), // #58 ([III)V
                        new global::net.sf.jni4net.core.MemberId("sort","([J)V", false, true), // #59 ([J)V
                        new global::net.sf.jni4net.core.MemberId("sort","([JII)V", false, true), // #60 ([JII)V
                        new global::net.sf.jni4net.core.MemberId("sort","([Ljava/lang/Object;)V", false, true), // #61 ([Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("sort","([Ljava/lang/Object;II)V", false, true), // #62 ([Lsystem/Object;II)V
                        new global::net.sf.jni4net.core.MemberId("sort","([Ljava/lang/Object;IILjava/util/Comparator;)V", false, true), // #63 ([Lsystem/Object;IILjava/util/Comparator;)V
                        new global::net.sf.jni4net.core.MemberId("sort","([Ljava/lang/Object;Ljava/util/Comparator;)V", false, true), // #64 ([Lsystem/Object;Ljava/util/Comparator;)V
                        new global::net.sf.jni4net.core.MemberId("sort","([S)V", false, true), // #65 ([S)V
                        new global::net.sf.jni4net.core.MemberId("sort","([SII)V", false, true), // #66 ([SII)V
                        new global::net.sf.jni4net.core.MemberId("toString","([B)Ljava/lang/String;", false, true), // #67 ([B)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","([C)Ljava/lang/String;", false, true), // #68 ([C)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","([D)Ljava/lang/String;", false, true), // #69 ([D)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","([F)Ljava/lang/String;", false, true), // #70 ([F)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","([I)Ljava/lang/String;", false, true), // #71 ([I)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","([J)Ljava/lang/String;", false, true), // #72 ([J)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","([Ljava/lang/Object;)Ljava/lang/String;", false, true), // #73 ([Lsystem/Object;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","([S)Ljava/lang/String;", false, true), // #74 ([S)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","([Z)Ljava/lang/String;", false, true), // #75 ([Z)Lsystem/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
