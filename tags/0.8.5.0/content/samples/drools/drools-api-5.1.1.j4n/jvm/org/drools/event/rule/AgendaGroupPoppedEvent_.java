// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.event.rule;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class AgendaGroupPoppedEvent_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.event.rule.AgendaGroupPoppedEvent_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.event.rule.AgendaGroupPoppedEvent_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __AgendaGroupPoppedEvent extends system.Object implements org.drools.event.rule.AgendaGroupPoppedEvent {
    
    protected __AgendaGroupPoppedEvent(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/runtime/KnowledgeRuntime;")
    public native org.drools.runtime.KnowledgeRuntime getKnowledgeRuntime();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/runtime/rule/AgendaGroup;")
    public native org.drools.runtime.rule.AgendaGroup getAgendaGroup();
}
//</generated-proxy>
