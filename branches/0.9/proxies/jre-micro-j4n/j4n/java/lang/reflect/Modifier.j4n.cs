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

namespace java.lang.reflect
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.Modifier))]
    public partial class Modifier : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected Modifier(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect.Modifier(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Modifier()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.Modifier));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Modifier()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[0]);
            }
        }
        
        static public int ABSTRACT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[1]);
                }
            }
        }
        
        static public int FINAL {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[2]);
                }
            }
        }
        
        static public int INTERFACE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[3]);
                }
            }
        }
        
        /// <signature>#4 (I)Z (I)Z</signature>
        static public bool isAbstract(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[4], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#5 (I)Z (I)Z</signature>
        static public bool isFinal(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[5], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#6 (I)Z (I)Z</signature>
        static public bool isInterface(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[6], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#7 (I)Z (I)Z</signature>
        static public bool isNative(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[7], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#8 (I)Z (I)Z</signature>
        static public bool isPrivate(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[8], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#9 (I)Z (I)Z</signature>
        static public bool isProtected(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[9], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#10 (I)Z (I)Z</signature>
        static public bool isPublic(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[10], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#11 (I)Z (I)Z</signature>
        static public bool isStatic(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[11], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#12 (I)Z (I)Z</signature>
        static public bool isStrict(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[12], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#13 (I)Z (I)Z</signature>
        static public bool isSynchronized(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[13], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#14 (I)Z (I)Z</signature>
        static public bool isTransient(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[14], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#15 (I)Z (I)Z</signature>
        static public bool isVolatile(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[15], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        static public int NATIVE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[16]);
                }
            }
        }
        
        static public int PRIVATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[17]);
                }
            }
        }
        
        static public int PROTECTED {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[18]);
                }
            }
        }
        
        static public int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[19]);
                }
            }
        }
        
        static public int STATIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[20]);
                }
            }
        }
        
        static public int STRICT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[21]);
                }
            }
        }
        
        static public int SYNCHRONIZED {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[22]);
                }
            }
        }
        
        /// <signature>#23 (I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static public string toString(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticStringMethod(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[23], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        static public int TRANSIENT {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[24]);
                }
            }
        }
        
        static public int VOLATILE {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.lang.reflect.Modifier.j4n_Class, java.lang.reflect.Modifier.j4n_Members[25]);
                }
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.reflect.Modifier))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.reflect.Modifier";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.Modifier_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.Modifier);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.Modifier);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect.Modifier);
                    proxyInfo.JVMProxyFactory = java.lang.reflect.Modifier.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("ABSTRACT","I", true, true), // #1 ()I
                        new global::net.sf.jni4net.core.MemberId("FINAL","I", true, true), // #2 ()I
                        new global::net.sf.jni4net.core.MemberId("INTERFACE","I", true, true), // #3 ()I
                        new global::net.sf.jni4net.core.MemberId("isAbstract","(I)Z", false, true), // #4 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isFinal","(I)Z", false, true), // #5 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isInterface","(I)Z", false, true), // #6 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isNative","(I)Z", false, true), // #7 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isPrivate","(I)Z", false, true), // #8 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isProtected","(I)Z", false, true), // #9 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isPublic","(I)Z", false, true), // #10 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isStatic","(I)Z", false, true), // #11 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isStrict","(I)Z", false, true), // #12 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isSynchronized","(I)Z", false, true), // #13 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isTransient","(I)Z", false, true), // #14 (I)Z
                        new global::net.sf.jni4net.core.MemberId("isVolatile","(I)Z", false, true), // #15 (I)Z
                        new global::net.sf.jni4net.core.MemberId("NATIVE","I", true, true), // #16 ()I
                        new global::net.sf.jni4net.core.MemberId("PRIVATE","I", true, true), // #17 ()I
                        new global::net.sf.jni4net.core.MemberId("PROTECTED","I", true, true), // #18 ()I
                        new global::net.sf.jni4net.core.MemberId("PUBLIC","I", true, true), // #19 ()I
                        new global::net.sf.jni4net.core.MemberId("STATIC","I", true, true), // #20 ()I
                        new global::net.sf.jni4net.core.MemberId("STRICT","I", true, true), // #21 ()I
                        new global::net.sf.jni4net.core.MemberId("SYNCHRONIZED","I", true, true), // #22 ()I
                        new global::net.sf.jni4net.core.MemberId("toString","(I)Ljava/lang/String;", false, true), // #23 (I)Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("TRANSIENT","I", true, true), // #24 ()I
                        new global::net.sf.jni4net.core.MemberId("VOLATILE","I", true, true), // #25 ()I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
