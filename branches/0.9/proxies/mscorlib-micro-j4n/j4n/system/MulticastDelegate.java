// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.MulticastDelegate.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class MulticastDelegate extends system.Delegate
// <j4ni-MulticastDelegate>
// put user interfaces here
// </j4ni-MulticastDelegate>
{
    // <j4nb-MulticastDelegate> 
    // put user members here
    // </j4nb-MulticastDelegate>
    
    protected MulticastDelegate(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.MulticastDelegate(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.MulticastDelegate.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.MulticastDelegate_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.MulticastDelegate.class, system.MulticastDelegate.class, system.MulticastDelegate.class, new system.MulticastDelegate.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
