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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.String))]
    public sealed partial class String : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Comparable, global::java.lang.CharSequence
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private String(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.String(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static String()
        {
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.CharSequence_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.CharSequence_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.String));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public String()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ([B)V ([B)V</signature>
        public String(byte[] par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[1], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 ([BI)V ([BI)V</signature>
        public String(byte[] par0, int par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[2], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#3 ([BII)V ([BII)V</signature>
        public String(byte[] par0, int par1, int par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[3], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#4 ([BIII)V ([BIII)V</signature>
        public String(byte[] par0, int par1, int par2, int par3)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[4], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3));
            }
        }
        
        /// <signature>#5 ([BIILjava/lang/String;)V ([BIILjava/lang/String;)V</signature>
        public String(byte[] par0, int par1, int par2, global::java.lang.String par3)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[5], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par3));
            }
        }
        
        /// <signature>#6 ([BLjava/lang/String;)V ([BLjava/lang/String;)V</signature>
        public String(byte[] par0, global::java.lang.String par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[6], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#7 ([C)V ([C)V</signature>
        public String(char[] par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[7], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#8 ([CII)V ([CII)V</signature>
        public String(char[] par0, int par1, int par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[8], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#9 ([III)V ([III)V</signature>
        public String(int[] par0, int par1, int par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[9], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#10 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
        public String(global::java.lang.String par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[10], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#11 (Ljava/lang/StringBuffer;)V (Ljava/lang/StringBuffer;)V</signature>
        public String(global::java.lang.StringBuffer par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[11], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#12 (Ljava/lang/StringBuilder;)V (Ljava/lang/StringBuilder;)V</signature>
        public String(global::java.lang.StringBuilder par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.String.j4n_Class, java.lang.String.j4n_Members[12], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        static public global::java.util.Comparator CASE_INSENSITIVE_ORDER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Comparator>(j4n_env, j4n_env.GetStaticObjectField(java.lang.String.j4n_Class, java.lang.String.j4n_Members[13]));
                }
            }
        }
        
        /// <signature>#14 ([C)Ljava/lang/String; ([C)Ljava/lang/String;</signature>
        static public global::java.lang.String copyValueOf(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[14], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#15 ([CII)Ljava/lang/String; ([CII)Ljava/lang/String;</signature>
        static public global::java.lang.String copyValueOf(char[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[15], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#16 (Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/String;[Lsystem/Object;)Ljava/lang/String;</signature>
        static public global::java.lang.String format(global::java.lang.String par0, object[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[16], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
            }
        }
        
        /// <signature>#17 (Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/Cloneable;Ljava/lang/String;[Lsystem/Object;)Ljava/lang/String;</signature>
        static public global::java.lang.String format(global::java.lang.Cloneable par0, global::java.lang.String par1, object[] par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[17], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Locale"), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.lang.Object")));
            }
        }
        
        /// <signature>#18 ([C)Ljava/lang/String; ([C)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[18], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#19 ([CII)Ljava/lang/String; ([CII)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(char[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[19], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#20 (C)Ljava/lang/String; (C)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[20], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#21 (D)Ljava/lang/String; (D)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[21], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0)));
            }
        }
        
        /// <signature>#22 (F)Ljava/lang/String; (F)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[22], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0)));
            }
        }
        
        /// <signature>#23 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[23], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#24 (J)Ljava/lang/String; (J)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[24], global::net.sf.jni4net.core.ConvertLong.ToValue(par0)));
            }
        }
        
        /// <signature>#25 (Ljava/lang/Object;)Ljava/lang/String; (Lsystem/Object;)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[25], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#26 (Z)Ljava/lang/String; (Z)Ljava/lang/String;</signature>
        static public global::java.lang.String valueOf(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.String.j4n_Class, java.lang.String.j4n_Members[26], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0)));
            }
        }
        
        /// <signature>#27 (I)C (I)C</signature>
        public char charAt(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallCharMethod(this, java.lang.String.j4n_Members[27], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#28 (I)I (I)I</signature>
        public int codePointAt(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[28], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#29 (I)I (I)I</signature>
        public int codePointBefore(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[29], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#30 (II)I (II)I</signature>
        public int codePointCount(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[30], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#31 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[31], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#32 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
        public int compareTo(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[32], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#33 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
        public int compareToIgnoreCase(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[33], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#34 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
        public global::java.lang.String concat(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[34], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#35 (Ljava/lang/CharSequence;)Z (Ljava/lang/CharSequence;)Z</signature>
        public bool contains(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[35], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"));
            }
        }
        
        /// <signature>#36 (Ljava/lang/CharSequence;)Z (Ljava/lang/CharSequence;)Z</signature>
        public bool contentEquals(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[36], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"));
            }
        }
        
        /// <signature>#37 (Ljava/lang/StringBuffer;)Z (Ljava/lang/StringBuffer;)Z</signature>
        public bool contentEquals(global::java.lang.StringBuffer par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[37], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#38 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
        public bool endsWith(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[38], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#39 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
        public bool equalsIgnoreCase(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[39], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#40 ()[B ()[B</signature>
        public byte[] getBytes()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertByte.ToCLRArray1(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[40]));
            }
        }
        
        /// <signature>#41 (II[BI)V (II[BI)V</signature>
        public void getBytes(int par0, int par1, byte[] par2, int par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallVoidMethod(this, java.lang.String.j4n_Members[41], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3));
            }
        }
        
        /// <signature>#42 (Ljava/lang/String;)[B (Ljava/lang/String;)[B</signature>
        public byte[] getBytes(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertByte.ToCLRArray1(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[42], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#43 (II[CI)V (II[CI)V</signature>
        public void getChars(int par0, int par1, char[] par2, int par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallVoidMethod(this, java.lang.String.j4n_Members[43], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3));
            }
        }
        
        /// <signature>#44 (I)I (I)I</signature>
        public int indexOf(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[44], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#45 (II)I (II)I</signature>
        public int indexOf(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[45], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#46 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
        public int indexOf(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[46], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#47 (Ljava/lang/String;I)I (Ljava/lang/String;I)I</signature>
        public int indexOf(global::java.lang.String par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[47], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#48 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
        public global::java.lang.String intern()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[48]));
            }
        }
        
        /// <signature>#49 (I)I (I)I</signature>
        public int lastIndexOf(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[49], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#50 (II)I (II)I</signature>
        public int lastIndexOf(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[50], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#51 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
        public int lastIndexOf(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[51], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#52 (Ljava/lang/String;I)I (Ljava/lang/String;I)I</signature>
        public int lastIndexOf(global::java.lang.String par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[52], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#53 ()I ()I</signature>
        public int length()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[53]);
            }
        }
        
        /// <signature>#54 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
        public bool matches(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[54], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#55 (II)I (II)I</signature>
        public int offsetByCodePoints(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.String.j4n_Members[55], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#56 (ILjava/lang/String;II)Z (ILjava/lang/String;II)Z</signature>
        public bool regionMatches(int par0, global::java.lang.String par1, int par2, int par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[56], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3));
            }
        }
        
        /// <signature>#57 (ZILjava/lang/String;II)Z (ZILjava/lang/String;II)Z</signature>
        public bool regionMatches(bool par0, int par1, global::java.lang.String par2, int par3, int par4)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[57], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3), global::net.sf.jni4net.core.ConvertInt.ToValue(par4));
            }
        }
        
        /// <signature>#58 (CC)Ljava/lang/String; (CC)Ljava/lang/String;</signature>
        public global::java.lang.String replace(char par0, char par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[58], global::net.sf.jni4net.core.ConvertChar.ToValue(par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1)));
            }
        }
        
        /// <signature>#59 (Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String; (Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;</signature>
        public global::java.lang.String replace(global::java.lang.CharSequence par0, global::java.lang.CharSequence par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[59], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#60 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;</signature>
        public global::java.lang.String replaceAll(global::java.lang.String par0, global::java.lang.String par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[60], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#61 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;</signature>
        public global::java.lang.String replaceFirst(global::java.lang.String par0, global::java.lang.String par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[61], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#62 (Ljava/lang/String;)[Ljava/lang/String; (Ljava/lang/String;)[Ljava/lang/String;</signature>
        public global::java.lang.String[] split(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[62], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#63 (Ljava/lang/String;I)[Ljava/lang/String; (Ljava/lang/String;I)[Ljava/lang/String;</signature>
        public global::java.lang.String[] split(global::java.lang.String par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[63], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#64 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
        public bool startsWith(global::java.lang.String par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[64], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#65 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
        public bool startsWith(global::java.lang.String par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.String.j4n_Members[65], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#66 (II)Ljava/lang/CharSequence; (II)Ljava/lang/CharSequence;</signature>
        public global::java.lang.CharSequence subSequence(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.CharSequence>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[66], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#67 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
        public global::java.lang.String substring(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[67], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#68 (II)Ljava/lang/String; (II)Ljava/lang/String;</signature>
        public global::java.lang.String substring(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[68], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#69 ()[C ()[C</signature>
        public char[] toCharArray()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertChar.ToCLRArray1(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[69]));
            }
        }
        
        /// <signature>#70 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
        public global::java.lang.String toLowerCase()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[70]));
            }
        }
        
        /// <signature>#71 (Ljava/util/Locale;)Ljava/lang/String; (Ljava/lang/Cloneable;)Ljava/lang/String;</signature>
        public global::java.lang.String toLowerCase(global::java.lang.Cloneable par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[71], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Locale")));
            }
        }
        
        /// <signature>#72 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
        public global::java.lang.String toUpperCase()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[72]));
            }
        }
        
        /// <signature>#73 (Ljava/util/Locale;)Ljava/lang/String; (Ljava/lang/Cloneable;)Ljava/lang/String;</signature>
        public global::java.lang.String toUpperCase(global::java.lang.Cloneable par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[73], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Locale")));
            }
        }
        
        /// <signature>#74 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
        public global::java.lang.String trim()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.String>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.String.j4n_Members[74]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.String))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.String";
                    proxyInfo.JVMStaticApiName = "java_.lang.String_";
                    proxyInfo.CLRApi = typeof(java.lang.String);
                    proxyInfo.CLRStaticApi = typeof(java.lang.String);
                    proxyInfo.CLRProxy = typeof(java.lang.String);
                    proxyInfo.JVMProxyFactory = java.lang.String.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","([B)V", false, false), // #1 ([B)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([BI)V", false, false), // #2 ([BI)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([BII)V", false, false), // #3 ([BII)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([BIII)V", false, false), // #4 ([BIII)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([BIILjava/lang/String;)V", false, false), // #5 ([BIILjava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([BLjava/lang/String;)V", false, false), // #6 ([BLjava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([C)V", false, false), // #7 ([C)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([CII)V", false, false), // #8 ([CII)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([III)V", false, false), // #9 ([III)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #10 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/StringBuffer;)V", false, false), // #11 (Ljava/lang/StringBuffer;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/StringBuilder;)V", false, false), // #12 (Ljava/lang/StringBuilder;)V
                        new global::net.sf.jni4net.core.MemberId("CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;", true, true), // #13 ()Ljava/util/Comparator;
                        new global::net.sf.jni4net.core.MemberId("copyValueOf","([C)Ljava/lang/String;", false, true), // #14 ([C)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("copyValueOf","([CII)Ljava/lang/String;", false, true), // #15 ([CII)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", false, true), // #16 (Ljava/lang/String;[Lsystem/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("format","(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", false, true), // #17 (Ljava/lang/Cloneable;Ljava/lang/String;[Lsystem/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","([C)Ljava/lang/String;", false, true), // #18 ([C)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","([CII)Ljava/lang/String;", false, true), // #19 ([CII)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(C)Ljava/lang/String;", false, true), // #20 (C)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(D)Ljava/lang/String;", false, true), // #21 (D)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(F)Ljava/lang/String;", false, true), // #22 (F)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(I)Ljava/lang/String;", false, true), // #23 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(J)Ljava/lang/String;", false, true), // #24 (J)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Ljava/lang/Object;)Ljava/lang/String;", false, true), // #25 (Lsystem/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("valueOf","(Z)Ljava/lang/String;", false, true), // #26 (Z)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("charAt","(I)C", false, false), // #27 (I)C
                        new global::net.sf.jni4net.core.MemberId("codePointAt","(I)I", false, false), // #28 (I)I
                        new global::net.sf.jni4net.core.MemberId("codePointBefore","(I)I", false, false), // #29 (I)I
                        new global::net.sf.jni4net.core.MemberId("codePointCount","(II)I", false, false), // #30 (II)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #31 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/String;)I", false, false), // #32 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("compareToIgnoreCase","(Ljava/lang/String;)I", false, false), // #33 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("concat","(Ljava/lang/String;)Ljava/lang/String;", false, false), // #34 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("contains","(Ljava/lang/CharSequence;)Z", false, false), // #35 (Ljava/lang/CharSequence;)Z
                        new global::net.sf.jni4net.core.MemberId("contentEquals","(Ljava/lang/CharSequence;)Z", false, false), // #36 (Ljava/lang/CharSequence;)Z
                        new global::net.sf.jni4net.core.MemberId("contentEquals","(Ljava/lang/StringBuffer;)Z", false, false), // #37 (Ljava/lang/StringBuffer;)Z
                        new global::net.sf.jni4net.core.MemberId("endsWith","(Ljava/lang/String;)Z", false, false), // #38 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("equalsIgnoreCase","(Ljava/lang/String;)Z", false, false), // #39 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("getBytes","()[B", false, false), // #40 ()[B
                        new global::net.sf.jni4net.core.MemberId("getBytes","(II[BI)V", false, false), // #41 (II[BI)V
                        new global::net.sf.jni4net.core.MemberId("getBytes","(Ljava/lang/String;)[B", false, false), // #42 (Ljava/lang/String;)[B
                        new global::net.sf.jni4net.core.MemberId("getChars","(II[CI)V", false, false), // #43 (II[CI)V
                        new global::net.sf.jni4net.core.MemberId("indexOf","(I)I", false, false), // #44 (I)I
                        new global::net.sf.jni4net.core.MemberId("indexOf","(II)I", false, false), // #45 (II)I
                        new global::net.sf.jni4net.core.MemberId("indexOf","(Ljava/lang/String;)I", false, false), // #46 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("indexOf","(Ljava/lang/String;I)I", false, false), // #47 (Ljava/lang/String;I)I
                        new global::net.sf.jni4net.core.MemberId("intern","()Ljava/lang/String;", false, false), // #48 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("lastIndexOf","(I)I", false, false), // #49 (I)I
                        new global::net.sf.jni4net.core.MemberId("lastIndexOf","(II)I", false, false), // #50 (II)I
                        new global::net.sf.jni4net.core.MemberId("lastIndexOf","(Ljava/lang/String;)I", false, false), // #51 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("lastIndexOf","(Ljava/lang/String;I)I", false, false), // #52 (Ljava/lang/String;I)I
                        new global::net.sf.jni4net.core.MemberId("length","()I", false, false), // #53 ()I
                        new global::net.sf.jni4net.core.MemberId("matches","(Ljava/lang/String;)Z", false, false), // #54 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("offsetByCodePoints","(II)I", false, false), // #55 (II)I
                        new global::net.sf.jni4net.core.MemberId("regionMatches","(ILjava/lang/String;II)Z", false, false), // #56 (ILjava/lang/String;II)Z
                        new global::net.sf.jni4net.core.MemberId("regionMatches","(ZILjava/lang/String;II)Z", false, false), // #57 (ZILjava/lang/String;II)Z
                        new global::net.sf.jni4net.core.MemberId("replace","(CC)Ljava/lang/String;", false, false), // #58 (CC)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;", false, false), // #59 (Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, false), // #60 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, false), // #61 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("split","(Ljava/lang/String;)[Ljava/lang/String;", false, false), // #62 (Ljava/lang/String;)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("split","(Ljava/lang/String;I)[Ljava/lang/String;", false, false), // #63 (Ljava/lang/String;I)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("startsWith","(Ljava/lang/String;)Z", false, false), // #64 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("startsWith","(Ljava/lang/String;I)Z", false, false), // #65 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("subSequence","(II)Ljava/lang/CharSequence;", false, false), // #66 (II)Ljava/lang/CharSequence;
                        new global::net.sf.jni4net.core.MemberId("substring","(I)Ljava/lang/String;", false, false), // #67 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("substring","(II)Ljava/lang/String;", false, false), // #68 (II)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("toCharArray","()[C", false, false), // #69 ()[C
                        new global::net.sf.jni4net.core.MemberId("toLowerCase","()Ljava/lang/String;", false, false), // #70 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;", false, false), // #71 (Ljava/lang/Cloneable;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("toUpperCase","()Ljava/lang/String;", false, false), // #72 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("toUpperCase","(Ljava/util/Locale;)Ljava/lang/String;", false, false), // #73 (Ljava/lang/Cloneable;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("trim","()Ljava/lang/String;", false, false), // #74 ()Ljava/lang/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
