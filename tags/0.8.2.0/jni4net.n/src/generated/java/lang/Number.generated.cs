//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Number : global::java.lang.Object, global::java.io.Serializable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _byteValue0;
        
        internal static global::net.sf.jni4net.jni.MethodId _doubleValue1;
        
        internal static global::net.sf.jni4net.jni.MethodId _floatValue2;
        
        internal static global::net.sf.jni4net.jni.MethodId _intValue3;
        
        internal static global::net.sf.jni4net.jni.MethodId _longValue4;
        
        internal static global::net.sf.jni4net.jni.MethodId _shortValue5;
        
        protected Number(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Number.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Number.staticClass = @__class;
            global::java.lang.Number._byteValue0 = @__env.GetMethodID(global::java.lang.Number.staticClass, "byteValue", "()B");
            global::java.lang.Number._doubleValue1 = @__env.GetMethodID(global::java.lang.Number.staticClass, "doubleValue", "()D");
            global::java.lang.Number._floatValue2 = @__env.GetMethodID(global::java.lang.Number.staticClass, "floatValue", "()F");
            global::java.lang.Number._intValue3 = @__env.GetMethodID(global::java.lang.Number.staticClass, "intValue", "()I");
            global::java.lang.Number._longValue4 = @__env.GetMethodID(global::java.lang.Number.staticClass, "longValue", "()J");
            global::java.lang.Number._shortValue5 = @__env.GetMethodID(global::java.lang.Number.staticClass, "shortValue", "()S");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()B")]
        public virtual byte byteValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((byte)(@__env.CallByteMethod(this, global::java.lang.Number._byteValue0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        public virtual double doubleValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((double)(@__env.CallDoubleMethod(this, global::java.lang.Number._doubleValue1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()F")]
        public virtual float floatValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((float)(@__env.CallFloatMethod(this, global::java.lang.Number._floatValue2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int intValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Number._intValue3)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long longValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::java.lang.Number._longValue4)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()S")]
        public virtual short shortValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((short)(@__env.CallShortMethod(this, global::java.lang.Number._shortValue5)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Number(@__env);
            }
        }
    }
    #endregion
}
