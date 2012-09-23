// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.String.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class String extends system.Object implements system.nongeneric.IComparable, system.ICloneable, system.IConvertible, system.collections.IEnumerable
// <j4ni-String>
// put user interfaces here
// </j4ni-String>
{
    // <j4nb-String> 
    public String(java.lang.String value) {
        super(net.sf.jni4net.core.Registry.CreateBoxedString(value), (net.sf.jni4net.core.ClrInstanceInfo)null);
    }

    public java.lang.String value() {
        return net.sf.jni4net.core.Registry.UnboxString(j4n_clrHandle);
    }
    // </j4nb-String>
    
    private String(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.String(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.String.j4n_ProxyInit(null);
    }
    
    public String(char[] value) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(value);
    }
    
    /// <signature>#0 ([C)V ([C)V</signature>
    private native long j4n_constructor(char[] value);
    
    public String(char[] value, int startIndex, int length) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(value, startIndex, length);
    }
    
    /// <signature>#1 ([CII)V ([CII)V</signature>
    private native long j4n_constructor(char[] value, int startIndex, int length);
    
    public String(char c, int count) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(c, count);
    }
    
    /// <signature>#2 (CI)V (CI)V</signature>
    private native long j4n_constructor(char c, int count);
    
    /// <signature>#3 (Ljava/lang/String;ILjava/lang/String;II)I (Ljava/lang/String;ILjava/lang/String;II)I</signature>
    static public native int Compare(java.lang.String strA, int indexA, java.lang.String strB, int indexB, int length);
    
    /// <signature>#4 (Ljava/lang/String;ILjava/lang/String;IIZ)I (Ljava/lang/String;ILjava/lang/String;IIZ)I</signature>
    static public native int Compare(java.lang.String strA, int indexA, java.lang.String strB, int indexB, int length, boolean ignoreCase);
    
    /// <signature>#5 (Ljava/lang/String;ILjava/lang/String;IIZLsystem/ICloneable;)I (Ljava/lang/String;ILjava/lang/String;IIZLSystem/ICloneable;)I</signature>
    static public native int Compare(java.lang.String strA, int indexA, java.lang.String strB, int indexB, int length, boolean ignoreCase, system.ICloneable culture);
    
    /// <signature>#6 (Ljava/lang/String;ILjava/lang/String;IILsystem/ICloneable;Lsystem/Enum;)I (Ljava/lang/String;ILjava/lang/String;IILSystem/ICloneable;LSystem/Enum;)I</signature>
    static public native int Compare(java.lang.String strA, int indexA, java.lang.String strB, int indexB, int length, system.ICloneable culture, system.Enum options);
    
    /// <signature>#7 (Ljava/lang/String;ILjava/lang/String;IILsystem/Enum;)I (Ljava/lang/String;ILjava/lang/String;IILSystem/Enum;)I</signature>
    static public native int Compare(java.lang.String strA, int indexA, java.lang.String strB, int indexB, int length, system.Enum comparisonType);
    
    /// <signature>#8 (Ljava/lang/String;Ljava/lang/String;)I (Ljava/lang/String;Ljava/lang/String;)I</signature>
    static public native int Compare(java.lang.String strA, java.lang.String strB);
    
    /// <signature>#9 (Ljava/lang/String;Ljava/lang/String;Z)I (Ljava/lang/String;Ljava/lang/String;Z)I</signature>
    static public native int Compare(java.lang.String strA, java.lang.String strB, boolean ignoreCase);
    
    /// <signature>#10 (Ljava/lang/String;Ljava/lang/String;ZLsystem/ICloneable;)I (Ljava/lang/String;Ljava/lang/String;ZLSystem/ICloneable;)I</signature>
    static public native int Compare(java.lang.String strA, java.lang.String strB, boolean ignoreCase, system.ICloneable culture);
    
    /// <signature>#11 (Ljava/lang/String;Ljava/lang/String;Lsystem/ICloneable;Lsystem/Enum;)I (Ljava/lang/String;Ljava/lang/String;LSystem/ICloneable;LSystem/Enum;)I</signature>
    static public native int Compare(java.lang.String strA, java.lang.String strB, system.ICloneable culture, system.Enum options);
    
    /// <signature>#12 (Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)I (Ljava/lang/String;Ljava/lang/String;LSystem/Enum;)I</signature>
    static public native int Compare(java.lang.String strA, java.lang.String strB, system.Enum comparisonType);
    
    /// <signature>#13 (Ljava/lang/String;ILjava/lang/String;II)I (Ljava/lang/String;ILjava/lang/String;II)I</signature>
    static public native int CompareOrdinal(java.lang.String strA, int indexA, java.lang.String strB, int indexB, int length);
    
    /// <signature>#14 (Ljava/lang/String;Ljava/lang/String;)I (Ljava/lang/String;Ljava/lang/String;)I</signature>
    static public native int CompareOrdinal(java.lang.String strA, java.lang.String strB);
    
    /// <signature>#15 ([Ljava/lang/Object;)Ljava/lang/String; ([Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.Object[] args);
    
    /// <signature>#16 ([Ljava/lang/String;)Ljava/lang/String; ([Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.String[] values);
    
    /// <signature>#17 (Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.Object arg0);
    
    /// <signature>#18 (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.Object arg0, java.lang.Object arg1);
    
    /// <signature>#19 (Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
    
    /// <signature>#20 (Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2, java.lang.Object arg3);
    
    /// <signature>#21 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.String str0, java.lang.String str1);
    
    /// <signature>#22 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.String str0, java.lang.String str1, java.lang.String str2);
    
    /// <signature>#23 (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String Concat(java.lang.String str0, java.lang.String str1, java.lang.String str2, java.lang.String str3);
    
    /// <signature>#24 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String Copy(java.lang.String str);
    
    /// <signature>#25 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String Empty();
    
    /// <signature>#26 (Ljava/lang/String;Ljava/lang/String;)Z (Ljava/lang/String;Ljava/lang/String;)Z</signature>
    static public native boolean Equals(java.lang.String a, java.lang.String b);
    
    /// <signature>#27 (Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)Z (Ljava/lang/String;Ljava/lang/String;LSystem/Enum;)Z</signature>
    static public native boolean Equals(java.lang.String a, java.lang.String b, system.Enum comparisonType);
    
    /// <signature>#28 (Lsystem/IFormatProvider;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String; (LSystem/IFormatProvider;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Format(system.IFormatProvider provider, java.lang.String format, java.lang.Object[] args);
    
    /// <signature>#29 (Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Format(java.lang.String format, java.lang.Object[] args);
    
    /// <signature>#30 (Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Format(java.lang.String format, java.lang.Object arg0);
    
    /// <signature>#31 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Format(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1);
    
    /// <signature>#32 (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;</signature>
    static public native java.lang.String Format(java.lang.String format, java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
    
    /// <signature>#33 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String Intern(java.lang.String str);
    
    /// <signature>#34 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String IsInterned(java.lang.String str);
    
    /// <signature>#35 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
    static public native boolean IsNullOrEmpty(java.lang.String value);
    
    /// <signature>#36 (Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String Join(java.lang.String separator, java.lang.String[] value);
    
    /// <signature>#37 (Ljava/lang/String;[Ljava/lang/String;II)Ljava/lang/String; (Ljava/lang/String;[Ljava/lang/String;II)Ljava/lang/String;</signature>
    static public native java.lang.String Join(java.lang.String separator, java.lang.String[] value, int startIndex, int count);
    
    /// <signature>#38 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object Clone();
    
    /// <signature>#39 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#40 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
    public native int CompareTo(java.lang.String strB);
    
    /// <signature>#41 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
    public final native boolean Contains(java.lang.String value);
    
    /// <signature>#42 (I[CII)V (I[CII)V</signature>
    public final native void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);
    
    /// <signature>#43 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
    public final native boolean EndsWith(java.lang.String value);
    
    /// <signature>#44 (Ljava/lang/String;ZLsystem/ICloneable;)Z (Ljava/lang/String;ZLSystem/ICloneable;)Z</signature>
    public final native boolean EndsWith(java.lang.String value, boolean ignoreCase, system.ICloneable culture);
    
    /// <signature>#45 (Ljava/lang/String;Lsystem/Enum;)Z (Ljava/lang/String;LSystem/Enum;)Z</signature>
    public final native boolean EndsWith(java.lang.String value, system.Enum comparisonType);
    
    /// <signature>#46 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
    public native boolean Equals(java.lang.String value);
    
    /// <signature>#47 (Ljava/lang/String;Lsystem/Enum;)Z (Ljava/lang/String;LSystem/Enum;)Z</signature>
    public final native boolean Equals(java.lang.String value, system.Enum comparisonType);
    
    /// <signature>#48 (I)C (I)C</signature>
    public final native char getChars(int index);
    
    /// <signature>#49 ()I ()I</signature>
    public final native int getLength();
    
    /// <signature>#50 ()Lsystem/CharEnumerator; ()LSystem/CharEnumerator;</signature>
    public final native system.CharEnumerator GetEnumerator();
    
    /// <signature>#51 ()Lsystem/collections/IEnumerator; ()LSystem/Collections/IEnumerator;</signature>
    public native system.collections.IEnumerator GetEnumerator_IEnumerable65();
    
    /// <signature>#52 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetTypeCode();
    
    /// <signature>#53 (C)I (C)I</signature>
    public final native int IndexOf(char value);
    
    /// <signature>#54 (CI)I (CI)I</signature>
    public final native int IndexOf(char value, int startIndex);
    
    /// <signature>#55 (CII)I (CII)I</signature>
    public final native int IndexOf(char value, int startIndex, int count);
    
    /// <signature>#56 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
    public final native int IndexOf(java.lang.String value);
    
    /// <signature>#57 (Ljava/lang/String;I)I (Ljava/lang/String;I)I</signature>
    public final native int IndexOf(java.lang.String value, int startIndex);
    
    /// <signature>#58 (Ljava/lang/String;II)I (Ljava/lang/String;II)I</signature>
    public final native int IndexOf(java.lang.String value, int startIndex, int count);
    
    /// <signature>#59 (Ljava/lang/String;IILsystem/Enum;)I (Ljava/lang/String;IILSystem/Enum;)I</signature>
    public final native int IndexOf(java.lang.String value, int startIndex, int count, system.Enum comparisonType);
    
    /// <signature>#60 (Ljava/lang/String;ILsystem/Enum;)I (Ljava/lang/String;ILSystem/Enum;)I</signature>
    public final native int IndexOf(java.lang.String value, int startIndex, system.Enum comparisonType);
    
    /// <signature>#61 (Ljava/lang/String;Lsystem/Enum;)I (Ljava/lang/String;LSystem/Enum;)I</signature>
    public final native int IndexOf(java.lang.String value, system.Enum comparisonType);
    
    /// <signature>#62 ([C)I ([C)I</signature>
    public final native int IndexOfAny(char[] anyOf);
    
    /// <signature>#63 ([CI)I ([CI)I</signature>
    public final native int IndexOfAny(char[] anyOf, int startIndex);
    
    /// <signature>#64 ([CII)I ([CII)I</signature>
    public final native int IndexOfAny(char[] anyOf, int startIndex, int count);
    
    /// <signature>#65 (ILjava/lang/String;)Ljava/lang/String; (ILjava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String Insert(int startIndex, java.lang.String value);
    
    /// <signature>#66 ()Z ()Z</signature>
    public final native boolean IsNormalized();
    
    /// <signature>#67 (Lsystem/Enum;)Z (LSystem/Enum;)Z</signature>
    public final native boolean IsNormalized(system.Enum normalizationForm);
    
    /// <signature>#68 (C)I (C)I</signature>
    public final native int LastIndexOf(char value);
    
    /// <signature>#69 (CI)I (CI)I</signature>
    public final native int LastIndexOf(char value, int startIndex);
    
    /// <signature>#70 (CII)I (CII)I</signature>
    public final native int LastIndexOf(char value, int startIndex, int count);
    
    /// <signature>#71 (Ljava/lang/String;)I (Ljava/lang/String;)I</signature>
    public final native int LastIndexOf(java.lang.String value);
    
    /// <signature>#72 (Ljava/lang/String;I)I (Ljava/lang/String;I)I</signature>
    public final native int LastIndexOf(java.lang.String value, int startIndex);
    
    /// <signature>#73 (Ljava/lang/String;II)I (Ljava/lang/String;II)I</signature>
    public final native int LastIndexOf(java.lang.String value, int startIndex, int count);
    
    /// <signature>#74 (Ljava/lang/String;IILsystem/Enum;)I (Ljava/lang/String;IILSystem/Enum;)I</signature>
    public final native int LastIndexOf(java.lang.String value, int startIndex, int count, system.Enum comparisonType);
    
    /// <signature>#75 (Ljava/lang/String;ILsystem/Enum;)I (Ljava/lang/String;ILSystem/Enum;)I</signature>
    public final native int LastIndexOf(java.lang.String value, int startIndex, system.Enum comparisonType);
    
    /// <signature>#76 (Ljava/lang/String;Lsystem/Enum;)I (Ljava/lang/String;LSystem/Enum;)I</signature>
    public final native int LastIndexOf(java.lang.String value, system.Enum comparisonType);
    
    /// <signature>#77 ([C)I ([C)I</signature>
    public final native int LastIndexOfAny(char[] anyOf);
    
    /// <signature>#78 ([CI)I ([CI)I</signature>
    public final native int LastIndexOfAny(char[] anyOf, int startIndex);
    
    /// <signature>#79 ([CII)I ([CII)I</signature>
    public final native int LastIndexOfAny(char[] anyOf, int startIndex, int count);
    
    /// <signature>#80 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String Normalize();
    
    /// <signature>#81 (Lsystem/Enum;)Ljava/lang/String; (LSystem/Enum;)Ljava/lang/String;</signature>
    public final native java.lang.String Normalize(system.Enum normalizationForm);
    
    /// <signature>#82 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
    public final native java.lang.String PadLeft(int totalWidth);
    
    /// <signature>#83 (IC)Ljava/lang/String; (IC)Ljava/lang/String;</signature>
    public final native java.lang.String PadLeft(int totalWidth, char paddingChar);
    
    /// <signature>#84 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
    public final native java.lang.String PadRight(int totalWidth);
    
    /// <signature>#85 (IC)Ljava/lang/String; (IC)Ljava/lang/String;</signature>
    public final native java.lang.String PadRight(int totalWidth, char paddingChar);
    
    /// <signature>#86 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
    public final native java.lang.String Remove(int startIndex);
    
    /// <signature>#87 (II)Ljava/lang/String; (II)Ljava/lang/String;</signature>
    public final native java.lang.String Remove(int startIndex, int count);
    
    /// <signature>#88 (CC)Ljava/lang/String; (CC)Ljava/lang/String;</signature>
    public final native java.lang.String Replace(char oldChar, char newChar);
    
    /// <signature>#89 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String Replace(java.lang.String oldValue, java.lang.String newValue);
    
    /// <signature>#90 ([C)[Ljava/lang/String; ([C)[Ljava/lang/String;</signature>
    public final native java.lang.String[] Split(char[] separator);
    
    /// <signature>#91 ([CI)[Ljava/lang/String; ([CI)[Ljava/lang/String;</signature>
    public final native java.lang.String[] Split(char[] separator, int count);
    
    /// <signature>#92 ([CILsystem/Enum;)[Ljava/lang/String; ([CILSystem/Enum;)[Ljava/lang/String;</signature>
    public final native java.lang.String[] Split(char[] separator, int count, system.Enum options);
    
    /// <signature>#93 ([CLsystem/Enum;)[Ljava/lang/String; ([CLSystem/Enum;)[Ljava/lang/String;</signature>
    public final native java.lang.String[] Split(char[] separator, system.Enum options);
    
    /// <signature>#94 ([Ljava/lang/String;ILsystem/Enum;)[Ljava/lang/String; ([Ljava/lang/String;ILSystem/Enum;)[Ljava/lang/String;</signature>
    public final native java.lang.String[] Split(java.lang.String[] separator, int count, system.Enum options);
    
    /// <signature>#95 ([Ljava/lang/String;Lsystem/Enum;)[Ljava/lang/String; ([Ljava/lang/String;LSystem/Enum;)[Ljava/lang/String;</signature>
    public final native java.lang.String[] Split(java.lang.String[] separator, system.Enum options);
    
    /// <signature>#96 (Ljava/lang/String;)Z (Ljava/lang/String;)Z</signature>
    public final native boolean StartsWith(java.lang.String value);
    
    /// <signature>#97 (Ljava/lang/String;ZLsystem/ICloneable;)Z (Ljava/lang/String;ZLSystem/ICloneable;)Z</signature>
    public final native boolean StartsWith(java.lang.String value, boolean ignoreCase, system.ICloneable culture);
    
    /// <signature>#98 (Ljava/lang/String;Lsystem/Enum;)Z (Ljava/lang/String;LSystem/Enum;)Z</signature>
    public final native boolean StartsWith(java.lang.String value, system.Enum comparisonType);
    
    /// <signature>#99 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
    public final native java.lang.String Substring(int startIndex);
    
    /// <signature>#100 (II)Ljava/lang/String; (II)Ljava/lang/String;</signature>
    public final native java.lang.String Substring(int startIndex, int length);
    
    /// <signature>#101 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#102 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#103 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    public native char ToChar(system.IFormatProvider provider);
    
    /// <signature>#104 ()[C ()[C</signature>
    public final native char[] ToCharArray();
    
    /// <signature>#105 (II)[C (II)[C</signature>
    public final native char[] ToCharArray(int startIndex, int length);
    
    /// <signature>#106 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#107 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#108 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    public native double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#109 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#110 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#111 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#112 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String ToLower();
    
    /// <signature>#113 (Lsystem/ICloneable;)Ljava/lang/String; (LSystem/ICloneable;)Ljava/lang/String;</signature>
    public final native java.lang.String ToLower(system.ICloneable culture);
    
    /// <signature>#114 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String ToLowerInvariant();
    
    /// <signature>#115 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#116 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    public native float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#117 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#118 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    public native java.lang.Object ToType(system.Type type, system.IFormatProvider provider);
    
    /// <signature>#119 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#120 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#121 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToUInt64(system.IFormatProvider provider);
    
    /// <signature>#122 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String ToUpper();
    
    /// <signature>#123 (Lsystem/ICloneable;)Ljava/lang/String; (LSystem/ICloneable;)Ljava/lang/String;</signature>
    public final native java.lang.String ToUpper(system.ICloneable culture);
    
    /// <signature>#124 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String ToUpperInvariant();
    
    /// <signature>#125 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String Trim();
    
    /// <signature>#126 ([C)Ljava/lang/String; ([C)Ljava/lang/String;</signature>
    public final native java.lang.String Trim(char[] trimChars);
    
    /// <signature>#127 ([C)Ljava/lang/String; ([C)Ljava/lang/String;</signature>
    public final native java.lang.String TrimEnd(char[] trimChars);
    
    /// <signature>#128 ([C)Ljava/lang/String; ([C)Ljava/lang/String;</signature>
    public final native java.lang.String TrimStart(char[] trimChars);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.String_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.String.class, system.String.class, system.String.class, new system.String.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
