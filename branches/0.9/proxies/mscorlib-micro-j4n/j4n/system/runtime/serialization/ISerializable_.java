package system.runtime.serialization;

@net.sf.jni4net.attributes.J4NProxy(system.runtime.serialization.ISerializable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ISerializable_
// <j4ni-ISerializable_>
// put user interfaces here
// </j4ni-ISerializable_>
{
    // <j4nb-ISerializable_> 
    // put user members here
    // </j4nb-ISerializable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.runtime.serialization._ISerializable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.runtime.serialization.ISerializable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Runtime.Serialization.ISerializable_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.runtime.serialization.ISerializable.class, system.runtime.serialization.ISerializable_.class, system.runtime.serialization._ISerializable.class, new system.runtime.serialization.ISerializable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.runtime.serialization.ISerializable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ISerializable extends system.Object implements system.runtime.serialization.ISerializable
// <j4ni-ISerializable>
// put user interfaces here
// </j4ni-ISerializable>
{
    // <j4nb-ISerializable> 
    // put user members here
    // </j4nb-ISerializable>
    
    _ISerializable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.runtime.serialization.ISerializable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
    public native void GetObjectData(system.runtime.serialization.SerializationInfo info, system.runtime.serialization.StreamingContext context);
}
