//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface GenericDeclaration {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/TypeVariable;")]
        java.lang.reflect.TypeVariable[] getTypeParameters();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class GenericDeclaration_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__GenericDeclaration.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.GenericDeclaration), typeof(global::java.lang.reflect.GenericDeclaration_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.GenericDeclaration), typeof(global::java.lang.reflect.GenericDeclaration_))]
    internal sealed partial class @__GenericDeclaration : global::java.lang.Object, global::java.lang.reflect.GenericDeclaration {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTypeParameters0;
        
        private @__GenericDeclaration(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.@__GenericDeclaration.staticClass = @__class;
            global::java.lang.reflect.@__GenericDeclaration.j4n_getTypeParameters0 = @__env.GetMethodID(global::java.lang.reflect.@__GenericDeclaration.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
        }
        
        public java.lang.reflect.TypeVariable[] getTypeParameters() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.TypeVariable[], global::java.lang.reflect.TypeVariable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__GenericDeclaration.j4n_getTypeParameters0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__GenericDeclaration);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTypeParameters", "getTypeParameters0", "()[Ljava/lang/reflect/TypeVariable;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getTypeParameters0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Ljava/lang/reflect/TypeVariable;
            // ()[Ljava/lang/reflect/TypeVariable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::java.lang.reflect.GenericDeclaration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.GenericDeclaration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<java.lang.reflect.TypeVariable[], global::java.lang.reflect.TypeVariable>(@__env, @__real.getTypeParameters());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.@__GenericDeclaration(@__env);
            }
        }
    }
    #endregion
}
