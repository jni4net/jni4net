//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class IFormatProvider_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.@__IFormatProvider.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IFormatProvider), typeof(global::System.IFormatProvider_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IFormatProvider), typeof(global::System.IFormatProvider_))]
    internal sealed partial class @__IFormatProvider : global::java.lang.Object, global::System.IFormatProvider {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetFormat0;
        
        private @__IFormatProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__IFormatProvider.staticClass = @__class;
            global::System.@__IFormatProvider._GetFormat0 = @__env.GetMethodID(global::System.@__IFormatProvider.staticClass, "GetFormat", "(Lsystem/Type;)Lsystem/Object;");
        }
        
        public object GetFormat(global::System.Type formatType) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IFormatProvider._GetFormat0, global::net.sf.jni4net.utils.Convertor.ParStrongC2Jp<global::System.Type>(@__env, formatType)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IFormatProvider);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetFormat", "GetFormat0", "(Lsystem/Type;)Lsystem/Object;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetFormat0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle formatType) {
            // (Lsystem/Type;)Lsystem/Object;
            // (LSystem/Type;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.IFormatProvider @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.GetFormat(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, formatType)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__IFormatProvider(@__env);
            }
        }
    }
    #endregion
}
