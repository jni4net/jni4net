package java_.io;

@net.sf.jni4net.attributes.J4NProxy(java_.io.Flushable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Flushable_
// <j4ni-Flushable_>
// put user interfaces here
// </j4ni-Flushable_>
{
    // <j4nb-Flushable_> 
    // put user members here
    // </j4nb-Flushable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.io._Flushable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.io.Flushable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.io.Flushable_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.io.Flushable.class, java_.io.Flushable_.class, java_.io._Flushable.class, new java_.io.Flushable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.io.Flushable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Flushable extends system.Object implements java.io.Flushable
// <j4ni-Flushable>
// put user interfaces here
// </j4ni-Flushable>
{
    // <j4nb-Flushable> 
    // put user members here
    // </j4nb-Flushable>
    
    _Flushable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.io.Flushable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()V ()V</signature>
    public native void flush();
}
