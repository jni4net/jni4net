//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    [global::System.SerializableAttribute()]
    public partial class NoSuchFieldException : global::java.lang.Exception {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorNoSuchFieldException0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorNoSuchFieldException1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public NoSuchFieldException(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException.@__ctorNoSuchFieldException0, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public NoSuchFieldException() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException.@__ctorNoSuchFieldException1, this);
        }
        
        protected NoSuchFieldException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected NoSuchFieldException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.NoSuchFieldException.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.NoSuchFieldException.staticClass = @__class;
            global::java.lang.NoSuchFieldException.@__ctorNoSuchFieldException0 = @__env.GetMethodID(global::java.lang.NoSuchFieldException.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.NoSuchFieldException.@__ctorNoSuchFieldException1 = @__env.GetMethodID(global::java.lang.NoSuchFieldException.staticClass, "<init>", "()V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.NoSuchFieldException(@__env);
            }
        }
    }
    #endregion
}
