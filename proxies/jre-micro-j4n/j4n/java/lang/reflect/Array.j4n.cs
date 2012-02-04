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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.reflect.Array))]
    public sealed partial class Array : global::java.lang.Object
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        private Array(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.reflect.Array(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static Array()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.reflect.Array));
        }
        
        /// <signature>#0 (Ljava/lang/Object;I)Ljava/lang/Object; (Lsystem/Object;I)Lsystem/Object;</signature>
        static public object get(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#1 (Ljava/lang/Object;I)Z (Lsystem/Object;I)Z</signature>
        static public bool getBoolean(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticBooleanMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#2 (Ljava/lang/Object;I)B (Lsystem/Object;I)B</signature>
        static public byte getByte(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticByteMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#3 (Ljava/lang/Object;I)C (Lsystem/Object;I)C</signature>
        static public char getChar(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticCharMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#4 (Ljava/lang/Object;I)D (Lsystem/Object;I)D</signature>
        static public double getDouble(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticDoubleMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[4], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#5 (Ljava/lang/Object;I)F (Lsystem/Object;I)F</signature>
        static public float getFloat(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticFloatMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[5], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#6 (Ljava/lang/Object;I)I (Lsystem/Object;I)I</signature>
        static public int getInt(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticIntMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[6], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#7 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static public int getLength(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallStaticIntMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[7], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#8 (Ljava/lang/Object;I)J (Lsystem/Object;I)J</signature>
        static public long getLong(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticLongMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[8], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#9 (Ljava/lang/Object;I)S (Lsystem/Object;I)S</signature>
        static public short getShort(object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallStaticShortMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[9], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#10 (Ljava/lang/Class;[I)Ljava/lang/Object; (Ljava/lang/Class;[I)Lsystem/Object;</signature>
        static public object newInstance(global::java.lang.Class par0, int[] par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[10], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#11 (Ljava/lang/Class;I)Ljava/lang/Object; (Ljava/lang/Class;I)Lsystem/Object;</signature>
        static public object newInstance(global::java.lang.Class par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallStaticObjectMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[11], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#12 (Ljava/lang/Object;ILjava/lang/Object;)V (Lsystem/Object;ILsystem/Object;)V</signature>
        static public void set(object par0, int par1, object par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.lang.Object"));
            }
        }
        
        /// <signature>#13 (Ljava/lang/Object;IZ)V (Lsystem/Object;IZ)V</signature>
        static public void setBoolean(object par0, int par1, bool par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[13], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par2));
            }
        }
        
        /// <signature>#14 (Ljava/lang/Object;IB)V (Lsystem/Object;IB)V</signature>
        static public void setByte(object par0, int par1, byte par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[14], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertByte.ToValue(par2));
            }
        }
        
        /// <signature>#15 (Ljava/lang/Object;IC)V (Lsystem/Object;IC)V</signature>
        static public void setChar(object par0, int par1, char par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[15], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertChar.ToValue(par2));
            }
        }
        
        /// <signature>#16 (Ljava/lang/Object;ID)V (Lsystem/Object;ID)V</signature>
        static public void setDouble(object par0, int par1, double par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[16], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertDouble.ToValue(par2));
            }
        }
        
        /// <signature>#17 (Ljava/lang/Object;IF)V (Lsystem/Object;IF)V</signature>
        static public void setFloat(object par0, int par1, float par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[17], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertFloat.ToValue(par2));
            }
        }
        
        /// <signature>#18 (Ljava/lang/Object;II)V (Lsystem/Object;II)V</signature>
        static public void setInt(object par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[18], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#19 (Ljava/lang/Object;IJ)V (Lsystem/Object;IJ)V</signature>
        static public void setLong(object par0, int par1, long par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[19], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertLong.ToValue(par2));
            }
        }
        
        /// <signature>#20 (Ljava/lang/Object;IS)V (Lsystem/Object;IS)V</signature>
        static public void setShort(object par0, int par1, short par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallStaticVoidMethod(java.lang.reflect.Array.j4n_Class, java.lang.reflect.Array.j4n_Members[20], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertShort.ToValue(par2));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.reflect.Array))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.lang.reflect.Array";
                    proxyInfo.JVMStaticApiName = "java_.lang.reflect.Array_";
                    proxyInfo.CLRApi = typeof(java.lang.reflect.Array);
                    proxyInfo.CLRStaticApi = typeof(java.lang.reflect.Array);
                    proxyInfo.CLRProxy = typeof(java.lang.reflect.Array);
                    proxyInfo.JVMProxyFactory = java.lang.reflect.Array.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/Object;I)Ljava/lang/Object;", false, true), // #0 (Lsystem/Object;I)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getBoolean","(Ljava/lang/Object;I)Z", false, true), // #1 (Lsystem/Object;I)Z
                        new global::net.sf.jni4net.core.MemberId("getByte","(Ljava/lang/Object;I)B", false, true), // #2 (Lsystem/Object;I)B
                        new global::net.sf.jni4net.core.MemberId("getChar","(Ljava/lang/Object;I)C", false, true), // #3 (Lsystem/Object;I)C
                        new global::net.sf.jni4net.core.MemberId("getDouble","(Ljava/lang/Object;I)D", false, true), // #4 (Lsystem/Object;I)D
                        new global::net.sf.jni4net.core.MemberId("getFloat","(Ljava/lang/Object;I)F", false, true), // #5 (Lsystem/Object;I)F
                        new global::net.sf.jni4net.core.MemberId("getInt","(Ljava/lang/Object;I)I", false, true), // #6 (Lsystem/Object;I)I
                        new global::net.sf.jni4net.core.MemberId("getLength","(Ljava/lang/Object;)I", false, true), // #7 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("getLong","(Ljava/lang/Object;I)J", false, true), // #8 (Lsystem/Object;I)J
                        new global::net.sf.jni4net.core.MemberId("getShort","(Ljava/lang/Object;I)S", false, true), // #9 (Lsystem/Object;I)S
                        new global::net.sf.jni4net.core.MemberId("newInstance","(Ljava/lang/Class;[I)Ljava/lang/Object;", false, true), // #10 (Ljava/lang/Class;[I)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("newInstance","(Ljava/lang/Class;I)Ljava/lang/Object;", false, true), // #11 (Ljava/lang/Class;I)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("set","(Ljava/lang/Object;ILjava/lang/Object;)V", false, true), // #12 (Lsystem/Object;ILsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("setBoolean","(Ljava/lang/Object;IZ)V", false, true), // #13 (Lsystem/Object;IZ)V
                        new global::net.sf.jni4net.core.MemberId("setByte","(Ljava/lang/Object;IB)V", false, true), // #14 (Lsystem/Object;IB)V
                        new global::net.sf.jni4net.core.MemberId("setChar","(Ljava/lang/Object;IC)V", false, true), // #15 (Lsystem/Object;IC)V
                        new global::net.sf.jni4net.core.MemberId("setDouble","(Ljava/lang/Object;ID)V", false, true), // #16 (Lsystem/Object;ID)V
                        new global::net.sf.jni4net.core.MemberId("setFloat","(Ljava/lang/Object;IF)V", false, true), // #17 (Lsystem/Object;IF)V
                        new global::net.sf.jni4net.core.MemberId("setInt","(Ljava/lang/Object;II)V", false, true), // #18 (Lsystem/Object;II)V
                        new global::net.sf.jni4net.core.MemberId("setLong","(Ljava/lang/Object;IJ)V", false, true), // #19 (Lsystem/Object;IJ)V
                        new global::net.sf.jni4net.core.MemberId("setShort","(Ljava/lang/Object;IS)V", false, true), // #20 (Lsystem/Object;IS)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
