// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.management;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ObjectTypeNodeMonitorMBean_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.management.ObjectTypeNodeMonitorMBean_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.management.ObjectTypeNodeMonitorMBean_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ObjectTypeNodeMonitorMBean extends system.Object implements org.drools.management.ObjectTypeNodeMonitorMBean {
    
    protected __ObjectTypeNodeMonitorMBean(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getId();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getEntryPoint();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getObjectType();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getPartitionId();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isEvent();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native long getExpirationOffset();
}
//</generated-proxy>
