//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ObjectFilter {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool accept(global::java.lang.Object par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ObjectFilter_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.@__ObjectFilter.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.ObjectFilter), typeof(global::org.drools.runtime.ObjectFilter_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.ObjectFilter), typeof(global::org.drools.runtime.ObjectFilter_))]
    internal sealed partial class @__ObjectFilter : global::java.lang.Object, global::org.drools.runtime.ObjectFilter {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _accept0;
        
        private @__ObjectFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.@__ObjectFilter.staticClass = @__class;
            global::org.drools.runtime.@__ObjectFilter._accept0 = @__env.GetMethodID(global::org.drools.runtime.@__ObjectFilter.staticClass, "accept", "(Ljava/lang/Object;)Z");
        }
        
        public bool accept(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.runtime.@__ObjectFilter._accept0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ObjectFilter);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "accept", "accept0", "(Ljava/lang/Object;)Z"));
            return methods;
        }
        
        private static bool accept0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.runtime.ObjectFilter @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.ObjectFilter>(@__env, @__obj);
            @__return = ((bool)(@__real.accept(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.@__ObjectFilter(@__env);
            }
        }
    }
    #endregion
}
