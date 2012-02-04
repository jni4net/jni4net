// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.Assembly.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Assembly extends system.Object implements system.security.IEvidenceFactory, system.reflection.ICustomAttributeProvider, system.runtime.serialization.ISerializable
// <j4ni-Assembly>
// put user interfaces here
// </j4ni-Assembly>
{
    // <j4nb-Assembly> 
    // put user members here
    // </j4nb-Assembly>
    
    protected Assembly(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.Assembly(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.Assembly.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String CreateQualifiedName(java.lang.String assemblyName, java.lang.String typeName);
    
    /// <signature>#1 (Lsystem/Type;)Lsystem/reflection/Assembly; (LSystem/Type;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly GetAssembly(system.Type type);
    
    /// <signature>#2 ()Lsystem/reflection/Assembly; ()LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly GetCallingAssembly();
    
    /// <signature>#3 ()Lsystem/reflection/Assembly; ()LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly GetEntryAssembly();
    
    /// <signature>#4 ()Lsystem/reflection/Assembly; ()LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly GetExecutingAssembly();
    
    /// <signature>#5 ([B)Lsystem/reflection/Assembly; ([B)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly Load(byte[] rawAssembly);
    
    /// <signature>#6 ([B[B)Lsystem/reflection/Assembly; ([B[B)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
    
    /// <signature>#7 ([B[BLsystem/collections/ICollection;)Lsystem/reflection/Assembly; ([B[BLSystem/Collections/ICollection;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, system.collections.ICollection securityEvidence);
    
    /// <signature>#8 (Lsystem/ICloneable;)Lsystem/reflection/Assembly; (LSystem/ICloneable;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly Load(system.ICloneable assemblyRef);
    
    /// <signature>#9 (Lsystem/ICloneable;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly; (LSystem/ICloneable;LSystem/Collections/ICollection;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly Load(system.ICloneable assemblyRef, system.collections.ICollection assemblySecurity);
    
    /// <signature>#10 (Ljava/lang/String;)Lsystem/reflection/Assembly; (Ljava/lang/String;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly Load(java.lang.String assemblyString);
    
    /// <signature>#11 (Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly; (Ljava/lang/String;LSystem/Collections/ICollection;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly Load(java.lang.String assemblyString, system.collections.ICollection assemblySecurity);
    
    /// <signature>#12 (Ljava/lang/String;)Lsystem/reflection/Assembly; (Ljava/lang/String;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly LoadFile(java.lang.String path);
    
    /// <signature>#13 (Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly; (Ljava/lang/String;LSystem/Collections/ICollection;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly LoadFile(java.lang.String path, system.collections.ICollection securityEvidence);
    
    /// <signature>#14 (Ljava/lang/String;)Lsystem/reflection/Assembly; (Ljava/lang/String;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly LoadFrom(java.lang.String assemblyFile);
    
    /// <signature>#15 (Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly; (Ljava/lang/String;LSystem/Collections/ICollection;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly LoadFrom(java.lang.String assemblyFile, system.collections.ICollection securityEvidence);
    
    /// <signature>#16 (Ljava/lang/String;Lsystem/collections/ICollection;[BLsystem/Enum;)Lsystem/reflection/Assembly; (Ljava/lang/String;LSystem/Collections/ICollection;[BLSystem/Enum;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly LoadFrom(java.lang.String assemblyFile, system.collections.ICollection securityEvidence, byte[] hashValue, system.Enum hashAlgorithm);
    
    /// <signature>#17 ([B)Lsystem/reflection/Assembly; ([B)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly ReflectionOnlyLoad(byte[] rawAssembly);
    
    /// <signature>#18 (Ljava/lang/String;)Lsystem/reflection/Assembly; (Ljava/lang/String;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly ReflectionOnlyLoad(java.lang.String assemblyString);
    
    /// <signature>#19 (Ljava/lang/String;)Lsystem/reflection/Assembly; (Ljava/lang/String;)LSystem/Reflection/Assembly;</signature>
    static public native system.reflection.Assembly ReflectionOnlyLoadFrom(java.lang.String assemblyFile);
    
    /// <signature>#20 (Lsystem/MulticastDelegate;)V (LSystem/MulticastDelegate;)V</signature>
    public native void addModuleResolve(system.MulticastDelegate value);
    
    /// <signature>#21 (Ljava/lang/String;)Ljava/lang/Object; (Ljava/lang/String;)Ljava/lang/Object;</signature>
    public native java.lang.Object CreateInstance(java.lang.String typeName);
    
    /// <signature>#22 (Ljava/lang/String;Z)Ljava/lang/Object; (Ljava/lang/String;Z)Ljava/lang/Object;</signature>
    public native java.lang.Object CreateInstance(java.lang.String typeName, boolean ignoreCase);
    
    /// <signature>#23 (Ljava/lang/String;ZLsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;[Ljava/lang/Object;)Ljava/lang/Object; (Ljava/lang/String;ZLSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;[Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public native java.lang.Object CreateInstance(java.lang.String typeName, boolean ignoreCase, system.reflection.BindingFlags bindingAttr, system.Object binder, java.lang.Object[] args, system.ICloneable culture, java.lang.Object[] activationAttributes);
    
    /// <signature>#24 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getCodeBase();
    
    /// <signature>#25 ()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
    public native system.reflection.MethodInfo getEntryPoint();
    
    /// <signature>#26 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getEscapedCodeBase();
    
    /// <signature>#27 ()Lsystem/collections/ICollection; ()LSystem/Collections/ICollection;</signature>
    public native system.collections.ICollection getEvidence();
    
    /// <signature>#28 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getFullName();
    
    /// <signature>#29 ()Z ()Z</signature>
    public native boolean getGlobalAssemblyCache();
    
    /// <signature>#30 ()J ()J</signature>
    public final native long getHostContext();
    
    /// <signature>#31 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getImageRuntimeVersion();
    
    /// <signature>#32 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public native java.lang.String getLocation();
    
    /// <signature>#33 ()Lsystem/runtime/serialization/ISerializable; ()LSystem/Runtime/Serialization/ISerializable;</signature>
    public final native system.runtime.serialization.ISerializable getManifestModule();
    
    /// <signature>#34 ()Z ()Z</signature>
    public native boolean getReflectionOnly();
    
    /// <signature>#35 (Z)[Ljava/lang/Object; (Z)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] GetCustomAttributes(boolean inherit);
    
    /// <signature>#36 (Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Ljava/lang/Object;</signature>
    public native java.lang.Object[] GetCustomAttributes(system.Type attributeType, boolean inherit);
    
    /// <signature>#37 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetExportedTypes();
    
    /// <signature>#38 (Ljava/lang/String;)Lsystem/io/FileStream; (Ljava/lang/String;)LSystem/IO/FileStream;</signature>
    public native system.io.FileStream GetFile(java.lang.String name);
    
    /// <signature>#39 ()[Lsystem/io/FileStream; ()[LSystem/IO/FileStream;</signature>
    public native system.io.FileStream[] GetFiles();
    
    /// <signature>#40 (Z)[Lsystem/io/FileStream; (Z)[LSystem/IO/FileStream;</signature>
    public native system.io.FileStream[] GetFiles(boolean getResourceModules);
    
    /// <signature>#41 ()[Lsystem/runtime/serialization/ISerializable; ()[LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable[] GetLoadedModules();
    
    /// <signature>#42 (Z)[Lsystem/runtime/serialization/ISerializable; (Z)[LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable[] GetLoadedModules(boolean getResourceModules);
    
    /// <signature>#43 (Ljava/lang/String;)Lsystem/Object; (Ljava/lang/String;)Lsystem/Object;</signature>
    public native system.Object GetManifestResourceInfo(java.lang.String resourceName);
    
    /// <signature>#44 ()[Ljava/lang/String; ()[Ljava/lang/String;</signature>
    public native java.lang.String[] GetManifestResourceNames();
    
    /// <signature>#45 (Ljava/lang/String;)Lsystem/io/Stream; (Ljava/lang/String;)LSystem/IO/Stream;</signature>
    public native system.io.Stream GetManifestResourceStream(java.lang.String name);
    
    /// <signature>#46 (Lsystem/Type;Ljava/lang/String;)Lsystem/io/Stream; (LSystem/Type;Ljava/lang/String;)LSystem/IO/Stream;</signature>
    public native system.io.Stream GetManifestResourceStream(system.Type type, java.lang.String name);
    
    /// <signature>#47 (Ljava/lang/String;)Lsystem/runtime/serialization/ISerializable; (Ljava/lang/String;)LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable GetModule(java.lang.String name);
    
    /// <signature>#48 ()[Lsystem/runtime/serialization/ISerializable; ()[LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable[] GetModules();
    
    /// <signature>#49 (Z)[Lsystem/runtime/serialization/ISerializable; (Z)[LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable[] GetModules(boolean getResourceModules);
    
    /// <signature>#50 ()Lsystem/ICloneable; ()LSystem/ICloneable;</signature>
    public native system.ICloneable GetName();
    
    /// <signature>#51 (Z)Lsystem/ICloneable; (Z)LSystem/ICloneable;</signature>
    public native system.ICloneable GetName(boolean copiedName);
    
    /// <signature>#52 (Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
    public native void GetObjectData(system.runtime.serialization.SerializationInfo info, system.runtime.serialization.StreamingContext context);
    
    /// <signature>#53 ()[Lsystem/ICloneable; ()[LSystem/ICloneable;</signature>
    public native system.ICloneable[] GetReferencedAssemblies();
    
    /// <signature>#54 (Lsystem/ICloneable;)Lsystem/reflection/Assembly; (LSystem/ICloneable;)LSystem/Reflection/Assembly;</signature>
    public native system.reflection.Assembly GetSatelliteAssembly(system.ICloneable culture);
    
    /// <signature>#55 (Lsystem/ICloneable;Lsystem/ICloneable;)Lsystem/reflection/Assembly; (LSystem/ICloneable;LSystem/ICloneable;)LSystem/Reflection/Assembly;</signature>
    public native system.reflection.Assembly GetSatelliteAssembly(system.ICloneable culture, system.ICloneable version);
    
    /// <signature>#56 (Ljava/lang/String;)Lsystem/Type; (Ljava/lang/String;)LSystem/Type;</signature>
    public native system.Type GetType(java.lang.String name);
    
    /// <signature>#57 (Ljava/lang/String;Z)Lsystem/Type; (Ljava/lang/String;Z)LSystem/Type;</signature>
    public native system.Type GetType(java.lang.String name, boolean throwOnError);
    
    /// <signature>#58 (Ljava/lang/String;ZZ)Lsystem/Type; (Ljava/lang/String;ZZ)LSystem/Type;</signature>
    public native system.Type GetType(java.lang.String name, boolean throwOnError, boolean ignoreCase);
    
    /// <signature>#59 ()[Lsystem/Type; ()[LSystem/Type;</signature>
    public native system.Type[] GetTypes();
    
    /// <signature>#60 (Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
    public native boolean IsDefined(system.Type attributeType, boolean inherit);
    
    /// <signature>#61 (Ljava/lang/String;[B)Lsystem/runtime/serialization/ISerializable; (Ljava/lang/String;[B)LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable LoadModule(java.lang.String moduleName, byte[] rawModule);
    
    /// <signature>#62 (Ljava/lang/String;[B[B)Lsystem/runtime/serialization/ISerializable; (Ljava/lang/String;[B[B)LSystem/Runtime/Serialization/ISerializable;</signature>
    public native system.runtime.serialization.ISerializable LoadModule(java.lang.String moduleName, byte[] rawModule, byte[] rawSymbolStore);
    
    /// <signature>#63 (Lsystem/MulticastDelegate;)V (LSystem/MulticastDelegate;)V</signature>
    public native void removeModuleResolve(system.MulticastDelegate value);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.Assembly_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.reflection.Assembly.class, system.reflection.Assembly.class, system.reflection.Assembly.class, new system.reflection.Assembly.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
