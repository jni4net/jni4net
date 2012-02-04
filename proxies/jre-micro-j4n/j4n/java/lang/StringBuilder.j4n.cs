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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.StringBuilder))]
    public sealed partial class StringBuilder : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Appendable, global::java.lang.CharSequence
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private StringBuilder(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.StringBuilder(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static StringBuilder()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.StringBuilder));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public StringBuilder()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.StringBuilder.j4n_Class, java.lang.StringBuilder.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 (I)V (I)V</signature>
        public StringBuilder(int par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.StringBuilder.j4n_Class, java.lang.StringBuilder.j4n_Members[1], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#2 (Ljava/lang/CharSequence;)V (Ljava/lang/CharSequence;)V</signature>
        public StringBuilder(global::java.lang.CharSequence par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.StringBuilder.j4n_Class, java.lang.StringBuilder.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"));
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public StringBuilder(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.StringBuilder.j4n_Class, java.lang.StringBuilder.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#4 ([C)Ljava/lang/AbstractStringBuilder; ([C)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[4], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#5 ([CII)Ljava/lang/AbstractStringBuilder; ([CII)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(char[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[5], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#6 (C)Ljava/lang/AbstractStringBuilder; (C)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[6], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#7 (C)Ljava/lang/Appendable; (C)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append_3(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[7], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#8 (D)Ljava/lang/AbstractStringBuilder; (D)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[8], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0)));
            }
        }
        
        /// <signature>#9 (F)Ljava/lang/AbstractStringBuilder; (F)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[9], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0)));
            }
        }
        
        /// <signature>#10 (I)Ljava/lang/AbstractStringBuilder; (I)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[10], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#11 (J)Ljava/lang/AbstractStringBuilder; (J)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[11], global::net.sf.jni4net.core.ConvertLong.ToValue(par0)));
            }
        }
        
        /// <signature>#12 (Ljava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder; (Ljava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#13 (Ljava/lang/CharSequence;)Ljava/lang/Appendable; (Ljava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append_8(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[13], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#14 (Ljava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder; (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[14], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#15 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable; (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append_3(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[15], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#16 (Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder; (Lsystem/Object;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[16], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#17 (Ljava/lang/String;)Ljava/lang/AbstractStringBuilder; (Lsystem/String;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[17], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#18 (Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder; (Ljava/lang/StringBuffer;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(global::java.lang.StringBuffer par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[18], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#19 (Z)Ljava/lang/AbstractStringBuilder; (Z)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[19], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0)));
            }
        }
        
        /// <signature>#20 (I)Ljava/lang/AbstractStringBuilder; (I)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable appendCodePoint(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[20], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#21 ()I ()I</signature>
        public int capacity()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[21]);
            }
        }
        
        /// <signature>#22 (I)C (I)C</signature>
        public char charAt(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallCharMethod(this, java.lang.StringBuilder.j4n_Members[22], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#23 (I)I (I)I</signature>
        public int codePointAt(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[23], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#24 (I)I (I)I</signature>
        public int codePointBefore(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[24], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#25 (II)I (II)I</signature>
        public int codePointCount(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[25], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#26 (II)Ljava/lang/AbstractStringBuilder; (II)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable delete(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[26], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#27 (I)Ljava/lang/AbstractStringBuilder; (I)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable deleteCharAt(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[27], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#28 (I)V (I)V</signature>
        public void ensureCapacity(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.StringBuilder.j4n_Members[28], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#29 (II[CI)V (II[CI)V</signature>
        public void getChars(int par0, int par1, char[] par2, int par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_env.CallVoidMethod(this, java.lang.StringBuilder.j4n_Members[29], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3));
            }
        }
        
        /// <signature>#30 (Ljava/lang/String;)I (Lsystem/String;)I</signature>
        public int indexOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[30], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#31 (Ljava/lang/String;I)I (Lsystem/String;I)I</signature>
        public int indexOf(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[31], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#32 (I[C)Ljava/lang/AbstractStringBuilder; (I[C)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, char[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[32], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#33 (I[CII)Ljava/lang/AbstractStringBuilder; (I[CII)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, char[] par1, int par2, int par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[33], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3)));
            }
        }
        
        /// <signature>#34 (IC)Ljava/lang/AbstractStringBuilder; (IC)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, char par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[34], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1)));
            }
        }
        
        /// <signature>#35 (ID)Ljava/lang/AbstractStringBuilder; (ID)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, double par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[35], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertDouble.ToValue(par1)));
            }
        }
        
        /// <signature>#36 (IF)Ljava/lang/AbstractStringBuilder; (IF)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, float par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[36], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertFloat.ToValue(par1)));
            }
        }
        
        /// <signature>#37 (II)Ljava/lang/AbstractStringBuilder; (II)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[37], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#38 (IJ)Ljava/lang/AbstractStringBuilder; (IJ)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, long par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[38], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertLong.ToValue(par1)));
            }
        }
        
        /// <signature>#39 (ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder; (ILjava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, global::java.lang.CharSequence par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[39], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#40 (ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder; (ILjava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, global::java.lang.CharSequence par1, int par2, int par3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[40], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3)));
            }
        }
        
        /// <signature>#41 (ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder; (ILsystem/Object;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[41], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
            }
        }
        
        /// <signature>#42 (ILjava/lang/String;)Ljava/lang/AbstractStringBuilder; (ILsystem/String;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[42], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#43 (IZ)Ljava/lang/AbstractStringBuilder; (IZ)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable insert(int par0, bool par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[43], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1)));
            }
        }
        
        /// <signature>#44 (Ljava/lang/String;)I (Lsystem/String;)I</signature>
        public int lastIndexOf(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[44], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#45 (Ljava/lang/String;I)I (Lsystem/String;I)I</signature>
        public int lastIndexOf(string par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[45], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#46 ()I ()I</signature>
        public int length()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[46]);
            }
        }
        
        /// <signature>#47 (II)I (II)I</signature>
        public int offsetByCodePoints(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallIntMethod(this, java.lang.StringBuilder.j4n_Members[47], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#48 (IILjava/lang/String;)Ljava/lang/AbstractStringBuilder; (IILsystem/String;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable replace(int par0, int par1, string par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[48], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2)));
            }
        }
        
        /// <signature>#49 ()Ljava/lang/AbstractStringBuilder; ()Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable reverse()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[49]));
            }
        }
        
        /// <signature>#50 (IC)V (IC)V</signature>
        public void setCharAt(int par0, char par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.StringBuilder.j4n_Members[50], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1));
            }
        }
        
        /// <signature>#51 (I)V (I)V</signature>
        public void setLength(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.StringBuilder.j4n_Members[51], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#52 (II)Ljava/lang/CharSequence; (II)Ljava/lang/CharSequence;</signature>
        public global::java.lang.CharSequence subSequence(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.CharSequence>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.StringBuilder.j4n_Members[52], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#53 (I)Ljava/lang/String; (I)Lsystem/String;</signature>
        public string substring(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStringMethod(this, java.lang.StringBuilder.j4n_Members[53], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#54 (II)Ljava/lang/String; (II)Lsystem/String;</signature>
        public string substring(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStringMethod(this, java.lang.StringBuilder.j4n_Members[54], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#55 ()V ()V</signature>
        public void trimToSize()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.StringBuilder.j4n_Members[55]);
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.StringBuilder))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.StringBuilder";
                    proxyInfo.JVMStaticApiName = "java_.lang.StringBuilder_";
                    proxyInfo.CLRApi = typeof(java.lang.StringBuilder);
                    proxyInfo.CLRStaticApi = typeof(java.lang.StringBuilder);
                    proxyInfo.CLRProxy = typeof(java.lang.StringBuilder);
                    proxyInfo.JVMProxyFactory = java.lang.StringBuilder.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","(I)V", false, false), // #1 (I)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/CharSequence;)V", false, false), // #2 (Ljava/lang/CharSequence;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #3 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("append","([C)Ljava/lang/AbstractStringBuilder;", false, false), // #4 ([C)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","([CII)Ljava/lang/AbstractStringBuilder;", false, false), // #5 ([CII)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(C)Ljava/lang/AbstractStringBuilder;", false, false), // #6 (C)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(C)Ljava/lang/Appendable;", false, false), // #7 (C)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(D)Ljava/lang/AbstractStringBuilder;", false, false), // #8 (D)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(F)Ljava/lang/AbstractStringBuilder;", false, false), // #9 (F)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(I)Ljava/lang/AbstractStringBuilder;", false, false), // #10 (I)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(J)Ljava/lang/AbstractStringBuilder;", false, false), // #11 (J)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;", false, false), // #12 (Ljava/lang/CharSequence;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", false, false), // #13 (Ljava/lang/CharSequence;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;", false, false), // #14 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", false, false), // #15 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;", false, false), // #16 (Lsystem/Object;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;", false, false), // #17 (Lsystem/String;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;", false, false), // #18 (Ljava/lang/StringBuffer;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Z)Ljava/lang/AbstractStringBuilder;", false, false), // #19 (Z)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("appendCodePoint","(I)Ljava/lang/AbstractStringBuilder;", false, false), // #20 (I)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("capacity","()I", false, false), // #21 ()I
                        new global::net.sf.jni4net.core.MemberId("charAt","(I)C", false, false), // #22 (I)C
                        new global::net.sf.jni4net.core.MemberId("codePointAt","(I)I", false, false), // #23 (I)I
                        new global::net.sf.jni4net.core.MemberId("codePointBefore","(I)I", false, false), // #24 (I)I
                        new global::net.sf.jni4net.core.MemberId("codePointCount","(II)I", false, false), // #25 (II)I
                        new global::net.sf.jni4net.core.MemberId("delete","(II)Ljava/lang/AbstractStringBuilder;", false, false), // #26 (II)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("deleteCharAt","(I)Ljava/lang/AbstractStringBuilder;", false, false), // #27 (I)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("ensureCapacity","(I)V", false, false), // #28 (I)V
                        new global::net.sf.jni4net.core.MemberId("getChars","(II[CI)V", false, false), // #29 (II[CI)V
                        new global::net.sf.jni4net.core.MemberId("indexOf","(Ljava/lang/String;)I", false, false), // #30 (Lsystem/String;)I
                        new global::net.sf.jni4net.core.MemberId("indexOf","(Ljava/lang/String;I)I", false, false), // #31 (Lsystem/String;I)I
                        new global::net.sf.jni4net.core.MemberId("insert","(I[C)Ljava/lang/AbstractStringBuilder;", false, false), // #32 (I[C)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(I[CII)Ljava/lang/AbstractStringBuilder;", false, false), // #33 (I[CII)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(IC)Ljava/lang/AbstractStringBuilder;", false, false), // #34 (IC)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(ID)Ljava/lang/AbstractStringBuilder;", false, false), // #35 (ID)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(IF)Ljava/lang/AbstractStringBuilder;", false, false), // #36 (IF)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(II)Ljava/lang/AbstractStringBuilder;", false, false), // #37 (II)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(IJ)Ljava/lang/AbstractStringBuilder;", false, false), // #38 (IJ)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;", false, false), // #39 (ILjava/lang/CharSequence;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;", false, false), // #40 (ILjava/lang/CharSequence;II)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;", false, false), // #41 (ILsystem/Object;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;", false, false), // #42 (ILsystem/String;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("insert","(IZ)Ljava/lang/AbstractStringBuilder;", false, false), // #43 (IZ)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("lastIndexOf","(Ljava/lang/String;)I", false, false), // #44 (Lsystem/String;)I
                        new global::net.sf.jni4net.core.MemberId("lastIndexOf","(Ljava/lang/String;I)I", false, false), // #45 (Lsystem/String;I)I
                        new global::net.sf.jni4net.core.MemberId("length","()I", false, false), // #46 ()I
                        new global::net.sf.jni4net.core.MemberId("offsetByCodePoints","(II)I", false, false), // #47 (II)I
                        new global::net.sf.jni4net.core.MemberId("replace","(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;", false, false), // #48 (IILsystem/String;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("reverse","()Ljava/lang/AbstractStringBuilder;", false, false), // #49 ()Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("setCharAt","(IC)V", false, false), // #50 (IC)V
                        new global::net.sf.jni4net.core.MemberId("setLength","(I)V", false, false), // #51 (I)V
                        new global::net.sf.jni4net.core.MemberId("subSequence","(II)Ljava/lang/CharSequence;", false, false), // #52 (II)Ljava/lang/CharSequence;
                        new global::net.sf.jni4net.core.MemberId("substring","(I)Ljava/lang/String;", false, false), // #53 (I)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("substring","(II)Ljava/lang/String;", false, false), // #54 (II)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("trimToSize","()V", false, false), // #55 ()V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
