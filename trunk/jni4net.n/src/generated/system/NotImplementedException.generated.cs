//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class NotImplementedException_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__NotImplementedException.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.NotImplementedException))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.NotImplementedException))]
    internal sealed partial class @__NotImplementedException : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__NotImplementedException(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__NotImplementedException.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__NotImplementedException);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorNotImplementedException0", "__ctorNotImplementedException0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorNotImplementedException1", "__ctorNotImplementedException1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorNotImplementedException2", "__ctorNotImplementedException2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Exception;)V"));
            return methods;
        }
        
        private static void @__ctorNotImplementedException0(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.NotImplementedException real = new global::System.NotImplementedException();
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorNotImplementedException1(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr message) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.NotImplementedException real = new global::System.NotImplementedException(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, message));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorNotImplementedException2(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr message, global::System.IntPtr inner) {
            // (Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.NotImplementedException real = new global::System.NotImplementedException(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, message), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, inner));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__NotImplementedException(env);
            }
        }
    }
    #endregion
}
