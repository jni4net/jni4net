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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Boolean_))]
    static public partial class Boolean_
    {
        static Boolean_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ValueType_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Boolean_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 FalseString()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, bool.FalseString, "java.lang.String");
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
        
        /// <signature>#1 Parse(Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static bool j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = bool.Parse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
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
        
        /// <signature>#2 TrueString()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, bool.TrueString, "java.lang.String");
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
        
        /// <signature>#3 TryParse(Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Lsystem/String;Lnet/sf/jni4net/OutZ;)Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value, global::System.IntPtr result)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_out_result;
                bool j4n_result = bool.TryParse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), out j4n_out_result);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, result, j4n_out_result, "system.Boolean");
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
        
        /// <signature>#4 CompareTo(Z)I (Z)I</signature>
        static int j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<bool>(j4n_env, j4n_self);
                int j4n_result = j4n_real.CompareTo(value);
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
        
        /// <signature>#5 CompareTo(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IComparable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IComparable>(j4n_env, j4n_self);
                int j4n_result = j4n_real.CompareTo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj));
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
        
        /// <signature>#6 Equals(Z)Z (Z)Z</signature>
        static bool j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool obj)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<bool>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Equals(obj);
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
        
        /// <signature>#7 GetTypeCode()Lsystem/Enum; ()LSystem/TypeCode;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetTypeCode(), "system.Enum");
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
        
        /// <signature>#8 ToBoolean(Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
        static bool j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.ToBoolean(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#9 ToByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
        static byte j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                byte j4n_result = j4n_real.ToByte(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#10 ToChar(Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
        static char j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                char j4n_result = j4n_real.ToChar(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#11 ToDateTime(Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToDateTime(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "system.DateTime");
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
        
        /// <signature>#12 ToDecimal(Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToDecimal(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "system.Decimal");
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
        
        /// <signature>#13 ToDouble(Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
        static double j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                double j4n_result = j4n_real.ToDouble(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#14 ToInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
        static short j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                short j4n_result = j4n_real.ToInt16(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#15 ToInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
        static int j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                int j4n_result = j4n_real.ToInt32(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#16 ToInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
        static long j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                long j4n_result = j4n_real.ToInt64(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#17 ToSByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)b</signature>
        static sbyte j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                sbyte j4n_result = j4n_real.ToSByte(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#18 ToSingle(Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
        static float j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                float j4n_result = j4n_real.ToSingle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#19 ToString(Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToString(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "java.lang.String");
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
        
        /// <signature>#20 ToType(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "java.lang.Object");
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
        
        /// <signature>#21 ToUInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)s</signature>
        static ushort j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                ushort j4n_result = j4n_real.ToUInt16(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#22 ToUInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)i</signature>
        static uint j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                uint j4n_result = j4n_real.ToUInt32(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#23 ToUInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)j</signature>
        static ulong j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                ulong j4n_result = j4n_real.ToUInt64(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(bool))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Boolean";
                    proxyInfo.JVMProxyName = "system.Boolean";
                    proxyInfo.JVMStaticApiName = "system.Boolean";
                    proxyInfo.CLRApi = typeof(System.Boolean);
                    proxyInfo.CLRStaticApi = typeof(System.Boolean_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("FalseString","()Ljava/lang/String;", true, true), // #0 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Parse","(Ljava/lang/String;)Z", false, true), // #1 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("TrueString","()Ljava/lang/String;", true, true), // #2 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("TryParse","(Ljava/lang/String;Lnet/sf/jni4net/Out;)Z", false, true), // #3 (Ljava/lang/String;Lnet/sf/jni4net/OutZ;)Z
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Z)I", false, false), // #4 (Z)I
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Ljava/lang/Object;)I", false, false), // #5 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Equals","(Z)Z", false, false), // #6 (Z)Z
                        new global::net.sf.jni4net.core.MemberId("GetTypeCode","()Lsystem/Enum;", false, false), // #7 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("ToBoolean","(Lsystem/IFormatProvider;)Z", false, false), // #8 (LSystem/IFormatProvider;)Z
                        new global::net.sf.jni4net.core.MemberId("ToByte","(Lsystem/IFormatProvider;)B", false, false), // #9 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToChar","(Lsystem/IFormatProvider;)C", false, false), // #10 (LSystem/IFormatProvider;)C
                        new global::net.sf.jni4net.core.MemberId("ToDateTime","(Lsystem/IFormatProvider;)Lsystem/DateTime;", false, false), // #11 (LSystem/IFormatProvider;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ToDecimal","(Lsystem/IFormatProvider;)Lsystem/Decimal;", false, false), // #12 (LSystem/IFormatProvider;)LSystem/Decimal;
                        new global::net.sf.jni4net.core.MemberId("ToDouble","(Lsystem/IFormatProvider;)D", false, false), // #13 (LSystem/IFormatProvider;)D
                        new global::net.sf.jni4net.core.MemberId("ToInt16","(Lsystem/IFormatProvider;)S", false, false), // #14 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToInt32","(Lsystem/IFormatProvider;)I", false, false), // #15 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToInt64","(Lsystem/IFormatProvider;)J", false, false), // #16 (LSystem/IFormatProvider;)J
                        new global::net.sf.jni4net.core.MemberId("ToSByte","(Lsystem/IFormatProvider;)B", false, false), // #17 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToSingle","(Lsystem/IFormatProvider;)F", false, false), // #18 (LSystem/IFormatProvider;)F
                        new global::net.sf.jni4net.core.MemberId("ToString","(Lsystem/IFormatProvider;)Ljava/lang/String;", false, false), // #19 (LSystem/IFormatProvider;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToType","(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object;", false, false), // #20 (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToUInt16","(Lsystem/IFormatProvider;)S", false, false), // #21 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToUInt32","(Lsystem/IFormatProvider;)I", false, false), // #22 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToUInt64","(Lsystem/IFormatProvider;)J", false, false), // #23 (LSystem/IFormatProvider;)J
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
