//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    public partial class CIfcImpl_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.@__CIfcImpl.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.jni4net.tested.CIfcImpl))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.tested.CIfcImpl))]
    internal sealed partial class @__CIfcImpl : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__CIfcImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.@__CIfcImpl.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__CIfcImpl);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getintProp", "intProp0", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setintProp", "intProp1", "(I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getfcePtr", "fcePtr2", "()Lnet/sf/jni4net/tested/TestDelegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setfcePtr", "fcePtr3", "(Lnet/sf/jni4net/tested/TestDelegate;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addEnvDispatcher", "EnvDispatcher4", "(Lnet/sf/jni4net/tested/TestDelegate;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeEnvDispatcher", "EnvDispatcher5", "(Lnet/sf/jni4net/tested/TestDelegate;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "RunPtr", "RunPtr6", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "RunEvnt", "RunEvnt7", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorCIfcImpl0", "__ctorCIfcImpl0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static int intProp0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CIfcImpl>(@__env, @__obj);
            @__return = ((int)(((global::net.sf.jni4net.tested.ICInterface)(@__real)).intProp));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void intProp1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CIfcImpl>(@__env, @__obj);
            ((global::net.sf.jni4net.tested.ICInterface)(@__real)).intProp = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle fcePtr2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lnet/sf/jni4net/tested/TestDelegate;
            // ()Lnet/sf/jni4net/tested/TestDelegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CIfcImpl>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::net.sf.jni4net.tested.TestDelegate>(@__env, ((global::net.sf.jni4net.tested.ICInterface)(@__real)).fcePtr);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void fcePtr3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lnet/sf/jni4net/tested/TestDelegate;)V
            // (Lnet/sf/jni4net/tested/TestDelegate;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CIfcImpl>(@__env, @__obj);
            ((global::net.sf.jni4net.tested.ICInterface)(@__real)).fcePtr = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.TestDelegate>(@__env, value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void EnvDispatcher4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lnet/sf/jni4net/tested/TestDelegate;)V
            // (Lnet/sf/jni4net/tested/TestDelegate;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CIfcImpl>(@__env, @__obj);
            ((global::net.sf.jni4net.tested.ICInterface)(@__real)).EnvDispatcher += global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.TestDelegate>(@__env, value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void EnvDispatcher5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lnet/sf/jni4net/tested/TestDelegate;)V
            // (Lnet/sf/jni4net/tested/TestDelegate;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CIfcImpl>(@__env, @__obj);
            ((global::net.sf.jni4net.tested.ICInterface)(@__real)).EnvDispatcher -= global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.TestDelegate>(@__env, value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle RunPtr6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CIfcImpl>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.RunPtr());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle RunEvnt7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CIfcImpl>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.RunEvnt());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorCIfcImpl0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CIfcImpl @__real = new global::net.sf.jni4net.tested.CIfcImpl();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.@__CIfcImpl(@__env);
            }
        }
    }
    #endregion
}
