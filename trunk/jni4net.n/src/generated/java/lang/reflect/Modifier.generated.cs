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
    public unsafe partial class Modifier : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _isInterface0;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString1;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAbstract2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isProtected3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isFinal4;
        
        internal static global::net.sf.jni4net.jni.MethodId _isStatic5;
        
        internal static global::net.sf.jni4net.jni.MethodId _isPublic6;
        
        internal static global::net.sf.jni4net.jni.MethodId _isVolatile7;
        
        internal static global::net.sf.jni4net.jni.MethodId _isPrivate8;
        
        internal static global::net.sf.jni4net.jni.MethodId _isNative9;
        
        internal static global::net.sf.jni4net.jni.MethodId _isStrict10;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSynchronized11;
        
        internal static global::net.sf.jni4net.jni.MethodId _isTransient12;
        
        internal static global::net.sf.jni4net.jni.FieldId _PUBLIC13;
        
        internal static global::net.sf.jni4net.jni.FieldId _PRIVATE14;
        
        internal static global::net.sf.jni4net.jni.FieldId _PROTECTED15;
        
        internal static global::net.sf.jni4net.jni.FieldId _STATIC16;
        
        internal static global::net.sf.jni4net.jni.FieldId _FINAL17;
        
        internal static global::net.sf.jni4net.jni.FieldId _SYNCHRONIZED18;
        
        internal static global::net.sf.jni4net.jni.FieldId _VOLATILE19;
        
        internal static global::net.sf.jni4net.jni.FieldId _TRANSIENT20;
        
        internal static global::net.sf.jni4net.jni.FieldId _NATIVE21;
        
        internal static global::net.sf.jni4net.jni.FieldId _INTERFACE22;
        
        internal static global::net.sf.jni4net.jni.FieldId _ABSTRACT23;
        
        internal static global::net.sf.jni4net.jni.FieldId _STRICT24;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor25;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Modifier() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.@__ctor25, this);
        }
        
        protected Modifier(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.Modifier.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._PUBLIC13);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PRIVATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._PRIVATE14);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PROTECTED {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._PROTECTED15);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int STATIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._STATIC16);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int FINAL {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._FINAL17);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SYNCHRONIZED {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._SYNCHRONIZED18);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int VOLATILE {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._VOLATILE19);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int TRANSIENT {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._TRANSIENT20);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int NATIVE {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._NATIVE21);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int INTERFACE {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._INTERFACE22);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ABSTRACT {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._ABSTRACT23);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int STRICT {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._STRICT24);
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.reflect.Modifier.staticClass = staticClass;
            global::java.lang.reflect.Modifier._isInterface0 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isInterface", "(I)Z");
            global::java.lang.reflect.Modifier._toString1 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "toString", "(I)Ljava/lang/String;");
            global::java.lang.reflect.Modifier._isAbstract2 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isAbstract", "(I)Z");
            global::java.lang.reflect.Modifier._isProtected3 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isProtected", "(I)Z");
            global::java.lang.reflect.Modifier._isFinal4 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isFinal", "(I)Z");
            global::java.lang.reflect.Modifier._isStatic5 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isStatic", "(I)Z");
            global::java.lang.reflect.Modifier._isPublic6 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isPublic", "(I)Z");
            global::java.lang.reflect.Modifier._isVolatile7 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isVolatile", "(I)Z");
            global::java.lang.reflect.Modifier._isPrivate8 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isPrivate", "(I)Z");
            global::java.lang.reflect.Modifier._isNative9 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isNative", "(I)Z");
            global::java.lang.reflect.Modifier._isStrict10 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isStrict", "(I)Z");
            global::java.lang.reflect.Modifier._isSynchronized11 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isSynchronized", "(I)Z");
            global::java.lang.reflect.Modifier._isTransient12 = env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isTransient", "(I)Z");
            global::java.lang.reflect.Modifier._PUBLIC13 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.Modifier._PRIVATE14 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PRIVATE", "I");
            global::java.lang.reflect.Modifier._PROTECTED15 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PROTECTED", "I");
            global::java.lang.reflect.Modifier._STATIC16 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "STATIC", "I");
            global::java.lang.reflect.Modifier._FINAL17 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "FINAL", "I");
            global::java.lang.reflect.Modifier._SYNCHRONIZED18 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "SYNCHRONIZED", "I");
            global::java.lang.reflect.Modifier._VOLATILE19 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "VOLATILE", "I");
            global::java.lang.reflect.Modifier._TRANSIENT20 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "TRANSIENT", "I");
            global::java.lang.reflect.Modifier._NATIVE21 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "NATIVE", "I");
            global::java.lang.reflect.Modifier._INTERFACE22 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "INTERFACE", "I");
            global::java.lang.reflect.Modifier._ABSTRACT23 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "ABSTRACT", "I");
            global::java.lang.reflect.Modifier._STRICT24 = env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "STRICT", "I");
            global::java.lang.reflect.Modifier.@__ctor25 = env.GetMethodID(global::java.lang.reflect.Modifier.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isInterface(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isInterface0, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._toString1, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isAbstract(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isAbstract2, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isProtected(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isProtected3, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isFinal(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isFinal4, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isStatic(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isStatic5, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isPublic(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isPublic6, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isVolatile(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isVolatile7, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isPrivate(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isPrivate8, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isNative(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isNative9, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isStrict(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isStrict10, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isSynchronized(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isSynchronized11, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isTransient(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isTransient12, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.reflect.Modifier(env);
            }
        }
    }
    #endregion
}
