// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.ArgumentException.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ArgumentException extends system.SystemException
// <j4ni-ArgumentException>
// put user interfaces here
// </j4ni-ArgumentException>
{
    // <j4nb-ArgumentException> 
    // put user members here
    // </j4nb-ArgumentException>
    
    protected ArgumentException(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.ArgumentException(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.ArgumentException.j4n_ProxyInit(null);
    }
    
    public ArgumentException() {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor();
    }
    
    /// <signature>#0 ()V ()V</signature>
    private native long j4n_constructor();
    
    public ArgumentException(java.lang.String message) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(message);
    }
    
    /// <signature>#1 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    private native long j4n_constructor(java.lang.String message);
    
    public ArgumentException(java.lang.String message, java.lang.Throwable innerException) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(message, innerException);
    }
    
    /// <signature>#2 (Ljava/lang/String;Ljava/lang/Throwable;)V (Ljava/lang/String;Ljava/lang/Throwable;)V</signature>
    private native long j4n_constructor(java.lang.String message, java.lang.Throwable innerException);
    
    public ArgumentException(java.lang.String message, java.lang.String paramName) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(message, paramName);
    }
    
    /// <signature>#3 (Ljava/lang/String;Ljava/lang/String;)V (Ljava/lang/String;Ljava/lang/String;)V</signature>
    private native long j4n_constructor(java.lang.String message, java.lang.String paramName);
    
    public ArgumentException(java.lang.String message, java.lang.String paramName, java.lang.Throwable innerException) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(message, paramName, innerException);
    }
    
    /// <signature>#4 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V</signature>
    private native long j4n_constructor(java.lang.String message, java.lang.String paramName, java.lang.Throwable innerException);
    
    /// <signature>#5 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getParamName();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.ArgumentException_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.ArgumentException.class, system.ArgumentException.class, system.ArgumentException.class, new system.ArgumentException.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
