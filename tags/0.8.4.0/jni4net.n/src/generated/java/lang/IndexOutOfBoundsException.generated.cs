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
    public partial class IndexOutOfBoundsException : global::java.lang.RuntimeException {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorIndexOutOfBoundsException0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorIndexOutOfBoundsException1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public IndexOutOfBoundsException(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.IndexOutOfBoundsException.staticClass, global::java.lang.IndexOutOfBoundsException.@__ctorIndexOutOfBoundsException0, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public IndexOutOfBoundsException() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.lang.IndexOutOfBoundsException.staticClass, global::java.lang.IndexOutOfBoundsException.@__ctorIndexOutOfBoundsException1, this);
            }
        }
        
        protected IndexOutOfBoundsException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected IndexOutOfBoundsException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.IndexOutOfBoundsException.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.IndexOutOfBoundsException.staticClass = @__class;
            global::java.lang.IndexOutOfBoundsException.@__ctorIndexOutOfBoundsException0 = @__env.GetMethodID(global::java.lang.IndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.IndexOutOfBoundsException.@__ctorIndexOutOfBoundsException1 = @__env.GetMethodID(global::java.lang.IndexOutOfBoundsException.staticClass, "<init>", "()V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.IndexOutOfBoundsException(@__env);
            }
        }
    }
    #endregion
}
