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
    public partial class ByteOrder : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_nativeOrder0;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_BIG_ENDIAN1;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_LITTLE_ENDIAN2;
        
        protected ByteOrder(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.nio.ByteOrder.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/nio/ByteOrder;")]
        public static global::java.nio.ByteOrder BIG_ENDIAN {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteOrder>(@__env, @__env.GetStaticObjectFieldPtr(global::java.nio.ByteOrder.staticClass, global::java.nio.ByteOrder.j4n_BIG_ENDIAN1));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/nio/ByteOrder;")]
        public static global::java.nio.ByteOrder LITTLE_ENDIAN {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteOrder>(@__env, @__env.GetStaticObjectFieldPtr(global::java.nio.ByteOrder.staticClass, global::java.nio.ByteOrder.j4n_LITTLE_ENDIAN2));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.nio.ByteOrder.staticClass = @__class;
            global::java.nio.ByteOrder.j4n_nativeOrder0 = @__env.GetStaticMethodID(global::java.nio.ByteOrder.staticClass, "nativeOrder", "()Ljava/nio/ByteOrder;");
            global::java.nio.ByteOrder.j4n_BIG_ENDIAN1 = @__env.GetStaticFieldID(global::java.nio.ByteOrder.staticClass, "BIG_ENDIAN", "Ljava/nio/ByteOrder;");
            global::java.nio.ByteOrder.j4n_LITTLE_ENDIAN2 = @__env.GetStaticFieldID(global::java.nio.ByteOrder.staticClass, "LITTLE_ENDIAN", "Ljava/nio/ByteOrder;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteOrder;")]
        public static global::java.nio.ByteOrder nativeOrder() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteOrder>(@__env, @__env.CallStaticObjectMethodPtr(global::java.nio.ByteOrder.staticClass, global::java.nio.ByteOrder.j4n_nativeOrder0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.nio.ByteOrder(@__env);
            }
        }
    }
    #endregion
}
