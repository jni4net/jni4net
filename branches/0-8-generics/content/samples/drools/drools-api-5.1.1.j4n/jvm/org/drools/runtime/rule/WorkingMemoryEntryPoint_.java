// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.runtime.rule;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class WorkingMemoryEntryPoint_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.runtime.rule.WorkingMemoryEntryPoint_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.runtime.rule.WorkingMemoryEntryPoint_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __WorkingMemoryEntryPoint extends system.Object implements org.drools.runtime.rule.WorkingMemoryEntryPoint {
    
    protected __WorkingMemoryEntryPoint(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/runtime/rule/FactHandle;)Ljava/lang/Object;")
    public native java.lang.Object getObject(org.drools.runtime.rule.FactHandle par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;")
    public native org.drools.runtime.rule.FactHandle insert(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/runtime/rule/FactHandle;Ljava/lang/Object;)V")
    public native void update(org.drools.runtime.rule.FactHandle par0, java.lang.Object par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;")
    public native org.drools.runtime.rule.FactHandle getFactHandle(java.lang.Object par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getEntryPointId();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/runtime/rule/FactHandle;)V")
    public native void retract(org.drools.runtime.rule.FactHandle par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;")
    public native java.util.Collection getObjects(org.drools.runtime.ObjectFilter par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Collection;")
    public native java.util.Collection getObjects();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;")
    public native java.util.Collection getFactHandles(org.drools.runtime.ObjectFilter par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/Collection;")
    public native java.util.Collection getFactHandles();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native long getFactCount();
}
//</generated-proxy>
