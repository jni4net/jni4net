package java_.lang.reflect;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.Type_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Type_
// <j4ni-Type_>
// put user interfaces here
// </j4ni-Type_>
{
    // <j4nb-Type_> 
    // put user members here
    // </j4nb-Type_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.reflect._Type(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.reflect.Type_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.reflect.Type_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.lang.reflect.Type.class, java_.lang.reflect.Type_.class, java_.lang.reflect._Type.class, new java_.lang.reflect.Type_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.Type_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Type extends system.Object implements java.lang.reflect.Type
// <j4ni-Type>
// put user interfaces here
// </j4ni-Type>
{
    // <j4nb-Type> 
    // put user members here
    // </j4nb-Type>
    
    _Type(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.reflect.Type_.j4n_ProxyInit(null);
    }
}
