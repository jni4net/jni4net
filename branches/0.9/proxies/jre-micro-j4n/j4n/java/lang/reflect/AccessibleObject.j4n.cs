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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.AccessibleObject))]
    public partial class AccessibleObject : global::java.lang.Object, global::java.lang.reflect.AnnotatedElement
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected AccessibleObject(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect.AccessibleObject(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static AccessibleObject()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.AnnotatedElement_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.reflect.AnnotatedElement_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.AccessibleObject));
        }
        
        /// <signature>#0 ([Ljava/lang/reflect/AccessibleObject;Z)V ([Ljava/lang/reflect/AccessibleObject;Z)V</signature>
        static public void setAccessible(global::java.lang.reflect.AccessibleObject[] par0, bool par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.AccessibleObject.j4n_Class, java.lang.reflect.AccessibleObject.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.reflect.AccessibleObject"), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1));
            }
        }
        
        /// <signature>#1 (Ljava/lang/Class;)Ljava/lang/annotation/Annotation; (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;</signature>
        public virtual global::java.lang.annotation.Annotation getAnnotation(global::java.lang.Class par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.AccessibleObject.j4n_Members[1], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#2 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        public virtual global::java.lang.annotation.Annotation[] getAnnotations()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.AccessibleObject.j4n_Members[2]));
            }
        }
        
        /// <signature>#3 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        public virtual global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.AccessibleObject.j4n_Members[3]));
            }
        }
        
        /// <signature>#4 ()Z ()Z</signature>
        public virtual bool isAccessible()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.AccessibleObject.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 (Ljava/lang/Class;)Z (Ljava/lang/Class;)Z</signature>
        public virtual bool isAnnotationPresent(global::java.lang.Class par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.AccessibleObject.j4n_Members[5], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#6 (Z)V (Z)V</signature>
        public virtual void setAccessible(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.AccessibleObject.j4n_Members[6], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.reflect.AccessibleObject))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.reflect.AccessibleObject";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.AccessibleObject_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.AccessibleObject);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.AccessibleObject);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect.AccessibleObject);
                    proxyInfo.JVMProxyFactory = java.lang.reflect.AccessibleObject.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("setAccessible","([Ljava/lang/reflect/AccessibleObject;Z)V", false, true), // #0 ([Ljava/lang/reflect/AccessibleObject;Z)V
                        new global::net.sf.jni4net.core.MemberId("getAnnotation","(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", false, false), // #1 (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("getAnnotations","()[Ljava/lang/annotation/Annotation;", false, false), // #2 ()[Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredAnnotations","()[Ljava/lang/annotation/Annotation;", false, false), // #3 ()[Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("isAccessible","()Z", false, false), // #4 ()Z
                        new global::net.sf.jni4net.core.MemberId("isAnnotationPresent","(Ljava/lang/Class;)Z", false, false), // #5 (Ljava/lang/Class;)Z
                        new global::net.sf.jni4net.core.MemberId("setAccessible","(Z)V", false, false), // #6 (Z)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
