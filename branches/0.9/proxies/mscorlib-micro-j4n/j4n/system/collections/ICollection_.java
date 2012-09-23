package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.ICollection_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ICollection_
// <j4ni-ICollection_>
// put user interfaces here
// </j4ni-ICollection_>
{
    // <j4nb-ICollection_> 
    // put user members here
    // </j4nb-ICollection_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.collections._ICollection(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.collections.ICollection_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Collections.ICollection_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.collections.ICollection.class, system.collections.ICollection_.class, system.collections._ICollection.class, new system.collections.ICollection_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.collections.ICollection_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ICollection extends system.Object implements system.collections.ICollection
// <j4ni-ICollection>
// put user interfaces here
// </j4ni-ICollection>
{
    // <j4nb-ICollection> 
    // put user members here
    // </j4nb-ICollection>
    
    _ICollection(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.collections.ICollection_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/Array;I)V (LSystem/Array;I)V</signature>
    public native void CopyTo(system.Array array, int index);
    
    /// <signature>#1 ()I ()I</signature>
    public native int getCount();
    
    /// <signature>#2 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
    public native system.collections.IEnumerator GetEnumerator();
    
    /// <signature>#3 ()Z ()Z</signature>
    public native boolean getIsSynchronized();
    
    /// <signature>#4 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getSyncRoot();
}
