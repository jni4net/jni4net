package system;

@net.sf.jni4net.attributes.J4NProxy(system.IFormatProvider_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IFormatProvider_
// <j4ni-IFormatProvider_>
// put user interfaces here
// </j4ni-IFormatProvider_>
{
    // <j4nb-IFormatProvider_> 
    // put user members here
    // </j4nb-IFormatProvider_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system._IFormatProvider(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.IFormatProvider_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IFormatProvider_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.IFormatProvider.class, system.IFormatProvider_.class, system._IFormatProvider.class, new system.IFormatProvider_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.IFormatProvider_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IFormatProvider extends system.Object implements system.IFormatProvider
// <j4ni-IFormatProvider>
// put user interfaces here
// </j4ni-IFormatProvider>
{
    // <j4nb-IFormatProvider> 
    // put user members here
    // </j4nb-IFormatProvider>
    
    _IFormatProvider(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.IFormatProvider_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/Type;)Ljava/lang/Object; (LSystem/Type;)Ljava/lang/Object;</signature>
    public native java.lang.Object GetFormat(system.Type formatType);
}
