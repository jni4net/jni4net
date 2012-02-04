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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.String_))]
    static public partial class String_
    {
        static String_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.ICloneable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ICloneable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Collections.IEnumerable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Collections.IEnumerable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.String_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor([C)V ([C)V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new string(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, value)));
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
        
        /// <signature>#1 .ctor([CII)V ([CII)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new string(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, value), startIndex, length));
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
        
        /// <signature>#2 .ctor(CI)V (CI)V</signature>
        static long j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char c, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new string(c, count));
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
        
        /// <signature>#3 Compare(Ljava/lang/String;ILjava/lang/String;II)I (Lsystem/String;ILsystem/String;II)I</signature>
        static int j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, int indexA, global::System.IntPtr strB, int indexB, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), indexA, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), indexB, length);
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
        
        /// <signature>#4 Compare(Ljava/lang/String;ILjava/lang/String;IIZ)I (Lsystem/String;ILsystem/String;IIZ)I</signature>
        static int j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, int indexA, global::System.IntPtr strB, int indexB, int length, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), indexA, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), indexB, length, ignoreCase);
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
        
        /// <signature>#5 Compare(Ljava/lang/String;ILjava/lang/String;IIZLsystem/ICloneable;)I (Lsystem/String;ILsystem/String;IIZLSystem/Globalization/CultureInfo;)I</signature>
        static int j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, int indexA, global::System.IntPtr strB, int indexB, int length, bool ignoreCase, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 24);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), indexA, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), indexB, length, ignoreCase, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture));
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
        
        /// <signature>#6 Compare(Ljava/lang/String;ILjava/lang/String;IILsystem/ICloneable;Lsystem/Enum;)I (Lsystem/String;ILsystem/String;IILSystem/Globalization/CultureInfo;LSystem/Globalization/CompareOptions;)I</signature>
        static int j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, int indexA, global::System.IntPtr strB, int indexB, int length, global::System.IntPtr culture, global::System.IntPtr options)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 24);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), indexA, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), indexB, length, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CompareOptions>(j4n_env, options));
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
        
        /// <signature>#7 Compare(Ljava/lang/String;ILjava/lang/String;IILsystem/Enum;)I (Lsystem/String;ILsystem/String;IILSystem/StringComparison;)I</signature>
        static int j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, int indexA, global::System.IntPtr strB, int indexB, int length, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), indexA, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), indexB, length, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#8 Compare(Ljava/lang/String;Ljava/lang/String;)I (Lsystem/String;Lsystem/String;)I</signature>
        static int j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, global::System.IntPtr strB)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB));
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
        
        /// <signature>#9 Compare(Ljava/lang/String;Ljava/lang/String;Z)I (Lsystem/String;Lsystem/String;Z)I</signature>
        static int j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, global::System.IntPtr strB, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), ignoreCase);
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
        
        /// <signature>#10 Compare(Ljava/lang/String;Ljava/lang/String;ZLsystem/ICloneable;)I (Lsystem/String;Lsystem/String;ZLSystem/Globalization/CultureInfo;)I</signature>
        static int j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, global::System.IntPtr strB, bool ignoreCase, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), ignoreCase, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture));
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
        
        /// <signature>#11 Compare(Ljava/lang/String;Ljava/lang/String;Lsystem/ICloneable;Lsystem/Enum;)I (Lsystem/String;Lsystem/String;LSystem/Globalization/CultureInfo;LSystem/Globalization/CompareOptions;)I</signature>
        static int j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, global::System.IntPtr strB, global::System.IntPtr culture, global::System.IntPtr options)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CompareOptions>(j4n_env, options));
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
        
        /// <signature>#12 Compare(Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)I (Lsystem/String;Lsystem/String;LSystem/StringComparison;)I</signature>
        static int j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, global::System.IntPtr strB, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                int j4n_result = string.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#13 CompareOrdinal(Ljava/lang/String;ILjava/lang/String;II)I (Lsystem/String;ILsystem/String;II)I</signature>
        static int j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, int indexA, global::System.IntPtr strB, int indexB, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                int j4n_result = string.CompareOrdinal(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), indexA, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB), indexB, length);
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
        
        /// <signature>#14 CompareOrdinal(Ljava/lang/String;Ljava/lang/String;)I (Lsystem/String;Lsystem/String;)I</signature>
        static int j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr strA, global::System.IntPtr strB)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = string.CompareOrdinal(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB));
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
        
        /// <signature>#15 Concat([Ljava/lang/Object;)Ljava/lang/String; ([Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr args)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args)), "java.lang.String");
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
        
        /// <signature>#16 Concat([Ljava/lang/String;)Ljava/lang/String; ([Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr values)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, values)), "java.lang.String");
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
        
        /// <signature>#17 Concat(Ljava/lang/Object;)Ljava/lang/String; (Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr arg0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0)), "java.lang.String");
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
        
        /// <signature>#18 Concat(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Lsystem/Object;Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr arg0, global::System.IntPtr arg1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1)), "java.lang.String");
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
        
        /// <signature>#19 Concat(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Lsystem/Object;Lsystem/Object;Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2)), "java.lang.String");
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
        
        /// <signature>#20 Concat(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2, global::System.IntPtr arg3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg3)), "java.lang.String");
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
        
        /// <signature>#21 Concat(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr str0, global::System.IntPtr str1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str1)), "java.lang.String");
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
        
        /// <signature>#22 Concat(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;Lsystem/String;Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr str0, global::System.IntPtr str1, global::System.IntPtr str2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str2)), "java.lang.String");
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
        
        /// <signature>#23 Concat(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;Lsystem/String;Lsystem/String;Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr str0, global::System.IntPtr str1, global::System.IntPtr str2, global::System.IntPtr str3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Concat(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str2), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str3)), "java.lang.String");
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
        
        /// <signature>#24 Copy(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr str)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Copy(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str)), "java.lang.String");
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
        
        /// <signature>#25 Empty()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Empty, "java.lang.String");
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
        
        /// <signature>#26 Equals(Ljava/lang/String;Ljava/lang/String;)Z (Lsystem/String;Lsystem/String;)Z</signature>
        static bool j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr a, global::System.IntPtr b)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = string.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, a), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, b));
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
        
        /// <signature>#27 Equals(Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)Z (Lsystem/String;Lsystem/String;LSystem/StringComparison;)Z</signature>
        static bool j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr a, global::System.IntPtr b, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                bool j4n_result = string.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, a), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, b), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#28 Format(Lsystem/IFormatProvider;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String; (LSystem/IFormatProvider;Lsystem/String;[Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr provider, global::System.IntPtr format, global::System.IntPtr args)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Format(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args)), "java.lang.String");
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
        
        /// <signature>#29 Format(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String; (Lsystem/String;[Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr args)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Format(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args)), "java.lang.String");
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
        
        /// <signature>#30 Format(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String; (Lsystem/String;Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Format(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0)), "java.lang.String");
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
        
        /// <signature>#31 Format(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Lsystem/String;Lsystem/Object;Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Format(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1)), "java.lang.String");
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
        
        /// <signature>#32 Format(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Lsystem/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Format(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, arg2)), "java.lang.String");
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
        
        /// <signature>#33 Intern(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr str)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Intern(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str)), "java.lang.String");
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
        
        /// <signature>#34 IsInterned(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr str)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.IsInterned(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, str)), "java.lang.String");
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
        
        /// <signature>#35 IsNullOrEmpty(Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static bool j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = string.IsNullOrEmpty(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
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
        
        /// <signature>#36 Join(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;[Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr separator, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Join(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, separator), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, value)), "java.lang.String");
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
        
        /// <signature>#37 Join(Ljava/lang/String;[Ljava/lang/String;II)Ljava/lang/String; (Lsystem/String;[Lsystem/String;II)Lsystem/String;</signature>
        static global::System.IntPtr j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr separator, global::System.IntPtr value, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, string.Join(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, separator), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, value), startIndex, count), "java.lang.String");
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
        
        /// <signature>#38 Clone()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.ICloneable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ICloneable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Clone(), "java.lang.Object");
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
        
        /// <signature>#39 CompareTo(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
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
        
        /// <signature>#40 CompareTo(Ljava/lang/String;)I (Lsystem/String;)I</signature>
        static int j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr strB)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.CompareTo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, strB));
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
        
        /// <signature>#41 Contains(Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static bool j4n_41(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Contains(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
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
        
        /// <signature>#42 CopyTo(I[CII)V (I[CII)V</signature>
        static void j4n_42(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int sourceIndex, global::System.IntPtr destination, int destinationIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_real.CopyTo(sourceIndex, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, destination), destinationIndex, count);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#43 EndsWith(Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static bool j4n_43(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.EndsWith(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
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
        
        /// <signature>#44 EndsWith(Ljava/lang/String;ZLsystem/ICloneable;)Z (Lsystem/String;ZLSystem/Globalization/CultureInfo;)Z</signature>
        static bool j4n_44(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, bool ignoreCase, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.EndsWith(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), ignoreCase, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture));
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
        
        /// <signature>#45 EndsWith(Ljava/lang/String;Lsystem/Enum;)Z (Lsystem/String;LSystem/StringComparison;)Z</signature>
        static bool j4n_45(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.EndsWith(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#46 Equals(Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static bool j4n_46(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
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
        
        /// <signature>#47 Equals(Ljava/lang/String;Lsystem/Enum;)Z (Lsystem/String;LSystem/StringComparison;)Z</signature>
        static bool j4n_47(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#48 get_Chars(I)C (I)C</signature>
        static char j4n_48(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                char j4n_result = j4n_real[index];
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
        
        /// <signature>#49 get_Length()I ()I</signature>
        static int j4n_49(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Length;
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
        
        /// <signature>#50 GetEnumerator()Lsystem/CharEnumerator; ()LSystem/CharEnumerator;</signature>
        static global::System.IntPtr j4n_50(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetEnumerator(), "system.CharEnumerator");
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
        
        /// <signature>#51 GetEnumerator()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
        static global::System.IntPtr j4n_51(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.IEnumerable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IEnumerable>(j4n_env, j4n_self);
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
        
        /// <signature>#52 GetTypeCode()Lsystem/Enum; ()LSystem/TypeCode;</signature>
        static global::System.IntPtr j4n_52(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#53 IndexOf(C)I (C)I</signature>
        static int j4n_53(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(value);
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
        
        /// <signature>#54 IndexOf(CI)I (CI)I</signature>
        static int j4n_54(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(value, startIndex);
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
        
        /// <signature>#55 IndexOf(CII)I (CII)I</signature>
        static int j4n_55(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(value, startIndex, count);
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
        
        /// <signature>#56 IndexOf(Ljava/lang/String;)I (Lsystem/String;)I</signature>
        static int j4n_56(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
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
        
        /// <signature>#57 IndexOf(Ljava/lang/String;I)I (Lsystem/String;I)I</signature>
        static int j4n_57(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), startIndex);
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
        
        /// <signature>#58 IndexOf(Ljava/lang/String;II)I (Lsystem/String;II)I</signature>
        static int j4n_58(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), startIndex, count);
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
        
        /// <signature>#59 IndexOf(Ljava/lang/String;IILsystem/Enum;)I (Lsystem/String;IILSystem/StringComparison;)I</signature>
        static int j4n_59(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex, int count, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), startIndex, count, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#60 IndexOf(Ljava/lang/String;ILsystem/Enum;)I (Lsystem/String;ILSystem/StringComparison;)I</signature>
        static int j4n_60(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), startIndex, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#61 IndexOf(Ljava/lang/String;Lsystem/Enum;)I (Lsystem/String;LSystem/StringComparison;)I</signature>
        static int j4n_61(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#62 IndexOfAny([C)I ([C)I</signature>
        static int j4n_62(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr anyOf)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOfAny(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, anyOf));
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
        
        /// <signature>#63 IndexOfAny([CI)I ([CI)I</signature>
        static int j4n_63(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr anyOf, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOfAny(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, anyOf), startIndex);
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
        
        /// <signature>#64 IndexOfAny([CII)I ([CII)I</signature>
        static int j4n_64(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr anyOf, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOfAny(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, anyOf), startIndex, count);
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
        
        /// <signature>#65 Insert(ILjava/lang/String;)Ljava/lang/String; (ILsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_65(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int startIndex, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Insert(startIndex, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value)), "java.lang.String");
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
        
        /// <signature>#66 IsNormalized()Z ()Z</signature>
        static bool j4n_66(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNormalized();
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
        
        /// <signature>#67 IsNormalized(Lsystem/Enum;)Z (LSystem/Text/NormalizationForm;)Z</signature>
        static bool j4n_67(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr normalizationForm)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNormalized(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Text.NormalizationForm>(j4n_env, normalizationForm));
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
        
        /// <signature>#68 LastIndexOf(C)I (C)I</signature>
        static int j4n_68(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(value);
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
        
        /// <signature>#69 LastIndexOf(CI)I (CI)I</signature>
        static int j4n_69(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(value, startIndex);
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
        
        /// <signature>#70 LastIndexOf(CII)I (CII)I</signature>
        static int j4n_70(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char value, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(value, startIndex, count);
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
        
        /// <signature>#71 LastIndexOf(Ljava/lang/String;)I (Lsystem/String;)I</signature>
        static int j4n_71(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
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
        
        /// <signature>#72 LastIndexOf(Ljava/lang/String;I)I (Lsystem/String;I)I</signature>
        static int j4n_72(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), startIndex);
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
        
        /// <signature>#73 LastIndexOf(Ljava/lang/String;II)I (Lsystem/String;II)I</signature>
        static int j4n_73(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), startIndex, count);
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
        
        /// <signature>#74 LastIndexOf(Ljava/lang/String;IILsystem/Enum;)I (Lsystem/String;IILSystem/StringComparison;)I</signature>
        static int j4n_74(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex, int count, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), startIndex, count, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#75 LastIndexOf(Ljava/lang/String;ILsystem/Enum;)I (Lsystem/String;ILSystem/StringComparison;)I</signature>
        static int j4n_75(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int startIndex, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), startIndex, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#76 LastIndexOf(Ljava/lang/String;Lsystem/Enum;)I (Lsystem/String;LSystem/StringComparison;)I</signature>
        static int j4n_76(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#77 LastIndexOfAny([C)I ([C)I</signature>
        static int j4n_77(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr anyOf)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOfAny(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, anyOf));
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
        
        /// <signature>#78 LastIndexOfAny([CI)I ([CI)I</signature>
        static int j4n_78(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr anyOf, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOfAny(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, anyOf), startIndex);
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
        
        /// <signature>#79 LastIndexOfAny([CII)I ([CII)I</signature>
        static int j4n_79(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr anyOf, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                int j4n_result = j4n_real.LastIndexOfAny(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, anyOf), startIndex, count);
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
        
        /// <signature>#80 Normalize()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_80(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Normalize(), "java.lang.String");
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
        
        /// <signature>#81 Normalize(Lsystem/Enum;)Ljava/lang/String; (LSystem/Text/NormalizationForm;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_81(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr normalizationForm)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Normalize(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Text.NormalizationForm>(j4n_env, normalizationForm)), "java.lang.String");
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
        
        /// <signature>#82 PadLeft(I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static global::System.IntPtr j4n_82(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int totalWidth)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.PadLeft(totalWidth), "java.lang.String");
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
        
        /// <signature>#83 PadLeft(IC)Ljava/lang/String; (IC)Lsystem/String;</signature>
        static global::System.IntPtr j4n_83(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int totalWidth, char paddingChar)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.PadLeft(totalWidth, paddingChar), "java.lang.String");
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
        
        /// <signature>#84 PadRight(I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static global::System.IntPtr j4n_84(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int totalWidth)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.PadRight(totalWidth), "java.lang.String");
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
        
        /// <signature>#85 PadRight(IC)Ljava/lang/String; (IC)Lsystem/String;</signature>
        static global::System.IntPtr j4n_85(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int totalWidth, char paddingChar)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.PadRight(totalWidth, paddingChar), "java.lang.String");
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
        
        /// <signature>#86 Remove(I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static global::System.IntPtr j4n_86(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Remove(startIndex), "java.lang.String");
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
        
        /// <signature>#87 Remove(II)Ljava/lang/String; (II)Lsystem/String;</signature>
        static global::System.IntPtr j4n_87(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Remove(startIndex, count), "java.lang.String");
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
        
        /// <signature>#88 Replace(CC)Ljava/lang/String; (CC)Lsystem/String;</signature>
        static global::System.IntPtr j4n_88(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char oldChar, char newChar)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Replace(oldChar, newChar), "java.lang.String");
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
        
        /// <signature>#89 Replace(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_89(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr oldValue, global::System.IntPtr newValue)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Replace(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, oldValue), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, newValue)), "java.lang.String");
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
        
        /// <signature>#90 Split([C)[Ljava/lang/String; ([C)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_90(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr separator)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Split(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, separator)), "java.lang.String");
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
        
        /// <signature>#91 Split([CI)[Ljava/lang/String; ([CI)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_91(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr separator, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Split(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, separator), count), "java.lang.String");
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
        
        /// <signature>#92 Split([CILsystem/Enum;)[Ljava/lang/String; ([CILSystem/StringSplitOptions;)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_92(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr separator, int count, global::System.IntPtr options)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Split(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, separator), count, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringSplitOptions>(j4n_env, options)), "java.lang.String");
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
        
        /// <signature>#93 Split([CLsystem/Enum;)[Ljava/lang/String; ([CLSystem/StringSplitOptions;)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_93(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr separator, global::System.IntPtr options)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Split(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, separator), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringSplitOptions>(j4n_env, options)), "java.lang.String");
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
        
        /// <signature>#94 Split([Ljava/lang/String;ILsystem/Enum;)[Ljava/lang/String; ([Lsystem/String;ILSystem/StringSplitOptions;)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_94(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr separator, int count, global::System.IntPtr options)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Split(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, separator), count, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringSplitOptions>(j4n_env, options)), "java.lang.String");
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
        
        /// <signature>#95 Split([Ljava/lang/String;Lsystem/Enum;)[Ljava/lang/String; ([Lsystem/String;LSystem/StringSplitOptions;)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_95(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr separator, global::System.IntPtr options)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Split(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, separator), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringSplitOptions>(j4n_env, options)), "java.lang.String");
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
        
        /// <signature>#96 StartsWith(Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
        static bool j4n_96(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.StartsWith(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value));
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
        
        /// <signature>#97 StartsWith(Ljava/lang/String;ZLsystem/ICloneable;)Z (Lsystem/String;ZLSystem/Globalization/CultureInfo;)Z</signature>
        static bool j4n_97(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, bool ignoreCase, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.StartsWith(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), ignoreCase, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture));
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
        
        /// <signature>#98 StartsWith(Ljava/lang/String;Lsystem/Enum;)Z (Lsystem/String;LSystem/StringComparison;)Z</signature>
        static bool j4n_98(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr comparisonType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.StartsWith(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.StringComparison>(j4n_env, comparisonType));
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
        
        /// <signature>#99 Substring(I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static global::System.IntPtr j4n_99(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Substring(startIndex), "java.lang.String");
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
        
        /// <signature>#100 Substring(II)Ljava/lang/String; (II)Lsystem/String;</signature>
        static global::System.IntPtr j4n_100(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int startIndex, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Substring(startIndex, length), "java.lang.String");
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
        
        /// <signature>#101 ToBoolean(Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
        static bool j4n_101(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#102 ToByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
        static byte j4n_102(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#103 ToChar(Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
        static char j4n_103(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#104 ToCharArray()[C ()[C</signature>
        static global::System.IntPtr j4n_104(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToCharArray(), "char");
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
        
        /// <signature>#105 ToCharArray(II)[C (II)[C</signature>
        static global::System.IntPtr j4n_105(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int startIndex, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToCharArray(startIndex, length), "char");
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
        
        /// <signature>#106 ToDateTime(Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_106(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#107 ToDecimal(Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
        static global::System.IntPtr j4n_107(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#108 ToDouble(Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
        static double j4n_108(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#109 ToInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
        static short j4n_109(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#110 ToInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
        static int j4n_110(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#111 ToInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
        static long j4n_111(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#112 ToLower()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_112(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToLower(), "java.lang.String");
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
        
        /// <signature>#113 ToLower(Lsystem/ICloneable;)Ljava/lang/String; (LSystem/Globalization/CultureInfo;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_113(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToLower(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture)), "java.lang.String");
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
        
        /// <signature>#114 ToLowerInvariant()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_114(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToLowerInvariant(), "java.lang.String");
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
        
        /// <signature>#115 ToSByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)b</signature>
        static sbyte j4n_115(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#116 ToSingle(Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
        static float j4n_116(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#117 ToString(Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_117(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#118 ToType(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_118(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type, global::System.IntPtr provider)
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
        
        /// <signature>#119 ToUInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)s</signature>
        static ushort j4n_119(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#120 ToUInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)i</signature>
        static uint j4n_120(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#121 ToUInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)j</signature>
        static ulong j4n_121(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#122 ToUpper()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_122(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToUpper(), "java.lang.String");
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
        
        /// <signature>#123 ToUpper(Lsystem/ICloneable;)Ljava/lang/String; (LSystem/Globalization/CultureInfo;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_123(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToUpper(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture)), "java.lang.String");
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
        
        /// <signature>#124 ToUpperInvariant()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_124(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToUpperInvariant(), "java.lang.String");
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
        
        /// <signature>#125 Trim()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_125(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Trim(), "java.lang.String");
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
        
        /// <signature>#126 Trim([C)Ljava/lang/String; ([C)Lsystem/String;</signature>
        static global::System.IntPtr j4n_126(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr trimChars)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Trim(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, trimChars)), "java.lang.String");
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
        
        /// <signature>#127 TrimEnd([C)Ljava/lang/String; ([C)Lsystem/String;</signature>
        static global::System.IntPtr j4n_127(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr trimChars)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.TrimEnd(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, trimChars)), "java.lang.String");
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
        
        /// <signature>#128 TrimStart([C)Ljava/lang/String; ([C)Lsystem/String;</signature>
        static global::System.IntPtr j4n_128(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr trimChars)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                string j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.TrimStart(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<char[]>(j4n_env, trimChars)), "java.lang.String");
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
            lock (typeof(string))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.String";
                    proxyInfo.JVMProxyName = "system.String";
                    proxyInfo.JVMStaticApiName = "system.String";
                    proxyInfo.CLRApi = typeof(System.String);
                    proxyInfo.CLRStaticApi = typeof(System.String_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","([C)V", false, false), // #0 ([C)V
                        new global::net.sf.jni4net.core.MemberId("<init>","([CII)V", false, false), // #1 ([CII)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(CI)V", false, false), // #2 (CI)V
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;ILjava/lang/String;II)I", false, true), // #3 (Ljava/lang/String;ILjava/lang/String;II)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;ILjava/lang/String;IIZ)I", false, true), // #4 (Ljava/lang/String;ILjava/lang/String;IIZ)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;ILjava/lang/String;IIZLsystem/ICloneable;)I", false, true), // #5 (Ljava/lang/String;ILjava/lang/String;IIZLSystem/ICloneable;)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;ILjava/lang/String;IILsystem/ICloneable;Lsystem/Enum;)I", false, true), // #6 (Ljava/lang/String;ILjava/lang/String;IILSystem/ICloneable;LSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;ILjava/lang/String;IILsystem/Enum;)I", false, true), // #7 (Ljava/lang/String;ILjava/lang/String;IILSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;Ljava/lang/String;)I", false, true), // #8 (Ljava/lang/String;Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;Ljava/lang/String;Z)I", false, true), // #9 (Ljava/lang/String;Ljava/lang/String;Z)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;Ljava/lang/String;ZLsystem/ICloneable;)I", false, true), // #10 (Ljava/lang/String;Ljava/lang/String;ZLSystem/ICloneable;)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;Ljava/lang/String;Lsystem/ICloneable;Lsystem/Enum;)I", false, true), // #11 (Ljava/lang/String;Ljava/lang/String;LSystem/ICloneable;LSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("Compare","(Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)I", false, true), // #12 (Ljava/lang/String;Ljava/lang/String;LSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("CompareOrdinal","(Ljava/lang/String;ILjava/lang/String;II)I", false, true), // #13 (Ljava/lang/String;ILjava/lang/String;II)I
                        new global::net.sf.jni4net.core.MemberId("CompareOrdinal","(Ljava/lang/String;Ljava/lang/String;)I", false, true), // #14 (Ljava/lang/String;Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("Concat","([Ljava/lang/Object;)Ljava/lang/String;", false, true), // #15 ([Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Concat","([Ljava/lang/String;)Ljava/lang/String;", false, true), // #16 ([Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Concat","(Ljava/lang/Object;)Ljava/lang/String;", false, true), // #17 (Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Concat","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;", false, true), // #18 (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Concat","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;", false, true), // #19 (Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Concat","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;", false, true), // #20 (Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Concat","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, true), // #21 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Concat","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, true), // #22 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Concat","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, true), // #23 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Copy","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #24 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Empty","()Ljava/lang/String;", true, true), // #25 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Equals","(Ljava/lang/String;Ljava/lang/String;)Z", false, true), // #26 (Ljava/lang/String;Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("Equals","(Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)Z", false, true), // #27 (Ljava/lang/String;Ljava/lang/String;LSystem/Enum;)Z
                        new global::net.sf.jni4net.core.MemberId("Format","(Lsystem/IFormatProvider;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", false, true), // #28 (LSystem/IFormatProvider;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", false, true), // #29 (Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Format","(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", false, true), // #30 (Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Format","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;", false, true), // #31 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Format","(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;", false, true), // #32 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Intern","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #33 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("IsInterned","(Ljava/lang/String;)Ljava/lang/String;", false, true), // #34 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("IsNullOrEmpty","(Ljava/lang/String;)Z", false, true), // #35 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("Join","(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", false, true), // #36 (Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Join","(Ljava/lang/String;[Ljava/lang/String;II)Ljava/lang/String;", false, true), // #37 (Ljava/lang/String;[Ljava/lang/String;II)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Clone","()Ljava/lang/Object;", false, false), // #38 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Ljava/lang/Object;)I", false, false), // #39 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Ljava/lang/String;)I", false, false), // #40 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("Contains","(Ljava/lang/String;)Z", false, false), // #41 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("CopyTo","(I[CII)V", false, false), // #42 (I[CII)V
                        new global::net.sf.jni4net.core.MemberId("EndsWith","(Ljava/lang/String;)Z", false, false), // #43 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("EndsWith","(Ljava/lang/String;ZLsystem/ICloneable;)Z", false, false), // #44 (Ljava/lang/String;ZLSystem/ICloneable;)Z
                        new global::net.sf.jni4net.core.MemberId("EndsWith","(Ljava/lang/String;Lsystem/Enum;)Z", false, false), // #45 (Ljava/lang/String;LSystem/Enum;)Z
                        new global::net.sf.jni4net.core.MemberId("Equals","(Ljava/lang/String;)Z", false, false), // #46 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("Equals","(Ljava/lang/String;Lsystem/Enum;)Z", false, false), // #47 (Ljava/lang/String;LSystem/Enum;)Z
                        new global::net.sf.jni4net.core.MemberId("getChars","(I)C", false, false), // #48 (I)C
                        new global::net.sf.jni4net.core.MemberId("getLength","()I", false, false), // #49 ()I
                        new global::net.sf.jni4net.core.MemberId("GetEnumerator","()Lsystem/CharEnumerator;", false, false), // #50 ()LSystem/CharEnumerator;
                        new global::net.sf.jni4net.core.MemberId("GetEnumerator_IEnumerable65","()Lsystem/collections/IEnumerator;", false, false), // #51 ()LSystem/Collections/IEnumerator;
                        new global::net.sf.jni4net.core.MemberId("GetTypeCode","()Lsystem/Enum;", false, false), // #52 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(C)I", false, false), // #53 (C)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(CI)I", false, false), // #54 (CI)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(CII)I", false, false), // #55 (CII)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Ljava/lang/String;)I", false, false), // #56 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Ljava/lang/String;I)I", false, false), // #57 (Ljava/lang/String;I)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Ljava/lang/String;II)I", false, false), // #58 (Ljava/lang/String;II)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Ljava/lang/String;IILsystem/Enum;)I", false, false), // #59 (Ljava/lang/String;IILSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Ljava/lang/String;ILsystem/Enum;)I", false, false), // #60 (Ljava/lang/String;ILSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Ljava/lang/String;Lsystem/Enum;)I", false, false), // #61 (Ljava/lang/String;LSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("IndexOfAny","([C)I", false, false), // #62 ([C)I
                        new global::net.sf.jni4net.core.MemberId("IndexOfAny","([CI)I", false, false), // #63 ([CI)I
                        new global::net.sf.jni4net.core.MemberId("IndexOfAny","([CII)I", false, false), // #64 ([CII)I
                        new global::net.sf.jni4net.core.MemberId("Insert","(ILjava/lang/String;)Ljava/lang/String;", false, false), // #65 (ILjava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("IsNormalized","()Z", false, false), // #66 ()Z
                        new global::net.sf.jni4net.core.MemberId("IsNormalized","(Lsystem/Enum;)Z", false, false), // #67 (LSystem/Enum;)Z
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(C)I", false, false), // #68 (C)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(CI)I", false, false), // #69 (CI)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(CII)I", false, false), // #70 (CII)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Ljava/lang/String;)I", false, false), // #71 (Ljava/lang/String;)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Ljava/lang/String;I)I", false, false), // #72 (Ljava/lang/String;I)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Ljava/lang/String;II)I", false, false), // #73 (Ljava/lang/String;II)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Ljava/lang/String;IILsystem/Enum;)I", false, false), // #74 (Ljava/lang/String;IILSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Ljava/lang/String;ILsystem/Enum;)I", false, false), // #75 (Ljava/lang/String;ILSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Ljava/lang/String;Lsystem/Enum;)I", false, false), // #76 (Ljava/lang/String;LSystem/Enum;)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOfAny","([C)I", false, false), // #77 ([C)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOfAny","([CI)I", false, false), // #78 ([CI)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOfAny","([CII)I", false, false), // #79 ([CII)I
                        new global::net.sf.jni4net.core.MemberId("Normalize","()Ljava/lang/String;", false, false), // #80 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Normalize","(Lsystem/Enum;)Ljava/lang/String;", false, false), // #81 (LSystem/Enum;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("PadLeft","(I)Ljava/lang/String;", false, false), // #82 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("PadLeft","(IC)Ljava/lang/String;", false, false), // #83 (IC)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("PadRight","(I)Ljava/lang/String;", false, false), // #84 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("PadRight","(IC)Ljava/lang/String;", false, false), // #85 (IC)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Remove","(I)Ljava/lang/String;", false, false), // #86 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Remove","(II)Ljava/lang/String;", false, false), // #87 (II)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Replace","(CC)Ljava/lang/String;", false, false), // #88 (CC)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Replace","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, false), // #89 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Split","([C)[Ljava/lang/String;", false, false), // #90 ([C)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Split","([CI)[Ljava/lang/String;", false, false), // #91 ([CI)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Split","([CILsystem/Enum;)[Ljava/lang/String;", false, false), // #92 ([CILSystem/Enum;)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Split","([CLsystem/Enum;)[Ljava/lang/String;", false, false), // #93 ([CLSystem/Enum;)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Split","([Ljava/lang/String;ILsystem/Enum;)[Ljava/lang/String;", false, false), // #94 ([Ljava/lang/String;ILSystem/Enum;)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Split","([Ljava/lang/String;Lsystem/Enum;)[Ljava/lang/String;", false, false), // #95 ([Ljava/lang/String;LSystem/Enum;)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("StartsWith","(Ljava/lang/String;)Z", false, false), // #96 (Ljava/lang/String;)Z
                        new global::net.sf.jni4net.core.MemberId("StartsWith","(Ljava/lang/String;ZLsystem/ICloneable;)Z", false, false), // #97 (Ljava/lang/String;ZLSystem/ICloneable;)Z
                        new global::net.sf.jni4net.core.MemberId("StartsWith","(Ljava/lang/String;Lsystem/Enum;)Z", false, false), // #98 (Ljava/lang/String;LSystem/Enum;)Z
                        new global::net.sf.jni4net.core.MemberId("Substring","(I)Ljava/lang/String;", false, false), // #99 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Substring","(II)Ljava/lang/String;", false, false), // #100 (II)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToBoolean","(Lsystem/IFormatProvider;)Z", false, false), // #101 (LSystem/IFormatProvider;)Z
                        new global::net.sf.jni4net.core.MemberId("ToByte","(Lsystem/IFormatProvider;)B", false, false), // #102 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToChar","(Lsystem/IFormatProvider;)C", false, false), // #103 (LSystem/IFormatProvider;)C
                        new global::net.sf.jni4net.core.MemberId("ToCharArray","()[C", false, false), // #104 ()[C
                        new global::net.sf.jni4net.core.MemberId("ToCharArray","(II)[C", false, false), // #105 (II)[C
                        new global::net.sf.jni4net.core.MemberId("ToDateTime","(Lsystem/IFormatProvider;)Lsystem/DateTime;", false, false), // #106 (LSystem/IFormatProvider;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ToDecimal","(Lsystem/IFormatProvider;)Lsystem/Decimal;", false, false), // #107 (LSystem/IFormatProvider;)LSystem/Decimal;
                        new global::net.sf.jni4net.core.MemberId("ToDouble","(Lsystem/IFormatProvider;)D", false, false), // #108 (LSystem/IFormatProvider;)D
                        new global::net.sf.jni4net.core.MemberId("ToInt16","(Lsystem/IFormatProvider;)S", false, false), // #109 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToInt32","(Lsystem/IFormatProvider;)I", false, false), // #110 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToInt64","(Lsystem/IFormatProvider;)J", false, false), // #111 (LSystem/IFormatProvider;)J
                        new global::net.sf.jni4net.core.MemberId("ToLower","()Ljava/lang/String;", false, false), // #112 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToLower","(Lsystem/ICloneable;)Ljava/lang/String;", false, false), // #113 (LSystem/ICloneable;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToLowerInvariant","()Ljava/lang/String;", false, false), // #114 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToSByte","(Lsystem/IFormatProvider;)B", false, false), // #115 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToSingle","(Lsystem/IFormatProvider;)F", false, false), // #116 (LSystem/IFormatProvider;)F
                        new global::net.sf.jni4net.core.MemberId("ToString","(Lsystem/IFormatProvider;)Ljava/lang/String;", false, false), // #117 (LSystem/IFormatProvider;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToType","(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object;", false, false), // #118 (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToUInt16","(Lsystem/IFormatProvider;)S", false, false), // #119 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToUInt32","(Lsystem/IFormatProvider;)I", false, false), // #120 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToUInt64","(Lsystem/IFormatProvider;)J", false, false), // #121 (LSystem/IFormatProvider;)J
                        new global::net.sf.jni4net.core.MemberId("ToUpper","()Ljava/lang/String;", false, false), // #122 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToUpper","(Lsystem/ICloneable;)Ljava/lang/String;", false, false), // #123 (LSystem/ICloneable;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToUpperInvariant","()Ljava/lang/String;", false, false), // #124 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Trim","()Ljava/lang/String;", false, false), // #125 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Trim","([C)Ljava/lang/String;", false, false), // #126 ([C)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("TrimEnd","([C)Ljava/lang/String;", false, false), // #127 ([C)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("TrimStart","([C)Ljava/lang/String;", false, false), // #128 ([C)Ljava/lang/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
