//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
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
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getParameterType", "ParameterType3", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "Name4", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDefaultValue", "DefaultValue5", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRawDefaultValue", "RawDefaultValue6", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getPosition", "Position7", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAttributes", "Attributes8", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMember", "Member9", "()Lsystem/reflection/MemberInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isIn", "IsIn10", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isOut", "IsOut11", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isLcid", "IsLcid12", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isRetval", "IsRetval13", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isOptional", "IsOptional14", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetadataToken", "MetadataToken15", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetRequiredCustomModifiers", "GetRequiredCustomModifiers16", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetOptionalCustomModifiers", "GetOptionalCustomModifiers17", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeInfo", "GetTypeInfo18", "(IILsystem/ValueType;)V"));
            return methods;
        }
        
        private static global::System.IntPtr GetCustomAttributes0(global::System.IntPtr @__envp, global::System.IntPtr @__obj, bool inherit) {
            // (Z)[Lsystem/Object;
            // (Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<object[], object>(@__env, ((global::System.Reflection.ICustomAttributeProvider)(@__real)).GetCustomAttributes(inherit));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetCustomAttributes1(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr attributeType, bool inherit) {
            // (Lsystem/Type;Z)[Lsystem/Object;
            // (LSystem/Type;Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<object[], object>(@__env, ((global::System.Reflection.ICustomAttributeProvider)(@__real)).GetCustomAttributes(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, attributeType), inherit));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool IsDefined2(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr attributeType, bool inherit) {
            // (Lsystem/Type;Z)Z
            // (LSystem/Type;Z)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(((global::System.Reflection.ICustomAttributeProvider)(@__real)).IsDefined(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, attributeType), inherit)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::System.IntPtr ParameterType3(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Type>(@__env, @__real.ParameterType);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Name4(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.Name);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr DefaultValue5(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.DefaultValue);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr RawDefaultValue6(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.RawDefaultValue);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static int Position7(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((int)(@__real.Position));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr Attributes8(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/ParameterAttributes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.ParameterAttributes>(@__env, @__real.Attributes);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Member9(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/reflection/MemberInfo;
            // ()LSystem/Reflection/MemberInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MemberInfo>(@__env, @__real.Member);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool IsIn10(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsIn));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsOut11(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsOut));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsLcid12(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsLcid));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsRetval13(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsRetval));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsOptional14(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((bool)(@__real.IsOptional));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static int MetadataToken15(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return ((int)(@__real.MetadataToken));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr GetRequiredCustomModifiers16(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<System.Type[], global::System.Type>(@__env, @__real.GetRequiredCustomModifiers());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetOptionalCustomModifiers17(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<System.Type[], global::System.Type>(@__env, @__real.GetOptionalCustomModifiers());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void GetTypeInfo18(global::System.IntPtr @__envp, global::System.IntPtr @__obj, uint iTInfo, uint lcid, global::System.IntPtr ppTInfo) {
            // (IILsystem/ValueType;)V
            // (LSystem/UInt32;LSystem/UInt32;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ParameterInfo @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.ParameterInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._ParameterInfo)(@__real)).GetTypeInfo(iTInfo, lcid, ppTInfo);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__ParameterInfo(@__env);
            }
        }
    }
    #endregion
}
