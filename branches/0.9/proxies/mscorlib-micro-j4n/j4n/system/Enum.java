// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Enum.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Enum extends system.ValueType implements system.nongeneric.IComparable, system.IFormattable, system.IConvertible
// <j4ni-Enum>
// put user interfaces here
// </j4ni-Enum>
{
    // <j4nb-Enum> 
    // put user members here
    // </j4nb-Enum>
    
    protected Enum(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Enum(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Enum.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String; (LSystem/Type;Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String Format(system.Type enumType, java.lang.Object value, java.lang.String format);
    
    /// <signature>#1 (Lsystem/Type;Ljava/lang/Object;)Ljava/lang/String; (LSystem/Type;Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String GetName(system.Type enumType, java.lang.Object value);
    
    /// <signature>#2 (Lsystem/Type;)[Ljava/lang/String; (LSystem/Type;)[Ljava/lang/String;</signature>
    static public native java.lang.String[] GetNames(system.Type enumType);
    
    /// <signature>#3 (Lsystem/Type;)Lsystem/Type; (LSystem/Type;)LSystem/Type;</signature>
    static public native system.Type GetUnderlyingType(system.Type enumType);
    
    /// <signature>#4 (Lsystem/Type;)Lsystem/Array; (LSystem/Type;)LSystem/Array;</signature>
    static public native system.Array GetValues(system.Type enumType);
    
    /// <signature>#5 (Lsystem/Type;Ljava/lang/Object;)Z (LSystem/Type;Ljava/lang/Object;)Z</signature>
    static public native boolean IsDefined(system.Type enumType, java.lang.Object value);
    
    /// <signature>#6 (Lsystem/Type;Ljava/lang/String;)Ljava/lang/Object; (LSystem/Type;Ljava/lang/String;)Ljava/lang/Object;</signature>
    static public native java.lang.Object Parse(system.Type enumType, java.lang.String value);
    
    /// <signature>#7 (Lsystem/Type;Ljava/lang/String;Z)Ljava/lang/Object; (LSystem/Type;Ljava/lang/String;Z)Ljava/lang/Object;</signature>
    static public native java.lang.Object Parse(system.Type enumType, java.lang.String value, boolean ignoreCase);
    
    /// <signature>#8 (Lsystem/Type;B)Ljava/lang/Object; (LSystem/Type;B)Ljava/lang/Object;</signature>
    static public native java.lang.Object ToObject(system.Type enumType, byte value);
    
    /// <signature>#9 (Lsystem/Type;S)Ljava/lang/Object; (LSystem/Type;S)Ljava/lang/Object;</signature>
    static public native java.lang.Object ToObject(system.Type enumType, short value);
    
    /// <signature>#10 (Lsystem/Type;I)Ljava/lang/Object; (LSystem/Type;I)Ljava/lang/Object;</signature>
    static public native java.lang.Object ToObject(system.Type enumType, int value);
    
    /// <signature>#11 (Lsystem/Type;J)Ljava/lang/Object; (LSystem/Type;J)Ljava/lang/Object;</signature>
    static public native java.lang.Object ToObject(system.Type enumType, long value);
    
    /// <signature>#12 (Lsystem/Type;Ljava/lang/Object;)Ljava/lang/Object; (LSystem/Type;Ljava/lang/Object;)Ljava/lang/Object;</signature>
    static public native java.lang.Object ToObject(system.Type enumType, java.lang.Object value);
    
    /// <signature>#17 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object target);
    
    /// <signature>#18 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetTypeCode();
    
    /// <signature>#19 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#20 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#21 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    public native char ToChar(system.IFormatProvider provider);
    
    /// <signature>#22 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#23 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#24 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    public native double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#25 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#26 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#27 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#28 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#29 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    public native float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#30 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#31 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String ToString(java.lang.String format);
    
    /// <signature>#32 (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider provider);
    
    /// <signature>#33 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    public native java.lang.Object ToType(system.Type type, system.IFormatProvider provider);
    
    /// <signature>#34 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#35 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#36 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToUInt64(system.IFormatProvider provider);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Enum_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.Enum.class, system.Enum.class, system.Enum.class, new system.Enum.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
