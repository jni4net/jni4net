// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.ICollection_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public interface ICollection extends system.collections.IEnumerable
// <j4ni-ICollection>
// put user interfaces here
// </j4ni-ICollection>
{
    // <j4nb-ICollection> 
    // put user members here
    // </j4nb-ICollection>
    
    /// <signature>#0 (Lsystem/Array;I)V (LSystem/Array;I)V</signature>
    void CopyTo(system.Array array, int index);
    
    /// <signature>#1 ()I ()I</signature>
    int getCount();
    
    /// <signature>#2 ()Z ()Z</signature>
    boolean getIsSynchronized();
    
    /// <signature>#3 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    java.lang.Object getSyncRoot();
}
