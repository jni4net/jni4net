//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class AsyncCallback_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.@__AsyncCallback.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.AsyncCallback), typeof(global::System.AsyncCallback_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.AsyncCallback), typeof(global::System.AsyncCallback_))]
    internal sealed partial class @__AsyncCallback : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_Invoke0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_BeginInvoke1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_EndInvoke2;
        
        private @__AsyncCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__AsyncCallback.staticClass = @__class;
            global::System.@__AsyncCallback.j4n_Invoke0 = @__env.GetMethodID(global::System.@__AsyncCallback.staticClass, "Invoke", "(Lsystem/IAsyncResult;)V");
            global::System.@__AsyncCallback.j4n_BeginInvoke1 = @__env.GetMethodID(global::System.@__AsyncCallback.staticClass, "BeginInvoke", "(Lsystem/IAsyncResult;Lsystem/AsyncCallback;Lsystem/Object;)Lsystem/IAsyncResult;" +
                    "");
            global::System.@__AsyncCallback.j4n_EndInvoke2 = @__env.GetMethodID(global::System.@__AsyncCallback.staticClass, "EndInvoke", "(Lsystem/IAsyncResult;)V");
        }
        
        public void Invoke(global::System.IAsyncResult ar) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::System.@__AsyncCallback.j4n_Invoke0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::System.IAsyncResult>(@__env, ar));
            }
        }
        
        public global::System.IAsyncResult BeginInvoke(global::System.IAsyncResult ar, global::System.AsyncCallback callback, object @object) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IAsyncResult>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__AsyncCallback.j4n_BeginInvoke1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::System.IAsyncResult>(@__env, ar), global::net.sf.jni4net.utils.Convertor.ParStrongC2JDelegate(@__env, callback), global::net.sf.jni4net.utils.Convertor.ParFullC2J<object>(@__env, @object)));
            }
        }
        
        public void EndInvoke(global::System.IAsyncResult result) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::System.@__AsyncCallback.j4n_EndInvoke2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::System.IAsyncResult>(@__env, result));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__AsyncCallback);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke", "Invoke0", "(Lsystem/IAsyncResult;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "BeginInvoke", "BeginInvoke1", "(Lsystem/IAsyncResult;Lsystem/AsyncCallback;Lsystem/Object;)Lsystem/IAsyncResult;" +
                        ""));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "EndInvoke", "EndInvoke2", "(Lsystem/IAsyncResult;)V"));
            return methods;
        }
        
        private static void Invoke0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle ar) {
            // (Lsystem/IAsyncResult;)V
            // (LSystem/IAsyncResult;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.AsyncCallback @__real = global::net.sf.jni4net.utils.Convertor.StrongJ2CpDelegate<global::System.AsyncCallback>(@__env, @__obj);
            @__real.Invoke(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IAsyncResult>(@__env, ar));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle BeginInvoke1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle ar, global::net.sf.jni4net.utils.JniLocalHandle callback, global::net.sf.jni4net.utils.JniLocalHandle @object) {
            // (Lsystem/IAsyncResult;Lsystem/AsyncCallback;Lsystem/Object;)Lsystem/IAsyncResult;
            // (LSystem/IAsyncResult;LSystem/AsyncCallback;LSystem/Object;)LSystem/IAsyncResult;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.AsyncCallback @__real = global::net.sf.jni4net.utils.Convertor.StrongJ2CpDelegate<global::System.AsyncCallback>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.IAsyncResult>(@__env, @__real.BeginInvoke(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IAsyncResult>(@__env, ar), global::net.sf.jni4net.utils.Convertor.StrongJ2CpDelegate<global::System.AsyncCallback>(@__env, callback), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, @object)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void EndInvoke2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle result) {
            // (Lsystem/IAsyncResult;)V
            // (LSystem/IAsyncResult;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.AsyncCallback @__real = global::net.sf.jni4net.utils.Convertor.StrongJ2CpDelegate<global::System.AsyncCallback>(@__env, @__obj);
            @__real.EndInvoke(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IAsyncResult>(@__env, result));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__AsyncCallback(@__env);
            }
        }
    }
    #endregion
}
