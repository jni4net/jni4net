// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package java_.util;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class List_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.util.List_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.util.List_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __List extends system.Object implements java.util.List {
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Iterator;")
    public native java.util.Iterator iterator();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int hashCode();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean add(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void clear();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean equals(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean contains(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Collection;)Z")
    public native boolean addAll(java.util.Collection par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int size();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Ljava/lang/Object;")
    public native java.lang.Object[] toArray();
    
    @net.sf.jni4net.attributes.ClrMethod("([Ljava/lang/Object;)[Ljava/lang/Object;")
    public native java.lang.Object[] toArray(java.lang.Object[] par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Z")
    public native boolean remove(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isEmpty();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Collection;)Z")
    public native boolean containsAll(java.util.Collection par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Collection;)Z")
    public native boolean removeAll(java.util.Collection par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/util/Collection;)Z")
    public native boolean retainAll(java.util.Collection par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILjava/lang/Object;)V")
    public native void add(int par0, java.lang.Object par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)I")
    public native int indexOf(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)I")
    public native int lastIndexOf(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILjava/util/Collection;)Z")
    public native boolean addAll(int par0, java.util.Collection par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)Ljava/lang/Object;")
    public native java.lang.Object get(int par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)Ljava/lang/Object;")
    public native java.lang.Object remove(int par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILjava/lang/Object;)Ljava/lang/Object;")
    public native java.lang.Object set(int par0, java.lang.Object par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(II)Ljava/util/List;")
    public native java.util.List subList(int par0, int par1);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Iterator;")
    public native java.util.ListIterator listIterator();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)Ljava/util/Iterator;")
    public native java.util.ListIterator listIterator(int par0);
}
//</generated-proxy>
