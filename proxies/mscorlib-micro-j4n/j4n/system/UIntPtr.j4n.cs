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

namespace System
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.UIntPtr_))]
    static public partial class UIntPtr_
    {
        static UIntPtr_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ValueType_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.UIntPtr_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor(I)V (i)V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, uint value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.UIntPtr(value));
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
        
        /// <signature>#1 .ctor(J)V (j)V</signature>
        static long j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, ulong value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::System.UIntPtr(value));
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
        
        /// <signature>#2 get_Size()I ()I</signature>
        static int j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::System.UIntPtr.Size;
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
        
        /// <signature>#3 Zero()Lsystem/UIntPtr; ()LSystem/UIntPtr;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.UIntPtr.Zero, "system.UIntPtr");
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
        
        /// <signature>#4 GetObjectData(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
        static void j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr info, global::System.IntPtr context)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.ISerializable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.ISerializable>(j4n_env, j4n_self);
                j4n_real.GetObjectData(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, info), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContext>(j4n_env, context));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#5 ToUInt32()I ()i</signature>
        static uint j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.UIntPtr j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.UIntPtr>(j4n_env, j4n_self);
                uint j4n_result = j4n_real.ToUInt32();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(uint);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#6 ToUInt64()J ()j</signature>
        static ulong j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.UIntPtr j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.UIntPtr>(j4n_env, j4n_self);
                ulong j4n_result = j4n_real.ToUInt64();
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(ulong);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.UIntPtr))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.UIntPtr";
                    proxyInfo.JVMProxyName = "system.UIntPtr";
                    proxyInfo.JVMStaticApiName = "system.UIntPtr";
                    proxyInfo.CLRApi = typeof(System.UIntPtr);
                    proxyInfo.CLRStaticApi = typeof(System.UIntPtr_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","(I)V", false, false), // #0 (I)V
                        new global::net.sf.jni4net.core.MemberId("<init>","(J)V", false, false), // #1 (J)V
                        new global::net.sf.jni4net.core.MemberId("getSize","()I", false, true), // #2 ()I
                        new global::net.sf.jni4net.core.MemberId("Zero","()Lsystem/UIntPtr;", true, true), // #3 ()LSystem/UIntPtr;
                        new global::net.sf.jni4net.core.MemberId("GetObjectData","(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V", false, false), // #4 (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V
                        new global::net.sf.jni4net.core.MemberId("ToUInt32","()I", false, false), // #5 ()I
                        new global::net.sf.jni4net.core.MemberId("ToUInt64","()J", false, false), // #6 ()J
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
