// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.collections;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ICollection_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return system.collections.ICollection_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.collections.ICollection_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ICollection extends system.Object implements system.collections.ICollection {
    
    protected __ICollection(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Collections/IEnumerator;")
    public native system.collections.IEnumerator GetEnumerator();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;I)V")
    public native void CopyTo(system.Array array, int index);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getCount();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object getSyncRoot();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSynchronized();
}
//</generated-proxy>