// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.MethodInfo.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class MethodInfo extends system.reflection.MethodBase
// <j4ni-MethodInfo>
// put user interfaces here
// </j4ni-MethodInfo>
{
    // <j4nb-MethodInfo> 
    // put user members here
    // </j4nb-MethodInfo>
    
    protected MethodInfo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.MethodInfo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.MethodInfo.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/reflection/ParameterInfo; ()LSystem/Reflection/ParameterInfo;</signature>
    public native system.reflection.ParameterInfo getReturnParameter();
    
    /// <signature>#1 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getReturnType();
    
    /// <signature>#2 ()Lsystem/reflection/ICustomAttributeProvider; ()LSystem/Reflection/ICustomAttributeProvider;</signature>
    public native system.reflection.ICustomAttributeProvider getReturnTypeCustomAttributes();
    
    /// <signature>#3 ()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetBaseDefinition();
    
    /// <signature>#4 ()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetGenericMethodDefinition();
    
    /// <signature>#5 ([Lsystem/Type;)Lsystem/reflection/MethodInfo; ([LSystem/Type;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo MakeGenericMethod(system.Type[] typeArguments);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.MethodInfo_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.reflection.MethodInfo.class, system.reflection.MethodInfo.class, system.reflection.MethodInfo.class, new system.reflection.MethodInfo.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
