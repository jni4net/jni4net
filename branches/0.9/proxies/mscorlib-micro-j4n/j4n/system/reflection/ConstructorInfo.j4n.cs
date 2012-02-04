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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.ConstructorInfo_))]
    static public partial class ConstructorInfo_
    {
        static ConstructorInfo_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.MethodBase_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.ConstructorInfo_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 ConstructorName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.ConstructorInfo.ConstructorName, "java.lang.String");
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
        
        /// <signature>#1 TypeConstructorName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.ConstructorInfo.TypeConstructorName, "java.lang.String");
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
        
        /// <signature>#2 Invoke([Ljava/lang/Object;)Ljava/lang/Object; ([Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr parameters)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.ConstructorInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ConstructorInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Invoke(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, parameters)), "java.lang.Object");
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
        
        /// <signature>#3 Invoke(Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object; (LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[Lsystem/Object;LSystem/Globalization/CultureInfo;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr parameters, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Reflection.ConstructorInfo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ConstructorInfo>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Invoke(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, invokeAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, parameters), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture)), "java.lang.Object");
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
            lock (typeof(global::System.Reflection.ConstructorInfo))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.reflection.ConstructorInfo";
                    proxyInfo.JVMProxyName = "system.reflection.ConstructorInfo";
                    proxyInfo.JVMStaticApiName = "system.reflection.ConstructorInfo";
                    proxyInfo.CLRApi = typeof(System.Reflection.ConstructorInfo);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.ConstructorInfo_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("ConstructorName","()Ljava/lang/String;", true, true), // #0 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("TypeConstructorName","()Ljava/lang/String;", true, true), // #1 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("Invoke","([Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #2 ([Ljava/lang/Object;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("Invoke","(Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object;", false, false), // #3 (LSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;)Ljava/lang/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
