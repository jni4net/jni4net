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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.net.URLClassLoader))]
    public partial class URLClassLoader : global::java.security.SecureClassLoader
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected URLClassLoader(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.net.URLClassLoader(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static URLClassLoader()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.security.SecureClassLoader));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.net.URLClassLoader));
        }
        
        /// <signature>#0 ([Ljava/net/URL;)V ([Ljava/net/URL;)V</signature>
        public URLClassLoader(global::java.net.URL[] par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URLClassLoader.j4n_Class, java.net.URLClassLoader.j4n_Members[0], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#1 ([Ljava/net/URL;Ljava/lang/ClassLoader;)V ([Ljava/net/URL;Ljava/lang/ClassLoader;)V</signature>
        public URLClassLoader(global::java.net.URL[] par0, global::java.lang.ClassLoader par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URLClassLoader.j4n_Class, java.net.URLClassLoader.j4n_Members[1], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.ClassLoader"));
            }
        }
        
        /// <signature>#2 ([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/net/URLStreamHandlerFactory;)V ([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/lang/Object;)V</signature>
        public URLClassLoader(global::java.net.URL[] par0, global::java.lang.ClassLoader par1, global::java.lang.Object par2)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_handle = j4n_env.NewObjectG(java.net.URLClassLoader.j4n_Class, java.net.URLClassLoader.j4n_Members[2], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.ClassLoader"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.net.URLStreamHandlerFactory"));
            }
        }
        
        /// <signature>#3 ([Ljava/net/URL;)Ljava/net/URLClassLoader; ([Ljava/net/URL;)Ljava/net/URLClassLoader;</signature>
        static public global::java.net.URLClassLoader newInstance(global::java.net.URL[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.net.URLClassLoader>(j4n_env, j4n_env.CallStaticObjectMethod(java.net.URLClassLoader.j4n_Class, java.net.URLClassLoader.j4n_Members[3], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#4 ([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader; ([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader;</signature>
        static public global::java.net.URLClassLoader newInstance(global::java.net.URL[] par0, global::java.lang.ClassLoader par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.net.URLClassLoader>(j4n_env, j4n_env.CallStaticObjectMethod(java.net.URLClassLoader.j4n_Class, java.net.URLClassLoader.j4n_Members[4], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.ClassLoader")));
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;)Ljava/net/URL; (Lsystem/String;)Ljava/net/URL;</signature>
        public virtual global::java.net.URL findResource(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URL>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URLClassLoader.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#6 (Ljava/lang/String;)Ljava/util/Enumeration; (Lsystem/String;)Ljava/util/Enumeration;</signature>
        public virtual global::java.util.Enumeration findResources(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Enumeration>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URLClassLoader.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#7 ()[Ljava/net/URL; ()[Ljava/net/URL;</signature>
        public virtual global::java.net.URL[] getURLs()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.net.URL>(j4n_env, j4n_env.CallObjectMethod(this, java.net.URLClassLoader.j4n_Members[7]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.net.URLClassLoader))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.net.URLClassLoader";
                    proxyInfo.JVMStaticApiName = "java_.net.URLClassLoader_";
                    proxyInfo.CLRApi = typeof(java.net.URLClassLoader);
                    proxyInfo.CLRStaticApi = typeof(java.net.URLClassLoader);
                    proxyInfo.CLRProxy = typeof(java.net.URLClassLoader);
                    proxyInfo.JVMProxyFactory = java.net.URLClassLoader.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","([Ljava/net/URL;)V", false, false), // #0 ([Ljava/net/URL;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([Ljava/net/URL;Ljava/lang/ClassLoader;)V", false, false), // #1 ([Ljava/net/URL;Ljava/lang/ClassLoader;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/net/URLStreamHandlerFactory;)V", false, false), // #2 ([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("newInstance","([Ljava/net/URL;)Ljava/net/URLClassLoader;", false, true), // #3 ([Ljava/net/URL;)Ljava/net/URLClassLoader;
                        new global::net.sf.jni4net.core.MemberId("newInstance","([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader;", false, true), // #4 ([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader;
                        new global::net.sf.jni4net.core.MemberId("findResource","(Ljava/lang/String;)Ljava/net/URL;", false, false), // #5 (Lsystem/String;)Ljava/net/URL;
                        new global::net.sf.jni4net.core.MemberId("findResources","(Ljava/lang/String;)Ljava/util/Enumeration;", false, false), // #6 (Lsystem/String;)Ljava/util/Enumeration;
                        new global::net.sf.jni4net.core.MemberId("getURLs","()[Ljava/net/URL;", false, false), // #7 ()[Ljava/net/URL;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
