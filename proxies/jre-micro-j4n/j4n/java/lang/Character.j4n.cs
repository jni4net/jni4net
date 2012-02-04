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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Character))]
    public sealed partial class Character : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Character(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Character(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Character()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Character));
        }
        
        /// <signature>#0 (C)V (C)V</signature>
        public Character(char par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[0], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#1 (I)I (I)I</signature>
        static public int charCount(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[1], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#2 ([CI)I ([CI)I</signature>
        static public int codePointAt(char[] par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[2], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#3 ([CII)I ([CII)I</signature>
        static public int codePointAt(char[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[3], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#4 (Ljava/lang/CharSequence;I)I (Ljava/lang/CharSequence;I)I</signature>
        static public int codePointAt(global::java.lang.CharSequence par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[4], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#5 ([CI)I ([CI)I</signature>
        static public int codePointBefore(char[] par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[5], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#6 ([CII)I ([CII)I</signature>
        static public int codePointBefore(char[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[6], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#7 (Ljava/lang/CharSequence;I)I (Ljava/lang/CharSequence;I)I</signature>
        static public int codePointBefore(global::java.lang.CharSequence par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[7], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#8 ([CII)I ([CII)I</signature>
        static public int codePointCount(char[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[8], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#9 (Ljava/lang/CharSequence;II)I (Ljava/lang/CharSequence;II)I</signature>
        static public int codePointCount(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[9], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        static public byte COMBINING_SPACING_MARK {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[10]);
                }
            }
        }
        
        static public byte CONNECTOR_PUNCTUATION {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[11]);
                }
            }
        }
        
        static public byte CONTROL {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[12]);
                }
            }
        }
        
        static public byte CURRENCY_SYMBOL {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[13]);
                }
            }
        }
        
        static public byte DASH_PUNCTUATION {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[14]);
                }
            }
        }
        
        static public byte DECIMAL_DIGIT_NUMBER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[15]);
                }
            }
        }
        
        /// <signature>#16 (CI)I (CI)I</signature>
        static public int digit(char par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[16], global::net.sf.jni4net.core.ConvertChar.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#17 (II)I (II)I</signature>
        static public int digit(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[17], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        static public byte DIRECTIONALITY_ARABIC_NUMBER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[18]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_BOUNDARY_NEUTRAL {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[19]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_COMMON_NUMBER_SEPARATOR {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[20]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_EUROPEAN_NUMBER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[21]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[22]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[23]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_LEFT_TO_RIGHT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[24]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[25]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[26]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_NONSPACING_MARK {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[27]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_OTHER_NEUTRALS {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[28]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_PARAGRAPH_SEPARATOR {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[29]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_POP_DIRECTIONAL_FORMAT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[30]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_RIGHT_TO_LEFT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[31]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[32]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[33]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[34]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_SEGMENT_SEPARATOR {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[35]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_UNDEFINED {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[36]);
                }
            }
        }
        
        static public byte DIRECTIONALITY_WHITESPACE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[37]);
                }
            }
        }
        
        static public byte ENCLOSING_MARK {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[38]);
                }
            }
        }
        
        static public byte END_PUNCTUATION {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[39]);
                }
            }
        }
        
        static public byte FINAL_QUOTE_PUNCTUATION {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[40]);
                }
            }
        }
        
        /// <signature>#41 (II)C (II)C</signature>
        static public char forDigit(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticCharMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[41], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        static public byte FORMAT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[42]);
                }
            }
        }
        
        /// <signature>#43 (C)B (C)B</signature>
        static public byte getDirectionality(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticByteMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[43], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#44 (I)B (I)B</signature>
        static public byte getDirectionality(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticByteMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[44], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#45 (C)I (C)I</signature>
        static public int getNumericValue(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[45], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#46 (I)I (I)I</signature>
        static public int getNumericValue(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[46], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#47 (C)I (C)I</signature>
        static public int getType(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[47], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#48 (I)I (I)I</signature>
        static public int getType(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[48], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        static public byte INITIAL_QUOTE_PUNCTUATION {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[49]);
                }
            }
        }
        
        /// <signature>#50 (C)Z (C)Z</signature>
        static public bool isDefined(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[50], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#51 (I)Z (I)Z</signature>
        static public bool isDefined(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[51], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#52 (C)Z (C)Z</signature>
        static public bool isDigit(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[52], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#53 (I)Z (I)Z</signature>
        static public bool isDigit(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[53], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#54 (C)Z (C)Z</signature>
        static public bool isHighSurrogate(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[54], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#55 (C)Z (C)Z</signature>
        static public bool isIdentifierIgnorable(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[55], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#56 (I)Z (I)Z</signature>
        static public bool isIdentifierIgnorable(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[56], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#57 (C)Z (C)Z</signature>
        static public bool isISOControl(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[57], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#58 (I)Z (I)Z</signature>
        static public bool isISOControl(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[58], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#59 (C)Z (C)Z</signature>
        static public bool isJavaIdentifierPart(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[59], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#60 (I)Z (I)Z</signature>
        static public bool isJavaIdentifierPart(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[60], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#61 (C)Z (C)Z</signature>
        static public bool isJavaIdentifierStart(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[61], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#62 (I)Z (I)Z</signature>
        static public bool isJavaIdentifierStart(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[62], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#63 (C)Z (C)Z</signature>
        static public bool isJavaLetter(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[63], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#64 (C)Z (C)Z</signature>
        static public bool isJavaLetterOrDigit(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[64], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#65 (C)Z (C)Z</signature>
        static public bool isLetter(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[65], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#66 (I)Z (I)Z</signature>
        static public bool isLetter(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[66], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#67 (C)Z (C)Z</signature>
        static public bool isLetterOrDigit(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[67], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#68 (I)Z (I)Z</signature>
        static public bool isLetterOrDigit(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[68], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#69 (C)Z (C)Z</signature>
        static public bool isLowerCase(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[69], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#70 (I)Z (I)Z</signature>
        static public bool isLowerCase(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[70], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#71 (C)Z (C)Z</signature>
        static public bool isLowSurrogate(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[71], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#72 (C)Z (C)Z</signature>
        static public bool isMirrored(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[72], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#73 (I)Z (I)Z</signature>
        static public bool isMirrored(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[73], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#74 (C)Z (C)Z</signature>
        static public bool isSpace(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[74], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#75 (C)Z (C)Z</signature>
        static public bool isSpaceChar(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[75], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#76 (I)Z (I)Z</signature>
        static public bool isSpaceChar(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[76], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#77 (I)Z (I)Z</signature>
        static public bool isSupplementaryCodePoint(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[77], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#78 (CC)Z (CC)Z</signature>
        static public bool isSurrogatePair(char par0, char par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[78], global::net.sf.jni4net.core.ConvertChar.ToValue(par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1));
            }
        }
        
        /// <signature>#79 (C)Z (C)Z</signature>
        static public bool isTitleCase(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[79], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#80 (I)Z (I)Z</signature>
        static public bool isTitleCase(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[80], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#81 (C)Z (C)Z</signature>
        static public bool isUnicodeIdentifierPart(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[81], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#82 (I)Z (I)Z</signature>
        static public bool isUnicodeIdentifierPart(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[82], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#83 (C)Z (C)Z</signature>
        static public bool isUnicodeIdentifierStart(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[83], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#84 (I)Z (I)Z</signature>
        static public bool isUnicodeIdentifierStart(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[84], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#85 (C)Z (C)Z</signature>
        static public bool isUpperCase(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[85], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#86 (I)Z (I)Z</signature>
        static public bool isUpperCase(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[86], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#87 (I)Z (I)Z</signature>
        static public bool isValidCodePoint(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[87], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#88 (C)Z (C)Z</signature>
        static public bool isWhitespace(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[88], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#89 (I)Z (I)Z</signature>
        static public bool isWhitespace(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[89], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        static public byte LETTER_NUMBER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[90]);
                }
            }
        }
        
        static public byte LINE_SEPARATOR {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[91]);
                }
            }
        }
        
        static public byte LOWERCASE_LETTER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[92]);
                }
            }
        }
        
        static public byte MATH_SYMBOL {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[93]);
                }
            }
        }
        
        static public int MAX_CODE_POINT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[94]);
                }
            }
        }
        
        static public char MAX_HIGH_SURROGATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[95]);
                }
            }
        }
        
        static public char MAX_LOW_SURROGATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[96]);
                }
            }
        }
        
        static public int MAX_RADIX {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[97]);
                }
            }
        }
        
        static public char MAX_SURROGATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[98]);
                }
            }
        }
        
        static public char MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[99]);
                }
            }
        }
        
        static public int MIN_CODE_POINT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[100]);
                }
            }
        }
        
        static public char MIN_HIGH_SURROGATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[101]);
                }
            }
        }
        
        static public char MIN_LOW_SURROGATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[102]);
                }
            }
        }
        
        static public int MIN_RADIX {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[103]);
                }
            }
        }
        
        static public int MIN_SUPPLEMENTARY_CODE_POINT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[104]);
                }
            }
        }
        
        static public char MIN_SURROGATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[105]);
                }
            }
        }
        
        static public char MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[106]);
                }
            }
        }
        
        static public byte MODIFIER_LETTER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[107]);
                }
            }
        }
        
        static public byte MODIFIER_SYMBOL {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[108]);
                }
            }
        }
        
        static public byte NON_SPACING_MARK {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[109]);
                }
            }
        }
        
        /// <signature>#110 ([CIIII)I ([CIIII)I</signature>
        static public int offsetByCodePoints(char[] par0, int par1, int par2, int par3, int par4)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[110], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3), global::net.sf.jni4net.core.ConvertInt.ToValue(par4));
            }
        }
        
        /// <signature>#111 (Ljava/lang/CharSequence;II)I (Ljava/lang/CharSequence;II)I</signature>
        static public int offsetByCodePoints(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[111], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        static public byte OTHER_LETTER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[112]);
                }
            }
        }
        
        static public byte OTHER_NUMBER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[113]);
                }
            }
        }
        
        static public byte OTHER_PUNCTUATION {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[114]);
                }
            }
        }
        
        static public byte OTHER_SYMBOL {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[115]);
                }
            }
        }
        
        static public byte PARAGRAPH_SEPARATOR {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[116]);
                }
            }
        }
        
        static public byte PRIVATE_USE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[117]);
                }
            }
        }
        
        /// <signature>#118 (C)C (C)C</signature>
        static public char reverseBytes(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticCharMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[118], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        static public int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[119]);
                }
            }
        }
        
        static public byte SPACE_SEPARATOR {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[120]);
                }
            }
        }
        
        static public byte START_PUNCTUATION {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[121]);
                }
            }
        }
        
        static public byte SURROGATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[122]);
                }
            }
        }
        
        static public byte TITLECASE_LETTER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[123]);
                }
            }
        }
        
        /// <signature>#124 (I)[C (I)[C</signature>
        static public char[] toChars(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertChar.ToCLRArray1(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[124], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#125 (I[CI)I (I[CI)I</signature>
        static public int toChars(int par0, char[] par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[125], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#126 (CC)I (CC)I</signature>
        static public int toCodePoint(char par0, char par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[126], global::net.sf.jni4net.core.ConvertChar.ToValue(par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1));
            }
        }
        
        /// <signature>#127 (C)C (C)C</signature>
        static public char toLowerCase(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticCharMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[127], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#128 (I)I (I)I</signature>
        static public int toLowerCase(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[128], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#129 (C)Ljava/lang/String; (C)Lsystem/String;</signature>
        static public string toString(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[129], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#130 (C)C (C)C</signature>
        static public char toTitleCase(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticCharMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[130], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#131 (I)I (I)I</signature>
        static public int toTitleCase(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[131], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#132 (C)C (C)C</signature>
        static public char toUpperCase(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticCharMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[132], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#133 (I)I (I)I</signature>
        static public int toUpperCase(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[133], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        static public global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[134]));
                }
            }
        }
        
        static public byte UNASSIGNED {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[135]);
                }
            }
        }
        
        static public byte UPPERCASE_LETTER {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticByteField(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[136]);
                }
            }
        }
        
        /// <signature>#137 (C)Ljava/lang/Character; (C)Ljava/lang/Character;</signature>
        static public global::java.lang.Character valueOf(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Character.j4n_Class, java.lang.Character.j4n_Members[137], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#138 ()C ()C</signature>
        public char charValue()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallCharMethod(this, java.lang.Character.j4n_Members[138]);
            }
        }
        
        /// <signature>#139 (Ljava/lang/Character;)I (Ljava/lang/Character;)I</signature>
        public int compareTo(global::java.lang.Character par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Character.j4n_Members[139], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#140 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.Character.j4n_Members[140], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Character))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Character";
                    proxyInfo.JVMStaticApiName = "java_.lang.Character_";
                    proxyInfo.CLRApi = typeof(java.lang.Character);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Character);
                    proxyInfo.CLRProxy = typeof(java.lang.Character);
                    proxyInfo.JVMProxyFactory = java.lang.Character.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(C)V", false, false), // #0 (C)V
                        new global::net.sf.jni4net.core.MemberId("charCount","(I)I", false, true), // #1 (I)I
                        new global::net.sf.jni4net.core.MemberId("codePointAt","([CI)I", false, true), // #2 ([CI)I
                        new global::net.sf.jni4net.core.MemberId("codePointAt","([CII)I", false, true), // #3 ([CII)I
                        new global::net.sf.jni4net.core.MemberId("codePointAt","(Ljava/lang/CharSequence;I)I", false, true), // #4 (Ljava/lang/CharSequence;I)I
                        new global::net.sf.jni4net.core.MemberId("codePointBefore","([CI)I", false, true), // #5 ([CI)I
                        new global::net.sf.jni4net.core.MemberId("codePointBefore","([CII)I", false, true), // #6 ([CII)I
                        new global::net.sf.jni4net.core.MemberId("codePointBefore","(Ljava/lang/CharSequence;I)I", false, true), // #7 (Ljava/lang/CharSequence;I)I
                        new global::net.sf.jni4net.core.MemberId("codePointCount","([CII)I", false, true), // #8 ([CII)I
                        new global::net.sf.jni4net.core.MemberId("codePointCount","(Ljava/lang/CharSequence;II)I", false, true), // #9 (Ljava/lang/CharSequence;II)I
                        new global::net.sf.jni4net.core.MemberId("COMBINING_SPACING_MARK","B", true, true), // #10 ()B
                        new global::net.sf.jni4net.core.MemberId("CONNECTOR_PUNCTUATION","B", true, true), // #11 ()B
                        new global::net.sf.jni4net.core.MemberId("CONTROL","B", true, true), // #12 ()B
                        new global::net.sf.jni4net.core.MemberId("CURRENCY_SYMBOL","B", true, true), // #13 ()B
                        new global::net.sf.jni4net.core.MemberId("DASH_PUNCTUATION","B", true, true), // #14 ()B
                        new global::net.sf.jni4net.core.MemberId("DECIMAL_DIGIT_NUMBER","B", true, true), // #15 ()B
                        new global::net.sf.jni4net.core.MemberId("digit","(CI)I", false, true), // #16 (CI)I
                        new global::net.sf.jni4net.core.MemberId("digit","(II)I", false, true), // #17 (II)I
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_ARABIC_NUMBER","B", true, true), // #18 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_BOUNDARY_NEUTRAL","B", true, true), // #19 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_COMMON_NUMBER_SEPARATOR","B", true, true), // #20 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_EUROPEAN_NUMBER","B", true, true), // #21 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR","B", true, true), // #22 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR","B", true, true), // #23 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_LEFT_TO_RIGHT","B", true, true), // #24 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING","B", true, true), // #25 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE","B", true, true), // #26 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_NONSPACING_MARK","B", true, true), // #27 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_OTHER_NEUTRALS","B", true, true), // #28 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_PARAGRAPH_SEPARATOR","B", true, true), // #29 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_POP_DIRECTIONAL_FORMAT","B", true, true), // #30 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_RIGHT_TO_LEFT","B", true, true), // #31 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC","B", true, true), // #32 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING","B", true, true), // #33 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE","B", true, true), // #34 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_SEGMENT_SEPARATOR","B", true, true), // #35 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_UNDEFINED","B", true, true), // #36 ()B
                        new global::net.sf.jni4net.core.MemberId("DIRECTIONALITY_WHITESPACE","B", true, true), // #37 ()B
                        new global::net.sf.jni4net.core.MemberId("ENCLOSING_MARK","B", true, true), // #38 ()B
                        new global::net.sf.jni4net.core.MemberId("END_PUNCTUATION","B", true, true), // #39 ()B
                        new global::net.sf.jni4net.core.MemberId("FINAL_QUOTE_PUNCTUATION","B", true, true), // #40 ()B
                        new global::net.sf.jni4net.core.MemberId("forDigit","(II)C", false, true), // #41 (II)C
                        new global::net.sf.jni4net.core.MemberId("FORMAT","B", true, true), // #42 ()B
                        new global::net.sf.jni4net.core.MemberId("getDirectionality","(C)B", false, true), // #43 (C)B
                        new global::net.sf.jni4net.core.MemberId("getDirectionality","(I)B", false, true), // #44 (I)B
                        new global::net.sf.jni4net.core.MemberId("getNumericValue","(C)I", false, true), // #45 (C)I
                        new global::net.sf.jni4net.core.MemberId("getNumericValue","(I)I", false, true), // #46 (I)I
                        new global::net.sf.jni4net.core.MemberId("getType","(C)I", false, true), // #47 (C)I
                        new global::net.sf.jni4net.core.MemberId("getType","(I)I", false, true), // #48 (I)I
                        new global::net.sf.jni4net.core.MemberId("INITIAL_QUOTE_PUNCTUATION","B", true, true), // #49 ()B
                        new global::net.sf.jni4net.core.MemberId("isDefined","(C)Z", false, true), // #50 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isDefined","(I)Z", false, true), // #51 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isDigit","(C)Z", false, true), // #52 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isDigit","(I)Z", false, true), // #53 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isHighSurrogate","(C)Z", false, true), // #54 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isIdentifierIgnorable","(C)Z", false, true), // #55 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isIdentifierIgnorable","(I)Z", false, true), // #56 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isISOControl","(C)Z", false, true), // #57 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isISOControl","(I)Z", false, true), // #58 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isJavaIdentifierPart","(C)Z", false, true), // #59 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isJavaIdentifierPart","(I)Z", false, true), // #60 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isJavaIdentifierStart","(C)Z", false, true), // #61 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isJavaIdentifierStart","(I)Z", false, true), // #62 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isJavaLetter","(C)Z", false, true), // #63 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isJavaLetterOrDigit","(C)Z", false, true), // #64 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isLetter","(C)Z", false, true), // #65 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isLetter","(I)Z", false, true), // #66 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isLetterOrDigit","(C)Z", false, true), // #67 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isLetterOrDigit","(I)Z", false, true), // #68 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isLowerCase","(C)Z", false, true), // #69 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isLowerCase","(I)Z", false, true), // #70 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isLowSurrogate","(C)Z", false, true), // #71 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isMirrored","(C)Z", false, true), // #72 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isMirrored","(I)Z", false, true), // #73 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isSpace","(C)Z", false, true), // #74 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isSpaceChar","(C)Z", false, true), // #75 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isSpaceChar","(I)Z", false, true), // #76 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isSupplementaryCodePoint","(I)Z", false, true), // #77 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isSurrogatePair","(CC)Z", false, true), // #78 (CC)Z
                        new global::net.sf.jni4net.core.MemberId("isTitleCase","(C)Z", false, true), // #79 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isTitleCase","(I)Z", false, true), // #80 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isUnicodeIdentifierPart","(C)Z", false, true), // #81 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isUnicodeIdentifierPart","(I)Z", false, true), // #82 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isUnicodeIdentifierStart","(C)Z", false, true), // #83 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isUnicodeIdentifierStart","(I)Z", false, true), // #84 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isUpperCase","(C)Z", false, true), // #85 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isUpperCase","(I)Z", false, true), // #86 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isValidCodePoint","(I)Z", false, true), // #87 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isWhitespace","(C)Z", false, true), // #88 (C)Z
                        new global::net.sf.jni4net.core.MemberId("isWhitespace","(I)Z", false, true), // #89 (I)Z
                        new global::net.sf.jni4net.core.MemberId("LETTER_NUMBER","B", true, true), // #90 ()B
                        new global::net.sf.jni4net.core.MemberId("LINE_SEPARATOR","B", true, true), // #91 ()B
                        new global::net.sf.jni4net.core.MemberId("LOWERCASE_LETTER","B", true, true), // #92 ()B
                        new global::net.sf.jni4net.core.MemberId("MATH_SYMBOL","B", true, true), // #93 ()B
                        new global::net.sf.jni4net.core.MemberId("MAX_CODE_POINT","I", true, true), // #94 ()I
                        new global::net.sf.jni4net.core.MemberId("MAX_HIGH_SURROGATE","C", true, true), // #95 ()C
                        new global::net.sf.jni4net.core.MemberId("MAX_LOW_SURROGATE","C", true, true), // #96 ()C
                        new global::net.sf.jni4net.core.MemberId("MAX_RADIX","I", true, true), // #97 ()I
                        new global::net.sf.jni4net.core.MemberId("MAX_SURROGATE","C", true, true), // #98 ()C
                        new global::net.sf.jni4net.core.MemberId("MAX_VALUE","C", true, true), // #99 ()C
                        new global::net.sf.jni4net.core.MemberId("MIN_CODE_POINT","I", true, true), // #100 ()I
                        new global::net.sf.jni4net.core.MemberId("MIN_HIGH_SURROGATE","C", true, true), // #101 ()C
                        new global::net.sf.jni4net.core.MemberId("MIN_LOW_SURROGATE","C", true, true), // #102 ()C
                        new global::net.sf.jni4net.core.MemberId("MIN_RADIX","I", true, true), // #103 ()I
                        new global::net.sf.jni4net.core.MemberId("MIN_SUPPLEMENTARY_CODE_POINT","I", true, true), // #104 ()I
                        new global::net.sf.jni4net.core.MemberId("MIN_SURROGATE","C", true, true), // #105 ()C
                        new global::net.sf.jni4net.core.MemberId("MIN_VALUE","C", true, true), // #106 ()C
                        new global::net.sf.jni4net.core.MemberId("MODIFIER_LETTER","B", true, true), // #107 ()B
                        new global::net.sf.jni4net.core.MemberId("MODIFIER_SYMBOL","B", true, true), // #108 ()B
                        new global::net.sf.jni4net.core.MemberId("NON_SPACING_MARK","B", true, true), // #109 ()B
                        new global::net.sf.jni4net.core.MemberId("offsetByCodePoints","([CIIII)I", false, true), // #110 ([CIIII)I
                        new global::net.sf.jni4net.core.MemberId("offsetByCodePoints","(Ljava/lang/CharSequence;II)I", false, true), // #111 (Ljava/lang/CharSequence;II)I
                        new global::net.sf.jni4net.core.MemberId("OTHER_LETTER","B", true, true), // #112 ()B
                        new global::net.sf.jni4net.core.MemberId("OTHER_NUMBER","B", true, true), // #113 ()B
                        new global::net.sf.jni4net.core.MemberId("OTHER_PUNCTUATION","B", true, true), // #114 ()B
                        new global::net.sf.jni4net.core.MemberId("OTHER_SYMBOL","B", true, true), // #115 ()B
                        new global::net.sf.jni4net.core.MemberId("PARAGRAPH_SEPARATOR","B", true, true), // #116 ()B
                        new global::net.sf.jni4net.core.MemberId("PRIVATE_USE","B", true, true), // #117 ()B
                        new global::net.sf.jni4net.core.MemberId("reverseBytes","(C)C", false, true), // #118 (C)C
                        new global::net.sf.jni4net.core.MemberId("SIZE","I", true, true), // #119 ()I
                        new global::net.sf.jni4net.core.MemberId("SPACE_SEPARATOR","B", true, true), // #120 ()B
                        new global::net.sf.jni4net.core.MemberId("START_PUNCTUATION","B", true, true), // #121 ()B
                        new global::net.sf.jni4net.core.MemberId("SURROGATE","B", true, true), // #122 ()B
                        new global::net.sf.jni4net.core.MemberId("TITLECASE_LETTER","B", true, true), // #123 ()B
                        new global::net.sf.jni4net.core.MemberId("toChars","(I)[C", false, true), // #124 (I)[C
                        new global::net.sf.jni4net.core.MemberId("toChars","(I[CI)I", false, true), // #125 (I[CI)I
                        new global::net.sf.jni4net.core.MemberId("toCodePoint","(CC)I", false, true), // #126 (CC)I
                        new global::net.sf.jni4net.core.MemberId("toLowerCase","(C)C", false, true), // #127 (C)C
                        new global::net.sf.jni4net.core.MemberId("toLowerCase","(I)I", false, true), // #128 (I)I
                        new global::net.sf.jni4net.core.MemberId("toString","(C)Ljava/lang/String;", false, true), // #129 (C)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toTitleCase","(C)C", false, true), // #130 (C)C
                        new global::net.sf.jni4net.core.MemberId("toTitleCase","(I)I", false, true), // #131 (I)I
                        new global::net.sf.jni4net.core.MemberId("toUpperCase","(C)C", false, true), // #132 (C)C
                        new global::net.sf.jni4net.core.MemberId("toUpperCase","(I)I", false, true), // #133 (I)I
                        new global::net.sf.jni4net.core.MemberId("TYPE","Ljava/lang/Class;", true, true), // #134 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("UNASSIGNED","B", true, true), // #135 ()B
                        new global::net.sf.jni4net.core.MemberId("UPPERCASE_LETTER","B", true, true), // #136 ()B
                        new global::net.sf.jni4net.core.MemberId("valueOf","(C)Ljava/lang/Character;", false, true), // #137 (C)Ljava/lang/Character;
                        new global::net.sf.jni4net.core.MemberId("charValue","()C", false, false), // #138 ()C
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Character;)I", false, false), // #139 (Ljava/lang/Character;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #140 (Lsystem/Object;)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Character.Subset))]
        public partial class Subset : global::java.lang.Object
        {
            
            static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static private global::java.lang.IClass j4n_Class;
            
            static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            new static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            protected Subset(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new java.lang.Character.Subset(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            static Subset()
            {
                global::net.sf.jni4net.modules.jremicroj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Character.Subset));
            }
            
            new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
            {
                lock (typeof(global::java.lang.Character.Subset))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = false;
                        proxyInfo.JVMApiName = "java.lang.Character$Subset";
                        proxyInfo.JVMStaticApiName = "java_.lang.Character_$Subset_";
                        proxyInfo.CLRApi = typeof(java.lang.Character.Subset);
                        proxyInfo.CLRStaticApi = typeof(java.lang.Character.Subset);
                        proxyInfo.CLRProxy = typeof(java.lang.Character.Subset);
                        proxyInfo.JVMProxyFactory = java.lang.Character.Subset.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Character.UnicodeBlock))]
        public sealed partial class UnicodeBlock : global::java.lang.Character.Subset
        {
            
            static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static private global::java.lang.IClass j4n_Class;
            
            static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            new static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            private UnicodeBlock(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new java.lang.Character.UnicodeBlock(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            static UnicodeBlock()
            {
                global::net.sf.jni4net.modules.jremicroj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Character.Subset));
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Character.UnicodeBlock));
            }
            
            static public global::java.lang.Character.UnicodeBlock AEGEAN_NUMBERS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[0]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ALPHABETIC_PRESENTATION_FORMS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[1]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ARABIC {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[2]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_A {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[3]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_B {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[4]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ARMENIAN {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[5]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ARROWS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[6]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BASIC_LATIN {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[7]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BENGALI {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[8]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BLOCK_ELEMENTS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[9]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BOPOMOFO {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[10]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BOPOMOFO_EXTENDED {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[11]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BOX_DRAWING {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[12]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BRAILLE_PATTERNS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[13]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BUHID {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[14]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[15]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CHEROKEE {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[16]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[17]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_FORMS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[18]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[19]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[20]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_RADICALS_SUPPLEMENT {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[21]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[22]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[23]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[24]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[25]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[26]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock COMBINING_HALF_MARKS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[27]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[28]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CONTROL_PICTURES {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[29]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CURRENCY_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[30]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CYPRIOT_SYLLABARY {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[31]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CYRILLIC {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[32]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock CYRILLIC_SUPPLEMENTARY {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[33]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock DESERET {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[34]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock DEVANAGARI {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[35]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock DINGBATS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[36]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERICS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[37]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[38]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ETHIOPIC {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[39]));
                    }
                }
            }
            
            /// <signature>#40 (Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock; (Lsystem/String;)Ljava/lang/Character+UnicodeBlock;</signature>
            static public global::java.lang.Character.UnicodeBlock forName(string par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[40], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock GENERAL_PUNCTUATION {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[41]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock GEOMETRIC_SHAPES {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[42]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock GEORGIAN {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[43]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock GOTHIC {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[44]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock GREEK {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[45]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock GREEK_EXTENDED {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[46]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock GUJARATI {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[47]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock GURMUKHI {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[48]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[49]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HANGUL_COMPATIBILITY_JAMO {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[50]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HANGUL_JAMO {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[51]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HANGUL_SYLLABLES {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[52]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HANUNOO {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[53]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HEBREW {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[54]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HIGH_PRIVATE_USE_SURROGATES {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[55]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HIGH_SURROGATES {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[56]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock HIRAGANA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[57]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[58]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock IPA_EXTENSIONS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[59]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock KANBUN {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[60]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock KANGXI_RADICALS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[61]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock KANNADA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[62]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock KATAKANA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[63]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[64]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock KHMER {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[65]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock KHMER_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[66]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LAO {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[67]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LATIN_1_SUPPLEMENT {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[68]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_A {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[69]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_ADDITIONAL {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[70]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_B {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[71]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LETTERLIKE_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[72]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LIMBU {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[73]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LINEAR_B_IDEOGRAMS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[74]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LINEAR_B_SYLLABARY {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[75]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock LOW_SURROGATES {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[76]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MALAYALAM {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[77]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[78]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MATHEMATICAL_OPERATORS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[79]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[80]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[81]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[82]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[83]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MISCELLANEOUS_TECHNICAL {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[84]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MONGOLIAN {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[85]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MUSICAL_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[86]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock MYANMAR {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[87]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock NUMBER_FORMS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[88]));
                    }
                }
            }
            
            /// <signature>#89 (C)Ljava/lang/Character$UnicodeBlock; (C)Ljava/lang/Character+UnicodeBlock;</signature>
            static public global::java.lang.Character.UnicodeBlock of(char par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[89], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
                }
            }
            
            /// <signature>#90 (I)Ljava/lang/Character$UnicodeBlock; (I)Ljava/lang/Character+UnicodeBlock;</signature>
            static public global::java.lang.Character.UnicodeBlock of(int par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[90], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock OGHAM {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[91]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock OLD_ITALIC {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[92]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock OPTICAL_CHARACTER_RECOGNITION {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[93]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock ORIYA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[94]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock OSMANYA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[95]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock PHONETIC_EXTENSIONS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[96]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock PRIVATE_USE_AREA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[97]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock RUNIC {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[98]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SHAVIAN {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[99]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SINHALA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[100]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SMALL_FORM_VARIANTS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[101]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SPACING_MODIFIER_LETTERS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[102]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SPECIALS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[103]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[104]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_A {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[105]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_B {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[106]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[107]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[108]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[109]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SURROGATES_AREA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[110]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock SYRIAC {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[111]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock TAGALOG {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[112]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock TAGBANWA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[113]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock TAGS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[114]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock TAI_LE {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[115]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock TAI_XUAN_JING_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[116]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock TAMIL {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[117]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock TELUGU {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[118]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock THAANA {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[119]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock THAI {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[120]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock TIBETAN {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[121]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock UGARITIC {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[122]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[123]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[124]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[125]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock YI_RADICALS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[126]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock YI_SYLLABLES {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[127]));
                    }
                }
            }
            
            static public global::java.lang.Character.UnicodeBlock YIJING_HEXAGRAM_SYMBOLS {
                get {
                    global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                    using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                    {
                        return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.Character.UnicodeBlock>(j4n_env, j4n_env.GetStaticObjectField(java.lang.Character.UnicodeBlock.j4n_Class, java.lang.Character.UnicodeBlock.j4n_Members[128]));
                    }
                }
            }
            
            new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
            {
                lock (typeof(global::java.lang.Character.UnicodeBlock))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = false;
                        proxyInfo.JVMApiName = "java.lang.Character$UnicodeBlock";
                        proxyInfo.JVMStaticApiName = "java_.lang.Character_$UnicodeBlock_";
                        proxyInfo.CLRApi = typeof(java.lang.Character.UnicodeBlock);
                        proxyInfo.CLRStaticApi = typeof(java.lang.Character.UnicodeBlock);
                        proxyInfo.CLRProxy = typeof(java.lang.Character.UnicodeBlock);
                        proxyInfo.JVMProxyFactory = java.lang.Character.UnicodeBlock.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("AEGEAN_NUMBERS","Ljava/lang/Character$UnicodeBlock;", true, true), // #0 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ALPHABETIC_PRESENTATION_FORMS","Ljava/lang/Character$UnicodeBlock;", true, true), // #1 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ARABIC","Ljava/lang/Character$UnicodeBlock;", true, true), // #2 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ARABIC_PRESENTATION_FORMS_A","Ljava/lang/Character$UnicodeBlock;", true, true), // #3 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ARABIC_PRESENTATION_FORMS_B","Ljava/lang/Character$UnicodeBlock;", true, true), // #4 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ARMENIAN","Ljava/lang/Character$UnicodeBlock;", true, true), // #5 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ARROWS","Ljava/lang/Character$UnicodeBlock;", true, true), // #6 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BASIC_LATIN","Ljava/lang/Character$UnicodeBlock;", true, true), // #7 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BENGALI","Ljava/lang/Character$UnicodeBlock;", true, true), // #8 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BLOCK_ELEMENTS","Ljava/lang/Character$UnicodeBlock;", true, true), // #9 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BOPOMOFO","Ljava/lang/Character$UnicodeBlock;", true, true), // #10 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BOPOMOFO_EXTENDED","Ljava/lang/Character$UnicodeBlock;", true, true), // #11 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BOX_DRAWING","Ljava/lang/Character$UnicodeBlock;", true, true), // #12 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BRAILLE_PATTERNS","Ljava/lang/Character$UnicodeBlock;", true, true), // #13 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BUHID","Ljava/lang/Character$UnicodeBlock;", true, true), // #14 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("BYZANTINE_MUSICAL_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #15 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CHEROKEE","Ljava/lang/Character$UnicodeBlock;", true, true), // #16 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_COMPATIBILITY","Ljava/lang/Character$UnicodeBlock;", true, true), // #17 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_COMPATIBILITY_FORMS","Ljava/lang/Character$UnicodeBlock;", true, true), // #18 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_COMPATIBILITY_IDEOGRAPHS","Ljava/lang/Character$UnicodeBlock;", true, true), // #19 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT","Ljava/lang/Character$UnicodeBlock;", true, true), // #20 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_RADICALS_SUPPLEMENT","Ljava/lang/Character$UnicodeBlock;", true, true), // #21 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_SYMBOLS_AND_PUNCTUATION","Ljava/lang/Character$UnicodeBlock;", true, true), // #22 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_UNIFIED_IDEOGRAPHS","Ljava/lang/Character$UnicodeBlock;", true, true), // #23 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A","Ljava/lang/Character$UnicodeBlock;", true, true), // #24 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B","Ljava/lang/Character$UnicodeBlock;", true, true), // #25 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("COMBINING_DIACRITICAL_MARKS","Ljava/lang/Character$UnicodeBlock;", true, true), // #26 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("COMBINING_HALF_MARKS","Ljava/lang/Character$UnicodeBlock;", true, true), // #27 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("COMBINING_MARKS_FOR_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #28 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CONTROL_PICTURES","Ljava/lang/Character$UnicodeBlock;", true, true), // #29 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CURRENCY_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #30 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CYPRIOT_SYLLABARY","Ljava/lang/Character$UnicodeBlock;", true, true), // #31 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CYRILLIC","Ljava/lang/Character$UnicodeBlock;", true, true), // #32 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("CYRILLIC_SUPPLEMENTARY","Ljava/lang/Character$UnicodeBlock;", true, true), // #33 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("DESERET","Ljava/lang/Character$UnicodeBlock;", true, true), // #34 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("DEVANAGARI","Ljava/lang/Character$UnicodeBlock;", true, true), // #35 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("DINGBATS","Ljava/lang/Character$UnicodeBlock;", true, true), // #36 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ENCLOSED_ALPHANUMERICS","Ljava/lang/Character$UnicodeBlock;", true, true), // #37 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ENCLOSED_CJK_LETTERS_AND_MONTHS","Ljava/lang/Character$UnicodeBlock;", true, true), // #38 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ETHIOPIC","Ljava/lang/Character$UnicodeBlock;", true, true), // #39 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("forName","(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;", false, true), // #40 (Lsystem/String;)Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("GENERAL_PUNCTUATION","Ljava/lang/Character$UnicodeBlock;", true, true), // #41 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("GEOMETRIC_SHAPES","Ljava/lang/Character$UnicodeBlock;", true, true), // #42 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("GEORGIAN","Ljava/lang/Character$UnicodeBlock;", true, true), // #43 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("GOTHIC","Ljava/lang/Character$UnicodeBlock;", true, true), // #44 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("GREEK","Ljava/lang/Character$UnicodeBlock;", true, true), // #45 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("GREEK_EXTENDED","Ljava/lang/Character$UnicodeBlock;", true, true), // #46 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("GUJARATI","Ljava/lang/Character$UnicodeBlock;", true, true), // #47 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("GURMUKHI","Ljava/lang/Character$UnicodeBlock;", true, true), // #48 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HALFWIDTH_AND_FULLWIDTH_FORMS","Ljava/lang/Character$UnicodeBlock;", true, true), // #49 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HANGUL_COMPATIBILITY_JAMO","Ljava/lang/Character$UnicodeBlock;", true, true), // #50 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HANGUL_JAMO","Ljava/lang/Character$UnicodeBlock;", true, true), // #51 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HANGUL_SYLLABLES","Ljava/lang/Character$UnicodeBlock;", true, true), // #52 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HANUNOO","Ljava/lang/Character$UnicodeBlock;", true, true), // #53 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HEBREW","Ljava/lang/Character$UnicodeBlock;", true, true), // #54 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HIGH_PRIVATE_USE_SURROGATES","Ljava/lang/Character$UnicodeBlock;", true, true), // #55 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HIGH_SURROGATES","Ljava/lang/Character$UnicodeBlock;", true, true), // #56 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("HIRAGANA","Ljava/lang/Character$UnicodeBlock;", true, true), // #57 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("IDEOGRAPHIC_DESCRIPTION_CHARACTERS","Ljava/lang/Character$UnicodeBlock;", true, true), // #58 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("IPA_EXTENSIONS","Ljava/lang/Character$UnicodeBlock;", true, true), // #59 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("KANBUN","Ljava/lang/Character$UnicodeBlock;", true, true), // #60 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("KANGXI_RADICALS","Ljava/lang/Character$UnicodeBlock;", true, true), // #61 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("KANNADA","Ljava/lang/Character$UnicodeBlock;", true, true), // #62 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("KATAKANA","Ljava/lang/Character$UnicodeBlock;", true, true), // #63 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("KATAKANA_PHONETIC_EXTENSIONS","Ljava/lang/Character$UnicodeBlock;", true, true), // #64 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("KHMER","Ljava/lang/Character$UnicodeBlock;", true, true), // #65 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("KHMER_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #66 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LAO","Ljava/lang/Character$UnicodeBlock;", true, true), // #67 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LATIN_1_SUPPLEMENT","Ljava/lang/Character$UnicodeBlock;", true, true), // #68 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LATIN_EXTENDED_A","Ljava/lang/Character$UnicodeBlock;", true, true), // #69 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LATIN_EXTENDED_ADDITIONAL","Ljava/lang/Character$UnicodeBlock;", true, true), // #70 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LATIN_EXTENDED_B","Ljava/lang/Character$UnicodeBlock;", true, true), // #71 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LETTERLIKE_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #72 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LIMBU","Ljava/lang/Character$UnicodeBlock;", true, true), // #73 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LINEAR_B_IDEOGRAMS","Ljava/lang/Character$UnicodeBlock;", true, true), // #74 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LINEAR_B_SYLLABARY","Ljava/lang/Character$UnicodeBlock;", true, true), // #75 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("LOW_SURROGATES","Ljava/lang/Character$UnicodeBlock;", true, true), // #76 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MALAYALAM","Ljava/lang/Character$UnicodeBlock;", true, true), // #77 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MATHEMATICAL_ALPHANUMERIC_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #78 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MATHEMATICAL_OPERATORS","Ljava/lang/Character$UnicodeBlock;", true, true), // #79 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A","Ljava/lang/Character$UnicodeBlock;", true, true), // #80 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B","Ljava/lang/Character$UnicodeBlock;", true, true), // #81 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MISCELLANEOUS_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #82 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MISCELLANEOUS_SYMBOLS_AND_ARROWS","Ljava/lang/Character$UnicodeBlock;", true, true), // #83 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MISCELLANEOUS_TECHNICAL","Ljava/lang/Character$UnicodeBlock;", true, true), // #84 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MONGOLIAN","Ljava/lang/Character$UnicodeBlock;", true, true), // #85 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MUSICAL_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #86 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("MYANMAR","Ljava/lang/Character$UnicodeBlock;", true, true), // #87 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("NUMBER_FORMS","Ljava/lang/Character$UnicodeBlock;", true, true), // #88 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("of","(C)Ljava/lang/Character$UnicodeBlock;", false, true), // #89 (C)Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("of","(I)Ljava/lang/Character$UnicodeBlock;", false, true), // #90 (I)Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("OGHAM","Ljava/lang/Character$UnicodeBlock;", true, true), // #91 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("OLD_ITALIC","Ljava/lang/Character$UnicodeBlock;", true, true), // #92 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("OPTICAL_CHARACTER_RECOGNITION","Ljava/lang/Character$UnicodeBlock;", true, true), // #93 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("ORIYA","Ljava/lang/Character$UnicodeBlock;", true, true), // #94 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("OSMANYA","Ljava/lang/Character$UnicodeBlock;", true, true), // #95 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("PHONETIC_EXTENSIONS","Ljava/lang/Character$UnicodeBlock;", true, true), // #96 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("PRIVATE_USE_AREA","Ljava/lang/Character$UnicodeBlock;", true, true), // #97 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("RUNIC","Ljava/lang/Character$UnicodeBlock;", true, true), // #98 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SHAVIAN","Ljava/lang/Character$UnicodeBlock;", true, true), // #99 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SINHALA","Ljava/lang/Character$UnicodeBlock;", true, true), // #100 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SMALL_FORM_VARIANTS","Ljava/lang/Character$UnicodeBlock;", true, true), // #101 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SPACING_MODIFIER_LETTERS","Ljava/lang/Character$UnicodeBlock;", true, true), // #102 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SPECIALS","Ljava/lang/Character$UnicodeBlock;", true, true), // #103 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SUPERSCRIPTS_AND_SUBSCRIPTS","Ljava/lang/Character$UnicodeBlock;", true, true), // #104 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SUPPLEMENTAL_ARROWS_A","Ljava/lang/Character$UnicodeBlock;", true, true), // #105 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SUPPLEMENTAL_ARROWS_B","Ljava/lang/Character$UnicodeBlock;", true, true), // #106 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SUPPLEMENTAL_MATHEMATICAL_OPERATORS","Ljava/lang/Character$UnicodeBlock;", true, true), // #107 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SUPPLEMENTARY_PRIVATE_USE_AREA_A","Ljava/lang/Character$UnicodeBlock;", true, true), // #108 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SUPPLEMENTARY_PRIVATE_USE_AREA_B","Ljava/lang/Character$UnicodeBlock;", true, true), // #109 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SURROGATES_AREA","Ljava/lang/Character$UnicodeBlock;", true, true), // #110 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("SYRIAC","Ljava/lang/Character$UnicodeBlock;", true, true), // #111 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("TAGALOG","Ljava/lang/Character$UnicodeBlock;", true, true), // #112 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("TAGBANWA","Ljava/lang/Character$UnicodeBlock;", true, true), // #113 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("TAGS","Ljava/lang/Character$UnicodeBlock;", true, true), // #114 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("TAI_LE","Ljava/lang/Character$UnicodeBlock;", true, true), // #115 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("TAI_XUAN_JING_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #116 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("TAMIL","Ljava/lang/Character$UnicodeBlock;", true, true), // #117 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("TELUGU","Ljava/lang/Character$UnicodeBlock;", true, true), // #118 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("THAANA","Ljava/lang/Character$UnicodeBlock;", true, true), // #119 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("THAI","Ljava/lang/Character$UnicodeBlock;", true, true), // #120 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("TIBETAN","Ljava/lang/Character$UnicodeBlock;", true, true), // #121 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("UGARITIC","Ljava/lang/Character$UnicodeBlock;", true, true), // #122 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS","Ljava/lang/Character$UnicodeBlock;", true, true), // #123 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("VARIATION_SELECTORS","Ljava/lang/Character$UnicodeBlock;", true, true), // #124 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("VARIATION_SELECTORS_SUPPLEMENT","Ljava/lang/Character$UnicodeBlock;", true, true), // #125 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("YI_RADICALS","Ljava/lang/Character$UnicodeBlock;", true, true), // #126 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("YI_SYLLABLES","Ljava/lang/Character$UnicodeBlock;", true, true), // #127 ()Ljava/lang/Character+UnicodeBlock;
                        new global::net.sf.jni4net.core.MemberId("YIJING_HEXAGRAM_SYMBOLS","Ljava/lang/Character$UnicodeBlock;", true, true), // #128 ()Ljava/lang/Character+UnicodeBlock;
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
    }
}

#endregion Component Designer generated code
