namespace Mitza.Jni4Net {

    public partial class KeyValuePair_ {

        public static global::java.lang.Class _class {
            get {
                return global::Mitza.Jni4Net.@__KeyValuePair.staticClass;
            }
        }
    }

    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::Mitza.Jni4Net.Wrapper.KeyValuePair), typeof(global::Mitza.Jni4Net.KeyValuePair_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::Mitza.Jni4Net.Wrapper.KeyValuePair), typeof(global::Mitza.Jni4Net.KeyValuePair_))]
    internal sealed partial class @__KeyValuePair : global::java.lang.Object {

        internal new static global::java.lang.Class staticClass;

        private @__KeyValuePair(global::net.sf.jni4net.jni.JNIEnv @__env) :
            base(@__env) {
        }

        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::Mitza.Jni4Net.@__KeyValuePair.staticClass = @__class;
        }

        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__KeyValuePair);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKey", "Key0", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setKey", "Key1", "(Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getValue", "Value2", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setValue", "Value3", "(Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorKeyValuePair0", "__ctorKeyValuePair0", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/Object;Lsystem/Object;)V"));
            return methods;
        }

        private static global::net.sf.jni4net.utils.JniHandle Key0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
                global::Mitza.Jni4Net.Wrapper.KeyValuePair @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Mitza.Jni4Net.Wrapper.KeyValuePair>(@__env, @__obj);
                @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.Key);
            } catch (global::System.Exception __ex) { @__env.ThrowExisting(__ex); }
            return @__return;
        }

        private static void Key1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Object;)V
            // (LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
                global::Mitza.Jni4Net.Wrapper.KeyValuePair @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Mitza.Jni4Net.Wrapper.KeyValuePair>(@__env, @__obj);
                @__real.Key = global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value);
            } catch (global::System.Exception __ex) { @__env.ThrowExisting(__ex); }
        }

        private static global::net.sf.jni4net.utils.JniHandle Value2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
                global::Mitza.Jni4Net.Wrapper.KeyValuePair @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Mitza.Jni4Net.Wrapper.KeyValuePair>(@__env, @__obj);
                @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.Value);
            } catch (global::System.Exception __ex) { @__env.ThrowExisting(__ex); }
            return @__return;
        }

        private static global::net.sf.jni4net.utils.JniHandle Value3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Object;)V
            // (LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
                global::Mitza.Jni4Net.Wrapper.KeyValuePair @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Mitza.Jni4Net.Wrapper.KeyValuePair>(@__env, @__obj);
                @__real.Value = global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value);
                @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.Value);
            } catch (global::System.Exception __ex) { @__env.ThrowExisting(__ex); }
            return @__return;
        }

        private static void @__ctorKeyValuePair0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle key, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Object;Lsystem/Object;)V
            // (LSystem/Object;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
                global::Mitza.Jni4Net.Wrapper.KeyValuePair @__real = new global::Mitza.Jni4Net.Wrapper.KeyValuePair(global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, key), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value));
                global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            } catch (global::System.Exception __ex) { @__env.ThrowExisting(__ex); }
        }

        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {

            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::Mitza.Jni4Net.@__KeyValuePair(@__env);
            }
        }
    }
}
