// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.IReflect_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public interface IReflect
// <j4ni-IReflect>
// put user interfaces here
// </j4ni-IReflect>
{
    // <j4nb-IReflect> 
    // put user members here
    // </j4nb-IReflect>
    
    /// <signature>#0 ()Lsystem/Type; ()LSystem/Type;</signature>
    system.Type getUnderlyingSystemType();
    
    /// <signature>#1 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/FieldInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/FieldInfo;</signature>
    system.reflection.FieldInfo GetField(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#2 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/FieldInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/FieldInfo;</signature>
    system.reflection.FieldInfo[] GetFields(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#3 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
    system.reflection.MemberInfo[] GetMember(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#4 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
    system.reflection.MemberInfo[] GetMembers(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#5 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MethodInfo;</signature>
    system.reflection.MethodInfo GetMethod(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#6 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;</signature>
    system.reflection.MethodInfo GetMethod(java.lang.String name, system.reflection.BindingFlags bindingAttr, system.Object binder, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#7 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MethodInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MethodInfo;</signature>
    system.reflection.MethodInfo[] GetMethods(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#8 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/PropertyInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/PropertyInfo;</signature>
    system.reflection.PropertyInfo[] GetProperties(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#9 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/PropertyInfo;</signature>
    system.reflection.PropertyInfo GetProperty(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#10 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Type;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/PropertyInfo;</signature>
    system.reflection.PropertyInfo GetProperty(java.lang.String name, system.reflection.BindingFlags bindingAttr, system.Object binder, system.Type returnType, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#11 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[Lsystem/ValueType;Lsystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[LSystem/ValueType;LSystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object;</signature>
    java.lang.Object InvokeMember(java.lang.String name, system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object target, java.lang.Object[] args, system.ValueType[] modifiers, system.ICloneable culture, java.lang.String[] namedParameters);
}
