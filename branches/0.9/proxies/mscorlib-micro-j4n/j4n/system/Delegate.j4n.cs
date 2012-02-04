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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Delegate_))]
    static public partial class Delegate_
    {
        static Delegate_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.ICloneable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ICloneable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Delegate_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 Combine([Lsystem/Delegate;)Lsystem/Delegate; ([LSystem/Delegate;)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr delegates)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.Combine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate[]>(j4n_env, delegates)), "system.Delegate");
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
        
        /// <signature>#1 Combine(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate; (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr a, global::System.IntPtr b)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.Combine(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, a), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, b)), "system.Delegate");
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
        
        /// <signature>#2 CreateDelegate(Lsystem/Type;Ljava/lang/Object;Lsystem/reflection/MethodInfo;)Lsystem/Delegate; (LSystem/Type;Lsystem/Object;LSystem/Reflection/MethodInfo;)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr firstArgument, global::System.IntPtr method)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, firstArgument), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, method)), "system.Delegate");
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
        
        /// <signature>#3 CreateDelegate(Lsystem/Type;Ljava/lang/Object;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate; (LSystem/Type;Lsystem/Object;LSystem/Reflection/MethodInfo;Z)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr firstArgument, global::System.IntPtr method, bool throwOnBindFailure)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, firstArgument), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, method), throwOnBindFailure), "system.Delegate");
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
        
        /// <signature>#4 CreateDelegate(Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;)Lsystem/Delegate; (LSystem/Type;Lsystem/Object;Lsystem/String;)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr target, global::System.IntPtr method)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, method)), "system.Delegate");
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
        
        /// <signature>#5 CreateDelegate(Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;Z)Lsystem/Delegate; (LSystem/Type;Lsystem/Object;Lsystem/String;Z)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr target, global::System.IntPtr method, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, method), ignoreCase), "system.Delegate");
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
        
        /// <signature>#6 CreateDelegate(Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;ZZ)Lsystem/Delegate; (LSystem/Type;Lsystem/Object;Lsystem/String;ZZ)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr target, global::System.IntPtr method, bool ignoreCase, bool throwOnBindFailure)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, method), ignoreCase, throwOnBindFailure), "system.Delegate");
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
        
        /// <signature>#7 CreateDelegate(Lsystem/Type;Lsystem/reflection/MethodInfo;)Lsystem/Delegate; (LSystem/Type;LSystem/Reflection/MethodInfo;)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr method)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, method)), "system.Delegate");
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
        
        /// <signature>#8 CreateDelegate(Lsystem/Type;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate; (LSystem/Type;LSystem/Reflection/MethodInfo;Z)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr method, bool throwOnBindFailure)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, method), throwOnBindFailure), "system.Delegate");
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
        
        /// <signature>#9 CreateDelegate(Lsystem/Type;Lsystem/Type;Ljava/lang/String;)Lsystem/Delegate; (LSystem/Type;LSystem/Type;Lsystem/String;)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr target, global::System.IntPtr method)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, method)), "system.Delegate");
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
        
        /// <signature>#10 CreateDelegate(Lsystem/Type;Lsystem/Type;Ljava/lang/String;Z)Lsystem/Delegate; (LSystem/Type;LSystem/Type;Lsystem/String;Z)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr target, global::System.IntPtr method, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, method), ignoreCase), "system.Delegate");
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
        
        /// <signature>#11 CreateDelegate(Lsystem/Type;Lsystem/Type;Ljava/lang/String;ZZ)Lsystem/Delegate; (LSystem/Type;LSystem/Type;Lsystem/String;ZZ)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type, global::System.IntPtr target, global::System.IntPtr method, bool ignoreCase, bool throwOnBindFailure)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, method), ignoreCase, throwOnBindFailure), "system.Delegate");
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
        
        /// <signature>#12 Remove(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate; (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr source, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.Remove(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, source), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, value)), "system.Delegate");
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
        
        /// <signature>#13 RemoveAll(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate; (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr source, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Delegate.RemoveAll(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, source), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, value)), "system.Delegate");
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
        
        /// <signature>#14 Clone()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.ICloneable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ICloneable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Clone(), "java.lang.Object");
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
        
        /// <signature>#15 DynamicInvoke([Ljava/lang/Object;)Ljava/lang/Object; ([Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr args)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Delegate j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.DynamicInvoke(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args)), "java.lang.Object");
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
        
        /// <signature>#16 get_Method()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Delegate j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Method, "system.reflection.MethodInfo");
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
        
        /// <signature>#17 get_Target()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Delegate j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Target, "java.lang.Object");
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
        
        /// <signature>#18 GetInvocationList()[Lsystem/Delegate; ()[LSystem/Delegate;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Delegate j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Delegate>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetInvocationList(), "system.Delegate");
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
        
        /// <signature>#19 GetObjectData(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
        static void j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr info, global::System.IntPtr context)
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
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Delegate))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Delegate";
                    proxyInfo.JVMProxyName = "system.Delegate";
                    proxyInfo.JVMStaticApiName = "system.Delegate";
                    proxyInfo.CLRApi = typeof(System.Delegate);
                    proxyInfo.CLRStaticApi = typeof(System.Delegate_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Combine","([Lsystem/Delegate;)Lsystem/Delegate;", false, true), // #0 ([LSystem/Delegate;)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("Combine","(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;", false, true), // #1 (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Ljava/lang/Object;Lsystem/reflection/MethodInfo;)Lsystem/Delegate;", false, true), // #2 (LSystem/Type;Ljava/lang/Object;LSystem/Reflection/MethodInfo;)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Ljava/lang/Object;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate;", false, true), // #3 (LSystem/Type;Ljava/lang/Object;LSystem/Reflection/MethodInfo;Z)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;)Lsystem/Delegate;", false, true), // #4 (LSystem/Type;Ljava/lang/Object;Ljava/lang/String;)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;Z)Lsystem/Delegate;", false, true), // #5 (LSystem/Type;Ljava/lang/Object;Ljava/lang/String;Z)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;ZZ)Lsystem/Delegate;", false, true), // #6 (LSystem/Type;Ljava/lang/Object;Ljava/lang/String;ZZ)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Lsystem/reflection/MethodInfo;)Lsystem/Delegate;", false, true), // #7 (LSystem/Type;LSystem/Reflection/MethodInfo;)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate;", false, true), // #8 (LSystem/Type;LSystem/Reflection/MethodInfo;Z)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Lsystem/Type;Ljava/lang/String;)Lsystem/Delegate;", false, true), // #9 (LSystem/Type;LSystem/Type;Ljava/lang/String;)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Lsystem/Type;Ljava/lang/String;Z)Lsystem/Delegate;", false, true), // #10 (LSystem/Type;LSystem/Type;Ljava/lang/String;Z)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("CreateDelegate","(Lsystem/Type;Lsystem/Type;Ljava/lang/String;ZZ)Lsystem/Delegate;", false, true), // #11 (LSystem/Type;LSystem/Type;Ljava/lang/String;ZZ)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("Remove","(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;", false, true), // #12 (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("RemoveAll","(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;", false, true), // #13 (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("Clone","()Ljava/lang/Object;", false, false), // #14 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("DynamicInvoke","([Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #15 ([Ljava/lang/Object;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getMethod","()Lsystem/reflection/MethodInfo;", false, false), // #16 ()LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("getTarget","()Ljava/lang/Object;", false, false), // #17 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetInvocationList","()[Lsystem/Delegate;", false, false), // #18 ()[LSystem/Delegate;
                        new global::net.sf.jni4net.core.MemberId("GetObjectData","(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V", false, false), // #19 (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
