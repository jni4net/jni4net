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

namespace System
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Exception_))]
    static public partial class Exception_
    {
        static Exception_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Exception_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor()V ()V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Exception());
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
        
        /// <signature>#1 .ctor(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr message)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Exception(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, message)));
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
        
        /// <signature>#2 .ctor(Ljava/lang/String;Ljava/lang/Throwable;)V (Lsystem/String;LSystem/Exception;)V</signature>
        static long j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr message, global::System.IntPtr innerException)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.Exception(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, message), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, innerException)));
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
        
        /// <signature>#3 Equals(Lsystem/Object;Lsystem/Object;)Lsystem/Boolean; (Lsystem/Object;Lsystem/Object;)Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr objA, global::System.IntPtr objB)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = global::System.Exception.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, objA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, objB));
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
        
        /// <signature>#4 ReferenceEquals(Lsystem/Object;Lsystem/Object;)Lsystem/Boolean; (Lsystem/Object;Lsystem/Object;)Z</signature>
        static bool j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr objA, global::System.IntPtr objB)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = global::System.Exception.ReferenceEquals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, objA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, objB));
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
        
        /// <signature>#5 Equals(Lsystem/Object;)Lsystem/Boolean; (Lsystem/Object;)Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj));
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
        
        /// <signature>#6 get_Data()Lsystem/collections/IDictionary; ()LSystem/Collections/IDictionary;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Data, "system.collections.IDictionary");
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
        
        /// <signature>#7 get_HelpLink()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.HelpLink, "java.lang.String");
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
        
        /// <signature>#8 get_InnerException()Ljava/lang/Throwable; ()LSystem/Exception;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.InnerException, "java.lang.Throwable");
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
        
        /// <signature>#9 get_Message()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Message, "java.lang.String");
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
        
        /// <signature>#10 get_Source()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Source, "java.lang.String");
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
        
        /// <signature>#11 get_StackTrace()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.StackTrace, "java.lang.String");
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
        
        /// <signature>#12 get_TargetSite()Lsystem/reflection/MethodBase; ()LSystem/Reflection/MethodBase;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.TargetSite, "system.reflection.MethodBase");
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
        
        /// <signature>#13 GetBaseException()Ljava/lang/Throwable; ()LSystem/Exception;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetBaseException(), "java.lang.Throwable");
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
        
        /// <signature>#14 GetHashCode()Lsystem/Int32; ()I</signature>
        static int j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                int j4n_result = j4n_real.GetHashCode();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(int);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#15 GetObjectData(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
        static void j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr info, global::System.IntPtr context)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.ISerializable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.ISerializable>(j4n_env, j4n_self);
                j4n_real.GetObjectData(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, info), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContext>(j4n_env, context));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#16 GetType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetType(), "system.Type");
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
        
        /// <signature>#17 GetType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetType(), "system.Type");
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
        
        /// <signature>#18 set_HelpLink(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_real.HelpLink = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#19 set_Source(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_real.Source = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#20 ToString()Lsystem/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Exception j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Exception>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToString(), "system.String");
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
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Exception))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Exception";
                    proxyInfo.JVMProxyName = "system.Exception";
                    proxyInfo.JVMStaticApiName = "system.Exception";
                    proxyInfo.CLRApi = typeof(System.Exception);
                    proxyInfo.CLRStaticApi = typeof(System.Exception_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V", false, false), // #2 (Ljava/lang/String;Ljava/lang/Throwable;)V
                        new global::net.sf.jni4net.core.MemberId("getData","()Lsystem/collections/IDictionary;", false, false), // #3 ()LSystem/Collections/IDictionary;
                        new global::net.sf.jni4net.core.MemberId("getHelpLink","()Ljava/lang/String;", false, false), // #4 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getInnerException","()Ljava/lang/Throwable;", false, false), // #5 ()Ljava/lang/Throwable;
                        new global::net.sf.jni4net.core.MemberId("getMessage","()Ljava/lang/String;", false, false), // #6 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getSource","()Ljava/lang/String;", false, false), // #7 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getClrStackTrace","()Ljava/lang/String;", false, false), // #8 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getTargetSite","()Lsystem/reflection/MethodBase;", false, false), // #9 ()LSystem/Reflection/MethodBase;
                        new global::net.sf.jni4net.core.MemberId("GetBaseException","()Ljava/lang/Throwable;", false, false), // #10 ()Ljava/lang/Throwable;
                        new global::net.sf.jni4net.core.MemberId("GetObjectData","(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V", false, false), // #11 (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V
                        new global::net.sf.jni4net.core.MemberId("GetType_26","()Lsystem/Type;", false, false), // #12 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("setHelpLink","(Ljava/lang/String;)V", false, false), // #13 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("setSource","(Ljava/lang/String;)V", false, false), // #14 (Ljava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("Equals","(Ljava/lang/Object;Ljava/lang/Object;)Z", false, true), // #15 (Ljava/lang/Object;Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("ReferenceEquals","(Ljava/lang/Object;Ljava/lang/Object;)Z", false, true), // #16 (Ljava/lang/Object;Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("Equals","(Ljava/lang/Object;)Z", false, false), // #17 (Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("GetHashCode","()I", false, false), // #18 ()I
                        new global::net.sf.jni4net.core.MemberId("ToString","()Ljava/lang/String;", false, false), // #19 ()Ljava/lang/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
