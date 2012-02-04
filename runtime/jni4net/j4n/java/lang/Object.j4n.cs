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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Object))]
    public partial class Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Object()
        {
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Object));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Object()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.Object.j4n_Class, java.lang.Object.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public virtual bool equals(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Object.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#3 ()I ()I</signature>
        public virtual int hashCode()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.Object.j4n_Members[3]);
            }
        }
        
        /// <signature>#4 ()V ()V</signature>
        public void notify()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.Object.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 ()V ()V</signature>
        public void notifyAll()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.Object.j4n_Members[5]);
            }
        }
        
        /// <signature>#6 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string toString()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.Object.j4n_Members[6]);
            }
        }
        
        /// <signature>#7 ()V ()V</signature>
        public void wait()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.Object.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 (J)V (J)V</signature>
        public void wait(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.Object.j4n_Members[8], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#9 (JI)V (JI)V</signature>
        public void wait(long par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.Object.j4n_Members[9], global::net.sf.jni4net.core.ConvertLong.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Object))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Object";
                    proxyInfo.JVMStaticApiName = "java_.lang.Object_";
                    proxyInfo.CLRApi = typeof(java.lang.Object);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Object);
                    proxyInfo.CLRProxy = typeof(java.lang.Object);
                    proxyInfo.JVMProxyFactory = java.lang.Object.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("equals","(Ljava/lang/Object;)Z", false, false), // #1 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("getClass","()Ljava/lang/Class;", false, false), // #2 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("hashCode","()I", false, false), // #3 ()I
                        new global::net.sf.jni4net.core.MemberId("notify","()V", false, false), // #4 ()V
                        new global::net.sf.jni4net.core.MemberId("notifyAll","()V", false, false), // #5 ()V
                        new global::net.sf.jni4net.core.MemberId("toString","()Ljava/lang/String;", false, false), // #6 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("wait","()V", false, false), // #7 ()V
                        new global::net.sf.jni4net.core.MemberId("wait","(J)V", false, false), // #8 (J)V
                        new global::net.sf.jni4net.core.MemberId("wait","(JI)V", false, false), // #9 (JI)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
