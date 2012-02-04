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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ByteArrayOutputStream))]
    public partial class ByteArrayOutputStream : global::java.io.OutputStream
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected ByteArrayOutputStream(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.ByteArrayOutputStream(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static ByteArrayOutputStream()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.OutputStream));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ByteArrayOutputStream));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public ByteArrayOutputStream()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.ByteArrayOutputStream.j4n_Class, java.io.ByteArrayOutputStream.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 (I)V (I)V</signature>
        public ByteArrayOutputStream(int par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.ByteArrayOutputStream.j4n_Class, java.io.ByteArrayOutputStream.j4n_Members[1], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#2 ()V ()V</signature>
        public virtual void reset()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.ByteArrayOutputStream.j4n_Members[2]);
            }
        }
        
        /// <signature>#3 ()I ()I</signature>
        public virtual int size()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.ByteArrayOutputStream.j4n_Members[3]);
            }
        }
        
        /// <signature>#4 ()[B ()[B</signature>
        public virtual byte[] toByteArray()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertByte.ToCLRArray1(j4n_env, j4n_env.CallObjectMethod(this, java.io.ByteArrayOutputStream.j4n_Members[4]));
            }
        }
        
        /// <signature>#5 (I)Ljava/lang/String; (I)Lsystem/String;</signature>
        public virtual string toString(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStringMethod(this, java.io.ByteArrayOutputStream.j4n_Members[5], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#6 (Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        public virtual string toString(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStringMethod(this, java.io.ByteArrayOutputStream.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#7 (Ljava/io/OutputStream;)V (Ljava/io/OutputStream;)V</signature>
        public virtual void writeTo(global::java.io.OutputStream par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ByteArrayOutputStream.j4n_Members[7], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.ByteArrayOutputStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.ByteArrayOutputStream";
                    proxyInfo.JVMStaticApiName = "java_.io.ByteArrayOutputStream_";
                    proxyInfo.CLRApi = typeof(java.io.ByteArrayOutputStream);
                    proxyInfo.CLRStaticApi = typeof(java.io.ByteArrayOutputStream);
                    proxyInfo.CLRProxy = typeof(java.io.ByteArrayOutputStream);
                    proxyInfo.JVMProxyFactory = java.io.ByteArrayOutputStream.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","(I)V", false, false), // #1 (I)V
                        new global::net.sf.jni4net.core.MemberId("reset","()V", false, false), // #2 ()V
                        new global::net.sf.jni4net.core.MemberId("size","()I", false, false), // #3 ()I
                        new global::net.sf.jni4net.core.MemberId("toByteArray","()[B", false, false), // #4 ()[B
                        new global::net.sf.jni4net.core.MemberId("toString","(I)Ljava/lang/String;", false, false), // #5 (I)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toString","(Ljava/lang/String;)Ljava/lang/String;", false, false), // #6 (Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("writeTo","(Ljava/io/OutputStream;)V", false, false), // #7 (Ljava/io/OutputStream;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
