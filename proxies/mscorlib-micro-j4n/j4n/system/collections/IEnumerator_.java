package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.IEnumerator_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IEnumerator_
// <j4ni-IEnumerator_>
// put user interfaces here
// </j4ni-IEnumerator_>
{
    // <j4nb-IEnumerator_> 
    // put user members here
    // </j4nb-IEnumerator_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.collections._IEnumerator(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.collections.IEnumerator_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Collections.IEnumerator_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.collections.IEnumerator.class, system.collections.IEnumerator_.class, system.collections._IEnumerator.class, new system.collections.IEnumerator_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.collections.IEnumerator_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IEnumerator extends system.Object implements system.collections.IEnumerator
// <j4ni-IEnumerator>
// put user interfaces here
// </j4ni-IEnumerator>
{
    // <j4nb-IEnumerator> 
    // put user members here
    // </j4nb-IEnumerator>
    
    _IEnumerator(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.collections.IEnumerator_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getCurrent();
    
    /// <signature>#1 ()Z ()Z</signature>
    public native boolean MoveNext();
    
    /// <signature>#2 ()V ()V</signature>
    public native void Reset();
}
