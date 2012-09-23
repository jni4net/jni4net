package java_.lang.reflect;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.Member_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Member_
// <j4ni-Member_>
// put user interfaces here
// </j4ni-Member_>
{
    // <j4nb-Member_> 
    // put user members here
    // </j4nb-Member_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang.reflect._Member(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.reflect.Member_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.reflect.Member_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.lang.reflect.Member.class, java_.lang.reflect.Member_.class, java_.lang.reflect._Member.class, new java_.lang.reflect.Member_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.reflect.Member_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Member extends system.Object implements java.lang.reflect.Member
// <j4ni-Member>
// put user interfaces here
// </j4ni-Member>
{
    // <j4nb-Member> 
    // put user members here
    // </j4nb-Member>
    
    _Member(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.reflect.Member_.j4n_ProxyInit(null);
    }
    
    /// <signature>#2 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
    public native java.lang.Class getDeclaringClass();
    
    /// <signature>#3 ()I ()I</signature>
    public native int getModifiers();
    
    /// <signature>#4 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getName();
    
    /// <signature>#5 ()Z ()Z</signature>
    public native boolean isSynthetic();
}
