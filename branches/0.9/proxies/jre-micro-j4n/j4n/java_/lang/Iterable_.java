package java_.lang;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Iterable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Iterable_
// <j4ni-Iterable_>
// put user interfaces here
// </j4ni-Iterable_>
{
    // <j4nb-Iterable_> 
    // put user members here
    // </j4nb-Iterable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang._Iterable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.Iterable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.Iterable_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.lang.Iterable.class, java_.lang.Iterable_.class, java_.lang._Iterable.class, new java_.lang.Iterable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Iterable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Iterable extends system.Object implements java.lang.Iterable
// <j4ni-Iterable>
// put user interfaces here
// </j4ni-Iterable>
{
    // <j4nb-Iterable> 
    // put user members here
    // </j4nb-Iterable>
    
    _Iterable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.Iterable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/util/Iterator; ()Ljava/util/Iterator;</signature>
    public native java.util.Iterator iterator();
}
