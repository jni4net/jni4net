//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public partial class ParameterInfo_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__ParameterInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.ParameterInfo))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.ParameterInfo))]
    internal sealed partial class @__ParameterInfo : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__ParameterInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Reflection.@__ParameterInfo.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ParameterInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes0", "(Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes1", "(Lsystem/Type;Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "IsDefined", "IsDefined2", "(Lsystem/Type;Z)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeInfo", "GetTypeInfo3", "(IIJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getParameterType", "ParameterType4", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "Name5", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDefaultValue", "DefaultValue6", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRawDefaultValue", "RawDefaultValue7", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getPosition", "Position8", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAttributes", "Attributes9", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMember", "Member10", "()Lsystem/reflection/MemberInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isIn", "IsIn11", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isOut", "IsOut12", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isLcid", "IsLcid13", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isRetval", "IsRetval14", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isOptional", "IsOptional15", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetadataToken", "MetadataToken16", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetRequiredCustomModifiers", "GetRequiredCustomModifiers17", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetOptionalCustomModifiers", "GetOptionalCustomModifiers18", "()[Lsystem/Type;"));
            return methods;
        }
        
        private static global::System.IntPtr GetCustomAttributes0(global::System.IntPtr @__envp, global::System.IntPtr @__obj, bool inherit) {
            // (Z)[Lsystem/Object;
            // (Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<object[], object>(@__env, ((global::System.Reflection.ICustomAttributeProvider)(@__real)).GetCustomAttributes(inherit));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetCustomAttributes1(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr attributeType, bool inherit) {
            // (Lsystem/Type;Z)[Lsystem/Object;
            // (LSystem/Type;Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<object[], object>(@__env, ((global::System.Reflection.ICustomAttributeProvider)(@__real)).GetCustomAttributes(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, attributeType), inherit));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool IsDefined2(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr attributeType, bool inherit) {
            // (Lsystem/Type;Z)Z
            // (LSystem/Type;Z)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(((global::System.Reflection.ICustomAttributeProvider)(@__real)).IsDefined(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, attributeType), inherit)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static void GetTypeInfo3(global::System.IntPtr @__envp, global::System.IntPtr @__obj, uint iTInfo, uint lcid, global::System.IntPtr ppTInfo) {
            // (IIJ)V
            // (LSystem/UInt32;LSystem/UInt32;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._ParameterInfo)(@__real)).GetTypeInfo(iTInfo, lcid, ppTInfo);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::System.IntPtr ParameterType4(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Type>(@__env, @__real.ParameterType);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Name5(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.Name);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr DefaultValue6(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.DefaultValue);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr RawDefaultValue7(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.RawDefaultValue);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static int Position8(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((int)(@__real.Position));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(int);
        }
        
        private static global::System.IntPtr Attributes9(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/ParameterAttributes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.ParameterAttributes>(@__env, @__real.Attributes);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Member10(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/reflection/MemberInfo;
            // ()LSystem/Reflection/MemberInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MemberInfo>(@__env, @__real.Member);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool IsIn11(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsIn));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static bool IsOut12(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsOut));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static bool IsLcid13(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsLcid));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static bool IsRetval14(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsRetval));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static bool IsOptional15(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsOptional));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static int MetadataToken16(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((int)(@__real.MetadataToken));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(int);
        }
        
        private static global::System.IntPtr GetRequiredCustomModifiers17(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<System.Type[], global::System.Type>(@__env, @__real.GetRequiredCustomModifiers());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetOptionalCustomModifiers18(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<System.Type[], global::System.Type>(@__env, @__real.GetOptionalCustomModifiers());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__ParameterInfo(@__env);
            }
        }
    }
    #endregion
}
