// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.runtime.serialization;

@net.sf.jni4net.attributes.J4NProxy(system.runtime.serialization.StreamingContext.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class StreamingContext extends system.ValueType
// <j4ni-StreamingContext>
// put user interfaces here
// </j4ni-StreamingContext>
{
    // <j4nb-StreamingContext> 
    // put user members here
    // </j4nb-StreamingContext>
    
    private StreamingContext(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.runtime.serialization.StreamingContext(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.runtime.serialization.StreamingContext.j4n_ProxyInit(null);
    }
    
    public StreamingContext(system.Enum state) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(state);
    }
    
    /// <signature>#0 (Lsystem/Enum;)V (LSystem/Enum;)V</signature>
    private native long j4n_constructor(system.Enum state);
    
    public StreamingContext(system.Enum state, java.lang.Object additional) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(state, additional);
    }
    
    /// <signature>#1 (Lsystem/Enum;Ljava/lang/Object;)V (LSystem/Enum;Ljava/lang/Object;)V</signature>
    private native long j4n_constructor(system.Enum state, java.lang.Object additional);
    
    /// <signature>#2 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public final native java.lang.Object getContext();
    
    /// <signature>#3 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public final native system.Enum getState();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Runtime.Serialization.StreamingContext_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.runtime.serialization.StreamingContext.class, system.runtime.serialization.StreamingContext.class, system.runtime.serialization.StreamingContext.class, new system.runtime.serialization.StreamingContext.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
