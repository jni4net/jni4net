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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.List_))]
    public partial interface List : global::java.util.Collection
    {
        /// <signature>#0 (ILjava/lang/Object;)V (ILsystem/Object;)V</signature>
        void add(int par0, object par1);
        
        /// <signature>#1 (ILjava/util/Collection;)Z (ILjava/util/Collection;)Z</signature>
        bool addAll(int par0, global::java.util.Collection par1);
        
        /// <signature>#2 (I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        object get(int par0);
        
        /// <signature>#3 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        int indexOf(object par0);
        
        /// <signature>#4 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        int lastIndexOf(object par0);
        
        /// <signature>#5 ()Ljava/util/ListIterator; ()Ljava/util/Iterator;</signature>
        global::java.util.Iterator listIterator();
        
        /// <signature>#6 (I)Ljava/util/ListIterator; (I)Ljava/util/Iterator;</signature>
        global::java.util.Iterator listIterator(int par0);
        
        /// <signature>#7 (I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        object remove(int par0);
        
        /// <signature>#8 (ILjava/lang/Object;)Ljava/lang/Object; (ILsystem/Object;)Lsystem/Object;</signature>
        object set(int par0, object par1);
        
        /// <signature>#9 (II)Ljava/util/List; (II)Ljava/util/List;</signature>
        global::java.util.List subList(int par0, int par1);
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.List_))]
    static public partial class List_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static List_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.List_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.util.List_));
        }
        
        /// <signature>#0 add(ILjava/lang/Object;)V (ILsystem/Object;)V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0, global::System.IntPtr par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                j4n_real.add(par0, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par1));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#1 add(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
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
        
        /// <signature>#2 addAll(ILjava/util/Collection;)Z (ILjava/util/Collection;)Z</signature>
        static bool j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0, global::System.IntPtr par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.addAll(par0, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Collection>(j4n_env, par1));
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
        
        /// <signature>#3 addAll(Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        static bool j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
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
        
        /// <signature>#4 clear()V ()V</signature>
        static void j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#5 contains(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
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
        
        /// <signature>#6 containsAll(Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        static bool j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
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
        
        /// <signature>#7 get(I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.get(par0), "java.lang.Object");
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
        
        /// <signature>#8 indexOf(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                int j4n_result = j4n_real.indexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
        
        /// <signature>#9 isEmpty()Z ()Z</signature>
        static bool j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#10 iterator()Ljava/util/Iterator; ()Ljava/util/Iterator;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#11 lastIndexOf(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                int j4n_result = j4n_real.lastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par0));
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
        
        /// <signature>#12 listIterator()Ljava/util/ListIterator; ()Ljava/util/Iterator;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.listIterator(), "java.util.ListIterator");
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
        
        /// <signature>#13 listIterator(I)Ljava/util/ListIterator; (I)Ljava/util/Iterator;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.listIterator(par0), "java.util.ListIterator");
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
        
        /// <signature>#14 remove(I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.remove(par0), "java.lang.Object");
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
        
        /// <signature>#15 remove(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
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
        
        /// <signature>#16 removeAll(Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        static bool j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
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
        
        /// <signature>#17 retainAll(Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        static bool j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
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
        
        /// <signature>#18 set(ILjava/lang/Object;)Ljava/lang/Object; (ILsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0, global::System.IntPtr par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.set(par0, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, par1)), "java.lang.Object");
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
        
        /// <signature>#19 size()I ()I</signature>
        static int j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#20 subList(II)Ljava/util/List; (II)Ljava/util/List;</signature>
        static global::System.IntPtr j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                java.util.List j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.util.List>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.subList(par0, par1), "java.util.List");
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
        
        /// <signature>#21 toArray()[Ljava/lang/Object; ()[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
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
        
        /// <signature>#22 toArray([Ljava/lang/Object;)[Ljava/lang/Object; ([Lsystem/Object;)[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr par0)
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
            lock (typeof(global::java.util.List))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.util.List";
                    proxyInfo.JVMProxyName = "java_.util._List";
                    proxyInfo.JVMStaticApiName = "java_.util.List_";
                    proxyInfo.CLRApi = typeof(java.util.List);
                    proxyInfo.CLRStaticApi = typeof(java.util.List_);
                    proxyInfo.CLRProxy = typeof(java.util._List);
                    proxyInfo.JVMProxyFactory = java.util._List.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("add","(ILjava/lang/Object;)V", false, false), // #0 (ILsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("add","(Ljava/lang/Object;)Z", false, false), // #1 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("addAll","(ILjava/util/Collection;)Z", false, false), // #2 (ILjava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("addAll","(Ljava/util/Collection;)Z", false, false), // #3 (Ljava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("clear","()V", false, false), // #4 ()V
                        new global::net.sf.jni4net.core.MemberId("contains","(Ljava/lang/Object;)Z", false, false), // #5 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("containsAll","(Ljava/util/Collection;)Z", false, false), // #6 (Ljava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("get","(I)Ljava/lang/Object;", false, false), // #7 (I)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("indexOf","(Ljava/lang/Object;)I", false, false), // #8 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("isEmpty","()Z", false, false), // #9 ()Z
                        new global::net.sf.jni4net.core.MemberId("iterator","()Ljava/util/Iterator;", false, false), // #10 ()Ljava/util/Iterator;
                        new global::net.sf.jni4net.core.MemberId("lastIndexOf","(Ljava/lang/Object;)I", false, false), // #11 (Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("listIterator","()Ljava/util/ListIterator;", false, false), // #12 ()Ljava/util/Iterator;
                        new global::net.sf.jni4net.core.MemberId("listIterator","(I)Ljava/util/ListIterator;", false, false), // #13 (I)Ljava/util/Iterator;
                        new global::net.sf.jni4net.core.MemberId("remove","(I)Ljava/lang/Object;", false, false), // #14 (I)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("remove","(Ljava/lang/Object;)Z", false, false), // #15 (Lsystem/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("removeAll","(Ljava/util/Collection;)Z", false, false), // #16 (Ljava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("retainAll","(Ljava/util/Collection;)Z", false, false), // #17 (Ljava/util/Collection;)Z
                        new global::net.sf.jni4net.core.MemberId("set","(ILjava/lang/Object;)Ljava/lang/Object;", false, false), // #18 (ILsystem/Object;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("size","()I", false, false), // #19 ()I
                        new global::net.sf.jni4net.core.MemberId("subList","(II)Ljava/util/List;", false, false), // #20 (II)Ljava/util/List;
                        new global::net.sf.jni4net.core.MemberId("toArray","()[Ljava/lang/Object;", false, false), // #21 ()[Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("toArray","([Ljava/lang/Object;)[Ljava/lang/Object;", false, false), // #22 ([Lsystem/Object;)[Lsystem/Object;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.util.List_))]
    internal partial class _List : global::java.lang.Object, java.util.List
    {
        static _List()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.util.List_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.util.List_));
        }
        
        protected _List(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.util._List(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 (ILjava/lang/Object;)V (ILsystem/Object;)V</signature>
        public void add(int par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                j4n_env.CallVoidMethod(this, java.util.List_.j4n_Members[0], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object"));
            }
        }
        
        /// <signature>#1 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool add(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[1], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#2 (ILjava/util/Collection;)Z (ILjava/util/Collection;)Z</signature>
        public bool addAll(int par0, global::java.util.Collection par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[2], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.util.Collection"));
            }
        }
        
        /// <signature>#3 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        public bool addAll(global::java.util.Collection par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[3], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Collection"));
            }
        }
        
        /// <signature>#4 ()V ()V</signature>
        public void clear()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                j4n_env.CallVoidMethod(this, java.util.List_.j4n_Members[4]);
            }
        }
        
        /// <signature>#5 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool contains(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[5], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#6 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        public bool containsAll(global::java.util.Collection par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[6], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Collection"));
            }
        }
        
        /// <signature>#7 (I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        public object get(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[7], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#8 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int indexOf(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.util.List_.j4n_Members[8], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#9 ()Z ()Z</signature>
        public bool isEmpty()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[9]);
            }
        }
        
        /// <signature>#10 ()Ljava/util/Iterator; ()Ljava/util/Iterator;</signature>
        public global::java.util.Iterator iterator()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Iterator>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[10]));
            }
        }
        
        /// <signature>#11 (Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        public int lastIndexOf(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallIntMethod(this, java.util.List_.j4n_Members[11], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#12 ()Ljava/util/ListIterator; ()Ljava/util/Iterator;</signature>
        public global::java.util.Iterator listIterator()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Iterator>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[12]));
            }
        }
        
        /// <signature>#13 (I)Ljava/util/ListIterator; (I)Ljava/util/Iterator;</signature>
        public global::java.util.Iterator listIterator(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.Iterator>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[13], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#14 (I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        public object remove(int par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[14], global::net.sf.jni4net.core.ConvertInt.ToValue(par0)));
            }
        }
        
        /// <signature>#15 (Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        public bool remove(object par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[15], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object"));
            }
        }
        
        /// <signature>#16 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        public bool removeAll(global::java.util.Collection par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[16], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Collection"));
            }
        }
        
        /// <signature>#17 (Ljava/util/Collection;)Z (Ljava/util/Collection;)Z</signature>
        public bool retainAll(global::java.util.Collection par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return j4n_env.CallBooleanMethod(this, java.util.List_.j4n_Members[17], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.util.Collection"));
            }
        }
        
        /// <signature>#18 (ILjava/lang/Object;)Ljava/lang/Object; (ILsystem/Object;)Lsystem/Object;</signature>
        public object set(int par0, object par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[18], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par1, "java.lang.Object")));
            }
        }
        
        /// <signature>#19 ()I ()I</signature>
        public int size()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return j4n_env.CallIntMethod(this, java.util.List_.j4n_Members[19]);
            }
        }
        
        /// <signature>#20 (II)Ljava/util/List; (II)Ljava/util/List;</signature>
        public global::java.util.List subList(int par0, int par1)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::java.util.List>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[20], global::net.sf.jni4net.core.ConvertInt.ToValue(par0), global::net.sf.jni4net.core.ConvertInt.ToValue(par1)));
            }
        }
        
        /// <signature>#21 ()[Ljava/lang/Object; ()[Lsystem/Object;</signature>
        public object[] toArray()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[21]));
            }
        }
        
        /// <signature>#22 ([Ljava/lang/Object;)[Ljava/lang/Object; ([Lsystem/Object;)[Lsystem/Object;</signature>
        public object[] toArray(object[] par0)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
            {
                return global::net.sf.jni4net.core.ConvertAbstract.ToCLRArray1<object>(j4n_env, j4n_env.CallObjectMethod(this, java.util.List_.j4n_Members[22], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, par0, "java.lang.Object")));
            }
        }
    }
}

#endregion Component Designer generated code
