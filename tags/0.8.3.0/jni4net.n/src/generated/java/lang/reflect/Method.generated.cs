//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Method : global::java.lang.reflect.AccessibleObject, global::java.lang.reflect.GenericDeclaration, global::java.lang.reflect.Member {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTypeParameters0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getModifiers1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSynthetic4;
        
        internal static global::net.sf.jni4net.jni.MethodId _invoke5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParameterTypes6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getReturnType7;
        
        internal static global::net.sf.jni4net.jni.MethodId _toGenericString8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDefaultValue9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getExceptionTypes10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericExceptionTypes11;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericParameterTypes12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericReturnType13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParameterAnnotations14;
        
        internal static global::net.sf.jni4net.jni.MethodId _isBridge15;
        
        internal static global::net.sf.jni4net.jni.MethodId _isVarArgs16;
        
        internal static global::net.sf.jni4net.jni.FieldId _PUBLIC17;
        
        internal static global::net.sf.jni4net.jni.FieldId _DECLARED18;
        
        protected Method(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.Method.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._PUBLIC17)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int DECLARED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._DECLARED18)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.Method.staticClass = @__class;
            global::java.lang.reflect.Method._getTypeParameters0 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
            global::java.lang.reflect.Method._getModifiers1 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getModifiers", "()I");
            global::java.lang.reflect.Method._getName2 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.reflect.Method._getDeclaringClass3 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
            global::java.lang.reflect.Method._isSynthetic4 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "isSynthetic", "()Z");
            global::java.lang.reflect.Method._invoke5 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.lang.reflect.Method._getParameterTypes6 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
            global::java.lang.reflect.Method._getReturnType7 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getReturnType", "()Ljava/lang/Class;");
            global::java.lang.reflect.Method._toGenericString8 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "toGenericString", "()Ljava/lang/String;");
            global::java.lang.reflect.Method._getDefaultValue9 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getDefaultValue", "()Ljava/lang/Object;");
            global::java.lang.reflect.Method._getExceptionTypes10 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
            global::java.lang.reflect.Method._getGenericExceptionTypes11 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Method._getGenericParameterTypes12 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Method._getGenericReturnType13 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getGenericReturnType", "()Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Method._getParameterAnnotations14 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.Method._isBridge15 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "isBridge", "()Z");
            global::java.lang.reflect.Method._isVarArgs16 = @__env.GetMethodID(global::java.lang.reflect.Method.staticClass, "isVarArgs", "()Z");
            global::java.lang.reflect.Method._PUBLIC17 = @__env.GetStaticFieldID(global::java.lang.reflect.Method.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.Method._DECLARED18 = @__env.GetStaticFieldID(global::java.lang.reflect.Method.staticClass, "DECLARED", "I");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/TypeVariable;")]
        public virtual java.lang.reflect.TypeVariable[] getTypeParameters() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.TypeVariable[], global::java.lang.reflect.TypeVariable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getTypeParameters0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getModifiers() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.reflect.Method._getModifiers1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getName2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getDeclaringClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getDeclaringClass3));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isSynthetic() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Method._isSynthetic4)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object invoke(global::java.lang.Object par0, java.lang.Object[] par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._invoke5, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], global::java.lang.Object>(@__env, par1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getParameterTypes6));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getReturnType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getReturnType7));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toGenericString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._toGenericString8));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        public virtual global::java.lang.Object getDefaultValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getDefaultValue9));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getExceptionTypes10));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual java.lang.reflect.Type[] getGenericExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getGenericExceptionTypes11));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual java.lang.reflect.Type[] getGenericParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getGenericParameterTypes12));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        public virtual global::java.lang.reflect.Type getGenericReturnType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getGenericReturnType13));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[[Ljava/lang/annotation/Annotation;")]
        public virtual java.lang.annotation.Annotation[][] getParameterAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJp2C<java.lang.annotation.Annotation[][], java.lang.annotation.Annotation[]>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getParameterAnnotations14));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isBridge() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Method._isBridge15)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isVarArgs() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Method._isVarArgs16)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.Method(@__env);
            }
        }
    }
    #endregion
}
