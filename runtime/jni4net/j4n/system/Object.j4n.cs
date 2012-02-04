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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Object_))]
    static public partial class Object_
    {
        static Object_()
        {
            global::net.sf.jni4net.modules.jni4net.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Object_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 .ctor()V ()V</signature>
        static long j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new object());
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
        
        /// <signature>#1 Equals(Ljava/lang/Object;Ljava/lang/Object;)Z (Lsystem/Object;Lsystem/Object;)Z</signature>
        static bool j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr objA, global::System.IntPtr objB)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = object.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, objA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, objB));
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
        
        /// <signature>#2 ReferenceEquals(Ljava/lang/Object;Ljava/lang/Object;)Z (Lsystem/Object;Lsystem/Object;)Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr objA, global::System.IntPtr objB)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                bool j4n_result = object.ReferenceEquals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, objA), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, objB));
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
        
        /// <signature>#3 Equals(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr obj)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                object j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Equals(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, obj));
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
        
        /// <signature>#4 GetHashCode()I ()I</signature>
        static int j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                object j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_self);
                int j4n_result = j4n_real.GetHashCode();
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
        
        /// <signature>#5 GetType()Lsystem/IType; ()LSystem/Type;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                object j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetType(), "system.IType");
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
        
        /// <signature>#6 ToString()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                object j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ToString(), "java.lang.String");
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
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(object))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Object";
                    proxyInfo.JVMProxyName = "system.Object";
                    proxyInfo.JVMStaticApiName = "system.Object";
                    proxyInfo.CLRApi = typeof(System.Object);
                    proxyInfo.CLRStaticApi = typeof(System.Object_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("Equals","(Ljava/lang/Object;Ljava/lang/Object;)Z", false, true), // #1 (Ljava/lang/Object;Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("ReferenceEquals","(Ljava/lang/Object;Ljava/lang/Object;)Z", false, true), // #2 (Ljava/lang/Object;Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("Equals","(Ljava/lang/Object;)Z", false, false), // #3 (Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("GetHashCode","()I", false, false), // #4 ()I
                        new global::net.sf.jni4net.core.MemberId("GetType","()Lsystem/IType;", false, false), // #5 ()Lsystem/IType;
                        new global::net.sf.jni4net.core.MemberId("ToString","()Ljava/lang/String;", false, false), // #6 ()Ljava/lang/String;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
