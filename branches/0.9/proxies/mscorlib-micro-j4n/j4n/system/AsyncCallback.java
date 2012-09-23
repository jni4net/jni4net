// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.AsyncCallback.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class AsyncCallback extends system.MulticastDelegate
// <j4ni-AsyncCallback>
// put user interfaces here
// </j4ni-AsyncCallback>
{
    // <j4nb-AsyncCallback> 
    // put user members here
    // </j4nb-AsyncCallback>
    
    private AsyncCallback(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.AsyncCallback(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.AsyncCallback.j4n_ProxyInit(null);
    }
    
    /// <signature>#1 (Lsystem/IAsyncResult;Lsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult; (LSystem/IAsyncResult;LSystem/AsyncCallback;Ljava/lang/Object;)LSystem/IAsyncResult;</signature>
    public native system.IAsyncResult BeginInvoke(system.IAsyncResult ar, system.AsyncCallback callback, java.lang.Object _object);
    
    /// <signature>#2 (Lsystem/IAsyncResult;)V (LSystem/IAsyncResult;)V</signature>
    public native void EndInvoke(system.IAsyncResult result);
    
    /// <signature>#3 (Lsystem/IAsyncResult;)V (LSystem/IAsyncResult;)V</signature>
    public native void Invoke(system.IAsyncResult ar);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.AsyncCallback_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.AsyncCallback.class, system.AsyncCallback.class, system.AsyncCallback.class, new system.AsyncCallback.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
