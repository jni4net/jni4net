//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class JavaCallBack : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_callBackException0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_callBackExceptionPropagate1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_callBackStatic2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_callBackComparison3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_callBackComparison24;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_callBackComparison35;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_callBackRun6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorJavaCallBack7;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public JavaCallBack() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::net.sf.jni4net.tested.JavaCallBack.staticClass, global::net.sf.jni4net.tested.JavaCallBack.j4n__ctorJavaCallBack7, this);
            }
        }
        
        protected JavaCallBack(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.JavaCallBack.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.JavaCallBack.staticClass = @__class;
            global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackException0 = @__env.GetStaticMethodID(global::net.sf.jni4net.tested.JavaCallBack.staticClass, "callBackException", "()V");
            global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackExceptionPropagate1 = @__env.GetStaticMethodID(global::net.sf.jni4net.tested.JavaCallBack.staticClass, "callBackExceptionPropagate", "()V");
            global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackStatic2 = @__env.GetStaticMethodID(global::net.sf.jni4net.tested.JavaCallBack.staticClass, "callBackStatic", "(II)I");
            global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackComparison3 = @__env.GetStaticMethodID(global::net.sf.jni4net.tested.JavaCallBack.staticClass, "callBackComparison", "()I");
            global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackComparison24 = @__env.GetStaticMethodID(global::net.sf.jni4net.tested.JavaCallBack.staticClass, "callBackComparison2", "()I");
            global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackComparison35 = @__env.GetStaticMethodID(global::net.sf.jni4net.tested.JavaCallBack.staticClass, "callBackComparison3", "()I");
            global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackRun6 = @__env.GetStaticMethodID(global::net.sf.jni4net.tested.JavaCallBack.staticClass, "callBackRun", "()I");
            global::net.sf.jni4net.tested.JavaCallBack.j4n__ctorJavaCallBack7 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaCallBack.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void callBackException() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallStaticVoidMethod(global::net.sf.jni4net.tested.JavaCallBack.staticClass, global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackException0);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void callBackExceptionPropagate() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallStaticVoidMethod(global::net.sf.jni4net.tested.JavaCallBack.staticClass, global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackExceptionPropagate1);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)I")]
        public static int callBackStatic(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((int)(@__env.CallStaticIntMethod(global::net.sf.jni4net.tested.JavaCallBack.staticClass, global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackStatic2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public static int callBackComparison() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallStaticIntMethod(global::net.sf.jni4net.tested.JavaCallBack.staticClass, global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackComparison3)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public static int callBackComparison2() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallStaticIntMethod(global::net.sf.jni4net.tested.JavaCallBack.staticClass, global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackComparison24)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public static int callBackComparison3() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallStaticIntMethod(global::net.sf.jni4net.tested.JavaCallBack.staticClass, global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackComparison35)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public static int callBackRun() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallStaticIntMethod(global::net.sf.jni4net.tested.JavaCallBack.staticClass, global::net.sf.jni4net.tested.JavaCallBack.j4n_callBackRun6)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.JavaCallBack(@__env);
            }
        }
    }
    #endregion
}