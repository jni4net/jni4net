// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.FieldInfo.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class FieldInfo extends system.reflection.MemberInfo
// <j4ni-FieldInfo>
// put user interfaces here
// </j4ni-FieldInfo>
{
    // <j4nb-FieldInfo> 
    // put user members here
    // </j4nb-FieldInfo>
    
    protected FieldInfo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.FieldInfo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.FieldInfo.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/ValueType;)Lsystem/reflection/FieldInfo; (LSystem/ValueType;)LSystem/Reflection/FieldInfo;</signature>
    static public native system.reflection.FieldInfo GetFieldFromHandle(system.ValueType handle);
    
    /// <signature>#1 (Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/FieldInfo; (LSystem/ValueType;LSystem/ValueType;)LSystem/Reflection/FieldInfo;</signature>
    static public native system.reflection.FieldInfo GetFieldFromHandle(system.ValueType handle, system.ValueType declaringType);
    
    /// <signature>#2 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum getAttributes();
    
    /// <signature>#3 ()Lsystem/ValueType; ()LSystem/ValueType;</signature>
    public native system.ValueType getFieldHandle();
    
    /// <signature>#4 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getFieldType();
    
    /// <signature>#5 ()Z ()Z</signature>
    public native boolean getIsAssembly();
    
    /// <signature>#6 ()Z ()Z</signature>
    public native boolean getIsFamily();
    
    /// <signature>#7 ()Z ()Z</signature>
    public native boolean getIsFamilyAndAssembly();
    
    /// <signature>#8 ()Z ()Z</signature>
    public native boolean getIsFamilyOrAssembly();
    
    /// <signature>#9 ()Z ()Z</signature>
    public native boolean getIsInitOnly();
    
    /// <signature>#10 ()Z ()Z</signature>
    public native boolean getIsLiteral();
    
    /// <signature>#11 ()Z ()Z</signature>
    public native boolean getIsNotSerialized();
    
    /// <signature>#12 ()Z ()Z</signature>
    public native boolean getIsPinvokeImpl();
    
    /// <signature>#13 ()Z ()Z</signature>
    public native boolean getIsPrivate();
    
    /// <signature>#14 ()Z ()Z</signature>
    public native boolean getIsPublic();
    
    /// <signature>#15 ()Z ()Z</signature>
    public native boolean getIsSpecialName();
    
    /// <signature>#16 ()Z ()Z</signature>
    public native boolean getIsStatic();
    
    /// <signature>#17 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetOptionalCustomModifiers();
    
    /// <signature>#18 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object GetRawConstantValue();
    
    /// <signature>#19 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetRequiredCustomModifiers();
    
    /// <signature>#20 (Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object GetValue(java.lang.Object obj);
    
    /// <signature>#22 (Ljava/lang/Object;Ljava/lang/Object;)V (Ljava/lang/Object;Ljava/lang/Object;)V</signature>
    public native void SetValue(java.lang.Object obj, java.lang.Object value);
    
    /// <signature>#23 (Ljava/lang/Object;Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/ICloneable;)V (Ljava/lang/Object;Ljava/lang/Object;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/ICloneable;)V</signature>
    public native void SetValue(java.lang.Object obj, java.lang.Object value, system.reflection.BindingFlags invokeAttr, system.Object binder, system.ICloneable culture);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.FieldInfo_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.reflection.FieldInfo.class, system.reflection.FieldInfo.class, system.reflection.FieldInfo.class, new system.reflection.FieldInfo.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
