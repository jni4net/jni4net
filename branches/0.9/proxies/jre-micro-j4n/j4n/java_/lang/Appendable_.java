package java_.lang;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Appendable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Appendable_
// <j4ni-Appendable_>
// put user interfaces here
// </j4ni-Appendable_>
{
    // <j4nb-Appendable_> 
    // put user members here
    // </j4nb-Appendable_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang._Appendable(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.Appendable_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.Appendable_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.lang.Appendable.class, java_.lang.Appendable_.class, java_.lang._Appendable.class, new java_.lang.Appendable_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.Appendable_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _Appendable extends system.Object implements java.lang.Appendable
// <j4ni-Appendable>
// put user interfaces here
// </j4ni-Appendable>
{
    // <j4nb-Appendable> 
    // put user members here
    // </j4nb-Appendable>
    
    _Appendable(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.Appendable_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (C)Ljava/lang/Appendable; (C)Ljava/lang/Appendable;</signature>
    public native java.lang.Appendable append(char par0);
    
    /// <signature>#1 (Ljava/lang/CharSequence;)Ljava/lang/Appendable; (Ljava/lang/CharSequence;)Ljava/lang/Appendable;</signature>
    public native java.lang.Appendable append(java.lang.CharSequence par0);
    
    /// <signature>#2 (Ljava/lang/CharSequence;II)Ljava/lang/Appendable; (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;</signature>
    public native java.lang.Appendable append(java.lang.CharSequence par0, int par1, int par2);
}
