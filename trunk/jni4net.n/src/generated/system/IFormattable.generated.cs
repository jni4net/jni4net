//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class IFormattable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__IFormattable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IFormattable))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IFormattable))]
    internal sealed partial class @__IFormattable : global::java.lang.Object, global::System.IFormattable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToString0;
        
        protected @__IFormattable(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__IFormattable.staticClass = @__class;
            global::System.@__IFormattable._ToString0 = @__env.GetMethodID(global::System.@__IFormattable.staticClass, "ToString", "(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;");
        }
        
        public string ToString(string format, global::System.IFormatProvider formatProvider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String, string>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IFormattable._ToString0, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, format), global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, formatProvider)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IFormattable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToString", "ToString0", "(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;"));
            return methods;
        }
        
        private static global::System.IntPtr ToString0(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr formatProvider) {
            // (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/String;LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IFormattable @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormattable>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::java.lang.String, string>(@__env, @__real.ToString(global::net.sf.jni4net.utils.Convertor.J2C<string>(@__env, format), global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, formatProvider)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__IFormattable(@__env);
            }
        }
    }
    #endregion
}
