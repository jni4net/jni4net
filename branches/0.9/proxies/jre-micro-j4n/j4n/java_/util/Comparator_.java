package java_.util;

@net.sf.jni4net.attributes.J4NProxy(java_.util.Comparator_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Comparator_
// <j4ni-Comparator_>
// put user interfaces here
// </j4ni-Comparator_>
{
    // <j4nb-Comparator_> 
    // put user members here
    // </j4nb-Comparator_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.util._Comparator(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.util.Comparator_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.util.Comparator_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.util.Comparator.class, java_.util.Comparator_.class, java_.util._Comparator.class, new java_.util.Comparator_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.util.Comparator_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Comparator extends system.Object implements java.util.Comparator
// <j4ni-Comparator>
// put user interfaces here
// </j4ni-Comparator>
{
    // <j4nb-Comparator> 
    // put user members here
    // </j4nb-Comparator>
    
    _Comparator(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.util.Comparator_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/Object;Ljava/lang/Object;)I (Ljava/lang/Object;Ljava/lang/Object;)I</signature>
    public native int compare(java.lang.Object par0, java.lang.Object par1);
}
