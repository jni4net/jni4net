//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class NoSuchFieldException : global::java.lang.Exception {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public NoSuchFieldException() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException.@__ctor0, this);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public NoSuchFieldException(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException.@__ctor1, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        protected NoSuchFieldException(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.NoSuchFieldException.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.NoSuchFieldException.staticClass = staticClass;
            global::java.lang.NoSuchFieldException.@__ctor0 = env.GetMethodID(global::java.lang.NoSuchFieldException.staticClass, "<init>", "()V");
            global::java.lang.NoSuchFieldException.@__ctor1 = env.GetMethodID(global::java.lang.NoSuchFieldException.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.NoSuchFieldException(env);
            }
        }
    }
    #endregion
}
