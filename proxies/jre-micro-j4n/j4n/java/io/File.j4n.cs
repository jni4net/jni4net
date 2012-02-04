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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.File))]
    public partial class File : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Comparable
    {
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        protected File(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io.File(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        static File()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Object));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.io.Serializable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::java.lang.Comparable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.File));
        }
        
        /// <signature>#0 (Ljava/io/File;Ljava/lang/String;)V (Ljava/io/File;Lsystem/String;)V</signature>
        public File(global::java.io.File par0, string par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.File.j4n_Class, java.io.File.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.File"), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#1 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public File(string par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.File.j4n_Class, java.io.File.j4n_Members[1], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#2 (Ljava/lang/String;Ljava/lang/String;)V (Lsystem/String;Lsystem/String;)V</signature>
        public File(string par0, string par1)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.File.j4n_Class, java.io.File.j4n_Members[2], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1));
            }
        }
        
        /// <signature>#3 (Ljava/net/URI;)V (Ljava/net/URI;)V</signature>
        public File(global::java.net.URI par0)
            : base((global::net.sf.jni4net.jni.JNIEnv)null, global::net.sf.jni4net.jni.JNIHandle.Zero, new global::net.sf.jni4net.core.JvmInstanceInfo(j4n_TypeInfo.JVMApi, j4n_TypeInfo))
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_handle = j4n_env.NewObjectG(java.io.File.j4n_Class, java.io.File.j4n_Members[3], global::net.sf.jni4net.core.ConvertSealed.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#4 (Ljava/lang/String;Ljava/lang/String;)Ljava/io/File; (Lsystem/String;Lsystem/String;)Ljava/io/File;</signature>
        static public global::java.io.File createTempFile(string par0, string par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.File>(j4n_env, j4n_env.CallStaticObjectMethod(java.io.File.j4n_Class, java.io.File.j4n_Members[4], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1)));
            }
        }
        
        /// <signature>#5 (Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File; (Lsystem/String;Lsystem/String;Ljava/io/File;)Ljava/io/File;</signature>
        static public global::java.io.File createTempFile(string par0, string par1, global::java.io.File par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.File>(j4n_env, j4n_env.CallStaticObjectMethod(java.io.File.j4n_Class, java.io.File.j4n_Members[5], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par1), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par2, "java.io.File")));
            }
        }
        
        /// <signature>#6 ()[Ljava/io/File; ()[Ljava/io/File;</signature>
        static public global::java.io.File[] listRoots()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.io.File>(j4n_env, j4n_env.CallStaticObjectMethod(java.io.File.j4n_Class, java.io.File.j4n_Members[6]));
            }
        }
        
        static public string pathSeparator {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticStringField(java.io.File.j4n_Class, java.io.File.j4n_Members[7]);
                }
            }
        }
        
        static public char pathSeparatorChar {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.io.File.j4n_Class, java.io.File.j4n_Members[8]);
                }
            }
        }
        
        static public string separator {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticStringField(java.io.File.j4n_Class, java.io.File.j4n_Members[9]);
                }
            }
        }
        
        static public char separatorChar {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.GetStaticCharField(java.io.File.j4n_Class, java.io.File.j4n_Members[10]);
                }
            }
        }
        
        /// <signature>#11 ()Z ()Z</signature>
        public virtual bool canRead()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[11]);
            }
        }
        
        /// <signature>#12 ()Z ()Z</signature>
        public virtual bool canWrite()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[12]);
            }
        }
        
        /// <signature>#13 (Ljava/io/File;)I (Ljava/io/File;)I</signature>
        public virtual int compareTo(global::java.io.File par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.io.File.j4n_Members[13], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.File"));
            }
        }
        
        /// <signature>#14 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public virtual int compareTo(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.io.File.j4n_Members[14], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#15 ()Z ()Z</signature>
        public virtual bool createNewFile()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[15]);
            }
        }
        
        /// <signature>#16 ()Z ()Z</signature>
        public virtual bool delete()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[16]);
            }
        }
        
        /// <signature>#17 ()V ()V</signature>
        public virtual void deleteOnExit()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.File.j4n_Members[17]);
            }
        }
        
        /// <signature>#18 ()Z ()Z</signature>
        public virtual bool exists()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[18]);
            }
        }
        
        /// <signature>#19 ()Ljava/io/File; ()Ljava/io/File;</signature>
        public virtual global::java.io.File getAbsoluteFile()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.File>(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[19]));
            }
        }
        
        /// <signature>#20 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getAbsolutePath()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.File.j4n_Members[20]);
            }
        }
        
        /// <signature>#21 ()Ljava/io/File; ()Ljava/io/File;</signature>
        public virtual global::java.io.File getCanonicalFile()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.File>(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[21]));
            }
        }
        
        /// <signature>#22 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getCanonicalPath()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.File.j4n_Members[22]);
            }
        }
        
        /// <signature>#23 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getName()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.File.j4n_Members[23]);
            }
        }
        
        /// <signature>#24 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getParent()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.File.j4n_Members[24]);
            }
        }
        
        /// <signature>#25 ()Ljava/io/File; ()Ljava/io/File;</signature>
        public virtual global::java.io.File getParentFile()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.io.File>(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[25]));
            }
        }
        
        /// <signature>#26 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public virtual string getPath()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.File.j4n_Members[26]);
            }
        }
        
        /// <signature>#27 ()Z ()Z</signature>
        public virtual bool isAbsolute()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[27]);
            }
        }
        
        /// <signature>#28 ()Z ()Z</signature>
        public virtual bool isDirectory()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[28]);
            }
        }
        
        /// <signature>#29 ()Z ()Z</signature>
        public virtual bool isFile()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[29]);
            }
        }
        
        /// <signature>#30 ()Z ()Z</signature>
        public virtual bool isHidden()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[30]);
            }
        }
        
        /// <signature>#31 ()J ()J</signature>
        public virtual long lastModified()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallLongMethod(this, java.io.File.j4n_Members[31]);
            }
        }
        
        /// <signature>#32 ()J ()J</signature>
        public virtual long length()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallLongMethod(this, java.io.File.j4n_Members[32]);
            }
        }
        
        /// <signature>#33 ()[Ljava/lang/String; ()[Lsystem/String;</signature>
        public virtual string[] list()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertString.ToCLRArray1(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[33]));
            }
        }
        
        /// <signature>#34 (Ljava/io/FilenameFilter;)[Ljava/lang/String; (Ljava/lang/Object;)[Lsystem/String;</signature>
        public virtual string[] list(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertString.ToCLRArray1(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[34], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.FilenameFilter")));
            }
        }
        
        /// <signature>#35 ()[Ljava/io/File; ()[Ljava/io/File;</signature>
        public virtual global::java.io.File[] listFiles()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.io.File>(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[35]));
            }
        }
        
        /// <signature>#36 (Ljava/io/FileFilter;)[Ljava/io/File; (Ljava/lang/Object;)[Ljava/io/File;</signature>
        public virtual global::java.io.File[] listFiles(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.io.File>(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[36], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.FileFilter")));
            }
        }
        
        /// <signature>#37 (Ljava/io/FilenameFilter;)[Ljava/io/File; (Ljava/lang/Object;)[Ljava/io/File;</signature>
        public virtual global::java.io.File[] listFiles_2(global::java.lang.Object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<global::java.io.File>(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[37], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.FilenameFilter")));
            }
        }
        
        /// <signature>#38 ()Z ()Z</signature>
        public virtual bool mkdir()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[38]);
            }
        }
        
        /// <signature>#39 ()Z ()Z</signature>
        public virtual bool mkdirs()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[39]);
            }
        }
        
        /// <signature>#40 (Ljava/io/File;)Z (Ljava/io/File;)Z</signature>
        public virtual bool renameTo(global::java.io.File par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[40], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.io.File"));
            }
        }
        
        /// <signature>#41 (J)Z (J)Z</signature>
        public virtual bool setLastModified(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[41], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#42 ()Z ()Z</signature>
        public virtual bool setReadOnly()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.File.j4n_Members[42]);
            }
        }
        
        /// <signature>#43 ()Ljava/net/URI; ()Ljava/net/URI;</signature>
        public virtual global::java.net.URI toURI()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URI>(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[43]));
            }
        }
        
        /// <signature>#44 ()Ljava/net/URL; ()Ljava/net/URL;</signature>
        public virtual global::java.net.URL toURL()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertSealed.ToCLR<global::java.net.URL>(j4n_env, j4n_env.CallObjectMethod(this, java.io.File.j4n_Members[44]));
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.io.File))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "java.io.File";
                    proxyInfo.JVMStaticApiName = "java_.io.File_";
                    proxyInfo.CLRApi = typeof(java.io.File);
                    proxyInfo.CLRStaticApi = typeof(java.io.File);
                    proxyInfo.CLRProxy = typeof(java.io.File);
                    proxyInfo.JVMProxyFactory = java.io.File.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/io/File;Ljava/lang/String;)V", false, false), // #0 (Ljava/io/File;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;)V", false, false), // #1 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/lang/String;Ljava/lang/String;)V", false, false), // #2 (Lsystem/String;Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(Ljava/net/URI;)V", false, false), // #3 (Ljava/net/URI;)V
                        new global::net.sf.jni4net.core.MemberId("createTempFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;", false, true), // #4 (Lsystem/String;Lsystem/String;)Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("createTempFile","(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", false, true), // #5 (Lsystem/String;Lsystem/String;Ljava/io/File;)Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("listRoots","()[Ljava/io/File;", false, true), // #6 ()[Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("pathSeparator","Ljava/lang/String;", true, true), // #7 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("pathSeparatorChar","C", true, true), // #8 ()C
                        new global::net.sf.jni4net.core.MemberId("separator","Ljava/lang/String;", true, true), // #9 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("separatorChar","C", true, true), // #10 ()C
                        new global::net.sf.jni4net.core.MemberId("canRead","()Z", false, false), // #11 ()Z
                        new global::net.sf.jni4net.core.MemberId("canWrite","()Z", false, false), // #12 ()Z
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/io/File;)I", false, false), // #13 (Ljava/io/File;)I
                        new global::net.sf.jni4net.core.MemberId("compareTo","(Ljava/lang/Object;)I", false, false), // #14 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("createNewFile","()Z", false, false), // #15 ()Z
                        new global::net.sf.jni4net.core.MemberId("delete","()Z", false, false), // #16 ()Z
                        new global::net.sf.jni4net.core.MemberId("deleteOnExit","()V", false, false), // #17 ()V
                        new global::net.sf.jni4net.core.MemberId("exists","()Z", false, false), // #18 ()Z
                        new global::net.sf.jni4net.core.MemberId("getAbsoluteFile","()Ljava/io/File;", false, false), // #19 ()Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("getAbsolutePath","()Ljava/lang/String;", false, false), // #20 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getCanonicalFile","()Ljava/io/File;", false, false), // #21 ()Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("getCanonicalPath","()Ljava/lang/String;", false, false), // #22 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getName","()Ljava/lang/String;", false, false), // #23 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getParent","()Ljava/lang/String;", false, false), // #24 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("getParentFile","()Ljava/io/File;", false, false), // #25 ()Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("getPath","()Ljava/lang/String;", false, false), // #26 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("isAbsolute","()Z", false, false), // #27 ()Z
                        new global::net.sf.jni4net.core.MemberId("isDirectory","()Z", false, false), // #28 ()Z
                        new global::net.sf.jni4net.core.MemberId("isFile","()Z", false, false), // #29 ()Z
                        new global::net.sf.jni4net.core.MemberId("isHidden","()Z", false, false), // #30 ()Z
                        new global::net.sf.jni4net.core.MemberId("lastModified","()J", false, false), // #31 ()J
                        new global::net.sf.jni4net.core.MemberId("length","()J", false, false), // #32 ()J
                        new global::net.sf.jni4net.core.MemberId("list","()[Ljava/lang/String;", false, false), // #33 ()[Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("list","(Ljava/io/FilenameFilter;)[Ljava/lang/String;", false, false), // #34 (Ljava/lang/Object;)[Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("listFiles","()[Ljava/io/File;", false, false), // #35 ()[Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("listFiles","(Ljava/io/FileFilter;)[Ljava/io/File;", false, false), // #36 (Ljava/lang/Object;)[Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("listFiles","(Ljava/io/FilenameFilter;)[Ljava/io/File;", false, false), // #37 (Ljava/lang/Object;)[Ljava/io/File;
                        new global::net.sf.jni4net.core.MemberId("mkdir","()Z", false, false), // #38 ()Z
                        new global::net.sf.jni4net.core.MemberId("mkdirs","()Z", false, false), // #39 ()Z
                        new global::net.sf.jni4net.core.MemberId("renameTo","(Ljava/io/File;)Z", false, false), // #40 (Ljava/io/File;)Z
                        new global::net.sf.jni4net.core.MemberId("setLastModified","(J)Z", false, false), // #41 (J)Z
                        new global::net.sf.jni4net.core.MemberId("setReadOnly","()Z", false, false), // #42 ()Z
                        new global::net.sf.jni4net.core.MemberId("toURI","()Ljava/net/URI;", false, false), // #43 ()Ljava/net/URI;
                        new global::net.sf.jni4net.core.MemberId("toURL","()Ljava/net/URL;", false, false), // #44 ()Ljava/net/URL;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
