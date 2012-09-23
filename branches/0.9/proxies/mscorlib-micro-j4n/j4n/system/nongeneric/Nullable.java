// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.nongeneric;

@net.sf.jni4net.attributes.J4NProxy(system.nongeneric.Nullable.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Nullable extends system.Object
// <j4ni-Nullable>
// put user interfaces here
// </j4ni-Nullable>
{
    // <j4nb-Nullable> 
    // put user members here
    // </j4nb-Nullable>
    
    private Nullable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.nongeneric.Nullable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.nongeneric.Nullable.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/Type;)Lsystem/Type; (LSystem/Type;)LSystem/Type;</signature>
    static public native system.Type GetUnderlyingType(system.Type nullableType);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Nullable_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.nongeneric.Nullable.class, system.nongeneric.Nullable.class, system.nongeneric.Nullable.class, new system.nongeneric.Nullable.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
