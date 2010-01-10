// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.reflection;

@net.sf.jni4net.attributes.ClrType
public class Assembly extends system.Object implements system.security.IEvidenceFactory, system.reflection.ICustomAttributeProvider, system.runtime.serialization.ISerializable {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected Assembly(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected Assembly() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Security/Policy/Evidence;")
    public native system.Object getEvidence();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)[LSystem/Object;")
    public native system.Object[] GetCustomAttributes(boolean inherit);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;Z)[LSystem/Object;")
    public native system.Object[] GetCustomAttributes(system.Type attributeType, boolean inherit);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;Z)Z")
    public native boolean IsDefined(system.Type attributeType, boolean inherit);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V")
    public native void GetObjectData(system.runtime.serialization.SerializationInfo info, system.runtime.serialization.StreamingContext context);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String ToString();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)Z")
    public native boolean Equals(system.Object other);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int GetHashCode();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Type;")
    public native system.Type GetType();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getCodeBase();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getEscapedCodeBase();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/AssemblyName;")
    public native system.Object GetName();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)LSystem/Reflection/AssemblyName;")
    public native system.Object GetName(boolean copiedName);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getFullName();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/MethodInfo;")
    public native system.reflection.MethodInfo getEntryPoint();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Type;")
    public native system.Type GetType(java.lang.String name);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;Z)LSystem/Type;")
    public native system.Type GetType(java.lang.String name, boolean throwOnError);
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Type;")
    public native system.Type[] GetExportedTypes();
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Type;")
    public native system.Type[] GetTypes();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/String;)LSystem/IO/Stream;")
    public native system.io.Stream GetManifestResourceStream(system.Type type, java.lang.String name);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/IO/Stream;")
    public native system.io.Stream GetManifestResourceStream(java.lang.String name);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/IO/FileStream;")
    public native system.io.FileStream GetFile(java.lang.String name);
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/IO/FileStream;")
    public native system.io.FileStream[] GetFiles();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)[LSystem/IO/FileStream;")
    public native system.io.FileStream[] GetFiles(boolean getResourceModules);
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/String;")
    public native java.lang.String[] GetManifestResourceNames();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Reflection/ManifestResourceInfo;")
    public native system.Object GetManifestResourceInfo(java.lang.String resourceName);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getLocation();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;ZZ)LSystem/Type;")
    public native system.Type GetType(java.lang.String name, boolean throwOnError, boolean ignoreCase);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Globalization/CultureInfo;)LSystem/Reflection/Assembly;")
    public native system.reflection.Assembly GetSatelliteAssembly(system.Object culture);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Globalization/CultureInfo;LSystem/Version;)LSystem/Reflection/Assembly;")
    public native system.reflection.Assembly GetSatelliteAssembly(system.Object culture, system.Object version);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;[B)LSystem/Reflection/Module;")
    public native system.Object LoadModule(java.lang.String moduleName, byte[] rawModule);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;[B[B)LSystem/Reflection/Module;")
    public native system.Object LoadModule(java.lang.String moduleName, byte[] rawModule, byte[] rawSymbolStore);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Object;")
    public native system.Object CreateInstance(java.lang.String typeName);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;Z)LSystem/Object;")
    public native system.Object CreateInstance(java.lang.String typeName, boolean ignoreCase);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;ZLSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;[LSystem/Object;)LSystem/Object;")
    public native system.Object CreateInstance(java.lang.String typeName, boolean ignoreCase, system.reflection.BindingFlags bindingAttr, system.Object binder, system.Object[] args, system.Object culture, system.Object[] activationAttributes);
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Reflection/Module;")
    public native system.Object[] GetLoadedModules();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)[LSystem/Reflection/Module;")
    public native system.Object[] GetLoadedModules(boolean getResourceModules);
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Reflection/Module;")
    public native system.Object[] GetModules();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)[LSystem/Reflection/Module;")
    public native system.Object[] GetModules(boolean getResourceModules);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Reflection/Module;")
    public native system.Object GetModule(java.lang.String name);
    
    @net.sf.jni4net.attributes.ClrMethod("()[LSystem/Reflection/AssemblyName;")
    public native system.Object[] GetReferencedAssemblies();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getGlobalAssemblyCache();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/String;)LSystem/String;")
    public native static java.lang.String CreateQualifiedName(java.lang.String assemblyName, java.lang.String typeName);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly GetAssembly(system.Type type);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/Module;")
    public native system.Object getManifestModule();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly LoadFrom(java.lang.String assemblyFile);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly ReflectionOnlyLoadFrom(java.lang.String assemblyFile);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly LoadFrom(java.lang.String assemblyFile, system.Object securityEvidence);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Security/Policy/Evidence;[BLSystem/Configuration/Assemblies/AssemblyHashAlgorithm;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly LoadFrom(java.lang.String assemblyFile, system.Object securityEvidence, byte[] hashValue, system.Enum hashAlgorithm);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly Load(java.lang.String assemblyString);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly ReflectionOnlyLoad(java.lang.String assemblyString);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly Load(java.lang.String assemblyString, system.Object assemblySecurity);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Reflection/AssemblyName;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly Load(system.Object assemblyRef);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Reflection/AssemblyName;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly Load(system.Object assemblyRef, system.Object assemblySecurity);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly LoadWithPartialName(java.lang.String partialName);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly LoadWithPartialName(java.lang.String partialName, system.Object securityEvidence);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getReflectionOnly();
    
    @net.sf.jni4net.attributes.ClrMethod("([B)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly Load(byte[] rawAssembly);
    
    @net.sf.jni4net.attributes.ClrMethod("([B)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly ReflectionOnlyLoad(byte[] rawAssembly);
    
    @net.sf.jni4net.attributes.ClrMethod("([B[B)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
    
    @net.sf.jni4net.attributes.ClrMethod("([B[BLSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, system.Object securityEvidence);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly LoadFile(java.lang.String path);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly LoadFile(java.lang.String path, system.Object securityEvidence);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly GetExecutingAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly GetCallingAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/Assembly;")
    public native static system.reflection.Assembly GetEntryAssembly();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/String;")
    public native java.lang.String getImageRuntimeVersion();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native long getHostContext();
    
    public static system.Type typeof() {
        return system.reflection.Assembly.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.reflection.Assembly.staticType = staticType;
    }
    //</generated-proxy>
}