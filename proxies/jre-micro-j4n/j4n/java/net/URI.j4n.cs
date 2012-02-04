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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.net.URI))]
    public sealed partial class URI : global::java.lang.Object, global::java.lang.Comparable, global::java.io.Serializable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private URI(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.net.URI(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static URI()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.net.URI));
        }
        
        /// <signature>#0 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public URI(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URI.j4n_Class, java.net.URI.j4n_Members[0], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V (Lsystem/String;Lsystem/String;Lsystem/String;)V</signature>
        public URI(string par0, string par1, string par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URI.j4n_Class, java.net.URI.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V (Lsystem/String;Lsystem/String;Lsystem/String;ILsystem/String;Lsystem/String;Lsystem/String;)V</signature>
        public URI(string par0, string par1, string par2, int par3, string par4, string par5, string par6)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 24))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URI.j4n_Class, java.net.URI.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2), global::net.sf.jni4net.core.ConvertInt.ToValue(par3), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par4), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par5), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par6));
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V (Lsystem/String;Lsystem/String;Lsystem/String;Lsystem/String;)V</signature>
        public URI(string par0, string par1, string par2, string par3)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URI.j4n_Class, java.net.URI.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par3));
            }
        }
        
        /// <signature>#4 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V (Lsystem/String;Lsystem/String;Lsystem/String;Lsystem/String;Lsystem/String;)V</signature>
        public URI(string par0, string par1, string par2, string par3, string par4)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URI.j4n_Class, java.net.URI.j4n_Members[4], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par3), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par4));
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;)Ljava/net/URI; (Lsystem/String;)Ljava/net/URI;</signature>
        static public global::java.net.URI create(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URI>(j4n_env, j4n_env.CallStaticObjectMethod(java.net.URI.j4n_Class, java.net.URI.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#6 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.net.URI.j4n_Members[6], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#7 (Ljava/net/URI;)I (Ljava/net/URI;)I</signature>
        public int compareTo(global::java.net.URI par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.net.URI.j4n_Members[7], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#8 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getAuthority()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[8]);
            }
        }
        
        /// <signature>#9 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getFragment()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[9]);
            }
        }
        
        /// <signature>#10 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getHost()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getPath()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[11]);
            }
        }
        
        /// <signature>#12 ()I ()I</signature>
        public int getPort()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.net.URI.j4n_Members[12]);
            }
        }
        
        /// <signature>#13 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getQuery()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[13]);
            }
        }
        
        /// <signature>#14 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getRawAuthority()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[14]);
            }
        }
        
        /// <signature>#15 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getRawFragment()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[15]);
            }
        }
        
        /// <signature>#16 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getRawPath()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[16]);
            }
        }
        
        /// <signature>#17 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getRawQuery()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[17]);
            }
        }
        
        /// <signature>#18 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getRawSchemeSpecificPart()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[18]);
            }
        }
        
        /// <signature>#19 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getRawUserInfo()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[19]);
            }
        }
        
        /// <signature>#20 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getScheme()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[20]);
            }
        }
        
        /// <signature>#21 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getSchemeSpecificPart()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[21]);
            }
        }
        
        /// <signature>#22 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getUserInfo()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[22]);
            }
        }
        
        /// <signature>#23 ()Z ()Z</signature>
        public bool isAbsolute()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.net.URI.j4n_Members[23]);
            }
        }
        
        /// <signature>#24 ()Z ()Z</signature>
        public bool isOpaque()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.net.URI.j4n_Members[24]);
            }
        }
        
        /// <signature>#25 ()Ljava/net/URI; ()Ljava/net/URI;</signature>
        public global::java.net.URI normalize()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URI>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URI.j4n_Members[25]));
            }
        }
        
        /// <signature>#26 ()Ljava/net/URI; ()Ljava/net/URI;</signature>
        public global::java.net.URI parseServerAuthority()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URI>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URI.j4n_Members[26]));
            }
        }
        
        /// <signature>#27 (Ljava/net/URI;)Ljava/net/URI; (Ljava/net/URI;)Ljava/net/URI;</signature>
        public global::java.net.URI relativize(global::java.net.URI par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URI>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URI.j4n_Members[27], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#28 (Ljava/lang/String;)Ljava/net/URI; (Lsystem/String;)Ljava/net/URI;</signature>
        public global::java.net.URI resolve(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URI>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URI.j4n_Members[28], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#29 (Ljava/net/URI;)Ljava/net/URI; (Ljava/net/URI;)Ljava/net/URI;</signature>
        public global::java.net.URI resolve(global::java.net.URI par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URI>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URI.j4n_Members[29], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#30 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string toASCIIString()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.net.URI.j4n_Members[30]);
            }
        }
        
        /// <signature>#31 ()Ljava/net/URL; ()Ljava/net/URL;</signature>
        public global::java.net.URL toURL()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URL>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URI.j4n_Members[31]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.net.URI))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.net.URI";
                    proxyInfo.JVMStaticApiName = "java_.net.URI_";
                    proxyInfo.CLRApi = typeof(java.net.URI);
                    proxyInfo.CLRStaticApi = typeof(java.net.URI);
                    proxyInfo.CLRProxy = typeof(java.net.URI);
                    proxyInfo.JVMProxyFactory = java.net.URI.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #0 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", false, false), // #1 (Lsystem/String;Lsystem/String;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", false, false), // #2 (Lsystem/String;Lsystem/String;Lsystem/String;ILsystem/String;Lsystem/String;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", false, false), // #3 (Lsystem/String;Lsystem/String;Lsystem/String;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", false, false), // #4 (Lsystem/String;Lsystem/String;Lsystem/String;Lsystem/String;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("create","(Ljava/lang/String;)Ljava/net/URI;", false, true), // #5 (Lsystem/String;)Ljava/net/URI;
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #6 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/net/URI;)I", false, false), // #7 (Ljava/net/URI;)I
                        new global::net.sf.jni4net.core.MemberId("getAuthority","()Ljava/lang/String;", false, false), // #8 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getFragment","()Ljava/lang/String;", false, false), // #9 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getHost","()Ljava/lang/String;", false, false), // #10 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getPath","()Ljava/lang/String;", false, false), // #11 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getPort","()I", false, false), // #12 ()I
                        new global::net.sf.jni4net.core.MemberId("getQuery","()Ljava/lang/String;", false, false), // #13 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getRawAuthority","()Ljava/lang/String;", false, false), // #14 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getRawFragment","()Ljava/lang/String;", false, false), // #15 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getRawPath","()Ljava/lang/String;", false, false), // #16 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getRawQuery","()Ljava/lang/String;", false, false), // #17 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getRawSchemeSpecificPart","()Ljava/lang/String;", false, false), // #18 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getRawUserInfo","()Ljava/lang/String;", false, false), // #19 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getScheme","()Ljava/lang/String;", false, false), // #20 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getSchemeSpecificPart","()Ljava/lang/String;", false, false), // #21 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getUserInfo","()Ljava/lang/String;", false, false), // #22 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("isAbsolute","()Z", false, false), // #23 ()Z
                        new global::net.sf.jni4net.core.MemberId("isOpaque","()Z", false, false), // #24 ()Z
                        new global::net.sf.jni4net.core.MemberId("normalize","()Ljava/net/URI;", false, false), // #25 ()Ljava/net/URI;
                        new global::net.sf.jni4net.core.MemberId("parseServerAuthority","()Ljava/net/URI;", false, false), // #26 ()Ljava/net/URI;
                        new global::net.sf.jni4net.core.MemberId("relativize","(Ljava/net/URI;)Ljava/net/URI;", false, false), // #27 (Ljava/net/URI;)Ljava/net/URI;
                        new global::net.sf.jni4net.core.MemberId("resolve","(Ljava/lang/String;)Ljava/net/URI;", false, false), // #28 (Lsystem/String;)Ljava/net/URI;
                        new global::net.sf.jni4net.core.MemberId("resolve","(Ljava/net/URI;)Ljava/net/URI;", false, false), // #29 (Ljava/net/URI;)Ljava/net/URI;
                        new global::net.sf.jni4net.core.MemberId("toASCIIString","()Ljava/lang/String;", false, false), // #30 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("toURL","()Ljava/net/URL;", false, false), // #31 ()Ljava/net/URL;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
