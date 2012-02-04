package system;

@net.sf.jni4net.attributes.J4NProxy(system.IFormattable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IFormattable_
// <j4ni-IFormattable_>
// put user interfaces here
// </j4ni-IFormattable_>
{
    // <j4nb-IFormattable_> 
    // put user members here
    // </j4nb-IFormattable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system._IFormattable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.IFormattable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IFormattable_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.IFormattable.class, system.IFormattable_.class, system._IFormattable.class, new system.IFormattable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.IFormattable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IFormattable extends system.Object implements system.IFormattable
// <j4ni-IFormattable>
// put user interfaces here
// </j4ni-IFormattable>
{
    // <j4nb-IFormattable> 
    // put user members here
    // </j4nb-IFormattable>
    
    _IFormattable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.IFormattable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider formatProvider);
}
