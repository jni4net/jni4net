package java_.lang.reflect;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.ParameterizedType_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ParameterizedType_
// <j4ni-ParameterizedType_>
// put user interfaces here
// </j4ni-ParameterizedType_>
{
    // <j4nb-ParameterizedType_> 
    // put user members here
    // </j4nb-ParameterizedType_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.reflect._ParameterizedType(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.reflect.ParameterizedType_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.reflect.ParameterizedType_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.lang.reflect.ParameterizedType.class, java_.lang.reflect.ParameterizedType_.class, java_.lang.reflect._ParameterizedType.class, new java_.lang.reflect.ParameterizedType_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.ParameterizedType_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ParameterizedType extends system.Object implements java.lang.reflect.ParameterizedType
// <j4ni-ParameterizedType>
// put user interfaces here
// </j4ni-ParameterizedType>
{
    // <j4nb-ParameterizedType> 
    // put user members here
    // </j4nb-ParameterizedType>
    
    _ParameterizedType(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.reflect.ParameterizedType_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
    public native java.lang.reflect.Type[] getActualTypeArguments();
    
    /// <signature>#1 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
    public native java.lang.reflect.Type getOwnerType();
    
    /// <signature>#2 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
    public native java.lang.reflect.Type getRawType();
}
