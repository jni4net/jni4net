// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Char.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class Char extends system.ValueType implements system.nongeneric.IComparable, system.IConvertible
// <j4ni-Char>
// put user interfaces here
// </j4ni-Char>
{
    // <j4nb-Char> 
    public Char(char value) {
        super(net.sf.jni4net.core.Registry.CreateBoxedChar(value), (net.sf.jni4net.core.ClrInstanceInfo)null);
    }

    public char value() {
        return net.sf.jni4net.core.Registry.UnboxChar(j4n_clrHandle);
    }
    // </j4nb-Char>
    
    private Char(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Char(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Char.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (I)Ljava/lang/String; (I)Ljava/lang/String;</signature>
    static public native java.lang.String ConvertFromUtf32(int utf32);
    
    /// <signature>#1 (CC)I (CC)I</signature>
    static public native int ConvertToUtf32(char highSurrogate, char lowSurrogate);
    
    /// <signature>#2 (Ljava/lang/String;I)I (Ljava/lang/String;I)I</signature>
    static public native int ConvertToUtf32(java.lang.String s, int index);
    
    /// <signature>#3 (C)D (C)D</signature>
    static public native double GetNumericValue(char c);
    
    /// <signature>#4 (Ljava/lang/String;I)D (Ljava/lang/String;I)D</signature>
    static public native double GetNumericValue(java.lang.String s, int index);
    
    /// <signature>#5 (C)Lsystem/Enum; (C)LSystem/Enum;</signature>
    static public native system.Enum GetUnicodeCategory(char c);
    
    /// <signature>#6 (Ljava/lang/String;I)Lsystem/Enum; (Ljava/lang/String;I)LSystem/Enum;</signature>
    static public native system.Enum GetUnicodeCategory(java.lang.String s, int index);
    
    /// <signature>#7 (C)Z (C)Z</signature>
    static public native boolean IsControl(char c);
    
    /// <signature>#8 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsControl(java.lang.String s, int index);
    
    /// <signature>#9 (C)Z (C)Z</signature>
    static public native boolean IsDigit(char c);
    
    /// <signature>#10 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsDigit(java.lang.String s, int index);
    
    /// <signature>#11 (C)Z (C)Z</signature>
    static public native boolean IsHighSurrogate(char c);
    
    /// <signature>#12 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsHighSurrogate(java.lang.String s, int index);
    
    /// <signature>#13 (C)Z (C)Z</signature>
    static public native boolean IsLetter(char c);
    
    /// <signature>#14 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsLetter(java.lang.String s, int index);
    
    /// <signature>#15 (C)Z (C)Z</signature>
    static public native boolean IsLetterOrDigit(char c);
    
    /// <signature>#16 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsLetterOrDigit(java.lang.String s, int index);
    
    /// <signature>#17 (C)Z (C)Z</signature>
    static public native boolean IsLower(char c);
    
    /// <signature>#18 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsLower(java.lang.String s, int index);
    
    /// <signature>#19 (C)Z (C)Z</signature>
    static public native boolean IsLowSurrogate(char c);
    
    /// <signature>#20 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsLowSurrogate(java.lang.String s, int index);
    
    /// <signature>#21 (C)Z (C)Z</signature>
    static public native boolean IsNumber(char c);
    
    /// <signature>#22 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsNumber(java.lang.String s, int index);
    
    /// <signature>#23 (C)Z (C)Z</signature>
    static public native boolean IsPunctuation(char c);
    
    /// <signature>#24 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsPunctuation(java.lang.String s, int index);
    
    /// <signature>#25 (C)Z (C)Z</signature>
    static public native boolean IsSeparator(char c);
    
    /// <signature>#26 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsSeparator(java.lang.String s, int index);
    
    /// <signature>#27 (C)Z (C)Z</signature>
    static public native boolean IsSurrogate(char c);
    
    /// <signature>#28 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsSurrogate(java.lang.String s, int index);
    
    /// <signature>#29 (CC)Z (CC)Z</signature>
    static public native boolean IsSurrogatePair(char highSurrogate, char lowSurrogate);
    
    /// <signature>#30 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsSurrogatePair(java.lang.String s, int index);
    
    /// <signature>#31 (C)Z (C)Z</signature>
    static public native boolean IsSymbol(char c);
    
    /// <signature>#32 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsSymbol(java.lang.String s, int index);
    
    /// <signature>#33 (C)Z (C)Z</signature>
    static public native boolean IsUpper(char c);
    
    /// <signature>#34 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsUpper(java.lang.String s, int index);
    
    /// <signature>#35 (C)Z (C)Z</signature>
    static public native boolean IsWhiteSpace(char c);
    
    /// <signature>#36 (Ljava/lang/String;I)Z (Ljava/lang/String;I)Z</signature>
    static public native boolean IsWhiteSpace(java.lang.String s, int index);
    
    /// <signature>#37 ()C ()C</signature>
    static public native char MaxValue();
    
    /// <signature>#38 ()C ()C</signature>
    static public native char MinValue();
    
    /// <signature>#39 (Ljava/lang/String;)C (Ljava/lang/String;)C</signature>
    static public native char Parse(java.lang.String s);
    
    /// <signature>#40 (C)C (C)C</signature>
    static public native char ToLower(char c);
    
    /// <signature>#41 (CLsystem/ICloneable;)C (CLSystem/ICloneable;)C</signature>
    static public native char ToLower(char c, system.ICloneable culture);
    
    /// <signature>#42 (C)C (C)C</signature>
    static public native char ToLowerInvariant(char c);
    
    /// <signature>#43 (C)Ljava/lang/String; (C)Ljava/lang/String;</signature>
    static public native java.lang.String ToString(char c);
    
    /// <signature>#44 (C)C (C)C</signature>
    static public native char ToUpper(char c);
    
    /// <signature>#45 (CLsystem/ICloneable;)C (CLSystem/ICloneable;)C</signature>
    static public native char ToUpper(char c, system.ICloneable culture);
    
    /// <signature>#46 (C)C (C)C</signature>
    static public native char ToUpperInvariant(char c);
    
    /// <signature>#47 (Ljava/lang/String;Lnet/sf/jni4net/Out;)Z (Ljava/lang/String;Lnet/sf/jni4net/OutC;)Z</signature>
    static public native boolean TryParse(java.lang.String s, net.sf.jni4net.Out<system.Char> result);
    
    /// <signature>#48 (C)I (C)I</signature>
    public native int CompareTo(char value);
    
    /// <signature>#49 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int CompareTo(java.lang.Object value);
    
    /// <signature>#50 (C)Z (C)Z</signature>
    public native boolean Equals(char obj);
    
    /// <signature>#51 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetTypeCode();
    
    /// <signature>#52 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#53 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#54 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    public native char ToChar(system.IFormatProvider provider);
    
    /// <signature>#55 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#56 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#57 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    public native double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#58 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#59 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#60 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#61 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    public native byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#62 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    public native float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#63 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#64 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    public native java.lang.Object ToType(system.Type type, system.IFormatProvider provider);
    
    /// <signature>#65 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    public native short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#66 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    public native int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#67 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    public native long ToUInt64(system.IFormatProvider provider);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Char_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.Char.class, system.Char.class, system.Char.class, new system.Char.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
