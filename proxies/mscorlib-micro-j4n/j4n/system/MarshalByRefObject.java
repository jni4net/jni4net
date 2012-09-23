// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.MarshalByRefObject.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class MarshalByRefObject extends system.Object
// <j4ni-MarshalByRefObject>
// put user interfaces here
// </j4ni-MarshalByRefObject>
{
    // <j4nb-MarshalByRefObject> 
    // put user members here
    // </j4nb-MarshalByRefObject>
    
    protected MarshalByRefObject(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.MarshalByRefObject(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.MarshalByRefObject.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/Type;)Lsystem/Object; (LSystem/Type;)Lsystem/Object;</signature>
    public native system.Object CreateObjRef(system.Type requestedType);
    
    /// <signature>#1 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object GetLifetimeService();
    
    /// <signature>#2 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object InitializeLifetimeService();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.MarshalByRefObject_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.MarshalByRefObject.class, system.MarshalByRefObject.class, system.MarshalByRefObject.class, new system.MarshalByRefObject.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
