// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.IntPtr.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class IntPtr extends system.ValueType implements system.runtime.serialization.ISerializable
// <j4ni-IntPtr>
// put user interfaces here
// </j4ni-IntPtr>
{
    // <j4nb-IntPtr> 
    // put user members here
    // </j4nb-IntPtr>
    
    private IntPtr(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.IntPtr(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.IntPtr.j4n_ProxyInit(null);
    }
    
    public IntPtr(int value) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(value);
    }
    
    /// <signature>#0 (I)V (I)V</signature>
    private native long j4n_constructor(int value);
    
    public IntPtr(long value) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(value);
    }
    
    /// <signature>#1 (J)V (J)V</signature>
    private native long j4n_constructor(long value);
    
    /// <signature>#2 ()I ()I</signature>
    static public native int getSize();
    
    /// <signature>#3 ()Lsystem/IntPtr; ()LSystem/IntPtr;</signature>
    static public native system.IntPtr Zero();
    
    /// <signature>#4 (Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
    public native void GetObjectData(system.runtime.serialization.SerializationInfo info, system.runtime.serialization.StreamingContext context);
    
    /// <signature>#5 ()I ()I</signature>
    public final native int ToInt32();
    
    /// <signature>#6 ()J ()J</signature>
    public final native long ToInt64();
    
    /// <signature>#7 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    public final native java.lang.String ToString(java.lang.String format);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IntPtr_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.IntPtr.class, system.IntPtr.class, system.IntPtr.class, new system.IntPtr.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
