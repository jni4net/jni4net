//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.nio {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Buffer : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _limit0;
        
        internal static global::net.sf.jni4net.jni.MethodId _limit1;
        
        internal static global::net.sf.jni4net.jni.MethodId _clear2;
        
        internal static global::net.sf.jni4net.jni.MethodId _position3;
        
        internal static global::net.sf.jni4net.jni.MethodId _position4;
        
        internal static global::net.sf.jni4net.jni.MethodId _remaining5;
        
        internal static global::net.sf.jni4net.jni.MethodId _capacity6;
        
        internal static global::net.sf.jni4net.jni.MethodId _flip7;
        
        internal static global::net.sf.jni4net.jni.MethodId _hasRemaining8;
        
        internal static global::net.sf.jni4net.jni.MethodId _isReadOnly9;
        
        internal static global::net.sf.jni4net.jni.MethodId _mark10;
        
        internal static global::net.sf.jni4net.jni.MethodId _reset11;
        
        internal static global::net.sf.jni4net.jni.MethodId _rewind12;
        
        protected Buffer(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.nio.Buffer.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.nio.Buffer.staticClass = @__class;
            global::java.nio.Buffer._limit0 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "limit", "(I)Ljava/nio/Buffer;");
            global::java.nio.Buffer._limit1 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "limit", "()I");
            global::java.nio.Buffer._clear2 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "clear", "()Ljava/nio/Buffer;");
            global::java.nio.Buffer._position3 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "position", "()I");
            global::java.nio.Buffer._position4 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "position", "(I)Ljava/nio/Buffer;");
            global::java.nio.Buffer._remaining5 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "remaining", "()I");
            global::java.nio.Buffer._capacity6 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "capacity", "()I");
            global::java.nio.Buffer._flip7 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "flip", "()Ljava/nio/Buffer;");
            global::java.nio.Buffer._hasRemaining8 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "hasRemaining", "()Z");
            global::java.nio.Buffer._isReadOnly9 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "isReadOnly", "()Z");
            global::java.nio.Buffer._mark10 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "mark", "()Ljava/nio/Buffer;");
            global::java.nio.Buffer._reset11 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "reset", "()Ljava/nio/Buffer;");
            global::java.nio.Buffer._rewind12 = @__env.GetMethodID(global::java.nio.Buffer.staticClass, "rewind", "()Ljava/nio/Buffer;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/nio/Buffer;")]
        public global::java.nio.Buffer limit(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.Buffer._limit0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public int limit() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.Buffer._limit1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public global::java.nio.Buffer clear() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.Buffer._clear2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public int position() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.Buffer._position3)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/nio/Buffer;")]
        public global::java.nio.Buffer position(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.Buffer._position4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public int remaining() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.Buffer._remaining5)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public int capacity() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.Buffer._capacity6)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public global::java.nio.Buffer flip() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.Buffer._flip7));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public bool hasRemaining() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.nio.Buffer._hasRemaining8)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isReadOnly() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.nio.Buffer._isReadOnly9)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public global::java.nio.Buffer mark() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.Buffer._mark10));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public global::java.nio.Buffer reset() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.Buffer._reset11));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public global::java.nio.Buffer rewind() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.Buffer._rewind12));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.nio.Buffer(@__env);
            }
        }
    }
    #endregion
}