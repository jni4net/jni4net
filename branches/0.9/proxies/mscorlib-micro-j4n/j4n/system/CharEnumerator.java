// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.CharEnumerator.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class CharEnumerator extends system.Object implements system.ICloneable, system.IDisposable, system.collections.IEnumerator
// <j4ni-CharEnumerator>
// put user interfaces here
// </j4ni-CharEnumerator>
{
    // <j4nb-CharEnumerator> 
    // put user members here
    // </j4nb-CharEnumerator>
    
    private CharEnumerator(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.CharEnumerator(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.CharEnumerator.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object Clone();
    
    /// <signature>#1 ()V ()V</signature>
    public native void Dispose();
    
    /// <signature>#2 ()Ljava/lang/Character; ()Ljava/lang/Character;</signature>
    public native java.lang.Character getCurrent();
    
    /// <signature>#3 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getCurrent_IEnumerator17();
    
    /// <signature>#4 ()Z ()Z</signature>
    public native boolean MoveNext();
    
    /// <signature>#5 ()V ()V</signature>
    public native void Reset();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.CharEnumerator_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.CharEnumerator.class, system.CharEnumerator.class, system.CharEnumerator.class, new system.CharEnumerator.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
