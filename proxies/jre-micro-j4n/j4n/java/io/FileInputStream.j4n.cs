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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.FileInputStream))]
    public partial class FileInputStream : global::java.io.InputStream
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected FileInputStream(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.FileInputStream(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static FileInputStream()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.InputStream));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.FileInputStream));
        }
        
        /// <signature>#0 (Ljava/io/File;)V (Ljava/io/File;)V</signature>
        public FileInputStream(global::java.io.File par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.FileInputStream.j4n_Class, java.io.FileInputStream.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.File"));
            }
        }
        
        /// <signature>#1 (Ljava/io/FileDescriptor;)V (Ljava/lang/Object;)V</signature>
        public FileInputStream(global::java.lang.Object par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.FileInputStream.j4n_Class, java.io.FileInputStream.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.FileDescriptor"));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public FileInputStream(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.FileInputStream.j4n_Class, java.io.FileInputStream.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#3 ()Ljava/nio/channels/FileChannel; ()Ljava/io/Closeable;</signature>
        public virtual global::java.io.Closeable getChannel()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.Closeable>(j4n_env, j4n_env.CallObjectMethod(this, java.io.FileInputStream.j4n_Members[3]));
            }
        }
        
        /// <signature>#4 ()Ljava/io/FileDescriptor; ()Ljava/lang/Object;</signature>
        public global::java.lang.Object getFD()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallObjectMethod(this, java.io.FileInputStream.j4n_Members[4]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.FileInputStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.FileInputStream";
                    proxyInfo.JVMStaticApiName = "java_.io.FileInputStream_";
                    proxyInfo.CLRApi = typeof(java.io.FileInputStream);
                    proxyInfo.CLRStaticApi = typeof(java.io.FileInputStream);
                    proxyInfo.CLRProxy = typeof(java.io.FileInputStream);
                    proxyInfo.JVMProxyFactory = java.io.FileInputStream.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/File;)V", false, false), // #0 (Ljava/io/File;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/FileDescriptor;)V", false, false), // #1 (Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #2 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("getChannel","()Ljava/nio/channels/FileChannel;", false, false), // #3 ()Ljava/io/Closeable;
                        new global::net.sf.jni4net.core.MemberId("getFD","()Ljava/io/FileDescriptor;", false, false), // #4 ()Ljava/lang/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
