//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class Enum_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.@__Enum.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Enum), typeof(global::System.Enum_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Enum), typeof(global::System.Enum_))]
    internal sealed partial class @__Enum : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__Enum(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__Enum.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Enum);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CompareTo", "CompareTo0", "(Lsystem/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToString", "ToString1", "(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeCode", "GetTypeCode2", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToBoolean", "ToBoolean3", "(Lsystem/IFormatProvider;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToChar", "ToChar4", "(Lsystem/IFormatProvider;)C"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToSByte", "ToSByte5", "(Lsystem/IFormatProvider;)B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToByte", "ToByte6", "(Lsystem/IFormatProvider;)B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToInt16", "ToInt167", "(Lsystem/IFormatProvider;)S"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToUInt16", "ToUInt168", "(Lsystem/IFormatProvider;)S"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToInt32", "ToInt329", "(Lsystem/IFormatProvider;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToUInt32", "ToUInt3210", "(Lsystem/IFormatProvider;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToInt64", "ToInt6411", "(Lsystem/IFormatProvider;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToUInt64", "ToUInt6412", "(Lsystem/IFormatProvider;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToSingle", "ToSingle13", "(Lsystem/IFormatProvider;)F"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToDouble", "ToDouble14", "(Lsystem/IFormatProvider;)D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToDecimal", "ToDecimal15", "(Lsystem/IFormatProvider;)Lsystem/Decimal;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToDateTime", "ToDateTime16", "(Lsystem/IFormatProvider;)Lsystem/DateTime;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToString", "ToString17", "(Lsystem/IFormatProvider;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToType", "ToType18", "(Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Parse", "Parse19", "(Lsystem/Type;Ljava/lang/String;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Parse", "Parse20", "(Lsystem/Type;Ljava/lang/String;Z)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetUnderlyingType", "GetUnderlyingType21", "(Lsystem/Type;)Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetValues", "GetValues22", "(Lsystem/Type;)Lsystem/Array;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetName", "GetName23", "(Lsystem/Type;Lsystem/Object;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetNames", "GetNames24", "(Lsystem/Type;)[Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToObject", "ToObject25", "(Lsystem/Type;Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "IsDefined", "IsDefined26", "(Lsystem/Type;Lsystem/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Format", "Format27", "(Lsystem/Type;Lsystem/Object;Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToString", "ToString28", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToObject", "ToObject29", "(Lsystem/Type;B)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToObject", "ToObject30", "(Lsystem/Type;S)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToObject", "ToObject31", "(Lsystem/Type;I)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToObject", "ToObject32", "(Lsystem/Type;J)Lsystem/Object;"));
            return methods;
        }
        
        private static int CompareTo0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle obj) {
            // (Lsystem/Object;)I
            // (LSystem/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((int)(((global::System.IComparable)(@__real)).CompareTo(global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, obj))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToString1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle format, global::net.sf.jni4net.utils.JniLocalHandle formatProvider) {
            // (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/String;LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, ((global::System.IFormattable)(@__real)).ToString(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, formatProvider)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetTypeCode2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/TypeCode;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.TypeCode>(@__env, ((global::System.IConvertible)(@__real)).GetTypeCode());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool ToBoolean3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)Z
            // (LSystem/IFormatProvider;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((bool)(((global::System.IConvertible)(@__real)).ToBoolean(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static char ToChar4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)C
            // (LSystem/IFormatProvider;)C
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            char @__return = default(char);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((char)(((global::System.IConvertible)(@__real)).ToChar(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static sbyte ToSByte5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)B
            // (LSystem/IFormatProvider;)LSystem/SByte;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            sbyte @__return = default(sbyte);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((sbyte)(((global::System.IConvertible)(@__real)).ToSByte(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static byte ToByte6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)B
            // (LSystem/IFormatProvider;)B
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            byte @__return = default(byte);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((byte)(((global::System.IConvertible)(@__real)).ToByte(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static short ToInt167(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)S
            // (LSystem/IFormatProvider;)S
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            short @__return = default(short);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((short)(((global::System.IConvertible)(@__real)).ToInt16(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static ushort ToUInt168(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)S
            // (LSystem/IFormatProvider;)LSystem/UInt16;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            ushort @__return = default(ushort);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((ushort)(((global::System.IConvertible)(@__real)).ToUInt16(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int ToInt329(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)I
            // (LSystem/IFormatProvider;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((int)(((global::System.IConvertible)(@__real)).ToInt32(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static uint ToUInt3210(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)I
            // (LSystem/IFormatProvider;)LSystem/UInt32;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            uint @__return = default(uint);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((uint)(((global::System.IConvertible)(@__real)).ToUInt32(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static long ToInt6411(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)J
            // (LSystem/IFormatProvider;)J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((long)(((global::System.IConvertible)(@__real)).ToInt64(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static ulong ToUInt6412(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)J
            // (LSystem/IFormatProvider;)LSystem/UInt64;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            ulong @__return = default(ulong);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((ulong)(((global::System.IConvertible)(@__real)).ToUInt64(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static float ToSingle13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)F
            // (LSystem/IFormatProvider;)F
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            float @__return = default(float);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((float)(((global::System.IConvertible)(@__real)).ToSingle(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double ToDouble14(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)D
            // (LSystem/IFormatProvider;)D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = ((double)(((global::System.IConvertible)(@__real)).ToDouble(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToDecimal15(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)Lsystem/Decimal;
            // (LSystem/IFormatProvider;)LSystem/Decimal;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<decimal>(@__env, ((global::System.IConvertible)(@__real)).ToDecimal(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToDateTime16(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)Lsystem/DateTime;
            // (LSystem/IFormatProvider;)LSystem/DateTime;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.DateTime>(@__env, ((global::System.IConvertible)(@__real)).ToDateTime(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToString17(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, ((global::System.IConvertible)(@__real)).ToString(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToType18(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle conversionType, global::net.sf.jni4net.utils.JniLocalHandle provider) {
            // (Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;
            // (LSystem/Type;LSystem/IFormatProvider;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, ((global::System.IConvertible)(@__real)).ToType(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, conversionType), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IFormatProvider>(@__env, provider)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Parse19(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Type;Ljava/lang/String;)Lsystem/Object;
            // (LSystem/Type;LSystem/String;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::System.Enum.Parse(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, value)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Parse20(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, global::net.sf.jni4net.utils.JniLocalHandle value, bool ignoreCase) {
            // (Lsystem/Type;Ljava/lang/String;Z)Lsystem/Object;
            // (LSystem/Type;LSystem/String;Z)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::System.Enum.Parse(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, value), ignoreCase));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetUnderlyingType21(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType) {
            // (Lsystem/Type;)Lsystem/Type;
            // (LSystem/Type;)LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Type>(@__env, global::System.Enum.GetUnderlyingType(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetValues22(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType) {
            // (Lsystem/Type;)Lsystem/Array;
            // (LSystem/Type;)LSystem/Array;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Array>(@__env, global::System.Enum.GetValues(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetName23(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Type;Lsystem/Object;)Ljava/lang/String;
            // (LSystem/Type;LSystem/Object;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, global::System.Enum.GetName(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetNames24(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType) {
            // (Lsystem/Type;)[Ljava/lang/String;
            // (LSystem/Type;)[LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongC2JString(@__env, global::System.Enum.GetNames(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToObject25(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Type;Lsystem/Object;)Lsystem/Object;
            // (LSystem/Type;LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsDefined26(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Type;Lsystem/Object;)Z
            // (LSystem/Type;LSystem/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            @__return = ((bool)(global::System.Enum.IsDefined(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Format27(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, global::net.sf.jni4net.utils.JniLocalHandle value, global::net.sf.jni4net.utils.JniLocalHandle format) {
            // (Lsystem/Type;Lsystem/Object;Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/Type;LSystem/Object;LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, global::System.Enum.Format(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToString28(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle format) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Enum @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Enum>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.ToString(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToObject29(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, sbyte value) {
            // (Lsystem/Type;B)Lsystem/Object;
            // (LSystem/Type;LSystem/SByte;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToObject30(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, short value) {
            // (Lsystem/Type;S)Lsystem/Object;
            // (LSystem/Type;S)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToObject31(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, int value) {
            // (Lsystem/Type;I)Lsystem/Object;
            // (LSystem/Type;I)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ToObject32(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle enumType, long value) {
            // (Lsystem/Type;J)Lsystem/Object;
            // (LSystem/Type;J)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, enumType), value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__Enum(@__env);
            }
        }
    }
    #endregion
}
