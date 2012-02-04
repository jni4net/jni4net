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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.Field))]
    public sealed partial class Field : global::java.lang.reflect.AccessibleObject, global::java.lang.reflect.Member
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Field(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect.Field(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Field()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.AccessibleObject));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.reflect.Member_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.reflect.Member_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.Field));
        }
        
        /// <signature>#0 (Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        public object get(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Field.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#1 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool getBoolean(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.Field.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#2 (Ljava/lang/Object;)B (Lsystem/Object;)B</signature>
        public byte getByte(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallByteMethod(this, java.lang.reflect.Field.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#3 (Ljava/lang/Object;)C (Lsystem/Object;)C</signature>
        public char getChar(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallCharMethod(this, java.lang.reflect.Field.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#4 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getDeclaringClass()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Field.j4n_Members[4]));
            }
        }
        
        /// <signature>#5 (Ljava/lang/Object;)D (Lsystem/Object;)D</signature>
        public double getDouble(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallDoubleMethod(this, java.lang.reflect.Field.j4n_Members[5], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#6 (Ljava/lang/Object;)F (Lsystem/Object;)F</signature>
        public float getFloat(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallFloatMethod(this, java.lang.reflect.Field.j4n_Members[6], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#7 ()Ljava/lang/reflect/Type; ()Ljava/lang/reflect/Type;</signature>
        public global::java.lang.reflect.Type getGenericType()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.lang.reflect.Type>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Field.j4n_Members[7]));
            }
        }
        
        /// <signature>#8 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int getInt(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.lang.reflect.Field.j4n_Members[8], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#9 (Ljava/lang/Object;)J (Lsystem/Object;)J</signature>
        public long getLong(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallLongMethod(this, java.lang.reflect.Field.j4n_Members[9], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#10 ()I ()I</signature>
        public int getModifiers()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.lang.reflect.Field.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string getName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.reflect.Field.j4n_Members[11]);
            }
        }
        
        /// <signature>#12 (Ljava/lang/Object;)S (Lsystem/Object;)S</signature>
        public short getShort(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallShortMethod(this, java.lang.reflect.Field.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#13 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class getType()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.reflect.Field.j4n_Members[13]));
            }
        }
        
        /// <signature>#14 ()Z ()Z</signature>
        public bool isEnumConstant()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.Field.j4n_Members[14]);
            }
        }
        
        /// <signature>#15 ()Z ()Z</signature>
        public bool isSynthetic()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.lang.reflect.Field.j4n_Members[15]);
            }
        }
        
        /// <signature>#16 (Ljava/lang/Object;Ljava/lang/Object;)V (Lsystem/Object;Lsystem/Object;)V</signature>
        public void set(object par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[16], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"));
            }
        }
        
        /// <signature>#17 (Ljava/lang/Object;Z)V (Lsystem/Object;Z)V</signature>
        public void setBoolean(object par0, bool par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[17], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1));
            }
        }
        
        /// <signature>#18 (Ljava/lang/Object;B)V (Lsystem/Object;B)V</signature>
        public void setByte(object par0, byte par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[18], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertByte.ToValue(par1));
            }
        }
        
        /// <signature>#19 (Ljava/lang/Object;C)V (Lsystem/Object;C)V</signature>
        public void setChar(object par0, char par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[19], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertChar.ToValue(par1));
            }
        }
        
        /// <signature>#20 (Ljava/lang/Object;D)V (Lsystem/Object;D)V</signature>
        public void setDouble(object par0, double par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[20], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertDouble.ToValue(par1));
            }
        }
        
        /// <signature>#21 (Ljava/lang/Object;F)V (Lsystem/Object;F)V</signature>
        public void setFloat(object par0, float par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[21], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertFloat.ToValue(par1));
            }
        }
        
        /// <signature>#22 (Ljava/lang/Object;I)V (Lsystem/Object;I)V</signature>
        public void setInt(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[22], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#23 (Ljava/lang/Object;J)V (Lsystem/Object;J)V</signature>
        public void setLong(object par0, long par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[23], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertLong.ToValue(par1));
            }
        }
        
        /// <signature>#24 (Ljava/lang/Object;S)V (Lsystem/Object;S)V</signature>
        public void setShort(object par0, short par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.lang.reflect.Field.j4n_Members[24], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertShort.ToValue(par1));
            }
        }
        
        /// <signature>#25 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string toGenericString()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.lang.reflect.Field.j4n_Members[25]);
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.reflect.Field))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.reflect.Field";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.Field_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.Field);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.Field);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect.Field);
                    proxyInfo.JVMProxyFactory = java.lang.reflect.Field.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #0 (Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getBoolean","(Ljava/lang/Object;)Z", false, false), // #1 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("getByte","(Ljava/lang/Object;)B", false, false), // #2 (Lsystem/Object;)B
                        new global::net.sf.jni4net.core.MemberId("getChar","(Ljava/lang/Object;)C", false, false), // #3 (Lsystem/Object;)C
                        new global::net.sf.jni4net.core.MemberId("getDeclaringClass","()Ljava/lang/Class;", false, false), // #4 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("getDouble","(Ljava/lang/Object;)D", false, false), // #5 (Lsystem/Object;)D
                        new global::net.sf.jni4net.core.MemberId("getFloat","(Ljava/lang/Object;)F", false, false), // #6 (Lsystem/Object;)F
                        new global::net.sf.jni4net.core.MemberId("getGenericType","()Ljava/lang/reflect/Type;", false, false), // #7 ()Ljava/lang/reflect/Type;
                        new global::net.sf.jni4net.core.MemberId("getInt","(Ljava/lang/Object;)I", false, false), // #8 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("getLong","(Ljava/lang/Object;)J", false, false), // #9 (Lsystem/Object;)J
                        new global::net.sf.jni4net.core.MemberId("getModifiers","()I", false, false), // #10 ()I
                        new global::net.sf.jni4net.core.MemberId("getName","()Ljava/lang/String;", false, false), // #11 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getShort","(Ljava/lang/Object;)S", false, false), // #12 (Lsystem/Object;)S
                        new global::net.sf.jni4net.core.MemberId("getType","()Ljava/lang/Class;", false, false), // #13 ()Ljava/lang/Class;
                        new global::net.sf.jni4net.core.MemberId("isEnumConstant","()Z", false, false), // #14 ()Z
                        new global::net.sf.jni4net.core.MemberId("isSynthetic","()Z", false, false), // #15 ()Z
                        new global::net.sf.jni4net.core.MemberId("set","(Ljava/lang/Object;Ljava/lang/Object;)V", false, false), // #16 (Lsystem/Object;Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("setBoolean","(Ljava/lang/Object;Z)V", false, false), // #17 (Lsystem/Object;Z)V
                        new global::net.sf.jni4net.core.MemberId("setByte","(Ljava/lang/Object;B)V", false, false), // #18 (Lsystem/Object;B)V
                        new global::net.sf.jni4net.core.MemberId("setChar","(Ljava/lang/Object;C)V", false, false), // #19 (Lsystem/Object;C)V
                        new global::net.sf.jni4net.core.MemberId("setDouble","(Ljava/lang/Object;D)V", false, false), // #20 (Lsystem/Object;D)V
                        new global::net.sf.jni4net.core.MemberId("setFloat","(Ljava/lang/Object;F)V", false, false), // #21 (Lsystem/Object;F)V
                        new global::net.sf.jni4net.core.MemberId("setInt","(Ljava/lang/Object;I)V", false, false), // #22 (Lsystem/Object;I)V
                        new global::net.sf.jni4net.core.MemberId("setLong","(Ljava/lang/Object;J)V", false, false), // #23 (Lsystem/Object;J)V
                        new global::net.sf.jni4net.core.MemberId("setShort","(Ljava/lang/Object;S)V", false, false), // #24 (Lsystem/Object;S)V
                        new global::net.sf.jni4net.core.MemberId("toGenericString","()Ljava/lang/String;", false, false), // #25 ()Lsystem/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
