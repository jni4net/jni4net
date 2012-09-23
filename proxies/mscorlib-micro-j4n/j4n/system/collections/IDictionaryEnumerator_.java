package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.IDictionaryEnumerator_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IDictionaryEnumerator_
// <j4ni-IDictionaryEnumerator_>
// put user interfaces here
// </j4ni-IDictionaryEnumerator_>
{
    // <j4nb-IDictionaryEnumerator_> 
    // put user members here
    // </j4nb-IDictionaryEnumerator_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.collections._IDictionaryEnumerator(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.collections.IDictionaryEnumerator_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Collections.IDictionaryEnumerator_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.collections.IDictionaryEnumerator.class, system.collections.IDictionaryEnumerator_.class, system.collections._IDictionaryEnumerator.class, new system.collections.IDictionaryEnumerator_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.collections.IDictionaryEnumerator_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IDictionaryEnumerator extends system.Object implements system.collections.IDictionaryEnumerator
// <j4ni-IDictionaryEnumerator>
// put user interfaces here
// </j4ni-IDictionaryEnumerator>
{
    // <j4nb-IDictionaryEnumerator> 
    // put user members here
    // </j4nb-IDictionaryEnumerator>
    
    _IDictionaryEnumerator(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.collections.IDictionaryEnumerator_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getCurrent();
    
    /// <signature>#1 ()Lsystem/ValueType; ()LSystem/ValueType;</signature>
    public native system.ValueType getEntry();
    
    /// <signature>#2 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getKey();
    
    /// <signature>#3 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getValue();
    
    /// <signature>#4 ()Z ()Z</signature>
    public native boolean MoveNext();
    
    /// <signature>#5 ()V ()V</signature>
    public native void Reset();
}
