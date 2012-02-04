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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.CharEnumerator_))]
    static public partial class CharEnumerator_
    {
        static CharEnumerator_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.ICloneable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ICloneable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IDisposable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IDisposable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Collections.IEnumerator_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Collections.IEnumerator_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.CharEnumerator_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 Clone()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.ICloneable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ICloneable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Clone(), "java.lang.Object");
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
        
        /// <signature>#1 Dispose()V ()V</signature>
        static void j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IDisposable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IDisposable>(j4n_env, j4n_self);
                j4n_real.Dispose();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#2 get_Current()Ljava/lang/Character; ()C</signature>
        static char j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.CharEnumerator j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.CharEnumerator>(j4n_env, j4n_self);
                char j4n_result = j4n_real.Current;
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(char);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 get_Current()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.IEnumerator j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IEnumerator>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Current, "java.lang.Object");
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
        
        /// <signature>#4 MoveNext()Z ()Z</signature>
        static bool j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.IEnumerator j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IEnumerator>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.MoveNext();
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
        
        /// <signature>#5 Reset()V ()V</signature>
        static void j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.IEnumerator j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IEnumerator>(j4n_env, j4n_self);
                j4n_real.Reset();
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
            lock (typeof(global::System.CharEnumerator))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.CharEnumerator";
                    proxyInfo.JVMProxyName = "system.CharEnumerator";
                    proxyInfo.JVMStaticApiName = "system.CharEnumerator";
                    proxyInfo.CLRApi = typeof(System.CharEnumerator);
                    proxyInfo.CLRStaticApi = typeof(System.CharEnumerator_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Clone","()Ljava/lang/Object;", false, false), // #0 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("Dispose","()V", false, false), // #1 ()V
                        new global::net.sf.jni4net.core.MemberId("getCurrent","()Ljava/lang/Character;", false, false), // #2 ()Ljava/lang/Character;
                        new global::net.sf.jni4net.core.MemberId("getCurrent_IEnumerator17","()Ljava/lang/Object;", false, false), // #3 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("MoveNext","()Z", false, false), // #4 ()Z
                        new global::net.sf.jni4net.core.MemberId("Reset","()V", false, false), // #5 ()V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
