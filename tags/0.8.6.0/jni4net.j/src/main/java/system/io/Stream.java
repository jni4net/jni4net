// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.io;

@net.sf.jni4net.attributes.ClrType
public class Stream extends system.MarshalByRefObject implements system.IDisposable {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected Stream(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected Stream() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Dispose();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getCanRead();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getCanSeek();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getCanTimeout();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getCanWrite();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native long getLength();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native long getPosition();
    
    @net.sf.jni4net.attributes.ClrMethod("(J)V")
    public native void setPosition(long value);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getReadTimeout();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native void setReadTimeout(int value);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getWriteTimeout();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native void setWriteTimeout(int value);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Close();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Flush();
    
    @net.sf.jni4net.attributes.ClrMethod("([BIILSystem/AsyncCallback;LSystem/Object;)LSystem/IAsyncResult;")
    public native system.IAsyncResult BeginRead(byte[] buffer, int offset, int count, system.AsyncCallback callback, system.Object state);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IAsyncResult;)I")
    public native int EndRead(system.IAsyncResult asyncResult);
    
    @net.sf.jni4net.attributes.ClrMethod("([BIILSystem/AsyncCallback;LSystem/Object;)LSystem/IAsyncResult;")
    public native system.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, system.AsyncCallback callback, system.Object state);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IAsyncResult;)V")
    public native void EndWrite(system.IAsyncResult asyncResult);
    
    @net.sf.jni4net.attributes.ClrMethod("(JLSystem/IO/SeekOrigin;)J")
    public native long Seek(long offset, system.Enum origin);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)V")
    public native void SetLength(long value);
    
    @net.sf.jni4net.attributes.ClrMethod("([BII)I")
    public native int Read(byte[] buffer, int offset, int count);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int ReadByte();
    
    @net.sf.jni4net.attributes.ClrMethod("([BII)V")
    public native void Write(byte[] buffer, int offset, int count);
    
    @net.sf.jni4net.attributes.ClrMethod("(B)V")
    public native void WriteByte(byte value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IO/Stream;)LSystem/IO/Stream;")
    public native static system.io.Stream Synchronized(system.io.Stream stream);
    
    public static system.Type typeof() {
        return system.io.Stream.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.io.Stream.staticType = staticType;
    }
    //</generated-proxy>
}
