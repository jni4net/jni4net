//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.nio {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    [global::System.SerializableAttribute()]
    public partial class InvalidMarkException : global::java.lang.RuntimeException {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorInvalidMarkException0;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public InvalidMarkException() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.nio.InvalidMarkException.staticClass, global::java.nio.InvalidMarkException.j4n__ctorInvalidMarkException0, this);
            }
        }
        
        protected InvalidMarkException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected InvalidMarkException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.nio.InvalidMarkException.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.nio.InvalidMarkException.staticClass = @__class;
            global::java.nio.InvalidMarkException.j4n__ctorInvalidMarkException0 = @__env.GetMethodID(global::java.nio.InvalidMarkException.staticClass, "<init>", "()V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.nio.InvalidMarkException(@__env);
            }
        }
    }
    #endregion
}
