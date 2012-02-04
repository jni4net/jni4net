package java_.io;

@net.sf.jni4net.attributes.J4NProxy(java_.io.ObjectOutput_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class ObjectOutput_
// <j4ni-ObjectOutput_>
// put user interfaces here
// </j4ni-ObjectOutput_>
{
    // <j4nb-ObjectOutput_> 
    // put user members here
    // </j4nb-ObjectOutput_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.io._ObjectOutput(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.io.ObjectOutput_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.io.ObjectOutput_, " + net.sf.jni4net.modules.jremicroj4n.assemblyName, java.io.ObjectOutput.class, java_.io.ObjectOutput_.class, java_.io._ObjectOutput.class, new java_.io.ObjectOutput_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.io.ObjectOutput_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _ObjectOutput extends system.Object implements java.io.ObjectOutput
// <j4ni-ObjectOutput>
// put user interfaces here
// </j4ni-ObjectOutput>
{
    // <j4nb-ObjectOutput> 
    // put user members here
    // </j4nb-ObjectOutput>
    
    _ObjectOutput(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.io.ObjectOutput_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ()V ()V</signature>
    public native void close();
    
    /// <signature>#1 ()V ()V</signature>
    public native void flush();
    
    /// <signature>#2 ([B)V ([B)V</signature>
    public native void write(byte[] par0);
    
    /// <signature>#3 ([BII)V ([BII)V</signature>
    public native void write(byte[] par0, int par1, int par2);
    
    /// <signature>#4 (I)V (I)V</signature>
    public native void write(int par0);
    
    /// <signature>#5 (Z)V (Z)V</signature>
    public native void writeBoolean(boolean par0);
    
    /// <signature>#6 (I)V (I)V</signature>
    public native void writeByte(int par0);
    
    /// <signature>#7 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void writeBytes(java.lang.String par0);
    
    /// <signature>#8 (I)V (I)V</signature>
    public native void writeChar(int par0);
    
    /// <signature>#9 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void writeChars(java.lang.String par0);
    
    /// <signature>#10 (D)V (D)V</signature>
    public native void writeDouble(double par0);
    
    /// <signature>#11 (F)V (F)V</signature>
    public native void writeFloat(float par0);
    
    /// <signature>#12 (I)V (I)V</signature>
    public native void writeInt(int par0);
    
    /// <signature>#13 (J)V (J)V</signature>
    public native void writeLong(long par0);
    
    /// <signature>#14 (Ljava/lang/Object;)V (Ljava/lang/Object;)V</signature>
    public native void writeObject(java.lang.Object par0);
    
    /// <signature>#15 (I)V (I)V</signature>
    public native void writeShort(int par0);
    
    /// <signature>#16 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void writeUTF(java.lang.String par0);
}
