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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Collections.ICollection_))]
    static public partial class ICollection_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static ICollection_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Collections.ICollection_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Collections.ICollection_));
        }
        
        /// <signature>#0 CopyTo(Lsystem/Array;I)V (LSystem/Array;I)V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr array, int index)
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
        
        /// <signature>#1 get_Count()I ()I</signature>
        static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#2 get_IsSynchronized()Z ()Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#3 get_SyncRoot()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#4 GetEnumerator()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Collections.ICollection))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "system.collections.ICollection";
                    proxyInfo.JVMProxyName = "system.collections._ICollection";
                    proxyInfo.JVMStaticApiName = "system.collections.ICollection_";
                    proxyInfo.CLRApi = typeof(System.Collections.ICollection);
                    proxyInfo.CLRStaticApi = typeof(System.Collections.ICollection_);
                    proxyInfo.CLRProxy = typeof(System.Collections._ICollection);
                    proxyInfo.JVMProxyFactory = System.Collections._ICollection.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("CopyTo","(Lsystem/Array;I)V", false, false), // #0 (LSystem/Array;I)V
                        new global::net.sf.jni4net.core.MemberId("getCount","()I", false, false), // #1 ()I
                        new global::net.sf.jni4net.core.MemberId("GetEnumerator","()Lsystem/collections/IEnumerator;", false, false), // #2 ()LSystem/Collections/IEnumerator;
                        new global::net.sf.jni4net.core.MemberId("getIsSynchronized","()Z", false, false), // #3 ()Z
                        new global::net.sf.jni4net.core.MemberId("getSyncRoot","()Ljava/lang/Object;", false, false), // #4 ()Ljava/lang/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Collections.ICollection_))]
    internal partial class _ICollection : global::java.lang.Object, System.Collections.ICollection
    {
        static _ICollection()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(System.Collections.ICollection_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Collections.ICollection_));
        }
        
        protected _ICollection(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new System.Collections._ICollection(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (Lsystem/Array;I)V (LSystem/Array;I)V</signature>
        public void CopyTo(global::System.Array array, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, System.Collections.ICollection_.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, array, "system.Array"), global::net.sf.jni4net.core.ConvertInt.ToValue(index));
            }
        }
        
        public int Count {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallIntMethod(this, System.Collections.ICollection_.j4n_Members[1]);
                }
            }
        }
        
        public bool IsSynchronized {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallBooleanMethod(this, System.Collections.ICollection_.j4n_Members[2]);
                }
            }
        }
        
        public object SyncRoot {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, System.Collections.ICollection_.j4n_Members[3]));
                }
            }
        }
        
        /// <signature>#4 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
        public global::System.Collections.IEnumerator GetEnumerator()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IEnumerator>(j4n_env, j4n_env.CallObjectMethod(this, System.Collections.ICollection_.j4n_Members[4]));
            }
        }
    }
}

#endregion Component Designer generated code
