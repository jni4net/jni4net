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
    public partial class IComparable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__IComparable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IComparable))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IComparable))]
    internal sealed partial class @__IComparable : global::java.lang.Object, global::System.IComparable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _CompareTo0;
        
        protected @__IComparable(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__IComparable.staticClass = staticClass;
            global::System.@__IComparable._CompareTo0 = env.GetMethodID(global::System.@__IComparable.staticClass, "CompareTo", "(Lsystem/Object;)I");
        }
        
        public int CompareTo(object obj) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::System.@__IComparable._CompareTo0, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, obj));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IComparable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "CompareTo", "CompareTo0", "(Lsystem/Object;)I"));
            return methods;
        }
        
        private static int CompareTo0(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr obj) {
            // (Lsystem/Object;)I
            // (LSystem/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IComparable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IComparable>(__env, @__obj);
            return real.CompareTo(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, obj));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__IComparable(env);
            }
        }
    }
    #endregion
}
