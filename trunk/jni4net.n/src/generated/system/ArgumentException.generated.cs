//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class ArgumentException_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.@__ArgumentException.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.ArgumentException))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.ArgumentException))]
    internal sealed partial class @__ArgumentException : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__ArgumentException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__ArgumentException.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ArgumentException);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getParamName", "ParamName0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorArgumentException0", "__ctorArgumentException0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorArgumentException1", "__ctorArgumentException1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorArgumentException2", "__ctorArgumentException2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Exception;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorArgumentException3", "__ctorArgumentException3", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Ljava/lang/String;Lsystem/Except" +
                        "ion;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorArgumentException4", "__ctorArgumentException4", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Ljava/lang/String;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ParamName0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ArgumentException @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.ArgumentException>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.ParamName);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static void @__ctorArgumentException0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ArgumentException @__real = new global::System.ArgumentException();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorArgumentException1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle message) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ArgumentException @__real = new global::System.ArgumentException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorArgumentException2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle message, global::net.sf.jni4net.utils.JniLocalHandle innerException) {
            // (Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ArgumentException @__real = new global::System.ArgumentException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Exception>(@__env, innerException));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorArgumentException3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle message, global::net.sf.jni4net.utils.JniLocalHandle paramName, global::net.sf.jni4net.utils.JniLocalHandle innerException) {
            // (Ljava/lang/String;Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ArgumentException @__real = new global::System.ArgumentException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, paramName), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Exception>(@__env, innerException));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorArgumentException4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle message, global::net.sf.jni4net.utils.JniLocalHandle paramName) {
            // (Ljava/lang/String;Ljava/lang/String;)V
            // (LSystem/String;LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ArgumentException @__real = new global::System.ArgumentException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, paramName));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__ArgumentException(@__env);
            }
        }
    }
    #endregion
}
