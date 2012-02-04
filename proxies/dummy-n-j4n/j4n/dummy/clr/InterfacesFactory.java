// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package dummy.clr;

@net.sf.jni4net.attributes.J4NProxy(dummy.clr.InterfacesFactory.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class InterfacesFactory extends system.Object
// <j4ni-InterfacesFactory>
// put user interfaces here
// </j4ni-InterfacesFactory>
{
    // <j4nb-InterfacesFactory> 
    // put user members here
    // </j4nb-InterfacesFactory>
    
    protected InterfacesFactory(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new dummy.clr.InterfacesFactory(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        dummy.clr.InterfacesFactory.j4n_ProxyInit(null);
    }
    
    public InterfacesFactory() {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor();
    }
    
    /// <signature>#0 ()V ()V</signature>
    private native long j4n_constructor();
    
    /// <signature>#1 ()Ldummy/clr/ITested; ()Ldummy/clr/ITested;</signature>
    static public native dummy.clr.ITested createITested();
    
    /// <signature>#2 ()Ldummy/clr/Tested; ()Ldummy/clr/Tested;</signature>
    static public native dummy.clr.Tested createTested();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.InterfacesFactory_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.InterfacesFactory.class, dummy.clr.InterfacesFactory.class, dummy.clr.InterfacesFactory.class, new dummy.clr.InterfacesFactory.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
