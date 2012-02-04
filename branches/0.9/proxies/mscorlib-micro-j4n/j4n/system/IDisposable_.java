package system;

@net.sf.jni4net.attributes.J4NProxy(system.IDisposable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IDisposable_
// <j4ni-IDisposable_>
// put user interfaces here
// </j4ni-IDisposable_>
{
    // <j4nb-IDisposable_> 
    // put user members here
    // </j4nb-IDisposable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system._IDisposable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.IDisposable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IDisposable_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.IDisposable.class, system.IDisposable_.class, system._IDisposable.class, new system.IDisposable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.IDisposable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IDisposable extends system.Object implements system.IDisposable
// <j4ni-IDisposable>
// put user interfaces here
// </j4ni-IDisposable>
{
    // <j4nb-IDisposable> 
    // put user members here
    // </j4nb-IDisposable>
    
    _IDisposable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.IDisposable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()V ()V</signature>
    public native void Dispose();
}
