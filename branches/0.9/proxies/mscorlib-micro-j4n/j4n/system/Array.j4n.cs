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
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Array_))]
    static public partial class Array_
    {
        static Array_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.ICloneable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.ICloneable_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Collections.IList_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Collections.IList_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Array_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 BinarySearch(Lsystem/Array;IILjava/lang/Object;)I (LSystem/Array;IILsystem/Object;)I</signature>
        static int j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, int index, int length, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                int j4n_result = global::System.Array.BinarySearch(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), index, length, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#1 BinarySearch(Lsystem/Array;IILjava/lang/Object;Lsystem/Object;)I (LSystem/Array;IILsystem/Object;LSystem/Collections/IComparer;)I</signature>
        static int j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, int index, int length, global::System.IntPtr value, global::System.IntPtr comparer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                int j4n_result = global::System.Array.BinarySearch(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), index, length, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IComparer>(j4n_env, comparer));
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
        
        /// <signature>#2 BinarySearch(Lsystem/Array;Ljava/lang/Object;)I (LSystem/Array;Lsystem/Object;)I</signature>
        static int j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = global::System.Array.BinarySearch(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#3 BinarySearch(Lsystem/Array;Ljava/lang/Object;Lsystem/Object;)I (LSystem/Array;Lsystem/Object;LSystem/Collections/IComparer;)I</signature>
        static int j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr value, global::System.IntPtr comparer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                int j4n_result = global::System.Array.BinarySearch(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IComparer>(j4n_env, comparer));
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
        
        /// <signature>#4 Clear(Lsystem/Array;II)V (LSystem/Array;II)V</signature>
        static void j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, int index, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array.Clear(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), index, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#5 ConstrainedCopy(Lsystem/Array;ILsystem/Array;II)V (LSystem/Array;ILSystem/Array;II)V</signature>
        static void j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr sourceArray, int sourceIndex, global::System.IntPtr destinationArray, int destinationIndex, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Array.ConstrainedCopy(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, sourceArray), sourceIndex, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, destinationArray), destinationIndex, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#6 Copy(Lsystem/Array;Lsystem/Array;I)V (LSystem/Array;LSystem/Array;I)V</signature>
        static void j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr sourceArray, global::System.IntPtr destinationArray, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array.Copy(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, sourceArray), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, destinationArray), length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#7 Copy(Lsystem/Array;Lsystem/Array;J)V (LSystem/Array;LSystem/Array;J)V</signature>
        static void j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr sourceArray, global::System.IntPtr destinationArray, long length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array.Copy(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, sourceArray), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, destinationArray), length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#8 Copy(Lsystem/Array;ILsystem/Array;II)V (LSystem/Array;ILSystem/Array;II)V</signature>
        static void j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr sourceArray, int sourceIndex, global::System.IntPtr destinationArray, int destinationIndex, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Array.Copy(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, sourceArray), sourceIndex, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, destinationArray), destinationIndex, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#9 Copy(Lsystem/Array;JLsystem/Array;JJ)V (LSystem/Array;JLSystem/Array;JJ)V</signature>
        static void j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr sourceArray, long sourceIndex, global::System.IntPtr destinationArray, long destinationIndex, long length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Array.Copy(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, sourceArray), sourceIndex, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, destinationArray), destinationIndex, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#10 CreateInstance(Lsystem/Type;[I)Lsystem/Array; (LSystem/Type;[I)LSystem/Array;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr elementType, global::System.IntPtr lengths)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Array.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, elementType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<int[]>(j4n_env, lengths)), "system.Array");
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
        
        /// <signature>#11 CreateInstance(Lsystem/Type;[I[I)Lsystem/Array; (LSystem/Type;[I[I)LSystem/Array;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr elementType, global::System.IntPtr lengths, global::System.IntPtr lowerBounds)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Array.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, elementType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<int[]>(j4n_env, lengths), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<int[]>(j4n_env, lowerBounds)), "system.Array");
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
        
        /// <signature>#12 CreateInstance(Lsystem/Type;[J)Lsystem/Array; (LSystem/Type;[J)LSystem/Array;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr elementType, global::System.IntPtr lengths)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Array.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, elementType), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<long[]>(j4n_env, lengths)), "system.Array");
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
        
        /// <signature>#13 CreateInstance(Lsystem/Type;I)Lsystem/Array; (LSystem/Type;I)LSystem/Array;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr elementType, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Array.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, elementType), length), "system.Array");
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
        
        /// <signature>#14 CreateInstance(Lsystem/Type;II)Lsystem/Array; (LSystem/Type;II)LSystem/Array;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr elementType, int length1, int length2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Array.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, elementType), length1, length2), "system.Array");
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
        
        /// <signature>#15 CreateInstance(Lsystem/Type;III)Lsystem/Array; (LSystem/Type;III)LSystem/Array;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr elementType, int length1, int length2, int length3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Array.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, elementType), length1, length2, length3), "system.Array");
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
        
        /// <signature>#16 IndexOf(Lsystem/Array;Ljava/lang/Object;)I (LSystem/Array;Lsystem/Object;)I</signature>
        static int j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = global::System.Array.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#17 IndexOf(Lsystem/Array;Ljava/lang/Object;I)I (LSystem/Array;Lsystem/Object;I)I</signature>
        static int j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr value, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                int j4n_result = global::System.Array.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), startIndex);
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
        
        /// <signature>#18 IndexOf(Lsystem/Array;Ljava/lang/Object;II)I (LSystem/Array;Lsystem/Object;II)I</signature>
        static int j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr value, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                int j4n_result = global::System.Array.IndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), startIndex, count);
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
        
        /// <signature>#19 LastIndexOf(Lsystem/Array;Ljava/lang/Object;)I (LSystem/Array;Lsystem/Object;)I</signature>
        static int j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                int j4n_result = global::System.Array.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value));
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
        
        /// <signature>#20 LastIndexOf(Lsystem/Array;Ljava/lang/Object;I)I (LSystem/Array;Lsystem/Object;I)I</signature>
        static int j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr value, int startIndex)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                int j4n_result = global::System.Array.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), startIndex);
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
        
        /// <signature>#21 LastIndexOf(Lsystem/Array;Ljava/lang/Object;II)I (LSystem/Array;Lsystem/Object;II)I</signature>
        static int j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr value, int startIndex, int count)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                int j4n_result = global::System.Array.LastIndexOf(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), startIndex, count);
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
        
        /// <signature>#22 Reverse(Lsystem/Array;)V (LSystem/Array;)V</signature>
        static void j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array.Reverse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#23 Reverse(Lsystem/Array;II)V (LSystem/Array;II)V</signature>
        static void j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, int index, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array.Reverse(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), index, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#24 Sort(Lsystem/Array;)V (LSystem/Array;)V</signature>
        static void j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array.Sort(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#25 Sort(Lsystem/Array;Lsystem/Array;)V (LSystem/Array;LSystem/Array;)V</signature>
        static void j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr keys, global::System.IntPtr items)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array.Sort(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, keys), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, items));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#26 Sort(Lsystem/Array;Lsystem/Array;Lsystem/Object;)V (LSystem/Array;LSystem/Array;LSystem/Collections/IComparer;)V</signature>
        static void j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr keys, global::System.IntPtr items, global::System.IntPtr comparer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array.Sort(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, keys), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, items), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IComparer>(j4n_env, comparer));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#27 Sort(Lsystem/Array;Lsystem/Array;II)V (LSystem/Array;LSystem/Array;II)V</signature>
        static void j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr keys, global::System.IntPtr items, int index, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Array.Sort(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, keys), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, items), index, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#28 Sort(Lsystem/Array;Lsystem/Array;IILsystem/Object;)V (LSystem/Array;LSystem/Array;IILSystem/Collections/IComparer;)V</signature>
        static void j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr keys, global::System.IntPtr items, int index, int length, global::System.IntPtr comparer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 20);
            try
            {
                global::System.Array.Sort(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, keys), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, items), index, length, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IComparer>(j4n_env, comparer));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#29 Sort(Lsystem/Array;Lsystem/Object;)V (LSystem/Array;LSystem/Collections/IComparer;)V</signature>
        static void j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, global::System.IntPtr comparer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array.Sort(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IComparer>(j4n_env, comparer));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#30 Sort(Lsystem/Array;II)V (LSystem/Array;II)V</signature>
        static void j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, int index, int length)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array.Sort(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), index, length);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#31 Sort(Lsystem/Array;IILsystem/Object;)V (LSystem/Array;IILSystem/Collections/IComparer;)V</signature>
        static void j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr array, int index, int length, global::System.IntPtr comparer)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Array.Sort(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, array), index, length, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IComparer>(j4n_env, comparer));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#32 Add(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#33 Clear()V ()V</signature>
        static void j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#34 Clone()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.ICloneable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.ICloneable>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Clone(), "java.lang.Object");
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
        
        /// <signature>#35 Contains(Ljava/lang/Object;)Z (Lsystem/Object;)Z</signature>
        static bool j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#36 CopyTo(Lsystem/Array;I)V (LSystem/Array;I)V</signature>
        static void j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr array, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Collections.ICollection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.ICollection>(j4n_env, j4n_self);
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
        
        /// <signature>#37 CopyTo(Lsystem/Array;J)V (LSystem/Array;J)V</signature>
        static void j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr array, long index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
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
        
        /// <signature>#38 get_Count()I ()I</signature>
        static int j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.ICollection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.ICollection>(j4n_env, j4n_self);
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
        
        /// <signature>#39 get_IsFixedSize()Z ()Z</signature>
        static bool j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#40 get_IsReadOnly()Z ()Z</signature>
        static bool j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#41 get_IsSynchronized()Z ()Z</signature>
        static bool j4n_41(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.ICollection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.ICollection>(j4n_env, j4n_self);
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
        
        /// <signature>#42 get_Item(I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_42(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#43 get_Length()I ()I</signature>
        static int j4n_43(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Length;
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
        
        /// <signature>#44 get_LongLength()J ()J</signature>
        static long j4n_44(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                long j4n_result = j4n_real.LongLength;
                return j4n_result;
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
        
        /// <signature>#45 get_Rank()I ()I</signature>
        static int j4n_45(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                int j4n_result = j4n_real.Rank;
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
        
        /// <signature>#46 get_SyncRoot()Ljava/lang/Object; ()Lsystem/Object;</signature>
        static global::System.IntPtr j4n_46(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.ICollection j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.ICollection>(j4n_env, j4n_self);
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
        
        /// <signature>#47 GetEnumerator()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
        static global::System.IntPtr j4n_47(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Collections.IEnumerable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IEnumerable>(j4n_env, j4n_self);
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
        
        /// <signature>#48 GetLength(I)I (I)I</signature>
        static int j4n_48(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int dimension)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                int j4n_result = j4n_real.GetLength(dimension);
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
        
        /// <signature>#49 GetLongLength(I)J (I)J</signature>
        static long j4n_49(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int dimension)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                long j4n_result = j4n_real.GetLongLength(dimension);
                return j4n_result;
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
        
        /// <signature>#50 GetLowerBound(I)I (I)I</signature>
        static int j4n_50(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int dimension)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                int j4n_result = j4n_real.GetLowerBound(dimension);
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
        
        /// <signature>#51 GetUpperBound(I)I (I)I</signature>
        static int j4n_51(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int dimension)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                int j4n_result = j4n_real.GetUpperBound(dimension);
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
        
        /// <signature>#52 GetValue([I)Ljava/lang/Object; ([I)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_52(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr indices)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<int[]>(j4n_env, indices)), "java.lang.Object");
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
        
        /// <signature>#53 GetValue([J)Ljava/lang/Object; ([J)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_53(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr indices)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<long[]>(j4n_env, indices)), "java.lang.Object");
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
        
        /// <signature>#54 GetValue(I)Ljava/lang/Object; (I)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_54(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(index), "java.lang.Object");
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
        
        /// <signature>#55 GetValue(II)Ljava/lang/Object; (II)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_55(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index1, int index2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(index1, index2), "java.lang.Object");
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
        
        /// <signature>#56 GetValue(III)Ljava/lang/Object; (III)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_56(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index1, int index2, int index3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(index1, index2, index3), "java.lang.Object");
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
        
        /// <signature>#57 GetValue(J)Ljava/lang/Object; (J)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_57(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(index), "java.lang.Object");
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
        
        /// <signature>#58 GetValue(JJ)Ljava/lang/Object; (JJ)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_58(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long index1, long index2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(index1, index2), "java.lang.Object");
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
        
        /// <signature>#59 GetValue(JJJ)Ljava/lang/Object; (JJJ)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_59(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, long index1, long index2, long index3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetValue(index1, index2, index3), "java.lang.Object");
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
        
        /// <signature>#60 IndexOf(Ljava/lang/Object;)I (Lsystem/Object;)I</signature>
        static int j4n_60(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#61 Initialize()V ()V</signature>
        static void j4n_61(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.Initialize();
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#62 Insert(ILjava/lang/Object;)V (ILsystem/Object;)V</signature>
        static void j4n_62(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#63 Remove(Ljava/lang/Object;)V (Lsystem/Object;)V</signature>
        static void j4n_63(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#64 RemoveAt(I)V (I)V</signature>
        static void j4n_64(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#65 set_Item(ILjava/lang/Object;)V (ILsystem/Object;)V</signature>
        static void j4n_65(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, int index, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Collections.IList j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Collections.IList>(j4n_env, j4n_self);
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
        
        /// <signature>#66 SetValue(Ljava/lang/Object;[I)V (Lsystem/Object;[I)V</signature>
        static void j4n_66(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr indices)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<int[]>(j4n_env, indices));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#67 SetValue(Ljava/lang/Object;[J)V (Lsystem/Object;[J)V</signature>
        static void j4n_67(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, global::System.IntPtr indices)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<long[]>(j4n_env, indices));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#68 SetValue(Ljava/lang/Object;I)V (Lsystem/Object;I)V</signature>
        static void j4n_68(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), index);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#69 SetValue(Ljava/lang/Object;II)V (Lsystem/Object;II)V</signature>
        static void j4n_69(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int index1, int index2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), index1, index2);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#70 SetValue(Ljava/lang/Object;III)V (Lsystem/Object;III)V</signature>
        static void j4n_70(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, int index1, int index2, int index3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), index1, index2, index3);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#71 SetValue(Ljava/lang/Object;J)V (Lsystem/Object;J)V</signature>
        static void j4n_71(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, long index)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), index);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#72 SetValue(Ljava/lang/Object;JJ)V (Lsystem/Object;JJ)V</signature>
        static void j4n_72(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, long index1, long index2)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), index1, index2);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#73 SetValue(Ljava/lang/Object;JJJ)V (Lsystem/Object;JJJ)V</signature>
        static void j4n_73(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value, long index1, long index2, long index3)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                global::System.Array j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Array>(j4n_env, j4n_self);
                j4n_real.SetValue(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object>(j4n_env, value), index1, index2, index3);
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
            lock (typeof(global::System.Array))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.Array";
                    proxyInfo.JVMProxyName = "system.Array";
                    proxyInfo.JVMStaticApiName = "system.Array";
                    proxyInfo.CLRApi = typeof(System.Array);
                    proxyInfo.CLRStaticApi = typeof(System.Array_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("BinarySearch","(Lsystem/Array;IILjava/lang/Object;)I", false, true), // #0 (LSystem/Array;IILjava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("BinarySearch","(Lsystem/Array;IILjava/lang/Object;Lsystem/Object;)I", false, true), // #1 (LSystem/Array;IILjava/lang/Object;Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("BinarySearch","(Lsystem/Array;Ljava/lang/Object;)I", false, true), // #2 (LSystem/Array;Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("BinarySearch","(Lsystem/Array;Ljava/lang/Object;Lsystem/Object;)I", false, true), // #3 (LSystem/Array;Ljava/lang/Object;Lsystem/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Clear","(Lsystem/Array;II)V", false, true), // #4 (LSystem/Array;II)V
                        new global::net.sf.jni4net.core.MemberId("ConstrainedCopy","(Lsystem/Array;ILsystem/Array;II)V", false, true), // #5 (LSystem/Array;ILSystem/Array;II)V
                        new global::net.sf.jni4net.core.MemberId("Copy","(Lsystem/Array;Lsystem/Array;I)V", false, true), // #6 (LSystem/Array;LSystem/Array;I)V
                        new global::net.sf.jni4net.core.MemberId("Copy","(Lsystem/Array;Lsystem/Array;J)V", false, true), // #7 (LSystem/Array;LSystem/Array;J)V
                        new global::net.sf.jni4net.core.MemberId("Copy","(Lsystem/Array;ILsystem/Array;II)V", false, true), // #8 (LSystem/Array;ILSystem/Array;II)V
                        new global::net.sf.jni4net.core.MemberId("Copy","(Lsystem/Array;JLsystem/Array;JJ)V", false, true), // #9 (LSystem/Array;JLSystem/Array;JJ)V
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Lsystem/Type;[I)Lsystem/Array;", false, true), // #10 (LSystem/Type;[I)LSystem/Array;
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Lsystem/Type;[I[I)Lsystem/Array;", false, true), // #11 (LSystem/Type;[I[I)LSystem/Array;
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Lsystem/Type;[J)Lsystem/Array;", false, true), // #12 (LSystem/Type;[J)LSystem/Array;
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Lsystem/Type;I)Lsystem/Array;", false, true), // #13 (LSystem/Type;I)LSystem/Array;
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Lsystem/Type;II)Lsystem/Array;", false, true), // #14 (LSystem/Type;II)LSystem/Array;
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Lsystem/Type;III)Lsystem/Array;", false, true), // #15 (LSystem/Type;III)LSystem/Array;
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Lsystem/Array;Ljava/lang/Object;)I", false, true), // #16 (LSystem/Array;Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Lsystem/Array;Ljava/lang/Object;I)I", false, true), // #17 (LSystem/Array;Ljava/lang/Object;I)I
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Lsystem/Array;Ljava/lang/Object;II)I", false, true), // #18 (LSystem/Array;Ljava/lang/Object;II)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Lsystem/Array;Ljava/lang/Object;)I", false, true), // #19 (LSystem/Array;Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Lsystem/Array;Ljava/lang/Object;I)I", false, true), // #20 (LSystem/Array;Ljava/lang/Object;I)I
                        new global::net.sf.jni4net.core.MemberId("LastIndexOf","(Lsystem/Array;Ljava/lang/Object;II)I", false, true), // #21 (LSystem/Array;Ljava/lang/Object;II)I
                        new global::net.sf.jni4net.core.MemberId("Reverse","(Lsystem/Array;)V", false, true), // #22 (LSystem/Array;)V
                        new global::net.sf.jni4net.core.MemberId("Reverse","(Lsystem/Array;II)V", false, true), // #23 (LSystem/Array;II)V
                        new global::net.sf.jni4net.core.MemberId("Sort","(Lsystem/Array;)V", false, true), // #24 (LSystem/Array;)V
                        new global::net.sf.jni4net.core.MemberId("Sort","(Lsystem/Array;Lsystem/Array;)V", false, true), // #25 (LSystem/Array;LSystem/Array;)V
                        new global::net.sf.jni4net.core.MemberId("Sort","(Lsystem/Array;Lsystem/Array;Lsystem/Object;)V", false, true), // #26 (LSystem/Array;LSystem/Array;Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Sort","(Lsystem/Array;Lsystem/Array;II)V", false, true), // #27 (LSystem/Array;LSystem/Array;II)V
                        new global::net.sf.jni4net.core.MemberId("Sort","(Lsystem/Array;Lsystem/Array;IILsystem/Object;)V", false, true), // #28 (LSystem/Array;LSystem/Array;IILsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Sort","(Lsystem/Array;Lsystem/Object;)V", false, true), // #29 (LSystem/Array;Lsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Sort","(Lsystem/Array;II)V", false, true), // #30 (LSystem/Array;II)V
                        new global::net.sf.jni4net.core.MemberId("Sort","(Lsystem/Array;IILsystem/Object;)V", false, true), // #31 (LSystem/Array;IILsystem/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Add","(Ljava/lang/Object;)I", false, false), // #32 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Clear","()V", false, false), // #33 ()V
                        new global::net.sf.jni4net.core.MemberId("Clone","()Ljava/lang/Object;", false, false), // #34 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("Contains","(Ljava/lang/Object;)Z", false, false), // #35 (Ljava/lang/Object;)Z
                        new global::net.sf.jni4net.core.MemberId("CopyTo","(Lsystem/Array;I)V", false, false), // #36 (LSystem/Array;I)V
                        new global::net.sf.jni4net.core.MemberId("CopyTo","(Lsystem/Array;J)V", false, false), // #37 (LSystem/Array;J)V
                        new global::net.sf.jni4net.core.MemberId("getCount","()I", false, false), // #38 ()I
                        new global::net.sf.jni4net.core.MemberId("getIsFixedSize","()Z", false, false), // #39 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsReadOnly","()Z", false, false), // #40 ()Z
                        new global::net.sf.jni4net.core.MemberId("getIsSynchronized","()Z", false, false), // #41 ()Z
                        new global::net.sf.jni4net.core.MemberId("getItem","(I)Ljava/lang/Object;", false, false), // #42 (I)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getLength","()I", false, false), // #43 ()I
                        new global::net.sf.jni4net.core.MemberId("getLongLength","()J", false, false), // #44 ()J
                        new global::net.sf.jni4net.core.MemberId("getRank","()I", false, false), // #45 ()I
                        new global::net.sf.jni4net.core.MemberId("getSyncRoot","()Ljava/lang/Object;", false, false), // #46 ()Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetEnumerator","()Lsystem/collections/IEnumerator;", false, false), // #47 ()LSystem/Collections/IEnumerator;
                        new global::net.sf.jni4net.core.MemberId("GetLength","(I)I", false, false), // #48 (I)I
                        new global::net.sf.jni4net.core.MemberId("GetLongLength","(I)J", false, false), // #49 (I)J
                        new global::net.sf.jni4net.core.MemberId("GetLowerBound","(I)I", false, false), // #50 (I)I
                        new global::net.sf.jni4net.core.MemberId("GetUpperBound","(I)I", false, false), // #51 (I)I
                        new global::net.sf.jni4net.core.MemberId("GetValue","([I)Ljava/lang/Object;", false, false), // #52 ([I)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetValue","([J)Ljava/lang/Object;", false, false), // #53 ([J)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(I)Ljava/lang/Object;", false, false), // #54 (I)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(II)Ljava/lang/Object;", false, false), // #55 (II)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(III)Ljava/lang/Object;", false, false), // #56 (III)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(J)Ljava/lang/Object;", false, false), // #57 (J)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(JJ)Ljava/lang/Object;", false, false), // #58 (JJ)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetValue","(JJJ)Ljava/lang/Object;", false, false), // #59 (JJJ)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("IndexOf","(Ljava/lang/Object;)I", false, false), // #60 (Ljava/lang/Object;)I
                        new global::net.sf.jni4net.core.MemberId("Initialize","()V", false, false), // #61 ()V
                        new global::net.sf.jni4net.core.MemberId("Insert","(ILjava/lang/Object;)V", false, false), // #62 (ILjava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("Remove","(Ljava/lang/Object;)V", false, false), // #63 (Ljava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("RemoveAt","(I)V", false, false), // #64 (I)V
                        new global::net.sf.jni4net.core.MemberId("setItem","(ILjava/lang/Object;)V", false, false), // #65 (ILjava/lang/Object;)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;[I)V", false, false), // #66 (Ljava/lang/Object;[I)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;[J)V", false, false), // #67 (Ljava/lang/Object;[J)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;I)V", false, false), // #68 (Ljava/lang/Object;I)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;II)V", false, false), // #69 (Ljava/lang/Object;II)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;III)V", false, false), // #70 (Ljava/lang/Object;III)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;J)V", false, false), // #71 (Ljava/lang/Object;J)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;JJ)V", false, false), // #72 (Ljava/lang/Object;JJ)V
                        new global::net.sf.jni4net.core.MemberId("SetValue","(Ljava/lang/Object;JJJ)V", false, false), // #73 (Ljava/lang/Object;JJJ)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
