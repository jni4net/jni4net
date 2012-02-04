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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.Class))]
    public sealed partial class Class : global::java.lang.Object, global::java.io.Serializable, global::java.lang.reflect.GenericDeclaration, global::java.lang.reflect.Type, global::java.lang.reflect.AnnotatedElement
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Class(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.Class(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Class()
        {
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.GenericDeclaration_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.reflect.GenericDeclaration_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.Type_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.reflect.Type_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.AnnotatedElement_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.reflect.AnnotatedElement_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.Class));
        }
        
        /// <signature>#0 (Ljava/lang/String;)Ljava/lang/Class; (Lsystem/String;)Ljava/lang/Class;</signature>
        static public global::java.lang.Class forName(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Class.j4n_Class, java.lang.Class.j4n_Members[0], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class; (Lsystem/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;</signature>
        static public global::java.lang.Class forName(string par0, bool par1, global::java.lang.ClassLoader par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.Class.j4n_Class, java.lang.Class.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.lang.ClassLoader")));
            }
        }
        
        /// <signature>#2 (Ljava/lang/Class;)Ljava/lang/Class; (Ljava/lang/Class;)Ljava/lang/Class;</signature>
        public global::java.lang.Class asSubclass(global::java.lang.Class par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[2], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#3 (Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        public object cast(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#4 ()Z ()Z</signature>
        public bool desiredAssertionStatus()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 (Ljava/lang/Class;)Ljava/lang/annotation/Annotation; (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;</signature>
        public global::java.lang.annotation.Annotation getAnnotation(global::java.lang.Class par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[5], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#6 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        public global::java.lang.annotation.Annotation[] getAnnotations()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[6]));
            }
        }
        
        /// <signature>#7 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getCanonicalName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.Class.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 ()[Ljava/lang/Class; ()[Ljava/lang/Class;</signature>
        public global::java.lang.Class[] getClasses()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 ()Ljava/lang/ClassLoader; ()Ljava/lang/ClassLoader;</signature>
        public global::java.lang.ClassLoader getClassLoader()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.ClassLoader>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[9]));
            }
        }
        
        /// <signature>#10 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getComponentType()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[10]));
            }
        }
        
        /// <signature>#11 ([Ljava/lang/Class;)Ljava/lang/reflect/Constructor; ([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;</signature>
        public global::java.lang.reflect.Constructor getConstructor(global::java.lang.Class[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.reflect.Constructor>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[11], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#12 ()[Ljava/lang/reflect/Constructor; ()[Ljava/lang/reflect/Constructor;</signature>
        public global::java.lang.reflect.Constructor[] getConstructors()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.reflect.Constructor>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[12]));
            }
        }
        
        /// <signature>#13 ()[Ljava/lang/annotation/Annotation; ()[Ljava/lang/annotation/Annotation;</signature>
        public global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.annotation.Annotation>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[13]));
            }
        }
        
        /// <signature>#14 ()[Ljava/lang/Class; ()[Ljava/lang/Class;</signature>
        public global::java.lang.Class[] getDeclaredClasses()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[14]));
            }
        }
        
        /// <signature>#15 ([Ljava/lang/Class;)Ljava/lang/reflect/Constructor; ([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;</signature>
        public global::java.lang.reflect.Constructor getDeclaredConstructor(global::java.lang.Class[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.reflect.Constructor>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[15], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#16 ()[Ljava/lang/reflect/Constructor; ()[Ljava/lang/reflect/Constructor;</signature>
        public global::java.lang.reflect.Constructor[] getDeclaredConstructors()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.reflect.Constructor>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[16]));
            }
        }
        
        /// <signature>#17 (Ljava/lang/String;)Ljava/lang/reflect/Field; (Lsystem/String;)Ljava/lang/reflect/Field;</signature>
        public global::java.lang.reflect.Field getDeclaredField(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.reflect.Field>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[17], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#18 ()[Ljava/lang/reflect/Field; ()[Ljava/lang/reflect/Field;</signature>
        public global::java.lang.reflect.Field[] getDeclaredFields()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.reflect.Field>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[18]));
            }
        }
        
        /// <signature>#19 (Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method; (Lsystem/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;</signature>
        public global::java.lang.reflect.Method getDeclaredMethod(string par0, global::java.lang.Class[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.reflect.Method>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[19], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#20 ()[Ljava/lang/reflect/Method; ()[Ljava/lang/reflect/Method;</signature>
        public global::java.lang.reflect.Method[] getDeclaredMethods()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.reflect.Method>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[20]));
            }
        }
        
        /// <signature>#21 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getDeclaringClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[21]));
            }
        }
        
        /// <signature>#22 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getEnclosingClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[22]));
            }
        }
        
        /// <signature>#23 ()Ljava/lang/reflect/Constructor; ()Ljava/lang/reflect/Constructor;</signature>
        public global::java.lang.reflect.Constructor getEnclosingConstructor()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.reflect.Constructor>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[23]));
            }
        }
        
        /// <signature>#24 ()Ljava/lang/reflect/Method; ()Ljava/lang/reflect/Method;</signature>
        public global::java.lang.reflect.Method getEnclosingMethod()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.reflect.Method>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[24]));
            }
        }
        
        /// <signature>#25 ()[Ljava/lang/Object; ()[Lsystem/Object;</signature>
        public object[] getEnumConstants()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<object>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[25]));
            }
        }
        
        /// <signature>#26 (Ljava/lang/String;)Ljava/lang/reflect/Field; (Lsystem/String;)Ljava/lang/reflect/Field;</signature>
        public global::java.lang.reflect.Field getField(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.reflect.Field>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[26], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#27 ()[Ljava/lang/reflect/Field; ()[Ljava/lang/reflect/Field;</signature>
        public global::java.lang.reflect.Field[] getFields()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.reflect.Field>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[27]));
            }
        }
        
        /// <signature>#28 ()[Ljava/lang/reflect/Type; ()[Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type[] getGenericInterfaces()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[28]));
            }
        }
        
        /// <signature>#29 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type getGenericSuperclass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[29]));
            }
        }
        
        /// <signature>#30 ()[Ljava/lang/Class; ()[Ljava/lang/Class;</signature>
        public global::java.lang.Class[] getInterfaces()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[30]));
            }
        }
        
        /// <signature>#31 (Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method; (Lsystem/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;</signature>
        public global::java.lang.reflect.Method getMethod(string par0, global::java.lang.Class[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.lang.reflect.Method>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[31], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#32 ()[Ljava/lang/reflect/Method; ()[Ljava/lang/reflect/Method;</signature>
        public global::java.lang.reflect.Method[] getMethods()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLRArray1<global::java.lang.reflect.Method>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[32]));
            }
        }
        
        /// <signature>#33 ()I ()I</signature>
        public int getModifiers()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.Class.j4n_Members[33]);
            }
        }
        
        /// <signature>#34 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.Class.j4n_Members[34]);
            }
        }
        
        /// <signature>#35 ()Ljava/lang/Package; ()Ljava/lang/reflect/AnnotatedElement;</signature>
        public global::java.lang.reflect.AnnotatedElement getPackage()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.reflect.AnnotatedElement>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[35]));
            }
        }
        
        /// <signature>#36 ()Ljava/security/ProtectionDomain; ()Ljava/lang/Object;</signature>
        public global::java.lang.Object getProtectionDomain()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[36]));
            }
        }
        
        /// <signature>#37 (Ljava/lang/String;)Ljava/net/URL; (Lsystem/String;)Ljava/net/URL;</signature>
        public global::java.net.URL getResource(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URL>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[37], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#38 (Ljava/lang/String;)Ljava/io/InputStream; (Lsystem/String;)Ljava/io/InputStream;</signature>
        public global::java.io.InputStream getResourceAsStream(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.InputStream>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[38], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0)));
            }
        }
        
        /// <signature>#39 ()[Ljava/lang/Object; ()[Lsystem/Object;</signature>
        public object[] getSigners()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<object>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[39]));
            }
        }
        
        /// <signature>#40 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getSimpleName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.Class.j4n_Members[40]);
            }
        }
        
        /// <signature>#41 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getSuperclass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[41]));
            }
        }
        
        /// <signature>#42 ()[Ljava/lang/reflect/TypeVariable; ()[Ljava/lang/reflect/TypeVariable;</signature>
        public global::java.lang.reflect.TypeVariable[] getTypeParameters()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.lang.reflect.TypeVariable>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[42]));
            }
        }
        
        /// <signature>#43 ()Z ()Z</signature>
        public bool isAnnotation()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[43]);
            }
        }
        
        /// <signature>#44 (Ljava/lang/Class;)Z (Ljava/lang/Class;)Z</signature>
        public bool isAnnotationPresent(global::java.lang.Class par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[44], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#45 ()Z ()Z</signature>
        public bool isAnonymousClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[45]);
            }
        }
        
        /// <signature>#46 ()Z ()Z</signature>
        public bool isArray()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[46]);
            }
        }
        
        /// <signature>#47 (Ljava/lang/Class;)Z (Ljava/lang/Class;)Z</signature>
        public bool isAssignableFrom(global::java.lang.Class par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[47], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#48 ()Z ()Z</signature>
        public bool isEnum()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[48]);
            }
        }
        
        /// <signature>#49 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool isInstance(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[49], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#50 ()Z ()Z</signature>
        public bool isInterface()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[50]);
            }
        }
        
        /// <signature>#51 ()Z ()Z</signature>
        public bool isLocalClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[51]);
            }
        }
        
        /// <signature>#52 ()Z ()Z</signature>
        public bool isMemberClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[52]);
            }
        }
        
        /// <signature>#53 ()Z ()Z</signature>
        public bool isPrimitive()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[53]);
            }
        }
        
        /// <signature>#54 ()Z ()Z</signature>
        public bool isSynthetic()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.Class.j4n_Members[54]);
            }
        }
        
        /// <signature>#55 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public object newInstance()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.Class.j4n_Members[55]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.Class))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.Class";
                    proxyInfo.JVMStaticApiName = "java_.lang.Class_";
                    proxyInfo.CLRApi = typeof(java.lang.Class);
                    proxyInfo.CLRStaticApi = typeof(java.lang.Class);
                    proxyInfo.CLRProxy = typeof(java.lang.Class);
                    proxyInfo.JVMProxyFactory = java.lang.Class.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("forName","(Ljava/lang/String;)Ljava/lang/Class;", false, true), // #0 (Lsystem/String;)Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("forName","(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;", false, true), // #1 (Lsystem/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("asSubclass","(Ljava/lang/Class;)Ljava/lang/Class;", false, false), // #2 (Ljava/lang/Class;)Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("cast","(Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #3 (Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("desiredAssertionStatus","()Z", false, false), // #4 ()Z
                        new global::net.sf.jni4net.core.MemberId("getAnnotation","(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", false, false), // #5 (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("getAnnotations","()[Ljava/lang/annotation/Annotation;", false, false), // #6 ()[Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("getCanonicalName","()Ljava/lang/String;", false, false), // #7 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getClasses","()[Ljava/lang/Class;", false, false), // #8 ()[Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getClassLoader","()Ljava/lang/ClassLoader;", false, false), // #9 ()Ljava/lang/ClassLoader;
                        new global::net.sf.jni4net.core.MemberId("getComponentType","()Ljava/lang/Class;", false, false), // #10 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getConstructor","([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", false, false), // #11 ([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;
                        new global::net.sf.jni4net.core.MemberId("getConstructors","()[Ljava/lang/reflect/Constructor;", false, false), // #12 ()[Ljava/lang/reflect/Constructor;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredAnnotations","()[Ljava/lang/annotation/Annotation;", false, false), // #13 ()[Ljava/lang/annotation/Annotation;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredClasses","()[Ljava/lang/Class;", false, false), // #14 ()[Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredConstructor","([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", false, false), // #15 ([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredConstructors","()[Ljava/lang/reflect/Constructor;", false, false), // #16 ()[Ljava/lang/reflect/Constructor;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredField","(Ljava/lang/String;)Ljava/lang/reflect/Field;", false, false), // #17 (Lsystem/String;)Ljava/lang/reflect/Field;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredFields","()[Ljava/lang/reflect/Field;", false, false), // #18 ()[Ljava/lang/reflect/Field;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredMethod","(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", false, false), // #19 (Lsystem/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;
                        new global::net.sf.jni4net.core.MemberId("getDeclaredMethods","()[Ljava/lang/reflect/Method;", false, false), // #20 ()[Ljava/lang/reflect/Method;
                        new global::net.sf.jni4net.core.MemberId("getDeclaringClass","()Ljava/lang/Class;", false, false), // #21 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getEnclosingClass","()Ljava/lang/Class;", false, false), // #22 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getEnclosingConstructor","()Ljava/lang/reflect/Constructor;", false, false), // #23 ()Ljava/lang/reflect/Constructor;
                        new global::net.sf.jni4net.core.MemberId("getEnclosingMethod","()Ljava/lang/reflect/Method;", false, false), // #24 ()Ljava/lang/reflect/Method;
                        new global::net.sf.jni4net.core.MemberId("getEnumConstants","()[Ljava/lang/Object;", false, false), // #25 ()[Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getField","(Ljava/lang/String;)Ljava/lang/reflect/Field;", false, false), // #26 (Lsystem/String;)Ljava/lang/reflect/Field;
                        new global::net.sf.jni4net.core.MemberId("getFields","()[Ljava/lang/reflect/Field;", false, false), // #27 ()[Ljava/lang/reflect/Field;
                        new global::net.sf.jni4net.core.MemberId("getGenericInterfaces","()[Ljava/lang/reflect/Type;", false, false), // #28 ()[Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getGenericSuperclass","()Ljava/lang/reflect/Type;", false, false), // #29 ()Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getInterfaces","()[Ljava/lang/Class;", false, false), // #30 ()[Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getMethod","(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", false, false), // #31 (Lsystem/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;
                        new global::net.sf.jni4net.core.MemberId("getMethods","()[Ljava/lang/reflect/Method;", false, false), // #32 ()[Ljava/lang/reflect/Method;
                        new global::net.sf.jni4net.core.MemberId("getModifiers","()I", false, false), // #33 ()I
                        new global::net.sf.jni4net.core.MemberId("getName","()Ljava/lang/String;", false, false), // #34 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getPackage","()Ljava/lang/Package;", false, false), // #35 ()Ljava/lang/reflect/AnnotatedElement;
                        new global::net.sf.jni4net.core.MemberId("getProtectionDomain","()Ljava/security/ProtectionDomain;", false, false), // #36 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getResource","(Ljava/lang/String;)Ljava/net/URL;", false, false), // #37 (Lsystem/String;)Ljava/net/URL;
                        new global::net.sf.jni4net.core.MemberId("getResourceAsStream","(Ljava/lang/String;)Ljava/io/InputStream;", false, false), // #38 (Lsystem/String;)Ljava/io/InputStream;
                        new global::net.sf.jni4net.core.MemberId("getSigners","()[Ljava/lang/Object;", false, false), // #39 ()[Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getSimpleName","()Ljava/lang/String;", false, false), // #40 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getSuperclass","()Ljava/lang/Class;", false, false), // #41 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getTypeParameters","()[Ljava/lang/reflect/TypeVariable;", false, false), // #42 ()[Ljava/lang/reflect/TypeVariable;
                        new global::net.sf.jni4net.core.MemberId("isAnnotation","()Z", false, false), // #43 ()Z
                        new global::net.sf.jni4net.core.MemberId("isAnnotationPresent","(Ljava/lang/Class;)Z", false, false), // #44 (Ljava/lang/Class;)Z
                        new global::net.sf.jni4net.core.MemberId("isAnonymousClass","()Z", false, false), // #45 ()Z
                        new global::net.sf.jni4net.core.MemberId("isArray","()Z", false, false), // #46 ()Z
                        new global::net.sf.jni4net.core.MemberId("isAssignableFrom","(Ljava/lang/Class;)Z", false, false), // #47 (Ljava/lang/Class;)Z
                        new global::net.sf.jni4net.core.MemberId("isEnum","()Z", false, false), // #48 ()Z
                        new global::net.sf.jni4net.core.MemberId("isInstance","(Ljava/lang/Object;)Z", false, false), // #49 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("isInterface","()Z", false, false), // #50 ()Z
                        new global::net.sf.jni4net.core.MemberId("isLocalClass","()Z", false, false), // #51 ()Z
                        new global::net.sf.jni4net.core.MemberId("isMemberClass","()Z", false, false), // #52 ()Z
                        new global::net.sf.jni4net.core.MemberId("isPrimitive","()Z", false, false), // #53 ()Z
                        new global::net.sf.jni4net.core.MemberId("isSynthetic","()Z", false, false), // #54 ()Z
                        new global::net.sf.jni4net.core.MemberId("newInstance","()Ljava/lang/Object;", false, false), // #55 ()Lsystem/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
