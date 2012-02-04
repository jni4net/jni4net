// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Double.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class Double extends system.ValueType implements system.nongeneric.IComparable, system.IFormattable, system.IConvertible
// <j4ni-Double>
// put user interfaces here
// </j4ni-Double>
{
    // <j4nb-Double> 
    public Double(double value) {
        super(net.sf.jni4net.core.Registry.CreateBoxedDouble(value), (net.sf.jni4net.core.ClrInstanceInfo)null);
    }

    public double value() {
        return net.sf.jni4net.core.Registry.UnboxDouble(j4n_clrHandle);
    }
    // </j4nb-Double>
    
    private Double(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Double(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Double.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()D ()D</signature>
    static public native double Epsilon();
    
    /// <signature>#1 (D)Z (D)Z</signature>
    static public native boolean IsInfinity(double d);
    
    /// <signature>#2 (D)Z (D)Z</signature>
    static public native boolean IsNaN(double d);
    
    /// <signature>#3 (D)Z (D)Z</signature>
    static public native boolean IsNegativeInfinity(double d);
    
    /// <signature>#4 (D)Z (D)Z</signature>
    static public native boolean IsPositiveInfinity(double d);
    
    /// <signature>#5 ()D ()D</signature>
    static public native double MaxValue();
    
    /// <signature>#6 ()D ()D</signature>
    static public native double MinValue();
    
    /// <signature>#7 ()D ()D</signature>
    static public native double NaN();
    
    /// <signature>#8 ()D ()D</signature>
    static public native double NegativeInfinity();
    
    /// <signature>#9 (Ljava/lang/String;)D (Ljava/lang/String;)D</signature>
    static public native double Parse(java.lang.String s);
    
    /// <signature>#10 (Ljava/lang/String;Lsystem/Enum;)D (Ljava/lang/String;LSystem/Enum;)D</signature>
    static public native double Parse(java.lang.String s, system.Enum style);
    
    /// <signature>#11 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;)D (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;)D</signature>
    static public native double Parse(java.lang.String s, system.Enum style, system.IFormatProvider provider);
    
    /// <signature>#12 (Ljava/lang/String;Lsystem/IFormatProvider;)D (Ljava/lang/String;LSystem/IFormatProvider;)D</signature>
    static public native double Parse(java.lang.String s, system.IFormatProvider provider);
    
    /// <signature>#13 ()D ()D</signature>
    static public native double PositiveInfinity();
    
    /// <signature>#14 (Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;Lnet/sf/jni4net/OutD;)Z</signature>
    static public native boolean TryParse(java.lang.String s, net.sf.jni4net.Out<system.Double> result);
    
    /// <signature>#15 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;Lnet/sf/jni4net/OutD;)Z</signature>
    static public native boolean TryParse(java.lang.String s, system.Enum style, system.IFormatProvider provider, net.sf.jni4net.Out<system.Double> result);
    
    /// <signature>#16 (D)I (D)I</signature>
    public native int CompareTo(double value);
    
    /// <signature>#17 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#18 (D)Z (D)Z</signature>
    public native boolean Equals(double obj);
    
    /// <signature>#19 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetTypeCode();
    
    /// <signature>#20 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#21 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#22 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    public native char ToChar(system.IFormatProvider provider);
    
    /// <signature>#23 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#24 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#25 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    public native double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#26 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#27 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#28 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#29 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#30 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    public native float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#31 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#32 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String ToString(java.lang.String format);
    
    /// <signature>#33 (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider provider);
    
    /// <signature>#34 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    public native java.lang.Object ToType(system.Type type, system.IFormatProvider provider);
    
    /// <signature>#35 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#36 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#37 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToUInt64(system.IFormatProvider provider);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Double_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.Double.class, system.Double.class, system.Double.class, new system.Double.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
