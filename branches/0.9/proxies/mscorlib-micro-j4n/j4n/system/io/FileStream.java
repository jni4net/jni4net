// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.io;

@net.sf.jni4net.attributes.J4NProxy(system.io.FileStream.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class FileStream extends system.io.Stream
// <j4ni-FileStream>
// put user interfaces here
// </j4ni-FileStream>
{
    // <j4nb-FileStream> 
    // put user members here
    // </j4nb-FileStream>
    
    protected FileStream(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.io.FileStream(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.io.FileStream.j4n_ProxyInit(null);
    }
    
    public FileStream(system.IDisposable handle, system.Enum access) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(handle, access);
    }
    
    /// <signature>#0 (Lsystem/IDisposable;Lsystem/Enum;)V (LSystem/IDisposable;LSystem/Enum;)V</signature>
    private native long j4n_constructor(system.IDisposable handle, system.Enum access);
    
    public FileStream(system.IDisposable handle, system.Enum access, int bufferSize) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(handle, access, bufferSize);
    }
    
    /// <signature>#1 (Lsystem/IDisposable;Lsystem/Enum;I)V (LSystem/IDisposable;LSystem/Enum;I)V</signature>
    private native long j4n_constructor(system.IDisposable handle, system.Enum access, int bufferSize);
    
    public FileStream(system.IDisposable handle, system.Enum access, int bufferSize, boolean isAsync) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(handle, access, bufferSize, isAsync);
    }
    
    /// <signature>#2 (Lsystem/IDisposable;Lsystem/Enum;IZ)V (LSystem/IDisposable;LSystem/Enum;IZ)V</signature>
    private native long j4n_constructor(system.IDisposable handle, system.Enum access, int bufferSize, boolean isAsync);
    
    public FileStream(java.lang.String path, system.Enum mode) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(path, mode);
    }
    
    /// <signature>#3 (Ljava/lang/String;Lsystem/Enum;)V (Ljava/lang/String;LSystem/Enum;)V</signature>
    private native long j4n_constructor(java.lang.String path, system.Enum mode);
    
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(path, mode, access);
    }
    
    /// <signature>#4 (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;)V (Ljava/lang/String;LSystem/Enum;LSystem/Enum;)V</signature>
    private native long j4n_constructor(java.lang.String path, system.Enum mode, system.Enum access);
    
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(path, mode, access, share);
    }
    
    /// <signature>#5 (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;)V (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;)V</signature>
    private native long j4n_constructor(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share);
    
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(path, mode, access, share, bufferSize);
    }
    
    /// <signature>#6 (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;I)V (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;I)V</signature>
    private native long j4n_constructor(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize);
    
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize, boolean useAsync) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(path, mode, access, share, bufferSize, useAsync);
    }
    
    /// <signature>#7 (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;IZ)V (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;IZ)V</signature>
    private native long j4n_constructor(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize, boolean useAsync);
    
    public FileStream(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize, system.Enum options) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(path, mode, access, share, bufferSize, options);
    }
    
    /// <signature>#8 (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;)V (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;ILSystem/Enum;)V</signature>
    private native long j4n_constructor(java.lang.String path, system.Enum mode, system.Enum access, system.Enum share, int bufferSize, system.Enum options);
    
    public FileStream(java.lang.String path, system.Enum mode, system.Enum rights, system.Enum share, int bufferSize, system.Enum options, system.Object fileSecurity) {
        super(0, (net.sf.jni4net.core.ClrInstanceInfo)null);
        j4n_clrHandle = j4n_constructor(path, mode, rights, share, bufferSize, options, fileSecurity);
    }
    
    /// <signature>#10 (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;Lsystem/Object;)V (Ljava/lang/String;LSystem/Enum;LSystem/Enum;LSystem/Enum;ILSystem/Enum;Lsystem/Object;)V</signature>
    private native long j4n_constructor(java.lang.String path, system.Enum mode, system.Enum rights, system.Enum share, int bufferSize, system.Enum options, system.Object fileSecurity);
    
    /// <signature>#11 ()Lsystem/IntPtr; ()LSystem/IntPtr;</signature>
    public native system.IntPtr getHandle();
    
    /// <signature>#12 ()Z ()Z</signature>
    public native boolean getIsAsync();
    
    /// <signature>#13 ()Ljava/lang/String; ()Ljava/lang/String;</signature>
    public final native java.lang.String getName();
    
    /// <signature>#14 ()Lsystem/IDisposable; ()LSystem/IDisposable;</signature>
    public native system.IDisposable getSafeFileHandle();
    
    /// <signature>#15 ()Lsystem/Object; ()Lsystem/Object;</signature>
    public final native system.Object GetAccessControl();
    
    /// <signature>#16 (JJ)V (JJ)V</signature>
    public native void Lock(long position, long length);
    
    /// <signature>#17 (Lsystem/Object;)V (Lsystem/Object;)V</signature>
    public final native void SetAccessControl(system.Object fileSecurity);
    
    /// <signature>#18 (JJ)V (JJ)V</signature>
    public native void Unlock(long position, long length);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IO.FileStream_, " + net.sf.jni4net.modules.mscorlibmicroj4n.assemblyName, system.io.FileStream.class, system.io.FileStream.class, system.io.FileStream.class, new system.io.FileStream.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
