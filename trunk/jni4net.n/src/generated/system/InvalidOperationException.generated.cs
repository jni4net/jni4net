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
    public unsafe partial class InvalidOperationException_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__InvalidOperationException.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.InvalidOperationException))]
    internal sealed unsafe partial class @__InvalidOperationException : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__InvalidOperationException(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__InvalidOperationException.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__InvalidOperationException);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorInvalidOperationException0", "__ctorInvalidOperationException0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorInvalidOperationException1", "__ctorInvalidOperationException1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorInvalidOperationException2", "__ctorInvalidOperationException2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Exception;)V"));
            return methods;
        }
        
        private static void @__ctorInvalidOperationException0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.InvalidOperationException real = new global::System.InvalidOperationException();
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorInvalidOperationException1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* message) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.InvalidOperationException real = new global::System.InvalidOperationException(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, message));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorInvalidOperationException2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* message, global::java.lang.Object.JavaPtr* innerException) {
            // (Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.InvalidOperationException real = new global::System.InvalidOperationException(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, message), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, innerException));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__InvalidOperationException(env);
            }
        }
    }
    #endregion
}