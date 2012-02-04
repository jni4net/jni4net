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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Char_))]
    static public partial class Char_
    {
        static Char_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ValueType_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Char_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 ConvertFromUtf32(I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int utf32)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, char.ConvertFromUtf32(utf32), "java.lang.String");
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
        
        /// <signature>#1 ConvertToUtf32(CC)I (CC)I</signature>
        static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char highSurrogate, char lowSurrogate)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = char.ConvertToUtf32(highSurrogate, lowSurrogate);
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
        
        /// <signature>#2 ConvertToUtf32(Ljava/lang/String;I)I (Lsystem/String;I)I</signature>
        static int j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = char.ConvertToUtf32(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#3 GetNumericValue(C)D (C)D</signature>
        static double j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                double j4n_result = char.GetNumericValue(c);
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
        
        /// <signature>#4 GetNumericValue(Ljava/lang/String;I)D (Lsystem/String;I)D</signature>
        static double j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                double j4n_result = char.GetNumericValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#5 GetUnicodeCategory(C)Lsystem/Enum; (C)LSystem/Globalization/UnicodeCategory;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, char.GetUnicodeCategory(c), "system.Enum");
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
        
        /// <signature>#6 GetUnicodeCategory(Ljava/lang/String;I)Lsystem/Enum; (Lsystem/String;I)LSystem/Globalization/UnicodeCategory;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, char.GetUnicodeCategory(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index), "system.Enum");
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
        
        /// <signature>#7 IsControl(C)Z (C)Z</signature>
        static bool j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsControl(c);
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
        
        /// <signature>#8 IsControl(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsControl(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#9 IsDigit(C)Z (C)Z</signature>
        static bool j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsDigit(c);
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
        
        /// <signature>#10 IsDigit(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsDigit(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#11 IsHighSurrogate(C)Z (C)Z</signature>
        static bool j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsHighSurrogate(c);
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
        
        /// <signature>#12 IsHighSurrogate(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsHighSurrogate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#13 IsLetter(C)Z (C)Z</signature>
        static bool j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsLetter(c);
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
        
        /// <signature>#14 IsLetter(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsLetter(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#15 IsLetterOrDigit(C)Z (C)Z</signature>
        static bool j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsLetterOrDigit(c);
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
        
        /// <signature>#16 IsLetterOrDigit(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsLetterOrDigit(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#17 IsLower(C)Z (C)Z</signature>
        static bool j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsLower(c);
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
        
        /// <signature>#18 IsLower(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsLower(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#19 IsLowSurrogate(C)Z (C)Z</signature>
        static bool j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsLowSurrogate(c);
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
        
        /// <signature>#20 IsLowSurrogate(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsLowSurrogate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#21 IsNumber(C)Z (C)Z</signature>
        static bool j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsNumber(c);
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
        
        /// <signature>#22 IsNumber(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsNumber(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#23 IsPunctuation(C)Z (C)Z</signature>
        static bool j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsPunctuation(c);
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
        
        /// <signature>#24 IsPunctuation(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsPunctuation(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#25 IsSeparator(C)Z (C)Z</signature>
        static bool j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsSeparator(c);
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
        
        /// <signature>#26 IsSeparator(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsSeparator(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#27 IsSurrogate(C)Z (C)Z</signature>
        static bool j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsSurrogate(c);
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
        
        /// <signature>#28 IsSurrogate(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsSurrogate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#29 IsSurrogatePair(CC)Z (CC)Z</signature>
        static bool j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char highSurrogate, char lowSurrogate)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsSurrogatePair(highSurrogate, lowSurrogate);
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
        
        /// <signature>#30 IsSurrogatePair(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsSurrogatePair(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#31 IsSymbol(C)Z (C)Z</signature>
        static bool j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsSymbol(c);
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
        
        /// <signature>#32 IsSymbol(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsSymbol(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#33 IsUpper(C)Z (C)Z</signature>
        static bool j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsUpper(c);
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
        
        /// <signature>#34 IsUpper(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsUpper(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#35 IsWhiteSpace(C)Z (C)Z</signature>
        static bool j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = char.IsWhiteSpace(c);
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
        
        /// <signature>#36 IsWhiteSpace(Ljava/lang/String;I)Z (Lsystem/String;I)Z</signature>
        static bool j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = char.IsWhiteSpace(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), index);
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
        
        /// <signature>#37 MaxValue()C ()C</signature>
        static char j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                char j4n_result = char.MaxValue;
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
        
        /// <signature>#38 MinValue()C ()C</signature>
        static char j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                char j4n_result = char.MinValue;
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
        
        /// <signature>#39 Parse(Ljava/lang/String;)C (Lsystem/String;)C</signature>
        static char j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                char j4n_result = char.Parse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s));
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
        
        /// <signature>#40 ToLower(C)C (C)C</signature>
        static char j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                char j4n_result = char.ToLower(c);
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
        
        /// <signature>#41 ToLower(CLsystem/ICloneable;)C (CLSystem/Globalization/CultureInfo;)C</signature>
        static char j4n_41(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                char j4n_result = char.ToLower(c, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture));
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
        
        /// <signature>#42 ToLowerInvariant(C)C (C)C</signature>
        static char j4n_42(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                char j4n_result = char.ToLowerInvariant(c);
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
        
        /// <signature>#43 ToString(C)Ljava/lang/String; (C)Lsystem/String;</signature>
        static global::System.IntPtr j4n_43(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, char.ToString(c), "java.lang.String");
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
        
        /// <signature>#44 ToUpper(C)C (C)C</signature>
        static char j4n_44(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                char j4n_result = char.ToUpper(c);
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
        
        /// <signature>#45 ToUpper(CLsystem/ICloneable;)C (CLSystem/Globalization/CultureInfo;)C</signature>
        static char j4n_45(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                char j4n_result = char.ToUpper(c, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture));
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
        
        /// <signature>#46 ToUpperInvariant(C)C (C)C</signature>
        static char j4n_46(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, char c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                char j4n_result = char.ToUpperInvariant(c);
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
        
        /// <signature>#47 TryParse(Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Lsystem/String;Lnet/sf/jni4net/OutC;)Z</signature>
        static bool j4n_47(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr result)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                char j4n_out_result;
                bool j4n_result = char.TryParse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), out j4n_out_result);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, result, j4n_out_result, "system.Char");
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
        
        /// <signature>#48 CompareTo(C)I (C)I</signature>
        static int j4n_48(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                char j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char>(j4n_env, j4n_self);
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
        
        /// <signature>#49 CompareTo(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_49(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
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
        
        /// <signature>#50 Equals(C)Z (C)Z</signature>
        static bool j4n_50(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char obj)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                char j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char>(j4n_env, j4n_self);
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
        
        /// <signature>#51 GetTypeCode()Lsystem/Enum; ()LSystem/TypeCode;</signature>
        static global::System.IntPtr j4n_51(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#52 ToBoolean(Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
        static bool j4n_52(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#53 ToByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
        static byte j4n_53(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#54 ToChar(Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
        static char j4n_54(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#55 ToDateTime(Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_55(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#56 ToDecimal(Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
        static global::System.IntPtr j4n_56(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#57 ToDouble(Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
        static double j4n_57(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#58 ToInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
        static short j4n_58(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#59 ToInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
        static int j4n_59(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#60 ToInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
        static long j4n_60(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#61 ToSByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)b</signature>
        static sbyte j4n_61(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#62 ToSingle(Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
        static float j4n_62(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#63 ToString(Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_63(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#64 ToType(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_64(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type, global::System.IntPtr provider)
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
        
        /// <signature>#65 ToUInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)s</signature>
        static ushort j4n_65(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#66 ToUInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)i</signature>
        static uint j4n_66(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#67 ToUInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)j</signature>
        static ulong j4n_67(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
            lock (typeof(char))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Char";
                    proxyInfo.JVMProxyName = "system.Char";
                    proxyInfo.JVMStaticApiName = "system.Char";
                    proxyInfo.CLRApi = typeof(System.Char);
                    proxyInfo.CLRStaticApi = typeof(System.Char_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("ConvertFromUtf32","(I)Ljava/lang/String;", false, true), // #0 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ConvertToUtf32","(CC)I", false, true), // #1 (CC)I
                        new global::net.sf.jni4net.core.MemberId("ConvertToUtf32","(Ljava/lang/String;I)I", false, true), // #2 (Ljava/lang/String;I)I
                        new global::net.sf.jni4net.core.MemberId("GetNumericValue","(C)D", false, true), // #3 (C)D
                        new global::net.sf.jni4net.core.MemberId("GetNumericValue","(Ljava/lang/String;I)D", false, true), // #4 (Ljava/lang/String;I)D
                        new global::net.sf.jni4net.core.MemberId("GetUnicodeCategory","(C)Lsystem/Enum;", false, true), // #5 (C)LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("GetUnicodeCategory","(Ljava/lang/String;I)Lsystem/Enum;", false, true), // #6 (Ljava/lang/String;I)LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("IsControl","(C)Z", false, true), // #7 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsControl","(Ljava/lang/String;I)Z", false, true), // #8 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsDigit","(C)Z", false, true), // #9 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsDigit","(Ljava/lang/String;I)Z", false, true), // #10 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsHighSurrogate","(C)Z", false, true), // #11 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsHighSurrogate","(Ljava/lang/String;I)Z", false, true), // #12 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsLetter","(C)Z", false, true), // #13 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsLetter","(Ljava/lang/String;I)Z", false, true), // #14 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsLetterOrDigit","(C)Z", false, true), // #15 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsLetterOrDigit","(Ljava/lang/String;I)Z", false, true), // #16 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsLower","(C)Z", false, true), // #17 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsLower","(Ljava/lang/String;I)Z", false, true), // #18 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsLowSurrogate","(C)Z", false, true), // #19 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsLowSurrogate","(Ljava/lang/String;I)Z", false, true), // #20 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsNumber","(C)Z", false, true), // #21 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsNumber","(Ljava/lang/String;I)Z", false, true), // #22 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsPunctuation","(C)Z", false, true), // #23 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsPunctuation","(Ljava/lang/String;I)Z", false, true), // #24 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsSeparator","(C)Z", false, true), // #25 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsSeparator","(Ljava/lang/String;I)Z", false, true), // #26 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsSurrogate","(C)Z", false, true), // #27 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsSurrogate","(Ljava/lang/String;I)Z", false, true), // #28 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsSurrogatePair","(CC)Z", false, true), // #29 (CC)Z
                        new global::net.sf.jni4net.core.MemberId("IsSurrogatePair","(Ljava/lang/String;I)Z", false, true), // #30 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsSymbol","(C)Z", false, true), // #31 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsSymbol","(Ljava/lang/String;I)Z", false, true), // #32 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsUpper","(C)Z", false, true), // #33 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsUpper","(Ljava/lang/String;I)Z", false, true), // #34 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("IsWhiteSpace","(C)Z", false, true), // #35 (C)Z
                        new global::net.sf.jni4net.core.MemberId("IsWhiteSpace","(Ljava/lang/String;I)Z", false, true), // #36 (Ljava/lang/String;I)Z
                        new global::net.sf.jni4net.core.MemberId("MaxValue","()C", true, true), // #37 ()C
                        new global::net.sf.jni4net.core.MemberId("MinValue","()C", true, true), // #38 ()C
                        new global::net.sf.jni4net.core.MemberId("Parse","(Ljava/lang/String;)C", false, true), // #39 (Ljava/lang/String;)C
                        new global::net.sf.jni4net.core.MemberId("ToLower","(C)C", false, true), // #40 (C)C
                        new global::net.sf.jni4net.core.MemberId("ToLower","(CLsystem/ICloneable;)C", false, true), // #41 (CLSystem/ICloneable;)C
                        new global::net.sf.jni4net.core.MemberId("ToLowerInvariant","(C)C", false, true), // #42 (C)C
                        new global::net.sf.jni4net.core.MemberId("ToString","(C)Ljava/lang/String;", false, true), // #43 (C)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToUpper","(C)C", false, true), // #44 (C)C
                        new global::net.sf.jni4net.core.MemberId("ToUpper","(CLsystem/ICloneable;)C", false, true), // #45 (CLSystem/ICloneable;)C
                        new global::net.sf.jni4net.core.MemberId("ToUpperInvariant","(C)C", false, true), // #46 (C)C
                        new global::net.sf.jni4net.core.MemberId("TryParse","(Ljava/lang/String;Lnet/sf/jni4net/Out;)Z", false, true), // #47 (Ljava/lang/String;Lnet/sf/jni4net/OutC;)Z
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(C)I", false, false), // #48 (C)I
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Ljava/lang/Object;)I", false, false), // #49 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Equals","(C)Z", false, false), // #50 (C)Z
                        new global::net.sf.jni4net.core.MemberId("GetTypeCode","()Lsystem/Enum;", false, false), // #51 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("ToBoolean","(Lsystem/IFormatProvider;)Z", false, false), // #52 (LSystem/IFormatProvider;)Z
                        new global::net.sf.jni4net.core.MemberId("ToByte","(Lsystem/IFormatProvider;)B", false, false), // #53 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToChar","(Lsystem/IFormatProvider;)C", false, false), // #54 (LSystem/IFormatProvider;)C
                        new global::net.sf.jni4net.core.MemberId("ToDateTime","(Lsystem/IFormatProvider;)Lsystem/DateTime;", false, false), // #55 (LSystem/IFormatProvider;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ToDecimal","(Lsystem/IFormatProvider;)Lsystem/Decimal;", false, false), // #56 (LSystem/IFormatProvider;)LSystem/Decimal;
                        new global::net.sf.jni4net.core.MemberId("ToDouble","(Lsystem/IFormatProvider;)D", false, false), // #57 (LSystem/IFormatProvider;)D
                        new global::net.sf.jni4net.core.MemberId("ToInt16","(Lsystem/IFormatProvider;)S", false, false), // #58 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToInt32","(Lsystem/IFormatProvider;)I", false, false), // #59 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToInt64","(Lsystem/IFormatProvider;)J", false, false), // #60 (LSystem/IFormatProvider;)J
                        new global::net.sf.jni4net.core.MemberId("ToSByte","(Lsystem/IFormatProvider;)B", false, false), // #61 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToSingle","(Lsystem/IFormatProvider;)F", false, false), // #62 (LSystem/IFormatProvider;)F
                        new global::net.sf.jni4net.core.MemberId("ToString","(Lsystem/IFormatProvider;)Ljava/lang/String;", false, false), // #63 (LSystem/IFormatProvider;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToType","(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object;", false, false), // #64 (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToUInt16","(Lsystem/IFormatProvider;)S", false, false), // #65 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToUInt32","(Lsystem/IFormatProvider;)I", false, false), // #66 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToUInt64","(Lsystem/IFormatProvider;)J", false, false), // #67 (LSystem/IFormatProvider;)J
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
