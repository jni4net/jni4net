//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ServiceRegistry : global::org.drools.Service {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Ljava/lang/Object;")]
        global::java.lang.Object get(global::java.lang.Class par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;Ljava/util/concurrent/Callable;)V")]
        void registerLocator(global::java.lang.Class par0, global::java.lang.Object par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)V")]
        void unregisterLocator(global::java.lang.Class par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;Ljava/lang/String;)V")]
        void addDefault(global::java.lang.Class par0, global::java.lang.String par1);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ServiceRegistry_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.util.@__ServiceRegistry.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.util.ServiceRegistry), typeof(global::org.drools.util.ServiceRegistry_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.util.ServiceRegistry), typeof(global::org.drools.util.ServiceRegistry_))]
    internal sealed partial class @__ServiceRegistry : global::java.lang.Object, global::org.drools.util.ServiceRegistry {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _get0;
        
        internal static global::net.sf.jni4net.jni.MethodId _registerLocator1;
        
        internal static global::net.sf.jni4net.jni.MethodId _unregisterLocator2;
        
        internal static global::net.sf.jni4net.jni.MethodId _addDefault3;
        
        private @__ServiceRegistry(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.util.@__ServiceRegistry.staticClass = @__class;
            global::org.drools.util.@__ServiceRegistry._get0 = @__env.GetMethodID(global::org.drools.util.@__ServiceRegistry.staticClass, "get", "(Ljava/lang/Class;)Ljava/lang/Object;");
            global::org.drools.util.@__ServiceRegistry._registerLocator1 = @__env.GetMethodID(global::org.drools.util.@__ServiceRegistry.staticClass, "registerLocator", "(Ljava/lang/Class;Ljava/util/concurrent/Callable;)V");
            global::org.drools.util.@__ServiceRegistry._unregisterLocator2 = @__env.GetMethodID(global::org.drools.util.@__ServiceRegistry.staticClass, "unregisterLocator", "(Ljava/lang/Class;)V");
            global::org.drools.util.@__ServiceRegistry._addDefault3 = @__env.GetMethodID(global::org.drools.util.@__ServiceRegistry.staticClass, "addDefault", "(Ljava/lang/Class;Ljava/lang/String;)V");
        }
        
        public global::java.lang.Object get(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.util.@__ServiceRegistry._get0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public void registerLocator(global::java.lang.Class par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.util.@__ServiceRegistry._registerLocator1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
            }
        }
        
        public void unregisterLocator(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.util.@__ServiceRegistry._unregisterLocator2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        public void addDefault(global::java.lang.Class par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.util.@__ServiceRegistry._addDefault3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ServiceRegistry);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "get", "get0", "(Ljava/lang/Class;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "registerLocator", "registerLocator1", "(Ljava/lang/Class;Ljava/util/concurrent/Callable;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "unregisterLocator", "unregisterLocator2", "(Ljava/lang/Class;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addDefault", "addDefault3", "(Ljava/lang/Class;Ljava/lang/String;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle get0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Class;)Ljava/lang/Object;
            // (Ljava/lang/Class;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.util.ServiceRegistry @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.util.ServiceRegistry>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.get(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void registerLocator1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/Class;Ljava/util/concurrent/Callable;)V
            // (Ljava/lang/Class;Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.util.ServiceRegistry @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.util.ServiceRegistry>(@__env, @__obj);
            @__real.registerLocator(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void unregisterLocator2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Class;)V
            // (Ljava/lang/Class;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.util.ServiceRegistry @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.util.ServiceRegistry>(@__env, @__obj);
            @__real.unregisterLocator(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void addDefault3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/Class;Ljava/lang/String;)V
            // (Ljava/lang/Class;Ljava/lang/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.util.ServiceRegistry @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.util.ServiceRegistry>(@__env, @__obj);
            @__real.addDefault(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.util.@__ServiceRegistry(@__env);
            }
        }
    }
    #endregion
}
