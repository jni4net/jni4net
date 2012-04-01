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

namespace dummy.jvm
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Foobararable_))]
    public partial interface Foobararable
    {
        /// <signature>#0 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        int Foob(object par0);
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Foobararable_))]
    static public partial class Foobararable_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Foobararable_()
        {
            global::net.sf.jni4net.modules.dummyjj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Foobararable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Foobararable_));
        }
        
        /// <signature>#0 Foob(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                dummy.jvm.Foobararable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Foobararable>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Foob(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::dummy.jvm.Foobararable))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "dummy.jvm.Foobararable";
                    proxyInfo.JVMProxyName = "dummy.jvm._Foobararable";
                    proxyInfo.JVMStaticApiName = "dummy.jvm.Foobararable_";
                    proxyInfo.CLRApi = typeof(dummy.jvm.Foobararable);
                    proxyInfo.CLRStaticApi = typeof(dummy.jvm.Foobararable_);
                    proxyInfo.CLRProxy = typeof(dummy.jvm._Foobararable);
                    proxyInfo.JVMProxyFactory = dummy.jvm._Foobararable.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Foob","(Ljava/lang/Object;)I", false, false), // #0 (Lsystem/Object;)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Foobararable_))]
    internal partial class _Foobararable : global::java.lang.Object, dummy.jvm.Foobararable
    {
        static _Foobararable()
        {
            global::net.sf.jni4net.modules.dummyjj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Foobararable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Foobararable_));
        }
        
        protected _Foobararable(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new dummy.jvm._Foobararable(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int Foob(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, dummy.jvm.Foobararable_.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
    }
}

#endregion Component Designer generated code
