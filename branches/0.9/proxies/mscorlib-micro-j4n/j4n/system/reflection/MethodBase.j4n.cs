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

namespace System.Reflection
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.MethodBase_))]
    static public partial class MethodBase_
    {
        static MethodBase_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.MemberInfo_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.MethodBase_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 GetCurrentMethod()Lsystem/reflection/MethodBase; ()LSystem/Reflection/MethodBase;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.MethodBase.GetCurrentMethod(), "system.reflection.MethodBase");
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
        
        /// <signature>#1 GetMethodFromHandle(Lsystem/ValueType;)Lsystem/reflection/MethodBase; (LSystem/RuntimeMethodHandle;)LSystem/Reflection/MethodBase;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr handle)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.MethodBase.GetMethodFromHandle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.RuntimeMethodHandle>(j4n_env, handle)), "system.reflection.MethodBase");
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
        
        /// <signature>#2 GetMethodFromHandle(Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/MethodBase; (LSystem/RuntimeMethodHandle;LSystem/RuntimeTypeHandle;)LSystem/Reflection/MethodBase;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr handle, global::System.IntPtr declaringType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.MethodBase.GetMethodFromHandle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.RuntimeMethodHandle>(j4n_env, handle), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.RuntimeTypeHandle>(j4n_env, declaringType)), "system.reflection.MethodBase");
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
        
        /// <signature>#3 get_Attributes()Lsystem/Enum; ()LSystem/Reflection/MethodAttributes;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
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
        
        /// <signature>#4 get_CallingConvention()Lsystem/Enum; ()LSystem/Reflection/CallingConventions;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.CallingConvention, "system.Enum");
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
        
        /// <signature>#5 get_ContainsGenericParameters()Z ()Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
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
        
        /// <signature>#6 get_IsAbstract()Z ()Z</signature>
        static bool j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
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
        
        /// <signature>#7 get_IsAssembly()Z ()Z</signature>
        static bool j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsAssembly;
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
        
        /// <signature>#8 get_IsConstructor()Z ()Z</signature>
        static bool j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsConstructor;
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
        
        /// <signature>#9 get_IsFamily()Z ()Z</signature>
        static bool j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsFamily;
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
        
        /// <signature>#10 get_IsFamilyAndAssembly()Z ()Z</signature>
        static bool j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsFamilyAndAssembly;
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
        
        /// <signature>#11 get_IsFamilyOrAssembly()Z ()Z</signature>
        static bool j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsFamilyOrAssembly;
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
        
        /// <signature>#12 get_IsFinal()Z ()Z</signature>
        static bool j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsFinal;
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
        
        /// <signature>#13 get_IsGenericMethod()Z ()Z</signature>
        static bool j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsGenericMethod;
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
        
        /// <signature>#14 get_IsGenericMethodDefinition()Z ()Z</signature>
        static bool j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsGenericMethodDefinition;
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
        
        /// <signature>#15 get_IsHideBySig()Z ()Z</signature>
        static bool j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsHideBySig;
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
        
        /// <signature>#16 get_IsPrivate()Z ()Z</signature>
        static bool j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsPrivate;
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
        
        /// <signature>#17 get_IsPublic()Z ()Z</signature>
        static bool j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
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
        
        /// <signature>#18 get_IsSpecialName()Z ()Z</signature>
        static bool j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
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
        
        /// <signature>#19 get_IsStatic()Z ()Z</signature>
        static bool j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsStatic;
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
        
        /// <signature>#20 get_IsVirtual()Z ()Z</signature>
        static bool j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsVirtual;
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
        
        /// <signature>#21 get_MethodHandle()Lsystem/ValueType; ()LSystem/RuntimeMethodHandle;</signature>
        static global::System.IntPtr j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.MethodHandle, "system.ValueType");
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
        
        /// <signature>#22 GetGenericArguments()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
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
        
        /// <signature>#23 GetMethodBody()Lsystem/Object; ()LSystem/Reflection/MethodBody;</signature>
        static global::System.IntPtr j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethodBody(), "system.Object");
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
        
        /// <signature>#24 GetMethodImplementationFlags()Lsystem/Enum; ()LSystem/Reflection/MethodImplAttributes;</signature>
        static global::System.IntPtr j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetMethodImplementationFlags(), "system.Enum");
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
        
        /// <signature>#25 GetParameters()[Lsystem/reflection/ParameterInfo; ()[LSystem/Reflection/ParameterInfo;</signature>
        static global::System.IntPtr j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetParameters(), "system.reflection.ParameterInfo");
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
        
        /// <signature>#26 Invoke(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;[Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj, global::System.IntPtr parameters)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Invoke(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, parameters)), "java.lang.Object");
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
        
        /// <signature>#27 Invoke(Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object; (Lsystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[Lsystem/Object;LSystem/Globalization/CultureInfo;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr parameters, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Reflection.MethodBase j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodBase>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Invoke(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, parameters), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture)), "java.lang.Object");
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
            lock (typeof(global::System.Reflection.MethodBase))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.reflection.MethodBase";
                    proxyInfo.JVMProxyName = "system.reflection.MethodBase";
                    proxyInfo.JVMStaticApiName = "system.reflection.MethodBase";
                    proxyInfo.CLRApi = typeof(System.Reflection.MethodBase);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.MethodBase_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("GetCurrentMethod","()Lsystem/reflection/MethodBase;", false, true), // #0 ()LSystem/Reflection/MethodBase;
                        new global::net.sf.jni4net.core.MemberId("GetMethodFromHandle","(Lsystem/ValueType;)Lsystem/reflection/MethodBase;", false, true), // #1 (LSystem/ValueType;)LSystem/Reflection/MethodBase;
                        new global::net.sf.jni4net.core.MemberId("GetMethodFromHandle","(Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/MethodBase;", false, true), // #2 (LSystem/ValueType;LSystem/ValueType;)LSystem/Reflection/MethodBase;
                        new global::net.sf.jni4net.core.MemberId("getAttributes","()Lsystem/Enum;", false, false), // #3 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getCallingConvention","()Lsystem/Enum;", false, false), // #4 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getContainsGenericParameters","()Z", false, false), // #5 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsAbstract","()Z", false, false), // #6 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsAssembly","()Z", false, false), // #7 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsConstructor","()Z", false, false), // #8 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsFamily","()Z", false, false), // #9 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsFamilyAndAssembly","()Z", false, false), // #10 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsFamilyOrAssembly","()Z", false, false), // #11 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsFinal","()Z", false, false), // #12 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsGenericMethod","()Z", false, false), // #13 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsGenericMethodDefinition","()Z", false, false), // #14 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsHideBySig","()Z", false, false), // #15 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsPrivate","()Z", false, false), // #16 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsPublic","()Z", false, false), // #17 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsSpecialName","()Z", false, false), // #18 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsStatic","()Z", false, false), // #19 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsVirtual","()Z", false, false), // #20 ()Z
                        new global::net.sf.jni4net.core.MemberId("getMethodHandle","()Lsystem/ValueType;", false, false), // #21 ()LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("GetGenericArguments","()[Lsystem/Type;", false, false), // #22 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetMethodBody","()Lsystem/Object;", false, false), // #23 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("GetMethodImplementationFlags","()Lsystem/Enum;", false, false), // #24 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("GetParameters","()[Lsystem/reflection/ParameterInfo;", false, false), // #25 ()[LSystem/Reflection/ParameterInfo;
                        new global::net.sf.jni4net.core.MemberId("Invoke","(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #26 (Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("Invoke","(Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object;", false, false), // #27 (Ljava/lang/Object;LSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;)Ljava/lang/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
