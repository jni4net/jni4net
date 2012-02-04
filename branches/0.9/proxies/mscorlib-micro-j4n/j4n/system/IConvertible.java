// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.IConvertible_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public interface IConvertible
// <j4ni-IConvertible>
// put user interfaces here
// </j4ni-IConvertible>
{
    // <j4nb-IConvertible> 
    // put user members here
    // </j4nb-IConvertible>
    
    /// <signature>#0 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    system.Enum GetTypeCode();
    
    /// <signature>#1 (Lsystem/IFormatProvider;)Z (LSystem/IFormatProvider;)Z</signature>
    boolean ToBoolean(system.IFormatProvider provider);
    
    /// <signature>#2 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    byte ToByte(system.IFormatProvider provider);
    
    /// <signature>#3 (Lsystem/IFormatProvider;)C (LSystem/IFormatProvider;)C</signature>
    char ToChar(system.IFormatProvider provider);
    
    /// <signature>#4 (Lsystem/IFormatProvider;)Lsystem/DateTime; (LSystem/IFormatProvider;)LSystem/DateTime;</signature>
    system.DateTime ToDateTime(system.IFormatProvider provider);
    
    /// <signature>#5 (Lsystem/IFormatProvider;)Lsystem/Decimal; (LSystem/IFormatProvider;)LSystem/Decimal;</signature>
    system.Decimal ToDecimal(system.IFormatProvider provider);
    
    /// <signature>#6 (Lsystem/IFormatProvider;)D (LSystem/IFormatProvider;)D</signature>
    double ToDouble(system.IFormatProvider provider);
    
    /// <signature>#7 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    short ToInt16(system.IFormatProvider provider);
    
    /// <signature>#8 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    int ToInt32(system.IFormatProvider provider);
    
    /// <signature>#9 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    long ToInt64(system.IFormatProvider provider);
    
    /// <signature>#10 (Lsystem/IFormatProvider;)B (LSystem/IFormatProvider;)B</signature>
    byte ToSByte(system.IFormatProvider provider);
    
    /// <signature>#11 (Lsystem/IFormatProvider;)F (LSystem/IFormatProvider;)F</signature>
    float ToSingle(system.IFormatProvider provider);
    
    /// <signature>#12 (Lsystem/IFormatProvider;)Ljava/lang/String; (LSystem/IFormatProvider;)Ljava/lang/String;</signature>
    java.lang.String ToString(system.IFormatProvider provider);
    
    /// <signature>#13 (Lsystem/Type;Lsystem/IFormatProvider;)Ljava/lang/Object; (LSystem/Type;LSystem/IFormatProvider;)Ljava/lang/Object;</signature>
    java.lang.Object ToType(system.Type conversionType, system.IFormatProvider provider);
    
    /// <signature>#14 (Lsystem/IFormatProvider;)S (LSystem/IFormatProvider;)S</signature>
    short ToUInt16(system.IFormatProvider provider);
    
    /// <signature>#15 (Lsystem/IFormatProvider;)I (LSystem/IFormatProvider;)I</signature>
    int ToUInt32(system.IFormatProvider provider);
    
    /// <signature>#16 (Lsystem/IFormatProvider;)J (LSystem/IFormatProvider;)J</signature>
    long ToUInt64(system.IFormatProvider provider);
}
