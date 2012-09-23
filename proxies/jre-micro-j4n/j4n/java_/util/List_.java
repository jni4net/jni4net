package java_.util;

@net.sf.jni4net.attributes.J4NProxy(java_.util.List_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class List_
// <j4ni-List_>
// put user interfaces here
// </j4ni-List_>
{
    // <j4nb-List_> 
    // put user members here
    // </j4nb-List_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.util._List(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.util.List_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.util.List_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.util.List.class, java_.util.List_.class, java_.util._List.class, new java_.util.List_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.util.List_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _List extends system.Object implements java.util.List
// <j4ni-List>
// put user interfaces here
// </j4ni-List>
{
    // <j4nb-List> 
    // put user members here
    // </j4nb-List>
    
    _List(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.util.List_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (ILjava/lang/Object;)V (ILjava/lang/Object;)V</signature>
    public native void add(int par0, java.lang.Object par1);
    
    /// <signature>#1 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean add(java.lang.Object par0);
    
    /// <signature>#2 (ILjava/util/Collection;)Z (ILjava/util/Collection;)Z</signature>
    public native boolean addAll(int par0, java.util.Collection par1);
    
    /// <signature>#3 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
    public native boolean addAll(java.util.Collection par0);
    
    /// <signature>#4 ()V ()V</signature>
    public native void clear();
    
    /// <signature>#5 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean contains(java.lang.Object par0);
    
    /// <signature>#6 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
    public native boolean containsAll(java.util.Collection par0);
    
    /// <signature>#7 (I)Ljava/lang/Object; (I)Ljava/lang/Object;</signature>
    public native java.lang.Object get(int par0);
    
    /// <signature>#8 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int indexOf(java.lang.Object par0);
    
    /// <signature>#9 ()Z ()Z</signature>
    public native boolean isEmpty();
    
    /// <signature>#10 ()Ljava/util/Iterator; ()Ljava/util/Iterator;</signature>
    public native java.util.Iterator iterator();
    
    /// <signature>#11 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int lastIndexOf(java.lang.Object par0);
    
    /// <signature>#12 ()Ljava/util/ListIterator; ()Ljava/util/ListIterator;</signature>
    public native java.util.ListIterator listIterator();
    
    /// <signature>#13 (I)Ljava/util/ListIterator; (I)Ljava/util/ListIterator;</signature>
    public native java.util.ListIterator listIterator(int par0);
    
    /// <signature>#14 (I)Ljava/lang/Object; (I)Ljava/lang/Object;</signature>
    public native java.lang.Object remove(int par0);
    
    /// <signature>#15 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean remove(java.lang.Object par0);
    
    /// <signature>#16 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
    public native boolean removeAll(java.util.Collection par0);
    
    /// <signature>#17 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
    public native boolean retainAll(java.util.Collection par0);
    
    /// <signature>#18 (ILjava/lang/Object;)Ljava/lang/Object; (ILjava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object set(int par0, java.lang.Object par1);
    
    /// <signature>#19 ()I ()I</signature>
    public native int size();
    
    /// <signature>#20 (II)Ljava/util/List; (II)Ljava/util/List;</signature>
    public native java.util.List subList(int par0, int par1);
    
    /// <signature>#21 ()[Ljava/lang/Object; ()[Ljava/lang/Object;</signature>
    public native java.lang.Object[] toArray();
    
    /// <signature>#22 ([Ljava/lang/Object;)[Ljava/lang/Object; ([Ljava/lang/Object;)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] toArray(java.lang.Object[] par0);
}
