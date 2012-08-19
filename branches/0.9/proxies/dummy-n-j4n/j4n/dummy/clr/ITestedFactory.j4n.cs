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

namespace dummy.clr
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.clr.ITestedFactory_))]
    static public partial class ITestedFactory_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static ITestedFactory_()
        {
            global::net.sf.jni4net.modules.dummynj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.clr.ITestedFactory_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.clr.ITestedFactory_));
        }
        
        /// <signature>#0 createJTested()Ldummy/clr/ITested; ()Ldummy/clr/ITested;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                dummy.clr.ITestedFactory j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITestedFactory>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.createJTested(), "dummy.clr.ITested");
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
            lock (typeof(global::dummy.clr.ITestedFactory))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "dummy.clr.ITestedFactory";
                    proxyInfo.JVMProxyName = "dummy.clr._ITestedFactory";
                    proxyInfo.JVMStaticApiName = "dummy.clr.ITestedFactory_";
                    proxyInfo.CLRApi = typeof(dummy.clr.ITestedFactory);
                    proxyInfo.CLRStaticApi = typeof(dummy.clr.ITestedFactory_);
                    proxyInfo.CLRProxy = typeof(dummy.clr._ITestedFactory);
                    proxyInfo.JVMProxyFactory = dummy.clr._ITestedFactory.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("createJTested","()Ldummy/clr/ITested;", false, false), // #0 ()Ldummy/clr/ITested;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.clr.ITestedFactory_))]
    internal partial class _ITestedFactory : global::java.lang.Object, dummy.clr.ITestedFactory
    {
        static _ITestedFactory()
        {
            global::net.sf.jni4net.modules.dummynj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.clr.ITestedFactory_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.clr.ITestedFactory_));
        }
        
        protected _ITestedFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new dummy.clr._ITestedFactory(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()Ldummy/clr/ITested; ()Ldummy/clr/ITested;</signature>
        public global::dummy.clr.ITested createJTested()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_env.CallObjectMethod(this, dummy.clr.ITestedFactory_.j4n_Members[0]));
            }
        }
    }
}

#endregion Component Designer generated code
