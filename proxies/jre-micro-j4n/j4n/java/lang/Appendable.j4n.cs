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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Appendable_))]
    public partial interface Appendable
    {
        /// <signature>#0 (C)Ljava/lang/Appendable; (C)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable append(char par0);
        
        /// <signature>#1 (Ljava/lang/CharSequence;)Ljava/lang/Appendable; (Ljava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable append(global::java.lang.CharSequence par0);
        
        /// <signature>#2 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable; (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
        global::java.lang.Appendable append(global::java.lang.CharSequence par0, int par1, int par2);
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Appendable_))]
    static public partial class Appendable_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Appendable_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Appendable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.Appendable_));
        }
        
        /// <signature>#0 append(C)Ljava/lang/Appendable; (C)Ljava/lang/Appendable;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.lang.Appendable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.Appendable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.append(par0), "java.lang.Appendable");
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
        
        /// <signature>#1 append(Ljava/lang/CharSequence;)Ljava/lang/Appendable; (Ljava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.lang.Appendable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.Appendable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.append(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.CharSequence>(j4n_env, par0)), "java.lang.Appendable");
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
        
        /// <signature>#2 append(Ljava/lang/CharSequence;II)Ljava/lang/Appendable; (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                java.lang.Appendable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.Appendable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.append(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.CharSequence>(j4n_env, par0), par1, par2), "java.lang.Appendable");
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
            lock (typeof(global::java.lang.Appendable))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.lang.Appendable";
                    proxyInfo.JVMProxyName = "java_.lang._Appendable";
                    proxyInfo.JVMStaticApiName = "java_.lang.Appendable_";
                    proxyInfo.CLRApi = typeof(java.lang.Appendable);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Appendable_);
                    proxyInfo.CLRProxy = typeof(java.lang._Appendable);
                    proxyInfo.JVMProxyFactory = java.lang._Appendable.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("append","(C)Ljava/lang/Appendable;", false, false), // #0 (C)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", false, false), // #1 (Ljava/lang/CharSequence;)Ljava/lang/Appendable;
                        new global::net.sf.jni4net.core.MemberId("append","(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", false, false), // #2 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Appendable_))]
    internal partial class _Appendable : global::java.lang.Object, java.lang.Appendable
    {
        static _Appendable()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Appendable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.Appendable_));
        }
        
        protected _Appendable(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang._Appendable(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (C)Ljava/lang/Appendable; (C)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(char par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Appendable_.j4n_Members[0], global::net.sf.jni4net.core.ConvertChar.ToValue(par0)));
            }
        }
        
        /// <signature>#1 (Ljava/lang/CharSequence;)Ljava/lang/Appendable; (Ljava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(global::java.lang.CharSequence par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Appendable_.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence")));
            }
        }
        
        /// <signature>#2 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable; (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
        public global::java.lang.Appendable append(global::java.lang.CharSequence par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Appendable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Appendable_.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.CharSequence"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2)));
            }
        }
    }
}

#endregion Component Designer generated code
