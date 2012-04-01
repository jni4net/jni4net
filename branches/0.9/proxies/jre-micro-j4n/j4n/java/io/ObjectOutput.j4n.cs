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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectOutput_))]
    public partial interface ObjectOutput : global::java.io.DataOutput
    {
        /// <signature>#0 ()V ()V</signature>
        void close();
        
        /// <signature>#1 ()V ()V</signature>
        void flush();
        
        /// <signature>#2 (Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        void writeObject(object par0);
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectOutput_))]
    static public partial class ObjectOutput_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static ObjectOutput_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ObjectOutput_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.io.ObjectOutput_));
        }
        
        /// <signature>#0 close()V ()V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.ObjectOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.ObjectOutput>(j4n_env, j4n_self);
                j4n_real.close();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 flush()V ()V</signature>
        static void j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.io.ObjectOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.ObjectOutput>(j4n_env, j4n_self);
                j4n_real.flush();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#2 write([B)V ([B)V</signature>
        static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, par0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 write([BII)V ([BII)V</signature>
        static void j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.write(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, par0), par1, par2);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#4 write(I)V (I)V</signature>
        static void j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.write(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#5 writeBoolean(Z)V (Z)V</signature>
        static void j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeBoolean(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#6 writeByte(I)V (I)V</signature>
        static void j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeByte(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#7 writeBytes(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeBytes(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, par0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#8 writeChar(I)V (I)V</signature>
        static void j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeChar(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#9 writeChars(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeChars(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, par0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#10 writeDouble(D)V (D)V</signature>
        static void j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeDouble(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#11 writeFloat(F)V (F)V</signature>
        static void j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeFloat(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#12 writeInt(I)V (I)V</signature>
        static void j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeInt(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#13 writeLong(J)V (J)V</signature>
        static void j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeLong(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#14 writeObject(Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        static void j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.ObjectOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.ObjectOutput>(j4n_env, j4n_self);
                j4n_real.writeObject(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#15 writeShort(I)V (I)V</signature>
        static void j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeShort(par0);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#16 writeUTF(Ljava/lang/String;)V (Lsystem/String;)V</signature>
        static void j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.io.DataOutput j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.io.DataOutput>(j4n_env, j4n_self);
                j4n_real.writeUTF(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, par0));
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
            lock (typeof(global::java.io.ObjectOutput))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.io.ObjectOutput";
                    proxyInfo.JVMProxyName = "java_.io._ObjectOutput";
                    proxyInfo.JVMStaticApiName = "java_.io.ObjectOutput_";
                    proxyInfo.CLRApi = typeof(java.io.ObjectOutput);
                    proxyInfo.CLRStaticApi = typeof(java.io.ObjectOutput_);
                    proxyInfo.CLRProxy = typeof(java.io._ObjectOutput);
                    proxyInfo.JVMProxyFactory = java.io._ObjectOutput.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("close","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("flush","()V", false, false), // #1 ()V
                        new global::net.sf.jni4net.core.MemberId("write","([B)V", false, false), // #2 ([B)V
                        new global::net.sf.jni4net.core.MemberId("write","([BII)V", false, false), // #3 ([BII)V
                        new global::net.sf.jni4net.core.MemberId("write","(I)V", false, false), // #4 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeBoolean","(Z)V", false, false), // #5 (Z)V
                        new global::net.sf.jni4net.core.MemberId("writeByte","(I)V", false, false), // #6 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeBytes","(Ljava/lang/String;)V", false, false), // #7 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("writeChar","(I)V", false, false), // #8 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeChars","(Ljava/lang/String;)V", false, false), // #9 (Lsystem/String;)V
                        new global::net.sf.jni4net.core.MemberId("writeDouble","(D)V", false, false), // #10 (D)V
                        new global::net.sf.jni4net.core.MemberId("writeFloat","(F)V", false, false), // #11 (F)V
                        new global::net.sf.jni4net.core.MemberId("writeInt","(I)V", false, false), // #12 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeLong","(J)V", false, false), // #13 (J)V
                        new global::net.sf.jni4net.core.MemberId("writeObject","(Ljava/lang/Object;)V", false, false), // #14 (Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("writeShort","(I)V", false, false), // #15 (I)V
                        new global::net.sf.jni4net.core.MemberId("writeUTF","(Ljava/lang/String;)V", false, false), // #16 (Lsystem/String;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.io.ObjectOutput_))]
    internal partial class _ObjectOutput : global::java.lang.Object, java.io.ObjectOutput
    {
        static _ObjectOutput()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.io.ObjectOutput_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.io.ObjectOutput_));
        }
        
        protected _ObjectOutput(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.io._ObjectOutput(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()V ()V</signature>
        public void close()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 ()V ()V</signature>
        public void flush()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 ([B)V ([B)V</signature>
        public void write(byte[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[2], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#3 ([BII)V ([BII)V</signature>
        public void write(byte[] par0, int par1, int par2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[3], global::net.sf.jni4net.core.ConvertByte.ToValue(j4n_env, par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1), global::net.sf.jni4net.core.ConvertInt.ToValue(par2));
            }
        }
        
        /// <signature>#4 (I)V (I)V</signature>
        public void write(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[4], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#5 (Z)V (Z)V</signature>
        public void writeBoolean(bool par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[5], global::net.sf.jni4net.core.ConvertBoolean.ToValue(par0));
            }
        }
        
        /// <signature>#6 (I)V (I)V</signature>
        public void writeByte(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[6], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#7 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public void writeBytes(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[7], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#8 (I)V (I)V</signature>
        public void writeChar(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[8], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#9 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public void writeChars(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[9], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
        
        /// <signature>#10 (D)V (D)V</signature>
        public void writeDouble(double par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[10], global::net.sf.jni4net.core.ConvertDouble.ToValue(par0));
            }
        }
        
        /// <signature>#11 (F)V (F)V</signature>
        public void writeFloat(float par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[11], global::net.sf.jni4net.core.ConvertFloat.ToValue(par0));
            }
        }
        
        /// <signature>#12 (I)V (I)V</signature>
        public void writeInt(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[12], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#13 (J)V (J)V</signature>
        public void writeLong(long par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[13], global::net.sf.jni4net.core.ConvertLong.ToValue(par0));
            }
        }
        
        /// <signature>#14 (Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        public void writeObject(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[14], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#15 (I)V (I)V</signature>
        public void writeShort(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[15], global::net.sf.jni4net.core.ConvertInt.ToValue(par0));
            }
        }
        
        /// <signature>#16 (Ljava/lang/String;)V (Lsystem/String;)V</signature>
        public void writeUTF(string par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.io.ObjectOutput_.j4n_Members[16], global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, par0));
            }
        }
    }
}

#endregion Component Designer generated code
