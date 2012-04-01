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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.ICustomAttributeProvider_))]
    static public partial class ICustomAttributeProvider_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static ICustomAttributeProvider_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Reflection.ICustomAttributeProvider_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.ICustomAttributeProvider_));
        }
        
        /// <signature>#0 GetCustomAttributes(Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr attributeType, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
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
        
        /// <signature>#1 GetCustomAttributes(Z)[Ljava/lang/Object; (Z)[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
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
        
        /// <signature>#2 IsDefined(Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr attributeType, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
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
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Reflection.ICustomAttributeProvider))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "system.reflection.ICustomAttributeProvider";
                    proxyInfo.JVMProxyName = "system.reflection._ICustomAttributeProvider";
                    proxyInfo.JVMStaticApiName = "system.reflection.ICustomAttributeProvider_";
                    proxyInfo.CLRApi = typeof(System.Reflection.ICustomAttributeProvider);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.ICustomAttributeProvider_);
                    proxyInfo.CLRProxy = typeof(System.Reflection._ICustomAttributeProvider);
                    proxyInfo.JVMProxyFactory = System.Reflection._ICustomAttributeProvider.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("GetCustomAttributes","(Lsystem/Type;Z)[Ljava/lang/Object;", false, false), // #0 (LSystem/Type;Z)[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetCustomAttributes","(Z)[Ljava/lang/Object;", false, false), // #1 (Z)[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("IsDefined","(Lsystem/Type;Z)Z", false, false), // #2 (LSystem/Type;Z)Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.ICustomAttributeProvider_))]
    internal partial class _ICustomAttributeProvider : global::java.lang.Object, System.Reflection.ICustomAttributeProvider
    {
        static _ICustomAttributeProvider()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Reflection.ICustomAttributeProvider_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.ICustomAttributeProvider_));
        }
        
        protected _ICustomAttributeProvider(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new System.Reflection._ICustomAttributeProvider(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Lsystem/Object;</signature>
        public object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<object>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.ICustomAttributeProvider_.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, attributeType, "system.Type"), global::net.sf.jni4net.core.ConvertBoolean.ToValue(inherit)));
            }
        }
        
        /// <signature>#1 (Z)[Ljava/lang/Object; (Z)[Lsystem/Object;</signature>
        public object[] GetCustomAttributes(bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<object>(j4n_env, j4n_env.CallObjectMethod(this, System.Reflection.ICustomAttributeProvider_.j4n_Members[1], global::net.sf.jni4net.core.ConvertBoolean.ToValue(inherit)));
            }
        }
        
        /// <signature>#2 (Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
        public bool IsDefined(global::System.Type attributeType, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallBooleanMethod(this, System.Reflection.ICustomAttributeProvider_.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, attributeType, "system.Type"), global::net.sf.jni4net.core.ConvertBoolean.ToValue(inherit));
            }
        }
    }
}

#endregion Component Designer generated code
