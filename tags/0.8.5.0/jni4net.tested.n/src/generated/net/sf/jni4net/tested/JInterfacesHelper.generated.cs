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
    public partial class JInterfacesHelper : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getCWithJavaInterfaceC0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getCWithJavaInterface1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createJWithClrInterface2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createJWithClrInterfaceUnreg3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createJWithClrInterfaceUnregRun4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createJWithClrInterfaceExt5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorJInterfacesHelper6;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public JInterfacesHelper() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, global::net.sf.jni4net.tested.JInterfacesHelper.j4n__ctorJInterfacesHelper6, this);
            }
        }
        
        protected JInterfacesHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.JInterfacesHelper.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.JInterfacesHelper.staticClass = @__class;
            global::net.sf.jni4net.tested.JInterfacesHelper.j4n_getCWithJavaInterfaceC0 = @__env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "getCWithJavaInterfaceC", "(Lnet/sf/jni4net/tested/CWithJavaInterface;)Lnet/sf/jni4net/tested/CWithJavaInter" +
                    "face;");
            global::net.sf.jni4net.tested.JInterfacesHelper.j4n_getCWithJavaInterface1 = @__env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "getCWithJavaInterface", "(Ljava/lang/Runnable;)Ljava/lang/Runnable;");
            global::net.sf.jni4net.tested.JInterfacesHelper.j4n_createJWithClrInterface2 = @__env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "createJWithClrInterface", "(I)Lnet/sf/jni4net/tested/JWithClrInterface;");
            global::net.sf.jni4net.tested.JInterfacesHelper.j4n_createJWithClrInterfaceUnreg3 = @__env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "createJWithClrInterfaceUnreg", "(I)Lsystem/IComparable;");
            global::net.sf.jni4net.tested.JInterfacesHelper.j4n_createJWithClrInterfaceUnregRun4 = @__env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "createJWithClrInterfaceUnregRun", "(I)Ljava/lang/Runnable;");
            global::net.sf.jni4net.tested.JInterfacesHelper.j4n_createJWithClrInterfaceExt5 = @__env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "createJWithClrInterfaceExt", "(I)Lnet/sf/jni4net/tested/JWithClrInterface;");
            global::net.sf.jni4net.tested.JInterfacesHelper.j4n__ctorJInterfacesHelper6 = @__env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/jni4net/tested/CWithJavaInterface;)Lnet/sf/jni4net/tested/CWithJavaInter" +
            "face;")]
        public virtual global::net.sf.jni4net.tested.CWithJavaInterface getCWithJavaInterfaceC(global::net.sf.jni4net.tested.CWithJavaInterface par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JInterfacesHelper.j4n_getCWithJavaInterfaceC0, global::net.sf.jni4net.utils.Convertor.ParStrongC2Jp<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Runnable;)Ljava/lang/Runnable;")]
        public virtual global::java.lang.Runnable getCWithJavaInterface(global::java.lang.Runnable par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Runnable>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JInterfacesHelper.j4n_getCWithJavaInterface1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Runnable>(@__env, par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lnet/sf/jni4net/tested/JWithClrInterface;")]
        public virtual global::net.sf.jni4net.tested.JWithClrInterface createJWithClrInterface(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::net.sf.jni4net.tested.JWithClrInterface>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JInterfacesHelper.j4n_createJWithClrInterface2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lsystem/IComparable;")]
        public virtual global::System.IComparable createJWithClrInterfaceUnreg(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IComparable>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JInterfacesHelper.j4n_createJWithClrInterfaceUnreg3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/Runnable;")]
        public virtual global::java.lang.Runnable createJWithClrInterfaceUnregRun(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Runnable>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JInterfacesHelper.j4n_createJWithClrInterfaceUnregRun4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lnet/sf/jni4net/tested/JWithClrInterface;")]
        public virtual global::net.sf.jni4net.tested.JWithClrInterface createJWithClrInterfaceExt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::net.sf.jni4net.tested.JWithClrInterface>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JInterfacesHelper.j4n_createJWithClrInterfaceExt5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.JInterfacesHelper(@__env);
            }
        }
    }
    #endregion
}
