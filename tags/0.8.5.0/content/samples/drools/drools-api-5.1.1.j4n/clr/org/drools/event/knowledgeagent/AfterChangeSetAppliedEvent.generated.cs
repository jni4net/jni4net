//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event.knowledgeagent {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class AfterChangeSetAppliedEvent : global::org.drools.@event.knowledgeagent.ChangeSetProcessingEvent {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorAfterChangeSetAppliedEvent0;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/ChangeSet;)V")]
        public AfterChangeSetAppliedEvent(global::org.drools.ChangeSet par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::org.drools.@event.knowledgeagent.AfterChangeSetAppliedEvent.staticClass, global::org.drools.@event.knowledgeagent.AfterChangeSetAppliedEvent.@__ctorAfterChangeSetAppliedEvent0, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.ChangeSet>(@__env, par0));
            }
        }
        
        protected AfterChangeSetAppliedEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.knowledgeagent.AfterChangeSetAppliedEvent.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.knowledgeagent.AfterChangeSetAppliedEvent.staticClass = @__class;
            global::org.drools.@event.knowledgeagent.AfterChangeSetAppliedEvent.@__ctorAfterChangeSetAppliedEvent0 = @__env.GetMethodID(global::org.drools.@event.knowledgeagent.AfterChangeSetAppliedEvent.staticClass, "<init>", "(Lorg/drools/ChangeSet;)V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.knowledgeagent.AfterChangeSetAppliedEvent(@__env);
            }
        }
    }
    #endregion
}