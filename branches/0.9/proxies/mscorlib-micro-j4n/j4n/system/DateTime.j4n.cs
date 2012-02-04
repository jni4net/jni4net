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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.DateTime_))]
    static public partial class DateTime_
    {
        static DateTime_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ValueType_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IFormattable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IFormattable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.DateTime_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor(III)V (III)V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day));
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
        
        /// <signature>#1 .ctor(IIILsystem/ICloneable;)V (IIILSystem/Globalization/Calendar;)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day, global::System.IntPtr calendar)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.Calendar>(j4n_env, calendar)));
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
        
        /// <signature>#2 .ctor(IIIIII)V (IIIIII)V</signature>
        static long j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day, int hour, int minute, int second)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day, hour, minute, second));
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
        
        /// <signature>#3 .ctor(IIIIIILsystem/Enum;)V (IIIIIILSystem/DateTimeKind;)V</signature>
        static long j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day, int hour, int minute, int second, global::System.IntPtr kind)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 24);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day, hour, minute, second, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTimeKind>(j4n_env, kind)));
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
        
        /// <signature>#4 .ctor(IIIIIILsystem/ICloneable;)V (IIIIIILSystem/Globalization/Calendar;)V</signature>
        static long j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day, int hour, int minute, int second, global::System.IntPtr calendar)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 24);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day, hour, minute, second, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.Calendar>(j4n_env, calendar)));
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
        
        /// <signature>#5 .ctor(IIIIIII)V (IIIIIII)V</signature>
        static long j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 24);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day, hour, minute, second, millisecond));
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
        
        /// <signature>#6 .ctor(IIIIIIILsystem/Enum;)V (IIIIIIILSystem/DateTimeKind;)V</signature>
        static long j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day, int hour, int minute, int second, int millisecond, global::System.IntPtr kind)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 26);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day, hour, minute, second, millisecond, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTimeKind>(j4n_env, kind)));
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
        
        /// <signature>#7 .ctor(IIIIIIILsystem/ICloneable;)V (IIIIIIILSystem/Globalization/Calendar;)V</signature>
        static long j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day, int hour, int minute, int second, int millisecond, global::System.IntPtr calendar)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 26);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day, hour, minute, second, millisecond, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.Calendar>(j4n_env, calendar)));
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
        
        /// <signature>#8 .ctor(IIIIIIILsystem/ICloneable;Lsystem/Enum;)V (IIIIIIILSystem/Globalization/Calendar;LSystem/DateTimeKind;)V</signature>
        static long j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int year, int month, int day, int hour, int minute, int second, int millisecond, global::System.IntPtr calendar, global::System.IntPtr kind)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 28);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(year, month, day, hour, minute, second, millisecond, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.Calendar>(j4n_env, calendar), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTimeKind>(j4n_env, kind)));
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
        
        /// <signature>#9 .ctor(J)V (J)V</signature>
        static long j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long ticks)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(ticks));
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
        
        /// <signature>#10 .ctor(JLsystem/Enum;)V (JLSystem/DateTimeKind;)V</signature>
        static long j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long ticks, global::System.IntPtr kind)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.DateTime(ticks, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTimeKind>(j4n_env, kind)));
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
        
        /// <signature>#11 Compare(Lsystem/DateTime;Lsystem/DateTime;)I (LSystem/DateTime;LSystem/DateTime;)I</signature>
        static int j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr t1, global::System.IntPtr t2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = global::System.DateTime.Compare(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, t1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, t2));
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
        
        /// <signature>#12 DaysInMonth(II)I (II)I</signature>
        static int j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int year, int month)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = global::System.DateTime.DaysInMonth(year, month);
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
        
        /// <signature>#13 Equals(Lsystem/DateTime;Lsystem/DateTime;)Z (LSystem/DateTime;LSystem/DateTime;)Z</signature>
        static bool j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr t1, global::System.IntPtr t2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = global::System.DateTime.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, t1), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, t2));
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
        
        /// <signature>#14 FromBinary(J)Lsystem/DateTime; (J)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, long dateData)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.FromBinary(dateData), "system.DateTime");
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
        
        /// <signature>#15 FromFileTime(J)Lsystem/DateTime; (J)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, long fileTime)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.FromFileTime(fileTime), "system.DateTime");
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
        
        /// <signature>#16 FromFileTimeUtc(J)Lsystem/DateTime; (J)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, long fileTime)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.FromFileTimeUtc(fileTime), "system.DateTime");
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
        
        /// <signature>#17 FromOADate(D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, double d)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.FromOADate(d), "system.DateTime");
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
        
        /// <signature>#18 get_Now()Lsystem/DateTime; ()LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.Now, "system.DateTime");
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
        
        /// <signature>#19 get_Today()Lsystem/DateTime; ()LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.Today, "system.DateTime");
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
        
        /// <signature>#20 get_UtcNow()Lsystem/DateTime; ()LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.UtcNow, "system.DateTime");
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
        
        /// <signature>#21 IsLeapYear(I)Z (I)Z</signature>
        static bool j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int year)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                bool j4n_result = global::System.DateTime.IsLeapYear(year);
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
        
        /// <signature>#22 MaxValue()Lsystem/DateTime; ()LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.MaxValue, "system.DateTime");
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
        
        /// <signature>#23 MinValue()Lsystem/DateTime; ()LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.MinValue, "system.DateTime");
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
        
        /// <signature>#24 Parse(Ljava/lang/String;)Lsystem/DateTime; (Lsystem/String;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.Parse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s)), "system.DateTime");
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
        
        /// <signature>#25 Parse(Ljava/lang/String;Lsystem/IFormatProvider;)Lsystem/DateTime; (Lsystem/String;LSystem/IFormatProvider;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.Parse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "system.DateTime");
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
        
        /// <signature>#26 Parse(Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime; (Lsystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr provider, global::System.IntPtr styles)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.Parse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.DateTimeStyles>(j4n_env, styles)), "system.DateTime");
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
        
        /// <signature>#27 ParseExact(Ljava/lang/String;[Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime; (Lsystem/String;[Lsystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr formats, global::System.IntPtr provider, global::System.IntPtr style)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.ParseExact(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, formats), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.DateTimeStyles>(j4n_env, style)), "system.DateTime");
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
        
        /// <signature>#28 ParseExact(Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;)Lsystem/DateTime; (Lsystem/String;Lsystem/String;LSystem/IFormatProvider;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr format, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.ParseExact(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "system.DateTime");
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
        
        /// <signature>#29 ParseExact(Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime; (Lsystem/String;Lsystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr format, global::System.IntPtr provider, global::System.IntPtr style)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.ParseExact(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.DateTimeStyles>(j4n_env, style)), "system.DateTime");
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
        
        /// <signature>#30 SpecifyKind(Lsystem/DateTime;Lsystem/Enum;)Lsystem/DateTime; (LSystem/DateTime;LSystem/DateTimeKind;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr value, global::System.IntPtr kind)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.DateTime.SpecifyKind(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTimeKind>(j4n_env, kind)), "system.DateTime");
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
        
        /// <signature>#31 TryParse(Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Lsystem/String;Lnet/sf/jni4net/OutSystem/DateTime;)Z</signature>
        static bool j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr result)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.DateTime j4n_out_result;
                bool j4n_result = global::System.DateTime.TryParse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), out j4n_out_result);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, result, j4n_out_result, "system.DateTime");
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
        
        /// <signature>#32 TryParse(Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z (Lsystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;Lnet/sf/jni4net/OutSystem/DateTime;)Z</signature>
        static bool j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr provider, global::System.IntPtr styles, global::System.IntPtr result)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.DateTime j4n_out_result;
                bool j4n_result = global::System.DateTime.TryParse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.DateTimeStyles>(j4n_env, styles), out j4n_out_result);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, result, j4n_out_result, "system.DateTime");
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
        
        /// <signature>#33 TryParseExact(Ljava/lang/String;[Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z (Lsystem/String;[Lsystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;Lnet/sf/jni4net/OutSystem/DateTime;)Z</signature>
        static bool j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr formats, global::System.IntPtr provider, global::System.IntPtr style, global::System.IntPtr result)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.DateTime j4n_out_result;
                bool j4n_result = global::System.DateTime.TryParseExact(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, formats), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.DateTimeStyles>(j4n_env, style), out j4n_out_result);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, result, j4n_out_result, "system.DateTime");
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
        
        /// <signature>#34 TryParseExact(Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z (Lsystem/String;Lsystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;Lnet/sf/jni4net/OutSystem/DateTime;)Z</signature>
        static bool j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr s, global::System.IntPtr format, global::System.IntPtr provider, global::System.IntPtr style, global::System.IntPtr result)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.DateTime j4n_out_result;
                bool j4n_result = global::System.DateTime.TryParseExact(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.DateTimeStyles>(j4n_env, style), out j4n_out_result);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, result, j4n_out_result, "system.DateTime");
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
        
        /// <signature>#35 Add(Lsystem/ValueType;)Lsystem/DateTime; (LSystem/TimeSpan;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Add(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.TimeSpan>(j4n_env, value)), "system.DateTime");
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
        
        /// <signature>#36 AddDays(D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AddDays(value), "system.DateTime");
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
        
        /// <signature>#37 AddHours(D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AddHours(value), "system.DateTime");
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
        
        /// <signature>#38 AddMilliseconds(D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AddMilliseconds(value), "system.DateTime");
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
        
        /// <signature>#39 AddMinutes(D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AddMinutes(value), "system.DateTime");
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
        
        /// <signature>#40 AddMonths(I)Lsystem/DateTime; (I)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int months)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AddMonths(months), "system.DateTime");
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
        
        /// <signature>#41 AddSeconds(D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_41(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, double value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AddSeconds(value), "system.DateTime");
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
        
        /// <signature>#42 AddTicks(J)Lsystem/DateTime; (J)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_42(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AddTicks(value), "system.DateTime");
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
        
        /// <signature>#43 AddYears(I)Lsystem/DateTime; (I)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_43(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AddYears(value), "system.DateTime");
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
        
        /// <signature>#44 CompareTo(Lsystem/DateTime;)I (LSystem/DateTime;)I</signature>
        static int j4n_44(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.CompareTo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, value));
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
        
        /// <signature>#45 CompareTo(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_45(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
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
        
        /// <signature>#46 Equals(Lsystem/DateTime;)Z (LSystem/DateTime;)Z</signature>
        static bool j4n_46(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, value));
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
        
        /// <signature>#47 get_Date()Lsystem/DateTime; ()LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_47(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Date, "system.DateTime");
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
        
        /// <signature>#48 get_Day()I ()I</signature>
        static int j4n_48(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Day;
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
        
        /// <signature>#49 get_DayOfWeek()Lsystem/Enum; ()LSystem/DayOfWeek;</signature>
        static global::System.IntPtr j4n_49(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.DayOfWeek, "system.Enum");
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
        
        /// <signature>#50 get_DayOfYear()I ()I</signature>
        static int j4n_50(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.DayOfYear;
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
        
        /// <signature>#51 get_Hour()I ()I</signature>
        static int j4n_51(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Hour;
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
        
        /// <signature>#52 get_Kind()Lsystem/Enum; ()LSystem/DateTimeKind;</signature>
        static global::System.IntPtr j4n_52(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Kind, "system.Enum");
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
        
        /// <signature>#53 get_Millisecond()I ()I</signature>
        static int j4n_53(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Millisecond;
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
        
        /// <signature>#54 get_Minute()I ()I</signature>
        static int j4n_54(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Minute;
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
        
        /// <signature>#55 get_Month()I ()I</signature>
        static int j4n_55(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Month;
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
        
        /// <signature>#56 get_Second()I ()I</signature>
        static int j4n_56(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Second;
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
        
        /// <signature>#57 get_Ticks()J ()J</signature>
        static long j4n_57(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                long j4n_result = j4n_real.Ticks;
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
        
        /// <signature>#58 get_TimeOfDay()Lsystem/ValueType; ()LSystem/TimeSpan;</signature>
        static global::System.IntPtr j4n_58(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.TimeOfDay, "system.ValueType");
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
        
        /// <signature>#59 get_Year()I ()I</signature>
        static int j4n_59(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Year;
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
        
        /// <signature>#60 GetDateTimeFormats()[Ljava/lang/String; ()[Lsystem/String;</signature>
        static global::System.IntPtr j4n_60(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetDateTimeFormats(), "java.lang.String");
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
        
        /// <signature>#61 GetDateTimeFormats(C)[Ljava/lang/String; (C)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_61(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char format)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetDateTimeFormats(format), "java.lang.String");
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
        
        /// <signature>#62 GetDateTimeFormats(CLsystem/IFormatProvider;)[Ljava/lang/String; (CLSystem/IFormatProvider;)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_62(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char format, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetDateTimeFormats(format, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "java.lang.String");
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
        
        /// <signature>#63 GetDateTimeFormats(Lsystem/IFormatProvider;)[Ljava/lang/String; (LSystem/IFormatProvider;)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_63(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetDateTimeFormats(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "java.lang.String");
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
        
        /// <signature>#64 GetObjectData(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
        static void j4n_64(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr info, global::System.IntPtr context)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.ISerializable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.ISerializable>(j4n_env, j4n_self);
                j4n_real.GetObjectData(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, info), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContext>(j4n_env, context));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#65 GetTypeCode()Lsystem/Enum; ()LSystem/TypeCode;</signature>
        static global::System.IntPtr j4n_65(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#66 IsDaylightSavingTime()Z ()Z</signature>
        static bool j4n_66(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsDaylightSavingTime();
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
        
        /// <signature>#67 Subtract(Lsystem/DateTime;)Lsystem/ValueType; (LSystem/DateTime;)LSystem/TimeSpan;</signature>
        static global::System.IntPtr j4n_67(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Subtract(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, value)), "system.ValueType");
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
        
        /// <signature>#68 Subtract(Lsystem/ValueType;)Lsystem/DateTime; (LSystem/TimeSpan;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_68(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Subtract(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.TimeSpan>(j4n_env, value)), "system.DateTime");
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
        
        /// <signature>#69 ToBinary()J ()J</signature>
        static long j4n_69(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                long j4n_result = j4n_real.ToBinary();
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
        
        /// <signature>#70 ToBoolean(Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
        static bool j4n_70(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#71 ToByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
        static byte j4n_71(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#72 ToChar(Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
        static char j4n_72(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#73 ToDateTime(Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_73(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#74 ToDecimal(Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
        static global::System.IntPtr j4n_74(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#75 ToDouble(Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
        static double j4n_75(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#76 ToFileTime()J ()J</signature>
        static long j4n_76(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                long j4n_result = j4n_real.ToFileTime();
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
        
        /// <signature>#77 ToFileTimeUtc()J ()J</signature>
        static long j4n_77(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                long j4n_result = j4n_real.ToFileTimeUtc();
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
        
        /// <signature>#78 ToInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
        static short j4n_78(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#79 ToInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
        static int j4n_79(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#80 ToInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
        static long j4n_80(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#81 ToLocalTime()Lsystem/DateTime; ()LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_81(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToLocalTime(), "system.DateTime");
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
        
        /// <signature>#82 ToLongDateString()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_82(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToLongDateString(), "java.lang.String");
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
        
        /// <signature>#83 ToLongTimeString()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_83(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToLongTimeString(), "java.lang.String");
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
        
        /// <signature>#84 ToOADate()D ()D</signature>
        static double j4n_84(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                double j4n_result = j4n_real.ToOADate();
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
        
        /// <signature>#85 ToSByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)b</signature>
        static sbyte j4n_85(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#86 ToShortDateString()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_86(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToShortDateString(), "java.lang.String");
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
        
        /// <signature>#87 ToShortTimeString()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_87(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToShortTimeString(), "java.lang.String");
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
        
        /// <signature>#88 ToSingle(Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
        static float j4n_88(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#89 ToString(Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_89(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#90 ToString(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_90(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
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
        
        /// <signature>#91 ToString(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Lsystem/String;LSystem/IFormatProvider;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_91(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr provider)
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
        
        /// <signature>#92 ToType(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_92(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type, global::System.IntPtr provider)
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
        
        /// <signature>#93 ToUInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)s</signature>
        static ushort j4n_93(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#94 ToUInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)i</signature>
        static uint j4n_94(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#95 ToUInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)j</signature>
        static ulong j4n_95(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
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
        
        /// <signature>#96 ToUniversalTime()Lsystem/DateTime; ()LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_96(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.DateTime j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.DateTime>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToUniversalTime(), "system.DateTime");
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
            lock (typeof(global::System.DateTime))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.DateTime";
                    proxyInfo.JVMProxyName = "system.DateTime";
                    proxyInfo.JVMStaticApiName = "system.DateTime";
                    proxyInfo.CLRApi = typeof(System.DateTime);
                    proxyInfo.CLRStaticApi = typeof(System.DateTime_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(III)V", false, false), // #0 (III)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IIILsystem/ICloneable;)V", false, false), // #1 (IIILSystem/ICloneable;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IIIIII)V", false, false), // #2 (IIIIII)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IIIIIILsystem/Enum;)V", false, false), // #3 (IIIIIILSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IIIIIILsystem/ICloneable;)V", false, false), // #4 (IIIIIILSystem/ICloneable;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IIIIIII)V", false, false), // #5 (IIIIIII)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IIIIIIILsystem/Enum;)V", false, false), // #6 (IIIIIIILSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IIIIIIILsystem/ICloneable;)V", false, false), // #7 (IIIIIIILSystem/ICloneable;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(IIIIIIILsystem/ICloneable;Lsystem/Enum;)V", false, false), // #8 (IIIIIIILSystem/ICloneable;LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(J)V", false, false), // #9 (J)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(JLsystem/Enum;)V", false, false), // #10 (JLSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("Compare","(Lsystem/DateTime;Lsystem/DateTime;)I", false, true), // #11 (LSystem/DateTime;LSystem/DateTime;)I
                        new global::net.sf.jni4net.core.MemberId("DaysInMonth","(II)I", false, true), // #12 (II)I
                        new global::net.sf.jni4net.core.MemberId("Equals","(Lsystem/DateTime;Lsystem/DateTime;)Z", false, true), // #13 (LSystem/DateTime;LSystem/DateTime;)Z
                        new global::net.sf.jni4net.core.MemberId("FromBinary","(J)Lsystem/DateTime;", false, true), // #14 (J)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("FromFileTime","(J)Lsystem/DateTime;", false, true), // #15 (J)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("FromFileTimeUtc","(J)Lsystem/DateTime;", false, true), // #16 (J)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("FromOADate","(D)Lsystem/DateTime;", false, true), // #17 (D)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("getNow","()Lsystem/DateTime;", false, true), // #18 ()LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("getToday","()Lsystem/DateTime;", false, true), // #19 ()LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("getUtcNow","()Lsystem/DateTime;", false, true), // #20 ()LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("IsLeapYear","(I)Z", false, true), // #21 (I)Z
                        new global::net.sf.jni4net.core.MemberId("MaxValue","()Lsystem/DateTime;", true, true), // #22 ()LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("MinValue","()Lsystem/DateTime;", true, true), // #23 ()LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("Parse","(Ljava/lang/String;)Lsystem/DateTime;", false, true), // #24 (Ljava/lang/String;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("Parse","(Ljava/lang/String;Lsystem/IFormatProvider;)Lsystem/DateTime;", false, true), // #25 (Ljava/lang/String;LSystem/IFormatProvider;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("Parse","(Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime;", false, true), // #26 (Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ParseExact","(Ljava/lang/String;[Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime;", false, true), // #27 (Ljava/lang/String;[Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ParseExact","(Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;)Lsystem/DateTime;", false, true), // #28 (Ljava/lang/String;Ljava/lang/String;LSystem/IFormatProvider;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ParseExact","(Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime;", false, true), // #29 (Ljava/lang/String;Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("SpecifyKind","(Lsystem/DateTime;Lsystem/Enum;)Lsystem/DateTime;", false, true), // #30 (LSystem/DateTime;LSystem/Enum;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("TryParse","(Ljava/lang/String;Lnet/sf/jni4net/Out;)Z", false, true), // #31 (Ljava/lang/String;Lnet/sf/jni4net/OutSystem/DateTime;)Z
                        new global::net.sf.jni4net.core.MemberId("TryParse","(Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z", false, true), // #32 (Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;Lnet/sf/jni4net/OutSystem/DateTime;)Z
                        new global::net.sf.jni4net.core.MemberId("TryParseExact","(Ljava/lang/String;[Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z", false, true), // #33 (Ljava/lang/String;[Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;Lnet/sf/jni4net/OutSystem/DateTime;)Z
                        new global::net.sf.jni4net.core.MemberId("TryParseExact","(Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z", false, true), // #34 (Ljava/lang/String;Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;Lnet/sf/jni4net/OutSystem/DateTime;)Z
                        new global::net.sf.jni4net.core.MemberId("Add","(Lsystem/ValueType;)Lsystem/DateTime;", false, false), // #35 (LSystem/ValueType;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("AddDays","(D)Lsystem/DateTime;", false, false), // #36 (D)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("AddHours","(D)Lsystem/DateTime;", false, false), // #37 (D)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("AddMilliseconds","(D)Lsystem/DateTime;", false, false), // #38 (D)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("AddMinutes","(D)Lsystem/DateTime;", false, false), // #39 (D)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("AddMonths","(I)Lsystem/DateTime;", false, false), // #40 (I)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("AddSeconds","(D)Lsystem/DateTime;", false, false), // #41 (D)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("AddTicks","(J)Lsystem/DateTime;", false, false), // #42 (J)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("AddYears","(I)Lsystem/DateTime;", false, false), // #43 (I)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Lsystem/DateTime;)I", false, false), // #44 (LSystem/DateTime;)I
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Ljava/lang/Object;)I", false, false), // #45 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Equals","(Lsystem/DateTime;)Z", false, false), // #46 (LSystem/DateTime;)Z
                        new global::net.sf.jni4net.core.MemberId("getDate","()Lsystem/DateTime;", false, false), // #47 ()LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("getDay","()I", false, false), // #48 ()I
                        new global::net.sf.jni4net.core.MemberId("getDayOfWeek","()Lsystem/Enum;", false, false), // #49 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getDayOfYear","()I", false, false), // #50 ()I
                        new global::net.sf.jni4net.core.MemberId("getHour","()I", false, false), // #51 ()I
                        new global::net.sf.jni4net.core.MemberId("getKind","()Lsystem/Enum;", false, false), // #52 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getMillisecond","()I", false, false), // #53 ()I
                        new global::net.sf.jni4net.core.MemberId("getMinute","()I", false, false), // #54 ()I
                        new global::net.sf.jni4net.core.MemberId("getMonth","()I", false, false), // #55 ()I
                        new global::net.sf.jni4net.core.MemberId("getSecond","()I", false, false), // #56 ()I
                        new global::net.sf.jni4net.core.MemberId("getTicks","()J", false, false), // #57 ()J
                        new global::net.sf.jni4net.core.MemberId("getTimeOfDay","()Lsystem/ValueType;", false, false), // #58 ()LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("getYear","()I", false, false), // #59 ()I
                        new global::net.sf.jni4net.core.MemberId("GetDateTimeFormats","()[Ljava/lang/String;", false, false), // #60 ()[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetDateTimeFormats","(C)[Ljava/lang/String;", false, false), // #61 (C)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetDateTimeFormats","(CLsystem/IFormatProvider;)[Ljava/lang/String;", false, false), // #62 (CLSystem/IFormatProvider;)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetDateTimeFormats","(Lsystem/IFormatProvider;)[Ljava/lang/String;", false, false), // #63 (LSystem/IFormatProvider;)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetObjectData","(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V", false, false), // #64 (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V
                        new global::net.sf.jni4net.core.MemberId("GetTypeCode","()Lsystem/Enum;", false, false), // #65 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("IsDaylightSavingTime","()Z", false, false), // #66 ()Z
                        new global::net.sf.jni4net.core.MemberId("Subtract","(Lsystem/DateTime;)Lsystem/ValueType;", false, false), // #67 (LSystem/DateTime;)LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("Subtract","(Lsystem/ValueType;)Lsystem/DateTime;", false, false), // #68 (LSystem/ValueType;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ToBinary","()J", false, false), // #69 ()J
                        new global::net.sf.jni4net.core.MemberId("ToBoolean","(Lsystem/IFormatProvider;)Z", false, false), // #70 (LSystem/IFormatProvider;)Z
                        new global::net.sf.jni4net.core.MemberId("ToByte","(Lsystem/IFormatProvider;)B", false, false), // #71 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToChar","(Lsystem/IFormatProvider;)C", false, false), // #72 (LSystem/IFormatProvider;)C
                        new global::net.sf.jni4net.core.MemberId("ToDateTime","(Lsystem/IFormatProvider;)Lsystem/DateTime;", false, false), // #73 (LSystem/IFormatProvider;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ToDecimal","(Lsystem/IFormatProvider;)Lsystem/Decimal;", false, false), // #74 (LSystem/IFormatProvider;)LSystem/Decimal;
                        new global::net.sf.jni4net.core.MemberId("ToDouble","(Lsystem/IFormatProvider;)D", false, false), // #75 (LSystem/IFormatProvider;)D
                        new global::net.sf.jni4net.core.MemberId("ToFileTime","()J", false, false), // #76 ()J
                        new global::net.sf.jni4net.core.MemberId("ToFileTimeUtc","()J", false, false), // #77 ()J
                        new global::net.sf.jni4net.core.MemberId("ToInt16","(Lsystem/IFormatProvider;)S", false, false), // #78 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToInt32","(Lsystem/IFormatProvider;)I", false, false), // #79 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToInt64","(Lsystem/IFormatProvider;)J", false, false), // #80 (LSystem/IFormatProvider;)J
                        new global::net.sf.jni4net.core.MemberId("ToLocalTime","()Lsystem/DateTime;", false, false), // #81 ()LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ToLongDateString","()Ljava/lang/String;", false, false), // #82 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToLongTimeString","()Ljava/lang/String;", false, false), // #83 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToOADate","()D", false, false), // #84 ()D
                        new global::net.sf.jni4net.core.MemberId("ToSByte","(Lsystem/IFormatProvider;)B", false, false), // #85 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToShortDateString","()Ljava/lang/String;", false, false), // #86 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToShortTimeString","()Ljava/lang/String;", false, false), // #87 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToSingle","(Lsystem/IFormatProvider;)F", false, false), // #88 (LSystem/IFormatProvider;)F
                        new global::net.sf.jni4net.core.MemberId("ToString","(Lsystem/IFormatProvider;)Ljava/lang/String;", false, false), // #89 (LSystem/IFormatProvider;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToString","(Ljava/lang/String;)Ljava/lang/String;", false, false), // #90 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToString","(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;", false, false), // #91 (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToType","(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object;", false, false), // #92 (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToUInt16","(Lsystem/IFormatProvider;)S", false, false), // #93 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToUInt32","(Lsystem/IFormatProvider;)I", false, false), // #94 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToUInt64","(Lsystem/IFormatProvider;)J", false, false), // #95 (LSystem/IFormatProvider;)J
                        new global::net.sf.jni4net.core.MemberId("ToUniversalTime","()Lsystem/DateTime;", false, false), // #96 ()LSystem/DateTime;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
