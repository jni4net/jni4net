//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event.io {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ResourceChangeListener {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/ChangeSet;)V")]
        void resourcesChanged(global::org.drools.ChangeSet par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ResourceChangeListener_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.io.@__ResourceChangeListener.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.@event.io.ResourceChangeListener), typeof(global::org.drools.@event.io.ResourceChangeListener_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.@event.io.ResourceChangeListener), typeof(global::org.drools.@event.io.ResourceChangeListener_))]
    internal sealed partial class @__ResourceChangeListener : global::java.lang.Object, global::org.drools.@event.io.ResourceChangeListener {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _resourcesChanged0;
        
        private @__ResourceChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.io.@__ResourceChangeListener.staticClass = @__class;
            global::org.drools.@event.io.@__ResourceChangeListener._resourcesChanged0 = @__env.GetMethodID(global::org.drools.@event.io.@__ResourceChangeListener.staticClass, "resourcesChanged", "(Lorg/drools/ChangeSet;)V");
        }
        
        public void resourcesChanged(global::org.drools.ChangeSet par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.@event.io.@__ResourceChangeListener._resourcesChanged0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.ChangeSet>(@__env, par0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ResourceChangeListener);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "resourcesChanged", "resourcesChanged0", "(Lorg/drools/ChangeSet;)V"));
            return methods;
        }
        
        private static void resourcesChanged0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/ChangeSet;)V
            // (Lorg/drools/ChangeSet;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.@event.io.ResourceChangeListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.io.ResourceChangeListener>(@__env, @__obj);
            @__real.resourcesChanged(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.ChangeSet>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.io.@__ResourceChangeListener(@__env);
            }
        }
    }
    #endregion
}