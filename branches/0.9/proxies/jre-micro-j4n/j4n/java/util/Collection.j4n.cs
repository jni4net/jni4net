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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Collection_))]
    public partial interface Collection : global::java.lang.Iterable
    {
        /// <signature>#0 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        bool add(object par0);
        
        /// <signature>#1 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        bool addAll(global::java.util.Collection par0);
        
        /// <signature>#2 ()V ()V</signature>
        void clear();
        
        /// <signature>#3 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        bool contains(object par0);
        
        /// <signature>#4 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        bool containsAll(global::java.util.Collection par0);
        
        /// <signature>#5 ()Z ()Z</signature>
        bool isEmpty();
        
        /// <signature>#6 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        bool remove(object par0);
        
        /// <signature>#7 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        bool removeAll(global::java.util.Collection par0);
        
        /// <signature>#8 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        bool retainAll(global::java.util.Collection par0);
        
        /// <signature>#9 ()I ()I</signature>
        int size();
        
        /// <signature>#10 ()[Ljava/lang/Object; ()[Lsystem/Object;</signature>
        object[] toArray();
        
        /// <signature>#11 ([Ljava/lang/Object;)[Ljava/lang/Object; ([Lsystem/Object;)[Lsystem/Object;</signature>
        object[] toArray(object[] par0);
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Collection_))]
    static public partial class Collection_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Collection_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Collection_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.util.Collection_));
        }
        
        /// <signature>#0 add(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.add(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
        
        /// <signature>#1 addAll(Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        static bool j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.addAll(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Collection>(j4n_env, par0));
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
        
        /// <signature>#2 clear()V ()V</signature>
        static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
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
        
        /// <signature>#3 contains(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.contains(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
        
        /// <signature>#4 containsAll(Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        static bool j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.containsAll(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Collection>(j4n_env, par0));
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
        
        /// <signature>#5 isEmpty()Z ()Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
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
        
        /// <signature>#6 iterator()Ljava/util/Iterator; ()Ljava/util/Iterator;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.Iterable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.Iterable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.iterator(), "java.util.Iterator");
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
        
        /// <signature>#7 remove(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.remove(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
        
        /// <signature>#8 removeAll(Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        static bool j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.removeAll(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Collection>(j4n_env, par0));
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
        
        /// <signature>#9 retainAll(Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        static bool j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.retainAll(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Collection>(j4n_env, par0));
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
        
        /// <signature>#10 size()I ()I</signature>
        static int j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
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
        
        /// <signature>#11 toArray()[Ljava/lang/Object; ()[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.toArray(), "java.lang.Object");
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
        
        /// <signature>#12 toArray([Ljava/lang/Object;)[Ljava/lang/Object; ([Lsystem/Object;)[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.Collection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.Collection>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.toArray(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, par0)), "java.lang.Object");
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
            lock (typeof(global::java.util.Collection))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.util.Collection";
                    proxyInfo.JVMProxyName = "java_.util._Collection";
                    proxyInfo.JVMStaticApiName = "java_.util.Collection_";
                    proxyInfo.CLRApi = typeof(java.util.Collection);
                    proxyInfo.CLRStaticApi = typeof(java.util.Collection_);
                    proxyInfo.CLRProxy = typeof(java.util._Collection);
                    proxyInfo.JVMProxyFactory = java.util._Collection.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("add","(Ljava/lang/Object;)Z", false, false), // #0 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("addAll","(Ljava/util/Collection;)Z", false, false), // #1 (Ljava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("clear","()V", false, false), // #2 ()V
                        new global::net.sf.jni4net.core.MemberId("contains","(Ljava/lang/Object;)Z", false, false), // #3 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("containsAll","(Ljava/util/Collection;)Z", false, false), // #4 (Ljava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("isEmpty","()Z", false, false), // #5 ()Z
                        new global::net.sf.jni4net.core.MemberId("iterator","()Ljava/util/Iterator;", false, false), // #6 ()Ljava/util/Iterator;
                        new global::net.sf.jni4net.core.MemberId("remove","(Ljava/lang/Object;)Z", false, false), // #7 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("removeAll","(Ljava/util/Collection;)Z", false, false), // #8 (Ljava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("retainAll","(Ljava/util/Collection;)Z", false, false), // #9 (Ljava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("size","()I", false, false), // #10 ()I
                        new global::net.sf.jni4net.core.MemberId("toArray","()[Ljava/lang/Object;", false, false), // #11 ()[Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("toArray","([Ljava/lang/Object;)[Ljava/lang/Object;", false, false), // #12 ([Lsystem/Object;)[Lsystem/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.Collection_))]
    internal partial class _Collection : global::java.lang.Object, java.util.Collection
    {
        static _Collection()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.Collection_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.util.Collection_));
        }
        
        protected _Collection(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util._Collection(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool add(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Collection_.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#1 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        public bool addAll(global::java.util.Collection par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Collection_.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Collection"));
            }
        }
        
        /// <signature>#2 ()V ()V</signature>
        public void clear()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.util.Collection_.j4n_Members[2]);
            }
        }
        
        /// <signature>#3 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool contains(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Collection_.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#4 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        public bool containsAll(global::java.util.Collection par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Collection_.j4n_Members[4], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Collection"));
            }
        }
        
        /// <signature>#5 ()Z ()Z</signature>
        public bool isEmpty()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Collection_.j4n_Members[5]);
            }
        }
        
        /// <signature>#6 ()Ljava/util/Iterator; ()Ljava/util/Iterator;</signature>
        public global::java.util.Iterator iterator()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Iterator>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Collection_.j4n_Members[6]));
            }
        }
        
        /// <signature>#7 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool remove(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Collection_.j4n_Members[7], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#8 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        public bool removeAll(global::java.util.Collection par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Collection_.j4n_Members[8], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Collection"));
            }
        }
        
        /// <signature>#9 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        public bool retainAll(global::java.util.Collection par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.Collection_.j4n_Members[9], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Collection"));
            }
        }
        
        /// <signature>#10 ()I ()I</signature>
        public int size()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.util.Collection_.j4n_Members[10]);
            }
        }
        
        /// <signature>#11 ()[Ljava/lang/Object; ()[Lsystem/Object;</signature>
        public object[] toArray()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Collection_.j4n_Members[11]));
            }
        }
        
        /// <signature>#12 ([Ljava/lang/Object;)[Ljava/lang/Object; ([Lsystem/Object;)[Lsystem/Object;</signature>
        public object[] toArray(object[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.Collection_.j4n_Members[12], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
    }
}

#endregion Component Designer generated code
