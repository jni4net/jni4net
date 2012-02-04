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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.BindingFlags_))]
    static public partial class BindingFlags_
    {
        static BindingFlags_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Enum_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.BindingFlags_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 CreateInstance()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.CreateInstance, "system.reflection.BindingFlags");
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
        
        /// <signature>#1 DeclaredOnly()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.DeclaredOnly, "system.reflection.BindingFlags");
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
        
        /// <signature>#2 Default()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.Default, "system.reflection.BindingFlags");
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
        
        /// <signature>#3 ExactBinding()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.ExactBinding, "system.reflection.BindingFlags");
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
        
        /// <signature>#4 FlattenHierarchy()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.FlattenHierarchy, "system.reflection.BindingFlags");
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
        
        /// <signature>#5 GetField()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.GetField, "system.reflection.BindingFlags");
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
        
        /// <signature>#6 GetProperty()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.GetProperty, "system.reflection.BindingFlags");
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
        
        /// <signature>#7 IgnoreCase()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.IgnoreCase, "system.reflection.BindingFlags");
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
        
        /// <signature>#8 IgnoreReturn()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.IgnoreReturn, "system.reflection.BindingFlags");
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
        
        /// <signature>#9 Instance()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.Instance, "system.reflection.BindingFlags");
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
        
        /// <signature>#10 InvokeMethod()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.InvokeMethod, "system.reflection.BindingFlags");
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
        
        /// <signature>#11 NonPublic()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.NonPublic, "system.reflection.BindingFlags");
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
        
        /// <signature>#12 OptionalParamBinding()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.OptionalParamBinding, "system.reflection.BindingFlags");
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
        
        /// <signature>#13 Public()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.Public, "system.reflection.BindingFlags");
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
        
        /// <signature>#14 PutDispProperty()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.PutDispProperty, "system.reflection.BindingFlags");
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
        
        /// <signature>#15 PutRefDispProperty()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.PutRefDispProperty, "system.reflection.BindingFlags");
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
        
        /// <signature>#16 SetField()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.SetField, "system.reflection.BindingFlags");
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
        
        /// <signature>#17 SetProperty()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.SetProperty, "system.reflection.BindingFlags");
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
        
        /// <signature>#18 Static()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.Static, "system.reflection.BindingFlags");
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
        
        /// <signature>#19 SuppressChangeType()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.BindingFlags.SuppressChangeType, "system.reflection.BindingFlags");
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
            lock (typeof(global::System.Reflection.BindingFlags))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.reflection.BindingFlags";
                    proxyInfo.JVMProxyName = "system.reflection.BindingFlags";
                    proxyInfo.JVMStaticApiName = "system.reflection.BindingFlags";
                    proxyInfo.CLRApi = typeof(System.Reflection.BindingFlags);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.BindingFlags_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","()Lsystem/reflection/BindingFlags;", true, true), // #0 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("DeclaredOnly","()Lsystem/reflection/BindingFlags;", true, true), // #1 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("Default","()Lsystem/reflection/BindingFlags;", true, true), // #2 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("ExactBinding","()Lsystem/reflection/BindingFlags;", true, true), // #3 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("FlattenHierarchy","()Lsystem/reflection/BindingFlags;", true, true), // #4 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("GetField","()Lsystem/reflection/BindingFlags;", true, true), // #5 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","()Lsystem/reflection/BindingFlags;", true, true), // #6 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("IgnoreCase","()Lsystem/reflection/BindingFlags;", true, true), // #7 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("IgnoreReturn","()Lsystem/reflection/BindingFlags;", true, true), // #8 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("Instance","()Lsystem/reflection/BindingFlags;", true, true), // #9 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("InvokeMethod","()Lsystem/reflection/BindingFlags;", true, true), // #10 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("NonPublic","()Lsystem/reflection/BindingFlags;", true, true), // #11 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("OptionalParamBinding","()Lsystem/reflection/BindingFlags;", true, true), // #12 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("Public","()Lsystem/reflection/BindingFlags;", true, true), // #13 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("PutDispProperty","()Lsystem/reflection/BindingFlags;", true, true), // #14 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("PutRefDispProperty","()Lsystem/reflection/BindingFlags;", true, true), // #15 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("SetField","()Lsystem/reflection/BindingFlags;", true, true), // #16 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("SetProperty","()Lsystem/reflection/BindingFlags;", true, true), // #17 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("Static","()Lsystem/reflection/BindingFlags;", true, true), // #18 ()LSystem/Reflection/BindingFlags;
                        new global::net.sf.jni4net.core.MemberId("SuppressChangeType","()Lsystem/reflection/BindingFlags;", true, true), // #19 ()LSystem/Reflection/BindingFlags;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
