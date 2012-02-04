// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.IDictionary_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public interface IDictionary extends system.collections.ICollection
// <j4ni-IDictionary>
// put user interfaces here
// </j4ni-IDictionary>
{
    // <j4nb-IDictionary> 
    // put user members here
    // </j4nb-IDictionary>
    
    /// <signature>#0 (Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    void Add(java.lang.Object key, java.lang.Object value);
    
    /// <signature>#1 ()V ()V</signature>
    void Clear();
    
    /// <signature>#2 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    boolean Contains(java.lang.Object key);
    
    /// <signature>#3 ()Z ()Z</signature>
    boolean getIsFixedSize();
    
    /// <signature>#4 ()Z ()Z</signature>
    boolean getIsReadOnly();
    
    /// <signature>#5 (Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;)Ljava/lang/Object;</signature>
    java.lang.Object getItem(java.lang.Object key);
    
    /// <signature>#6 ()Lsystem/collections/ICollection; ()LSystem/Collections/ICollection;</signature>
    system.collections.ICollection getKeys();
    
    /// <signature>#7 ()Lsystem/collections/ICollection; ()LSystem/Collections/ICollection;</signature>
    system.collections.ICollection getValues();
    
    /// <signature>#8 ()Lsystem/collections/IDictionaryEnumerator; ()LSystem/Collections/IDictionaryEnumerator;</signature>
    system.collections.IDictionaryEnumerator GetEnumerator();
    
    /// <signature>#9 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    void Remove(java.lang.Object key);
    
    /// <signature>#10 (Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    void setItem(java.lang.Object key, java.lang.Object value);
}
