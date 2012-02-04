package java_.lang.reflect;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.GenericDeclaration_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class GenericDeclaration_
// <j4ni-GenericDeclaration_>
// put user interfaces here
// </j4ni-GenericDeclaration_>
{
    // <j4nb-GenericDeclaration_> 
    // put user members here
    // </j4nb-GenericDeclaration_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.reflect._GenericDeclaration(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.reflect.GenericDeclaration_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.reflect.GenericDeclaration_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.lang.reflect.GenericDeclaration.class, java_.lang.reflect.GenericDeclaration_.class, java_.lang.reflect._GenericDeclaration.class, new java_.lang.reflect.GenericDeclaration_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.GenericDeclaration_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _GenericDeclaration extends system.Object implements java.lang.reflect.GenericDeclaration
// <j4ni-GenericDeclaration>
// put user interfaces here
// </j4ni-GenericDeclaration>
{
    // <j4nb-GenericDeclaration> 
    // put user members here
    // </j4nb-GenericDeclaration>
    
    _GenericDeclaration(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.reflect.GenericDeclaration_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()[Ljava/lang/reflect/TypeVariable; ()[Ljava/lang/reflect/TypeVariable;</signature>
    public native java.lang.reflect.TypeVariable[] getTypeParameters();
}
