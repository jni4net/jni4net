// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system;

@net.sf.jni4net.attributes.J4NProxy(system.Environment.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Environment extends system.Object
// <j4ni-Environment>
// put user interfaces here
// </j4ni-Environment>
{
    // <j4nb-Environment> 
    // put user members here
    // </j4nb-Environment>
    
    private Environment(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.Environment(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.Environment.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 (I)V (I)V</signature>
    static public native void Exit(int exitCode);
    
    /// <signature>#1 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String ExpandEnvironmentVariables(java.lang.String name);
    
    /// <signature>#2 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    static public native void FailFast(java.lang.String message);
    
    /// <signature>#3 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getCommandLine();
    
    /// <signature>#4 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getCurrentDirectory();
    
    /// <signature>#5 ()I ()I</signature>
    static public native int getExitCode();
    
    /// <signature>#6 ()Z ()Z</signature>
    static public native boolean getHasShutdownStarted();
    
    /// <signature>#7 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getMachineName();
    
    /// <signature>#8 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getNewLine();
    
    /// <signature>#9 ()Lsystem/ICloneable; ()LSystem/ICloneable;</signature>
    static public native system.ICloneable getOSVersion();
    
    /// <signature>#10 ()I ()I</signature>
    static public native int getProcessorCount();
    
    /// <signature>#11 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getStackTrace();
    
    /// <signature>#12 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getSystemDirectory();
    
    /// <signature>#13 ()I ()I</signature>
    static public native int getTickCount();
    
    /// <signature>#14 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getUserDomainName();
    
    /// <signature>#15 ()Z ()Z</signature>
    static public native boolean getUserInteractive();
    
    /// <signature>#16 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    static public native java.lang.String getUserName();
    
    /// <signature>#17 ()Lsystem/ICloneable; ()LSystem/ICloneable;</signature>
    static public native system.ICloneable getVersion();
    
    /// <signature>#18 ()J ()J</signature>
    static public native long getWorkingSet();
    
    /// <signature>#19 ()[Ljava/lang/String; ()[Ljava/lang/String;</signature>
    static public native java.lang.String[] GetCommandLineArgs();
    
    /// <signature>#20 (Ljava/lang/String;)Ljava/lang/String; (Ljava/lang/String;)Ljava/lang/String;</signature>
    static public native java.lang.String GetEnvironmentVariable(java.lang.String variable);
    
    /// <signature>#21 (Ljava/lang/String;Lsystem/Enum;)Ljava/lang/String; (Ljava/lang/String;LSystem/Enum;)Ljava/lang/String;</signature>
    static public native java.lang.String GetEnvironmentVariable(java.lang.String variable, system.Enum target);
    
    /// <signature>#22 ()Lsystem/collections/IDictionary; ()LSystem/Collections/IDictionary;</signature>
    static public native system.collections.IDictionary GetEnvironmentVariables();
    
    /// <signature>#23 (Lsystem/Enum;)Lsystem/collections/IDictionary; (LSystem/Enum;)LSystem/Collections/IDictionary;</signature>
    static public native system.collections.IDictionary GetEnvironmentVariables(system.Enum target);
    
    /// <signature>#24 (Lsystem/Environment$SpecialFolder;)Ljava/lang/String; (LSystem/Environment+SpecialFolder;)Ljava/lang/String;</signature>
    static public native java.lang.String GetFolderPath(system.Environment.SpecialFolder folder);
    
    /// <signature>#25 ()[Ljava/lang/String; ()[Ljava/lang/String;</signature>
    static public native java.lang.String[] GetLogicalDrives();
    
    /// <signature>#26 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    static public native void setCurrentDirectory(java.lang.String value);
    
    /// <signature>#27 (I)V (I)V</signature>
    static public native void setExitCode(int value);
    
    /// <signature>#28 (Ljava/lang/String;Ljava/lang/String;)V (Ljava/lang/String;Ljava/lang/String;)V</signature>
    static public native void SetEnvironmentVariable(java.lang.String variable, java.lang.String value);
    
    /// <signature>#29 (Ljava/lang/String;Ljava/lang/String;Lsystem/Enum;)V (Ljava/lang/String;Ljava/lang/String;LSystem/Enum;)V</signature>
    static public native void SetEnvironmentVariable(java.lang.String variable, java.lang.String value, system.Enum target);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Environment_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.Environment.class, system.Environment.class, system.Environment.class, new system.Environment.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
    
    @net.sf.jni4net.attributes.J4NProxy(system.Environment.SpecialFolder.class)
    @SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
    static public final class SpecialFolder extends system.Enum
    // <j4ni-SpecialFolder>
    // put user interfaces here
    // </j4ni-SpecialFolder>
    {
        // <j4nb-SpecialFolder> 
        // put user members here
        // </j4nb-SpecialFolder>
        
        private SpecialFolder(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
            super(j4n_handle, j4n_instanceInfo);
        }
        
        static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
            
            public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
                return new system.Environment.SpecialFolder(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
            }
        }
        
        static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static system.IType j4n_Type;
        
        static public system.IType typeOf() {
            return j4n_Type;
        }
        
        static  {
            system.Environment.SpecialFolder.j4n_ProxyInit(null);
        }
        
        /// <signature>#0 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder ApplicationData();
        
        /// <signature>#1 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder CommonApplicationData();
        
        /// <signature>#2 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder CommonProgramFiles();
        
        /// <signature>#3 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder Cookies();
        
        /// <signature>#4 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder Desktop();
        
        /// <signature>#5 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder DesktopDirectory();
        
        /// <signature>#6 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder Favorites();
        
        /// <signature>#7 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder History();
        
        /// <signature>#8 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder InternetCache();
        
        /// <signature>#9 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder LocalApplicationData();
        
        /// <signature>#10 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder MyComputer();
        
        /// <signature>#11 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder MyDocuments();
        
        /// <signature>#12 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder MyMusic();
        
        /// <signature>#13 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder MyPictures();
        
        /// <signature>#14 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder Personal();
        
        /// <signature>#15 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder ProgramFiles();
        
        /// <signature>#16 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder Programs();
        
        /// <signature>#17 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder Recent();
        
        /// <signature>#18 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder SendTo();
        
        /// <signature>#19 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder StartMenu();
        
        /// <signature>#20 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder Startup();
        
        /// <signature>#21 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder System();
        
        /// <signature>#22 ()Lsystem/Environment$SpecialFolder; ()LSystem/Environment+SpecialFolder;</signature>
        static public native system.Environment.SpecialFolder Templates();
        
        static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
            if (j4n_TypeInfo==null)
            {
                j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.Environment_+SpecialFolder_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.Environment.SpecialFolder.class, system.Environment.SpecialFolder.class, system.Environment.SpecialFolder.class, new system.Environment.SpecialFolder.j4n_ProxyFactory());
            }
            return j4n_TypeInfo;
        }
    }
}
