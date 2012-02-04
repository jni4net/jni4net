// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Delegate.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Delegate extends system.Object implements system.ICloneable, system.runtime.serialization.ISerializable
// <j4ni-Delegate>
// put user interfaces here
// </j4ni-Delegate>
{
    // <j4nb-Delegate> 
    // put user members here
    // </j4nb-Delegate>
    
    protected Delegate(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Delegate(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Delegate.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ([Lsystem/Delegate;)Lsystem/Delegate; ([LSystem/Delegate;)LSystem/Delegate;</signature>
    static public native system.Delegate Combine(system.Delegate[] delegates);
    
    /// <signature>#1 (Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate; (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;</signature>
    static public native system.Delegate Combine(system.Delegate a, system.Delegate b);
    
    /// <signature>#2 (Lsystem/Type;Ljava/lang/Object;Lsystem/reflection/MethodInfo;)Lsystem/Delegate; (LSystem/Type;Ljava/lang/Object;LSystem/Reflection/MethodInfo;)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, java.lang.Object firstArgument, system.reflection.MethodInfo method);
    
    /// <signature>#3 (Lsystem/Type;Ljava/lang/Object;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate; (LSystem/Type;Ljava/lang/Object;LSystem/Reflection/MethodInfo;Z)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, java.lang.Object firstArgument, system.reflection.MethodInfo method, boolean throwOnBindFailure);
    
    /// <signature>#4 (Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;)Lsystem/Delegate; (LSystem/Type;Ljava/lang/Object;Ljava/lang/String;)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, java.lang.Object target, java.lang.String method);
    
    /// <signature>#5 (Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;Z)Lsystem/Delegate; (LSystem/Type;Ljava/lang/Object;Ljava/lang/String;Z)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, java.lang.Object target, java.lang.String method, boolean ignoreCase);
    
    /// <signature>#6 (Lsystem/Type;Ljava/lang/Object;Ljava/lang/String;ZZ)Lsystem/Delegate; (LSystem/Type;Ljava/lang/Object;Ljava/lang/String;ZZ)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, java.lang.Object target, java.lang.String method, boolean ignoreCase, boolean throwOnBindFailure);
    
    /// <signature>#7 (Lsystem/Type;Lsystem/reflection/MethodInfo;)Lsystem/Delegate; (LSystem/Type;LSystem/Reflection/MethodInfo;)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, system.reflection.MethodInfo method);
    
    /// <signature>#8 (Lsystem/Type;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate; (LSystem/Type;LSystem/Reflection/MethodInfo;Z)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, system.reflection.MethodInfo method, boolean throwOnBindFailure);
    
    /// <signature>#9 (Lsystem/Type;Lsystem/Type;Ljava/lang/String;)Lsystem/Delegate; (LSystem/Type;LSystem/Type;Ljava/lang/String;)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, system.Type target, java.lang.String method);
    
    /// <signature>#10 (Lsystem/Type;Lsystem/Type;Ljava/lang/String;Z)Lsystem/Delegate; (LSystem/Type;LSystem/Type;Ljava/lang/String;Z)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, system.Type target, java.lang.String method, boolean ignoreCase);
    
    /// <signature>#11 (Lsystem/Type;Lsystem/Type;Ljava/lang/String;ZZ)Lsystem/Delegate; (LSystem/Type;LSystem/Type;Ljava/lang/String;ZZ)LSystem/Delegate;</signature>
    static public native system.Delegate CreateDelegate(system.Type type, system.Type target, java.lang.String method, boolean ignoreCase, boolean throwOnBindFailure);
    
    /// <signature>#12 (Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate; (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;</signature>
    static public native system.Delegate Remove(system.Delegate source, system.Delegate value);
    
    /// <signature>#13 (Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate; (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;</signature>
    static public native system.Delegate RemoveAll(system.Delegate source, system.Delegate value);
    
    /// <signature>#14 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public native java.lang.Object Clone();
    
    /// <signature>#15 ([Ljava/lang/Object;)Ljava/lang/Object; ([Ljava/lang/Object;)Ljava/lang/Object;</signature>
    public final native java.lang.Object DynamicInvoke(java.lang.Object[] args);
    
    /// <signature>#16 ()Lsystem/reflection/MethodInfo; ()LSystem/Reflection/MethodInfo;</signature>
    public final native system.reflection.MethodInfo getMethod();
    
    /// <signature>#17 ()Ljava/lang/Object; ()Ljava/lang/Object;</signature>
    public final native java.lang.Object getTarget();
    
    /// <signature>#18 ()[Lsystem/Delegate; ()[LSystem/Delegate;</signature>
    public native system.Delegate[] GetInvocationList();
    
    /// <signature>#19 (Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V</signature>
    public native void GetObjectData(system.runtime.serialization.SerializationInfo info, system.runtime.serialization.StreamingContext context);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Delegate_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.Delegate.class, system.Delegate.class, system.Delegate.class, new system.Delegate.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
