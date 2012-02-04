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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Enum_))]
    static public partial class Enum_
    {
        static Enum_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ValueType_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IComparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IFormattable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IFormattable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.IConvertible_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Enum_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 Format(Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String; (LSystem/Type;Lsystem/Object;Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, global::System.IntPtr value, global::System.IntPtr format)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.Format(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format)), "java.lang.String");
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
        
        /// <signature>#1 GetName(Lsystem/Type;Ljava/lang/Object;)Ljava/lang/String; (LSystem/Type;Lsystem/Object;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.GetName(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value)), "java.lang.String");
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
        
        /// <signature>#2 GetNames(Lsystem/Type;)[Ljava/lang/String; (LSystem/Type;)[Lsystem/String;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.GetNames(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType)), "java.lang.String");
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
        
        /// <signature>#3 GetUnderlyingType(Lsystem/Type;)Lsystem/Type; (LSystem/Type;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.GetUnderlyingType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType)), "system.Type");
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
        
        /// <signature>#4 GetValues(Lsystem/Type;)Lsystem/Array; (LSystem/Type;)LSystem/Array;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.GetValues(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType)), "system.Array");
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
        
        /// <signature>#5 IsDefined(Lsystem/Type;Ljava/lang/Object;)Z (LSystem/Type;Lsystem/Object;)Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = global::System.Enum.IsDefined(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#6 Parse(Lsystem/Type;Ljava/lang/String;)Ljava/lang/Object; (LSystem/Type;Lsystem/String;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.Parse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value)), "java.lang.Object");
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
        
        /// <signature>#7 Parse(Lsystem/Type;Ljava/lang/String;Z)Ljava/lang/Object; (LSystem/Type;Lsystem/String;Z)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, global::System.IntPtr value, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.Parse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value), ignoreCase), "java.lang.Object");
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
        
        /// <signature>#8 ToObject(Lsystem/Type;B)Ljava/lang/Object; (LSystem/Type;B)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, byte value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), value), "java.lang.Object");
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
        
        /// <signature>#9 ToObject(Lsystem/Type;S)Ljava/lang/Object; (LSystem/Type;S)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, short value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), value), "java.lang.Object");
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
        
        /// <signature>#10 ToObject(Lsystem/Type;I)Ljava/lang/Object; (LSystem/Type;I)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), value), "java.lang.Object");
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
        
        /// <signature>#11 ToObject(Lsystem/Type;J)Ljava/lang/Object; (LSystem/Type;J)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, long value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), value), "java.lang.Object");
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
        
        /// <signature>#12 ToObject(Lsystem/Type;Ljava/lang/Object;)Ljava/lang/Object; (LSystem/Type;Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value)), "java.lang.Object");
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
        
        /// <signature>#13 ToObject(Lsystem/Type;B)Ljava/lang/Object; (LSystem/Type;b)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, sbyte value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), value), "java.lang.Object");
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
        
        /// <signature>#14 ToObject(Lsystem/Type;S)Ljava/lang/Object; (LSystem/Type;s)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, ushort value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), value), "java.lang.Object");
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
        
        /// <signature>#15 ToObject(Lsystem/Type;I)Ljava/lang/Object; (LSystem/Type;i)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, uint value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), value), "java.lang.Object");
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
        
        /// <signature>#16 ToObject(Lsystem/Type;J)Ljava/lang/Object; (LSystem/Type;j)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr enumType, ulong value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Enum.ToObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, enumType), value), "java.lang.Object");
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
        
        /// <signature>#17 CompareTo(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr target)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IComparable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IComparable>(j4n_env, j4n_self);
                int j4n_result = j4n_real.CompareTo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, target));
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
        
        /// <signature>#18 GetTypeCode()Lsystem/Enum; ()LSystem/TypeCode;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetTypeCode(), "system.Enum");
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
        
        /// <signature>#19 ToBoolean(Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
        static bool j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.ToBoolean(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#20 ToByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
        static byte j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                byte j4n_result = j4n_real.ToByte(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(byte);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#21 ToChar(Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
        static char j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                char j4n_result = j4n_real.ToChar(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#22 ToDateTime(Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToDateTime(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "system.DateTime");
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
        
        /// <signature>#23 ToDecimal(Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
        static global::System.IntPtr j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToDecimal(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "system.Decimal");
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
        
        /// <signature>#24 ToDouble(Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
        static double j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                double j4n_result = j4n_real.ToDouble(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(double);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#25 ToInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
        static short j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                short j4n_result = j4n_real.ToInt16(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(short);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#26 ToInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
        static int j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                int j4n_result = j4n_real.ToInt32(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
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
        
        /// <signature>#27 ToInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
        static long j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                long j4n_result = j4n_real.ToInt64(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
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
        
        /// <signature>#28 ToSByte(Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)b</signature>
        static sbyte j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                sbyte j4n_result = j4n_real.ToSByte(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(sbyte);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#29 ToSingle(Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
        static float j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                float j4n_result = j4n_real.ToSingle(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(float);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#30 ToString(Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToString(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "java.lang.String");
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
        
        /// <signature>#31 ToString(Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Enum j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Enum>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToString(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format)), "java.lang.String");
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
        
        /// <signature>#32 ToString(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String; (Lsystem/String;LSystem/IFormatProvider;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr format, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IFormattable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormattable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToString(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, format), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "java.lang.String");
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
        
        /// <signature>#33 ToType(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider)), "java.lang.Object");
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
        
        /// <signature>#34 ToUInt16(Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)s</signature>
        static ushort j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                ushort j4n_result = j4n_real.ToUInt16(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(ushort);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#35 ToUInt32(Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)i</signature>
        static uint j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                uint j4n_result = j4n_real.ToUInt32(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(uint);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#36 ToUInt64(Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)j</signature>
        static ulong j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr provider)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.IConvertible j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IConvertible>(j4n_env, j4n_self);
                ulong j4n_result = j4n_real.ToUInt64(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.IFormatProvider>(j4n_env, provider));
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(ulong);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Enum))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Enum";
                    proxyInfo.JVMProxyName = "system.Enum";
                    proxyInfo.JVMStaticApiName = "system.Enum";
                    proxyInfo.CLRApi = typeof(System.Enum);
                    proxyInfo.CLRStaticApi = typeof(System.Enum_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Format","(Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", false, true), // #0 (LSystem/Type;Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetName","(Lsystem/Type;Ljava/lang/Object;)Ljava/lang/String;", false, true), // #1 (LSystem/Type;Ljava/lang/Object;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetNames","(Lsystem/Type;)[Ljava/lang/String;", false, true), // #2 (LSystem/Type;)[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetUnderlyingType","(Lsystem/Type;)Lsystem/Type;", false, true), // #3 (LSystem/Type;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetValues","(Lsystem/Type;)Lsystem/Array;", false, true), // #4 (LSystem/Type;)LSystem/Array;
                        new global::net.sf.jni4net.core.MemberId("IsDefined","(Lsystem/Type;Ljava/lang/Object;)Z", false, true), // #5 (LSystem/Type;Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("Parse","(Lsystem/Type;Ljava/lang/String;)Ljava/lang/Object;", false, true), // #6 (LSystem/Type;Ljava/lang/String;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("Parse","(Lsystem/Type;Ljava/lang/String;Z)Ljava/lang/Object;", false, true), // #7 (LSystem/Type;Ljava/lang/String;Z)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToObject","(Lsystem/Type;B)Ljava/lang/Object;", false, true), // #8 (LSystem/Type;B)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToObject","(Lsystem/Type;S)Ljava/lang/Object;", false, true), // #9 (LSystem/Type;S)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToObject","(Lsystem/Type;I)Ljava/lang/Object;", false, true), // #10 (LSystem/Type;I)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToObject","(Lsystem/Type;J)Ljava/lang/Object;", false, true), // #11 (LSystem/Type;J)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToObject","(Lsystem/Type;Ljava/lang/Object;)Ljava/lang/Object;", false, true), // #12 (LSystem/Type;Ljava/lang/Object;)Ljava/lang/Object;
                        null, // #13 IsJvmSkip: ToObject
                        null, // #14 IsJvmSkip: ToObject
                        null, // #15 IsJvmSkip: ToObject
                        null, // #16 IsJvmSkip: ToObject
                        new global::net.sf.jni4net.core.MemberId("CompareTo","(Ljava/lang/Object;)I", false, false), // #17 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("GetTypeCode","()Lsystem/Enum;", false, false), // #18 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("ToBoolean","(Lsystem/IFormatProvider;)Z", false, false), // #19 (LSystem/IFormatProvider;)Z
                        new global::net.sf.jni4net.core.MemberId("ToByte","(Lsystem/IFormatProvider;)B", false, false), // #20 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToChar","(Lsystem/IFormatProvider;)C", false, false), // #21 (LSystem/IFormatProvider;)C
                        new global::net.sf.jni4net.core.MemberId("ToDateTime","(Lsystem/IFormatProvider;)Lsystem/DateTime;", false, false), // #22 (LSystem/IFormatProvider;)LSystem/DateTime;
                        new global::net.sf.jni4net.core.MemberId("ToDecimal","(Lsystem/IFormatProvider;)Lsystem/Decimal;", false, false), // #23 (LSystem/IFormatProvider;)LSystem/Decimal;
                        new global::net.sf.jni4net.core.MemberId("ToDouble","(Lsystem/IFormatProvider;)D", false, false), // #24 (LSystem/IFormatProvider;)D
                        new global::net.sf.jni4net.core.MemberId("ToInt16","(Lsystem/IFormatProvider;)S", false, false), // #25 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToInt32","(Lsystem/IFormatProvider;)I", false, false), // #26 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToInt64","(Lsystem/IFormatProvider;)J", false, false), // #27 (LSystem/IFormatProvider;)J
                        new global::net.sf.jni4net.core.MemberId("ToSByte","(Lsystem/IFormatProvider;)B", false, false), // #28 (LSystem/IFormatProvider;)B
                        new global::net.sf.jni4net.core.MemberId("ToSingle","(Lsystem/IFormatProvider;)F", false, false), // #29 (LSystem/IFormatProvider;)F
                        new global::net.sf.jni4net.core.MemberId("ToString","(Lsystem/IFormatProvider;)Ljava/lang/String;", false, false), // #30 (LSystem/IFormatProvider;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToString","(Ljava/lang/String;)Ljava/lang/String;", false, false), // #31 (Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToString","(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;", false, false), // #32 (Ljava/lang/String;LSystem/IFormatProvider;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("ToType","(Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object;", false, false), // #33 (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("ToUInt16","(Lsystem/IFormatProvider;)S", false, false), // #34 (LSystem/IFormatProvider;)S
                        new global::net.sf.jni4net.core.MemberId("ToUInt32","(Lsystem/IFormatProvider;)I", false, false), // #35 (LSystem/IFormatProvider;)I
                        new global::net.sf.jni4net.core.MemberId("ToUInt64","(Lsystem/IFormatProvider;)J", false, false), // #36 (LSystem/IFormatProvider;)J
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
