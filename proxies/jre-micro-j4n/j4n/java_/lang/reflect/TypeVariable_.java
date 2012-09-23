package java_.lang.reflect;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.TypeVariable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class TypeVariable_
// <j4ni-TypeVariable_>
// put user interfaces here
// </j4ni-TypeVariable_>
{
    // <j4nb-TypeVariable_> 
    // put user members here
    // </j4nb-TypeVariable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.reflect._TypeVariable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.reflect.TypeVariable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.reflect.TypeVariable_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.lang.reflect.TypeVariable.class, java_.lang.reflect.TypeVariable_.class, java_.lang.reflect._TypeVariable.class, new java_.lang.reflect.TypeVariable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.TypeVariable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _TypeVariable extends system.Object implements java.lang.reflect.TypeVariable
// <j4ni-TypeVariable>
// put user interfaces here
// </j4ni-TypeVariable>
{
    // <j4nb-TypeVariable> 
    // put user members here
    // </j4nb-TypeVariable>
    
    _TypeVariable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.reflect.TypeVariable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
    public native java.lang.reflect.Type[] getBounds();
    
    /// <signature>#1 ()Ljava/lang/reflect/GenericDeclaration; ()Ljava/lang/reflect/GenericDeclaration;</signature>
    public native java.lang.reflect.GenericDeclaration getGenericDeclaration();
    
    /// <signature>#2 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getName();
}
