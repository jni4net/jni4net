//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.builder {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface JaxbConfiguration : global::org.drools.builder.ResourceConfiguration {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/List;")]
        global::java.util.List getClasses();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lcom/sun/tools/xjc/Options;")]
        global::java.lang.Object getXjcOpts();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getSystemId();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class JaxbConfiguration_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.builder.@__JaxbConfiguration.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.builder.JaxbConfiguration), typeof(global::org.drools.builder.JaxbConfiguration_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.builder.JaxbConfiguration), typeof(global::org.drools.builder.JaxbConfiguration_))]
    internal sealed partial class @__JaxbConfiguration : global::java.lang.Object, global::org.drools.builder.JaxbConfiguration {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClasses0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getXjcOpts1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSystemId2;
        
        private @__JaxbConfiguration(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.builder.@__JaxbConfiguration.staticClass = @__class;
            global::org.drools.builder.@__JaxbConfiguration._getClasses0 = @__env.GetMethodID(global::org.drools.builder.@__JaxbConfiguration.staticClass, "getClasses", "()Ljava/util/List;");
            global::org.drools.builder.@__JaxbConfiguration._getXjcOpts1 = @__env.GetMethodID(global::org.drools.builder.@__JaxbConfiguration.staticClass, "getXjcOpts", "()Lcom/sun/tools/xjc/Options;");
            global::org.drools.builder.@__JaxbConfiguration._getSystemId2 = @__env.GetMethodID(global::org.drools.builder.@__JaxbConfiguration.staticClass, "getSystemId", "()Ljava/lang/String;");
        }
        
        public global::java.util.List getClasses() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__JaxbConfiguration._getClasses0));
            }
        }
        
        public global::java.lang.Object getXjcOpts() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__JaxbConfiguration._getXjcOpts1));
            }
        }
        
        public global::java.lang.String getSystemId() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__JaxbConfiguration._getSystemId2));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__JaxbConfiguration);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getClasses", "getClasses0", "()Ljava/util/List;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getXjcOpts", "getXjcOpts1", "()Lcom/sun/tools/xjc/Options;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getSystemId", "getSystemId2", "()Ljava/lang/String;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getClasses0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/List;
            // ()Ljava/util/List;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.JaxbConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.JaxbConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.List>(@__env, @__real.getClasses());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getXjcOpts1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lcom/sun/tools/xjc/Options;
            // ()Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.JaxbConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.JaxbConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getXjcOpts());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getSystemId2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.JaxbConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.JaxbConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getSystemId());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.builder.@__JaxbConfiguration(@__env);
            }
        }
    }
    #endregion
}
