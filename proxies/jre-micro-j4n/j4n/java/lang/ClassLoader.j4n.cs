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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.ClassLoader))]
    public partial class ClassLoader : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected ClassLoader(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.ClassLoader(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static ClassLoader()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.ClassLoader));
        }
        
        /// <signature>#0 ()Ljava/lang/ClassLoader; ()Ljava/lang/ClassLoader;</signature>
        static public global::java.lang.ClassLoader getSystemClassLoader()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.ClassLoader>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.ClassLoader.j4n_Class, java.lang.ClassLoader.j4n_Members[0]));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)Ljava/net/URL; (Lsystem/String;)Ljava/net/URL;</signature>
        static public global::java.net.URL getSystemResource(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URL>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.ClassLoader.j4n_Class, java.lang.ClassLoader.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;)Ljava/io/InputStream; (Lsystem/String;)Ljava/io/InputStream;</signature>
        static public global::java.io.InputStream getSystemResourceAsStream(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.InputStream>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.ClassLoader.j4n_Class, java.lang.ClassLoader.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;)Ljava/util/Enumeration; (Lsystem/String;)Ljava/util/Enumeration;</signature>
        static public global::java.util.Enumeration getSystemResources(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Enumeration>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.ClassLoader.j4n_Class, java.lang.ClassLoader.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#4 ()V ()V</signature>
        public virtual void clearAssertionStatus()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.lang.ClassLoader.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 ()Ljava/lang/ClassLoader; ()Ljava/lang/ClassLoader;</signature>
        public global::java.lang.ClassLoader getParent()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.ClassLoader>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.ClassLoader.j4n_Members[5]));
            }
        }
        
        /// <signature>#6 (Ljava/lang/String;)Ljava/net/URL; (Lsystem/String;)Ljava/net/URL;</signature>
        public virtual global::java.net.URL getResource(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URL>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.ClassLoader.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#7 (Ljava/lang/String;)Ljava/io/InputStream; (Lsystem/String;)Ljava/io/InputStream;</signature>
        public virtual global::java.io.InputStream getResourceAsStream(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.InputStream>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.ClassLoader.j4n_Members[7], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#8 (Ljava/lang/String;)Ljava/util/Enumeration; (Lsystem/String;)Ljava/util/Enumeration;</signature>
        public virtual global::java.util.Enumeration getResources(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Enumeration>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.ClassLoader.j4n_Members[8], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#9 (Ljava/lang/String;)Ljava/lang/Class; (Lsystem/String;)Ljava/lang/Class;</signature>
        public virtual global::java.lang.Class loadClass(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.ClassLoader.j4n_Members[9], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#10 (Ljava/lang/String;Z)V (Lsystem/String;Z)V</signature>
        public virtual void setClassAssertionStatus(string par0, bool par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.ClassLoader.j4n_Members[10], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1));
            }
        }
        
        /// <signature>#11 (Z)V (Z)V</signature>
        public virtual void setDefaultAssertionStatus(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.ClassLoader.j4n_Members[11], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        /// <signature>#12 (Ljava/lang/String;Z)V (Lsystem/String;Z)V</signature>
        public virtual void setPackageAssertionStatus(string par0, bool par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.ClassLoader.j4n_Members[12], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.ClassLoader))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.ClassLoader";
                    proxyInfo.JVMStaticApiName = "java_.lang.ClassLoader_";
                    proxyInfo.CLRApi = typeof(java.lang.ClassLoader);
                    proxyInfo.CLRStaticApi = typeof(java.lang.ClassLoader);
                    proxyInfo.CLRProxy = typeof(java.lang.ClassLoader);
                    proxyInfo.JVMProxyFactory = java.lang.ClassLoader.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getSystemClassLoader","()Ljava/lang/ClassLoader;", false, true), // #0 ()Ljava/lang/ClassLoader;
                        new global::net.sf.jni4net.core.MemberId("getSystemResource","(Ljava/lang/String;)Ljava/net/URL;", false, true), // #1 (Lsystem/String;)Ljava/net/URL;
                        new global::net.sf.jni4net.core.MemberId("getSystemResourceAsStream","(Ljava/lang/String;)Ljava/io/InputStream;", false, true), // #2 (Lsystem/String;)Ljava/io/InputStream;
                        new global::net.sf.jni4net.core.MemberId("getSystemResources","(Ljava/lang/String;)Ljava/util/Enumeration;", false, true), // #3 (Lsystem/String;)Ljava/util/Enumeration;
                        new global::net.sf.jni4net.core.MemberId("clearAssertionStatus","()V", false, false), // #4 ()V
                        new global::net.sf.jni4net.core.MemberId("getParent","()Ljava/lang/ClassLoader;", false, false), // #5 ()Ljava/lang/ClassLoader;
                        new global::net.sf.jni4net.core.MemberId("getResource","(Ljava/lang/String;)Ljava/net/URL;", false, false), // #6 (Lsystem/String;)Ljava/net/URL;
                        new global::net.sf.jni4net.core.MemberId("getResourceAsStream","(Ljava/lang/String;)Ljava/io/InputStream;", false, false), // #7 (Lsystem/String;)Ljava/io/InputStream;
                        new global::net.sf.jni4net.core.MemberId("getResources","(Ljava/lang/String;)Ljava/util/Enumeration;", false, false), // #8 (Lsystem/String;)Ljava/util/Enumeration;
                        new global::net.sf.jni4net.core.MemberId("loadClass","(Ljava/lang/String;)Ljava/lang/Class;", false, false), // #9 (Lsystem/String;)Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("setClassAssertionStatus","(Ljava/lang/String;Z)V", false, false), // #10 (Lsystem/String;Z)V
                        new global::net.sf.jni4net.core.MemberId("setDefaultAssertionStatus","(Z)V", false, false), // #11 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setPackageAssertionStatus","(Ljava/lang/String;Z)V", false, false), // #12 (Lsystem/String;Z)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
