//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Constructor : global::java.lang.reflect.AccessibleObject, global::java.lang.reflect.GenericDeclaration, global::java.lang.reflect.Member {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTypeParameters0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getModifiers1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSynthetic4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParameterTypes5;
        
        internal static global::net.sf.jni4net.jni.MethodId _newInstance6;
        
        internal static global::net.sf.jni4net.jni.MethodId _toGenericString7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getExceptionTypes8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericExceptionTypes9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericParameterTypes10;
        
        internal static global::net.sf.jni4net.jni.MethodId _isVarArgs11;
        
        internal static global::net.sf.jni4net.jni.FieldId _PUBLIC12;
        
        internal static global::net.sf.jni4net.jni.FieldId _DECLARED13;
        
        protected Constructor(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.Constructor.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._PUBLIC12)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int DECLARED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._DECLARED13)));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.Constructor.staticClass = @__class;
            global::java.lang.reflect.Constructor._getTypeParameters0 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
            global::java.lang.reflect.Constructor._getModifiers1 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "getModifiers", "()I");
            global::java.lang.reflect.Constructor._getName2 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.reflect.Constructor._getDeclaringClass3 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
            global::java.lang.reflect.Constructor._isSynthetic4 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "isSynthetic", "()Z");
            global::java.lang.reflect.Constructor._getParameterTypes5 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
            global::java.lang.reflect.Constructor._newInstance6 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.lang.reflect.Constructor._toGenericString7 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "toGenericString", "()Ljava/lang/String;");
            global::java.lang.reflect.Constructor._getExceptionTypes8 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
            global::java.lang.reflect.Constructor._getGenericExceptionTypes9 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Constructor._getGenericParameterTypes10 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Constructor._isVarArgs11 = @__env.GetMethodID(global::java.lang.reflect.Constructor.staticClass, "isVarArgs", "()Z");
            global::java.lang.reflect.Constructor._PUBLIC12 = @__env.GetStaticFieldID(global::java.lang.reflect.Constructor.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.Constructor._DECLARED13 = @__env.GetStaticFieldID(global::java.lang.reflect.Constructor.staticClass, "DECLARED", "I");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/TypeVariable;")]
        public virtual java.lang.reflect.TypeVariable[] getTypeParameters() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.TypeVariable[], global::java.lang.reflect.TypeVariable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._getTypeParameters0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getModifiers() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.reflect.Constructor._getModifiers1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._getName2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getDeclaringClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._getDeclaringClass3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isSynthetic() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Constructor._isSynthetic4)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._getParameterTypes5));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object newInstance(java.lang.Object[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._newInstance6, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], global::java.lang.Object>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toGenericString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._toGenericString7));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._getExceptionTypes8));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual java.lang.reflect.Type[] getGenericExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._getGenericExceptionTypes9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual java.lang.reflect.Type[] getGenericParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.Constructor._getGenericParameterTypes10));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isVarArgs() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.Constructor._isVarArgs11)));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.Constructor(@__env);
            }
        }
    }
    #endregion
}
