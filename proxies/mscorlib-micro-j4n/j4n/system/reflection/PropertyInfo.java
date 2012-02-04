// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.PropertyInfo.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class PropertyInfo extends system.reflection.MemberInfo
// <j4ni-PropertyInfo>
// put user interfaces here
// </j4ni-PropertyInfo>
{
    // <j4nb-PropertyInfo> 
    // put user members here
    // </j4nb-PropertyInfo>
    
    protected PropertyInfo(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.PropertyInfo(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.PropertyInfo.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum getAttributes();
    
    /// <signature>#1 ()Z ()Z</signature>
    public native boolean getCanRead();
    
    /// <signature>#2 ()Z ()Z</signature>
    public native boolean getCanWrite();
    
    /// <signature>#3 ()Z ()Z</signature>
    public native boolean getIsSpecialName();
    
    /// <signature>#4 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getPropertyType();
    
    /// <signature>#5 ()[Lsystem/reflection/MethodInfo; ()[LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo[] GetAccessors();
    
    /// <signature>#6 (Z)[Lsystem/reflection/MethodInfo; (Z)[LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo[] GetAccessors(boolean nonPublic);
    
    /// <signature>#7 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object GetConstantValue();
    
    /// <signature>#8 ()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetGetMethod();
    
    /// <signature>#9 (Z)Lsystem/reflection/MethodInfo; (Z)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetGetMethod(boolean nonPublic);
    
    /// <signature>#10 ()[Lsystem/reflection/ParameterInfo; ()[LSystem/Reflection/ParameterInfo;</signature>
    public native system.reflection.ParameterInfo[] GetIndexParameters();
    
    /// <signature>#11 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetOptionalCustomModifiers();
    
    /// <signature>#12 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object GetRawConstantValue();
    
    /// <signature>#13 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetRequiredCustomModifiers();
    
    /// <signature>#14 ()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetSetMethod();
    
    /// <signature>#15 (Z)Lsystem/reflection/MethodInfo; (Z)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetSetMethod(boolean nonPublic);
    
    /// <signature>#16 (Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object GetValue(java.lang.Object obj, java.lang.Object[] index);
    
    /// <signature>#17 (Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object; (Ljava/lang/Object;LSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;)Ljava/lang/Object;</signature>
    public native java.lang.Object GetValue(java.lang.Object obj, system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object[] index, system.ICloneable culture);
    
    /// <signature>#18 (Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)V (Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)V</signature>
    public native void SetValue(java.lang.Object obj, java.lang.Object value, java.lang.Object[] index);
    
    /// <signature>#19 (Ljava/lang/Object;Ljava/lang/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;)V (Ljava/lang/Object;Ljava/lang/Object;LSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;)V</signature>
    public native void SetValue(java.lang.Object obj, java.lang.Object value, system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object[] index, system.ICloneable culture);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.PropertyInfo_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.reflection.PropertyInfo.class, system.reflection.PropertyInfo.class, system.reflection.PropertyInfo.class, new system.reflection.PropertyInfo.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
