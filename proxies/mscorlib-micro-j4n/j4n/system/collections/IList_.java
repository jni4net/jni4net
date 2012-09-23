package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.IList_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IList_
// <j4ni-IList_>
// put user interfaces here
// </j4ni-IList_>
{
    // <j4nb-IList_> 
    // put user members here
    // </j4nb-IList_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.collections._IList(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.collections.IList_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Collections.IList_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.collections.IList.class, system.collections.IList_.class, system.collections._IList.class, new system.collections.IList_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.collections.IList_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IList extends system.Object implements system.collections.IList
// <j4ni-IList>
// put user interfaces here
// </j4ni-IList>
{
    // <j4nb-IList> 
    // put user members here
    // </j4nb-IList>
    
    _IList(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.collections.IList_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int Add(java.lang.Object value);
    
    /// <signature>#1 ()V ()V</signature>
    public native void Clear();
    
    /// <signature>#2 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean Contains(java.lang.Object value);
    
    /// <signature>#3 (Lsystem/Array;I)V (LSystem/Array;I)V</signature>
    public native void CopyTo(system.Array array, int index);
    
    /// <signature>#4 ()I ()I</signature>
    public native int getCount();
    
    /// <signature>#5 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
    public native system.collections.IEnumerator GetEnumerator();
    
    /// <signature>#6 ()Z ()Z</signature>
    public native boolean getIsFixedSize();
    
    /// <signature>#7 ()Z ()Z</signature>
    public native boolean getIsReadOnly();
    
    /// <signature>#8 ()Z ()Z</signature>
    public native boolean getIsSynchronized();
    
    /// <signature>#9 (I)Ljava/lang/Object; (I)Ljava/lang/Object;</signature>
    public native java.lang.Object getItem(int index);
    
    /// <signature>#10 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getSyncRoot();
    
    /// <signature>#11 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int IndexOf(java.lang.Object value);
    
    /// <signature>#12 (ILjava/lang/Object;)V (ILjava/lang/Object;)V</signature>
    public native void Insert(int index, java.lang.Object value);
    
    /// <signature>#13 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    public native void Remove(java.lang.Object value);
    
    /// <signature>#14 (I)V (I)V</signature>
    public native void RemoveAt(int index);
    
    /// <signature>#15 (ILjava/lang/Object;)V (ILjava/lang/Object;)V</signature>
    public native void setItem(int index, java.lang.Object value);
}
