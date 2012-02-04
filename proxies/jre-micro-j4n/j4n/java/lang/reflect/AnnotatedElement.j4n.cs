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

namespace java.lang.reflect
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.AnnotatedElement_))]
    public partial interface AnnotatedElement
    {
        /// <signature>#0 (Ljava/lang/Class;)Ljava/lang/annotation/Annotation; (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;</signature>
        global::java.lang.annotation.Annotation getAnnotation(global::java.lang.Class par0);
        
        /// <signature>#1 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        global::java.lang.annotation.Annotation[] getAnnotations();
        
        /// <signature>#2 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        global::java.lang.annotation.Annotation[] getDeclaredAnnotations();
        
        /// <signature>#3 (Ljava/lang/Class;)Z (Ljava/lang/Class;)Z</signature>
        bool isAnnotationPresent(global::java.lang.Class par0);
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.AnnotatedElement_))]
    static public partial class AnnotatedElement_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static AnnotatedElement_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.AnnotatedElement_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.AnnotatedElement_));
        }
        
        /// <signature>#0 getAnnotation(Ljava/lang/Class;)Ljava/lang/annotation/Annotation; (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.lang.reflect.AnnotatedElement j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.AnnotatedElement>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getAnnotation(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Class>(j4n_env, par0)), "java.lang.annotation.Annotation");
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
        
        /// <signature>#1 getAnnotations()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.AnnotatedElement j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.AnnotatedElement>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getAnnotations(), "java.lang.annotation.Annotation");
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
        
        /// <signature>#2 getDeclaredAnnotations()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.reflect.AnnotatedElement j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.AnnotatedElement>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.getDeclaredAnnotations(), "java.lang.annotation.Annotation");
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
        
        /// <signature>#3 isAnnotationPresent(Ljava/lang/Class;)Z (Ljava/lang/Class;)Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.lang.reflect.AnnotatedElement j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.reflect.AnnotatedElement>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.isAnnotationPresent(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Class>(j4n_env, par0));
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
            lock (typeof(global::java.lang.reflect.AnnotatedElement))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.lang.reflect.AnnotatedElement";
                    proxyInfo.JVMProxyName = "java_.lang.reflect._AnnotatedElement";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.AnnotatedElement_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.AnnotatedElement);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.AnnotatedElement_);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect._AnnotatedElement);
                    proxyInfo.JVMProxyFactory = java.lang.reflect._AnnotatedElement.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("getAnnotation","(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", false, false), // #0 (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("getAnnotations","()[Ljava/lang/annotation/Annotation;", false, false), // #1 ()[Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredAnnotations","()[Ljava/lang/annotation/Annotation;", false, false), // #2 ()[Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("isAnnotationPresent","(Ljava/lang/Class;)Z", false, false), // #3 (Ljava/lang/Class;)Z
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.AnnotatedElement_))]
    internal partial class _AnnotatedElement : global::java.lang.Object, java.lang.reflect.AnnotatedElement
    {
        static _AnnotatedElement()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.AnnotatedElement_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.reflect.AnnotatedElement_));
        }
        
        protected _AnnotatedElement(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect._AnnotatedElement(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (Ljava/lang/Class;)Ljava/lang/annotation/Annotation; (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;</signature>
        public global::java.lang.annotation.Annotation getAnnotation(global::java.lang.Class par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.AnnotatedElement_.j4n_Members[0], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#1 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        public global::java.lang.annotation.Annotation[] getAnnotations()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.AnnotatedElement_.j4n_Members[1]));
            }
        }
        
        /// <signature>#2 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        public global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.AnnotatedElement_.j4n_Members[2]));
            }
        }
        
        /// <signature>#3 (Ljava/lang/Class;)Z (Ljava/lang/Class;)Z</signature>
        public bool isAnnotationPresent(global::java.lang.Class par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.AnnotatedElement_.j4n_Members[3], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
    }
}

#endregion Component Designer generated code
