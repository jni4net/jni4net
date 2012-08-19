package dummy.clr;

@net.sf.jni4net.attributes.J4NProxy(dummy.clr.ITestedFactory_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ITestedFactory_
// <j4ni-ITestedFactory_>
// put user interfaces here
// </j4ni-ITestedFactory_>
{
    // <j4nb-ITestedFactory_> 
    // put user members here
    // </j4nb-ITestedFactory_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new dummy.clr._ITestedFactory(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        System.out.printf("static constructopr");
        dummy.clr.ITestedFactory_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        System.out.printf("j4n_ProxyInit");
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.clr.ITestedFactory_, " + net.sf.jni4net.modules.dummynj4n.assemblyName, dummy.clr.ITestedFactory.class, dummy.clr.ITestedFactory_.class, dummy.clr._ITestedFactory.class, new dummy.clr.ITestedFactory_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(dummy.clr.ITestedFactory_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ITestedFactory extends system.Object implements dummy.clr.ITestedFactory
// <j4ni-ITestedFactory>
// put user interfaces here
// </j4ni-ITestedFactory>
{
    // <j4nb-ITestedFactory> 
    // put user members here
    // </j4nb-ITestedFactory>
    
    _ITestedFactory(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        dummy.clr.ITestedFactory_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ldummy/clr/ITested; ()Ldummy/clr/ITested;</signature>
    public native dummy.clr.ITested createJTested();
}
