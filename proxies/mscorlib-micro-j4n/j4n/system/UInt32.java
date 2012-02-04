// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.UInt32.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class UInt32 extends system.ValueType implements system.nongeneric.IComparable, system.IFormattable, system.IConvertible
// <j4ni-UInt32>
// put user interfaces here
// </j4ni-UInt32>
{
    // <j4nb-UInt32> 
    // put user members here
    // </j4nb-UInt32>
    
    private UInt32(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.UInt32(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.UInt32.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()I ()I</signature>
    static public native int MaxValue();
    
    /// <signature>#1 ()I ()I</signature>
    static public native int MinValue();
    
    /// <signature>#2 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
    static public native int Parse(java.lang.String s);
    
    /// <signature>#3 (Ljava/lang/String;Lsystem/Enum;)I (Ljava/lang/String;LSystem/Enum;)I</signature>
    static public native int Parse(java.lang.String s, system.Enum style);
    
    /// <signature>#4 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;)I (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;)I</signature>
    static public native int Parse(java.lang.String s, system.Enum style, system.IFormatProvider provider);
    
    /// <signature>#5 (Ljava/lang/String;Lsystem/IFormatProvider;)I (Ljava/lang/String;LSystem/IFormatProvider;)I</signature>
    static public native int Parse(java.lang.String s, system.IFormatProvider provider);
    
    /// <signature>#6 (Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;Lnet/sf/jni4net/Outi;)Z</signature>
    static public native boolean TryParse(java.lang.String s, net.sf.jni4net.Out<system.UInt32> result);
    
    /// <signature>#7 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;Lnet/sf/jni4net/Outi;)Z</signature>
    static public native boolean TryParse(java.lang.String s, system.Enum style, system.IFormatProvider provider, net.sf.jni4net.Out<system.UInt32> result);
    
    /// <signature>#8 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#9 (I)I (I)I</signature>
    public native int CompareTo(int value);
    
    /// <signature>#10 (I)Z (I)Z</signature>
    public native boolean Equals(int obj);
    
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
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.UInt32_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.UInt32.class, system.UInt32.class, system.UInt32.class, new system.UInt32.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
