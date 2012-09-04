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

namespace net.sf.jni4net
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(net.sf.jni4net.CurrentBridgeSetup_))]
    static public partial class CurrentBridgeSetup_
    {
        static CurrentBridgeSetup_()
        {
            global::net.sf.jni4net.modules.jni4net.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(net.sf.jni4net.CurrentBridgeSetup_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 AddLogListener(Lsystem/Object;)V (Lnet/sf/jni4net/ILogListener;)V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr listener)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.AddLogListener(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.ILogListener>(j4n_env, listener));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 get_AllowJVMJoin()Z ()Z</signature>
        static bool j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.AllowJVMJoin;
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
        
        /// <signature>#2 get_AutoCreateLocalFrame()Z ()Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.AutoCreateLocalFrame;
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
        
        /// <signature>#3 get_BindClrProxies()Z ()Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.BindClrProxies;
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
        
        /// <signature>#4 get_CLRCoreAssembly()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.CLRCoreAssembly, "java.lang.String");
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
        
        /// <signature>#5 get_CLRCoreDllLocation()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.CLRCoreDllLocation, "java.lang.String");
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
        
        /// <signature>#6 get_CLRCoreJarLocation()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.CLRCoreJarLocation, "java.lang.String");
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
        
        /// <signature>#7 get_DefaultClassLoader()Lsystem/Object; ()Ljava/lang/IClassLoader;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.DefaultClassLoader, "system.Object");
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
        
        /// <signature>#8 get_DisableJavaHomeDetection()Z ()Z</signature>
        static bool j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.DisableJavaHomeDetection;
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
        
        /// <signature>#9 get_EnforceImmediateBinding()Z ()Z</signature>
        static bool j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.EnforceImmediateBinding;
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
        
        /// <signature>#10 get_EnforceThreadDetach()Z ()Z</signature>
        static bool j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.EnforceThreadDetach;
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
        
        /// <signature>#11 get_HideJNIFromStackTrace()Z ()Z</signature>
        static bool j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.HideJNIFromStackTrace;
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
        
        /// <signature>#12 get_J4NAssembly()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.J4NAssembly, "java.lang.String");
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
        
        /// <signature>#13 get_J4NDllLocation()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.J4NDllLocation, "java.lang.String");
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
        
        /// <signature>#14 get_J4NJarLocation()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.J4NJarLocation, "java.lang.String");
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
        
        /// <signature>#15 get_JavaHome()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.JavaHome, "java.lang.String");
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
        
        /// <signature>#16 get_JVMCoreAssembly()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.JVMCoreAssembly, "java.lang.String");
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
        
        /// <signature>#17 get_JVMCoreDllLocation()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.JVMCoreDllLocation, "java.lang.String");
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
        
        /// <signature>#18 get_JVMCoreJarLocation()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.JVMCoreJarLocation, "java.lang.String");
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
        
        /// <signature>#19 get_LogLevel()Lnet/sf/jni4net/LogLevel; ()Lnet/sf/jni4net/LogLevel;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.LogLevel, "net.sf.jni4net.LogLevel");
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
        
        /// <signature>#20 set_AllowJVMJoin(Z)V (Z)V</signature>
        static void j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.AllowJVMJoin = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#21 set_AutoCreateLocalFrame(Z)V (Z)V</signature>
        static void j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.AutoCreateLocalFrame = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#22 set_BindClrProxies(Z)V (Z)V</signature>
        static void j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.BindClrProxies = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#23 set_DefaultClassLoader(Lsystem/Object;)V (Ljava/lang/IClassLoader;)V</signature>
        static void j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.DefaultClassLoader = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.IClassLoader>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#24 set_DisableJavaHomeDetection(Z)V (Z)V</signature>
        static void j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.DisableJavaHomeDetection = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#25 set_EnforceImmediateBinding(Z)V (Z)V</signature>
        static void j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.EnforceImmediateBinding = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#26 set_EnforceThreadDetach(Z)V (Z)V</signature>
        static void j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.EnforceThreadDetach = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#27 set_HideJNIFromStackTrace(Z)V (Z)V</signature>
        static void j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.HideJNIFromStackTrace = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#28 set_LogLevel(Lnet/sf/jni4net/LogLevel;)V (Lnet/sf/jni4net/LogLevel;)V</signature>
        static void j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::net.sf.jni4net.CurrentBridgeSetup j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.CurrentBridgeSetup>(j4n_env, j4n_self);
                j4n_real.LogLevel = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::net.sf.jni4net.LogLevel>(j4n_env, value);
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
            lock (typeof(global::net.sf.jni4net.CurrentBridgeSetup))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "net.sf.jni4net.CurrentBridgeSetup";
                    proxyInfo.JVMProxyName = "net.sf.jni4net.CurrentBridgeSetup";
                    proxyInfo.JVMStaticApiName = "net.sf.jni4net.CurrentBridgeSetup";
                    proxyInfo.CLRApi = typeof(net.sf.jni4net.CurrentBridgeSetup);
                    proxyInfo.CLRStaticApi = typeof(net.sf.jni4net.CurrentBridgeSetup_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("AddLogListener","(Lsystem/Object;)V", false, false), // #0 (Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("getAllowJVMJoin","()Z", false, false), // #1 ()Z
                        new global::net.sf.jni4net.core.MemberId("getAutoCreateLocalFrame","()Z", false, false), // #2 ()Z
                        new global::net.sf.jni4net.core.MemberId("getBindClrProxies","()Z", false, false), // #3 ()Z
                        new global::net.sf.jni4net.core.MemberId("getCLRCoreAssembly","()Ljava/lang/String;", false, false), // #4 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getCLRCoreDllLocation","()Ljava/lang/String;", false, false), // #5 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getCLRCoreJarLocation","()Ljava/lang/String;", false, false), // #6 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getDefaultClassLoader","()Lsystem/Object;", false, false), // #7 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getDisableJavaHomeDetection","()Z", false, false), // #8 ()Z
                        new global::net.sf.jni4net.core.MemberId("getEnforceImmediateBinding","()Z", false, false), // #9 ()Z
                        new global::net.sf.jni4net.core.MemberId("getEnforceThreadDetach","()Z", false, false), // #10 ()Z
                        new global::net.sf.jni4net.core.MemberId("getHideJNIFromStackTrace","()Z", false, false), // #11 ()Z
                        new global::net.sf.jni4net.core.MemberId("getJ4NAssembly","()Ljava/lang/String;", false, false), // #12 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getJ4NDllLocation","()Ljava/lang/String;", false, false), // #13 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getJ4NJarLocation","()Ljava/lang/String;", false, false), // #14 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getJavaHome","()Ljava/lang/String;", false, false), // #15 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getJVMCoreAssembly","()Ljava/lang/String;", false, false), // #16 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getJVMCoreDllLocation","()Ljava/lang/String;", false, false), // #17 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getJVMCoreJarLocation","()Ljava/lang/String;", false, false), // #18 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getLogLevel","()Lnet/sf/jni4net/LogLevel;", false, false), // #19 ()Lnet/sf/jni4net/LogLevel;
                        new global::net.sf.jni4net.core.MemberId("setAllowJVMJoin","(Z)V", false, false), // #20 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setAutoCreateLocalFrame","(Z)V", false, false), // #21 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setBindClrProxies","(Z)V", false, false), // #22 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setDefaultClassLoader","(Lsystem/Object;)V", false, false), // #23 (Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("setDisableJavaHomeDetection","(Z)V", false, false), // #24 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setEnforceImmediateBinding","(Z)V", false, false), // #25 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setEnforceThreadDetach","(Z)V", false, false), // #26 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setHideJNIFromStackTrace","(Z)V", false, false), // #27 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setLogLevel","(Lnet/sf/jni4net/LogLevel;)V", false, false), // #28 (Lnet/sf/jni4net/LogLevel;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
