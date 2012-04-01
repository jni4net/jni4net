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

namespace java.util
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Map_))]
    public partial interface Map
    {
        /// <signature>#0 ()V ()V</signature>
        void clear();
        
        /// <signature>#1 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        bool containsKey(object par0);
        
        /// <signature>#2 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        bool containsValue(object par0);
        
        /// <signature>#3 ()Ljava/util/Set; ()Ljava/util/Set;</signature>
        global::java.util.Set entrySet();
        
        /// <signature>#4 (Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        object get(object par0);
        
        /// <signature>#5 ()Z ()Z</signature>
        bool isEmpty();
        
        /// <signature>#6 ()Ljava/util/Set; ()Ljava/util/Set;</signature>
        global::java.util.Set keySet();
        
        /// <signature>#7 (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;Lsystem/Object;)Lsystem/Object;</signature>
        object put(object par0, object par1);
        
        /// <signature>#8 (Ljava/util/Map;)V (Ljava/util/Map;)V</signature>
        void putAll(global::java.util.Map par0);
        
        /// <signature>#9 (Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        object remove(object par0);
        
        /// <signature>#10 ()I ()I</signature>
        int size();
        
        /// <signature>#11 ()Ljava/util/Collection; ()Ljava/util/Collection;</signature>
        global::java.util.Collection values();
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Map_))]
    static public partial class Map_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Map_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Map_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.util.Map_));
        }
        
        /// <signature>#0 clear()V ()V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                j4n_real.clear();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 containsKey(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.containsKey(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
        
        /// <signature>#2 containsValue(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.containsValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
        
        /// <signature>#3 entrySet()Ljava/util/Set; ()Ljava/util/Set;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.entrySet(), "java.util.Set");
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
        
        /// <signature>#4 get(Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.get(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0)), "java.lang.Object");
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
        
        /// <signature>#5 isEmpty()Z ()Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.isEmpty();
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
        
        /// <signature>#6 keySet()Ljava/util/Set; ()Ljava/util/Set;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.keySet(), "java.util.Set");
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
        
        /// <signature>#7 put(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0, global::System.IntPtr par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.put(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par1)), "java.lang.Object");
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
        
        /// <signature>#8 putAll(Ljava/util/Map;)V (Ljava/util/Map;)V</signature>
        static void j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                j4n_real.putAll(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Map>(j4n_env, par0));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#9 remove(Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.remove(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0)), "java.lang.Object");
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
        
        /// <signature>#10 size()I ()I</signature>
        static int j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                int j4n_result = j4n_real.size();
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
        
        /// <signature>#11 values()Ljava/util/Collection; ()Ljava/util/Collection;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Map j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Map>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.values(), "java.util.Collection");
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
            lock (typeof(global::java.util.Map))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.util.Map";
                    proxyInfo.JVMProxyName = "java_.util._Map";
                    proxyInfo.JVMStaticApiName = "java_.util.Map_";
                    proxyInfo.CLRApi = typeof(java.util.Map);
                    proxyInfo.CLRStaticApi = typeof(java.util.Map_);
                    proxyInfo.CLRProxy = typeof(java.util._Map);
                    proxyInfo.JVMProxyFactory = java.util._Map.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("clear","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("containsKey","(Ljava/lang/Object;)Z", false, false), // #1 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("containsValue","(Ljava/lang/Object;)Z", false, false), // #2 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("entrySet","()Ljava/util/Set;", false, false), // #3 ()Ljava/util/Set;
                        new global::net.sf.jni4net.core.MemberId("get","(Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #4 (Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("isEmpty","()Z", false, false), // #5 ()Z
                        new global::net.sf.jni4net.core.MemberId("keySet","()Ljava/util/Set;", false, false), // #6 ()Ljava/util/Set;
                        new global::net.sf.jni4net.core.MemberId("put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #7 (Lsystem/Object;Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("putAll","(Ljava/util/Map;)V", false, false), // #8 (Ljava/util/Map;)V
                        new global::net.sf.jni4net.core.MemberId("remove","(Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #9 (Lsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("size","()I", false, false), // #10 ()I
                        new global::net.sf.jni4net.core.MemberId("values","()Ljava/util/Collection;", false, false), // #11 ()Ljava/util/Collection;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Map_))]
    internal partial class _Map : global::java.lang.Object, java.util.Map
    {
        static _Map()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Map_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.util.Map_));
        }
        
        protected _Map(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util._Map(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()V ()V</signature>
        public void clear()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.util.Map_.j4n_Members[0]);
            }
        }
        
        /// <signature>#1 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool containsKey(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Map_.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#2 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool containsValue(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Map_.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#3 ()Ljava/util/Set; ()Ljava/util/Set;</signature>
        public global::java.util.Set entrySet()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Set>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Map_.j4n_Members[3]));
            }
        }
        
        /// <signature>#4 (Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        public object get(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Map_.j4n_Members[4], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#5 ()Z ()Z</signature>
        public bool isEmpty()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Map_.j4n_Members[5]);
            }
        }
        
        /// <signature>#6 ()Ljava/util/Set; ()Ljava/util/Set;</signature>
        public global::java.util.Set keySet()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Set>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Map_.j4n_Members[6]));
            }
        }
        
        /// <signature>#7 (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;Lsystem/Object;)Lsystem/Object;</signature>
        public object put(object par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Map_.j4n_Members[7], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
            }
        }
        
        /// <signature>#8 (Ljava/util/Map;)V (Ljava/util/Map;)V</signature>
        public void putAll(global::java.util.Map par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, java.util.Map_.j4n_Members[8], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Map"));
            }
        }
        
        /// <signature>#9 (Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/Object;)Lsystem/Object;</signature>
        public object remove(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Map_.j4n_Members[9], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
        
        /// <signature>#10 ()I ()I</signature>
        public int size()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.util.Map_.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 ()Ljava/util/Collection; ()Ljava/util/Collection;</signature>
        public global::java.util.Collection values()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Collection>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Map_.j4n_Members[11]));
            }
        }
    }
}

#endregion Component Designer generated code
