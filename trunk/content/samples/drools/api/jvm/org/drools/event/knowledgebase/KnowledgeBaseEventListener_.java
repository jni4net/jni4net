// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.event.knowledgebase;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class KnowledgeBaseEventListener_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.event.knowledgebase.KnowledgeBaseEventListener_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.event.knowledgebase.KnowledgeBaseEventListener_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __KnowledgeBaseEventListener extends system.Object implements org.drools.event.knowledgebase.KnowledgeBaseEventListener {
    
    protected __KnowledgeBaseEventListener(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/BeforeKnowledgePackageAddedEvent;)V")
    public native void beforeKnowledgePackageAdded(org.drools.event.knowledgebase.BeforeKnowledgePackageAddedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/AfterKnowledgePackageAddedEvent;)V")
    public native void afterKnowledgePackageAdded(org.drools.event.knowledgebase.AfterKnowledgePackageAddedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/BeforeKnowledgePackageRemovedEvent;)V")
    public native void beforeKnowledgePackageRemoved(org.drools.event.knowledgebase.BeforeKnowledgePackageRemovedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/AfterKnowledgePackageRemovedEvent;)V")
    public native void afterKnowledgePackageRemoved(org.drools.event.knowledgebase.AfterKnowledgePackageRemovedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/BeforeKnowledgeBaseLockedEvent;)V")
    public native void beforeKnowledgeBaseLocked(org.drools.event.knowledgebase.BeforeKnowledgeBaseLockedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/AfterKnowledgeBaseLockedEvent;)V")
    public native void afterKnowledgeBaseLocked(org.drools.event.knowledgebase.AfterKnowledgeBaseLockedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/BeforeKnowledgeBaseUnlockedEvent;)V")
    public native void beforeKnowledgeBaseUnlocked(org.drools.event.knowledgebase.BeforeKnowledgeBaseUnlockedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/AfterKnowledgeBaseUnlockedEvent;)V")
    public native void afterKnowledgeBaseUnlocked(org.drools.event.knowledgebase.AfterKnowledgeBaseUnlockedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/BeforeRuleAddedEvent;)V")
    public native void beforeRuleAdded(org.drools.event.knowledgebase.BeforeRuleAddedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/AfterRuleAddedEvent;)V")
    public native void afterRuleAdded(org.drools.event.knowledgebase.AfterRuleAddedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/BeforeRuleRemovedEvent;)V")
    public native void beforeRuleRemoved(org.drools.event.knowledgebase.BeforeRuleRemovedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/AfterRuleRemovedEvent;)V")
    public native void afterRuleRemoved(org.drools.event.knowledgebase.AfterRuleRemovedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/BeforeFunctionRemovedEvent;)V")
    public native void beforeFunctionRemoved(org.drools.event.knowledgebase.BeforeFunctionRemovedEvent par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgebase/AfterFunctionRemovedEvent;)V")
    public native void afterFunctionRemoved(org.drools.event.knowledgebase.AfterFunctionRemovedEvent par0);
}
//</generated-proxy>
