// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.ConstructorInfo.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ConstructorInfo extends system.reflection.MethodBase
// <j4ni-ConstructorInfo>
// put user interfaces here
// </j4ni-ConstructorInfo>
{
    // <j4nb-ConstructorInfo> 
    // put user members here
    // </j4nb-ConstructorInfo>
    
    protected ConstructorInfo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.ConstructorInfo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.ConstructorInfo.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String ConstructorName();
    
    /// <signature>#1 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String TypeConstructorName();
    
    /// <signature>#2 ([Ljava/lang/Object;)Ljava/lang/Object; ([Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public final native java.lang.Object Invoke(java.lang.Object[] parameters);
    
    /// <signature>#3 (Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object; (LSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;)Ljava/lang/Object;</signature>
    public native java.lang.Object Invoke(system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object[] parameters, system.ICloneable culture);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.ConstructorInfo_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.reflection.ConstructorInfo.class, system.reflection.ConstructorInfo.class, system.reflection.ConstructorInfo.class, new system.reflection.ConstructorInfo.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
