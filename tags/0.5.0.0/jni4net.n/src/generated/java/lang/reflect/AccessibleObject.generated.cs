//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class AccessibleObject : global::java.lang.Object, global::java.lang.reflect.AnnotatedElement {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAnnotation0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAnnotations1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredAnnotations2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAnnotationPresent3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAccessible4;
        
        internal static global::net.sf.jni4net.jni.MethodId _setAccessible5;
        
        internal static global::net.sf.jni4net.jni.MethodId _setAccessible6;
        
        protected AccessibleObject(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.AccessibleObject.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.AccessibleObject.staticClass = @__class;
            global::java.lang.reflect.AccessibleObject._getAnnotation0 = @__env.GetMethodID(global::java.lang.reflect.AccessibleObject.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.AccessibleObject._getAnnotations1 = @__env.GetMethodID(global::java.lang.reflect.AccessibleObject.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.AccessibleObject._getDeclaredAnnotations2 = @__env.GetMethodID(global::java.lang.reflect.AccessibleObject.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.AccessibleObject._isAnnotationPresent3 = @__env.GetMethodID(global::java.lang.reflect.AccessibleObject.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
            global::java.lang.reflect.AccessibleObject._isAccessible4 = @__env.GetMethodID(global::java.lang.reflect.AccessibleObject.staticClass, "isAccessible", "()Z");
            global::java.lang.reflect.AccessibleObject._setAccessible5 = @__env.GetMethodID(global::java.lang.reflect.AccessibleObject.staticClass, "setAccessible", "(Z)V");
            global::java.lang.reflect.AccessibleObject._setAccessible6 = @__env.GetStaticMethodID(global::java.lang.reflect.AccessibleObject.staticClass, "setAccessible", "([Ljava/lang/reflect/AccessibleObject;Z)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
        public virtual global::java.lang.annotation.Annotation getAnnotation(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.AccessibleObject._getAnnotation0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/annotation/Annotation;")]
        public virtual java.lang.annotation.Annotation[] getAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.annotation.Annotation[], global::java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.AccessibleObject._getAnnotations1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/annotation/Annotation;")]
        public virtual java.lang.annotation.Annotation[] getDeclaredAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.annotation.Annotation[], global::java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.AccessibleObject._getDeclaredAnnotations2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Z")]
        public virtual bool isAnnotationPresent(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.AccessibleObject._isAnnotationPresent3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isAccessible() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.AccessibleObject._isAccessible4)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public virtual void setAccessible(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.reflect.AccessibleObject._setAccessible5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/reflect/AccessibleObject;Z)V")]
        public static void setAccessible(java.lang.reflect.AccessibleObject[] par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.reflect.AccessibleObject.staticClass, global::java.lang.reflect.AccessibleObject._setAccessible6, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.AccessibleObject(@__env);
            }
        }
    }
    #endregion
}
