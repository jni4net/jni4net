package system;

@net.sf.jni4net.attributes.J4NProxy(system.IAsyncResult_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IAsyncResult_
// <j4ni-IAsyncResult_>
// put user interfaces here
// </j4ni-IAsyncResult_>
{
    // <j4nb-IAsyncResult_> 
    // put user members here
    // </j4nb-IAsyncResult_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system._IAsyncResult(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.IAsyncResult_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IAsyncResult_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.IAsyncResult.class, system.IAsyncResult_.class, system._IAsyncResult.class, new system.IAsyncResult_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.IAsyncResult_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IAsyncResult extends system.Object implements system.IAsyncResult
// <j4ni-IAsyncResult>
// put user interfaces here
// </j4ni-IAsyncResult>
{
    // <j4nb-IAsyncResult> 
    // put user members here
    // </j4nb-IAsyncResult>
    
    _IAsyncResult(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.IAsyncResult_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getAsyncState();
    
    /// <signature>#1 ()Lsystem/MarshalByRefObject; ()LSystem/MarshalByRefObject;</signature>
    public native system.MarshalByRefObject getAsyncWaitHandle();
    
    /// <signature>#2 ()Z ()Z</signature>
    public native boolean getCompletedSynchronously();
    
    /// <signature>#3 ()Z ()Z</signature>
    public native boolean getIsCompleted();
}
