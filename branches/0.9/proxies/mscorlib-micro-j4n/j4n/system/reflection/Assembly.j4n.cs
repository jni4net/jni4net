// This code was generated using jni4net. See http://jni4net.sourceforge.net/

#region Component Designer generated code
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantCast
// ReSharper disable RedundantCommaInArrayInitializer
// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable UnassignedField.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable SuggestUseVarKeywordEvident
// ReSharper disable PossibleMultipleEnumeration
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedMember.Global
#pragma warning disable 109
#pragma warning disable 649
#pragma warning disable 618

namespace System.Reflection
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(System.Reflection.Assembly_))]
    static public partial class Assembly_
    {
        static Assembly_()
        {
            global::net.sf.jni4net.modules.mscorlibmicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Object_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Security.IEvidenceFactory_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Security.IEvidenceFactory_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Reflection.ICustomAttributeProvider_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Reflection.ICustomAttributeProvider_));
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(global::System.Runtime.Serialization.ISerializable_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(System.Reflection.Assembly_));
        }
        
        static private global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static private global::java.lang.IClass j4n_Class;
        
        static private global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        new static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        /// <signature>#0 CreateQualifiedName(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String; (Lsystem/String;Lsystem/String;)Lsystem/String;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyName, global::System.IntPtr typeName)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.CreateQualifiedName(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, assemblyName), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, typeName)), "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#1 GetAssembly(Lsystem/Type;)Lsystem/reflection/Assembly; (LSystem/Type;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_1(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr type)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.GetAssembly(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#2 GetCallingAssembly()Lsystem/reflection/Assembly; ()LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_2(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.GetCallingAssembly(), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#3 GetEntryAssembly()Lsystem/reflection/Assembly; ()LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_3(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.GetEntryAssembly(), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#4 GetExecutingAssembly()Lsystem/reflection/Assembly; ()LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_4(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.GetExecutingAssembly(), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#5 Load([B)Lsystem/reflection/Assembly; ([B)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_5(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr rawAssembly)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.Load(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawAssembly)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#6 Load([B[B)Lsystem/reflection/Assembly; ([B[B)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_6(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr rawAssembly, global::System.IntPtr rawSymbolStore)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.Load(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawAssembly), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawSymbolStore)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#7 Load([B[BLsystem/collections/ICollection;)Lsystem/reflection/Assembly; ([B[BLSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_7(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr rawAssembly, global::System.IntPtr rawSymbolStore, global::System.IntPtr securityEvidence)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.Load(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawAssembly), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawSymbolStore), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.Policy.Evidence>(j4n_env, securityEvidence)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#8 Load(Lsystem/ICloneable;)Lsystem/reflection/Assembly; (LSystem/Reflection/AssemblyName;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_8(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyRef)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.Load(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.AssemblyName>(j4n_env, assemblyRef)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#9 Load(Lsystem/ICloneable;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly; (LSystem/Reflection/AssemblyName;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_9(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyRef, global::System.IntPtr assemblySecurity)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.Load(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.AssemblyName>(j4n_env, assemblyRef), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.Policy.Evidence>(j4n_env, assemblySecurity)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#10 Load(Ljava/lang/String;)Lsystem/reflection/Assembly; (Lsystem/String;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_10(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyString)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.Load(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, assemblyString)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#11 Load(Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly; (Lsystem/String;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_11(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyString, global::System.IntPtr assemblySecurity)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.Load(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, assemblyString), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.Policy.Evidence>(j4n_env, assemblySecurity)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#12 LoadFile(Ljava/lang/String;)Lsystem/reflection/Assembly; (Lsystem/String;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_12(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr path)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.LoadFile(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#13 LoadFile(Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly; (Lsystem/String;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_13(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr path, global::System.IntPtr securityEvidence)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.LoadFile(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, path), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.Policy.Evidence>(j4n_env, securityEvidence)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#14 LoadFrom(Ljava/lang/String;)Lsystem/reflection/Assembly; (Lsystem/String;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_14(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyFile)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.LoadFrom(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, assemblyFile)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#15 LoadFrom(Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly; (Lsystem/String;LSystem/Security/Policy/Evidence;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_15(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyFile, global::System.IntPtr securityEvidence)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.LoadFrom(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, assemblyFile), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.Policy.Evidence>(j4n_env, securityEvidence)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#16 LoadFrom(Ljava/lang/String;Lsystem/collections/ICollection;[BLsystem/Enum;)Lsystem/reflection/Assembly; (Lsystem/String;LSystem/Security/Policy/Evidence;[BLSystem/Configuration/Assemblies/AssemblyHashAlgorithm;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_16(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyFile, global::System.IntPtr securityEvidence, global::System.IntPtr hashValue, global::System.IntPtr hashAlgorithm)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 18);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.LoadFrom(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, assemblyFile), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.Policy.Evidence>(j4n_env, securityEvidence), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, hashValue), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Configuration.Assemblies.AssemblyHashAlgorithm>(j4n_env, hashAlgorithm)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#17 ReflectionOnlyLoad([B)Lsystem/reflection/Assembly; ([B)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_17(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr rawAssembly)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.ReflectionOnlyLoad(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawAssembly)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#18 ReflectionOnlyLoad(Ljava/lang/String;)Lsystem/reflection/Assembly; (Lsystem/String;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_18(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyString)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.ReflectionOnlyLoad(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, assemblyString)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#19 ReflectionOnlyLoadFrom(Ljava/lang/String;)Lsystem/reflection/Assembly; (Lsystem/String;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_19(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_clazz, global::System.IntPtr assemblyFile)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, global::System.Reflection.Assembly.ReflectionOnlyLoadFrom(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, assemblyFile)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#20 add_ModuleResolve(Lsystem/MulticastDelegate;)V (LSystem/Reflection/ModuleResolveEventHandler;)V</signature>
        static void j4n_20(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_real.ModuleResolve += global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ModuleResolveEventHandler>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#21 CreateInstance(Ljava/lang/String;)Ljava/lang/Object; (Lsystem/String;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_21(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr typeName)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, typeName)), "java.lang.Object");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#22 CreateInstance(Ljava/lang/String;Z)Ljava/lang/Object; (Lsystem/String;Z)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_22(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr typeName, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, typeName), ignoreCase), "java.lang.Object");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#23 CreateInstance(Ljava/lang/String;ZLsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;[Ljava/lang/Object;)Ljava/lang/Object; (Lsystem/String;ZLSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[Lsystem/Object;LSystem/Globalization/CultureInfo;[Lsystem/Object;)Lsystem/Object;</signature>
        static global::System.IntPtr j4n_23(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr typeName, bool ignoreCase, global::System.IntPtr bindingAttr, global::System.IntPtr binder, global::System.IntPtr args, global::System.IntPtr culture, global::System.IntPtr activationAttributes)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 24);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.CreateInstance(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, typeName), ignoreCase, global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.BindingFlags>(j4n_env, bindingAttr), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Binder>(j4n_env, binder), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, args), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<object[]>(j4n_env, activationAttributes)), "java.lang.Object");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#24 get_CodeBase()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_24(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.CodeBase, "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#25 get_EntryPoint()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
        static global::System.IntPtr j4n_25(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.EntryPoint, "system.reflection.MethodInfo");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#26 get_EscapedCodeBase()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_26(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.EscapedCodeBase, "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#27 get_Evidence()Lsystem/collections/ICollection; ()LSystem/Security/Policy/Evidence;</signature>
        static global::System.IntPtr j4n_27(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Security.IEvidenceFactory j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Security.IEvidenceFactory>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Evidence, "system.collections.ICollection");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#28 get_FullName()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_28(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.FullName, "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#29 get_GlobalAssemblyCache()Z ()Z</signature>
        static bool j4n_29(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.GlobalAssemblyCache;
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(bool);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#30 get_HostContext()J ()J</signature>
        static long j4n_30(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                long j4n_result = j4n_real.HostContext;
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(long);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#31 get_ImageRuntimeVersion()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_31(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ImageRuntimeVersion, "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#32 get_Location()Ljava/lang/String; ()Lsystem/String;</signature>
        static global::System.IntPtr j4n_32(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.Location, "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#33 get_ManifestModule()Lsystem/runtime/serialization/ISerializable; ()LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_33(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.ManifestModule, "system.runtime.serialization.ISerializable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#34 get_ReflectionOnly()Z ()Z</signature>
        static bool j4n_34(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.ReflectionOnly;
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(bool);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#35 GetCustomAttributes(Z)[Ljava/lang/Object; (Z)[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_35(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetCustomAttributes(inherit), "java.lang.Object");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#36 GetCustomAttributes(Lsystem/Type;Z)[Ljava/lang/Object; (LSystem/Type;Z)[Lsystem/Object;</signature>
        static global::System.IntPtr j4n_36(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr attributeType, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetCustomAttributes(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, attributeType), inherit), "java.lang.Object");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#37 GetExportedTypes()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_37(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetExportedTypes(), "system.Type");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#38 GetFile(Ljava/lang/String;)Lsystem/io/FileStream; (Lsystem/String;)LSystem/IO/FileStream;</signature>
        static global::System.IntPtr j4n_38(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetFile(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.io.FileStream");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#39 GetFiles()[Lsystem/io/FileStream; ()[LSystem/IO/FileStream;</signature>
        static global::System.IntPtr j4n_39(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetFiles(), "system.io.FileStream");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#40 GetFiles(Z)[Lsystem/io/FileStream; (Z)[LSystem/IO/FileStream;</signature>
        static global::System.IntPtr j4n_40(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool getResourceModules)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetFiles(getResourceModules), "system.io.FileStream");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#41 GetLoadedModules()[Lsystem/runtime/serialization/ISerializable; ()[LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_41(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetLoadedModules(), "system.runtime.serialization.ISerializable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#42 GetLoadedModules(Z)[Lsystem/runtime/serialization/ISerializable; (Z)[LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_42(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool getResourceModules)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetLoadedModules(getResourceModules), "system.runtime.serialization.ISerializable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#43 GetManifestResourceInfo(Ljava/lang/String;)Lsystem/Object; (Lsystem/String;)LSystem/Reflection/ManifestResourceInfo;</signature>
        static global::System.IntPtr j4n_43(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr resourceName)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetManifestResourceInfo(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, resourceName)), "system.Object");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#44 GetManifestResourceNames()[Ljava/lang/String; ()[Lsystem/String;</signature>
        static global::System.IntPtr j4n_44(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetManifestResourceNames(), "java.lang.String");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#45 GetManifestResourceStream(Ljava/lang/String;)Lsystem/io/Stream; (Lsystem/String;)LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_45(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetManifestResourceStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.io.Stream");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#46 GetManifestResourceStream(Lsystem/Type;Ljava/lang/String;)Lsystem/io/Stream; (LSystem/Type;Lsystem/String;)LSystem/IO/Stream;</signature>
        static global::System.IntPtr j4n_46(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr type, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetManifestResourceStream(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, type), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.io.Stream");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#47 GetModule(Ljava/lang/String;)Lsystem/runtime/serialization/ISerializable; (Lsystem/String;)LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_47(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetModule(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.runtime.serialization.ISerializable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#48 GetModules()[Lsystem/runtime/serialization/ISerializable; ()[LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_48(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetModules(), "system.runtime.serialization.ISerializable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#49 GetModules(Z)[Lsystem/runtime/serialization/ISerializable; (Z)[LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_49(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool getResourceModules)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetModules(getResourceModules), "system.runtime.serialization.ISerializable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#50 GetName()Lsystem/ICloneable; ()LSystem/Reflection/AssemblyName;</signature>
        static global::System.IntPtr j4n_50(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetName(), "system.ICloneable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#51 GetName(Z)Lsystem/ICloneable; (Z)LSystem/Reflection/AssemblyName;</signature>
        static global::System.IntPtr j4n_51(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, bool copiedName)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetName(copiedName), "system.ICloneable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#52 GetObjectData(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
        static void j4n_52(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr info, global::System.IntPtr context)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Runtime.Serialization.ISerializable j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.ISerializable>(j4n_env, j4n_self);
                j4n_real.GetObjectData(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.SerializationInfo>(j4n_env, info), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Runtime.Serialization.StreamingContext>(j4n_env, context));
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#53 GetReferencedAssemblies()[Lsystem/ICloneable; ()[LSystem/Reflection/AssemblyName;</signature>
        static global::System.IntPtr j4n_53(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetReferencedAssemblies(), "system.ICloneable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#54 GetSatelliteAssembly(Lsystem/ICloneable;)Lsystem/reflection/Assembly; (LSystem/Globalization/CultureInfo;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_54(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr culture)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetSatelliteAssembly(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#55 GetSatelliteAssembly(Lsystem/ICloneable;Lsystem/ICloneable;)Lsystem/reflection/Assembly; (LSystem/Globalization/CultureInfo;LSystem/Version;)LSystem/Reflection/Assembly;</signature>
        static global::System.IntPtr j4n_55(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr culture, global::System.IntPtr version)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetSatelliteAssembly(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Globalization.CultureInfo>(j4n_env, culture), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Version>(j4n_env, version)), "system.reflection.Assembly");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#56 GetType(Ljava/lang/String;)Lsystem/Type; (Lsystem/String;)LSystem/Type;</signature>
        static global::System.IntPtr j4n_56(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name)), "system.Type");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#57 GetType(Ljava/lang/String;Z)Lsystem/Type; (Lsystem/String;Z)LSystem/Type;</signature>
        static global::System.IntPtr j4n_57(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, bool throwOnError)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), throwOnError), "system.Type");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#58 GetType(Ljava/lang/String;ZZ)Lsystem/Type; (Lsystem/String;ZZ)LSystem/Type;</signature>
        static global::System.IntPtr j4n_58(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr name, bool throwOnError, bool ignoreCase)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetType(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, name), throwOnError, ignoreCase), "system.Type");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#59 GetTypes()[Lsystem/Type; ()[LSystem/Type;</signature>
        static global::System.IntPtr j4n_59(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.GetTypes(), "system.Type");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#60 IsDefined(Lsystem/Type;Z)Z (LSystem/Type;Z)Z</signature>
        static bool j4n_60(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr attributeType, bool inherit)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.ICustomAttributeProvider j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ICustomAttributeProvider>(j4n_env, j4n_self);
                bool j4n_result = j4n_real.IsDefined(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Type>(j4n_env, attributeType), inherit);
                return j4n_result;
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(bool);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        /// <signature>#61 LoadModule(Ljava/lang/String;[B)Lsystem/runtime/serialization/ISerializable; (Lsystem/String;[B)LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_61(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr moduleName, global::System.IntPtr rawModule)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 14);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.LoadModule(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, moduleName), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawModule)), "system.runtime.serialization.ISerializable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#62 LoadModule(Ljava/lang/String;[B[B)Lsystem/runtime/serialization/ISerializable; (Lsystem/String;[B[B)LSystem/Reflection/Module;</signature>
        static global::System.IntPtr j4n_62(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr moduleName, global::System.IntPtr rawModule, global::System.IntPtr rawSymbolStore)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 16);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.LoadModule(global::net.sf.jni4net.core.ConvertAbstract.ToCLR<string>(j4n_env, moduleName), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawModule), global::net.sf.jni4net.core.ConvertAbstract.ToCLR<byte[]>(j4n_env, rawSymbolStore)), "system.runtime.serialization.ISerializable");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        /// <signature>#63 remove_ModuleResolve(Lsystem/MulticastDelegate;)V (LSystem/Reflection/ModuleResolveEventHandler;)V</signature>
        static void j4n_63(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self, global::System.IntPtr value)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 12);
            try
            {
                global::System.Reflection.Assembly j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.Assembly>(j4n_env, j4n_self);
                j4n_real.ModuleResolve -= global::net.sf.jni4net.core.ConvertAbstract.ToCLR<global::System.Reflection.ModuleResolveEventHandler>(j4n_env, value);
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
            }
            finally{
                j4n_frame.Dispose();
            }
        }
        
        new static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::System.Reflection.Assembly))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = true;
                    proxyInfo.IsInterface = false;
                    proxyInfo.JVMApiName = "system.reflection.Assembly";
                    proxyInfo.JVMProxyName = "system.reflection.Assembly";
                    proxyInfo.JVMStaticApiName = "system.reflection.Assembly";
                    proxyInfo.CLRApi = typeof(System.Reflection.Assembly);
                    proxyInfo.CLRStaticApi = typeof(System.Reflection.Assembly_);
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("CreateQualifiedName","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, true), // #0 (Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetAssembly","(Lsystem/Type;)Lsystem/reflection/Assembly;", false, true), // #1 (LSystem/Type;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("GetCallingAssembly","()Lsystem/reflection/Assembly;", false, true), // #2 ()LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("GetEntryAssembly","()Lsystem/reflection/Assembly;", false, true), // #3 ()LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("GetExecutingAssembly","()Lsystem/reflection/Assembly;", false, true), // #4 ()LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("Load","([B)Lsystem/reflection/Assembly;", false, true), // #5 ([B)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("Load","([B[B)Lsystem/reflection/Assembly;", false, true), // #6 ([B[B)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("Load","([B[BLsystem/collections/ICollection;)Lsystem/reflection/Assembly;", false, true), // #7 ([B[BLSystem/Collections/ICollection;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("Load","(Lsystem/ICloneable;)Lsystem/reflection/Assembly;", false, true), // #8 (LSystem/ICloneable;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("Load","(Lsystem/ICloneable;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly;", false, true), // #9 (LSystem/ICloneable;LSystem/Collections/ICollection;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("Load","(Ljava/lang/String;)Lsystem/reflection/Assembly;", false, true), // #10 (Ljava/lang/String;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("Load","(Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly;", false, true), // #11 (Ljava/lang/String;LSystem/Collections/ICollection;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("LoadFile","(Ljava/lang/String;)Lsystem/reflection/Assembly;", false, true), // #12 (Ljava/lang/String;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("LoadFile","(Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly;", false, true), // #13 (Ljava/lang/String;LSystem/Collections/ICollection;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("LoadFrom","(Ljava/lang/String;)Lsystem/reflection/Assembly;", false, true), // #14 (Ljava/lang/String;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("LoadFrom","(Ljava/lang/String;Lsystem/collections/ICollection;)Lsystem/reflection/Assembly;", false, true), // #15 (Ljava/lang/String;LSystem/Collections/ICollection;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("LoadFrom","(Ljava/lang/String;Lsystem/collections/ICollection;[BLsystem/Enum;)Lsystem/reflection/Assembly;", false, true), // #16 (Ljava/lang/String;LSystem/Collections/ICollection;[BLSystem/Enum;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("ReflectionOnlyLoad","([B)Lsystem/reflection/Assembly;", false, true), // #17 ([B)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("ReflectionOnlyLoad","(Ljava/lang/String;)Lsystem/reflection/Assembly;", false, true), // #18 (Ljava/lang/String;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("ReflectionOnlyLoadFrom","(Ljava/lang/String;)Lsystem/reflection/Assembly;", false, true), // #19 (Ljava/lang/String;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("addModuleResolve","(Lsystem/MulticastDelegate;)V", false, false), // #20 (LSystem/MulticastDelegate;)V
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Ljava/lang/String;)Ljava/lang/Object;", false, false), // #21 (Ljava/lang/String;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Ljava/lang/String;Z)Ljava/lang/Object;", false, false), // #22 (Ljava/lang/String;Z)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("CreateInstance","(Ljava/lang/String;ZLsystem/reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;Lsystem/ICloneable;[Ljava/lang/Object;)Ljava/lang/Object;", false, false), // #23 (Ljava/lang/String;ZLSystem/Reflection/BindingFlags;Lsystem/Object;[Ljava/lang/Object;LSystem/ICloneable;[Ljava/lang/Object;)Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("getCodeBase","()Ljava/lang/String;", false, false), // #24 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getEntryPoint","()Lsystem/reflection/MethodInfo;", false, false), // #25 ()LSystem/Reflection/MethodInfo;
                        new global::net.sf.jni4net.core.MemberId("getEscapedCodeBase","()Ljava/lang/String;", false, false), // #26 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getEvidence","()Lsystem/collections/ICollection;", false, false), // #27 ()LSystem/Collections/ICollection;
                        new global::net.sf.jni4net.core.MemberId("getFullName","()Ljava/lang/String;", false, false), // #28 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getGlobalAssemblyCache","()Z", false, false), // #29 ()Z
                        new global::net.sf.jni4net.core.MemberId("getHostContext","()J", false, false), // #30 ()J
                        new global::net.sf.jni4net.core.MemberId("getImageRuntimeVersion","()Ljava/lang/String;", false, false), // #31 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getLocation","()Ljava/lang/String;", false, false), // #32 ()Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("getManifestModule","()Lsystem/runtime/serialization/ISerializable;", false, false), // #33 ()LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("getReflectionOnly","()Z", false, false), // #34 ()Z
                        new global::net.sf.jni4net.core.MemberId("GetCustomAttributes","(Z)[Ljava/lang/Object;", false, false), // #35 (Z)[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetCustomAttributes","(Lsystem/Type;Z)[Ljava/lang/Object;", false, false), // #36 (LSystem/Type;Z)[Ljava/lang/Object;
                        new global::net.sf.jni4net.core.MemberId("GetExportedTypes","()[Lsystem/Type;", false, false), // #37 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetFile","(Ljava/lang/String;)Lsystem/io/FileStream;", false, false), // #38 (Ljava/lang/String;)LSystem/IO/FileStream;
                        new global::net.sf.jni4net.core.MemberId("GetFiles","()[Lsystem/io/FileStream;", false, false), // #39 ()[LSystem/IO/FileStream;
                        new global::net.sf.jni4net.core.MemberId("GetFiles","(Z)[Lsystem/io/FileStream;", false, false), // #40 (Z)[LSystem/IO/FileStream;
                        new global::net.sf.jni4net.core.MemberId("GetLoadedModules","()[Lsystem/runtime/serialization/ISerializable;", false, false), // #41 ()[LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("GetLoadedModules","(Z)[Lsystem/runtime/serialization/ISerializable;", false, false), // #42 (Z)[LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("GetManifestResourceInfo","(Ljava/lang/String;)Lsystem/Object;", false, false), // #43 (Ljava/lang/String;)Lsystem/Object;
                        new global::net.sf.jni4net.core.MemberId("GetManifestResourceNames","()[Ljava/lang/String;", false, false), // #44 ()[Ljava/lang/String;
                        new global::net.sf.jni4net.core.MemberId("GetManifestResourceStream","(Ljava/lang/String;)Lsystem/io/Stream;", false, false), // #45 (Ljava/lang/String;)LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("GetManifestResourceStream","(Lsystem/Type;Ljava/lang/String;)Lsystem/io/Stream;", false, false), // #46 (LSystem/Type;Ljava/lang/String;)LSystem/IO/Stream;
                        new global::net.sf.jni4net.core.MemberId("GetModule","(Ljava/lang/String;)Lsystem/runtime/serialization/ISerializable;", false, false), // #47 (Ljava/lang/String;)LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("GetModules","()[Lsystem/runtime/serialization/ISerializable;", false, false), // #48 ()[LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("GetModules","(Z)[Lsystem/runtime/serialization/ISerializable;", false, false), // #49 (Z)[LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("GetName","()Lsystem/ICloneable;", false, false), // #50 ()LSystem/ICloneable;
                        new global::net.sf.jni4net.core.MemberId("GetName","(Z)Lsystem/ICloneable;", false, false), // #51 (Z)LSystem/ICloneable;
                        new global::net.sf.jni4net.core.MemberId("GetObjectData","(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V", false, false), // #52 (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V
                        new global::net.sf.jni4net.core.MemberId("GetReferencedAssemblies","()[Lsystem/ICloneable;", false, false), // #53 ()[LSystem/ICloneable;
                        new global::net.sf.jni4net.core.MemberId("GetSatelliteAssembly","(Lsystem/ICloneable;)Lsystem/reflection/Assembly;", false, false), // #54 (LSystem/ICloneable;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("GetSatelliteAssembly","(Lsystem/ICloneable;Lsystem/ICloneable;)Lsystem/reflection/Assembly;", false, false), // #55 (LSystem/ICloneable;LSystem/ICloneable;)LSystem/Reflection/Assembly;
                        new global::net.sf.jni4net.core.MemberId("GetType","(Ljava/lang/String;)Lsystem/Type;", false, false), // #56 (Ljava/lang/String;)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetType","(Ljava/lang/String;Z)Lsystem/Type;", false, false), // #57 (Ljava/lang/String;Z)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetType","(Ljava/lang/String;ZZ)Lsystem/Type;", false, false), // #58 (Ljava/lang/String;ZZ)LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("GetTypes","()[Lsystem/Type;", false, false), // #59 ()[LSystem/Type;
                        new global::net.sf.jni4net.core.MemberId("IsDefined","(Lsystem/Type;Z)Z", false, false), // #60 (LSystem/Type;Z)Z
                        new global::net.sf.jni4net.core.MemberId("LoadModule","(Ljava/lang/String;[B)Lsystem/runtime/serialization/ISerializable;", false, false), // #61 (Ljava/lang/String;[B)LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("LoadModule","(Ljava/lang/String;[B[B)Lsystem/runtime/serialization/ISerializable;", false, false), // #62 (Ljava/lang/String;[B[B)LSystem/Runtime/Serialization/ISerializable;
                        new global::net.sf.jni4net.core.MemberId("removeModuleResolve","(Lsystem/MulticastDelegate;)V", false, false), // #63 (LSystem/MulticastDelegate;)V
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
}

#endregion Component Designer generated code
