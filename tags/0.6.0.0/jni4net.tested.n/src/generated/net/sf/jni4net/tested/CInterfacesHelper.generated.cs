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
    public partial class CInterfacesHelper_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.@__CInterfacesHelper.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.jni4net.tested.CInterfacesHelper))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.tested.CInterfacesHelper))]
    internal sealed partial class @__CInterfacesHelper : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__CInterfacesHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.@__CInterfacesHelper.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__CInterfacesHelper);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "createCWithJavaInterface", "createCWithJavaInterface0", "(I)Lnet/sf/jni4net/tested/CWithJavaInterface;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CWithJavaInterfaceUnreg", "CWithJavaInterfaceUnreg1", "(I)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorCInterfacesHelper0", "__ctorCInterfacesHelper0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle createCWithJavaInterface0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int i) {
            // (I)Lnet/sf/jni4net/tested/CWithJavaInterface;
            // (I)Lnet/sf/jni4net/tested/CWithJavaInterface;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.jni4net.tested.CInterfacesHelper @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CInterfacesHelper>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__real.createCWithJavaInterface(i));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CWithJavaInterfaceUnreg1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int i) {
            // (I)Lsystem/Object;
            // (I)Lnet/sf/jni4net/tested/CWithJavaInterfaceUnreg;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.jni4net.tested.CInterfacesHelper @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CInterfacesHelper>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::net.sf.jni4net.tested.CWithJavaInterfaceUnreg>(@__env, @__real.CWithJavaInterfaceUnreg(i));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorCInterfacesHelper0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CInterfacesHelper @__real = new global::net.sf.jni4net.tested.CInterfacesHelper();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.@__CInterfacesHelper(@__env);
            }
        }
    }
    #endregion
}
