// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.collections;

@net.sf.jni4net.attributes.J4NProxy(system.collections.IList_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public interface IList extends system.collections.ICollection
// <j4ni-IList>
// put user interfaces here
// </j4ni-IList>
{
    // <j4nb-IList> 
    // put user members here
    // </j4nb-IList>
    
    /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    int Add(java.lang.Object value);
    
    /// <signature>#1 ()V ()V</signature>
    void Clear();
    
    /// <signature>#2 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    boolean Contains(java.lang.Object value);
    
    /// <signature>#3 ()Z ()Z</signature>
    boolean getIsFixedSize();
    
    /// <signature>#4 ()Z ()Z</signature>
    boolean getIsReadOnly();
    
    /// <signature>#5 (I)Ljava/lang/Object; (I)Ljava/lang/Object;</signature>
    java.lang.Object getItem(int index);
    
    /// <signature>#6 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    int IndexOf(java.lang.Object value);
    
    /// <signature>#7 (ILjava/lang/Object;)V (ILjava/lang/Object;)V</signature>
    void Insert(int index, java.lang.Object value);
    
    /// <signature>#8 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    void Remove(java.lang.Object value);
    
    /// <signature>#9 (I)V (I)V</signature>
    void RemoveAt(int index);
    
    /// <signature>#10 (ILjava/lang/Object;)V (ILjava/lang/Object;)V</signature>
    void setItem(int index, java.lang.Object value);
}
