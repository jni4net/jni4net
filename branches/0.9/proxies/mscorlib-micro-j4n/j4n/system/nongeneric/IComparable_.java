package system.nongeneric;

@net.sf.jni4net.attributes.J4NProxy(system.nongeneric.IComparable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IComparable_
// <j4ni-IComparable_>
// put user interfaces here
// </j4ni-IComparable_>
{
    // <j4nb-IComparable_> 
    // put user members here
    // </j4nb-IComparable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.nongeneric._IComparable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.nongeneric.IComparable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IComparable_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.nongeneric.IComparable.class, system.nongeneric.IComparable_.class, system.nongeneric._IComparable.class, new system.nongeneric.IComparable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.nongeneric.IComparable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IComparable extends system.Object implements system.nongeneric.IComparable
// <j4ni-IComparable>
// put user interfaces here
// </j4ni-IComparable>
{
    // <j4nb-IComparable> 
    // put user members here
    // </j4nb-IComparable>
    
    _IComparable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.nongeneric.IComparable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object obj);
}
