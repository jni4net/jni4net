package system;

@net.sf.jni4net.attributes.J4NProxy(system.ICloneable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ICloneable_
// <j4ni-ICloneable_>
// put user interfaces here
// </j4ni-ICloneable_>
{
    // <j4nb-ICloneable_> 
    // put user members here
    // </j4nb-ICloneable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system._ICloneable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.ICloneable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.ICloneable_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.ICloneable.class, system.ICloneable_.class, system._ICloneable.class, new system.ICloneable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.ICloneable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ICloneable extends system.Object implements system.ICloneable
// <j4ni-ICloneable>
// put user interfaces here
// </j4ni-ICloneable>
{
    // <j4nb-ICloneable> 
    // put user members here
    // </j4nb-ICloneable>
    
    _ICloneable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.ICloneable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object Clone();
}
