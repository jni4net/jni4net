// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.DateTime.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class DateTime extends system.ValueType implements system.nongeneric.IComparable, system.IFormattable, system.IConvertible, system.runtime.serialization.ISerializable
// <j4ni-DateTime>
// put user interfaces here
// </j4ni-DateTime>
{
    // <j4nb-DateTime> 
    // put user members here
    // </j4nb-DateTime>
    
    private DateTime(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.DateTime(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.DateTime.j4n_ProxyInit(null);
    }
    
    public DateTime(int year, int month, int day) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day);
    }
    
    /// <signature>#0 (III)V (III)V</signature>
    private native long j4n_constructor(int year, int month, int day);
    
    public DateTime(int year, int month, int day, system.ICloneable calendar) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day, calendar);
    }
    
    /// <signature>#1 (IIILsystem/ICloneable;)V (IIILSystem/ICloneable;)V</signature>
    private native long j4n_constructor(int year, int month, int day, system.ICloneable calendar);
    
    public DateTime(int year, int month, int day, int hour, int minute, int second) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day, hour, minute, second);
    }
    
    /// <signature>#2 (IIIIII)V (IIIIII)V</signature>
    private native long j4n_constructor(int year, int month, int day, int hour, int minute, int second);
    
    public DateTime(int year, int month, int day, int hour, int minute, int second, system.Enum kind) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day, hour, minute, second, kind);
    }
    
    /// <signature>#3 (IIIIIILsystem/Enum;)V (IIIIIILSystem/Enum;)V</signature>
    private native long j4n_constructor(int year, int month, int day, int hour, int minute, int second, system.Enum kind);
    
    public DateTime(int year, int month, int day, int hour, int minute, int second, system.ICloneable calendar) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day, hour, minute, second, calendar);
    }
    
    /// <signature>#4 (IIIIIILsystem/ICloneable;)V (IIIIIILSystem/ICloneable;)V</signature>
    private native long j4n_constructor(int year, int month, int day, int hour, int minute, int second, system.ICloneable calendar);
    
    public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day, hour, minute, second, millisecond);
    }
    
    /// <signature>#5 (IIIIIII)V (IIIIIII)V</signature>
    private native long j4n_constructor(int year, int month, int day, int hour, int minute, int second, int millisecond);
    
    public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, system.Enum kind) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day, hour, minute, second, millisecond, kind);
    }
    
    /// <signature>#6 (IIIIIIILsystem/Enum;)V (IIIIIIILSystem/Enum;)V</signature>
    private native long j4n_constructor(int year, int month, int day, int hour, int minute, int second, int millisecond, system.Enum kind);
    
    public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, system.ICloneable calendar) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day, hour, minute, second, millisecond, calendar);
    }
    
    /// <signature>#7 (IIIIIIILsystem/ICloneable;)V (IIIIIIILSystem/ICloneable;)V</signature>
    private native long j4n_constructor(int year, int month, int day, int hour, int minute, int second, int millisecond, system.ICloneable calendar);
    
    public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, system.ICloneable calendar, system.Enum kind) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(year, month, day, hour, minute, second, millisecond, calendar, kind);
    }
    
    /// <signature>#8 (IIIIIIILsystem/ICloneable;Lsystem/Enum;)V (IIIIIIILSystem/ICloneable;LSystem/Enum;)V</signature>
    private native long j4n_constructor(int year, int month, int day, int hour, int minute, int second, int millisecond, system.ICloneable calendar, system.Enum kind);
    
    public DateTime(long ticks) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(ticks);
    }
    
    /// <signature>#9 (J)V (J)V</signature>
    private native long j4n_constructor(long ticks);
    
    public DateTime(long ticks, system.Enum kind) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(ticks, kind);
    }
    
    /// <signature>#10 (JLsystem/Enum;)V (JLSystem/Enum;)V</signature>
    private native long j4n_constructor(long ticks, system.Enum kind);
    
    /// <signature>#11 (Lsystem/DateTime;Lsystem/DateTime;)I (LSystem/DateTime;LSystem/DateTime;)I</signature>
    static public native int Compare(system.DateTime t1, system.DateTime t2);
    
    /// <signature>#12 (II)I (II)I</signature>
    static public native int DaysInMonth(int year, int month);
    
    /// <signature>#13 (Lsystem/DateTime;Lsystem/DateTime;)Z (LSystem/DateTime;LSystem/DateTime;)Z</signature>
    static public native boolean Equals(system.DateTime t1, system.DateTime t2);
    
    /// <signature>#14 (J)Lsystem/DateTime; (J)LSystem/DateTime;</signature>
    static public native system.DateTime FromBinary(long dateData);
    
    /// <signature>#15 (J)Lsystem/DateTime; (J)LSystem/DateTime;</signature>
    static public native system.DateTime FromFileTime(long fileTime);
    
    /// <signature>#16 (J)Lsystem/DateTime; (J)LSystem/DateTime;</signature>
    static public native system.DateTime FromFileTimeUtc(long fileTime);
    
    /// <signature>#17 (D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
    static public native system.DateTime FromOADate(double d);
    
    /// <signature>#18 ()Lsystem/DateTime; ()LSystem/DateTime;</signature>
    static public native system.DateTime getNow();
    
    /// <signature>#19 ()Lsystem/DateTime; ()LSystem/DateTime;</signature>
    static public native system.DateTime getToday();
    
    /// <signature>#20 ()Lsystem/DateTime; ()LSystem/DateTime;</signature>
    static public native system.DateTime getUtcNow();
    
    /// <signature>#21 (I)Z (I)Z</signature>
    static public native boolean IsLeapYear(int year);
    
    /// <signature>#22 ()Lsystem/DateTime; ()LSystem/DateTime;</signature>
    static public native system.DateTime MaxValue();
    
    /// <signature>#23 ()Lsystem/DateTime; ()LSystem/DateTime;</signature>
    static public native system.DateTime MinValue();
    
    /// <signature>#24 (Ljava/lang/String;)Lsystem/DateTime; (Ljava/lang/String;)LSystem/DateTime;</signature>
    static public native system.DateTime Parse(java.lang.String s);
    
    /// <signature>#25 (Ljava/lang/String;Lsystem/IFormatProvider;)Lsystem/DateTime; (Ljava/lang/String;LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    static public native system.DateTime Parse(java.lang.String s, system.IFormatProvider provider);
    
    /// <signature>#26 (Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime; (Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;)LSystem/DateTime;</signature>
    static public native system.DateTime Parse(java.lang.String s, system.IFormatProvider provider, system.Enum styles);
    
    /// <signature>#27 (Ljava/lang/String;[Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime; (Ljava/lang/String;[Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;)LSystem/DateTime;</signature>
    static public native system.DateTime ParseExact(java.lang.String s, java.lang.String[] formats, system.IFormatProvider provider, system.Enum style);
    
    /// <signature>#28 (Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;)Lsystem/DateTime; (Ljava/lang/String;Ljava/lang/String;LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    static public native system.DateTime ParseExact(java.lang.String s, java.lang.String format, system.IFormatProvider provider);
    
    /// <signature>#29 (Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;)Lsystem/DateTime; (Ljava/lang/String;Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;)LSystem/DateTime;</signature>
    static public native system.DateTime ParseExact(java.lang.String s, java.lang.String format, system.IFormatProvider provider, system.Enum style);
    
    /// <signature>#30 (Lsystem/DateTime;Lsystem/Enum;)Lsystem/DateTime; (LSystem/DateTime;LSystem/Enum;)LSystem/DateTime;</signature>
    static public native system.DateTime SpecifyKind(system.DateTime value, system.Enum kind);
    
    /// <signature>#31 (Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;Lnet/sf/jni4net/OutSystem/DateTime;)Z</signature>
    static public native boolean TryParse(java.lang.String s, net.sf.jni4net.Out<system.DateTime> result);
    
    /// <signature>#32 (Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;Lnet/sf/jni4net/OutSystem/DateTime;)Z</signature>
    static public native boolean TryParse(java.lang.String s, system.IFormatProvider provider, system.Enum styles, net.sf.jni4net.Out<system.DateTime> result);
    
    /// <signature>#33 (Ljava/lang/String;[Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;[Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;Lnet/sf/jni4net/OutSystem/DateTime;)Z</signature>
    static public native boolean TryParseExact(java.lang.String s, java.lang.String[] formats, system.IFormatProvider provider, system.Enum style, net.sf.jni4net.Out<system.DateTime> result);
    
    /// <signature>#34 (Ljava/lang/String;Ljava/lang/String;Lsystem/IFormatProvider;Lsystem/Enum;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;Ljava/lang/String;LSystem/IFormatProvider;LSystem/Enum;Lnet/sf/jni4net/OutSystem/DateTime;)Z</signature>
    static public native boolean TryParseExact(java.lang.String s, java.lang.String format, system.IFormatProvider provider, system.Enum style, net.sf.jni4net.Out<system.DateTime> result);
    
    /// <signature>#35 (Lsystem/ValueType;)Lsystem/DateTime; (LSystem/ValueType;)LSystem/DateTime;</signature>
    public final native system.DateTime Add(system.ValueType value);
    
    /// <signature>#36 (D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
    public final native system.DateTime AddDays(double value);
    
    /// <signature>#37 (D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
    public final native system.DateTime AddHours(double value);
    
    /// <signature>#38 (D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
    public final native system.DateTime AddMilliseconds(double value);
    
    /// <signature>#39 (D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
    public final native system.DateTime AddMinutes(double value);
    
    /// <signature>#40 (I)Lsystem/DateTime; (I)LSystem/DateTime;</signature>
    public final native system.DateTime AddMonths(int months);
    
    /// <signature>#41 (D)Lsystem/DateTime; (D)LSystem/DateTime;</signature>
    public final native system.DateTime AddSeconds(double value);
    
    /// <signature>#42 (J)Lsystem/DateTime; (J)LSystem/DateTime;</signature>
    public final native system.DateTime AddTicks(long value);
    
    /// <signature>#43 (I)Lsystem/DateTime; (I)LSystem/DateTime;</signature>
    public final native system.DateTime AddYears(int value);
    
    /// <signature>#44 (Lsystem/DateTime;)I (LSystem/DateTime;)I</signature>
    public native int CompareTo(system.DateTime value);
    
    /// <signature>#45 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#46 (Lsystem/DateTime;)Z (LSystem/DateTime;)Z</signature>
    public native boolean Equals(system.DateTime value);
    
    /// <signature>#47 ()Lsystem/DateTime; ()LSystem/DateTime;</signature>
    public final native system.DateTime getDate();
    
    /// <signature>#48 ()I ()I</signature>
    public final native int getDay();
    
    /// <signature>#49 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public final native system.Enum getDayOfWeek();
    
    /// <signature>#50 ()I ()I</signature>
    public final native int getDayOfYear();
    
    /// <signature>#51 ()I ()I</signature>
    public final native int getHour();
    
    /// <signature>#52 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public final native system.Enum getKind();
    
    /// <signature>#53 ()I ()I</signature>
    public final native int getMillisecond();
    
    /// <signature>#54 ()I ()I</signature>
    public final native int getMinute();
    
    /// <signature>#55 ()I ()I</signature>
    public final native int getMonth();
    
    /// <signature>#56 ()I ()I</signature>
    public final native int getSecond();
    
    /// <signature>#57 ()J ()J</signature>
    public final native long getTicks();
    
    /// <signature>#58 ()Lsystem/ValueType; ()LSystem/ValueType;</signature>
    public final native system.ValueType getTimeOfDay();
    
    /// <signature>#59 ()I ()I</signature>
    public final native int getYear();
    
    /// <signature>#60 ()[Ljava/lang/String; ()[Ljava/lang/String;</signature>
    public final native java.lang.String[] GetDateTimeFormats();
    
    /// <signature>#61 (C)[Ljava/lang/String; (C)[Ljava/lang/String;</signature>
    public final native java.lang.String[] GetDateTimeFormats(char format);
    
    /// <signature>#62 (CLsystem/IFormatProvider;)[Ljava/lang/String; (CLSystem/IFormatProvider;)[Ljava/lang/String;</signature>
    public final native java.lang.String[] GetDateTimeFormats(char format, system.IFormatProvider provider);
    
    /// <signature>#63 (Lsystem/IFormatProvider;)[Ljava/lang/String; (LSystem/IFormatProvider;)[Ljava/lang/String;</signature>
    public final native java.lang.String[] GetDateTimeFormats(system.IFormatProvider provider);
    
    /// <signature>#64 (Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
    public native void GetObjectData(system.runtime.serialization.SerializationInfo info, system.runtime.serialization.StreamingContext context);
    
    /// <signature>#65 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetTypeCode();
    
    /// <signature>#66 ()Z ()Z</signature>
    public final native boolean IsDaylightSavingTime();
    
    /// <signature>#67 (Lsystem/DateTime;)Lsystem/ValueType; (LSystem/DateTime;)LSystem/ValueType;</signature>
    public final native system.ValueType Subtract(system.DateTime value);
    
    /// <signature>#68 (Lsystem/ValueType;)Lsystem/DateTime; (LSystem/ValueType;)LSystem/DateTime;</signature>
    public final native system.DateTime Subtract(system.ValueType value);
    
    /// <signature>#69 ()J ()J</signature>
    public final native long ToBinary();
    
    /// <signature>#70 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#71 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#72 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    public native char ToChar(system.IFormatProvider provider);
    
    /// <signature>#73 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#74 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#75 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    public native double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#76 ()J ()J</signature>
    public final native long ToFileTime();
    
    /// <signature>#77 ()J ()J</signature>
    public final native long ToFileTimeUtc();
    
    /// <signature>#78 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#79 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#80 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#81 ()Lsystem/DateTime; ()LSystem/DateTime;</signature>
    public final native system.DateTime ToLocalTime();
    
    /// <signature>#82 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String ToLongDateString();
    
    /// <signature>#83 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String ToLongTimeString();
    
    /// <signature>#84 ()D ()D</signature>
    public final native double ToOADate();
    
    /// <signature>#85 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#86 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String ToShortDateString();
    
    /// <signature>#87 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String ToShortTimeString();
    
    /// <signature>#88 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    public native float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#89 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#90 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String ToString(java.lang.String format);
    
    /// <signature>#91 (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider provider);
    
    /// <signature>#92 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    public native java.lang.Object ToType(system.Type type, system.IFormatProvider provider);
    
    /// <signature>#93 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#94 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#95 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToUInt64(system.IFormatProvider provider);
    
    /// <signature>#96 ()Lsystem/DateTime; ()LSystem/DateTime;</signature>
    public final native system.DateTime ToUniversalTime();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.DateTime_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.DateTime.class, system.DateTime.class, system.DateTime.class, new system.DateTime.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
