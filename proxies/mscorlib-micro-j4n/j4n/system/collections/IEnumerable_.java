package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.IEnumerable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IEnumerable_
// <j4ni-IEnumerable_>
// put user interfaces here
// </j4ni-IEnumerable_>
{
    // <j4nb-IEnumerable_> 
    // put user members here
    // </j4nb-IEnumerable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.collections._IEnumerable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.collections.IEnumerable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Collections.IEnumerable_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.collections.IEnumerable.class, system.collections.IEnumerable_.class, system.collections._IEnumerable.class, new system.collections.IEnumerable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.collections.IEnumerable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IEnumerable extends system.Object implements system.collections.IEnumerable
// <j4ni-IEnumerable>
// put user interfaces here
// </j4ni-IEnumerable>
{
    // <j4nb-IEnumerable> 
    // put user members here
    // </j4nb-IEnumerable>
    
    _IEnumerable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.collections.IEnumerable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
    public native system.collections.IEnumerator GetEnumerator();
}
