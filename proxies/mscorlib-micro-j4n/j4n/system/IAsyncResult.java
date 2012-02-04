// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.IAsyncResult_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public interface IAsyncResult
// <j4ni-IAsyncResult>
// put user interfaces here
// </j4ni-IAsyncResult>
{
    // <j4nb-IAsyncResult> 
    // put user members here
    // </j4nb-IAsyncResult>
    
    /// <signature>#0 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    java.lang.Object getAsyncState();
    
    /// <signature>#1 ()Lsystem/MarshalByRefObject; ()LSystem/MarshalByRefObject;</signature>
    system.MarshalByRefObject getAsyncWaitHandle();
    
    /// <signature>#2 ()Z ()Z</signature>
    boolean getCompletedSynchronously();
    
    /// <signature>#3 ()Z ()Z</signature>
    boolean getIsCompleted();
}
