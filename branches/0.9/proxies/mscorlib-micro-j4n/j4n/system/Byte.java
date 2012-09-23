// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Byte.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class Byte extends system.ValueType implements system.nongeneric.IComparable, system.IFormattable, system.IConvertible
// <j4ni-Byte>
// put user interfaces here
// </j4ni-Byte>
{
    // <j4nb-Byte> 
    public Byte(byte value) {
        super(net.sf.jni4net.core.Registry.CreateBoxedByte(value), (net.sf.jni4net.core.ClrInstanceInfo)null);
    }

    public byte value() {
        return net.sf.jni4net.core.Registry.UnboxByte(j4n_clrHandle);
    }
    // </j4nb-Byte>
    
    private Byte(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Byte(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Byte.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()B ()B</signature>
    static public native byte MaxValue();
    
    /// <signature>#1 ()B ()B</signature>
    static public native byte MinValue();
    
    /// <signature>#2 (Ljava/lang/String;)B (Ljava/lang/String;)B</signature>
    static public native byte Parse(java.lang.String s);
    
    /// <signature>#3 (Ljava/lang/String;Lsystem/Enum;)B (Ljava/lang/String;LSystem/Enum;)B</signature>
    static public native byte Parse(java.lang.String s, system.Enum style);
    
    /// <signature>#4 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;)B (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;)B</signature>
    static public native byte Parse(java.lang.String s, system.Enum style, system.IFormatProvider provider);
    
    /// <signature>#5 (Ljava/lang/String;Lsystem/IFormatProvider;)B (Ljava/lang/String;LSystem/IFormatProvider;)B</signature>
    static public native byte Parse(java.lang.String s, system.IFormatProvider provider);
    
    /// <signature>#6 (Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;Lnet/sf/jni4net/OutB;)Z</signature>
    static public native boolean TryParse(java.lang.String s, net.sf.jni4net.Out<system.Byte> result);
    
    /// <signature>#7 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;Lnet/sf/jni4net/OutB;)Z</signature>
    static public native boolean TryParse(java.lang.String s, system.Enum style, system.IFormatProvider provider, net.sf.jni4net.Out<system.Byte> result);
    
    /// <signature>#8 (B)I (B)I</signature>
    public native int CompareTo(byte value);
    
    /// <signature>#9 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#10 (B)Z (B)Z</signature>
    public native boolean Equals(byte obj);
    
    /// <signature>#11 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetTypeCode();
    
    /// <signature>#12 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#13 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#14 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    public native char ToChar(system.IFormatProvider provider);
    
    /// <signature>#15 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#16 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#17 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    public native double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#18 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#19 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#20 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#21 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#22 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    public native float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#23 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#24 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String ToString(java.lang.String format);
    
    /// <signature>#25 (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider provider);
    
    /// <signature>#26 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    public native java.lang.Object ToType(system.Type type, system.IFormatProvider provider);
    
    /// <signature>#27 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#28 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#29 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToUInt64(system.IFormatProvider provider);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Byte_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.Byte.class, system.Byte.class, system.Byte.class, new system.Byte.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
