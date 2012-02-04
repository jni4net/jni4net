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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.OutputStream))]
    public partial class OutputStream : global::java.lang.Object, global::java.io.Closeable, global::java.io.Flushable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected OutputStream(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.OutputStream(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static OutputStream()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Closeable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Closeable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Flushable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Flushable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.OutputStream));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public OutputStream()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.OutputStream.j4n_Class, java.io.OutputStream.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()V ()V</signature>
        public virtual void close()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.OutputStream.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 ()V ()V</signature>
        public virtual void flush()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.OutputStream.j4n_Members[2]);
            }
        }
        
        /// <signature>#3 ([B)V ([B)V</signature>
        public virtual void write(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.OutputStream.j4n_Members[3], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#4 ([BII)V ([BII)V</signature>
        public virtual void write(byte[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallVoidMethod(this, java.io.OutputStream.j4n_Members[4], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#5 (I)V (I)V</signature>
        public virtual void write(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.OutputStream.j4n_Members[5], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.OutputStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.OutputStream";
                    proxyInfo.JVMStaticApiName = "java_.io.OutputStream_";
                    proxyInfo.CLRApi = typeof(java.io.OutputStream);
                    proxyInfo.CLRStaticApi = typeof(java.io.OutputStream);
                    proxyInfo.CLRProxy = typeof(java.io.OutputStream);
                    proxyInfo.JVMProxyFactory = java.io.OutputStream.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("close","()V", false, false), // #1 ()V
                        new global::net.sf.jni4net.core.MemberId("flush","()V", false, false), // #2 ()V
                        new global::net.sf.jni4net.core.MemberId("write","([B)V", false, false), // #3 ([B)V
                        new global::net.sf.jni4net.core.MemberId("write","([BII)V", false, false), // #4 ([BII)V
                        new global::net.sf.jni4net.core.MemberId("write","(I)V", false, false), // #5 (I)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
