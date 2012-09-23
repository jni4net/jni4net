// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.MethodBase.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class MethodBase extends system.reflection.MemberInfo
// <j4ni-MethodBase>
// put user interfaces here
// </j4ni-MethodBase>
{
    // <j4nb-MethodBase> 
    // put user members here
    // </j4nb-MethodBase>
    
    protected MethodBase(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.MethodBase(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.MethodBase.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/reflection/MethodBase; ()LSystem/Reflection/MethodBase;</signature>
    static public native system.reflection.MethodBase GetCurrentMethod();
    
    /// <signature>#1 (Lsystem/ValueType;)Lsystem/reflection/MethodBase; (LSystem/ValueType;)LSystem/Reflection/MethodBase;</signature>
    static public native system.reflection.MethodBase GetMethodFromHandle(system.ValueType handle);
    
    /// <signature>#2 (Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/MethodBase; (LSystem/ValueType;LSystem/ValueType;)LSystem/Reflection/MethodBase;</signature>
    static public native system.reflection.MethodBase GetMethodFromHandle(system.ValueType handle, system.ValueType declaringType);
    
    /// <signature>#3 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum getAttributes();
    
    /// <signature>#4 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum getCallingConvention();
    
    /// <signature>#5 ()Z ()Z</signature>
    public native boolean getContainsGenericParameters();
    
    /// <signature>#6 ()Z ()Z</signature>
    public native boolean getIsAbstract();
    
    /// <signature>#7 ()Z ()Z</signature>
    public native boolean getIsAssembly();
    
    /// <signature>#8 ()Z ()Z</signature>
    public native boolean getIsConstructor();
    
    /// <signature>#9 ()Z ()Z</signature>
    public native boolean getIsFamily();
    
    /// <signature>#10 ()Z ()Z</signature>
    public native boolean getIsFamilyAndAssembly();
    
    /// <signature>#11 ()Z ()Z</signature>
    public native boolean getIsFamilyOrAssembly();
    
    /// <signature>#12 ()Z ()Z</signature>
    public native boolean getIsFinal();
    
    /// <signature>#13 ()Z ()Z</signature>
    public native boolean getIsGenericMethod();
    
    /// <signature>#14 ()Z ()Z</signature>
    public native boolean getIsGenericMethodDefinition();
    
    /// <signature>#15 ()Z ()Z</signature>
    public native boolean getIsHideBySig();
    
    /// <signature>#16 ()Z ()Z</signature>
    public native boolean getIsPrivate();
    
    /// <signature>#17 ()Z ()Z</signature>
    public native boolean getIsPublic();
    
    /// <signature>#18 ()Z ()Z</signature>
    public native boolean getIsSpecialName();
    
    /// <signature>#19 ()Z ()Z</signature>
    public native boolean getIsStatic();
    
    /// <signature>#20 ()Z ()Z</signature>
    public native boolean getIsVirtual();
    
    /// <signature>#21 ()Lsystem/ValueType; ()LSystem/ValueType;</signature>
    public native system.ValueType getMethodHandle();
    
    /// <signature>#22 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetGenericArguments();
    
    /// <signature>#23 ()Lsystem/Object; ()Lsystem/Object;</signature>
    public native system.Object GetMethodBody();
    
    /// <signature>#24 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum GetMethodImplementationFlags();
    
    /// <signature>#25 ()[Lsystem/reflection/ParameterInfo; ()[LSystem/Reflection/ParameterInfo;</signature>
    public native system.reflection.ParameterInfo[] GetParameters();
    
    /// <signature>#26 (Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object Invoke(java.lang.Object obj, java.lang.Object[] parameters);
    
    /// <signature>#27 (Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object; (Ljava/lang/Object;LSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;)Ljava/lang/Object;</signature>
    public native java.lang.Object Invoke(java.lang.Object obj, system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object[] parameters, system.ICloneable culture);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.MethodBase_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.reflection.MethodBase.class, system.reflection.MethodBase.class, system.reflection.MethodBase.class, new system.reflection.MethodBase.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
