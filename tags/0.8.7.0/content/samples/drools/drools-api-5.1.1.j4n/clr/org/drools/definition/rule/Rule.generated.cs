//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.definition.rule {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Rule : global::org.drools.definition.KnowledgeDefinition {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getName();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getPackageName();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        global::java.util.Map getMetaData();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Collection;")]
        global::java.util.Collection listMetaAttributes();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        global::java.util.Map getMetaAttributes();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        global::java.lang.String getMetaAttribute(global::java.lang.String par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Rule_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.definition.rule.@__Rule.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.definition.rule.Rule), typeof(global::org.drools.definition.rule.Rule_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.definition.rule.Rule), typeof(global::org.drools.definition.rule.Rule_))]
    internal sealed partial class @__Rule : global::java.lang.Object, global::org.drools.definition.rule.Rule {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPackageName1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMetaData2;
        
        internal static global::net.sf.jni4net.jni.MethodId _listMetaAttributes3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMetaAttributes4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMetaAttribute5;
        
        private @__Rule(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.definition.rule.@__Rule.staticClass = @__class;
            global::org.drools.definition.rule.@__Rule._getName0 = @__env.GetMethodID(global::org.drools.definition.rule.@__Rule.staticClass, "getName", "()Ljava/lang/String;");
            global::org.drools.definition.rule.@__Rule._getPackageName1 = @__env.GetMethodID(global::org.drools.definition.rule.@__Rule.staticClass, "getPackageName", "()Ljava/lang/String;");
            global::org.drools.definition.rule.@__Rule._getMetaData2 = @__env.GetMethodID(global::org.drools.definition.rule.@__Rule.staticClass, "getMetaData", "()Ljava/util/Map;");
            global::org.drools.definition.rule.@__Rule._listMetaAttributes3 = @__env.GetMethodID(global::org.drools.definition.rule.@__Rule.staticClass, "listMetaAttributes", "()Ljava/util/Collection;");
            global::org.drools.definition.rule.@__Rule._getMetaAttributes4 = @__env.GetMethodID(global::org.drools.definition.rule.@__Rule.staticClass, "getMetaAttributes", "()Ljava/util/Map;");
            global::org.drools.definition.rule.@__Rule._getMetaAttribute5 = @__env.GetMethodID(global::org.drools.definition.rule.@__Rule.staticClass, "getMetaAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
        }
        
        public global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.rule.@__Rule._getName0));
            }
        }
        
        public global::java.lang.String getPackageName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.rule.@__Rule._getPackageName1));
            }
        }
        
        public global::java.util.Map getMetaData() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.rule.@__Rule._getMetaData2));
            }
        }
        
        public global::java.util.Collection listMetaAttributes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.rule.@__Rule._listMetaAttributes3));
            }
        }
        
        public global::java.util.Map getMetaAttributes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.rule.@__Rule._getMetaAttributes4));
            }
        }
        
        public global::java.lang.String getMetaAttribute(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.definition.rule.@__Rule._getMetaAttribute5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Rule);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "getName0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getPackageName", "getPackageName1", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetaData", "getMetaData2", "()Ljava/util/Map;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "listMetaAttributes", "listMetaAttributes3", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetaAttributes", "getMetaAttributes4", "()Ljava/util/Map;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetaAttribute", "getMetaAttribute5", "(Ljava/lang/String;)Ljava/lang/String;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getName0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.rule.Rule @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.rule.Rule>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getName());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getPackageName1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.rule.Rule @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.rule.Rule>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getPackageName());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getMetaData2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Map;
            // ()Ljava/util/Map;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.rule.Rule @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.rule.Rule>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Map>(@__env, @__real.getMetaData());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle listMetaAttributes3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.rule.Rule @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.rule.Rule>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, @__real.listMetaAttributes());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getMetaAttributes4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Map;
            // ()Ljava/util/Map;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.rule.Rule @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.rule.Rule>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Map>(@__env, @__real.getMetaAttributes());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getMetaAttribute5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (Ljava/lang/String;)Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.definition.rule.Rule @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.rule.Rule>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getMetaAttribute(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.definition.rule.@__Rule(@__env);
            }
        }
    }
    #endregion
}
