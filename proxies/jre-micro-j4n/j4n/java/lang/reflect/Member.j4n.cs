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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.Member_))]
    public partial interface Member
    {
        /// <signature>#2 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        global::java.lang.Class getDeclaringClass();
        
        /// <signature>#3 ()I ()I</signature>
        int getModifiers();
        
        /// <signature>#4 ()Ljava/lang/String; ()Lsystem/String;</signature>
        string getName();
        
        /// <signature>#5 ()Z ()Z</signature>
        bool isSynthetic();
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.Member_))]
    static public partial class Member_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Member_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.Member_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.Member_));
        }
        
        /// <signature>#2 getDeclaringClass()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.Member j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.Member>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getDeclaringClass(), "java.lang.Class");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#3 getModifiers()I ()I</signature>
        static int j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.Member j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.Member>(j4n_env, j4n_self);
                int j4n_result = j4n_real.getModifiers();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(int);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#4 getName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.Member j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.Member>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getName(), "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#5 isSynthetic()Z ()Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.Member j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.Member>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.isSynthetic();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(bool);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.reflect.Member))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.lang.reflect.Member";
                    proxyInfo.JVMProxyName = "java_.lang.reflect._Member";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.Member_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.Member);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.Member_);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect._Member);
                    proxyInfo.JVMProxyFactory = java.lang.reflect._Member.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        null, // #0 interface static: DECLARED
                        null, // #1 interface static: PUBLIC
                        new global::net.sf.jni4net.core.MemberId("getDeclaringClass","()Ljava/lang/Class;", false, false), // #2 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getModifiers","()I", false, false), // #3 ()I
                        new global::net.sf.jni4net.core.MemberId("getName","()Ljava/lang/String;", false, false), // #4 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("isSynthetic","()Z", false, false), // #5 ()Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.Member_))]
    internal partial class _Member : global::java.lang.Object, java.lang.reflect.Member
    {
        static _Member()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.Member_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.Member_));
        }
        
        protected _Member(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect._Member(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#2 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getDeclaringClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Member_.j4n_Members[2]));
            }
        }
        
        /// <signature>#3 ()I ()I</signature>
        public int getModifiers()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.reflect.Member_.j4n_Members[3]);
            }
        }
        
        /// <signature>#4 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.reflect.Member_.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 ()Z ()Z</signature>
        public bool isSynthetic()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.Member_.j4n_Members[5]);
            }
        }
    }
}

#endregion Component Designer generated code
