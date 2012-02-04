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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.InputStream))]
    public partial class InputStream : global::java.lang.Object, global::java.io.Closeable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected InputStream(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.InputStream(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static InputStream()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Closeable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Closeable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.InputStream));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public InputStream()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.InputStream.j4n_Class, java.io.InputStream.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()I ()I</signature>
        public virtual int available()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.InputStream.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 ()V ()V</signature>
        public virtual void close()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.InputStream.j4n_Members[2]);
            }
        }
        
        /// <signature>#3 (I)V (I)V</signature>
        public virtual void mark(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.InputStream.j4n_Members[3], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#4 ()Z ()Z</signature>
        public virtual bool markSupported()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.InputStream.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 ()I ()I</signature>
        public virtual int read()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.InputStream.j4n_Members[5]);
            }
        }
        
        /// <signature>#6 ([B)I ([B)I</signature>
        public virtual int read(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.io.InputStream.j4n_Members[6], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#7 ([BII)I ([BII)I</signature>
        public virtual int read(byte[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallIntMethod(this, java.io.InputStream.j4n_Members[7], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#8 ()V ()V</signature>
        public virtual void reset()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.InputStream.j4n_Members[8]);
            }
        }
        
        /// <signature>#9 (J)J (J)J</signature>
        public virtual long skip(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallLongMethod(this, java.io.InputStream.j4n_Members[9], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.InputStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.InputStream";
                    proxyInfo.JVMStaticApiName = "java_.io.InputStream_";
                    proxyInfo.CLRApi = typeof(java.io.InputStream);
                    proxyInfo.CLRStaticApi = typeof(java.io.InputStream);
                    proxyInfo.CLRProxy = typeof(java.io.InputStream);
                    proxyInfo.JVMProxyFactory = java.io.InputStream.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("available","()I", false, false), // #1 ()I
                        new global::net.sf.jni4net.core.MemberId("close","()V", false, false), // #2 ()V
                        new global::net.sf.jni4net.core.MemberId("mark","(I)V", false, false), // #3 (I)V
                        new global::net.sf.jni4net.core.MemberId("markSupported","()Z", false, false), // #4 ()Z
                        new global::net.sf.jni4net.core.MemberId("read","()I", false, false), // #5 ()I
                        new global::net.sf.jni4net.core.MemberId("read","([B)I", false, false), // #6 ([B)I
                        new global::net.sf.jni4net.core.MemberId("read","([BII)I", false, false), // #7 ([BII)I
                        new global::net.sf.jni4net.core.MemberId("reset","()V", false, false), // #8 ()V
                        new global::net.sf.jni4net.core.MemberId("skip","(J)J", false, false), // #9 (J)J
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
