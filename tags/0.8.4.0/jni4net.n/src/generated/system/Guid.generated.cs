//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class Guid_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.@__Guid.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Guid), typeof(global::System.Guid_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Guid), typeof(global::System.Guid_))]
    internal sealed partial class @__Guid : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__Guid(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__Guid.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Guid);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToString", "ToString0", "(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CompareTo", "CompareTo1", "(Lsystem/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CompareTo", "CompareTo2", "(Lsystem/Guid;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Equals", "Equals3", "(Lsystem/Guid;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToByteArray", "ToByteArray4", "()[B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "NewGuid", "NewGuid5", "()Lsystem/Guid;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToString", "ToString6", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorGuid0", "__ctorGuid0", "(Lnet/sf/jni4net/inj/IClrProxy;[B)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorGuid1", "__ctorGuid1", "(Lnet/sf/jni4net/inj/IClrProxy;ISSBBBBBBBB)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorGuid2", "__ctorGuid2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorGuid3", "__ctorGuid3", "(Lnet/sf/jni4net/inj/IClrProxy;ISS[B)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToString0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle format, global::net.sf.jni4net.utils.JniLocalHandle formatProvider) {
            // (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/String;LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Guid @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Guid>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, ((global::System.IFormattable)(@__real)).ToString(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, formatProvider)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int CompareTo1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle obj) {
            // (Lsystem/Object;)I
            // (LSystem/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.Guid @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Guid>(@__env, @__obj);
            @__return = ((int)(((global::System.IComparable)(@__real)).CompareTo(global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, obj))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int CompareTo2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle other) {
            // (Lsystem/Guid;)I
            // (LSystem/Guid;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.Guid @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Guid>(@__env, @__obj);
            @__return = ((int)(((global::System.IComparable<System.Guid>)(@__real)).CompareTo(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Guid>(@__env, other))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool Equals3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle other) {
            // (Lsystem/Guid;)Z
            // (LSystem/Guid;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Guid @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Guid>(@__env, @__obj);
            @__return = ((bool)(((global::System.IEquatable<System.Guid>)(@__real)).Equals(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Guid>(@__env, other))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToByteArray4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[B
            // ()[B
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Guid @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Guid>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayPrimC2J(@__env, @__real.ToByteArray());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle NewGuid5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class) {
            // ()Lsystem/Guid;
            // ()LSystem/Guid;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Guid>(@__env, global::System.Guid.NewGuid());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToString6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle format) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Guid @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Guid>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.ToString(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorGuid0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle b) {
            // ([B)V
            // ([B)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Guid @__real = new global::System.Guid(global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cbyte(@__env, b));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorGuid1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {
            // (ISSBBBBBBBB)V
            // (LSystem/UInt32;LSystem/UInt16;LSystem/UInt16;BBBBBBBB)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Guid @__real = new global::System.Guid(a, b, c, d, e, f, g, h, i, j, k);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorGuid2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle g) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Guid @__real = new global::System.Guid(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, g));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorGuid3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int a, short b, short c, global::net.sf.jni4net.utils.JniLocalHandle d) {
            // (ISS[B)V
            // (ISS[B)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Guid @__real = new global::System.Guid(a, b, c, global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cbyte(@__env, d));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__Guid(@__env);
            }
        }
    }
    #endregion
}
