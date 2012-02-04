// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.ICustomAttributeProvider_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public interface ICustomAttributeProvider
// <j4ni-ICustomAttributeProvider>
// put user interfaces here
// </j4ni-ICustomAttributeProvider>
{
    // <j4nb-ICustomAttributeProvider> 
    // put user members here
    // </j4nb-ICustomAttributeProvider>
    
    /// <signature>#0 (Z)[Ljava/lang/Object; (Z)[Ljava/lang/Object;</signature>
    java.lang.Object[] GetCustomAttributes(boolean inherit);
    
    /// <signature>#1 (Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Ljava/lang/Object;</signature>
    java.lang.Object[] GetCustomAttributes(system.Type attributeType, boolean inherit);
    
    /// <signature>#2 (Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
    boolean IsDefined(system.Type attributeType, boolean inherit);
}
