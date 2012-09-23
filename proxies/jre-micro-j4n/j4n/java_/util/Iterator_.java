package java_.util;

@net.sf.jni4net.attributes.J4NProxy(java_.util.Iterator_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Iterator_
// <j4ni-Iterator_>
// put user interfaces here
// </j4ni-Iterator_>
{
    // <j4nb-Iterator_> 
    // put user members here
    // </j4nb-Iterator_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.util._Iterator(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.util.Iterator_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.util.Iterator_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.util.Iterator.class, java_.util.Iterator_.class, java_.util._Iterator.class, new java_.util.Iterator_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.util.Iterator_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Iterator extends system.Object implements java.util.Iterator
// <j4ni-Iterator>
// put user interfaces here
// </j4ni-Iterator>
{
    // <j4nb-Iterator> 
    // put user members here
    // </j4nb-Iterator>
    
    _Iterator(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.util.Iterator_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Z ()Z</signature>
    public native boolean hasNext();
    
    /// <signature>#1 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object next();
    
    /// <signature>#2 ()V ()V</signature>
    public native void remove();
}
