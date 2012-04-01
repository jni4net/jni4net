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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.ParameterizedType_))]
    public partial interface ParameterizedType : global::java.lang.reflect.Type
    {
        /// <signature>#0 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        global::java.lang.reflect.Type[] getActualTypeArguments();
        
        /// <signature>#1 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        global::java.lang.reflect.Type getOwnerType();
        
        /// <signature>#2 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        global::java.lang.reflect.Type getRawType();
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.ParameterizedType_))]
    static public partial class ParameterizedType_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static ParameterizedType_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.ParameterizedType_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.ParameterizedType_));
        }
        
        /// <signature>#0 getActualTypeArguments()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.ParameterizedType j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.ParameterizedType>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getActualTypeArguments(), "java.lang.reflect.Type");
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
        
        /// <signature>#1 getOwnerType()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.ParameterizedType j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.ParameterizedType>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getOwnerType(), "java.lang.reflect.Type");
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
        
        /// <signature>#2 getRawType()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.ParameterizedType j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.ParameterizedType>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getRawType(), "java.lang.reflect.Type");
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
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.reflect.ParameterizedType))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.lang.reflect.ParameterizedType";
                    proxyInfo.JVMProxyName = "java_.lang.reflect._ParameterizedType";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.ParameterizedType_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.ParameterizedType);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.ParameterizedType_);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect._ParameterizedType);
                    proxyInfo.JVMProxyFactory = java.lang.reflect._ParameterizedType.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getActualTypeArguments","()[Ljava/lang/reflect/Type;", false, false), // #0 ()[Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getOwnerType","()Ljava/lang/reflect/Type;", false, false), // #1 ()Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getRawType","()Ljava/lang/reflect/Type;", false, false), // #2 ()Ljava/lang/reflect/Type;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.ParameterizedType_))]
    internal partial class _ParameterizedType : global::java.lang.Object, java.lang.reflect.ParameterizedType
    {
        static _ParameterizedType()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.ParameterizedType_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.ParameterizedType_));
        }
        
        protected _ParameterizedType(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect._ParameterizedType(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type[] getActualTypeArguments()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.ParameterizedType_.j4n_Members[0]));
            }
        }
        
        /// <signature>#1 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type getOwnerType()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.ParameterizedType_.j4n_Members[1]));
            }
        }
        
        /// <signature>#2 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type getRawType()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.ParameterizedType_.j4n_Members[2]));
            }
        }
    }
}

#endregion Component Designer generated code
