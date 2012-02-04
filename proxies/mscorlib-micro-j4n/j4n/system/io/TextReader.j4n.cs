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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.IO.TextReader_))]
    static public partial class TextReader_
    {
        static TextReader_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.MarshalByRefObject_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IDisposable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IDisposable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.IO.TextReader_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 Null()Lsystem/io/TextReader; ()LSystem/IO/TextReader;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.IO.TextReader.Null, "system.io.TextReader");
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
        
        /// <signature>#1 Synchronized(Lsystem/io/TextReader;)Lsystem/io/TextReader; (LSystem/IO/TextReader;)LSystem/IO/TextReader;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr reader)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.IO.TextReader.Synchronized(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, reader)), "system.io.TextReader");
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
                global::System.IO.TextReader j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, j4n_self);
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
        
        /// <signature>#4 Peek()I ()I</signature>
        static int j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextReader j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Peek();
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
        
        /// <signature>#5 Read()I ()I</signature>
        static int j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextReader j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Read();
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
        
        /// <signature>#6 Read([CII)I ([CII)I</signature>
        static int j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer, int index, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.IO.TextReader j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Read(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer), index, count);
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
        
        /// <signature>#7 ReadBlock([CII)I ([CII)I</signature>
        static int j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr buffer, int index, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.IO.TextReader j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, j4n_self);
                int j4n_result = j4n_real.ReadBlock(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, buffer), index, count);
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
        
        /// <signature>#8 ReadLine()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextReader j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ReadLine(), "java.lang.String");
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
        
        /// <signature>#9 ReadToEnd()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.TextReader j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.TextReader>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ReadToEnd(), "java.lang.String");
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
            lock (typeof(global::System.IO.TextReader))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.io.TextReader";
                    proxyInfo.JVMProxyName = "system.io.TextReader";
                    proxyInfo.JVMStaticApiName = "system.io.TextReader";
                    proxyInfo.CLRApi = typeof(System.IO.TextReader);
                    proxyInfo.CLRStaticApi = typeof(System.IO.TextReader_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Null","()Lsystem/io/TextReader;", true, true), // #0 ()LSystem/IO/TextReader;
                        new global::net.sf.jni4net.core.MemberId("Synchronized","(Lsystem/io/TextReader;)Lsystem/io/TextReader;", false, true), // #1 (LSystem/IO/TextReader;)LSystem/IO/TextReader;
                        new global::net.sf.jni4net.core.MemberId("Close","()V", false, false), // #2 ()V
                        new global::net.sf.jni4net.core.MemberId("Dispose","()V", false, false), // #3 ()V
                        new global::net.sf.jni4net.core.MemberId("Peek","()I", false, false), // #4 ()I
                        new global::net.sf.jni4net.core.MemberId("Read","()I", false, false), // #5 ()I
                        new global::net.sf.jni4net.core.MemberId("Read","([CII)I", false, false), // #6 ([CII)I
                        new global::net.sf.jni4net.core.MemberId("ReadBlock","([CII)I", false, false), // #7 ([CII)I
                        new global::net.sf.jni4net.core.MemberId("ReadLine","()Ljava/lang/String;", false, false), // #8 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ReadToEnd","()Ljava/lang/String;", false, false), // #9 ()Ljava/lang/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
