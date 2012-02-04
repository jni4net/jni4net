package java_.lang;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Cloneable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Cloneable_
// <j4ni-Cloneable_>
// put user interfaces here
// </j4ni-Cloneable_>
{
    // <j4nb-Cloneable_> 
    // put user members here
    // </j4nb-Cloneable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang._Cloneable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.Cloneable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.Cloneable_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.lang.Cloneable.class, java_.lang.Cloneable_.class, java_.lang._Cloneable.class, new java_.lang.Cloneable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Cloneable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Cloneable extends system.Object implements java.lang.Cloneable
// <j4ni-Cloneable>
// put user interfaces here
// </j4ni-Cloneable>
{
    // <j4nb-Cloneable> 
    // put user members here
    // </j4nb-Cloneable>
    
    _Cloneable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.Cloneable_.j4n_ProxyInit(null);
    }
}
