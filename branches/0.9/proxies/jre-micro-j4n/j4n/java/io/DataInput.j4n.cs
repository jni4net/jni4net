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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.DataInput_))]
    public partial interface DataInput
    {
        /// <signature>#0 ()Z ()Z</signature>
        bool readBoolean();
        
        /// <signature>#1 ()B ()B</signature>
        byte readByte();
        
        /// <signature>#2 ()C ()C</signature>
        char readChar();
        
        /// <signature>#3 ()D ()D</signature>
        double readDouble();
        
        /// <signature>#4 ()F ()F</signature>
        float readFloat();
        
        /// <signature>#5 ([B)V ([B)V</signature>
        void readFully(byte[] par0);
        
        /// <signature>#6 ([BII)V ([BII)V</signature>
        void readFully(byte[] par0, int par1, int par2);
        
        /// <signature>#7 ()I ()I</signature>
        int readInt();
        
        /// <signature>#8 ()Ljava/lang/String; ()Lsystem/String;</signature>
        string readLine();
        
        /// <signature>#9 ()J ()J</signature>
        long readLong();
        
        /// <signature>#10 ()S ()S</signature>
        short readShort();
        
        /// <signature>#11 ()I ()I</signature>
        int readUnsignedByte();
        
        /// <signature>#12 ()I ()I</signature>
        int readUnsignedShort();
        
        /// <signature>#13 ()Ljava/lang/String; ()Lsystem/String;</signature>
        string readUTF();
        
        /// <signature>#14 (I)I (I)I</signature>
        int skipBytes(int par0);
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.DataInput_))]
    static public partial class DataInput_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static DataInput_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.DataInput_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.io.DataInput_));
        }
        
        /// <signature>#0 readBoolean()Z ()Z</signature>
        static bool j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.readBoolean();
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
        
        /// <signature>#1 readByte()B ()B</signature>
        static byte j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                byte j4n_result = j4n_real.readByte();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(byte);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#2 readChar()C ()C</signature>
        static char j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                char j4n_result = j4n_real.readChar();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(char);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 readDouble()D ()D</signature>
        static double j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                double j4n_result = j4n_real.readDouble();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(double);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#4 readFloat()F ()F</signature>
        static float j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                float j4n_result = j4n_real.readFloat();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(float);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#5 readFully([B)V ([B)V</signature>
        static void j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                j4n_real.readFully(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, par0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#6 readFully([BII)V ([BII)V</signature>
        static void j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                j4n_real.readFully(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, par0), par1, par2);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#7 readInt()I ()I</signature>
        static int j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                int j4n_result = j4n_real.readInt();
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
        
        /// <signature>#8 readLine()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.readLine(), "java.lang.String");
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
        
        /// <signature>#9 readLong()J ()J</signature>
        static long j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                long j4n_result = j4n_real.readLong();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#10 readShort()S ()S</signature>
        static short j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                short j4n_result = j4n_real.readShort();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(short);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#11 readUnsignedByte()I ()I</signature>
        static int j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                int j4n_result = j4n_real.readUnsignedByte();
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
        
        /// <signature>#12 readUnsignedShort()I ()I</signature>
        static int j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                int j4n_result = j4n_real.readUnsignedShort();
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
        
        /// <signature>#13 readUTF()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.readUTF(), "java.lang.String");
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
        
        /// <signature>#14 skipBytes(I)I (I)I</signature>
        static int j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataInput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataInput>(j4n_env, j4n_self);
                int j4n_result = j4n_real.skipBytes(par0);
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
            lock (typeof(global::java.io.DataInput))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.io.DataInput";
                    proxyInfo.JVMProxyName = "java_.io._DataInput";
                    proxyInfo.JVMStaticApiName = "java_.io.DataInput_";
                    proxyInfo.CLRApi = typeof(java.io.DataInput);
                    proxyInfo.CLRStaticApi = typeof(java.io.DataInput_);
                    proxyInfo.CLRProxy = typeof(java.io._DataInput);
                    proxyInfo.JVMProxyFactory = java.io._DataInput.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("readBoolean","()Z", false, false), // #0 ()Z
                        new global::net.sf.jni4net.core.MemberId("readByte","()B", false, false), // #1 ()B
                        new global::net.sf.jni4net.core.MemberId("readChar","()C", false, false), // #2 ()C
                        new global::net.sf.jni4net.core.MemberId("readDouble","()D", false, false), // #3 ()D
                        new global::net.sf.jni4net.core.MemberId("readFloat","()F", false, false), // #4 ()F
                        new global::net.sf.jni4net.core.MemberId("readFully","([B)V", false, false), // #5 ([B)V
                        new global::net.sf.jni4net.core.MemberId("readFully","([BII)V", false, false), // #6 ([BII)V
                        new global::net.sf.jni4net.core.MemberId("readInt","()I", false, false), // #7 ()I
                        new global::net.sf.jni4net.core.MemberId("readLine","()Ljava/lang/String;", false, false), // #8 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("readLong","()J", false, false), // #9 ()J
                        new global::net.sf.jni4net.core.MemberId("readShort","()S", false, false), // #10 ()S
                        new global::net.sf.jni4net.core.MemberId("readUnsignedByte","()I", false, false), // #11 ()I
                        new global::net.sf.jni4net.core.MemberId("readUnsignedShort","()I", false, false), // #12 ()I
                        new global::net.sf.jni4net.core.MemberId("readUTF","()Ljava/lang/String;", false, false), // #13 ()Lsystem/String;
                        new global::net.sf.jni4net.core.MemberId("skipBytes","(I)I", false, false), // #14 (I)I
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.DataInput_))]
    internal partial class _DataInput : global::java.lang.Object, java.io.DataInput
    {
        static _DataInput()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.DataInput_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.io.DataInput_));
        }
        
        protected _DataInput(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io._DataInput(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()Z ()Z</signature>
        public bool readBoolean()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.io.DataInput_.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()B ()B</signature>
        public byte readByte()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallByteMethod(this, java.io.DataInput_.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 ()C ()C</signature>
        public char readChar()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallCharMethod(this, java.io.DataInput_.j4n_Members[2]);
            }
        }
        
        /// <signature>#3 ()D ()D</signature>
        public double readDouble()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallDoubleMethod(this, java.io.DataInput_.j4n_Members[3]);
            }
        }
        
        /// <signature>#4 ()F ()F</signature>
        public float readFloat()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallFloatMethod(this, java.io.DataInput_.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 ([B)V ([B)V</signature>
        public void readFully(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.DataInput_.j4n_Members[5], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#6 ([BII)V ([BII)V</signature>
        public void readFully(byte[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallVoidMethod(this, java.io.DataInput_.j4n_Members[6], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#7 ()I ()I</signature>
        public int readInt()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.DataInput_.j4n_Members[7]);
            }
        }
        
        /// <signature>#8 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string readLine()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.DataInput_.j4n_Members[8]);
            }
        }
        
        /// <signature>#9 ()J ()J</signature>
        public long readLong()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallLongMethod(this, java.io.DataInput_.j4n_Members[9]);
            }
        }
        
        /// <signature>#10 ()S ()S</signature>
        public short readShort()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallShortMethod(this, java.io.DataInput_.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 ()I ()I</signature>
        public int readUnsignedByte()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.DataInput_.j4n_Members[11]);
            }
        }
        
        /// <signature>#12 ()I ()I</signature>
        public int readUnsignedShort()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.io.DataInput_.j4n_Members[12]);
            }
        }
        
        /// <signature>#13 ()Ljava/lang/String; ()Lsystem/String;</signature>
        public string readUTF()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallStringMethod(this, java.io.DataInput_.j4n_Members[13]);
            }
        }
        
        /// <signature>#14 (I)I (I)I</signature>
        public int skipBytes(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.io.DataInput_.j4n_Members[14], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
    }
}

#endregion Component Designer generated code
