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

namespace dummy.clr
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.clr.Tested_))]
    static public partial class Tested_
    {
        static Tested_()
        {
            global::net.sf.jni4net.modules.dummynj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::dummy.clr.ITested_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::dummy.clr.ITested_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.clr.Tested_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
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
                return global::net.sf.jni4net.core.ConvertAbstract.ToClrHandle(new global::dummy.clr.Tested());
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
        
        /// <signature>#1 intStaticField()I ()I</signature>
        static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::dummy.clr.Tested.intStaticField;
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
        
        /// <signature>#2 intStaticField(I)V (I)V</signature>
        static void j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::dummy.clr.Tested.intStaticField = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#3 intStaticFieldRo()I ()I</signature>
        static int j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                int j4n_result = global::dummy.clr.Tested.intStaticFieldRo;
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
        
        /// <signature>#4 add_PropertyChanged(Lsystem/MulticastDelegate;)V (LSystem/ComponentModel/PropertyChangedEventHandler;)V</signature>
        static void j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.PropertyChanged += global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ComponentModel.PropertyChangedEventHandler>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#5 get_Item(I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int a)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real[a], "java.lang.String");
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
        
        /// <signature>#6 get_testGet()I ()I</signature>
        static int j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.testGet;
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
        
        /// <signature>#7 get_testGetPrivateSet()I ()I</signature>
        static int j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.testGetPrivateSet;
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
        
        /// <signature>#8 get_testGetSet()I ()I</signature>
        static int j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.testGetSet;
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
        
        /// <signature>#9 intField()I ()I</signature>
        static int j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::dummy.clr.Tested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.Tested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.intField;
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
        
        /// <signature>#10 intField(I)V (I)V</signature>
        static void j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::dummy.clr.Tested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.Tested>(j4n_env, j4n_self);
                j4n_real.intField = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#11 intFieldRO()I ()I</signature>
        static int j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::dummy.clr.Tested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.Tested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.intFieldRO;
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
        
        /// <signature>#12 remove_PropertyChanged(Lsystem/MulticastDelegate;)V (LSystem/ComponentModel/PropertyChangedEventHandler;)V</signature>
        static void j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.PropertyChanged -= global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ComponentModel.PropertyChangedEventHandler>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#13 set_Item(ILjava/lang/String;)V (ILsystem/String;)V</signature>
        static void j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int a, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real[a] = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#14 set_Item(JLjava/lang/String;)V (JLsystem/String;)V</signature>
        static void j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long a, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real[a] = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#15 set_testGetSet(I)V (I)V</signature>
        static void j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testGetSet = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#16 set_testSet(I)V (I)V</signature>
        static void j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testSet = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#17 set_testSetPrivateGet(I)V (I)V</signature>
        static void j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testSetPrivateGet = value;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#18 test1(ILjava/lang/String;Lsystem/collections/IList;)I (ILsystem/String;LSystem/Collections/IList;)I</signature>
        static int j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value, global::System.IntPtr s, global::System.IntPtr l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.test1(value, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, l));
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
        
        /// <signature>#19 test2(ILjava/lang/String;Lsystem/collections/IList;)I (ILsystem/String;LSystem/Collections/IList;)I</signature>
        static int j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value, global::System.IntPtr s, global::System.IntPtr l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.test2(value, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, l));
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
        
        /// <signature>#20 test3([I[Ljava/lang/String;[Lsystem/collections/IList;)I ([I[Lsystem/String;[LSystem/Collections/IList;)I</signature>
        static int j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr s, global::System.IntPtr l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.test3(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<int[]>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string[]>(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList[]>(j4n_env, l));
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
        
        /// <signature>#21 testOut(Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)V</signature>
        static void j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                int[] j4n_out_value;
                object[] j4n_out_value2;
                string[] j4n_out_srt;
                global::System.Collections.IEnumerable[] j4n_out_enumerable;
                global::System.Collections.BitArray[] j4n_out_array;
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testOut(out j4n_out_value, out j4n_out_value2, out j4n_out_srt, out j4n_out_enumerable, out j4n_out_array);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, value, j4n_out_value, "system.Int32");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, value2, j4n_out_value2, "java.lang.Object");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, srt, j4n_out_srt, "java.lang.String");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, enumerable, j4n_out_enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, array, j4n_out_array, "system.collections.ICollection");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#22 testOutCallback(Ldummy/clr/ITested;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)V</signature>
        static void j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr callback, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                int[] j4n_out_value;
                object[] j4n_out_value2;
                string[] j4n_out_srt;
                global::System.Collections.IEnumerable[] j4n_out_enumerable;
                global::System.Collections.BitArray[] j4n_out_array;
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testOutCallback(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, callback), out j4n_out_value, out j4n_out_value2, out j4n_out_srt, out j4n_out_enumerable, out j4n_out_array);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, value, j4n_out_value, "system.Int32");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, value2, j4n_out_value2, "java.lang.Object");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, srt, j4n_out_srt, "java.lang.String");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, enumerable, j4n_out_enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, array, j4n_out_array, "system.collections.ICollection");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#23 testOutint(Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)I (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)I</signature>
        static int j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                int j4n_out_value;
                object j4n_out_value2;
                string j4n_out_srt;
                global::System.Collections.IEnumerable j4n_out_enumerable;
                global::System.Collections.BitArray j4n_out_array;
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.testOutint(out j4n_out_value, out j4n_out_value2, out j4n_out_srt, out j4n_out_enumerable, out j4n_out_array);
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, value, j4n_out_value, "system.Int32");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, value2, j4n_out_value2, "java.lang.Object");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, srt, j4n_out_srt, "java.lang.String");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, enumerable, j4n_out_enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.core.ConvertAbstract.ToOutObject(j4n_env, array, j4n_out_array, "system.collections.ICollection");
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
        
        /// <signature>#24 testRef(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        static void j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                int[] j4n_ref_value = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<int>(j4n_env, value);
                object[] j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<object>(j4n_env, value2);
                string[] j4n_ref_srt = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<string>(j4n_env, srt);
                global::System.Collections.IEnumerable[] j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<global::System.Collections.IEnumerable>(j4n_env, enumerable);
                global::System.Collections.BitArray[] j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<global::System.Collections.BitArray>(j4n_env, array);
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testRef(ref j4n_ref_value, ref j4n_ref_value2, ref j4n_ref_srt, ref j4n_ref_enumerable, ref j4n_ref_array);
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value, j4n_ref_value, "system.Int32");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value2, j4n_ref_value2, "java.lang.Object");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, srt, j4n_ref_srt, "java.lang.String");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, enumerable, j4n_ref_enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, array, j4n_ref_array, "system.collections.ICollection");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#25 testRef11(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        static void j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                int[][] j4n_ref_value = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<int>(j4n_env, value);
                object[][] j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<object>(j4n_env, value2);
                string[][] j4n_ref_srt = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<string>(j4n_env, srt);
                global::System.Collections.IEnumerable[][] j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<global::System.Collections.IEnumerable>(j4n_env, enumerable);
                global::System.Collections.BitArray[][] j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<global::System.Collections.BitArray>(j4n_env, array);
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testRef11(ref j4n_ref_value, ref j4n_ref_value2, ref j4n_ref_srt, ref j4n_ref_enumerable, ref j4n_ref_array);
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value, j4n_ref_value, "system.Int32");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value2, j4n_ref_value2, "java.lang.Object");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, srt, j4n_ref_srt, "java.lang.String");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, enumerable, j4n_ref_enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, array, j4n_ref_array, "system.collections.ICollection");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#26 testRefCallback(Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        static void j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr callback, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                int[] j4n_ref_value = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<int>(j4n_env, value);
                object[] j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<object>(j4n_env, value2);
                string[] j4n_ref_srt = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<string>(j4n_env, srt);
                global::System.Collections.IEnumerable[] j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<global::System.Collections.IEnumerable>(j4n_env, enumerable);
                global::System.Collections.BitArray[] j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray1<global::System.Collections.BitArray>(j4n_env, array);
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testRefCallback(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, callback), ref j4n_ref_value, ref j4n_ref_value2, ref j4n_ref_srt, ref j4n_ref_enumerable, ref j4n_ref_array);
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value, j4n_ref_value, "system.Int32");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value2, j4n_ref_value2, "java.lang.Object");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, srt, j4n_ref_srt, "java.lang.String");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, enumerable, j4n_ref_enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, array, j4n_ref_array, "system.collections.ICollection");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#27 testRefCallback11(Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        static void j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr callback, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22);
            try
            {
                int[][] j4n_ref_value = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<int>(j4n_env, value);
                object[][] j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<object>(j4n_env, value2);
                string[][] j4n_ref_srt = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<string>(j4n_env, srt);
                global::System.Collections.IEnumerable[][] j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<global::System.Collections.IEnumerable>(j4n_env, enumerable);
                global::System.Collections.BitArray[][] j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.FromRefObjectArray11<global::System.Collections.BitArray>(j4n_env, array);
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testRefCallback11(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, callback), ref j4n_ref_value, ref j4n_ref_value2, ref j4n_ref_srt, ref j4n_ref_enumerable, ref j4n_ref_array);
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value, j4n_ref_value, "system.Int32");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value2, j4n_ref_value2, "java.lang.Object");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, srt, j4n_ref_srt, "java.lang.String");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, enumerable, j4n_ref_enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, array, j4n_ref_array, "system.collections.ICollection");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#28 testRefint(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)I (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)I</signature>
        static int j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                int j4n_ref_value = global::net.sf.jni4net.core.ConvertAbstract.FromRefObject<int>(j4n_env, value);
                object j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.FromRefObject<object>(j4n_env, value2);
                string j4n_ref_srt = global::net.sf.jni4net.core.ConvertAbstract.FromRefObject<string>(j4n_env, srt);
                global::System.Collections.IEnumerable j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.FromRefObject<global::System.Collections.IEnumerable>(j4n_env, enumerable);
                global::System.Collections.BitArray j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.FromRefObject<global::System.Collections.BitArray>(j4n_env, array);
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                int j4n_result = j4n_real.testRefint(ref j4n_ref_value, ref j4n_ref_value2, ref j4n_ref_srt, ref j4n_ref_enumerable, ref j4n_ref_array);
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value, j4n_ref_value, "system.Int32");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, value2, j4n_ref_value2, "java.lang.Object");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, srt, j4n_ref_srt, "java.lang.String");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, enumerable, j4n_ref_enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.core.ConvertAbstract.ToRefObject(j4n_env, array, j4n_ref_array, "system.collections.ICollection");
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
        
        /// <signature>#29 testSkip()V ()V</signature>
        static void j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::dummy.clr.ITested>(j4n_env, j4n_self);
                j4n_real.testSkip();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::dummy.clr.Tested))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "dummy.clr.Tested";
                    proxyInfo.JVMProxyName = "dummy.clr.Tested";
                    proxyInfo.JVMStaticApiName = "dummy.clr.Tested";
                    proxyInfo.CLRApi = typeof(dummy.clr.Tested);
                    proxyInfo.CLRStaticApi = typeof(dummy.clr.Tested_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("<init>","()V", false, false), // #0 ()V
                        new global::net.sf.jni4net.core.MemberId("intStaticField","()I", true, true), // #1 ()I
                        new global::net.sf.jni4net.core.MemberId("intStaticField","(I)V", true, true), // #2 (I)V
                        new global::net.sf.jni4net.core.MemberId("intStaticFieldRo","()I", true, true), // #3 ()I
                        new global::net.sf.jni4net.core.MemberId("addPropertyChanged","(Lsystem/MulticastDelegate;)V", false, false), // #4 (LSystem/MulticastDelegate;)V
                        new global::net.sf.jni4net.core.MemberId("getItem","(I)Ljava/lang/String;", false, false), // #5 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("gettestGet","()I", false, false), // #6 ()I
                        new global::net.sf.jni4net.core.MemberId("gettestGetPrivateSet","()I", false, false), // #7 ()I
                        new global::net.sf.jni4net.core.MemberId("gettestGetSet","()I", false, false), // #8 ()I
                        new global::net.sf.jni4net.core.MemberId("intField","()I", true, false), // #9 ()I
                        new global::net.sf.jni4net.core.MemberId("intField","(I)V", true, false), // #10 (I)V
                        new global::net.sf.jni4net.core.MemberId("intFieldRO","()I", true, false), // #11 ()I
                        new global::net.sf.jni4net.core.MemberId("removePropertyChanged","(Lsystem/MulticastDelegate;)V", false, false), // #12 (LSystem/MulticastDelegate;)V
                        new global::net.sf.jni4net.core.MemberId("setItem","(ILjava/lang/String;)V", false, false), // #13 (ILjava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("setItem","(JLjava/lang/String;)V", false, false), // #14 (JLjava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("settestGetSet","(I)V", false, false), // #15 (I)V
                        new global::net.sf.jni4net.core.MemberId("settestSet","(I)V", false, false), // #16 (I)V
                        new global::net.sf.jni4net.core.MemberId("settestSetPrivateGet","(I)V", false, false), // #17 (I)V
                        new global::net.sf.jni4net.core.MemberId("test1","(ILjava/lang/String;Lsystem/collections/IList;)I", false, false), // #18 (ILjava/lang/String;LSystem/Collections/IList;)I
                        new global::net.sf.jni4net.core.MemberId("test2","(ILjava/lang/String;Lsystem/collections/IList;)I", false, false), // #19 (ILjava/lang/String;LSystem/Collections/IList;)I
                        new global::net.sf.jni4net.core.MemberId("test3","([I[Ljava/lang/String;[Lsystem/collections/IList;)I", false, false), // #20 ([I[Ljava/lang/String;[LSystem/Collections/IList;)I
                        new global::net.sf.jni4net.core.MemberId("testOut","(Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V", false, false), // #21 (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testOutCallback","(Ldummy/clr/ITested;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V", false, false), // #22 (Ldummy/clr/ITested;Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testOutint","(Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)I", false, false), // #23 (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)I
                        new global::net.sf.jni4net.core.MemberId("testRef","(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V", false, false), // #24 (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testRef11","(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V", false, false), // #25 (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testRefCallback","(Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V", false, false), // #26 (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testRefCallback11","(Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V", false, false), // #27 (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testRefint","(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)I", false, false), // #28 (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)I
                        new global::net.sf.jni4net.core.MemberId("testSkip","()V", false, false), // #29 ()V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
