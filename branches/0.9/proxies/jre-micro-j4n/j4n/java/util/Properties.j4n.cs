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

namespace java.util
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Properties))]
    public partial class Properties : global::java.util.Hashtable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected Properties(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util.Properties(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Properties()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.util.Hashtable));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Properties));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Properties()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.Properties.j4n_Class, java.util.Properties.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 (Ljava/util/Properties;)V (Ljava/util/Properties;)V</signature>
        public Properties(global::java.util.Properties par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.Properties.j4n_Class, java.util.Properties.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Properties"));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        public virtual string getProperty(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStringMethod(this, java.util.Properties.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;Lsystem/String;)Lsystem/String;</signature>
        public virtual string getProperty(string par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStringMethod(this, java.util.Properties.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#4 (Ljava/io/PrintStream;)V (Ljava/io/PrintStream;)V</signature>
        public virtual void list(global::java.io.PrintStream par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.Properties.j4n_Members[4], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.PrintStream"));
            }
        }
        
        /// <signature>#5 (Ljava/io/PrintWriter;)V (Ljava/io/PrintWriter;)V</signature>
        public virtual void list(global::java.io.PrintWriter par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.Properties.j4n_Members[5], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.PrintWriter"));
            }
        }
        
        /// <signature>#6 (Ljava/io/InputStream;)V (Ljava/io/InputStream;)V</signature>
        public virtual void load(global::java.io.InputStream par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.Properties.j4n_Members[6], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.InputStream"));
            }
        }
        
        /// <signature>#7 (Ljava/io/InputStream;)V (Ljava/io/InputStream;)V</signature>
        public virtual void loadFromXML(global::java.io.InputStream par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.Properties.j4n_Members[7], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.InputStream"));
            }
        }
        
        /// <signature>#8 ()Ljava/util/Enumeration; ()Ljava/util/Enumeration;</signature>
        public virtual global::java.util.Enumeration propertyNames()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Enumeration>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Properties.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 (Ljava/io/OutputStream;Ljava/lang/String;)V (Ljava/io/OutputStream;Lsystem/String;)V</signature>
        public virtual void save(global::java.io.OutputStream par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.util.Properties.j4n_Members[9], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#10 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object; (Lsystem/String;Lsystem/String;)Lsystem/Object;</signature>
        public virtual object setProperty(string par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Properties.j4n_Members[10], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#11 (Ljava/io/OutputStream;Ljava/lang/String;)V (Ljava/io/OutputStream;Lsystem/String;)V</signature>
        public virtual void store(global::java.io.OutputStream par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.util.Properties.j4n_Members[11], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#12 (Ljava/io/OutputStream;Ljava/lang/String;)V (Ljava/io/OutputStream;Lsystem/String;)V</signature>
        public virtual void storeToXML(global::java.io.OutputStream par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.util.Properties.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#13 (Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V (Ljava/io/OutputStream;Lsystem/String;Lsystem/String;)V</signature>
        public virtual void storeToXML(global::java.io.OutputStream par0, string par1, string par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallVoidMethod(this, java.util.Properties.j4n_Members[13], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par2));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.util.Properties))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.util.Properties";
                    proxyInfo.JVMStaticApiName = "java_.util.Properties_";
                    proxyInfo.CLRApi = typeof(java.util.Properties);
                    proxyInfo.CLRStaticApi = typeof(java.util.Properties);
                    proxyInfo.CLRProxy = typeof(java.util.Properties);
                    proxyInfo.JVMProxyFactory = java.util.Properties.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/util/Properties;)V", false, false), // #1 (Ljava/util/Properties;)V
                        new global::net.sf.jni4net.core.MemberId("getProperty","(Ljava/lang/String;)Ljava/lang/String;", false, false), // #2 (Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getProperty","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, false), // #3 (Lsystem/String;Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("list","(Ljava/io/PrintStream;)V", false, false), // #4 (Ljava/io/PrintStream;)V
                        new global::net.sf.jni4net.core.MemberId("list","(Ljava/io/PrintWriter;)V", false, false), // #5 (Ljava/io/PrintWriter;)V
                        new global::net.sf.jni4net.core.MemberId("load","(Ljava/io/InputStream;)V", false, false), // #6 (Ljava/io/InputStream;)V
                        new global::net.sf.jni4net.core.MemberId("loadFromXML","(Ljava/io/InputStream;)V", false, false), // #7 (Ljava/io/InputStream;)V
                        new global::net.sf.jni4net.core.MemberId("propertyNames","()Ljava/util/Enumeration;", false, false), // #8 ()Ljava/util/Enumeration;
                        new global::net.sf.jni4net.core.MemberId("save","(Ljava/io/OutputStream;Ljava/lang/String;)V", false, false), // #9 (Ljava/io/OutputStream;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("setProperty","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", false, false), // #10 (Lsystem/String;Lsystem/String;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("store","(Ljava/io/OutputStream;Ljava/lang/String;)V", false, false), // #11 (Ljava/io/OutputStream;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("storeToXML","(Ljava/io/OutputStream;Ljava/lang/String;)V", false, false), // #12 (Ljava/io/OutputStream;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("storeToXML","(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V", false, false), // #13 (Ljava/io/OutputStream;Lsystem/String;Lsystem/String;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
