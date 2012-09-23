package java_.util;

@net.sf.jni4net.attributes.J4NProxy(java_.util.Set_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Set_
// <j4ni-Set_>
// put user interfaces here
// </j4ni-Set_>
{
    // <j4nb-Set_> 
    // put user members here
    // </j4nb-Set_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.util._Set(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.util.Set_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.util.Set_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.util.Set.class, java_.util.Set_.class, java_.util._Set.class, new java_.util.Set_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.util.Set_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Set extends system.Object implements java.util.Set
// <j4ni-Set>
// put user interfaces here
// </j4ni-Set>
{
    // <j4nb-Set> 
    // put user members here
    // </j4nb-Set>
    
    _Set(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.util.Set_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean add(java.lang.Object par0);
    
    /// <signature>#1 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
    public native boolean addAll(java.util.Collection par0);
    
    /// <signature>#2 ()V ()V</signature>
    public native void clear();
    
    /// <signature>#3 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean contains(java.lang.Object par0);
    
    /// <signature>#4 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
    public native boolean containsAll(java.util.Collection par0);
    
    /// <signature>#5 ()Z ()Z</signature>
    public native boolean isEmpty();
    
    /// <signature>#6 ()Ljava/util/Iterator; ()Ljava/util/Iterator;</signature>
    public native java.util.Iterator iterator();
    
    /// <signature>#7 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean remove(java.lang.Object par0);
    
    /// <signature>#8 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
    public native boolean removeAll(java.util.Collection par0);
    
    /// <signature>#9 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
    public native boolean retainAll(java.util.Collection par0);
    
    /// <signature>#10 ()I ()I</signature>
    public native int size();
    
    /// <signature>#11 ()[Ljava/lang/Object; ()[Ljava/lang/Object;</signature>
    public native java.lang.Object[] toArray();
    
    /// <signature>#12 ([Ljava/lang/Object;)[Ljava/lang/Object; ([Ljava/lang/Object;)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] toArray(java.lang.Object[] par0);
}
