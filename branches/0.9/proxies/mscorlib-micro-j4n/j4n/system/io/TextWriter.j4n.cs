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

namespace System.IO
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.IO.TextWriter_))]
    static public partial class TextWriter_
    {
        static TextWriter_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.MarshalByRefObject_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IDisposable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IDisposable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.IO.TextWriter_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 Null()Lsystem/io/TextWriter; ()LSystem/IO/TextWriter;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.IO.TextWriter.Null, "system.io.TextWriter");
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
        
        /// <signature>#1 Synchronized(Lsystem/io/TextWriter;)Lsystem/io/TextWriter; (LSystem/IO/TextWriter;)LSystem/IO/TextWriter;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr writer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.IO.TextWriter.Synchronized(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, writer)), "system.io.TextWriter");
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
        
        /// <signature>#2 Close()V ()V</signature>
        static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Close();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 Dispose()V ()V</signature>
        static void j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#4 Flush()V ()V</signature>
        static void j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Flush();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#5 get_Encoding()Lsystem/ICloneable; ()LSystem/Text/Encoding;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Encoding, "system.ICloneable");
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
        
        /// <signature>#6 get_FormatProvider()Lsystem/IFormatProvider; ()LSystem/IFormatProvider;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.FormatProvider, "system.IFormatProvider");
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
        
        /// <signature>#7 get_NewLine()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.NewLine, "java.lang.String");
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
        
        /// <signature>#8 set_NewLine(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.NewLine = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#9 Write([C)V ([C)V</signature>
        static void j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#10 Write([CII)V ([CII)V</signature>
        static void j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer, int index, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer), index, count);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#11 Write(Z)V (Z)V</signature>
        static void j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#12 Write(C)V (C)V</signature>
        static void j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#13 Write(Lsystem/Decimal;)V (LSystem/Decimal;)V</signature>
        static void j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Decimal>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#14 Write(D)V (D)V</signature>
        static void j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#15 Write(I)V (I)V</signature>
        static void j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#16 Write(J)V (J)V</signature>
        static void j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#17 Write(Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        static void j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#18 Write(F)V (F)V</signature>
        static void j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, float value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#19 Write(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#20 Write(Ljava/lang/String;[Ljava/lang/Object;)V (Lsystem/String;[Lsystem/Object;)V</signature>
        static void j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr arg)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, arg));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#21 Write(Ljava/lang/String;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;)V</signature>
        static void j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr arg0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#22 Write(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#23 Write(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#24 Write(I)V (i)V</signature>
        static void j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, uint value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#25 Write(J)V (j)V</signature>
        static void j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, ulong value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.Write(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#26 WriteLine()V ()V</signature>
        static void j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#27 WriteLine([C)V ([C)V</signature>
        static void j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#28 WriteLine([CII)V ([CII)V</signature>
        static void j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer, int index, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer), index, count);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#29 WriteLine(Z)V (Z)V</signature>
        static void j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#30 WriteLine(C)V (C)V</signature>
        static void j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#31 WriteLine(Lsystem/Decimal;)V (LSystem/Decimal;)V</signature>
        static void j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Decimal>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#32 WriteLine(D)V (D)V</signature>
        static void j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#33 WriteLine(I)V (I)V</signature>
        static void j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#34 WriteLine(J)V (J)V</signature>
        static void j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#35 WriteLine(Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        static void j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#36 WriteLine(F)V (F)V</signature>
        static void j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, float value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#37 WriteLine(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#38 WriteLine(Ljava/lang/String;[Ljava/lang/Object;)V (Lsystem/String;[Lsystem/Object;)V</signature>
        static void j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr arg)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, arg));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#39 WriteLine(Ljava/lang/String;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;)V</signature>
        static void j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr arg0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#40 WriteLine(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#41 WriteLine(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_41(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#42 WriteLine(I)V (i)V</signature>
        static void j4n_42(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, uint value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#43 WriteLine(J)V (j)V</signature>
        static void j4n_43(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, ulong value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.TextWriter j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextWriter>(j4n_env, j4n_self);
                j4n_real.WriteLine(value);
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
            lock (typeof(global::System.IO.TextWriter))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.io.TextWriter";
                    proxyInfo.JVMProxyName = "system.io.TextWriter";
                    proxyInfo.JVMStaticApiName = "system.io.TextWriter";
                    proxyInfo.CLRApi = typeof(System.IO.TextWriter);
                    proxyInfo.CLRStaticApi = typeof(System.IO.TextWriter_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Null","()Lsystem/io/TextWriter;", true, true), // #0 ()LSystem/IO/TextWriter;
                        new global::net.sf.jni4net.core.MemberId("Synchronized","(Lsystem/io/TextWriter;)Lsystem/io/TextWriter;", false, true), // #1 (LSystem/IO/TextWriter;)LSystem/IO/TextWriter;
                        new global::net.sf.jni4net.core.MemberId("Close","()V", false, false), // #2 ()V
                        new global::net.sf.jni4net.core.MemberId("Dispose","()V", false, false), // #3 ()V
                        new global::net.sf.jni4net.core.MemberId("Flush","()V", false, false), // #4 ()V
                        new global::net.sf.jni4net.core.MemberId("getEncoding","()Lsystem/ICloneable;", false, false), // #5 ()LSystem/ICloneable;
                        new global::net.sf.jni4net.core.MemberId("getFormatProvider","()Lsystem/IFormatProvider;", false, false), // #6 ()LSystem/IFormatProvider;
                        new global::net.sf.jni4net.core.MemberId("getNewLine","()Ljava/lang/String;", false, false), // #7 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("setNewLine","(Ljava/lang/String;)V", false, false), // #8 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("Write","([C)V", false, false), // #9 ([C)V
                        new global::net.sf.jni4net.core.MemberId("Write","([CII)V", false, false), // #10 ([CII)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Z)V", false, false), // #11 (Z)V
                        new global::net.sf.jni4net.core.MemberId("Write","(C)V", false, false), // #12 (C)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Lsystem/Decimal;)V", false, false), // #13 (LSystem/Decimal;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(D)V", false, false), // #14 (D)V
                        new global::net.sf.jni4net.core.MemberId("Write","(I)V", false, false), // #15 (I)V
                        new global::net.sf.jni4net.core.MemberId("Write","(J)V", false, false), // #16 (J)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/Object;)V", false, false), // #17 (Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(F)V", false, false), // #18 (F)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;)V", false, false), // #19 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;[Ljava/lang/Object;)V", false, false), // #20 (Ljava/lang/String;[Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;Ljava/lang/Object;)V", false, false), // #21 (Ljava/lang/String;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", false, false), // #22 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Write","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", false, false), // #23 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V
                        null, // #24 IsJvmSkip: Write
                        null, // #25 IsJvmSkip: Write
                        new global::net.sf.jni4net.core.MemberId("WriteLine","()V", false, false), // #26 ()V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","([C)V", false, false), // #27 ([C)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","([CII)V", false, false), // #28 ([CII)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Z)V", false, false), // #29 (Z)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(C)V", false, false), // #30 (C)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Lsystem/Decimal;)V", false, false), // #31 (LSystem/Decimal;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(D)V", false, false), // #32 (D)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(I)V", false, false), // #33 (I)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(J)V", false, false), // #34 (J)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/Object;)V", false, false), // #35 (Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(F)V", false, false), // #36 (F)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;)V", false, false), // #37 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;[Ljava/lang/Object;)V", false, false), // #38 (Ljava/lang/String;[Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;Ljava/lang/Object;)V", false, false), // #39 (Ljava/lang/String;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", false, false), // #40 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("WriteLine","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", false, false), // #41 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V
                        null, // #42 IsJvmSkip: WriteLine
                        null, // #43 IsJvmSkip: WriteLine
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
