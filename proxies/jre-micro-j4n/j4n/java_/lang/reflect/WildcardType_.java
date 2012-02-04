package java_.lang.reflect;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.WildcardType_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class WildcardType_
// <j4ni-WildcardType_>
// put user interfaces here
// </j4ni-WildcardType_>
{
    // <j4nb-WildcardType_> 
    // put user members here
    // </j4nb-WildcardType_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.reflect._WildcardType(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.reflect.WildcardType_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.reflect.WildcardType_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.lang.reflect.WildcardType.class, java_.lang.reflect.WildcardType_.class, java_.lang.reflect._WildcardType.class, new java_.lang.reflect.WildcardType_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.WildcardType_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _WildcardType extends system.Object implements java.lang.reflect.WildcardType
// <j4ni-WildcardType>
// put user interfaces here
// </j4ni-WildcardType>
{
    // <j4nb-WildcardType> 
    // put user members here
    // </j4nb-WildcardType>
    
    _WildcardType(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.reflect.WildcardType_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
    public native java.lang.reflect.Type[] getLowerBounds();
    
    /// <signature>#1 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
    public native java.lang.reflect.Type[] getUpperBounds();
}
