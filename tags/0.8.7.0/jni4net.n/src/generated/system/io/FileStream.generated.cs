//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IO {
    
    
    #region Component Designer generated code 
    public partial class FileStream_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.IO.@__FileStream.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IO.FileStream), typeof(global::System.IO.FileStream_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IO.FileStream), typeof(global::System.IO.FileStream_))]
    internal sealed partial class @__FileStream : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__FileStream(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.IO.@__FileStream.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__FileStream);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isAsync", "IsAsync0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "Name1", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetAccessControl", "GetAccessControl2", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "SetAccessControl", "SetAccessControl3", "(Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getHandle", "Handle4", "()J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getSafeFileHandle", "SafeFileHandle5", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Lock", "Lock6", "(JJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Unlock", "Unlock7", "(JJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream0", "__ctorFileStream0", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream1", "__ctorFileStream1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream2", "__ctorFileStream2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream3", "__ctorFileStream3", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream4", "__ctorFileStream4", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;ILsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream5", "__ctorFileStream5", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;IZ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream6", "__ctorFileStream6", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;ILsystem/Enum;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream7", "__ctorFileStream7", "(Lnet/sf/jni4net/inj/IClrProxy;JLsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream8", "__ctorFileStream8", "(Lnet/sf/jni4net/inj/IClrProxy;JLsystem/Enum;Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream9", "__ctorFileStream9", "(Lnet/sf/jni4net/inj/IClrProxy;JLsystem/Enum;ZI)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream10", "__ctorFileStream10", "(Lnet/sf/jni4net/inj/IClrProxy;JLsystem/Enum;ZIZ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream11", "__ctorFileStream11", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/Object;Lsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream12", "__ctorFileStream12", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/Object;Lsystem/Enum;I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorFileStream13", "__ctorFileStream13", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/Object;Lsystem/Enum;IZ)V"));
            return methods;
        }
        
        private static bool IsAsync0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.IO.FileStream @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileStream>(@__env, @__obj);
            @__return = ((bool)(@__real.IsAsync));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Name1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.IO.FileStream @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileStream>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.Name);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetAccessControl2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Security/AccessControl/FileSecurity;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.IO.FileStream @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileStream>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Security.AccessControl.FileSecurity>(@__env, @__real.GetAccessControl());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void SetAccessControl3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle fileSecurity) {
            // (Lsystem/Object;)V
            // (LSystem/Security/AccessControl/FileSecurity;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileStream>(@__env, @__obj);
            @__real.SetAccessControl(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Security.AccessControl.FileSecurity>(@__env, fileSecurity));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::System.IntPtr Handle4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()LSystem/IntPtr;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::System.IntPtr @__return = default(global::System.IntPtr);
            try {
            global::System.IO.FileStream @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileStream>(@__env, @__obj);
            @__return = ((global::System.IntPtr)(@__real.Handle));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle SafeFileHandle5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LMicrosoft/Win32/SafeHandles/SafeFileHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.IO.FileStream @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileStream>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(@__env, @__real.SafeFileHandle);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void Lock6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, long position, long length) {
            // (JJ)V
            // (JJ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileStream>(@__env, @__obj);
            @__real.Lock(position, length);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Unlock7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, long position, long length) {
            // (JJ)V
            // (JJ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileStream>(@__env, @__obj);
            @__real.Unlock(position, length);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle path, global::net.sf.jni4net.utils.JniLocalHandle mode) {
            // (Ljava/lang/String;Lsystem/Enum;)V
            // (LSystem/String;LSystem/IO/FileMode;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, path), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileMode>(@__env, mode));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle path, global::net.sf.jni4net.utils.JniLocalHandle mode, global::net.sf.jni4net.utils.JniLocalHandle access) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, path), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileMode>(@__env, mode), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle path, global::net.sf.jni4net.utils.JniLocalHandle mode, global::net.sf.jni4net.utils.JniLocalHandle access, global::net.sf.jni4net.utils.JniLocalHandle share) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, path), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileMode>(@__env, mode), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileShare>(@__env, share));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle path, global::net.sf.jni4net.utils.JniLocalHandle mode, global::net.sf.jni4net.utils.JniLocalHandle access, global::net.sf.jni4net.utils.JniLocalHandle share, int bufferSize) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;I)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, path), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileMode>(@__env, mode), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileShare>(@__env, share), bufferSize);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle path, global::net.sf.jni4net.utils.JniLocalHandle mode, global::net.sf.jni4net.utils.JniLocalHandle access, global::net.sf.jni4net.utils.JniLocalHandle share, int bufferSize, global::net.sf.jni4net.utils.JniLocalHandle options) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;ILSystem/IO/FileOptions;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, path), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileMode>(@__env, mode), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileShare>(@__env, share), bufferSize, global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileOptions>(@__env, options));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle path, global::net.sf.jni4net.utils.JniLocalHandle mode, global::net.sf.jni4net.utils.JniLocalHandle access, global::net.sf.jni4net.utils.JniLocalHandle share, int bufferSize, bool useAsync) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;IZ)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;IZ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, path), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileMode>(@__env, mode), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileShare>(@__env, share), bufferSize, useAsync);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle path, global::net.sf.jni4net.utils.JniLocalHandle mode, global::net.sf.jni4net.utils.JniLocalHandle rights, global::net.sf.jni4net.utils.JniLocalHandle share, int bufferSize, global::net.sf.jni4net.utils.JniLocalHandle options, global::net.sf.jni4net.utils.JniLocalHandle fileSecurity) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;Lsystem/Object;)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/Security/AccessControl/FileSystemRights;LSystem/IO/FileShare;ILSystem/IO/FileOptions;LSystem/Security/AccessControl/FileSecurity;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, path), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileMode>(@__env, mode), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Security.AccessControl.FileSystemRights>(@__env, rights), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileShare>(@__env, share), bufferSize, global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileOptions>(@__env, options), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Security.AccessControl.FileSecurity>(@__env, fileSecurity));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::System.IntPtr handle, global::net.sf.jni4net.utils.JniLocalHandle access) {
            // (JLsystem/Enum;)V
            // (LSystem/IntPtr;LSystem/IO/FileAccess;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(handle, global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::System.IntPtr handle, global::net.sf.jni4net.utils.JniLocalHandle access, bool ownsHandle) {
            // (JLsystem/Enum;Z)V
            // (LSystem/IntPtr;LSystem/IO/FileAccess;Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(handle, global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), ownsHandle);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::System.IntPtr handle, global::net.sf.jni4net.utils.JniLocalHandle access, bool ownsHandle, int bufferSize) {
            // (JLsystem/Enum;ZI)V
            // (LSystem/IntPtr;LSystem/IO/FileAccess;ZI)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(handle, global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), ownsHandle, bufferSize);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::System.IntPtr handle, global::net.sf.jni4net.utils.JniLocalHandle access, bool ownsHandle, int bufferSize, bool isAsync) {
            // (JLsystem/Enum;ZIZ)V
            // (LSystem/IntPtr;LSystem/IO/FileAccess;ZIZ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(handle, global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), ownsHandle, bufferSize, isAsync);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle handle, global::net.sf.jni4net.utils.JniLocalHandle access) {
            // (Lsystem/Object;Lsystem/Enum;)V
            // (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(@__env, handle), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle handle, global::net.sf.jni4net.utils.JniLocalHandle access, int bufferSize) {
            // (Lsystem/Object;Lsystem/Enum;I)V
            // (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(@__env, handle), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), bufferSize);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorFileStream13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle handle, global::net.sf.jni4net.utils.JniLocalHandle access, int bufferSize, bool isAsync) {
            // (Lsystem/Object;Lsystem/Enum;IZ)V
            // (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;IZ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.FileStream @__real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(@__env, handle), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.FileAccess>(@__env, access), bufferSize, isAsync);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.IO.@__FileStream(@__env);
            }
        }
    }
    #endregion
}
