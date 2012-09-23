package java_.lang.reflect;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.GenericArrayType_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class GenericArrayType_
// <j4ni-GenericArrayType_>
// put user interfaces here
// </j4ni-GenericArrayType_>
{
    // <j4nb-GenericArrayType_> 
    // put user members here
    // </j4nb-GenericArrayType_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.reflect._GenericArrayType(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.reflect.GenericArrayType_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.reflect.GenericArrayType_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.lang.reflect.GenericArrayType.class, java_.lang.reflect.GenericArrayType_.class, java_.lang.reflect._GenericArrayType.class, new java_.lang.reflect.GenericArrayType_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.GenericArrayType_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _GenericArrayType extends system.Object implements java.lang.reflect.GenericArrayType
// <j4ni-GenericArrayType>
// put user interfaces here
// </j4ni-GenericArrayType>
{
    // <j4nb-GenericArrayType> 
    // put user members here
    // </j4nb-GenericArrayType>
    
    _GenericArrayType(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.reflect.GenericArrayType_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
    public native java.lang.reflect.Type getGenericComponentType();
}
