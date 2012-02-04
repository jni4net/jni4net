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

namespace System.Runtime.Serialization
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Runtime.Serialization.StreamingContext_))]
    static public partial class StreamingContext_
    {
        static StreamingContext_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ValueType_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Runtime.Serialization.StreamingContext_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor(Lsystem/Enum;)V (LSystem/Runtime/Serialization/StreamingContextStates;)V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr state)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Runtime.Serialization.StreamingContext(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContextStates>(j4n_env, state)));
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
        
        /// <signature>#1 .ctor(Lsystem/Enum;Ljava/lang/Object;)V (LSystem/Runtime/Serialization/StreamingContextStates;Lsystem/Object;)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr state, global::System.IntPtr additional)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Runtime.Serialization.StreamingContext(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContextStates>(j4n_env, state), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, additional)));
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
        
        /// <signature>#2 get_Context()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Runtime.Serialization.StreamingContext j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContext>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Context, "java.lang.Object");
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
        
        /// <signature>#3 get_State()Lsystem/Enum; ()LSystem/Runtime/Serialization/StreamingContextStates;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Runtime.Serialization.StreamingContext j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContext>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.State, "system.Enum");
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
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Runtime.Serialization.StreamingContext))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.runtime.serialization.StreamingContext";
                    proxyInfo.JVMProxyName = "system.runtime.serialization.StreamingContext";
                    proxyInfo.JVMStaticApiName = "system.runtime.serialization.StreamingContext";
                    proxyInfo.CLRApi = typeof(System.Runtime.Serialization.StreamingContext);
                    proxyInfo.CLRStaticApi = typeof(System.Runtime.Serialization.StreamingContext_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Lsystem/Enum;)V", false, false), // #0 (LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Lsystem/Enum;Ljava/lang/Object;)V", false, false), // #1 (LSystem/Enum;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("getContext","()Ljava/lang/Object;", false, false), // #2 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getState","()Lsystem/Enum;", false, false), // #3 ()LSystem/Enum;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
