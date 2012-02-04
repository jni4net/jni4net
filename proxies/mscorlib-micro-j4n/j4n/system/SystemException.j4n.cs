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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.SystemException_))]
    static public partial class SystemException_
    {
        static SystemException_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Exception_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.SystemException_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor()V ()V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.SystemException());
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 .ctor(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr message)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.SystemException(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, message)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#2 .ctor(Ljava/lang/String;Ljava/lang/Throwable;)V (Lsystem/String;LSystem/Exception;)V</signature>
        static long j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr message, global::System.IntPtr innerException)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.SystemException(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, message), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, innerException)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.SystemException))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.SystemException";
                    proxyInfo.JVMProxyName = "system.SystemException";
                    proxyInfo.JVMStaticApiName = "system.SystemException";
                    proxyInfo.CLRApi = typeof(System.SystemException);
                    proxyInfo.CLRStaticApi = typeof(System.SystemException_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V", false, false), // #2 (Ljava/lang/String;Ljava/lang/Throwable;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
