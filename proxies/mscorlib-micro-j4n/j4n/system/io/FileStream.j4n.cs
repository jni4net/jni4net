// This code was generated using jni4net. See http://jni4net.sourceforge.net/

#region Component Designer generated code
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantCast
// ReSharper disable RedundantCommaInArrayInitializer
// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable UnassignedField.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable SuggestUseVarKeywordEvident
// ReSharper disable PossibleMultipleEnumeration
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedMember.Global
#pragma warning disable 109
#pragma warning disable 649
#pragma warning disable 618

namespace System.IO
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.IO.FileStream_))]
    static public partial class FileStream_
    {
        static FileStream_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IO.Stream_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.IO.FileStream_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor(Lsystem/IDisposable;Lsystem/Enum;)V (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;)V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr handle, global::System.IntPtr access)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(j4n_env, handle), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileAccess>(j4n_env, access)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 .ctor(Lsystem/IDisposable;Lsystem/Enum;I)V (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;I)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr handle, global::System.IntPtr access, int bufferSize)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(j4n_env, handle), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileAccess>(j4n_env, access), bufferSize));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#2 .ctor(Lsystem/IDisposable;Lsystem/Enum;IZ)V (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;IZ)V</signature>
        static long j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr handle, global::System.IntPtr access, int bufferSize, bool isAsync)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(j4n_env, handle), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileAccess>(j4n_env, access), bufferSize, isAsync));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 .ctor(Ljava/lang/String;Lsystem/Enum;)V (Lsystem/String;LSystem/IO/FileMode;)V</signature>
        static long j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr path, global::System.IntPtr mode)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileMode>(j4n_env, mode)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#4 .ctor(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;)V (Lsystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;)V</signature>
        static long j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileMode>(j4n_env, mode), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileAccess>(j4n_env, access)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#5 .ctor(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;)V (Lsystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;)V</signature>
        static long j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access, global::System.IntPtr share)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileMode>(j4n_env, mode), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileAccess>(j4n_env, access), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileShare>(j4n_env, share)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#6 .ctor(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;I)V (Lsystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;I)V</signature>
        static long j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access, global::System.IntPtr share, int bufferSize)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileMode>(j4n_env, mode), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileAccess>(j4n_env, access), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileShare>(j4n_env, share), bufferSize));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#7 .ctor(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;IZ)V (Lsystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;IZ)V</signature>
        static long j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access, global::System.IntPtr share, int bufferSize, bool useAsync)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileMode>(j4n_env, mode), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileAccess>(j4n_env, access), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileShare>(j4n_env, share), bufferSize, useAsync));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#8 .ctor(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;)V (Lsystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;ILSystem/IO/FileOptions;)V</signature>
        static long j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access, global::System.IntPtr share, int bufferSize, global::System.IntPtr options)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileMode>(j4n_env, mode), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileAccess>(j4n_env, access), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileShare>(j4n_env, share), bufferSize, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileOptions>(j4n_env, options)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#9 .ctor(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;)V (Lsystem/String;LSystem/IO/FileMode;LSystem/Security/AccessControl/FileSystemRights;LSystem/IO/FileShare;ILSystem/IO/FileOptions;)V</signature>
        static long j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr rights, global::System.IntPtr share, int bufferSize, global::System.IntPtr options)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileMode>(j4n_env, mode), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.AccessControl.FileSystemRights>(j4n_env, rights), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileShare>(j4n_env, share), bufferSize, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileOptions>(j4n_env, options)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#10 .ctor(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;Lsystem/Object;)V (Lsystem/String;LSystem/IO/FileMode;LSystem/Security/AccessControl/FileSystemRights;LSystem/IO/FileShare;ILSystem/IO/FileOptions;LSystem/Security/AccessControl/FileSecurity;)V</signature>
        static long j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr rights, global::System.IntPtr share, int bufferSize, global::System.IntPtr options, global::System.IntPtr fileSecurity)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 24);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.IO.FileStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileMode>(j4n_env, mode), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.AccessControl.FileSystemRights>(j4n_env, rights), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileShare>(j4n_env, share), bufferSize, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileOptions>(j4n_env, options), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.AccessControl.FileSecurity>(j4n_env, fileSecurity)));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#11 get_Handle()Lsystem/IntPtr; ()LSystem/IntPtr;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.FileStream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileStream>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Handle, "system.IntPtr");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#12 get_IsAsync()Z ()Z</signature>
        static bool j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.FileStream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileStream>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsAsync;
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(bool);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#13 get_Name()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.FileStream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileStream>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Name, "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#14 get_SafeFileHandle()Lsystem/IDisposable; ()LMicrosoft/Win32/SafeHandles/SafeFileHandle;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.FileStream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileStream>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.SafeFileHandle, "system.IDisposable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#15 GetAccessControl()Lsystem/Object; ()LSystem/Security/AccessControl/FileSecurity;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IO.FileStream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileStream>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetAccessControl(), "system.Object");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#16 Lock(JJ)V (JJ)V</signature>
        static void j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long position, long length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IO.FileStream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileStream>(j4n_env, j4n_self);
                j4n_real.Lock(position, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#17 SetAccessControl(Lsystem/Object;)V (LSystem/Security/AccessControl/FileSecurity;)V</signature>
        static void j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr fileSecurity)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IO.FileStream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileStream>(j4n_env, j4n_self);
                j4n_real.SetAccessControl(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.AccessControl.FileSecurity>(j4n_env, fileSecurity));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#18 Unlock(JJ)V (JJ)V</signature>
        static void j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long position, long length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IO.FileStream j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IO.FileStream>(j4n_env, j4n_self);
                j4n_real.Unlock(position, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.IO.FileStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.io.FileStream";
                    proxyInfo.JVMProxyName = "system.io.FileStream";
                    proxyInfo.JVMStaticApiName = "system.io.FileStream";
                    proxyInfo.CLRApi = typeof(System.IO.FileStream);
                    proxyInfo.CLRStaticApi = typeof(System.IO.FileStream_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Lsystem/IDisposable;Lsystem/Enum;)V", false, false), // #0 (LSystem/IDisposable;LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Lsystem/IDisposable;Lsystem/Enum;I)V", false, false), // #1 (LSystem/IDisposable;LSystem/Enum;I)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Lsystem/IDisposable;Lsystem/Enum;IZ)V", false, false), // #2 (LSystem/IDisposable;LSystem/Enum;IZ)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Lsystem/Enum;)V", false, false), // #3 (Ljava/lang/String;LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;)V", false, false), // #4 (Ljava/lang/String;LSystem/Enum;LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;)V", false, false), // #5 (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;I)V", false, false), // #6 (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;I)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;IZ)V", false, false), // #7 (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;IZ)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;)V", false, false), // #8 (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;ILSystem/Enum;)V
                        null, // #9 IsJvmSkip: .ctor
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;Lsystem/Object;)V", false, false), // #10 (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;ILSystem/Enum;Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("getHandle","()Lsystem/IntPtr;", false, false), // #11 ()LSystem/IntPtr;
                        new global::net.sf.jni4net.core.MemberId("getIsAsync","()Z", false, false), // #12 ()Z
                        new global::net.sf.jni4net.core.MemberId("getName","()Ljava/lang/String;", false, false), // #13 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getSafeFileHandle","()Lsystem/IDisposable;", false, false), // #14 ()LSystem/IDisposable;
                        new global::net.sf.jni4net.core.MemberId("GetAccessControl","()Lsystem/Object;", false, false), // #15 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("Lock","(JJ)V", false, false), // #16 (JJ)V
                        new global::net.sf.jni4net.core.MemberId("SetAccessControl","(Lsystem/Object;)V", false, false), // #17 (Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Unlock","(JJ)V", false, false), // #18 (JJ)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
