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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.IReflect_))]
    static public partial class IReflect_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static IReflect_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Reflection.IReflect_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.IReflect_));
        }
        
        /// <signature>#0 get_UnderlyingSystemType()Lsystem/Type; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#1 GetField(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/FieldInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/FieldInfo;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#2 GetFields(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/FieldInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/FieldInfo;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#3 GetMember(Ljava/lang/String;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#4 GetMembers(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#5 GetMethod(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MethodInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#6 GetMethod(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr, global::System.IntPtr binder, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#7 GetMethods(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MethodInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#8 GetProperties(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/PropertyInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#9 GetProperty(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#10 GetProperty(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;LSystem/Type;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/PropertyInfo;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr bindingAttr, global::System.IntPtr binder, global::System.IntPtr returnType, global::System.IntPtr types, global::System.IntPtr modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        /// <signature>#11 InvokeMember(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[Lsystem/ValueType;Lsystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;Lsystem/Object;[Lsystem/Object;[LSystem/Reflection/ParameterModifier;LSystem/Globalization/CultureInfo;[Lsystem/String;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr target, global::System.IntPtr args, global::System.IntPtr modifiers, global::System.IntPtr culture, global::System.IntPtr namedParameters)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 26);
            try
            {
                System.Reflection.IReflect j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.IReflect>(j4n_env, j4n_self);
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
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Reflection.IReflect))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "system.reflection.IReflect";
                    proxyInfo.JVMProxyName = "system.reflection._IReflect";
                    proxyInfo.JVMStaticApiName = "system.reflection.IReflect_";
                    proxyInfo.CLRApi = typeof(System.Reflection.IReflect);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.IReflect_);
                    proxyInfo.CLRProxy = typeof(System.Reflection._IReflect);
                    proxyInfo.JVMProxyFactory = System.Reflection._IReflect.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("GetField","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/FieldInfo;", false, false), // #0 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/FieldInfo;
                        new global::net.sf.jni4net.core.MemberId("GetFields","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/FieldInfo;", false, false), // #1 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/FieldInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMember","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo;", false, false), // #2 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMembers","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo;", false, false), // #3 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethod","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MethodInfo;", false, false), // #4 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethod","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo;", false, false), // #5 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetMethods","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MethodInfo;", false, false), // #6 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperties","(Lsystem/reflection/BindingFlags;)[Lsystem/reflection/PropertyInfo;", false, false), // #7 (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/PropertyInfo;", false, false), // #8 (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("GetProperty","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo;", false, false), // #9 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Type;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/PropertyInfo;
                        new global::net.sf.jni4net.core.MemberId("getUnderlyingSystemType","()Lsystem/Type;", false, false), // #10 ()LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("InvokeMember","(Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[Lsystem/ValueType;Lsystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object;", false, false), // #11 (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[LSystem/ValueType;LSystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.IReflect_))]
    internal partial class _IReflect : global::java.lang.Object, System.Reflection.IReflect
    {
        static _IReflect()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Reflection.IReflect_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.IReflect_));
        }
        
        protected _IReflect(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new System.Reflection._IReflect(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        public global::System.Type UnderlyingSystemType {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[0]));
                }
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/FieldInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/FieldInfo;</signature>
        public global::System.Reflection.FieldInfo GetField(string name, global::System.Reflection.BindingFlags bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.FieldInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, name), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr)));
            }
        }
        
        /// <signature>#2 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/FieldInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/FieldInfo;</signature>
        public global::System.Reflection.FieldInfo[] GetFields(global::System.Reflection.BindingFlags bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::System.Reflection.FieldInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[2], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr)));
            }
        }
        
        /// <signature>#3 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
        public global::System.Reflection.MemberInfo[] GetMember(string name, global::System.Reflection.BindingFlags bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::System.Reflection.MemberInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, name), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr)));
            }
        }
        
        /// <signature>#4 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
        public global::System.Reflection.MemberInfo[] GetMembers(global::System.Reflection.BindingFlags bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::System.Reflection.MemberInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[4], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr)));
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MethodInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MethodInfo;</signature>
        public global::System.Reflection.MethodInfo GetMethod(string name, global::System.Reflection.BindingFlags bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, name), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr)));
            }
        }
        
        /// <signature>#6 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/MethodInfo;</signature>
        public global::System.Reflection.MethodInfo GetMethod(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.MethodInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, name), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, binder, "system.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, types, "system.Type"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, modifiers, "system.ValueType")));
            }
        }
        
        /// <signature>#7 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MethodInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MethodInfo;</signature>
        public global::System.Reflection.MethodInfo[] GetMethods(global::System.Reflection.BindingFlags bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::System.Reflection.MethodInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[7], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr)));
            }
        }
        
        /// <signature>#8 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/PropertyInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/PropertyInfo;</signature>
        public global::System.Reflection.PropertyInfo[] GetProperties(global::System.Reflection.BindingFlags bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::System.Reflection.PropertyInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[8], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr)));
            }
        }
        
        /// <signature>#9 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/PropertyInfo;</signature>
        public global::System.Reflection.PropertyInfo GetProperty(string name, global::System.Reflection.BindingFlags bindingAttr)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[9], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, name), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr)));
            }
        }
        
        /// <signature>#10 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;LSystem/Type;[LSystem/Type;[LSystem/Reflection/ParameterModifier;)LSystem/Reflection/PropertyInfo;</signature>
        public global::System.Reflection.PropertyInfo GetProperty(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Type returnType, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.PropertyInfo>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[10], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, name), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, binder, "system.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, returnType, "system.Type"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, types, "system.Type"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, modifiers, "system.ValueType")));
            }
        }
        
        /// <signature>#11 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[Lsystem/ValueType;Lsystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object; (Lsystem/String;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;Lsystem/Object;[Lsystem/Object;[LSystem/Reflection/ParameterModifier;LSystem/Globalization/CultureInfo;[Lsystem/String;)Lsystem/Object;</signature>
        public object InvokeMember(string name, global::System.Reflection.BindingFlags invokeAttr, global::System.Reflection.Binder binder, object target, object[] args, global::System.Reflection.ParameterModifier[] modifiers, global::System.Globalization.CultureInfo culture, string[] namedParameters)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 26))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.IReflect_.j4n_Members[11], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, name), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, binder, "system.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, target, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, args, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, modifiers, "system.ValueType"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, culture, "system.ICloneable"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, namedParameters)));
            }
        }
    }
}

#endregion Component Designer generated code
