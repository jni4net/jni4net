//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Collections {
    
    
    #region Component Designer generated code 
    public partial class IDictionaryEnumerator_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.Collections.@__IDictionaryEnumerator.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Collections.IDictionaryEnumerator), typeof(global::System.Collections.IDictionaryEnumerator_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Collections.IDictionaryEnumerator), typeof(global::System.Collections.IDictionaryEnumerator_))]
    internal sealed partial class @__IDictionaryEnumerator : global::java.lang.Object, global::System.Collections.IDictionaryEnumerator {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _MoveNext0;
        
        internal static global::net.sf.jni4net.jni.MethodId _Current1;
        
        internal static global::net.sf.jni4net.jni.MethodId _Reset2;
        
        internal static global::net.sf.jni4net.jni.MethodId _Key3;
        
        internal static global::net.sf.jni4net.jni.MethodId _Value4;
        
        internal static global::net.sf.jni4net.jni.MethodId _Entry5;
        
        private @__IDictionaryEnumerator(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public object Current {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionaryEnumerator._Current1));
            }
            }
        }
        
        public object Key {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionaryEnumerator._Key3));
            }
            }
        }
        
        public object Value {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionaryEnumerator._Value4));
            }
            }
        }
        
        public global::System.Collections.DictionaryEntry Entry {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Collections.DictionaryEntry>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionaryEnumerator._Entry5));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Collections.@__IDictionaryEnumerator.staticClass = @__class;
            global::System.Collections.@__IDictionaryEnumerator._MoveNext0 = @__env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "MoveNext", "()Z");
            global::System.Collections.@__IDictionaryEnumerator._Current1 = @__env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "getCurrent", "()Lsystem/Object;");
            global::System.Collections.@__IDictionaryEnumerator._Reset2 = @__env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "Reset", "()V");
            global::System.Collections.@__IDictionaryEnumerator._Key3 = @__env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "getKey", "()Lsystem/Object;");
            global::System.Collections.@__IDictionaryEnumerator._Value4 = @__env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "getValue", "()Lsystem/Object;");
            global::System.Collections.@__IDictionaryEnumerator._Entry5 = @__env.GetMethodID(global::System.Collections.@__IDictionaryEnumerator.staticClass, "getEntry", "()Lsystem/ValueType;");
        }
        
        public bool MoveNext() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::System.Collections.@__IDictionaryEnumerator._MoveNext0)));
            }
        }
        
        public void Reset() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::System.Collections.@__IDictionaryEnumerator._Reset2);
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IDictionaryEnumerator);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "MoveNext", "MoveNext0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrent", "Current1", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Reset", "Reset2", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKey", "Key3", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getValue", "Value4", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getEntry", "Entry5", "()Lsystem/ValueType;"));
            return methods;
        }
        
        private static bool MoveNext0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Collections.IDictionaryEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IDictionaryEnumerator>(@__env, @__obj);
            @__return = ((bool)(((global::System.Collections.IEnumerator)(@__real)).MoveNext()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Current1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Collections.IDictionaryEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IDictionaryEnumerator>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, ((global::System.Collections.IEnumerator)(@__real)).Current);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void Reset2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IDictionaryEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IDictionaryEnumerator>(@__env, @__obj);
            ((global::System.Collections.IEnumerator)(@__real)).Reset();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Key3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Collections.IDictionaryEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IDictionaryEnumerator>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.Key);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Value4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Collections.IDictionaryEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IDictionaryEnumerator>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.Value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Entry5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/ValueType;
            // ()LSystem/Collections/DictionaryEntry;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Collections.IDictionaryEnumerator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IDictionaryEnumerator>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Collections.DictionaryEntry>(@__env, @__real.Entry);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Collections.@__IDictionaryEnumerator(@__env);
            }
        }
    }
    #endregion
}
