//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.builder.conf {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface KnowledgeBuilderOption : global::org.drools.conf.Option {
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class KnowledgeBuilderOption_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.builder.conf.@__KnowledgeBuilderOption.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.builder.conf.KnowledgeBuilderOption), typeof(global::org.drools.builder.conf.KnowledgeBuilderOption_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.builder.conf.KnowledgeBuilderOption), typeof(global::org.drools.builder.conf.KnowledgeBuilderOption_))]
    internal sealed partial class @__KnowledgeBuilderOption : global::java.lang.Object, global::org.drools.builder.conf.KnowledgeBuilderOption {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPropertyName0;
        
        private @__KnowledgeBuilderOption(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.builder.conf.@__KnowledgeBuilderOption.staticClass = @__class;
            global::org.drools.builder.conf.@__KnowledgeBuilderOption._getPropertyName0 = @__env.GetMethodID(global::org.drools.builder.conf.@__KnowledgeBuilderOption.staticClass, "getPropertyName", "()Ljava/lang/String;");
        }
        
        public global::java.lang.String getPropertyName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.conf.@__KnowledgeBuilderOption._getPropertyName0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__KnowledgeBuilderOption);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getPropertyName", "getPropertyName0", "()Ljava/lang/String;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getPropertyName0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.conf.KnowledgeBuilderOption @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.conf.KnowledgeBuilderOption>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(((global::org.drools.conf.Option)(@__real)).getPropertyName());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.builder.conf.@__KnowledgeBuilderOption(@__env);
            }
        }
    }
    #endregion
}
