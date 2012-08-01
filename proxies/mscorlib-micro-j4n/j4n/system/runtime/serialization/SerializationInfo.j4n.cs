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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Runtime.Serialization.SerializationInfo_))]
    static public partial class SerializationInfo_
    {
        static SerializationInfo_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Runtime.Serialization.SerializationInfo_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor(Lsystem/Type;Lsystem/Object;)V (LSystem/Type;LSystem/Runtime/Serialization/IFormatterConverter;)V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type, global::System.IntPtr converter)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Runtime.Serialization.SerializationInfo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.IFormatterConverter>(j4n_env, converter)));
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
        
        /// <signature>#1 .ctor(Lsystem/Type;Lsystem/Object;Z)V (LSystem/Type;LSystem/Runtime/Serialization/IFormatterConverter;Z)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type, global::System.IntPtr converter, bool requireSameTokenInPartialTrust)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Runtime.Serialization.SerializationInfo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.IFormatterConverter>(j4n_env, converter), requireSameTokenInPartialTrust));
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
        
        /// <signature>#2 AddValue(Ljava/lang/String;Z)V (Lsystem/String;Z)V</signature>
        static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 AddValue(Ljava/lang/String;B)V (Lsystem/String;B)V</signature>
        static void j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, byte value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#4 AddValue(Ljava/lang/String;C)V (Lsystem/String;C)V</signature>
        static void j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, char value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#5 AddValue(Ljava/lang/String;Lsystem/DateTime;)V (Lsystem/String;LSystem/DateTime;)V</signature>
        static void j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#6 AddValue(Ljava/lang/String;Lsystem/Decimal;)V (Lsystem/String;LSystem/Decimal;)V</signature>
        static void j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Decimal>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#7 AddValue(Ljava/lang/String;D)V (Lsystem/String;D)V</signature>
        static void j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#8 AddValue(Ljava/lang/String;S)V (Lsystem/String;S)V</signature>
        static void j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, short value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#9 AddValue(Ljava/lang/String;I)V (Lsystem/String;I)V</signature>
        static void j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#10 AddValue(Ljava/lang/String;J)V (Lsystem/String;J)V</signature>
        static void j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#11 AddValue(Ljava/lang/String;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;)V</signature>
        static void j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#12 AddValue(Ljava/lang/String;Ljava/lang/Object;Lsystem/Type;)V (Lsystem/String;Lsystem/Object;LSystem/Type;)V</signature>
        static void j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr value, global::System.IntPtr type)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#13 AddValue(Ljava/lang/String;B)V (Lsystem/String;b)V</signature>
        static void j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, sbyte value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#14 AddValue(Ljava/lang/String;F)V (Lsystem/String;F)V</signature>
        static void j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, float value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#15 AddValue(Ljava/lang/String;S)V (Lsystem/String;s)V</signature>
        static void j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, ushort value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#16 AddValue(Ljava/lang/String;I)V (Lsystem/String;i)V</signature>
        static void j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, uint value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#17 AddValue(Ljava/lang/String;J)V (Lsystem/String;j)V</signature>
        static void j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, ulong value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AddValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#18 get_AssemblyName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AssemblyName, "java.lang.String");
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
        
        /// <signature>#19 get_FullTypeName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.FullTypeName, "java.lang.String");
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
        
        /// <signature>#20 get_MemberCount()I ()I</signature>
        static int j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                int j4n_result = j4n_real.MemberCount;
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
        
        /// <signature>#21 GetBoolean(Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static bool j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.GetBoolean(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
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
        
        /// <signature>#22 GetByte(Ljava/lang/String;)B (Lsystem/String;)B</signature>
        static byte j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                byte j4n_result = j4n_real.GetByte(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(byte);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#23 GetChar(Ljava/lang/String;)C (Lsystem/String;)C</signature>
        static char j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                char j4n_result = j4n_real.GetChar(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
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
        
        /// <signature>#24 GetDateTime(Ljava/lang/String;)Lsystem/DateTime; (Lsystem/String;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetDateTime(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.DateTime");
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
        
        /// <signature>#25 GetDecimal(Ljava/lang/String;)Lsystem/Decimal; (Lsystem/String;)LSystem/Decimal;</signature>
        static global::System.IntPtr j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetDecimal(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.Decimal");
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
        
        /// <signature>#26 GetDouble(Ljava/lang/String;)D (Lsystem/String;)D</signature>
        static double j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                double j4n_result = j4n_real.GetDouble(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(double);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#27 GetEnumerator()Lsystem/collections/IEnumerator; ()LSystem/Runtime/Serialization/SerializationInfoEnumerator;</signature>
        static global::System.IntPtr j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetEnumerator(), "system.collections.IEnumerator");
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
        
        /// <signature>#28 GetInt16(Ljava/lang/String;)S (Lsystem/String;)S</signature>
        static short j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                short j4n_result = j4n_real.GetInt16(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(short);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#29 GetInt32(Ljava/lang/String;)I (Lsystem/String;)I</signature>
        static int j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                int j4n_result = j4n_real.GetInt32(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
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
        
        /// <signature>#30 GetInt64(Ljava/lang/String;)J (Lsystem/String;)J</signature>
        static long j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                long j4n_result = j4n_real.GetInt64(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
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
        
        /// <signature>#31 GetSByte(Ljava/lang/String;)B (Lsystem/String;)b</signature>
        static sbyte j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                sbyte j4n_result = j4n_real.GetSByte(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(sbyte);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#32 GetSingle(Ljava/lang/String;)F (Lsystem/String;)F</signature>
        static float j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                float j4n_result = j4n_real.GetSingle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(float);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#33 GetString(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetString(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "java.lang.String");
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
        
        /// <signature>#34 GetUInt16(Ljava/lang/String;)S (Lsystem/String;)s</signature>
        static ushort j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                ushort j4n_result = j4n_real.GetUInt16(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(ushort);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#35 GetUInt32(Ljava/lang/String;)I (Lsystem/String;)i</signature>
        static uint j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                uint j4n_result = j4n_real.GetUInt32(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(uint);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#36 GetUInt64(Ljava/lang/String;)J (Lsystem/String;)j</signature>
        static ulong j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                ulong j4n_result = j4n_real.GetUInt64(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(ulong);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#37 GetValue(Ljava/lang/String;Lsystem/Type;)Ljava/lang/Object; (Lsystem/String;LSystem/Type;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr type)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type)), "java.lang.Object");
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
        
        /// <signature>#38 set_AssemblyName(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.AssemblyName = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#39 set_FullTypeName(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.FullTypeName = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#40 SetType(Lsystem/Type;)V (LSystem/Type;)V</signature>
        static void j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Runtime.Serialization.SerializationInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, j4n_self);
                j4n_real.SetType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type));
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
            lock (typeof(global::System.Runtime.Serialization.SerializationInfo))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.runtime.serialization.SerializationInfo";
                    proxyInfo.JVMProxyName = "system.runtime.serialization.SerializationInfo";
                    proxyInfo.JVMStaticApiName = "system.runtime.serialization.SerializationInfo";
                    proxyInfo.CLRApi = typeof(System.Runtime.Serialization.SerializationInfo);
                    proxyInfo.CLRStaticApi = typeof(System.Runtime.Serialization.SerializationInfo_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Lsystem/Type;Lsystem/Object;)V", false, false), // #0 (LSystem/Type;Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Lsystem/Type;Lsystem/Object;Z)V", false, false), // #1 (LSystem/Type;Lsystem/Object;Z)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;Z)V", false, false), // #2 (Ljava/lang/String;Z)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;B)V", false, false), // #3 (Ljava/lang/String;B)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;C)V", false, false), // #4 (Ljava/lang/String;C)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;Lsystem/DateTime;)V", false, false), // #5 (Ljava/lang/String;LSystem/DateTime;)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;Lsystem/Decimal;)V", false, false), // #6 (Ljava/lang/String;LSystem/Decimal;)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;D)V", false, false), // #7 (Ljava/lang/String;D)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;S)V", false, false), // #8 (Ljava/lang/String;S)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;I)V", false, false), // #9 (Ljava/lang/String;I)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;J)V", false, false), // #10 (Ljava/lang/String;J)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;Ljava/lang/Object;)V", false, false), // #11 (Ljava/lang/String;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;Ljava/lang/Object;Lsystem/Type;)V", false, false), // #12 (Ljava/lang/String;Ljava/lang/Object;LSystem/Type;)V
                        null, // #13 IsJvmSkip: AddValue
                        new global::net.sf.jni4net.core.MemberId("AddValue","(Ljava/lang/String;F)V", false, false), // #14 (Ljava/lang/String;F)V
                        null, // #15 IsJvmSkip: AddValue
                        null, // #16 IsJvmSkip: AddValue
                        null, // #17 IsJvmSkip: AddValue
                        new global::net.sf.jni4net.core.MemberId("getAssemblyName","()Ljava/lang/String;", false, false), // #18 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getFullTypeName","()Ljava/lang/String;", false, false), // #19 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getMemberCount","()I", false, false), // #20 ()I
                        new global::net.sf.jni4net.core.MemberId("GetBoolean","(Ljava/lang/String;)Z", false, false), // #21 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("GetByte","(Ljava/lang/String;)B", false, false), // #22 (Ljava/lang/String;)B
                        new global::net.sf.jni4net.core.MemberId("GetChar","(Ljava/lang/String;)C", false, false), // #23 (Ljava/lang/String;)C
                        new global::net.sf.jni4net.core.MemberId("GetDateTime","(Ljava/lang/String;)Lsystem/DateTime;", false, false), // #24 (Ljava/lang/String;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("GetDecimal","(Ljava/lang/String;)Lsystem/Decimal;", false, false), // #25 (Ljava/lang/String;)LSystem/Decimal;
                        new global::net.sf.jni4net.core.MemberId("GetDouble","(Ljava/lang/String;)D", false, false), // #26 (Ljava/lang/String;)D
                        new global::net.sf.jni4net.core.MemberId("GetEnumerator","()Lsystem/collections/IEnumerator;", false, false), // #27 ()LSystem/Collections/IEnumerator;
                        new global::net.sf.jni4net.core.MemberId("GetInt16","(Ljava/lang/String;)S", false, false), // #28 (Ljava/lang/String;)S
                        new global::net.sf.jni4net.core.MemberId("GetInt32","(Ljava/lang/String;)I", false, false), // #29 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("GetInt64","(Ljava/lang/String;)J", false, false), // #30 (Ljava/lang/String;)J
                        new global::net.sf.jni4net.core.MemberId("GetSByte","(Ljava/lang/String;)B", false, false), // #31 (Ljava/lang/String;)B
                        new global::net.sf.jni4net.core.MemberId("GetSingle","(Ljava/lang/String;)F", false, false), // #32 (Ljava/lang/String;)F
                        new global::net.sf.jni4net.core.MemberId("GetString","(Ljava/lang/String;)Ljava/lang/String;", false, false), // #33 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetUInt16","(Ljava/lang/String;)S", false, false), // #34 (Ljava/lang/String;)S
                        new global::net.sf.jni4net.core.MemberId("GetUInt32","(Ljava/lang/String;)I", false, false), // #35 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("GetUInt64","(Ljava/lang/String;)J", false, false), // #36 (Ljava/lang/String;)J
                        new global::net.sf.jni4net.core.MemberId("GetValue","(Ljava/lang/String;Lsystem/Type;)Ljava/lang/Object;", false, false), // #37 (Ljava/lang/String;LSystem/Type;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("setAssemblyName","(Ljava/lang/String;)V", false, false), // #38 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("setFullTypeName","(Ljava/lang/String;)V", false, false), // #39 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("SetType","(Lsystem/Type;)V", false, false), // #40 (LSystem/Type;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
