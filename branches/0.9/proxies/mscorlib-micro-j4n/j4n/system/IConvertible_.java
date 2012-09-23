package system;

@net.sf.jni4net.attributes.J4NProxy(system.IConvertible_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IConvertible_
// <j4ni-IConvertible_>
// put user interfaces here
// </j4ni-IConvertible_>
{
    // <j4nb-IConvertible_> 
    // put user members here
    // </j4nb-IConvertible_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system._IConvertible(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.IConvertible_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IConvertible_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.IConvertible.class, system.IConvertible_.class, system._IConvertible.class, new system.IConvertible_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.IConvertible_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IConvertible extends system.Object implements system.IConvertible
// <j4ni-IConvertible>
// put user interfaces here
// </j4ni-IConvertible>
{
    // <j4nb-IConvertible> 
    // put user members here
    // </j4nb-IConvertible>
    
    _IConvertible(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.IConvertible_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetTypeCode();
    
    /// <signature>#1 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#2 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#3 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    public native char ToChar(system.IFormatProvider provider);
    
    /// <signature>#4 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#5 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#6 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    public native double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#7 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#8 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#9 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#10 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#11 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    public native float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#12 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#13 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    public native java.lang.Object ToType(system.Type conversionType, system.IFormatProvider provider);
    
    /// <signature>#14 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#15 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#16 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToUInt64(system.IFormatProvider provider);
}
