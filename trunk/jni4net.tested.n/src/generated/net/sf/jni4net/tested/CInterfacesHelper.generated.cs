//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    public unsafe partial class CInterfacesHelper_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.@__CInterfacesHelper.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.tested.CInterfacesHelper))]
    internal sealed unsafe partial class @__CInterfacesHelper : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__CInterfacesHelper(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::net.sf.jni4net.tested.@__CInterfacesHelper.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__CInterfacesHelper);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "createCWithJavaInterface", "createCWithJavaInterface0", "(I)Lnet/sf/jni4net/tested/CWithJavaInterface;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "CWithJavaInterfaceUnreg", "CWithJavaInterfaceUnreg1", "(I)Ljava/lang/Comparable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorCInterfacesHelper0", "__ctorCInterfacesHelper0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* createCWithJavaInterface0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int i) {
            // (I)Lnet/sf/jni4net/tested/CWithJavaInterface;
            // (I)Lnet/sf/jni4net/tested/CWithJavaInterface;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::net.sf.jni4net.tested.CInterfacesHelper real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::net.sf.jni4net.tested.CInterfacesHelper>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.createCWithJavaInterface(i));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* CWithJavaInterfaceUnreg1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int i) {
            // (I)Ljava/lang/Comparable;
            // (I)Lnet/sf/jni4net/tested/CWithJavaInterfaceUnreg;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::net.sf.jni4net.tested.CInterfacesHelper real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::net.sf.jni4net.tested.CInterfacesHelper>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.CWithJavaInterfaceUnreg(i));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static void @__ctorCInterfacesHelper0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::net.sf.jni4net.tested.CInterfacesHelper real = new global::net.sf.jni4net.tested.CInterfacesHelper();
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::net.sf.jni4net.tested.@__CInterfacesHelper(env);
            }
        }
    }
    #endregion
}
