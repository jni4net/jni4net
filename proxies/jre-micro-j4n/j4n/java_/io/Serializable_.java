package java_.io;

@net.sf.jni4net.attributes.J4NProxy(java_.io.Serializable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Serializable_
// <j4ni-Serializable_>
// put user interfaces here
// </j4ni-Serializable_>
{
    // <j4nb-Serializable_> 
    // put user members here
    // </j4nb-Serializable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.io._Serializable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.io.Serializable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.io.Serializable_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.io.Serializable.class, java_.io.Serializable_.class, java_.io._Serializable.class, new java_.io.Serializable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.io.Serializable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Serializable extends system.Object implements java.io.Serializable
// <j4ni-Serializable>
// put user interfaces here
// </j4ni-Serializable>
{
    // <j4nb-Serializable> 
    // put user members here
    // </j4nb-Serializable>
    
    _Serializable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.io.Serializable_.j4n_ProxyInit(null);
    }
}
