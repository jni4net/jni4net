// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.reflection;

@net.sf.jni4net.attributes.J4NProxy(system.reflection.BindingFlags.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public final class BindingFlags extends system.Enum
// <j4ni-BindingFlags>
// put user interfaces here
// </j4ni-BindingFlags>
{
    // <j4nb-BindingFlags> 
    // put user members here
    // </j4nb-BindingFlags>
    
    private BindingFlags(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.reflection.BindingFlags(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.reflection.BindingFlags.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags CreateInstance();
    
    /// <signature>#1 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags DeclaredOnly();
    
    /// <signature>#2 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags Default();
    
    /// <signature>#3 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags ExactBinding();
    
    /// <signature>#4 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags FlattenHierarchy();
    
    /// <signature>#5 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags GetField();
    
    /// <signature>#6 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags GetProperty();
    
    /// <signature>#7 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags IgnoreCase();
    
    /// <signature>#8 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags IgnoreReturn();
    
    /// <signature>#9 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags Instance();
    
    /// <signature>#10 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags InvokeMethod();
    
    /// <signature>#11 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags NonPublic();
    
    /// <signature>#12 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags OptionalParamBinding();
    
    /// <signature>#13 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags Public();
    
    /// <signature>#14 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags PutDispProperty();
    
    /// <signature>#15 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags PutRefDispProperty();
    
    /// <signature>#16 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags SetField();
    
    /// <signature>#17 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags SetProperty();
    
    /// <signature>#18 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags Static();
    
    /// <signature>#19 ()Lsystem/reflection/BindingFlags; ()LSystem/Reflection/BindingFlags;</signature>
    static public native system.reflection.BindingFlags SuppressChangeType();
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Reflection.BindingFlags_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.reflection.BindingFlags.class, system.reflection.BindingFlags.class, system.reflection.BindingFlags.class, new system.reflection.BindingFlags.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
