//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Byte : global::java.lang.Number, global::java.lang.Comparable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString2;
        
        internal static global::net.sf.jni4net.jni.MethodId _decode3;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf4;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf5;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf6;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseByte7;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseByte8;
        
        internal static global::net.sf.jni4net.jni.FieldId _MIN_VALUE9;
        
        internal static global::net.sf.jni4net.jni.FieldId _MAX_VALUE10;
        
        internal static global::net.sf.jni4net.jni.FieldId _TYPE11;
        
        internal static global::net.sf.jni4net.jni.FieldId _SIZE12;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorByte13;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorByte14;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(B)V")]
        public Byte(byte par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.Byte.staticClass, global::java.lang.Byte.@__ctorByte13, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Byte(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.Byte.staticClass, global::java.lang.Byte.@__ctorByte14, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        protected Byte(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Byte.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("B")]
        public static byte MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((byte)(@__env.GetStaticByteField(global::java.lang.Byte.staticClass, global::java.lang.Byte._MIN_VALUE9)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("B")]
        public static byte MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((byte)(@__env.GetStaticByteField(global::java.lang.Byte.staticClass, global::java.lang.Byte._MAX_VALUE10)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Class;")]
        public static global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Byte.staticClass, global::java.lang.Byte._TYPE11));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.Byte.staticClass, global::java.lang.Byte._SIZE12)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Byte.staticClass = @__class;
            global::java.lang.Byte._compareTo0 = @__env.GetMethodID(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.lang.Byte._compareTo1 = @__env.GetMethodID(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Byte;)I");
            global::java.lang.Byte._toString2 = @__env.GetStaticMethodID(global::java.lang.Byte.staticClass, "toString", "(B)Ljava/lang/String;");
            global::java.lang.Byte._decode3 = @__env.GetStaticMethodID(global::java.lang.Byte.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Byte;");
            global::java.lang.Byte._valueOf4 = @__env.GetStaticMethodID(global::java.lang.Byte.staticClass, "valueOf", "(B)Ljava/lang/Byte;");
            global::java.lang.Byte._valueOf5 = @__env.GetStaticMethodID(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;");
            global::java.lang.Byte._valueOf6 = @__env.GetStaticMethodID(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;");
            global::java.lang.Byte._parseByte7 = @__env.GetStaticMethodID(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;)B");
            global::java.lang.Byte._parseByte8 = @__env.GetStaticMethodID(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;I)B");
            global::java.lang.Byte._MIN_VALUE9 = @__env.GetStaticFieldID(global::java.lang.Byte.staticClass, "MIN_VALUE", "B");
            global::java.lang.Byte._MAX_VALUE10 = @__env.GetStaticFieldID(global::java.lang.Byte.staticClass, "MAX_VALUE", "B");
            global::java.lang.Byte._TYPE11 = @__env.GetStaticFieldID(global::java.lang.Byte.staticClass, "TYPE", "Ljava/lang/Class;");
            global::java.lang.Byte._SIZE12 = @__env.GetStaticFieldID(global::java.lang.Byte.staticClass, "SIZE", "I");
            global::java.lang.Byte.@__ctorByte13 = @__env.GetMethodID(global::java.lang.Byte.staticClass, "<init>", "(B)V");
            global::java.lang.Byte.@__ctorByte14 = @__env.GetMethodID(global::java.lang.Byte.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Byte._compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Byte;)I")]
        public virtual int compareTo(global::java.lang.Byte par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Byte._compareTo1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(B)Ljava/lang/String;")]
        public static global::java.lang.String toString(byte par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Byte.staticClass, global::java.lang.Byte._toString2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Byte;")]
        public static global::java.lang.Byte decode(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Byte>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Byte.staticClass, global::java.lang.Byte._decode3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(B)Ljava/lang/Byte;")]
        public static global::java.lang.Byte valueOf(byte par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Byte>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Byte.staticClass, global::java.lang.Byte._valueOf4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)Ljava/lang/Byte;")]
        public static global::java.lang.Byte valueOf(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Byte>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Byte.staticClass, global::java.lang.Byte._valueOf5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Byte;")]
        public static global::java.lang.Byte valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Byte>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Byte.staticClass, global::java.lang.Byte._valueOf6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)B")]
        public static byte parseByte(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((byte)(@__env.CallStaticByteMethod(global::java.lang.Byte.staticClass, global::java.lang.Byte._parseByte7, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)B")]
        public static byte parseByte(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((byte)(@__env.CallStaticByteMethod(global::java.lang.Byte.staticClass, global::java.lang.Byte._parseByte8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Byte(@__env);
            }
        }
    }
    #endregion
}
