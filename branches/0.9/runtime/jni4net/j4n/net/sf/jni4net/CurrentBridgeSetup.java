// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package net.sf.jni4net;

@net.sf.jni4net.attributes.J4NProxy(net.sf.jni4net.CurrentBridgeSetup.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class CurrentBridgeSetup extends system.Object
// <j4ni-CurrentBridgeSetup>
// put user interfaces here
// </j4ni-CurrentBridgeSetup>
{
    // <j4nb-CurrentBridgeSetup> 
    // put user members here
    // </j4nb-CurrentBridgeSetup>
    
    protected CurrentBridgeSetup(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new net.sf.jni4net.CurrentBridgeSetup(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        net.sf.jni4net.CurrentBridgeSetup.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (Lsystem/Object;)V (Lsystem/Object;)V</signature>
    public final native void AddLogListener(system.Object listener);
    
    /// <signature>#1 ()Z ()Z</signature>
    public final native boolean getAllowJVMJoin();
    
    /// <signature>#2 ()Z ()Z</signature>
    public final native boolean getAutoCreateLocalFrame();
    
    /// <signature>#3 ()Z ()Z</signature>
    public final native boolean getBindClrProxies();
    
    /// <signature>#4 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getCLRCoreAssembly();
    
    /// <signature>#5 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getCLRCoreDllLocation();
    
    /// <signature>#6 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getCLRCoreJarLocation();
    
    /// <signature>#7 ()Lsystem/Object; ()Lsystem/Object;</signature>
    public final native system.Object getDefaultClassLoader();
    
    /// <signature>#8 ()Z ()Z</signature>
    public final native boolean getDisableJavaHomeDetection();
    
    /// <signature>#9 ()Z ()Z</signature>
    public final native boolean getEnforceImmediateBinding();
    
    /// <signature>#10 ()Z ()Z</signature>
    public final native boolean getEnforceThreadDetach();
    
    /// <signature>#11 ()Z ()Z</signature>
    public final native boolean getHideJNIFromStackTrace();
    
    /// <signature>#12 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getJ4NAssembly();
    
    /// <signature>#13 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getJ4NDllLocation();
    
    /// <signature>#14 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getJ4NJarLocation();
    
    /// <signature>#15 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getJavaHome();
    
    /// <signature>#16 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getJVMCoreAssembly();
    
    /// <signature>#17 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getJVMCoreDllLocation();
    
    /// <signature>#18 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getJVMCoreJarLocation();
    
    /// <signature>#19 ()Lnet/sf/jni4net/LogLevel; ()Lnet/sf/jni4net/LogLevel;</signature>
    public final native net.sf.jni4net.LogLevel getLogLevel();
    
    /// <signature>#20 (Z)V (Z)V</signature>
    public final native void setAllowJVMJoin(boolean value);
    
    /// <signature>#21 (Z)V (Z)V</signature>
    public final native void setAutoCreateLocalFrame(boolean value);
    
    /// <signature>#22 (Z)V (Z)V</signature>
    public final native void setBindClrProxies(boolean value);
    
    /// <signature>#23 (Lsystem/Object;)V (Lsystem/Object;)V</signature>
    public final native void setDefaultClassLoader(system.Object value);
    
    /// <signature>#24 (Z)V (Z)V</signature>
    public final native void setDisableJavaHomeDetection(boolean value);
    
    /// <signature>#25 (Z)V (Z)V</signature>
    public final native void setEnforceImmediateBinding(boolean value);
    
    /// <signature>#26 (Z)V (Z)V</signature>
    public final native void setEnforceThreadDetach(boolean value);
    
    /// <signature>#27 (Z)V (Z)V</signature>
    public final native void setHideJNIFromStackTrace(boolean value);
    
    /// <signature>#28 (Lnet/sf/jni4net/LogLevel;)V (Lnet/sf/jni4net/LogLevel;)V</signature>
    public final native void setLogLevel(net.sf.jni4net.LogLevel value);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "net.sf.jni4net.CurrentBridgeSetup_, " + net.sf.jni4net.modules.jni4net.assemblyName, net.sf.jni4net.CurrentBridgeSetup.class, net.sf.jni4net.CurrentBridgeSetup.class, net.sf.jni4net.CurrentBridgeSetup.class, new net.sf.jni4net.CurrentBridgeSetup.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
