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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Environment_))]
    static public partial class Environment_
    {
        static Environment_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Environment_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 Exit(I)V (I)V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int exitCode)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Environment.Exit(exitCode);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 ExpandEnvironmentVariables(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.ExpandEnvironmentVariables(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "java.lang.String");
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
        
        /// <signature>#2 FailFast(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr message)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Environment.FailFast(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, message));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 get_CommandLine()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.CommandLine, "java.lang.String");
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
        
        /// <signature>#4 get_CurrentDirectory()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.CurrentDirectory, "java.lang.String");
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
        
        /// <signature>#5 get_ExitCode()I ()I</signature>
        static int j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Environment.ExitCode;
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
        
        /// <signature>#6 get_HasShutdownStarted()Z ()Z</signature>
        static bool j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                bool j4n_result = global::System.Environment.HasShutdownStarted;
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
        
        /// <signature>#7 get_MachineName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.MachineName, "java.lang.String");
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
        
        /// <signature>#8 get_NewLine()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.NewLine, "java.lang.String");
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
        
        /// <signature>#9 get_OSVersion()Lsystem/ICloneable; ()LSystem/OperatingSystem;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.OSVersion, "system.ICloneable");
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
        
        /// <signature>#10 get_ProcessorCount()I ()I</signature>
        static int j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Environment.ProcessorCount;
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
        
        /// <signature>#11 get_StackTrace()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.StackTrace, "java.lang.String");
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
        
        /// <signature>#12 get_SystemDirectory()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SystemDirectory, "java.lang.String");
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
        
        /// <signature>#13 get_TickCount()I ()I</signature>
        static int j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Environment.TickCount;
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
        
        /// <signature>#14 get_UserDomainName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.UserDomainName, "java.lang.String");
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
        
        /// <signature>#15 get_UserInteractive()Z ()Z</signature>
        static bool j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                bool j4n_result = global::System.Environment.UserInteractive;
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
        
        /// <signature>#16 get_UserName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.UserName, "java.lang.String");
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
        
        /// <signature>#17 get_Version()Lsystem/ICloneable; ()LSystem/Version;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.Version, "system.ICloneable");
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
        
        /// <signature>#18 get_WorkingSet()J ()J</signature>
        static long j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                long j4n_result = global::System.Environment.WorkingSet;
                return j4n_result;
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
        
        /// <signature>#19 GetCommandLineArgs()[Ljava/lang/String; ()[Lsystem/String;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.GetCommandLineArgs(), "java.lang.String");
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
        
        /// <signature>#20 GetEnvironmentVariable(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr variable)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.GetEnvironmentVariable(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, variable)), "java.lang.String");
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
        
        /// <signature>#21 GetEnvironmentVariable(Ljava/lang/String;Lsystem/Enum;)Ljava/lang/String; (Lsystem/String;LSystem/EnvironmentVariableTarget;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr variable, global::System.IntPtr target)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.GetEnvironmentVariable(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, variable), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.EnvironmentVariableTarget>(j4n_env, target)), "java.lang.String");
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
        
        /// <signature>#22 GetEnvironmentVariables()Lsystem/collections/IDictionary; ()LSystem/Collections/IDictionary;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.GetEnvironmentVariables(), "system.collections.IDictionary");
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
        
        /// <signature>#23 GetEnvironmentVariables(Lsystem/Enum;)Lsystem/collections/IDictionary; (LSystem/EnvironmentVariableTarget;)LSystem/Collections/IDictionary;</signature>
        static global::System.IntPtr j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr target)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.GetEnvironmentVariables(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.EnvironmentVariableTarget>(j4n_env, target)), "system.collections.IDictionary");
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
        
        /// <signature>#24 GetFolderPath(Lsystem/Environment$SpecialFolder;)Ljava/lang/String; (LSystem/Environment+SpecialFolder;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr folder)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.GetFolderPath(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Environment.SpecialFolder>(j4n_env, folder)), "java.lang.String");
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
        
        /// <signature>#25 GetLogicalDrives()[Ljava/lang/String; ()[Lsystem/String;</signature>
        static global::System.IntPtr j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.GetLogicalDrives(), "java.lang.String");
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
        
        /// <signature>#26 set_CurrentDirectory(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Environment.CurrentDirectory = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#27 set_ExitCode(I)V (I)V</signature>
        static void j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Environment.ExitCode = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#28 SetEnvironmentVariable(Ljava/lang/String;Ljava/lang/String;)V (Lsystem/String;Lsystem/String;)V</signature>
        static void j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr variable, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Environment.SetEnvironmentVariable(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, variable), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#29 SetEnvironmentVariable(Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)V (Lsystem/String;Lsystem/String;LSystem/EnvironmentVariableTarget;)V</signature>
        static void j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr variable, global::System.IntPtr value, global::System.IntPtr target)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Environment.SetEnvironmentVariable(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, variable), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.EnvironmentVariableTarget>(j4n_env, target));
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
            lock (typeof(global::System.Environment))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Environment";
                    proxyInfo.JVMProxyName = "system.Environment";
                    proxyInfo.JVMStaticApiName = "system.Environment";
                    proxyInfo.CLRApi = typeof(System.Environment);
                    proxyInfo.CLRStaticApi = typeof(System.Environment_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Exit","(I)V", false, true), // #0 (I)V
                        new global::net.sf.jni4net.core.MemberId("ExpandEnvironmentVariables","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #1 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("FailFast","(Ljava/lang/String;)V", false, true), // #2 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("getCommandLine","()Ljava/lang/String;", false, true), // #3 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getCurrentDirectory","()Ljava/lang/String;", false, true), // #4 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getExitCode","()I", false, true), // #5 ()I
                        new global::net.sf.jni4net.core.MemberId("getHasShutdownStarted","()Z", false, true), // #6 ()Z
                        new global::net.sf.jni4net.core.MemberId("getMachineName","()Ljava/lang/String;", false, true), // #7 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getNewLine","()Ljava/lang/String;", false, true), // #8 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getOSVersion","()Lsystem/ICloneable;", false, true), // #9 ()LSystem/ICloneable;
                        new global::net.sf.jni4net.core.MemberId("getProcessorCount","()I", false, true), // #10 ()I
                        new global::net.sf.jni4net.core.MemberId("getStackTrace","()Ljava/lang/String;", false, true), // #11 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getSystemDirectory","()Ljava/lang/String;", false, true), // #12 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getTickCount","()I", false, true), // #13 ()I
                        new global::net.sf.jni4net.core.MemberId("getUserDomainName","()Ljava/lang/String;", false, true), // #14 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getUserInteractive","()Z", false, true), // #15 ()Z
                        new global::net.sf.jni4net.core.MemberId("getUserName","()Ljava/lang/String;", false, true), // #16 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getVersion","()Lsystem/ICloneable;", false, true), // #17 ()LSystem/ICloneable;
                        new global::net.sf.jni4net.core.MemberId("getWorkingSet","()J", false, true), // #18 ()J
                        new global::net.sf.jni4net.core.MemberId("GetCommandLineArgs","()[Ljava/lang/String;", false, true), // #19 ()[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetEnvironmentVariable","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #20 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetEnvironmentVariable","(Ljava/lang/String;Lsystem/Enum;)Ljava/lang/String;", false, true), // #21 (Ljava/lang/String;LSystem/Enum;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetEnvironmentVariables","()Lsystem/collections/IDictionary;", false, true), // #22 ()LSystem/Collections/IDictionary;
                        new global::net.sf.jni4net.core.MemberId("GetEnvironmentVariables","(Lsystem/Enum;)Lsystem/collections/IDictionary;", false, true), // #23 (LSystem/Enum;)LSystem/Collections/IDictionary;
                        new global::net.sf.jni4net.core.MemberId("GetFolderPath","(Lsystem/Environment$SpecialFolder;)Ljava/lang/String;", false, true), // #24 (LSystem/Environment+SpecialFolder;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetLogicalDrives","()[Ljava/lang/String;", false, true), // #25 ()[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("setCurrentDirectory","(Ljava/lang/String;)V", false, true), // #26 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("setExitCode","(I)V", false, true), // #27 (I)V
                        new global::net.sf.jni4net.core.MemberId("SetEnvironmentVariable","(Ljava/lang/String;Ljava/lang/String;)V", false, true), // #28 (Ljava/lang/String;Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("SetEnvironmentVariable","(Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)V", false, true), // #29 (Ljava/lang/String;Ljava/lang/String;LSystem/Enum;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Environment_.SpecialFolder_))]
        static public partial class SpecialFolder_
        {
            static SpecialFolder_()
            {
                global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Enum_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Environment_.SpecialFolder_));
            }
            
            static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static private global::java.lang.IClass j4n_Class;
            
            static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            new static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            /// <signature>#0 ApplicationData()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.ApplicationData, "system.Environment$SpecialFolder");
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
            
            /// <signature>#1 CommonApplicationData()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.CommonApplicationData, "system.Environment$SpecialFolder");
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
            
            /// <signature>#2 CommonProgramFiles()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.CommonProgramFiles, "system.Environment$SpecialFolder");
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
            
            /// <signature>#3 Cookies()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.Cookies, "system.Environment$SpecialFolder");
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
            
            /// <signature>#4 Desktop()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.Desktop, "system.Environment$SpecialFolder");
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
            
            /// <signature>#5 DesktopDirectory()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.DesktopDirectory, "system.Environment$SpecialFolder");
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
            
            /// <signature>#6 Favorites()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.Favorites, "system.Environment$SpecialFolder");
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
            
            /// <signature>#7 History()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.History, "system.Environment$SpecialFolder");
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
            
            /// <signature>#8 InternetCache()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.InternetCache, "system.Environment$SpecialFolder");
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
            
            /// <signature>#9 LocalApplicationData()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.LocalApplicationData, "system.Environment$SpecialFolder");
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
            
            /// <signature>#10 MyComputer()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.MyComputer, "system.Environment$SpecialFolder");
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
            
            /// <signature>#11 MyDocuments()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.MyDocuments, "system.Environment$SpecialFolder");
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
            
            /// <signature>#12 MyMusic()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.MyMusic, "system.Environment$SpecialFolder");
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
            
            /// <signature>#13 MyPictures()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.MyPictures, "system.Environment$SpecialFolder");
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
            
            /// <signature>#14 Personal()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.Personal, "system.Environment$SpecialFolder");
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
            
            /// <signature>#15 ProgramFiles()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.ProgramFiles, "system.Environment$SpecialFolder");
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
            
            /// <signature>#16 Programs()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.Programs, "system.Environment$SpecialFolder");
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
            
            /// <signature>#17 Recent()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.Recent, "system.Environment$SpecialFolder");
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
            
            /// <signature>#18 SendTo()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.SendTo, "system.Environment$SpecialFolder");
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
            
            /// <signature>#19 StartMenu()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.StartMenu, "system.Environment$SpecialFolder");
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
            
            /// <signature>#20 Startup()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.Startup, "system.Environment$SpecialFolder");
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
            
            /// <signature>#21 System()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.System, "system.Environment$SpecialFolder");
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
            
            /// <signature>#22 Templates()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
            static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Environment.SpecialFolder.Templates, "system.Environment$SpecialFolder");
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
                lock (typeof(global::System.Environment.SpecialFolder))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = true;
                        proxyInfo.IsInterface = false;
                        proxyInfo.JVMApiName = "system.Environment$SpecialFolder";
                        proxyInfo.JVMProxyName = "system.Environment$SpecialFolder";
                        proxyInfo.JVMStaticApiName = "system.Environment$SpecialFolder";
                        proxyInfo.CLRApi = typeof(System.Environment.SpecialFolder);
                        proxyInfo.CLRStaticApi = typeof(System.Environment_.SpecialFolder_);
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("ApplicationData","()Lsystem/Environment$SpecialFolder;", true, true), // #0 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("CommonApplicationData","()Lsystem/Environment$SpecialFolder;", true, true), // #1 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("CommonProgramFiles","()Lsystem/Environment$SpecialFolder;", true, true), // #2 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("Cookies","()Lsystem/Environment$SpecialFolder;", true, true), // #3 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("Desktop","()Lsystem/Environment$SpecialFolder;", true, true), // #4 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("DesktopDirectory","()Lsystem/Environment$SpecialFolder;", true, true), // #5 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("Favorites","()Lsystem/Environment$SpecialFolder;", true, true), // #6 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("History","()Lsystem/Environment$SpecialFolder;", true, true), // #7 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("InternetCache","()Lsystem/Environment$SpecialFolder;", true, true), // #8 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("LocalApplicationData","()Lsystem/Environment$SpecialFolder;", true, true), // #9 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("MyComputer","()Lsystem/Environment$SpecialFolder;", true, true), // #10 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("MyDocuments","()Lsystem/Environment$SpecialFolder;", true, true), // #11 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("MyMusic","()Lsystem/Environment$SpecialFolder;", true, true), // #12 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("MyPictures","()Lsystem/Environment$SpecialFolder;", true, true), // #13 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("Personal","()Lsystem/Environment$SpecialFolder;", true, true), // #14 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("ProgramFiles","()Lsystem/Environment$SpecialFolder;", true, true), // #15 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("Programs","()Lsystem/Environment$SpecialFolder;", true, true), // #16 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("Recent","()Lsystem/Environment$SpecialFolder;", true, true), // #17 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("SendTo","()Lsystem/Environment$SpecialFolder;", true, true), // #18 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("StartMenu","()Lsystem/Environment$SpecialFolder;", true, true), // #19 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("Startup","()Lsystem/Environment$SpecialFolder;", true, true), // #20 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("System","()Lsystem/Environment$SpecialFolder;", true, true), // #21 ()LSystem/Environment+SpecialFolder;
                        new global::net.sf.jni4net.core.MemberId("Templates","()Lsystem/Environment$SpecialFolder;", true, true), // #22 ()LSystem/Environment+SpecialFolder;
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
    }
}

#endregion Component Designer generated code
