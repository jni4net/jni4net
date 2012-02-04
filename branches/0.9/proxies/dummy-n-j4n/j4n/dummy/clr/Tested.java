// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package dummy.clr;

@net.sf.jni4net.attributes.J4NProxy(dummy.clr.Tested.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Tested extends system.Object implements dummy.clr.ITested
// <j4ni-Tested>
// put user interfaces here
// </j4ni-Tested>
{
    // <j4nb-Tested> 
    // put user members here
    // </j4nb-Tested>
    
    protected Tested(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new dummy.clr.Tested(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        dummy.clr.Tested.j4n_ProxyInit(null);
    }
    
    public Tested() {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor();
    }
    
    /// <signature>#0 ()V ()V</signature>
    private native long j4n_constructor();
    
    /// <signature>#1 ()I ()I</signature>
    static public native int intStaticField();
    
    /// <signature>#2 (I)V (I)V</signature>
    static public native void intStaticField(int value);
    
    /// <signature>#3 ()I ()I</signature>
    static public native int intStaticFieldRo();
    
    /// <signature>#4 (Lsystem/MulticastDelegate;)V (LSystem/MulticastDelegate;)V</signature>
    public native void addPropertyChanged(system.MulticastDelegate value);
    
    /// <signature>#5 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
    public native java.lang.String getItem(int a);
    
    /// <signature>#6 ()I ()I</signature>
    public native int gettestGet();
    
    /// <signature>#7 ()I ()I</signature>
    public native int gettestGetPrivateSet();
    
    /// <signature>#8 ()I ()I</signature>
    public native int gettestGetSet();
    
    /// <signature>#9 ()I ()I</signature>
    public final native int intField();
    
    /// <signature>#10 (I)V (I)V</signature>
    public final native void intField(int value);
    
    /// <signature>#11 ()I ()I</signature>
    public final native int intFieldRO();
    
    /// <signature>#12 (Lsystem/MulticastDelegate;)V (LSystem/MulticastDelegate;)V</signature>
    public native void removePropertyChanged(system.MulticastDelegate value);
    
    /// <signature>#13 (ILjava/lang/String;)V (ILjava/lang/String;)V</signature>
    public native void setItem(int a, java.lang.String value);
    
    /// <signature>#14 (JLjava/lang/String;)V (JLjava/lang/String;)V</signature>
    public native void setItem(long a, java.lang.String value);
    
    /// <signature>#15 (I)V (I)V</signature>
    public native void settestGetSet(int value);
    
    /// <signature>#16 (I)V (I)V</signature>
    public native void settestSet(int value);
    
    /// <signature>#17 (I)V (I)V</signature>
    public native void settestSetPrivateGet(int value);
    
    /// <signature>#18 (ILjava/lang/String;Lsystem/collections/IList;)I (ILjava/lang/String;LSystem/Collections/IList;)I</signature>
    public native int test1(int value, java.lang.String s, system.collections.IList l);
    
    /// <signature>#19 (ILjava/lang/String;Lsystem/collections/IList;)I (ILjava/lang/String;LSystem/Collections/IList;)I</signature>
    public native int test2(int value, java.lang.String s, system.collections.IList l);
    
    /// <signature>#20 ([I[Ljava/lang/String;[Lsystem/collections/IList;)I ([I[Ljava/lang/String;[LSystem/Collections/IList;)I</signature>
    public native int test3(int[] value, java.lang.String[] s, system.collections.IList[] l);
    
    /// <signature>#21 (Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)V</signature>
    public native void testOut(net.sf.jni4net.Out<system.Int32[]> value, net.sf.jni4net.Out<java.lang.Object[]> value2, net.sf.jni4net.Out<java.lang.String[]> srt, net.sf.jni4net.Out<system.collections.IEnumerable[]> enumerable, net.sf.jni4net.Out<system.collections.ICollection[]> array);
    
    /// <signature>#22 (Ldummy/clr/ITested;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)V</signature>
    public native void testOutCallback(dummy.clr.ITested callback, net.sf.jni4net.Out<system.Int32[]> value, net.sf.jni4net.Out<java.lang.Object[]> value2, net.sf.jni4net.Out<java.lang.String[]> srt, net.sf.jni4net.Out<system.collections.IEnumerable[]> enumerable, net.sf.jni4net.Out<system.collections.ICollection[]> array);
    
    /// <signature>#23 (Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)I (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)I</signature>
    public native int testOutint(net.sf.jni4net.Out<system.Int32> value, net.sf.jni4net.Out<java.lang.Object> value2, net.sf.jni4net.Out<java.lang.String> srt, net.sf.jni4net.Out<system.collections.IEnumerable> enumerable, net.sf.jni4net.Out<system.collections.ICollection> array);
    
    /// <signature>#24 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V</signature>
    public native void testRef(net.sf.jni4net.Ref<system.Int32[]> value, net.sf.jni4net.Ref<java.lang.Object[]> value2, net.sf.jni4net.Ref<java.lang.String[]> srt, net.sf.jni4net.Ref<system.collections.IEnumerable[]> enumerable, net.sf.jni4net.Ref<system.collections.ICollection[]> array);
    
    /// <signature>#25 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V</signature>
    public native void testRef11(net.sf.jni4net.Ref<system.Int32[][]> value, net.sf.jni4net.Ref<java.lang.Object[][]> value2, net.sf.jni4net.Ref<java.lang.String[][]> srt, net.sf.jni4net.Ref<system.collections.IEnumerable[][]> enumerable, net.sf.jni4net.Ref<system.collections.ICollection[][]> array);
    
    /// <signature>#26 (Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V</signature>
    public native void testRefCallback(dummy.clr.ITested callback, net.sf.jni4net.Ref<system.Int32[]> value, net.sf.jni4net.Ref<java.lang.Object[]> value2, net.sf.jni4net.Ref<java.lang.String[]> srt, net.sf.jni4net.Ref<system.collections.IEnumerable[]> enumerable, net.sf.jni4net.Ref<system.collections.ICollection[]> array);
    
    /// <signature>#27 (Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V</signature>
    public native void testRefCallback11(dummy.clr.ITested callback, net.sf.jni4net.Ref<system.Int32[][]> value, net.sf.jni4net.Ref<java.lang.Object[][]> value2, net.sf.jni4net.Ref<java.lang.String[][]> srt, net.sf.jni4net.Ref<system.collections.IEnumerable[][]> enumerable, net.sf.jni4net.Ref<system.collections.ICollection[][]> array);
    
    /// <signature>#28 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)I (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)I</signature>
    public native int testRefint(net.sf.jni4net.Ref<system.Int32> value, net.sf.jni4net.Ref<java.lang.Object> value2, net.sf.jni4net.Ref<java.lang.String> srt, net.sf.jni4net.Ref<system.collections.IEnumerable> enumerable, net.sf.jni4net.Ref<system.collections.ICollection> array);
    
    /// <signature>#29 ()V ()V</signature>
    public native void testSkip();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.Tested_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.Tested.class, dummy.clr.Tested.class, dummy.clr.Tested.class, new dummy.clr.Tested.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
