// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class IAsyncResult_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return system.IAsyncResult_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.IAsyncResult_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __IAsyncResult extends system.Object implements system.IAsyncResult {
    
    protected __IAsyncResult(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isCompleted();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Threading/WaitHandle;")
    public native system.MarshalByRefObject getAsyncWaitHandle();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object getAsyncState();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getCompletedSynchronously();
}
//</generated-proxy>
