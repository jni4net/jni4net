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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectOutputStream))]
    public partial class ObjectOutputStream : global::java.io.OutputStream, global::java.io.ObjectOutput, global::java.io.ObjectStreamConstants
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected ObjectOutputStream(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.ObjectOutputStream(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static ObjectOutputStream()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.OutputStream));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.ObjectOutput_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.ObjectOutput_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.ObjectStreamConstants_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.ObjectStreamConstants_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ObjectOutputStream));
        }
        
        /// <signature>#0 (Ljava/io/OutputStream;)V (Ljava/io/OutputStream;)V</signature>
        public ObjectOutputStream(global::java.io.OutputStream par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.ObjectOutputStream.j4n_Class, java.io.ObjectOutputStream.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.OutputStream"));
            }
        }
        
        /// <signature>#1 ()V ()V</signature>
        public virtual void defaultWriteObject()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 ()Ljava/io/ObjectOutputStream$PutField; ()Ljava/io/ObjectOutputStream+PutField;</signature>
        public virtual global::java.io.ObjectOutputStream.PutField putFields()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.ObjectOutputStream.PutField>(j4n_env, j4n_env.CallObjectMethod(this, java.io.ObjectOutputStream.j4n_Members[2]));
            }
        }
        
        /// <signature>#3 ()V ()V</signature>
        public virtual void reset()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[3]);
            }
        }
        
        /// <signature>#4 (I)V (I)V</signature>
        public virtual void useProtocolVersion(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[4], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#5 (Z)V (Z)V</signature>
        public virtual void writeBoolean(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[5], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        /// <signature>#6 (I)V (I)V</signature>
        public virtual void writeByte(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[6], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#7 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public virtual void writeBytes(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[7], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#8 (I)V (I)V</signature>
        public virtual void writeChar(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[8], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#9 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public virtual void writeChars(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[9], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#10 (D)V (D)V</signature>
        public virtual void writeDouble(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[10], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#11 ()V ()V</signature>
        public virtual void writeFields()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[11]);
            }
        }
        
        /// <signature>#12 (F)V (F)V</signature>
        public virtual void writeFloat(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[12], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#13 (I)V (I)V</signature>
        public virtual void writeInt(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[13], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#14 (J)V (J)V</signature>
        public virtual void writeLong(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[14], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#15 (Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        public void writeObject(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[15], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#16 (I)V (I)V</signature>
        public virtual void writeShort(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[16], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#17 (Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        public virtual void writeUnshared(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[17], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#18 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public virtual void writeUTF(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.j4n_Members[18], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.ObjectOutputStream))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.ObjectOutputStream";
                    proxyInfo.JVMStaticApiName = "java_.io.ObjectOutputStream_";
                    proxyInfo.CLRApi = typeof(java.io.ObjectOutputStream);
                    proxyInfo.CLRStaticApi = typeof(java.io.ObjectOutputStream);
                    proxyInfo.CLRProxy = typeof(java.io.ObjectOutputStream);
                    proxyInfo.JVMProxyFactory = java.io.ObjectOutputStream.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/OutputStream;)V", false, false), // #0 (Ljava/io/OutputStream;)V
                        new global::net.sf.jni4net.core.MemberId("defaultWriteObject","()V", false, false), // #1 ()V
                        new global::net.sf.jni4net.core.MemberId("putFields","()Ljava/io/ObjectOutputStream$PutField;", false, false), // #2 ()Ljava/io/ObjectOutputStream+PutField;
                        new global::net.sf.jni4net.core.MemberId("reset","()V", false, false), // #3 ()V
                        new global::net.sf.jni4net.core.MemberId("useProtocolVersion","(I)V", false, false), // #4 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeBoolean","(Z)V", false, false), // #5 (Z)V
                        new global::net.sf.jni4net.core.MemberId("writeByte","(I)V", false, false), // #6 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeBytes","(Ljava/lang/String;)V", false, false), // #7 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("writeChar","(I)V", false, false), // #8 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeChars","(Ljava/lang/String;)V", false, false), // #9 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("writeDouble","(D)V", false, false), // #10 (D)V
                        new global::net.sf.jni4net.core.MemberId("writeFields","()V", false, false), // #11 ()V
                        new global::net.sf.jni4net.core.MemberId("writeFloat","(F)V", false, false), // #12 (F)V
                        new global::net.sf.jni4net.core.MemberId("writeInt","(I)V", false, false), // #13 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeLong","(J)V", false, false), // #14 (J)V
                        new global::net.sf.jni4net.core.MemberId("writeObject","(Ljava/lang/Object;)V", false, false), // #15 (Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("writeShort","(I)V", false, false), // #16 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeUnshared","(Ljava/lang/Object;)V", false, false), // #17 (Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("writeUTF","(Ljava/lang/String;)V", false, false), // #18 (Lsystem/String;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
        
        [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectOutputStream.PutField))]
        public partial class PutField : global::java.lang.Object
        {
            
            static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
            
            static private global::java.lang.IClass j4n_Class;
            
            static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
            
            new static public global::java.lang.IClass _class {
                get {
                    return j4n_Class;
                }
            }
            
            protected PutField(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
                : base(j4n_env, j4n_handle, j4n_instanceInfo)
            {
            }
            
            new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            {
                return new java.io.ObjectOutputStream.PutField(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
            }
            
            static PutField()
            {
                global::net.sf.jni4net.modules.jremicroj4n.InitModule();
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
                global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ObjectOutputStream.PutField));
            }
            
            /// <signature>#0 ()V ()V</signature>
            public PutField()
                : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    j4n_handle = j4n_env.NewObjectG(java.io.ObjectOutputStream.PutField.j4n_Class, java.io.ObjectOutputStream.PutField.j4n_Members[0]);
                }
            }
            
            /// <signature>#1 (Ljava/lang/String;B)V (Lsystem/String;B)V</signature>
            public virtual void put(string par0, byte par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertByte.ToValue(par1));
                }
            }
            
            /// <signature>#2 (Ljava/lang/String;C)V (Lsystem/String;C)V</signature>
            public virtual void put(string par0, char par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertChar.ToValue(par1));
                }
            }
            
            /// <signature>#3 (Ljava/lang/String;D)V (Lsystem/String;D)V</signature>
            public virtual void put(string par0, double par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[3], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertDouble.ToValue(par1));
                }
            }
            
            /// <signature>#4 (Ljava/lang/String;F)V (Lsystem/String;F)V</signature>
            public virtual void put(string par0, float par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[4], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertFloat.ToValue(par1));
                }
            }
            
            /// <signature>#5 (Ljava/lang/String;I)V (Lsystem/String;I)V</signature>
            public virtual void put(string par0, int par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1));
                }
            }
            
            /// <signature>#6 (Ljava/lang/String;J)V (Lsystem/String;J)V</signature>
            public virtual void put(string par0, long par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[6], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertLong.ToValue(par1));
                }
            }
            
            /// <signature>#7 (Ljava/lang/String;Ljava/lang/Object;)V (Lsystem/String;Lsystem/Object;)V</signature>
            public virtual void put(string par0, object par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[7], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"));
                }
            }
            
            /// <signature>#8 (Ljava/lang/String;S)V (Lsystem/String;S)V</signature>
            public virtual void put(string par0, short par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[8], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertShort.ToValue(par1));
                }
            }
            
            /// <signature>#9 (Ljava/lang/String;Z)V (Lsystem/String;Z)V</signature>
            public virtual void put(string par0, bool par1)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[9], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertBoolean.ToValue(par1));
                }
            }
            
            /// <signature>#10 (Ljava/io/ObjectOutput;)V (Ljava/io/ObjectOutput;)V</signature>
            public virtual void write(global::java.io.ObjectOutput par0)
            {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    j4n_env.CallVoidMethod(this, java.io.ObjectOutputStream.PutField.j4n_Members[10], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.ObjectOutput"));
                }
            }
            
            new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
            {
                lock (typeof(global::java.io.ObjectOutputStream.PutField))
                {
                    if (j4n_TypeInfo==null)
                    {
                        j4n_TypeInfo = proxyInfo;
                        proxyInfo.IsCLR = false;
                        proxyInfo.IsInterface = false;
                        proxyInfo.JVMApiName = "java.io.ObjectOutputStream$PutField";
                        proxyInfo.JVMStaticApiName = "java_.io.ObjectOutputStream_$PutField_";
                        proxyInfo.CLRApi = typeof(java.io.ObjectOutputStream.PutField);
                        proxyInfo.CLRStaticApi = typeof(java.io.ObjectOutputStream.PutField);
                        proxyInfo.CLRProxy = typeof(java.io.ObjectOutputStream.PutField);
                        proxyInfo.JVMProxyFactory = java.io.ObjectOutputStream.PutField.j4n_ProxyFactory;
                        proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;B)V", false, false), // #1 (Lsystem/String;B)V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;C)V", false, false), // #2 (Lsystem/String;C)V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;D)V", false, false), // #3 (Lsystem/String;D)V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;F)V", false, false), // #4 (Lsystem/String;F)V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;I)V", false, false), // #5 (Lsystem/String;I)V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;J)V", false, false), // #6 (Lsystem/String;J)V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;Ljava/lang/Object;)V", false, false), // #7 (Lsystem/String;Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;S)V", false, false), // #8 (Lsystem/String;S)V
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/String;Z)V", false, false), // #9 (Lsystem/String;Z)V
                        new global::net.sf.jni4net.core.MemberId("write","(Ljava/io/ObjectOutput;)V", false, false), // #10 (Ljava/io/ObjectOutput;)V
                        };
                    }
                    return j4n_TypeInfo;
                }
            }
        }
    }
}

#endregion Component Designer generated code
