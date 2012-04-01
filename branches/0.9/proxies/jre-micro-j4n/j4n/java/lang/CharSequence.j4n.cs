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

namespace java.lang
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.CharSequence_))]
    public partial interface CharSequence
    {
        /// <signature>#0 (I)C (I)C</signature>
        char charAt(int par0);
        
        /// <signature>#1 ()I ()I</signature>
        int length();
        
        /// <signature>#2 (II)Ljava/lang/CharSequence; (II)Ljava/lang/CharSequence;</signature>
        global::java.lang.CharSequence subSequence(int par0, int par1);
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.CharSequence_))]
    static public partial class CharSequence_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static CharSequence_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.CharSequence_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.CharSequence_));
        }
        
        /// <signature>#0 charAt(I)C (I)C</signature>
        static char j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.lang.CharSequence j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.CharSequence>(j4n_env, j4n_self);
                char j4n_result = j4n_real.charAt(par0);
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
        
        /// <signature>#1 length()I ()I</signature>
        static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.CharSequence j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.CharSequence>(j4n_env, j4n_self);
                int j4n_result = j4n_real.length();
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
        
        /// <signature>#2 subSequence(II)Ljava/lang/CharSequence; (II)Ljava/lang/CharSequence;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                java.lang.CharSequence j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.CharSequence>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.subSequence(par0, par1), "java.lang.CharSequence");
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
            lock (typeof(global::java.lang.CharSequence))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.lang.CharSequence";
                    proxyInfo.JVMProxyName = "java_.lang._CharSequence";
                    proxyInfo.JVMStaticApiName = "java_.lang.CharSequence_";
                    proxyInfo.CLRApi = typeof(java.lang.CharSequence);
                    proxyInfo.CLRStaticApi = typeof(java.lang.CharSequence_);
                    proxyInfo.CLRProxy = typeof(java.lang._CharSequence);
                    proxyInfo.JVMProxyFactory = java.lang._CharSequence.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("charAt","(I)C", false, false), // #0 (I)C
                        new global::net.sf.jni4net.core.MemberId("length","()I", false, false), // #1 ()I
                        new global::net.sf.jni4net.core.MemberId("subSequence","(II)Ljava/lang/CharSequence;", false, false), // #2 (II)Ljava/lang/CharSequence;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.CharSequence_))]
    internal partial class _CharSequence : global::java.lang.Object, java.lang.CharSequence
    {
        static _CharSequence()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.CharSequence_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.CharSequence_));
        }
        
        protected _CharSequence(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang._CharSequence(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (I)C (I)C</signature>
        public char charAt(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallCharMethod(this, java.lang.CharSequence_.j4n_Members[0], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#1 ()I ()I</signature>
        public int length()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.CharSequence_.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 (II)Ljava/lang/CharSequence; (II)Ljava/lang/CharSequence;</signature>
        public global::java.lang.CharSequence subSequence(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.CharSequence>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.CharSequence_.j4n_Members[2], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
    }
}

#endregion Component Designer generated code
