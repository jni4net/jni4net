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

namespace java.util.zip
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.zip.ZipEntry))]
    public partial class ZipEntry : global::java.lang.Object, global::java.lang.Cloneable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected ZipEntry(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util.zip.ZipEntry(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static ZipEntry()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Cloneable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Cloneable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.zip.ZipEntry));
        }
        
        /// <signature>#0 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public ZipEntry(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.zip.ZipEntry.j4n_Class, java.util.zip.ZipEntry.j4n_Members[0], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#1 (Ljava/util/zip/ZipEntry;)V (Ljava/util/zip/ZipEntry;)V</signature>
        public ZipEntry(global::java.util.zip.ZipEntry par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.util.zip.ZipEntry.j4n_Class, java.util.zip.ZipEntry.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.zip.ZipEntry"));
            }
        }
        
        static public int DEFLATED {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.util.zip.ZipEntry.j4n_Class, java.util.zip.ZipEntry.j4n_Members[2]);
                }
            }
        }
        
        static public int STORED {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticIntField(java.util.zip.ZipEntry.j4n_Class, java.util.zip.ZipEntry.j4n_Members[3]);
                }
            }
        }
        
        /// <signature>#4 ()Ljava/lang/Object; ()Lsystem/Object;</signature>
        public virtual object clone()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.zip.ZipEntry.j4n_Members[4]));
            }
        }
        
        /// <signature>#5 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getComment()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.util.zip.ZipEntry.j4n_Members[5]);
            }
        }
        
        /// <signature>#6 ()J ()J</signature>
        public virtual long getCompressedSize()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallLongMethod(this, java.util.zip.ZipEntry.j4n_Members[6]);
            }
        }
        
        /// <signature>#7 ()J ()J</signature>
        public virtual long getCrc()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallLongMethod(this, java.util.zip.ZipEntry.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 ()[B ()[B</signature>
        public virtual byte[] getExtra()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertByte.ToCLRArray1(j4n_env, j4n_env.CallObjectMethod(this, java.util.zip.ZipEntry.j4n_Members[8]));
            }
        }
        
        /// <signature>#9 ()I ()I</signature>
        public virtual int getMethod()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.util.zip.ZipEntry.j4n_Members[9]);
            }
        }
        
        /// <signature>#10 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.util.zip.ZipEntry.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 ()J ()J</signature>
        public virtual long getSize()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallLongMethod(this, java.util.zip.ZipEntry.j4n_Members[11]);
            }
        }
        
        /// <signature>#12 ()J ()J</signature>
        public virtual long getTime()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallLongMethod(this, java.util.zip.ZipEntry.j4n_Members[12]);
            }
        }
        
        /// <signature>#13 ()Z ()Z</signature>
        public virtual bool isDirectory()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.util.zip.ZipEntry.j4n_Members[13]);
            }
        }
        
        /// <signature>#14 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public virtual void setComment(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.zip.ZipEntry.j4n_Members[14], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#15 (J)V (J)V</signature>
        public virtual void setCompressedSize(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.zip.ZipEntry.j4n_Members[15], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#16 (J)V (J)V</signature>
        public virtual void setCrc(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.zip.ZipEntry.j4n_Members[16], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#17 ([B)V ([B)V</signature>
        public virtual void setExtra(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.zip.ZipEntry.j4n_Members[17], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#18 (I)V (I)V</signature>
        public virtual void setMethod(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.zip.ZipEntry.j4n_Members[18], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#19 (J)V (J)V</signature>
        public virtual void setSize(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.zip.ZipEntry.j4n_Members[19], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#20 (J)V (J)V</signature>
        public virtual void setTime(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.zip.ZipEntry.j4n_Members[20], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.util.zip.ZipEntry))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.util.zip.ZipEntry";
                    proxyInfo.JVMStaticApiName = "java_.util.zip.ZipEntry_";
                    proxyInfo.CLRApi = typeof(java.util.zip.ZipEntry);
                    proxyInfo.CLRStaticApi = typeof(java.util.zip.ZipEntry);
                    proxyInfo.CLRProxy = typeof(java.util.zip.ZipEntry);
                    proxyInfo.JVMProxyFactory = java.util.zip.ZipEntry.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #0 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/util/zip/ZipEntry;)V", false, false), // #1 (Ljava/util/zip/ZipEntry;)V
                        new global::net.sf.jni4net.core.MemberId("DEFLATED","I", true, true), // #2 ()I
                        new global::net.sf.jni4net.core.MemberId("STORED","I", true, true), // #3 ()I
                        new global::net.sf.jni4net.core.MemberId("clone","()Ljava/lang/Object;", false, false), // #4 ()Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("getComment","()Ljava/lang/String;", false, false), // #5 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getCompressedSize","()J", false, false), // #6 ()J
                        new global::net.sf.jni4net.core.MemberId("getCrc","()J", false, false), // #7 ()J
                        new global::net.sf.jni4net.core.MemberId("getExtra","()[B", false, false), // #8 ()[B
                        new global::net.sf.jni4net.core.MemberId("getMethod","()I", false, false), // #9 ()I
                        new global::net.sf.jni4net.core.MemberId("getName","()Ljava/lang/String;", false, false), // #10 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getSize","()J", false, false), // #11 ()J
                        new global::net.sf.jni4net.core.MemberId("getTime","()J", false, false), // #12 ()J
                        new global::net.sf.jni4net.core.MemberId("isDirectory","()Z", false, false), // #13 ()Z
                        new global::net.sf.jni4net.core.MemberId("setComment","(Ljava/lang/String;)V", false, false), // #14 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("setCompressedSize","(J)V", false, false), // #15 (J)V
                        new global::net.sf.jni4net.core.MemberId("setCrc","(J)V", false, false), // #16 (J)V
                        new global::net.sf.jni4net.core.MemberId("setExtra","([B)V", false, false), // #17 ([B)V
                        new global::net.sf.jni4net.core.MemberId("setMethod","(I)V", false, false), // #18 (I)V
                        new global::net.sf.jni4net.core.MemberId("setSize","(J)V", false, false), // #19 (J)V
                        new global::net.sf.jni4net.core.MemberId("setTime","(J)V", false, false), // #20 (J)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
