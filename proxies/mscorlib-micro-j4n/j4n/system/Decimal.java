// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Decimal.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class Decimal extends system.ValueType implements system.IFormattable, system.nongeneric.IComparable, system.IConvertible
// <j4ni-Decimal>
// put user interfaces here
// </j4ni-Decimal>
{
    // <j4nb-Decimal> 
    // put user members here
    // </j4nb-Decimal>
    
    private Decimal(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Decimal(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Decimal.j4n_ProxyInit(null);
    }
    
    public Decimal(int[] bits) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(bits);
    }
    
    /// <signature>#0 ([I)V ([I)V</signature>
    private native long j4n_constructor(int[] bits);
    
    public Decimal(double value) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(value);
    }
    
    /// <signature>#1 (D)V (D)V</signature>
    private native long j4n_constructor(double value);
    
    public Decimal(int value) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(value);
    }
    
    /// <signature>#2 (I)V (I)V</signature>
    private native long j4n_constructor(int value);
    
    public Decimal(int lo, int mid, int hi, boolean isNegative, byte scale) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(lo, mid, hi, isNegative, scale);
    }
    
    /// <signature>#3 (IIIZB)V (IIIZB)V</signature>
    private native long j4n_constructor(int lo, int mid, int hi, boolean isNegative, byte scale);
    
    public Decimal(long value) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(value);
    }
    
    /// <signature>#4 (J)V (J)V</signature>
    private native long j4n_constructor(long value);
    
    public Decimal(float value) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(value);
    }
    
    /// <signature>#5 (F)V (F)V</signature>
    private native long j4n_constructor(float value);
    
    /// <signature>#8 (Lsystem/Decimal;Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Add(system.Decimal d1, system.Decimal d2);
    
    /// <signature>#9 (Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Ceiling(system.Decimal d);
    
    /// <signature>#10 (Lsystem/Decimal;Lsystem/Decimal;)I (LSystem/Decimal;LSystem/Decimal;)I</signature>
    static public native int Compare(system.Decimal d1, system.Decimal d2);
    
    /// <signature>#11 (Lsystem/Decimal;Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Divide(system.Decimal d1, system.Decimal d2);
    
    /// <signature>#12 (Lsystem/Decimal;Lsystem/Decimal;)Z (LSystem/Decimal;LSystem/Decimal;)Z</signature>
    static public native boolean Equals(system.Decimal d1, system.Decimal d2);
    
    /// <signature>#13 (Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Floor(system.Decimal d);
    
    /// <signature>#14 (J)Lsystem/Decimal; (J)LSystem/Decimal;</signature>
    static public native system.Decimal FromOACurrency(long cy);
    
    /// <signature>#15 (Lsystem/Decimal;)[I (LSystem/Decimal;)[I</signature>
    static public native int[] GetBits(system.Decimal d);
    
    /// <signature>#16 ()Lsystem/Decimal; ()LSystem/Decimal;</signature>
    static public native system.Decimal MaxValue();
    
    /// <signature>#17 ()Lsystem/Decimal; ()LSystem/Decimal;</signature>
    static public native system.Decimal MinusOne();
    
    /// <signature>#18 ()Lsystem/Decimal; ()LSystem/Decimal;</signature>
    static public native system.Decimal MinValue();
    
    /// <signature>#19 (Lsystem/Decimal;Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Multiply(system.Decimal d1, system.Decimal d2);
    
    /// <signature>#20 (Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Negate(system.Decimal d);
    
    /// <signature>#21 ()Lsystem/Decimal; ()LSystem/Decimal;</signature>
    static public native system.Decimal One();
    
    /// <signature>#22 (Ljava/lang/String;)Lsystem/Decimal; (Ljava/lang/String;)LSystem/Decimal;</signature>
    static public native system.Decimal Parse(java.lang.String s);
    
    /// <signature>#23 (Ljava/lang/String;Lsystem/Enum;)Lsystem/Decimal; (Ljava/lang/String;LSystem/Enum;)LSystem/Decimal;</signature>
    static public native system.Decimal Parse(java.lang.String s, system.Enum style);
    
    /// <signature>#24 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;)Lsystem/Decimal; (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    static public native system.Decimal Parse(java.lang.String s, system.Enum style, system.IFormatProvider provider);
    
    /// <signature>#25 (Ljava/lang/String;Lsystem/IFormatProvider;)Lsystem/Decimal; (Ljava/lang/String;LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    static public native system.Decimal Parse(java.lang.String s, system.IFormatProvider provider);
    
    /// <signature>#26 (Lsystem/Decimal;Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Remainder(system.Decimal d1, system.Decimal d2);
    
    /// <signature>#27 (Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Round(system.Decimal d);
    
    /// <signature>#28 (Lsystem/Decimal;I)Lsystem/Decimal; (LSystem/Decimal;I)LSystem/Decimal;</signature>
    static public native system.Decimal Round(system.Decimal d, int decimals);
    
    /// <signature>#29 (Lsystem/Decimal;ILsystem/Enum;)Lsystem/Decimal; (LSystem/Decimal;ILSystem/Enum;)LSystem/Decimal;</signature>
    static public native system.Decimal Round(system.Decimal d, int decimals, system.Enum mode);
    
    /// <signature>#30 (Lsystem/Decimal;Lsystem/Enum;)Lsystem/Decimal; (LSystem/Decimal;LSystem/Enum;)LSystem/Decimal;</signature>
    static public native system.Decimal Round(system.Decimal d, system.Enum mode);
    
    /// <signature>#31 (Lsystem/Decimal;Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Subtract(system.Decimal d1, system.Decimal d2);
    
    /// <signature>#32 (Lsystem/Decimal;)B (LSystem/Decimal;)B</signature>
    static public native byte ToByte(system.Decimal value);
    
    /// <signature>#33 (Lsystem/Decimal;)D (LSystem/Decimal;)D</signature>
    static public native double ToDouble(system.Decimal d);
    
    /// <signature>#34 (Lsystem/Decimal;)S (LSystem/Decimal;)S</signature>
    static public native short ToInt16(system.Decimal value);
    
    /// <signature>#35 (Lsystem/Decimal;)I (LSystem/Decimal;)I</signature>
    static public native int ToInt32(system.Decimal d);
    
    /// <signature>#36 (Lsystem/Decimal;)J (LSystem/Decimal;)J</signature>
    static public native long ToInt64(system.Decimal d);
    
    /// <signature>#37 (Lsystem/Decimal;)J (LSystem/Decimal;)J</signature>
    static public native long ToOACurrency(system.Decimal value);
    
    /// <signature>#38 (Lsystem/Decimal;)B (LSystem/Decimal;)B</signature>
    static public native byte ToSByte(system.Decimal value);
    
    /// <signature>#39 (Lsystem/Decimal;)F (LSystem/Decimal;)F</signature>
    static public native float ToSingle(system.Decimal d);
    
    /// <signature>#40 (Lsystem/Decimal;)S (LSystem/Decimal;)S</signature>
    static public native short ToUInt16(system.Decimal value);
    
    /// <signature>#41 (Lsystem/Decimal;)I (LSystem/Decimal;)I</signature>
    static public native int ToUInt32(system.Decimal d);
    
    /// <signature>#42 (Lsystem/Decimal;)J (LSystem/Decimal;)J</signature>
    static public native long ToUInt64(system.Decimal d);
    
    /// <signature>#43 (Lsystem/Decimal;)Lsystem/Decimal; (LSystem/Decimal;)LSystem/Decimal;</signature>
    static public native system.Decimal Truncate(system.Decimal d);
    
    /// <signature>#44 (Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;Lnet/sf/jni4net/OutSystem/Decimal;)Z</signature>
    static public native boolean TryParse(java.lang.String s, net.sf.jni4net.Out<system.Decimal> result);
    
    /// <signature>#45 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;Lnet/sf/jni4net/OutSystem/Decimal;)Z</signature>
    static public native boolean TryParse(java.lang.String s, system.Enum style, system.IFormatProvider provider, net.sf.jni4net.Out<system.Decimal> result);
    
    /// <signature>#46 ()Lsystem/Decimal; ()LSystem/Decimal;</signature>
    static public native system.Decimal Zero();
    
    /// <signature>#47 (Lsystem/Decimal;)I (LSystem/Decimal;)I</signature>
    public native int CompareTo(system.Decimal value);
    
    /// <signature>#48 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#49 (Lsystem/Decimal;)Z (LSystem/Decimal;)Z</signature>
    public native boolean Equals(system.Decimal value);
    
    /// <signature>#50 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetTypeCode();
    
    /// <signature>#51 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#52 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#53 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    public native char ToChar(system.IFormatProvider provider);
    
    /// <signature>#54 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#55 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#56 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    public native double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#57 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#58 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#59 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#60 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#61 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    public native float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#62 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#63 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String ToString(java.lang.String format);
    
    /// <signature>#64 (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider provider);
    
    /// <signature>#65 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    public native java.lang.Object ToType(system.Type type, system.IFormatProvider provider);
    
    /// <signature>#66 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#67 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#68 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToUInt64(system.IFormatProvider provider);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Decimal_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.Decimal.class, system.Decimal.class, system.Decimal.class, new system.Decimal.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
