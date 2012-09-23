// This code was generated using jni4net. See http://jni4net.sourceforge.net/

package system.io;

@net.sf.jni4net.attributes.J4NProxy(system.io.Stream.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class Stream extends system.MarshalByRefObject implements system.IDisposable
// <j4ni-Stream>
// put user interfaces here
// </j4ni-Stream>
{
    // <j4nb-Stream> 
    // put user members here
    // </j4nb-Stream>
    
    protected Stream(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new system.io.Stream(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static  {
        system.io.Stream.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()Lsystem/io/Stream; ()LSystem/IO/Stream;</signature>
    static public native system.io.Stream Null();
    
    /// <signature>#1 (Lsystem/io/Stream;)Lsystem/io/Stream; (LSystem/IO/Stream;)LSystem/IO/Stream;</signature>
    static public native system.io.Stream Synchronized(system.io.Stream stream);
    
    /// <signature>#2 ([BIILsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult; ([BIILSystem/AsyncCallback;Ljava/lang/Object;)LSystem/IAsyncResult;</signature>
    public native system.IAsyncResult BeginRead(byte[] buffer, int offset, int count, system.AsyncCallback callback, java.lang.Object state);
    
    /// <signature>#3 ([BIILsystem/AsyncCallback;Ljava/lang/Object;)Lsystem/IAsyncResult; ([BIILSystem/AsyncCallback;Ljava/lang/Object;)LSystem/IAsyncResult;</signature>
    public native system.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, system.AsyncCallback callback, java.lang.Object state);
    
    /// <signature>#4 ()V ()V</signature>
    public native void Close();
    
    /// <signature>#5 ()V ()V</signature>
    public native void Dispose();
    
    /// <signature>#6 (Lsystem/IAsyncResult;)I (LSystem/IAsyncResult;)I</signature>
    public native int EndRead(system.IAsyncResult asyncResult);
    
    /// <signature>#7 (Lsystem/IAsyncResult;)V (LSystem/IAsyncResult;)V</signature>
    public native void EndWrite(system.IAsyncResult asyncResult);
    
    /// <signature>#8 ()V ()V</signature>
    public native void Flush();
    
    /// <signature>#9 ()Z ()Z</signature>
    public native boolean getCanRead();
    
    /// <signature>#10 ()Z ()Z</signature>
    public native boolean getCanSeek();
    
    /// <signature>#11 ()Z ()Z</signature>
    public native boolean getCanTimeout();
    
    /// <signature>#12 ()Z ()Z</signature>
    public native boolean getCanWrite();
    
    /// <signature>#13 ()J ()J</signature>
    public native long getLength();
    
    /// <signature>#14 ()J ()J</signature>
    public native long getPosition();
    
    /// <signature>#15 ()I ()I</signature>
    public native int getReadTimeout();
    
    /// <signature>#16 ()I ()I</signature>
    public native int getWriteTimeout();
    
    /// <signature>#17 ([BII)I ([BII)I</signature>
    public native int Read(byte[] buffer, int offset, int count);
    
    /// <signature>#18 ()I ()I</signature>
    public native int ReadByte();
    
    /// <signature>#19 (JLsystem/Enum;)J (JLSystem/Enum;)J</signature>
    public native long Seek(long offset, system.Enum origin);
    
    /// <signature>#20 (J)V (J)V</signature>
    public native void setPosition(long value);
    
    /// <signature>#21 (I)V (I)V</signature>
    public native void setReadTimeout(int value);
    
    /// <signature>#22 (I)V (I)V</signature>
    public native void setWriteTimeout(int value);
    
    /// <signature>#23 (J)V (J)V</signature>
    public native void SetLength(long value);
    
    /// <signature>#24 ([BII)V ([BII)V</signature>
    public native void Write(byte[] buffer, int offset, int count);
    
    /// <signature>#25 (B)V (B)V</signature>
    public native void WriteByte(byte value);
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "System.IO.Stream_, " + net.sf.jni4net.modules.mscorlibmicroj4n.proxyAssemblyName, system.io.Stream.class, system.io.Stream.class, system.io.Stream.class, new system.io.Stream.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}
