// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Single.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class Single extends system.ValueType implements system.nongeneric.IComparable, system.IFormattable, system.IConvertible
// <j4ni-Single>
// put user interfaces here
// </j4ni-Single>
{
    // <j4nb-Single> 
    public Single(float value) {
        super(net.sf.jni4net.core.Registry.CreateBoxedFloat(value), (net.sf.jni4net.core.ClrInstanceInfo)null);
    }

    public float value() {
        return net.sf.jni4net.core.Registry.UnboxFloat(j4n_clrHandle);
    }
    // </j4nb-Single>
    
    private Single(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Single(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Single.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()F ()F</signature>
    static public native float Epsilon();
    
    /// <signature>#1 (F)Z (F)Z</signature>
    static public native boolean IsInfinity(float f);
    
    /// <signature>#2 (F)Z (F)Z</signature>
    static public native boolean IsNaN(float f);
    
    /// <signature>#3 (F)Z (F)Z</signature>
    static public native boolean IsNegativeInfinity(float f);
    
    /// <signature>#4 (F)Z (F)Z</signature>
    static public native boolean IsPositiveInfinity(float f);
    
    /// <signature>#5 ()F ()F</signature>
    static public native float MaxValue();
    
    /// <signature>#6 ()F ()F</signature>
    static public native float MinValue();
    
    /// <signature>#7 ()F ()F</signature>
    static public native float NaN();
    
    /// <signature>#8 ()F ()F</signature>
    static public native float NegativeInfinity();
    
    /// <signature>#9 (Ljava/lang/String;)F (Ljava/lang/String;)F</signature>
    static public native float Parse(java.lang.String s);
    
    /// <signature>#10 (Ljava/lang/String;Lsystem/Enum;)F (Ljava/lang/String;LSystem/Enum;)F</signature>
    static public native float Parse(java.lang.String s, system.Enum style);
    
    /// <signature>#11 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;)F (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;)F</signature>
    static public native float Parse(java.lang.String s, system.Enum style, system.IFormatProvider provider);
    
    /// <signature>#12 (Ljava/lang/String;Lsystem/IFormatProvider;)F (Ljava/lang/String;LSystem/IFormatProvider;)F</signature>
    static public native float Parse(java.lang.String s, system.IFormatProvider provider);
    
    /// <signature>#13 ()F ()F</signature>
    static public native float PositiveInfinity();
    
    /// <signature>#14 (Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;Lnet/sf/jni4net/OutF;)Z</signature>
    static public native boolean TryParse(java.lang.String s, net.sf.jni4net.Out<system.Single> result);
    
    /// <signature>#15 (Ljava/lang/String;Lsystem/Enum;Lsystem/IFormatProvider;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;LSystem/Enum;LSystem/IFormatProvider;Lnet/sf/jni4net/OutF;)Z</signature>
    static public native boolean TryParse(java.lang.String s, system.Enum style, system.IFormatProvider provider, net.sf.jni4net.Out<system.Single> result);
    
    /// <signature>#16 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#17 (F)I (F)I</signature>
    public native int CompareTo(float value);
    
    /// <signature>#18 (F)Z (F)Z</signature>
    public native boolean Equals(float obj);
    
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
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Single_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.Single.class, system.Single.class, system.Single.class, new system.Single.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
