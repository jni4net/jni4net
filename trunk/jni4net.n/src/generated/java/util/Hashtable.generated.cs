//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Hashtable : global::java.util.Dictionary, global::java.util.Map, global::java.lang.Cloneable, global::java.io.Serializable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _clear0;
        
        internal static global::net.sf.jni4net.jni.MethodId _entrySet1;
        
        internal static global::net.sf.jni4net.jni.MethodId _putAll2;
        
        internal static global::net.sf.jni4net.jni.MethodId _values3;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsKey4;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsValue5;
        
        internal static global::net.sf.jni4net.jni.MethodId _keySet6;
        
        internal static global::net.sf.jni4net.jni.MethodId _contains7;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorHashtable8;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorHashtable9;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorHashtable10;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorHashtable11;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Hashtable() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.@__ctorHashtable8, this);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Map;)V")]
        public Hashtable(global::java.util.Map par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.@__ctorHashtable9, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Map>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public Hashtable(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.@__ctorHashtable10, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IF)V")]
        public Hashtable(int par0, float par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.@__ctorHashtable11, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        protected Hashtable(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.Hashtable.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.Hashtable.staticClass = @__class;
            global::java.util.Hashtable._clear0 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "clear", "()V");
            global::java.util.Hashtable._entrySet1 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "entrySet", "()Ljava/util/Set;");
            global::java.util.Hashtable._putAll2 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "putAll", "(Ljava/util/Map;)V");
            global::java.util.Hashtable._values3 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "values", "()Ljava/util/Collection;");
            global::java.util.Hashtable._containsKey4 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable._containsValue5 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable._keySet6 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "keySet", "()Ljava/util/Set;");
            global::java.util.Hashtable._contains7 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "contains", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable.@__ctorHashtable8 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "()V");
            global::java.util.Hashtable.@__ctorHashtable9 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(Ljava/util/Map;)V");
            global::java.util.Hashtable.@__ctorHashtable10 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(I)V");
            global::java.util.Hashtable.@__ctorHashtable11 = @__env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(IF)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void clear() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::java.util.Hashtable._clear0);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Set;")]
        public virtual global::java.util.Set entrySet() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable._entrySet1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Map;)V")]
        public virtual void putAll(global::java.util.Map par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Hashtable._putAll2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Map>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Collection;")]
        public virtual global::java.util.Collection values() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable._values3));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool containsKey(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Hashtable._containsKey4, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool containsValue(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Hashtable._containsValue5, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Set;")]
        public virtual global::java.util.Set keySet() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Hashtable._keySet6));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool contains(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Hashtable._contains7, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.Hashtable(@__env);
            }
        }
    }
    #endregion
}
