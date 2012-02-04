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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.PropertyInfo_))]
    static public partial class PropertyInfo_
    {
        static PropertyInfo_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.MemberInfo_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.PropertyInfo_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 get_Attributes()Lsystem/Enum; ()LSystem/Reflection/PropertyAttributes;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#1 get_CanRead()Z ()Z</signature>
        static bool j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.CanRead;
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
        
        /// <signature>#2 get_CanWrite()Z ()Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.CanWrite;
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
        
        /// <signature>#3 get_IsSpecialName()Z ()Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#4 get_PropertyType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.PropertyType, "system.Type");
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
        
        /// <signature>#5 GetAccessors()[Lsystem/reflection/MethodInfo; ()[LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetAccessors(), "system.reflection.MethodInfo");
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
        
        /// <signature>#6 GetAccessors(Z)[Lsystem/reflection/MethodInfo; (Z)[LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool nonPublic)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetAccessors(nonPublic), "system.reflection.MethodInfo");
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
        
        /// <signature>#7 GetConstantValue()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetConstantValue(), "java.lang.Object");
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
        
        /// <signature>#8 GetGetMethod()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetGetMethod(), "system.reflection.MethodInfo");
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
        
        /// <signature>#9 GetGetMethod(Z)Lsystem/reflection/MethodInfo; (Z)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool nonPublic)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetGetMethod(nonPublic), "system.reflection.MethodInfo");
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
        
        /// <signature>#10 GetIndexParameters()[Lsystem/reflection/ParameterInfo; ()[LSystem/Reflection/ParameterInfo;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetIndexParameters(), "system.reflection.ParameterInfo");
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
        
        /// <signature>#11 GetOptionalCustomModifiers()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#12 GetRawConstantValue()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#13 GetRequiredCustomModifiers()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#14 GetSetMethod()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetSetMethod(), "system.reflection.MethodInfo");
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
        
        /// <signature>#15 GetSetMethod(Z)Lsystem/reflection/MethodInfo; (Z)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool nonPublic)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetSetMethod(nonPublic), "system.reflection.MethodInfo");
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
        
        /// <signature>#16 GetValue(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;[Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj, global::System.IntPtr index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, index)), "java.lang.Object");
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
        
        /// <signature>#17 GetValue(Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object; (Lsystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[Lsystem/Object;LSystem/Globalization/CultureInfo;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr index, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, index), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture)), "java.lang.Object");
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
        
        /// <signature>#18 SetValue(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)V (Lsystem/Object;Lsystem/Object;[Lsystem/Object;)V</signature>
        static void j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj, global::System.IntPtr value, global::System.IntPtr index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, index));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#19 SetValue(Ljava/lang/Object;Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)V (Lsystem/Object;Lsystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[Lsystem/Object;LSystem/Globalization/CultureInfo;)V</signature>
        static void j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj, global::System.IntPtr value, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr index, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                global::System.Reflection.PropertyInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, index), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture));
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
            lock (typeof(global::System.Reflection.PropertyInfo))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.reflection.PropertyInfo";
                    proxyInfo.JVMProxyName = "system.reflection.PropertyInfo";
                    proxyInfo.JVMStaticApiName = "system.reflection.PropertyInfo";
                    proxyInfo.CLRApi = typeof(System.Reflection.PropertyInfo);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.PropertyInfo_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getAttributes","()Lsystem/Enum;", false, false), // #0 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getCanRead","()Z", false, false), // #1 ()Z
                        new global::net.sf.jni4net.core.MemberId("getCanWrite","()Z", false, false), // #2 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsSpecialName","()Z", false, false), // #3 ()Z
                        new global::net.sf.jni4net.core.MemberId("getPropertyType","()Lsystem/Type;", false, false), // #4 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetAccessors","()[Lsystem/reflection/MethodInfo;", false, false), // #5 ()[LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetAccessors","(Z)[Lsystem/reflection/MethodInfo;", false, false), // #6 (Z)[LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetConstantValue","()Ljava/lang/Object;", false, false), // #7 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetGetMethod","()Lsystem/reflection/MethodInfo;", false, false), // #8 ()LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetGetMethod","(Z)Lsystem/reflection/MethodInfo;", false, false), // #9 (Z)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetIndexParameters","()[Lsystem/reflection/ParameterInfo;", false, false), // #10 ()[LSystem/Reflection/ParameterInfo;
                        new global::net.sf.jni4net.core.MemberId("GetOptionalCustomModifiers","()[Lsystem/Type;", false, false), // #11 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetRawConstantValue","()Ljava/lang/Object;", false, false), // #12 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetRequiredCustomModifiers","()[Lsystem/Type;", false, false), // #13 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetSetMethod","()Lsystem/reflection/MethodInfo;", false, false), // #14 ()LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetSetMethod","(Z)Lsystem/reflection/MethodInfo;", false, false), // #15 (Z)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #16 (Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object;", false, false), // #17 (Ljava/lang/Object;LSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)V", false, false), // #18 (Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)V", false, false), // #19 (Ljava/lang/Object;Ljava/lang/Object;LSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
