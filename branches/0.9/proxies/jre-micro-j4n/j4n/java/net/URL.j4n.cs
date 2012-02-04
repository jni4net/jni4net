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

namespace java.net
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.net.URL))]
    public sealed partial class URL : global::java.lang.Object, global::java.io.Serializable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private URL(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.net.URL(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static URL()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.net.URL));
        }
        
        /// <signature>#0 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public URL(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URL.j4n_Class, java.net.URL.j4n_Members[0], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V (Lsystem/String;Lsystem/String;ILsystem/String;)V</signature>
        public URL(string par0, string par1, int par2, string par3)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URL.j4n_Class, java.net.URL.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par3));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandler;)V (Lsystem/String;Lsystem/String;ILsystem/String;Ljava/lang/Object;)V</signature>
        public URL(string par0, string par1, int par2, string par3, global::java.lang.Object par4)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URL.j4n_Class, java.net.URL.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par3), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par4, "java.net.URLStreamHandler"));
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V (Lsystem/String;Lsystem/String;Lsystem/String;)V</signature>
        public URL(string par0, string par1, string par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URL.j4n_Class, java.net.URL.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2));
            }
        }
        
        /// <signature>#4 (Ljava/net/URL;Ljava/lang/String;)V (Ljava/net/URL;Lsystem/String;)V</signature>
        public URL(global::java.net.URL par0, string par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URL.j4n_Class, java.net.URL.j4n_Members[4], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#5 (Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V (Ljava/net/URL;Lsystem/String;Ljava/lang/Object;)V</signature>
        public URL(global::java.net.URL par0, string par1, global::java.lang.Object par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URL.j4n_Class, java.net.URL.j4n_Members[5], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.net.URLStreamHandler"));
            }
        }
        
        /// <signature>#6 (Ljava/net/URLStreamHandlerFactory;)V (Ljava/lang/Object;)V</signature>
        static public void setURLStreamHandlerFactory(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.net.URL.j4n_Class, java.net.URL.j4n_Members[6], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.net.URLStreamHandlerFactory"));
            }
        }
        
        /// <signature>#7 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getAuthority()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public object getContent()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URL.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 ([Ljava/lang/Class;)Ljava/lang/Object; ([Ljava/lang/Class;)Lsystem/Object;</signature>
        public object getContent(global::java.lang.Class[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URL.j4n_Members[9], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#10 ()I ()I</signature>
        public int getDefaultPort()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.net.URL.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getFile()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[11]);
            }
        }
        
        /// <signature>#12 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getHost()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[12]);
            }
        }
        
        /// <signature>#13 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getPath()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[13]);
            }
        }
        
        /// <signature>#14 ()I ()I</signature>
        public int getPort()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.net.URL.j4n_Members[14]);
            }
        }
        
        /// <signature>#15 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getProtocol()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[15]);
            }
        }
        
        /// <signature>#16 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getQuery()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[16]);
            }
        }
        
        /// <signature>#17 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getRef()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[17]);
            }
        }
        
        /// <signature>#18 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getUserInfo()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[18]);
            }
        }
        
        /// <signature>#19 ()Ljava/net/URLConnection; ()Ljava/lang/Object;</signature>
        public global::java.lang.Object openConnection()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URL.j4n_Members[19]));
            }
        }
        
        /// <signature>#20 (Ljava/net/Proxy;)Ljava/net/URLConnection; (Ljava/lang/Object;)Ljava/lang/Object;</signature>
        public global::java.lang.Object openConnection(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URL.j4n_Members[20], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.net.Proxy")));
            }
        }
        
        /// <signature>#21 ()Ljava/io/InputStream; ()Ljava/io/InputStream;</signature>
        public global::java.io.InputStream openStream()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.InputStream>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URL.j4n_Members[21]));
            }
        }
        
        /// <signature>#22 (Ljava/net/URL;)Z (Ljava/net/URL;)Z</signature>
        public bool sameFile(global::java.net.URL par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.net.URL.j4n_Members[22], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#23 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string toExternalForm()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URL.j4n_Members[23]);
            }
        }
        
        /// <signature>#24 ()Ljava/net/URI; ()Ljava/net/URI;</signature>
        public global::java.net.URI toURI()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URI>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URL.j4n_Members[24]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.net.URL))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.net.URL";
                    proxyInfo.JVMStaticApiName = "java_.net.URL_";
                    proxyInfo.CLRApi = typeof(java.net.URL);
                    proxyInfo.CLRStaticApi = typeof(java.net.URL);
                    proxyInfo.CLRProxy = typeof(java.net.URL);
                    proxyInfo.JVMProxyFactory = java.net.URL.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #0 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", false, false), // #1 (Lsystem/String;Lsystem/String;ILsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandler;)V", false, false), // #2 (Lsystem/String;Lsystem/String;ILsystem/String;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", false, false), // #3 (Lsystem/String;Lsystem/String;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/net/URL;Ljava/lang/String;)V", false, false), // #4 (Ljava/net/URL;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V", false, false), // #5 (Ljava/net/URL;Lsystem/String;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("setURLStreamHandlerFactory","(Ljava/net/URLStreamHandlerFactory;)V", false, true), // #6 (Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("getAuthority","()Ljava/lang/String;", false, false), // #7 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getContent","()Ljava/lang/Object;", false, false), // #8 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getContent","([Ljava/lang/Class;)Ljava/lang/Object;", false, false), // #9 ([Ljava/lang/Class;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getDefaultPort","()I", false, false), // #10 ()I
                        new global::net.sf.jni4net.core.MemberId("getFile","()Ljava/lang/String;", false, false), // #11 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getHost","()Ljava/lang/String;", false, false), // #12 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getPath","()Ljava/lang/String;", false, false), // #13 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getPort","()I", false, false), // #14 ()I
                        new global::net.sf.jni4net.core.MemberId("getProtocol","()Ljava/lang/String;", false, false), // #15 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getQuery","()Ljava/lang/String;", false, false), // #16 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getRef","()Ljava/lang/String;", false, false), // #17 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getUserInfo","()Ljava/lang/String;", false, false), // #18 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("openConnection","()Ljava/net/URLConnection;", false, false), // #19 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("openConnection","(Ljava/net/Proxy;)Ljava/net/URLConnection;", false, false), // #20 (Ljava/lang/Object;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("openStream","()Ljava/io/InputStream;", false, false), // #21 ()Ljava/io/InputStream;
                        new global::net.sf.jni4net.core.MemberId("sameFile","(Ljava/net/URL;)Z", false, false), // #22 (Ljava/net/URL;)Z
                        new global::net.sf.jni4net.core.MemberId("toExternalForm","()Ljava/lang/String;", false, false), // #23 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toURI","()Ljava/net/URI;", false, false), // #24 ()Ljava/net/URI;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
