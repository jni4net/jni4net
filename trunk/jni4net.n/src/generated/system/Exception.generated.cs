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
    public unsafe partial class Exception_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__Exception.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Exception))]
    internal sealed unsafe partial class @__Exception : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__Exception.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Exception);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetObjectData", "GetObjectData0", "(Ljava/lang/Object;Lsystem/ValueType;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getMessage", "Message1", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getData", "Data2", "()Lsystem/collections/IDictionary;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetBaseException", "GetBaseException3", "()Lsystem/Exception;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getInnerException", "InnerException4", "()Lsystem/Exception;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getTargetSite", "TargetSite5", "()Lsystem/reflection/MethodBase;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getStackTraceNet", "StackTrace6", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getHelpLink", "HelpLink7", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "setHelpLink", "HelpLink8", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getSource", "Source9", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "setSource", "Source10", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToString", "ToString11", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetType", "GetType12", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Equals", "Equals13", "(Lsystem/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetHashCode", "GetHashCode14", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorException0", "__ctorException0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorException1", "__ctorException1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorException2", "__ctorException2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Exception;)V"));
            return methods;
        }
        
        private static void GetObjectData0(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* info, global::java.lang.Object.JavaPtr* context) {
            // (Ljava/lang/Object;Lsystem/ValueType;)V
            // (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            ((global::System.Runtime.Serialization.ISerializable)(real)).GetObjectData(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Runtime.Serialization.SerializationInfo>(__env, info), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Runtime.Serialization.StreamingContext>(__env, context));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::java.lang.Object.JavaPtr* Message1(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.Message);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* Data2(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/collections/IDictionary;
            // ()LSystem/Collections/IDictionary;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Data);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetBaseException3(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Exception;
            // ()LSystem/Exception;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetBaseException());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* InnerException4(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Exception;
            // ()LSystem/Exception;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.InnerException);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* TargetSite5(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/reflection/MethodBase;
            // ()LSystem/Reflection/MethodBase;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.TargetSite);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* StackTrace6(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.StackTrace);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* HelpLink7(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.HelpLink);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static void HelpLink8(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* value) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            real.HelpLink = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, value);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::java.lang.Object.JavaPtr* Source9(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.Source);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static void Source10(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* value) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            real.Source = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, value);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::java.lang.Object.JavaPtr* ToString11(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.ToString());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetType12(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetType());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool Equals13(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* obj) {
            // (Lsystem/Object;)Z
            // (LSystem/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return ((object)(real)).Equals(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, obj));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static int GetHashCode14(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, @__obj);
            return ((object)(real)).GetHashCode();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void @__ctorException0(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = new global::System.Exception();
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorException1(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* message) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = new global::System.Exception(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, message));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorException2(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* message, global::java.lang.Object.JavaPtr* innerException) {
            // (Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Exception real = new global::System.Exception(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, message), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, innerException));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__Exception(env);
            }
        }
    }
    #endregion
}
