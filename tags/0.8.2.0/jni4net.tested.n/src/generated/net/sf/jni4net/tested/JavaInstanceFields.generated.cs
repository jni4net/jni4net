//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class JavaInstanceFields : global::java.lang.Object, global::System.Runtime.Serialization.ISerializable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.FieldId _intField1;
        
        internal static global::net.sf.jni4net.jni.FieldId _stringField2;
        
        internal static global::net.sf.jni4net.jni.FieldId _byteField3;
        
        internal static global::net.sf.jni4net.jni.FieldId _charField4;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorJavaInstanceFields5;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public JavaInstanceFields() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::net.sf.jni4net.tested.JavaInstanceFields.staticClass, global::net.sf.jni4net.tested.JavaInstanceFields.@__ctorJavaInstanceFields5, this);
            }
        }
        
        protected JavaInstanceFields(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.JavaInstanceFields.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public virtual int intField {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetIntField(this, global::net.sf.jni4net.tested.JavaInstanceFields._intField1)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public virtual global::java.lang.String stringField {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.GetObjectFieldPtr(this, global::net.sf.jni4net.tested.JavaInstanceFields._stringField2));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("B")]
        public virtual byte byteField {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((byte)(@__env.GetByteField(this, global::net.sf.jni4net.tested.JavaInstanceFields._byteField3)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("C")]
        public virtual char charField {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((char)(@__env.GetCharField(this, global::net.sf.jni4net.tested.JavaInstanceFields._charField4)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.JavaInstanceFields.staticClass = @__class;
            global::net.sf.jni4net.tested.JavaInstanceFields._intField1 = @__env.GetFieldID(global::net.sf.jni4net.tested.JavaInstanceFields.staticClass, "intField", "I");
            global::net.sf.jni4net.tested.JavaInstanceFields._stringField2 = @__env.GetFieldID(global::net.sf.jni4net.tested.JavaInstanceFields.staticClass, "stringField", "Ljava/lang/String;");
            global::net.sf.jni4net.tested.JavaInstanceFields._byteField3 = @__env.GetFieldID(global::net.sf.jni4net.tested.JavaInstanceFields.staticClass, "byteField", "B");
            global::net.sf.jni4net.tested.JavaInstanceFields._charField4 = @__env.GetFieldID(global::net.sf.jni4net.tested.JavaInstanceFields.staticClass, "charField", "C");
            global::net.sf.jni4net.tested.JavaInstanceFields.@__ctorJavaInstanceFields5 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaInstanceFields.staticClass, "<init>", "()V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.JavaInstanceFields(@__env);
            }
        }
    }
    #endregion
}
