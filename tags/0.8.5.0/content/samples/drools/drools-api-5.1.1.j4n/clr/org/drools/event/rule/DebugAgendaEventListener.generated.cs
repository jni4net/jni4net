//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event.rule {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class DebugAgendaEventListener : global::java.lang.Object, global::org.drools.@event.rule.AgendaEventListener {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _activationCreated0;
        
        internal static global::net.sf.jni4net.jni.MethodId _activationCancelled1;
        
        internal static global::net.sf.jni4net.jni.MethodId _beforeActivationFired2;
        
        internal static global::net.sf.jni4net.jni.MethodId _afterActivationFired3;
        
        internal static global::net.sf.jni4net.jni.MethodId _agendaGroupPopped4;
        
        internal static global::net.sf.jni4net.jni.MethodId _agendaGroupPushed5;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorDebugAgendaEventListener6;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public DebugAgendaEventListener() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::org.drools.@event.rule.DebugAgendaEventListener.staticClass, global::org.drools.@event.rule.DebugAgendaEventListener.@__ctorDebugAgendaEventListener6, this);
            }
        }
        
        protected DebugAgendaEventListener(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.rule.DebugAgendaEventListener.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.rule.DebugAgendaEventListener.staticClass = @__class;
            global::org.drools.@event.rule.DebugAgendaEventListener._activationCreated0 = @__env.GetMethodID(global::org.drools.@event.rule.DebugAgendaEventListener.staticClass, "activationCreated", "(Lorg/drools/event/rule/ActivationCreatedEvent;)V");
            global::org.drools.@event.rule.DebugAgendaEventListener._activationCancelled1 = @__env.GetMethodID(global::org.drools.@event.rule.DebugAgendaEventListener.staticClass, "activationCancelled", "(Lorg/drools/event/rule/ActivationCancelledEvent;)V");
            global::org.drools.@event.rule.DebugAgendaEventListener._beforeActivationFired2 = @__env.GetMethodID(global::org.drools.@event.rule.DebugAgendaEventListener.staticClass, "beforeActivationFired", "(Lorg/drools/event/rule/BeforeActivationFiredEvent;)V");
            global::org.drools.@event.rule.DebugAgendaEventListener._afterActivationFired3 = @__env.GetMethodID(global::org.drools.@event.rule.DebugAgendaEventListener.staticClass, "afterActivationFired", "(Lorg/drools/event/rule/AfterActivationFiredEvent;)V");
            global::org.drools.@event.rule.DebugAgendaEventListener._agendaGroupPopped4 = @__env.GetMethodID(global::org.drools.@event.rule.DebugAgendaEventListener.staticClass, "agendaGroupPopped", "(Lorg/drools/event/rule/AgendaGroupPoppedEvent;)V");
            global::org.drools.@event.rule.DebugAgendaEventListener._agendaGroupPushed5 = @__env.GetMethodID(global::org.drools.@event.rule.DebugAgendaEventListener.staticClass, "agendaGroupPushed", "(Lorg/drools/event/rule/AgendaGroupPushedEvent;)V");
            global::org.drools.@event.rule.DebugAgendaEventListener.@__ctorDebugAgendaEventListener6 = @__env.GetMethodID(global::org.drools.@event.rule.DebugAgendaEventListener.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/rule/ActivationCreatedEvent;)V")]
        public virtual void activationCreated(global::org.drools.@event.rule.ActivationCreatedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.rule.DebugAgendaEventListener._activationCreated0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.ActivationCreatedEvent>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/rule/ActivationCancelledEvent;)V")]
        public virtual void activationCancelled(global::org.drools.@event.rule.ActivationCancelledEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.rule.DebugAgendaEventListener._activationCancelled1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.ActivationCancelledEvent>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/rule/BeforeActivationFiredEvent;)V")]
        public virtual void beforeActivationFired(global::org.drools.@event.rule.BeforeActivationFiredEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.rule.DebugAgendaEventListener._beforeActivationFired2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.BeforeActivationFiredEvent>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/rule/AfterActivationFiredEvent;)V")]
        public virtual void afterActivationFired(global::org.drools.@event.rule.AfterActivationFiredEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.rule.DebugAgendaEventListener._afterActivationFired3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.AfterActivationFiredEvent>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/rule/AgendaGroupPoppedEvent;)V")]
        public virtual void agendaGroupPopped(global::org.drools.@event.rule.AgendaGroupPoppedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.rule.DebugAgendaEventListener._agendaGroupPopped4, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.AgendaGroupPoppedEvent>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/rule/AgendaGroupPushedEvent;)V")]
        public virtual void agendaGroupPushed(global::org.drools.@event.rule.AgendaGroupPushedEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.rule.DebugAgendaEventListener._agendaGroupPushed5, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.AgendaGroupPushedEvent>(@__env, par0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.rule.DebugAgendaEventListener(@__env);
            }
        }
    }
    #endregion
}
