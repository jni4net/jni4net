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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Guid_))]
    static public partial class Guid_
    {
        static Guid_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ValueType_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IFormattable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IFormattable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Guid_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor([B)V ([B)V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr b)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Guid(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, b)));
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
        
        /// <signature>#1 .ctor(ISS[B)V (ISS[B)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int a, short b, short c, global::System.IntPtr d)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Guid(a, b, c, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, d)));
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
        
        /// <signature>#2 .ctor(ISSBBBBBBBB)V (ISSBBBBBBBB)V</signature>
        static long j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 32);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Guid(a, b, c, d, e, f, g, h, i, j, k));
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
        
        /// <signature>#3 .ctor(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static long j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr g)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Guid(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, g)));
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
        
        /// <signature>#4 .ctor(ISSBBBBBBBB)V (issBBBBBBBB)V</signature>
        static long j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 32);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Guid(a, b, c, d, e, f, g, h, i, j, k));
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
        
        /// <signature>#5 Empty()Lsystem/Guid; ()LSystem/Guid;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Guid.Empty, "system.Guid");
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
        
        /// <signature>#6 NewGuid()Lsystem/Guid; ()LSystem/Guid;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Guid.NewGuid(), "system.Guid");
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
        
        /// <signature>#7 CompareTo(Lsystem/Guid;)I (LSystem/Guid;)I</signature>
        static int j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Guid j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, j4n_self);
                int j4n_result = j4n_real.CompareTo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, value));
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
        
        /// <signature>#8 CompareTo(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IComparable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IComparable>(j4n_env, j4n_self);
                int j4n_result = j4n_real.CompareTo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#9 Equals(Lsystem/Guid;)Z (LSystem/Guid;)Z</signature>
        static bool j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr g)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Guid j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, g));
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
        
        /// <signature>#10 ToByteArray()[B ()[B</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Guid j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToByteArray(), "byte");
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
        
        /// <signature>#11 ToString(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Guid j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToString(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format)), "java.lang.String");
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
        
        /// <signature>#12 ToString(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Lsystem/String;LSystem/IFormatProvider;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IFormattable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormattable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToString(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "java.lang.String");
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
            lock (typeof(global::System.Guid))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Guid";
                    proxyInfo.JVMProxyName = "system.Guid";
                    proxyInfo.JVMStaticApiName = "system.Guid";
                    proxyInfo.CLRApi = typeof(System.Guid);
                    proxyInfo.CLRStaticApi = typeof(System.Guid_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","([B)V", false, false), // #0 ([B)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(ISS[B)V", false, false), // #1 (ISS[B)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(ISSBBBBBBBB)V", false, false), // #2 (ISSBBBBBBBB)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #3 (Ljava/lang/String;)V
                        null, // #4 IsJvmSkip: .ctor
                        new global::net.sf.jni4net.core.MemberId("Empty","()Lsystem/Guid;", true, true), // #5 ()LSystem/Guid;
                        new global::net.sf.jni4net.core.MemberId("NewGuid","()Lsystem/Guid;", false, true), // #6 ()LSystem/Guid;
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Lsystem/Guid;)I", false, false), // #7 (LSystem/Guid;)I
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Ljava/lang/Object;)I", false, false), // #8 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Equals","(Lsystem/Guid;)Z", false, false), // #9 (LSystem/Guid;)Z
                        new global::net.sf.jni4net.core.MemberId("ToByteArray","()[B", false, false), // #10 ()[B
                        new global::net.sf.jni4net.core.MemberId("ToString","(Ljava/lang/String;)Ljava/lang/String;", false, false), // #11 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToString","(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;", false, false), // #12 (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
