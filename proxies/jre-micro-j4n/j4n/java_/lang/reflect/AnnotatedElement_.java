package java_.lang.reflect;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.AnnotatedElement_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class AnnotatedElement_
// <j4ni-AnnotatedElement_>
// put user interfaces here
// </j4ni-AnnotatedElement_>
{
    // <j4nb-AnnotatedElement_> 
    // put user members here
    // </j4nb-AnnotatedElement_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.reflect._AnnotatedElement(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.reflect.AnnotatedElement_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.reflect.AnnotatedElement_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.lang.reflect.AnnotatedElement.class, java_.lang.reflect.AnnotatedElement_.class, java_.lang.reflect._AnnotatedElement.class, new java_.lang.reflect.AnnotatedElement_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.AnnotatedElement_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _AnnotatedElement extends system.Object implements java.lang.reflect.AnnotatedElement
// <j4ni-AnnotatedElement>
// put user interfaces here
// </j4ni-AnnotatedElement>
{
    // <j4nb-AnnotatedElement> 
    // put user members here
    // </j4nb-AnnotatedElement>
    
    _AnnotatedElement(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.reflect.AnnotatedElement_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/Class;)Ljava/lang/annotation/Annotation; (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;</signature>
    public native java.lang.annotation.Annotation getAnnotation(java.lang.Class par0);
    
    /// <signature>#1 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
    public native java.lang.annotation.Annotation[] getAnnotations();
    
    /// <signature>#2 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
    public native java.lang.annotation.Annotation[] getDeclaredAnnotations();
    
    /// <signature>#3 (Ljava/lang/Class;)Z (Ljava/lang/Class;)Z</signature>
    public native boolean isAnnotationPresent(java.lang.Class par0);
}
