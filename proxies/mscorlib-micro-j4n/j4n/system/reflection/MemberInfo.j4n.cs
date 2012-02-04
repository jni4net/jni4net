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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.MemberInfo_))]
    static public partial class MemberInfo_
    {
        static MemberInfo_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Reflection.ICustomAttributeProvider_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.ICustomAttributeProvider_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.MemberInfo_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 get_DeclaringType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MemberInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.DeclaringType, "system.Type");
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
        
        /// <signature>#1 get_MemberType()Lsystem/Enum; ()LSystem/Reflection/MemberTypes;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MemberInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.MemberType, "system.Enum");
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
        
        /// <signature>#2 get_MetadataToken()I ()I</signature>
        static int j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MemberInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberInfo>(j4n_env, j4n_self);
                int j4n_result = j4n_real.MetadataToken;
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
        
        /// <signature>#3 get_Module()Lsystem/runtime/serialization/ISerializable; ()LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MemberInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#4 get_Name()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MemberInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberInfo>(j4n_env, j4n_self);
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
        
        /// <signature>#5 get_ReflectedType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MemberInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MemberInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ReflectedType, "system.Type");
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
        
        /// <signature>#6 GetCustomAttributes(Z)[Ljava/lang/Object; (Z)[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetCustomAttributes(inherit), "java.lang.Object");
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
        
        /// <signature>#7 GetCustomAttributes(Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr attributeType, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetCustomAttributes(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, attributeType), inherit), "java.lang.Object");
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
        
        /// <signature>#8 IsDefined(Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
        static bool j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr attributeType, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsDefined(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, attributeType), inherit);
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
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Reflection.MemberInfo))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.reflection.MemberInfo";
                    proxyInfo.JVMProxyName = "system.reflection.MemberInfo";
                    proxyInfo.JVMStaticApiName = "system.reflection.MemberInfo";
                    proxyInfo.CLRApi = typeof(System.Reflection.MemberInfo);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.MemberInfo_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getDeclaringType","()Lsystem/Type;", false, false), // #0 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("getMemberType","()Lsystem/Enum;", false, false), // #1 ()LSystem/Enum;
                        new global::net.sf.jni4net.core.MemberId("getMetadataToken","()I", false, false), // #2 ()I
                        new global::net.sf.jni4net.core.MemberId("getModule","()Lsystem/runtime/serialization/ISerializable;", false, false), // #3 ()LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("getName","()Ljava/lang/String;", false, false), // #4 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getReflectedType","()Lsystem/Type;", false, false), // #5 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetCustomAttributes","(Z)[Ljava/lang/Object;", false, false), // #6 (Z)[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetCustomAttributes","(Lsystem/Type;Z)[Ljava/lang/Object;", false, false), // #7 (LSystem/Type;Z)[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("IsDefined","(Lsystem/Type;Z)Z", false, false), // #8 (LSystem/Type;Z)Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
