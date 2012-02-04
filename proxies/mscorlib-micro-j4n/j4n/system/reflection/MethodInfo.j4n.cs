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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.MethodInfo_))]
    static public partial class MethodInfo_
    {
        static MethodInfo_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.MethodBase_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.MethodInfo_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 get_ReturnParameter()Lsystem/reflection/ParameterInfo; ()LSystem/Reflection/ParameterInfo;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ReturnParameter, "system.reflection.ParameterInfo");
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
        
        /// <signature>#1 get_ReturnType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ReturnType, "system.Type");
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
        
        /// <signature>#2 get_ReturnTypeCustomAttributes()Lsystem/reflection/ICustomAttributeProvider; ()LSystem/Reflection/ICustomAttributeProvider;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ReturnTypeCustomAttributes, "system.reflection.ICustomAttributeProvider");
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
        
        /// <signature>#3 GetBaseDefinition()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetBaseDefinition(), "system.reflection.MethodInfo");
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
        
        /// <signature>#4 GetGenericMethodDefinition()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.MethodInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetGenericMethodDefinition(), "system.reflection.MethodInfo");
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
        
        /// <signature>#5 MakeGenericMethod([Lsystem/Type;)Lsystem/reflection/MethodInfo; ([LSystem/Type;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr typeArguments)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.MethodInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.MakeGenericMethod(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type[]>(j4n_env, typeArguments)), "system.reflection.MethodInfo");
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
            lock (typeof(global::System.Reflection.MethodInfo))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.reflection.MethodInfo";
                    proxyInfo.JVMProxyName = "system.reflection.MethodInfo";
                    proxyInfo.JVMStaticApiName = "system.reflection.MethodInfo";
                    proxyInfo.CLRApi = typeof(System.Reflection.MethodInfo);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.MethodInfo_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getReturnParameter","()Lsystem/reflection/ParameterInfo;", false, false), // #0 ()LSystem/Reflection/ParameterInfo;
                        new global::net.sf.jni4net.core.MemberId("getReturnType","()Lsystem/Type;", false, false), // #1 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("getReturnTypeCustomAttributes","()Lsystem/reflection/ICustomAttributeProvider;", false, false), // #2 ()LSystem/Reflection/ICustomAttributeProvider;
                        new global::net.sf.jni4net.core.MemberId("GetBaseDefinition","()Lsystem/reflection/MethodInfo;", false, false), // #3 ()LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetGenericMethodDefinition","()Lsystem/reflection/MethodInfo;", false, false), // #4 ()LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("MakeGenericMethod","([Lsystem/Type;)Lsystem/reflection/MethodInfo;", false, false), // #5 ([LSystem/Type;)LSystem/Reflection/MethodInfo;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
