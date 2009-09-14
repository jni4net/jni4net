// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system;

@net.sf.jni4net.attributes.ClrType
public class DateTime extends system.ValueType implements system.IComparable, system.IFormattable, system.IConvertible, system.runtime.serialization.ISerializable {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected DateTime(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(J)V")
    public DateTime(long ticks) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime0(this, ticks);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(JLSystem/DateTimeKind;)V")
    public DateTime(long ticks, system.Enum kind) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime1(this, ticks, kind);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(III)V")
    public DateTime(int year, int month, int day) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime2(this, year, month, day);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIILSystem/Globalization/Calendar;)V")
    public DateTime(int year, int month, int day, system.Object calendar) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime3(this, year, month, day, calendar);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIIIII)V")
    public DateTime(int year, int month, int day, int hour, int minute, int second) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime4(this, year, month, day, hour, minute, second);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIIIIILSystem/DateTimeKind;)V")
    public DateTime(int year, int month, int day, int hour, int minute, int second, system.Enum kind) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime5(this, year, month, day, hour, minute, second, kind);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIIIIILSystem/Globalization/Calendar;)V")
    public DateTime(int year, int month, int day, int hour, int minute, int second, system.Object calendar) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime6(this, year, month, day, hour, minute, second, calendar);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIIIIII)V")
    public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime7(this, year, month, day, hour, minute, second, millisecond);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIIIIIILSystem/DateTimeKind;)V")
    public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, system.Enum kind) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime8(this, year, month, day, hour, minute, second, millisecond, kind);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIIIIIILSystem/Globalization/Calendar;)V")
    public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, system.Object calendar) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime9(this, year, month, day, hour, minute, second, millisecond, calendar);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIIIIIILSystem/Globalization/Calendar;LSystem/DateTimeKind;)V")
    public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, system.Object calendar, system.Enum kind) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.DateTime.__ctorDateTime10(this, year, month, day, hour, minute, second, millisecond, calendar, kind);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(J)V")
    private native static void __ctorDateTime0(net.sf.jni4net.inj.IClrProxy thiz, long ticks);
    
    @net.sf.jni4net.attributes.ClrMethod("(JLsystem/Enum;)V")
    private native static void __ctorDateTime1(net.sf.jni4net.inj.IClrProxy thiz, long ticks, system.Enum kind);
    
    @net.sf.jni4net.attributes.ClrMethod("(III)V")
    private native static void __ctorDateTime2(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIILsystem/Object;)V")
    private native static void __ctorDateTime3(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day, system.Object calendar);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIIIII)V")
    private native static void __ctorDateTime4(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day, int hour, int minute, int second);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIIIIILsystem/Enum;)V")
    private native static void __ctorDateTime5(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day, int hour, int minute, int second, system.Enum kind);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIIIIILsystem/Object;)V")
    private native static void __ctorDateTime6(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day, int hour, int minute, int second, system.Object calendar);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIIIIII)V")
    private native static void __ctorDateTime7(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day, int hour, int minute, int second, int millisecond);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIIIIIILsystem/Enum;)V")
    private native static void __ctorDateTime8(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day, int hour, int minute, int second, int millisecond, system.Enum kind);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIIIIIILsystem/Object;)V")
    private native static void __ctorDateTime9(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day, int hour, int minute, int second, int millisecond, system.Object calendar);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIIIIIILsystem/Object;Lsystem/Enum;)V")
    private native static void __ctorDateTime10(net.sf.jni4net.inj.IClrProxy thiz, int year, int month, int day, int hour, int minute, int second, int millisecond, system.Object calendar, system.Enum kind);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)I")
    public native int CompareTo(system.Object obj);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/IFormatProvider;)LSystem/String;")
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider formatProvider);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/TypeCode;")
    public native system.Enum GetTypeCode();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)Z")
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)C")
    public native char ToChar(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/SByte;")
    public native byte ToSByte(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)B")
    public native byte ToByte(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)S")
    public native short ToInt16(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/UInt16;")
    public native short ToUInt16(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)I")
    public native int ToInt32(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/UInt32;")
    public native int ToUInt32(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)J")
    public native long ToInt64(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/UInt64;")
    public native long ToUInt64(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)F")
    public native float ToSingle(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)D")
    public native double ToDouble(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/Decimal;")
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/DateTime;")
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/String;")
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/IFormatProvider;)LSystem/Object;")
    public native system.Object ToType(system.Type conversionType, system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V")
    public native void GetObjectData(system.Object info, system.ValueType context);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/TimeSpan;)LSystem/DateTime;")
    public native final system.DateTime Add(system.ValueType value);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)LSystem/DateTime;")
    public native final system.DateTime AddDays(double value);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)LSystem/DateTime;")
    public native final system.DateTime AddHours(double value);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)LSystem/DateTime;")
    public native final system.DateTime AddMilliseconds(double value);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)LSystem/DateTime;")
    public native final system.DateTime AddMinutes(double value);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)LSystem/DateTime;")
    public native final system.DateTime AddMonths(int months);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)LSystem/DateTime;")
    public native final system.DateTime AddSeconds(double value);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)LSystem/DateTime;")
    public native final system.DateTime AddTicks(long value);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)LSystem/DateTime;")
    public native final system.DateTime AddYears(int value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/DateTime;LSystem/DateTime;)I")
    public native static int Compare(system.DateTime t1, system.DateTime t2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/DateTime;)I")
    public native int CompareTo(system.DateTime value);
    
    @net.sf.jni4net.attributes.ClrMethod("(II)I")
    public native static int DaysInMonth(int year, int month);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/DateTime;)Z")
    public native boolean Equals(system.DateTime value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/DateTime;LSystem/DateTime;)Z")
    public native static boolean Equals(system.DateTime t1, system.DateTime t2);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)LSystem/DateTime;")
    public native static system.DateTime FromBinary(long dateData);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)LSystem/DateTime;")
    public native static system.DateTime FromFileTime(long fileTime);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)LSystem/DateTime;")
    public native static system.DateTime FromFileTimeUtc(long fileTime);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)LSystem/DateTime;")
    public native static system.DateTime FromOADate(double d);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native final boolean IsDaylightSavingTime();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/DateTime;LSystem/DateTimeKind;)LSystem/DateTime;")
    public native static system.DateTime SpecifyKind(system.DateTime value, system.Enum kind);
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native final long ToBinary();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DateTime;")
    public native final system.DateTime getDate();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getDay();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DayOfWeek;")
    public native final system.Enum getDayOfWeek();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getDayOfYear();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getHour();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DateTimeKind;")
    public native final system.Enum getKind();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getMillisecond();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getMinute();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getMonth();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DateTime;")
    public native static system.DateTime getNow();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DateTime;")
    public native static system.DateTime getUtcNow();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getSecond();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native final long getTicks();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/TimeSpan;")
    public native final system.ValueType getTimeOfDay();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DateTime;")
    public native static system.DateTime getToday();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getYear();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)Z")
    public native static boolean IsLeapYear(int year);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/DateTime;")
    public native static system.DateTime Parse(java.lang.String s);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/IFormatProvider;)LSystem/DateTime;")
    public native static system.DateTime Parse(java.lang.String s, system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;)LSystem/DateTime;")
    public native static system.DateTime Parse(java.lang.String s, system.IFormatProvider provider, system.Enum styles);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/String;LSystem/IFormatProvider;)LSystem/DateTime;")
    public native static system.DateTime ParseExact(java.lang.String s, java.lang.String format, system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;)LSystem/DateTime;")
    public native static system.DateTime ParseExact(java.lang.String s, java.lang.String format, system.IFormatProvider provider, system.Enum style);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;[LSystem/String;LSystem/IFormatProvider;LSystem/Globalization/DateTimeStyles;)LSystem/DateTime;")
    public native static system.DateTime ParseExact(java.lang.String s, java.lang.String[] formats, system.IFormatProvider provider, system.Enum style);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/DateTime;)LSystem/TimeSpan;")
    public native final system.ValueType Subtract(system.DateTime value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/TimeSpan;)LSystem/DateTime;")
    public native final system.DateTime Subtract(system.ValueType value);
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native final double ToOADate();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native final long ToFileTime();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native final long ToFileTimeUtc();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DateTime;")
    public native final system.DateTime ToLocalTime();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native final java.lang.String ToLongDateString();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native final java.lang.String ToLongTimeString();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native final java.lang.String ToShortDateString();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native final java.lang.String ToShortTimeString();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/String;")
    public native final java.lang.String ToString(java.lang.String format);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DateTime;")
    public native final system.DateTime ToUniversalTime();
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/String;")
    public native final java.lang.String[] GetDateTimeFormats();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)[LSystem/String;")
    public native final java.lang.String[] GetDateTimeFormats(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(C)[LSystem/String;")
    public native final java.lang.String[] GetDateTimeFormats(char format);
    
    @net.sf.jni4net.attributes.ClrMethod("(CLSystem/IFormatProvider;)[LSystem/String;")
    public native final java.lang.String[] GetDateTimeFormats(char format, system.IFormatProvider provider);
    
    public static system.Type typeof() {
        return system.DateTime.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.DateTime.staticType = staticType;
    }
    //</generated-proxy>
}
