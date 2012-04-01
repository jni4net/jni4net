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

namespace System.Collections
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Collections.IEnumerable_))]
    static public partial class IEnumerable_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static IEnumerable_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Collections.IEnumerable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Collections.IEnumerable_));
        }
        
        /// <signature>#0 GetEnumerator()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Collections.IEnumerable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IEnumerable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetEnumerator(), "system.collections.IEnumerator");
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
            lock (typeof(global::System.Collections.IEnumerable))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "system.collections.IEnumerable";
                    proxyInfo.JVMProxyName = "system.collections._IEnumerable";
                    proxyInfo.JVMStaticApiName = "system.collections.IEnumerable_";
                    proxyInfo.CLRApi = typeof(System.Collections.IEnumerable);
                    proxyInfo.CLRStaticApi = typeof(System.Collections.IEnumerable_);
                    proxyInfo.CLRProxy = typeof(System.Collections._IEnumerable);
                    proxyInfo.JVMProxyFactory = System.Collections._IEnumerable.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("GetEnumerator","()Lsystem/collections/IEnumerator;", false, false), // #0 ()LSystem/Collections/IEnumerator;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Collections.IEnumerable_))]
    internal partial class _IEnumerable : global::java.lang.Object, System.Collections.IEnumerable
    {
        static _IEnumerable()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Collections.IEnumerable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Collections.IEnumerable_));
        }
        
        protected _IEnumerable(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new System.Collections._IEnumerable(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
        public global::System.Collections.IEnumerator GetEnumerator()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IEnumerator>(j4n_env, j4n_env.CallObjectMethod(this, System.Collections.IEnumerable_.j4n_Members[0]));
            }
        }
    }
}

#endregion Component Designer generated code
