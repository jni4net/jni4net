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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.clr.ITested_))]
    static public partial class ITested_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static ITested_()
        {
            global::net.sf.jni4net.modules.dummynj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.clr.ITested_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.clr.ITested_));
        }
        
        /// <signature>#0 add_PropertyChanged(Lsystem/MulticastDelegate;)V (LSystem/ComponentModel/PropertyChangedEventHandler;)V</signature>
        static void j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#1 get_Item(I)Ljava/lang/String; (I)Lsystem/String;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int a)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#2 get_testGet()I ()I</signature>
        static int j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#3 get_testGetPrivateSet()I ()I</signature>
        static int j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#4 get_testGetSet()I ()I</signature>
        static int j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#5 remove_PropertyChanged(Lsystem/MulticastDelegate;)V (LSystem/ComponentModel/PropertyChangedEventHandler;)V</signature>
        static void j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#6 set_Item(ILjava/lang/String;)V (ILsystem/String;)V</signature>
        static void j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int a, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#7 set_Item(JLjava/lang/String;)V (JLsystem/String;)V</signature>
        static void j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long a, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#8 set_testGetSet(I)V (I)V</signature>
        static void j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#9 set_testSet(I)V (I)V</signature>
        static void j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#10 set_testSetPrivateGet(I)V (I)V</signature>
        static void j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#11 test1(ILjava/lang/String;Lsystem/collections/IList;)I (ILsystem/String;LSystem/Collections/IList;)I</signature>
        static int j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value, global::System.IntPtr s, global::System.IntPtr l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#12 test2(ILjava/lang/String;Lsystem/collections/IList;)I (ILsystem/String;LSystem/Collections/IList;)I</signature>
        static int j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int value, global::System.IntPtr s, global::System.IntPtr l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#13 test3([I[Ljava/lang/String;[Lsystem/collections/IList;)I ([I[Lsystem/String;[LSystem/Collections/IList;)I</signature>
        static int j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr s, global::System.IntPtr l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#14 testOut(Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)V</signature>
        static void j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
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
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#15 testOutCallback(Ldummy/clr/ITested;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)V</signature>
        static void j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr callback, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
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
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#16 testOutint(Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)I (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)I</signature>
        static int j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
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
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#17 testRef(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        static void j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
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
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#18 testRef11(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        static void j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
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
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#19 testRefCallback(Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        static void j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr callback, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
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
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#20 testRefCallback11(Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        static void j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr callback, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
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
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        /// <signature>#21 testRefint(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)I (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)I</signature>
        static int j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr value2, global::System.IntPtr srt, global::System.IntPtr enumerable, global::System.IntPtr array)
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
                dummy.clr.ITested j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<dummy.clr.ITested>(j4n_env, j4n_self);
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
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::dummy.clr.ITested))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "dummy.clr.ITested";
                    proxyInfo.JVMProxyName = "dummy.clr._ITested";
                    proxyInfo.JVMStaticApiName = "dummy.clr.ITested_";
                    proxyInfo.CLRApi = typeof(dummy.clr.ITested);
                    proxyInfo.CLRStaticApi = typeof(dummy.clr.ITested_);
                    proxyInfo.CLRProxy = typeof(dummy.clr._ITested);
                    proxyInfo.JVMProxyFactory = dummy.clr._ITested.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("addPropertyChanged","(Lsystem/MulticastDelegate;)V", false, false), // #0 (LSystem/MulticastDelegate;)V
                        new global::net.sf.jni4net.core.MemberId("getItem","(I)Ljava/lang/String;", false, false), // #1 (I)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("gettestGet","()I", false, false), // #2 ()I
                        new global::net.sf.jni4net.core.MemberId("gettestGetPrivateSet","()I", false, false), // #3 ()I
                        new global::net.sf.jni4net.core.MemberId("gettestGetSet","()I", false, false), // #4 ()I
                        new global::net.sf.jni4net.core.MemberId("removePropertyChanged","(Lsystem/MulticastDelegate;)V", false, false), // #5 (LSystem/MulticastDelegate;)V
                        new global::net.sf.jni4net.core.MemberId("setItem","(ILjava/lang/String;)V", false, false), // #6 (ILjava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("setItem","(JLjava/lang/String;)V", false, false), // #7 (JLjava/lang/String;)V
                        new global::net.sf.jni4net.core.MemberId("settestGetSet","(I)V", false, false), // #8 (I)V
                        new global::net.sf.jni4net.core.MemberId("settestSet","(I)V", false, false), // #9 (I)V
                        new global::net.sf.jni4net.core.MemberId("settestSetPrivateGet","(I)V", false, false), // #10 (I)V
                        new global::net.sf.jni4net.core.MemberId("test1","(ILjava/lang/String;Lsystem/collections/IList;)I", false, false), // #11 (ILjava/lang/String;LSystem/Collections/IList;)I
                        new global::net.sf.jni4net.core.MemberId("test2","(ILjava/lang/String;Lsystem/collections/IList;)I", false, false), // #12 (ILjava/lang/String;LSystem/Collections/IList;)I
                        new global::net.sf.jni4net.core.MemberId("test3","([I[Ljava/lang/String;[Lsystem/collections/IList;)I", false, false), // #13 ([I[Ljava/lang/String;[LSystem/Collections/IList;)I
                        new global::net.sf.jni4net.core.MemberId("testOut","(Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V", false, false), // #14 (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testOutCallback","(Ldummy/clr/ITested;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V", false, false), // #15 (Ldummy/clr/ITested;Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testOutint","(Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)I", false, false), // #16 (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/Outjava/lang/Object;Lnet/sf/jni4net/Outjava/lang/String;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/ICollection;)I
                        new global::net.sf.jni4net.core.MemberId("testRef","(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V", false, false), // #17 (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testRef11","(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V", false, false), // #18 (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testRefCallback","(Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V", false, false), // #19 (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testRefCallback11","(Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V", false, false), // #20 (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)V
                        new global::net.sf.jni4net.core.MemberId("testRefint","(Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)I", false, false), // #21 (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/Refjava/lang/Object;Lnet/sf/jni4net/Refjava/lang/String;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/ICollection;)I
                        null, // #22 IsJvmSkip: testSkip
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(dummy.clr.ITested_))]
    internal partial class _ITested : global::java.lang.Object, dummy.clr.ITested
    {
        static _ITested()
        {
            global::net.sf.jni4net.modules.dummynj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(dummy.clr.ITested_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(dummy.clr.ITested_));
        }
        
        protected _ITested(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        new static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new dummy.clr._ITested(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged {
            add {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[0], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, value, "system.MulticastDelegate"));
                }
            }
            remove {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[5], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, value, "system.MulticastDelegate"));
                }
            }
        }
        
        public string this[int a] {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    return j4n_env.CallStringMethod(this, dummy.clr.ITested_.j4n_Members[1], global::net.sf.jni4net.core.ConvertInt.ToValue(a));
                }
            }
            set {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[6], global::net.sf.jni4net.core.ConvertInt.ToValue(a), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, value));
                }
            }
        }
        
        public int testGet {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallIntMethod(this, dummy.clr.ITested_.j4n_Members[2]);
                }
            }
        }
        
        public int testGetPrivateSet {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallIntMethod(this, dummy.clr.ITested_.j4n_Members[3]);
                }
            }
        }
        
        public int testGetSet {
            get {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
                {
                    return j4n_env.CallIntMethod(this, dummy.clr.ITested_.j4n_Members[4]);
                }
            }
            set {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[8], global::net.sf.jni4net.core.ConvertInt.ToValue(value));
                }
            }
        }
        
        public string this[long a] {
            set {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14))
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[7], global::net.sf.jni4net.core.ConvertLong.ToValue(a), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, value));
                }
            }
        }
        
        public int testSet {
            set {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[9], global::net.sf.jni4net.core.ConvertInt.ToValue(value));
                }
            }
        }
        
        public int testSetPrivateGet {
            set {
                global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12))
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[10], global::net.sf.jni4net.core.ConvertInt.ToValue(value));
                }
            }
        }
        
        /// <signature>#11 (ILjava/lang/String;Lsystem/collections/IList;)I (ILsystem/String;LSystem/Collections/IList;)I</signature>
        public int test1(int value, string s, global::System.Collections.IList l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallIntMethod(this, dummy.clr.ITested_.j4n_Members[11], global::net.sf.jni4net.core.ConvertInt.ToValue(value), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, l, "system.collections.IList"));
            }
        }
        
        /// <signature>#12 (ILjava/lang/String;Lsystem/collections/IList;)I (ILsystem/String;LSystem/Collections/IList;)I</signature>
        public int test2(int value, string s, global::System.Collections.IList l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallIntMethod(this, dummy.clr.ITested_.j4n_Members[12], global::net.sf.jni4net.core.ConvertInt.ToValue(value), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, l, "system.collections.IList"));
            }
        }
        
        /// <signature>#13 ([I[Ljava/lang/String;[Lsystem/collections/IList;)I ([I[Lsystem/String;[LSystem/Collections/IList;)I</signature>
        public int test3(int[] value, string[] s, global::System.Collections.IList[] l)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16))
            {
                return j4n_env.CallIntMethod(this, dummy.clr.ITested_.j4n_Members[13], global::net.sf.jni4net.core.ConvertInt.ToValue(j4n_env, value), global::net.sf.jni4net.core.ConvertString.ToValue(j4n_env, s), global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, l, "system.collections.IList"));
            }
        }
        
        /// <signature>#14 (Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)V</signature>
        public void testOut(out int[] value, out object[] value2, out string[] srt, out global::System.Collections.IEnumerable[] enumerable, out global::System.Collections.BitArray[] array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_value = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_value2 = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_srt = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_enumerable = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_array = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                try
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[14], j4n_out_value, j4n_out_value2, j4n_out_srt, j4n_out_enumerable, j4n_out_array);
                }
                finally
                {
                    global::net.sf.jni4net.core.ConvertInt.FromOutParam(j4n_env, j4n_out_value, out value);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_value2, out value2);
                    global::net.sf.jni4net.core.ConvertString.FromOutParam(j4n_env, j4n_out_srt, out srt);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_enumerable, out enumerable);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_array, out array);
                }
            }
        }
        
        /// <signature>#15 (Ldummy/clr/ITested;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)V</signature>
        public void testOutCallback(global::dummy.clr.ITested callback, out int[] value, out object[] value2, out string[] srt, out global::System.Collections.IEnumerable[] enumerable, out global::System.Collections.BitArray[] array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22))
            {
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_value = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_value2 = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_srt = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_enumerable = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_array = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                try
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[15], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, callback, "dummy.clr.ITested"), j4n_out_value, j4n_out_value2, j4n_out_srt, j4n_out_enumerable, j4n_out_array);
                }
                finally
                {
                    global::net.sf.jni4net.core.ConvertInt.FromOutParam(j4n_env, j4n_out_value, out value);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_value2, out value2);
                    global::net.sf.jni4net.core.ConvertString.FromOutParam(j4n_env, j4n_out_srt, out srt);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_enumerable, out enumerable);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_array, out array);
                }
            }
        }
        
        /// <signature>#16 (Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;Lnet/sf/jni4net/Out;)I (Lnet/sf/jni4net/OutI;Lnet/sf/jni4net/OutLsystem/Object;;Lnet/sf/jni4net/OutLsystem/String;;Lnet/sf/jni4net/OutSystem/Collections/IEnumerable;Lnet/sf/jni4net/OutSystem/Collections/BitArray;)I</signature>
        public int testOutint(out int value, out object value2, out string srt, out global::System.Collections.IEnumerable enumerable, out global::System.Collections.BitArray array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_value = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_value2 = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_srt = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_enumerable = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                global::net.sf.jni4net.jni.JNIValueOut j4n_out_array = new global::net.sf.jni4net.jni.JNIValueOut(j4n_env);
                try
                {
                    return j4n_env.CallIntMethod(this, dummy.clr.ITested_.j4n_Members[16], j4n_out_value, j4n_out_value2, j4n_out_srt, j4n_out_enumerable, j4n_out_array);
                }
                finally
                {
                    global::net.sf.jni4net.core.ConvertInt.FromOutParam(j4n_env, j4n_out_value, out value);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_value2, out value2);
                    global::net.sf.jni4net.core.ConvertString.FromOutParam(j4n_env, j4n_out_srt, out srt);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_enumerable, out enumerable);
                    global::net.sf.jni4net.core.ConvertAbstract.FromOutParam(j4n_env, j4n_out_array, out array);
                }
            }
        }
        
        /// <signature>#17 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        public void testRef(ref int[] value, ref object[] value2, ref string[] srt, ref global::System.Collections.IEnumerable[] enumerable, ref global::System.Collections.BitArray[] array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value = global::net.sf.jni4net.core.ConvertInt.ToRefParam(j4n_env, value);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, value2, "java.lang.Object");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_srt = global::net.sf.jni4net.core.ConvertString.ToRefParam(j4n_env, srt);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, array, "system.collections.ICollection");
                try
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[17], j4n_ref_value, j4n_ref_value2, j4n_ref_srt, j4n_ref_enumerable, j4n_ref_array);
                }
                finally
                {
                    global::net.sf.jni4net.core.ConvertInt.FromRefParam(j4n_env, j4n_ref_value, ref value);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_value2, ref value2);
                    global::net.sf.jni4net.core.ConvertString.FromRefParam(j4n_env, j4n_ref_srt, ref srt);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_enumerable, ref enumerable);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_array, ref array);
                }
            }
        }
        
        /// <signature>#18 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        public void testRef11(ref int[][] value, ref object[][] value2, ref string[][] srt, ref global::System.Collections.IEnumerable[][] enumerable, ref global::System.Collections.BitArray[][] array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value = global::net.sf.jni4net.core.ConvertInt.ToRefParam(j4n_env, value);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, value2, "java.lang.Object");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_srt = global::net.sf.jni4net.core.ConvertString.ToRefParam(j4n_env, srt);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, array, "system.collections.ICollection");
                try
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[18], j4n_ref_value, j4n_ref_value2, j4n_ref_srt, j4n_ref_enumerable, j4n_ref_array);
                }
                finally
                {
                    global::net.sf.jni4net.core.ConvertInt.FromRefParam(j4n_env, j4n_ref_value, ref value);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_value2, ref value2);
                    global::net.sf.jni4net.core.ConvertString.FromRefParam(j4n_env, j4n_ref_srt, ref srt);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_enumerable, ref enumerable);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_array, ref array);
                }
            }
        }
        
        /// <signature>#19 (Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        public void testRefCallback(global::dummy.clr.ITested callback, ref int[] value, ref object[] value2, ref string[] srt, ref global::System.Collections.IEnumerable[] enumerable, ref global::System.Collections.BitArray[] array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22))
            {
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value = global::net.sf.jni4net.core.ConvertInt.ToRefParam(j4n_env, value);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, value2, "java.lang.Object");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_srt = global::net.sf.jni4net.core.ConvertString.ToRefParam(j4n_env, srt);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, array, "system.collections.ICollection");
                try
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[19], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, callback, "dummy.clr.ITested"), j4n_ref_value, j4n_ref_value2, j4n_ref_srt, j4n_ref_enumerable, j4n_ref_array);
                }
                finally
                {
                    global::net.sf.jni4net.core.ConvertInt.FromRefParam(j4n_env, j4n_ref_value, ref value);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_value2, ref value2);
                    global::net.sf.jni4net.core.ConvertString.FromRefParam(j4n_env, j4n_ref_srt, ref srt);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_enumerable, ref enumerable);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_array, ref array);
                }
            }
        }
        
        /// <signature>#20 (Ldummy/clr/ITested;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)V (Ldummy/clr/ITested;Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)V</signature>
        public void testRefCallback11(global::dummy.clr.ITested callback, ref int[][] value, ref object[][] value2, ref string[][] srt, ref global::System.Collections.IEnumerable[][] enumerable, ref global::System.Collections.BitArray[][] array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 22))
            {
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value = global::net.sf.jni4net.core.ConvertInt.ToRefParam(j4n_env, value);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, value2, "java.lang.Object");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_srt = global::net.sf.jni4net.core.ConvertString.ToRefParam(j4n_env, srt);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, array, "system.collections.ICollection");
                try
                {
                    j4n_env.CallVoidMethod(this, dummy.clr.ITested_.j4n_Members[20], global::net.sf.jni4net.core.ConvertAbstract.ToValue(j4n_env, callback, "dummy.clr.ITested"), j4n_ref_value, j4n_ref_value2, j4n_ref_srt, j4n_ref_enumerable, j4n_ref_array);
                }
                finally
                {
                    global::net.sf.jni4net.core.ConvertInt.FromRefParam(j4n_env, j4n_ref_value, ref value);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_value2, ref value2);
                    global::net.sf.jni4net.core.ConvertString.FromRefParam(j4n_env, j4n_ref_srt, ref srt);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_enumerable, ref enumerable);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_array, ref array);
                }
            }
        }
        
        /// <signature>#21 (Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;Lnet/sf/jni4net/Ref;)I (Lnet/sf/jni4net/RefI;Lnet/sf/jni4net/RefLsystem/Object;;Lnet/sf/jni4net/RefLsystem/String;;Lnet/sf/jni4net/RefSystem/Collections/IEnumerable;Lnet/sf/jni4net/RefSystem/Collections/BitArray;)I</signature>
        public int testRefint(ref int value, ref object value2, ref string srt, ref global::System.Collections.IEnumerable enumerable, ref global::System.Collections.BitArray array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20))
            {
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value = global::net.sf.jni4net.core.ConvertInt.ToRefParam(j4n_env, value);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_value2 = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, value2, "java.lang.Object");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_srt = global::net.sf.jni4net.core.ConvertString.ToRefParam(j4n_env, srt);
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_enumerable = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, enumerable, "system.collections.IEnumerable");
                global::net.sf.jni4net.jni.JNIValueRef j4n_ref_array = global::net.sf.jni4net.core.ConvertAbstract.ToRefParam(j4n_env, array, "system.collections.ICollection");
                try
                {
                    return j4n_env.CallIntMethod(this, dummy.clr.ITested_.j4n_Members[21], j4n_ref_value, j4n_ref_value2, j4n_ref_srt, j4n_ref_enumerable, j4n_ref_array);
                }
                finally
                {
                    global::net.sf.jni4net.core.ConvertInt.FromRefParam(j4n_env, j4n_ref_value, ref value);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_value2, ref value2);
                    global::net.sf.jni4net.core.ConvertString.FromRefParam(j4n_env, j4n_ref_srt, ref srt);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_enumerable, ref enumerable);
                    global::net.sf.jni4net.core.ConvertAbstract.FromRefParam(j4n_env, j4n_ref_array, ref array);
                }
            }
        }
        
        /// <signature>#22 ()V ()V</signature>
        public void testSkip()
        {
            throw new global::System.NotImplementedException();
        }
    }
}

#endregion Component Designer generated code
