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

namespace java.util.zip
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.zip.InflaterInputStream))]
    public partial class InflaterInputStream : global::java.io.FilterInputStream
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected InflaterInputStream(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util.zip.InflaterInputStream(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static InflaterInputStream()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.FilterInputStream));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.zip.InflaterInputStream));
        }
        
        /// <signature>#0 (Ljava/io/InputStream;)V (Ljava/io/InputStream;)V</signature>
        public InflaterInputStream(global::java.io.InputStream par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.zip.InflaterInputStream.j4n_Class, java.util.zip.InflaterInputStream.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.InputStream"));
            }
        }
        
        /// <signature>#1 (Ljava/io/InputStream;Ljava/util/zip/Inflater;)V (Ljava/io/InputStream;Ljava/lang/Object;)V</signature>
        public InflaterInputStream(global::java.io.InputStream par0, global::java.lang.Object par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.zip.InflaterInputStream.j4n_Class, java.util.zip.InflaterInputStream.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.InputStream"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.util.zip.Inflater"));
            }
        }
        
        /// <signature>#2 (Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V (Ljava/io/InputStream;Ljava/lang/Object;I)V</signature>
        public InflaterInputStream(global::java.io.InputStream par0, global::java.lang.Object par1, int par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.zip.InflaterInputStream.j4n_Class, java.util.zip.InflaterInputStream.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.InputStream"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.util.zip.Inflater"), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.util.zip.InflaterInputStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.util.zip.InflaterInputStream";
                    proxyInfo.JVMStaticApiName = "java_.util.zip.InflaterInputStream_";
                    proxyInfo.CLRApi = typeof(java.util.zip.InflaterInputStream);
                    proxyInfo.CLRStaticApi = typeof(java.util.zip.InflaterInputStream);
                    proxyInfo.CLRProxy = typeof(java.util.zip.InflaterInputStream);
                    proxyInfo.JVMProxyFactory = java.util.zip.InflaterInputStream.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/InputStream;)V", false, false), // #0 (Ljava/io/InputStream;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V", false, false), // #1 (Ljava/io/InputStream;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V", false, false), // #2 (Ljava/io/InputStream;Ljava/lang/Object;I)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
