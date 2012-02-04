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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Console_))]
    static public partial class Console_
    {
        static Console_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Console_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 add_CancelKeyPress(Lsystem/MulticastDelegate;)V (LSystem/ConsoleCancelEventHandler;)V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.CancelKeyPress += global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ConsoleCancelEventHandler>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 Beep()V ()V</signature>
        static void j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Console.Beep();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#2 Beep(II)V (II)V</signature>
        static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int frequency, int duration)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.Beep(frequency, duration);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 Clear()V ()V</signature>
        static void j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Console.Clear();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#4 get_BackgroundColor()Lsystem/Enum; ()LSystem/ConsoleColor;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.BackgroundColor, "system.Enum");
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
        
        /// <signature>#5 get_BufferHeight()I ()I</signature>
        static int j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.BufferHeight;
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
        
        /// <signature>#6 get_BufferWidth()I ()I</signature>
        static int j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.BufferWidth;
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
        
        /// <signature>#7 get_CapsLock()Z ()Z</signature>
        static bool j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                bool j4n_result = global::System.Console.CapsLock;
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
        
        /// <signature>#8 get_CursorLeft()I ()I</signature>
        static int j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.CursorLeft;
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
        
        /// <signature>#9 get_CursorSize()I ()I</signature>
        static int j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.CursorSize;
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
        
        /// <signature>#10 get_CursorTop()I ()I</signature>
        static int j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.CursorTop;
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
        
        /// <signature>#11 get_CursorVisible()Z ()Z</signature>
        static bool j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                bool j4n_result = global::System.Console.CursorVisible;
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
        
        /// <signature>#12 get_Error()Lsystem/io/TextWriter; ()LSystem/IO/TextWriter;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.Error, "system.io.TextWriter");
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
        
        /// <signature>#13 get_ForegroundColor()Lsystem/Enum; ()LSystem/ConsoleColor;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.ForegroundColor, "system.Enum");
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
        
        /// <signature>#14 get_In()Lsystem/io/TextReader; ()LSystem/IO/TextReader;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.In, "system.io.TextReader");
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
        
        /// <signature>#15 get_InputEncoding()Lsystem/ICloneable; ()LSystem/Text/Encoding;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.InputEncoding, "system.ICloneable");
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
        
        /// <signature>#16 get_KeyAvailable()Z ()Z</signature>
        static bool j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                bool j4n_result = global::System.Console.KeyAvailable;
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
        
        /// <signature>#17 get_LargestWindowHeight()I ()I</signature>
        static int j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.LargestWindowHeight;
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
        
        /// <signature>#18 get_LargestWindowWidth()I ()I</signature>
        static int j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.LargestWindowWidth;
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
        
        /// <signature>#19 get_NumberLock()Z ()Z</signature>
        static bool j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                bool j4n_result = global::System.Console.NumberLock;
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
        
        /// <signature>#20 get_Out()Lsystem/io/TextWriter; ()LSystem/IO/TextWriter;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.Out, "system.io.TextWriter");
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
        
        /// <signature>#21 get_OutputEncoding()Lsystem/ICloneable; ()LSystem/Text/Encoding;</signature>
        static global::System.IntPtr j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.OutputEncoding, "system.ICloneable");
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
        
        /// <signature>#22 get_Title()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.Title, "java.lang.String");
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
        
        /// <signature>#23 get_TreatControlCAsInput()Z ()Z</signature>
        static bool j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                bool j4n_result = global::System.Console.TreatControlCAsInput;
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
        
        /// <signature>#24 get_WindowHeight()I ()I</signature>
        static int j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.WindowHeight;
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
        
        /// <signature>#25 get_WindowLeft()I ()I</signature>
        static int j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.WindowLeft;
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
        
        /// <signature>#26 get_WindowTop()I ()I</signature>
        static int j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.WindowTop;
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
        
        /// <signature>#27 get_WindowWidth()I ()I</signature>
        static int j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.WindowWidth;
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
        
        /// <signature>#28 MoveBufferArea(IIIIII)V (IIIIII)V</signature>
        static void j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                global::System.Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#29 MoveBufferArea(IIIIIICLsystem/Enum;Lsystem/Enum;)V (IIIIIICLSystem/ConsoleColor;LSystem/ConsoleColor;)V</signature>
        static void j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, global::System.IntPtr sourceForeColor, global::System.IntPtr sourceBackColor)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 28);
            try
            {
                global::System.Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ConsoleColor>(j4n_env, sourceForeColor), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ConsoleColor>(j4n_env, sourceBackColor));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#30 OpenStandardError()Lsystem/io/Stream; ()LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.OpenStandardError(), "system.io.Stream");
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
        
        /// <signature>#31 OpenStandardError(I)Lsystem/io/Stream; (I)LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int bufferSize)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.OpenStandardError(bufferSize), "system.io.Stream");
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
        
        /// <signature>#32 OpenStandardInput()Lsystem/io/Stream; ()LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.OpenStandardInput(), "system.io.Stream");
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
        
        /// <signature>#33 OpenStandardInput(I)Lsystem/io/Stream; (I)LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int bufferSize)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.OpenStandardInput(bufferSize), "system.io.Stream");
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
        
        /// <signature>#34 OpenStandardOutput()Lsystem/io/Stream; ()LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.OpenStandardOutput(), "system.io.Stream");
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
        
        /// <signature>#35 OpenStandardOutput(I)Lsystem/io/Stream; (I)LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int bufferSize)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.OpenStandardOutput(bufferSize), "system.io.Stream");
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
        
        /// <signature>#36 Read()I ()I</signature>
        static int j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.Console.Read();
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
        
        /// <signature>#37 ReadKey()Lsystem/ValueType; ()LSystem/ConsoleKeyInfo;</signature>
        static global::System.IntPtr j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.ReadKey(), "system.ValueType");
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
        
        /// <signature>#38 ReadKey(Z)Lsystem/ValueType; (Z)LSystem/ConsoleKeyInfo;</signature>
        static global::System.IntPtr j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, bool intercept)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.ReadKey(intercept), "system.ValueType");
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
        
        /// <signature>#39 ReadLine()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Console.ReadLine(), "java.lang.String");
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
        
        /// <signature>#40 remove_CancelKeyPress(Lsystem/MulticastDelegate;)V (LSystem/ConsoleCancelEventHandler;)V</signature>
        static void j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.CancelKeyPress -= global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ConsoleCancelEventHandler>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#41 ResetColor()V ()V</signature>
        static void j4n_41(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Console.ResetColor();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#42 set_BackgroundColor(Lsystem/Enum;)V (LSystem/ConsoleColor;)V</signature>
        static void j4n_42(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.BackgroundColor = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ConsoleColor>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#43 set_BufferHeight(I)V (I)V</signature>
        static void j4n_43(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.BufferHeight = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#44 set_BufferWidth(I)V (I)V</signature>
        static void j4n_44(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.BufferWidth = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#45 set_CursorLeft(I)V (I)V</signature>
        static void j4n_45(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.CursorLeft = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#46 set_CursorSize(I)V (I)V</signature>
        static void j4n_46(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.CursorSize = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#47 set_CursorTop(I)V (I)V</signature>
        static void j4n_47(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.CursorTop = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#48 set_CursorVisible(Z)V (Z)V</signature>
        static void j4n_48(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.CursorVisible = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#49 set_ForegroundColor(Lsystem/Enum;)V (LSystem/ConsoleColor;)V</signature>
        static void j4n_49(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.ForegroundColor = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ConsoleColor>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#50 set_InputEncoding(Lsystem/ICloneable;)V (LSystem/Text/Encoding;)V</signature>
        static void j4n_50(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.InputEncoding = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Text.Encoding>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#51 set_OutputEncoding(Lsystem/ICloneable;)V (LSystem/Text/Encoding;)V</signature>
        static void j4n_51(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.OutputEncoding = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Text.Encoding>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#52 set_Title(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_52(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Title = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#53 set_TreatControlCAsInput(Z)V (Z)V</signature>
        static void j4n_53(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.TreatControlCAsInput = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#54 set_WindowHeight(I)V (I)V</signature>
        static void j4n_54(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WindowHeight = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#55 set_WindowLeft(I)V (I)V</signature>
        static void j4n_55(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WindowLeft = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#56 set_WindowTop(I)V (I)V</signature>
        static void j4n_56(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WindowTop = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#57 set_WindowWidth(I)V (I)V</signature>
        static void j4n_57(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WindowWidth = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#58 SetBufferSize(II)V (II)V</signature>
        static void j4n_58(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int width, int height)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.SetBufferSize(width, height);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#59 SetCursorPosition(II)V (II)V</signature>
        static void j4n_59(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int left, int top)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.SetCursorPosition(left, top);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#60 SetError(Lsystem/io/TextWriter;)V (LSystem/IO/TextWriter;)V</signature>
        static void j4n_60(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr newError)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.SetError(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, newError));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#61 SetIn(Lsystem/io/TextReader;)V (LSystem/IO/TextReader;)V</signature>
        static void j4n_61(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr newIn)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.SetIn(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, newIn));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#62 SetOut(Lsystem/io/TextWriter;)V (LSystem/IO/TextWriter;)V</signature>
        static void j4n_62(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr newOut)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.SetOut(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, newOut));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#63 SetWindowPosition(II)V (II)V</signature>
        static void j4n_63(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int left, int top)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.SetWindowPosition(left, top);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#64 SetWindowSize(II)V (II)V</signature>
        static void j4n_64(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int width, int height)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.SetWindowSize(width, height);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#65 Write([C)V ([C)V</signature>
        static void j4n_65(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr buffer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#66 Write([CII)V ([CII)V</signature>
        static void j4n_66(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr buffer, int index, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer), index, count);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#67 Write(Z)V (Z)V</signature>
        static void j4n_67(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#68 Write(C)V (C)V</signature>
        static void j4n_68(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#69 Write(Lsystem/Decimal;)V (LSystem/Decimal;)V</signature>
        static void j4n_69(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Decimal>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#70 Write(D)V (D)V</signature>
        static void j4n_70(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#71 Write(I)V (I)V</signature>
        static void j4n_71(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#72 Write(J)V (J)V</signature>
        static void j4n_72(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#73 Write(Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        static void j4n_73(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#74 Write(F)V (F)V</signature>
        static void j4n_74(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, float value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#75 Write(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_75(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#76 Write(Ljava/lang/String;[Ljava/lang/Object;)V (Lsystem/String;[Lsystem/Object;)V</signature>
        static void j4n_76(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, arg));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#77 Write(Ljava/lang/String;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;)V</signature>
        static void j4n_77(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#78 Write(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_78(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#79 Write(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_79(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#80 Write(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_80(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Console.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg3));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#81 Write(I)V (i)V</signature>
        static void j4n_81(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, uint value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#82 Write(J)V (j)V</signature>
        static void j4n_82(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, ulong value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#83 WriteLine()V ()V</signature>
        static void j4n_83(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Console.WriteLine();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#84 WriteLine([C)V ([C)V</signature>
        static void j4n_84(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr buffer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#85 WriteLine([CII)V ([CII)V</signature>
        static void j4n_85(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr buffer, int index, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer), index, count);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#86 WriteLine(Z)V (Z)V</signature>
        static void j4n_86(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#87 WriteLine(C)V (C)V</signature>
        static void j4n_87(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#88 WriteLine(Lsystem/Decimal;)V (LSystem/Decimal;)V</signature>
        static void j4n_88(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Decimal>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#89 WriteLine(D)V (D)V</signature>
        static void j4n_89(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#90 WriteLine(I)V (I)V</signature>
        static void j4n_90(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#91 WriteLine(J)V (J)V</signature>
        static void j4n_91(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#92 WriteLine(Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        static void j4n_92(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#93 WriteLine(F)V (F)V</signature>
        static void j4n_93(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, float value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#94 WriteLine(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_94(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#95 WriteLine(Ljava/lang/String;[Ljava/lang/Object;)V (Lsystem/String;[Lsystem/Object;)V</signature>
        static void j4n_95(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, arg));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#96 WriteLine(Ljava/lang/String;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;)V</signature>
        static void j4n_96(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#97 WriteLine(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_97(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#98 WriteLine(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_98(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#99 WriteLine(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_99(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Console.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg3));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#100 WriteLine(I)V (i)V</signature>
        static void j4n_100(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, uint value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#101 WriteLine(J)V (j)V</signature>
        static void j4n_101(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, ulong value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Console.WriteLine(value);
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
            lock (typeof(global::System.Console))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Console";
                    proxyInfo.JVMProxyName = "system.Console";
                    proxyInfo.JVMStaticApiName = "system.Console";
                    proxyInfo.CLRApi = typeof(System.Console);
                    proxyInfo.CLRStaticApi = typeof(System.Console_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("addCancelKeyPress","(Lsystem/MulticastDelegate;)V", false, true), // #0 (LSystem/MulticastDelegate;)V
                        new global::net.sf.jni4net.core.MemberId("Beep","()V", false, true), // #1 ()V
                        new global::net.sf.jni4net.core.MemberId("Beep","(II)V", false, true), // #2 (II)V
                        new global::net.sf.jni4net.core.MemberId("Clear","()V", false, true), // #3 ()V
                        new global::net.sf.jni4net.core.MemberId("getBackgroundColor","()Lsystem/Enum;", false, true), // #4 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getBufferHeight","()I", false, true), // #5 ()I
                        new global::net.sf.jni4net.core.MemberId("getBufferWidth","()I", false, true), // #6 ()I
                        new global::net.sf.jni4net.core.MemberId("getCapsLock","()Z", false, true), // #7 ()Z
                        new global::net.sf.jni4net.core.MemberId("getCursorLeft","()I", false, true), // #8 ()I
                        new global::net.sf.jni4net.core.MemberId("getCursorSize","()I", false, true), // #9 ()I
                        new global::net.sf.jni4net.core.MemberId("getCursorTop","()I", false, true), // #10 ()I
                        new global::net.sf.jni4net.core.MemberId("getCursorVisible","()Z", false, true), // #11 ()Z
                        new global::net.sf.jni4net.core.MemberId("getError","()Lsystem/io/TextWriter;", false, true), // #12 ()LSystem/IO/TextWriter;
                        new global::net.sf.jni4net.core.MemberId("getForegroundColor","()Lsystem/Enum;", false, true), // #13 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getIn","()Lsystem/io/TextReader;", false, true), // #14 ()LSystem/IO/TextReader;
                        new global::net.sf.jni4net.core.MemberId("getInputEncoding","()Lsystem/ICloneable;", false, true), // #15 ()LSystem/ICloneable;
                        new global::net.sf.jni4net.core.MemberId("getKeyAvailable","()Z", false, true), // #16 ()Z
                        new global::net.sf.jni4net.core.MemberId("getLargestWindowHeight","()I", false, true), // #17 ()I
                        new global::net.sf.jni4net.core.MemberId("getLargestWindowWidth","()I", false, true), // #18 ()I
                        new global::net.sf.jni4net.core.MemberId("getNumberLock","()Z", false, true), // #19 ()Z
                        new global::net.sf.jni4net.core.MemberId("getOut","()Lsystem/io/TextWriter;", false, true), // #20 ()LSystem/IO/TextWriter;
                        new global::net.sf.jni4net.core.MemberId("getOutputEncoding","()Lsystem/ICloneable;", false, true), // #21 ()LSystem/ICloneable;
                        new global::net.sf.jni4net.core.MemberId("getTitle","()Ljava/lang/String;", false, true), // #22 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getTreatControlCAsInput","()Z", false, true), // #23 ()Z
                        new global::net.sf.jni4net.core.MemberId("getWindowHeight","()I", false, true), // #24 ()I
                        new global::net.sf.jni4net.core.MemberId("getWindowLeft","()I", false, true), // #25 ()I
                        new global::net.sf.jni4net.core.MemberId("getWindowTop","()I", false, true), // #26 ()I
                        new global::net.sf.jni4net.core.MemberId("getWindowWidth","()I", false, true), // #27 ()I
                        new global::net.sf.jni4net.core.MemberId("MoveBufferArea","(IIIIII)V", false, true), // #28 (IIIIII)V
                        new global::net.sf.jni4net.core.MemberId("MoveBufferArea","(IIIIIICLsystem/Enum;Lsystem/Enum;)V", false, true), // #29 (IIIIIICLSystem/Enum;LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("OpenStandardError","()Lsystem/io/Stream;", false, true), // #30 ()LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("OpenStandardError","(I)Lsystem/io/Stream;", false, true), // #31 (I)LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("OpenStandardInput","()Lsystem/io/Stream;", false, true), // #32 ()LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("OpenStandardInput","(I)Lsystem/io/Stream;", false, true), // #33 (I)LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("OpenStandardOutput","()Lsystem/io/Stream;", false, true), // #34 ()LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("OpenStandardOutput","(I)Lsystem/io/Stream;", false, true), // #35 (I)LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("Read","()I", false, true), // #36 ()I
                        new global::net.sf.jni4net.core.MemberId("ReadKey","()Lsystem/ValueType;", false, true), // #37 ()LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("ReadKey","(Z)Lsystem/ValueType;", false, true), // #38 (Z)LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("ReadLine","()Ljava/lang/String;", false, true), // #39 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("removeCancelKeyPress","(Lsystem/MulticastDelegate;)V", false, true), // #40 (LSystem/MulticastDelegate;)V
                        new global::net.sf.jni4net.core.MemberId("ResetColor","()V", false, true), // #41 ()V
                        new global::net.sf.jni4net.core.MemberId("setBackgroundColor","(Lsystem/Enum;)V", false, true), // #42 (LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("setBufferHeight","(I)V", false, true), // #43 (I)V
                        new global::net.sf.jni4net.core.MemberId("setBufferWidth","(I)V", false, true), // #44 (I)V
                        new global::net.sf.jni4net.core.MemberId("setCursorLeft","(I)V", false, true), // #45 (I)V
                        new global::net.sf.jni4net.core.MemberId("setCursorSize","(I)V", false, true), // #46 (I)V
                        new global::net.sf.jni4net.core.MemberId("setCursorTop","(I)V", false, true), // #47 (I)V
                        new global::net.sf.jni4net.core.MemberId("setCursorVisible","(Z)V", false, true), // #48 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setForegroundColor","(Lsystem/Enum;)V", false, true), // #49 (LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("setInputEncoding","(Lsystem/ICloneable;)V", false, true), // #50 (LSystem/ICloneable;)V
                        new global::net.sf.jni4net.core.MemberId("setOutputEncoding","(Lsystem/ICloneable;)V", false, true), // #51 (LSystem/ICloneable;)V
                        new global::net.sf.jni4net.core.MemberId("setTitle","(Ljava/lang/String;)V", false, true), // #52 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("setTreatControlCAsInput","(Z)V", false, true), // #53 (Z)V
                        new global::net.sf.jni4net.core.MemberId("setWindowHeight","(I)V", false, true), // #54 (I)V
                        new global::net.sf.jni4net.core.MemberId("setWindowLeft","(I)V", false, true), // #55 (I)V
                        new global::net.sf.jni4net.core.MemberId("setWindowTop","(I)V", false, true), // #56 (I)V
                        new global::net.sf.jni4net.core.MemberId("setWindowWidth","(I)V", false, true), // #57 (I)V
                        new global::net.sf.jni4net.core.MemberId("SetBufferSize","(II)V", false, true), // #58 (II)V
                        new global::net.sf.jni4net.core.MemberId("SetCursorPosition","(II)V", false, true), // #59 (II)V
                        new global::net.sf.jni4net.core.MemberId("SetError","(Lsystem/io/TextWriter;)V", false, true), // #60 (LSystem/IO/TextWriter;)V
                        new global::net.sf.jni4net.core.MemberId("SetIn","(Lsystem/io/TextReader;)V", false, true), // #61 (LSystem/IO/TextReader;)V
                        new global::net.sf.jni4net.core.MemberId("SetOut","(Lsystem/io/TextWriter;)V", false, true), // #62 (LSystem/IO/TextWriter;)V
                        new global::net.sf.jni4net.core.MemberId("SetWindowPosition","(II)V", false, true), // #63 (II)V
                        new global::net.sf.jni4net.core.MemberId("SetWindowSize","(II)V", false, true), // #64 (II)V
                        new global::net.sf.jni4net.core.MemberId("Write","([C)V", false, true), // #65 ([C)V
                        new global::net.sf.jni4net.core.MemberId("Write","([CII)V", false, true), // #66 ([CII)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Z)V", false, true), // #67 (Z)V
                        new global::net.sf.jni4net.core.MemberId("Write","(C)V", false, true), // #68 (C)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Lsystem/Decimal;)V", false, true), // #69 (LSystem/Decimal;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(D)V", false, true), // #70 (D)V
                        new global::net.sf.jni4net.core.MemberId("Write","(I)V", false, true), // #71 (I)V
                        new global::net.sf.jni4net.core.MemberId("Write","(J)V", false, true), // #72 (J)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/Object;)V", false, true), // #73 (Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(F)V", false, true), // #74 (F)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;)V", false, true), // #75 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;[Ljava/lang/Object;)V", false, true), // #76 (Ljava/lang/String;[Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;Ljava/lang/Object;)V", false, true), // #77 (Ljava/lang/String;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", false, true), // #78 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", false, true), // #79 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", false, true), // #80 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V
                        null, // #81 IsJvmSkip: Write
                        null, // #82 IsJvmSkip: Write
                        new global::net.sf.jni4net.core.MemberId("WriteLine","()V", false, true), // #83 ()V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","([C)V", false, true), // #84 ([C)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","([CII)V", false, true), // #85 ([CII)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Z)V", false, true), // #86 (Z)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(C)V", false, true), // #87 (C)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Lsystem/Decimal;)V", false, true), // #88 (LSystem/Decimal;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(D)V", false, true), // #89 (D)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(I)V", false, true), // #90 (I)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(J)V", false, true), // #91 (J)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/Object;)V", false, true), // #92 (Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(F)V", false, true), // #93 (F)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;)V", false, true), // #94 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;[Ljava/lang/Object;)V", false, true), // #95 (Ljava/lang/String;[Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;Ljava/lang/Object;)V", false, true), // #96 (Ljava/lang/String;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", false, true), // #97 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", false, true), // #98 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", false, true), // #99 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V
                        null, // #100 IsJvmSkip: WriteLine
                        null, // #101 IsJvmSkip: WriteLine
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
