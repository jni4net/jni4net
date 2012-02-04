package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.IDictionary_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IDictionary_
// <j4ni-IDictionary_>
// put user interfaces here
// </j4ni-IDictionary_>
{
    // <j4nb-IDictionary_> 
    // put user members here
    // </j4nb-IDictionary_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.collections._IDictionary(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.collections.IDictionary_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Collections.IDictionary_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.collections.IDictionary.class, system.collections.IDictionary_.class, system.collections._IDictionary.class, new system.collections.IDictionary_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.collections.IDictionary_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IDictionary extends system.Object implements system.collections.IDictionary
// <j4ni-IDictionary>
// put user interfaces here
// </j4ni-IDictionary>
{
    // <j4nb-IDictionary> 
    // put user members here
    // </j4nb-IDictionary>
    
    _IDictionary(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.collections.IDictionary_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    public native void Add(java.lang.Object key, java.lang.Object value);
    
    /// <signature>#1 ()V ()V</signature>
    public native void Clear();
    
    /// <signature>#2 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean Contains(java.lang.Object key);
    
    /// <signature>#3 (Lsystem/Array;I)V (LSystem/Array;I)V</signature>
    public native void CopyTo(system.Array array, int index);
    
    /// <signature>#4 ()I ()I</signature>
    public native int getCount();
    
    /// <signature>#5 ()Lsystem/collections/IDictionaryEnumerator; ()LSystem/Collections/IDictionaryEnumerator;</signature>
    public native system.collections.IDictionaryEnumerator GetEnumerator();
    
    /// <signature>#7 ()Z ()Z</signature>
    public native boolean getIsFixedSize();
    
    /// <signature>#8 ()Z ()Z</signature>
    public native boolean getIsReadOnly();
    
    /// <signature>#9 ()Z ()Z</signature>
    public native boolean getIsSynchronized();
    
    /// <signature>#10 (Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object getItem(java.lang.Object key);
    
    /// <signature>#11 ()Lsystem/collections/ICollection; ()LSystem/Collections/ICollection;</signature>
    public native system.collections.ICollection getKeys();
    
    /// <signature>#12 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getSyncRoot();
    
    /// <signature>#13 ()Lsystem/collections/ICollection; ()LSystem/Collections/ICollection;</signature>
    public native system.collections.ICollection getValues();
    
    /// <signature>#14 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    public native void Remove(java.lang.Object key);
    
    /// <signature>#15 (Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    public native void setItem(java.lang.Object key, java.lang.Object value);
}
