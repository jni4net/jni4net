// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.ParameterInfo.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ParameterInfo extends system.Object implements system.reflection.ICustomAttributeProvider
// <j4ni-ParameterInfo>
// put user interfaces here
// </j4ni-ParameterInfo>
{
    // <j4nb-ParameterInfo> 
    // put user members here
    // </j4nb-ParameterInfo>
    
    protected ParameterInfo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.ParameterInfo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.ParameterInfo.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum getAttributes();
    
    /// <signature>#1 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getDefaultValue();
    
    /// <signature>#2 ()Z ()Z</signature>
    public final native boolean getIsIn();
    
    /// <signature>#3 ()Z ()Z</signature>
    public final native boolean getIsLcid();
    
    /// <signature>#4 ()Z ()Z</signature>
    public final native boolean getIsOptional();
    
    /// <signature>#5 ()Z ()Z</signature>
    public final native boolean getIsOut();
    
    /// <signature>#6 ()Z ()Z</signature>
    public final native boolean getIsRetval();
    
    /// <signature>#7 ()Lsystem/reflection/MemberInfo; ()LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo getMember();
    
    /// <signature>#8 ()I ()I</signature>
    public final native int getMetadataToken();
    
    /// <signature>#9 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getName();
    
    /// <signature>#10 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getParameterType();
    
    /// <signature>#11 ()I ()I</signature>
    public native int getPosition();
    
    /// <signature>#12 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object getRawDefaultValue();
    
    /// <signature>#13 (Z)[Ljava/lang/Object; (Z)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] GetCustomAttributes(boolean inherit);
    
    /// <signature>#14 (Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] GetCustomAttributes(system.Type attributeType, boolean inherit);
    
    /// <signature>#15 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetOptionalCustomModifiers();
    
    /// <signature>#16 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetRequiredCustomModifiers();
    
    /// <signature>#17 (Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
    public native boolean IsDefined(system.Type attributeType, boolean inherit);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.ParameterInfo_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.reflection.ParameterInfo.class, system.reflection.ParameterInfo.class, system.reflection.ParameterInfo.class, new system.reflection.ParameterInfo.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
