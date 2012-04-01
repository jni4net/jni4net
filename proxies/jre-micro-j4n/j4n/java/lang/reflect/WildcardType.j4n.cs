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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.WildcardType_))]
    public partial interface WildcardType : global::java.lang.reflect.Type
    {
        /// <signature>#0 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        global::java.lang.reflect.Type[] getLowerBounds();
        
        /// <signature>#1 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        global::java.lang.reflect.Type[] getUpperBounds();
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.WildcardType_))]
    static public partial class WildcardType_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static WildcardType_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.WildcardType_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.WildcardType_));
        }
        
        /// <signature>#0 getLowerBounds()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.WildcardType j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.WildcardType>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getLowerBounds(), "java.lang.reflect.Type");
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
        
        /// <signature>#1 getUpperBounds()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.WildcardType j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.WildcardType>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getUpperBounds(), "java.lang.reflect.Type");
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
            lock (typeof(global::java.lang.reflect.WildcardType))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.lang.reflect.WildcardType";
                    proxyInfo.JVMProxyName = "java_.lang.reflect._WildcardType";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.WildcardType_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.WildcardType);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.WildcardType_);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect._WildcardType);
                    proxyInfo.JVMProxyFactory = java.lang.reflect._WildcardType.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getLowerBounds","()[Ljava/lang/reflect/Type;", false, false), // #0 ()[Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getUpperBounds","()[Ljava/lang/reflect/Type;", false, false), // #1 ()[Ljava/lang/reflect/Type;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.WildcardType_))]
    internal partial class _WildcardType : global::java.lang.Object, java.lang.reflect.WildcardType
    {
        static _WildcardType()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.WildcardType_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.WildcardType_));
        }
        
        protected _WildcardType(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect._WildcardType(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type[] getLowerBounds()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.WildcardType_.j4n_Members[0]));
            }
        }
        
        /// <signature>#1 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type[] getUpperBounds()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.WildcardType_.j4n_Members[1]));
            }
        }
    }
}

#endregion Component Designer generated code
