//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Collections {
    
    
    #region Component Designer generated code 
    public unsafe partial class IDictionaryEnumerator_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Collections.@__IDictionaryEnumerator.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Collections.IDictionaryEnumerator))]
    internal sealed unsafe partial class @__IDictionaryEnumerator : global::java.lang.Object, global::System.Collections.IDictionaryEnumerator {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _MoveNext0;
        
        internal static global::net.sf.jni4net.jni.MethodId _Current1;
        
        internal static global::net.sf.jni4net.jni.MethodId _Reset2;
        
        internal static global::net.sf.jni4net.jni.MethodId _Key3;
        
        internal static global::net.sf.jni4net.jni.MethodId _Value4;
        
        internal static global::net.sf.jni4net.jni.MethodId _Entry5;
        
        protected @__IDictionaryEnumerator(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public object Current {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::System.Collections.@__IDictionaryEnumerator._Current1));
            }
        }
        
        public object Key {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::System.Collections.@__IDictionaryEnumerator._Key3));
            }
        }
        
        public object Value {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::System.Collections.@__IDictionaryEnumerator._Value4));
            }
        }
        
        public global::System.Collections.DictionaryEntry Entry {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.Bridge.ToCLR<global::System.Collections.DictionaryEntry>(env.CallObjectMethod(this, global::System.Collections.@__IDictionaryEnumerator._Entry5));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.Collections.@__IDictionaryEnumerator.staticClass = staticClass;
            global::System.Collections.@__IDictionaryEnumerator._MoveNext0 = env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "MoveNext", "()Z");
            global::System.Collections.@__IDictionaryEnumerator._Current1 = env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "getCurrent", "()Lsystem/Object;");
            global::System.Collections.@__IDictionaryEnumerator._Reset2 = env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "Reset", "()V");
            global::System.Collections.@__IDictionaryEnumerator._Key3 = env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "getKey", "()Lsystem/Object;");
            global::System.Collections.@__IDictionaryEnumerator._Value4 = env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "getValue", "()Lsystem/Object;");
            global::System.Collections.@__IDictionaryEnumerator._Entry5 = env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "getEntry", "()Lsystem/ValueType;");
        }
        
        public bool MoveNext() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::System.Collections.@__IDictionaryEnumerator._MoveNext0);
        }
        
        public void Reset() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::System.Collections.@__IDictionaryEnumerator._Reset2);
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IDictionaryEnumerator);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "MoveNext", "MoveNext0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getCurrent", "Current1", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Reset", "Reset2", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getKey", "Key3", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getValue", "Value4", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getEntry", "Entry5", "()Lsystem/ValueType;"));
            return methods;
        }
        
        private static bool MoveNext0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Collections.IDictionaryEnumerator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionaryEnumerator>(__env, @__obj);
            return ((global::System.Collections.IEnumerator)(real)).MoveNext();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::java.lang.Object.JavaPtr* Current1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Collections.IDictionaryEnumerator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionaryEnumerator>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::System.Collections.IEnumerator)(real)).Current);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static void Reset2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Collections.IDictionaryEnumerator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionaryEnumerator>(__env, @__obj);
            ((global::System.Collections.IEnumerator)(real)).Reset();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::java.lang.Object.JavaPtr* Key3(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Collections.IDictionaryEnumerator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionaryEnumerator>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Key);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* Value4(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Collections.IDictionaryEnumerator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionaryEnumerator>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Value);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* Entry5(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/ValueType;
            // ()LSystem/Collections/DictionaryEntry;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Collections.IDictionaryEnumerator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionaryEnumerator>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Entry);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.Collections.@__IDictionaryEnumerator(env);
            }
        }
    }
    #endregion
}
