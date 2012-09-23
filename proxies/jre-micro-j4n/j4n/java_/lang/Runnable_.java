package java_.lang;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Runnable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Runnable_
// <j4ni-Runnable_>
// put user interfaces here
// </j4ni-Runnable_>
{
    // <j4nb-Runnable_> 
    // put user members here
    // </j4nb-Runnable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang._Runnable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.Runnable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.Runnable_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.lang.Runnable.class, java_.lang.Runnable_.class, java_.lang._Runnable.class, new java_.lang.Runnable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Runnable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Runnable extends system.Object implements java.lang.Runnable
// <j4ni-Runnable>
// put user interfaces here
// </j4ni-Runnable>
{
    // <j4nb-Runnable> 
    // put user members here
    // </j4nb-Runnable>
    
    _Runnable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.Runnable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()V ()V</signature>
    public native void run();
}
