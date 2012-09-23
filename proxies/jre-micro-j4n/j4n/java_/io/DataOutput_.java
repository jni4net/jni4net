package java_.io;

@net.sf.jni4net.attributes.J4NProxy(java_.io.DataOutput_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
public class DataOutput_
// <j4ni-DataOutput_>
// put user interfaces here
// </j4ni-DataOutput_>
{
    // <j4nb-DataOutput_> 
    // put user members here
    // </j4nb-DataOutput_>
    
    static net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
    
    static system.IType j4n_Type;
    
    static public system.IType typeOf() {
        return j4n_Type;
    }
    
    static private class j4n_ProxyFactory implements net.sf.jni4net.core.IClrProxyFactory{
        
        public net.sf.jni4net.IClrProxy CreateInstance(long j4n_handle) {
            return new java_.io._DataOutput(j4n_handle, (net.sf.jni4net.core.ClrInstanceInfo)null);
        }
    }
    
    static  {
        java_.io.DataOutput_.j4n_ProxyInit(null);
    }
    
    static protected synchronized net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(net.sf.jni4net.inj.INJEnv env) {
        if (j4n_TypeInfo==null)
        {
            j4n_TypeInfo = net.sf.jni4net.core.Registry.registerProxy(env, "java.io.DataOutput_, " + net.sf.jni4net.modules.jremicroj4n.proxyAssemblyName, java.io.DataOutput.class, java_.io.DataOutput_.class, java_.io._DataOutput.class, new java_.io.DataOutput_.j4n_ProxyFactory());
        }
        return j4n_TypeInfo;
    }
}

@net.sf.jni4net.attributes.J4NProxy(java_.io.DataOutput_.class)
@SuppressWarnings({"UnusedDeclaration", "NullableProblems", "RedundantCast", "deprecation", "unchecked"})
class _DataOutput extends system.Object implements java.io.DataOutput
// <j4ni-DataOutput>
// put user interfaces here
// </j4ni-DataOutput>
{
    // <j4nb-DataOutput> 
    // put user members here
    // </j4nb-DataOutput>
    
    _DataOutput(long j4n_handle, net.sf.jni4net.core.ClrInstanceInfo j4n_instanceInfo) {
        super(j4n_handle, j4n_instanceInfo);
    }
    
    static  {
        java_.io.DataOutput_.j4n_ProxyInit(null);
    }
    
    /// <signature>#0 ([B)V ([B)V</signature>
    public native void write(byte[] par0);
    
    /// <signature>#1 ([BII)V ([BII)V</signature>
    public native void write(byte[] par0, int par1, int par2);
    
    /// <signature>#2 (I)V (I)V</signature>
    public native void write(int par0);
    
    /// <signature>#3 (Z)V (Z)V</signature>
    public native void writeBoolean(boolean par0);
    
    /// <signature>#4 (I)V (I)V</signature>
    public native void writeByte(int par0);
    
    /// <signature>#5 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void writeBytes(java.lang.String par0);
    
    /// <signature>#6 (I)V (I)V</signature>
    public native void writeChar(int par0);
    
    /// <signature>#7 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void writeChars(java.lang.String par0);
    
    /// <signature>#8 (D)V (D)V</signature>
    public native void writeDouble(double par0);
    
    /// <signature>#9 (F)V (F)V</signature>
    public native void writeFloat(float par0);
    
    /// <signature>#10 (I)V (I)V</signature>
    public native void writeInt(int par0);
    
    /// <signature>#11 (J)V (J)V</signature>
    public native void writeLong(long par0);
    
    /// <signature>#12 (I)V (I)V</signature>
    public native void writeShort(int par0);
    
    /// <signature>#13 (Ljava/lang/String;)V (Ljava/lang/String;)V</signature>
    public native void writeUTF(java.lang.String par0);
}
