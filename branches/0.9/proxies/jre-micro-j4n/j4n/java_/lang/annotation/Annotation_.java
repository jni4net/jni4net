package java_.lang.annotation;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.annotation.Annotation_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Annotation_
// <j4ni-Annotation_>
// put user interfaces here
// </j4ni-Annotation_>
{
    // <j4nb-Annotation_> 
    // put user members here
    // </j4nb-Annotation_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.annotation._Annotation(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.annotation.Annotation_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.annotation.Annotation_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.lang.annotation.Annotation.class, java_.lang.annotation.Annotation_.class, java_.lang.annotation._Annotation.class, new java_.lang.annotation.Annotation_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.annotation.Annotation_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Annotation extends system.Object implements java.lang.annotation.Annotation
// <j4ni-Annotation>
// put user interfaces here
// </j4ni-Annotation>
{
    // <j4nb-Annotation> 
    // put user members here
    // </j4nb-Annotation>
    
    _Annotation(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.annotation.Annotation_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
    public native java.lang.Class annotationType();
}
