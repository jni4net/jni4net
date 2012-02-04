package java_.util;

@net.sf.jni4net.attributes.J4NProxy(java_.util.Enumeration_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Enumeration_
// <j4ni-Enumeration_>
// put user interfaces here
// </j4ni-Enumeration_>
{
    // <j4nb-Enumeration_> 
    // put user members here
    // </j4nb-Enumeration_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.util._Enumeration(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.util.Enumeration_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.util.Enumeration_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.util.Enumeration.class, java_.util.Enumeration_.class, java_.util._Enumeration.class, new java_.util.Enumeration_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.util.Enumeration_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Enumeration extends system.Object implements java.util.Enumeration
// <j4ni-Enumeration>
// put user interfaces here
// </j4ni-Enumeration>
{
    // <j4nb-Enumeration> 
    // put user members here
    // </j4nb-Enumeration>
    
    _Enumeration(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.util.Enumeration_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Z ()Z</signature>
    public native boolean hasMoreElements();
    
    /// <signature>#1 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object nextElement();
}
