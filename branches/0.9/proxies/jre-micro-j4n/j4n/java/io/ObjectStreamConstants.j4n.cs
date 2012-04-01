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

namespace java.io
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectStreamConstants_))]
    public partial interface ObjectStreamConstants
    {
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectStreamConstants_))]
    static public partial class ObjectStreamConstants_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static ObjectStreamConstants_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ObjectStreamConstants_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.io.ObjectStreamConstants_));
        }
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.ObjectStreamConstants))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.io.ObjectStreamConstants";
                    proxyInfo.JVMProxyName = "java_.io._ObjectStreamConstants";
                    proxyInfo.JVMStaticApiName = "java_.io.ObjectStreamConstants_";
                    proxyInfo.CLRApi = typeof(java.io.ObjectStreamConstants);
                    proxyInfo.CLRStaticApi = typeof(java.io.ObjectStreamConstants_);
                    proxyInfo.CLRProxy = typeof(java.io._ObjectStreamConstants);
                    proxyInfo.JVMProxyFactory = java.io._ObjectStreamConstants.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        null, // #0 interface static: baseWireHandle
                        null, // #1 interface static: PROTOCOL_VERSION_1
                        null, // #2 interface static: PROTOCOL_VERSION_2
                        null, // #3 interface static: SC_BLOCK_DATA
                        null, // #4 interface static: SC_ENUM
                        null, // #5 interface static: SC_EXTERNALIZABLE
                        null, // #6 interface static: SC_SERIALIZABLE
                        null, // #7 interface static: SC_WRITE_METHOD
                        null, // #8 interface static: STREAM_MAGIC
                        null, // #9 interface static: STREAM_VERSION
                        null, // #10 interface static: SUBCLASS_IMPLEMENTATION_PERMISSION
                        null, // #11 interface static: SUBSTITUTION_PERMISSION
                        null, // #12 interface static: TC_ARRAY
                        null, // #13 interface static: TC_BASE
                        null, // #14 interface static: TC_BLOCKDATA
                        null, // #15 interface static: TC_BLOCKDATALONG
                        null, // #16 interface static: TC_CLASS
                        null, // #17 interface static: TC_CLASSDESC
                        null, // #18 interface static: TC_ENDBLOCKDATA
                        null, // #19 interface static: TC_ENUM
                        null, // #20 interface static: TC_EXCEPTION
                        null, // #21 interface static: TC_LONGSTRING
                        null, // #22 interface static: TC_MAX
                        null, // #23 interface static: TC_NULL
                        null, // #24 interface static: TC_OBJECT
                        null, // #25 interface static: TC_PROXYCLASSDESC
                        null, // #26 interface static: TC_REFERENCE
                        null, // #27 interface static: TC_RESET
                        null, // #28 interface static: TC_STRING
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectStreamConstants_))]
    internal partial class _ObjectStreamConstants : global::java.lang.Object, java.io.ObjectStreamConstants
    {
        static _ObjectStreamConstants()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ObjectStreamConstants_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.io.ObjectStreamConstants_));
        }
        
        protected _ObjectStreamConstants(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io._ObjectStreamConstants(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
    }
}

#endregion Component Designer generated code
