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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.PrintStream))]
    public partial class PrintStream : global::java.io.FilterOutputStream, global::java.lang.Appendable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected PrintStream(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.PrintStream(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static PrintStream()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.FilterOutputStream));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Appendable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Appendable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.PrintStream));
        }
        
        /// <signature>#0 (Ljava/io/File;)V (Ljava/io/File;)V</signature>
        public PrintStream(global::java.io.File par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.PrintStream.j4n_Class, java.io.PrintStream.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.File"));
            }
        }
        
        /// <signature>#1 (Ljava/io/File;Ljava/lang/String;)V (Ljava/io/File;Lsystem/String;)V</signature>
        public PrintStream(global::java.io.File par0, string par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.PrintStream.j4n_Class, java.io.PrintStream.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.File"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#2 (Ljava/io/OutputStream;)V (Ljava/io/OutputStream;)V</signature>
        public PrintStream(global::java.io.OutputStream par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.PrintStream.j4n_Class, java.io.PrintStream.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"));
            }
        }
        
        /// <signature>#3 (Ljava/io/OutputStream;Z)V (Ljava/io/OutputStream;Z)V</signature>
        public PrintStream(global::java.io.OutputStream par0, bool par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.PrintStream.j4n_Class, java.io.PrintStream.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1));
            }
        }
        
        /// <signature>#4 (Ljava/io/OutputStream;ZLjava/lang/String;)V (Ljava/io/OutputStream;ZLsystem/String;)V</signature>
        public PrintStream(global::java.io.OutputStream par0, bool par1, string par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.PrintStream.j4n_Class, java.io.PrintStream.j4n_Members[4], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2));
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public PrintStream(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.PrintStream.j4n_Class, java.io.PrintStream.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#6 (Ljava/lang/String;Ljava/lang/String;)V (Lsystem/String;Lsystem/String;)V</signature>
        public PrintStream(string par0, string par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.PrintStream.j4n_Class, java.io.PrintStream.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#7 (C)Ljava/io/PrintStream; (C)Ljava/io/PrintStream;</signature>
        public virtual global::java.io.PrintStream append(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[7], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#8 (C)Ljava/lang/Appendable; (C)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable global::java.lang.Appendable.append(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[8], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#9 (Ljava/lang/CharSequence;)Ljava/io/PrintStream; (Ljava/lang/CharSequence;)Ljava/io/PrintStream;</signature>
        public virtual global::java.io.PrintStream append(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[9], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#10 (Ljava/lang/CharSequence;)Ljava/lang/Appendable; (Ljava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable global::java.lang.Appendable.append(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[10], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#11 (Ljava/lang/CharSequence;II)Ljava/io/PrintStream; (Ljava/lang/CharSequence;II)Ljava/io/PrintStream;</signature>
        public virtual global::java.io.PrintStream append(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[11], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#12 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable; (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable global::java.lang.Appendable.append(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
        
        /// <signature>#13 ()Z ()Z</signature>
        public virtual bool checkError()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.PrintStream.j4n_Members[13]);
            }
        }
        
        /// <signature>#14 (Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream; (Lsystem/String;[Lsystem/Object;)Ljava/io/PrintStream;</signature>
        public virtual global::java.io.PrintStream format(string par0, object[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[14], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
            }
        }
        
        /// <signature>#15 (Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream; (Ljava/lang/Cloneable;Lsystem/String;[Lsystem/Object;)Ljava/io/PrintStream;</signature>
        public virtual global::java.io.PrintStream format(global::java.lang.Cloneable par0, string par1, object[] par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[15], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Locale"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.lang.Object")));
            }
        }
        
        /// <signature>#16 ([C)V ([C)V</signature>
        public virtual void print(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[16], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#17 (C)V (C)V</signature>
        public virtual void print(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[17], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#18 (D)V (D)V</signature>
        public virtual void print(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[18], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#19 (F)V (F)V</signature>
        public virtual void print(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[19], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#20 (I)V (I)V</signature>
        public virtual void print(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[20], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#21 (J)V (J)V</signature>
        public virtual void print(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[21], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#22 (Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        public virtual void print(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[22], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#23 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public virtual void print(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[23], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#24 (Z)V (Z)V</signature>
        public virtual void print(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[24], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        /// <signature>#25 (Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream; (Lsystem/String;[Lsystem/Object;)Ljava/io/PrintStream;</signature>
        public virtual global::java.io.PrintStream printf(string par0, object[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[25], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
            }
        }
        
        /// <signature>#26 (Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream; (Ljava/lang/Cloneable;Lsystem/String;[Lsystem/Object;)Ljava/io/PrintStream;</signature>
        public virtual global::java.io.PrintStream printf(global::java.lang.Cloneable par0, string par1, object[] par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.CallObjectMethod(this, java.io.PrintStream.j4n_Members[26], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Locale"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.lang.Object")));
            }
        }
        
        /// <signature>#27 ()V ()V</signature>
        public virtual void println()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[27]);
            }
        }
        
        /// <signature>#28 ([C)V ([C)V</signature>
        public virtual void println(char[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[28], global::net.sf.jni4net.core.ConvertChar.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#29 (C)V (C)V</signature>
        public virtual void println(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[29], global::net.sf.jni4net.core.ConvertChar.ToValue(par0));
            }
        }
        
        /// <signature>#30 (D)V (D)V</signature>
        public virtual void println(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[30], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#31 (F)V (F)V</signature>
        public virtual void println(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[31], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#32 (I)V (I)V</signature>
        public virtual void println(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[32], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#33 (J)V (J)V</signature>
        public virtual void println(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[33], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#34 (Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        public virtual void println(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[34], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#35 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public virtual void println(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[35], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#36 (Z)V (Z)V</signature>
        public virtual void println(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.PrintStream.j4n_Members[36], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.PrintStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.PrintStream";
                    proxyInfo.JVMStaticApiName = "java_.io.PrintStream_";
                    proxyInfo.CLRApi = typeof(java.io.PrintStream);
                    proxyInfo.CLRStaticApi = typeof(java.io.PrintStream);
                    proxyInfo.CLRProxy = typeof(java.io.PrintStream);
                    proxyInfo.JVMProxyFactory = java.io.PrintStream.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/File;)V", false, false), // #0 (Ljava/io/File;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/File;Ljava/lang/String;)V", false, false), // #1 (Ljava/io/File;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/OutputStream;)V", false, false), // #2 (Ljava/io/OutputStream;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/OutputStream;Z)V", false, false), // #3 (Ljava/io/OutputStream;Z)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/OutputStream;ZLjava/lang/String;)V", false, false), // #4 (Ljava/io/OutputStream;ZLsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #5 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;)V", false, false), // #6 (Lsystem/String;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("append","(C)Ljava/io/PrintStream;", false, false), // #7 (C)Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("append","(C)Ljava/lang/Appendable;", false, false), // #8 (C)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;)Ljava/io/PrintStream;", false, false), // #9 (Ljava/lang/CharSequence;)Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", false, false), // #10 (Ljava/lang/CharSequence;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;II)Ljava/io/PrintStream;", false, false), // #11 (Ljava/lang/CharSequence;II)Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", false, false), // #12 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("checkError","()Z", false, false), // #13 ()Z
                        new global::net.sf.jni4net.core.MemberId("format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", false, false), // #14 (Lsystem/String;[Lsystem/Object;)Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("format","(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", false, false), // #15 (Ljava/lang/Cloneable;Lsystem/String;[Lsystem/Object;)Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("print","([C)V", false, false), // #16 ([C)V
                        new global::net.sf.jni4net.core.MemberId("print","(C)V", false, false), // #17 (C)V
                        new global::net.sf.jni4net.core.MemberId("print","(D)V", false, false), // #18 (D)V
                        new global::net.sf.jni4net.core.MemberId("print","(F)V", false, false), // #19 (F)V
                        new global::net.sf.jni4net.core.MemberId("print","(I)V", false, false), // #20 (I)V
                        new global::net.sf.jni4net.core.MemberId("print","(J)V", false, false), // #21 (J)V
                        new global::net.sf.jni4net.core.MemberId("print","(Ljava/lang/Object;)V", false, false), // #22 (Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("print","(Ljava/lang/String;)V", false, false), // #23 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("print","(Z)V", false, false), // #24 (Z)V
                        new global::net.sf.jni4net.core.MemberId("printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", false, false), // #25 (Lsystem/String;[Lsystem/Object;)Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("printf","(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", false, false), // #26 (Ljava/lang/Cloneable;Lsystem/String;[Lsystem/Object;)Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("println","()V", false, false), // #27 ()V
                        new global::net.sf.jni4net.core.MemberId("println","([C)V", false, false), // #28 ([C)V
                        new global::net.sf.jni4net.core.MemberId("println","(C)V", false, false), // #29 (C)V
                        new global::net.sf.jni4net.core.MemberId("println","(D)V", false, false), // #30 (D)V
                        new global::net.sf.jni4net.core.MemberId("println","(F)V", false, false), // #31 (F)V
                        new global::net.sf.jni4net.core.MemberId("println","(I)V", false, false), // #32 (I)V
                        new global::net.sf.jni4net.core.MemberId("println","(J)V", false, false), // #33 (J)V
                        new global::net.sf.jni4net.core.MemberId("println","(Ljava/lang/Object;)V", false, false), // #34 (Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("println","(Ljava/lang/String;)V", false, false), // #35 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("println","(Z)V", false, false), // #36 (Z)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
