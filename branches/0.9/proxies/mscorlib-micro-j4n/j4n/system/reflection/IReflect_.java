package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.IReflect_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class IReflect_
// <j4ni-IReflect_>
// put user interfaces here
// </j4ni-IReflect_>
{
    // <j4nb-IReflect_> 
    // put user members here
    // </j4nb-IReflect_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection._IReflect(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        system.reflection.IReflect_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.IReflect_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.reflection.IReflect.class, system.reflection.IReflect_.class, system.reflection._IReflect.class, new system.reflection.IReflect_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(system.reflection.IReflect_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _IReflect extends system.Object implements system.reflection.IReflect
// <j4ni-IReflect>
// put user interfaces here
// </j4ni-IReflect>
{
    // <j4nb-IReflect> 
    // put user members here
    // </j4nb-IReflect>
    
    _IReflect(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        system.reflection.IReflect_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/FieldInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/FieldInfo;</signature>
    public native system.reflection.FieldInfo GetField(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#1 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/FieldInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/FieldInfo;</signature>
    public native system.reflection.FieldInfo[] GetFields(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#2 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetMember(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#3 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetMembers(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#4 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetMethod(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#5 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetMethod(java.lang.String name, system.reflection.BindingFlags bindingAttr, system.Object binder, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#6 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MethodInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo[] GetMethods(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#7 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/PropertyInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo[] GetProperties(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#8 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#9 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Type;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name, system.reflection.BindingFlags bindingAttr, system.Object binder, system.Type returnType, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#10 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getUnderlyingSystemType();
    
    /// <signature>#11 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[Lsystem/ValueType;Lsystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[LSystem/ValueType;LSystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object;</signature>
    public native java.lang.Object InvokeMember(java.lang.String name, system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object target, java.lang.Object[] args, system.ValueType[] modifiers, system.ICloneable culture, java.lang.String[] namedParameters);
}
