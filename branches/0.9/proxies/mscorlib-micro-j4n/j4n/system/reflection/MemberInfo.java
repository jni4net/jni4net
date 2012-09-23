// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.MemberInfo.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class MemberInfo extends system.Object implements system.reflection.ICustomAttributeProvider
// <j4ni-MemberInfo>
// put user interfaces here
// </j4ni-MemberInfo>
{
    // <j4nb-MemberInfo> 
    // put user members here
    // </j4nb-MemberInfo>
    
    protected MemberInfo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.MemberInfo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.MemberInfo.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getDeclaringType();
    
    /// <signature>#1 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum getMemberType();
    
    /// <signature>#2 ()I ()I</signature>
    public native int getMetadataToken();
    
    /// <signature>#3 ()Lsystem/runtime/serialization/ISerializable; ()LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable getModule();
    
    /// <signature>#4 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getName();
    
    /// <signature>#5 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getReflectedType();
    
    /// <signature>#6 (Z)[Ljava/lang/Object; (Z)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] GetCustomAttributes(boolean inherit);
    
    /// <signature>#7 (Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] GetCustomAttributes(system.Type attributeType, boolean inherit);
    
    /// <signature>#8 (Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
    public native boolean IsDefined(system.Type attributeType, boolean inherit);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.MemberInfo_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.reflection.MemberInfo.class, system.reflection.MemberInfo.class, system.reflection.MemberInfo.class, new system.reflection.MemberInfo.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
