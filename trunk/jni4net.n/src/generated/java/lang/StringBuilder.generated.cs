//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class StringBuilder : global::java.lang.AbstractStringBuilder, global::java.io.Serializable, global::java.lang.CharSequence {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString0;
        
        internal static global::net.sf.jni4net.jni.MethodId _charAt1;
        
        internal static global::net.sf.jni4net.jni.MethodId _length2;
        
        internal static global::net.sf.jni4net.jni.MethodId _subSequence3;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor4;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor5;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor6;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor7;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public StringBuilder(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder.@__ctor4, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public StringBuilder(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder.@__ctor5, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/CharSequence;)V")]
        public StringBuilder(global::java.lang.CharSequence par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder.@__ctor6, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public StringBuilder() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder.@__ctor7, this);
        }
        
        protected StringBuilder(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.StringBuilder.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.StringBuilder.staticClass = staticClass;
            global::java.lang.StringBuilder._toString0 = env.GetMethodID(global::java.lang.StringBuilder.staticClass, "toString", "()Ljava/lang/String;");
            global::java.lang.StringBuilder._charAt1 = env.GetMethodID(global::java.lang.StringBuilder.staticClass, "charAt", "(I)C");
            global::java.lang.StringBuilder._length2 = env.GetMethodID(global::java.lang.StringBuilder.staticClass, "length", "()I");
            global::java.lang.StringBuilder._subSequence3 = env.GetMethodID(global::java.lang.StringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
            global::java.lang.StringBuilder.@__ctor4 = env.GetMethodID(global::java.lang.StringBuilder.staticClass, "<init>", "(I)V");
            global::java.lang.StringBuilder.@__ctor5 = env.GetMethodID(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.StringBuilder.@__ctor6 = env.GetMethodID(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
            global::java.lang.StringBuilder.@__ctor7 = env.GetMethodID(global::java.lang.StringBuilder.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.StringBuilder._toString0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)C")]
        public virtual char charAt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallCharMethod(this, global::java.lang.StringBuilder._charAt1, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int length() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.StringBuilder._length2);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/lang/CharSequence;")]
        public virtual global::java.lang.CharSequence subSequence(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.CharSequence>(env.CallObjectMethod(this, global::java.lang.StringBuilder._subSequence3, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.StringBuilder(env);
            }
        }
    }
    #endregion
}
