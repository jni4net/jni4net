package java_.lang;

@net.sf.jni4net.attributes.J4NProxy(java_.lang.CharSequence_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class CharSequence_
// <j4ni-CharSequence_>
// put user interfaces here
// </j4ni-CharSequence_>
{
    // <j4nb-CharSequence_> 
    // put user members here
    // </j4nb-CharSequence_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.lang._CharSequence(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.lang.CharSequence_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.lang.CharSequence_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.lang.CharSequence.class, java_.lang.CharSequence_.class, java_.lang._CharSequence.class, new java_.lang.CharSequence_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.lang.CharSequence_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _CharSequence extends system.Object implements java.lang.CharSequence
// <j4ni-CharSequence>
// put user interfaces here
// </j4ni-CharSequence>
{
    // <j4nb-CharSequence> 
    // put user members here
    // </j4nb-CharSequence>
    
    _CharSequence(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.lang.CharSequence_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (I)C (I)C</signature>
    public native char charAt(int par0);
    
    /// <signature>#1 ()I ()I</signature>
    public native int length();
    
    /// <signature>#2 (II)Ljava/lang/CharSequence; (II)Ljava/lang/CharSequence;</signature>
    public native java.lang.CharSequence subSequence(int par0, int par1);
}
