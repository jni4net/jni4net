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

namespace dummy.jvm
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces))]
    public partial class Interfaces : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected Interfaces(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new dummy.jvm.Interfaces(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Interfaces()
        {
            global::net.sf.jni4net.modules.dummyjj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces));
        }
        
        /// <signature>#0 ()V ()V</signature>
        public Interfaces()
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_handle = j4n_env.NewObjectG(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()Ldummy/jvm/Interfaces$Foo; ()Ldummy/jvm/Interfaces+Foo;</signature>
        static public global::dummy.jvm.Interfaces.Foo getFoo()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Interfaces.Foo>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[1]));
            }
        }
        
        /// <signature>#2 ()Ldummy/jvm/Foobararable; ()Ldummy/jvm/Foobararable;</signature>
        static public global::dummy.jvm.Foobararable getFoobararableA()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Foobararable>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[2]));
            }
        }
        
        /// <signature>#3 ()Ldummy/jvm/Foobararable; ()Ldummy/jvm/Foobararable;</signature>
        static public global::dummy.jvm.Foobararable getFoobararableAG()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Foobararable>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[3]));
            }
        }
        
        /// <signature>#4 ()Ldummy/jvm/Foobararable; ()Ldummy/jvm/Foobararable;</signature>
        static public global::dummy.jvm.Foobararable getFoobararableB()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Foobararable>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[4]));
            }
        }
        
        /// <signature>#5 ()Ldummy/jvm/Foobararable; ()Ldummy/jvm/Foobararable;</signature>
        static public global::dummy.jvm.Foobararable getFoobararableBG()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Foobararable>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[5]));
            }
        }
        
        /// <signature>#6 ()Ljava/util/List; ()Ljava/lang/Object;</signature>
        static public global::java.lang.Object getListOfInteger()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[6]));
            }
        }
        
        /// <signature>#7 ()Ljava/util/List; ()Ljava/lang/Object;</signature>
        static public global::java.lang.Object getListOfIntegerNG()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[7]));
            }
        }
        
        /// <signature>#8 ()Ljava/util/List; ()Ljava/lang/Object;</signature>
        static public global::java.lang.Object getListOfList()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 ()Ljava/util/List; ()Ljava/lang/Object;</signature>
        static public global::java.lang.Object getListOfListOfClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[9]));
            }
        }
        
        /// <signature>#10 ()Ldummy/jvm/Interfaces$MyPublicZ; ()Ldummy/jvm/Interfaces+MyPublicZ;</signature>
        static public global::dummy.jvm.Interfaces.MyPublicZ getMyPublicA()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Interfaces.MyPublicZ>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[10]));
            }
        }
        
        /// <signature>#11 ()Ldummy/jvm/Interfaces$MyPublicZ; ()Ldummy/jvm/Interfaces+MyPublicZ;</signature>
        static public global::dummy.jvm.Interfaces.MyPublicZ getMyPublicB()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Interfaces.MyPublicZ>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[11]));
            }
        }
        
        /// <signature>#12 ()Ldummy/jvm/Interfaces$MyPublicY; ()Ldummy/jvm/Interfaces+MyPublicY;</signature>
        static public global::dummy.jvm.Interfaces.MyPublicY getMyPublicYA()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Interfaces.MyPublicY>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[12]));
            }
        }
        
        /// <signature>#13 ()Ldummy/jvm/Interfaces$MyPublicY; ()Ldummy/jvm/Interfaces+MyPublicY;</signature>
        static public global::dummy.jvm.Interfaces.MyPublicY getMyPublicYB()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Interfaces.MyPublicY>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[13]));
            }
        }
        
        /// <signature>#14 ()Ldummy/jvm/Interfaces$MyPublicY; ()Ldummy/jvm/Interfaces+MyPublicY;</signature>
        static public global::dummy.jvm.Interfaces.MyPublicY getMyPublicYZ()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Interfaces.MyPublicY>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[14]));
            }
        }
        
        /// <signature>#15 ()Ldummy/jvm/Interfaces$MyPublicZ; ()Ldummy/jvm/Interfaces+MyPublicZ;</signature>
        static public global::dummy.jvm.Interfaces.MyPublicZ getMyPublicZ()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.jvm.Interfaces.MyPublicZ>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[15]));
            }
        }
        
        /// <signature>#16 ()Ljava/lang/Runnable; ()Ljava/lang/Object;</signature>
        static public global::java.lang.Object getRunnable()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.Object>(j4n_env, j4n_env.CallStaticObjectMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[16]));
            }
        }
        
        /// <signature>#17 (Ljava/util/List;)I (Ljava/lang/Object;)I</signature>
        static public int setListOfInteger(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[17], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.List"));
            }
        }
        
        /// <signature>#18 (Ljava/util/List;)I (Ljava/lang/Object;)I</signature>
        static public int setListOfIntegerAG(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[18], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.List"));
            }
        }
        
        /// <signature>#19 (Ljava/util/List;)I (Ljava/lang/Object;)I</signature>
        static public int setListOfIntegerNG(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[19], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.List"));
            }
        }
        
        /// <signature>#20 (Ljava/util/List;)I (Ljava/lang/Object;)I</signature>
        static public int setListOfList(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[20], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.List"));
            }
        }
        
        /// <signature>#21 (Ljava/util/List;)I (Ljava/lang/Object;)I</signature>
        static public int setListOfListOfClass(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(dummy.jvm.Interfaces.j4n_Class, dummy.jvm.Interfaces.j4n_Members[21], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.List"));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::dummy.jvm.Interfaces))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "dummy.jvm.Interfaces";
                    proxyInfo.JVMStaticApiName = "dummy.jvm.Interfaces_";
                    proxyInfo.CLRApi = typeof(dummy.jvm.Interfaces);
                    proxyInfo.CLRStaticApi = typeof(dummy.jvm.Interfaces);
                    proxyInfo.CLRProxy = typeof(dummy.jvm.Interfaces);
                    proxyInfo.JVMProxyFactory = dummy.jvm.Interfaces.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("getFoo","()Ldummy/jvm/Interfaces$Foo;", false, true), // #1 ()Ldummy/jvm/Interfaces+Foo;
                        new global::net.sf.jni4net.core.MemberId("getFoobararableA","()Ldummy/jvm/Foobararable;", false, true), // #2 ()Ldummy/jvm/Foobararable;
                        new global::net.sf.jni4net.core.MemberId("getFoobararableAG","()Ldummy/jvm/Foobararable;", false, true), // #3 ()Ldummy/jvm/Foobararable;
                        new global::net.sf.jni4net.core.MemberId("getFoobararableB","()Ldummy/jvm/Foobararable;", false, true), // #4 ()Ldummy/jvm/Foobararable;
                        new global::net.sf.jni4net.core.MemberId("getFoobararableBG","()Ldummy/jvm/Foobararable;", false, true), // #5 ()Ldummy/jvm/Foobararable;
                        new global::net.sf.jni4net.core.MemberId("getListOfInteger","()Ljava/util/List;", false, true), // #6 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getListOfIntegerNG","()Ljava/util/List;", false, true), // #7 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getListOfList","()Ljava/util/List;", false, true), // #8 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getListOfListOfClass","()Ljava/util/List;", false, true), // #9 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getMyPublicA","()Ldummy/jvm/Interfaces$MyPublicZ;", false, true), // #10 ()Ldummy/jvm/Interfaces+MyPublicZ;
                        new global::net.sf.jni4net.core.MemberId("getMyPublicB","()Ldummy/jvm/Interfaces$MyPublicZ;", false, true), // #11 ()Ldummy/jvm/Interfaces+MyPublicZ;
                        new global::net.sf.jni4net.core.MemberId("getMyPublicYA","()Ldummy/jvm/Interfaces$MyPublicY;", false, true), // #12 ()Ldummy/jvm/Interfaces+MyPublicY;
                        new global::net.sf.jni4net.core.MemberId("getMyPublicYB","()Ldummy/jvm/Interfaces$MyPublicY;", false, true), // #13 ()Ldummy/jvm/Interfaces+MyPublicY;
                        new global::net.sf.jni4net.core.MemberId("getMyPublicYZ","()Ldummy/jvm/Interfaces$MyPublicY;", false, true), // #14 ()Ldummy/jvm/Interfaces+MyPublicY;
                        new global::net.sf.jni4net.core.MemberId("getMyPublicZ","()Ldummy/jvm/Interfaces$MyPublicZ;", false, true), // #15 ()Ldummy/jvm/Interfaces+MyPublicZ;
                        new global::net.sf.jni4net.core.MemberId("getRunnable","()Ljava/lang/Runnable;", false, true), // #16 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("setListOfInteger","(Ljava/util/List;)I", false, true), // #17 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("setListOfIntegerAG","(Ljava/util/List;)I", false, true), // #18 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("setListOfIntegerNG","(Ljava/util/List;)I", false, true), // #19 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("setListOfList","(Ljava/util/List;)I", false, true), // #20 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("setListOfListOfClass","(Ljava/util/List;)I", false, true), // #21 (Ljava/lang/Object;)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Bar_))]
        public partial interface Bar : global::dummy.jvm.Foobararable
        {
            /// <signature>#0 ()V ()V</signature>
            void bar();
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Bar_))]
        static public partial class Bar_
        {
            
            static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static internal global::java.lang.IClass j4n_Class;
            
            static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            static Bar_()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.Bar_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Interfaces.Bar_));
            }
            
            /// <signature>#0 bar()V ()V</signature>
            static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    dummy.jvm.Interfaces.Bar j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Interfaces.Bar>(j4n_env, j4n_self);
                    j4n_real.bar();
                }
                catch (global::System.Exception j4n_ex)
                {
                    j4n_env.ThrowExisting(j4n_ex);
                }
                finally{
                    j4n_frame.Dispose();
                }
            }
            
            /// <signature>#1 Foob(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
            static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
                try
                {
                    dummy.jvm.Foobararable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Foobararable>(j4n_env, j4n_self);
                    int j4n_result = j4n_real.Foob(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
            
            static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
            {
                lock (typeof(global::dummy.jvm.Interfaces.Bar))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = true;
                        proxyInfo.JVMApiName = "dummy.jvm.Interfaces$Bar";
                        proxyInfo.JVMProxyName = "dummy.jvm.Interfaces_$_Bar";
                        proxyInfo.JVMStaticApiName = "dummy.jvm.Interfaces_$Bar_";
                        proxyInfo.CLRApi = typeof(dummy.jvm.Interfaces.Bar);
                        proxyInfo.CLRStaticApi = typeof(dummy.jvm.Interfaces.Bar_);
                        proxyInfo.CLRProxy = typeof(dummy.jvm.Interfaces._Bar);
                        proxyInfo.JVMProxyFactory = dummy.jvm.Interfaces._Bar.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("bar","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("Foob","(Ljava/lang/Object;)I", false, false), // #1 (Lsystem/Object;)I
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Bar_))]
        internal partial class _Bar : global::java.lang.Object, dummy.jvm.Interfaces.Bar
        {
            static _Bar()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.Bar_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Interfaces.Bar_));
            }
            
            protected _Bar(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new dummy.jvm.Interfaces._Bar(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            /// <signature>#0 ()V ()V</signature>
            public void bar()
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_env.CallVoidMethod(this, dummy.jvm.Interfaces.Bar_.j4n_Members[0]);
                }
            }
            
            /// <signature>#1 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
            public int Foob(object par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return j4n_env.CallIntMethod(this, dummy.jvm.Interfaces.Bar_.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Foo_))]
        public partial interface Foo : global::dummy.jvm.Foobararable
        {
            /// <signature>#0 ()V ()V</signature>
            void foo();
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Foo_))]
        static public partial class Foo_
        {
            
            static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static internal global::java.lang.IClass j4n_Class;
            
            static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            static Foo_()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.Foo_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Interfaces.Foo_));
            }
            
            /// <signature>#0 foo()V ()V</signature>
            static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    dummy.jvm.Interfaces.Foo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Interfaces.Foo>(j4n_env, j4n_self);
                    j4n_real.foo();
                }
                catch (global::System.Exception j4n_ex)
                {
                    j4n_env.ThrowExisting(j4n_ex);
                }
                finally{
                    j4n_frame.Dispose();
                }
            }
            
            /// <signature>#1 Foob(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
            static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
                try
                {
                    dummy.jvm.Foobararable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Foobararable>(j4n_env, j4n_self);
                    int j4n_result = j4n_real.Foob(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
            
            static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
            {
                lock (typeof(global::dummy.jvm.Interfaces.Foo))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = true;
                        proxyInfo.JVMApiName = "dummy.jvm.Interfaces$Foo";
                        proxyInfo.JVMProxyName = "dummy.jvm.Interfaces_$_Foo";
                        proxyInfo.JVMStaticApiName = "dummy.jvm.Interfaces_$Foo_";
                        proxyInfo.CLRApi = typeof(dummy.jvm.Interfaces.Foo);
                        proxyInfo.CLRStaticApi = typeof(dummy.jvm.Interfaces.Foo_);
                        proxyInfo.CLRProxy = typeof(dummy.jvm.Interfaces._Foo);
                        proxyInfo.JVMProxyFactory = dummy.jvm.Interfaces._Foo.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("foo","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("Foob","(Ljava/lang/Object;)I", false, false), // #1 (Lsystem/Object;)I
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Foo_))]
        internal partial class _Foo : global::java.lang.Object, dummy.jvm.Interfaces.Foo
        {
            static _Foo()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.Foo_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Interfaces.Foo_));
            }
            
            protected _Foo(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new dummy.jvm.Interfaces._Foo(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            /// <signature>#0 ()V ()V</signature>
            public void foo()
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_env.CallVoidMethod(this, dummy.jvm.Interfaces.Foo_.j4n_Members[0]);
                }
            }
            
            /// <signature>#1 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
            public int Foob(object par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return j4n_env.CallIntMethod(this, dummy.jvm.Interfaces.Foo_.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Goo_))]
        public partial interface Goo : global::dummy.jvm.Interfaces.Foo
        {
            /// <signature>#0 ()V ()V</signature>
            void goo();
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Goo_))]
        static public partial class Goo_
        {
            
            static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static internal global::java.lang.IClass j4n_Class;
            
            static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            static Goo_()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.Goo_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Interfaces.Goo_));
            }
            
            /// <signature>#0 foo()V ()V</signature>
            static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    dummy.jvm.Interfaces.Foo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Interfaces.Foo>(j4n_env, j4n_self);
                    j4n_real.foo();
                }
                catch (global::System.Exception j4n_ex)
                {
                    j4n_env.ThrowExisting(j4n_ex);
                }
                finally{
                    j4n_frame.Dispose();
                }
            }
            
            /// <signature>#1 Foob(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
            static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
                try
                {
                    dummy.jvm.Foobararable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Foobararable>(j4n_env, j4n_self);
                    int j4n_result = j4n_real.Foob(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
            
            /// <signature>#2 goo()V ()V</signature>
            static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    dummy.jvm.Interfaces.Goo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Interfaces.Goo>(j4n_env, j4n_self);
                    j4n_real.goo();
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
                lock (typeof(global::dummy.jvm.Interfaces.Goo))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = true;
                        proxyInfo.JVMApiName = "dummy.jvm.Interfaces$Goo";
                        proxyInfo.JVMProxyName = "dummy.jvm.Interfaces_$_Goo";
                        proxyInfo.JVMStaticApiName = "dummy.jvm.Interfaces_$Goo_";
                        proxyInfo.CLRApi = typeof(dummy.jvm.Interfaces.Goo);
                        proxyInfo.CLRStaticApi = typeof(dummy.jvm.Interfaces.Goo_);
                        proxyInfo.CLRProxy = typeof(dummy.jvm.Interfaces._Goo);
                        proxyInfo.JVMProxyFactory = dummy.jvm.Interfaces._Goo.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("foo","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("Foob","(Ljava/lang/Object;)I", false, false), // #1 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("goo","()V", false, false), // #2 ()V
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Goo_))]
        internal partial class _Goo : global::java.lang.Object, dummy.jvm.Interfaces.Goo
        {
            static _Goo()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.Goo_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Interfaces.Goo_));
            }
            
            protected _Goo(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new dummy.jvm.Interfaces._Goo(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            /// <signature>#0 ()V ()V</signature>
            public void foo()
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_env.CallVoidMethod(this, dummy.jvm.Interfaces.Goo_.j4n_Members[0]);
                }
            }
            
            /// <signature>#1 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
            public int Foob(object par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return j4n_env.CallIntMethod(this, dummy.jvm.Interfaces.Goo_.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
                }
            }
            
            /// <signature>#2 ()V ()V</signature>
            public void goo()
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_env.CallVoidMethod(this, dummy.jvm.Interfaces.Goo_.j4n_Members[2]);
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.MyPublicY))]
        public partial class MyPublicY : global::java.lang.Object
        {
            
            static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static private global::java.lang.IClass j4n_Class;
            
            static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            new static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            protected MyPublicY(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new dummy.jvm.Interfaces.MyPublicY(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            static MyPublicY()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.MyPublicY));
            }
            
            /// <signature>#0 ()V ()V</signature>
            public MyPublicY()
                : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_handle = j4n_env.NewObjectG(dummy.jvm.Interfaces.MyPublicY.j4n_Class, dummy.jvm.Interfaces.MyPublicY.j4n_Members[0]);
                }
            }
            
            new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
            {
                lock (typeof(global::dummy.jvm.Interfaces.MyPublicY))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = false;
                        proxyInfo.JVMApiName = "dummy.jvm.Interfaces$MyPublicY";
                        proxyInfo.JVMStaticApiName = "dummy.jvm.Interfaces_$MyPublicY_";
                        proxyInfo.CLRApi = typeof(dummy.jvm.Interfaces.MyPublicY);
                        proxyInfo.CLRStaticApi = typeof(dummy.jvm.Interfaces.MyPublicY);
                        proxyInfo.CLRProxy = typeof(dummy.jvm.Interfaces.MyPublicY);
                        proxyInfo.JVMProxyFactory = dummy.jvm.Interfaces.MyPublicY.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.MyPublicZ))]
        public partial class MyPublicZ : global::dummy.jvm.Interfaces.MyPublicY
        {
            
            static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static private global::java.lang.IClass j4n_Class;
            
            static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            new static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            protected MyPublicZ(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new dummy.jvm.Interfaces.MyPublicZ(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            static MyPublicZ()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::dummy.jvm.Interfaces.MyPublicY));
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.MyPublicZ));
            }
            
            /// <signature>#0 ()V ()V</signature>
            public MyPublicZ()
                : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_handle = j4n_env.NewObjectG(dummy.jvm.Interfaces.MyPublicZ.j4n_Class, dummy.jvm.Interfaces.MyPublicZ.j4n_Members[0]);
                }
            }
            
            new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
            {
                lock (typeof(global::dummy.jvm.Interfaces.MyPublicZ))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = false;
                        proxyInfo.JVMApiName = "dummy.jvm.Interfaces$MyPublicZ";
                        proxyInfo.JVMStaticApiName = "dummy.jvm.Interfaces_$MyPublicZ_";
                        proxyInfo.CLRApi = typeof(dummy.jvm.Interfaces.MyPublicZ);
                        proxyInfo.CLRStaticApi = typeof(dummy.jvm.Interfaces.MyPublicZ);
                        proxyInfo.CLRProxy = typeof(dummy.jvm.Interfaces.MyPublicZ);
                        proxyInfo.JVMProxyFactory = dummy.jvm.Interfaces.MyPublicZ.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Zoo_))]
        public partial interface Zoo : global::dummy.jvm.Interfaces.Foo
        {
            /// <signature>#0 ()V ()V</signature>
            void zoo();
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Zoo_))]
        static public partial class Zoo_
        {
            
            static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static internal global::java.lang.IClass j4n_Class;
            
            static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            static Zoo_()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.Zoo_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Interfaces.Zoo_));
            }
            
            /// <signature>#0 foo()V ()V</signature>
            static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    dummy.jvm.Interfaces.Foo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Interfaces.Foo>(j4n_env, j4n_self);
                    j4n_real.foo();
                }
                catch (global::System.Exception j4n_ex)
                {
                    j4n_env.ThrowExisting(j4n_ex);
                }
                finally{
                    j4n_frame.Dispose();
                }
            }
            
            /// <signature>#1 Foob(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
            static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
                try
                {
                    dummy.jvm.Foobararable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Foobararable>(j4n_env, j4n_self);
                    int j4n_result = j4n_real.Foob(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
            
            /// <signature>#2 zoo()V ()V</signature>
            static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
                global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
                try
                {
                    dummy.jvm.Interfaces.Zoo j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.jvm.Interfaces.Zoo>(j4n_env, j4n_self);
                    j4n_real.zoo();
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
                lock (typeof(global::dummy.jvm.Interfaces.Zoo))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = true;
                        proxyInfo.JVMApiName = "dummy.jvm.Interfaces$Zoo";
                        proxyInfo.JVMProxyName = "dummy.jvm.Interfaces_$_Zoo";
                        proxyInfo.JVMStaticApiName = "dummy.jvm.Interfaces_$Zoo_";
                        proxyInfo.CLRApi = typeof(dummy.jvm.Interfaces.Zoo);
                        proxyInfo.CLRStaticApi = typeof(dummy.jvm.Interfaces.Zoo_);
                        proxyInfo.CLRProxy = typeof(dummy.jvm.Interfaces._Zoo);
                        proxyInfo.JVMProxyFactory = dummy.jvm.Interfaces._Zoo.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("foo","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("Foob","(Ljava/lang/Object;)I", false, false), // #1 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("zoo","()V", false, false), // #2 ()V
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.jvm.Interfaces.Zoo_))]
        internal partial class _Zoo : global::java.lang.Object, dummy.jvm.Interfaces.Zoo
        {
            static _Zoo()
            {
                global::net.sf.jni4net.modules.dummyjj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.jvm.Interfaces.Zoo_));
                global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.jvm.Interfaces.Zoo_));
            }
            
            protected _Zoo(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new dummy.jvm.Interfaces._Zoo(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            /// <signature>#0 ()V ()V</signature>
            public void foo()
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_env.CallVoidMethod(this, dummy.jvm.Interfaces.Zoo_.j4n_Members[0]);
                }
            }
            
            /// <signature>#1 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
            public int Foob(object par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return j4n_env.CallIntMethod(this, dummy.jvm.Interfaces.Zoo_.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
                }
            }
            
            /// <signature>#2 ()V ()V</signature>
            public void zoo()
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_env.CallVoidMethod(this, dummy.jvm.Interfaces.Zoo_.j4n_Members[2]);
                }
            }
        }
    }
}

#endregion Component Designer generated code
