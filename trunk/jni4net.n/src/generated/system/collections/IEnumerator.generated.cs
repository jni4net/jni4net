//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Collections {
    
    
    #region Component Designer generated code 
    public partial class IEnumerator_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Collections.@__IEnumerator.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Collections.IEnumerator))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Collections.IEnumerator))]
    internal sealed partial class @__IEnumerator : global::java.lang.Object, global::System.Collections.IEnumerator {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _MoveNext0;
        
        internal static global::net.sf.jni4net.jni.MethodId _Current1;
        
        internal static global::net.sf.jni4net.jni.MethodId _Reset2;
        
        protected @__IEnumerator(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public object Current {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.StrongJp2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IEnumerator._Current1));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Collections.@__IEnumerator.staticClass = @__class;
            global::System.Collections.@__IEnumerator._MoveNext0 = @__env.GetMethodID(global::System.Collections.@__IEnumerator.staticClass, "MoveNext", "()Z");
            global::System.Collections.@__IEnumerator._Current1 = @__env.GetMethodID(global::System.Collections.@__IEnumerator.staticClass, "getCurrent", "()Lsystem/Object;");
            global::System.Collections.@__IEnumerator._Reset2 = @__env.GetMethodID(global::System.Collections.@__IEnumerator.staticClass, "Reset", "()V");
        }
        
        public bool MoveNext() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::System.Collections.@__IEnumerator._MoveNext0)));
        }
        
        public void Reset() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::System.Collections.@__IEnumerator._Reset2);
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IEnumerator);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "MoveNext", "MoveNext0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrent", "Current1", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Reset", "Reset2", "()V"));
            return methods;
        }
        
        private static bool MoveNext0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IEnumerator>(@__env, @__obj);
            return ((bool)(@__real.MoveNext()));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::System.IntPtr Current1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IEnumerator>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<object>(@__env, @__real.Current);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void Reset2(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IEnumerator>(@__env, @__obj);
            @__real.Reset();
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Collections.@__IEnumerator(@__env);
            }
        }
    }
    #endregion
}
