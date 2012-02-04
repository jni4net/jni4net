package java_.util;

@net.sf.jni4net.attributes.J4NProxy(java_.util.Map_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Map_
// <j4ni-Map_>
// put user interfaces here
// </j4ni-Map_>
{
    // <j4nb-Map_> 
    // put user members here
    // </j4nb-Map_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.util._Map(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.util.Map_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.util.Map_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.util.Map.class, java_.util.Map_.class, java_.util._Map.class, new java_.util.Map_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
    
    @net.sf.jni4net.attributes.J4NProxy(java_.util.Map_.Entry_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public class Entry_
    // <j4ni-Entry_>
    // put user interfaces here
    // </j4ni-Entry_>
    {
        // <j4nb-Entry_> 
        // put user members here
        // </j4nb-Entry_>
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new java_.util.Map_._Entry(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static  {
            java_.util.Map_.Entry_.j4n_ProxyInit(null);
        }
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.util.MapNest.Entry_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.util.Map.Entry.class, java_.util.Map_.Entry_.class, java_.util.Map_._Entry.class, new java_.util.Map_.Entry_.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
    
    @net.sf.jni4net.attributes.J4NProxy(java_.util.Map_.Entry_.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static class _Entry extends system.Object implements java.util.Map.Entry
    // <j4ni-Entry>
    // put user interfaces here
    // </j4ni-Entry>
    {
        // <j4nb-Entry> 
        // put user members here
        // </j4nb-Entry>
        
        _Entry(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static  {
            java_.util.Map_.Entry_.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
        public native java.lang.Object getKey();
        
        /// <signature>#1 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
        public native java.lang.Object getValue();
        
        /// <signature>#2 (Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;)Ljava/lang/Object;</signature>
        public native java.lang.Object setValue(java.lang.Object par0);
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.util.Map_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Map extends system.Object implements java.util.Map
// <j4ni-Map>
// put user interfaces here
// </j4ni-Map>
{
    // <j4nb-Map> 
    // put user members here
    // </j4nb-Map>
    
    _Map(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.util.Map_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()V ()V</signature>
    public native void clear();
    
    /// <signature>#1 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean containsKey(java.lang.Object par0);
    
    /// <signature>#2 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean containsValue(java.lang.Object par0);
    
    /// <signature>#3 ()Ljava/util/Set; ()Ljava/util/Set;</signature>
    public native java.util.Set entrySet();
    
    /// <signature>#4 (Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object get(java.lang.Object par0);
    
    /// <signature>#5 ()Z ()Z</signature>
    public native boolean isEmpty();
    
    /// <signature>#6 ()Ljava/util/Set; ()Ljava/util/Set;</signature>
    public native java.util.Set keySet();
    
    /// <signature>#7 (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object put(java.lang.Object par0, java.lang.Object par1);
    
    /// <signature>#8 (Ljava/util/Map;)V (Ljava/util/Map;)V</signature>
    public native void putAll(java.util.Map par0);
    
    /// <signature>#9 (Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object remove(java.lang.Object par0);
    
    /// <signature>#10 ()I ()I</signature>
    public native int size();
    
    /// <signature>#11 ()Ljava/util/Collection; ()Ljava/util/Collection;</signature>
    public native java.util.Collection values();
}
