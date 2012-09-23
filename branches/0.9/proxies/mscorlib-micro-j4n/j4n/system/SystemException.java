// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.SystemException.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class SystemException extends system.Exception
// <j4ni-SystemException>
// put user interfaces here
// </j4ni-SystemException>
{
    // <j4nb-SystemException> 
    // put user members here
    // </j4nb-SystemException>
    
    protected SystemException(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.SystemException(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.SystemException.j4n_ProxyInit(null);
    }
    
    public SystemException() {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor();
    }
    
    /// <signature>#0 ()V ()V</signature>
    private native long j4n_constructor();
    
    public SystemException(java.lang.String message) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(message);
    }
    
    /// <signature>#1 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    private native long j4n_constructor(java.lang.String message);
    
    public SystemException(java.lang.String message, java.lang.Throwable innerException) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(message, innerException);
    }
    
    /// <signature>#2 (Ljava/lang/String;Ljava/lang/Throwable;)V (Ljava/lang/String;Ljava/lang/Throwable;)V</signature>
    private native long j4n_constructor(java.lang.String message, java.lang.Throwable innerException);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.SystemException_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.SystemException.class, system.SystemException.class, system.SystemException.class, new system.SystemException.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
