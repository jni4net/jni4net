//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.io {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ByteArrayOutputStream : global::java.io.OutputStream {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString0;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString1;
        
        internal static global::net.sf.jni4net.jni.MethodId _size2;
        
        internal static global::net.sf.jni4net.jni.MethodId _reset3;
        
        internal static global::net.sf.jni4net.jni.MethodId _toByteArray4;
        
        internal static global::net.sf.jni4net.jni.MethodId _writeTo5;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorByteArrayOutputStream6;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorByteArrayOutputStream7;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public ByteArrayOutputStream(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream.@__ctorByteArrayOutputStream6, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public ByteArrayOutputStream() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream.@__ctorByteArrayOutputStream7, this);
        }
        
        protected ByteArrayOutputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.io.ByteArrayOutputStream.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.io.ByteArrayOutputStream.staticClass = @__class;
            global::java.io.ByteArrayOutputStream._toString0 = @__env.GetMethodID(global::java.io.ByteArrayOutputStream.staticClass, "toString", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.io.ByteArrayOutputStream._toString1 = @__env.GetMethodID(global::java.io.ByteArrayOutputStream.staticClass, "toString", "(I)Ljava/lang/String;");
            global::java.io.ByteArrayOutputStream._size2 = @__env.GetMethodID(global::java.io.ByteArrayOutputStream.staticClass, "size", "()I");
            global::java.io.ByteArrayOutputStream._reset3 = @__env.GetMethodID(global::java.io.ByteArrayOutputStream.staticClass, "reset", "()V");
            global::java.io.ByteArrayOutputStream._toByteArray4 = @__env.GetMethodID(global::java.io.ByteArrayOutputStream.staticClass, "toByteArray", "()[B");
            global::java.io.ByteArrayOutputStream._writeTo5 = @__env.GetMethodID(global::java.io.ByteArrayOutputStream.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
            global::java.io.ByteArrayOutputStream.@__ctorByteArrayOutputStream6 = @__env.GetMethodID(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "(I)V");
            global::java.io.ByteArrayOutputStream.@__ctorByteArrayOutputStream7 = @__env.GetMethodID(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public virtual global::java.lang.String toString(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.ByteArrayOutputStream._toString0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public virtual global::java.lang.String toString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.ByteArrayOutputStream._toString1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int size() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.io.ByteArrayOutputStream._size2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void reset() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.ByteArrayOutputStream._reset3);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[B")]
        public virtual byte[] toByteArray() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cbyte(@__env, @__env.CallObjectMethodPtr(this, global::java.io.ByteArrayOutputStream._toByteArray4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;)V")]
        public virtual void writeTo(global::java.io.OutputStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.ByteArrayOutputStream._writeTo5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.io.ByteArrayOutputStream(@__env);
            }
        }
    }
    #endregion
}
