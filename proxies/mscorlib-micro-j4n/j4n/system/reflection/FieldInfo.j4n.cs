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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.FieldInfo_))]
    static public partial class FieldInfo_
    {
        static FieldInfo_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.MemberInfo_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.FieldInfo_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 GetFieldFromHandle(Lsystem/ValueType;)Lsystem/reflection/FieldInfo; (LSystem/RuntimeFieldHandle;)LSystem/Reflection/FieldInfo;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr handle)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.FieldInfo.GetFieldFromHandle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.RuntimeFieldHandle>(j4n_env, handle)), "system.reflection.FieldInfo");
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
        
        /// <signature>#1 GetFieldFromHandle(Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/FieldInfo; (LSystem/RuntimeFieldHandle;LSystem/RuntimeTypeHandle;)LSystem/Reflection/FieldInfo;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr handle, global::System.IntPtr declaringType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.FieldInfo.GetFieldFromHandle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.RuntimeFieldHandle>(j4n_env, handle), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.RuntimeTypeHandle>(j4n_env, declaringType)), "system.reflection.FieldInfo");
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
        
        /// <signature>#2 get_Attributes()Lsystem/Enum; ()LSystem/Reflection/FieldAttributes;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#3 get_FieldHandle()Lsystem/ValueType; ()LSystem/RuntimeFieldHandle;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.FieldHandle, "system.ValueType");
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
        
        /// <signature>#4 get_FieldType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.FieldType, "system.Type");
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
        
        /// <signature>#5 get_IsAssembly()Z ()Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#6 get_IsFamily()Z ()Z</signature>
        static bool j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#7 get_IsFamilyAndAssembly()Z ()Z</signature>
        static bool j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#8 get_IsFamilyOrAssembly()Z ()Z</signature>
        static bool j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#9 get_IsInitOnly()Z ()Z</signature>
        static bool j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsInitOnly;
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
        
        /// <signature>#10 get_IsLiteral()Z ()Z</signature>
        static bool j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsLiteral;
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
        
        /// <signature>#11 get_IsNotSerialized()Z ()Z</signature>
        static bool j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsNotSerialized;
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
        
        /// <signature>#12 get_IsPinvokeImpl()Z ()Z</signature>
        static bool j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsPinvokeImpl;
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
        
        /// <signature>#13 get_IsPrivate()Z ()Z</signature>
        static bool j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#14 get_IsPublic()Z ()Z</signature>
        static bool j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#15 get_IsSpecialName()Z ()Z</signature>
        static bool j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#16 get_IsStatic()Z ()Z</signature>
        static bool j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#17 GetOptionalCustomModifiers()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetOptionalCustomModifiers(), "system.Type");
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
        
        /// <signature>#18 GetRawConstantValue()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetRawConstantValue(), "java.lang.Object");
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
        
        /// <signature>#19 GetRequiredCustomModifiers()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetRequiredCustomModifiers(), "system.Type");
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
        
        /// <signature>#20 GetValue(Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj)), "java.lang.Object");
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
        
        /// <signature>#22 SetValue(Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/Object;Lsystem/Object;)V</signature>
        static void j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#23 SetValue(Ljava/lang/Object;Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/ICloneable;)V (Lsystem/Object;Lsystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;LSystem/Globalization/CultureInfo;)V</signature>
        static void j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj, global::System.IntPtr value, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Reflection.FieldInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture));
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
            lock (typeof(global::System.Reflection.FieldInfo))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.reflection.FieldInfo";
                    proxyInfo.JVMProxyName = "system.reflection.FieldInfo";
                    proxyInfo.JVMStaticApiName = "system.reflection.FieldInfo";
                    proxyInfo.CLRApi = typeof(System.Reflection.FieldInfo);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.FieldInfo_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("GetFieldFromHandle","(Lsystem/ValueType;)Lsystem/reflection/FieldInfo;", false, true), // #0 (LSystem/ValueType;)LSystem/Reflection/FieldInfo;
                        new global::net.sf.jni4net.core.MemberId("GetFieldFromHandle","(Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/FieldInfo;", false, true), // #1 (LSystem/ValueType;LSystem/ValueType;)LSystem/Reflection/FieldInfo;
                        new global::net.sf.jni4net.core.MemberId("getAttributes","()Lsystem/Enum;", false, false), // #2 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getFieldHandle","()Lsystem/ValueType;", false, false), // #3 ()LSystem/ValueType;
                        new global::net.sf.jni4net.core.MemberId("getFieldType","()Lsystem/Type;", false, false), // #4 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("getIsAssembly","()Z", false, false), // #5 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsFamily","()Z", false, false), // #6 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsFamilyAndAssembly","()Z", false, false), // #7 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsFamilyOrAssembly","()Z", false, false), // #8 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsInitOnly","()Z", false, false), // #9 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsLiteral","()Z", false, false), // #10 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsNotSerialized","()Z", false, false), // #11 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsPinvokeImpl","()Z", false, false), // #12 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsPrivate","()Z", false, false), // #13 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsPublic","()Z", false, false), // #14 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsSpecialName","()Z", false, false), // #15 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsStatic","()Z", false, false), // #16 ()Z
                        new global::net.sf.jni4net.core.MemberId("GetOptionalCustomModifiers","()[Lsystem/Type;", false, false), // #17 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetRawConstantValue","()Ljava/lang/Object;", false, false), // #18 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetRequiredCustomModifiers","()[Lsystem/Type;", false, false), // #19 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #20 (Ljava/lang/Object;)Ljava/lang/Object;
                        null, // #21 IsJvmSkip: GetValueDirect
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;Ljava/lang/Object;)V", false, false), // #22 (Ljava/lang/Object;Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/ICloneable;)V", false, false), // #23 (Ljava/lang/Object;Ljava/lang/Object;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/ICloneable;)V
                        null, // #24 IsJvmSkip: SetValueDirect
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
