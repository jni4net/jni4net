package java_.io;

@net.sf.jni4net.attributes.J4NProxy(java_.io.ObjectStreamConstants_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ObjectStreamConstants_
// <j4ni-ObjectStreamConstants_>
// put user interfaces here
// </j4ni-ObjectStreamConstants_>
{
    // <j4nb-ObjectStreamConstants_> 
    // put user members here
    // </j4nb-ObjectStreamConstants_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.io._ObjectStreamConstants(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.io.ObjectStreamConstants_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.io.ObjectStreamConstants_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.io.ObjectStreamConstants.class, java_.io.ObjectStreamConstants_.class, java_.io._ObjectStreamConstants.class, new java_.io.ObjectStreamConstants_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.io.ObjectStreamConstants_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ObjectStreamConstants extends system.Object implements java.io.ObjectStreamConstants
// <j4ni-ObjectStreamConstants>
// put user interfaces here
// </j4ni-ObjectStreamConstants>
{
    // <j4nb-ObjectStreamConstants> 
    // put user members here
    // </j4nb-ObjectStreamConstants>
    
    _ObjectStreamConstants(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.io.ObjectStreamConstants_.j4n_ProxyInit(null);
    }
}
