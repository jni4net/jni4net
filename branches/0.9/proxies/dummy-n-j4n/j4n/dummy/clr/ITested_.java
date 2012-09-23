package dummy.clr;

@net.sf.jni4net.attributes.J4NProxy(dummy.clr.ITested_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ITested_
// <j4ni-ITested_>
// put user interfaces here
// </j4ni-ITested_>
{
    // <j4nb-ITested_> 
    // put user members here
    // </j4nb-ITested_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new dummy.clr._ITested(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        dummy.clr.ITested_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.ITested_, " + net.sf.jni4net.modules.dummynj4n.proxyAssemblyName, dummy.clr.ITested.class, dummy.clr.ITested_.class, dummy.clr._ITested.class, new dummy.clr.ITested_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(dummy.clr.ITested_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ITested extends system.Object implements dummy.clr.ITested
// <j4ni-ITested>
// put user interfaces here
// </j4ni-ITested>
{
    // <j4nb-ITested> 
    // put user members here
    // </j4nb-ITested>
    
    _ITested(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        dummy.clr.ITested_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/MulticastDelegate;)V (LSystem/MulticastDelegate;)V</signature>
    public native void addPropertyChanged(system.MulticastDelegate value);
    
    /// <signature>#1 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
    public native java.lang.String getItem(int a);
    
    /// <signature>#2 ()I ()I</signature>
    public native int gettestGet();
    
    /// <signature>#3 ()I ()I</signature>
    public native int gettestGetPrivateSet();
    
    /// <signature>#4 ()I ()I</signature>
    public native int gettestGetSet();
    
    /// <signature>#5 (Lsystem/MulticastDelegate;)V (LSystem/MulticastDelegate;)V</signature>
    public native void removePropertyChanged(system.MulticastDelegate value);
    
    /// <signature>#6 (ILjava/lang/String;)V (ILjava/lang/String;)V</signature>
    public native void setItem(int a, java.lang.String value);
    
    /// <signature>#7 (JLjava/lang/String;)V (JLjava/lang/String;)V</signature>
    public native void setItem(long a, java.lang.String value);
    
    /// <signature>#8 (I)V (I)V</signature>
    public native void settestGetSet(int value);
    
    /// <signature>#9 (I)V (I)V</signature>
    public native void settestSet(int value);
    
    /// <signature>#10 (I)V (I)V</signature>
    public native void settestSetPrivateGet(int value);
    
    /// <signature>#11 (ILjava/lang/String;Lsystem/collections/IList;)I (ILjava/lang/String;LSystem/Collections/IList;)I</signature>
    public native int test1(int value, java.lang.String s, system.collections.IList l);
    
    /// <signature>#12 (ILjava/lang/String;Lsystem/collections/IList;)I (ILjava/lang/String;LSystem/Collections/IList;)I</signature>
    public native int test2(int value, java.lang.String s, system.collections.IList l);
    
    /// <signature>#13 ([I[Ljava/lang/String;[Lsystem/collections/IList;)I ([I[Ljava/lang/String;[LSystem/Collections/IList;)I</signature>
    public native int test3(int[] value, java.lang.String[] s, system.collections.IList[] l);
    
    /// <signature>#14 (Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)V</signature>
    public native void testOut(net.sf.jni4net.Out<system.Int32[]> value, net.sf.jni4net.Out<java.lang.Object[]> value2, net.sf.jni4net.Out<java.lang.String[]> srt, net.sf.jni4net.Out<system.collections.IEnumerable[]> enumerable, net.sf.jni4net.Out<system.collections.ICollection[]> array);
    
    /// <signature>#15 (Ldummy/clr/ITested;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)V</signature>
    public native void testOutCallback(dummy.clr.ITested callback, net.sf.jni4net.Out<system.Int32[]> value, net.sf.jni4net.Out<java.lang.Object[]> value2, net.sf.jni4net.Out<java.lang.String[]> srt, net.sf.jni4net.Out<system.collections.IEnumerable[]> enumerable, net.sf.jni4net.Out<system.collections.ICollection[]> array);
    
    /// <signature>#16 (Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)I (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)I</signature>
    public native int testOutint(net.sf.jni4net.Out<system.Int32> value, net.sf.jni4net.Out<java.lang.Object> value2, net.sf.jni4net.Out<java.lang.String> srt, net.sf.jni4net.Out<system.collections.IEnumerable> enumerable, net.sf.jni4net.Out<system.collections.ICollection> array);
    
    /// <signature>#17 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V</signature>
    public native void testRef(net.sf.jni4net.Ref<system.Int32[]> value, net.sf.jni4net.Ref<java.lang.Object[]> value2, net.sf.jni4net.Ref<java.lang.String[]> srt, net.sf.jni4net.Ref<system.collections.IEnumerable[]> enumerable, net.sf.jni4net.Ref<system.collections.ICollection[]> array);
    
    /// <signature>#18 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V</signature>
    public native void testRef11(net.sf.jni4net.Ref<system.Int32[][]> value, net.sf.jni4net.Ref<java.lang.Object[][]> value2, net.sf.jni4net.Ref<java.lang.String[][]> srt, net.sf.jni4net.Ref<system.collections.IEnumerable[][]> enumerable, net.sf.jni4net.Ref<system.collections.ICollection[][]> array);
    
    /// <signature>#19 (Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V</signature>
    public native void testRefCallback(dummy.clr.ITested callback, net.sf.jni4net.Ref<system.Int32[]> value, net.sf.jni4net.Ref<java.lang.Object[]> value2, net.sf.jni4net.Ref<java.lang.String[]> srt, net.sf.jni4net.Ref<system.collections.IEnumerable[]> enumerable, net.sf.jni4net.Ref<system.collections.ICollection[]> array);
    
    /// <signature>#20 (Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V</signature>
    public native void testRefCallback11(dummy.clr.ITested callback, net.sf.jni4net.Ref<system.Int32[][]> value, net.sf.jni4net.Ref<java.lang.Object[][]> value2, net.sf.jni4net.Ref<java.lang.String[][]> srt, net.sf.jni4net.Ref<system.collections.IEnumerable[][]> enumerable, net.sf.jni4net.Ref<system.collections.ICollection[][]> array);
    
    /// <signature>#21 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)I (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)I</signature>
    public native int testRefint(net.sf.jni4net.Ref<system.Int32> value, net.sf.jni4net.Ref<java.lang.Object> value2, net.sf.jni4net.Ref<java.lang.String> srt, net.sf.jni4net.Ref<system.collections.IEnumerable> enumerable, net.sf.jni4net.Ref<system.collections.ICollection> array);
}
