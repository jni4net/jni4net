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

namespace System.Security
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Security.IEvidenceFactory_))]
    static public partial class IEvidenceFactory_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static IEvidenceFactory_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Security.IEvidenceFactory_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Security.IEvidenceFactory_));
        }
        
        /// <signature>#0 get_Evidence()Lsystem/collections/ICollection; ()LSystem/Security/Policy/Evidence;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Security.IEvidenceFactory j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Security.IEvidenceFactory>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Evidence, "system.collections.ICollection");
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
            lock (typeof(global::System.Security.IEvidenceFactory))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "system.security.IEvidenceFactory";
                    proxyInfo.JVMProxyName = "system.security._IEvidenceFactory";
                    proxyInfo.JVMStaticApiName = "system.security.IEvidenceFactory_";
                    proxyInfo.CLRApi = typeof(System.Security.IEvidenceFactory);
                    proxyInfo.CLRStaticApi = typeof(System.Security.IEvidenceFactory_);
                    proxyInfo.CLRProxy = typeof(System.Security._IEvidenceFactory);
                    proxyInfo.JVMProxyFactory = System.Security._IEvidenceFactory.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getEvidence","()Lsystem/collections/ICollection;", false, false), // #0 ()LSystem/Collections/ICollection;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Security.IEvidenceFactory_))]
    internal partial class _IEvidenceFactory : global::java.lang.Object, System.Security.IEvidenceFactory
    {
        static _IEvidenceFactory()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Security.IEvidenceFactory_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Security.IEvidenceFactory_));
        }
        
        protected _IEvidenceFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new System.Security._IEvidenceFactory(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        public global::System.Security.Policy.Evidence Evidence {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.Policy.Evidence>(j4n_env, j4n_env.CallObjectMethod(this, System.Security.IEvidenceFactory_.j4n_Members[0]));
                }
            }
        }
    }
}

#endregion Component Designer generated code
