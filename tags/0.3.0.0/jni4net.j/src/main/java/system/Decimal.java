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
public class Decimal extends system.ValueType implements system.IFormattable, system.IComparable, system.IConvertible {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected Decimal(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(I)V")
    public Decimal(int value) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.Decimal.__ctorDecimal0(this, value);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(J)V")
    public Decimal(long value) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.Decimal.__ctorDecimal1(this, value);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(F)V")
    public Decimal(float value) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.Decimal.__ctorDecimal2(this, value);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(D)V")
    public Decimal(double value) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.Decimal.__ctorDecimal3(this, value);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("([I)V")
    public Decimal(int[] bits) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.Decimal.__ctorDecimal4(this, bits);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(IIIZB)V")
    public Decimal(int lo, int mid, int hi, boolean isNegative, byte scale) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.Decimal.__ctorDecimal5(this, lo, mid, hi, isNegative, scale);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    private native static void __ctorDecimal0(net.sf.jni4net.inj.IClrProxy thiz, int value);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)V")
    private native static void __ctorDecimal1(net.sf.jni4net.inj.IClrProxy thiz, long value);
    
    @net.sf.jni4net.attributes.ClrMethod("(F)V")
    private native static void __ctorDecimal2(net.sf.jni4net.inj.IClrProxy thiz, float value);
    
    @net.sf.jni4net.attributes.ClrMethod("(D)V")
    private native static void __ctorDecimal3(net.sf.jni4net.inj.IClrProxy thiz, double value);
    
    @net.sf.jni4net.attributes.ClrMethod("([I)V")
    private native static void __ctorDecimal4(net.sf.jni4net.inj.IClrProxy thiz, int[] bits);
    
    @net.sf.jni4net.attributes.ClrMethod("(IIIZB)V")
    private native static void __ctorDecimal5(net.sf.jni4net.inj.IClrProxy thiz, int lo, int mid, int hi, boolean isNegative, byte scale);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/IFormatProvider;)LSystem/String;")
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider formatProvider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)I")
    public native int CompareTo(system.Object obj);
    
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
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)J")
    public native static long ToOACurrency(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)LSystem/Decimal;")
    public native static system.Decimal FromOACurrency(long cy);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Add(system.Decimal d1, system.Decimal d2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Ceiling(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;LSystem/Decimal;)I")
    public native static int Compare(system.Decimal d1, system.Decimal d2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)I")
    public native int CompareTo(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Divide(system.Decimal d1, system.Decimal d2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)Z")
    public native boolean Equals(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;LSystem/Decimal;)Z")
    public native static boolean Equals(system.Decimal d1, system.Decimal d2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Floor(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/String;")
    public native final java.lang.String ToString(java.lang.String format);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Decimal;")
    public native static system.Decimal Parse(java.lang.String s);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Globalization/NumberStyles;)LSystem/Decimal;")
    public native static system.Decimal Parse(java.lang.String s, system.Enum style);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/IFormatProvider;)LSystem/Decimal;")
    public native static system.Decimal Parse(java.lang.String s, system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Globalization/NumberStyles;LSystem/IFormatProvider;)LSystem/Decimal;")
    public native static system.Decimal Parse(java.lang.String s, system.Enum style, system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)[I")
    public native static int[] GetBits(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Remainder(system.Decimal d1, system.Decimal d2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Multiply(system.Decimal d1, system.Decimal d2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Negate(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Round(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;I)LSystem/Decimal;")
    public native static system.Decimal Round(system.Decimal d, int decimals);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;LSystem/MidpointRounding;)LSystem/Decimal;")
    public native static system.Decimal Round(system.Decimal d, system.Enum mode);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;ILSystem/MidpointRounding;)LSystem/Decimal;")
    public native static system.Decimal Round(system.Decimal d, int decimals, system.Enum mode);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Subtract(system.Decimal d1, system.Decimal d2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)B")
    public native static byte ToByte(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/SByte;")
    public native static byte ToSByte(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)S")
    public native static short ToInt16(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)D")
    public native static double ToDouble(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)I")
    public native static int ToInt32(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)J")
    public native static long ToInt64(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/UInt16;")
    public native static short ToUInt16(system.Decimal value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/UInt32;")
    public native static int ToUInt32(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/UInt64;")
    public native static long ToUInt64(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)F")
    public native static float ToSingle(system.Decimal d);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Decimal;)LSystem/Decimal;")
    public native static system.Decimal Truncate(system.Decimal d);
    
    public static system.Type typeof() {
        return system.Decimal.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.Decimal.staticType = staticType;
    }
    //</generated-proxy>
}
