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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.System))]
    public sealed partial class System : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private System(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.System(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static System()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.System));
        }
        
        /// <signature>#0 (Ljava/lang/Object;ILjava/lang/Object;II)V (Lsystem/Object;ILsystem/Object;II)V</signature>
        static public void arraycopy(object par0, int par1, object par2, int par3, int par4)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par3), global::net.sf.jni4net.core.ConvertInt.ToValue(par4));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static public string clearProperty(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 ()J ()J</signature>
        static public long currentTimeMillis()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStaticLongMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[2]);
            }
        }
        
        static public global::java.io.PrintStream err {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.GetStaticObjectField(java.lang.System.j4n_Class, java.lang.System.j4n_Members[3]));
                }
            }
        }
        
        /// <signature>#4 (I)V (I)V</signature>
        static public void exit(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[4], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#5 ()V ()V</signature>
        static public void gc()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[5]);
            }
        }
        
        /// <signature>#6 ()Ljava/util/Map; ()Ljava/util/Map;</signature>
        static public global::java.util.Map getenv()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Map>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[6]));
            }
        }
        
        /// <signature>#7 (Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static public string getenv(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[7], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#8 ()Ljava/util/Properties; ()Ljava/util/Properties;</signature>
        static public global::java.util.Properties getProperties()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Properties>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 (Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static public string getProperty(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[9], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#10 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;Lsystem/String;)Lsystem/String;</signature>
        static public string getProperty(string par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticStringMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[10], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#11 ()Ljava/lang/SecurityManager; ()Ljava/lang/Object;</signature>
        static public global::java.lang.Object getSecurityManager()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[11]));
            }
        }
        
        /// <signature>#12 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static public int identityHashCode(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        static public global::java.io.InputStream @in {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.InputStream>(j4n_env, j4n_env.GetStaticObjectField(java.lang.System.j4n_Class, java.lang.System.j4n_Members[13]));
                }
            }
        }
        
        /// <signature>#14 ()Ljava/nio/channels/Channel; ()Ljava/io/Closeable;</signature>
        static public global::java.io.Closeable inheritedChannel()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.Closeable>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[14]));
            }
        }
        
        /// <signature>#15 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static public void load(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[15], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#16 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static public void loadLibrary(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[16], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#17 (Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static public string mapLibraryName(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[17], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#18 ()J ()J</signature>
        static public long nanoTime()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStaticLongMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[18]);
            }
        }
        
        static public global::java.io.PrintStream @out {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.PrintStream>(j4n_env, j4n_env.GetStaticObjectField(java.lang.System.j4n_Class, java.lang.System.j4n_Members[19]));
                }
            }
        }
        
        /// <signature>#20 ()V ()V</signature>
        static public void runFinalization()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[20]);
            }
        }
        
        /// <signature>#21 (Z)V (Z)V</signature>
        static public void runFinalizersOnExit(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[21], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        /// <signature>#22 (Ljava/io/PrintStream;)V (Ljava/io/PrintStream;)V</signature>
        static public void setErr(global::java.io.PrintStream par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[22], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.PrintStream"));
            }
        }
        
        /// <signature>#23 (Ljava/io/InputStream;)V (Ljava/io/InputStream;)V</signature>
        static public void setIn(global::java.io.InputStream par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[23], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.InputStream"));
            }
        }
        
        /// <signature>#24 (Ljava/io/PrintStream;)V (Ljava/io/PrintStream;)V</signature>
        static public void setOut(global::java.io.PrintStream par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[24], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.PrintStream"));
            }
        }
        
        /// <signature>#25 (Ljava/util/Properties;)V (Ljava/util/Properties;)V</signature>
        static public void setProperties(global::java.util.Properties par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[25], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Properties"));
            }
        }
        
        /// <signature>#26 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;Lsystem/String;)Lsystem/String;</signature>
        static public string setProperty(string par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticStringMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[26], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#27 (Ljava/lang/SecurityManager;)V (Ljava/lang/Object;)V</signature>
        static public void setSecurityManager(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallStaticVoidMethod(java.lang.System.j4n_Class, java.lang.System.j4n_Members[27], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.SecurityManager"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.System))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.System";
                    proxyInfo.JVMStaticApiName = "java_.lang.System_";
                    proxyInfo.CLRApi = typeof(java.lang.System);
                    proxyInfo.CLRStaticApi = typeof(java.lang.System);
                    proxyInfo.CLRProxy = typeof(java.lang.System);
                    proxyInfo.JVMProxyFactory = java.lang.System.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V", false, true), // #0 (Lsystem/Object;ILsystem/Object;II)V
                        new global::net.sf.jni4net.core.MemberId("clearProperty","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #1 (Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("currentTimeMillis","()J", false, true), // #2 ()J
                        new global::net.sf.jni4net.core.MemberId("err","Ljava/io/PrintStream;", true, true), // #3 ()Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("exit","(I)V", false, true), // #4 (I)V
                        new global::net.sf.jni4net.core.MemberId("gc","()V", false, true), // #5 ()V
                        new global::net.sf.jni4net.core.MemberId("getenv","()Ljava/util/Map;", false, true), // #6 ()Ljava/util/Map;
                        new global::net.sf.jni4net.core.MemberId("getenv","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #7 (Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getProperties","()Ljava/util/Properties;", false, true), // #8 ()Ljava/util/Properties;
                        new global::net.sf.jni4net.core.MemberId("getProperty","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #9 (Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getProperty","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, true), // #10 (Lsystem/String;Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getSecurityManager","()Ljava/lang/SecurityManager;", false, true), // #11 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("identityHashCode","(Ljava/lang/Object;)I", false, true), // #12 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("in","Ljava/io/InputStream;", true, true), // #13 ()Ljava/io/InputStream;
                        new global::net.sf.jni4net.core.MemberId("inheritedChannel","()Ljava/nio/channels/Channel;", false, true), // #14 ()Ljava/io/Closeable;
                        new global::net.sf.jni4net.core.MemberId("load","(Ljava/lang/String;)V", false, true), // #15 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("loadLibrary","(Ljava/lang/String;)V", false, true), // #16 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("mapLibraryName","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #17 (Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("nanoTime","()J", false, true), // #18 ()J
                        new global::net.sf.jni4net.core.MemberId("out","Ljava/io/PrintStream;", true, true), // #19 ()Ljava/io/PrintStream;
                        new global::net.sf.jni4net.core.MemberId("runFinalization","()V", false, true), // #20 ()V
                        new global::net.sf.jni4net.core.MemberId("runFinalizersOnExit","(Z)V", false, true), // #21 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setErr","(Ljava/io/PrintStream;)V", false, true), // #22 (Ljava/io/PrintStream;)V
                        new global::net.sf.jni4net.core.MemberId("setIn","(Ljava/io/InputStream;)V", false, true), // #23 (Ljava/io/InputStream;)V
                        new global::net.sf.jni4net.core.MemberId("setOut","(Ljava/io/PrintStream;)V", false, true), // #24 (Ljava/io/PrintStream;)V
                        new global::net.sf.jni4net.core.MemberId("setProperties","(Ljava/util/Properties;)V", false, true), // #25 (Ljava/util/Properties;)V
                        new global::net.sf.jni4net.core.MemberId("setProperty","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, true), // #26 (Lsystem/String;Lsystem/String;)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("setSecurityManager","(Ljava/lang/SecurityManager;)V", false, true), // #27 (Ljava/lang/Object;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
