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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Throwable))]
    public partial class Throwable : global::java.io.Serializable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Throwable()
        {
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Throwable));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Throwable()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Throwable.j4n_Class, java.lang.Throwable.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public Throwable(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Throwable.j4n_Class, java.lang.Throwable.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;Ljava/lang/Throwable;)V (Lsystem/String;LSystem/Exception;)V</signature>
        public Throwable(string par0, global::System.Exception par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Throwable.j4n_Class, java.lang.Throwable.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Throwable"));
            }
        }
        
        /// <signature>#3 (Ljava/lang/Throwable;)V (LSystem/Exception;)V</signature>
        public Throwable(global::System.Exception par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Throwable.j4n_Class, java.lang.Throwable.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Throwable"));
            }
        }
        
        /// <signature>#4 ()Ljava/lang/Throwable; ()LSystem/Exception;</signature>
        public virtual global::System.Exception fillInStackTrace()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Throwable.j4n_Members[4]));
            }
        }
        
        /// <signature>#5 ()Ljava/lang/Throwable; ()LSystem/Exception;</signature>
        public virtual global::System.Exception getCause()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Throwable.j4n_Members[5]));
            }
        }
        
        /// <signature>#6 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getLocalizedMessage()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.Throwable.j4n_Members[6]);
            }
        }
        
        /// <signature>#7 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getMessage()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.Throwable.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 ()[Ljava/lang/StackTraceElement; ()[Ljava/lang/StackTraceElement;</signature>
        public virtual global::java.lang.StackTraceElement[] getStackTrace()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.StackTraceElement>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Throwable.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 (Ljava/lang/Throwable;)Ljava/lang/Throwable; (LSystem/Exception;)LSystem/Exception;</signature>
        public virtual global::System.Exception initCause(global::System.Exception par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Throwable.j4n_Members[9], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Throwable")));
            }
        }
        
        /// <signature>#10 ()V ()V</signature>
        public virtual void printStackTrace()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 (Ljava/io/PrintStream;)V (Ljava/io/PrintStream;)V</signature>
        public virtual void printStackTrace(global::java.io.PrintStream par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[11], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.PrintStream"));
            }
        }
        
        /// <signature>#12 (Ljava/io/PrintWriter;)V (Ljava/io/PrintWriter;)V</signature>
        public virtual void printStackTrace(global::java.io.PrintWriter par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.PrintWriter"));
            }
        }
        
        /// <signature>#13 ([Ljava/lang/StackTraceElement;)V ([Ljava/lang/StackTraceElement;)V</signature>
        public virtual void setStackTrace(global::java.lang.StackTraceElement[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[13], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#14 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public virtual bool equals(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Throwable.j4n_Members[14], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#15 ()I ()I</signature>
        public virtual int hashCode()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.Throwable.j4n_Members[15]);
            }
        }
        
        /// <signature>#16 ()V ()V</signature>
        public void notify()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[16]);
            }
        }
        
        /// <signature>#17 ()V ()V</signature>
        public void notifyAll()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[17]);
            }
        }
        
        /// <signature>#18 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string toString()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.Throwable.j4n_Members[18]);
            }
        }
        
        /// <signature>#19 ()V ()V</signature>
        public void wait()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[19]);
            }
        }
        
        /// <signature>#20 (J)V (J)V</signature>
        public void wait(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[20], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#21 (JI)V (JI)V</signature>
        public void wait(long par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.Throwable.j4n_Members[21], global::net.sf.jni4net.core.ConvertLong.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Throwable))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Throwable";
                    proxyInfo.JVMStaticApiName = "java_.lang.Throwable_";
                    proxyInfo.CLRApi = typeof(java.lang.Throwable);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Throwable);
                    proxyInfo.CLRProxy = typeof(java.lang.Throwable);
                    proxyInfo.JVMProxyFactory = java.lang.Throwable.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V", false, false), // #2 (Lsystem/String;LSystem/Exception;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/Throwable;)V", false, false), // #3 (LSystem/Exception;)V
                        new global::net.sf.jni4net.core.MemberId("fillInStackTrace","()Ljava/lang/Throwable;", false, false), // #4 ()LSystem/Exception;
                        new global::net.sf.jni4net.core.MemberId("getCause","()Ljava/lang/Throwable;", false, false), // #5 ()LSystem/Exception;
                        new global::net.sf.jni4net.core.MemberId("getLocalizedMessage","()Ljava/lang/String;", false, false), // #6 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getMessage","()Ljava/lang/String;", false, false), // #7 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getStackTrace","()[Ljava/lang/StackTraceElement;", false, false), // #8 ()[Ljava/lang/StackTraceElement;
                        new global::net.sf.jni4net.core.MemberId("initCause","(Ljava/lang/Throwable;)Ljava/lang/Throwable;", false, false), // #9 (LSystem/Exception;)LSystem/Exception;
                        new global::net.sf.jni4net.core.MemberId("printStackTrace","()V", false, false), // #10 ()V
                        new global::net.sf.jni4net.core.MemberId("printStackTrace","(Ljava/io/PrintStream;)V", false, false), // #11 (Ljava/io/PrintStream;)V
                        new global::net.sf.jni4net.core.MemberId("printStackTrace","(Ljava/io/PrintWriter;)V", false, false), // #12 (Ljava/io/PrintWriter;)V
                        new global::net.sf.jni4net.core.MemberId("setStackTrace","([Ljava/lang/StackTraceElement;)V", false, false), // #13 ([Ljava/lang/StackTraceElement;)V
                        new global::net.sf.jni4net.core.MemberId("equals","(Ljava/lang/Object;)Z", false, false), // #14 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("hashCode","()I", false, false), // #15 ()I
                        new global::net.sf.jni4net.core.MemberId("notify","()V", false, false), // #16 ()V
                        new global::net.sf.jni4net.core.MemberId("notifyAll","()V", false, false), // #17 ()V
                        new global::net.sf.jni4net.core.MemberId("toString","()Ljava/lang/String;", false, false), // #18 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("wait","()V", false, false), // #19 ()V
                        new global::net.sf.jni4net.core.MemberId("wait","(J)V", false, false), // #20 (J)V
                        new global::net.sf.jni4net.core.MemberId("wait","(JI)V", false, false), // #21 (JI)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
