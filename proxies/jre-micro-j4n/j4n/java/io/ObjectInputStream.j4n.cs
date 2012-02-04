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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectInputStream))]
    public partial class ObjectInputStream : global::java.io.InputStream, global::java.io.ObjectInput, global::java.io.ObjectStreamConstants
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected ObjectInputStream(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.ObjectInputStream(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static ObjectInputStream()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.InputStream));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.ObjectInput_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.ObjectInput_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.ObjectStreamConstants_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.ObjectStreamConstants_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ObjectInputStream));
        }
        
        /// <signature>#0 (Ljava/io/InputStream;)V (Ljava/io/InputStream;)V</signature>
        public ObjectInputStream(global::java.io.InputStream par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.ObjectInputStream.j4n_Class, java.io.ObjectInputStream.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.InputStream"));
            }
        }
        
        /// <signature>#1 ()V ()V</signature>
        public virtual void defaultReadObject()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectInputStream.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 ()Z ()Z</signature>
        public virtual bool readBoolean()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.ObjectInputStream.j4n_Members[2]);
            }
        }
        
        /// <signature>#3 ()B ()B</signature>
        public virtual byte readByte()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallByteMethod(this, java.io.ObjectInputStream.j4n_Members[3]);
            }
        }
        
        /// <signature>#4 ()C ()C</signature>
        public virtual char readChar()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallCharMethod(this, java.io.ObjectInputStream.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 ()D ()D</signature>
        public virtual double readDouble()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallDoubleMethod(this, java.io.ObjectInputStream.j4n_Members[5]);
            }
        }
        
        /// <signature>#6 ()Ljava/io/ObjectInputStream$GetField; ()Ljava/io/ObjectInputStream+GetField;</signature>
        public virtual global::java.io.ObjectInputStream.GetField readFields()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.ObjectInputStream.GetField>(j4n_env, j4n_env.CallObjectMethod(this, java.io.ObjectInputStream.j4n_Members[6]));
            }
        }
        
        /// <signature>#7 ()F ()F</signature>
        public virtual float readFloat()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallFloatMethod(this, java.io.ObjectInputStream.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 ([B)V ([B)V</signature>
        public virtual void readFully(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectInputStream.j4n_Members[8], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#9 ([BII)V ([BII)V</signature>
        public virtual void readFully(byte[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectInputStream.j4n_Members[9], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#10 ()I ()I</signature>
        public virtual int readInt()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.ObjectInputStream.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string readLine()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.ObjectInputStream.j4n_Members[11]);
            }
        }
        
        /// <signature>#12 ()J ()J</signature>
        public virtual long readLong()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallLongMethod(this, java.io.ObjectInputStream.j4n_Members[12]);
            }
        }
        
        /// <signature>#13 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public object readObject()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.io.ObjectInputStream.j4n_Members[13]));
            }
        }
        
        /// <signature>#14 ()S ()S</signature>
        public virtual short readShort()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallShortMethod(this, java.io.ObjectInputStream.j4n_Members[14]);
            }
        }
        
        /// <signature>#15 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public virtual object readUnshared()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.io.ObjectInputStream.j4n_Members[15]));
            }
        }
        
        /// <signature>#16 ()I ()I</signature>
        public virtual int readUnsignedByte()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.ObjectInputStream.j4n_Members[16]);
            }
        }
        
        /// <signature>#17 ()I ()I</signature>
        public virtual int readUnsignedShort()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.ObjectInputStream.j4n_Members[17]);
            }
        }
        
        /// <signature>#18 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string readUTF()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.ObjectInputStream.j4n_Members[18]);
            }
        }
        
        /// <signature>#19 (Ljava/io/ObjectInputValidation;I)V (Ljava/lang/Object;I)V</signature>
        public virtual void registerValidation(global::java.lang.Object par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectInputStream.j4n_Members[19], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.ObjectInputValidation"), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
            }
        }
        
        /// <signature>#20 (I)I (I)I</signature>
        public virtual int skipBytes(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.io.ObjectInputStream.j4n_Members[20], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.ObjectInputStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.ObjectInputStream";
                    proxyInfo.JVMStaticApiName = "java_.io.ObjectInputStream_";
                    proxyInfo.CLRApi = typeof(java.io.ObjectInputStream);
                    proxyInfo.CLRStaticApi = typeof(java.io.ObjectInputStream);
                    proxyInfo.CLRProxy = typeof(java.io.ObjectInputStream);
                    proxyInfo.JVMProxyFactory = java.io.ObjectInputStream.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/InputStream;)V", false, false), // #0 (Ljava/io/InputStream;)V
                        new global::net.sf.jni4net.core.MemberId("defaultReadObject","()V", false, false), // #1 ()V
                        new global::net.sf.jni4net.core.MemberId("readBoolean","()Z", false, false), // #2 ()Z
                        new global::net.sf.jni4net.core.MemberId("readByte","()B", false, false), // #3 ()B
                        new global::net.sf.jni4net.core.MemberId("readChar","()C", false, false), // #4 ()C
                        new global::net.sf.jni4net.core.MemberId("readDouble","()D", false, false), // #5 ()D
                        new global::net.sf.jni4net.core.MemberId("readFields","()Ljava/io/ObjectInputStream$GetField;", false, false), // #6 ()Ljava/io/ObjectInputStream+GetField;
                        new global::net.sf.jni4net.core.MemberId("readFloat","()F", false, false), // #7 ()F
                        new global::net.sf.jni4net.core.MemberId("readFully","([B)V", false, false), // #8 ([B)V
                        new global::net.sf.jni4net.core.MemberId("readFully","([BII)V", false, false), // #9 ([BII)V
                        new global::net.sf.jni4net.core.MemberId("readInt","()I", false, false), // #10 ()I
                        new global::net.sf.jni4net.core.MemberId("readLine","()Ljava/lang/String;", false, false), // #11 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("readLong","()J", false, false), // #12 ()J
                        new global::net.sf.jni4net.core.MemberId("readObject","()Ljava/lang/Object;", false, false), // #13 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("readShort","()S", false, false), // #14 ()S
                        new global::net.sf.jni4net.core.MemberId("readUnshared","()Ljava/lang/Object;", false, false), // #15 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("readUnsignedByte","()I", false, false), // #16 ()I
                        new global::net.sf.jni4net.core.MemberId("readUnsignedShort","()I", false, false), // #17 ()I
                        new global::net.sf.jni4net.core.MemberId("readUTF","()Ljava/lang/String;", false, false), // #18 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("registerValidation","(Ljava/io/ObjectInputValidation;I)V", false, false), // #19 (Ljava/lang/Object;I)V
                        new global::net.sf.jni4net.core.MemberId("skipBytes","(I)I", false, false), // #20 (I)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectInputStream.GetField))]
        public partial class GetField : global::java.lang.Object
        {
            
            static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static private global::java.lang.IClass j4n_Class;
            
            static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            new static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            protected GetField(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new java.io.ObjectInputStream.GetField(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            static GetField()
            {
                global::net.sf.jni4net.modules.jremicroj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ObjectInputStream.GetField));
            }
            
            /// <signature>#0 ()V ()V</signature>
            public GetField()
                : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_handle = j4n_env.NewObjectG(java.io.ObjectInputStream.GetField.j4n_Class, java.io.ObjectInputStream.GetField.j4n_Members[0]);
                }
            }
            
            /// <signature>#1 (Ljava/lang/String;)Z (Lsystem/String;)Z</signature>
            public virtual bool defaulted(string par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return j4n_env.CallBooleanMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
                }
            }
            
            /// <signature>#2 (Ljava/lang/String;B)B (Lsystem/String;B)B</signature>
            public virtual byte get(string par0, byte par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return j4n_env.CallByteMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertByte.ToValue(par1));
                }
            }
            
            /// <signature>#3 (Ljava/lang/String;C)C (Lsystem/String;C)C</signature>
            public virtual char get(string par0, char par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return j4n_env.CallCharMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1));
                }
            }
            
            /// <signature>#4 (Ljava/lang/String;D)D (Lsystem/String;D)D</signature>
            public virtual double get(string par0, double par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return j4n_env.CallDoubleMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[4], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertDouble.ToValue(par1));
                }
            }
            
            /// <signature>#5 (Ljava/lang/String;F)F (Lsystem/String;F)F</signature>
            public virtual float get(string par0, float par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return j4n_env.CallFloatMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertFloat.ToValue(par1));
                }
            }
            
            /// <signature>#6 (Ljava/lang/String;I)I (Lsystem/String;I)I</signature>
            public virtual int get(string par0, int par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return j4n_env.CallIntMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
                }
            }
            
            /// <signature>#7 (Ljava/lang/String;J)J (Lsystem/String;J)J</signature>
            public virtual long get(string par0, long par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return j4n_env.CallLongMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[7], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertLong.ToValue(par1));
                }
            }
            
            /// <signature>#8 (Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/String;Lsystem/Object;)Lsystem/Object;</signature>
            public virtual object get(string par0, object par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[8], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
                }
            }
            
            /// <signature>#9 (Ljava/lang/String;S)S (Lsystem/String;S)S</signature>
            public virtual short get(string par0, short par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return j4n_env.CallShortMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[9], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertShort.ToValue(par1));
                }
            }
            
            /// <signature>#10 (Ljava/lang/String;Z)Z (Lsystem/String;Z)Z</signature>
            public virtual bool get(string par0, bool par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    return j4n_env.CallBooleanMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[10], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1));
                }
            }
            
            /// <signature>#11 ()Ljava/io/ObjectStreamClass; ()Ljava/io/Serializable;</signature>
            public virtual global::java.io.Serializable getObjectStreamClass()
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.Serializable>(j4n_env, j4n_env.CallObjectMethod(this, java.io.ObjectInputStream.GetField.j4n_Members[11]));
                }
            }
            
            new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
            {
                lock (typeof(global::java.io.ObjectInputStream.GetField))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = false;
                        proxyInfo.JVMApiName = "java.io.ObjectInputStream$GetField";
                        proxyInfo.JVMStaticApiName = "java_.io.ObjectInputStream_$GetField_";
                        proxyInfo.CLRApi = typeof(java.io.ObjectInputStream.GetField);
                        proxyInfo.CLRStaticApi = typeof(java.io.ObjectInputStream.GetField);
                        proxyInfo.CLRProxy = typeof(java.io.ObjectInputStream.GetField);
                        proxyInfo.JVMProxyFactory = java.io.ObjectInputStream.GetField.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("defaulted","(Ljava/lang/String;)Z", false, false), // #1 (Lsystem/String;)Z
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;B)B", false, false), // #2 (Lsystem/String;B)B
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;C)C", false, false), // #3 (Lsystem/String;C)C
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;D)D", false, false), // #4 (Lsystem/String;D)D
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;F)F", false, false), // #5 (Lsystem/String;F)F
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;I)I", false, false), // #6 (Lsystem/String;I)I
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;J)J", false, false), // #7 (Lsystem/String;J)J
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #8 (Lsystem/String;Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;S)S", false, false), // #9 (Lsystem/String;S)S
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/String;Z)Z", false, false), // #10 (Lsystem/String;Z)Z
                        new global::net.sf.jni4net.core.MemberId("getObjectStreamClass","()Ljava/io/ObjectStreamClass;", false, false), // #11 ()Ljava/io/Serializable;
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
    }
}

#endregion Component Designer generated code
