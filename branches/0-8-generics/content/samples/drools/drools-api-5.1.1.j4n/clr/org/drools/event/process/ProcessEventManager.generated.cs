//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event.process {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ProcessEventManager {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/process/ProcessEventListener;)V")]
        void addEventListener(global::org.drools.@event.process.ProcessEventListener par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/process/ProcessEventListener;)V")]
        void removeEventListener(global::org.drools.@event.process.ProcessEventListener par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Collection;")]
        global::java.util.Collection getProcessEventListeners();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ProcessEventManager_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.process.@__ProcessEventManager.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.@event.process.ProcessEventManager), typeof(global::org.drools.@event.process.ProcessEventManager_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.@event.process.ProcessEventManager), typeof(global::org.drools.@event.process.ProcessEventManager_))]
    internal sealed partial class @__ProcessEventManager : global::java.lang.Object, global::org.drools.@event.process.ProcessEventManager {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _addEventListener0;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeEventListener1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProcessEventListeners2;
        
        private @__ProcessEventManager(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.process.@__ProcessEventManager.staticClass = @__class;
            global::org.drools.@event.process.@__ProcessEventManager._addEventListener0 = @__env.GetMethodID(global::org.drools.@event.process.@__ProcessEventManager.staticClass, "addEventListener", "(Lorg/drools/event/process/ProcessEventListener;)V");
            global::org.drools.@event.process.@__ProcessEventManager._removeEventListener1 = @__env.GetMethodID(global::org.drools.@event.process.@__ProcessEventManager.staticClass, "removeEventListener", "(Lorg/drools/event/process/ProcessEventListener;)V");
            global::org.drools.@event.process.@__ProcessEventManager._getProcessEventListeners2 = @__env.GetMethodID(global::org.drools.@event.process.@__ProcessEventManager.staticClass, "getProcessEventListeners", "()Ljava/util/Collection;");
        }
        
        public void addEventListener(global::org.drools.@event.process.ProcessEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.process.@__ProcessEventManager._addEventListener0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }
        }
        
        public void removeEventListener(global::org.drools.@event.process.ProcessEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.process.@__ProcessEventManager._removeEventListener1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }
        }
        
        public global::java.util.Collection getProcessEventListeners() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.process.@__ProcessEventManager._getProcessEventListeners2));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ProcessEventManager);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addEventListener", "addEventListener0", "(Lorg/drools/event/process/ProcessEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeEventListener", "removeEventListener1", "(Lorg/drools/event/process/ProcessEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getProcessEventListeners", "getProcessEventListeners2", "()Ljava/util/Collection;"));
            return methods;
        }
        
        private static void addEventListener0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/process/ProcessEventListener;)V
            // (Lorg/drools/event/process/ProcessEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.process.ProcessEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventManager>(@__env, @__obj);
            @__real.addEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void removeEventListener1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/process/ProcessEventListener;)V
            // (Lorg/drools/event/process/ProcessEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.process.ProcessEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventManager>(@__env, @__obj);
            @__real.removeEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getProcessEventListeners2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.process.ProcessEventManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventManager>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, @__real.getProcessEventListeners());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.process.@__ProcessEventManager(@__env);
            }
        }
    }
    #endregion
}
