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

namespace java.util
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Enumeration_))]
    public partial interface Enumeration
    {
        /// <signature>#0 ()Z ()Z</signature>
        bool hasMoreElements();
        
        /// <signature>#1 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        object nextElement();
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Enumeration_))]
    static public partial class Enumeration_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Enumeration_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Enumeration_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.util.Enumeration_));
        }
        
        /// <signature>#0 hasMoreElements()Z ()Z</signature>
        static bool j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Enumeration j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Enumeration>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.hasMoreElements();
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
        
        /// <signature>#1 nextElement()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Enumeration j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Enumeration>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.nextElement(), "java.lang.Object");
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
            lock (typeof(global::java.util.Enumeration))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.util.Enumeration";
                    proxyInfo.JVMProxyName = "java_.util._Enumeration";
                    proxyInfo.JVMStaticApiName = "java_.util.Enumeration_";
                    proxyInfo.CLRApi = typeof(java.util.Enumeration);
                    proxyInfo.CLRStaticApi = typeof(java.util.Enumeration_);
                    proxyInfo.CLRProxy = typeof(java.util._Enumeration);
                    proxyInfo.JVMProxyFactory = java.util._Enumeration.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("hasMoreElements","()Z", false, false), // #0 ()Z
                        new global::net.sf.jni4net.core.MemberId("nextElement","()Ljava/lang/Object;", false, false), // #1 ()Lsystem/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Enumeration_))]
    internal partial class _Enumeration : global::java.lang.Object, java.util.Enumeration
    {
        static _Enumeration()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Enumeration_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.util.Enumeration_));
        }
        
        protected _Enumeration(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util._Enumeration(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()Z ()Z</signature>
        public bool hasMoreElements()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Enumeration_.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public object nextElement()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Enumeration_.j4n_Members[1]));
            }
        }
    }
}

#endregion Component Designer generated code
