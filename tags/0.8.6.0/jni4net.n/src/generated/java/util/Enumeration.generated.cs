//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Enumeration {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool hasMoreElements();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        global::java.lang.Object nextElement();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Enumeration_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::java.util.@__Enumeration.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.util.Enumeration), typeof(global::java.util.Enumeration_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.util.Enumeration), typeof(global::java.util.Enumeration_))]
    internal sealed partial class @__Enumeration : global::java.lang.Object, global::java.util.Enumeration {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_hasMoreElements0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_nextElement1;
        
        private @__Enumeration(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.@__Enumeration.staticClass = @__class;
            global::java.util.@__Enumeration.j4n_hasMoreElements0 = @__env.GetMethodID(global::java.util.@__Enumeration.staticClass, "hasMoreElements", "()Z");
            global::java.util.@__Enumeration.j4n_nextElement1 = @__env.GetMethodID(global::java.util.@__Enumeration.staticClass, "nextElement", "()Ljava/lang/Object;");
        }
        
        public bool hasMoreElements() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Enumeration.j4n_hasMoreElements0)));
            }
        }
        
        public global::java.lang.Object nextElement() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Enumeration.j4n_nextElement1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Enumeration);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "hasMoreElements", "hasMoreElements0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "nextElement", "nextElement1", "()Ljava/lang/Object;"));
            return methods;
        }
        
        private static bool hasMoreElements0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::java.util.Enumeration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Enumeration>(@__env, @__obj);
            @__return = ((bool)(@__real.hasMoreElements()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle nextElement1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/Object;
            // ()Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::java.util.Enumeration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Enumeration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.nextElement());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.@__Enumeration(@__env);
            }
        }
    }
    #endregion
}
