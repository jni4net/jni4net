//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface GenericArrayType : global::java.lang.reflect.Type {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        global::java.lang.reflect.Type getGenericComponentType();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class GenericArrayType_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__GenericArrayType.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.GenericArrayType), typeof(global::java.lang.reflect.GenericArrayType_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.GenericArrayType), typeof(global::java.lang.reflect.GenericArrayType_))]
    internal sealed partial class @__GenericArrayType : global::java.lang.Object, global::java.lang.reflect.GenericArrayType {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericComponentType0;
        
        private @__GenericArrayType(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.@__GenericArrayType.staticClass = @__class;
            global::java.lang.reflect.@__GenericArrayType._getGenericComponentType0 = @__env.GetMethodID(global::java.lang.reflect.@__GenericArrayType.staticClass, "getGenericComponentType", "()Ljava/lang/reflect/Type;");
        }
        
        public global::java.lang.reflect.Type getGenericComponentType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__GenericArrayType._getGenericComponentType0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__GenericArrayType);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getGenericComponentType", "getGenericComponentType0", "()Ljava/lang/reflect/Type;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getGenericComponentType0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/reflect/Type;
            // ()Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::java.lang.reflect.GenericArrayType @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.GenericArrayType>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.reflect.Type>(@__env, @__real.getGenericComponentType());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.@__GenericArrayType(@__env);
            }
        }
    }
    #endregion
}
