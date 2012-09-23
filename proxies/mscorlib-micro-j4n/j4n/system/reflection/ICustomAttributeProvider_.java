package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.ICustomAttributeProvider_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ICustomAttributeProvider_
// <j4ni-ICustomAttributeProvider_>
// put user interfaces here
// </j4ni-ICustomAttributeProvider_>
{
    // <j4nb-ICustomAttributeProvider_> 
    // put user members here
    // </j4nb-ICustomAttributeProvider_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection._ICustomAttributeProvider(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.reflection.ICustomAttributeProvider_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.ICustomAttributeProvider_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.reflection.ICustomAttributeProvider.class, system.reflection.ICustomAttributeProvider_.class, system.reflection._ICustomAttributeProvider.class, new system.reflection.ICustomAttributeProvider_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.reflection.ICustomAttributeProvider_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ICustomAttributeProvider extends system.Object implements system.reflection.ICustomAttributeProvider
// <j4ni-ICustomAttributeProvider>
// put user interfaces here
// </j4ni-ICustomAttributeProvider>
{
    // <j4nb-ICustomAttributeProvider> 
    // put user members here
    // </j4nb-ICustomAttributeProvider>
    
    _ICustomAttributeProvider(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.reflection.ICustomAttributeProvider_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] GetCustomAttributes(system.Type attributeType, boolean inherit);
    
    /// <signature>#1 (Z)[Ljava/lang/Object; (Z)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] GetCustomAttributes(boolean inherit);
    
    /// <signature>#2 (Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
    public native boolean IsDefined(system.Type attributeType, boolean inherit);
}
