package system.security;

@net.sf.jni4net.attributes.J4NProxy(system.security.IEvidenceFactory_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IEvidenceFactory_
// <j4ni-IEvidenceFactory_>
// put user interfaces here
// </j4ni-IEvidenceFactory_>
{
    // <j4nb-IEvidenceFactory_> 
    // put user members here
    // </j4nb-IEvidenceFactory_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.security._IEvidenceFactory(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.security.IEvidenceFactory_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Security.IEvidenceFactory_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.security.IEvidenceFactory.class, system.security.IEvidenceFactory_.class, system.security._IEvidenceFactory.class, new system.security.IEvidenceFactory_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.security.IEvidenceFactory_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IEvidenceFactory extends system.Object implements system.security.IEvidenceFactory
// <j4ni-IEvidenceFactory>
// put user interfaces here
// </j4ni-IEvidenceFactory>
{
    // <j4nb-IEvidenceFactory> 
    // put user members here
    // </j4nb-IEvidenceFactory>
    
    _IEvidenceFactory(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.security.IEvidenceFactory_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/collections/ICollection; ()LSystem/Collections/ICollection;</signature>
    public native system.collections.ICollection getEvidence();
}
