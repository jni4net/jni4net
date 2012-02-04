// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Type.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Type extends system.reflection.MemberInfo implements system.reflection.IReflect
// <j4ni-Type>
        , system.IType
// </j4ni-Type>
{
    // <j4nb-Type> 
    // put user members here
    // </j4nb-Type>
    
    protected Type(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Type(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Type.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()C ()C</signature>
    static public native char Delimiter();
    
    /// <signature>#1 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    static public native system.Type[] EmptyTypes();
    
    /// <signature>#2 ()Lsystem/MulticastDelegate; ()LSystem/MulticastDelegate;</signature>
    static public native system.MulticastDelegate FilterAttribute();
    
    /// <signature>#3 ()Lsystem/MulticastDelegate; ()LSystem/MulticastDelegate;</signature>
    static public native system.MulticastDelegate FilterName();
    
    /// <signature>#4 ()Lsystem/MulticastDelegate; ()LSystem/MulticastDelegate;</signature>
    static public native system.MulticastDelegate FilterNameIgnoreCase();
    
    /// <signature>#5 ()Lsystem/Object; ()Lsystem/Object;</signature>
    static public native system.Object getDefaultBinder();
    
    /// <signature>#6 (Ljava/lang/String;)Lsystem/Type; (Ljava/lang/String;)LSystem/Type;</signature>
    static public native system.Type GetType(java.lang.String typeName);
    
    /// <signature>#7 (Ljava/lang/String;Z)Lsystem/Type; (Ljava/lang/String;Z)LSystem/Type;</signature>
    static public native system.Type GetType(java.lang.String typeName, boolean throwOnError);
    
    /// <signature>#8 (Ljava/lang/String;ZZ)Lsystem/Type; (Ljava/lang/String;ZZ)LSystem/Type;</signature>
    static public native system.Type GetType(java.lang.String typeName, boolean throwOnError, boolean ignoreCase);
    
    /// <signature>#9 ([Ljava/lang/Object;)[Lsystem/Type; ([Ljava/lang/Object;)[LSystem/Type;</signature>
    static public native system.Type[] GetTypeArray(java.lang.Object[] args);
    
    /// <signature>#10 (Lsystem/Type;)Lsystem/Enum; (LSystem/Type;)LSystem/Enum;</signature>
    static public native system.Enum GetTypeCode(system.Type type);
    
    /// <signature>#11 (Lsystem/Guid;)Lsystem/Type; (LSystem/Guid;)LSystem/Type;</signature>
    static public native system.Type GetTypeFromCLSID(system.Guid clsid);
    
    /// <signature>#12 (Lsystem/Guid;Z)Lsystem/Type; (LSystem/Guid;Z)LSystem/Type;</signature>
    static public native system.Type GetTypeFromCLSID(system.Guid clsid, boolean throwOnError);
    
    /// <signature>#13 (Lsystem/Guid;Ljava/lang/String;)Lsystem/Type; (LSystem/Guid;Ljava/lang/String;)LSystem/Type;</signature>
    static public native system.Type GetTypeFromCLSID(system.Guid clsid, java.lang.String server);
    
    /// <signature>#14 (Lsystem/Guid;Ljava/lang/String;Z)Lsystem/Type; (LSystem/Guid;Ljava/lang/String;Z)LSystem/Type;</signature>
    static public native system.Type GetTypeFromCLSID(system.Guid clsid, java.lang.String server, boolean throwOnError);
    
    /// <signature>#15 (Lsystem/ValueType;)Lsystem/Type; (LSystem/ValueType;)LSystem/Type;</signature>
    static public native system.Type GetTypeFromHandle(system.ValueType handle);
    
    /// <signature>#16 (Ljava/lang/String;)Lsystem/Type; (Ljava/lang/String;)LSystem/Type;</signature>
    static public native system.Type GetTypeFromProgID(java.lang.String progID);
    
    /// <signature>#17 (Ljava/lang/String;Z)Lsystem/Type; (Ljava/lang/String;Z)LSystem/Type;</signature>
    static public native system.Type GetTypeFromProgID(java.lang.String progID, boolean throwOnError);
    
    /// <signature>#18 (Ljava/lang/String;Ljava/lang/String;)Lsystem/Type; (Ljava/lang/String;Ljava/lang/String;)LSystem/Type;</signature>
    static public native system.Type GetTypeFromProgID(java.lang.String progID, java.lang.String server);
    
    /// <signature>#19 (Ljava/lang/String;Ljava/lang/String;Z)Lsystem/Type; (Ljava/lang/String;Ljava/lang/String;Z)LSystem/Type;</signature>
    static public native system.Type GetTypeFromProgID(java.lang.String progID, java.lang.String server, boolean throwOnError);
    
    /// <signature>#20 (Ljava/lang/Object;)Lsystem/ValueType; (Ljava/lang/Object;)LSystem/ValueType;</signature>
    static public native system.ValueType GetTypeHandle(java.lang.Object o);
    
    /// <signature>#21 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    static public native java.lang.Object Missing();
    
    /// <signature>#22 (Ljava/lang/String;ZZ)Lsystem/Type; (Ljava/lang/String;ZZ)LSystem/Type;</signature>
    static public native system.Type ReflectionOnlyGetType(java.lang.String typeName, boolean throwIfNotFound, boolean ignoreCase);
    
    /// <signature>#23 (Lsystem/Type;)Z (LSystem/Type;)Z</signature>
    public native boolean Equals(system.Type o);
    
    /// <signature>#24 (Lsystem/MulticastDelegate;Ljava/lang/Object;)[Lsystem/Type; (LSystem/MulticastDelegate;Ljava/lang/Object;)[LSystem/Type;</signature>
    public native system.Type[] FindInterfaces(system.MulticastDelegate filter, java.lang.Object filterCriteria);
    
    /// <signature>#25 (Lsystem/Enum;Lsystem/reflection/BindingFlags;Lsystem/MulticastDelegate;Ljava/lang/Object;)[Lsystem/reflection/MemberInfo; (LSystem/Enum;LSystem/Reflection/BindingFlags;LSystem/MulticastDelegate;Ljava/lang/Object;)[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] FindMembers(system.Enum memberType, system.reflection.BindingFlags bindingAttr, system.MulticastDelegate filter, java.lang.Object filterCriteria);
    
    /// <signature>#26 ()Lsystem/reflection/Assembly; ()LSystem/Reflection/Assembly;</signature>
    public native system.reflection.Assembly getAssembly();
    
    /// <signature>#27 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getAssemblyQualifiedName();
    
    /// <signature>#28 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum getAttributes();
    
    /// <signature>#29 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getBaseType();
    
    /// <signature>#30 ()Z ()Z</signature>
    public native boolean getContainsGenericParameters();
    
    /// <signature>#31 ()Lsystem/reflection/MethodBase; ()LSystem/Reflection/MethodBase;</signature>
    public native system.reflection.MethodBase getDeclaringMethod();
    
    /// <signature>#32 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getFullName();
    
    /// <signature>#33 ()Lsystem/Enum; ()LSystem/Enum;</signature>
    public native system.Enum getGenericParameterAttributes();
    
    /// <signature>#34 ()I ()I</signature>
    public native int getGenericParameterPosition();
    
    /// <signature>#35 ()Lsystem/Guid; ()LSystem/Guid;</signature>
    public native system.Guid getGUID();
    
    /// <signature>#36 ()Z ()Z</signature>
    public native boolean getHasElementType();
    
    /// <signature>#37 ()Z ()Z</signature>
    public native boolean getIsAbstract();
    
    /// <signature>#38 ()Z ()Z</signature>
    public native boolean getIsAnsiClass();
    
    /// <signature>#39 ()Z ()Z</signature>
    public native boolean getIsArray();
    
    /// <signature>#40 ()Z ()Z</signature>
    public native boolean getIsAutoClass();
    
    /// <signature>#41 ()Z ()Z</signature>
    public native boolean getIsAutoLayout();
    
    /// <signature>#42 ()Z ()Z</signature>
    public native boolean getIsByRef();
    
    /// <signature>#43 ()Z ()Z</signature>
    public native boolean getIsClass();
    
    /// <signature>#44 ()Z ()Z</signature>
    public native boolean getIsCOMObject();
    
    /// <signature>#45 ()Z ()Z</signature>
    public native boolean getIsContextful();
    
    /// <signature>#46 ()Z ()Z</signature>
    public native boolean getIsEnum();
    
    /// <signature>#47 ()Z ()Z</signature>
    public native boolean getIsExplicitLayout();
    
    /// <signature>#48 ()Z ()Z</signature>
    public native boolean getIsGenericParameter();
    
    /// <signature>#49 ()Z ()Z</signature>
    public native boolean getIsGenericType();
    
    /// <signature>#50 ()Z ()Z</signature>
    public native boolean getIsGenericTypeDefinition();
    
    /// <signature>#51 ()Z ()Z</signature>
    public native boolean getIsImport();
    
    /// <signature>#52 ()Z ()Z</signature>
    public native boolean getIsInterface();
    
    /// <signature>#53 ()Z ()Z</signature>
    public native boolean getIsLayoutSequential();
    
    /// <signature>#54 ()Z ()Z</signature>
    public native boolean getIsMarshalByRef();
    
    /// <signature>#55 ()Z ()Z</signature>
    public final native boolean getIsNested();
    
    /// <signature>#56 ()Z ()Z</signature>
    public native boolean getIsNestedAssembly();
    
    /// <signature>#57 ()Z ()Z</signature>
    public native boolean getIsNestedFamANDAssem();
    
    /// <signature>#58 ()Z ()Z</signature>
    public native boolean getIsNestedFamily();
    
    /// <signature>#59 ()Z ()Z</signature>
    public native boolean getIsNestedFamORAssem();
    
    /// <signature>#60 ()Z ()Z</signature>
    public native boolean getIsNestedPrivate();
    
    /// <signature>#61 ()Z ()Z</signature>
    public native boolean getIsNestedPublic();
    
    /// <signature>#62 ()Z ()Z</signature>
    public native boolean getIsNotPublic();
    
    /// <signature>#63 ()Z ()Z</signature>
    public native boolean getIsPointer();
    
    /// <signature>#64 ()Z ()Z</signature>
    public native boolean getIsPrimitive();
    
    /// <signature>#65 ()Z ()Z</signature>
    public native boolean getIsPublic();
    
    /// <signature>#66 ()Z ()Z</signature>
    public native boolean getIsSealed();
    
    /// <signature>#67 ()Z ()Z</signature>
    public native boolean getIsSerializable();
    
    /// <signature>#68 ()Z ()Z</signature>
    public native boolean getIsSpecialName();
    
    /// <signature>#69 ()Z ()Z</signature>
    public native boolean getIsUnicodeClass();
    
    /// <signature>#70 ()Z ()Z</signature>
    public native boolean getIsValueType();
    
    /// <signature>#71 ()Z ()Z</signature>
    public final native boolean getIsVisible();
    
    /// <signature>#72 ()Lsystem/runtime/serialization/ISerializable; ()LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable getModule_95();
    
    /// <signature>#73 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getNamespace();
    
    /// <signature>#74 ()Lsystem/Object; ()Lsystem/Object;</signature>
    public native system.Object getStructLayoutAttribute();
    
    /// <signature>#75 ()Lsystem/ValueType; ()LSystem/ValueType;</signature>
    public native system.ValueType getTypeHandle();
    
    /// <signature>#76 ()Lsystem/reflection/ConstructorInfo; ()LSystem/Reflection/ConstructorInfo;</signature>
    public native system.reflection.ConstructorInfo getTypeInitializer();
    
    /// <signature>#77 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type getUnderlyingSystemType();
    
    /// <signature>#78 ()I ()I</signature>
    public native int GetArrayRank();
    
    /// <signature>#79 ([Lsystem/Type;)Lsystem/reflection/ConstructorInfo; ([LSystem/Type;)LSystem/Reflection/ConstructorInfo;</signature>
    public native system.reflection.ConstructorInfo GetConstructor(system.Type[] types);
    
    /// <signature>#80 (Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/ConstructorInfo; (LSystem/Reflection/BindingFlags;Lsystem/Object;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/ConstructorInfo;</signature>
    public native system.reflection.ConstructorInfo GetConstructor(system.reflection.BindingFlags bindingAttr, system.Object binder, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#81 (Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Enum;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/ConstructorInfo; (LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Enum;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/ConstructorInfo;</signature>
    public native system.reflection.ConstructorInfo GetConstructor(system.reflection.BindingFlags bindingAttr, system.Object binder, system.Enum callConvention, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#82 ()[Lsystem/reflection/ConstructorInfo; ()[LSystem/Reflection/ConstructorInfo;</signature>
    public native system.reflection.ConstructorInfo[] GetConstructors();
    
    /// <signature>#83 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/ConstructorInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/ConstructorInfo;</signature>
    public native system.reflection.ConstructorInfo[] GetConstructors(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#84 ()[Lsystem/reflection/MemberInfo; ()[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetDefaultMembers();
    
    /// <signature>#85 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type GetElementType();
    
    /// <signature>#86 (Ljava/lang/String;)Lsystem/reflection/MemberInfo; (Ljava/lang/String;)LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo GetEvent(java.lang.String name);
    
    /// <signature>#87 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MemberInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo GetEvent(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#88 ()[Lsystem/reflection/MemberInfo; ()[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetEvents();
    
    /// <signature>#89 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetEvents(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#90 (Ljava/lang/String;)Lsystem/reflection/FieldInfo; (Ljava/lang/String;)LSystem/Reflection/FieldInfo;</signature>
    public native system.reflection.FieldInfo GetField(java.lang.String name);
    
    /// <signature>#91 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/FieldInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/FieldInfo;</signature>
    public native system.reflection.FieldInfo GetField(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#92 ()[Lsystem/reflection/FieldInfo; ()[LSystem/Reflection/FieldInfo;</signature>
    public native system.reflection.FieldInfo[] GetFields();
    
    /// <signature>#93 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/FieldInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/FieldInfo;</signature>
    public native system.reflection.FieldInfo[] GetFields(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#94 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetGenericArguments();
    
    /// <signature>#95 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetGenericParameterConstraints();
    
    /// <signature>#96 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type GetGenericTypeDefinition();
    
    /// <signature>#97 (Ljava/lang/String;)Lsystem/Type; (Ljava/lang/String;)LSystem/Type;</signature>
    public native system.Type GetInterface(java.lang.String name);
    
    /// <signature>#98 (Ljava/lang/String;Z)Lsystem/Type; (Ljava/lang/String;Z)LSystem/Type;</signature>
    public native system.Type GetInterface(java.lang.String name, boolean ignoreCase);
    
    /// <signature>#99 (Lsystem/Type;)Lsystem/ValueType; (LSystem/Type;)LSystem/ValueType;</signature>
    public native system.ValueType GetInterfaceMap(system.Type interfaceType);
    
    /// <signature>#100 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetInterfaces();
    
    /// <signature>#101 (Ljava/lang/String;)[Lsystem/reflection/MemberInfo; (Ljava/lang/String;)[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetMember(java.lang.String name);
    
    /// <signature>#102 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetMember(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#103 (Ljava/lang/String;Lsystem/Enum;Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (Ljava/lang/String;LSystem/Enum;LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetMember(java.lang.String name, system.Enum type, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#104 ()[Lsystem/reflection/MemberInfo; ()[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetMembers();
    
    /// <signature>#105 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MemberInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MemberInfo;</signature>
    public native system.reflection.MemberInfo[] GetMembers(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#106 (Ljava/lang/String;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetMethod(java.lang.String name);
    
    /// <signature>#107 (Ljava/lang/String;[Lsystem/Type;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;[LSystem/Type;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetMethod(java.lang.String name, system.Type[] types);
    
    /// <signature>#108 (Ljava/lang/String;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetMethod(java.lang.String name, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#109 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetMethod(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#110 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetMethod(java.lang.String name, system.reflection.BindingFlags bindingAttr, system.Object binder, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#111 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Enum;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/MethodInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Enum;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo GetMethod(java.lang.String name, system.reflection.BindingFlags bindingAttr, system.Object binder, system.Enum callConvention, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#112 ()[Lsystem/reflection/MethodInfo; ()[LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo[] GetMethods();
    
    /// <signature>#113 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/MethodInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo[] GetMethods(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#114 (Ljava/lang/String;)Lsystem/Type; (Ljava/lang/String;)LSystem/Type;</signature>
    public native system.Type GetNestedType(java.lang.String name);
    
    /// <signature>#115 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/Type; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Type;</signature>
    public native system.Type GetNestedType(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#116 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetNestedTypes();
    
    /// <signature>#117 (Lsystem/reflection/BindingFlags;)[Lsystem/Type; (LSystem/Reflection/BindingFlags;)[LSystem/Type;</signature>
    public native system.Type[] GetNestedTypes(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#118 ()[Lsystem/reflection/PropertyInfo; ()[LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo[] GetProperties();
    
    /// <signature>#119 (Lsystem/reflection/BindingFlags;)[Lsystem/reflection/PropertyInfo; (LSystem/Reflection/BindingFlags;)[LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo[] GetProperties(system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#120 (Ljava/lang/String;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name);
    
    /// <signature>#121 (Ljava/lang/String;[Lsystem/Type;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;[LSystem/Type;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name, system.Type[] types);
    
    /// <signature>#122 (Ljava/lang/String;Lsystem/reflection/BindingFlags;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name, system.reflection.BindingFlags bindingAttr);
    
    /// <signature>#123 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;LSystem/Type;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name, system.reflection.BindingFlags bindingAttr, system.Object binder, system.Type returnType, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#124 (Ljava/lang/String;Lsystem/Type;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Type;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name, system.Type returnType);
    
    /// <signature>#125 (Ljava/lang/String;Lsystem/Type;[Lsystem/Type;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Type;[LSystem/Type;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name, system.Type returnType, system.Type[] types);
    
    /// <signature>#126 (Ljava/lang/String;Lsystem/Type;[Lsystem/Type;[Lsystem/ValueType;)Lsystem/reflection/PropertyInfo; (Ljava/lang/String;LSystem/Type;[LSystem/Type;[LSystem/ValueType;)LSystem/Reflection/PropertyInfo;</signature>
    public native system.reflection.PropertyInfo GetProperty(java.lang.String name, system.Type returnType, system.Type[] types, system.ValueType[] modifiers);
    
    /// <signature>#127 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type GetType_150();
    
    /// <signature>#128 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object InvokeMember(java.lang.String name, system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object target, java.lang.Object[] args);
    
    /// <signature>#129 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[Lsystem/ValueType;Lsystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;[LSystem/ValueType;LSystem/ICloneable;[Ljava/lang/String;)Ljava/lang/Object;</signature>
    public native java.lang.Object InvokeMember(java.lang.String name, system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object target, java.lang.Object[] args, system.ValueType[] modifiers, system.ICloneable culture, java.lang.String[] namedParameters);
    
    /// <signature>#130 (Ljava/lang/String;Lsystem/reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;Lsystem/ICloneable;)Ljava/lang/Object; (Ljava/lang/String;LSystem/Reflection/BindingFlags;Lsystem/Object;Ljava/lang/Object;[Ljava/lang/Object;LSystem/ICloneable;)Ljava/lang/Object;</signature>
    public native java.lang.Object InvokeMember(java.lang.String name, system.reflection.BindingFlags invokeAttr, system.Object binder, java.lang.Object target, java.lang.Object[] args, system.ICloneable culture);
    
    /// <signature>#131 (Lsystem/Type;)Z (LSystem/Type;)Z</signature>
    public native boolean IsAssignableFrom(system.Type c);
    
    /// <signature>#132 (Ljava/lang/Object;)Z (Ljava/lang/Object;)Z</signature>
    public native boolean IsInstanceOfType(java.lang.Object o);
    
    /// <signature>#133 (Lsystem/Type;)Z (LSystem/Type;)Z</signature>
    public native boolean IsSubclassOf(system.Type c);
    
    /// <signature>#134 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type MakeArrayType();
    
    /// <signature>#135 (I)Lsystem/Type; (I)LSystem/Type;</signature>
    public native system.Type MakeArrayType(int rank);
    
    /// <signature>#136 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type MakeByRefType();
    
    /// <signature>#137 ([Lsystem/Type;)Lsystem/Type; ([LSystem/Type;)LSystem/Type;</signature>
    public native system.Type MakeGenericType(system.Type[] typeArguments);
    
    /// <signature>#138 ()Lsystem/Type; ()LSystem/Type;</signature>
    public native system.Type MakePointerType();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Type_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.Type.class, system.Type.class, system.Type.class, new system.Type.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
