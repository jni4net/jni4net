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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.IO.Stream_))]
    static public partial class Stream_
    {
        static Stream_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.MarshalByRefObject_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IDisposable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IDisposable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.IO.Stream_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 Null()Lsystem/io/Stream; ()LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.IO.Stream.Null, "system.io.Stream");
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
        
        /// <signature>#1 Synchronized(Lsystem/io/Stream;)Lsystem/io/Stream; (LSystem/IO/Stream;)LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr stream)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.IO.Stream.Synchronized(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, stream)), "system.io.Stream");
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
        
        /// <signature>#2 BeginRead([BIILsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult; ([BIILSystem/AsyncCallback;Lsystem/Object;)LSystem/IAsyncResult;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer, int offset, int count, global::System.IntPtr callback, global::System.IntPtr state)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.BeginRead(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, buffer), offset, count, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.AsyncCallback>(j4n_env, callback), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, state)), "system.IAsyncResult");
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
        
        /// <signature>#3 BeginWrite([BIILsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult; ([BIILSystem/AsyncCallback;Lsystem/Object;)LSystem/IAsyncResult;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer, int offset, int count, global::System.IntPtr callback, global::System.IntPtr state)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.BeginWrite(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, buffer), offset, count, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.AsyncCallback>(j4n_env, callback), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, state)), "system.IAsyncResult");
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
        
        /// <signature>#4 Close()V ()V</signature>
        static void j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
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
        
        /// <signature>#5 Dispose()V ()V</signature>
        static void j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#6 EndRead(Lsystem/IAsyncResult;)I (LSystem/IAsyncResult;)I</signature>
        static int j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr asyncResult)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                int j4n_result = j4n_real.EndRead(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IAsyncResult>(j4n_env, asyncResult));
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
        
        /// <signature>#7 EndWrite(Lsystem/IAsyncResult;)V (LSystem/IAsyncResult;)V</signature>
        static void j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr asyncResult)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_real.EndWrite(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IAsyncResult>(j4n_env, asyncResult));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#8 Flush()V ()V</signature>
        static void j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
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
        
        /// <signature>#9 get_CanRead()Z ()Z</signature>
        static bool j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.CanRead;
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
        
        /// <signature>#10 get_CanSeek()Z ()Z</signature>
        static bool j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.CanSeek;
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
        
        /// <signature>#11 get_CanTimeout()Z ()Z</signature>
        static bool j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.CanTimeout;
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
        
        /// <signature>#12 get_CanWrite()Z ()Z</signature>
        static bool j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.CanWrite;
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
        
        /// <signature>#13 get_Length()J ()J</signature>
        static long j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                long j4n_result = j4n_real.Length;
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
        
        /// <signature>#14 get_Position()J ()J</signature>
        static long j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                long j4n_result = j4n_real.Position;
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
        
        /// <signature>#15 get_ReadTimeout()I ()I</signature>
        static int j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                int j4n_result = j4n_real.ReadTimeout;
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
        
        /// <signature>#16 get_WriteTimeout()I ()I</signature>
        static int j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                int j4n_result = j4n_real.WriteTimeout;
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
        
        /// <signature>#17 Read([BII)I ([BII)I</signature>
        static int j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer, int offset, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Read(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, buffer), offset, count);
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
        
        /// <signature>#18 ReadByte()I ()I</signature>
        static int j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                int j4n_result = j4n_real.ReadByte();
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
        
        /// <signature>#19 Seek(JLsystem/Enum;)J (JLSystem/IO/SeekOrigin;)J</signature>
        static long j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long offset, global::System.IntPtr origin)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                long j4n_result = j4n_real.Seek(offset, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.SeekOrigin>(j4n_env, origin));
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
        
        /// <signature>#20 set_Position(J)V (J)V</signature>
        static void j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_real.Position = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#21 set_ReadTimeout(I)V (I)V</signature>
        static void j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_real.ReadTimeout = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#22 set_WriteTimeout(I)V (I)V</signature>
        static void j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_real.WriteTimeout = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#23 SetLength(J)V (J)V</signature>
        static void j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_real.SetLength(value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#24 Write([BII)V ([BII)V</signature>
        static void j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer, int offset, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_real.Write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, buffer), offset, count);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#25 WriteByte(B)V (B)V</signature>
        static void j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, byte value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.Stream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.Stream>(j4n_env, j4n_self);
                j4n_real.WriteByte(value);
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
            lock (typeof(global::System.IO.Stream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.io.Stream";
                    proxyInfo.JVMProxyName = "system.io.Stream";
                    proxyInfo.JVMStaticApiName = "system.io.Stream";
                    proxyInfo.CLRApi = typeof(System.IO.Stream);
                    proxyInfo.CLRStaticApi = typeof(System.IO.Stream_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Null","()Lsystem/io/Stream;", true, true), // #0 ()LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("Synchronized","(Lsystem/io/Stream;)Lsystem/io/Stream;", false, true), // #1 (LSystem/IO/Stream;)LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("BeginRead","([BIILsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult;", false, false), // #2 ([BIILSystem/AsyncCallback;Ljava/lang/Object;)LSystem/IAsyncResult;
                        new global::net.sf.jni4net.core.MemberId("BeginWrite","([BIILsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult;", false, false), // #3 ([BIILSystem/AsyncCallback;Ljava/lang/Object;)LSystem/IAsyncResult;
                        new global::net.sf.jni4net.core.MemberId("Close","()V", false, false), // #4 ()V
                        new global::net.sf.jni4net.core.MemberId("Dispose","()V", false, false), // #5 ()V
                        new global::net.sf.jni4net.core.MemberId("EndRead","(Lsystem/IAsyncResult;)I", false, false), // #6 (LSystem/IAsyncResult;)I
                        new global::net.sf.jni4net.core.MemberId("EndWrite","(Lsystem/IAsyncResult;)V", false, false), // #7 (LSystem/IAsyncResult;)V
                        new global::net.sf.jni4net.core.MemberId("Flush","()V", false, false), // #8 ()V
                        new global::net.sf.jni4net.core.MemberId("getCanRead","()Z", false, false), // #9 ()Z
                        new global::net.sf.jni4net.core.MemberId("getCanSeek","()Z", false, false), // #10 ()Z
                        new global::net.sf.jni4net.core.MemberId("getCanTimeout","()Z", false, false), // #11 ()Z
                        new global::net.sf.jni4net.core.MemberId("getCanWrite","()Z", false, false), // #12 ()Z
                        new global::net.sf.jni4net.core.MemberId("getLength","()J", false, false), // #13 ()J
                        new global::net.sf.jni4net.core.MemberId("getPosition","()J", false, false), // #14 ()J
                        new global::net.sf.jni4net.core.MemberId("getReadTimeout","()I", false, false), // #15 ()I
                        new global::net.sf.jni4net.core.MemberId("getWriteTimeout","()I", false, false), // #16 ()I
                        new global::net.sf.jni4net.core.MemberId("Read","([BII)I", false, false), // #17 ([BII)I
                        new global::net.sf.jni4net.core.MemberId("ReadByte","()I", false, false), // #18 ()I
                        new global::net.sf.jni4net.core.MemberId("Seek","(JLsystem/Enum;)J", false, false), // #19 (JLSystem/Enum;)J
                        new global::net.sf.jni4net.core.MemberId("setPosition","(J)V", false, false), // #20 (J)V
                        new global::net.sf.jni4net.core.MemberId("setReadTimeout","(I)V", false, false), // #21 (I)V
                        new global::net.sf.jni4net.core.MemberId("setWriteTimeout","(I)V", false, false), // #22 (I)V
                        new global::net.sf.jni4net.core.MemberId("SetLength","(J)V", false, false), // #23 (J)V
                        new global::net.sf.jni4net.core.MemberId("Write","([BII)V", false, false), // #24 ([BII)V
                        new global::net.sf.jni4net.core.MemberId("WriteByte","(B)V", false, false), // #25 (B)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
