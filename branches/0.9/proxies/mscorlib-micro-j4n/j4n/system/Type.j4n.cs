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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Type_))]
    static public partial class Type_
    {
        static Type_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.MemberInfo_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Reflection.IReflect_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.IReflect_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Type_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 Delimiter()C ()C</signature>
        static char j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                char j4n_result = global::System.Type.Delimiter;
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(char);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 EmptyTypes()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.EmptyTypes, "system.Type");
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
        
        /// <signature>#2 FilterAttribute()Lsystem/MulticastDelegate; ()LSystem/Reflection/MemberFilter;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.FilterAttribute, "system.MulticastDelegate");
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
        
        /// <signature>#3 FilterName()Lsystem/MulticastDelegate; ()LSystem/Reflection/MemberFilter;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.FilterName, "system.MulticastDelegate");
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
        
        /// <signature>#4 FilterNameIgnoreCase()Lsystem/MulticastDelegate; ()LSystem/Reflection/MemberFilter;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.FilterNameIgnoreCase, "system.MulticastDelegate");
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
        
        /// <signature>#5 get_DefaultBinder()Lsystem/Object; ()LSystem/Reflection/Binder;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.DefaultBinder, "system.Object");
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
        
        /// <signature>#6 GetType(Ljava/lang/String;)Lsystem/Type; (Lsystem/String;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr typeName)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, typeName)), "system.Type");
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
        
        /// <signature>#7 GetType(Ljava/lang/String;Z)Lsystem/Type; (Lsystem/String;Z)LSystem/Type;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr typeName, bool throwOnError)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, typeName), throwOnError), "system.Type");
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
        
        /// <signature>#8 GetType(Ljava/lang/String;ZZ)Lsystem/Type; (Lsystem/String;ZZ)LSystem/Type;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr typeName, bool throwOnError, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, typeName), throwOnError, ignoreCase), "system.Type");
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
        
        /// <signature>#9 GetTypeArray([Ljava/lang/Object;)[Lsystem/Type; ([Lsystem/Object;)[LSystem/Type;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr args)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeArray(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args)), "system.Type");
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
        
        /// <signature>#10 GetTypeCode(Lsystem/Type;)Lsystem/Enum; (LSystem/Type;)LSystem/TypeCode;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeCode(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type)), "system.Enum");
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
        
        /// <signature>#11 GetTypeFromCLSID(Lsystem/Guid;)Lsystem/Type; (LSystem/Guid;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr clsid)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromCLSID(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, clsid)), "system.Type");
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
        
        /// <signature>#12 GetTypeFromCLSID(Lsystem/Guid;Z)Lsystem/Type; (LSystem/Guid;Z)LSystem/Type;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr clsid, bool throwOnError)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromCLSID(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, clsid), throwOnError), "system.Type");
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
        
        /// <signature>#13 GetTypeFromCLSID(Lsystem/Guid;Ljava/lang/String;)Lsystem/Type; (LSystem/Guid;Lsystem/String;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr clsid, global::System.IntPtr server)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromCLSID(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, clsid), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, server)), "system.Type");
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
        
        /// <signature>#14 GetTypeFromCLSID(Lsystem/Guid;Ljava/lang/String;Z)Lsystem/Type; (LSystem/Guid;Lsystem/String;Z)LSystem/Type;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr clsid, global::System.IntPtr server, bool throwOnError)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromCLSID(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Guid>(j4n_env, clsid), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, server), throwOnError), "system.Type");
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
        
        /// <signature>#15 GetTypeFromHandle(Lsystem/ValueType;)Lsystem/Type; (LSystem/RuntimeTypeHandle;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr handle)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromHandle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.RuntimeTypeHandle>(j4n_env, handle)), "system.Type");
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
        
        /// <signature>#16 GetTypeFromProgID(Ljava/lang/String;)Lsystem/Type; (Lsystem/String;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr progID)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromProgID(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, progID)), "system.Type");
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
        
        /// <signature>#17 GetTypeFromProgID(Ljava/lang/String;Z)Lsystem/Type; (Lsystem/String;Z)LSystem/Type;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr progID, bool throwOnError)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromProgID(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, progID), throwOnError), "system.Type");
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
        
        /// <signature>#18 GetTypeFromProgID(Ljava/lang/String;Ljava/lang/String;)Lsystem/Type; (Lsystem/String;Lsystem/String;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr progID, global::System.IntPtr server)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromProgID(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, progID), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, server)), "system.Type");
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
        
        /// <signature>#19 GetTypeFromProgID(Ljava/lang/String;Ljava/lang/String;Z)Lsystem/Type; (Lsystem/String;Lsystem/String;Z)LSystem/Type;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr progID, global::System.IntPtr server, bool throwOnError)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeFromProgID(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, progID), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, server), throwOnError), "system.Type");
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
        
        /// <signature>#20 GetTypeHandle(Ljava/lang/Object;)Lsystem/ValueType; (Lsystem/Object;)LSystem/RuntimeTypeHandle;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr o)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.GetTypeHandle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, o)), "system.ValueType");
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
        
        /// <signature>#21 Missing()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.Missing, "java.lang.Object");
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
        
        /// <signature>#22 ReflectionOnlyGetType(Ljava/lang/String;ZZ)Lsystem/Type; (Lsystem/String;ZZ)LSystem/Type;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr typeName, bool throwIfNotFound, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Type.ReflectionOnlyGetType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, typeName), throwIfNotFound, ignoreCase), "system.Type");
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
        
        /// <signature>#23 Equals(Lsystem/Type;)Z (LSystem/Type;)Z</signature>
        static bool j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr o)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, o));
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
        
        /// <signature>#24 FindInterfaces(Lsystem/MulticastDelegate;Ljava/lang/Object;)[Lsystem/Type; (LSystem/Reflection/TypeFilter;Lsystem/Object;)[LSystem/Type;</signature>
        static global::System.IntPtr j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr filter, global::System.IntPtr filterCriteria)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.FindInterfaces(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.TypeFilter>(j4n_env, filter), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, filterCriteria)), "system.Type");
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
        
        /// <signature>#25 FindMembers(Lsystem/Enum;Lsystem/reflection/BindingFlags;Lsystem/MulticastDelegate;Ljava/lang/Object;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/MemberTypes;LSystem/Reflection/BindingFlags;LSystem/Reflection/MemberFilter;Lsystem/Object;)[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr memberType, global::System.IntPtr bindingAttr, global::System.IntPtr filter, global::System.IntPtr filterCriteria)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.FindMembers(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberTypes>(j4n_env, memberType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberFilter>(j4n_env, filter), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, filterCriteria)), "system.reflection.MemberInfo");
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
        
        /// <signature>#26 get_Assembly()Lsystem/reflection/Assembly; ()LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Assembly, "system.reflection.Assembly");
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
        
        /// <signature>#27 get_AssemblyQualifiedName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.AssemblyQualifiedName, "java.lang.String");
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
        
        /// <signature>#28 get_Attributes()Lsystem/Enum; ()LSystem/Reflection/TypeAttributes;</signature>
        static global::System.IntPtr j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Attributes, "system.Enum");
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
        
        /// <signature>#29 get_BaseType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.BaseType, "system.Type");
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
        
        /// <signature>#30 get_ContainsGenericParameters()Z ()Z</signature>
        static bool j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.ContainsGenericParameters;
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
        
        /// <signature>#31 get_DeclaringMethod()Lsystem/reflection/MethodBase; ()LSystem/Reflection/MethodBase;</signature>
        static global::System.IntPtr j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.DeclaringMethod, "system.reflection.MethodBase");
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
        
        /// <signature>#32 get_FullName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.FullName, "java.lang.String");
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
        
        /// <signature>#33 get_GenericParameterAttributes()Lsystem/Enum; ()LSystem/Reflection/GenericParameterAttributes;</signature>
        static global::System.IntPtr j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GenericParameterAttributes, "system.Enum");
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
        
        /// <signature>#34 get_GenericParameterPosition()I ()I</signature>
        static int j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                int j4n_result = j4n_real.GenericParameterPosition;
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
        
        /// <signature>#35 get_GUID()Lsystem/Guid; ()LSystem/Guid;</signature>
        static global::System.IntPtr j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GUID, "system.Guid");
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
        
        /// <signature>#36 get_HasElementType()Z ()Z</signature>
        static bool j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.HasElementType;
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
        
        /// <signature>#37 get_IsAbstract()Z ()Z</signature>
        static bool j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsAbstract;
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
        
        /// <signature>#38 get_IsAnsiClass()Z ()Z</signature>
        static bool j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsAnsiClass;
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
        
        /// <signature>#39 get_IsArray()Z ()Z</signature>
        static bool j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsArray;
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
        
        /// <signature>#40 get_IsAutoClass()Z ()Z</signature>
        static bool j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsAutoClass;
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
        
        /// <signature>#41 get_IsAutoLayout()Z ()Z</signature>
        static bool j4n_41(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsAutoLayout;
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
        
        /// <signature>#42 get_IsByRef()Z ()Z</signature>
        static bool j4n_42(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsByRef;
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
        
        /// <signature>#43 get_IsClass()Z ()Z</signature>
        static bool j4n_43(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsClass;
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
        
        /// <signature>#44 get_IsCOMObject()Z ()Z</signature>
        static bool j4n_44(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsCOMObject;
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
        
        /// <signature>#45 get_IsContextful()Z ()Z</signature>
        static bool j4n_45(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsContextful;
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
        
        /// <signature>#46 get_IsEnum()Z ()Z</signature>
        static bool j4n_46(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsEnum;
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
        
        /// <signature>#47 get_IsExplicitLayout()Z ()Z</signature>
        static bool j4n_47(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsExplicitLayout;
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
        
        /// <signature>#48 get_IsGenericParameter()Z ()Z</signature>
        static bool j4n_48(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsGenericParameter;
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
        
        /// <signature>#49 get_IsGenericType()Z ()Z</signature>
        static bool j4n_49(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsGenericType;
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
        
        /// <signature>#50 get_IsGenericTypeDefinition()Z ()Z</signature>
        static bool j4n_50(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsGenericTypeDefinition;
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
        
        /// <signature>#51 get_IsImport()Z ()Z</signature>
        static bool j4n_51(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsImport;
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
        
        /// <signature>#52 get_IsInterface()Z ()Z</signature>
        static bool j4n_52(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsInterface;
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
        
        /// <signature>#53 get_IsLayoutSequential()Z ()Z</signature>
        static bool j4n_53(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsLayoutSequential;
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
        
        /// <signature>#54 get_IsMarshalByRef()Z ()Z</signature>
        static bool j4n_54(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsMarshalByRef;
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
        
        /// <signature>#55 get_IsNested()Z ()Z</signature>
        static bool j4n_55(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNested;
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
        
        /// <signature>#56 get_IsNestedAssembly()Z ()Z</signature>
        static bool j4n_56(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNestedAssembly;
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
        
        /// <signature>#57 get_IsNestedFamANDAssem()Z ()Z</signature>
        static bool j4n_57(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNestedFamANDAssem;
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
        
        /// <signature>#58 get_IsNestedFamily()Z ()Z</signature>
        static bool j4n_58(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNestedFamily;
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
        
        /// <signature>#59 get_IsNestedFamORAssem()Z ()Z</signature>
        static bool j4n_59(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNestedFamORAssem;
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
        
        /// <signature>#60 get_IsNestedPrivate()Z ()Z</signature>
        static bool j4n_60(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNestedPrivate;
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
        
        /// <signature>#61 get_IsNestedPublic()Z ()Z</signature>
        static bool j4n_61(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNestedPublic;
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
        
        /// <signature>#62 get_IsNotPublic()Z ()Z</signature>
        static bool j4n_62(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNotPublic;
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
        
        /// <signature>#63 get_IsPointer()Z ()Z</signature>
        static bool j4n_63(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsPointer;
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
        
        /// <signature>#64 get_IsPrimitive()Z ()Z</signature>
        static bool j4n_64(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsPrimitive;
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
        
        /// <signature>#65 get_IsPublic()Z ()Z</signature>
        static bool j4n_65(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsPublic;
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
        
        /// <signature>#66 get_IsSealed()Z ()Z</signature>
        static bool j4n_66(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsSealed;
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
        
        /// <signature>#67 get_IsSerializable()Z ()Z</signature>
        static bool j4n_67(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsSerializable;
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
        
        /// <signature>#68 get_IsSpecialName()Z ()Z</signature>
        static bool j4n_68(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsSpecialName;
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
        
        /// <signature>#69 get_IsUnicodeClass()Z ()Z</signature>
        static bool j4n_69(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsUnicodeClass;
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
        
        /// <signature>#70 get_IsValueType()Z ()Z</signature>
        static bool j4n_70(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsValueType;
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
        
        /// <signature>#71 get_IsVisible()Z ()Z</signature>
        static bool j4n_71(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsVisible;
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
        
        /// <signature>#72 get_Module()Lsystem/runtime/serialization/ISerializable; ()LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_72(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Module, "system.runtime.serialization.ISerializable");
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
        
        /// <signature>#73 get_Namespace()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_73(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Namespace, "java.lang.String");
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
        
        /// <signature>#74 get_StructLayoutAttribute()Lsystem/Object; ()LSystem/Runtime/InteropServices/StructLayoutAttribute;</signature>
        static global::System.IntPtr j4n_74(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.StructLayoutAttribute, "system.Object");
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
        
        /// <signature>#75 get_TypeHandle()Lsystem/ValueType; ()LSystem/RuntimeTypeHandle;</signature>
        static global::System.IntPtr j4n_75(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.TypeHandle, "system.ValueType");
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
        
        /// <signature>#76 get_TypeInitializer()Lsystem/reflection/ConstructorInfo; ()LSystem/Reflection/ConstructorInfo;</signature>
        static global::System.IntPtr j4n_76(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.TypeInitializer, "system.reflection.ConstructorInfo");
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
        
        /// <signature>#77 get_UnderlyingSystemType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_77(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.UnderlyingSystemType, "system.Type");
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
        
        /// <signature>#78 GetArrayRank()I ()I</signature>
        static int j4n_78(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                int j4n_result = j4n_real.GetArrayRank();
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
        
        /// <signature>#79 GetConstructor([Lsystem/Type;)Lsystem/reflection/ConstructorInfo; ([LSystem/Type;)LSystem/Reflection/ConstructorInfo;</signature>
        static global::System.IntPtr j4n_79(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr types)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetConstructor(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types)), "system.reflection.ConstructorInfo");
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
        
        /// <signature>#80 GetConstructor(Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/ConstructorInfo; (LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/ConstructorInfo;</signature>
        static global::System.IntPtr j4n_80(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr, global::System.IntPtr binder, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetConstructor(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ParameterModifier[]>(j4n_env, modifiers)), "system.reflection.ConstructorInfo");
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
        
        /// <signature>#81 GetConstructor(Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Enum;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/ConstructorInfo; (LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;LSystem/Reflection/CallingConventions;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/ConstructorInfo;</signature>
        static global::System.IntPtr j4n_81(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr, global::System.IntPtr binder, global::System.IntPtr callConvention, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetConstructor(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.CallingConventions>(j4n_env, callConvention), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ParameterModifier[]>(j4n_env, modifiers)), "system.reflection.ConstructorInfo");
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
        
        /// <signature>#82 GetConstructors()[Lsystem/reflection/ConstructorInfo; ()[LSystem/Reflection/ConstructorInfo;</signature>
        static global::System.IntPtr j4n_82(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetConstructors(), "system.reflection.ConstructorInfo");
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
        
        /// <signature>#83 GetConstructors(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/ConstructorInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/ConstructorInfo;</signature>
        static global::System.IntPtr j4n_83(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetConstructors(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.ConstructorInfo");
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
        
        /// <signature>#84 GetDefaultMembers()[Lsystem/reflection/MemberInfo; ()[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_84(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetDefaultMembers(), "system.reflection.MemberInfo");
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
        
        /// <signature>#85 GetElementType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_85(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetElementType(), "system.Type");
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
        
        /// <signature>#86 GetEvent(Ljava/lang/String;)Lsystem/reflection/MemberInfo; (Lsystem/String;)LSystem/Reflection/EventInfo;</signature>
        static global::System.IntPtr j4n_86(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetEvent(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.reflection.MemberInfo");
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
        
        /// <signature>#87 GetEvent(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MemberInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/EventInfo;</signature>
        static global::System.IntPtr j4n_87(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetEvent(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.MemberInfo");
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
        
        /// <signature>#88 GetEvents()[Lsystem/reflection/MemberInfo; ()[LSystem/Reflection/EventInfo;</signature>
        static global::System.IntPtr j4n_88(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetEvents(), "system.reflection.MemberInfo");
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
        
        /// <signature>#89 GetEvents(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/EventInfo;</signature>
        static global::System.IntPtr j4n_89(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetEvents(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.MemberInfo");
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
        
        /// <signature>#90 GetField(Ljava/lang/String;)Lsystem/reflection/FieldInfo; (Lsystem/String;)LSystem/Reflection/FieldInfo;</signature>
        static global::System.IntPtr j4n_90(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetField(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.reflection.FieldInfo");
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
        
        /// <signature>#91 GetField(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/FieldInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/FieldInfo;</signature>
        static global::System.IntPtr j4n_91(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetField(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.FieldInfo");
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
        
        /// <signature>#92 GetFields()[Lsystem/reflection/FieldInfo; ()[LSystem/Reflection/FieldInfo;</signature>
        static global::System.IntPtr j4n_92(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetFields(), "system.reflection.FieldInfo");
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
        
        /// <signature>#93 GetFields(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/FieldInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/FieldInfo;</signature>
        static global::System.IntPtr j4n_93(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetFields(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.FieldInfo");
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
        
        /// <signature>#94 GetGenericArguments()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_94(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetGenericArguments(), "system.Type");
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
        
        /// <signature>#95 GetGenericParameterConstraints()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_95(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetGenericParameterConstraints(), "system.Type");
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
        
        /// <signature>#96 GetGenericTypeDefinition()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_96(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetGenericTypeDefinition(), "system.Type");
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
        
        /// <signature>#97 GetInterface(Ljava/lang/String;)Lsystem/Type; (Lsystem/String;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_97(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetInterface(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.Type");
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
        
        /// <signature>#98 GetInterface(Ljava/lang/String;Z)Lsystem/Type; (Lsystem/String;Z)LSystem/Type;</signature>
        static global::System.IntPtr j4n_98(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetInterface(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), ignoreCase), "system.Type");
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
        
        /// <signature>#99 GetInterfaceMap(Lsystem/Type;)Lsystem/ValueType; (LSystem/Type;)LSystem/Reflection/InterfaceMapping;</signature>
        static global::System.IntPtr j4n_99(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr interfaceType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetInterfaceMap(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, interfaceType)), "system.ValueType");
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
        
        /// <signature>#100 GetInterfaces()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_100(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetInterfaces(), "system.Type");
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
        
        /// <signature>#101 GetMember(Ljava/lang/String;)[Lsystem/reflection/MemberInfo; (Lsystem/String;)[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_101(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMember(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.reflection.MemberInfo");
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
        
        /// <signature>#102 GetMember(Ljava/lang/String;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_102(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMember(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.MemberInfo");
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
        
        /// <signature>#103 GetMember(Ljava/lang/String;Lsystem/Enum;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (Lsystem/String;LSystem/Reflection/MemberTypes;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_103(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr type, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMember(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberTypes>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.MemberInfo");
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
        
        /// <signature>#104 GetMembers()[Lsystem/reflection/MemberInfo; ()[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_104(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMembers(), "system.reflection.MemberInfo");
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
        
        /// <signature>#105 GetMembers(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_105(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMembers(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.MemberInfo");
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
        
        /// <signature>#106 GetMethod(Ljava/lang/String;)Lsystem/reflection/MethodInfo; (Lsystem/String;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_106(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethod(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.reflection.MethodInfo");
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
        
        /// <signature>#107 GetMethod(Ljava/lang/String;[Lsystem/Type;)Lsystem/reflection/MethodInfo; (Lsystem/String;[LSystem/Type;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_107(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr types)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethod(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types)), "system.reflection.MethodInfo");
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
        
        /// <signature>#108 GetMethod(Ljava/lang/String;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Lsystem/String;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_108(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethod(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ParameterModifier[]>(j4n_env, modifiers)), "system.reflection.MethodInfo");
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
        
        /// <signature>#109 GetMethod(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MethodInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_109(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethod(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.MethodInfo");
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
        
        /// <signature>#110 GetMethod(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_110(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr, global::System.IntPtr binder, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethod(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ParameterModifier[]>(j4n_env, modifiers)), "system.reflection.MethodInfo");
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
        
        /// <signature>#111 GetMethod(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Enum;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;LSystem/Reflection/CallingConventions;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_111(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr, global::System.IntPtr binder, global::System.IntPtr callConvention, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethod(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.CallingConventions>(j4n_env, callConvention), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ParameterModifier[]>(j4n_env, modifiers)), "system.reflection.MethodInfo");
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
        
        /// <signature>#112 GetMethods()[Lsystem/reflection/MethodInfo; ()[LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_112(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethods(), "system.reflection.MethodInfo");
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
        
        /// <signature>#113 GetMethods(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MethodInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_113(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethods(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.MethodInfo");
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
        
        /// <signature>#114 GetNestedType(Ljava/lang/String;)Lsystem/Type; (Lsystem/String;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_114(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetNestedType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.Type");
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
        
        /// <signature>#115 GetNestedType(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/Type; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_115(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetNestedType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.Type");
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
        
        /// <signature>#116 GetNestedTypes()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_116(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetNestedTypes(), "system.Type");
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
        
        /// <signature>#117 GetNestedTypes(Lsystem/reflection/BindingFlags;)[Lsystem/Type; (LSystem/Reflection/BindingFlags;)[LSystem/Type;</signature>
        static global::System.IntPtr j4n_117(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetNestedTypes(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.Type");
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
        
        /// <signature>#118 GetProperties()[Lsystem/reflection/PropertyInfo; ()[LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_118(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperties(), "system.reflection.PropertyInfo");
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
        
        /// <signature>#119 GetProperties(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/PropertyInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_119(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperties(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.PropertyInfo");
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
        
        /// <signature>#120 GetProperty(Ljava/lang/String;)Lsystem/reflection/PropertyInfo; (Lsystem/String;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_120(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperty(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.reflection.PropertyInfo");
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
        
        /// <signature>#121 GetProperty(Ljava/lang/String;[Lsystem/Type;)Lsystem/reflection/PropertyInfo; (Lsystem/String;[LSystem/Type;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_121(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr types)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperty(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types)), "system.reflection.PropertyInfo");
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
        
        /// <signature>#122 GetProperty(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_122(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperty(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr)), "system.reflection.PropertyInfo");
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
        
        /// <signature>#123 GetProperty(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;LSystem/Type;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_123(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr, global::System.IntPtr binder, global::System.IntPtr returnType, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperty(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, returnType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ParameterModifier[]>(j4n_env, modifiers)), "system.reflection.PropertyInfo");
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
        
        /// <signature>#124 GetProperty(Ljava/lang/String;Lsystem/Type;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Type;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_124(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr returnType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperty(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, returnType)), "system.reflection.PropertyInfo");
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
        
        /// <signature>#125 GetProperty(Ljava/lang/String;Lsystem/Type;[Lsystem/Type;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Type;[LSystem/Type;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_125(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr returnType, global::System.IntPtr types)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperty(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, returnType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types)), "system.reflection.PropertyInfo");
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
        
        /// <signature>#126 GetProperty(Ljava/lang/String;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Type;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_126(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr returnType, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetProperty(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, returnType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, types), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ParameterModifier[]>(j4n_env, modifiers)), "system.reflection.PropertyInfo");
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
        
        /// <signature>#127 GetType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_127(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
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
        
        /// <signature>#128 InvokeMember(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;Lsystem/Object;[Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_128(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr target, global::System.IntPtr args)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.InvokeMember(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args)), "java.lang.Object");
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
        
        /// <signature>#129 InvokeMember(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[Lsystem/ValueType;Lsystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;Lsystem/Object;[Lsystem/Object;[LSystem/Reflection/ParameterModifier;LSystem/Globalization/CultureInfo;[Lsystem/String;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_129(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr target, global::System.IntPtr args, global::System.IntPtr modifiers, global::System.IntPtr culture, global::System.IntPtr namedParameters)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 26);
            try
            {
                global::System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.IReflect>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.InvokeMember(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ParameterModifier[]>(j4n_env, modifiers), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, namedParameters)), "java.lang.Object");
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
        
        /// <signature>#130 InvokeMember(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;Lsystem/Object;[Lsystem/Object;LSystem/Globalization/CultureInfo;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_130(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr target, global::System.IntPtr args, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.InvokeMember(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, target), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture)), "java.lang.Object");
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
        
        /// <signature>#131 IsAssignableFrom(Lsystem/Type;)Z (LSystem/Type;)Z</signature>
        static bool j4n_131(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsAssignableFrom(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, c));
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
        
        /// <signature>#132 IsInstanceOfType(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_132(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr o)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsInstanceOfType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, o));
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
        
        /// <signature>#133 IsSubclassOf(Lsystem/Type;)Z (LSystem/Type;)Z</signature>
        static bool j4n_133(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr c)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsSubclassOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, c));
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
        
        /// <signature>#134 MakeArrayType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_134(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.MakeArrayType(), "system.Type");
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
        
        /// <signature>#135 MakeArrayType(I)Lsystem/Type; (I)LSystem/Type;</signature>
        static global::System.IntPtr j4n_135(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int rank)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.MakeArrayType(rank), "system.Type");
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
        
        /// <signature>#136 MakeByRefType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_136(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.MakeByRefType(), "system.Type");
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
        
        /// <signature>#137 MakeGenericType([Lsystem/Type;)Lsystem/Type; ([LSystem/Type;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_137(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr typeArguments)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.MakeGenericType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, typeArguments)), "system.Type");
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
        
        /// <signature>#138 MakePointerType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_138(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Type j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.MakePointerType(), "system.Type");
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
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Type))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Type";
                    proxyInfo.JVMProxyName = "system.Type";
                    proxyInfo.JVMStaticApiName = "system.Type";
                    proxyInfo.CLRApi = typeof(System.Type);
                    proxyInfo.CLRStaticApi = typeof(System.Type_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Delimiter","()C", true, true), // #0 ()C
                        new global::net.sf.jni4net.core.MemberId("EmptyTypes","()[Lsystem/Type;", true, true), // #1 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("FilterAttribute","()Lsystem/MulticastDelegate;", true, true), // #2 ()LSystem/MulticastDelegate;
                        new global::net.sf.jni4net.core.MemberId("FilterName","()Lsystem/MulticastDelegate;", true, true), // #3 ()LSystem/MulticastDelegate;
                        new global::net.sf.jni4net.core.MemberId("FilterNameIgnoreCase","()Lsystem/MulticastDelegate;", true, true), // #4 ()LSystem/MulticastDelegate;
                        new global::net.sf.jni4net.core.MemberId("getDefaultBinder","()Lsystem/Object;", false, true), // #5 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("GetType","(Ljava/lang/String;)Lsystem/Type;", false, true), // #6 (Ljava/lang/String;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetType","(Ljava/lang/String;Z)Lsystem/Type;", false, true), // #7 (Ljava/lang/String;Z)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetType","(Ljava/lang/String;ZZ)Lsystem/Type;", false, true), // #8 (Ljava/lang/String;ZZ)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeArray","([Ljava/lang/Object;)[Lsystem/Type;", false, true), // #9 ([Ljava/lang/Object;)[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeCode","(Lsystem/Type;)Lsystem/Enum;", false, true), // #10 (LSystem/Type;)LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromCLSID","(Lsystem/Guid;)Lsystem/Type;", false, true), // #11 (LSystem/Guid;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromCLSID","(Lsystem/Guid;Z)Lsystem/Type;", false, true), // #12 (LSystem/Guid;Z)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromCLSID","(Lsystem/Guid;Ljava/lang/String;)Lsystem/Type;", false, true), // #13 (LSystem/Guid;Ljava/lang/String;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromCLSID","(Lsystem/Guid;Ljava/lang/String;Z)Lsystem/Type;", false, true), // #14 (LSystem/Guid;Ljava/lang/String;Z)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromHandle","(Lsystem/ValueType;)Lsystem/Type;", false, true), // #15 (LSystem/ValueType;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromProgID","(Ljava/lang/String;)Lsystem/Type;", false, true), // #16 (Ljava/lang/String;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromProgID","(Ljava/lang/String;Z)Lsystem/Type;", false, true), // #17 (Ljava/lang/String;Z)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromProgID","(Ljava/lang/String;Ljava/lang/String;)Lsystem/Type;", false, true), // #18 (Ljava/lang/String;Ljava/lang/String;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeFromProgID","(Ljava/lang/String;Ljava/lang/String;Z)Lsystem/Type;", false, true), // #19 (Ljava/lang/String;Ljava/lang/String;Z)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypeHandle","(Ljava/lang/Object;)Lsystem/ValueType;", false, true), // #20 (Ljava/lang/Object;)LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("Missing","()Ljava/lang/Object;", true, true), // #21 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ReflectionOnlyGetType","(Ljava/lang/String;ZZ)Lsystem/Type;", false, true), // #22 (Ljava/lang/String;ZZ)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("Equals","(Lsystem/Type;)Z", false, false), // #23 (LSystem/Type;)Z
                        new global::net.sf.jni4net.core.MemberId("FindInterfaces","(Lsystem/MulticastDelegate;Ljava/lang/Object;)[Lsystem/Type;", false, false), // #24 (LSystem/MulticastDelegate;Ljava/lang/Object;)[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("FindMembers","(Lsystem/Enum;Lsystem/reflection/BindingFlags;Lsystem/MulticastDelegate;Ljava/lang/Object;)[Lsystem/reflection/MemberInfo;", false, false), // #25 (LSystem/Enum;LSystem/Reflection/BindingFlags;LSystem/MulticastDelegate;Ljava/lang/Object;)[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("getAssembly","()Lsystem/reflection/Assembly;", false, false), // #26 ()LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("getAssemblyQualifiedName","()Ljava/lang/String;", false, false), // #27 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getAttributes","()Lsystem/Enum;", false, false), // #28 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getBaseType","()Lsystem/Type;", false, false), // #29 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("getContainsGenericParameters","()Z", false, false), // #30 ()Z
                        new global::net.sf.jni4net.core.MemberId("getDeclaringMethod","()Lsystem/reflection/MethodBase;", false, false), // #31 ()LSystem/Reflection/MethodBase;
                        new global::net.sf.jni4net.core.MemberId("getFullName","()Ljava/lang/String;", false, false), // #32 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getGenericParameterAttributes","()Lsystem/Enum;", false, false), // #33 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getGenericParameterPosition","()I", false, false), // #34 ()I
                        new global::net.sf.jni4net.core.MemberId("getGUID","()Lsystem/Guid;", false, false), // #35 ()LSystem/Guid;
                        new global::net.sf.jni4net.core.MemberId("getHasElementType","()Z", false, false), // #36 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsAbstract","()Z", false, false), // #37 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsAnsiClass","()Z", false, false), // #38 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsArray","()Z", false, false), // #39 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsAutoClass","()Z", false, false), // #40 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsAutoLayout","()Z", false, false), // #41 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsByRef","()Z", false, false), // #42 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsClass","()Z", false, false), // #43 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsCOMObject","()Z", false, false), // #44 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsContextful","()Z", false, false), // #45 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsEnum","()Z", false, false), // #46 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsExplicitLayout","()Z", false, false), // #47 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsGenericParameter","()Z", false, false), // #48 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsGenericType","()Z", false, false), // #49 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsGenericTypeDefinition","()Z", false, false), // #50 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsImport","()Z", false, false), // #51 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsInterface","()Z", false, false), // #52 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsLayoutSequential","()Z", false, false), // #53 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsMarshalByRef","()Z", false, false), // #54 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNested","()Z", false, false), // #55 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNestedAssembly","()Z", false, false), // #56 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNestedFamANDAssem","()Z", false, false), // #57 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNestedFamily","()Z", false, false), // #58 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNestedFamORAssem","()Z", false, false), // #59 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNestedPrivate","()Z", false, false), // #60 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNestedPublic","()Z", false, false), // #61 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNotPublic","()Z", false, false), // #62 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsPointer","()Z", false, false), // #63 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsPrimitive","()Z", false, false), // #64 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsPublic","()Z", false, false), // #65 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsSealed","()Z", false, false), // #66 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsSerializable","()Z", false, false), // #67 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsSpecialName","()Z", false, false), // #68 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsUnicodeClass","()Z", false, false), // #69 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsValueType","()Z", false, false), // #70 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsVisible","()Z", false, false), // #71 ()Z
                        new global::net.sf.jni4net.core.MemberId("getModule_95","()Lsystem/runtime/serialization/ISerializable;", false, false), // #72 ()LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("getNamespace","()Ljava/lang/String;", false, false), // #73 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getStructLayoutAttribute","()Lsystem/Object;", false, false), // #74 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getTypeHandle","()Lsystem/ValueType;", false, false), // #75 ()LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("getTypeInitializer","()Lsystem/reflection/ConstructorInfo;", false, false), // #76 ()LSystem/Reflection/ConstructorInfo;
                        new global::net.sf.jni4net.core.MemberId("getUnderlyingSystemType","()Lsystem/Type;", false, false), // #77 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetArrayRank","()I", false, false), // #78 ()I
                        new global::net.sf.jni4net.core.MemberId("GetConstructor","([Lsystem/Type;)Lsystem/reflection/ConstructorInfo;", false, false), // #79 ([LSystem/Type;)LSystem/Reflection/ConstructorInfo;
                        new global::net.sf.jni4net.core.MemberId("GetConstructor","(Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/ConstructorInfo;", false, false), // #80 (LSystem/Reflection/BindingFlags;Lsystem/Object;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/ConstructorInfo;
                        new global::net.sf.jni4net.core.MemberId("GetConstructor","(Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Enum;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/ConstructorInfo;", false, false), // #81 (LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Enum;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/ConstructorInfo;
                        new global::net.sf.jni4net.core.MemberId("GetConstructors","()[Lsystem/reflection/ConstructorInfo;", false, false), // #82 ()[LSystem/Reflection/ConstructorInfo;
                        new global::net.sf.jni4net.core.MemberId("GetConstructors","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/ConstructorInfo;", false, false), // #83 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/ConstructorInfo;
                        new global::net.sf.jni4net.core.MemberId("GetDefaultMembers","()[Lsystem/reflection/MemberInfo;", false, false), // #84 ()[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetElementType","()Lsystem/Type;", false, false), // #85 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetEvent","(Ljava/lang/String;)Lsystem/reflection/MemberInfo;", false, false), // #86 (Ljava/lang/String;)LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetEvent","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MemberInfo;", false, false), // #87 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetEvents","()[Lsystem/reflection/MemberInfo;", false, false), // #88 ()[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetEvents","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo;", false, false), // #89 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetField","(Ljava/lang/String;)Lsystem/reflection/FieldInfo;", false, false), // #90 (Ljava/lang/String;)LSystem/Reflection/FieldInfo;
                        new global::net.sf.jni4net.core.MemberId("GetField","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/FieldInfo;", false, false), // #91 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/FieldInfo;
                        new global::net.sf.jni4net.core.MemberId("GetFields","()[Lsystem/reflection/FieldInfo;", false, false), // #92 ()[LSystem/Reflection/FieldInfo;
                        new global::net.sf.jni4net.core.MemberId("GetFields","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/FieldInfo;", false, false), // #93 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/FieldInfo;
                        new global::net.sf.jni4net.core.MemberId("GetGenericArguments","()[Lsystem/Type;", false, false), // #94 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetGenericParameterConstraints","()[Lsystem/Type;", false, false), // #95 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetGenericTypeDefinition","()Lsystem/Type;", false, false), // #96 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetInterface","(Ljava/lang/String;)Lsystem/Type;", false, false), // #97 (Ljava/lang/String;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetInterface","(Ljava/lang/String;Z)Lsystem/Type;", false, false), // #98 (Ljava/lang/String;Z)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetInterfaceMap","(Lsystem/Type;)Lsystem/ValueType;", false, false), // #99 (LSystem/Type;)LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("GetInterfaces","()[Lsystem/Type;", false, false), // #100 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetMember","(Ljava/lang/String;)[Lsystem/reflection/MemberInfo;", false, false), // #101 (Ljava/lang/String;)[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMember","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo;", false, false), // #102 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMember","(Ljava/lang/String;Lsystem/Enum;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo;", false, false), // #103 (Ljava/lang/String;LSystem/Enum;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMembers","()[Lsystem/reflection/MemberInfo;", false, false), // #104 ()[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMembers","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo;", false, false), // #105 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethod","(Ljava/lang/String;)Lsystem/reflection/MethodInfo;", false, false), // #106 (Ljava/lang/String;)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethod","(Ljava/lang/String;[Lsystem/Type;)Lsystem/reflection/MethodInfo;", false, false), // #107 (Ljava/lang/String;[LSystem/Type;)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethod","(Ljava/lang/String;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo;", false, false), // #108 (Ljava/lang/String;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethod","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MethodInfo;", false, false), // #109 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethod","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo;", false, false), // #110 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethod","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Enum;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo;", false, false), // #111 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Enum;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethods","()[Lsystem/reflection/MethodInfo;", false, false), // #112 ()[LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethods","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MethodInfo;", false, false), // #113 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetNestedType","(Ljava/lang/String;)Lsystem/Type;", false, false), // #114 (Ljava/lang/String;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetNestedType","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/Type;", false, false), // #115 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetNestedTypes","()[Lsystem/Type;", false, false), // #116 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetNestedTypes","(Lsystem/reflection/BindingFlags;)[Lsystem/Type;", false, false), // #117 (LSystem/Reflection/BindingFlags;)[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetProperties","()[Lsystem/reflection/PropertyInfo;", false, false), // #118 ()[LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperties","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/PropertyInfo;", false, false), // #119 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;)Lsystem/reflection/PropertyInfo;", false, false), // #120 (Ljava/lang/String;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;[Lsystem/Type;)Lsystem/reflection/PropertyInfo;", false, false), // #121 (Ljava/lang/String;[LSystem/Type;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/PropertyInfo;", false, false), // #122 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo;", false, false), // #123 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Type;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;Lsystem/Type;)Lsystem/reflection/PropertyInfo;", false, false), // #124 (Ljava/lang/String;LSystem/Type;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;Lsystem/Type;[Lsystem/Type;)Lsystem/reflection/PropertyInfo;", false, false), // #125 (Ljava/lang/String;LSystem/Type;[LSystem/Type;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo;", false, false), // #126 (Ljava/lang/String;LSystem/Type;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetType_150","()Lsystem/Type;", false, false), // #127 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("InvokeMember","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #128 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("InvokeMember","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[Lsystem/ValueType;Lsystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object;", false, false), // #129 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[LSystem/ValueType;LSystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("InvokeMember","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object;", false, false), // #130 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;LSystem/ICloneable;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("IsAssignableFrom","(Lsystem/Type;)Z", false, false), // #131 (LSystem/Type;)Z
                        new global::net.sf.jni4net.core.MemberId("IsInstanceOfType","(Ljava/lang/Object;)Z", false, false), // #132 (Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("IsSubclassOf","(Lsystem/Type;)Z", false, false), // #133 (LSystem/Type;)Z
                        new global::net.sf.jni4net.core.MemberId("MakeArrayType","()Lsystem/Type;", false, false), // #134 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("MakeArrayType","(I)Lsystem/Type;", false, false), // #135 (I)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("MakeByRefType","()Lsystem/Type;", false, false), // #136 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("MakeGenericType","([Lsystem/Type;)Lsystem/Type;", false, false), // #137 ([LSystem/Type;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("MakePointerType","()Lsystem/Type;", false, false), // #138 ()LSystem/Type;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
