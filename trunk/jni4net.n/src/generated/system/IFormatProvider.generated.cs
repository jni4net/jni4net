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
    public unsafe partial class IFormatProvider_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__IFormatProvider.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IFormatProvider))]
    internal sealed unsafe partial class @__IFormatProvider : global::java.lang.Object, global::System.IFormatProvider {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetFormat0;
        
        protected @__IFormatProvider(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__IFormatProvider.staticClass = staticClass;
            global::System.@__IFormatProvider._GetFormat0 = env.GetMethodID(global::System.@__IFormatProvider.staticClass, "GetFormat", "(Lsystem/Type;)Lsystem/Object;");
        }
        
        public object GetFormat(global::System.Type formatType) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::System.@__IFormatProvider._GetFormat0, new global::net.sf.jni4net.jni.Value(formatType)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IFormatProvider);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetFormat", "GetFormat0", "(Lsystem/Type;)Lsystem/Object;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* GetFormat0(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* formatType) {
            // (Lsystem/Type;)Lsystem/Object;
            // (LSystem/Type;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IFormatProvider real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetFormat(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, formatType)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__IFormatProvider(env);
            }
        }
    }
    #endregion
}
