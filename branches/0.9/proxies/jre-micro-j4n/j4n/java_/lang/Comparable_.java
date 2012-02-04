package java_.lang;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Comparable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Comparable_
// <j4ni-Comparable_>
// put user interfaces here
// </j4ni-Comparable_>
{
    // <j4nb-Comparable_> 
    // put user members here
    // </j4nb-Comparable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang._Comparable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.Comparable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.Comparable_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.lang.Comparable.class, java_.lang.Comparable_.class, java_.lang._Comparable.class, new java_.lang.Comparable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Comparable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Comparable extends system.Object implements java.lang.Comparable
// <j4ni-Comparable>
// put user interfaces here
// </j4ni-Comparable>
{
    // <j4nb-Comparable> 
    // put user members here
    // </j4nb-Comparable>
    
    _Comparable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.Comparable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int compareTo(java.lang.Object par0);
}
