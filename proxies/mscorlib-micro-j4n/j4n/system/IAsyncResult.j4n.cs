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

namespace System
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.IAsyncResult_))]
    static public partial class IAsyncResult_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static IAsyncResult_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.IAsyncResult_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.IAsyncResult_));
        }
        
        /// <signature>#0 get_AsyncState()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.IAsyncResult j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.IAsyncResult>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AsyncState, "java.lang.Object");
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
        
        /// <signature>#1 get_AsyncWaitHandle()Lsystem/MarshalByRefObject; ()LSystem/Threading/WaitHandle;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.IAsyncResult j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.IAsyncResult>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AsyncWaitHandle, "system.MarshalByRefObject");
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
        
        /// <signature>#2 get_CompletedSynchronously()Z ()Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.IAsyncResult j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.IAsyncResult>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.CompletedSynchronously;
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
        
        /// <signature>#3 get_IsCompleted()Z ()Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.IAsyncResult j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.IAsyncResult>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsCompleted;
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
            lock (typeof(global::System.IAsyncResult))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "system.IAsyncResult";
                    proxyInfo.JVMProxyName = "system._IAsyncResult";
                    proxyInfo.JVMStaticApiName = "system.IAsyncResult_";
                    proxyInfo.CLRApi = typeof(System.IAsyncResult);
                    proxyInfo.CLRStaticApi = typeof(System.IAsyncResult_);
                    proxyInfo.CLRProxy = typeof(System._IAsyncResult);
                    proxyInfo.JVMProxyFactory = System._IAsyncResult.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getAsyncState","()Ljava/lang/Object;", false, false), // #0 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getAsyncWaitHandle","()Lsystem/MarshalByRefObject;", false, false), // #1 ()LSystem/MarshalByRefObject;
                        new global::net.sf.jni4net.core.MemberId("getCompletedSynchronously","()Z", false, false), // #2 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsCompleted","()Z", false, false), // #3 ()Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.IAsyncResult_))]
    internal partial class _IAsyncResult : global::java.lang.Object, System.IAsyncResult
    {
        static _IAsyncResult()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.IAsyncResult_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.IAsyncResult_));
        }
        
        protected _IAsyncResult(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new System._IAsyncResult(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        public object AsyncState {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, System.IAsyncResult_.j4n_Members[0]));
                }
            }
        }
        
        public global::System.Threading.WaitHandle AsyncWaitHandle {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Threading.WaitHandle>(j4n_env, j4n_env.CallObjectMethod(this, System.IAsyncResult_.j4n_Members[1]));
                }
            }
        }
        
        public bool CompletedSynchronously {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallBooleanMethod(this, System.IAsyncResult_.j4n_Members[2]);
                }
            }
        }
        
        public bool IsCompleted {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallBooleanMethod(this, System.IAsyncResult_.j4n_Members[3]);
                }
            }
        }
    }
}

#endregion Component Designer generated code
