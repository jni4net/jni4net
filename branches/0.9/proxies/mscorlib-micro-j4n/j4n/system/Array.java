// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Array.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Array extends system.Object implements system.ICloneable, system.collections.IList
// <j4ni-Array>
// put user interfaces here
// </j4ni-Array>
{
    // <j4nb-Array> 
    // put user members here
    // </j4nb-Array>
    
    protected Array(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Array(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Array.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/Array;IILjava/lang/Object;)I (LSystem/Array;IILjava/lang/Object;)I</signature>
    static public native int BinarySearch(system.Array array, int index, int length, java.lang.Object value);
    
    /// <signature>#1 (Lsystem/Array;IILjava/lang/Object;Lsystem/Object;)I (LSystem/Array;IILjava/lang/Object;Lsystem/Object;)I</signature>
    static public native int BinarySearch(system.Array array, int index, int length, java.lang.Object value, system.Object comparer);
    
    /// <signature>#2 (Lsystem/Array;Ljava/lang/Object;)I (LSystem/Array;Ljava/lang/Object;)I</signature>
    static public native int BinarySearch(system.Array array, java.lang.Object value);
    
    /// <signature>#3 (Lsystem/Array;Ljava/lang/Object;Lsystem/Object;)I (LSystem/Array;Ljava/lang/Object;Lsystem/Object;)I</signature>
    static public native int BinarySearch(system.Array array, java.lang.Object value, system.Object comparer);
    
    /// <signature>#4 (Lsystem/Array;II)V (LSystem/Array;II)V</signature>
    static public native void Clear(system.Array array, int index, int length);
    
    /// <signature>#5 (Lsystem/Array;ILsystem/Array;II)V (LSystem/Array;ILSystem/Array;II)V</signature>
    static public native void ConstrainedCopy(system.Array sourceArray, int sourceIndex, system.Array destinationArray, int destinationIndex, int length);
    
    /// <signature>#6 (Lsystem/Array;Lsystem/Array;I)V (LSystem/Array;LSystem/Array;I)V</signature>
    static public native void Copy(system.Array sourceArray, system.Array destinationArray, int length);
    
    /// <signature>#7 (Lsystem/Array;Lsystem/Array;J)V (LSystem/Array;LSystem/Array;J)V</signature>
    static public native void Copy(system.Array sourceArray, system.Array destinationArray, long length);
    
    /// <signature>#8 (Lsystem/Array;ILsystem/Array;II)V (LSystem/Array;ILSystem/Array;II)V</signature>
    static public native void Copy(system.Array sourceArray, int sourceIndex, system.Array destinationArray, int destinationIndex, int length);
    
    /// <signature>#9 (Lsystem/Array;JLsystem/Array;JJ)V (LSystem/Array;JLSystem/Array;JJ)V</signature>
    static public native void Copy(system.Array sourceArray, long sourceIndex, system.Array destinationArray, long destinationIndex, long length);
    
    /// <signature>#10 (Lsystem/Type;[I)Lsystem/Array; (LSystem/Type;[I)LSystem/Array;</signature>
    static public native system.Array CreateInstance(system.Type elementType, int[] lengths);
    
    /// <signature>#11 (Lsystem/Type;[I[I)Lsystem/Array; (LSystem/Type;[I[I)LSystem/Array;</signature>
    static public native system.Array CreateInstance(system.Type elementType, int[] lengths, int[] lowerBounds);
    
    /// <signature>#12 (Lsystem/Type;[J)Lsystem/Array; (LSystem/Type;[J)LSystem/Array;</signature>
    static public native system.Array CreateInstance(system.Type elementType, long[] lengths);
    
    /// <signature>#13 (Lsystem/Type;I)Lsystem/Array; (LSystem/Type;I)LSystem/Array;</signature>
    static public native system.Array CreateInstance(system.Type elementType, int length);
    
    /// <signature>#14 (Lsystem/Type;II)Lsystem/Array; (LSystem/Type;II)LSystem/Array;</signature>
    static public native system.Array CreateInstance(system.Type elementType, int length1, int length2);
    
    /// <signature>#15 (Lsystem/Type;III)Lsystem/Array; (LSystem/Type;III)LSystem/Array;</signature>
    static public native system.Array CreateInstance(system.Type elementType, int length1, int length2, int length3);
    
    /// <signature>#16 (Lsystem/Array;Ljava/lang/Object;)I (LSystem/Array;Ljava/lang/Object;)I</signature>
    static public native int IndexOf(system.Array array, java.lang.Object value);
    
    /// <signature>#17 (Lsystem/Array;Ljava/lang/Object;I)I (LSystem/Array;Ljava/lang/Object;I)I</signature>
    static public native int IndexOf(system.Array array, java.lang.Object value, int startIndex);
    
    /// <signature>#18 (Lsystem/Array;Ljava/lang/Object;II)I (LSystem/Array;Ljava/lang/Object;II)I</signature>
    static public native int IndexOf(system.Array array, java.lang.Object value, int startIndex, int count);
    
    /// <signature>#19 (Lsystem/Array;Ljava/lang/Object;)I (LSystem/Array;Ljava/lang/Object;)I</signature>
    static public native int LastIndexOf(system.Array array, java.lang.Object value);
    
    /// <signature>#20 (Lsystem/Array;Ljava/lang/Object;I)I (LSystem/Array;Ljava/lang/Object;I)I</signature>
    static public native int LastIndexOf(system.Array array, java.lang.Object value, int startIndex);
    
    /// <signature>#21 (Lsystem/Array;Ljava/lang/Object;II)I (LSystem/Array;Ljava/lang/Object;II)I</signature>
    static public native int LastIndexOf(system.Array array, java.lang.Object value, int startIndex, int count);
    
    /// <signature>#22 (Lsystem/Array;)V (LSystem/Array;)V</signature>
    static public native void Reverse(system.Array array);
    
    /// <signature>#23 (Lsystem/Array;II)V (LSystem/Array;II)V</signature>
    static public native void Reverse(system.Array array, int index, int length);
    
    /// <signature>#24 (Lsystem/Array;)V (LSystem/Array;)V</signature>
    static public native void Sort(system.Array array);
    
    /// <signature>#25 (Lsystem/Array;Lsystem/Array;)V (LSystem/Array;LSystem/Array;)V</signature>
    static public native void Sort(system.Array keys, system.Array items);
    
    /// <signature>#26 (Lsystem/Array;Lsystem/Array;Lsystem/Object;)V (LSystem/Array;LSystem/Array;Lsystem/Object;)V</signature>
    static public native void Sort(system.Array keys, system.Array items, system.Object comparer);
    
    /// <signature>#27 (Lsystem/Array;Lsystem/Array;II)V (LSystem/Array;LSystem/Array;II)V</signature>
    static public native void Sort(system.Array keys, system.Array items, int index, int length);
    
    /// <signature>#28 (Lsystem/Array;Lsystem/Array;IILsystem/Object;)V (LSystem/Array;LSystem/Array;IILsystem/Object;)V</signature>
    static public native void Sort(system.Array keys, system.Array items, int index, int length, system.Object comparer);
    
    /// <signature>#29 (Lsystem/Array;Lsystem/Object;)V (LSystem/Array;Lsystem/Object;)V</signature>
    static public native void Sort(system.Array array, system.Object comparer);
    
    /// <signature>#30 (Lsystem/Array;II)V (LSystem/Array;II)V</signature>
    static public native void Sort(system.Array array, int index, int length);
    
    /// <signature>#31 (Lsystem/Array;IILsystem/Object;)V (LSystem/Array;IILsystem/Object;)V</signature>
    static public native void Sort(system.Array array, int index, int length, system.Object comparer);
    
    /// <signature>#32 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int Add(java.lang.Object value);
    
    /// <signature>#33 ()V ()V</signature>
    public native void Clear();
    
    /// <signature>#34 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object Clone();
    
    /// <signature>#35 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean Contains(java.lang.Object value);
    
    /// <signature>#36 (Lsystem/Array;I)V (LSystem/Array;I)V</signature>
    public native void CopyTo(system.Array array, int index);
    
    /// <signature>#37 (Lsystem/Array;J)V (LSystem/Array;J)V</signature>
    public final native void CopyTo(system.Array array, long index);
    
    /// <signature>#38 ()I ()I</signature>
    public native int getCount();
    
    /// <signature>#39 ()Z ()Z</signature>
    public native boolean getIsFixedSize();
    
    /// <signature>#40 ()Z ()Z</signature>
    public native boolean getIsReadOnly();
    
    /// <signature>#41 ()Z ()Z</signature>
    public native boolean getIsSynchronized();
    
    /// <signature>#42 (I)Ljava/lang/Object; (I)Ljava/lang/Object;</signature>
    public native java.lang.Object getItem(int index);
    
    /// <signature>#43 ()I ()I</signature>
    public final native int getLength();
    
    /// <signature>#44 ()J ()J</signature>
    public final native long getLongLength();
    
    /// <signature>#45 ()I ()I</signature>
    public final native int getRank();
    
    /// <signature>#46 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getSyncRoot();
    
    /// <signature>#47 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
    public native system.collections.IEnumerator GetEnumerator();
    
    /// <signature>#48 (I)I (I)I</signature>
    public final native int GetLength(int dimension);
    
    /// <signature>#49 (I)J (I)J</signature>
    public final native long GetLongLength(int dimension);
    
    /// <signature>#50 (I)I (I)I</signature>
    public final native int GetLowerBound(int dimension);
    
    /// <signature>#51 (I)I (I)I</signature>
    public final native int GetUpperBound(int dimension);
    
    /// <signature>#52 ([I)Ljava/lang/Object; ([I)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(int[] indices);
    
    /// <signature>#53 ([J)Ljava/lang/Object; ([J)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(long[] indices);
    
    /// <signature>#54 (I)Ljava/lang/Object; (I)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(int index);
    
    /// <signature>#55 (II)Ljava/lang/Object; (II)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(int index1, int index2);
    
    /// <signature>#56 (III)Ljava/lang/Object; (III)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(int index1, int index2, int index3);
    
    /// <signature>#57 (J)Ljava/lang/Object; (J)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(long index);
    
    /// <signature>#58 (JJ)Ljava/lang/Object; (JJ)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(long index1, long index2);
    
    /// <signature>#59 (JJJ)Ljava/lang/Object; (JJJ)Ljava/lang/Object;</signature>
    public final native java.lang.Object GetValue(long index1, long index2, long index3);
    
    /// <signature>#60 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int IndexOf(java.lang.Object value);
    
    /// <signature>#61 ()V ()V</signature>
    public final native void Initialize();
    
    /// <signature>#62 (ILjava/lang/Object;)V (ILjava/lang/Object;)V</signature>
    public native void Insert(int index, java.lang.Object value);
    
    /// <signature>#63 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    public native void Remove(java.lang.Object value);
    
    /// <signature>#64 (I)V (I)V</signature>
    public native void RemoveAt(int index);
    
    /// <signature>#65 (ILjava/lang/Object;)V (ILjava/lang/Object;)V</signature>
    public native void setItem(int index, java.lang.Object value);
    
    /// <signature>#66 (Ljava/lang/Object;[I)V (Ljava/lang/Object;[I)V</signature>
    public final native void SetValue(java.lang.Object value, int[] indices);
    
    /// <signature>#67 (Ljava/lang/Object;[J)V (Ljava/lang/Object;[J)V</signature>
    public final native void SetValue(java.lang.Object value, long[] indices);
    
    /// <signature>#68 (Ljava/lang/Object;I)V (Ljava/lang/Object;I)V</signature>
    public final native void SetValue(java.lang.Object value, int index);
    
    /// <signature>#69 (Ljava/lang/Object;II)V (Ljava/lang/Object;II)V</signature>
    public final native void SetValue(java.lang.Object value, int index1, int index2);
    
    /// <signature>#70 (Ljava/lang/Object;III)V (Ljava/lang/Object;III)V</signature>
    public final native void SetValue(java.lang.Object value, int index1, int index2, int index3);
    
    /// <signature>#71 (Ljava/lang/Object;J)V (Ljava/lang/Object;J)V</signature>
    public final native void SetValue(java.lang.Object value, long index);
    
    /// <signature>#72 (Ljava/lang/Object;JJ)V (Ljava/lang/Object;JJ)V</signature>
    public final native void SetValue(java.lang.Object value, long index1, long index2);
    
    /// <signature>#73 (Ljava/lang/Object;JJJ)V (Ljava/lang/Object;JJJ)V</signature>
    public final native void SetValue(java.lang.Object value, long index1, long index2, long index3);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Array_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.Array.class, system.Array.class, system.Array.class, new system.Array.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
