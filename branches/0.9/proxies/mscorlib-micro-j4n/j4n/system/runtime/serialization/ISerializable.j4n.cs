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

namespace System.Runtime.Serialization
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Runtime.Serialization.ISerializable_))]
    static public partial class ISerializable_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static ISerializable_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Runtime.Serialization.ISerializable_));
        }
        
        /// <signature>#0 GetObjectData(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr info, global::System.IntPtr context)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Runtime.Serialization.ISerializable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Runtime.Serialization.ISerializable>(j4n_env, j4n_self);
                j4n_real.GetObjectData(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, info), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContext>(j4n_env, context));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Runtime.Serialization.ISerializable))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "system.runtime.serialization.ISerializable";
                    proxyInfo.JVMProxyName = "system.runtime.serialization._ISerializable";
                    proxyInfo.JVMStaticApiName = "system.runtime.serialization.ISerializable_";
                    proxyInfo.CLRApi = typeof(System.Runtime.Serialization.ISerializable);
                    proxyInfo.CLRStaticApi = typeof(System.Runtime.Serialization.ISerializable_);
                    proxyInfo.CLRProxy = typeof(System.Runtime.Serialization._ISerializable);
                    proxyInfo.JVMProxyFactory = System.Runtime.Serialization._ISerializable.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("GetObjectData","(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V", false, false), // #0 (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Runtime.Serialization.ISerializable_))]
    internal partial class _ISerializable : global::java.lang.Object, System.Runtime.Serialization.ISerializable
    {
        static _ISerializable()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Runtime.Serialization.ISerializable_));
        }
        
        protected _ISerializable(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new System.Runtime.Serialization._ISerializable(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
        public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, System.Runtime.Serialization.ISerializable_.j4n_Members[0], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, info), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, context));
            }
        }
    }
}

#endregion Component Designer generated code
