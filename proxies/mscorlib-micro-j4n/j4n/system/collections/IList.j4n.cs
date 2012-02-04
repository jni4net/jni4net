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

namespace System.Collections
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Collections.IList_))]
    static public partial class IList_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static IList_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Collections.IList_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Collections.IList_));
        }
        
        /// <signature>#0 Add(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Add(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#1 Clear()V ()V</signature>
        static void j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                j4n_real.Clear();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#2 Contains(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.Contains(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#3 CopyTo(Lsystem/Array;I)V (LSystem/Array;I)V</signature>
        static void j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr array, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Collections.ICollection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.ICollection>(j4n_env, j4n_self);
                j4n_real.CopyTo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), index);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#4 get_Count()I ()I</signature>
        static int j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Collections.ICollection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.ICollection>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Count;
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
        
        /// <signature>#5 get_IsFixedSize()Z ()Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsFixedSize;
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
        
        /// <signature>#6 get_IsReadOnly()Z ()Z</signature>
        static bool j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsReadOnly;
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
        
        /// <signature>#7 get_IsSynchronized()Z ()Z</signature>
        static bool j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Collections.ICollection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.ICollection>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsSynchronized;
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
        
        /// <signature>#8 get_Item(I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real[index], "java.lang.Object");
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
        
        /// <signature>#9 get_SyncRoot()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Collections.ICollection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.ICollection>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.SyncRoot, "java.lang.Object");
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
        
        /// <signature>#10 GetEnumerator()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                System.Collections.IEnumerable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IEnumerable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetEnumerator(), "system.collections.IEnumerator");
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
        
        /// <signature>#11 IndexOf(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                int j4n_result = j4n_real.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#12 Insert(ILjava/lang/Object;)V (ILsystem/Object;)V</signature>
        static void j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                j4n_real.Insert(index, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#13 Remove(Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        static void j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                j4n_real.Remove(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#14 RemoveAt(I)V (I)V</signature>
        static void j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                j4n_real.RemoveAt(index);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#15 set_Item(ILjava/lang/Object;)V (ILsystem/Object;)V</signature>
        static void j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<System.Collections.IList>(j4n_env, j4n_self);
                j4n_real[index] = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value);
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
            lock (typeof(global::System.Collections.IList))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "system.collections.IList";
                    proxyInfo.JVMProxyName = "system.collections._IList";
                    proxyInfo.JVMStaticApiName = "system.collections.IList_";
                    proxyInfo.CLRApi = typeof(System.Collections.IList);
                    proxyInfo.CLRStaticApi = typeof(System.Collections.IList_);
                    proxyInfo.CLRProxy = typeof(System.Collections._IList);
                    proxyInfo.JVMProxyFactory = System.Collections._IList.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("Add","(Ljava/lang/Object;)I", false, false), // #0 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Clear","()V", false, false), // #1 ()V
                        new global::net.sf.jni4net.core.MemberId("Contains","(Ljava/lang/Object;)Z", false, false), // #2 (Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("CopyTo","(Lsystem/Array;I)V", false, false), // #3 (LSystem/Array;I)V
                        new global::net.sf.jni4net.core.MemberId("getCount","()I", false, false), // #4 ()I
                        new global::net.sf.jni4net.core.MemberId("GetEnumerator","()Lsystem/collections/IEnumerator;", false, false), // #5 ()LSystem/Collections/IEnumerator;
                        new global::net.sf.jni4net.core.MemberId("getIsFixedSize","()Z", false, false), // #6 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsReadOnly","()Z", false, false), // #7 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsSynchronized","()Z", false, false), // #8 ()Z
                        new global::net.sf.jni4net.core.MemberId("getItem","(I)Ljava/lang/Object;", false, false), // #9 (I)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getSyncRoot","()Ljava/lang/Object;", false, false), // #10 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Ljava/lang/Object;)I", false, false), // #11 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Insert","(ILjava/lang/Object;)V", false, false), // #12 (ILjava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Remove","(Ljava/lang/Object;)V", false, false), // #13 (Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("RemoveAt","(I)V", false, false), // #14 (I)V
                        new global::net.sf.jni4net.core.MemberId("setItem","(ILjava/lang/Object;)V", false, false), // #15 (ILjava/lang/Object;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Collections.IList_))]
    internal partial class _IList : global::java.lang.Object, System.Collections.IList
    {
        static _IList()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Collections.IList_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Collections.IList_));
        }
        
        protected _IList(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new System.Collections._IList(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int Add(object value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, System.Collections.IList_.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, value, "java.lang.Object"));
            }
        }
        
        /// <signature>#1 ()V ()V</signature>
        public void Clear()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, System.Collections.IList_.j4n_Members[1]);
            }
        }
        
        /// <signature>#2 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool Contains(object value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, System.Collections.IList_.j4n_Members[2], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, value, "java.lang.Object"));
            }
        }
        
        /// <signature>#3 (Lsystem/Array;I)V (LSystem/Array;I)V</signature>
        public void CopyTo(global::System.Array array, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, System.Collections.IList_.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, array, "system.Array"), global::net.sf.jni4net.core.ConvertInt.ToValue(index));
            }
        }
        
        public int Count {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallIntMethod(this, System.Collections.IList_.j4n_Members[4]);
                }
            }
        }
        
        public bool IsFixedSize {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallBooleanMethod(this, System.Collections.IList_.j4n_Members[5]);
                }
            }
        }
        
        public bool IsReadOnly {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallBooleanMethod(this, System.Collections.IList_.j4n_Members[6]);
                }
            }
        }
        
        public bool IsSynchronized {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallBooleanMethod(this, System.Collections.IList_.j4n_Members[7]);
                }
            }
        }
        
        public object this[int index] {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, System.Collections.IList_.j4n_Members[8], global::net.sf.jni4net.core.ConvertInt.ToValue(index)));
                }
            }
            set {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, System.Collections.IList_.j4n_Members[15], global::net.sf.jni4net.core.ConvertInt.ToValue(index), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, value, "java.lang.Object"));
                }
            }
        }
        
        public object SyncRoot {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, System.Collections.IList_.j4n_Members[9]));
                }
            }
        }
        
        /// <signature>#10 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
        public global::System.Collections.IEnumerator GetEnumerator()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IEnumerator>(j4n_env, j4n_env.CallObjectMethod(this, System.Collections.IList_.j4n_Members[10]));
            }
        }
        
        /// <signature>#11 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int IndexOf(object value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, System.Collections.IList_.j4n_Members[11], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, value, "java.lang.Object"));
            }
        }
        
        /// <signature>#12 (ILjava/lang/Object;)V (ILsystem/Object;)V</signature>
        public void Insert(int index, object value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, System.Collections.IList_.j4n_Members[12], global::net.sf.jni4net.core.ConvertInt.ToValue(index), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, value, "java.lang.Object"));
            }
        }
        
        /// <signature>#13 (Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        public void Remove(object value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, System.Collections.IList_.j4n_Members[13], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, value, "java.lang.Object"));
            }
        }
        
        /// <signature>#14 (I)V (I)V</signature>
        public void RemoveAt(int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                j4n_env.CallVoidMethod(this, System.Collections.IList_.j4n_Members[14], global::net.sf.jni4net.core.ConvertInt.ToValue(index));
            }
        }
    }
}

#endregion Component Designer generated code
