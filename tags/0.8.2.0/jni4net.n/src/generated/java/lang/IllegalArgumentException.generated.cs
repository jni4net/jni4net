//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    [global::System.SerializableAttribute()]
    public partial class IllegalArgumentException : global::java.lang.RuntimeException {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorIllegalArgumentException0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorIllegalArgumentException1;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorIllegalArgumentException2;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorIllegalArgumentException3;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public IllegalArgumentException(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException.@__ctorIllegalArgumentException0, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public IllegalArgumentException(global::java.lang.String par0, global::java.lang.Throwable par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.NewObject(global::java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException.@__ctorIllegalArgumentException1, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)V")]
        public IllegalArgumentException(global::java.lang.Throwable par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException.@__ctorIllegalArgumentException2, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public IllegalArgumentException() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException.@__ctorIllegalArgumentException3, this);
            }
        }
        
        protected IllegalArgumentException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected IllegalArgumentException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.IllegalArgumentException.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.IllegalArgumentException.staticClass = @__class;
            global::java.lang.IllegalArgumentException.@__ctorIllegalArgumentException0 = @__env.GetMethodID(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.IllegalArgumentException.@__ctorIllegalArgumentException1 = @__env.GetMethodID(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::java.lang.IllegalArgumentException.@__ctorIllegalArgumentException2 = @__env.GetMethodID(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
            global::java.lang.IllegalArgumentException.@__ctorIllegalArgumentException3 = @__env.GetMethodID(global::java.lang.IllegalArgumentException.staticClass, "<init>", "()V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.IllegalArgumentException(@__env);
            }
        }
    }
    #endregion
}
