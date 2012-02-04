package dummy.jvm;

@net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Foobararable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Foobararable_
// <j4ni-Foobararable_>
// put user interfaces here
// </j4ni-Foobararable_>
{
    // <j4nb-Foobararable_> 
    // put user members here
    // </j4nb-Foobararable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new dummy.jvm._Foobararable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        dummy.jvm.Foobararable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "dummy.jvm.Foobararable_, " + net.sf.jni4net.modules.dummyjj4n.assemblyName, dummy.jvm.Foobararable.class, dummy.jvm.Foobararable_.class, dummy.jvm._Foobararable.class, new dummy.jvm.Foobararable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(dummy.jvm.Foobararable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Foobararable extends system.Object implements dummy.jvm.Foobararable
// <j4ni-Foobararable>
// put user interfaces here
// </j4ni-Foobararable>
{
    // <j4nb-Foobararable> 
    // put user members here
    // </j4nb-Foobararable>
    
    _Foobararable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        dummy.jvm.Foobararable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/Object;)I (Ljava/lang/Object;)I</signature>
    public native int Foob(java.lang.Object par0);
}
