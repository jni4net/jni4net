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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.AsyncCallback_))]
    static public partial class AsyncCallback_
    {
        static AsyncCallback_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.MulticastDelegate_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.AsyncCallback_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#1 BeginInvoke(Lsystem/IAsyncResult;Lsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult; (LSystem/IAsyncResult;LSystem/AsyncCallback;Lsystem/Object;)LSystem/IAsyncResult;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr ar, global::System.IntPtr callback, global::System.IntPtr @object)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.AsyncCallback j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.AsyncCallback>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.BeginInvoke(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IAsyncResult>(j4n_env, ar), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.AsyncCallback>(j4n_env, callback), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, @object)), "system.IAsyncResult");
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
        
        /// <signature>#2 EndInvoke(Lsystem/IAsyncResult;)V (LSystem/IAsyncResult;)V</signature>
        static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr result)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.AsyncCallback j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.AsyncCallback>(j4n_env, j4n_self);
                j4n_real.EndInvoke(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IAsyncResult>(j4n_env, result));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 Invoke(Lsystem/IAsyncResult;)V (LSystem/IAsyncResult;)V</signature>
        static void j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr ar)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.AsyncCallback j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.AsyncCallback>(j4n_env, j4n_self);
                j4n_real.Invoke(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IAsyncResult>(j4n_env, ar));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.AsyncCallback))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.AsyncCallback";
                    proxyInfo.JVMProxyName = "system.AsyncCallback";
                    proxyInfo.JVMStaticApiName = "system.AsyncCallback";
                    proxyInfo.CLRApi = typeof(System.AsyncCallback);
                    proxyInfo.CLRStaticApi = typeof(System.AsyncCallback_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        null, // #0 IsJvmSkip: .ctor
                        new global::net.sf.jni4net.core.MemberId("BeginInvoke","(Lsystem/IAsyncResult;Lsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult;", false, false), // #1 (LSystem/IAsyncResult;LSystem/AsyncCallback;Ljava/lang/Object;)LSystem/IAsyncResult;
                        new global::net.sf.jni4net.core.MemberId("EndInvoke","(Lsystem/IAsyncResult;)V", false, false), // #2 (LSystem/IAsyncResult;)V
                        new global::net.sf.jni4net.core.MemberId("Invoke","(Lsystem/IAsyncResult;)V", false, false), // #3 (LSystem/IAsyncResult;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
