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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.GenericDeclaration_))]
    public partial interface GenericDeclaration
    {
        /// <signature>#0 ()[Ljava/lang/reflect/TypeVariable; ()[Ljava/lang/reflect/TypeVariable;</signature>
        global::java.lang.reflect.TypeVariable[] getTypeParameters();
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.GenericDeclaration_))]
    static public partial class GenericDeclaration_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static GenericDeclaration_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.GenericDeclaration_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.GenericDeclaration_));
        }
        
        /// <signature>#0 getTypeParameters()[Ljava/lang/reflect/TypeVariable; ()[Ljava/lang/reflect/TypeVariable;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.GenericDeclaration j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.GenericDeclaration>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getTypeParameters(), "java.lang.reflect.TypeVariable");
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
            lock (typeof(global::java.lang.reflect.GenericDeclaration))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.lang.reflect.GenericDeclaration";
                    proxyInfo.JVMProxyName = "java_.lang.reflect._GenericDeclaration";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.GenericDeclaration_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.GenericDeclaration);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.GenericDeclaration_);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect._GenericDeclaration);
                    proxyInfo.JVMProxyFactory = java.lang.reflect._GenericDeclaration.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getTypeParameters","()[Ljava/lang/reflect/TypeVariable;", false, false), // #0 ()[Ljava/lang/reflect/TypeVariable;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.GenericDeclaration_))]
    internal partial class _GenericDeclaration : global::java.lang.Object, java.lang.reflect.GenericDeclaration
    {
        static _GenericDeclaration()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.GenericDeclaration_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.GenericDeclaration_));
        }
        
        protected _GenericDeclaration(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect._GenericDeclaration(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()[Ljava/lang/reflect/TypeVariable; ()[Ljava/lang/reflect/TypeVariable;</signature>
        public global::java.lang.reflect.TypeVariable[] getTypeParameters()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.TypeVariable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.GenericDeclaration_.j4n_Members[0]));
            }
        }
    }
}

#endregion Component Designer generated code
