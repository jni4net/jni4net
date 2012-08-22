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

namespace java.io
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.Writer))]
    public partial class Writer : global::java.lang.Object, global::java.lang.Appendable, global::java.io.Closeable, global::java.io.Flushable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected Writer(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.Writer(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Writer()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Appendable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Appendable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Closeable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Closeable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Flushable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Flushable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.Writer));
        }
        
        /// <signature>#0 (C)Ljava/io/Writer; (C)Ljava/io/Writer;</signature>
        public virtual global::java.io.Writer append(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.Writer>(j4n_env, j4n_env.CallObjectMethod(this, java.io.Writer.j4n_Members[0], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#1 (C)Ljava/lang/Appendable; (C)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable global::java.lang.Appendable.append(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.io.Writer.j4n_Members[1], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#2 (Ljava/lang/CharSequence;)Ljava/io/Writer; (Ljava/lang/CharSequence;)Ljava/io/Writer;</signature>
        public virtual global::java.io.Writer append(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.Writer>(j4n_env, j4n_env.CallObjectMethod(this, java.io.Writer.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#3 (Ljava/lang/CharSequence;)Ljava/lang/Appendable; (Ljava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable global::java.lang.Appendable.append(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.io.Writer.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#4 (Ljava/lang/CharSequence;II)Ljava/io/Writer; (Ljava/lang/CharSequence;II)Ljava/io/Writer;</signature>
        public virtual global::java.io.Writer append(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.Writer>(j4n_env, j4n_env.CallObjectMethod(this, java.io.Writer.j4n_Members[4], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#5 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable; (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable global::java.lang.Appendable.append(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.io.Writer.j4n_Members[5], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#6 ()V ()V</signature>
        public virtual void close()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.Writer.j4n_Members[6]);
            }
        }
        
        /// <signature>#7 ()V ()V</signature>
        public virtual void flush()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.Writer.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 ([C)V ([C)V</signature>
        public virtual void write(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.Writer.j4n_Members[8], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#9 ([CII)V ([CII)V</signature>
        public virtual void write(char[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallVoidMethod(this, java.io.Writer.j4n_Members[9], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#10 (I)V (I)V</signature>
        public virtual void write(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.Writer.j4n_Members[10], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#11 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public virtual void write(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.Writer.j4n_Members[11], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#12 (Ljava/lang/String;II)V (Lsystem/String;II)V</signature>
        public virtual void write(string par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallVoidMethod(this, java.io.Writer.j4n_Members[12], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.Writer))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.Writer";
                    proxyInfo.JVMStaticApiName = "java_.io.Writer_";
                    proxyInfo.CLRApi = typeof(java.io.Writer);
                    proxyInfo.CLRStaticApi = typeof(java.io.Writer);
                    proxyInfo.CLRProxy = typeof(java.io.Writer);
                    proxyInfo.JVMProxyFactory = java.io.Writer.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("append","(C)Ljava/io/Writer;", false, false), // #0 (C)Ljava/io/Writer;
                        new global::net.sf.jni4net.core.MemberId("append","(C)Ljava/lang/Appendable;", false, false), // #1 (C)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;)Ljava/io/Writer;", false, false), // #2 (Ljava/lang/CharSequence;)Ljava/io/Writer;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", false, false), // #3 (Ljava/lang/CharSequence;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;II)Ljava/io/Writer;", false, false), // #4 (Ljava/lang/CharSequence;II)Ljava/io/Writer;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", false, false), // #5 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("close","()V", false, false), // #6 ()V
                        new global::net.sf.jni4net.core.MemberId("flush","()V", false, false), // #7 ()V
                        new global::net.sf.jni4net.core.MemberId("write","([C)V", false, false), // #8 ([C)V
                        new global::net.sf.jni4net.core.MemberId("write","([CII)V", false, false), // #9 ([CII)V
                        new global::net.sf.jni4net.core.MemberId("write","(I)V", false, false), // #10 (I)V
                        new global::net.sf.jni4net.core.MemberId("write","(Ljava/lang/String;)V", false, false), // #11 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("write","(Ljava/lang/String;II)V", false, false), // #12 (Lsystem/String;II)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
