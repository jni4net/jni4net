//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface KnowledgeRuntimeEventManager : global::org.drools.@event.rule.WorkingMemoryEventManager, global::org.drools.@event.process.ProcessEventManager {
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class KnowledgeRuntimeEventManager_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.@event.KnowledgeRuntimeEventManager), typeof(global::org.drools.@event.KnowledgeRuntimeEventManager_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.@event.KnowledgeRuntimeEventManager), typeof(global::org.drools.@event.KnowledgeRuntimeEventManager_))]
    internal sealed partial class @__KnowledgeRuntimeEventManager : global::java.lang.Object, global::org.drools.@event.KnowledgeRuntimeEventManager {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _addEventListener0;
        
        internal static global::net.sf.jni4net.jni.MethodId _addEventListener1;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeEventListener2;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeEventListener3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getWorkingMemoryEventListeners4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAgendaEventListeners5;
        
        internal static global::net.sf.jni4net.jni.MethodId _addEventListener6;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeEventListener7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProcessEventListeners8;
        
        private @__KnowledgeRuntimeEventManager(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass = @__class;
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._addEventListener0 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "addEventListener", "(Lorg/drools/event/rule/AgendaEventListener;)V");
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._addEventListener1 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "addEventListener", "(Lorg/drools/event/rule/WorkingMemoryEventListener;)V");
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._removeEventListener2 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "removeEventListener", "(Lorg/drools/event/rule/AgendaEventListener;)V");
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._removeEventListener3 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "removeEventListener", "(Lorg/drools/event/rule/WorkingMemoryEventListener;)V");
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._getWorkingMemoryEventListeners4 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "getWorkingMemoryEventListeners", "()Ljava/util/Collection;");
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._getAgendaEventListeners5 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "getAgendaEventListeners", "()Ljava/util/Collection;");
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._addEventListener6 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "addEventListener", "(Lorg/drools/event/process/ProcessEventListener;)V");
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._removeEventListener7 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "removeEventListener", "(Lorg/drools/event/process/ProcessEventListener;)V");
            global::org.drools.@event.@__KnowledgeRuntimeEventManager._getProcessEventListeners8 = @__env.GetMethodID(global::org.drools.@event.@__KnowledgeRuntimeEventManager.staticClass, "getProcessEventListeners", "()Ljava/util/Collection;");
        }
        
        public void addEventListener(global::org.drools.@event.rule.AgendaEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._addEventListener0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.AgendaEventListener>(@__env, par0));
            }
        }
        
        public void addEventListener(global::org.drools.@event.rule.WorkingMemoryEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._addEventListener1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.WorkingMemoryEventListener>(@__env, par0));
            }
        }
        
        public void removeEventListener(global::org.drools.@event.rule.AgendaEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._removeEventListener2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.AgendaEventListener>(@__env, par0));
            }
        }
        
        public void removeEventListener(global::org.drools.@event.rule.WorkingMemoryEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._removeEventListener3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.WorkingMemoryEventListener>(@__env, par0));
            }
        }
        
        public global::java.util.Collection getWorkingMemoryEventListeners() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._getWorkingMemoryEventListeners4));
            }
        }
        
        public global::java.util.Collection getAgendaEventListeners() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._getAgendaEventListeners5));
            }
        }
        
        public void addEventListener(global::org.drools.@event.process.ProcessEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._addEventListener6, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }
        }
        
        public void removeEventListener(global::org.drools.@event.process.ProcessEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._removeEventListener7, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }
        }
        
        public global::java.util.Collection getProcessEventListeners() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.@__KnowledgeRuntimeEventManager._getProcessEventListeners8));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__KnowledgeRuntimeEventManager);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addEventListener", "addEventListener0", "(Lorg/drools/event/rule/AgendaEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addEventListener", "addEventListener1", "(Lorg/drools/event/rule/WorkingMemoryEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeEventListener", "removeEventListener2", "(Lorg/drools/event/rule/AgendaEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeEventListener", "removeEventListener3", "(Lorg/drools/event/rule/WorkingMemoryEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getWorkingMemoryEventListeners", "getWorkingMemoryEventListeners4", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAgendaEventListeners", "getAgendaEventListeners5", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addEventListener", "addEventListener6", "(Lorg/drools/event/process/ProcessEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeEventListener", "removeEventListener7", "(Lorg/drools/event/process/ProcessEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getProcessEventListeners", "getProcessEventListeners8", "()Ljava/util/Collection;"));
            return methods;
        }
        
        private static void addEventListener0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/rule/AgendaEventListener;)V
            // (Lorg/drools/event/rule/AgendaEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).addEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.AgendaEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void addEventListener1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/rule/WorkingMemoryEventListener;)V
            // (Lorg/drools/event/rule/WorkingMemoryEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).addEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.WorkingMemoryEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void removeEventListener2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/rule/AgendaEventListener;)V
            // (Lorg/drools/event/rule/AgendaEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).removeEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.AgendaEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void removeEventListener3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/rule/WorkingMemoryEventListener;)V
            // (Lorg/drools/event/rule/WorkingMemoryEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).removeEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.WorkingMemoryEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getWorkingMemoryEventListeners4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).getWorkingMemoryEventListeners());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getAgendaEventListeners5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).getAgendaEventListeners());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void addEventListener6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/process/ProcessEventListener;)V
            // (Lorg/drools/event/process/ProcessEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            ((global::org.drools.@event.process.ProcessEventManager)(@__real)).addEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void removeEventListener7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/process/ProcessEventListener;)V
            // (Lorg/drools/event/process/ProcessEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            ((global::org.drools.@event.process.ProcessEventManager)(@__real)).removeEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getProcessEventListeners8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.KnowledgeRuntimeEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, ((global::org.drools.@event.process.ProcessEventManager)(@__real)).getProcessEventListeners());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.@__KnowledgeRuntimeEventManager(@__env);
            }
        }
    }
    #endregion
}