package java_.io;

@net.sf.jni4net.attributes.J4NProxy(java_.io.Closeable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Closeable_
// <j4ni-Closeable_>
// put user interfaces here
// </j4ni-Closeable_>
{
    // <j4nb-Closeable_> 
    // put user members here
    // </j4nb-Closeable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.io._Closeable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.io.Closeable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.io.Closeable_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.io.Closeable.class, java_.io.Closeable_.class, java_.io._Closeable.class, new java_.io.Closeable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.io.Closeable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Closeable extends system.Object implements java.io.Closeable
// <j4ni-Closeable>
// put user interfaces here
// </j4ni-Closeable>
{
    // <j4nb-Closeable> 
    // put user members here
    // </j4nb-Closeable>
    
    _Closeable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.io.Closeable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()V ()V</signature>
    public native void close();
}
